using Microsoft.Xna.Framework;
using System.Collections.Generic;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using static Aerothyte.AerothytePlayer;
using Aerothyte;

namespace Aerothyte.Templates {
    public class EvokerPlayer : ModPlayer {
        #region Fields
        public float EvokerDamage = 1f;
        public float EvokerDamageMult = 1f;
        public float EvokerCritChance = 0f;

        #endregion
        #region Class Specific
        public static EvokerPlayer GetEvokerPlayer(Player p) {
            return p.GetModPlayer<EvokerPlayer>();
        }
        internal void ClearStats() {
            EvokerDamage = 1f; 
            EvokerDamageMult = 1f; 
            EvokerCritChance = 0f;
        }
        #endregion

        public override void ResetEffects() {
            ClearStats();
        }
        public override void UpdateDead() {
            ClearStats();
        }
    }
}
