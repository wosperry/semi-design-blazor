using BlazorComponent.Components.Tag.Types;
using Microsoft.AspNetCore.Components.Web;

namespace BlazorComponent;

public partial class STag
{
    [Parameter]
    public RenderFragment ChildContent { get; set; }

    [Parameter]
    public string AvatarSrc { get; set; }

    [Parameter]
    public AvatarShape AvatarShape { get; set; } = AvatarShape.Circle;

    private const string PrefixCls = "semi-tag";
}