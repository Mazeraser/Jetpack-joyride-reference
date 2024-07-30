using System;

namespace Assets.Codebase.Mechanics.LiveSystem
{
    public interface ILife
    {
        public static event Action DeathEvent;
    }
}