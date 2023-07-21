using MedidorASPModel;
using MedidorASPModel.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MedidorASP
{
    public partial class IngresarUsuario : System.Web.UI.Page
    {
        private IUsuariosDAL usuariosDAL = new UsuariosDALDB();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnAgregarUsuario_Click(object sender, EventArgs e)
        {

            //if (Page.IsValid)
            //{
            //    this.RequiredFieldValidator1.Text = "debes completar";

            //}
            //else {
            //    this.RequiredFieldValidator1.Text = "Esta vacio";
            //}






            if (!comparaDatoUsuario())
            {
                this.Label1.Text = "Dato no valido";

            }
            else if (existeUsuario())
            {
                this.Label1.Text = "El usuario ya existe";
            }
            else
            {
                string rut = this.rutTxt.Text.Trim();
                string tipo = this.TipoUsuarioDdl.SelectedItem.Text;
                string contrasenia = this.contraseniaTxt.Text.Trim();
                string correo = this.correoTxt.Text.Trim();
                string nombre = this.nombreTxt.Text.Trim();
                string apellido = this.apellidoTxt.Text.Trim();

                nombre = nombre.ToUpper();
                apellido = apellido.ToUpper();
                

                Usuario usuario = new Usuario()
                {
                    Rut = rut,
                    TipoUsuario = tipo,
                    Contrasenia = contrasenia, 
                    Correo = correo,
                    Nombre = nombre,
                    Apellido = apellido

                };
                usuariosDAL.AgregarUsuario(usuario);

                this.mensajeLbl.Text = "Se han ingresado los datos";

                Response.Redirect("MostrarUsuario.aspx");


            }

        }

        protected bool comparaDatoUsuario()
        {
            bool valido= true;
            string rut = this.rutTxt.Text.Trim();

            if (rut.Length > 15)
            {
                valido = false;
            }

            return valido;


        }

        protected bool existeUsuario()
        {
            bool existe = false;

            if (comparaDatoUsuario())
            {
                string rut = this.rutTxt.Text.Trim();

                List<Usuario> usuarios = usuariosDAL.ObtenerUsuarios();
                bool usuarioExiste = usuarios.Any(u => u.Rut == rut);
                if (usuarioExiste)
                {
                    existe = true;
                }
            }

            return existe;


        }
    }
}