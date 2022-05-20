using WasmDemo.Shared;

namespace WasmDemo.Server.Handlers
{
    public class RequestHandler<TDto> : IHandler<TDto>
    {
        private readonly ILogger<RequestHandler<TDto>> _logger = default!;
        private readonly IRepository<TDto> _repo = default!;
        public CommonResponse<TDto> HandleRequest(CommonRequest request)
        {
            throw new NotImplementedException();
        }
    }

    public interface IRepository<TDto>
    {
        TDto Get();
        
    }
    
    public class Repository<TDto> : IRepository<TDto>
    {
        public TDto Get()
        {
            throw new NotImplementedException();
        }
    }

    public static class RequestBuilder<TDto>
    {
        public static CommonRequest Get() => new($"GET-{typeof(TDto)}") { };
        public static CommonRequest Post => new($"POST-{typeof(TDto)}");
        public static CommonRequest Put => new($"PUT-{typeof(TDto)}");
        public static CommonRequest Delete => new($"DELETE-{typeof(TDto)}");        
    }


    public static class ResponseBuilder<TDto>
    {
        private static Dictionary<Type, string> _getActions = new()
        {
            
        };
        //public static CommonResponse<TDto> Get => new(default(TDto));
    }

    public interface IHandler<TDto>
    {
        public CommonResponse<TDto> HandleRequest(CommonRequest request);
    }

    public class CommonRequest
    {
        public string RequestType { get; set; }
        public Guid CorrelationID { get; set; }
        public SortedList<string, object> QueryParameters { get; set; }
        public SortedList<string, object> ResultParameters { get; set; }
        public SortedList<string, object> ACLParameters { get; set; }

        public CommonRequest(string requestType)
        {
            QueryParameters = new SortedList<string, object>();
            ResultParameters = new SortedList<string, object>();
            ACLParameters = new SortedList<string, object>();
            RequestType = requestType;
            CorrelationID = Guid.NewGuid();
        }
    }

    public class CommonResponse<TData> 
    {
        public Dictionary<string, object> Metadata { get; set; } = default!;
        public List<TData> Payload { get; set; } = default!;

        public int Rows { get; set; }
        public bool Success { get; set; }
        public string ErrorMessage { get; set; } = default!;
        public Guid CorrelationID { get; set; }
    }
}
