using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.Rentas 
{
    public class SeguridadBl
    {
        
        Contexto _contexto;

        public SeguridadBl()
        {
            _contexto = new Contexto();
        }

       /* public string Contrasena { get; private set; }
        public string Nombre { get; private set; }*/

        public  bool Automatizar(string usuario, string contrasena)
        {
            var usuarios = _contexto.Usuarios.ToList();

            foreach (var usuariosDB in usuarios)
            {
                if (usuario == usuariosDB.Nombre && contrasena == usuariosDB.Contrasena) 
                {
                    return true;
                }
            }

            return false;
        }
        public class UsuariosDB 
        {
            public int Id { get; set; }
            public string Nombre { get; set; } 
            public string Contrasena { get; internal set; }
        }
    }
}
