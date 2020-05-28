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
using Org.Json;

namespace Com.Alibaba.Sdk.Android.Openaccount.UI.Widget
{
    public partial class OauthWidget 
    {
        // Metadata.xml XPath field reference: path="/api/package[@name='com.alibaba.sdk.android.openaccount.ui.widget']/class[@name='OauthWidget']/field[@name='oauths']"
        [Register("oauths")]
        protected IList<TextView> Oauths
        {
            get
            {
                const string __id = "oauths.[Landroid/widget/TextView;";

                var __v = _members.InstanceFields.GetObjectValue(__id, this);
                return global::Android.Runtime.JavaArray<global::Android.Widget.TextView>.FromJniHandle(__v.Handle, JniHandleOwnership.TransferLocalRef);
            }
            set
            {
                const string __id = "oauths.[Landroid/widget/TextView;";

                IntPtr native_value = global::Android.Runtime.JavaArray<global::Android.Widget.TextView>.ToLocalJniHandle(value);
                try
                {
                    _members.InstanceFields.SetValue(__id, this, new JniObjectReference(native_value));
                }
                finally
                {
                    global::Android.Runtime.JNIEnv.DeleteLocalRef(native_value);
                }
            }
        }


        // Metadata.xml XPath field reference: path="/api/package[@name='com.alibaba.sdk.android.openaccount.ui.widget']/class[@name='OauthWidget']/field[@name='texts']"
        [Register("texts")]
        protected IList<TextView> Texts
        {
            get
            {
                const string __id = "texts.[Landroid/widget/TextView;";

                var __v = _members.InstanceFields.GetObjectValue(__id, this);
                return global::Android.Runtime.JavaArray<global::Android.Widget.TextView>.FromJniHandle(__v.Handle, JniHandleOwnership.TransferLocalRef);
            }
            set
            {
                const string __id = "texts.[Landroid/widget/TextView;";

                IntPtr native_value = global::Android.Runtime.JavaArray<global::Android.Widget.TextView>.ToLocalJniHandle(value);
                try
                {
                    _members.InstanceFields.SetValue(__id, this, new JniObjectReference(native_value));
                }
                finally
                {
                    global::Android.Runtime.JNIEnv.DeleteLocalRef(native_value);
                }
            }
        }
    }
}

namespace Com.Alibaba.Sdk.Android.Openaccount.UI.Model 
{
    public partial class CountryComparator 
    {        
        public int Compare(Java.Lang.Object o1, Java.Lang.Object o2) 
        {             
            return Compare(o1 as CountrySort, o2 as CountrySort);
        }
    }
}

namespace Com.Alibaba.Sdk.Android.Openaccount.UI.Task
{
    public partial class UpdateProfileTask 
    {
        protected override Java.Lang.Object ParseData(JSONObject p0)
        {
            return RawParseData(p0);
        }

        protected override Java.Lang.Object AsyncExecute(params Java.Lang.Object[] p0)
        {
            return AsyncExecute(p0 as Java.Lang.Void[]);
        }
    }
    public partial class UpdateLoginIdTask
    {
        protected override Java.Lang.Object ParseData(JSONObject p0)
        {
            return RawParseData(p0);
        }
        protected override Java.Lang.Object AsyncExecute(params Java.Lang.Object[] p0)
        {
            return AsyncExecute(p0 as Java.Lang.Void[]);
        }
    }
    public partial class QrLoginConfirmTask
    {
        protected override Java.Lang.Object AsyncExecute(params Java.Lang.Object[] p0)
        {
            return AsyncExecute(p0 as Java.Lang.Void[]);
        }
    }
    public partial class OpenAccountLoginTask
    {
        protected override Java.Lang.Object AsyncExecute(params Java.Lang.Object[] p0)
        {
            return AsyncExecute(p0 as Java.Lang.Void[]);
        }
    }
    public partial class LoginByQrCodeTask
    {
        protected override Java.Lang.Object AsyncExecute(params Java.Lang.Object[] p0)
        {
            return AsyncExecute(p0 as Java.Lang.Void[]);
        }
    }
    public partial class LoginByIVTokenTask
    {
        protected override Java.Lang.Object AsyncExecute(params Java.Lang.Object[] p0)
        {
            return AsyncExecute(p0 as Java.Lang.Void[]);
        }
    }
    public partial class CheckOpenAccountExistTask
    {
        protected override Java.Lang.Object AsyncExecute(params Java.Lang.Object[] p0)
        {
            return AsyncExecute(p0 as Java.Lang.Void[]);
        }
    }
}