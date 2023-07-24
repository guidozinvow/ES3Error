using System;
using UnityEngine;

namespace ES3Types
{
    [UnityEngine.Scripting.Preserve]
    [ES3PropertiesAttribute("expLevel", "exp", "balance", "previousExpLevel", "previousExp", "selectedWeapon", "selectedSkin")]
    public class ES3UserType_PlayerData : ES3ScriptableObjectType
    {
        public static ES3Type Instance = null;

        public ES3UserType_PlayerData() : base(typeof(PlayerData)) { Instance = this; priority = 1; }


        protected override void WriteScriptableObject(object obj, ES3Writer writer)
        {
            var instance = (PlayerData)obj;

            writer.WriteProperty("expLevel", instance.expLevel, ES3Type_int.Instance);
            writer.WriteProperty("exp", instance.exp, ES3Type_float.Instance);
            writer.WriteProperty("balance", instance.balance, ES3Type_int.Instance);
            writer.WriteProperty("previousExpLevel", instance.previousExpLevel, ES3Type_int.Instance);
            writer.WriteProperty("previousExp", instance.previousExp, ES3Type_float.Instance);
            writer.WritePropertyByRef("selectedWeapon", instance.selectedWeapon);
            writer.WritePropertyByRef("selectedSkin", instance.selectedSkin);
        }

        protected override void ReadScriptableObject<T>(ES3Reader reader, object obj)
        {
            var instance = (PlayerData)obj;
            foreach (string propertyName in reader.Properties)
            {
                switch (propertyName)
                {

                    case "expLevel":
                        instance.expLevel = reader.Read<System.Int32>(ES3Type_int.Instance);
                        break;
                    case "exp":
                        instance.exp = reader.Read<System.Single>(ES3Type_float.Instance);
                        break;
                    case "balance":
                        instance.balance = reader.Read<System.Int32>(ES3Type_int.Instance);
                        break;
                    case "previousExpLevel":
                        instance.previousExpLevel = reader.Read<System.Int32>(ES3Type_int.Instance);
                        break;
                    case "previousExp":
                        instance.previousExp = reader.Read<System.Single>(ES3Type_float.Instance);
                        break;
                    case "selectedWeapon":
                        instance.selectedWeapon = reader.Read<WeaponType>();
                        break;
                    case "selectedSkin":
                        instance.selectedSkin = reader.Read<SkinType>();
                        break;
                    default:
                        reader.Skip();
                        break;
                }
            }
        }
    }


    public class ES3UserType_PlayerDataArray : ES3ArrayType
    {
        public static ES3Type Instance;

        public ES3UserType_PlayerDataArray() : base(typeof(PlayerData[]), ES3UserType_PlayerData.Instance)
        {
            Instance = this;
        }
    }
}