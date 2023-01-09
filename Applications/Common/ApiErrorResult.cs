using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Applications.Common
{
    public class ApiErrorResult<T> : ApiResult<T>
    {
        public string[] ValidatetionErrors { get; set; }
        public ApiErrorResult(string? message)
        {
            IsSuccessed = false;
            Message = message;

        }
        public ApiErrorResult(string[] validatetionErrors)
        {
            IsSuccessed = false;
            ValidatetionErrors = validatetionErrors;

        }
        public ApiErrorResult()
        {
            IsSuccessed = false;

        }
    }
}
