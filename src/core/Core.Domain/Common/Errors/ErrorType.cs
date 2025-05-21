namespace Core.Domain.Common.Errors
{
    public enum ErrorType
    {
        Failure = 0,
        NotFound = 1,
        Validation = 2,
        Conflict = 3,
        BadRequest = 4,
        Unauthorized = 5,
        Forbidden = 6,
        InternalServerError = 7,
    }
}