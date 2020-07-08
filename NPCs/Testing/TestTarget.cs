using Microsoft.Xna.Framework;
using System.Collections.Generic;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using static Aerothyte.AerothytePlayer;
using Aerothyte;

namespace Aerothyte.NPCs.Testing
{
    public class TestTarget : ModNPC
    {
        private int hasbeenhit;
        public override void SetStaticDefaults()
        {
            Main.npcFrameCount[npc.type] = 2;
        }
        public override void SetDefaults()
        {
            npc.aiStyle = -1;
            npc.lifeMax = 1000;
            npc.width = 24;
            npc.height = 44;
            npc.knockBackResist = 100;
        }
        public override void OnHitByItem(Player player, Item item, int damage, float knockback, bool crit)
        {
            npc.life += damage;
            hasbeenhit = 30;
            if (npc.life > npc.lifeMax) npc.life = npc.lifeMax;
        }
        public override void OnHitByProjectile(Projectile projectile, int damage, float knockback, bool crit)
        {
            npc.life += damage;
            hasbeenhit = 20;
            if (npc.life > npc.lifeMax) npc.life = npc.lifeMax;
        }
        public override void AI()
        {
            npc.velocity *= 0f;
            hasbeenhit--;
            npc.TargetClosest();
        }
        public override void FindFrame(int frameHeight)
        {
            if (hasbeenhit > 0) npc.frame.Y = frameHeight * 1;
            else npc.frame.Y = frameHeight * 0;
        }
    }
}
