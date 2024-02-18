namespace CheckList.Infrastructure.Ef.Models;

public class DestinationReadModels
{
    public string City { get; set; }
    public string Country { get; set; }

    public static DestinationReadModels Create(string value)
    {
        var SplitLocalization = value.Split(',');

        return new DestinationReadModels { City = SplitLocalization.First(), Country = SplitLocalization.Last() };
    }

    public override string ToString()
        => $"{City}, {Country}";
}
