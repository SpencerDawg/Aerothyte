using Microsoft.Xna.Framework;
using System.Collections.Generic;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using static Aerothyte.AerothytePlayer;
using Aerothyte;

namespace Aerothyte.Templates {
    public class EvokerItem : GlobalItem {
        public override bool InstancePerEntity => true;
        public override bool CloneNewInstances => true;
        public int EvokerDamage = 0;
        public float EvokerCritChance = 0f;
        public bool Evoker = false;
        public void UpdateThings(Player player) {
            EvokerDamage = (int)(EvokerDamage * player.GetModPlayer<EvokerPlayer>().EvokerDamageMult);
            EvokerDamage = EvokerDamage + player.GetModPlayer<EvokerPlayer>().EvokerDamage;
            EvokerCritChance = EvokerCritChance + player.GetModPlayer<EvokerPlayer>().EvokerCritChance;
        }
        public override void UpdateInventory(Item item, Player player) {
            UpdateThings(player);
        }
        public override void ModifyTooltips(Item item, List<TooltipLine> tooltips) {
            item.EGI().Evoker = false;
            if (item.GetGlobalItem<EvokerItem>().Evoker) {
                foreach(TooltipLine t in tooltips) {
                    bool Check(string s) {
                        return t.mod == "Terraria" && t.Name == s;
                    }
                    if (Check("Damage")) {
                        t.text = $"{item.GetGlobalItem<EvokerItem>().EvokerDamage} evocative damage";
                    }
                    if(Check("CritChance")) {
                        t.text = $"{item.GetGlobalItem<EvokerItem>().EvokerCritChance}% evocative crit chance";
                    }
                }
            }
        }
    }
}
