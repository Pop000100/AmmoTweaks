using Mutagen.Bethesda.Synthesis.Settings;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmmoTweaks.Settings
{
    public class LootSettings
    {
        [SynthesisOrder]
        public float Mult = 1f;

        [SynthesisOrder]
        public float BoltWeight = 0f;

        [SynthesisOrder]
        public float ArrowWeight = 0f;
    }
}
