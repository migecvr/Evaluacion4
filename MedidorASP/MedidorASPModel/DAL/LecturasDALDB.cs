using MedidorASPModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedidorASPModel.DAL
{
    public class LecturasDALDB : ILecturasDAL
    {
        
        private MEDIDORDBEntities medidorDBLectura = new MEDIDORDBEntities();
        public void AgregarLectura(Lectura lectura)
        {
            
            this.medidorDBLectura.Lecturas.Add(lectura);
            this.medidorDBLectura.SaveChanges();
        }

        public List<Lectura> ObtenerLecturas()
        {
            
            return this.medidorDBLectura.Lecturas.ToList();
        }

        
    }
}
