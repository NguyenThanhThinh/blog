namespace Blog.Core
{
    public interface IHasOwner
    {
        long CreatedBy { get; set; }

        long ModifiedBy { get; set; }
    }
}