using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.Rentas
{
    public class ClientesBL
    {
        public BindingList<Cliente> ListaClientes { get; set; }

        public ClientesBL()
        {
            ListaClientes = new BindingList<Cliente>();

            var Cliente1 = new Cliente();
            Cliente1.IdCliente = 001;
            Cliente1.Nombre = "Maria";
            Cliente1.Apellido = "Perez";
            Cliente1.Direccion = "Col.Penjamo";
            Cliente1.Telefono = "97776757";
            Cliente1.Correo = "MariaPerez67@gmail.com";
            Cliente1.activo = true;

            ListaClientes.Add(Cliente1);

            var Cliente2 = new Cliente();
            Cliente2.IdCliente = 002;
            Cliente2.Nombre = "Rosio";
            Cliente2.Apellido = "Mejia";
            Cliente2.Direccion = "Col.La Nutria";
            Cliente2.Telefono = "97276753";
            Cliente2.Correo = "RosioMejia67@gmail.com";
            Cliente2.activo = true;

            ListaClientes.Add(Cliente2);

            var Cliente3 = new Cliente();
            Cliente3.IdCliente = 003;
            Cliente3.Nombre = "Sonia";
            Cliente3.Apellido = "Cruz";
            Cliente3.Direccion = "Col.3 deJunio";
            Cliente3.Telefono = "88903456";
            Cliente3.Correo = "SoniaCruz1@gmail.com";
            Cliente3.activo = false;

            ListaClientes.Add(Cliente3);
        }
        public BindingList<Cliente> ObtenerClientes()
        {
            return ListaClientes;
        }

        public static implicit operator ClientesBL(ProductosBL v)
        {
            throw new NotImplementedException();
        }
    }
    public class Cliente
    {
        public int IdCliente { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Direccion { get; set; }
        public string Telefono { get; set; }
        public string Correo { get; set; }
        public bool activo { get; set; }
    }
}
