using System;
using UnityEngine;

namespace Gameplay.Assets._2_Gameplay.Scripts.So.So_Actions
{
    [CreateAssetMenu(menuName = "Movement/Swim/Simple", fileName = "SimpleSwimSo")]

    public class SimpleSwimSo : SoSwim
    {
        public override bool CanSwim()
        {
            throw new NotImplementedException();
        }
    }
}
