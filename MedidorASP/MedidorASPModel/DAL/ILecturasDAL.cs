using MedidorASPModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedidorASPModel.DAL
{
    public interface ILecturasDAL
    {
        List<Lectura> ObtenerLecturas();

        void AgregarLectura(Lectura lectura);

        
    }
}
