using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace U3DWI
{
    public partial class Factura : System.Web.UI.Page
    {
        public string leyenda;
        public string leyenda2;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                // Se cargaran los nombres de los clientes con esta conexion
                MySqlConnection c1 = new MySqlConnection("Server = 127.0.0.1; Database = patito; Uid = root; Pwd = ; SslMode = none ");
                c1.Open();
                MySqlCommand cm1, cm2;
                MySqlDataReader dr1;
                cm1 = new MySqlCommand("SELECT distinct venta.id_c, clientes.nombre FROM clientes INNER JOIN venta where clientes.id_c = venta.id_c", c1);
                cm2 = new MySqlCommand("SELECT distinct venta.fecha FROM venta", c1);
                dr1 = cm1.ExecuteReader();
                DropDownList1.DataSource = dr1;
                DropDownList1.DataTextField = "nombre";
                DropDownList1.DataValueField = "id_c";
                DropDownList1.DataBind();
                dr1.Close();
                DropDownList1.Items.Insert(0, new ListItem("Seleccione...", "Seleccione..."));
                leyenda2 = leyenda + Page.Request.Params["__EVENTTARGET"];
            }
        }

        protected void Button7_Click(object sender, EventArgs e)
        {
            MySqlConnection c1 = new MySqlConnection("Server = 127.0.0.1; Database =patito; Uid = root; Pwd = ; SslMode = none");
            MySqlCommand cm1;
            c1.Open();
            cm1 = new MySqlCommand("Select detalle.id_d as ID, productos.nombre as Nombre, detalle.cantidad as Cantidad, detalle.subtotal as Subtotal from detalle inner join productos on productos.id_p = detalle.id_p where detalle.id_v = '" + DropDownList2.SelectedValue + "'", c1);
            cm1.ExecuteNonQuery();
            MySqlDataReader dr1;
            dr1 = cm1.ExecuteReader();
            GridView1.DataSource = dr1;
            GridView1.DataBind();
            c1.Close();
            //cargar los datos del cliente
            MySqlConnection c2 = new MySqlConnection("Server = 127.0.0.1; Database = patito; Uid = root; Pwd = 12345678; SslMode = none");
            MySqlCommand cm2;
            c2.Open();
            cm2 = new MySqlCommand("Select nombre, direccion from clientes where id_c = '" + DropDownList1.SelectedValue + "'", c2);
            MySqlDataReader dr2;
            cm2.ExecuteNonQuery();
            dr2 = cm2.ExecuteReader();
            if (dr2.Read())
            {
                Label2.Text = dr2.GetValue(0).ToString();
                Label3.Text = dr2.GetValue(1).ToString();
            }
            c2.Close();
            //Cargar los datos de venta en la factura

            MySqlConnection c3 = new MySqlConnection("Server = 127.0.0.1; Database = patito; Uid = root; Pwd = ; SslMode = none");
            MySqlCommand cm3;
            c3.Open();
            cm3 = new MySqlCommand("Select id_v, fecha from venta where id_v='" + DropDownList2.SelectedValue + "'", c3);
            MySqlDataReader dr3;
            dr3 = cm3.ExecuteReader();
            if (dr3.Read())
            {
                Label2.Text = dr3.GetValue(0).ToString();
                Label3.Text = dr3.GetValue(1).ToString();
            }
            c3.Close();
            MySqlConnection c4 = new MySqlConnection("Server = 127.0.0.1; Database = patito; Uid = root; Pwd = ; SslMode = none");
            MySqlCommand cm4;
            c4.Open();
            cm4 = new MySqlCommand("Select total from venta where id_v= '" +
            DropDownList2.SelectedValue + "'", c4);
            MySqlDataReader dr4;
            dr4 = cm4.ExecuteReader();
            c4.Close();
        }

        protected void Button6_Click(object sender, EventArgs e)
        {
            // Se cargaran los nombres de los clientes con esta conexion
            MySqlConnection c1 = new MySqlConnection("Server = 127.0.0.1;  Database = patito; Uid = root; Pwd = ; SslMode = none ");
            c1.Open();
            MySqlCommand cm1;
            MySqlDataReader dr1;
            cm1 = new MySqlCommand("SELECT venta.id_v, venta.fecha FROM clientes INNER JOIN venta on clientes.id_c = venta.id_c where clientes.id_c =  '" + DropDownList1.SelectedValue + "' ", c1);
            dr1 = cm1.ExecuteReader();
            DropDownList2.DataSource = dr1;
            DropDownList2.DataTextField = "fecha";
            DropDownList2.DataValueField = "id_v";
            DropDownList2.DataBind();
            dr1.Close();
        }
    }
}