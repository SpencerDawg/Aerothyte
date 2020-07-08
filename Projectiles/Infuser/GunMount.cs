using Microsoft.Xna.Framework;
using System.Collections.Generic;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using static Aerothyte.AerothytePlayer;
using Aerothyte;
using Aerothyte.Projectiles.GlacialQuartzP;
using System;

namespace Aerothyte.Projectiles.Infuser
{
    public class GunMount : ModProjectile
    {
        public override void SetDefaults()
        {
            projectile.friendly = true;
            projectile.damage = 0;
            projectile.height = 32;
            projectile.width = 24;
            projectile.tileCollide = false;
        }
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Infuser Gun Mount");
        }
        public override void DrawBehind(int index, List<int> drawCacheProjsBehindNPCsAndTiles, List<int> drawCacheProjsBehindNPCs, List<int> drawCacheProjsBehindProjectiles, List<int> drawCacheProjsOverWiresUI)
        {
            drawCacheProjsBehindNPCsAndTiles.Add(index);
        }
        public override bool? CanCutTiles() => false;
        public override void AI()
        {

            Player player = Main.player[projectile.owner];
            if (player.GetModPlayer<AerothytePlayer>().InfuserEquip == false || player.dead)
            {
                projectile.Kill();
            }

            switch (player.direction)
            {
                default:
                    projectile.spriteDirection = 0;
                    projectile.position = player.Center;
                    break;
                case -1:
                    projectile.spriteDirection = -1; // left
                    projectile.position = player.Center + new Vector2(-2, -20);
                    break;
                case 1:
                    projectile.spriteDirection = 1; // right
                    projectile.position = player.Center + new Vector2(-22, -20);
                    break;
            }

            if (player.ownedProjectileCounts[ModContent.ProjectileType<InfuserGun>()] < 1)
            {
                Projectile.NewProjectile(projectile.Top, Vector2.Zero, ModContent.ProjectileType<InfuserGun>(), 0, 0, projectile.owner);
            }
        }
    }
}
