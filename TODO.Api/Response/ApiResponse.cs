namespace TODO.Models;

public class ApiResponse<T>
{
    public T Data { get; set; }
    public MetaData Metadata { get; set; }
}