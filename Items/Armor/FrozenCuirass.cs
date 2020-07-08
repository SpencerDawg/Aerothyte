using Microsoft.Xna.Framework;
using System.Collections.Generic;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using static Aerothyte.AerothytePlayer;
using Aerothyte;

namespace Aerothyte.Items.Armor
{
    [AutoloadEquip(EquipType.Body)]
    public class FrozenCuirass : ModItem
    {

        public override void SetDefaults()
        {
            item.wornArmor = true;
        }
        public override void SetStaticDefaults()
        {
           
        }
        public override bool IsArmorSet(Item head, Item body, Item legs)
        {
            return base.IsArmorSet(head, body, legs);
        }
        public override void UpdateArmorSet(Player player)
        {
            base.UpdateArmorSet(player);
        }
    }
}
