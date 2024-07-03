using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using mili;

namespace U3DWI
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            //Manejo de excepciones
            try
            {//Declarar dos string para guardar la informacion de los textbox
                string user = txtUsername.Text;
                string password = txtPassword.Text;
                //Instruccion sql
                string cmd = string.Format("Select user, password from login where user = '" + user + "' and password = '" + password + "'");
                //Cargar dataset con milibreria
                DataSet dt = utileria.Ejecutar(cmd);
                //Lo que encontro lo comparara lo guarda en los siguientes variables string
                string usu2 = dt.Tables[0].Rows[0]["user"].ToString().Trim();
                string psw2 = dt.Tables[0].Rows[0]["password"].ToString().Trim();
                //Compara la informacion de la base de datos con la apliacion
                if ((usu2 == user) && (psw2 == password))
                {//Si resulta igual, te envia a la segunda forma
                    Response.Redirect("Productos.aspx");
                }
            }//Si no envia un mensaje, con el nombre del error
            catch (Exception)
            {
                Response.Write("<script>alert('El usuario no se encuentra');</script>");
                txtUsername.Focus();
            }
        }
    }
}