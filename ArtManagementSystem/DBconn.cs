using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace ArtManagementSystem
{
    class DBconn
    {

        string url = "server=.;database =artgallerymanagmentsystem ;uid=aaa; pwd=123";

        public void insertartists(artists a )
        {
           
                SqlConnection con = new SqlConnection(url);
                con.Open();
                SqlCommand cmd = new SqlCommand("addArtists2", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@fullname", a.name);
                cmd.Parameters.AddWithValue("@profilepicture", a.profilepicture);
                cmd.Parameters.AddWithValue("@contact", a.contact);
                cmd.Parameters.AddWithValue("@email", a.email);
                cmd.Parameters.AddWithValue("@artistsId", a.artistsid);
            
                

                cmd.ExecuteNonQuery();
                con.Close();    
        }

        public void insertsales(sales s)
        {

            SqlConnection con = new SqlConnection(url);
            con.Open();
            SqlCommand cmd = new SqlCommand("addsales", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@customername", s.customername);
            cmd.Parameters.AddWithValue("@contact", s.contact);
            cmd.Parameters.AddWithValue("@email", s.email);
            cmd.Parameters.AddWithValue("@issuedDate", s.issueddate);
            cmd.Parameters.AddWithValue("@artworkname", s.artworkname);



            cmd.ExecuteNonQuery();
            con.Close();


        }

        public void insertart(arts at)
        {

            SqlConnection con = new SqlConnection(url);
            con.Open();
            SqlCommand cmd = new SqlCommand("insertarts", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@artname", at.artname);
            cmd.Parameters.AddWithValue("@artistname", at.artistname);
            cmd.Parameters.AddWithValue("@purchasedate", at.purchasedate);
            cmd.Parameters.AddWithValue("@priceofart", at.priceofart);
            cmd.Parameters.AddWithValue("@quantity", at.quantity);
            cmd.Parameters.AddWithValue("@typeofartwork", at.typeofartwork);



            cmd.ExecuteNonQuery();
            con.Close();


        }

        public void insertmanager(manager m)
        {

            SqlConnection con = new SqlConnection(url);
            con.Open();
            SqlCommand cmd = new SqlCommand("addmanager", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@name", m.name);
            cmd.Parameters.AddWithValue("@username", m.username);
            cmd.Parameters.AddWithValue("@password", m.password);
            cmd.Parameters.AddWithValue("@email", m.email);
            cmd.Parameters.AddWithValue("@contact", m.contact);
            



            cmd.ExecuteNonQuery();
            con.Close();


        }


    }
}
