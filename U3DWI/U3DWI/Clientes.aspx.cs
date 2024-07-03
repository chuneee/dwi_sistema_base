using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO.Ports;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using mili;

namespace U3DWI
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        MySqlCommand comando;
        MySqlConnection Con = new MySqlConnection("Server=127.0.0.1; Database = patito; Uid=root;Pwd=;");
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                llenar();
            }
        }
        public void llenar()
        {
            comando = new MySqlCommand("Select * from clientes ", Con);
            MySqlDataAdapter sda = new MySqlDataAdapter();
            sda.SelectCommand = comando;
            DataTable dt = new DataTable();
            sda.Fill(dt);
            Con.Close();
            if (dt.Rows.Count > 0)
            {
                GridView1.DataSource = dt;
                GridView1.DataBind();
            }
            else
            {
                dt.Rows.Add(dt.NewRow());
                GridView1.DataSource = dt;
                GridView1.Rows[0].Cells.Clear();
                GridView1.Rows[0].Cells.Add(new TableCell());
                GridView1.Rows[0].Cells[0].ColumnSpan = dt.Columns.Count;
                GridView1.Rows[0].Cells[0].Text = "No se encuentra";
                GridView1.Rows[0].Cells[0].HorizontalAlign = HorizontalAlign.Center;
            }
        }

        protected void GridView1_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            try
            {
                if (e.CommandName.Equals("Save"))
                {
                    using (Con)

                    {

                        Con.Open(); MySqlCommand comando = new MySqlCommand("Insert into clientes(nombre, correo) values(@nombre, @correo)", Con);


                        comando.Parameters.AddWithValue("@nombre",
                        (GridView1.FooterRow.FindControl("txtfn") as
                        TextBox).Text.Trim());
                        comando.Parameters.AddWithValue("@correo",
                        (GridView1.FooterRow.FindControl("txtftel") as
                        TextBox).Text.Trim());
                        comando.ExecuteNonQuery();

                        llenar();
                        MensajeS.Text = "Se agrego correctamente";
                        MensajeM.Text = "";
                        Con.Close();
                    }
                }
            }
            catch (Exception)
            {
                MensajeS.Text = "";
                MensajeM.Text = "No se agrego";
            }
        }

        protected void GridView1_RowEditing(object sender, GridViewEditEventArgs e)
        {
            GridView1.EditIndex = e.NewEditIndex;
            llenar();
        }

        protected void GridView1_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            GridView1.EditIndex = -1;
            llenar();
        }

        protected void GridView1_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            try
            {
                using (Con)
                {
                    Con.Open();

                    MySqlCommand comando = new MySqlCommand("Update clientes SET nombre = @nom, correo = @correo WHERE idc = @idc", Con);
                    comando.Parameters.AddWithValue("@nom",
                    (GridView1.Rows[e.RowIndex].FindControl("txtnombre") as TextBox).Text.Trim());
                    comando.Parameters.AddWithValue("@correo",
                    (GridView1.Rows[e.RowIndex].FindControl("txtel") as TextBox).Text.Trim());
                    comando.Parameters.AddWithValue("@idc",
                    (GridView1.Rows[e.RowIndex].FindControl("txtid") as TextBox).Text.Trim());

                    comando.ExecuteNonQuery();
                    GridView1.EditIndex = -1;
                    llenar();
                    MensajeS.Text = "Se actualizo correctamente";
                    Con.Close();

                }
            }
            catch (Exception)
            {
                MensajeS.Text = "";
                MensajeM.Text = "No se agrego";
            }
        }

        protected void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            try
            {
                using (Con)
                {
                    Con.Open();
                    MySqlCommand comando = new MySqlCommand("Delete from clientes WHERE idc = @id", Con);
                    comando.Parameters.AddWithValue("@id", (GridView1.Rows[e.RowIndex].FindControl("txtid") as TextBox).Text.Trim());
                    comando.ExecuteNonQuery();

                    llenar();
                    Con.Close();
                    MensajeS.Text = "Se elimino correctamente";
                }
            }
            catch (Exception)
            {
                MensajeS.Text = "";
                MensajeM.Text = "No se agrego";
            }
        }
    }
}
