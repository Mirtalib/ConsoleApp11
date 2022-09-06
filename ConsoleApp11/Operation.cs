namespace ConsoleApp11
{
    internal class Operation
    {

        public Guid GuidOperation { get; set; }
        public string? OperationName { get; set; }
        public DateTime? OperationTime { get; set; }


        public Operation(Guid guidOperation , string? operationName , DateTime? operationTime)
        {
            GuidOperation = guidOperation;
            OperationName = operationName;
            OperationTime = operationTime;
        }



        public override string ToString()
        {
            return $"ID =>{GuidOperation}\nName Operation=>{OperationName}\nDate Time Operation=>{OperationTime}\n";
        }

    }
}
