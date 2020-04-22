using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Aliyun.Iot.Aep.Sdk.Framework.Config {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.aliyun.iot.aep.sdk.framework.config']/class[@name='AConfigure']"
	[global::Android.Runtime.Register ("com/aliyun/iot/aep/sdk/framework/config/AConfigure", DoNotGenerateAcw=true)]
	public partial class AConfigure : global::Java.Lang.Object {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/aliyun/iot/aep/sdk/framework/config/AConfigure", typeof (AConfigure));
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

		protected AConfigure (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static Delegate cb_getConfig;
#pragma warning disable 0169
		static Delegate GetGetConfigHandler ()
		{
			if (cb_getConfig == null)
				cb_getConfig = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetConfig);
			return cb_getConfig;
		}

		static IntPtr n_GetConfig (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Aliyun.Iot.Aep.Sdk.Framework.Config.AConfigure __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Iot.Aep.Sdk.Framework.Config.AConfigure> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaDictionary.ToLocalJniHandle (__this.Config);
		}
#pragma warning restore 0169

		public virtual unsafe global::System.Collections.IDictionary Config {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.iot.aep.sdk.framework.config']/class[@name='AConfigure']/method[@name='getConfig' and count(parameter)=0]"
			[Register ("getConfig", "()Ljava/util/Map;", "GetGetConfigHandler")]
			get {
				const string __id = "getConfig.()Ljava/util/Map;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Android.Runtime.JavaDictionary.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getEnv;
#pragma warning disable 0169
		static Delegate GetGetEnvHandler ()
		{
			if (cb_getEnv == null)
				cb_getEnv = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetEnv);
			return cb_getEnv;
		}

		static IntPtr n_GetEnv (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Aliyun.Iot.Aep.Sdk.Framework.Config.AConfigure __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Iot.Aep.Sdk.Framework.Config.AConfigure> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Env);
		}
#pragma warning restore 0169

		public virtual unsafe string Env {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.iot.aep.sdk.framework.config']/class[@name='AConfigure']/method[@name='getEnv' and count(parameter)=0]"
			[Register ("getEnv", "()Ljava/lang/String;", "GetGetEnvHandler")]
			get {
				const string __id = "getEnv.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		public static unsafe global::Com.Aliyun.Iot.Aep.Sdk.Framework.Config.AConfigure Instance {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.iot.aep.sdk.framework.config']/class[@name='AConfigure']/method[@name='getInstance' and count(parameter)=0]"
			[Register ("getInstance", "()Lcom/aliyun/iot/aep/sdk/framework/config/AConfigure;", "")]
			get {
				const string __id = "getInstance.()Lcom/aliyun/iot/aep/sdk/framework/config/AConfigure;";
				try {
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
					return global::Java.Lang.Object.GetObject<global::Com.Aliyun.Iot.Aep.Sdk.Framework.Config.AConfigure> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getConfig_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetGetConfig_Ljava_lang_String_Handler ()
		{
			if (cb_getConfig_Ljava_lang_String_ == null)
				cb_getConfig_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_GetConfig_Ljava_lang_String_);
			return cb_getConfig_Ljava_lang_String_;
		}

		static IntPtr n_GetConfig_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_key)
		{
			global::Com.Aliyun.Iot.Aep.Sdk.Framework.Config.AConfigure __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Iot.Aep.Sdk.Framework.Config.AConfigure> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string key = JNIEnv.GetString (native_key, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewString (__this.GetConfig (key));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.iot.aep.sdk.framework.config']/class[@name='AConfigure']/method[@name='getConfig' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("getConfig", "(Ljava/lang/String;)Ljava/lang/String;", "GetGetConfig_Ljava_lang_String_Handler")]
		public virtual unsafe string GetConfig (string key)
		{
			const string __id = "getConfig.(Ljava/lang/String;)Ljava/lang/String;";
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

		static Delegate cb_getSpConfig_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetGetSpConfig_Ljava_lang_String_Handler ()
		{
			if (cb_getSpConfig_Ljava_lang_String_ == null)
				cb_getSpConfig_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_GetSpConfig_Ljava_lang_String_);
			return cb_getSpConfig_Ljava_lang_String_;
		}

		static IntPtr n_GetSpConfig_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_key)
		{
			global::Com.Aliyun.Iot.Aep.Sdk.Framework.Config.AConfigure __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Iot.Aep.Sdk.Framework.Config.AConfigure> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string key = JNIEnv.GetString (native_key, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewString (__this.GetSpConfig (key));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.iot.aep.sdk.framework.config']/class[@name='AConfigure']/method[@name='getSpConfig' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("getSpConfig", "(Ljava/lang/String;)Ljava/lang/String;", "GetGetSpConfig_Ljava_lang_String_Handler")]
		public virtual unsafe string GetSpConfig (string key)
		{
			const string __id = "getSpConfig.(Ljava/lang/String;)Ljava/lang/String;";
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

		static Delegate cb_init_Landroid_content_Context_;
#pragma warning disable 0169
		static Delegate GetInit_Landroid_content_Context_Handler ()
		{
			if (cb_init_Landroid_content_Context_ == null)
				cb_init_Landroid_content_Context_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_Init_Landroid_content_Context_);
			return cb_init_Landroid_content_Context_;
		}

		static void n_Init_Landroid_content_Context_ (IntPtr jnienv, IntPtr native__this, IntPtr native_ctx)
		{
			global::Com.Aliyun.Iot.Aep.Sdk.Framework.Config.AConfigure __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Iot.Aep.Sdk.Framework.Config.AConfigure> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.Context ctx = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (native_ctx, JniHandleOwnership.DoNotTransfer);
			__this.Init (ctx);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.iot.aep.sdk.framework.config']/class[@name='AConfigure']/method[@name='init' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("init", "(Landroid/content/Context;)V", "GetInit_Landroid_content_Context_Handler")]
		public virtual unsafe void Init (global::Android.Content.Context ctx)
		{
			const string __id = "init.(Landroid/content/Context;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((ctx == null) ? IntPtr.Zero : ((global::Java.Lang.Object) ctx).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_putConfig_Ljava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetPutConfig_Ljava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_putConfig_Ljava_lang_String_Ljava_lang_String_ == null)
				cb_putConfig_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_PutConfig_Ljava_lang_String_Ljava_lang_String_);
			return cb_putConfig_Ljava_lang_String_Ljava_lang_String_;
		}

		static void n_PutConfig_Ljava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_key, IntPtr native_value)
		{
			global::Com.Aliyun.Iot.Aep.Sdk.Framework.Config.AConfigure __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Iot.Aep.Sdk.Framework.Config.AConfigure> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string key = JNIEnv.GetString (native_key, JniHandleOwnership.DoNotTransfer);
			string value = JNIEnv.GetString (native_value, JniHandleOwnership.DoNotTransfer);
			__this.PutConfig (key, value);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.iot.aep.sdk.framework.config']/class[@name='AConfigure']/method[@name='putConfig' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("putConfig", "(Ljava/lang/String;Ljava/lang/String;)V", "GetPutConfig_Ljava_lang_String_Ljava_lang_String_Handler")]
		public virtual unsafe void PutConfig (string key, string value)
		{
			const string __id = "putConfig.(Ljava/lang/String;Ljava/lang/String;)V";
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

		static Delegate cb_updateSpConfig_Ljava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetUpdateSpConfig_Ljava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_updateSpConfig_Ljava_lang_String_Ljava_lang_String_ == null)
				cb_updateSpConfig_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_UpdateSpConfig_Ljava_lang_String_Ljava_lang_String_);
			return cb_updateSpConfig_Ljava_lang_String_Ljava_lang_String_;
		}

		static void n_UpdateSpConfig_Ljava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_key, IntPtr native_value)
		{
			global::Com.Aliyun.Iot.Aep.Sdk.Framework.Config.AConfigure __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Iot.Aep.Sdk.Framework.Config.AConfigure> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string key = JNIEnv.GetString (native_key, JniHandleOwnership.DoNotTransfer);
			string value = JNIEnv.GetString (native_value, JniHandleOwnership.DoNotTransfer);
			__this.UpdateSpConfig (key, value);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.iot.aep.sdk.framework.config']/class[@name='AConfigure']/method[@name='updateSpConfig' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("updateSpConfig", "(Ljava/lang/String;Ljava/lang/String;)V", "GetUpdateSpConfig_Ljava_lang_String_Ljava_lang_String_Handler")]
		public virtual unsafe void UpdateSpConfig (string key, string value)
		{
			const string __id = "updateSpConfig.(Ljava/lang/String;Ljava/lang/String;)V";
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
