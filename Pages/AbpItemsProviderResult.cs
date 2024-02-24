namespace BlazorApp4.Pages;

public class AbpItemsProviderResult<TGridItem>
{
    public List<TGridItem> Items { get; set; }

    public int TotalCount { get; set; }
}