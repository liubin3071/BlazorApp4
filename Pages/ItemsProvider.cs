namespace BlazorApp4.Pages;

public delegate ValueTask<AbpItemsProviderResult<TGridItem>> ItemsProvider<TGridItem>(
    AbpItemsProviderRequest<TGridItem> request);