﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using solucaoNiteltaga.Classes;
using solucaoNiteltaga.Persistencia;


public partial class Paginas_PedidosEntregues : System.Web.UI.Page
{

    
    protected void Page_Load(object sender, EventArgs e)
    {
       

    }
    


    protected void btnSair_Click(object sender, EventArgs e)
    {
        {
            Session.Abandon();
            Session.Clear();
            Session.RemoveAll();
            Response.Redirect("Login.aspx");
        }
    }

    
    
}