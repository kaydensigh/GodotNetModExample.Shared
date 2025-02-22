using Godot;

#if !NESTED_GODOT_LIB

public partial class GodotClassInShared : GodotNetModExample.Shared.GodotClassInShared {}

#else

namespace GodotNetModExample.Shared;

/// <summary>
/// A class in the submodule that can be instantiated from C#.
/// </summary>
public partial class GodotClassInShared : PanelContainer
{
    protected virtual StyleBox StyleBox { get; } = GD.Load<StyleBox>("res://Shared/style_box.tres");

    protected Container Container;

    public override void _Ready()
    {
        AddThemeStyleboxOverride("panel", StyleBox);

        Container = new VBoxContainer();
        AddChild(Container);
        Container.AddChild(new Label { Text = GetType().Name });
    }
}

#endif
