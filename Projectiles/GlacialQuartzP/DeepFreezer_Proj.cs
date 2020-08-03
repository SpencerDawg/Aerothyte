using Microsoft.Xna.Framework;
using System.Collections.Generic;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using static Aerothyte.AerothytePlayer;
using Aerothyte;
using System;

namespace Aerothyte.Projectiles.GlacialQuartzP {
    public class DeepFreezer_P : ModProjectile {
        // Projectile here is invisible and serves as flak;
        // Is the part that glows. And stuff.
        public override void SetDefaults() {

        }
        public override void SetStaticDefaults() {
            DisplayName.SetDefault("Frost Spark");
        }
        public override void AI() {
            
        }
    }
    public class DeepFreezer_P2 : ModProjectile {
        // snowbol. phat projectile.
        public override void SetDefaults() {
            projectile.height = 28;
            projectile.width = 28;
            projectile.friendly = true;
            projectile.damage = 10;
            projectile.knockBack = 2;
            projectile.timeLeft = 600;
        }
        public override void SetStaticDefaults() {
            DisplayName.SetDefault("Blue Balls");
        }
        public override void AI() {
            for (int i = 0; i < 1; i++) {
                float position = projectile.position.X + (float)Math.Tan(i);
                float position2 = projectile.position.Y + (float)Math.Sin(i);
                Dust.NewDustDirect(new Vector2(position, position2), projectile.width, projectile.height, DustID.IceTorch);
            }
        }
        public override void Kill(int timeLeft) {
            for (int i = 0; i < 32; i++) {
                float position = projectile.position.X + (float)Math.Tan(i);
                float position2 = projectile.position.Y + (float)Math.Sin(i);
                Dust.NewDust(new Vector2(position, position2), projectile.width, projectile.height, DustID.Fireworks);
            }
        }
    }
}
