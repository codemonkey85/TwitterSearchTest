namespace TwitterSearchTest;

public static class Constants
{
    public const string SearchUrlFormat =
        "https://twitter.com/search?q=(from%3A{0})%20until%3A{3:yyyy-MM-dd}%20since%3A{2:yyyy-MM-dd}&src=typed_query&f={1}";
}
