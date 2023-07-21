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
    public partial class MostrarUsuario : System.Web.UI.Page
    {
        private IUsuariosDAL usuariosDAL = new UsuariosDALDB();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                List<Usuario> usuarios = usuariosDAL.ObtenerUsuarios();
                this.grillaUsuarios.DataSource = usuarios;
                this.grillaUsuarios.DataBind();


            }
        }

        protected void CargaGrilla()
        {


            List<Usuario> usuarios = usuariosDAL.ObtenerUsuarios();
            this.grillaUsuarios.DataSource = usuarios;
            this.grillaUsuarios.DataBind();


        }




        protected void btnFiltrarUsuario_Click(object sender, EventArgs e)
        {


            string filtroTipo = this.FltUsuarioDdl.SelectedItem.Text;


            
            List<Usuario> usuariosFiltrados = usuariosDAL.FiltrarUsuarios(filtroTipo);
            this.grillaUsuarios.DataSource = usuariosFiltrados;
            this.grillaUsuarios.DataBind();


        }


        protected void grillaUsuarios_RowCommand(object sender, GridViewCommandEventArgs e)
        {

            if (e.CommandName == "elimina")
            {
                
                string rut = Convert.ToString(e.CommandArgument);
                usuariosDAL.EliminarUsuario(rut);
                CargaGrilla();
                
            }
        }

        protected void FltUsuarioDdl_SelectedIndexChanged(object sender, EventArgs e)
        {
            string filtroTipo = this.FltUsuarioDdl.SelectedItem.Text;


            
            List<Usuario> usuariosFiltrados = usuariosDAL.FiltrarUsuarios(filtroTipo);
            this.grillaUsuarios.DataSource = usuariosFiltrados;
            this.grillaUsuarios.DataBind();
        }

        protected void btnRecargarUsuarios_Click(object sender, EventArgs e)
        {
            Response.Redirect("MostrarUsuario.aspx");
        }
    }
}