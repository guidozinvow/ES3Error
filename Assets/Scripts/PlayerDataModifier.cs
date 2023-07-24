using UnityEngine;

public class PlayerDataModifier : MonoBehaviour
{
    [SerializeField] private PlayerData playerData;
    public WeaponType selectedWeapon;
    public SkinType selectedSkin;

    private void Awake()
    {
        playerData.selectedSkin = selectedSkin;
        playerData.selectedWeapon = selectedWeapon;
        playerData.Save();
    }
}
