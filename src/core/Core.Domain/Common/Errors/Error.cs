
namespace Core.Domain.Common.Errors;

    public sealed class Error
    {
        public string Code{get;}
        public string Message{get;}
        public ErrorType Type{get;}

        public Error(string code, string message, ErrorType type)
        {
            Code = code;
            Message = message;
            Type = type;
        }
        public static Error Failure(string code, string description)
        =>new(code, description, ErrorType.Failure);
        public static Error NotFound(string code, string description)
        =>new(code, description, ErrorType.NotFound);
        public static Error Validation(string code, string description)
        =>new(code, description, ErrorType.Validation);
        public static Error Conflict(string code, string description)
        =>new(code, description, ErrorType.Conflict);
        public static Error BadRequest(string code, string description)
        =>new(code, description, ErrorType.BadRequest);
        public static Error Unauthorized(string code, string description)
        =>new(code, description, ErrorType.Unauthorized);
        public static Error Forbidden(string code, string description)
        =>new(code, description, ErrorType.Forbidden);
        public static Error InternalServerError(string code, string description)
        =>new(code, description, ErrorType.InternalServerError);
        
    }
