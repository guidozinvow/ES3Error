using System;
using UnityEngine;

namespace ES3Types
{
    [UnityEngine.Scripting.Preserve]
    [ES3PropertiesAttribute("weapons")]
    public class ES3UserType_PurchasedWeapons : ES3ScriptableObjectType
    {
        public static ES3Type Instance = null;

        public ES3UserType_PurchasedWeapons() : base(typeof(PurchasedWeapons)) { Instance = this; priority = 1; }


        protected override void WriteScriptableObject(object obj, ES3Writer writer)
        {
            var instance = (PurchasedWeapons)obj;

            writer.WriteProperty("weapons", instance.weapons, ES3Internal.ES3TypeMgr.GetOrCreateES3Type(typeof(System.Collections.Generic.List<PurchasedWeaponLevel>)));
        }

        protected override void ReadScriptableObject<T>(ES3Reader reader, object obj)
        {
            var instance = (PurchasedWeapons)obj;
            foreach (string propertyName in reader.Properties)
            {
                switch (propertyName)
                {

                    case "weapons":
                        instance.weapons = reader.Read<System.Collections.Generic.List<PurchasedWeaponLevel>>();
                        break;
                    default:
                        reader.Skip();
                        break;
                }
            }
        }
    }


    public class ES3UserType_PurchasedWeaponsArray : ES3ArrayType
    {
        public static ES3Type Instance;

        public ES3UserType_PurchasedWeaponsArray() : base(typeof(PurchasedWeapons[]), ES3UserType_PurchasedWeapons.Instance)
        {
            Instance = this;
        }
    }
}