using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.Rentas 
{
   
    public class CitasBL
    {
        public BindingList<Citas> ListaCitas { get; set; } 

        public CitasBL()
        {
            ListaCitas = new BindingList<Citas>();

            var Cita1 = new Citas();
            Cita1.Fecha_Cita = "17-06-2021";
            Cita1.Hora = "10 a.m";
            Cita1.Cliente = "Aorosa Perez";
            Cita1.Empleado = "Gladys Sosa";
            Cita1.Servicio = "Corte de pelo";
            Cita1.Estatus = "Programado";

            ListaCitas.Add(Cita1);

            var Cita2 = new Citas();
            Cita2.Fecha_Cita = "18-06-2021";
            Cita2.Hora = "11 a.m";
            Cita2.Cliente = "Kevin Perez";
            Cita2.Empleado = "Misael Sosa";
            Cita2.Servicio = "Corte de barbilla";
            Cita2.Estatus = "Programado";

            ListaCitas.Add(Cita2);
        }
        public BindingList<Citas> ObtenerCitas()
        {
            return ListaCitas;
        }
        public class Citas
        {
            public string Fecha_Cita { get; set; }
            public string Hora { get; set; }
            public string Cliente { get; set; }
            public string Empleado { get; set; }
            public string Servicio { get; set; }
            public string Estatus { get; set; }
        }
    }
}
