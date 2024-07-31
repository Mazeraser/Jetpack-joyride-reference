using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Assets.Codebase.Mechanics.LiveSystem
{
    public class ProjectileLife : CoreLife
    {
        private void OnTriggerExit2D()
        {
            Destroy(this.gameObject);
        }
    }
}
    
