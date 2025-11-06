
using System;
using Player;
using UnityEngine;

public class GameManager: PersistentSingleton<GameManager>
{
    [SerializeField] private PlayerSetting _playerSetting;
    public PlayerSetting PlayerSetting => _playerSetting;
    private void OnEnable()
    {
        _playerSetting = Resources.Load<PlayerSetting>("Manager/PlayerSetting");
    }
}
