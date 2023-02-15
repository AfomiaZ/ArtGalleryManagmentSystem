using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArtManagementSystem
{
    class sales
    {
        public string customername;
        public string contact;
        public string email;
        public string issueddate;
        public string artworkname;

        public void addsales()
        {
            DBconn dbc = new DBconn();
            dbc.insertsales(this);
        }
    }


}
