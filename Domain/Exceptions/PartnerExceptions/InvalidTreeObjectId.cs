namespace Samauma.Domain.Errors
{
    public class InvalidTreeObjectIdException : BaseException
    {
        public InvalidTreeObjectIdException() : base("005", "Invalid Tree Object Id") { }
    }
}
