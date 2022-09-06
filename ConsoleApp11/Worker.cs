namespace ConsoleApp11
{
    internal class Worker :Employe
    {

        TimeOnly StartWork { get; set; }
        TimeOnly EndWork { get; set; }

        public List<Operation> Operation { get; set; }  = new List<Operation>();

        public Worker(Guid id, string name, string surname, string position, int age, int salary , TimeOnly startWork , TimeOnly endWork)
            : base(id, name, surname, position, age, salary)
        {
            StartWork = startWork;
            EndWork = endWork;
        }

        public void addOperation(Operation operation) =>Operation.Add(operation);
        
        public void ShowOperation()
        {
            foreach(Operation operation in Operation)
            {
                Console.WriteLine(operation);
            }
        }

        public override string ToString()
        {
            return $@"ID=>{GuidEmploye}
Name=>{NameEmploye}
Surname=>{SurnameEmploye}
Age=>{AgeEmploye}
Position=>{PositionEmploye}
Salary=>{SalaryEmploye}
Start Work=>{StartWork}
End Work=>{EndWork}
";
        }


    }
}
