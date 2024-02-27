using System.Net;

namespace CTS.Result;
public sealed class Result<T>
{
    public T? Data { get; set; }
    public List<string>? ErrorMessages { get; set; }
    public bool IsSuccess { get; set; } = true;
    public int StatusCode { get; set; } = (int)HttpStatusCode.OK;

    public Result(T data)
    {
        Data = data;
    }

    public Result(int statusCode, List<string> errorMessages)
    {
        IsSuccess = false;
        StatusCode = statusCode;
        ErrorMessages = errorMessages;
    }

    public Result(int statusCode, string errorMessage)
    {
        IsSuccess = false;
        StatusCode = statusCode;
        ErrorMessages = new() { errorMessage };
    }

    public static implicit operator Result<T>(T data)
    {
        return new(data);
    }
    public static implicit operator Result<T>((int statusCode, List<string> errorMessages) parameters)
    {
        return new(parameters.statusCode, parameters.errorMessages);
    }
    public static implicit operator Result<T>((int statusCode, string errorMessage) parameters)
    {
        return new(parameters.statusCode, parameters.errorMessage);
    }
}
