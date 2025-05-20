using System;
using UnityEngine;

namespace Gameplay.Assets._2_Gameplay.Scripts.So.So_Actions
{
    [CreateAssetMenu(menuName = "Movement/Climb/Simple", fileName = "SimpleClimbSo")]
    public class SimpleClimbSo : SoClimb
    {
        public override bool CanClimb()
        {
            throw new NotImplementedException();
        }
    }
}
