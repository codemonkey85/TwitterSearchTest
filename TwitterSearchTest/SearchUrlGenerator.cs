namespace TwitterSearchTest;

public static class SearchUrlGenerator
{
    public static string GetSearchUrl(string userName, SearchTypes searchType, DateOnly startDate, DateOnly endDate)
    {
        var searchTypeString = searchType switch
        {
            SearchTypes.Latest => "live",
            SearchTypes.People => "user",
            SearchTypes.Photos => "image",
            SearchTypes.Videos => "video",
            _ => string.Empty,
        };

        return $"https://twitter.com/search?q=(from%3A{userName})%20until%3A{endDate:yyyy-MM-dd}%20since%3A{startDate:yyyy-MM-dd}&src=typed_query{(searchTypeString is { Length: > 0 } ? $"&f={searchTypeString}" : string.Empty)}";
    }

    public enum SearchTypes
    {
        Top,
        Latest,
        People,
        Photos,
        Videos,
    }
}
