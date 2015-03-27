namespace TestConsoleApplication.Unity
{
    public class Entity : IEntity
    {
        public string Name { get; set; }

        public string GetName()
        {
            this.Name = "DI WORKED: Name set in the Entity";
            return this.Name;
        }
    }
}