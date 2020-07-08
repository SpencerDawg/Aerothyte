using Microsoft.Xna.Framework;
using System.Collections.Generic;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using static Aerothyte.AerothytePlayer;
using Aerothyte;
using System;

namespace Aerothyte.Projectiles.GlacialQuartzP
{
    public class CarProj1 : ModProjectile
    {
        private int sinful;
        public override void SetDefaults()
        {
            projectile.height = 30;
            projectile.width = 32;
            projectile.damage = 10;
            projectile.timeLeft = 50;
            projectile.friendly = true;
            projectile.magic = true;
            projectile.penetrate = 3;
            projectile.aiStyle = -1;
        }
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Carámbano blast");
        }
        public override void AI()
        {
            sinful++;
            for (int i = 0; i < 3; i++)
            {
                Dust.NewDustPerfect(projectile.Center, 43, new Vector2(((float)Math.Cos(sinful) * 0.2f * (float)(i + 1 * 1.25)), (float)Math.Sin(sinful) * (float)(i * 1 * 1.25)).RotatedByRandom(25), 200, Color.Blue);
            }
        }
        public override void Kill(int timeLeft)
        {
            int SpawnedIcicles = Main.rand.Next(2, 4);
            Main.PlaySound(SoundID.Shatter, projectile.position);
            for (int i = 0; i < 20; i++)
            {
                Dust.NewDustDirect(projectile.Center, projectile.width, projectile.height, 20, default, default, 200, Color.Blue, 2.5f);
            }
            for (int i = -1; i < SpawnedIcicles - 1; i++)
            {
                int bruh = i * 15;
                Projectile.NewProjectile(new Vector2(projectile.position.X + bruh, projectile.position.Y), new Vector2(Main.rand.Next(-2, 2), Main.rand.Next(-2, 2)) + projectile.velocity, ModContent.ProjectileType<CarProj2>(), 10, 5, projectile.owner);
            }
        }
    }
}
