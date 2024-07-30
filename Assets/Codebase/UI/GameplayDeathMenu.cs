using Assets.Codebase.Mechanics.LiveSystem;

namespace Assets.Codebase.UI
{
    public class GameplayDeathMenu : GameplayMenu
    {
        private void Awake()
        {
            PlayerLife.DeathEvent += Activate;
        }
        private void OnDestroy()
        {
            PlayerLife.DeathEvent -= Activate;
        }
    }
}