using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Perks{
    public enum PerkType{
        slow,
        fast
    }

    public class PerkHandler {

        public static float getPerkValue(PerkType perk){
            switch(perk){
                case PerkType.slow:
                    return -0.3f;
                case PerkType.fast:
                    return 0.3f;
                default:
                    return 0;
            }
        }
    }
}
