using Modul2Test_Bojan_Adzic.Models;
using Modul2Test_Bojan_Adzic.Repository.Interfaces;
using System.Data.SqlClient;
using System.Data;

namespace Modul2Test_Bojan_Adzic.Repository
{
    public class RacunarRepository : IRacunarRepository
    {
        IConfiguration Configuration { get; }
        public RacunarRepository(IConfiguration Configuration)
        {
            this.Configuration = Configuration;
        }

        public List<Racunar> GetAll()
        {
            string queryUsers = "SELECT * FROM Racunar;";

            string connectionString = Configuration.GetConnectionString("Racunari");

            SqlConnection connection = new SqlConnection(connectionString);
            SqlCommand command = connection.CreateCommand();

            connection.Open();

            command.CommandText = queryUsers;

            DataSet ds = new DataSet();
            DataTable dt = new DataTable();

            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = command;

            adapter.Fill(ds, "Racunar");
            dt = ds.Tables["Racunar"];

            command.Dispose();
            connection.Close();

            List<Racunar> Racunari = new List<Racunar>();

            foreach (DataRow dr in dt.Rows)
            {
                Racunar r = new Racunar();
                r.Id = int.Parse(dr["Id"].ToString());
                r.Naziv = dr["Naziv"].ToString();
                r.BrojGodinaGarancije = int.Parse(dr["BrojGodinaGarancije"].ToString());
                r.Cena = int.Parse(dr["Cena"].ToString());
                r.Tip = dr["Tip"].ToString();
                r.StudentskiPopust = bool.Parse(dr["StudentskiPopust"].ToString());
                Racunari.Add(r);
            }

            return Racunari;
        }

        public Racunar GetOne(int Id)
        {
            string queryUsers = "SELECT * FROM Racunar WHERE Id=@Id;";

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

            adapter.Fill(ds, "Racunar");
            dt = ds.Tables["Racunar"];

            command.Dispose();
            connection.Close();

            Racunar r = new Racunar();

            foreach (DataRow dr in dt.Rows)
            {
                r.Id = int.Parse(dr["Id"].ToString());
                r.Naziv = dr["Naziv"].ToString();
                r.BrojGodinaGarancije = int.Parse(dr["BrojGodinaGarancije"].ToString());
                r.Cena = int.Parse(dr["Cena"].ToString());
                r.Tip = dr["Tip"].ToString();
                r.StudentskiPopust = bool.Parse(dr["StudentskiPopust"].ToString());
            }

            return r;
        }

        public void Create(Racunar Racunar)
        {
            string query = "INSERT INTO Racunar(Naziv, BrojGodinaGarancije, Cena, Tip, StudentskiPopust) values (@Naziv, @BrojGodinaGarancije, @Cena, @Tip, @StudentskiPopust)";

            string connectionString = Configuration.GetConnectionString("Racunari");

            SqlConnection connection = new SqlConnection(connectionString);
            SqlCommand command = connection.CreateCommand();

            connection.Open();

            command.CommandText = query;
            command.Parameters.AddWithValue("@Id", Racunar.Id);
            command.Parameters.AddWithValue("@Naziv", Racunar.Naziv);
            command.Parameters.AddWithValue("@BrojGodinaGarancije", Racunar.BrojGodinaGarancije);
            command.Parameters.AddWithValue("@Cena", Racunar.Cena);
            command.Parameters.AddWithValue("@Tip", Racunar.Tip);
            command.Parameters.AddWithValue("@StudentskiPopust", Racunar.StudentskiPopust);

            command.ExecuteNonQuery();

            command.Dispose();
            connection.Close();
        }

        public void Delete(int Id)
        {
            string query = "DELETE Racunar WHERE Id = @Id";

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

        public void Edit(Racunar Racunar)
        {
            string query = "UPDATE Racunar SET Naziv = @Naziv, BrojGodinaGarancije = @BrojGodinaGarancije, Cena = @Cena, Tip = @Tip, StudentskiPopust = @StudentskiPopust WHERE Id = @Id";

            string connectionString = Configuration.GetConnectionString("Racunari");

            SqlConnection connection = new SqlConnection(connectionString);
            SqlCommand command = connection.CreateCommand();

            connection.Open();

            command.CommandText = query;
            command.Parameters.AddWithValue("@Id", Racunar.Id);
            command.Parameters.AddWithValue("@Naziv", Racunar.Naziv);
            command.Parameters.AddWithValue("@BrojGodinaGarancije", Racunar.BrojGodinaGarancije);
            command.Parameters.AddWithValue("@Cena", Racunar.Cena);
            command.Parameters.AddWithValue("@Tip", Racunar.Tip);
            command.Parameters.AddWithValue("@StudentskiPopust", Racunar.StudentskiPopust);

            command.ExecuteNonQuery();

            command.Dispose();
            connection.Close();
        }
    }
}
