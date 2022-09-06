namespace ConsoleApp11
{
    internal class CEO : Employe , IOrganize , IControl , IMeeting
    {
        public CEO(Guid id, string name, string surname, string position, int age, int salary)
            :base(id , name , surname , position , age , salary)
        {

        }

        public CEO()
        {
                
        }

        public void Control()
        {
            Console.WriteLine("I am CEO and I control");
        }

        public void MakeMeeting()
        {
            Console.WriteLine("I am CEO and I Meeting");
        }

        public void Organize()
        {
            Console.WriteLine("I am CEO and I Organize");
        }



    }
}
