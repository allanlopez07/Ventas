using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.Rentas 
{
   public  class ProductosBL
    {
        public BindingList<Producto> ListaProductos { get; set;  }

        public ProductosBL()
        {
            ListaProductos = new BindingList<Producto>();

            var Producto1 = new Producto();
            Producto1.Id = 001;
            Producto1.Descripcion = "Plancha de Ceramica";
            Producto1.Marca = "Remington S9500 Pearl";
            Producto1.Precio = 5000;
            Producto1.Existencia = 5;
            Producto1.Activo = true;

            ListaProductos.Add(Producto1);

            var Producto2 = new Producto();
            Producto2.Id = 002;
            Producto2.Descripcion = "Delantal para estilistas.";
            Producto2.Marca = "LCL Beauty ";
            Producto2.Precio = 50;
            Producto2.Existencia = 100;
            Producto2.Activo = true;

            ListaProductos.Add(Producto2);

            var Producto3 = new Producto();
            Producto3.Id = 003;
            Producto3.Descripcion = "Sillón reclinable hidráulico.";
            Producto3.Marca = "Heavy Duty  ";
            Producto3.Precio = 1500;
            Producto3.Existencia = 4;
            Producto3.Activo = true;

            ListaProductos.Add(Producto3);
        }
        public BindingList<Producto> ObtenerProductos()
        {
            return ListaProductos;
        }

        public Resultado GuardarProducto(Producto producto)
        {
            var resultado = Validar(producto);
            if (resultado.Exitoso == false)
            {
                return resultado;
            }


            if(producto.Id==0)
            {
                producto.Id = ListaProductos.Max(item => item.Id) + 1;
            }

            resultado.Exitoso = true;
            return resultado;
        }

        public void AgregarProducto()
        {
            var nuevoProducto = new Producto();

            ListaProductos.Add(nuevoProducto);
        }

        public bool EliminarProducto(int id)
        {
            foreach (var producto in ListaProductos )
            {
                if (producto.Id==id)
                {
                    ListaProductos.Remove(producto);
                    return true;
                }
            }

            return false;

        }

        private Resultado Validar(Producto producto)
        {

            var resultado = new Resultado();
            resultado.Exitoso = true;

            if (string.IsNullOrEmpty(producto.Descripcion)==true)
            {
                resultado.Mensaje = "Ingrese una descripción";
                resultado.Exitoso = false;
            }

            if(producto.Existencia<0)
            {
                resultado.Mensaje = "La existencia debe ser mayor que cero";
                resultado.Exitoso = false;
            }

            if (producto.Precio < 0)
            {
                resultado.Mensaje = "El Precio debe ser mayor que cero";
                resultado.Exitoso = false;
            }

            return resultado;

        }

    }
public class Producto
    {
        public int Id { get; set; }
        public string Descripcion { get; set; }
        public string Marca { get; set; }
        public double Precio { get; set; }
        public int Existencia { get; set; }
        public bool Activo { get; set; }
    }

    public class Resultado
    {
        public bool Exitoso { get; set; }
        public string Mensaje { get; set; }
    }

}



