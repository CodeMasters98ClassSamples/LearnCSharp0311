﻿using BaseBackend.Entities;
using BaseBackend.Interfaces;
using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace BaseBackend.Businesses;

public class StudentBusiness : IBaseBusiness<Student>, IStudentBusiness<StudentCourse>
{
    //const string connectionString = "Data Source=.;Initial Catalog=BookShop;Integrated Security=True;";
    string connectionString = ConfigurationManager.ConnectionStrings["LearnCSharp0311Db"].ToString();


    public StudentBusiness()
    {
    }

    public bool Add(Student item)
    {
        using (SqlConnection connection = new SqlConnection(connectionString))
        {
            bool isAffected = false;
            try
            {
                connection.Open();
                string tableName = "[User]";

                // Create a SQL command to insert a new person record
                string query = $"INSERT INTO {tableName} (FirstName, LastName, PhoneNumber) " +
                               "VALUES (@FirstName, @LastName, @PhoneNumber)";
                SqlCommand command = new SqlCommand(query, connection);

                // Add parameters to the SQL command
                //command.Parameters.AddWithValue("@Id", person.Id);
                command.Parameters.AddWithValue("@FirstName", item.FirstName);
                command.Parameters.AddWithValue("@LastName", item.LastName);
                command.Parameters.AddWithValue("@PhoneNumber", item.MobileNumber);

                // Execute the insert query
                int rowsAffected = command.ExecuteNonQuery();

                isAffected = rowsAffected > 0;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
            finally
            {
                connection.Close();
            }
            return isAffected;
        }
    }

    public bool AddWithSp(Student item)
    {
        using (SqlConnection connection = new SqlConnection(connectionString))
        {
            connection.Open();
            using (SqlCommand command = new SqlCommand("AddStudent", connection))
            {
                command.CommandType = CommandType.StoredProcedure;
                // Add parameters
                command.Parameters.Add(new SqlParameter("@FirstName", SqlDbType.NVarChar, 150)).Value = item.FirstName;
                command.Parameters.Add(new SqlParameter("@LastName", SqlDbType.NVarChar, 150)).Value = item.LastName;
                command.Parameters.Add(new SqlParameter("@PhoneNumber", SqlDbType.NVarChar, 11)).Value = item.MobileNumber;
                command.Parameters.Add(new SqlParameter("@Referer", SqlDbType.NVarChar, 150)).Value = "asudhas";
                command.Parameters.Add(new SqlParameter("@University", SqlDbType.NVarChar, 150)).Value = "asdsa";
                // Execute the stored procedure
                command.ExecuteNonQuery();
            }
        }
        return true;
    }

    public List<Student> GetAll(string firstName, string lastname)
    {
        //Step 1
        List<Student> students = new List<Student>();

        //Step2
        // Replace "YourTableName" with the actual name of the table you want to query
        using (SqlConnection connection = new SqlConnection(connectionString))
        {
            try
            {
                connection.Open();

                //Step 3
                // Create a SQL command to select data from the table
                string query = $"select U.FirstName,U.LastName,U.NationalCode,U.PhoneNumber,S.Id  from dbo.[User] as U LEFT JOIN dbo.Student as s ON U.Id = s.UserId";
                SqlCommand command = new SqlCommand(query, connection);

                //sTEP 4
                // Create a data reader to fetch the data
                SqlDataReader reader = command.ExecuteReader();

                // Read data and map it to Person objects
                //Step 5
                while (reader.Read())
                {
                    //Step 6
                    Student student = new Student
                    {
                        Id = (int)reader["Id"],
                        FirstName = reader["FirstName"].ToString(),
                        LastName = reader["LastName"].ToString(),
                        MobileNumber = reader["PhoneNumber"].ToString(),
                        NationalCode = reader["NationalCode"].ToString()
                    };
                    //Step 7
                    students.Add(student);
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
            finally
            {
                //Step 8
                connection.Close();
            }
            //Stpe 9
            return students;
        }
    }

    public List<Student> GetAll()
    {
        return GetAll(firstName: null, lastname: null);
    }

    public List<StudentCourse> GetRegisteredStudent()
    {
        throw new NotImplementedException();
    }

    public bool Register(StudentCourse item)
    {
        using (SqlConnection connection = new SqlConnection(connectionString))
        {
            bool isAffected = false;
            try
            {
                connection.Open();
                string tableName = "[StudentCourse]";

                // Create a SQL command to insert a new person record
                string query = $"INSERT INTO {tableName} (CourseId,StudentId,CurrentAmount) " +
                               "VALUES (@CourseId, @StudentId, @CurrentAmount)";
                SqlCommand command = new SqlCommand(query, connection);

                // Add parameters to the SQL command
                //command.Parameters.AddWithValue("@Id", person.Id);
                command.Parameters.AddWithValue("@CourseId", item.CourseId);
                command.Parameters.AddWithValue("@StudentId", item.StudentId);
                command.Parameters.AddWithValue("@CurrentAmount", item.CurrentAmount);

                // Execute the insert query
                int rowsAffected = command.ExecuteNonQuery();

                isAffected = rowsAffected > 0;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
            finally
            {
                connection.Close();
            }
            return isAffected;
        }
    }

    public bool Update(Student item)
    {
        using (SqlConnection connection = new SqlConnection(connectionString))
        {
            bool isAffected = false;
            try
            {
                connection.Open();

                // Create a SQL command to insert a new person record
                string query = "UPDATE dbo.[User] " +
                                "SET FirstName = @FirstName, " +
                                    "LastName = @LastName," +
                                    "PhoneNumber = @PhoneNumber," +
                                    "NationalCode = @NationalCode " +
                                "WHERE Id = @Id";
                SqlCommand command = new SqlCommand(query, connection);

                // Add parameters to the SQL command
                //command.Parameters.AddWithValue("@Id", person.Id);
                command.Parameters.AddWithValue("@FirstName", item.FirstName);
                command.Parameters.AddWithValue("@LastName", item.LastName);
                command.Parameters.AddWithValue("@PhoneNumber", item.MobileNumber);
                command.Parameters.AddWithValue("@NationalCode", item.NationalCode);
                command.Parameters.AddWithValue("@Id", item.Id);

                // Execute the insert query
                int rowsAffected = command.ExecuteNonQuery();

                isAffected = rowsAffected > 0;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
            finally
            {
                connection.Close();
            }
            return isAffected;
        }
    }
}
