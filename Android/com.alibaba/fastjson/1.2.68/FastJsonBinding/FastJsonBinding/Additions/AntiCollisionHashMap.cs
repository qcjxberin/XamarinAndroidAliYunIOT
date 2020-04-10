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

namespace Com.Alibaba.Fastjson.Util
{
    public partial class AntiCollisionHashMap : global::Java.Util.AbstractMap, global::Java.IO.ISerializable, global::Java.Lang.ICloneable, global::Java.Util.IMap
    {
		/// <summary>
		/// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.fastjson.util']/class[@name='AntiCollisionHashMap']/method[@name='entrySet' and count(parameter)=0]"
		/// </summary>
		/// <returns>ICollection<global::Java.Util.IMapEntry></returns>
		[Register("entrySet", "()Ljava/util/Set;", "GetEntrySetHandler")]
		public override unsafe global::System.Collections.ICollection EntrySet()
		{
			const string __id = "entrySet.()Ljava/util/Set;";
			try
			{
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod(__id, this, null);
				var nativeJavaResult= global::Android.Runtime.JavaSet<global::Java.Util.IMapEntry>.FromJniHandle(__rm.Handle, JniHandleOwnership.TransferLocalRef);
				var result = nativeJavaResult as System.Collections.ICollection;
				return result;
			}
			finally
			{
			}
		}
	}
}