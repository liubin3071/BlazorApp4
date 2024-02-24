using Microsoft.AspNetCore.Components;

namespace BlazorApp4.Pages;

public class AbpDataGrid<TGridItem> : ComponentBase
{
    // [Parameter] public RenderFragment ChildContent { get; set; }

    [Parameter] public RenderFragment EmptyContent { get; set; }

    [Parameter] public RenderFragment EmptyCellTemplate { get; set; }

    [Parameter] public RenderFragment LoadingTemplate { get; set; }
    [Parameter] public RenderFragment DataGridColumns { get; set; }

    [Parameter] public bool Virtualize { get; set; }

    /// <summary>
    /// 静态数据
    /// </summary>
    [Parameter]
    public virtual IEnumerable<TGridItem>? Items { get; set; } = null;

    /// <summary>
    /// 项目提供者, 与静态数据互斥
    /// </summary>
    [Parameter]
    public virtual ItemsProvider<TGridItem>? ItemsProvider { get; set; }


    protected override Task OnParametersSetAsync()
    {
        if (Items is not null && ItemsProvider is not null)
        {
            throw new InvalidOperationException(
                $"FluentDataGrid requires one of {nameof(Items)} or {nameof(ItemsProvider)}, but both were specified.");
        }

        return base.OnParametersSetAsync();
    }
}