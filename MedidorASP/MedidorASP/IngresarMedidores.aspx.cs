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
    public partial class IngresarMedidores : System.Web.UI.Page
    {
        private IMedidoresDAL medidoresDAL = new MedidoresDALDB();
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void btnAgregarMedidor_Click(object sender, EventArgs e)
        {

            //if (Page.IsValid)
            //{
            //    this.RequiredFieldValidator1.Text = "debes completar";

            //}
            //else {
            //    this.RequiredFieldValidator1.Text = "Esta vacio";
            //}

           
            

            

            if (!comparaDatoMedidor())
            {
                this.Label1.Text = "Dato no valido";

            }else if(existeMedidor()){
                this.Label1.Text = "El medidor ya existe";
            }
            else{
                int numSerie = Convert.ToInt32(this.NumSerie.Text.Trim());
                string tipo = this.TipoDdl.SelectedItem.Text;
                

                Medidor medidor = new Medidor()
                {
                    NumSerie = numSerie,
                    Tipo = tipo

                };
                medidoresDAL.AgregarMedidor(medidor);

                this.mensajeLbl.Text = "Se han ingresado los datos";

                Response.Redirect("Default.aspx");

                
            }

        }

        protected bool comparaDatoMedidor()
        {
            bool valido;
            int num;
            valido = Int32.TryParse(this.NumSerie.Text.Trim(), out num);

            return valido;


        }

        protected bool existeMedidor()
        {
            bool existe = false;

            if (comparaDatoMedidor())
            {
                int numSerie = Convert.ToInt32(this.NumSerie.Text.Trim());

                List<Medidor> medidores = medidoresDAL.ObtenerMedidores();
                bool medidorExiste = medidores.Any(m => m.NumSerie == numSerie);
                if (medidorExiste)
                {
                    existe = true;
                }
            }

            return existe;


        }
    }
}