using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
namespace ArtManagementSystem
{
    class artists
    {
        public string name;
        public Image profilepicture;
        public string contact;
        public string email;
        public string artistsid;
        

        public void addartists()
        {
            DBconn dbc = new DBconn();
            dbc.insertartists(this);
        }
    }

   
}
