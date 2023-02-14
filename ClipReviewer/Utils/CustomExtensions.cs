using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ClipReviewer.Utils
{
    public static class CustomExtensions
    {
        // inefficient https://stackoverflow.com/a/3527717/10806542
        public static IEnumerable<FileInfo> GetFilesByExtensions(this DirectoryInfo dir, params string[] extensions)
        {
            if (extensions == null)
                throw new ArgumentNullException("extensions");
            IEnumerable<FileInfo> files = dir.EnumerateFiles();
            return files.Where(f => extensions.Contains(f.Extension));
        }

        public static int ParseCustomTime(this string time, int currentTime)
        {
            if (!Regex.IsMatch(time, @"^\d+(\.\d+)?%?$"))
                throw new ArgumentException($"Time isn't valid! time: \"{time}\"");
            if (time[time.Length - 1] == '%')
            {
                float parsedTime = int.Parse(time.Remove(time.Length - 1));
                return (int)((parsedTime / 100) * currentTime);
            }
            else return int.Parse(time);
        }

        public static bool IsRunning(this Process process)
        {
            if (process == null)
                return false;

            try
            {
                Process.GetProcessById(process.Id);
            }
            catch (ArgumentException)
            {
                return false;
            }
            return true;
        }
    }
}
