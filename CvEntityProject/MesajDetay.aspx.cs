using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CvEntityProject
{
    public partial class MesajDetay : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            DBCVENTITYEntities db=new DBCVENTITYEntities();
            int id = int.Parse(Request.QueryString["ID"]);
            var mesaj=db.TBLILETISIM.Find(id);
            TextBoxAdSoyad.Text = mesaj.ADSOYAD;
            TextBoxMail.Text = mesaj.MAIL;
            TextBoxKonu.Text = mesaj.KONU;
            TextBoxMesaj.Text = mesaj.MESAJ;

        }
    }
}