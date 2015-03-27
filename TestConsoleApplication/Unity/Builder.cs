namespace TestConsoleApplication.Unity
{
    public abstract class Builder<TEntity> where TEntity : new()
    {
        protected TEntity entity;
        
        protected IRepository<TEntity> _repository;

        public Builder()
        {
            
        }

        public Builder(IRepository<TEntity> repository)
        {
            this._repository = repository;
        }

        public string BuildName()
        {
            this.entity = new TEntity();
            return this._repository.GetName(entity);
        }
    }
}