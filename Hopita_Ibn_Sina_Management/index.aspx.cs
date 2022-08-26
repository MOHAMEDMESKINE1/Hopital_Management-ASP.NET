using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Drawing;

namespace Hopita_Ibn_Sina_Management
{
    public partial class index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void pr_re_vo_Click(object sender, EventArgs e)
        {

            //if ((txtcin.Text == null) && (txtdate.Text == null) && (txtnom.Text == null) && (txtprenom.Text == null) && (txtphone.Text == null))
            //if ((txtcin.Text == "") && (txtdate.Text == "") && (txtnom.Text == "") && (txtprenom.Text == "") && (txtphone.Text == ""))
            if ((String.IsNullOrEmpty(txtcin.Text)) || (String.IsNullOrEmpty(txtnom.Text)) || (String.IsNullOrEmpty(txtprenom.Text)) || (String.IsNullOrEmpty(txtphone.Text)) || (String.IsNullOrEmpty(txtdate.Text)))
            {
                txter.Text = "";
                txter.ForeColor = System.Drawing.Color.Red;
                txter.Text = "vérifiez vos informations et réessayez";
            }
            else
            {
                try
                {
                    string nom = txtnom.Text.ToString();
                    string prenom = txtprenom.Text.ToString();
                    string cin = txtcin.Text.ToString();
                    string tele = txtphone.Text.ToString();
                    DateTime date_rendez = DateTime.Parse(txtdate.Text);

                    Gestion_HopitalEntities1 db = new Gestion_HopitalEntities1();

                    var count = (from p in db.Patient_web
                                 where p.date_re == date_rendez
                                 select p).Count();

                    if (count > 8)
                    {
                        txter.Text = "";
                        txter.ForeColor = System.Drawing.Color.Red;
                        txter.Text = "Le jour donné est déjà plein";
                    }
                    else
                    {
                        db.ajouter_rePatient_web(cin, nom, prenom, tele, date_rendez);
                        //******************************************************
                        txtcin.Text = null;
                        txtdate.Text = null;
                        txtnom.Text = null;
                        txtprenom.Text = null;
                        txtphone.Text = null;
                        txter.Text = "";
                        txter.Text = "Le rendez-vous a été réservé avec succès";
                        txter.ForeColor = System.Drawing.Color.Green;
                    }

                }
                catch (SqlException)
                {
                    txter.Text = "";
                    txter.ForeColor = System.Drawing.Color.Red;
                    txter.Text = "Rendez-vous saisi est déja attribué";
                }
                catch (Exception)
                {
                    txter.Text = "";
                    txter.ForeColor = System.Drawing.Color.Red;
                    txter.Text = "Rendez-vous saisi est déja attribué";
                }
            }

        }
    }
}