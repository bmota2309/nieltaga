﻿using CrudIngrediente.Classes;
using CrudIngrediente.Persistencia;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Paginas_Alterar : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
        {
            IngredienteBD bd = new IngredienteBD();
            Ingrediente ingrediente= bd.Select(Convert.ToInt32(Session["ID"]));
            txtNome.Text = ingrediente.Nome;
            txtSalario.Text = ingrediente.Marca;
            txtQuantidade.Double = ingrediente.Quantidade.ToString();
            txtValorUnit.Double = ingrediente.ValorUnit.ToString();
        }
    }
}