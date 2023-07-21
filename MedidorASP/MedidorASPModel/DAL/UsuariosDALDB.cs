using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedidorASPModel.DAL
{
    public class UsuariosDALDB : IUsuariosDAL
    {
        private MEDIDORDBEntities medidorDBUsuario = new MEDIDORDBEntities();
        public void AgregarUsuario(Usuario usuario)
        {
            this.medidorDBUsuario.Usuarios.Add(usuario);
            this.medidorDBUsuario.SaveChanges();
        }

        public List<Usuario> FiltrarUsuarios(string tipoUsuario)
        {
            var query = from u in this.medidorDBUsuario.Usuarios
                        where u.TipoUsuario == tipoUsuario
                        select u;
            return query.ToList();

        }

        public List<Usuario> ObtenerUsuarios()
        {
            return this.medidorDBUsuario.Usuarios.ToList();
            
        }

        public void EliminarUsuario(string rut)
        {
            var query = from u in this.medidorDBUsuario.Usuarios
                        where u.Rut == rut
                        select u;

            int id = query.ToList()[0].IdUsuario;
            
            Usuario usuario = this.medidorDBUsuario.Usuarios.Find(id);
           
            this.medidorDBUsuario.Usuarios.Remove(usuario);
            this.medidorDBUsuario.SaveChanges();
        }

        
    }
}
