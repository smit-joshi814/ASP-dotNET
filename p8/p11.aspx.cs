﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class p11 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
   
    protected void Button1_Click(object sender, EventArgs e)
    {
        if (dl.SelectedIndex == 0)
        {
            SqlConnection cn = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=E:\SMIT\p8\App_Data\Database.mdf;Integrated Security=True");
            string query = "select * from Products";
            SqlDataAdapter sda2 = new SqlDataAdapter(query, cn);
            DataSet ds2 = new DataSet();
            sda2.Fill(ds2, "Products");
            Response.Write("<table cellspacing=1 cellpadding=10><caption>"+dl.SelectedValue+"</caption>");
            Response.Write("<tr><th>Pid</th><th>Pname</th><th>Cid</th></tr>");
            for(int i=0;i<ds2.Tables["Products"].Rows.Count;i++)
            {
                Response.Write("<tr><td>" + ds2.Tables["Products"].Rows[i].ItemArray.GetValue(0).ToString() +"</td>");
                Response.Write("<td>" + ds2.Tables["Products"].Rows[i].ItemArray.GetValue(1).ToString() + "</td>");
                Response.Write("<td>" + ds2.Tables["Products"].Rows[i].ItemArray.GetValue(0).ToString() + "</td></tr>");
            }
        }
        else if (dl.SelectedIndex == 1)
        {
            SqlConnection cn = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=E:\SMIT\p8\App_Data\Database.mdf;Integrated Security=True");
            string query = "select * from Categories";
            SqlDataAdapter sda2 = new SqlDataAdapter(query, cn);
            DataSet ds2 = new DataSet();
            sda2.Fill(ds2, "Products");
            Response.Write("<table cellspacing=1 cellpadding=10><caption>" + dl.SelectedValue + "</caption>");
            Response.Write("<tr><th>Cid</th><th>Cname</th></tr>");
            for (int i = 0; i < ds2.Tables["Products"].Rows.Count; i++)
            {
                Response.Write("<tr><td>" + ds2.Tables["Products"].Rows[i].ItemArray.GetValue(0).ToString() + "</td>");
                Response.Write("<td>" + ds2.Tables["Products"].Rows[i].ItemArray.GetValue(1).ToString() + "</td></tr>");
                
            }
        }
    }
}