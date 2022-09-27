namespace Samauma.Domain.Errors
{
    public class InvalidTreeObjectIdException : BaseException
    {
        public InvalidTreeObjectIdException() : base("007", "Invalid Tree Object Id") { }
    }
}
