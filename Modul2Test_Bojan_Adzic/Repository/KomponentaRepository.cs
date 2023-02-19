using Modul2Test_Bojan_Adzic.Models;
using Modul2Test_Bojan_Adzic.Repository.Interfaces;
using System.Data;
using System.Data.SqlClient;

namespace Modul2Test_Bojan_Adzic.Repository
{
    public class KomponentaRepository : IKomponentaRepository
    {
        IConfiguration Configuration { get; }
        public KomponentaRepository(IConfiguration Configuration)
        {
            this.Configuration = Configuration;
        }

        public List<Komponenta> GetAll(int RacunarId)
        {
            string queryUsers = "SELECT * FROM Komponenta WHERE RacunarId = @RacunarId;";

            string connectionString = Configuration.GetConnectionString("Racunari");

            SqlConnection connection = new SqlConnection(connectionString);
            SqlCommand command = connection.CreateCommand();
            command.Parameters.AddWithValue("@RacunarId", RacunarId);

            connection.Open();

            command.CommandText = queryUsers;

            DataSet ds = new DataSet();
            DataTable dt = new DataTable();

            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = command;

            adapter.Fill(ds, "Komponenta");
            dt = ds.Tables["Komponenta"];

            command.Dispose();
            connection.Close();

            List<Komponenta> Komponente = new List<Komponenta>();

            foreach (DataRow dr in dt.Rows)
            {
                Komponenta k = new Komponenta();
                k.Id = int.Parse(dr["Id"].ToString());
                k.Ime = dr["Ime"].ToString();
                k.GodinaProizvodnje = int.Parse(dr["GodinaProizvodnje"].ToString());
                k.Tip = dr["Tip"].ToString();
                k.RacunarId = int.Parse(dr["RacunarId"].ToString());
                Komponente.Add(k);
            }

            return Komponente;
        }

        public Komponenta GetOne(int Id)
        {
            string queryUsers = "SELECT * FROM Komponenta WHERE Id = @Id;";

            string connectionString = Configuration.GetConnectionString("Racunari");

            SqlConnection connection = new SqlConnection(connectionString);
            SqlCommand command = connection.CreateCommand();
            command.Parameters.AddWithValue("@Id", Id);

            connection.Open();

            command.CommandText = queryUsers;

            DataSet ds = new DataSet();
            DataTable dt = new DataTable();

            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = command;

            adapter.Fill(ds, "Komponenta");
            dt = ds.Tables["Komponenta"];

            command.Dispose();
            connection.Close();

            Komponenta k = new Komponenta();

            foreach (DataRow dr in dt.Rows)
            {
                k.Id = int.Parse(dr["Id"].ToString());
                k.Ime = dr["Ime"].ToString();
                k.GodinaProizvodnje = int.Parse(dr["GodinaProizvodnje"].ToString());
                k.Tip = dr["Tip"].ToString();
                k.RacunarId = int.Parse(dr["RacunarId"].ToString());
            }

            return k;
        }

        public void Create(Komponenta Komponenta)
        {
            string query = "INSERT INTO Komponenta(Ime, GodinaProizvodnje, Tip, RacunarId) values (@Ime, @GodinaProizvodnje, @Tip, @RacunarId)";

            string connectionString = Configuration.GetConnectionString("Racunari");

            SqlConnection connection = new SqlConnection(connectionString);
            SqlCommand command = connection.CreateCommand();

            connection.Open();

            command.CommandText = query;
            command.Parameters.AddWithValue("@Ime", Komponenta.Ime);
            command.Parameters.AddWithValue("@GodinaProizvodnje", Komponenta.GodinaProizvodnje);
            command.Parameters.AddWithValue("@Tip", Komponenta.Tip);
            command.Parameters.AddWithValue("@RacunarId", Komponenta.RacunarId);

            command.ExecuteNonQuery();

            command.Dispose();
            connection.Close();
        }

        public void Delete(int Id)
        {
            string query = "DELETE Komponenta WHERE Id = @Id";

            string connectionString = Configuration.GetConnectionString("Racunari");

            SqlConnection connection = new SqlConnection(connectionString);
            SqlCommand command = connection.CreateCommand();

            connection.Open();

            command.CommandText = query;
            command.Parameters.AddWithValue("@Id", Id);

            command.ExecuteNonQuery();

            command.Dispose();
            connection.Close();
        }

        public void Edit(Komponenta Komponenta)
        {
            throw new NotImplementedException();
        }

        public List<Komponenta> Ovogodisnje(int RacunarId)
        {
            string queryUsers = "SELECT * FROM Komponenta WHERE RacunarId = @RacunarId AND GodinaProizvodnje = 2023;";

            string connectionString = Configuration.GetConnectionString("Racunari");

            SqlConnection connection = new SqlConnection(connectionString);
            SqlCommand command = connection.CreateCommand();
            command.Parameters.AddWithValue("@RacunarId", RacunarId);

            connection.Open();

            command.CommandText = queryUsers;

            DataSet ds = new DataSet();
            DataTable dt = new DataTable();

            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = command;

            adapter.Fill(ds, "Komponenta");
            dt = ds.Tables["Komponenta"];

            command.Dispose();
            connection.Close();

            List<Komponenta> Komponente = new List<Komponenta>();

            foreach (DataRow dr in dt.Rows)
            {
                Komponenta k = new Komponenta();
                k.Id = int.Parse(dr["Id"].ToString());
                k.Ime = dr["Ime"].ToString();
                k.GodinaProizvodnje = int.Parse(dr["GodinaProizvodnje"].ToString());
                k.Tip = dr["Tip"].ToString();
                k.RacunarId = int.Parse(dr["RacunarId"].ToString());
                Komponente.Add(k);
            }

            return Komponente;
        }

        public List<Komponenta> SortImeRastuce(int RacunarId)
        {
            string queryUsers = "SELECT * FROM Komponenta WHERE RacunarId = @RacunarId ORDER BY Ime;";

            string connectionString = Configuration.GetConnectionString("Racunari");

            SqlConnection connection = new SqlConnection(connectionString);
            SqlCommand command = connection.CreateCommand();
            command.Parameters.AddWithValue("@RacunarId", RacunarId);

            connection.Open();

            command.CommandText = queryUsers;

            DataSet ds = new DataSet();
            DataTable dt = new DataTable();

            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = command;

            adapter.Fill(ds, "Komponenta");
            dt = ds.Tables["Komponenta"];

            command.Dispose();
            connection.Close();

            List<Komponenta> Komponente = new List<Komponenta>();

            foreach (DataRow dr in dt.Rows)
            {
                Komponenta k = new Komponenta();
                k.Id = int.Parse(dr["Id"].ToString());
                k.Ime = dr["Ime"].ToString();
                k.GodinaProizvodnje = int.Parse(dr["GodinaProizvodnje"].ToString());
                k.Tip = dr["Tip"].ToString();
                k.RacunarId = int.Parse(dr["RacunarId"].ToString());
                Komponente.Add(k);
            }

            return Komponente;
        }

        public List<Komponenta> SortImeOpadajuce(int RacunarId)
        {
            string queryUsers = "SELECT * FROM Komponenta WHERE RacunarId = @RacunarId ORDER BY Ime DESC;";

            string connectionString = Configuration.GetConnectionString("Racunari");

            SqlConnection connection = new SqlConnection(connectionString);
            SqlCommand command = connection.CreateCommand();
            command.Parameters.AddWithValue("@RacunarId", RacunarId);

            connection.Open();

            command.CommandText = queryUsers;

            DataSet ds = new DataSet();
            DataTable dt = new DataTable();

            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = command;

            adapter.Fill(ds, "Komponenta");
            dt = ds.Tables["Komponenta"];

            command.Dispose();
            connection.Close();

            List<Komponenta> Komponente = new List<Komponenta>();

            foreach (DataRow dr in dt.Rows)
            {
                Komponenta k = new Komponenta();
                k.Id = int.Parse(dr["Id"].ToString());
                k.Ime = dr["Ime"].ToString();
                k.GodinaProizvodnje = int.Parse(dr["GodinaProizvodnje"].ToString());
                k.Tip = dr["Tip"].ToString();
                k.RacunarId = int.Parse(dr["RacunarId"].ToString());
                Komponente.Add(k);
            }

            return Komponente;
        }
    }
}
