# Chen's Bad Prefix Reroller
This tModLoader mod literally just rerolls the vanilla bad prefixes into another existing one. That's it.

Do note that this mod implements a way to avoid going into an infinite loop, so only a limited number of virtual retries are implemented. If you are very unlucky, you'd still get one of the bad prefixes. Number of retries is configurable.

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
