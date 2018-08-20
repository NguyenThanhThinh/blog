namespace Blog.Core
{
    public class Entity<T> : IEntity<T>
    {
        public T Id { get; set; }
    }
}
