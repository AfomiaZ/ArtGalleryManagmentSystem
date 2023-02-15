using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArtManagementSystem
{
    class arts
    {
        public string artname;
        public string artistname;
        public string purchasedate;
        public string priceofart;
        public string quantity;
        public string typeofartwork;

        public void addart()
        {
            DBconn dbc = new DBconn();
            dbc.insertart(this);
        }

    }
}
