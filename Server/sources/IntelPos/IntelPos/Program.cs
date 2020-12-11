using IntelPos.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;

namespace IntelPos
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // ���������� ������
            using (var db = new ApplicationContext())
            {
                // ������� ��� ������� Card
                var card1 = new Card { Term = "Term1", Definition = "Def1" };
                var card2 = new Card { Term = "Term2", Definition = "Def2" };

                // ��������� �� � ��
                db.Cards.AddRange(card1, card2);
                db.SaveChanges();
            }

            CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}
