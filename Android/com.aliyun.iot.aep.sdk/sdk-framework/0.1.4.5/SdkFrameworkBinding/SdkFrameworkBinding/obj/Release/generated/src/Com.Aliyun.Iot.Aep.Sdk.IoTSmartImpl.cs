using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Aliyun.Iot.Aep.Sdk {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.aliyun.iot.aep.sdk']/class[@name='IoTSmartImpl']"
	[global::Android.Runtime.Register ("com/aliyun/iot/aep/sdk/IoTSmartImpl", DoNotGenerateAcw=true)]
	public partial class IoTSmartImpl : global::Java.Lang.Object {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/aliyun/iot/aep/sdk/IoTSmartImpl", typeof (IoTSmartImpl));
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

		protected IoTSmartImpl (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.aliyun.iot.aep.sdk']/class[@name='IoTSmartImpl']/constructor[@name='IoTSmartImpl' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe IoTSmartImpl ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "()V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), null);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_getCountry;
#pragma warning disable 0169
		static Delegate GetGetCountryHandler ()
		{
			if (cb_getCountry == null)
				cb_getCountry = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetCountry);
			return cb_getCountry;
		}

		static IntPtr n_GetCountry (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Aliyun.Iot.Aep.Sdk.IoTSmartImpl __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Iot.Aep.Sdk.IoTSmartImpl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Country);
		}
#pragma warning restore 0169

		public virtual unsafe global::Com.Aliyun.Iot.Aep.Sdk.IoTSmart.Country Country {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.iot.aep.sdk']/class[@name='IoTSmartImpl']/method[@name='getCountry' and count(parameter)=0]"
			[Register ("getCountry", "()Lcom/aliyun/iot/aep/sdk/IoTSmart$Country;", "GetGetCountryHandler")]
			get {
				const string __id = "getCountry.()Lcom/aliyun/iot/aep/sdk/IoTSmart$Country;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Aliyun.Iot.Aep.Sdk.IoTSmart.Country> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		public static unsafe global::Com.Aliyun.Iot.Aep.Sdk.IoTSmartImpl Instance {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.iot.aep.sdk']/class[@name='IoTSmartImpl']/method[@name='getInstance' and count(parameter)=0]"
			[Register ("getInstance", "()Lcom/aliyun/iot/aep/sdk/IoTSmartImpl;", "")]
			get {
				const string __id = "getInstance.()Lcom/aliyun/iot/aep/sdk/IoTSmartImpl;";
				try {
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
					return global::Java.Lang.Object.GetObject<global::Com.Aliyun.Iot.Aep.Sdk.IoTSmartImpl> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getLanguage;
#pragma warning disable 0169
		static Delegate GetGetLanguageHandler ()
		{
			if (cb_getLanguage == null)
				cb_getLanguage = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetLanguage);
			return cb_getLanguage;
		}

		static IntPtr n_GetLanguage (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Aliyun.Iot.Aep.Sdk.IoTSmartImpl __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Iot.Aep.Sdk.IoTSmartImpl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Language);
		}
#pragma warning restore 0169

		static Delegate cb_setLanguage_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetLanguage_Ljava_lang_String_Handler ()
		{
			if (cb_setLanguage_Ljava_lang_String_ == null)
				cb_setLanguage_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetLanguage_Ljava_lang_String_);
			return cb_setLanguage_Ljava_lang_String_;
		}

		static void n_SetLanguage_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_language)
		{
			global::Com.Aliyun.Iot.Aep.Sdk.IoTSmartImpl __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Iot.Aep.Sdk.IoTSmartImpl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string language = JNIEnv.GetString (native_language, JniHandleOwnership.DoNotTransfer);
			__this.Language = language;
		}
#pragma warning restore 0169

		public virtual unsafe string Language {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.iot.aep.sdk']/class[@name='IoTSmartImpl']/method[@name='getLanguage' and count(parameter)=0]"
			[Register ("getLanguage", "()Ljava/lang/String;", "GetGetLanguageHandler")]
			get {
				const string __id = "getLanguage.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.iot.aep.sdk']/class[@name='IoTSmartImpl']/method[@name='setLanguage' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setLanguage", "(Ljava/lang/String;)V", "GetSetLanguage_Ljava_lang_String_Handler")]
			set {
				const string __id = "setLanguage.(Ljava/lang/String;)V";
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getCountryList_Lcom_aliyun_iot_aep_sdk_IoTSmart_ICountryListGetCallBack_;
#pragma warning disable 0169
		static Delegate GetGetCountryList_Lcom_aliyun_iot_aep_sdk_IoTSmart_ICountryListGetCallBack_Handler ()
		{
			if (cb_getCountryList_Lcom_aliyun_iot_aep_sdk_IoTSmart_ICountryListGetCallBack_ == null)
				cb_getCountryList_Lcom_aliyun_iot_aep_sdk_IoTSmart_ICountryListGetCallBack_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_GetCountryList_Lcom_aliyun_iot_aep_sdk_IoTSmart_ICountryListGetCallBack_);
			return cb_getCountryList_Lcom_aliyun_iot_aep_sdk_IoTSmart_ICountryListGetCallBack_;
		}

		static void n_GetCountryList_Lcom_aliyun_iot_aep_sdk_IoTSmart_ICountryListGetCallBack_ (IntPtr jnienv, IntPtr native__this, IntPtr native__callback)
		{
			global::Com.Aliyun.Iot.Aep.Sdk.IoTSmartImpl __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Iot.Aep.Sdk.IoTSmartImpl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Aliyun.Iot.Aep.Sdk.IoTSmart.ICountryListGetCallBack @callback = (global::Com.Aliyun.Iot.Aep.Sdk.IoTSmart.ICountryListGetCallBack)global::Java.Lang.Object.GetObject<global::Com.Aliyun.Iot.Aep.Sdk.IoTSmart.ICountryListGetCallBack> (native__callback, JniHandleOwnership.DoNotTransfer);
			__this.GetCountryList (@callback);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.iot.aep.sdk']/class[@name='IoTSmartImpl']/method[@name='getCountryList' and count(parameter)=1 and parameter[1][@type='com.aliyun.iot.aep.sdk.IoTSmart.ICountryListGetCallBack']]"
		[Register ("getCountryList", "(Lcom/aliyun/iot/aep/sdk/IoTSmart$ICountryListGetCallBack;)V", "GetGetCountryList_Lcom_aliyun_iot_aep_sdk_IoTSmart_ICountryListGetCallBack_Handler")]
		public virtual unsafe void GetCountryList (global::Com.Aliyun.Iot.Aep.Sdk.IoTSmart.ICountryListGetCallBack @callback)
		{
			const string __id = "getCountryList.(Lcom/aliyun/iot/aep/sdk/IoTSmart$ICountryListGetCallBack;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((@callback == null) ? IntPtr.Zero : ((global::Java.Lang.Object) @callback).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_setCountry_Lcom_aliyun_iot_aep_sdk_IoTSmart_Country_Lcom_aliyun_iot_aep_sdk_IoTSmart_ICountrySetCallBack_;
#pragma warning disable 0169
		static Delegate GetSetCountry_Lcom_aliyun_iot_aep_sdk_IoTSmart_Country_Lcom_aliyun_iot_aep_sdk_IoTSmart_ICountrySetCallBack_Handler ()
		{
			if (cb_setCountry_Lcom_aliyun_iot_aep_sdk_IoTSmart_Country_Lcom_aliyun_iot_aep_sdk_IoTSmart_ICountrySetCallBack_ == null)
				cb_setCountry_Lcom_aliyun_iot_aep_sdk_IoTSmart_Country_Lcom_aliyun_iot_aep_sdk_IoTSmart_ICountrySetCallBack_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_SetCountry_Lcom_aliyun_iot_aep_sdk_IoTSmart_Country_Lcom_aliyun_iot_aep_sdk_IoTSmart_ICountrySetCallBack_);
			return cb_setCountry_Lcom_aliyun_iot_aep_sdk_IoTSmart_Country_Lcom_aliyun_iot_aep_sdk_IoTSmart_ICountrySetCallBack_;
		}

		static void n_SetCountry_Lcom_aliyun_iot_aep_sdk_IoTSmart_Country_Lcom_aliyun_iot_aep_sdk_IoTSmart_ICountrySetCallBack_ (IntPtr jnienv, IntPtr native__this, IntPtr native_country, IntPtr native_callBack)
		{
			global::Com.Aliyun.Iot.Aep.Sdk.IoTSmartImpl __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Iot.Aep.Sdk.IoTSmartImpl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Aliyun.Iot.Aep.Sdk.IoTSmart.Country country = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Iot.Aep.Sdk.IoTSmart.Country> (native_country, JniHandleOwnership.DoNotTransfer);
			global::Com.Aliyun.Iot.Aep.Sdk.IoTSmart.ICountrySetCallBack callBack = (global::Com.Aliyun.Iot.Aep.Sdk.IoTSmart.ICountrySetCallBack)global::Java.Lang.Object.GetObject<global::Com.Aliyun.Iot.Aep.Sdk.IoTSmart.ICountrySetCallBack> (native_callBack, JniHandleOwnership.DoNotTransfer);
			__this.SetCountry (country, callBack);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.iot.aep.sdk']/class[@name='IoTSmartImpl']/method[@name='setCountry' and count(parameter)=2 and parameter[1][@type='com.aliyun.iot.aep.sdk.IoTSmart.Country'] and parameter[2][@type='com.aliyun.iot.aep.sdk.IoTSmart.ICountrySetCallBack']]"
		[Register ("setCountry", "(Lcom/aliyun/iot/aep/sdk/IoTSmart$Country;Lcom/aliyun/iot/aep/sdk/IoTSmart$ICountrySetCallBack;)V", "GetSetCountry_Lcom_aliyun_iot_aep_sdk_IoTSmart_Country_Lcom_aliyun_iot_aep_sdk_IoTSmart_ICountrySetCallBack_Handler")]
		public virtual unsafe void SetCountry (global::Com.Aliyun.Iot.Aep.Sdk.IoTSmart.Country country, global::Com.Aliyun.Iot.Aep.Sdk.IoTSmart.ICountrySetCallBack callBack)
		{
			const string __id = "setCountry.(Lcom/aliyun/iot/aep/sdk/IoTSmart$Country;Lcom/aliyun/iot/aep/sdk/IoTSmart$ICountrySetCallBack;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((country == null) ? IntPtr.Zero : ((global::Java.Lang.Object) country).Handle);
				__args [1] = new JniArgumentValue ((callBack == null) ? IntPtr.Zero : ((global::Java.Lang.Object) callBack).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_setDebug_Z;
#pragma warning disable 0169
		static Delegate GetSetDebug_ZHandler ()
		{
			if (cb_setDebug_Z == null)
				cb_setDebug_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_SetDebug_Z);
			return cb_setDebug_Z;
		}

		static void n_SetDebug_Z (IntPtr jnienv, IntPtr native__this, bool debug)
		{
			global::Com.Aliyun.Iot.Aep.Sdk.IoTSmartImpl __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Iot.Aep.Sdk.IoTSmartImpl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetDebug (debug);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.iot.aep.sdk']/class[@name='IoTSmartImpl']/method[@name='setDebug' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("setDebug", "(Z)V", "GetSetDebug_ZHandler")]
		public virtual unsafe void SetDebug (bool debug)
		{
			const string __id = "setDebug.(Z)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (debug);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_setDebugLevel_I;
#pragma warning disable 0169
		static Delegate GetSetDebugLevel_IHandler ()
		{
			if (cb_setDebugLevel_I == null)
				cb_setDebugLevel_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetDebugLevel_I);
			return cb_setDebugLevel_I;
		}

		static void n_SetDebugLevel_I (IntPtr jnienv, IntPtr native__this, int level)
		{
			global::Com.Aliyun.Iot.Aep.Sdk.IoTSmartImpl __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Iot.Aep.Sdk.IoTSmartImpl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetDebugLevel (level);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.iot.aep.sdk']/class[@name='IoTSmartImpl']/method[@name='setDebugLevel' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setDebugLevel", "(I)V", "GetSetDebugLevel_IHandler")]
		public virtual unsafe void SetDebugLevel (int level)
		{
			const string __id = "setDebugLevel.(I)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (level);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_showCountryList_Lcom_aliyun_iot_aep_sdk_IoTSmart_ICountrySelectCallBack_;
#pragma warning disable 0169
		static Delegate GetShowCountryList_Lcom_aliyun_iot_aep_sdk_IoTSmart_ICountrySelectCallBack_Handler ()
		{
			if (cb_showCountryList_Lcom_aliyun_iot_aep_sdk_IoTSmart_ICountrySelectCallBack_ == null)
				cb_showCountryList_Lcom_aliyun_iot_aep_sdk_IoTSmart_ICountrySelectCallBack_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_ShowCountryList_Lcom_aliyun_iot_aep_sdk_IoTSmart_ICountrySelectCallBack_);
			return cb_showCountryList_Lcom_aliyun_iot_aep_sdk_IoTSmart_ICountrySelectCallBack_;
		}

		static void n_ShowCountryList_Lcom_aliyun_iot_aep_sdk_IoTSmart_ICountrySelectCallBack_ (IntPtr jnienv, IntPtr native__this, IntPtr native_callBack)
		{
			global::Com.Aliyun.Iot.Aep.Sdk.IoTSmartImpl __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Iot.Aep.Sdk.IoTSmartImpl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Aliyun.Iot.Aep.Sdk.IoTSmart.ICountrySelectCallBack callBack = (global::Com.Aliyun.Iot.Aep.Sdk.IoTSmart.ICountrySelectCallBack)global::Java.Lang.Object.GetObject<global::Com.Aliyun.Iot.Aep.Sdk.IoTSmart.ICountrySelectCallBack> (native_callBack, JniHandleOwnership.DoNotTransfer);
			__this.ShowCountryList (callBack);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.iot.aep.sdk']/class[@name='IoTSmartImpl']/method[@name='showCountryList' and count(parameter)=1 and parameter[1][@type='com.aliyun.iot.aep.sdk.IoTSmart.ICountrySelectCallBack']]"
		[Register ("showCountryList", "(Lcom/aliyun/iot/aep/sdk/IoTSmart$ICountrySelectCallBack;)V", "GetShowCountryList_Lcom_aliyun_iot_aep_sdk_IoTSmart_ICountrySelectCallBack_Handler")]
		public virtual unsafe void ShowCountryList (global::Com.Aliyun.Iot.Aep.Sdk.IoTSmart.ICountrySelectCallBack callBack)
		{
			const string __id = "showCountryList.(Lcom/aliyun/iot/aep/sdk/IoTSmart$ICountrySelectCallBack;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((callBack == null) ? IntPtr.Zero : ((global::Java.Lang.Object) callBack).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

	}
}
