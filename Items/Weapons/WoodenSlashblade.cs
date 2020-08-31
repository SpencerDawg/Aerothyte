using Microsoft.Xna.Framework;
using System.Collections.Generic;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using static Aerothyte.AerothytePlayer;
using Aerothyte;
using Microsoft.Xna.Framework.Input;
using System;
using Aerothyte.Templates;

namespace Aerothyte.Items.Weapons {
    public class WoodenSlashblade : EvokerSlashblade {
        public override int ParryLength => 30;
        public override int ParryPerfectLength => 10;

        public override void SetDefaults() {
            SetStats(
                damage: 10,
                critChance: 0.4f);
            item.height = 46;
            item.width = 28;
        }
        public override bool UseItem(Player player) {
            Slash(player);
            return true;
        }
        public override bool AltFunctionUse(Player player) {
            return true;
        }
    }
}
