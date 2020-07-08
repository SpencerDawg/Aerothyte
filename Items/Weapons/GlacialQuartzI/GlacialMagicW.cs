using Microsoft.Xna.Framework;
using System.Collections.Generic;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using static Aerothyte.AerothytePlayer;
using Aerothyte;
using Aerothyte.Projectiles.GlacialQuartzP;
using System;

namespace Aerothyte.Items.Weapons.GlacialQuartzI
{
    public class GlacialMagicW : ModItem
    {
        public override void SetDefaults()
        {
            item.width = 32;
            item.height = 32;
            item.magic = true;
            item.mana = 15;
            item.damage = 20;
            item.knockBack = 5;
            item.useTime = 15;
            item.noMelee = true;
            item.useAnimation = 15;
            item.useStyle = ItemUseStyleID.Swing;
            item.shoot = ModContent.ProjectileType<CarProj1>();

        }
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Carámbano");
            Tooltip.SetDefault("Fires a projectile which explodes into a shower of icicles.");
        }
        public override bool CanUseItem(Player player)
        {
            return player.ownedProjectileCounts[item.shoot] < 2;
        }
        public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
        {
            Projectile.NewProjectile(player.Center, player.DirectionTo(Main.MouseWorld).RotatedByRandom(0.3) * Main.rand.Next(4,6) + (player.velocity * 0.2f), ModContent.ProjectileType<CarProj1>(), 10, 5, player.whoAmI);
            return false;

        }
        public override void AddRecipes()
        {
          
        }
        public override void ModifyTooltips(List<TooltipLine> tooltips)
        {
            foreach(TooltipLine tooltip in tooltips)
            {
                if(tooltip.mod == "Terraria" && tooltip.Name == "Tooltip0")
                {
                    tooltip.overrideColor = Color.CornflowerBlue;
                    break;
                }
            }
        }
    }
}
