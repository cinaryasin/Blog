using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Utilities.Results.ContentResult
{
    public class ContentResult<T, TContent> : Result, IContentResult<T, TContent>
    {


        public ContentResult(T data, TContent content, bool success, string message) : base(success, message)
        {
            Data = data;
            Content = content;
        }
        public ContentResult(TContent content, bool success, string message) : base(success, message)
        {

            Content = content;
        }

        public ContentResult(T data, TContent content, bool success) : base(success)
        {
            Data = data;
            Content = content;

        }
        public ContentResult(TContent content, bool success) : base(success)
        {

            Content = content;

        }


        public TContent Content { get; set; }

        public T Data { get; set; }


    }
}
