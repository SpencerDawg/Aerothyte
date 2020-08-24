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

        }
        public override void Kill(int timeLeft) {

        }
    }
}
