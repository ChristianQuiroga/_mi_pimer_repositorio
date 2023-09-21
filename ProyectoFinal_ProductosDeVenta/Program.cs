using ProyectoFinal_ProductosDeVenta;
Console.WriteLine("Hello, World!");



Usuario usuario1 = new Usuario(1, "Miguel", "Rodriguez", "MRodriguez", "123zyz", "gmail");
Console.WriteLine("id: " + usuario1.Id +
                    "\nnombre: " + usuario1.Nombre +
                    "\nApellido: " + usuario1.Apellido +
                    "\nNomUsuario: " + usuario1.NombreUsuario +
                    "\nContraseña: " + usuario1.Contrasena +
                    "\ne-mail: " + usuario1.Mail);


Usuario usuario2 = new Usuario();
Console.WriteLine("id: " + usuario2.Id +
                    "\nnombre: " + usuario2.Nombre +
                    "\nApellido: " + usuario2.Apellido +
                    "\nNomUsuario: " + usuario2.NombreUsuario +
                    "\nContraseña: " + usuario2.Contrasena +
                    "\ne-mail: " + usuario2.Mail);

