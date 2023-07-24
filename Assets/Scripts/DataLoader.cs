using UnityEngine;

public class DataLoader : MonoBehaviour
{
    [SerializeField] private PlayerData playerData;

    private void Awake()
    {
        playerData.Load();
    }
}
