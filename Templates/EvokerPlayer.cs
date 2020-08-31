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
        public int EvokerDamage = 0;
        public float EvokerDamageMult = 1f;
        public float EvokerCritChance = 0f;
        public int Energy = 0;
        #endregion
        #region Class Specific
        public static EvokerPlayer GetEvokerPlayer(Player p) {
            return p.GetModPlayer<EvokerPlayer>();
        }
        internal void ClearStats() {
            EvokerDamage = 0; 
            EvokerDamageMult = 1f; 
            EvokerCritChance = 0f;
            Energy = 0;
        }
        #endregion
        public override void PostUpdateEquips() {

        }
        public override void ResetEffects() {
            ClearStats();
        }
        public override void UpdateDead() {
            ClearStats();
        }
    }
}
