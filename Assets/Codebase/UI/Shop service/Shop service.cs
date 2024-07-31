using Assets.Codebase.Mechanics.ShopSystem;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

namespace Assets.Codebase.UI.ShopService
{
    public class ShopService : MonoBehaviour
    {
        [SerializeField]
        private Shop _shop;

        [SerializeField]
        private GameObject _buyButton;

        [SerializeField]
        private GameObject _vehicleBlock;
        [SerializeField]
        private GameObject _weaponBlock;

        [SerializeField]
        private TMP_Text _coinText;
        [SerializeField]
        private TMP_Text _crystallText;

        private void Start()
        {
            foreach (var vehicle in _shop.VehicleList)
            {
                GameObject clone = Instantiate(_buyButton, _vehicleBlock.transform);
                clone.GetComponent<BuyButton>().SetItem(vehicle);
            }
            foreach (var weapon in _shop.WeaponList)
            {
                GameObject clone = Instantiate(_buyButton, _weaponBlock.transform);
                clone.GetComponent<BuyButton>().SetItem(weapon);
            }
        }
        private void Update()
        {
            _coinText.text = _shop.resourceStorage.Coins.ToString();
            _crystallText.text = _shop.resourceStorage.Crystalls.ToString();
        }
    }
}
    