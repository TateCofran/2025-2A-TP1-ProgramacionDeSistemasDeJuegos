using UnityEngine;

namespace Gameplay.Assets._2_Gameplay.Scripts.So.So_Actions
{
    [CreateAssetMenu(menuName = "Movement/Jump/Single", fileName = "SingleJumpSo")]
    public class SingleJumpSo : SoJump
    {
        private bool hasJumped;

        public override bool CanJump() => !hasJumped;

        public override void OnJump() => hasJumped = true;

        public override void Reset() => hasJumped = false;
    }
}
