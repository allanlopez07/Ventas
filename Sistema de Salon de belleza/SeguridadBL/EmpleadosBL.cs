using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.Rentas
{
    public class EmpleadosBL
    {
        // empleadosBL_EmpleadosBindingSource
        Contexto _contexto;
        public BindingList<Empleados> ListaEmpleados { get; set; }
        public EmpleadosBL()
        {
            _contexto = new Contexto();
            ListaEmpleados = new BindingList<Empleados>();
        }

        public BindingList<Empleados> ObtenerEmpleados()
        {
            _contexto.Empleados.Load();
            ListaEmpleados = _contexto.Empleados.Local.ToBindingList();

            return ListaEmpleados;
        }

        public Resultado GuardarEmpelados(Empleados empleados)
        {
            var resultado = Validar(empleados);
            if (resultado.Exitoso == false)
            {
                return resultado;
            }

            _contexto.SaveChanges();

            resultado.Exitoso = true;
            return resultado;
        }

        public void Agregarempleados()
        {
            var nuevoEmpleado = new Empleados();
            ListaEmpleados.Add(nuevoEmpleado);
        }


        private Resultado Validar(Empleados empleados)
        {
            var resultado = new Resultado();
            resultado.Exitoso = true;


            if (string.IsNullOrEmpty(empleados.Nombre) == true)
            {
                resultado.Mensaje = "Ingrese el nombre del empleado";
                resultado.Exitoso = false;
            }
            return resultado;
        }
        public class Empleados
        {
            public int Id { get; set; }
            public string Nombre { get; set; }
            public string Apellido { get; set; }
            public string Correo { get; set; }
            public string Direccion { get; set; }
            public int Telefono { get; set; }
            public string Fecha_de_Ingreso { get; set; }
            public bool Activo { get; set; }
        }
    }
}
