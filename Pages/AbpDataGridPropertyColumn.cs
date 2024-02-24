using System.Linq.Expressions;
using Microsoft.AspNetCore.Components;

namespace BlazorApp4.Pages;

public class AbpDataGridPropertyColumn<TGridItem, TProp> : ComponentBase
{
    [Parameter, EditorRequired] public Expression<Func<TGridItem, TProp>> Property { get; set; }
}