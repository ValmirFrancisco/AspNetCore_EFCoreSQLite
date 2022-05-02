using Data.Context;

namespace AspNetCore_EFCoreInMemory.Helpers
{
    public static class HelpContext
    {
        private static IHttpContextAccessor _httpContextAccessor;
        private static IConfiguration _configuration;
        private static ApiContext _apiContext;

        public static void Configure(IHttpContextAccessor httpContextAccessor, IConfiguration configuration, ApiContext apiContext)
        {
            _httpContextAccessor = httpContextAccessor;
            _configuration = configuration;
            _apiContext = apiContext;
        }

        public static HttpContext CurrentContext => _httpContextAccessor.HttpContext;
        public static IHttpContextAccessor Current => _httpContextAccessor;
        public static IConfiguration Configuration => _configuration;
        // public static ApiContext ApiContext { get => _apiContext; set => _apiContext = value; }
        public static ApiContext ApiContext => _apiContext;
    }
}
