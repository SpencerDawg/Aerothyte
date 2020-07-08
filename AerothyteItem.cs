using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using Terraria;
using Aerothyte;
using Terraria.ModLoader;
using Microsoft.Xna.Framework.Graphics;
using Terraria.ID;

namespace Aerothyte
{
    /// <summary>
    ///  This class contains stuff for modifying individual items. Do not change things specific to all items here!
    /// </summary>
    public class AerothyteItem : GlobalItem
    {

        public override bool CloneNewInstances => true;
        public override void ModifyTooltips(Item item, List<TooltipLine> tooltips)
        {
            foreach (TooltipLine tooltip in tooltips)
            {
                if (tooltip.mod == "Terraria" && tooltip.Name == "SocialDesc")
                {
                    tooltip.overrideColor = Color.LimeGreen;
                }
                if (tooltip.mod == "Terraria" && tooltip.Name == "Vanity")
                {
                    tooltip.overrideColor = Color.Lime;
                }
                if (tooltip.mod == "Terraria" && tooltip.Name == "Material")
                {
                    tooltip.overrideColor = Color.GreenYellow;
                }
                if (tooltip.mod == "Terraria" && tooltip.Name == "UseMana")
                {
                    tooltip.overrideColor = Color.MediumPurple;
                }
                if (tooltip.mod == "Terraria" && tooltip.Name == "HealMana")
                {
                    tooltip.overrideColor = Color.Magenta;
                }
                if (tooltip.mod == "Terraria" && tooltip.Name == "Damage")
                {
                    tooltip.overrideColor = Color.OrangeRed;
                }
                if (tooltip.mod == "Terraria" && tooltip.Name == "Tooltip0")
                {
                    tooltip.overrideColor = Color.CornflowerBlue;
                }
                if (tooltip.mod == "Terraria" && tooltip.Name == "Defense" || tooltip.mod == "Terraria" && tooltip.Name == "TileBoost")
                {
                    tooltip.overrideColor = Color.LightGoldenrodYellow;
                }
                if (item.rare == Aerothyte.GlacialQuartzRarityID && tooltip.Name == "ItemName")
                {
                    // Glacial Quartz and Adjacent 
                    tooltip.overrideColor = new Color(27, 243, 255);
                }

            }
            item.RebuildTooltip();
        }
        public override void SetDefaults(Item item)
        {
        }
        public static void DrawAsInactive(Color color, Texture2D texture, Vector2 position, Rectangle frame, float scale, Vector2 origin)
        {
            Main.spriteBatch.Draw(texture, position, frame, color, 0f, origin, scale, SpriteEffects.None, 0f);
        }
    }
    public static class AerothyteColor
    {
        public static Color RarityGQ => new Color(27, 243, 255);
    }
}


