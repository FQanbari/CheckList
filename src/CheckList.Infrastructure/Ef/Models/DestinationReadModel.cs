namespace CheckList.Infrastructure.Ef.Models;

public class DestinationReadModel
{
    public string City { get; set; }
    public string Country { get; set; }

    public static DestinationReadModel Create(string value)
    {
        var SplitLocalization = value.Split(',');

        return new DestinationReadModel { City = SplitLocalization.First(), Country = SplitLocalization.Last() };
    }

    public override string ToString()
        => $"{City}, {Country}";
}
