namespace TestConsoleApplication.Unity
{
    public class Repository<TEntity> : IRepository<TEntity> where TEntity : IEntity
    {
        public string GetName(TEntity entity)
        {
            return entity.GetName();
        }
    }
}