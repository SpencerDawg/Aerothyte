using Microsoft.Xna.Framework;
using System.Collections.Generic;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using static Aerothyte.AerothytePlayer;
using Aerothyte;
using System;

namespace Aerothyte.Projectiles.GlacialQuartzP {
    public class CarProj2 : ModProjectile {

        public override void SetDefaults() {
            projectile.height = 30;
            projectile.width = 24;
            projectile.damage = 10;
            projectile.timeLeft = 100;
            projectile.friendly = true;
            projectile.magic = true;
            projectile.aiStyle = -1;
            projectile.penetrate = 1;
            }
        public override void SetStaticDefaults() {

            DisplayName.SetDefault("Carámbano Icicle");
            }
        public override void AI() {
            projectile.ai[0]++;
            if (projectile.ai[0] % 20 == 0) {
                projectile.damage *= 3;
                }
            if (projectile.damage > 60) {
                projectile.damage = 60;
                }
            projectile.rotation = MathHelper.SmoothStep(projectile.velocity.ToRotation(), projectile.oldVelocity.ToRotation(), projectile.timeLeft) + MathHelper.PiOver2;
            if (projectile.timeLeft > 90) projectile.tileCollide = false;
            else projectile.tileCollide = true;
            projectile.velocity.Y += 0.7f;

            }

        public override void Kill(int timeLeft) {
            for (int i = 0; i < 10; i++) {
                Dust.NewDust(projectile.position, projectile.width, projectile.height, 20, default, default, Main.rand.Next(50, 200), Color.Blue);
                }
            }
        }
    }
