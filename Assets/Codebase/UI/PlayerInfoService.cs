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
        private ResourceStorage _storage;

        [SerializeField]
        private TMP_Text _hpText;
        [SerializeField]
        private TMP_Text _coinsText;
        [SerializeField]
        private TMP_Text _crystallText;

        private Player _player;
        private PlayerLife _life;

        private int _coinStorage;
        private int _crystallStorage;

        [Inject]
        private void Construct(Player player)
        {
            _player = player;
            _life = player.GetComponent<PlayerLife>();
        }

        private void Start()
        {
            Player.AddResourcesEvent += SetResourcesInfo;
        }
        private void Update()
        {
            _hpText.text = $"HP: {_life.CurrentHP.ToString()}";
            _coinsText.text = $": {_player.CoinStorage}";
            _crystallText.text = $": {_player.CrystallStorage}";
        }
        private void OnDestroy()
        {
            Player.AddResourcesEvent -= SetResourcesInfo;

            _storage.Coins += _coinStorage;
            _storage.Crystalls += _crystallStorage;
        }

        private void SetResourcesInfo(int coins, int crystalls)
        {
            _coinStorage = coins;
            _crystallStorage = crystalls;
        }
    }
}
    
