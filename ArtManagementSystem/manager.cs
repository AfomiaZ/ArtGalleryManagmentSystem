using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArtManagementSystem
{
    class manager
    {
        public string name;
        public string username;
        public string password;
        public string email;
        public string contact;
        
        public void addmanager()
        {
            DBconn dbc = new DBconn();
            dbc.insertmanager(this);
        }
    }
}
