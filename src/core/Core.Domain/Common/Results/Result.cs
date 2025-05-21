
using Core.Domain.Common.Errors;
using System.Text.Json.Serialization;

namespace Core.Domain.Common.Results;

    public class Result
    {
        public bool IsSuccess{get;}
        [System.Text.Json.Serialization.JsonIgnore(Condition=JsonIgnoreCondition.WhenWritingDefault)]
        public Error? Error{get;}
        public static implicit operator Result(Error error)=>new(error);
        public static Result Success()=>new();
        public static Result Failure(Error error)=>new(error);
        protected Result(Error error)
        {
            
            IsSuccess=false;
            Error=error;
        }
        protected Result()
        {
            IsSuccess=true;
            Error=default;
        }
      
    }
    public class Result<T>:Result
    {
        private readonly T _value;
   
        protected Result(Error error):base(error)
        {
          _value=default!;  
        }
        protected Result(T value):base()
        {
            _value=value;
        }
        public T Value=> IsSuccess?_value:throw new InvalidOperationException("Result is not a success");
        public static implicit operator Result<T>(T value)=>new(value);
        public static implicit operator Result<T> (Error error)=>new(error);
        public static Result<T> Success(T value)=>new(value);
        public static Result<T> Failure(Error error)=>new(error);
       
    }
