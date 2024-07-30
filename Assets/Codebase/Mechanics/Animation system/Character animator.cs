using UnityEngine;

namespace Assets.Codebase.Mechanics.AnimationSystem
{
    [RequireComponent(typeof(Animator))]
    public class CharacterAnimator : MonoBehaviour
    {
        public enum CharacterState
        {
            run=0,
            fly=1
        }
        private CharacterState state;
        public void SetState(int stateID) => state = (CharacterState)stateID;

        public string LastMoveName { get; set; }

        public void SetPhysicInteraction(Vector2 bodyVelocity)
        {
            if (bodyVelocity.y != 0)
                SetState(1);
            else if (bodyVelocity.y == 0)
                SetState(0);

            GetComponent<Animator>().SetFloat("state", (float)state);
        }
    }
}