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
using Com.Google.Gson.Stream;

namespace Com.Google.Gson.Internal.Bind
{
    public sealed partial class DateTypeAdapter : global::Com.Google.Gson.TypeAdapter
    {
        public override Java.Lang.Object Read(JsonReader p0)
        {
            return RawRead(p0);
        }

        public override void Write(JsonWriter p0, Java.Lang.Object p1)
        {
            RawWrite(p0, (Java.Util.Date)p1);
        }
    }
}