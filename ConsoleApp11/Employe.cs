namespace ConsoleApp11
{
    internal abstract class Employe
    {
        public Guid GuidEmploye { get; set; }
        public string? NameEmploye { get; set; }
        public string? SurnameEmploye { get; set; }
        public string? PositionEmploye { get; set; }
        public int AgeEmploye { get; set; }
        public int SalaryEmploye { get; set; }



        public Employe(Guid id , string name , string surname , string position , int age , int salary)
        {

            GuidEmploye = id;
            NameEmploye = name;
            SurnameEmploye = surname;
            SalaryEmploye = salary;
            PositionEmploye = position;
            AgeEmploye = age;
            
        }


        public Employe()
        {
            GuidEmploye = default;
            NameEmploye = default!;
            SurnameEmploye = default!;
            SalaryEmploye = default!;
            PositionEmploye = default!;
            AgeEmploye = default;
            
        }



        public override string ToString()
        {
            return $@"ID=>{GuidEmploye}
Name=>{NameEmploye}
Surname=>{SurnameEmploye}
Age=>{AgeEmploye}
Position=>{PositionEmploye}
Salary=>{SalaryEmploye}
";
        }
    }
}
