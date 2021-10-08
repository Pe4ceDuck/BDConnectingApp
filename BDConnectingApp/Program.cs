using System;
using System.Data.SqlClient;
using System.Configuration;

namespace BDConnectingApp
{
    class Program
    {
        static void Main()
        {
            Forum newforum1 = new Forum
            {
                Postid = 2,
                Threadname = "Новая тема",
                Userid = 1,
                CreationDate = "08.10.2021",
                Title = "Имя нового сообщения",
                Body = "Новое сообщение",
            };

            string connectionString = @"Data Source=.\SQLEXPRESS;Initial Catalog=BuisnessDataBase;Integrated Security=True";
            string sqlExpression = "INSERT INTO FORUM (postid, threadname, userid, creationDate, title, body) VALUES (@postid, @threadname, @userid, @creationDate, @title, @body)";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(sqlExpression, connection);
                SqlParameter postidParam = new SqlParameter(@"postid", newforum1.Postid);
                command.Parameters.Add(postidParam);
                SqlParameter threadnameParam = new SqlParameter("@threadname", newforum1.Threadname);
                command.Parameters.Add(threadnameParam);
                SqlParameter useridParam = new SqlParameter("@userid", newforum1.Userid);
                command.Parameters.Add(useridParam);
                SqlParameter creationDateParam = new SqlParameter("@creationDate", newforum1.CreationDate);
                command.Parameters.Add(creationDateParam);
                SqlParameter titleParam = new SqlParameter("@title", newforum1.Title);
                command.Parameters.Add(titleParam);
                SqlParameter bodyParam = new SqlParameter("@body", newforum1.Body);
                command.Parameters.Add(bodyParam);
                int number = command.ExecuteNonQuery();
                Console.WriteLine("Добавлено объектов: {0}", number);
            }
        }
    }
}