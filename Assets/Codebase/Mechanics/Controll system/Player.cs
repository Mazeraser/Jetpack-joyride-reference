using Assets.Codebase.Infrastructure;
using Assets.Codebase.Infrastructure.InputService;
using Assets.Codebase.Mechanics.MoveSystem;
using Assets.Codebase.Mechanics.CameraHelper;
using UnityEngine;
using Zenject;

namespace Assets.Codebase.Mechanics.ControllSystem
{
    [RequireComponent(typeof(Jump))]
    [RequireComponent(typeof(Walk))]
    public class Player : MonoBehaviour,IControllable, IInterestable
    {
        private IInput _input;

        private Character _character;

        [Inject]
        private void Construct(IInput input)
        {
            _input = input;
        }

        private void Start()
        {
            _character = GetComponent<Character>();
        }

        private void FixedUpdate()
        {
            ControllMove(new Vector2(0,_input.JumpValue()));
        }


        public void ControllMove(Vector2 velocity)
        {
            _character.Move(Vector2.right, GetComponent<Walk>());
            if(velocity.y>0)
                _character.Move(Vector2.up, GetComponent<Jump>());
        }

        public Transform GetTransform { get { return transform; } }
    }
}