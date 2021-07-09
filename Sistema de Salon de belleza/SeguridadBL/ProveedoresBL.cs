using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.Rentas
{
    public class ProveedoresBL
    {
        public BindingList<Proveedores> ListaProveedores { get; set; }

        public ProveedoresBL()
        {
            ListaProveedores = new BindingList<Proveedores>();

            var Proveedor1 = new Proveedores();
            Proveedor1.IdProveedor = 001;
            Proveedor1.NombreCompania = "Reminton";
            Proveedor1.NombreContacto = "Juan Perez";
            Proveedor1.Ciudad = "Austin";
            Proveedor1.Telefono = "(212) 324-4152";
            Proveedor1.Pais = "Estados Unidos";
            Proveedor1.Activo = true;

            ListaProveedores.Add(Proveedor1);

            var Proveedor2 = new Proveedores();
            Proveedor2.IdProveedor = 002;
            Proveedor2.NombreCompania = "Huda Beauty";
            Proveedor2.NombreContacto = "Sarai Carcamo";
            Proveedor2.Ciudad = " Dubai, AE ";
            Proveedor2.Telefono = "(212) 724-4134";
            Proveedor2.Pais = "Emiratos Arabes Unidos";
            Proveedor2.Activo = true;

            ListaProveedores.Add(Proveedor2);

            var Proveedor3 = new Proveedores();
            Proveedor3.IdProveedor = 003;
            Proveedor3.NombreCompania = "BeautyCreation";
            Proveedor3.NombreContacto = "Sarai Carcamo";
            Proveedor3.Ciudad = " Cuidad de Mexico ";
            Proveedor3.Telefono = "(212) 724-4134";
            Proveedor3.Pais = "Mexico";
            Proveedor3.Activo = true;

            ListaProveedores.Add(Proveedor3);
        }
        public BindingList<Proveedores> ObtenerProveedores()
        {
            return ListaProveedores;
        }
    }
    public class Proveedores
    {
        public int IdProveedor { get; set; }
        public string NombreCompania { get; set; }
        public string NombreContacto { get; set; }
        public string Ciudad { get; set; }
        public string Telefono { get; set; }
        public string Pais { get; set; }
        public bool Activo { get; set; }
    }
}
