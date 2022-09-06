namespace ConsoleApp11
{
    internal class Meneger : Employe, IOrganize
    {



        public Meneger(Guid id, string name, string surname, string position, int age, int salary)
            :base(id, name, surname, position, age, salary)
        {

        }

        public void Organize()
        {
            Console.WriteLine("I am Meneger and I Organize");
        }


        public int CalculateSalary(Employe s)
        {
            return s.SalaryEmploye;
        }

        public int CalculateSalary(List<Employe> s)
        {
            int SomeSalary = 0;
            foreach (var item in s)
            {
                SomeSalary += item.SalaryEmploye;
            }
            return SomeSalary;
        }

    }
}
