namespace Core.Utilities.Results.ContentResult
{
    public class SuccessContentResult<T, TContent> : ContentResult<T, TContent>, IResult
    {
        public SuccessContentResult(T data, TContent content, string message) : base(data, content, true, message)
        {

        }
        public SuccessContentResult(T data, TContent content) : base(data, content, true)
        {

        }
        public SuccessContentResult(TContent content) : base(content, true)
        {

        }
        public SuccessContentResult(string message) : base(default, true, message)
        {

        }
        public SuccessContentResult() : base(default, true)
        {

        }
    }
}
