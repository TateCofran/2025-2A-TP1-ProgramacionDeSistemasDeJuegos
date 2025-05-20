using UnityEngine;

namespace Gameplay.Assets._2_Gameplay.Scripts.So
{
    public abstract class SoJump : ScriptableObject
    {
        public abstract bool CanJump();

        public abstract void OnJump();

        public abstract void Reset();
    }
}
