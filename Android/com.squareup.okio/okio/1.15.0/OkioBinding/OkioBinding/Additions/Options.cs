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

namespace Okio
{
    public sealed partial class Options : global::Java.Util.AbstractList, global::Java.Util.IRandomAccess
    {
		// Metadata.xml XPath method reference: path="/api/package[@name='okio']/class[@name='Options']/method[@name='get' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register("get", "(I)Lokio/ByteString;", "")]
		public unsafe global::Okio.ByteString RawGet(int i)
		{
			const string __id = "get.(I)Lokio/ByteString;";
			try
			{
				JniArgumentValue* __args = stackalloc JniArgumentValue[1];
				__args[0] = new JniArgumentValue(i);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod(__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Okio.ByteString>(__rm.Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
			}
		}
		public override Java.Lang.Object Get(int index)
		{
			return RawGet(index);
		}
	}
}