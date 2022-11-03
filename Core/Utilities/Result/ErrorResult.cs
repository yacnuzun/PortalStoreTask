namespace Core.Utilities.Result
{
    public class ErrorResult : Result
    {
        public ErrorResult(string message) : base(false)
        {

        }
        public ErrorResult() : base(false)
        {

        }
    }
}
