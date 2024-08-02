using Assets.Codebase.Infrastructure;
using Assets.Codebase.Infrastructure.InputService;
using Assets.Codebase.Mechanics.MoveSystem;
using Assets.Codebase.Mechanics.CameraHelper;
using Assets.Codebase.Mechanics.ResourceCollector;
using Assets.Codebase.Mechanics.ShopSystem.Purchasable;
using Assets.Codebase.Mechanics.ShopSystem;
using System;
using UnityEngine;
using Zenject;

namespace Assets.Codebase.Mechanics.ControllSystem
{
    [RequireComponent(typeof(Jump))]
    [RequireComponent(typeof(Walk))]
    public class Player : MonoBehaviour,IControllable, IInterestable
    {
        public static event Action<int, int> AddResourcesEvent;

        private IInput _input;

        private Character _character;

        [SerializeField]
        private GameObject _weapon;
        [SerializeField]
        private GameObject _vehicle;


        private int _coinStorage=0;
        public int CoinStorage => _coinStorage;
        private int _crystallStorage=0;
        public int CrystallStorage => _crystallStorage;

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
        private void OnDestroy()
        {
            AddResourcesEvent?.Invoke(CoinStorage, CrystallStorage);
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

        private void OnTriggerEnter2D(Collider2D collision)
        {
            if (collision.CompareTag("Coin"))
                collision.gameObject.GetComponent<ICollector>().Collect(ref _coinStorage, 1);
            else if (collision.CompareTag("Crystall"))
                collision.gameObject.GetComponent<ICollector>().Collect(ref _crystallStorage, 1);
        }

        public Transform GetTransform { get { return transform; } }
    }
}