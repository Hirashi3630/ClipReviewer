using ClipReviewer.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClipReviewer.Controls
{
    partial class compAbout : Form
    {
        public static readonly string GITHUB_URL = "https://github.com/Hirashi3630/ClipReviewer";

        public compAbout()
        {
            InitializeComponent();
            this.Text = string.Format("About {0}", AssemblyTitle);
            this.labelProductName.Text = AssemblyProduct;
            this.labelVersion.Text = string.Format("Version {0}", AssemblyVersion);
            this.labelURL.Text = GITHUB_URL;
            this.textBoxDescription.Text = AssemblyDescription;
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void labelURL_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            OpenURL(labelURL.Text);
        }

        #region Assembly Attribute Accessors

        public static void OpenURL(string url, string appendToUrl = "")
        {
            try
            {
                Process.Start("explorer",
                    string.IsNullOrEmpty(appendToUrl) ? url
                    : UrlCombine(url, appendToUrl));

            }
            catch (Exception ex)
            {
                MessageBox.Show("Unable to open URL in a browser!\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static string UrlCombine(string uri1, string uri2)
        {
            uri1 = uri1.TrimEnd('/');
            uri2 = uri2.TrimStart('/');
            return string.Format("{0}/{1}", uri1, uri2);
        }

        public static string? AssemblyTitle
        {
            get
            {
                // TODO: get human readable title
                return Assembly.GetExecutingAssembly().GetCustomAttribute<AssemblyTitleAttribute>()?.Title;
            }
        }

        public static string? AssemblyVersion
        {
            get
            {
                return FileVersionInfo.GetVersionInfo(Assembly.GetExecutingAssembly().Location).ProductVersion;

            }
        }

        public static string AssemblyDescription
        {
            get
            {
                object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyDescriptionAttribute), false);
                if (attributes.Length == 0)
                {
                    return "";
                }
                return ((AssemblyDescriptionAttribute)attributes[0]).Description;
            }
        }

        public static string AssemblyProduct
        {
            get
            {
                object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyProductAttribute), false);
                if (attributes.Length == 0)
                {
                    return "";
                }
                return ((AssemblyProductAttribute)attributes[0]).Product;
            }
        }

        public static string AssemblyCopyright
        {
            get
            {
                object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyCopyrightAttribute), false);
                if (attributes.Length == 0)
                {
                    return "";
                }
                return ((AssemblyCopyrightAttribute)attributes[0]).Copyright;
            }
        }

        public static string AssemblyCompany
        {
            get
            {
                object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyCompanyAttribute), false);
                if (attributes.Length == 0)
                {
                    return "";
                }
                return ((AssemblyCompanyAttribute)attributes[0]).Company;
            }
        }
        #endregion
    }
}
