using System.Collections.Generic;

namespace Forum.Application.Models
{
    public class Result<T>
    {
        public Result()
        {
            Success = false;
        }

        public bool Success { get; set; }
        public T Data { get; set; }
        public List<string> Messages { get; set; }

        public void CreateSuccessResult(T data)
        {
            Success = true;
            Data = data;
        }

        public void CreateFailureResult(IList<string> messages)
        {
            Success = false;
            Messages = new List<string>();
            Messages.AddRange(messages);
        }

        public void CreateFailureResult(string message)
        {
            Success = false;
            Messages = new List<string>() { message };
        }
    }
}