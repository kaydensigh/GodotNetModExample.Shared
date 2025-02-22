using Godot;

namespace GodotNetModExample.SharedAssets;

/// <summary>
/// Script attached to a scene resource in the submodule.
/// </summary>
public partial class SceneInShared : PanelContainer
{
    public override void _Ready()
    {
        var container = GetNode<Container>("Container");

        // Instantiate a non-scene class from this mod.
        container.AddChild(new GodotClassInShared { Name = nameof(GodotClassInShared) });
    }
}
