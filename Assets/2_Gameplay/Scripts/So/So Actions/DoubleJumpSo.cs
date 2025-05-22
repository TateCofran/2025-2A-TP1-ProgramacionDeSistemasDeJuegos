using System;
using UnityEngine;

namespace Gameplay.Assets._2_Gameplay.Scripts.So.So_Actions
{
    [CreateAssetMenu(menuName = "Movement/Jump/Double", fileName = "DoubleJumpSo")]
    public class DoubleJumpSo : SoJump
    {
        //Similar to singleJumpSo but  added a quantity of max jumps the player can do
        private int jumpsDone = 0;
        private readonly int maxJumps = 2;

        public override bool CanJump() => jumpsDone < maxJumps;

        public override void OnJump() => jumpsDone++;

        public override void Reset() => jumpsDone = 0;

    }
}
