using UnityEngine;
using Zenject;
using Assets.Codebase.Mechanics.ControllSystem;
using Assets.Codebase.Mechanics.LiveSystem;

public class PlayerInstaller : MonoInstaller
{

    [SerializeField]
    private GameObject[] _playerList;
    

    [SerializeField]
    private Transform _spawnTransform;
    
    public override void InstallBindings()
    {
        var player = Container.
            InstantiatePrefabForComponent<Player>
            (_playerList[PlayerPrefs.HasKey("CharacterIndex")?PlayerPrefs.GetInt("CharacterIndex"):0],
            _spawnTransform);

        Container.BindInterfacesAndSelfTo<Player>().
            FromInstance(player).
            AsSingle().
            NonLazy();
    }
}