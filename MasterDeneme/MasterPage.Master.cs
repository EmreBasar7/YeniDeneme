using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MasterDeneme
{
    public partial class MasterPage : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            getir();
        }
        void getir()
        {
            Veritabani.projeEntities ent = new Veritabani.projeEntities();
            GridView1.DataSource = ent.Kullanıcılar.ToList();
            GridView1.DataBind();

        }
    }
}