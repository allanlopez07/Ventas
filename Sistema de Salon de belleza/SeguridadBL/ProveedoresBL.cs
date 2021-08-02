using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.Rentas
{
    public class ProveedoresBL
    {
        Contexto _contexto;
        public BindingList<Proveedores> ListaProveedores { get; set; }

        public ProveedoresBL()
        {
            _contexto = new Contexto();
            ListaProveedores = new BindingList<Proveedores>();

        }
        public BindingList<Proveedores> ObtenerProveedores()
        {
            _contexto.Proveedores.Load();
            ListaProveedores = _contexto.Proveedores.Local.ToBindingList();

            return ListaProveedores;
        }

        public void CancelarCambios()
        {
            foreach (var item in _contexto.ChangeTracker.Entries())
            {
                item.State = EntityState.Unchanged;
                item.Reload();
            }
        }

        public Resultado GuardarProveedores(Proveedores proveedores)
        {
            var resultado = Validar(proveedores);
            if (resultado.Exitoso == false)
            {
                return resultado;
            }

            _contexto.SaveChanges();

            resultado.Exitoso = true;
            return resultado;
        }

        public void AgregarProveedores()
        {
            var nuevoProveedor = new Proveedores();
            ListaProveedores.Add(nuevoProveedor);
        }

        public bool EliminarProveedores(int Id)
        {
            foreach (var proveedores in ListaProveedores)
            {
                if (proveedores.Id == Id)
                {
                    ListaProveedores.Remove(proveedores);
                    _contexto.SaveChanges();
                    return true;
                }
            }
            return false;
        }

        private Resultado Validar(Proveedores proveedores)
        {
            var resultado = new Resultado();
            resultado.Exitoso = true;



            if (string.IsNullOrEmpty(proveedores.NombreContacto) == true)
            {
                resultado.Mensaje = "Ingrese el nombre del contacto";
                resultado.Exitoso = false;
            }

            if (string.IsNullOrEmpty(proveedores.NombreCompania) == true)
            {
                resultado.Mensaje = "Ingrese el nombre de la compañia";
                resultado.Exitoso = false;
            }
            return resultado;
        }
    }
    public class Proveedores
    {
        public int Id { get; set; }
        public string NombreCompania { get; set; }
        public string NombreContacto { get; set; }
        public string Ciudad { get; set; }
        public string Telefono { get; set; }
        public string Pais { get; set; }
        public bool Activo { get; set; }
    }


}
