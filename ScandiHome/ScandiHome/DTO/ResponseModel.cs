namespace ScandiHome
{
    public class ResponseModel<T>
    {
        public bool Succeeded { get; set; }
        public string Message { get; set; }
        public string Errors { get; set; }
        public T Data { get; set; }

        public ResponseModel() { }

        public ResponseModel(T pData, string pMessage = null)
        {
            Data = pData;
            Message = pMessage;
        }

        public ResponseModel(bool pSucceeded, string pMessage, string pErrors)
        {
            Succeeded = pSucceeded;
            Message = pMessage;
            Errors = pErrors;
        }

        public ResponseModel(T pData, bool pSucceeded, string pMessage, string pErrors)
        {
            Data = pData;
            Succeeded = pSucceeded;
            Message = pMessage;
            Errors = pErrors;
        }
    }
}
