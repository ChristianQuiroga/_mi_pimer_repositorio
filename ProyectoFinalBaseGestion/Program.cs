using ProyectoFinalBaseGestion;

namespace ProyectoFinalBaseGestion
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
            ApplicationConfiguration.Initialize();
            ///Application.Run(new Form1());
            Application.Run(new frmDgProductos());
            Application.Run(new frmDgUsuarios());
            Application.Run(new frmDgProductoVendido());
            Application.Run(new frmDgVenta());
        }
    }
}