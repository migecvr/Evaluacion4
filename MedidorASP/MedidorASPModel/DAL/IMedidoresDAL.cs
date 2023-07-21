using MedidorASPModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedidorASPModel.DAL
{
    public interface IMedidoresDAL
    {
        List<Medidor> ObtenerMedidores();

        void AgregarMedidor(Medidor medidor);

        List<Medidor> FiltrarMedidores(string tipo);
    }
}
