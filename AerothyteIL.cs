using Microsoft.Xna.Framework;
using System.Collections.Generic;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using IL.Terraria;
using On.Terraria;
using MonoMod;
using static Aerothyte.AerothytePlayer;
using Aerothyte;
using Aerothyte.Projectiles.GlacialQuartzP;
using System;
using Terraria.Chat;
using System.Reflection;
using Terraria.UI.Chat;
using Microsoft.Xna.Framework.Graphics;
using Aerothyte.Items.Tools;
using MonoMod.Cil;
using Mono.Cecil.Cil;

namespace Aerothyte
{
    public class AerothyteON
    {
        public static Terraria.Item ArbitraryNewItem = null;
        public static int ArbitraryStack = 0;
        public static bool ass = false;
        public static bool ass2 = false;
        public static void HookMethod()
        {
            On.Terraria.Player.PickTile += CustomTilePick;
            //On.Terraria.Main.MouseText += CustomTooltips;
            //get itemtext fixed here eventually
        }

        private static void CustomTooltips(On.Terraria.Main.orig_MouseText orig, Terraria.Main self, string cursorText, int rare, byte diff, int hackedMouseX, int hackedMouseY, int hackedScreenWidth, int hackedScreenHeight)
        {
            orig.Invoke(self, cursorText, rare, diff, hackedMouseX, hackedMouseY, hackedScreenWidth, hackedScreenHeight);
            int X2 = Terraria.Main.mouseX + 10;
            int Y2 = Terraria.Main.mouseY + 10;
            if (hackedMouseX != -1 && hackedMouseY != -1)
            {
                X2 = hackedMouseX + 10;
                Y2 = hackedMouseY + 10;
            }

            if (Terraria.Main.ThickMouse)
            {
                X2 += 6;
                Y2 += 6;
            }
            if (rare == Aerothyte.GlacialQuartzRarityID)
            {
                // TODO: Fix Custom Rarity Pt. 2
                //ChatManager.DrawColorCodedStringWithShadow(Terraria.Main.spriteBatch, Terraria.GameContent.FontAssets.MouseText<>.Value, cursorText, new Vector2(X2, Y2), AerothyteColor.RarityGQ, 0f, Vector2.Zero, Vector2.One);
            }
        }

        private static void CustomTilePick(On.Terraria.Player.orig_PickTile orig, Terraria.Player self, int x, int y, int pickPower)
        {
            orig.Invoke(self, x, y, pickPower);
            if (Terraria.Main.tile[x, y].type == TileID.SnowBlock || Terraria.Main.tile[x, y].type == TileID.IceBlock && self.HeldItem.type == ModContent.ItemType<IcePick>())
            {
                Terraria.WorldGen.KillTile(x, y);
            }
            Terraria.Main.NewText("pee");
        }
    }
}