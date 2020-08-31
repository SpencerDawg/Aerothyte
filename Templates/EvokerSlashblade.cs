using Microsoft.Xna.Framework;
using System.Collections.Generic;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using static Aerothyte.AerothytePlayer;
using Aerothyte;
using Microsoft.Xna.Framework.Input;
using System;

namespace Aerothyte.Templates {
    public abstract class EvokerSlashblade : EvokerWeapon {
        public List<Action<Player>> actions;
        /// <summary>
        /// Parry length in milliseconds.
        /// </summary>
        public abstract int ParryLength { get; }
        /// <summary>
        /// When hit during this period, give the most Energy
        /// </summary>
        public abstract int ParryPerfectLength { get; }
        /// <summary>
        /// Size of the slash.
        /// </summary>
        public virtual float ParrySlashMult => 1.0f;
        public virtual string SlashTexture => "Aerothyte/Templates/Resources/SlashTexture";
        public void Slash(Player p) {
            if(Terraria.GameInput.PlayerInput.GetPressedKeys().Contains(Keys.W)) {

            }
            if (Terraria.GameInput.PlayerInput.GetPressedKeys().Contains(Keys.S)) {
                if (Main.tile[(int)(p.position.X / 16), (int)(p.position.Y / 16 + 32)].active()) {
                }
            }
            if (Terraria.GameInput.PlayerInput.GetPressedKeys().Contains(Keys.A)) {

            }
            if (Terraria.GameInput.PlayerInput.GetPressedKeys().Contains(Keys.D)) {

            }
        }
        public void Parry(Player p) {

        }
        public virtual void AddToParry(Player p,  Action<Player> action) {
            actions.Add(action);
        }
        public void ParryInvoke(Player p) {
            foreach (Action<Player> a in actions) {
                a.Invoke(p);
            }
        }
    }
}
