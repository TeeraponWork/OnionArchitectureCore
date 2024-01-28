using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnionArchitectureCore.Domain.Result
{
    public class ResultModel<T>
    {
        public bool IsSuccess { get; set; }
        public T Value { get; set; }
        public string Error { get; set; }

        public static ResultModel<T> Success(T value) => new ResultModel<T> { IsSuccess = true, Value = value };
        public static ResultModel<T> Failure(string error) => new ResultModel<T> { IsSuccess = false, Error = error };
    }
}
