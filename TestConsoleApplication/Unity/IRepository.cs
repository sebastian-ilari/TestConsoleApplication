namespace TestConsoleApplication.Unity
{
    public interface IRepository<TEntity>
    {
        string GetName(TEntity entity);
    }
}