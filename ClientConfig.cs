using System.ComponentModel;
using Terraria.ModLoader.Config;

namespace ChensBadPrefixReroller
{
    public class ClientConfig : ModConfig
    {
        public override ConfigScope Mode => ConfigScope.ClientSide;

        [Label("Retry Attempts")]
        [Tooltip("The number of retries when a bad prefix is acquired.\n" +
                 "Reaching max retries will stop the re-roll and leave the item with a bad prefix.\n" +
                 "Higher retries also mean that one may experience frame drops if unlucky.")]
        [Range(0, 1000)]
        [Increment(1)]
        [DrawTicks]
        [DefaultValue(10)]
        public int retryAttempts;
    }
}