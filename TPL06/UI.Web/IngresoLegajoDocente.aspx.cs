﻿using Business.Logic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Academia.UI.Web
{
    public partial class IngresoLegajoForm : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnAceptar_Click(object sender, EventArgs e)
        {
            int legajo = int.Parse(txtLegajo.Text);
            Session["docente"] = (new PersonaLogic()).GetByLegajo(legajo);
            Page.Response.Redirect("~/MisCursosDocente.aspx");
        }
    }
}