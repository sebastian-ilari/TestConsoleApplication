namespace TestConsoleApplication.DesignPatterns.Composite
{
    public abstract class EmployeeBase : IEmployed
    {
        public int EmployeeId { get; set; }
        public string Name { get; set; }

        public override string ToString()
        {
            return string.Format("EmployeeID: {0}, Type: {1}, Name: {2}", 
                                        this.EmployeeId, 
                                        this.GetType().Name, 
                                        this.Name);
        }
    }
}