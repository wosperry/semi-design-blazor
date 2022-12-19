using BlazorComponent.Components.Tag.Types;

namespace BlazorComponent.Components.Tag
{
    public class TagProps
    {
        public string? TagKey { get; set; }
        public TagSize? Size { get; set; }
        public TagColor? Color { get; set; }
        public TagType? Type { get; set; }
        public bool? Closable { get; set; }
        public bool? Visible { get; set; }
        public string? ClassName { get; set; }
        public string? AvatarSrc { get; set; }
        public AvatarShape? AvatarShape { get; set; }
        public TagShape? Shape { get; set; }

        // TODO: 这对不知道咋搞，先放着
        //public onClose?: (tagChildren: React.ReactNode, private event: React.MouseEvent<HTMLElement>, tagKey: string | number) => void;
        //public onClick?: React.MouseEventHandler<HTMLDivElement>;
        //public style?: React.CSSProperties;
        //public onKeyDown?: React.KeyboardEventHandler<HTMLDivElement>;
        //public 'aria-label'?: React.AriaAttributes['aria-label'];
        //public tabIndex?: number; // use internal, when tag in taInput, we want to use left arrow and right arrow to control the tag focus, so the tabIndex need to be -1.c   i
        //public onMouseEnter?: () => void
    }
}