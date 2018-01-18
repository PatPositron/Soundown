using System;
using System.Windows.Forms;
using Soundown.Forms;

namespace Soundown
{
    internal static class Program
    {
        public const string DefaultDownloadLocation = "Soundown Tracks";
        public const string DefaultAlbum = "Soundown";
        public const string ClientId = "07ed3fa5abbd2525c9d5c7c2cba7aa30";

        public static string DownloadLocation { get; set; }

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        private static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }
    }
}
