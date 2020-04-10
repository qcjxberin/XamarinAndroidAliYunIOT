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

namespace Com.Alibaba.Fastjson
{
    public partial class JSONObject : global::Com.Alibaba.Fastjson.JSON, global::Java.IO.ISerializable, global::Java.Lang.ICloneable, global::Java.Lang.Reflect.IInvocationHandler, global::Java.Util.IMap
    {
		/// <summary>
		/// 
		/// </summary>
		/// <returns>global::System.Collections.Generic.ICollection<global::Java.Util.IMapEntry></returns>
		public unsafe System.Collections.ICollection EntrySet()
		{
			return RawEntrySet() as System.Collections.ICollection;
		}

		/// <summary>
		/// 
		/// </summary>
		/// <returns>global::System.Collections.Generic.ICollection<string></returns>
		public unsafe System.Collections.ICollection KeySet()
		{
			return RawKeySet() as System.Collections.ICollection;
		}
		/// <summary>
		/// 
		/// </summary>
		/// <param name="key">string</param>
		/// <param name="value">global::Java.Lang.Object</param>
		/// <returns>global::Java.Lang.Object</returns>
		public unsafe global::Java.Lang.Object Put(global::Java.Lang.Object key, global::Java.Lang.Object value)
		{
			return RawPut((string)key, value);
		}
		/// <summary>
		/// 
		/// </summary>
		/// <param name="m">global::System.Collections.Generic.IDictionary<string, global::Java.Lang.Object></param>
		public unsafe void PutAll(global::System.Collections.IDictionary m)
		{
			RawPutAll(m as global::System.Collections.Generic.IDictionary<string, global::Java.Lang.Object>);
		}
		/// <summary>
		/// 
		/// </summary>
		/// <returns>global::System.Collections.Generic.ICollection<global::Java.Lang.Object></returns>
		public unsafe System.Collections.ICollection Values()
		{
			return RawValues() as System.Collections.ICollection;
		}

	}
}