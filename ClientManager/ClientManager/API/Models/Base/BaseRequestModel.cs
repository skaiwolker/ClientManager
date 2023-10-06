namespace API.Models.Base
{
    public abstract class BaseRequestModel
    {
        public BaseRequestModel()
        {
            Id = Guid.NewGuid();
        }

        public Guid Id { get; set; }
    }
}
