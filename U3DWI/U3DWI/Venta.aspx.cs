using mili;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace U3DWI
{
    public partial class Venta : System.Web.UI.Page
    {
        public int suma = 0;
        public string leyenda = "";
        public string leyenda2;
        public int total;
        public int clavep;
        protected void Page_Load(object sender, EventArgs e)
        {
            //Este textBox guardara el id del producto seleccionado
            TextBox3.Visible = false;
            if (!IsPostBack)
            {
                // Se cargaran los nombres de los clientes con esta conexion
                MySqlConnection c1 = new MySqlConnection("Server = 127.0.0.1; Database = patito; Uid = root; Pwd = ; ");
                c1.Open(); MySqlCommand cm1;
                MySqlDataReader dr1;
                cm1 = new MySqlCommand("select id_c, nombre from clientes order by nombre", c1);
                dr1 = cm1.ExecuteReader();
                DropDownList1.DataSource = dr1;
                DropDownList1.DataTextField = "nombre";
                DropDownList1.DataValueField = "id_c";
                DropDownList1.DataBind();
                dr1.Close();
                DropDownList1.Items.Insert(0, new ListItem("Seleccione...", "Seleccione..."));
                leyenda2 = leyenda + Page.Request.Params["__EVENTTARGET"];

                // Cargar datos en DropDownList2 (Ejemplo: cargar una lista de cantidades)
                DropDownList2.Items.Clear();
                for (int i = 1; i <= 10; i++)
                {
                    DropDownList2.Items.Add(new ListItem(i.ToString(), i.ToString()));
                }
                DropDownList2.Items.Insert(0, new ListItem("Seleccione...", "0"));

                //Se cargaran las imágenes del productos

                string cmd = "SELECT imagen FROM productos where id_p=200";
                DataSet dt = utileria.Ejecutar(cmd);
                string url = dt.Tables[0].Rows[0]["imagen"].ToString();
                ImageButton1.ImageUrl = url;
                string cmd1 = "SELECT imagen FROM productos where id_p=201";
                DataSet dt1 = utileria.Ejecutar(cmd1);
                string url1 = dt1.Tables[0].Rows[0]["imagen"].ToString();
                ImageButton2.ImageUrl = url1;
                string cmd2 = "SELECT imagen FROM productos where id_p=202";
                DataSet dt2 = utileria.Ejecutar(cmd2);
                string url2 = dt2.Tables[0].Rows[0]["imagen"].ToString();
                ImageButton3.ImageUrl = url2;
            }
        }

        protected void Button8_Click(object sender, EventArgs e)
        {
            string cmd1 = string.Format("call calcular4;");
            DataSet dt1 = utileria.Ejecutar(cmd1);
            string cmd = string.Format("select total from venta where id_v= (select max(id_v) from venta)");
            DataSet dt = utileria.Ejecutar(cmd);
            TextBox3.Text = dt.Tables[0].Rows[0]["total"].ToString();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            {
                try
                {
                    //Instruccion para crear una nueva venta
                    string cmd = string.Format("Insert into ventas (fecha, idc, total) values('" + TextBox1.Text + "', '" +
                    DropDownList1.SelectedValue + "', 0 )");
                    //Cargar dataset con milibreria
                    DataSet dt = utileria.Ejecutar(cmd);
                    Response.Write("<script>alert('Venta Correctamente');</script>");
                }
                catch (Exception)
                {
                    Response.Write("<script>alert('No se guardo');</script>");
                }
            }
        }

        protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
        {
            //Instruccion para seleccionar los datos de los productos
            clavep = 200;
            TextBox3.Text = clavep.ToString();
            string cmd = "SELECT nombre, precio FROM productos where id_p = '" + clavep + "'";
            DataSet dt = utileria.Ejecutar(cmd);
            Label1.Text = dt.Tables[0].Rows[0]["nombre"].ToString();
            Label2.Text = dt.Tables[0].Rows[0]["precio"].ToString();
        }

        protected void ImageButton2_Click(object sender, ImageClickEventArgs e)
        {
            TextBox3.Text = clavep.ToString();
            clavep = 201;
            string cmd = "SELECT nombre, precio FROM productos where id_p = '" + clavep + "'";
            DataSet dt = utileria.Ejecutar(cmd);
            Label1.Text = dt.Tables[0].Rows[0]["nombre"].ToString();
            Label2.Text = dt.Tables[0].Rows[0]["precio"].ToString();
        }

        protected void ImageButton3_Click(object sender, ImageClickEventArgs e)
        {
            TextBox3.Text = clavep.ToString();
            clavep = 202;
            string cmd = "SELECT nombre, precio FROM productos where id_p='" +
            clavep + "'";
            DataSet dt = utileria.Ejecutar(cmd);
            Label1.Text = dt.Tables[0].Rows[0]["nombre"].ToString();
            Label2.Text = dt.Tables[0].Rows[0]["precio"].ToString();
        }

        protected void Button6_Click(object sender, EventArgs e)
        {
            int cant = Convert.ToInt32(DropDownList2.Text) * Convert.ToInt32(Label2.Text);
            //TextBox3.Text = cant.ToString();
            suma = suma + cant;
            Label1.Text = suma.ToString();
            TextBox4.Text = suma.ToString(); // Actualizar el total en TextBox4
        }

        protected void Button7_Click(object sender, EventArgs e)
        {
            //Instrucción insertar productos en tabla detalle mediante un procedure

            int cant = Convert.ToInt32(DropDownList2.Text) * Convert.ToInt32(Label2.Text);
            // TextBox3.Text = cant.ToString();
            string cmd1 = string.Format("call este1 ('{0}','{1}','{2}');",
            TextBox3.Text.Trim(), DropDownList2.Text.Trim(), cant);
            //Cargar dataset con milibreria
            DataSet dt1 = utileria.Ejecutar(cmd1);
            TextBox3.Text = "";
            DropDownList2.ClearSelection();
        }
    }
}
