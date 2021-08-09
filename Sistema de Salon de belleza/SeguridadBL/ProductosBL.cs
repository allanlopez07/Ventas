using System;
using BL.Rentas;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static BL.Rentas.CitasBL;

namespace BL.Rentas 
{
   public  class ProductosBL
    {
        Contexto _contexto;
        public BindingList<Producto> ListaProductos { get; set;  }

        TipoBL _tipoBL;
        public BindingList<Tipo> ListaTipos { get; set;  }
        public ProductosBL()
        {
            _contexto = new Contexto();
             ListaProductos = new BindingList<Producto>();

            _tipoBL = new TipoBL();
            ListaTipos = new BindingList<Tipo>();
        }
        public BindingList<Producto> ObtenerProductos()
        {
            _contexto.Productos.Load();
            ListaProductos = _contexto.Productos.Local.ToBindingList();

            return ListaProductos;
        }

        public BindingList<Producto> ObtenerProductos(string buscar)
        {
            var query = _contexto.Productos
            .Where(p => p.Descripcion.ToLower()
            .Contains(buscar.ToLower()) == true)
            .ToList();

            var resultado = new BindingList<Producto>(query);

            return resultado;
        }

        public Resultado GuardarProducto(Producto producto)
        {
            var resultado = Validar(producto);
            if (resultado.Exitoso == false)
            {
                return resultado;
            }

            _contexto.SaveChanges();

            resultado.Exitoso = true;
            return resultado;
        }

        public void AgrearProducto()
        {
            var nuevoProducto = new Producto();
            ListaProductos.Add(nuevoProducto);
        }

        public bool EliminarProducto(int Id)
        {
            foreach (var productos in ListaProductos)
            {
                if (productos.Id  == Id)
                {
                    ListaProductos.Remove(productos);
                    _contexto.SaveChanges();
                    return true;
                } 
            }
            return false;
        }

        public void CancelarCambios()
        {
            foreach (var item in _contexto.ChangeTracker.Entries())
            {
                item.State = EntityState.Unchanged;
                item.Reload();
            }
        }
        private Resultado Validar(Producto producto)
        {
            var resultado = new Resultado();
            resultado.Exitoso = true;

            if (producto ==  null)
            {
                resultado.Mensaje = "Agrege un producto o servicio valido";
                resultado.Exitoso = false;

               return resultado;

            }

                  if (string.IsNullOrEmpty(producto.Descripcion) == true)
                  {
                      resultado.Mensaje = "Ingrese una descripcion";
                      resultado.Exitoso = false;
                  }

                  if (producto.Existencia <0)
                  {
                      resultado.Mensaje = "La existencia debe de ser mayor a cero";
                      resultado.Exitoso = false;

                  }
                  
            if (producto.Precio < 0)
            {
                resultado.Mensaje = "La precio debe de ser mayor a cero";
                resultado.Exitoso = false;

            }

            if (producto.CategoriaId ==0)
            {
                resultado.Mensaje = "Seleccione una Categoria";
                resultado.Exitoso = false;

            }

            if (producto.TipoId == 0)
            {
                resultado.Mensaje = "Seleccione un Tipo";
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
        public byte[] Foto { get; set; }
        public int TipoId { get; set; }
        public Tipo Tipo { get; set; }
        public int CategoriaId { get; set; } 
        public Categoria Categoria { get; set; }
    }

    public class Resultado
    {
        public bool Exitoso { get; set; }
        public string Mensaje { get; set; }
    }
}