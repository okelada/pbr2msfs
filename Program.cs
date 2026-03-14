using ImageMagick;

namespace pbr2msfs
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            MagickNET.Initialize();
            ApplicationConfiguration.Initialize();
            Application.Run(new MainForm());
        }
    }
}