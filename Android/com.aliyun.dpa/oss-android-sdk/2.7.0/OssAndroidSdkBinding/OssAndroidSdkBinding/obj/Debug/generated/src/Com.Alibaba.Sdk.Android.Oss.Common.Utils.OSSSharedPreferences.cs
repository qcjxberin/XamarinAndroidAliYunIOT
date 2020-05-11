using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Alibaba.Sdk.Android.Oss.Common.Utils {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.alibaba.sdk.android.oss.common.utils']/class[@name='OSSSharedPreferences']"
	[global::Android.Runtime.Register ("com/alibaba/sdk/android/oss/common/utils/OSSSharedPreferences", DoNotGenerateAcw=true)]
	public partial class OSSSharedPreferences : global::Java.Lang.Object {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/alibaba/sdk/android/oss/common/utils/OSSSharedPreferences", typeof (OSSSharedPreferences));
		internal static new IntPtr class_ref {
			get {
				return _members.JniPeerType.PeerReference.Handle;
			}
		}

		public override global::Java.Interop.JniPeerMembers JniPeerMembers {
			get { return _members; }
		}

		protected override IntPtr ThresholdClass {
			get { return _members.JniPeerType.PeerReference.Handle; }
		}

		protected override global::System.Type ThresholdType {
			get { return _members.ManagedPeerType; }
		}

		protected OSSSharedPreferences (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static Delegate cb_contains_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetContains_Ljava_lang_String_Handler ()
		{
			if (cb_contains_Ljava_lang_String_ == null)
				cb_contains_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_Contains_Ljava_lang_String_);
			return cb_contains_Ljava_lang_String_;
		}

		static bool n_Contains_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_key)
		{
			global::Com.Alibaba.Sdk.Android.Oss.Common.Utils.OSSSharedPreferences __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.Common.Utils.OSSSharedPreferences> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string key = JNIEnv.GetString (native_key, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.Contains (key);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.oss.common.utils']/class[@name='OSSSharedPreferences']/method[@name='contains' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("contains", "(Ljava/lang/String;)Z", "GetContains_Ljava_lang_String_Handler")]
		public virtual unsafe bool Contains (string key)
		{
			const string __id = "contains.(Ljava/lang/String;)Z";
			IntPtr native_key = JNIEnv.NewString (key);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_key);
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
				JNIEnv.DeleteLocalRef (native_key);
			}
		}

		static Delegate cb_getStringValue_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetGetStringValue_Ljava_lang_String_Handler ()
		{
			if (cb_getStringValue_Ljava_lang_String_ == null)
				cb_getStringValue_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_GetStringValue_Ljava_lang_String_);
			return cb_getStringValue_Ljava_lang_String_;
		}

		static IntPtr n_GetStringValue_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_key)
		{
			global::Com.Alibaba.Sdk.Android.Oss.Common.Utils.OSSSharedPreferences __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.Common.Utils.OSSSharedPreferences> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string key = JNIEnv.GetString (native_key, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewString (__this.GetStringValue (key));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.oss.common.utils']/class[@name='OSSSharedPreferences']/method[@name='getStringValue' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("getStringValue", "(Ljava/lang/String;)Ljava/lang/String;", "GetGetStringValue_Ljava_lang_String_Handler")]
		public virtual unsafe string GetStringValue (string key)
		{
			const string __id = "getStringValue.(Ljava/lang/String;)Ljava/lang/String;";
			IntPtr native_key = JNIEnv.NewString (key);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_key);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_key);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.oss.common.utils']/class[@name='OSSSharedPreferences']/method[@name='instance' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("instance", "(Landroid/content/Context;)Lcom/alibaba/sdk/android/oss/common/utils/OSSSharedPreferences;", "")]
		public static unsafe global::Com.Alibaba.Sdk.Android.Oss.Common.Utils.OSSSharedPreferences Instance (global::Android.Content.Context context)
		{
			const string __id = "instance.(Landroid/content/Context;)Lcom/alibaba/sdk/android/oss/common/utils/OSSSharedPreferences;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((context == null) ? IntPtr.Zero : ((global::Java.Lang.Object) context).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.Common.Utils.OSSSharedPreferences> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_removeKey_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetRemoveKey_Ljava_lang_String_Handler ()
		{
			if (cb_removeKey_Ljava_lang_String_ == null)
				cb_removeKey_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_RemoveKey_Ljava_lang_String_);
			return cb_removeKey_Ljava_lang_String_;
		}

		static void n_RemoveKey_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_key)
		{
			global::Com.Alibaba.Sdk.Android.Oss.Common.Utils.OSSSharedPreferences __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.Common.Utils.OSSSharedPreferences> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string key = JNIEnv.GetString (native_key, JniHandleOwnership.DoNotTransfer);
			__this.RemoveKey (key);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.oss.common.utils']/class[@name='OSSSharedPreferences']/method[@name='removeKey' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("removeKey", "(Ljava/lang/String;)V", "GetRemoveKey_Ljava_lang_String_Handler")]
		public virtual unsafe void RemoveKey (string key)
		{
			const string __id = "removeKey.(Ljava/lang/String;)V";
			IntPtr native_key = JNIEnv.NewString (key);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_key);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_key);
			}
		}

		static Delegate cb_setStringValue_Ljava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetStringValue_Ljava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_setStringValue_Ljava_lang_String_Ljava_lang_String_ == null)
				cb_setStringValue_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_SetStringValue_Ljava_lang_String_Ljava_lang_String_);
			return cb_setStringValue_Ljava_lang_String_Ljava_lang_String_;
		}

		static void n_SetStringValue_Ljava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_key, IntPtr native_value)
		{
			global::Com.Alibaba.Sdk.Android.Oss.Common.Utils.OSSSharedPreferences __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.Common.Utils.OSSSharedPreferences> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string key = JNIEnv.GetString (native_key, JniHandleOwnership.DoNotTransfer);
			string value = JNIEnv.GetString (native_value, JniHandleOwnership.DoNotTransfer);
			__this.SetStringValue (key, value);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.oss.common.utils']/class[@name='OSSSharedPreferences']/method[@name='setStringValue' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("setStringValue", "(Ljava/lang/String;Ljava/lang/String;)V", "GetSetStringValue_Ljava_lang_String_Ljava_lang_String_Handler")]
		public virtual unsafe void SetStringValue (string key, string value)
		{
			const string __id = "setStringValue.(Ljava/lang/String;Ljava/lang/String;)V";
			IntPtr native_key = JNIEnv.NewString (key);
			IntPtr native_value = JNIEnv.NewString (value);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_key);
				__args [1] = new JniArgumentValue (native_value);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_key);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

	}
}
