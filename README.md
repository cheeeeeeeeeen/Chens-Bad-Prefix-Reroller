# Chen's Bad Prefix Reroller
This tModLoader mod literally just rerolls the vanilla bad prefixes into another existing one. That's it.

One can add more (or remove some) "bad" prefixes by using Mod.Call.

Adding a bad prefix:
```cs
Mod mod = ModLoader.GetMod("ChensBadPrefixReroller");
if (mod != null)
{
    mod.Call("AddBadPrefix", PrefixID.Legendary);
    mod.Call("AddBadPrefix", ModContent.PrefixType<MyModdedPrefix>());
}
```

Removing a bad prefix:
```cs
Mod mod = ModLoader.GetMod("ChensBadPrefixReroller");
if (mod != null)
{
    mod.Call("RemoveBadPrefix", PrefixID.Awkward);
    mod.Call("RemoveBadPrefix", ModContent.PrefixType<MyModdedPrefix>());
}
```
