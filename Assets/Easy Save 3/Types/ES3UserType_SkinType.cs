using System;
using UnityEngine;

namespace ES3Types
{
	[UnityEngine.Scripting.Preserve]
	[ES3PropertiesAttribute()]
	public class ES3UserType_SkinType : ES3ScriptableObjectType
	{
		public static ES3Type Instance = null;

		public ES3UserType_SkinType() : base(typeof(SkinType)){ Instance = this; priority = 1; }


		protected override void WriteScriptableObject(object obj, ES3Writer writer)
		{
			var instance = (SkinType)obj;
			
		}

		protected override void ReadScriptableObject<T>(ES3Reader reader, object obj)
		{
			var instance = (SkinType)obj;
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


	public class ES3UserType_SkinTypeArray : ES3ArrayType
	{
		public static ES3Type Instance;

		public ES3UserType_SkinTypeArray() : base(typeof(SkinType[]), ES3UserType_SkinType.Instance)
		{
			Instance = this;
		}
	}
}