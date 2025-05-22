using UnityEngine;

namespace Gameplay.Assets._2_Gameplay.Scripts.So.So_Actions
{
    [CreateAssetMenu(menuName = "Movement/Jump/Single", fileName = "SingleJumpSo")]
    public class SingleJumpSo : SoJump
    {
        //Added a simple logic that contains methods to jump, can jump and reset the jump
        private bool hasJumped;

        public override bool CanJump() => !hasJumped;

        public override void OnJump() => hasJumped = true;

        public override void Reset() => hasJumped = false;
    }
}
