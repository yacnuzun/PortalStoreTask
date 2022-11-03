namespace Core.Utilities.Result
{
    public class SuccessResult : Result, IResult
    {
        public SuccessResult(string message) : base(true)
        {

        }
        public SuccessResult() : base(true)
        {

        }
    }
}
