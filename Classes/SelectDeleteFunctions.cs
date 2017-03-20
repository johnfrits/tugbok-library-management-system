using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace MPosInfoManagementSystem
{
    class SelectDeleteFunctions : ConnectionString
    {
        SqlCommand command = new SqlCommand();
        public SelectDeleteFunctions()
        {
            try
            {
                Connection();
                command = new SqlCommand();
                command = connection.CreateCommand();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                throw;
            }
        }
        public object GetFingerPrints(int detaineNo)
        {
            command.CommandText = "SELECT * FROM Fingerprints WHERE DetaineeNo = @DetaineeNo";
            command.CommandType = CommandType.Text;

            command.Parameters.AddWithValue("@DetaineeNo", detaineNo);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable dTable = new DataTable();

            adapter.Fill(dTable);

            return dTable;
        }
        public object GetActivityLogging()
        {
            command.CommandText = "SELECT * FROM ActivityLogging";
            command.CommandType = CommandType.Text;

            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable dTable = new DataTable();

            adapter.Fill(dTable);

            return dTable;
        }
        public object GetIncidentFiledCases()
        {
            command.CommandText = "SELECT TypeofIncident, COUNT(EntryNumber) FROM IncidentRecord GROUP BY TypeofIncident";
            command.CommandType = CommandType.Text;

            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable dTable = new DataTable();

            adapter.Fill(dTable);

            return dTable;
        }
        public string CountDetainee()
        {
            command.CommandText = "SELECT COUNT(DetaineeNo) FROM Detainee WHERE Status = @ss";
            command.CommandType = CommandType.Text;
            connection.Open();

            command.Parameters.Clear();
            command.Parameters.AddWithValue("@ss", "Detainee");
            var data = command.ExecuteScalar();

            connection.Close();
            command.Dispose();

            return data.ToString();
        }
        public string CountReleasedDetainee()
        {
            command.CommandText = "SELECT COUNT(DetaineeNo) FROM ReleasedDetainees";
            command.CommandType = CommandType.Text;
            connection.Open();

            var data = command.ExecuteScalar();

            connection.Close();
            command.Dispose();

            return data.ToString();
        }
        public string CountSuspect()
        {
            command.CommandText = "SELECT COUNT(SuspectNo) FROM Suspect WHERE Status = @ss";
            command.CommandType = CommandType.Text;
            connection.Open();

            command.Parameters.Clear();
            command.Parameters.AddWithValue("@ss", "Suspect");
            var data = command.ExecuteScalar();

            connection.Close();
            command.Dispose();

            return data.ToString();
        }
        public int RecentLogNo()
        {
            int logNo;

            command.CommandText = "SELECT MAX(LogNo) FROM ActivityLogging";
            command.CommandType = CommandType.Text;
            connection.Open();


            var l = command.ExecuteScalar();
            logNo = Convert.ToInt32(l);

            connection.Close();
            command.Dispose();
            return logNo;
        }
        public int RecentEntryNumber()
        {
            int logNo;

            command.CommandText = "SELECT MAX(EntryNumber) FROM IncidentRecord";
            command.CommandType = CommandType.Text;
            connection.Open();


            var l = command.ExecuteScalar();
            logNo = Convert.ToInt32(l);

            connection.Close();
            command.Dispose();
            return logNo;
        }
        public bool UserSearch(string personnelId, string password)
        {
            bool LoginState = false;

            command.CommandText = "SELECT * FROM [Users] WHERE PersonnelID = @personnelID AND Password = @password";
            command.CommandType = CommandType.Text;
            connection.Open();

            command.Parameters.Clear();
            command.Parameters.AddWithValue("@personnelID", personnelId);
            command.Parameters.AddWithValue("@password", password);

            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                if (reader.HasRows)
                        LoginState = true;
            }
            if (!reader.HasRows)
            {
                connection.Close();
                command.Dispose();
                reader.Close();
            }

            return LoginState;
        }
        public string GetCrimeIncident(int entryNumber)
        {
           string s = "";
            try
            {
                command.CommandText = "SELECT TypeofIncident FROM [IncidentRecord] WHERE EntryNumber = @EntryNumber";
                command.CommandType = CommandType.Text;
                connection.Open();

                command.Parameters.Clear();
                command.Parameters.AddWithValue("@EntryNumber", entryNumber);

                var crimeIncident = command.ExecuteScalar();
                s = crimeIncident.ToString();

                connection.Close();
                command.Dispose();

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

            return s;
        }
        public bool CheckIfSuspectExist(int entryNumber)
        {
            bool exist = false;
            try
            {
                command.CommandText = "SELECT * FROM [Suspect] WHERE EntryNumber = @EntryNumber";
                command.CommandType = CommandType.Text;
                connection.Open();

                command.Parameters.Clear();
                command.Parameters.AddWithValue("@EntryNumber", entryNumber);
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    if (reader.HasRows)
                        exist = true;
                }
                connection.Close();
                command.Dispose();
                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

            return exist;
        }
        public object GetAllIncidents()
        {
            command.CommandText = "SELECT * FROM[IncidentRecord]";
            command.CommandType = CommandType.Text;

            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable dTable = new DataTable();

            adapter.Fill(dTable);

            return dTable;
        }

        public object GetSuspect(int EntryNumber)
        {
            command.CommandText = "SELECT * FROM[Suspect] WHERE EntryNumber = @en";
            command.CommandType = CommandType.Text;

            command.Parameters.Clear();
            command.Parameters.AddWithValue("@en", EntryNumber);

            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable dTable = new DataTable();

            adapter.Fill(dTable);


            return dTable;
        }
        public object GetAllDetainee(string stats)
        {
            command.CommandText = "SELECT * FROM[Detainee] WHERE Status = @status";
            command.CommandType = CommandType.Text;

            command.Parameters.Clear();
            command.Parameters.AddWithValue("@status", stats);

            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable dTable = new DataTable();

            adapter.Fill(dTable);


            return dTable;
        }
        public object GetDetainedSuspect(int EntryNumber)
        {
            command.CommandText = "SELECT * FROM[Suspect] WHERE EntryNumber = @en AND Status = @st";
            command.CommandType = CommandType.Text;

            command.Parameters.Clear();
            command.Parameters.AddWithValue("@st", "Suspect");
            command.Parameters.AddWithValue("@en", EntryNumber);

            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable dTable = new DataTable();

            adapter.Fill(dTable);


            return dTable;
        }
        public object GetReleasedDetainee()
        {
            command.CommandText = "SELECT * FROM[Detainee] WHERE Status = @ss";
            command.CommandType = CommandType.Text;

            command.Parameters.Clear();
            command.Parameters.AddWithValue("@ss", "Released");

            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable dTable = new DataTable();

            adapter.Fill(dTable);


            return dTable;
        }
        public List<object> GetRD(int dNo)
        {
          
            var data = new List<object>();
            try
            {
                command.CommandText = "SELECT * FROM[ReleasedDetainees] WHERE DetaineeNo = @dNO";
                command.CommandType = CommandType.Text;
                connection.Open();

                command.Parameters.Clear();
                command.Parameters.AddWithValue("@dNo", dNo);

                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    if (reader.HasRows)
                    {
                        data.Add(reader["DateTimeReleased"].ToString());
                        data.Add(reader["Reason"].ToString());
                    }
                }

                connection.Close();
                command.Dispose();
            }
        
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            return data;
        }
        public object GetDetainee(int EntryNumber)
        {
            command.CommandText = "SELECT * FROM[Detainee] WHERE EntryNumber = @en";
            command.CommandType = CommandType.Text;

            command.Parameters.Clear();
            command.Parameters.AddWithValue("@en", EntryNumber);

            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable dTable = new DataTable();

            adapter.Fill(dTable);


            return dTable;
        }
        public object GetMugshots(int d1)
        {
            command.CommandText = "SELECT * FROM [DetaineeMugshot] WHERE DetaineeNo = @d1";
            command.CommandType = CommandType.Text;


            command.Parameters.Clear();
            command.Parameters.AddWithValue("@d1", d1);

            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable dTable = new DataTable();

            adapter.Fill(dTable);
            return dTable;
        }
        public string GetPersonnelName(int PersonnelID)
        {
            command.CommandText = "SELECT [Name] FROM [Personnel] WHERE PersonnelID = @pID";
            command.CommandType = CommandType.Text;
            connection.Open();

            command.Parameters.Clear();
            command.Parameters.AddWithValue("@pID", PersonnelID);

            var pName = command.ExecuteScalar();

            connection.Close();
            command.Dispose();

            return pName.ToString();
        }
        public object GetAllPersonnel()
        {
            command.CommandText = "SELECT * FROM [Personnel]";
            command.CommandType = CommandType.Text;

            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable dTable = new DataTable();
            adapter.Fill(dTable);

            return dTable;
        }
        public Byte[] PersonnelPic(int pID)
        {
            command.CommandText = "SELECT[Picture] FROM [PersonnelPic] WHERE PersonnelID = @pID";
            command.CommandType = CommandType.Text;
            connection.Open();

            command.Parameters.Clear();
            command.Parameters.AddWithValue("@pID", pID);

            var pic = (Byte[])(command.ExecuteScalar());

            connection.Close();
            command.Dispose();

            return pic;
        }
        public object GetReportingPerson(int reportingPerson)
        {

            command.CommandText = "SELECT * FROM [ReportingPerson] WHERE ReportingPersonNo = @rp";
            command.CommandType = CommandType.Text;

            command.Parameters.Clear();
            command.Parameters.AddWithValue("rp", reportingPerson);

            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable dTable = new DataTable();

            adapter.Fill(dTable);

            return dTable;
        }
        public object GetVictim(int EntryNumber)
        {
            command.CommandText = "SELECT * FROM[Victim] WHERE EntryNumber = @en";
            command.CommandType = CommandType.Text;

            command.Parameters.Clear();
            command.Parameters.AddWithValue("@en", EntryNumber);

            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable dTable = new DataTable();

            adapter.Fill(dTable);


            return dTable;
        }
        public bool CheckExistingPassword(int personnelID, string password)
        {
            bool checkExisting = false;

            try
            {
                command.CommandText = "SELECT [Password] FROM [Users] WHERE PersonnelID = @pId and Password = @pw";
                command.CommandType = CommandType.Text;
                connection.Open();

                command.Parameters.Clear();
                command.Parameters.AddWithValue("@pID", personnelID);
                command.Parameters.AddWithValue("@pw", password);

                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    if (reader.HasRows)
                    {
                        checkExisting = true;
                    }
                }
                connection.Close();
                command.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

            return checkExisting;
        }
        public bool CheckExistPidFromPersonnel(int personnelID)
        {
            bool checkavailable = false;
            try
            {
                command.CommandText = "SELECT[PersonnelID] FROM [Personnel] WHERE PersonnelID = @pId";
                command.CommandType = CommandType.Text;
                connection.Open();

                command.Parameters.Clear();
                command.Parameters.AddWithValue("@pId", personnelID);

                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    if (reader.HasRows)
                        checkavailable = true;
                }
                reader.Close();
                command.Dispose();
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            return checkavailable;
        }
        public bool CheckUsersPersonnelID(int personnelID)
        {
            bool checkavailable = false;
            try
            {
                command.CommandText = "SELECT[PersonnelID] FROM [Users] WHERE PersonnelID = @pId";
                command.CommandType = CommandType.Text;
                connection.Open();

                command.Parameters.Clear();
                command.Parameters.AddWithValue("@pId", personnelID);

                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    if (reader.HasRows)
                        checkavailable = true;
                }

                reader.Close();
                command.Dispose();
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            return checkavailable;
        }
        public List<object> GetPersonnel(int personnelID)
        {
            var data = new List<object>();
            try
            {
                command.CommandText = "SELECT [Rank],[Name],[PersonnelPic].[Picture] FROM [Personnel],[PersonnelPic] WHERE Personnel.PersonnelID = @pID AND PersonnelPic.PersonnelID = @pID";
                command.CommandType = CommandType.Text;
                connection.Open();

                command.Parameters.Clear();
                command.Parameters.AddWithValue("@pID", personnelID);

                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    if (reader.HasRows)
                    {
                        data.Add(reader["Rank"].ToString());
                        data.Add(reader["Name"].ToString());
                        data.Add(reader["Picture"]);
                    }
                }
              
                command.Dispose();
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

            return data;
        }
        public object GetBlotter()
        {
            command.CommandText = "SELECT EntryNumber, Narrative FROM IncidentRecord";
            command.CommandType = CommandType.Text;

            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable dTable = new DataTable();

            adapter.Fill(dTable);

            return dTable;
        }
     











        //
        public void DeleteSuspect(int suspectNo)
        {
            try
            {
                command.CommandText = "DELETE FROM[Suspect] WHERE SuspectNo = @sn";
                command.CommandType = CommandType.Text;
                connection.Open();

                command.Parameters.Clear();
                command.Parameters.AddWithValue("@sn", suspectNo);

                command.ExecuteNonQuery();
                connection.Close();
                command.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        public void DeleteVictim(int victimNo)
        {
            try
            {
                command.CommandText = "DELETE FROM[Victim] WHERE SuspectNo = @vn";
                command.CommandType = CommandType.Text;
                connection.Open();

                command.Parameters.Clear();
                command.Parameters.AddWithValue("@vn", victimNo);

                command.ExecuteNonQuery();
                connection.Close();
                command.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        public void DeleteDetainee(int detaineeNo)
        {
            try
            {
                command.CommandText = "DELETE FROM[Detainee] WHERE DetaineeNo = @sn";
                command.CommandType = CommandType.Text;
                connection.Open();

                command.Parameters.Clear();
                command.Parameters.AddWithValue("@sn", detaineeNo);

                command.ExecuteNonQuery();
                connection.Close();
                command.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        public void RemoveSuspectAndVictim(int entryNumber)
        {
            try
            {
                command.CommandText = "DELETE FROM[Suspect] WHERE EntryNumber = @en; DELETE FROM[Victim] WHERE EntryNumber = @en";
                command.CommandType = CommandType.Text;
                connection.Open();

                command.Parameters.Clear();
                command.Parameters.AddWithValue("@en", entryNumber);

                command.ExecuteNonQuery();
                connection.Close();
                command.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        public void RemoveVictim(int entryNumber)
        {
            try
            {
                command.CommandText = "DELETE FROM[Victim] WHERE EntryNumber = @en";
                command.CommandType = CommandType.Text;
                connection.Open();

                command.Parameters.Clear();
                command.Parameters.AddWithValue("@en", entryNumber);

                command.ExecuteNonQuery();
                connection.Close();
                command.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        public void RemoveSuspect(int entryNumber)
        {
            try
            {
                command.CommandText = "DELETE FROM[Suspect] WHERE EntryNumber = @en";
                command.CommandType = CommandType.Text;
                connection.Open();

                command.Parameters.Clear();
                command.Parameters.AddWithValue("@en", entryNumber);

                command.ExecuteNonQuery();
                connection.Close();
                command.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
