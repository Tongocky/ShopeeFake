namespace ShopeeFake.Commons
{
    public class ApiResult<T>
    {
        public string? Message { get; set; }
        public bool IsSuccessed { get; set; }
        public T? ResultObj { get; set; }
    }
}