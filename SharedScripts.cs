using Godot.Bridge;

namespace GodotNetModExample.Shared;

/// <summary>
/// Godot registers the scripts of a project's own assembly and of no other, so a scene that has one of this
/// library's scripts on a node fails to load until something registers them. Whichever project starts first
/// calls this, before it loads any such scene.
/// </summary>
public static class SharedScripts
{
    private static bool _registered;

    /// <summary>Registers this library's scripts with Godot. Safe to call more than once.</summary>
    public static void Register()
    {
        if (_registered)
            return;
        _registered = true;

        ScriptManagerBridge.LookupScriptsInAssembly(typeof(SharedScripts).Assembly);
    }
}
