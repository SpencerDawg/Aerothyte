using Microsoft.Xna.Framework;
using System.Collections.Generic;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using On.Terraria;
using MonoMod;
using static Aerothyte.AerothytePlayer;
using Aerothyte;
using Aerothyte.Projectiles.GlacialQuartzP;
using System;

namespace Aerothyte.Items.Tools
{
    public class FourTimesFourPick : ModItem
    {
        public override string Texture => Aerothyte.GetVanillaItemTexture(ItemID.Swordfish);
        public override void SetDefaults()
        {
            item.width = 32;
            item.height = 32;
            item.damage = 10;
            item.useStyle = ItemUseStyleID.SwingThrow;
            item.useAnimation = 20;
            item.useTime = 20;
            item.pick = 20;

        }
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("(Dev) 4x4 Pick");
            Tooltip.SetDefault("DEVELOPERS DEVELOPERS DEVELOPERS DEVELOPERS");
        }
        public override bool UseItem(Terraria.Player player)
        {
            AerothyteTileMethods.BreakMultiplePlus(Terraria.Main.MouseWorld / 16);
            return true;
        }
    }
}
