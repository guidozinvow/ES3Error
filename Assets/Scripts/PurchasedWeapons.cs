using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Purchased Weapons", menuName = "Weapons/Purchased Weapons")]

public class PurchasedWeapons : PersistentData
{

    public List<PurchasedWeaponLevel> weapons;

    public override void ResetData()
    {
        weapons = new List<PurchasedWeaponLevel>();
    }
}

[System.Serializable]
public class PurchasedWeaponLevel
{
    public WeaponType weaponType;
    public int weaponLevel;
}