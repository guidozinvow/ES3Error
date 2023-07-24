using System;
using UnityEngine;

namespace ES3Types
{
    [UnityEngine.Scripting.Preserve]
    [ES3PropertiesAttribute("skintypes")]
    public class ES3UserType_PurchasedSkins : ES3ScriptableObjectType
    {
        public static ES3Type Instance = null;

        public ES3UserType_PurchasedSkins() : base(typeof(PurchasedSkins)) { Instance = this; priority = 1; }


        protected override void WriteScriptableObject(object obj, ES3Writer writer)
        {
            var instance = (PurchasedSkins)obj;

            writer.WriteProperty("skintypes", instance.skintypes, ES3Internal.ES3TypeMgr.GetOrCreateES3Type(typeof(System.Collections.Generic.List<SkinType>)));
        }

        protected override void ReadScriptableObject<T>(ES3Reader reader, object obj)
        {
            var instance = (PurchasedSkins)obj;
            foreach (string propertyName in reader.Properties)
            {
                switch (propertyName)
                {

                    case "skintypes":
                        instance.skintypes = reader.Read<System.Collections.Generic.List<SkinType>>();
                        break;
                    default:
                        reader.Skip();
                        break;
                }
            }
        }
    }


    public class ES3UserType_PurchasedSkinsArray : ES3ArrayType
    {
        public static ES3Type Instance;

        public ES3UserType_PurchasedSkinsArray() : base(typeof(PurchasedSkins[]), ES3UserType_PurchasedSkins.Instance)
        {
            Instance = this;
        }
    }
}