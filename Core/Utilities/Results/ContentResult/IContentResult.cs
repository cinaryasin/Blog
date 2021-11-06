namespace Core.Utilities.Results.ContentResult
{
    public interface IContentResult<T, TContent> : IDataResult<T>
    {
        TContent Content { get; set; }
    }
}
