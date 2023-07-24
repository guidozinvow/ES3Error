using UnityEngine;

[CreateAssetMenu(fileName = "Player Data", menuName = "Core/PlayerData")]
public class PlayerData : PersistentData
{
    public int expLevel = 0;
    public float exp = 0;
    public int balance = 0;
    public int previousExpLevel = 0;
    public float previousExp = 0;
    public WeaponType selectedWeapon;
    public SkinType selectedSkin;

    public override void ResetData()
    {
        expLevel = 0;
        exp = 0;
        previousExp = 0;
        previousExpLevel = 0;
        balance = 0;
    }
}
