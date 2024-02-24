using Microsoft.AspNetCore.Components;

namespace BlazorApp4.Pages;

public class AbpDataGridTemplateColumn<TGridItem> : ComponentBase
{
    [Parameter] public string Title { get; set; }
    [Parameter] public RenderFragment<TGridItem> ChildContent { get; set; }
}