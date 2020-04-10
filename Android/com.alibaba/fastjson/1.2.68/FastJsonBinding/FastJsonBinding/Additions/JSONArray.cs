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
    public partial class JSONArray : global::Com.Alibaba.Fastjson.JSON, global::Java.IO.ISerializable, global::Java.Lang.ICloneable, global::Java.Util.IList, global::Java.Util.IRandomAccess
	{
		/// <summary>
		/// 
		/// </summary>
		/// <param name="index">int</param>
		/// <param name="c">global::System.Collections.Generic.ICollection<global::Java.Lang.Object></param>
		/// <returns></returns>
		public unsafe bool AddAll(int index, System.Collections.ICollection c)
		{
			return RawAddAll(index, c as global::System.Collections.Generic.ICollection<global::Java.Lang.Object>);
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="c">global::System.Collections.Generic.ICollection<global::Java.Lang.Object></param>
		/// <returns></returns>
		public unsafe bool AddAll(System.Collections.ICollection c)
		{
			return RawAddAll(c as global::System.Collections.Generic.ICollection<global::Java.Lang.Object>);
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="c">global::System.Collections.Generic.ICollection<object></param>
		/// <returns></returns>
		public unsafe bool ContainsAll(System.Collections.ICollection c)
		{
			return RawContainsAll(c as global::System.Collections.Generic.ICollection<object>);
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="c">global::System.Collections.Generic.ICollection<object></param>
		/// <returns></returns>
		public unsafe bool RemoveAll(System.Collections.ICollection c)
		{
			return RawRemoveAll(c as global::System.Collections.Generic.ICollection<object>);
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="c">global::System.Collections.Generic.ICollection<object></param>
		/// <returns></returns>
		public unsafe bool RetainAll(System.Collections.ICollection c)
		{
			return RawRetainAll(c as global::System.Collections.Generic.ICollection<object>);
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="fromIndex"></param>
		/// <param name="toIndex"></param>
		/// <returns>global::System.Collections.Generic.IList<global::Java.Lang.Object></returns>
		public unsafe System.Collections.IList SubList(int fromIndex, int toIndex)
		{
			return RawSubList(fromIndex, toIndex) as System.Collections.IList;
		}
	}
}