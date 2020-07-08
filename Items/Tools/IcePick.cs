using Microsoft.Xna.Framework;
using System.Collections.Generic;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using static Aerothyte.AerothytePlayer;
using Aerothyte;
using Aerothyte.Projectiles.GlacialQuartzP;
using System;

namespace Aerothyte.Items.Tools
{
    public class IcePick : ModItem
    {
        public override string Texture => "Aerothyte/Items/Tools/IcePick";
        public override void SetDefaults()
        {
            item.width = 32;
            item.height = 32;
            item.damage = 10;
            item.useStyle = ItemUseStyleID.SwingThrow;
            item.useAnimation = 20;
            item.useTime = 20;
            item.pick = 50;
            item.rare = Aerothyte.GlacialQuartzRarityID;
            item.autoReuse = true;
        }
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Ice Pick");
            Tooltip.SetDefault("Once featured in uh.. [c/F36b09:Quarter Life 2], or something.");
         
        }
        /**public override bool UseItem(Player player)
        {
            Vector2 tilepos = new Vector2((float)Math.Floor(Main.MouseWorld.X * 16), (float)Math.Floor(Main.MouseWorld.Y * 16));
            bool CanBeMined()
            {

                if(Vector2.Distance(player.position, tilepos) < (player.blockRange * 16) % 16)
                {
                    return true;
                }
                return false;
            }
            Tile tiletype = Main.tile[(int)tilepos.X, (int)tilepos.Y];
            if (tiletype.type == TileID.SnowBlock && CanBeMined() || tiletype.type == TileID.IceBlock && CanBeMined())
            {
                WorldGen.KillTile((int)tilepos.X, (int)tilepos.Y, true);
            }
                return true;
        }**/
    }
}
