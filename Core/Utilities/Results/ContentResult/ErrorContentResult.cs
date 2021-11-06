namespace Core.Utilities.Results.ContentResult
{
    public class ErrorContentResult<T, TContent> : ContentResult<T, TContent>, IResult
    {
        public ErrorContentResult(T data, TContent content, string message) : base(data, content, false, message)
        {

        }
        public ErrorContentResult(T data, TContent content) : base(data, content, false)
        {

        }
        public ErrorContentResult(TContent content) : base(content, false)
        {

        }
        public ErrorContentResult(string message) : base(default, false, message)
        {

        }
        public ErrorContentResult() : base(default, false)
        {

        }
    }
}
