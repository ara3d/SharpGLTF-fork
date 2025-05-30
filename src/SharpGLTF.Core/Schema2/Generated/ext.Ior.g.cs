// <auto-generated/>

//------------------------------------------------------------------------------------------------
//      This file has been programatically generated; DON´T EDIT!
//------------------------------------------------------------------------------------------------

#pragma warning disable SA1001
#pragma warning disable SA1027
#pragma warning disable SA1028
#pragma warning disable SA1121
#pragma warning disable SA1205
#pragma warning disable SA1309
#pragma warning disable SA1402
#pragma warning disable SA1505
#pragma warning disable SA1507
#pragma warning disable SA1508
#pragma warning disable SA1652

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Numerics;
using System.Text.Json;

using JSONREADER = System.Text.Json.Utf8JsonReader;
using JSONWRITER = System.Text.Json.Utf8JsonWriter;
using FIELDINFO = SharpGLTF.Reflection.FieldInfo;


namespace SharpGLTF.Schema2
{
	using Collections;

	/// <summary>
	/// glTF extension that defines the index of refraction of a material.
	/// </summary>
	#if NET6_0_OR_GREATER
	[System.Diagnostics.CodeAnalysis.DynamicallyAccessedMembers(System.Diagnostics.CodeAnalysis.DynamicallyAccessedMemberTypes.NonPublicConstructors | System.Diagnostics.CodeAnalysis.DynamicallyAccessedMemberTypes.PublicConstructors)]
	#endif
	[global::System.CodeDom.Compiler.GeneratedCodeAttribute("SharpGLTF.CodeGen", "1.0.0.0")]
	partial class MaterialIOR : ExtraProperties
	{
	
		#region reflection
	
		public const string SCHEMANAME = "KHR_materials_ior";
		protected override string GetSchemaName() => SCHEMANAME;
	
		protected override IEnumerable<string> ReflectFieldsNames()
		{
			yield return "ior";
			foreach(var f in base.ReflectFieldsNames()) yield return f;
		}
		protected override bool TryReflectField(string name, out FIELDINFO value)
		{
			switch(name)
			{
				case "ior": value = FIELDINFO.From("ior",this, instance => instance._ior ?? 1.5); return true;
				default: return base.TryReflectField(name, out value);
			}
		}
	
		#endregion
	
		#region data
	
		private const Double _iorDefault = 1.5;
		private Double? _ior = _iorDefault;
		
		#endregion
	
		#region serialization
	
		protected override void SerializeProperties(JSONWRITER writer)
		{
			base.SerializeProperties(writer);
			SerializeProperty(writer, "ior", _ior, _iorDefault);
		}
	
		protected override void DeserializeProperty(string jsonPropertyName, ref JSONREADER reader)
		{
			switch (jsonPropertyName)
			{
				case "ior": DeserializePropertyValue<MaterialIOR, Double?>(ref reader, this, out _ior); break;
				default: base.DeserializeProperty(jsonPropertyName,ref reader); break;
			}
		}
	
		#endregion
	
	}

}
