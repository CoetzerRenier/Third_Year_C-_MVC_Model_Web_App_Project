using GroovyBooks1.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

namespace GroovyBooks1.Controllers
{
    public class ProductsController : Controller
    {
        public List<String> products = new List<String>();

        public string connectionString = "Data Source=ZIPPERSELAPTOP;Initial Catalog=GroovyBooks;Integrated Security=True;Trust Server Certificate=True;";

        public IActionResult Index()
        {
            populateList();

            return View(products);
        }

        //This method opens the sqlconnection and retrieves the data using sql statements. It is made for better code reuseability.
        public void sqlQuery(string connectionString, string query, string tableName, string tableDescription, string tablePrice, string tableStock, string tableGenre, string tableImage)
        {   
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    try
                    {
                        //Open the connection
                        connection.Open();

                        //Execute the SQL query.
                        SqlDataReader reader = command.ExecuteReader();

                        //Check if the SqlDataReader has rows
                        if (reader.HasRows)
                        {
                            //Loop through the rows and retrieve data.
                            while (reader.Read())
                            {
                                tableName = reader.GetString(reader.GetOrdinal(uppercaseFirstLetter(tableName)));
                                tableDescription = reader.GetString(reader.GetOrdinal(tableDescription));
                                tablePrice = reader.GetString(reader.GetOrdinal(tablePrice));
                                tableStock = reader.GetString(reader.GetOrdinal(tableStock));
                                tableGenre = reader.GetString(reader.GetOrdinal(tableGenre));
                                tableImage = reader.GetString(reader.GetOrdinal(tableImage));

                                products.Add(tableName);
                                products.Add(tableDescription);
                                products.Add(tablePrice);
                                products.Add(tableStock);
                                products.Add(tableGenre);
                                products.Add(tableImage);
                            }

                            foreach(var product in products)
                            {
                                Console.WriteLine(products);
                            } 
                        }
                        else
                        {
                            Console.WriteLine("No rows found.");
                        }

                        //Close the SqlDataReader & Connection
                        reader.Close();
                        connection.Close();
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Error: " + ex.Message);
                    }
                }
            }
        }

        //This method makes the fuirst letter of a string uppercase, needed for the sql method.
        public string uppercaseFirstLetter(string tableHeader)
        {
            string uppercased = tableHeader;

            if (tableHeader.Length == 0)
            {
                System.Console.WriteLine("Empty String");
            }
            else if (tableHeader.Length == 1)
            {
                char.ToUpper(uppercased[0]);
            }
            else
            {
                uppercased = char.ToUpper(uppercased[0]) + uppercased.Substring(1);
            }

            return uppercased;
        }

        //This method popluates the list that will be passed on to the view.
        public void populateList()
        {
            //Creating the query.
            string namesQuery = "SELECT * FROM Product";

            //Running the method that retireves the data from the database and populates the list.
            sqlQuery(connectionString, namesQuery, "name", "description", "price", "stock", "genre", "iamge");
        }
    }
}
