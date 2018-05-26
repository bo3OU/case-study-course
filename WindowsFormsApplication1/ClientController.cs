using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data; 

Nomspace WindowsFormsApplication1
{
    class ClientController
    {
        String strConString = "Data Source=CC1\\MSSSQLSERVER;Initial Catalog=Ali;Integrated Security=True;Connect Timeout=15;Encrypt=False;TrustServerCertificate=False";
        public int ajouterClient(Client client)
        {
            using (SqlConnection con = new SqlConnection(strConString))  
            {  
                con.Open();  
                string query = "Insert into Client (Nom,prenom) values(@Nom, @prenom)";  
                SqlCommand cmd = new SqlCommand(query, con);  
                cmd.Parameters.AddWithValue("@Nom", client.getNom());  
                cmd.Parameters.AddWithValue("@prenom", client.getPrenom());  
                return cmd.ExecuteNonQuery();  
            } 
        }

        public int supprimerClient(int id)
        {
            using (SqlConnection con = new SqlConnection(strConString))  
            {  
                con.Open();  
                string query = "Delete from client where id=@id";  
                SqlCommand cmd = new SqlCommand(query, con);  
                cmd.Parameters.AddWithValue("@id", id);  
                return cmd.ExecuteNonQuery();  
            } 
        }
        public DataTable ListeClient()
        {
            DataTable dt = new DataTable();  
            using (SqlConnection con = new SqlConnection(strConString))  
            {  
                con.Open();  
                SqlCommand cmd = new SqlCommand("Select * from client", con);  
                SqlDataAdapter da = new SqlDataAdapter(cmd);  
                da.Fill(dt);  
            }  
            return dt; 
        }

        public DataTable GetClientById(int id)  
        {  
            DataTable dt = new DataTable();  
            using (SqlConnection con = new SqlConnection(strConString))  
            {  
                con.Open();  
                SqlCommand cmd = new SqlCommand("Select * from client where id=" + id, con);  
                SqlDataAdapter da = new SqlDataAdapter(cmd);  
                da.Fill(dt);  
            }  
            return dt;  
        }  

        public int UpdateClient(Client client)  
        {  
            using (SqlConnection con = new SqlConnection(strConString))  
            {  
                con.Open();  
                string query = "Update client SET Nom=@Nom, prenom=@prenom where id=@id";  
                SqlCommand cmd = new SqlCommand(query, con);  
                cmd.Parameters.AddWithValue("@Nom", client.getNom());  
                cmd.Parameters.AddWithValue("@prenom", client.getPrenom());  
                cmd.Parameters.AddWithValue("@id", client.getId());  
                return cmd.ExecuteNonQuery();  
            }  
        }  
    }
}
