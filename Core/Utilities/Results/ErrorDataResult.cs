namespace Core.Utilities.Results
{
    public class ErrorDatResult<T> : DataResult<T>
    {
        public ErrorDatResult(T data, string message) : base(data, false, message)
        {

        }

        public ErrorDatResult(T data) : base(data, false)
        {

        }

        public ErrorDatResult(string message) : base(default, false, message)
        {

        }

        public ErrorDatResult() : base(default, false)
        {

        }
    }
}
