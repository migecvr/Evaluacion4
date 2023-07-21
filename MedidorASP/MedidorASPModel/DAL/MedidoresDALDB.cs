using MedidorASPModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedidorASPModel.DAL
{
    public class MedidoresDALDB : IMedidoresDAL
    {
        
        private MEDIDORDBEntities medidorDB = new MEDIDORDBEntities();
        public void AgregarMedidor(Medidor medidor)
        {
            
            this.medidorDB.Medidors.Add(medidor);
            this.medidorDB.SaveChanges();
        }

        public List<Medidor> ObtenerMedidores()
        {
            
            return this.medidorDB.Medidors.ToList();
        }

        public List<Medidor> FiltrarMedidores(string tipo)
        {
            var query = from m in this.medidorDB.Medidors
                        where m.Tipo == tipo
                        select m;
            return query.ToList();

        }
    }
}
