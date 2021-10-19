using System;
using Terraria.ModLoader;

namespace ChensBadPrefixReroller
{
    public class ChensBadPrefixReroller : Mod
    {
        public override object Call(params object[] args)
        {
            string mode = args[0] as string;
            if (args.Length == 2)
            {
                switch (mode)
                {
                    case "AddBadPrefix":
                        return GlobalItemPrefix.AddBadPrefix((int)args[1]);

                    case "RemoveBadPrefix":
                        return GlobalItemPrefix.RemoveBadPrefix((int)args[1]);

                    default:
                        throw new ArgumentException("Invalid mode argument.");
                }
            }
            else throw new ArgumentException("Invalid number of arguments.");
        }
    }
}