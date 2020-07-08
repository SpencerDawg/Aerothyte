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
    public class GlacialHanger1 : ModProjectile
    {
        public override void SetDefaults()
        {
            projectile.height = 30;
            projectile.width = 16;
            projectile.friendly = true;
            
        }
        public override void AI()
        {
            projectile.velocity.Y += 0.7f;
            projectile.rotation += Main.rand.NextFloat(0.05f, 0.1f);
        }
    }
    public class GlacialHanger2 : ModProjectile
    {
        public override void SetDefaults()
        {
            projectile.height = 16;
            projectile.width = 16;
            projectile.friendly = true;

        }
        public override void AI()
        {
            projectile.rotation += Main.rand.NextFloat(0.05f, 0.1f);
            projectile.velocity.Y += 0.7f;
        }
    }
    public class GlacialHanger3 : ModProjectile
    {
        public override void SetDefaults()
        {
            projectile.height = 16;
            projectile.width = 16;
            projectile.friendly = true;
        }
        public override void AI()
        {
            projectile.rotation += Main.rand.NextFloat(0.05f, 0.1f);
            projectile.velocity.Y += 0.7f;
        }
    }
    public class GlacialHanger4 : ModProjectile
    {
        public override void SetDefaults()
        {
            projectile.height = 16;
            projectile.width = 16;
            projectile.friendly = true;
        }
        public override void AI()
        {
            projectile.rotation += Main.rand.NextFloat(0.05f, 0.1f);
            projectile.velocity.Y += 0.7f;
        }
    }
}
