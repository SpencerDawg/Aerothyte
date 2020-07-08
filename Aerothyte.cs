using Terraria.ModLoader;
using Terraria.ID;
using Terraria;
using Microsoft.Xna.Framework;
using System.Threading;
using System;
using Terraria.Localization;

namespace Aerothyte
{
	public class Aerothyte : Mod
	{
		
		public enum ModState
		{
			Testing,
			Public,
			Development,
			CCRelease,
			Debug = Development | Testing
		} 
		public static ModState GetModState()
		{
			return ModState.Development;
		}
		public static bool Debug => false;
		public static readonly int GlacialQuartzRarityID = 21;
		public Aerothyte()
		{
			
			// reserves memory
			// leave here if you're editing
		}
		public override void Load()
		{
			AerothyteON.HookMethod();
			Mod calamityInstance = ModLoader.GetMod("CalamityMod");
			
		}
		// TODO: Timers

		#region UselessMethods
		public static string GetVanillaItemTexture(int ItemID) => "Terraria/Item_" + ItemID;
		public static string GiveCBT() => "Aerothyte/cockandballtorture";
		public static void SendMessageSafe(string Message, Color color)
		{
			if (Main.netMode == NetmodeID.SinglePlayer)
			{
				Main.NewText(Message, color);
			}
		
			if (Main.netMode == NetmodeID.Server)
			{
				NetMessage.BroadcastChatMessage(NetworkText.FromLiteral(Message), color);
			}
		}
		#endregion
	}
    #region Tile Methods
    public class AerothyteTileMethods : GlobalTile
	{
		public static void BreakMultiplePlus(Vector2 position)
		{

		}
	}
    #endregion
    #region NPC
    public class AerothyteNPC : GlobalNPC
	{
	}
    #endregion

}
