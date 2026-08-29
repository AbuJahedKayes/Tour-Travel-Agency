using System;
using System.Data;
using System.Data.SqlClient;
using System.IO.Packaging;
using System.Security.Cryptography.X509Certificates;
using System.Windows.Forms;

namespace Tour_and_Travel_agency
{
    internal class Database
    {
        public void insertPackage(object entity, string type)
        {

            using (SqlConnection connection = new SqlConnection("Data Source=LAPTOP-5NJO5E7E\\SQLEXPRESS;Initial Catalog=TravelAgency;Integrated Security=True;"))
            {
                connection.Open();
                try
                {
                    string query = "";
                    if (type.Equals("package"))
                    {
                        Package package = (Package) entity;
                        query = "USE TravelAgency; INSERT INTO Packages (p_name, description, t_name, t_contact, date, time, status) VALUES ('" + package.p_name + "', '" + package.description + "', '" + package.t_name + "', '" + package.t_contact + "', '" + package.date + "', '" + package.time + "', '" + package.status + "');";

                    }
                    else if (type.Equals("t_guid"))
                    {
                        t_guid t_guid = (t_guid) entity;
                        query = "USE TravelAgency ;INSERT INTO Tour_guid(t_name,t_nid,t_address,t_contact,p_id) VALUES ('" + t_guid.t_name + "', '" + t_guid.t_nid + "', '" + t_guid.t_address + "', '" + t_guid.t_contact + "', '" + t_guid.p_id + "');";
                    }
                    else if (type.Equals("place"))
                    {
                        place place = (place) entity;
                        query = "USE TravelAgency ; INSERT INTO places (pl_name,p_id,p_name,taka) VALUES ('" + place.pl_name + "', '" + place.p_id + "' ,'" + place.p_name + "', '" + place.taka + "');";
                    }
                    else if (type.Equals("travelers"))
                    {
                        travelers travelers = (travelers) entity;
                        query ="USE TravelAgency ; iNSERT INTO travelers (tr_name,tr_contact,tr_nid,p_name,taka) VALUES ('" + travelers.tr_name + "', '" + travelers.tr_contact + "', '" + travelers.tr_nid + "', '" + travelers.p_name + "', '" + travelers.taka + "');";
                    }
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        try
                        {
                            command.ExecuteNonQuery();
                           MessageBox.Show("Row inserted successfully!");
                            
                        }
                        catch 
                        {
                           MessageBox.Show("Row insertion failed");
                        }
                    }
                    MessageBox.Show("Connection successful!");
                }
                catch (Exception ex)
                {
                   MessageBox.Show($"Connection failed: {ex.Message}");
                }
                connection.Close();
            }

        }

        public void view (string tableName, DataGridView dataGridView)
        {
            using (SqlConnection connection = new SqlConnection("Data Source=LAPTOP-5NJO5E7E\\SQLEXPRESS;Initial Catalog=TravelAgency;Integrated Security=True;"))
            {
                connection.Open();
                string query = "select * from " + tableName + ";";
                SqlDataAdapter dataAdapter = new SqlDataAdapter(query, connection);

                // Create a DataSet
                DataSet dataSet = new DataSet();

                // Fill the DataSet with the results from the SqlDataAdapter
                dataAdapter.Fill(dataSet, tableName);

                // Set the DataGridView's DataSource to the DataSet's table
                dataGridView.DataSource = dataSet.Tables[tableName];
            }
        }

        public void Retrive(object entity, string type, int i = 0)
        {

            using (SqlConnection connection = new SqlConnection("Data Source=LAPTOP-5NJO5E7E\\SQLEXPRESS;Initial Catalog=TravelAgency;Integrated Security=True;"))
            {
                connection.Open();
                try
                {
                    string query = "";
                    if (type.Equals("packageId"))
                    {
                        Package package = (Package)entity;
                        query = "USE TravelAgency; SELECT TOP 1 * FROM Packages ORDER BY p_id DESC;";

                        using (SqlCommand command = new SqlCommand(query, connection))
                        {
                            try
                            {
                                SqlDataReader reader = command.ExecuteReader();
                                while (reader.Read())
                                {
                                    package.p_id += reader.GetInt32(0); // Assuming the first column is of type int
                                    //package.p_name = reader.GetString(1);
                                }
                               // MessageBox.Show("Row retrive successfully!");

                            }
                            catch
                            {
                                //MessageBox.Show("Row insertion failed");
                            }
                        }

                    }

                    else if (type.Equals("tourGuideName"))
                    {
                        ComboBox combo = (ComboBox) entity;
                        query = "USE TravelAgency; SELECT t_name from Tour_guid;";

                        using (SqlCommand command = new SqlCommand(query, connection))
                        {
                            try
                            {
                                SqlDataReader reader = command.ExecuteReader();
                                while (reader.Read())
                                {
                                    combo.Items.Add(reader.GetString(0));
                                }
                               // MessageBox.Show("Row retrive successfully!");

                            }
                            catch
                            {
                               // MessageBox.Show("Row insertion failed");
                            }
                        }
                    }

                    else if (type.Equals("tourGuideContact"))
                    {
                        Package package = (Package)entity;
                        query = "USE TravelAgency; SELECT t_contact from Tour_guid WHERE t_name = '" + package.t_name + "';";

                        using (SqlCommand command = new SqlCommand(query, connection))
                        {
                            try
                            {
                                SqlDataReader reader = command.ExecuteReader();
                                while (reader.Read())
                                {
                                    package.t_contact = reader.GetString(2);
                                }
                               // MessageBox.Show("Row retrive successfully!");

                            }
                            catch
                            {
                               // MessageBox.Show("Row insertion failed");
                            }
                        }
                    }

                    else if (type.Equals("package"))
                    {
                        Package package = (Package)entity;
                        query = "USE TravelAgency; SELECT * from Packages;";

                        using (SqlCommand command = new SqlCommand(query, connection))
                        {
                            try
                            {
                                SqlDataReader reader = command.ExecuteReader();
                                int j = 0;
                                while (reader.Read())
                                {
                                    if (i == j)
                                    {
                                        package.p_name = reader.GetString(1); // Assuming the first column is of type int
                                        package.description = reader.GetString(2);
                                        package.t_name = reader.GetString(3);
                                        package.t_contact = reader.GetString(4);
                                        package.date = reader.GetString(5);
                                        package.time = reader.GetString(6);
                                        //package.status = reader.GetString(7);
                                    }
                                    j++;
                                }
                               // MessageBox.Show("Row retrive successfully!");

                            }
                            catch
                            {
                               // MessageBox.Show("Row insertion failed");
                            }
                        }
                    }

                    else if (type.Equals("place"))
                    {
                        place place = (place) entity;
                        query = "use TravelAgency; select * from places where p_name = '" + place.p_name + "';";

                        using (SqlCommand command = new SqlCommand(query, connection))
                        {
                            try
                            {
                                SqlDataReader reader = command.ExecuteReader();
                                int j = 0;
                                while (reader.Read())
                                {
                                    if (i == j)
                                    {
                                        place.pl_name = reader.GetString(1);
                                    }
                                    j++;
                                }
                              //  MessageBox.Show("Row retrive successfully!");

                            }
                            catch
                            {
                              //  MessageBox.Show("Row insertion failed");
                            }
                        }
                    }

                   // MessageBox.Show("Connection successful!");
                }
                catch (Exception ex)
                {
                   // MessageBox.Show($"Connection failed: {ex.Message}");
                }
                connection.Close();
            }

        }

    }
}
