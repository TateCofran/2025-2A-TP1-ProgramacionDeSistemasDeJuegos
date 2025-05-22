using UnityEngine;

namespace Gameplay.Assets._2_Gameplay.Scripts.So
{
    public abstract class SoJump : ScriptableObject
    {
        //Added a SO that contains basic functions

        public abstract bool CanJump();

        public abstract void OnJump();

        public abstract void Reset();
    }
}
