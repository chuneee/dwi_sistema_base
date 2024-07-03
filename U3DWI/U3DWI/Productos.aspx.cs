using mili;
using Mysqlx;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace U3DWI
{
    public partial class Productos : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            altas.Visible = false;
            edicion.Visible = false;
            consultar.Visible = false;


        }
        public void limpiar()
        {
            TextBox3.Text = "";
            TextBox4.Text = "";
            TextBox5.Text = "";
            TextBox6.Text = "";
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            altas.Visible = true;
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            int precio = Convert.ToInt32(TextBox1.Text);
            int cantidad = Convert.ToInt32(TextBox2.Text);
            //Manejo de excepciones
            try
            {
                //Instruccion
                string cmd = string.Format("Insert into productos(nombre,precio, cantidad) values('" + txtUsername.Text + "', '" +precio+ "', '" + cantidad +"')");
                //Cargar dataset con milibreria
                DataSet dt = utileria.Ejecutar(cmd);
                Response.Write("<script>alert('Se guardo satisfactoriamente');</script>");
            }
            catch (Exception)
            { Response.Write("<script>alert('No se guardo');</script>"); }
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            edicion.Visible = true;
        }

        protected void Button5_Click(object sender, EventArgs e)
        {
            try
            {
                string cmd = string.Format("Select nombre, precio, cantidad from productos where Id = '" + TextBox4.Text + "'");
                DataSet dt = utileria.Ejecutar(cmd);
                TextBox4.Text = dt.Tables[0].Rows[0]["nombre"].ToString();
                TextBox5.Text = dt.Tables[0].Rows[0]["precio"].ToString();
                TextBox6.Text = dt.Tables[0].Rows[0]["cantidad"].ToString();
                edicion.Visible = true;
            }
            catch
            {
                Response.Write("<script>alert('Ocurrio un error');</script>");
            }
        }

        protected void Button6_Click(object sender, EventArgs e)
        {
            int precio = Convert.ToInt32(TextBox5.Text);
            int cantidad = Convert.ToInt32(TextBox6.Text);
            //Manejo de excepciones
            try
            {
                //Instruccion
                string cmd = string.Format("Update productos set nombre='" +
                TextBox4.Text + "', precio='" + precio + "',cantidad='" + cantidad + "' where Id= '"
                + TextBox3.Text + "'");
                //Cargar dataset con milibreria
                DataSet dt = utileria.Ejecutar(cmd);
                Response.Write("<script>alert('Se modifico satisfactoriamente');</script>");
                limpiar();
            }
            catch (Exception)
            { Response.Write("<script>alert('No se modifico');</script>"); }
        }

        protected void Button7_Click(object sender, EventArgs e)
        {
            int ide = Convert.ToInt32(TextBox4.Text);
            try
            {
                //Instruccion
                string cmd = string.Format("delete from productos where Id='" + ide + "'");
                //Cargar dataset con milibreria
                DataSet dt = utileria.Ejecutar(cmd);
                Response.Write("<script>alert('Se elimino correctamente');</script>");
            }
            catch (Exception)
            {
                Response.Write("<script>alert('Ocurrio un error');</script>");
            }
        }

        protected void Button9_Click(object sender, EventArgs e)
        {
            try
            {
                string cmd = string.Format("Select Id as ID, nombre as Nombre, precio as Precio, cantidad as Cantidad from productos where Id = '" + TextBox7.Text +"'"); //Cargar dataset con milibreria
                DataSet dt = utileria.Ejecutar(cmd);
                GridView1.DataSource = dt;
                GridView1.DataBind();
            }
            catch
            {
                Response.Write("<script>alert('Ocurrio un error');</script>");
            }
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            consultar.Visible = true;
        }

        protected void Button10_Click(object sender, EventArgs e)
        {
            try
            {
                string cmd = string.Format("Select Id as ID, nombre as Nombre, precio as Precio, cantidad as Cantidad from productos");
                //Cargar dataset con milibreria
                DataSet dt = utileria.Ejecutar(cmd);
                GridView1.DataSource = dt;
                GridView1.DataBind();
            }
            catch
            {
                Response.Write("<script>alert('Ocurrio un error');</script>");
            }
        }
    }
    
}