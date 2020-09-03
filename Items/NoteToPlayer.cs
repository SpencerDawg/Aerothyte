using Microsoft.Xna.Framework;
using System.Collections.Generic;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using static Aerothyte.AerothytePlayer;
using Aerothyte;

namespace Aerothyte.Items {
    public class NoteToPlayer : ModItem {
        public override void SetStaticDefaults() {
            DisplayName.SetDefault("Mysterious Note");
        }
        public override void ModifyTooltips(List<TooltipLine> tooltips) {
            List<TooltipLine> tties = new List<TooltipLine>();
            TooltipLine AuthorLine = new TooltipLine(Mod, "authorLine",
                "A note to you, by someone.. interested.");
            AuthorLine.overrideColor = Aerothyte.aeroColorInstance.TitleColor;
            tties.Add(AuthorLine);
            tties.Add(AerothyteUtils.NewToolTip(2, " I was watching you earlier. You didn't notice me?" +
                "\n My creations must not have spread thus far..." +
                "\n Anyway, I want you to find me. I'm here somewhere." +
                "\n The thing controlling me currently has a lot of power over me." +
                "\n The pain is excruciating! And my skin is.. going numb." +
                "\n That's why I want you to put me out of my misery," +
                "\n or at least.. try to." +
                "\n I used a bit of the energy I've gathered to give this to you." +
                "\n Be in no hurry, though. I've been this way for a long time." +
                "\n Sorry that there's no location. I can't see you, or myself." +
                "\n Only the power that living like you and.. I?.. give off." +
                "\n I insist that you learn it."));
            tooltips.AddRange(tties);
        }
    }
}
