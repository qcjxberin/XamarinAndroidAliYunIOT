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

namespace Com.Facebook.Cache.Disk
{
    
    public partial class DefaultDiskStorage : global::Java.Lang.Object, global::Com.Facebook.Cache.Disk.IDiskStorage
    {
		public global::System.Collections.Generic.ICollection<global::Com.Facebook.Cache.Disk.IDiskStorageEntry> Entries
		{
			get 
			{
				return RawEntries();
			}
		}
		
		public partial class EntryImpl : global::Java.Lang.Object, global::Com.Facebook.Cache.Disk.IDiskStorageEntry 
		{
			public global::Com.Facebook.Binaryresource.IBinaryResource Resource		
			{
				get 
				{
					return RawResource();
				}
			}
		}
	}
}