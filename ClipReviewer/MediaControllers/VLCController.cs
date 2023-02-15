using Microsoft.Win32;
using System.Diagnostics;
using System.Management;
using System.Net.Sockets;
using System.Text;

namespace ClipReviewer.MediaControllers
{
    // credits to https://gist.github.com/SamSaffron/101357
    // edited by me
    public class VLCController : MediaController
    {
        public VLCController(string? vlcPath = null)
        {
            if (vlcPath == null)
            {
                var vlcKey = Registry.LocalMachine.OpenSubKey(@"Software\VideoLan\VLC");
                if (vlcKey == null)
                    vlcKey = Registry.LocalMachine.OpenSubKey(@"Software\Wow6432Node\VideoLan\VLC");
                if (vlcKey != null)
                    vlcPath = vlcKey.GetValue(null) as string;
            }

            if (vlcPath == null || !File.Exists(vlcPath))
                throw new ApplicationException("Can not find the VLC executable!");

            var info = new ProcessStartInfo(vlcPath, "-I rc --rc-host=localhost:9876");
            controllerProcess = Process.Start(info);
            controllerTcpClient = new TcpClient("localhost", 9876);
        }

        #region Overrides
        public override Process? GetProcess()
        {
            var currentProcessId = Process.GetCurrentProcess().Id;
            Process? vlcProcess = null;
            foreach (var process in Process.GetProcessesByName("vlc"))
            {
                if (GetParentProcessId(process.Id) == currentProcessId)
                {
                    vlcProcess = process;
                    break;
                }
            }
            return vlcProcess;
        }

        public override bool IsPlaying
        {
            get
            {
                SendCommand(VlcCommand.Is_Playing);
                string result = WaitForResult().Trim();
                return result == "1";
            }
        }

        public override string WhatIsPlaying
        {
            get
            {
                SendCommand(VlcCommand.Info);
                return WaitForResult().Trim();
            }
        }

        public override int Position
        {
            get
            {
                SendCommand(VlcCommand.Get_Time);
                var result = WaitForResult().Trim();
                return Convert.ToInt32(result);
            }
            //set
            //{
            //    SendCommand(VlcCommand.Seek, value.ToString());
            //}
        }

        public override void Play()
        {
            SendCommand(VlcCommand.Play);
        }

        public override void Stop()
        {
            SendCommand(VlcCommand.Stop);
        }

        public override void Pause()
        {
            SendCommand(VlcCommand.Pause);
        }

        public override bool Add(string filename)
        {
            if (string.IsNullOrEmpty(filename) || !File.Exists(filename)) return false;
            SendCommand(VlcCommand.Add, filename);
            return true;
        }

        public override void Fullscreen(bool value)
        {
            SendCommand(VlcCommand.F, value ? "on" : "off");
        }

        public override bool Seek(int time)
        {
            if (time < 0) return false;
            SendCommand(VlcCommand.Seek, time.ToString());
            return true;
        }

        public override void Loop(bool value)
        {
            SendCommand(VlcCommand.Loop, value ? "on" : "off");
        }
        #endregion

        #region Help Methods
        // maximum 2 second wait on results. 
        const int WaitTimeout = 2000;

        static ASCIIEncoding ASCIIEncoding = new ASCIIEncoding();


        static int GetParentProcessId(int Id)
        {
            int parentPid = 0;
            using (ManagementObject mo = new ManagementObject($"win32_process.handle='{Id}'"))
            {
                mo.Get();
                parentPid = Convert.ToInt32(mo["ParentProcessId"]);
            }
            return parentPid;
        }

        private void SendCommand(VlcCommand command)
        {
            SendCommand(command, null);
        }

        private void SendCommand(VlcCommand command, string? param)
        {
            ReadTillEnd(); // flush old stuff

            string? packet = Enum.GetName(typeof(VlcCommand), command)?.ToLower();
            if (param != null)
                packet += " " + param;

            packet += Environment.NewLine;

            var buffer = ASCIIEncoding.GetBytes(packet);
            controllerTcpClient.GetStream().Write(buffer, 0, buffer.Length);
            controllerTcpClient.GetStream().Flush();

            Trace.Write(packet);
        }

        public string ReadTillEnd()
        {
            StringBuilder sb = new StringBuilder();
            while (controllerTcpClient.GetStream().DataAvailable)
            {
                int b = controllerTcpClient.GetStream().ReadByte();
                if (b >= 0)
                    sb.Append((char)b);
                else
                    break;
            }
            return sb.ToString();
        }

        private string WaitForResult()
        {
            string result = "";
            DateTime start = DateTime.Now;
            while ((DateTime.Now - start).TotalMilliseconds < WaitTimeout)
            {
                result = ReadTillEnd();
                if (!string.IsNullOrEmpty(result))
                    break;
            }
            return result;
        }
        #endregion

        enum VlcCommand
        {
            Add,           // add XYZ  . . . . . . . . . . . . add XYZ to playlist  
            Enqueue,       // enqueue XYZ  . . . . . . . . . queue XYZ to playlist
            Playlist,      // playlist . . . . .  show items currently in playlist
            Play,          // play . . . . . . . . . . . . . . . . . . play stream
            Stop,          // stop . . . . . . . . . . . . . . . . . . stop stream
            Next,          // next . . . . . . . . . . . . . .  next playlist item
            Prev,          // prev . . . . . . . . . . . .  previous playlist item
            Goto,          // goto . . . . . . . . . . . . . .  goto item at index
            Repeat,        // repeat [on|off] . . . .  toggle playlist item repeat
            Loop,          // loop [on|off] . . . . . . . . . toggle playlist loop
            Random,        // random [on|off] . . . . . . .  toggle random jumping
            Clear,         // clear . . . . . . . . . . . . . . clear the playlist
            Status,        // status . . . . . . . . . . . current playlist status
            Title,         // title [X]  . . . . . . set/get title in current item
            Title_n,       // title_n  . . . . . . . .  next title in current item
            Title_p,       // title_p  . . . . . .  previous title in current item
            Chapter,       // chapter [X]  . . . . set/get chapter in current item
            Chapter_n,     // chapter_n  . . . . . .  next chapter in current item
            Chapter_p,     // chapter_p  . . . .  previous chapter in current item
                           // 
            Seek,          // seek X . . . seek in seconds, for instance `seek 12'
            Pause,         // pause  . . . . . . . . . . . . . . . .  toggle pause
            FastForward,   // fastforward  . . . . . . . .  .  set to maximum rate
            Rewind,        // rewind  . . . . . . . . . . . .  set to minimum rate
            Faster,        // faster . . . . . . . . . .  faster playing of stream
            Slower,        // slower . . . . . . . . . .  slower playing of stream
            Normal,        // normal . . . . . . . . . .  normal playing of stream
            F,             // f [on|off] . . . . . . . . . . . . toggle fullscreen
            Info,          // info . . . . .  information about the current stream
            Stats,         // stats  . . . . . . . .  show statistical information
            Is_Playing,    // get_time . . seconds elapsed since stream's beginnin
            Get_Time,      // is_playing . . . .  1 if a stream plays, 0 otherwise
            Get_Title,     // get_title . . . . .  the title of the current stream
            Get_Length,    // get_length . . . .  the length of the current stream
                           // 
            Volume,        // volume [X] . . . . . . . . . .  set/get audio volume
            VolUp,         // volup [X]  . . . . . . .  raise audio volume X steps
            VolDown,       // voldown [X]  . . . . . .  lower audio volume X steps
            aDev,          // adev [X] . . . . . . . . . . .  set/get audio device
            aChan,         // achan [X]. . . . . . . . . .  set/get audio channels
            aTrack,        // atrack [X] . . . . . . . . . . . set/get audio track
            vTrack,        // vtrack [X] . . . . . . . . . . . set/get video track
            vRatio,        // vratio [X]  . . . . . . . set/get video aspect ratio
            vCrop,         // vcrop [X]  . . . . . . . . . . .  set/get video crop
            vZoom,         // vzoom [X]  . . . . . . . . . . .  set/get video zoom
            Snapshot,      // snapshot . . . . . . . . . . . . take video snapshot
            sTrack,        // strack [X] . . . . . . . . . set/get subtitles track
            Key,           // key [hotkey name] . . . . . .  simulate hotkey press
            Menu,          // menu . . [on|off|up|down|left|right|select] use menu
                           // 
            Help,          // help . . . . . . . . . . . . . . . this help message
            Longhelp,      // longhelp . . . . . . . . . . . a longer help message
            Logout,        // logout . . . . . . .  exit (if in socket connection)
            Quit,          // quit . . . . . . . . . . . . . . . . . . .  quit vlc
        }
    }
}
