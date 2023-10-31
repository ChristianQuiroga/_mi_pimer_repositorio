namespace SistemaGestionUI
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
            Application.Run(new frmMenu());
            Application.Run(new frmDgUsuarios());
            Application.Run(new frmDgProductos());
            Application.Run(new frmDgVenta());
            Application.Run(new frmDgProductoVendido());
        }
    }
}