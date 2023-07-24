using System;
using UnityEngine;

namespace ES3Types
{
	[UnityEngine.Scripting.Preserve]
	[ES3PropertiesAttribute("weaponType", "weaponLevel")]
	public class ES3UserType_PurchasedWeaponLevel : ES3ObjectType
	{
		public static ES3Type Instance = null;

		public ES3UserType_PurchasedWeaponLevel() : base(typeof(PurchasedWeaponLevel)){ Instance = this; priority = 1; }


		protected override void WriteObject(object obj, ES3Writer writer)
		{
			var instance = (PurchasedWeaponLevel)obj;
			
			writer.WritePropertyByRef("weaponType", instance.weaponType);
			writer.WriteProperty("weaponLevel", instance.weaponLevel, ES3Type_int.Instance);
		}

		protected override void ReadObject<T>(ES3Reader reader, object obj)
		{
			var instance = (PurchasedWeaponLevel)obj;
			foreach(string propertyName in reader.Properties)
			{
				switch(propertyName)
				{
					
					case "weaponType":
						instance.weaponType = reader.Read<WeaponType>(ES3UserType_WeaponType.Instance);
						break;
					case "weaponLevel":
						instance.weaponLevel = reader.Read<System.Int32>(ES3Type_int.Instance);
						break;
					default:
						reader.Skip();
						break;
				}
			}
		}

		protected override object ReadObject<T>(ES3Reader reader)
		{
			var instance = new PurchasedWeaponLevel();
			ReadObject<T>(reader, instance);
			return instance;
		}
	}


	public class ES3UserType_PurchasedWeaponLevelArray : ES3ArrayType
	{
		public static ES3Type Instance;

		public ES3UserType_PurchasedWeaponLevelArray() : base(typeof(PurchasedWeaponLevel[]), ES3UserType_PurchasedWeaponLevel.Instance)
		{
			Instance = this;
		}
	}
}