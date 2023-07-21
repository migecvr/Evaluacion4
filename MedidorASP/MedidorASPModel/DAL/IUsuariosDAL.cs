using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedidorASPModel.DAL
{
    public interface IUsuariosDAL
    {
        List<Usuario> ObtenerUsuarios();

        void AgregarUsuario(Usuario usuario);

        List<Usuario> FiltrarUsuarios(string tipoUsuario);

        void EliminarUsuario(string rut);

        
    }
}
