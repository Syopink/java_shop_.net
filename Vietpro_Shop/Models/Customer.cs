using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BCrypt.Net;

namespace Vietpro_Shop.Models
{
    public class Customers
    {
        private readonly SqlConnection conn;

        public Customers(string connectionString)
        {
            conn = new SqlConnection(connectionString);
            conn.Open(); // Open the connection in the constructor
        }

        // Login method
        public string Login(string email, string password)
        {
            string query = "SELECT * FROM customers WHERE email = @Email AND isDeleted = 0";

            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@Email", email);

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        string hashedPassword = reader["password"].ToString();
                        if (BCrypt.Net.BCrypt.Verify(password, hashedPassword)) // Verify hashed password
                        {
                            return reader["role"].ToString(); // Return role if login is successful
                        }
                        else
                        {
                            return "invalid_password"; // Incorrect password
                        }
                    }
                    else
                    {
                        return "invalid_email"; // Email not found
                    }
                }
            }
        }

        // Register a new customer
        public bool RegisterCustomer(string email, string password, string fullName, string address, string phone)
        {
            if (IsEmailExists(email))
            {
                Console.WriteLine("Email already exists!");
                return false;
            }

            if (IsPhoneExists(phone))
            {
                Console.WriteLine("Phone number already exists!");
                return false;
            }

            string hashedPassword = BCrypt.Net.BCrypt.HashPassword(password);

            string query = "INSERT INTO customers (email, password, isDeleted, createdAt, updatedAt, fullName, numberOfPhone, address) " +
                           "VALUES (@Email, @Password, 0, GETDATE(), GETDATE(), @FullName, @Phone, @Address)";

            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@Email", email);
                cmd.Parameters.AddWithValue("@Password", hashedPassword);
                cmd.Parameters.AddWithValue("@FullName", fullName);
                cmd.Parameters.AddWithValue("@Phone", phone);
                cmd.Parameters.AddWithValue("@Address", address);

                try
                {
                    cmd.ExecuteNonQuery();
                    return true;
                }
                catch (Exception e)
                {
                    Console.WriteLine("Error while registering user: " + e.Message);
                    return false;
                }
            }
        }

        // Check if email exists
        public bool IsEmailExists(string email)
        {
            string query = "SELECT COUNT(*) FROM customers WHERE email = @Email";

            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@Email", email);
                int count = (int)cmd.ExecuteScalar();
                return count > 0;
            }
        }

        // Check if phone number exists
        public bool IsPhoneExists(string phone)
        {
            string query = "SELECT COUNT(*) FROM customers WHERE numberOfPhone = @Phone";

            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@Phone", phone);
                int count = (int)cmd.ExecuteScalar();
                return count > 0;
            }
        }

        // Update password
        public bool UpdatePassword(string email, string newPassword)
        {
            string checkEmailQuery = "SELECT * FROM customers WHERE email = @Email AND isDeleted = 0";
            string updatePasswordQuery = "UPDATE customers SET password = @Password, updatedAt = GETDATE() WHERE email = @Email AND isDeleted = 0";

            using (SqlCommand checkCmd = new SqlCommand(checkEmailQuery, conn))
            {
                checkCmd.Parameters.AddWithValue("@Email", email);
                using (SqlDataReader reader = checkCmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        string hashedPassword = BCrypt.Net.BCrypt.HashPassword(newPassword);
                        using (SqlCommand updateCmd = new SqlCommand(updatePasswordQuery, conn))
                        {
                            updateCmd.Parameters.AddWithValue("@Password", hashedPassword);
                            updateCmd.Parameters.AddWithValue("@Email", email);
                            int rowsAffected = updateCmd.ExecuteNonQuery();
                            return rowsAffected > 0;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Email does not exist.");
                        return false;
                    }
                }
            }
        }

        // Get customer name by email
        public string GetCustomerNameByEmail(string email)
        {
            string query = "SELECT fullName FROM customers WHERE email = @Email AND isDeleted = 0";

            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@Email", email);
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        return reader["fullName"].ToString();
                    }
                }
            }

            return null; // Return null if user not found
        }

        // Update user info (including password if provided)
        public bool UpdateUserInfo(string email, string fullName, string address, string phone, string password)
        {
            string checkEmailQuery = "SELECT * FROM customers WHERE email = @Email AND isDeleted = 0";
            string checkPhoneQuery = "SELECT * FROM customers WHERE numberOfPhone = @Phone AND email != @Email AND isDeleted = 0";
            string updateQuery = "UPDATE customers SET fullName = @FullName, address = @Address, numberOfPhone = @Phone, updatedAt = GETDATE()";

            if (!string.IsNullOrEmpty(password))
            {
                updateQuery += ", password = @Password";
            }

            updateQuery += " WHERE email = @Email AND isDeleted = 0";

            using (SqlCommand checkEmailCmd = new SqlCommand(checkEmailQuery, conn))
            using (SqlCommand checkPhoneCmd = new SqlCommand(checkPhoneQuery, conn))
            using (SqlCommand updateCmd = new SqlCommand(updateQuery, conn))
            {
                checkEmailCmd.Parameters.AddWithValue("@Email", email);
                using (SqlDataReader reader = checkEmailCmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        checkPhoneCmd.Parameters.AddWithValue("@Phone", phone);
                        checkPhoneCmd.Parameters.AddWithValue("@Email", email);
                        using (SqlDataReader phoneReader = checkPhoneCmd.ExecuteReader())
                        {
                            if (phoneReader.Read())
                            {
                                Console.WriteLine("Phone number already exists.");
                                return false;
                            }
                        }

                        updateCmd.Parameters.AddWithValue("@FullName", fullName);
                        updateCmd.Parameters.AddWithValue("@Address", address);
                        updateCmd.Parameters.AddWithValue("@Phone", phone);

                        if (!string.IsNullOrEmpty(password))
                        {
                            string hashedPassword = BCrypt.Net.BCrypt.HashPassword(password);
                            updateCmd.Parameters.AddWithValue("@Password", hashedPassword);
                        }

                        updateCmd.Parameters.AddWithValue("@Email", email);
                        int rowsAffected = updateCmd.ExecuteNonQuery();
                        return rowsAffected > 0;
                    }
                    else
                    {
                        Console.WriteLine("Email does not exist.");
                        return false;
                    }
                }
            }
        }
    }
}