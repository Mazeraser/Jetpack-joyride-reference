using Assets.Codebase.Infrastructure;
using Assets.Codebase.Infrastructure.InputService;
using Assets.Codebase.Mechanics.MoveSystem;
using Assets.Codebase.Mechanics.CameraHelper;
using Assets.Codebase.Mechanics.WeaponSystem;
using Assets.Codebase.Mechanics.ShopSystem.Purchasable;
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

        [SerializeField]
        private GameObject _weapon;
        [SerializeField]
        private GameObject _vehicle;

        [Inject]
        private void Construct(IInput input)
        {
            _input = input;
        }

        private void Start()
        {
            _character = GetComponent<Character>();

            GameObject clone = Instantiate(_weapon, transform);
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

        public void SetNewWeapon(Weapon weapon) 
        {
            _weapon = weapon.WeaponObject;
        }
        public void SetNewVehicle(Vehicle vehicle)
        {
            Debug.Log($"{vehicle.ItemName} has equipped");
            if(_vehicle!=null)
                _vehicle.GetComponent<SpriteRenderer>().sprite = vehicle.VehicleImage;
            GetComponent<Jump>().SetPower = vehicle.VehiclePower;
        }

        public Transform GetTransform { get { return transform; } }
    }
}