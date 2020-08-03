using Microsoft.Xna.Framework;
using System.Collections.Generic;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using static Aerothyte.AerothytePlayer;
using Aerothyte;
using Aerothyte.Projectiles.GlacialQuartzP;
using System;
using Terraria.Audio;
using Aerothyte.Sounds;
using Microsoft.Xna.Framework.Graphics;
using Terraria.GameContent;

namespace Aerothyte.Projectiles.Infuser {
    public class InfuserGun : ModProjectile {
        public override bool CloneNewInstances => true;
        Projectile projectile3 = null;
        NPC target = null;
        int counter = 0;
        bool CalledOut = false;
        public override void SetDefaults() {
            projectile.friendly = true;
            projectile.damage = 0;
            projectile.height = 32;
            projectile.width = 32;
            projectile.tileCollide = false;

        }
        public override void SetStaticDefaults() {
            DisplayName.SetDefault("Infuser Blaster");
        }
        public override bool? CanCutTiles() => false;
        public override bool PreDraw(SpriteBatch spriteBatch, Color lightColor) {
            SpriteEffects spriteEffects = SpriteEffects.None;
            Texture2D texture = ModContent.GetTexture(Texture).Value;
            Rectangle sourceRectangle = new Rectangle(0, 0, texture.Width, texture.Height);
            Vector2 origin = sourceRectangle.Size() / 2f;

            Color drawColor = projectile.GetAlpha(lightColor);
            Main.spriteBatch.Draw(ModContent.GetTexture(Texture).Value, Main.player[projectile.owner].Center + new Vector2((Main.player[projectile.owner].direction * 15), 0) - Main.screenPosition + new Vector2(0f, projectile.gfxOffY), sourceRectangle, drawColor, projectile.rotation, origin, 1, spriteEffects, 0f);

            return false;
        }
        public override void AI() {

            Player player = Main.player[projectile.owner];
            projectile.Center = projectile.position / 2;
            void FullyCharged() {
                if (player.whoAmI == Main.myPlayer) CombatText.NewText(player.getRect(), Color.LightBlue, "Fully Charged!");
            }
            #region Drawing
            if (player.ownedProjectileCounts[projectile.type] > 1 || player.ownedProjectileCounts[ModContent.ProjectileType<GunMount>()] == 0 || player.dead) {
                projectile.Kill();
            }
            if (player.ownedProjectileCounts[ModContent.ProjectileType<GunMount>()] == 1) {
                if (projectile3 == null || !projectile3.active) {
                    foreach (Projectile projectile2 in Main.projectile) {
                        if (projectile2.type == ModContent.ProjectileType<GunMount>() && projectile2.owner == projectile.owner) {
                            projectile3 = projectile2;
                        }
                    }
                }
            }
            if (projectile3 != null) {
                projectile.position = player.Top;
            }
            #endregion
            #region Gun
            if (counter < 300) counter++;

            if (target == null || !target.active || projectile.Distance(target.position) > 100) {
                for (int i = 0; i < 200; i++) {
                    if (Main.npc[i].active && projectile.Distance(Main.npc[i].position) <= 100 && Main.npc[i].CanBeChasedBy()) {
                        target = Main.npc[i];
                    }
                }
            }
            bool hastarget; if (target != null) { hastarget = true; }
            else hastarget = false;
            if (counter == 300 && CalledOut == false) {
                if (target != null) {
                    if (target.Distance(player.position) > 150) {
                        FullyCharged();
                        CalledOut = true;
                    }
                }
            }
            if (target != null && target.active && target.Distance(projectile.position) < 150) projectile.rotation = projectile.DirectionTo(target.Center).ToRotation();
            if (hastarget && target.active && counter >= 300 && target.Distance(projectile.position) < 150 && player.statMana >= 50) {
                if (projectile.owner == Main.myPlayer) Projectile.NewProjectile(player.Center, projectile.DirectionTo(target.Center) * 20, ProjectileID.WaterBolt, 40, 5, projectile.owner);
                player.statMana -= 50;
                Terraria.Audio.SoundEngine.PlaySound(SoundLoader.customSoundType, -1, -1, Mod.GetSoundSlot(Terraria.ModLoader.SoundType.Custom, "Sounds/InfuserS"));
                counter = 0;
                CalledOut = false;
            }
            #endregion

        }
    }
}