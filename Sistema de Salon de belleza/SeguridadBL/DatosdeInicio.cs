using BL.Rentas;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static BL.Rentas.CitasBL;
using static BL.Rentas.SeguridadBl;

namespace BL.Rentas
{
    class DatosdeInicio: CreateDatabaseIfNotExists <Contexto>

    {
        protected override void Seed(Contexto contexto) 
        {
            var tipo1 = new Tipo();
            tipo1.Id = 002;
            tipo1.Descripcion = "Planchado";
            contexto.Tipos.Add(tipo1);

            var tipo2 = new Tipo();
            tipo2.Id = 001;
            tipo2.Descripcion = "Champu";
            contexto.Tipos.Add(tipo2);

            var usuarioAdmin1 = new UsuariosDB();
            usuarioAdmin1.Nombre = "gladys";
            usuarioAdmin1.Contrasena = "gladys15";
            usuarioAdmin1.Foto = null;
            usuarioAdmin1.TipoUsuario = "Admin";
            contexto.Usuarios.Add(usuarioAdmin1);

            var usuarioAdmin2 = new UsuariosDB();
            usuarioAdmin2.Nombre = "henry";
            usuarioAdmin2.Contrasena = "henry15";
            usuarioAdmin1.Foto = null;
            usuarioAdmin2.TipoUsuario = "Caja";
            contexto.Usuarios.Add(usuarioAdmin2);

            
            var categoria1 = new Categoria();
            categoria1.Id = 002;
            categoria1.Descripcion = "Producto";
            contexto.Categorias.Add(categoria1);

            var categoria2 = new Categoria();
            categoria2.Id = 001;
            categoria2.Descripcion = "Servicio";
            contexto.Categorias.Add(categoria2);

            var cliente1 = new Cliente();
            cliente1.Id = 001;
            cliente1.Nombre = "Gladys";
            cliente1.Apellido = "Sosa";
            cliente1.Correo = "gladyssosa22@gmail.com";
            cliente1.Direccion = "Bendeck";
            cliente1.Telefono = "99080006";
            cliente1.activo = true;
            contexto.Cliente.Add(cliente1);

            var cliente2 = new Cliente();
            cliente2.Id = 002;
            cliente2.Nombre = "Mary";
            cliente2.Apellido = "Sosa";
            cliente2.Correo = "maryssosa22@gmail.com";
            cliente2.Direccion = "Bendeck";
            cliente2.Telefono = "97992919";
            cliente2.activo = true;
            contexto.Cliente.Add(cliente2);

            var cita1 = new Citas() ;
            cita1.Id = 001;
            cita1.Cliente = "Doris"; 
            cita1.Empleado = "Gladys";
            cita1.Estatus = "En proceso";
            cita1.Fecha_Cita = "2-2-2020";
            cita1.Hora = "12:00 PM";
            cita1.Servicio = "Planchado";
            contexto.Citas.Add(cita1);

            var cita2 = new Citas();
            cita2.Id = 002;
            cita2.Cliente = "Jefrey";
            cita2.Empleado = "Gladys";
            cita2.Estatus = "En proceso";
            cita2.Fecha_Cita = "2-4-2020";
            cita2.Hora = "11:00 PAM";
            cita2.Servicio = "Corte de Pelo";
            contexto.Citas.Add(cita2);
            

            var proveedores1 = new Proveedores();
            proveedores1.Id = 001;
            proveedores1.Activo = true;
            proveedores1.Ciudad  = "El Progreso";
            proveedores1.NombreCompania = "Huda Beaty";
            proveedores1.NombreContacto = "Jose Mejia";
            proveedores1.Pais = "Honduras";
            proveedores1.Telefono = "99080006";
            contexto.Proveedores.Add(proveedores1);

            var proveedores2 = new Proveedores();
            proveedores2.Id = 002;
            proveedores2.Activo = true;
            proveedores2.Ciudad = "Texas";
            proveedores2.NombreCompania = "Araia";
            proveedores2.NombreContacto = "Jose Funez";
            proveedores2.Pais = "Estados Unidos";
            proveedores2.Telefono = "97990007";
            contexto.Proveedores.Add(proveedores2);

            var producto1 = new Producto();
            producto1.Id = 001;
            producto1.Activo = true;
            producto1.Descripcion = "Champoo Keratine";
            producto1.Existencia = 002;
            producto1.Foto = null;
            producto1.Marca = "KeratineSb";
            producto1.Precio = 560;
            producto1.TipoId = 001;
            producto1.CategoriaId = 001;
            contexto.Productos.Add(producto1);

            var producto2 = new Producto();
            producto2.Id = 002;
            producto2.Activo = false;
            producto2.Descripcion = "Planchado";
            producto2.Existencia = 002;
            producto2.Foto = null;
            producto2.Marca = "Ninguna";
            producto2.Precio = 560;
            producto2.TipoId = 002;
            producto2.CategoriaId = 001;
            contexto.Productos.Add(producto2);

            var Empleado1 = new EmpleadosBL.Empleados();
            Empleado1.Id = 001;
            Empleado1.Nombre = "Gladys";
            Empleado1.Apellido = "Sosa";
            Empleado1.Correo = "Gladyssosa22@gmail.com";
            Empleado1.Direccion = "Bendeck";
            Empleado1.Fecha_de_Ingreso = "2-2-2020";
            Empleado1.Telefono = 99080006;
            Empleado1.Activo = true;
            contexto.Empleados.Add(Empleado1);

        }
    }
}
