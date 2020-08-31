using Terraria;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria.ModLoader;
using Terraria.ID;
using System.Diagnostics;
using Microsoft.Xna.Framework;
using Aerothyte.Projectiles.Infuser;
using Aerothyte.Items;

namespace Aerothyte
{
    public class AerothytePlayer : ModPlayer
    {
        //public static bool? holdingAndineGreatsword = false;
        public bool? InfuserEquip = null;
        private bool InfuserActive = false;
        public static bool DebugPlayer = true;
        public int counter;
        private int i = 0;
        public override void SetupStartInventory(IList<Item> items, bool mediumcoreDeath) {
            if(!mediumcoreDeath) {
                Item note = new Item();
                note.SetDefaults(ModContent.ItemType<NoteToPlayer>());
                note.stack = 1;
                items.Add(note);
            }
        }
        public override void ResetEffects()
        {
            InfuserEquip = false;
            InfuserActive = false;
        }
        public override void UpdateEquips(ref bool wallSpeedBuff, ref bool tileSpeedBuff, ref bool tileRangeBuff)
        {
            // infuser - see projectiles/infuser and items/accessories/infuser
            if (InfuserEquip == true && !InfuserActive && player.ownedProjectileCounts[ModContent.ProjectileType<GunMount>()] < 1) { Projectile.NewProjectile(player.position, Vector2.Zero, ModContent.ProjectileType<GunMount>(), 0, 0, player.whoAmI); InfuserActive = true; }
            if (i == 300) { i = 0; Main.NewText(InfuserEquip + ", " + InfuserActive); }
        }
    }
}
