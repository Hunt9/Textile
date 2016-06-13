using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.IO;
using Microsoft.VisualBasic;
using Microsoft.SqlServer;


namespace SeC_E
{
    class DAL
    {
        

        SqlConnection con = new SqlConnection(@"Data Source=AHMAD\SQLSERVER;Initial Catalog=cotton;Integrated Security=True ");
        public bool login(string myname,string mypw) 
        {

            con.Open();
            string s = "select u_name,u_pass from uzerz where u_name='"+myname+"'and u_pass='"+mypw+"'     ";
            SqlCommand com = new SqlCommand(s,con);
            SqlDataReader rdr;
            rdr = com.ExecuteReader();
          return  rdr.Read();


        }
        public void insert(string myname, string myemail, string mypass, string mycontact) 
        {
            con.Close();
            string s = "insert into uzerz values('" + myname + "','" + myemail + "','" + mypass + "','" + mycontact + "') ";
            SqlCommand com = new SqlCommand(s,con);
            con.Open();
            com.ExecuteNonQuery();
            con.Close();
        }
        public void del(int myuid)
        {
            con.Close();
     
            string s = "delete from uzerz where u_id='"+myuid+"' ";
            SqlCommand com = new SqlCommand(s, con);
            con.Open();
            com.ExecuteNonQuery();
            con.Close();
        }
        public void update(string myname, string myemail, string mypass, string mycontact, int myid)
        {
            con.Close();
            string s = " update uzerz set u_name='" + myname + "',u_email='" + myemail + "',u_pass='" + mypass + "',u_contact='" + mycontact + "'where u_id='" + myid + "' ";
            SqlCommand com = new SqlCommand(s, con);
            con.Open();
            com.ExecuteNonQuery();
            con.Close();
        }


        public void insertp(string pname, string ptype, string psize,int q)
        {
            con.Close();
            string s = "insert into product values('" + pname + "','" + ptype + "','" + psize + "','" + q + "') ";
            SqlCommand com = new SqlCommand(s, con);
            con.Open();
            com.ExecuteNonQuery();
            con.Close();
        }

        public void delp(int myuid)
        {
            con.Close();
            string s = "delete from product where p_id='" + myuid + "' ";
            SqlCommand com = new SqlCommand(s, con);
            con.Open();
            com.ExecuteNonQuery();
            con.Close();
        }
        public void updatep(string myname, string myemail, string mypass, int myid, int q)
        {
            con.Close();
            string s = " update product set p_name='" + myname + "',p_type='" + myemail + "',p_size='" + mypass + "',p_quantity='" + myid + "'where p_id='" + q + "' ";
            SqlCommand com = new SqlCommand(s, con);
            con.Open();
            com.ExecuteNonQuery();
            con.Close();
        }

       

        public void updates(int sq,int sq1)
        {
            con.Close();
            string s = " update product set p_quantity='" + sq + "' where p_id= '" + sq1 + "' ";
            SqlCommand com = new SqlCommand(s, con);
            con.Open();
            com.ExecuteNonQuery();
            con.Close();
        }


        public void insl(int lot,string cname,int cquan,int price,string date)
        {
            con.Close();
            string s = "insert into lot values('" + lot + "','" + cname + "','" + cquan + "','" + price + "','" + date + "') ";
            SqlCommand com = new SqlCommand(s, con);
            con.Open();
            com.ExecuteNonQuery();
            con.Close();
        }

        public void updl(string cname,int quan, int price,string date,int l)
        {
            con.Close();
            string s = " update lot set l_com='" + cname + "',l_quan='" + quan + "',l_price='" + price + "',l_date='" + date + "'where l_id='" + l + "' ";
            SqlCommand com = new SqlCommand(s, con);
            con.Open();
            com.ExecuteNonQuery();
            con.Close();
        }

        public void dell(int ln)
        {
            con.Close();
            string s = "delete from lot where l_id='" + ln + "' ";
            SqlCommand com = new SqlCommand(s, con);
            con.Open();
            com.ExecuteNonQuery();
            con.Close();
        }

        public void insc(byte[] im ,int w, int h, string color,int lot)
        {
            con.Close();
            string s = "insert into cloth (c_im,c_width,c_hight,c_color,l_id) values('" + im + "','" + w + "','" + h + "','" + color + "','" + lot + "') ";
            SqlCommand com = new SqlCommand(s, con);
            con.Open();
            com.ExecuteNonQuery();
            con.Close();
        }

       




    }
}
