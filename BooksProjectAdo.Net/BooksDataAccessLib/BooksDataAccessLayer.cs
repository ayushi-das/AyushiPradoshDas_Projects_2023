using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CRUDOperationsBooksProj;
using System.Data.SqlClient;
using System.Data;
//connected mode
namespace BooksDataAccessLib
{
    public class BooksDataAccessLayer
    {
        SqlConnection con;

        public BooksDataAccessLayer()
        {
            con = new SqlConnection();

            con.ConnectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=SQLDB;Integrated Security=True;";

        }
        public int AddBooks(Books b)
        {
            int booksRecordAffected = 0;
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.Text;

                cmd.CommandText = "insert into Books values(@bc,@bn,@pn,@an,@p)";

                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@bc", b.BookCode);
                cmd.Parameters.AddWithValue("@bn", b.BookName);
                cmd.Parameters.AddWithValue("@pn", b.PublisherName);
                cmd.Parameters.AddWithValue("@an", b.AuthorName);
                cmd.Parameters.AddWithValue("@p", b.Price);

                con.Open();

                cmd.Connection = con;

                booksRecordAffected = cmd.ExecuteNonQuery();

                if(booksRecordAffected==0)
                {
                    throw new Exception("Could not add the book details");
                }


            }
            catch(Exception ex)
            {
                throw;
            }
            finally
            {
                con.Close();
            }
            return booksRecordAffected;
        }

        public int DeleteById(string bookCode)
        {
            int booksrecordAffected = 0;
            try
            {


                //2.configure the command for DELETE
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "delete from Books where [Book Code]=@bc";
                //3.specify the parameter value
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@bc", bookCode);
                //attach connection with command
                cmd.Connection = con;
                //open connection
                con.Open();
                //execute the command
               booksrecordAffected  = cmd.ExecuteNonQuery();
                if (booksrecordAffected == 0)
                {
                    throw new Exception("BOOK CODE DOES NOT EXIST ,NO BOOKS  DELETED ");
                }
            }
            catch (Exception ex)
            {
                throw;
            }
            finally
            {
                //close the connection
                con.Close();
            }
            return booksrecordAffected;
        
        }

        public List<Books> GetAllBooks()
        {
            List<Books> books= new List<Books>();
            //2.configure the command for SELECT all
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from Books";
            //attach Connection
            cmd.Connection = con;
            //open connection
            con.Open();
            //execute the command
            SqlDataReader sdr = cmd.ExecuteReader();
            //traverse the record and add them to the collection
            while (sdr.Read())
            {
                Books b = new Books
                {
                    BookCode = sdr[0].ToString(),
                    BookName = sdr[1].ToString(),
                    PublisherName = sdr[2].ToString(),
                    AuthorName = sdr[3].ToString(),
                    Price=(int)sdr[4]

                };
                //add it to the colection
                books.Add(b);
            }
            //close the reader
            sdr.Close();
            //close the connection 
            con.Close();

            //return the records
            return books;

        }

        public Books GetBooksByBookName(string bookname)
        {
            Books books = null;

            try
            {
                //2.get the employee record by ecode
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select * from Books where [Book Name]=@bn";
                //specify the parameter value
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@bn", bookname);
                //attach the connection with command
                cmd.Connection = con;
                //open connection with execute command
                con.Open();
                SqlDataReader sdr = cmd.ExecuteReader();
                if (sdr.Read())
                {
                     books = new Books
                    {
                        BookCode = sdr[0].ToString(),
                        BookName = sdr[1].ToString(),
                        PublisherName =sdr[2].ToString(),
                        AuthorName =sdr[3].ToString(),
                        Price=(int)sdr[4]
                    };
                    sdr.Close();
                }
                else
                {
                    throw new Exception("NO BOOK FOUND,BOOK NAME DOES NOT EXIST");
                }
            }
            catch (Exception ex)
            {
                throw;
            }
            finally
            {
                //close the connection
                con.Close();
            }
            return books;
        }

        public Books GetBooksByBookCode(string bookcode)
        {
            Books books = null;

            try
            {
                //2.get the employee record by ecode
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select * from Books where [Book Code]=@bc";
                //specify the parameter value
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@bc", bookcode);
                //attach the connection with command
                cmd.Connection = con;
                //open connection with execute command
                con.Open();
                SqlDataReader sdr = cmd.ExecuteReader();
                if (sdr.Read())
                {
                    books = new Books
                    {
                        BookCode = sdr[0].ToString(),
                        BookName = sdr[1].ToString(),
                        PublisherName = sdr[2].ToString(),
                        AuthorName = sdr[3].ToString(),
                        Price = (int)sdr[4]
                    };
                    sdr.Close();
                }
                else
                {
                    throw new Exception("NO BOOK FOUND,BOOK CODE DOES NOT EXIST");
                }
            }
            catch (Exception ex)
            {
                throw;
            }
            finally
            {
                //close the connection
                con.Close();
            }
            return books;
        }

        public int UpdateBooks(Books books)
        {
            int booksrecordAffected = 0;
            try
            {


                //INSERT OPERATION
                //2.Configure the SqlCommand for UPDATE sataement
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.Text;
                //3.specify the command text for INSERT
                cmd.CommandText = "update Books set [Book Name]=@bn,[Publisher Name]=@pn,[Author Name]=@an,Price=@p where [Book Code]=@bc";
                //4.specify the values for the parameters
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@bc", books.BookCode);
                cmd.Parameters.AddWithValue("@bn",books.BookName);
                cmd.Parameters.AddWithValue("@pn", books.PublisherName);
                cmd.Parameters.AddWithValue("@an", books.AuthorName);
                cmd.Parameters.AddWithValue("@p", books.Price);
                //5.open the connection
                con.Open();
                //6.attach the connection with the command
                cmd.Connection = con;
                //7.Execute the command
                //cmd.ExecuteNonQuery();
               booksrecordAffected = cmd.ExecuteNonQuery();
                if (booksrecordAffected == 0)
                {
                    throw new Exception("Could not  update record");
                }

            }
            catch (Exception ex)
            {
                throw;
            }
            finally
            {
                //8.close the connection
                con.Close();
            }

            return booksrecordAffected;
        }
    }
}
