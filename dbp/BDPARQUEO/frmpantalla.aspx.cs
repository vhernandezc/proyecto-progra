using BDPARQUEO.clases;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BDPARQUEO
{
    public partial class frmpantalla : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void txtpropietario_TextChanged(object sender, EventArgs e)
        {

        }

        protected void btnguargar_Click(object sender, EventArgs e)

        {
            clspropietario propietario = new clspropietario();
            propietario.matricula = txtmatricula.Text;
            propietario.propietario = txtpropietario.Text;
            propietario.fecha_ingreso = txtfecha_ingreso.Text;
            propietario.DPI = int.Parse(txtDPI.Text);
            propietario.telefono = int.Parse(txtTelefono.Text);
            propietario.color = txtcolor.Text;


            

            int resultado = clsProDal.agregar(propietario);



            if (resultado > 0)
            {
                string script = "alert(\"datos gruardados\");";
                ScriptManager.RegisterStartupScript(this, GetType(), "servercontrolsc", script, true);


                DataTable dt = new DataTable();
                     DataRow Row1;
                    DataRow Row2;
                    dt.Columns.Add(new DataColumn("Matricula", System.Type.GetType("System.String")));
                    dt.Columns.Add(new DataColumn("propietario", System.Type.GetType("System.String")));
                    dt.Columns.Add(new DataColumn("fecha_ingreso", System.Type.GetType("System.String")));
                    dt.Columns.Add(new DataColumn("DPI", System.Type.GetType("System.String")));
                    dt.Columns.Add(new DataColumn("Telefono", System.Type.GetType("System.String")));
                    dt.Columns.Add(new DataColumn("color", System.Type.GetType("System.String")));

                    Row1 = dt.NewRow();
                    Row1["Matricula"] = this.txtmatricula.Text;
                    Row1["Propietario"] = this.txtpropietario.Text;
                    Row1["fecha_ingreso"] = this.txtfecha_ingreso.Text;
                    Row1["DPI"] = this.txtDPI.Text;
                    Row1["Telefono"] = this.txtTelefono.Text;
                    Row1["color"] = this.txtcolor.Text;
                    dt.Rows.Add(Row1);



                    GridViewDatos.DataSource = dt;
                    GridViewDatos.DataBind();

                txtcolor.Text = "";
                txtDPI.Text = "";
                txtfecha_ingreso.Text = "";
                txtmatricula.Text = "";
                txtpropietario.Text = "";
                txtTelefono.Text = "";

                
            }
            else
            {
                string script = "alert(\"los datos no se guardaron\");";
                ScriptManager.RegisterStartupScript(this, GetType(), "servercontrolsc", script, true);
            }
            

        }



        
        protected void txtfecha_ingreso_TextChanged(object sender, EventArgs e)
        {
            
        }

        protected void gv_Rowcommand(object sender, GridViewCommandEventArgs e)
        {

        }

       
    }
}