namespace Domain.Models;

public class DatabaseSettings
{
    public const string SectionName = "ConnectionStrings";

    public string PostgresSQLConnection { get; set; } = default!;
}

