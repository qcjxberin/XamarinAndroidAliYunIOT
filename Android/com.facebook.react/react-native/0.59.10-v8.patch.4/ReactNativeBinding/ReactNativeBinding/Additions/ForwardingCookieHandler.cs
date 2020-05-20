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
using Java.Net;

namespace Com.Facebook.React.Modules.Network
{
    public partial class ForwardingCookieHandler
    {
        public override void Put(URI uri, IDictionary<string, IList<string>> responseHeaders) 
        {
            RawPut(uri, responseHeaders);
        }

        public override IDictionary<string, IList<string>> Get(URI uri, IDictionary<string, IList<string>> requestHeaders)
        {
            return RawGet(uri, requestHeaders);
        }

    }
}