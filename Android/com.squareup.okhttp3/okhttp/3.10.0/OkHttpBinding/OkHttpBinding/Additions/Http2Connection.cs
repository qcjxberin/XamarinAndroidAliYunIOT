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

namespace Okhttp3.Internal.Http2
{
    public sealed partial class Http2Connection : global::Java.Lang.Object, global::Java.IO.ICloseable
    {
        public sealed partial class PingRunnable : global::Okhttp3.Internal.NamedRunnable
        {

			// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3.internal.http2']/class[@name='Http2Connection.PingRunnable']/method[@name='execute' and count(parameter)=0]"
			[Register("execute", "()V", "")]
			protected override unsafe void Execute()
			{
				const string __id = "execute.()V";
				try
				{
					_members.InstanceMethods.InvokeAbstractVoidMethod(__id, this, null);
				}
				finally
				{
				}
			}
		}
    }
}