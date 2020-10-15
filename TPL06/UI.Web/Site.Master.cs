﻿using Business.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Academia.UI.Web
{
    public partial class Site1 : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Usuario usuarioLog = (Usuario)Session["usuarioLogueado"];
            if (usuarioLog == null)
            {
                Page.Response.Redirect("~/Login.aspx");
            }
            this.gestionAcademica.Visible = false;
            this.gestionAlumno.Visible = false;
            this.gestionDocente.Visible = false;
            ScriptManager.RegisterStartupScript(this, this.GetType(), "alert", "printHello();", true);
            string text;
            TimeSpan now = DateTime.Now.TimeOfDay;
            if (now >= TimeSpan.Parse("05:00") && now < TimeSpan.Parse("13:00"))
            {
                text = "Buenos días, ";
            }
            else if (now >= TimeSpan.Parse("13:00") && now < TimeSpan.Parse("18:00"))
            {
                text = "Buenas tardes, ";
            }
            else
            {
                text = "Buenas noches, ";
            }
            this.lblUsuarioLogeado.Text =  text + usuarioLog.Nombre;
            foreach (Modulo m in usuarioLog.Modulo)
            {
                if (m.Descripcion == "Alumno" || m.Descripcion == "Administrador")
                    this.gestionAlumno.Visible = true;
                if (m.Descripcion == "Docente" || m.Descripcion == "Administrador")
                    this.gestionDocente.Visible = true;
                if (m.Descripcion == "No docente" || m.Descripcion == "Administrador")
                    this.gestionAcademica.Visible = true;
            }
        }

        protected void LogOut_ServerClick(object sender, EventArgs e)
        {
            Session.Clear();
            Page.Response.Redirect("~/Login.aspx");
        }
    }
}