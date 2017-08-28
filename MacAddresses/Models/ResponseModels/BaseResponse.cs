namespace MacAddresses.Models.ResponseModels
{
    public class BaseResponse
    {
        public bool IsSuccess { get; set; }
        public string[] Messages { get; set; }
    }
}