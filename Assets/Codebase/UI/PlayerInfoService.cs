using Assets.Codebase.Mechanics.LiveSystem;
using Assets.Codebase.Mechanics.ShopSystem;
using Assets.Codebase.Mechanics.ControllSystem;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using Zenject;

namespace Assets.Codebase.UI
{
    public class PlayerInfoService : MonoBehaviour
    {
        [SerializeField]
        private TMP_Text _hpText;
        [SerializeField]
        private TMP_Text _coinsText;
        [SerializeField]
        private TMP_Text _crystallText;

        [SerializeField]
        private ResourceStorage _resourceStorage;

        private PlayerLife _life;

        [Inject]
        private void Construct(Player player)
        {
            _life = player.GetComponent<PlayerLife>();
        }

        private void Update()
        {
            _hpText.text = $"HP: {_life.CurrentHP.ToString()}";
            _coinsText.text = $"Coins: {_resourceStorage.Coins}";
            _crystallText.text = $"Crystalls: {_resourceStorage.Crystalls}";
        }
    }
}
    
