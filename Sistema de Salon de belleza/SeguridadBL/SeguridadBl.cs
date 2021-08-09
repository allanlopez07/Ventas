using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.Rentas 
{
    public class SeguridadBl
    {
        
        Contexto _usuarios; 
        public BindingList<UsuariosDB> ListaUsuarios { get; set; } 

        public SeguridadBl()
        {
            _usuarios = new Contexto();
            ListaUsuarios = new BindingList<UsuariosDB>();
        }

        public BindingList<UsuariosDB> ObtenerUsuarios()
        {
            _usuarios.Usuarios.Load();
            ListaUsuarios = _usuarios.Usuarios.Local.ToBindingList();

            return ListaUsuarios;
        }

        public Resultado GuardarUsuario(UsuariosDB usuario)
        {
            var resultado = Validar(usuario);
            if (resultado.Exitoso == false)
            {
                return resultado;
            }

            _usuarios.SaveChanges();

            resultado.Exitoso = true;
            return resultado;
        }

        public void AgregarUsuario()
        {
            var nuevoUsuario = new UsuariosDB();
            ListaUsuarios.Add(nuevoUsuario);
        }

        public void CancelarCambios()
        {
            foreach (var item in _usuarios.ChangeTracker.Entries())
            {
                item.State = EntityState.Unchanged;
                item.Reload();
            }
        }

        private Resultado Validar(UsuariosDB usuario) 
        {
            var resultado = new Resultado();
            resultado.Exitoso = true;

            if (string.IsNullOrEmpty(usuario.Nombre) == true)
            {
                resultado.Mensaje = "Ingrese un nombre";
                resultado.Exitoso = false;
            }

         

            return resultado;
        }

        public bool EliminarUsuario(int Id)
        {
            foreach (var usuarios in ListaUsuarios)
            {
                if (usuarios.Id == Id)
                {
                    ListaUsuarios.Remove(usuarios);
                    _usuarios.SaveChanges();
                    return true;
                }
            }
            return false;
        }



        public  UsuariosDB Automatizar(string usuario, string contrasena)
        {
            var usuarios = _usuarios.Usuarios.ToList();

            foreach (var usuariosDB in usuarios)
            {
                if (usuario == usuariosDB.Nombre && contrasena == usuariosDB.Contrasena) 
                {
                    return usuariosDB;
                }
            }

            return null;
        }
        public class UsuariosDB 
        {
            public int Id { get; set; }
            public string Nombre { get; set; } 
            public string Contrasena { get; set; }
            public byte[] Foto { get; set; }
            public string  TipoUsuario { get; set; } 
        }
    }
}
