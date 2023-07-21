using MedidorASPModel.DAL;
using MedidorASPModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MedidorASP
{
    public partial class VerLecturas : System.Web.UI.Page
    {
        private ILecturasDAL lecturasDAL = new LecturasDALDB();
        private IMedidoresDAL medidoresDAL = new MedidoresDALDB();
        protected void Page_Load(object sender, EventArgs e)
        {
            List<Lectura> lecturas = lecturasDAL.ObtenerLecturas();
            this.grillaLecturas.DataSource = lecturas;

            this.grillaLecturas.DataBind();

            
            if (!IsPostBack)
            {
                List<Lectura> lecturas1 = lecturasDAL.ObtenerLecturas();

                if (lecturas1.Count == 0)
                {
                    this.FltLecturaDdl.Items.Add("No hay datos aun");
                }
                else {
                    List<int> numsSeriess = devuelveNSeries();
                    for (int i = 0; i < numsSeriess.Count(); i++)
                    {
                        this.FltLecturaDdl.Items.Add(new ListItem(numsSeriess[i].ToString(), i.ToString()));
                    }
                }
                

                
            }

        }

        protected void CargaGrilla()
        {

            List<Lectura> lecturas = lecturasDAL.ObtenerLecturas();
            this.grillaLecturas.DataSource = lecturas;

            this.grillaLecturas.DataBind();


        }

        protected void btnFiltrarLectura_Click(object sender, EventArgs e)
        {
            List<Lectura> lecturas1 = lecturasDAL.ObtenerLecturas();


            if (lecturas1.Count == 0)
            {
                
                this.FltLecturaDdl.Items.Clear();
                this.FltLecturaDdl.Items.Add("No hay datos aun");

            }
            else
            {
                

                int filtroNumSerie = Convert.ToInt32(this.FltLecturaDdl.SelectedItem.Text);


                List<Lectura> medidores = lecturasDAL.ObtenerLecturas();
                List<Lectura> medidoresFiltrados = medidores.FindAll(m => m.Medidor.NumSerie == filtroNumSerie);
                this.grillaLecturas.DataSource = medidoresFiltrados;
                this.grillaLecturas.DataBind();
            }
        }

        public List<int> devuelveNSeries() {
            List<int> listaNumSeries = new List<int>();
            List<Lectura> lecturas = lecturasDAL.ObtenerLecturas();
            
            foreach (Lectura l in lecturas)
            {
                listaNumSeries.Add(l.Medidor.NumSerie);
            }

            return listaNumSeries = listaNumSeries.Distinct().ToList();
        }


        protected void btnRecargarLecturas_Click(object sender, EventArgs e)
        {
            Response.Redirect("VerLecturas.aspx");

        }
    }
}