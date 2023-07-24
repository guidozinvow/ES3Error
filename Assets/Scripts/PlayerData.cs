using UnityEngine;

[CreateAssetMenu(fileName = "Player Data", menuName = "Core/PlayerData")]
public class PlayerData : PersistentData
{
    public WeaponType selectedWeapon;
    public SkinType selectedSkin;

}
