using Microsoft.Xna.Framework;
using System.Collections.Generic;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using static Aerothyte.AerothytePlayer;
using Aerothyte;
using Microsoft.Xna.Framework.Graphics;
using Terraria.IO;
using Terraria.Audio;

namespace Aerothyte.Items.Weapons.GlacialQuartzI
{
    public class GlacialHanger : ModItem
    {
        private bool broken = false;
        private int brokenTimer = 0;
        private float counter = 0.1f;
        public static int ass;
        public override void SetDefaults()
        {
            item.width = 54;
            item.height = 54;
            item.damage = 20; // balance it!!!
            item.autoReuse = true;
            item.useTime = 20;
            item.useAnimation = 20;
            item.useStyle = ItemUseStyleID.Swing;
        }
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Glacial Hanger");
            Tooltip.SetDefault("Right click to jump at the expense of your sword");
        }
        public override bool CanUseItem(Player player) { if (broken) return false; return true; }
        public override bool UseItem(Player player)
        {
            if (player.altFunctionUse == 2)
            {
                broken = true;
                SoundEngine.PlaySound(SoundID.Shatter);
                player.velocity.Y = 0;
                player.velocity.Y -= 10;
                for (int i = 0; i < 20; i++)
                {
                    Dust.NewDust(player.position, player.width, player.height, DustID.Ice);
                }
                for (int i = 0; i < 4; i++)
                {
                    Projectile.NewProjectile(player.Center, player.DirectionTo(Main.MouseWorld).RotatedByRandom(MathHelper.ToRadians(30f)) * Main.rand.Next(4, 7), Mod.ProjectileType("GlacialHanger" + i), 10, 5, player.whoAmI);
                }
            }
            return true;
        }
        public override bool AltFunctionUse(Player player)
        {
            if (!broken) return true;
            return false;
        }
        public override void HoldItem(Player player)
        {
            if(broken)
            {
                if (brokenTimer <= 600) brokenTimer++; if (counter < 1) counter += 0.01f;
            }
            if (brokenTimer == 600)
            { 
                broken = false;
                brokenTimer = 0;
                counter = 0.1f;
            }
        }
        public override void PostDrawInInventory(SpriteBatch spriteBatch, Vector2 position, Rectangle frame, Color drawColor, Color itemColor, Vector2 origin, float scale)
        {
            if (broken)
            {
                AerothyteItem.DrawAsInactive(Color.DarkSlateBlue * counter, ModContent.GetTexture(Texture).Value, position, frame, scale, origin);
            }
        }
    }
}
