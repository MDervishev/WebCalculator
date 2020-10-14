using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Calcolatrice.Styles
{
    public partial class calc : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            TextBox1.Text += "1";
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            TextBox1.Text += "2";
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            TextBox1.Text += "3";
        }

        protected void Button5_Click(object sender, EventArgs e)
        {
            TextBox1.Text += "4";
        }

        protected void Button6_Click(object sender, EventArgs e)
        {
            TextBox1.Text += "5";
        }

        protected void Button7_Click(object sender, EventArgs e)
        {
            TextBox1.Text += "6";
        }

        protected void Button9_Click(object sender, EventArgs e)
        {
            TextBox1.Text += "7";
        }

        protected void Button10_Click(object sender, EventArgs e)
        {
            TextBox1.Text += "8";
        }

        protected void Button11_Click(object sender, EventArgs e)
        {
            TextBox1.Text += "9";
        }

        protected void Button14_Click(object sender, EventArgs e)
        {
            TextBox1.Text += "0";
        }
        //+
        protected void Button4_Click(object sender, EventArgs e)
        {
            Session["sessione"] = TextBox1.Text;
            Session["operazione"] = "+";
            TextBox1.Text = "";
        }
        //-
        protected void Button8_Click(object sender, EventArgs e)
        {
            Session["sessione"] = TextBox1.Text;
            Session["operazione"] = "-"; TextBox1.Text = "";
        }
        //X
        protected void Button12_Click(object sender, EventArgs e)
        {
            Session["sessione"] = TextBox1.Text;
            Session["operazione"] = "x"; TextBox1.Text = "";
        }
        //:
        protected void Button16_Click(object sender, EventArgs e)
        {
            Session["sessione"] = TextBox1.Text;
            Session["operazione"] = ":"; TextBox1.Text = "";
        }
        //=
        protected void Button15_Click(object sender, EventArgs e)
        {
            switch (Session["operazione"].ToString()) {
                case "+": { if (TextBox1.Text == "") { TextBox1.Text = "0"; } 
                    string a=TextBox1.Text;
                    string b=Session["sessione"].ToString();
                    TextBox1.Text = (Convert.ToInt32(a)+Convert.ToInt32(b)).ToString(); } break;
                case "-":
                    {
                        if (TextBox1.Text == "") { TextBox1.Text = "0"; }
                        string a = TextBox1.Text;
                        string b = Session["sessione"].ToString();
                        TextBox1.Text = (Convert.ToInt32(b) - Convert.ToInt32(a)).ToString();
                    } break;
                case "x":
                    {
                        if (TextBox1.Text == "") { TextBox1.Text = "0"; }
                        string a = TextBox1.Text;
                        string b = Session["sessione"].ToString();
                        TextBox1.Text = (Convert.ToInt32(a)* Convert.ToInt32(b)).ToString();
                    } break;
                case ":":
                    {
                        if (TextBox1.Text == "") { TextBox1.Text = "0"; }
                        string a = TextBox1.Text;
                        string b = Session["sessione"].ToString();
                        TextBox1.Text = (Convert.ToInt32(b) / Convert.ToInt32(b)).ToString();
                    } break;
            }
        }
        //ce
        protected void Button13_Click(object sender, EventArgs e)
        {
            Session.Clear();
            TextBox1.Text = "";
        }

        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}