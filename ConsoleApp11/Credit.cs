using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp11
{
    internal class Credit
    {
        public Guid IdCredit { get; set; }
        public int Amont { get; set; }
        public int Percent { get; set; }
        public int Months { get; set; }
        public int PaymentMonths { get; set; }
        public int CalculatePercent { get; set; } 


        public Credit(Guid idCredit,int amont,int percent,int months)
        {
            IdCredit = idCredit;
            Percent = percent;
            Months = months;
            CalculatePercent = (amont / 100) * percent;
            PaymentMonths = (amont + CalculatePercent) / months;
            Amont = amont + CalculatePercent;
        }

        public Credit()
        {
            IdCredit = default;
            Amont = default;
            Percent = default;
            Months = default;
            CalculatePercent = default;
            PaymentMonths = default;
        }

        public override string ToString()
        {
            return $@"ID=>{IdCredit}
Amont=>{Amont}
Months=>{Months}
Calculate Percent=>{CalculatePercent}
Percent=>{Percent}%
Payment Months=>{PaymentMonths}
";
        }

    }
}
