using Assets.Codebase.Mechanics.ShopSystem.Purchasable;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Assets.Codebase.UI.ShopService
{
    public class BuyButton : MonoBehaviour
    {
        [SerializeField]
        private TMP_Text _itemName;
        [SerializeField]
        private TMP_Text _itemCost;
        
        private IPurchasable _item;

        public void SetItem(IPurchasable item)
        {
            _item = item;
            _itemName.text = _item.ItemName;
            _itemCost.text = _item.Cost.ToString();
        }

        private void Update()
        {
            _itemCost.text = _item.Bought ? "-" : _item.Cost.ToString();
        }

        public void Purchase()
        {
            _item?.Purchase();
        }
    }
}