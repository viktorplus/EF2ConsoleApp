using DBContext;
using Microsoft.Data.SqlClient;
using Models;

namespace ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                using (var db = new CommandContext())
                {
                    Func.CreateDB(db);
                    Func.AutoAddCommand(db);
                    //Func.AddCommand(db); // ВВод с клавиатуры
                    Func.ShowCommands(db);
                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}