using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Aliyun.Iot.Aep.Sdk.Framework.Region {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.aliyun.iot.aep.sdk.framework.region']/class[@name='RegionQueryApi']"
	[global::Android.Runtime.Register ("com/aliyun/iot/aep/sdk/framework/region/RegionQueryApi", DoNotGenerateAcw=true)]
	public partial class RegionQueryApi : global::Com.Aliyun.Iot.Aep.Sdk.Framework.Base.BaseServerApi {


		// Metadata.xml XPath field reference: path="/api/package[@name='com.aliyun.iot.aep.sdk.framework.region']/class[@name='RegionQueryApi']/field[@name='authType']"
		[Register ("authType")]
		public const string AuthType = (string) "iotNoAuth";


		// Metadata.xml XPath field reference: path="/api/package[@name='com.aliyun.iot.aep.sdk.framework.region']/class[@name='RegionQueryApi']/field[@name='host']"
		[Register ("host")]
		public static string Host {
			get {
				const string __id = "host.Ljava/lang/String;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Metadata.xml XPath field reference: path="/api/package[@name='com.aliyun.iot.aep.sdk.framework.region']/class[@name='RegionQueryApi']/field[@name='path']"
		[Register ("path")]
		public const string Path = (string) "/living/account/region/get";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.aliyun.iot.aep.sdk.framework.region']/class[@name='RegionQueryApi']/field[@name='version']"
		[Register ("version")]
		public const string Version = (string) "1.0.1";
		// Metadata.xml XPath class reference: path="/api/package[@name='com.aliyun.iot.aep.sdk.framework.region']/class[@name='RegionQueryApi.Request']"
		[global::Android.Runtime.Register ("com/aliyun/iot/aep/sdk/framework/region/RegionQueryApi$Request", DoNotGenerateAcw=true)]
		public partial class Request : global::Com.Aliyun.Iot.Aep.Sdk.Framework.Network.BaseRequest {



			// Metadata.xml XPath field reference: path="/api/package[@name='com.aliyun.iot.aep.sdk.framework.region']/class[@name='RegionQueryApi.Request']/field[@name='phoneLocationCode']"
			[Register ("phoneLocationCode")]
			public string PhoneLocationCode {
				get {
					const string __id = "phoneLocationCode.Ljava/lang/String;";

					var __v = _members.InstanceFields.GetObjectValue (__id, this);
					return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
				set {
					const string __id = "phoneLocationCode.Ljava/lang/String;";

					IntPtr native_value = JNIEnv.NewString (value);
					try {
						_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
					} finally {
						JNIEnv.DeleteLocalRef (native_value);
					}
				}
			}
			static readonly JniPeerMembers _members = new XAPeerMembers ("com/aliyun/iot/aep/sdk/framework/region/RegionQueryApi$Request", typeof (Request));
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

			protected Request (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static Delegate cb_getAuthCode;
#pragma warning disable 0169
			static Delegate GetGetAuthCodeHandler ()
			{
				if (cb_getAuthCode == null)
					cb_getAuthCode = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetAuthCode);
				return cb_getAuthCode;
			}

			static IntPtr n_GetAuthCode (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Aliyun.Iot.Aep.Sdk.Framework.Region.RegionQueryApi.Request __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Iot.Aep.Sdk.Framework.Region.RegionQueryApi.Request> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.NewString (__this.AuthCode);
			}
#pragma warning restore 0169

			static Delegate cb_setAuthCode_Ljava_lang_String_;
#pragma warning disable 0169
			static Delegate GetSetAuthCode_Ljava_lang_String_Handler ()
			{
				if (cb_setAuthCode_Ljava_lang_String_ == null)
					cb_setAuthCode_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetAuthCode_Ljava_lang_String_);
				return cb_setAuthCode_Ljava_lang_String_;
			}

			static void n_SetAuthCode_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_authCode)
			{
				global::Com.Aliyun.Iot.Aep.Sdk.Framework.Region.RegionQueryApi.Request __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Iot.Aep.Sdk.Framework.Region.RegionQueryApi.Request> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				string authCode = JNIEnv.GetString (native_authCode, JniHandleOwnership.DoNotTransfer);
				__this.AuthCode = authCode;
			}
#pragma warning restore 0169

			public virtual unsafe string AuthCode {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.iot.aep.sdk.framework.region']/class[@name='RegionQueryApi.Request']/method[@name='getAuthCode' and count(parameter)=0]"
				[Register ("getAuthCode", "()Ljava/lang/String;", "GetGetAuthCodeHandler")]
				get {
					const string __id = "getAuthCode.()Ljava/lang/String;";
					try {
						var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
						return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
					} finally {
					}
				}
				// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.iot.aep.sdk.framework.region']/class[@name='RegionQueryApi.Request']/method[@name='setAuthCode' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
				[Register ("setAuthCode", "(Ljava/lang/String;)V", "GetSetAuthCode_Ljava_lang_String_Handler")]
				set {
					const string __id = "setAuthCode.(Ljava/lang/String;)V";
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

			static Delegate cb_getCountryCode;
#pragma warning disable 0169
			static Delegate GetGetCountryCodeHandler ()
			{
				if (cb_getCountryCode == null)
					cb_getCountryCode = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetCountryCode);
				return cb_getCountryCode;
			}

			static IntPtr n_GetCountryCode (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Aliyun.Iot.Aep.Sdk.Framework.Region.RegionQueryApi.Request __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Iot.Aep.Sdk.Framework.Region.RegionQueryApi.Request> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.NewString (__this.CountryCode);
			}
#pragma warning restore 0169

			static Delegate cb_setCountryCode_Ljava_lang_String_;
#pragma warning disable 0169
			static Delegate GetSetCountryCode_Ljava_lang_String_Handler ()
			{
				if (cb_setCountryCode_Ljava_lang_String_ == null)
					cb_setCountryCode_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetCountryCode_Ljava_lang_String_);
				return cb_setCountryCode_Ljava_lang_String_;
			}

			static void n_SetCountryCode_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_countryCode)
			{
				global::Com.Aliyun.Iot.Aep.Sdk.Framework.Region.RegionQueryApi.Request __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Iot.Aep.Sdk.Framework.Region.RegionQueryApi.Request> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				string countryCode = JNIEnv.GetString (native_countryCode, JniHandleOwnership.DoNotTransfer);
				__this.CountryCode = countryCode;
			}
#pragma warning restore 0169

			public virtual unsafe string CountryCode {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.iot.aep.sdk.framework.region']/class[@name='RegionQueryApi.Request']/method[@name='getCountryCode' and count(parameter)=0]"
				[Register ("getCountryCode", "()Ljava/lang/String;", "GetGetCountryCodeHandler")]
				get {
					const string __id = "getCountryCode.()Ljava/lang/String;";
					try {
						var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
						return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
					} finally {
					}
				}
				// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.iot.aep.sdk.framework.region']/class[@name='RegionQueryApi.Request']/method[@name='setCountryCode' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
				[Register ("setCountryCode", "(Ljava/lang/String;)V", "GetSetCountryCode_Ljava_lang_String_Handler")]
				set {
					const string __id = "setCountryCode.(Ljava/lang/String;)V";
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

			static Delegate cb_getEmail;
#pragma warning disable 0169
			static Delegate GetGetEmailHandler ()
			{
				if (cb_getEmail == null)
					cb_getEmail = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetEmail);
				return cb_getEmail;
			}

			static IntPtr n_GetEmail (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Aliyun.Iot.Aep.Sdk.Framework.Region.RegionQueryApi.Request __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Iot.Aep.Sdk.Framework.Region.RegionQueryApi.Request> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.NewString (__this.Email);
			}
#pragma warning restore 0169

			static Delegate cb_setEmail_Ljava_lang_String_;
#pragma warning disable 0169
			static Delegate GetSetEmail_Ljava_lang_String_Handler ()
			{
				if (cb_setEmail_Ljava_lang_String_ == null)
					cb_setEmail_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetEmail_Ljava_lang_String_);
				return cb_setEmail_Ljava_lang_String_;
			}

			static void n_SetEmail_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_email)
			{
				global::Com.Aliyun.Iot.Aep.Sdk.Framework.Region.RegionQueryApi.Request __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Iot.Aep.Sdk.Framework.Region.RegionQueryApi.Request> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				string email = JNIEnv.GetString (native_email, JniHandleOwnership.DoNotTransfer);
				__this.Email = email;
			}
#pragma warning restore 0169

			public virtual unsafe string Email {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.iot.aep.sdk.framework.region']/class[@name='RegionQueryApi.Request']/method[@name='getEmail' and count(parameter)=0]"
				[Register ("getEmail", "()Ljava/lang/String;", "GetGetEmailHandler")]
				get {
					const string __id = "getEmail.()Ljava/lang/String;";
					try {
						var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
						return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
					} finally {
					}
				}
				// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.iot.aep.sdk.framework.region']/class[@name='RegionQueryApi.Request']/method[@name='setEmail' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
				[Register ("setEmail", "(Ljava/lang/String;)V", "GetSetEmail_Ljava_lang_String_Handler")]
				set {
					const string __id = "setEmail.(Ljava/lang/String;)V";
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

			static Delegate cb_getPhone;
#pragma warning disable 0169
			static Delegate GetGetPhoneHandler ()
			{
				if (cb_getPhone == null)
					cb_getPhone = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetPhone);
				return cb_getPhone;
			}

			static IntPtr n_GetPhone (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Aliyun.Iot.Aep.Sdk.Framework.Region.RegionQueryApi.Request __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Iot.Aep.Sdk.Framework.Region.RegionQueryApi.Request> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.NewString (__this.Phone);
			}
#pragma warning restore 0169

			static Delegate cb_setPhone_Ljava_lang_String_;
#pragma warning disable 0169
			static Delegate GetSetPhone_Ljava_lang_String_Handler ()
			{
				if (cb_setPhone_Ljava_lang_String_ == null)
					cb_setPhone_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetPhone_Ljava_lang_String_);
				return cb_setPhone_Ljava_lang_String_;
			}

			static void n_SetPhone_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_phone)
			{
				global::Com.Aliyun.Iot.Aep.Sdk.Framework.Region.RegionQueryApi.Request __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Iot.Aep.Sdk.Framework.Region.RegionQueryApi.Request> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				string phone = JNIEnv.GetString (native_phone, JniHandleOwnership.DoNotTransfer);
				__this.Phone = phone;
			}
#pragma warning restore 0169

			public virtual unsafe string Phone {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.iot.aep.sdk.framework.region']/class[@name='RegionQueryApi.Request']/method[@name='getPhone' and count(parameter)=0]"
				[Register ("getPhone", "()Ljava/lang/String;", "GetGetPhoneHandler")]
				get {
					const string __id = "getPhone.()Ljava/lang/String;";
					try {
						var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
						return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
					} finally {
					}
				}
				// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.iot.aep.sdk.framework.region']/class[@name='RegionQueryApi.Request']/method[@name='setPhone' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
				[Register ("setPhone", "(Ljava/lang/String;)V", "GetSetPhone_Ljava_lang_String_Handler")]
				set {
					const string __id = "setPhone.(Ljava/lang/String;)V";
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

			public static unsafe global::Com.Aliyun.Iot.Aep.Sdk.Framework.Region.RegionQueryApi.Request RegRequest {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.iot.aep.sdk.framework.region']/class[@name='RegionQueryApi.Request']/method[@name='getRegRequest' and count(parameter)=0]"
				[Register ("getRegRequest", "()Lcom/aliyun/iot/aep/sdk/framework/region/RegionQueryApi$Request;", "")]
				get {
					const string __id = "getRegRequest.()Lcom/aliyun/iot/aep/sdk/framework/region/RegionQueryApi$Request;";
					try {
						var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
						return global::Java.Lang.Object.GetObject<global::Com.Aliyun.Iot.Aep.Sdk.Framework.Region.RegionQueryApi.Request> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
					} finally {
					}
				}
			}

			static Delegate cb_getRegionEnglishName;
#pragma warning disable 0169
			static Delegate GetGetRegionEnglishNameHandler ()
			{
				if (cb_getRegionEnglishName == null)
					cb_getRegionEnglishName = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetRegionEnglishName);
				return cb_getRegionEnglishName;
			}

			static IntPtr n_GetRegionEnglishName (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Aliyun.Iot.Aep.Sdk.Framework.Region.RegionQueryApi.Request __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Iot.Aep.Sdk.Framework.Region.RegionQueryApi.Request> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.NewString (__this.RegionEnglishName);
			}
#pragma warning restore 0169

			static Delegate cb_setRegionEnglishName_Ljava_lang_String_;
#pragma warning disable 0169
			static Delegate GetSetRegionEnglishName_Ljava_lang_String_Handler ()
			{
				if (cb_setRegionEnglishName_Ljava_lang_String_ == null)
					cb_setRegionEnglishName_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetRegionEnglishName_Ljava_lang_String_);
				return cb_setRegionEnglishName_Ljava_lang_String_;
			}

			static void n_SetRegionEnglishName_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_type)
			{
				global::Com.Aliyun.Iot.Aep.Sdk.Framework.Region.RegionQueryApi.Request __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Iot.Aep.Sdk.Framework.Region.RegionQueryApi.Request> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				string type = JNIEnv.GetString (native_type, JniHandleOwnership.DoNotTransfer);
				__this.RegionEnglishName = type;
			}
#pragma warning restore 0169

			public virtual unsafe string RegionEnglishName {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.iot.aep.sdk.framework.region']/class[@name='RegionQueryApi.Request']/method[@name='getRegionEnglishName' and count(parameter)=0]"
				[Register ("getRegionEnglishName", "()Ljava/lang/String;", "GetGetRegionEnglishNameHandler")]
				get {
					const string __id = "getRegionEnglishName.()Ljava/lang/String;";
					try {
						var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
						return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
					} finally {
					}
				}
				// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.iot.aep.sdk.framework.region']/class[@name='RegionQueryApi.Request']/method[@name='setRegionEnglishName' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
				[Register ("setRegionEnglishName", "(Ljava/lang/String;)V", "GetSetRegionEnglishName_Ljava_lang_String_Handler")]
				set {
					const string __id = "setRegionEnglishName.(Ljava/lang/String;)V";
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

			static Delegate cb_getType;
#pragma warning disable 0169
			static Delegate GetGetTypeHandler ()
			{
				if (cb_getType == null)
					cb_getType = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetType);
				return cb_getType;
			}

			static IntPtr n_GetType (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Aliyun.Iot.Aep.Sdk.Framework.Region.RegionQueryApi.Request __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Iot.Aep.Sdk.Framework.Region.RegionQueryApi.Request> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.NewString (__this.Type);
			}
#pragma warning restore 0169

			static Delegate cb_setType_Ljava_lang_String_;
#pragma warning disable 0169
			static Delegate GetSetType_Ljava_lang_String_Handler ()
			{
				if (cb_setType_Ljava_lang_String_ == null)
					cb_setType_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetType_Ljava_lang_String_);
				return cb_setType_Ljava_lang_String_;
			}

			static void n_SetType_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_type)
			{
				global::Com.Aliyun.Iot.Aep.Sdk.Framework.Region.RegionQueryApi.Request __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Iot.Aep.Sdk.Framework.Region.RegionQueryApi.Request> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				string type = JNIEnv.GetString (native_type, JniHandleOwnership.DoNotTransfer);
				__this.Type = type;
			}
#pragma warning restore 0169

			public virtual unsafe string Type {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.iot.aep.sdk.framework.region']/class[@name='RegionQueryApi.Request']/method[@name='getType' and count(parameter)=0]"
				[Register ("getType", "()Ljava/lang/String;", "GetGetTypeHandler")]
				get {
					const string __id = "getType.()Ljava/lang/String;";
					try {
						var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
						return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
					} finally {
					}
				}
				// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.iot.aep.sdk.framework.region']/class[@name='RegionQueryApi.Request']/method[@name='setType' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
				[Register ("setType", "(Ljava/lang/String;)V", "GetSetType_Ljava_lang_String_Handler")]
				set {
					const string __id = "setType.(Ljava/lang/String;)V";
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

			// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.iot.aep.sdk.framework.region']/class[@name='RegionQueryApi.Request']/method[@name='getLoginRequest' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String']]"
			[Register ("getLoginRequest", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Lcom/aliyun/iot/aep/sdk/framework/region/RegionQueryApi$Request;", "")]
			public static unsafe global::Com.Aliyun.Iot.Aep.Sdk.Framework.Region.RegionQueryApi.Request GetLoginRequest (string type, string id, string phoneLocationCode)
			{
				const string __id = "getLoginRequest.(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Lcom/aliyun/iot/aep/sdk/framework/region/RegionQueryApi$Request;";
				IntPtr native_type = JNIEnv.NewString (type);
				IntPtr native_id = JNIEnv.NewString (id);
				IntPtr native_phoneLocationCode = JNIEnv.NewString (phoneLocationCode);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [3];
					__args [0] = new JniArgumentValue (native_type);
					__args [1] = new JniArgumentValue (native_id);
					__args [2] = new JniArgumentValue (native_phoneLocationCode);
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Aliyun.Iot.Aep.Sdk.Framework.Region.RegionQueryApi.Request> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					JNIEnv.DeleteLocalRef (native_type);
					JNIEnv.DeleteLocalRef (native_id);
					JNIEnv.DeleteLocalRef (native_phoneLocationCode);
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.iot.aep.sdk.framework.region']/class[@name='RegionQueryApi.Request']/method[@name='getThirdLoginRequest' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
			[Register ("getThirdLoginRequest", "(Ljava/lang/String;Ljava/lang/String;)Lcom/aliyun/iot/aep/sdk/framework/region/RegionQueryApi$Request;", "")]
			public static unsafe global::Com.Aliyun.Iot.Aep.Sdk.Framework.Region.RegionQueryApi.Request GetThirdLoginRequest (string type, string authCode)
			{
				const string __id = "getThirdLoginRequest.(Ljava/lang/String;Ljava/lang/String;)Lcom/aliyun/iot/aep/sdk/framework/region/RegionQueryApi$Request;";
				IntPtr native_type = JNIEnv.NewString (type);
				IntPtr native_authCode = JNIEnv.NewString (authCode);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [2];
					__args [0] = new JniArgumentValue (native_type);
					__args [1] = new JniArgumentValue (native_authCode);
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Aliyun.Iot.Aep.Sdk.Framework.Region.RegionQueryApi.Request> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					JNIEnv.DeleteLocalRef (native_type);
					JNIEnv.DeleteLocalRef (native_authCode);
				}
			}

		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/aliyun/iot/aep/sdk/framework/region/RegionQueryApi", typeof (RegionQueryApi));
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

		protected RegionQueryApi (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.aliyun.iot.aep.sdk.framework.region']/class[@name='RegionQueryApi']/constructor[@name='RegionQueryApi' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe RegionQueryApi ()
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

	}
}
