using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp11
{
    internal class Bank
    {
        public string? Name { get; set; }
        public int Budget { get; set; }
        public int Profit { get; set; }
        public CEO Ceo { get; set; }
        public List<Meneger>? Managers { get; set; } = new();
        public List<Worker>? Workers { get; set; } = new();
        public List<Client>? Clients { get; set; } = new();


        public Bank(string name , int budget , CEO ceo)
        {
            Name = name;
            Budget = budget;
            Profit = default;
            Ceo = ceo;
        }



        public void AddMeneger(Meneger menger) => Managers?.Add(menger);
        
        public void AddWorker(Worker worker) => Workers?.Add(worker);
        
        public void AddClient(Client client)=> Clients?.Add(client);
        



        public void ShowClientCredit(string Fullname)
        {
            foreach(var client in Clients!)
            {
                if(Fullname == (client.NameClient + client.SurnameClient))
                {
                    if(client.credits == null)
                        Console.WriteLine("Not Credit");
                    else
                    {
                        foreach (var cl in client.credits!)
                        {
                            Console.WriteLine(cl);
                        }
                        break;
                    }
                    break;
                }
            }
        }


        public int CalculateProfit()
        {
            int profit = 0;

            foreach(var client in Clients!)
            {
                for(int i = 0; i < client.credits.Count; i++)
                {
                    profit += client.credits[i].CalculatePercent;
                }
            }

            return profit;
        }


        public void PayCredit(Client client , int money)
        {
            foreach (var cl in Clients!)
            {
                if (cl.NameClient == client.NameClient)
                {
                    int number = 0;
                    foreach (var cl2 in client.credits!)
                    {
                        Console.WriteLine(++number);
                        Console.WriteLine(cl2);
                    }

                    Console.WriteLine("Select what you want to pay for:");
                    int check = int.Parse(Console.ReadLine()!);

                    for (int i = 0; i < client.credits.Count; i++)
                    {
                        if(check > i || check < i)
                        {
                            Console.WriteLine("No Debt Found");
                            break;
                        }
                        if(i == check - 1)
                        {
                            client.credits[i].Amont -= money;
                            client.credits[i].Months -= 1;
                            Console.WriteLine("This monthly debt");
                            if (client.credits[i].PaymentMonths - money > 0)
                            {
                                Console.WriteLine(client.credits[i].PaymentMonths - money);
                            }
                            else
                            {
                                Console.WriteLine("0");
                            }
                            break;
                        }
                    }

                }
            }
        }


        public void ShowAllCredit()
        {
            foreach (var client in Clients!)
            {

                if (client.credits == null)
                    Console.WriteLine("Not Credit");
                else
                {
                    foreach (var cl in client.credits!)
                    {
                        Console.WriteLine(cl);
                    }      
                }
            }
        }



    }
}
