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
    public class DeepFreezer : ModItem
    {
        public override void SetDefaults()
        {
            // set width and height
            item.width = 70;
            item.height = 28;
            item.damage = 20;
            item.useTime = 20;
            item.useAnimation = 20;
            item.noMelee = true;
            item.useStyle = ItemUseStyleID.Shoot;
            item.shoot = ModContent.ProjectileType<DeepFreezer_P2>();
        }
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Deep Freezer");
        }
        public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
        {
            // Replace Swordfish with uhhhhhhhhhhhhhhhhhhhhhhhhhhhh DeepFreezer_P2
            Projectile.NewProjectile(player.position, player.DirectionTo(Main.MouseWorld) * 6, ModContent.ProjectileType<DeepFreezer_P2>(), 20, 5, player.whoAmI);
            return false;
        }
        public override void HoldItem(Player player) {
            for (int i = 0; i < 1; i++) {
                Vector2 pos = new Vector2(Main.MouseWorld.X + (float)Math.Tan(i), Main.MouseWorld.Y + (float)Math.Sin(i));
                //Dust.NewDustDirect(pos, Main.MouseWorld.X, (int)Main.MouseWorld.Y, DustID.IceTorch);
            }
        }
        public override void AddRecipes() {
            CreateRecipe()
                .AddIngredient(ItemID.DirtBlock)
                .Register();
        }
    }
}
