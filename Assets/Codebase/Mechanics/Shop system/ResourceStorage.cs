using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Assets.Codebase.Mechanics.ShopSystem
{
    [CreateAssetMenu(menuName ="ResourceStorage",fileName ="Resource storage")]
    public class ResourceStorage : ScriptableObject
    {
        [SerializeField]
        private int _coins;
        [SerializeField]
        private int _crystalls;

        public int Coins 
        {
            get => _coins;
            set => _coins = value;
        }
        public int Crystalls 
        {
            get => _crystalls;
            set => _crystalls = value;
        }
    }
}
    
