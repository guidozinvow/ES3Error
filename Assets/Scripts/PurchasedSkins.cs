using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Purchased Skins", menuName = "Skins/Purchased Skins")]

    public class PurchasedSkins : PersistentData
    {

        public List<SkinType> skintypes;

        public override void ResetData()
        {
            skintypes = new List<SkinType>();
        }
    }


