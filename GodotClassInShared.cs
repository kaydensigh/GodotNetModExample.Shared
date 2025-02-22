using Godot;

namespace GodotNetModExample.SharedAssets;

public partial class GodotClassInShared : PanelContainer
{
    protected virtual StyleBox StyleBox { get; } = GD.Load<StyleBox>("res://SharedAssets/style_box.tres");

    protected Container Container;

    public override void _Ready()
    {
        AddThemeStyleboxOverride("panel", StyleBox);

        Container = new VBoxContainer();
        AddChild(Container);
        Container.AddChild(new Label { Text = GetType().Name });
    }
}
