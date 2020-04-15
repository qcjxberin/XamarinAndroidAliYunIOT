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

namespace Com.Facebook.Datasource
{
    public partial class FirstAvailableDataSourceSupplier : global::Java.Lang.Object, global::Com.Facebook.Common.Internal.ISupplier
    {
		public unsafe global::Java.Lang.Object Get()
		{
			return (Java.Lang.Object)RawGet();
		}
	}
}