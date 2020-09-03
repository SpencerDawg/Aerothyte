using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Aerothyte;
using Aerothyte.Templates;
using Microsoft.Xna.Framework;

namespace Aerothyte {
    public static class AerothyteUtils {
        // Welcome to the Utils class. Here are utilities! Mostly extension methods..
        #region Projectile Related
        public static bool IsHostile(this Projectile projectile) {
            return projectile.hostile && !projectile.friendly;
        }
        public static bool IsFriendly(this Projectile projectile) {
            return projectile.friendly && !projectile.hostile;
        }
        public static bool IsSummon(this Projectile projectile) {
            return projectile.sentry || projectile.minion;
        }
        public static bool IsMagic(this Projectile projectile) {
            return projectile.magic;
        }

        // -- //

        public static ref Player GetOwner(this Projectile proj) {
            return ref Main.player[proj.owner];
        }

        // -- //
        #endregion
        #region Item Related
        public static EvokerItem EGI(this Item i) {
            return i.GetGlobalItem<EvokerItem>();
        }
        public static TooltipLine NewToolTip(int Number, string Tooltip) => new TooltipLine(Aerothyte.instance, $"AeroTT{Number}", Tooltip);
        public static TooltipLine NewToolTip(int Number, string Tooltip, Color c) {
            TooltipLine t = new TooltipLine(Aerothyte.instance, $"AeroTT{Number}", Tooltip);
            t.overrideColor = c;
            return t;
        }

        #endregion
    }
}
