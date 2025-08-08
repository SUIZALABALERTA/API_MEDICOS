namespace Domain.Models;

public static class SD
{
    public static class Api
    {
        public static readonly string InstanceId = Guid.NewGuid().ToString().Substring(0, 8).ToUpper();
    }

    public static class Environments
    {
        public static readonly string Production = "Production";
        public static readonly string Qa = "Qa";
        public static readonly string Development = "Development";
    }

    public static class Cors
    {
        public static readonly string DefaultPolicy = "DefaultPolicy";

        public static readonly string[] Origins = new string[] {
                "http://localhost:3000" ,
                "http://localhost:3001" ,
                "http://localhost:5173" ,
                "http://localhost:5174" ,
                "https://app.suiza-soft.com",
                "https://dev.suiza-soft.com",
                "https://qa.suiza-soft.com",
                "https://qa.suizalab.online",
                "https://suizacitas.suizalab.online"
        };
    }

    public enum ApiType
    {
        GET,
        POST,
        PUT,
        DELETE
    }

}
