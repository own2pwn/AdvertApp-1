namespace Common
{
    public class Result
    {
        public Result(bool isSuccess)
        {
            this.IsSuccess = IsSuccess;
        }
        public Result(bool isSuccess, string message)
        {
            this.IsSuccess = isSuccess;
            this.Message = message;
        }

        public bool IsSuccess { get; set; }

        public string Message { get; set; }
    }
}
