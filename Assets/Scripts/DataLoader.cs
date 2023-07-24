using System;
using System.Linq;
using UnityEditor;
using UnityEngine;

public class DataLoader : MonoBehaviour
{
    [SerializeField] private PlayerData playerData;
    [SerializeField] private PurchasedWeapons purchasedWeapons;
    [SerializeField] private PurchasedSkins purchasedSkins;

    private void Awake()
    {
        Load();
        playerData.Load();
        SetPlayerData();
    }

    private void SetPlayerData()
    {
        if (playerData.selectedWeapon.Equals(null))
        {
            playerData.selectedWeapon = purchasedWeapons.weapons[0].weaponType;
        }
        if (playerData.selectedSkin.Equals(null))
        {
            playerData.selectedSkin = purchasedSkins.skintypes[0];
        }
    }

    public void Load()
    {
        purchasedWeapons.Load();
        purchasedSkins.Load();
    }
}
