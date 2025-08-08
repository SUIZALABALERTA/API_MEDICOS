namespace Infrastructure.ExternalServices.SaveFileAwsApi;


public class EndPoints
{
    public class SaveFilesAws
    {
        private const string PathEndpoint = "/api/files-upload";
        public static string SaveFiles => $"{PathEndpoint}";

    }
}

