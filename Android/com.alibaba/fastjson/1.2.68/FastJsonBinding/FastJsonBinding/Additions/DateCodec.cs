using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Java.Interop;

namespace Com.Alibaba.Fastjson.Serializer
{
    public partial class DateCodec : global::Com.Alibaba.Fastjson.Parser.Deserializer.AbstractDateDeserializer, global::Com.Alibaba.Fastjson.Parser.Deserializer.IObjectDeserializer, global::Com.Alibaba.Fastjson.Serializer.IObjectSerializer
    {
		// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.fastjson.serializer']/class[@name='DateCodec']/method[@name='cast' and count(parameter)=4 and parameter[1][@type='com.alibaba.fastjson.parser.DefaultJSONParser'] and parameter[2][@type='java.lang.reflect.Type'] and parameter[3][@type='java.lang.Object'] and parameter[4][@type='java.lang.Object']]"
		[Register("cast", "(Lcom/alibaba/fastjson/parser/DefaultJSONParser;Ljava/lang/reflect/Type;Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;", "GetCast_Lcom_alibaba_fastjson_parser_DefaultJSONParser_Ljava_lang_reflect_Type_Ljava_lang_Object_Ljava_lang_Object_Handler")]
		[global::Java.Interop.JavaTypeParameters(new string[] { "T" })]
		protected override unsafe global::Java.Lang.Object Cast(global::Com.Alibaba.Fastjson.Parser.DefaultJSONParser parser, global::Java.Lang.Reflect.IType clazz, global::Java.Lang.Object fieldName, global::Java.Lang.Object val)
		{
			const string __id = "cast.(Lcom/alibaba/fastjson/parser/DefaultJSONParser;Ljava/lang/reflect/Type;Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;";
			try
			{
				JniArgumentValue* __args = stackalloc JniArgumentValue[4];
				__args[0] = new JniArgumentValue((parser == null) ? IntPtr.Zero : ((global::Java.Lang.Object)parser).Handle);
				__args[1] = new JniArgumentValue((clazz == null) ? IntPtr.Zero : ((global::Java.Lang.Object)clazz).Handle);
				__args[2] = new JniArgumentValue((fieldName == null) ? IntPtr.Zero : ((global::Java.Lang.Object)fieldName).Handle);
				__args[3] = new JniArgumentValue((val == null) ? IntPtr.Zero : ((global::Java.Lang.Object)val).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod(__id, this, __args);
				return (Java.Lang.Object)global::Java.Lang.Object.GetObject<global::Java.Lang.Object>(__rm.Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
			}
		}

	}
}