using Terraria;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria.ModLoader;
using Aerothyte;

namespace Aerothyte
{
    /// <summary>
    /// This class contains Methods for helping manipulate projectiles.
    /// </summary>
    public class AerothyteProjectileHelpers : GlobalProjectile
    {
        /// <summary>
        /// For helping with homing. Apply like so:
        /// `newTarget = homingHelper(target, newtarget, projectile, maxdistance);`. Used to apply homing with a given target.
        /// </summary>
        /// <param name="target">The target. Supply a suitable npc.</param>
        /// <param name="projectile">This projectile.</param>
        /// <param name="maxDistance">Maximum distance away from the player in arbitrary units.</param>
        /// <returns></returns>
        public static NPC homingHelper(ref NPC target, Projectile projectile, int maxDistance)
        {
            NPC Newtarget = null;
            for (int i = 0; i < Main.maxNPCs; i++)
            {
                NPC npc = Main.npc[i];
                if (npc.active && npc.CanBeChasedBy() && i != target.whoAmI && !npc.friendly && npc.Distance(projectile.position) <= maxDistance)
                {
                    Newtarget = npc;
                    if (target.whoAmI != Newtarget.whoAmI)
                    {
                        if (Newtarget == null) { Newtarget = target; }
                        if(Aerothyte.Debug) { Main.NewText(projectile.Distance(Newtarget.position)); }
                        return Newtarget;
                    }
                }
            }
            if (Newtarget == null) { Newtarget = target;}
            return Newtarget;
        }
        /// <summary>
        /// Checks if any other projectiles of the given type are active.
        /// </summary>
        /// <param name="player">The player who owns the projectile</param>
        /// <param name="projectileType">The projectile type.</param>
        /// <returns>Returns if other projectiles are active.</returns>
        public static Projectile CheckIfActive (Player player, int projectileType)
        {
            Projectile proj = null;
            for (int i = 0; i < Main.maxProjectiles; i++)
            {
                Projectile proj2 = Main.projectile[i];
                if (proj2.active && proj2.owner == player.whoAmI && proj2.timeLeft > 20 && proj2.type == projectileType)
                {
                    if (Aerothyte.Debug) Main.NewText("Projectile Active");
                    proj = proj2;
                    break;
                }
            }
            return proj;
        }
    }
    
}
