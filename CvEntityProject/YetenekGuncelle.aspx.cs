using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


namespace CvEntityProject
{
    public partial class YetenekGuncelle : System.Web.UI.Page
    {
        DBCVENTITYEntities db = new DBCVENTITYEntities();
        protected void Page_Load(object sender, EventArgs e)
        {
            int id=int.Parse(Request.QueryString["ID"]);
            var yetenek = db.TBLYETENEKLER.Find(id);
            TextBox1.Text = yetenek.YETENEK;

        }
    }
}