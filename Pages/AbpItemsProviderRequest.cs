namespace BlazorApp4.Pages;

public class AbpItemsProviderRequest<TGridItem>
{
    /// <summary>
    /// Gets or sets the zero-based index of the first item to be supplied.
    /// skip count
    /// </summary>
    public int StartIndex { get; init; }

    /// <summary>
    /// If set, the maximum number of items to be supplied. If not set, the maximum number is unlimited.
    /// </summary>
    public int? Count { get; init; }

    public string? Sort { get; set; }

    public CancellationToken CancellationToken { get; init; }
}