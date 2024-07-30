using Assets.Codebase.Mechanics.AnimationSystem;
using Assets.Codebase.Mechanics.ControllSystem;
using Assets.Codebase.Mechanics.GeneratorSystem;
using Assets.Codebase.Mechanics.LiveSystem;
using Assets.Codebase.Mechanics.MoveSystem;
using Assets.Codebase.Trigger;
using Assets.Codebase.UI;
using System;
using UnityEngine;

namespace Assets.Codebase.Infrastructure
{
    [RequireComponent(typeof(CharacterAnimator))]
    [RequireComponent(typeof(Rigidbody2D))]
    [RequireComponent(typeof(IControllable))]
    [RequireComponent(typeof(IMovable))]
    [RequireComponent(typeof(ILife))]
    public class Character : MonoBehaviour
    {
        public static event Action<Transform> GenerateNewPartEvent;

        private CharacterAnimator _animator;
        private Rigidbody2D _rb;
        private Transform _lastGeneratePosition;

        private void Start()
        {
            GeneratedPoint.NewPointGeneratedEvent += SetNewPoint;
            PlayerLife.DeathEvent += Die;

            _animator = GetComponent<CharacterAnimator>();
            _rb = GetComponent<Rigidbody2D>();

            foreach (var movableComponent in GetComponents<MovableParent>())
                movableComponent.MoveDelegate = delegate { _animator.LastMoveName = movableComponent.GetType().Name; };
        }
        private void Update()
        {
            if (transform.position.x > _lastGeneratePosition.position.x)
                GenerateNewPartEvent?.Invoke(_lastGeneratePosition);

            _animator.SetPhysicInteraction(_rb.velocity);
        }
        private void OnDestroy()
        {
            GeneratedPoint.NewPointGeneratedEvent -= SetNewPoint;
            PlayerLife.DeathEvent -= Die;
        }

        private void Die()
        {
            Destroy(this.gameObject);
        }
        public void Move(Vector2 direction, IMovable movable)
        {
            movable.Turn(direction.normalized);
        }

        private void SetNewPoint(Transform point)
        {
            _lastGeneratePosition = point;
        }
    }
}