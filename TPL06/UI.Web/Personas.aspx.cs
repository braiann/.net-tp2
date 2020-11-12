﻿using Business.Entities;
using Business.Logic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Academia.UI.Web
{
    public partial class Personas : System.Web.UI.Page
    {
        PersonaLogic pl = new PersonaLogic();

        protected void Page_Load(object sender, EventArgs e)
        {
            Usuario usuario = (Usuario)Session["usuarioLogueado"];
            if (usuario == null)
            {
                Page.Response.Redirect("~/PaginaNoPermitida.aspx");
            }
            foreach (Modulo m in usuario.Modulo)
            {
                if (!(m.Descripcion == "NoDocente" || m.Descripcion == "Administrador"))
                    Page.Response.Redirect("~/PaginaNoPermitida.aspx");
            }
            dgvPersonas.DataSource = pl.GetAll();
            dgvPersonas.DataBind();
            dgvPersonas.Columns[0].Visible = false;
        }

        protected void btnEditar_Click(object sender, EventArgs e)
        {
            Session["idSeleccionado"] = dgvPersonas.SelectedValue;
            Page.Response.Redirect("~/MiInformacion.aspx");
        }

        protected void btnEliminar_Click(object sender, EventArgs e)
        {
            pl.Delete((int)dgvPersonas.SelectedValue);
        }

        protected void btnNuevo_Click(object sender, EventArgs e)
        {
            Session["idSeleccionado"] = -1;
            Page.Response.Redirect("~/MiInformacion.aspx");
        }
    }
}