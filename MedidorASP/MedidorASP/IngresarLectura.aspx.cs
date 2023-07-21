using MedidorASPModel.DAL;
using MedidorASPModel;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MedidorASP
{
    public partial class IngresarLectura : System.Web.UI.Page
    {
        private ILecturasDAL lecturasDAL = new LecturasDALDB();
        private IMedidoresDAL medidoresDAL = new MedidoresDALDB();
        protected void Page_Load(object sender, EventArgs e)
        {

            if (!IsPostBack)
            {
                List<Medidor> medidores = medidoresDAL.ObtenerMedidores();
                if (medidores.Count == 0)
                {
                    this.medidorDdl.Items.Add("No se han ingresado medidores");

                }
                else {
                    this.medidorDdl.DataSource = medidores;
                    this.medidorDdl.DataTextField = "NumSerie";
                    this.medidorDdl.DataValueField = "NumSerie";
                    this.medidorDdl.DataBind();
                }

                
                
                FechaTxt.Text = Calendar1.TodaysDate.ToShortDateString();
            }
                
        }


        protected void btnIngresarLectura_Click(object sender, EventArgs e)
        {

            List<Medidor> medidores1 = medidoresDAL.ObtenerMedidores();
            

            if (medidores1.Count == 0)
            {

                this.Label1.Text = "Aun no se han ingresado medidores";

            }
            else {
                string medidorValor = this.medidorDdl.SelectedValue;
                
                string medidorTexto = this.medidorDdl.SelectedItem.Text;



                String fecha = this.FechaTxt.Text.Trim();

                int hora = Convert.ToInt32(this.HoraTxt.Text.Trim());

                int minuto = Convert.ToInt32(this.MinutoTxt.Text.Trim());

                double consumo = Convert.ToDouble(this.ConsumoTxt.Text.Trim());



                List<Medidor> medidores = medidoresDAL.ObtenerMedidores();

                Medidor medidor = medidores.Find(m => m.NumSerie == Convert.ToInt32(this.medidorDdl.SelectedItem.Value));



                Lectura lectura = new Lectura()
                {
                    
                    Fecha = fecha,
                    Hora = hora,
                    Minuto = minuto,
                    Consumo = consumo,
                    IdMedidor = medidor.IdMedidor
                };
                lecturasDAL.AgregarLectura(lectura);

                this.mensajeLbl.Text = "Ingesado Correctamente";

                Response.Redirect("VerLecturas.aspx");
            }
            
        }

        

        protected void Calendar1_SelectionChanged(object sender, EventArgs e)
        {
            FechaTxt.Text = Calendar1.SelectedDate.ToShortDateString();
        }
    }
}