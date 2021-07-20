using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static BL.Rentas.CitasBL;

namespace BL.Rentas
{
    public class ClientesBL
    {
         Contexto _contexto;
        public BindingList<Cliente> ListaClientes { get; set; }

        public ClientesBL()
        {
            _contexto = new Contexto();
            ListaClientes = new BindingList<Cliente>();


        }
        public BindingList<Cliente> ObtenerClientes()
        {
            _contexto.Cliente.Load();
            ListaClientes = _contexto.Cliente.Local.ToBindingList();


            return ListaClientes;
        }

        public Resultado GuardarCliente(Cliente cliente)
        {
            var resultado = Validar(cliente);
            if (resultado.Exitoso == false)
            {
                return resultado;
            }

            _contexto.SaveChanges();
            resultado.Exitoso = true;
            return resultado;
        }

        public void AgregarClientes()
        {
            var nuevoCliente = new Cliente();
            ListaClientes.Add(nuevoCliente);
        }

        public bool EliminarClientes(int Id)
        {
            foreach (var clientes in ListaClientes)
            {
                if (clientes.Id == Id)
                {
                    ListaClientes.Remove(clientes);
                    _contexto.SaveChanges();
                    return true;
                }
            }
            return false;
        }
    /*    public static implicit operator ClientesBL(Cliente v)
        {
            throw new NotImplementedException();
        }*/

            public void CancelarCambios()
        {
            foreach (var item in _contexto.ChangeTracker.Entries())
            {
                item.State = EntityState.Unchanged;
                item.Reload();
            }
        }
        private Resultado Validar(Cliente cliente)
        {
            var resultado = new Resultado();
            resultado.Exitoso = true;



            if (string.IsNullOrEmpty(cliente.Apellido) == true)
            {
                resultado.Mensaje = "ingrese un apellido";
                resultado.Exitoso = false;

            }

            if (string.IsNullOrEmpty(cliente.Nombre) == true)
            {
                resultado.Mensaje = "Ingrese un nombre";
                resultado.Exitoso = false;
            }

            return resultado;
        }
    }
    public class Cliente
    {
        public int Id { get; set; } 
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Direccion { get; set; }
        public string Telefono { get; set; }
        public string Correo { get; set; }
        public bool activo { get; set; }
 //       public int ClienteId { get; set; }
        
    }



}