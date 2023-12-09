using DBContext;
using Microsoft.Data.SqlClient;
using Models;

namespace ConsoleApp
{
    public static class Func
    {
        public static void CreateDB(CommandContext context)
        {
            context.Database.EnsureDeleted();
            context.Database.EnsureCreated();
        }

        public static void AutoAddCommand(CommandContext context)
        {
            var commandsToAdd = new List<Command>
            {
                new Command("Team1", "City1", 10, 5, 3),
                new Command("Team2", "City2", 8, 7, 2),
                new Command("Team3", "City3", 12, 3, 5),
            };

            context.Commands.AddRange(commandsToAdd);
            context.SaveChanges();
        }
        public static void AddCommand(CommandContext context)
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

            Command newitem = new() { Name = name, City = city, Wins = wins, Losses = losses, Draw = draw };
            context.Commands.Add(newitem);
            context.SaveChanges();

            Console.WriteLine("Успешно добавлена.");
        }
        public static void ShowCommands(CommandContext context)
        {
            var commands = context.Commands.ToList();
            foreach (var command in commands)
            {
                Console.WriteLine(command);
            }
        }
    }
}
