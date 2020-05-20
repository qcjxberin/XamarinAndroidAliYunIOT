using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Aliyun.Alink.Linksdk.Alcs.Api.Client {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.api.client']/class[@name='AlcsClientConfig']"
	[global::Android.Runtime.Register ("com/aliyun/alink/linksdk/alcs/api/client/AlcsClientConfig", DoNotGenerateAcw=true)]
	public partial class AlcsClientConfig : global::Java.Lang.Object {



		// Metadata.xml XPath field reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.api.client']/class[@name='AlcsClientConfig']/field[@name='mAccessKey']"
		[Register ("mAccessKey")]
		protected string MAccessKey {
			get {
				const string __id = "mAccessKey.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "mAccessKey.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.api.client']/class[@name='AlcsClientConfig']/field[@name='mAccessToken']"
		[Register ("mAccessToken")]
		protected string MAccessToken {
			get {
				const string __id = "mAccessToken.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "mAccessToken.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.api.client']/class[@name='AlcsClientConfig']/field[@name='mDataFormat']"
		[Register ("mDataFormat")]
		public string MDataFormat {
			get {
				const string __id = "mDataFormat.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "mDataFormat.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.api.client']/class[@name='AlcsClientConfig']/field[@name='mDeviceName']"
		[Register ("mDeviceName")]
		protected string MDeviceName {
			get {
				const string __id = "mDeviceName.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "mDeviceName.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.api.client']/class[@name='AlcsClientConfig']/field[@name='mDstAddr']"
		[Register ("mDstAddr")]
		protected string MDstAddr {
			get {
				const string __id = "mDstAddr.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "mDstAddr.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.api.client']/class[@name='AlcsClientConfig']/field[@name='mDstPort']"
		[Register ("mDstPort")]
		protected int MDstPort {
			get {
				const string __id = "mDstPort.I";

				var __v = _members.InstanceFields.GetInt32Value (__id, this);
				return __v;
			}
			set {
				const string __id = "mDstPort.I";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.api.client']/class[@name='AlcsClientConfig']/field[@name='mHeartBeatTimeout']"
		[Register ("mHeartBeatTimeout")]
		protected int MHeartBeatTimeout {
			get {
				const string __id = "mHeartBeatTimeout.I";

				var __v = _members.InstanceFields.GetInt32Value (__id, this);
				return __v;
			}
			set {
				const string __id = "mHeartBeatTimeout.I";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.api.client']/class[@name='AlcsClientConfig']/field[@name='mIsNeddAuth']"
		[Register ("mIsNeddAuth")]
		protected bool MIsNeddAuth {
			get {
				const string __id = "mIsNeddAuth.Z";

				var __v = _members.InstanceFields.GetBooleanValue (__id, this);
				return __v;
			}
			set {
				const string __id = "mIsNeddAuth.Z";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.api.client']/class[@name='AlcsClientConfig']/field[@name='mProductKey']"
		[Register ("mProductKey")]
		protected string MProductKey {
			get {
				const string __id = "mProductKey.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "mProductKey.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/aliyun/alink/linksdk/alcs/api/client/AlcsClientConfig", typeof (AlcsClientConfig));
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

		protected AlcsClientConfig (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.api.client']/class[@name='AlcsClientConfig']/constructor[@name='AlcsClientConfig' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe AlcsClientConfig ()
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

		static Delegate cb_getAccessKey;
#pragma warning disable 0169
		static Delegate GetGetAccessKeyHandler ()
		{
			if (cb_getAccessKey == null)
				cb_getAccessKey = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetAccessKey);
			return cb_getAccessKey;
		}

		static IntPtr n_GetAccessKey (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Aliyun.Alink.Linksdk.Alcs.Api.Client.AlcsClientConfig __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Api.Client.AlcsClientConfig> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.AccessKey);
		}
#pragma warning restore 0169

		static Delegate cb_setAccessKey_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetAccessKey_Ljava_lang_String_Handler ()
		{
			if (cb_setAccessKey_Ljava_lang_String_ == null)
				cb_setAccessKey_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetAccessKey_Ljava_lang_String_);
			return cb_setAccessKey_Ljava_lang_String_;
		}

		static void n_SetAccessKey_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_mAccessKey)
		{
			global::Com.Aliyun.Alink.Linksdk.Alcs.Api.Client.AlcsClientConfig __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Api.Client.AlcsClientConfig> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string mAccessKey = JNIEnv.GetString (native_mAccessKey, JniHandleOwnership.DoNotTransfer);
			__this.AccessKey = mAccessKey;
		}
#pragma warning restore 0169

		public virtual unsafe string AccessKey {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.api.client']/class[@name='AlcsClientConfig']/method[@name='getAccessKey' and count(parameter)=0]"
			[Register ("getAccessKey", "()Ljava/lang/String;", "GetGetAccessKeyHandler")]
			get {
				const string __id = "getAccessKey.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.api.client']/class[@name='AlcsClientConfig']/method[@name='setAccessKey' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setAccessKey", "(Ljava/lang/String;)V", "GetSetAccessKey_Ljava_lang_String_Handler")]
			set {
				const string __id = "setAccessKey.(Ljava/lang/String;)V";
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

		static Delegate cb_getAccessToken;
#pragma warning disable 0169
		static Delegate GetGetAccessTokenHandler ()
		{
			if (cb_getAccessToken == null)
				cb_getAccessToken = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetAccessToken);
			return cb_getAccessToken;
		}

		static IntPtr n_GetAccessToken (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Aliyun.Alink.Linksdk.Alcs.Api.Client.AlcsClientConfig __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Api.Client.AlcsClientConfig> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.AccessToken);
		}
#pragma warning restore 0169

		static Delegate cb_setAccessToken_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetAccessToken_Ljava_lang_String_Handler ()
		{
			if (cb_setAccessToken_Ljava_lang_String_ == null)
				cb_setAccessToken_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetAccessToken_Ljava_lang_String_);
			return cb_setAccessToken_Ljava_lang_String_;
		}

		static void n_SetAccessToken_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_mAccessToken)
		{
			global::Com.Aliyun.Alink.Linksdk.Alcs.Api.Client.AlcsClientConfig __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Api.Client.AlcsClientConfig> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string mAccessToken = JNIEnv.GetString (native_mAccessToken, JniHandleOwnership.DoNotTransfer);
			__this.AccessToken = mAccessToken;
		}
#pragma warning restore 0169

		public virtual unsafe string AccessToken {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.api.client']/class[@name='AlcsClientConfig']/method[@name='getAccessToken' and count(parameter)=0]"
			[Register ("getAccessToken", "()Ljava/lang/String;", "GetGetAccessTokenHandler")]
			get {
				const string __id = "getAccessToken.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.api.client']/class[@name='AlcsClientConfig']/method[@name='setAccessToken' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setAccessToken", "(Ljava/lang/String;)V", "GetSetAccessToken_Ljava_lang_String_Handler")]
			set {
				const string __id = "setAccessToken.(Ljava/lang/String;)V";
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

		static Delegate cb_getDeviceName;
#pragma warning disable 0169
		static Delegate GetGetDeviceNameHandler ()
		{
			if (cb_getDeviceName == null)
				cb_getDeviceName = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetDeviceName);
			return cb_getDeviceName;
		}

		static IntPtr n_GetDeviceName (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Aliyun.Alink.Linksdk.Alcs.Api.Client.AlcsClientConfig __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Api.Client.AlcsClientConfig> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.DeviceName);
		}
#pragma warning restore 0169

		static Delegate cb_setDeviceName_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetDeviceName_Ljava_lang_String_Handler ()
		{
			if (cb_setDeviceName_Ljava_lang_String_ == null)
				cb_setDeviceName_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetDeviceName_Ljava_lang_String_);
			return cb_setDeviceName_Ljava_lang_String_;
		}

		static void n_SetDeviceName_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_mDeviceName)
		{
			global::Com.Aliyun.Alink.Linksdk.Alcs.Api.Client.AlcsClientConfig __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Api.Client.AlcsClientConfig> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string mDeviceName = JNIEnv.GetString (native_mDeviceName, JniHandleOwnership.DoNotTransfer);
			__this.DeviceName = mDeviceName;
		}
#pragma warning restore 0169

		public virtual unsafe string DeviceName {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.api.client']/class[@name='AlcsClientConfig']/method[@name='getDeviceName' and count(parameter)=0]"
			[Register ("getDeviceName", "()Ljava/lang/String;", "GetGetDeviceNameHandler")]
			get {
				const string __id = "getDeviceName.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.api.client']/class[@name='AlcsClientConfig']/method[@name='setDeviceName' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setDeviceName", "(Ljava/lang/String;)V", "GetSetDeviceName_Ljava_lang_String_Handler")]
			set {
				const string __id = "setDeviceName.(Ljava/lang/String;)V";
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

		static Delegate cb_getDstAddr;
#pragma warning disable 0169
		static Delegate GetGetDstAddrHandler ()
		{
			if (cb_getDstAddr == null)
				cb_getDstAddr = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetDstAddr);
			return cb_getDstAddr;
		}

		static IntPtr n_GetDstAddr (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Aliyun.Alink.Linksdk.Alcs.Api.Client.AlcsClientConfig __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Api.Client.AlcsClientConfig> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.DstAddr);
		}
#pragma warning restore 0169

		static Delegate cb_setDstAddr_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetDstAddr_Ljava_lang_String_Handler ()
		{
			if (cb_setDstAddr_Ljava_lang_String_ == null)
				cb_setDstAddr_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetDstAddr_Ljava_lang_String_);
			return cb_setDstAddr_Ljava_lang_String_;
		}

		static void n_SetDstAddr_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_mDstAddr)
		{
			global::Com.Aliyun.Alink.Linksdk.Alcs.Api.Client.AlcsClientConfig __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Api.Client.AlcsClientConfig> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string mDstAddr = JNIEnv.GetString (native_mDstAddr, JniHandleOwnership.DoNotTransfer);
			__this.DstAddr = mDstAddr;
		}
#pragma warning restore 0169

		public virtual unsafe string DstAddr {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.api.client']/class[@name='AlcsClientConfig']/method[@name='getDstAddr' and count(parameter)=0]"
			[Register ("getDstAddr", "()Ljava/lang/String;", "GetGetDstAddrHandler")]
			get {
				const string __id = "getDstAddr.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.api.client']/class[@name='AlcsClientConfig']/method[@name='setDstAddr' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setDstAddr", "(Ljava/lang/String;)V", "GetSetDstAddr_Ljava_lang_String_Handler")]
			set {
				const string __id = "setDstAddr.(Ljava/lang/String;)V";
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

		static Delegate cb_getDstPort;
#pragma warning disable 0169
		static Delegate GetGetDstPortHandler ()
		{
			if (cb_getDstPort == null)
				cb_getDstPort = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetDstPort);
			return cb_getDstPort;
		}

		static int n_GetDstPort (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Aliyun.Alink.Linksdk.Alcs.Api.Client.AlcsClientConfig __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Api.Client.AlcsClientConfig> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.DstPort;
		}
#pragma warning restore 0169

		static Delegate cb_setDstPort_I;
#pragma warning disable 0169
		static Delegate GetSetDstPort_IHandler ()
		{
			if (cb_setDstPort_I == null)
				cb_setDstPort_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetDstPort_I);
			return cb_setDstPort_I;
		}

		static void n_SetDstPort_I (IntPtr jnienv, IntPtr native__this, int mDstPort)
		{
			global::Com.Aliyun.Alink.Linksdk.Alcs.Api.Client.AlcsClientConfig __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Api.Client.AlcsClientConfig> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.DstPort = mDstPort;
		}
#pragma warning restore 0169

		public virtual unsafe int DstPort {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.api.client']/class[@name='AlcsClientConfig']/method[@name='getDstPort' and count(parameter)=0]"
			[Register ("getDstPort", "()I", "GetGetDstPortHandler")]
			get {
				const string __id = "getDstPort.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.api.client']/class[@name='AlcsClientConfig']/method[@name='setDstPort' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setDstPort", "(I)V", "GetSetDstPort_IHandler")]
			set {
				const string __id = "setDstPort.(I)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_isNeddAuth;
#pragma warning disable 0169
		static Delegate GetIsNeddAuthHandler ()
		{
			if (cb_isNeddAuth == null)
				cb_isNeddAuth = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsNeddAuth);
			return cb_isNeddAuth;
		}

		static bool n_IsNeddAuth (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Aliyun.Alink.Linksdk.Alcs.Api.Client.AlcsClientConfig __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Api.Client.AlcsClientConfig> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsNeddAuth;
		}
#pragma warning restore 0169

		static Delegate cb_setIsNeddAuth_Z;
#pragma warning disable 0169
		static Delegate GetSetIsNeddAuth_ZHandler ()
		{
			if (cb_setIsNeddAuth_Z == null)
				cb_setIsNeddAuth_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_SetIsNeddAuth_Z);
			return cb_setIsNeddAuth_Z;
		}

		static void n_SetIsNeddAuth_Z (IntPtr jnienv, IntPtr native__this, bool mIsNeddAuth)
		{
			global::Com.Aliyun.Alink.Linksdk.Alcs.Api.Client.AlcsClientConfig __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Api.Client.AlcsClientConfig> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.IsNeddAuth = mIsNeddAuth;
		}
#pragma warning restore 0169

		public virtual unsafe bool IsNeddAuth {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.api.client']/class[@name='AlcsClientConfig']/method[@name='isNeddAuth' and count(parameter)=0]"
			[Register ("isNeddAuth", "()Z", "GetIsNeddAuthHandler")]
			get {
				const string __id = "isNeddAuth.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.api.client']/class[@name='AlcsClientConfig']/method[@name='setIsNeddAuth' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setIsNeddAuth", "(Z)V", "GetSetIsNeddAuth_ZHandler")]
			set {
				const string __id = "setIsNeddAuth.(Z)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getProductKey;
#pragma warning disable 0169
		static Delegate GetGetProductKeyHandler ()
		{
			if (cb_getProductKey == null)
				cb_getProductKey = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetProductKey);
			return cb_getProductKey;
		}

		static IntPtr n_GetProductKey (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Aliyun.Alink.Linksdk.Alcs.Api.Client.AlcsClientConfig __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Api.Client.AlcsClientConfig> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.ProductKey);
		}
#pragma warning restore 0169

		static Delegate cb_setProductKey_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetProductKey_Ljava_lang_String_Handler ()
		{
			if (cb_setProductKey_Ljava_lang_String_ == null)
				cb_setProductKey_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetProductKey_Ljava_lang_String_);
			return cb_setProductKey_Ljava_lang_String_;
		}

		static void n_SetProductKey_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_mProductKey)
		{
			global::Com.Aliyun.Alink.Linksdk.Alcs.Api.Client.AlcsClientConfig __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Api.Client.AlcsClientConfig> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string mProductKey = JNIEnv.GetString (native_mProductKey, JniHandleOwnership.DoNotTransfer);
			__this.ProductKey = mProductKey;
		}
#pragma warning restore 0169

		public virtual unsafe string ProductKey {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.api.client']/class[@name='AlcsClientConfig']/method[@name='getProductKey' and count(parameter)=0]"
			[Register ("getProductKey", "()Ljava/lang/String;", "GetGetProductKeyHandler")]
			get {
				const string __id = "getProductKey.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.api.client']/class[@name='AlcsClientConfig']/method[@name='setProductKey' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setProductKey", "(Ljava/lang/String;)V", "GetSetProductKey_Ljava_lang_String_Handler")]
			set {
				const string __id = "setProductKey.(Ljava/lang/String;)V";
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

	}
}
