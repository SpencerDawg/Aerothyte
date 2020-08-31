using Microsoft.Xna.Framework;
using System.Collections.Generic;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using static Aerothyte.AerothytePlayer;
using Aerothyte;

namespace Aerothyte.Templates {
    public abstract class EvokerWeapon : ModItem {
        public void SetStats(int damage, float critChance) {
            item.GetGlobalItem<EvokerItem>().EvokerDamage = damage;
            item.GetGlobalItem<EvokerItem>().EvokerCritChance = critChance;
            item.GetGlobalItem<EvokerItem>().Evoker = true;
        }
    }
}
