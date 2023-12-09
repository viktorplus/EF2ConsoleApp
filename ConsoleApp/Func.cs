using DBContext;
using Microsoft.Data.SqlClient;
using Models;

namespace ConsoleApp
{
    public static class Func
    {
        public static void CreateDB()
        {
            using (CommandContext context = new())
            {
                context.Database.EnsureDeleted();
                context.Database.EnsureCreated();
            }
        }
        public static void AddCommand()
        {
            try
            {
                using (CommandContext context = new())
                {
                    Console.Write("Введите название команды: ");
                    string name = Console.ReadLine();

                    Console.Write("Введите город: ");
                    string city = Console.ReadLine();

                    Console.Write("Введите количество побед: ");
                    if (!int.TryParse(Console.ReadLine(), out int wins))
                    {
                        Console.WriteLine("Некорректный ввод для количества побед.");
                        return;
                    }

                    Console.Write("Введите количество поражений: ");
                    if (!int.TryParse(Console.ReadLine(), out int losses))
                    {
                        Console.WriteLine("Некорректный ввод для количества поражений.");
                        return;
                    }

                    Console.Write("Введите количество ничьих: ");
                    if (!int.TryParse(Console.ReadLine(), out int draw))
                    {
                        Console.WriteLine("Некорректный ввод для количества ничьих.");
                        return;
                    }

                    var newitem = new Command { Name = name, City = city, Wins = wins, Losses = losses, Draw = draw };
                    context.Commands.Add(newitem);
                    context.SaveChanges();

                    Console.WriteLine("Успешно добавлена.");
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
