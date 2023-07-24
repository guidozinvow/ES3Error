using System;
using UnityEngine;

namespace ES3Types
{
	[UnityEngine.Scripting.Preserve]
	[ES3PropertiesAttribute()]
	public class ES3UserType_WeaponType : ES3ScriptableObjectType
	{
		public static ES3Type Instance = null;

		public ES3UserType_WeaponType() : base(typeof(WeaponType)){ Instance = this; priority = 1; }


		protected override void WriteScriptableObject(object obj, ES3Writer writer)
		{
			var instance = (WeaponType)obj;
			
		}

		protected override void ReadScriptableObject<T>(ES3Reader reader, object obj)
		{
			var instance = (WeaponType)obj;
			foreach(string propertyName in reader.Properties)
			{
				switch(propertyName)
				{
					
					default:
						reader.Skip();
						break;
				}
			}
		}
	}


	public class ES3UserType_WeaponTypeArray : ES3ArrayType
	{
		public static ES3Type Instance;

		public ES3UserType_WeaponTypeArray() : base(typeof(WeaponType[]), ES3UserType_WeaponType.Instance)
		{
			Instance = this;
		}
	}
}