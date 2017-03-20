using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Windows.Forms;
using System.Data;
using MetroFramework.Controls;

namespace MPosInfoManagementSystem
{
    class InsertUpdateFunctions : ConnectionString
    {
        SqlCommand command = new SqlCommand();
        public InsertUpdateFunctions()
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

        public void InsertFingerPrints(int detaineeNo, byte[] Rthumb, byte[] Lthumb)
        {
            try
            {
                command.CommandText = "INSERT INTO[Fingerprints] VALUES(@DetaineeNo, @RThumb, @LThumb)";
                command.CommandType = CommandType.Text;
                connection.Open();

                command.Parameters.Clear();
                command.Parameters.AddWithValue("@DetaineeNo", detaineeNo);
                command.Parameters.AddWithValue("@RThumb", Rthumb);
                command.Parameters.AddWithValue("@LThumb", Lthumb);

                command.ExecuteNonQuery();
                connection.Close();
                command.Dispose();
            }
            catch (Exception ex)
            {
                ex.ToString();
            }


        }
        public void ReportingPersonInsert(int reportingPerson, int entryNumber, string lastName, string firstName, string middleName, string nickName, string sex, string status,
                                          string DOB, int age, string POB, string mobileNo, string address, string occupation, string emailAd, string idCard)
        {
            try
            {
                command.CommandText = "INSERT INTO[ReportingPerson] VALUES(@ReportingPersonNo, @EntryNumber, @LastName, @FirstName, @MiddleName, @NickName, @Sex, @Status, @DOB, @Age, @POB, @MobileNo, @Address, @Occupation, @EmailAddress, @IDCard)";
                command.CommandType = CommandType.Text;
                connection.Open();

                command.Parameters.Clear();
                command.Parameters.AddWithValue("@ReportingPersonNo", reportingPerson);
                command.Parameters.AddWithValue("@EntryNumber", entryNumber);
                command.Parameters.AddWithValue("@LastName", lastName);
                command.Parameters.AddWithValue("@FirstName", firstName);
                command.Parameters.AddWithValue("@MiddleName", nickName);
                command.Parameters.AddWithValue("@NickName", nickName);
                command.Parameters.AddWithValue("@Sex", sex);
                command.Parameters.AddWithValue("@Status", status);
                command.Parameters.AddWithValue("@DOB", DOB);
                command.Parameters.AddWithValue("@Age", age);
                command.Parameters.AddWithValue("@POB", POB);
                command.Parameters.AddWithValue("@MobileNo", mobileNo);
                command.Parameters.AddWithValue("@Address", address);
                command.Parameters.AddWithValue("@Occupation", occupation);
                command.Parameters.AddWithValue("@EmailAddress", emailAd);
                command.Parameters.AddWithValue("@IDCard", idCard);

                command.ExecuteNonQuery();
                connection.Close();
                command.Dispose();
            }
            catch (Exception ex)
            {
                ex.ToString();
            }
            finally
            {
                connection.Close();
            }
        }

        public void VictimInsert(int victimNo, int entryNumber, string lastName, string firstName, string middleName, string nickName, string sex, string status,
                                       string DOB, int age, string POB, string mobileNo, string address, string occupation, string emailAd, string idCard)
        {
            try
            {
                command.CommandText = "INSERT INTO[Victim] VALUES(@VictimNo, @EntryNumber, @LastName, @FirstName, @MiddleName, @NickName, @Sex, @Status, @DOB, @Age, @POB, @MobileNo, @Address, @Occupation, @EmailAddress, @IDCard)";
                command.CommandType = CommandType.Text;
                connection.Open();

                command.Parameters.Clear();
                command.Parameters.AddWithValue("@VictimNo", victimNo);
                command.Parameters.AddWithValue("@EntryNumber", entryNumber);
                command.Parameters.AddWithValue("@LastName", lastName);
                command.Parameters.AddWithValue("@FirstName", firstName);
                command.Parameters.AddWithValue("@MiddleName", nickName);
                command.Parameters.AddWithValue("@NickName", nickName);
                command.Parameters.AddWithValue("@Sex", sex);
                command.Parameters.AddWithValue("@Status", status);
                command.Parameters.AddWithValue("@DOB", DOB);
                command.Parameters.AddWithValue("@Age", age);
                command.Parameters.AddWithValue("@POB", POB);
                command.Parameters.AddWithValue("@MobileNo", mobileNo);
                command.Parameters.AddWithValue("@Address", address);
                command.Parameters.AddWithValue("@Occupation", occupation);
                command.Parameters.AddWithValue("@EmailAddress", emailAd);
                command.Parameters.AddWithValue("@IDCard", idCard);

                command.ExecuteNonQuery();
                connection.Close();
                command.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                connection.Close();
            }
        }

        public void SuspectInsert(int s1, int s2, string s3, string s4, string s5, string s6, string s7,
                                  string s8, string s9, string s10, int s11, string s12, string s13,
                                  string s14, string s15, string s16, string s17, string s18, string s19, string s20, string s21)
        {
            try
            {
                command.CommandText = "INSERT INTO [Suspect] VALUES(@s1, @s2, @s3, @s4, @s5, @s6, @s7, @s8, @s9, @s10, @s11, @s12, @s13, @s14, @s15, @s16, @s17, @s18, @s19, @s20, @s21)";
                command.CommandType = CommandType.Text;
                connection.Open();

                command.Parameters.Clear();
                command.Parameters.AddWithValue("@s1", s1);
                command.Parameters.AddWithValue("@s2", s2);
                command.Parameters.AddWithValue("@s3", s3);
                command.Parameters.AddWithValue("@s4", s4);
                command.Parameters.AddWithValue("@s5", s5);
                command.Parameters.AddWithValue("@s6", s6);
                command.Parameters.AddWithValue("@s7", s7);
                command.Parameters.AddWithValue("@s8", s8);
                command.Parameters.AddWithValue("@s9", s9);
                command.Parameters.AddWithValue("@s10", s10);
                command.Parameters.AddWithValue("@s11", s11);
                command.Parameters.AddWithValue("@s12", s12);
                command.Parameters.AddWithValue("@s13", s13);
                command.Parameters.AddWithValue("@s14", s14);
                command.Parameters.AddWithValue("@s15", s15);
                command.Parameters.AddWithValue("@s16", s16);
                command.Parameters.AddWithValue("@s17", s17);
                command.Parameters.AddWithValue("@s18", s18);
                command.Parameters.AddWithValue("@s19", s19);
                command.Parameters.AddWithValue("@s20", s20);
                command.Parameters.AddWithValue("@s21", s21);

                command.ExecuteNonQuery();
                connection.Close();
                command.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                connection.Close();
            }
        }

        public void DetaineeInsert(int s1, int s2, string s3, string s4, string s5, string s6, string s7,
                                string s8, string s9, string s10, int s11, string s12, string s13,
                                string s14, string s15, string s16, string s17, string s18, string s19,
                                string s20, string s21, string s22, string s23)
        {
            try
            {
                command.CommandText = "INSERT INTO [Detainee] VALUES(@s1, @s2, @s3, @s4, @s5, @s6, @s7, @s8, @s9, @s10, @s11, @s12, @s13, @s14, @s15, @s16, @s17, @s18, @s19, @s20, @s21, @s22, @s23)";
                command.CommandType = CommandType.Text;
                connection.Open();

                command.Parameters.Clear();
                command.Parameters.AddWithValue("@s1", s1);
                command.Parameters.AddWithValue("@s2", s2);
                command.Parameters.AddWithValue("@s3", s3);
                command.Parameters.AddWithValue("@s4", s4);
                command.Parameters.AddWithValue("@s5", s5);
                command.Parameters.AddWithValue("@s6", s6);
                command.Parameters.AddWithValue("@s7", s7);
                command.Parameters.AddWithValue("@s8", s8);
                command.Parameters.AddWithValue("@s9", s9);
                command.Parameters.AddWithValue("@s10", s10);
                command.Parameters.AddWithValue("@s11", s11);
                command.Parameters.AddWithValue("@s12", s12);
                command.Parameters.AddWithValue("@s13", s13);
                command.Parameters.AddWithValue("@s14", s14);
                command.Parameters.AddWithValue("@s15", s15);
                command.Parameters.AddWithValue("@s16", s16);
                command.Parameters.AddWithValue("@s17", s17);
                command.Parameters.AddWithValue("@s18", s18);
                command.Parameters.AddWithValue("@s19", s19);
                command.Parameters.AddWithValue("@s20", s20);
                command.Parameters.AddWithValue("@s21", s21);
                command.Parameters.AddWithValue("@s22", s22);
                command.Parameters.AddWithValue("@s23", s23);

                command.ExecuteNonQuery();
                connection.Close();
                command.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                connection.Close();
            }
        }

        public void InsertDetaineeMugshots(int d, byte[] f1, byte[] f2, byte[] f3)
        {
            try
            {
                command.CommandText = "INSERT INTO [DetaineeMugshot] VALUES(@d1, @d2, @d3, @d4)";
                command.CommandType = CommandType.Text;
                connection.Open();

                command.Parameters.Clear();
                command.Parameters.AddWithValue("@d1", d);
                command.Parameters.AddWithValue("@d2", SqlDbType.Image).Value = f1;
                command.Parameters.AddWithValue("@d3", SqlDbType.Image).Value = f2;
                command.Parameters.AddWithValue("@d4", SqlDbType.Image).Value = f3;

                command.ExecuteNonQuery();
                connection.Close();
                command.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        public void InsertToReleasedDetainee(int d1, string d2, string d3)
        {
            try
            {
                command.CommandText = "INSERT INTO [ReleasedDetainees] VALUES(@d1,@d2,@d3)";
                command.CommandType = CommandType.Text;
                connection.Open();

                command.Parameters.Clear();
                command.Parameters.AddWithValue("@d1", d1);
                command.Parameters.AddWithValue("@d2", d2);
                command.Parameters.AddWithValue("@d3", d3);

                command.ExecuteNonQuery();
                connection.Close();
                command.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        public void InsertToIRF(int entryNumber, int personnelID, DateTime entryDateTime, string typeIncident,
                                int reportingPerNo, string dateHappened, string timeHappened,
                                string place, string narrative)
        {
            try
            {
                command.CommandText = "INSERT INTO [IncidentRecord] VALUES (@EntryNumber, @PersonnelID, @EntryDateTime, @TypeofIncident, @ReportingPersonNo, @DateHappened, @TimeHappened, @Place, @Narrative)";
                command.CommandType = CommandType.Text;
                connection.Open();

                command.Parameters.Clear();
                command.Parameters.AddWithValue("@EntryNumber", entryNumber);
                command.Parameters.AddWithValue("@PersonnelID", personnelID);
                command.Parameters.AddWithValue("@EntryDateTime", entryDateTime);
                command.Parameters.AddWithValue("@TypeofIncident", typeIncident);
                command.Parameters.AddWithValue("@ReportingPersonNo", reportingPerNo);
                command.Parameters.AddWithValue("@DateHappened", dateHappened);
                command.Parameters.AddWithValue("@TimeHappened", timeHappened);
                command.Parameters.AddWithValue("@Place", place);
                command.Parameters.AddWithValue("@Narrative", narrative);

                command.ExecuteNonQuery();
                connection.Close();
                command.Dispose();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
            finally
            {
                connection.Close();
            }
        }

        public void InsertPersonnel(int personnelID, string rank, string positionInCharge, string name, string dateAssigned, byte[] personnelPic)
        {
            try
            {
                command.CommandText = "INSERT INTO [Personnel] VALUES(@PersonnelID, @Rank, @POI, @Name, @DateAssigned); INSERT INTO[PersonnelPic] VALUES(@PersonnelID, @PersonnelPic)";
                command.CommandType = CommandType.Text;
                connection.Open();

                command.Parameters.AddWithValue("@PersonnelID", personnelID);
                command.Parameters.AddWithValue("@Rank", rank);
                command.Parameters.AddWithValue("@POI", positionInCharge);
                command.Parameters.AddWithValue("@Name", name);
                command.Parameters.AddWithValue("@DateAssigned", dateAssigned);
                command.Parameters.AddWithValue("@PersonnelPic", SqlDbType.Image).Value = personnelPic;

                command.ExecuteNonQuery();
                connection.Close();
                command.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                connection.Close();
            }
        }

        public void AddUser(int personnelID, string password)
        {
            try
            {
                command.CommandText = "INSERT INTO[Users] VALUES(@p1, @p2)";
                command.CommandType = CommandType.Text;
                connection.Open();

                command.Parameters.Clear();
                command.Parameters.AddWithValue("@p1", personnelID);
                command.Parameters.AddWithValue("@p2", password);

                command.ExecuteNonQuery();
                connection.Close();
                command.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        public void ChangePassword(int personnelID, string password)
        {
            try
            {
                command.CommandText = "UPDATE [Users] SET Password = @ps WHERE PersonnelID = @pi";
                command.CommandType = CommandType.Text;
                connection.Open();

                command.Parameters.Clear();
                command.Parameters.AddWithValue("@pi", personnelID);
                command.Parameters.AddWithValue("@ps", password);

                command.ExecuteNonQuery();
                connection.Close();
                command.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        public void InsertActivities(int logNo, int personnelID, string logAbout, DateTime dateTime)
        {
            try
            {
                command.CommandText = "INSERT INTO[ActivityLogging] VALUES(@i1,@i2,@i3,@i4)";
                command.CommandType = CommandType.Text;
                connection.Open();

                command.Parameters.Clear();
                command.Parameters.AddWithValue("@i1", logNo);
                command.Parameters.AddWithValue("@i2", personnelID);
                command.Parameters.AddWithValue("@i3", logAbout);
                command.Parameters.AddWithValue("@i4", dateTime);

                command.ExecuteNonQuery();
                connection.Close();
                command.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        public void UpdateNarrative(int EntryNumber, string narrative)
        {
            try
            {
                command.CommandText = "UPDATE[IncidentRecord] SET Narrative = @nt WHERE EntryNumber = @en";
                command.CommandType = CommandType.Text;
                connection.Open();

                command.Parameters.Clear();
                command.Parameters.AddWithValue("en", EntryNumber);
                command.Parameters.AddWithValue("@nt", narrative);

                command.ExecuteNonQuery();
                connection.Close();
                command.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        public void UpdatePersonnel(int piD, string rank, string poc)
        {
            try
            {
                command.CommandText = "UPDATE[Personnel] SET Rank = @rr, PositionInCharge = @poc WHERE PersonnelID = @pID";
                command.CommandType = CommandType.Text;
                connection.Open();

                command.Parameters.Clear();
                command.Parameters.AddWithValue("@pID", piD);
                command.Parameters.AddWithValue("@rr", rank);
                command.Parameters.AddWithValue("@poc", poc);

                command.ExecuteNonQuery();
                connection.Close();
                command.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        public void UpdateStatus(int suspectNo)
        {
            try
            {
                command.CommandText = "UPDATE [Suspect] SET Status = @ss WHERE SuspectNo = @sNo";
                command.CommandType = CommandType.Text;
                connection.Open();

                command.Parameters.Clear();
                command.Parameters.AddWithValue("@ss", "Detainee");
                command.Parameters.AddWithValue("@sNo", suspectNo);

                command.ExecuteNonQuery();
                connection.Close();
                command.Dispose();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        public void UpdateSuspectDetainee(int sdno)
        {
            try
            {
                command.CommandText = "UPDATE [Suspect] SET Status = @ss WHERE SuspectNo = @sNo; UPDATE [Detainee] SET Status = @ss WHERE DetaineeNo = @sNo";
                command.CommandType = CommandType.Text;
                connection.Open();

                command.Parameters.Clear();
                command.Parameters.AddWithValue("@ss", "Released");
                command.Parameters.AddWithValue("@sNo", sdno);

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