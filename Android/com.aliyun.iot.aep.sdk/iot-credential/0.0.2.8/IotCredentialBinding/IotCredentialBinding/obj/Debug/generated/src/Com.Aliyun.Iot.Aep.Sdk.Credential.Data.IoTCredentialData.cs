using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Aliyun.Iot.Aep.Sdk.Credential.Data {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.aliyun.iot.aep.sdk.credential.data']/class[@name='IoTCredentialData']"
	[global::Android.Runtime.Register ("com/aliyun/iot/aep/sdk/credential/data/IoTCredentialData", DoNotGenerateAcw=true)]
	public partial class IoTCredentialData : global::Java.Lang.Object {



		// Metadata.xml XPath field reference: path="/api/package[@name='com.aliyun.iot.aep.sdk.credential.data']/class[@name='IoTCredentialData']/field[@name='identity']"
		[Register ("identity")]
		public string Identity {
			get {
				const string __id = "identity.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "identity.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.aliyun.iot.aep.sdk.credential.data']/class[@name='IoTCredentialData']/field[@name='iotToken']"
		[Register ("iotToken")]
		public string IotToken {
			get {
				const string __id = "iotToken.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "iotToken.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.aliyun.iot.aep.sdk.credential.data']/class[@name='IoTCredentialData']/field[@name='iotTokenCreateTime']"
		[Register ("iotTokenCreateTime")]
		public long IotTokenCreateTime {
			get {
				const string __id = "iotTokenCreateTime.J";

				var __v = _members.InstanceFields.GetInt64Value (__id, this);
				return __v;
			}
			set {
				const string __id = "iotTokenCreateTime.J";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.aliyun.iot.aep.sdk.credential.data']/class[@name='IoTCredentialData']/field[@name='iotTokenExpireTime']"
		[Register ("iotTokenExpireTime")]
		public long IotTokenExpireTime {
			get {
				const string __id = "iotTokenExpireTime.J";

				var __v = _members.InstanceFields.GetInt64Value (__id, this);
				return __v;
			}
			set {
				const string __id = "iotTokenExpireTime.J";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.aliyun.iot.aep.sdk.credential.data']/class[@name='IoTCredentialData']/field[@name='refreshToken']"
		[Register ("refreshToken")]
		public string RefreshToken {
			get {
				const string __id = "refreshToken.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "refreshToken.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.aliyun.iot.aep.sdk.credential.data']/class[@name='IoTCredentialData']/field[@name='refreshTokenCreateTime']"
		[Register ("refreshTokenCreateTime")]
		public long RefreshTokenCreateTime {
			get {
				const string __id = "refreshTokenCreateTime.J";

				var __v = _members.InstanceFields.GetInt64Value (__id, this);
				return __v;
			}
			set {
				const string __id = "refreshTokenCreateTime.J";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.aliyun.iot.aep.sdk.credential.data']/class[@name='IoTCredentialData']/field[@name='refreshTokenExpireTime']"
		[Register ("refreshTokenExpireTime")]
		public long RefreshTokenExpireTime {
			get {
				const string __id = "refreshTokenExpireTime.J";

				var __v = _members.InstanceFields.GetInt64Value (__id, this);
				return __v;
			}
			set {
				const string __id = "refreshTokenExpireTime.J";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/aliyun/iot/aep/sdk/credential/data/IoTCredentialData", typeof (IoTCredentialData));
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

		protected IoTCredentialData (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.aliyun.iot.aep.sdk.credential.data']/class[@name='IoTCredentialData']/constructor[@name='IoTCredentialData' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe IoTCredentialData ()
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

		static Delegate cb_isIotTokenExpire;
#pragma warning disable 0169
		static Delegate GetIsIotTokenExpireHandler ()
		{
			if (cb_isIotTokenExpire == null)
				cb_isIotTokenExpire = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsIotTokenExpire);
			return cb_isIotTokenExpire;
		}

		static bool n_IsIotTokenExpire (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Aliyun.Iot.Aep.Sdk.Credential.Data.IoTCredentialData __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Iot.Aep.Sdk.Credential.Data.IoTCredentialData> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsIotTokenExpire;
		}
#pragma warning restore 0169

		public virtual unsafe bool IsIotTokenExpire {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.iot.aep.sdk.credential.data']/class[@name='IoTCredentialData']/method[@name='isIotTokenExpire' and count(parameter)=0]"
			[Register ("isIotTokenExpire", "()Z", "GetIsIotTokenExpireHandler")]
			get {
				const string __id = "isIotTokenExpire.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_isRefreshTokenExpire;
#pragma warning disable 0169
		static Delegate GetIsRefreshTokenExpireHandler ()
		{
			if (cb_isRefreshTokenExpire == null)
				cb_isRefreshTokenExpire = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsRefreshTokenExpire);
			return cb_isRefreshTokenExpire;
		}

		static bool n_IsRefreshTokenExpire (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Aliyun.Iot.Aep.Sdk.Credential.Data.IoTCredentialData __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Iot.Aep.Sdk.Credential.Data.IoTCredentialData> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsRefreshTokenExpire;
		}
#pragma warning restore 0169

		public virtual unsafe bool IsRefreshTokenExpire {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.iot.aep.sdk.credential.data']/class[@name='IoTCredentialData']/method[@name='isRefreshTokenExpire' and count(parameter)=0]"
			[Register ("isRefreshTokenExpire", "()Z", "GetIsRefreshTokenExpireHandler")]
			get {
				const string __id = "isRefreshTokenExpire.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_clear;
#pragma warning disable 0169
		static Delegate GetClearHandler ()
		{
			if (cb_clear == null)
				cb_clear = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Clear);
			return cb_clear;
		}

		static void n_Clear (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Aliyun.Iot.Aep.Sdk.Credential.Data.IoTCredentialData __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Iot.Aep.Sdk.Credential.Data.IoTCredentialData> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Clear ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.iot.aep.sdk.credential.data']/class[@name='IoTCredentialData']/method[@name='clear' and count(parameter)=0]"
		[Register ("clear", "()V", "GetClearHandler")]
		public virtual unsafe void Clear ()
		{
			const string __id = "clear.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_update_Lorg_json_JSONObject_;
#pragma warning disable 0169
		static Delegate GetUpdate_Lorg_json_JSONObject_Handler ()
		{
			if (cb_update_Lorg_json_JSONObject_ == null)
				cb_update_Lorg_json_JSONObject_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_Update_Lorg_json_JSONObject_);
			return cb_update_Lorg_json_JSONObject_;
		}

		static void n_Update_Lorg_json_JSONObject_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Aliyun.Iot.Aep.Sdk.Credential.Data.IoTCredentialData __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Iot.Aep.Sdk.Credential.Data.IoTCredentialData> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Org.Json.JSONObject p0 = global::Java.Lang.Object.GetObject<global::Org.Json.JSONObject> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Update (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.iot.aep.sdk.credential.data']/class[@name='IoTCredentialData']/method[@name='update' and count(parameter)=1 and parameter[1][@type='org.json.JSONObject']]"
		[Register ("update", "(Lorg/json/JSONObject;)V", "GetUpdate_Lorg_json_JSONObject_Handler")]
		public virtual unsafe void Update (global::Org.Json.JSONObject p0)
		{
			const string __id = "update.(Lorg/json/JSONObject;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

	}
}
