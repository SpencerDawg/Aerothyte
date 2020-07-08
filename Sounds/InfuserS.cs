using Microsoft.Xna.Framework;
using System.Collections.Generic;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using static Aerothyte.AerothytePlayer;
using Aerothyte;
using Aerothyte.Projectiles.GlacialQuartzP;
using System;
using Microsoft.Xna.Framework.Audio;

namespace Aerothyte.Sounds
{
    public class InfuserS : ModSound
    {
        public override SoundEffectInstance PlaySound(ref SoundEffectInstance soundInstance, float volume, float pan, SoundType type)
        {
            if (soundInstance.State == SoundState.Playing)
            {
                return null;
            }
            soundInstance.Volume = volume * 0.5f;
            soundInstance.Pan = pan;
            soundInstance.Pitch = Main.rand.NextFloat(0.4f, 0.7f) * 0.5f;
            return soundInstance;
        }
    }
}