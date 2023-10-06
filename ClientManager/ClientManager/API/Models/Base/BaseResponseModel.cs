namespace API.Models.Base
{
    public abstract class BaseResponseModel
    {
        public BaseResponseModel()
        {
            Id = Guid.NewGuid();
        }

        public Guid Id { get; set; }
    }
}
