using Terraria.ID;
using System.Collections.Generic;
using Terraria;
using Terraria.ModLoader;

namespace ChensBadPrefixReroller
{
    public class GlobalItemPrefix : GlobalItem
    {
        private static readonly List<int> badPrefixes = new List<int>()
        {
            PrefixID.Broken, PrefixID.Damaged, PrefixID.Shoddy, PrefixID.Weak, PrefixID.Slow,
            PrefixID.Lazy, PrefixID.Annoying, PrefixID.Tiny, PrefixID.Terrible, PrefixID.Small,
            PrefixID.Unhappy, PrefixID.Awful, PrefixID.Lethargic, PrefixID.Awkward, PrefixID.Inept,
            PrefixID.Deranged, PrefixID.Ignorant, PrefixID.Sluggish, PrefixID.Dull
        };

        private static int retries = 0;

        public override bool AllowPrefix(Item item, int pre)
        {
            if (badPrefixes.Contains(pre))
            {
                if (++retries >= ModContent.GetInstance<ClientConfig>().retryAttempts)
                {
                    retries = 0;
                    return true;
                }
                else return false;
            }
            else
            {
                retries = 0;
                return true;
            }
        }

        public static bool AddBadPrefix(int pre)
        {
            if (badPrefixes.Contains(pre)) return false;
            else
            {
                badPrefixes.Add(pre);
                return true;
            }
        }

        public static bool RemoveBadPrefix(int pre)
        {
            if (badPrefixes.Contains(pre))
            {
                badPrefixes.Remove(pre);
                return true;
            }
            else return false;
        }
    }
}