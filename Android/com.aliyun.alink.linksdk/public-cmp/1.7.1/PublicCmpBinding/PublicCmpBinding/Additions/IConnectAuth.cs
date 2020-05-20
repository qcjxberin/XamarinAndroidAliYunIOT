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


namespace Com.Aliyun.Alink.Linksdk.Cmp.Core.Listener
{		
    public partial interface IConnectAuth
    {
		// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.cmp.core.listener']/interface[@name='IConnectAuth']/method[@name='onAuth' and count(parameter)=1 and parameter[1][@type='T']]"
		[Register("onAuth", "(Ljava/lang/Object;)V", "GetOnAuth_Ljava_lang_Object_Handler:Com.Aliyun.Alink.Linksdk.Cmp.Core.Listener.IConnectAuthInvoker, PublicCmpBinding")]
		void OnAuth(global::Java.Lang.Object p0);
	}
    internal partial class IConnectAuthInvoker 
    {
		static Delegate cb_onAuth_Ljava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetOnAuth_Ljava_lang_Object_Handler()
		{
			if (cb_onAuth_Ljava_lang_Object_ == null)
				cb_onAuth_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate((Action<IntPtr, IntPtr, IntPtr>)n_OnAuth_Ljava_lang_Object_);
			return cb_onAuth_Ljava_lang_Object_;
		}

		static void n_OnAuth_Ljava_lang_Object_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Aliyun.Alink.Linksdk.Cmp.Core.Listener.IConnectAuth __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Cmp.Core.Listener.IConnectAuth>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object>(native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnAuth(p0);
		}
#pragma warning restore 0169

		IntPtr id_onAuth_Ljava_lang_Object_;
		public unsafe void OnAuth(global::Java.Lang.Object p0)
		{
			if (id_onAuth_Ljava_lang_Object_ == IntPtr.Zero)
				id_onAuth_Ljava_lang_Object_ = JNIEnv.GetMethodID(class_ref, "onAuth", "(Ljava/lang/Object;)V");
			IntPtr native_p0 = JNIEnv.ToLocalJniHandle(p0);
			JValue* __args = stackalloc JValue[1];
			__args[0] = new JValue(native_p0);
			JNIEnv.CallVoidMethod(((global::Java.Lang.Object)this).Handle, id_onAuth_Ljava_lang_Object_, __args);
			JNIEnv.DeleteLocalRef(native_p0);
		}
	}

	
}

