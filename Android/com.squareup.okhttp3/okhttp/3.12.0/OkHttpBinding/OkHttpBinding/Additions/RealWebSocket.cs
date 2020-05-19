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

namespace Okhttp3.Internal.WS
{
    public sealed partial class RealWebSocket : global::Java.Lang.Object, global::Okhttp3.IWebSocket
    {
        unsafe bool global::Okhttp3.IWebSocket.Close(int code, string reason)
        {
            return InvokeClose(code, reason);
        }
    }
}