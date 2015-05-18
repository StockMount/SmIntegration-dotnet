using System;

namespace Haser.SmIntegration.Sample.Model.General
{
    public class ResultModel
    {
        public ResultModel()
        {
            Result = false;
        }
        public bool Result { get; set; }
        public string Message { get; set; }
        public int ErrorId { get; set; }
        public string ErrorCode { get; set; }
        public string ErrorMessage { get; set; }
        public Byte ErrorType { get; set; }
        public object Response { get; set; }
        public string IntegrationErrorCode { get; set; }
    }
}