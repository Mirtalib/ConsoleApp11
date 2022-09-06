using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp11
{
    internal class Client
    {
        public Guid GuidClient { get; set; }
        public string? NameClient { get; set; }
        public string? SurnameClient { get; set; }
        public int AgeClientcs { get; set; }
        public int SalaryClient { get; set; }
        public string? LiveAddressClient { get; set; }
        public string? WorkAddressClient { get; set; }

        public List<Credit> credits { get; set; } = new();

        public Client(Guid id, string name, string surname, string liveAddress, string workAddress, int age, int salary)
        {
            GuidClient = id;
            NameClient = name;
            SurnameClient = surname;
            LiveAddressClient = liveAddress;
            WorkAddressClient = workAddress;
            AgeClientcs = age;
            SalaryClient = salary;
        }

        public Client()
        {
            GuidClient = default;
            NameClient = default;
            SurnameClient = default;
            LiveAddressClient = default;
            WorkAddressClient = default;
            AgeClientcs = default;
            SalaryClient = default;
        }



        public void AddCredit(Credit credit)=>credits.Add(credit);
        



        public override string ToString()
        {
            return $@"ID=>{GuidClient}
Name=>{NameClient}
Surname=>{SurnameClient}
Age=>{AgeClientcs}
Live Address=>{LiveAddressClient}
Work Address=>{WorkAddressClient}
Salary=>{SalaryClient}";
        }

    }
}
