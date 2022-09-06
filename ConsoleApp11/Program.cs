namespace ConsoleApp11;



class Program
{
    static void Main()
    {
        

        CEO s1 = new CEO(Guid.NewGuid(), "Mirtalib" , "Huseynzade" , "Ceo" , 19 , 2400);
        Meneger s2 = new Meneger(Guid.NewGuid(), "Ibadulla", "Huseynzade", "Meneger", 18, 800);
        Worker s3 = new Worker(Guid.NewGuid(), "Kamran", "Rizayev", "Worker", 24, 600, new TimeOnly(9, 00), new TimeOnly(18, 00));
        Credit s4 = new(Guid.NewGuid(), 1000, 10, 10);
        Client client = new(Guid.NewGuid(), "Eltac", "Memmedov", "MirEli Seyidov 31/38", "Nazim Hikmet 28", 21, 4000);
        Operation operation = new(Guid.NewGuid(), "Add Creadit", DateTime.Now);
        
        
        // Worker 
        s3.addOperation(operation);
        s3.ShowOperation();
        
        // Client
        client.AddCredit(s4);
        
        // ceo
        s1.Control();
        s1.Organize();
        s1.MakeMeeting();
        
        // meneger
        s2.Organize();

        // Bank


        Bank Capital = new("Capital", 100000, s1);

        Capital.AddMeneger(s2);
        Capital.AddWorker(s3);
        Capital.AddClient(client);

        Console.WriteLine("Profit Bank in Month=>", Capital.CalculateProfit());

        Capital.ShowAllCredit();

        Capital.PayCredit(client, 100);

        Capital.ShowClientCredit("EltacMemmedov");

    }
}