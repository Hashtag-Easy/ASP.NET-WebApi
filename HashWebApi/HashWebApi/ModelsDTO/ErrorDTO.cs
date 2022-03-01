namespace HashWebApi.ModelsDTO
{
    public class ErrorDTO
    {
        public string Message { get; set; }

        public ErrorDTO()
        {
            Message = string.Empty;
        }

        public ErrorDTO(string message)
        {
            Message = message ?? string.Empty;
        }
    }
}
