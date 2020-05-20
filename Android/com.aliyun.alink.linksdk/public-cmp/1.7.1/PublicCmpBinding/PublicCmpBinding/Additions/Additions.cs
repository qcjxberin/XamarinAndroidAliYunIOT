using System;
using System.Collections.Generic;
using System.Linq;
using Android.Runtime;
using Java.Interop;


namespace Com.Aliyun.Alink.Linksdk.Cmp.Connect.Channel
{	
	public partial class PersistentConnect
    {
		static Delegate cb_onAuth_Ljava_util_Map_;
#pragma warning disable 0169
		static Delegate GetOnAuth_Ljava_util_Map_Handler()
		{
			if (cb_onAuth_Ljava_util_Map_ == null)
				cb_onAuth_Ljava_util_Map_ = JNINativeWrapper.CreateDelegate((Action<IntPtr, IntPtr, IntPtr>)n_OnAuth_Ljava_util_Map_);
			return cb_onAuth_Ljava_util_Map_;
		}

		static void n_OnAuth_Ljava_util_Map_(IntPtr jnienv, IntPtr native__this, IntPtr native_authInfo)
		{
			global::Com.Aliyun.Alink.Linksdk.Cmp.Connect.Channel.PersistentConnect __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Cmp.Connect.Channel.PersistentConnect>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var authInfo = global::Android.Runtime.JavaDictionary<string, string>.FromJniHandle(native_authInfo, JniHandleOwnership.DoNotTransfer);
			__this.OnAuth(authInfo);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.cmp.connect.channel']/class[@name='PersistentConnect']/method[@name='onAuth' and count(parameter)=1 and parameter[1][@type='java.util.Map&lt;java.lang.String, java.lang.String&gt;']]"
		[Register("onAuth", "(Ljava/util/Map;)V", "GetOnAuth_Ljava_util_Map_Handler")]
		public virtual unsafe void OnAuth(global::System.Collections.Generic.IDictionary<string, string> authInfo)
		{
			const string __id = "onAuth.(Ljava/util/Map;)V";
			IntPtr native_authInfo = global::Android.Runtime.JavaDictionary<string, string>.ToLocalJniHandle(authInfo);
			try
			{
				JniArgumentValue* __args = stackalloc JniArgumentValue[1];
				__args[0] = new JniArgumentValue(native_authInfo);
				_members.InstanceMethods.InvokeVirtualVoidMethod(__id, this, __args);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(native_authInfo);
			}
		}

		// This method is explicitly implemented as a member of an instantiated Com.Aliyun.Alink.Linksdk.Cmp.Core.Listener.IConnectAuth
		void global::Com.Aliyun.Alink.Linksdk.Cmp.Core.Listener.IConnectAuth.OnAuth(global::Java.Lang.Object p0)
		{
			var androidList = Java.Interop.JavaObjectExtensions.JavaCast<JavaDictionary<string, string>>(p0);			
			OnAuth(androidList);
		}
	}	
}

namespace Com.Aliyun.Alink.Linksdk.Cmp.Connect.Alcs
{
	public partial class AlcsConnect 
	{
		static Delegate cb_onAuth_Ljava_util_Map_;
#pragma warning disable 0169
		static Delegate GetOnAuth_Ljava_util_Map_Handler()
		{
			if (cb_onAuth_Ljava_util_Map_ == null)
				cb_onAuth_Ljava_util_Map_ = JNINativeWrapper.CreateDelegate((Action<IntPtr, IntPtr, IntPtr>)n_OnAuth_Ljava_util_Map_);
			return cb_onAuth_Ljava_util_Map_;
		}

		static void n_OnAuth_Ljava_util_Map_(IntPtr jnienv, IntPtr native__this, IntPtr native_authInfo)
		{
			global::Com.Aliyun.Alink.Linksdk.Cmp.Connect.Alcs.AlcsConnect __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Cmp.Connect.Alcs.AlcsConnect>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var authInfo = global::Android.Runtime.JavaDictionary<string, string>.FromJniHandle(native_authInfo, JniHandleOwnership.DoNotTransfer);
			__this.OnAuth(authInfo);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.cmp.connect.alcs']/class[@name='AlcsConnect']/method[@name='onAuth' and count(parameter)=1 and parameter[1][@type='java.util.Map&lt;java.lang.String, java.lang.String&gt;']]"
		[Register("onAuth", "(Ljava/util/Map;)V", "GetOnAuth_Ljava_util_Map_Handler")]
		public virtual unsafe void OnAuth(global::System.Collections.Generic.IDictionary<string, string> authInfo)
		{
			const string __id = "onAuth.(Ljava/util/Map;)V";
			IntPtr native_authInfo = global::Android.Runtime.JavaDictionary<string, string>.ToLocalJniHandle(authInfo);
			try
			{
				JniArgumentValue* __args = stackalloc JniArgumentValue[1];
				__args[0] = new JniArgumentValue(native_authInfo);
				_members.InstanceMethods.InvokeVirtualVoidMethod(__id, this, __args);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(native_authInfo);
			}
		}

		// This method is explicitly implemented as a member of an instantiated Com.Aliyun.Alink.Linksdk.Cmp.Core.Listener.IConnectAuth
		void global::Com.Aliyun.Alink.Linksdk.Cmp.Core.Listener.IConnectAuth.OnAuth(global::Java.Lang.Object p0)
		{
			var androidList = Java.Interop.JavaObjectExtensions.JavaCast<JavaDictionary<string, string>>(p0);
			OnAuth(androidList);
		}
	}

	public partial class AlcsServerConnect
	{
		static Delegate cb_onAuth_Ljava_util_Map_;
#pragma warning disable 0169
		static Delegate GetOnAuth_Ljava_util_Map_Handler()
		{
			if (cb_onAuth_Ljava_util_Map_ == null)
				cb_onAuth_Ljava_util_Map_ = JNINativeWrapper.CreateDelegate((Action<IntPtr, IntPtr, IntPtr>)n_OnAuth_Ljava_util_Map_);
			return cb_onAuth_Ljava_util_Map_;
		}

		static void n_OnAuth_Ljava_util_Map_(IntPtr jnienv, IntPtr native__this, IntPtr native_authInfo)
		{
			global::Com.Aliyun.Alink.Linksdk.Cmp.Connect.Alcs.AlcsServerConnect __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Cmp.Connect.Alcs.AlcsServerConnect>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var authInfo = global::Android.Runtime.JavaDictionary<string, string>.FromJniHandle(native_authInfo, JniHandleOwnership.DoNotTransfer);
			__this.OnAuth(authInfo);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.cmp.connect.alcs']/class[@name='AlcsServerConnect']/method[@name='onAuth' and count(parameter)=1 and parameter[1][@type='java.util.Map&lt;java.lang.String, java.lang.String&gt;']]"
		[Register("onAuth", "(Ljava/util/Map;)V", "GetOnAuth_Ljava_util_Map_Handler")]
		public virtual unsafe void OnAuth(global::System.Collections.Generic.IDictionary<string, string> authInfo)
		{
			const string __id = "onAuth.(Ljava/util/Map;)V";
			IntPtr native_authInfo = global::Android.Runtime.JavaDictionary<string, string>.ToLocalJniHandle(authInfo);
			try
			{
				JniArgumentValue* __args = stackalloc JniArgumentValue[1];
				__args[0] = new JniArgumentValue(native_authInfo);
				_members.InstanceMethods.InvokeVirtualVoidMethod(__id, this, __args);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(native_authInfo);
			}
		}

		// This method is explicitly implemented as a member of an instantiated Com.Aliyun.Alink.Linksdk.Cmp.Core.Listener.IConnectAuth
		void global::Com.Aliyun.Alink.Linksdk.Cmp.Core.Listener.IConnectAuth.OnAuth(global::Java.Lang.Object p0)
		{
			var androidList = Java.Interop.JavaObjectExtensions.JavaCast<JavaDictionary<string, string>>(p0);
			OnAuth(androidList);
		}
	}
}

