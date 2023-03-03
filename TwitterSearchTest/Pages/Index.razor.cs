namespace TwitterSearchTest.Pages;

public partial class Index
{
    private const string PageTitle = @"Twitter Search";

    private string UserName { get; set; } = "twitter";

    private SearchTypes SearchType { get; set; } = SearchTypes.Top;

    private DateOnly StartDate { get; set; } = DateOnly.FromDateTime(DateTime.Now.AddDays(-1));

    private DateOnly EndDate { get; set; } = DateOnly.FromDateTime(DateTime.Now);

    private async Task DoSearchAsync()
    {
        var searchUrl = GetSearchUrl(UserName, SearchType, StartDate, EndDate);
        await JsRuntime.InvokeVoidAsync("open", searchUrl, "_blank");
    }
}
