using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Aliyun.Iot.Aep.Sdk {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.aliyun.iot.aep.sdk']/class[@name='IoTSmart']"
	[global::Android.Runtime.Register ("com/aliyun/iot/aep/sdk/IoTSmart", DoNotGenerateAcw=true)]
	public partial class IoTSmart : global::Java.Lang.Object {


		// Metadata.xml XPath field reference: path="/api/package[@name='com.aliyun.iot.aep.sdk']/class[@name='IoTSmart']/field[@name='PRODUCT_ENV_DEV']"
		[Register ("PRODUCT_ENV_DEV")]
		public const string ProductEnvDev = (string) "develop";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.aliyun.iot.aep.sdk']/class[@name='IoTSmart']/field[@name='PRODUCT_ENV_PROD']"
		[Register ("PRODUCT_ENV_PROD")]
		public const string ProductEnvProd = (string) "production";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.aliyun.iot.aep.sdk']/class[@name='IoTSmart']/field[@name='REGION_ALL']"
		[Register ("REGION_ALL")]
		public const int RegionAll = (int) 0;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.aliyun.iot.aep.sdk']/class[@name='IoTSmart']/field[@name='REGION_CHINA_ONLY']"
		[Register ("REGION_CHINA_ONLY")]
		public const int RegionChinaOnly = (int) 1;
		// Metadata.xml XPath class reference: path="/api/package[@name='com.aliyun.iot.aep.sdk']/class[@name='IoTSmart.Country']"
		[global::Android.Runtime.Register ("com/aliyun/iot/aep/sdk/IoTSmart$Country", DoNotGenerateAcw=true)]
		public partial class Country : global::Java.Lang.Object, global::Java.IO.ISerializable {



			// Metadata.xml XPath field reference: path="/api/package[@name='com.aliyun.iot.aep.sdk']/class[@name='IoTSmart.Country']/field[@name='areaName']"
			[Register ("areaName")]
			public string AreaName {
				get {
					const string __id = "areaName.Ljava/lang/String;";

					var __v = _members.InstanceFields.GetObjectValue (__id, this);
					return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
				set {
					const string __id = "areaName.Ljava/lang/String;";

					IntPtr native_value = JNIEnv.NewString (value);
					try {
						_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
					} finally {
						JNIEnv.DeleteLocalRef (native_value);
					}
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.aliyun.iot.aep.sdk']/class[@name='IoTSmart.Country']/field[@name='code']"
			[Register ("code")]
			public string Code {
				get {
					const string __id = "code.Ljava/lang/String;";

					var __v = _members.InstanceFields.GetObjectValue (__id, this);
					return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
				set {
					const string __id = "code.Ljava/lang/String;";

					IntPtr native_value = JNIEnv.NewString (value);
					try {
						_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
					} finally {
						JNIEnv.DeleteLocalRef (native_value);
					}
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.aliyun.iot.aep.sdk']/class[@name='IoTSmart.Country']/field[@name='domainAbbreviation']"
			[Register ("domainAbbreviation")]
			public string DomainAbbreviation {
				get {
					const string __id = "domainAbbreviation.Ljava/lang/String;";

					var __v = _members.InstanceFields.GetObjectValue (__id, this);
					return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
				set {
					const string __id = "domainAbbreviation.Ljava/lang/String;";

					IntPtr native_value = JNIEnv.NewString (value);
					try {
						_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
					} finally {
						JNIEnv.DeleteLocalRef (native_value);
					}
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.aliyun.iot.aep.sdk']/class[@name='IoTSmart.Country']/field[@name='isoCode']"
			[Register ("isoCode")]
			public string IsoCode {
				get {
					const string __id = "isoCode.Ljava/lang/String;";

					var __v = _members.InstanceFields.GetObjectValue (__id, this);
					return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
				set {
					const string __id = "isoCode.Ljava/lang/String;";

					IntPtr native_value = JNIEnv.NewString (value);
					try {
						_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
					} finally {
						JNIEnv.DeleteLocalRef (native_value);
					}
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.aliyun.iot.aep.sdk']/class[@name='IoTSmart.Country']/field[@name='pinyin']"
			[Register ("pinyin")]
			public string Pinyin {
				get {
					const string __id = "pinyin.Ljava/lang/String;";

					var __v = _members.InstanceFields.GetObjectValue (__id, this);
					return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
				set {
					const string __id = "pinyin.Ljava/lang/String;";

					IntPtr native_value = JNIEnv.NewString (value);
					try {
						_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
					} finally {
						JNIEnv.DeleteLocalRef (native_value);
					}
				}
			}
			static readonly JniPeerMembers _members = new XAPeerMembers ("com/aliyun/iot/aep/sdk/IoTSmart$Country", typeof (Country));
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

			protected Country (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.aliyun.iot.aep.sdk']/class[@name='IoTSmart.Country']/constructor[@name='IoTSmart.Country' and count(parameter)=0]"
			[Register (".ctor", "()V", "")]
			public unsafe Country ()
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

		// Metadata.xml XPath interface reference: path="/api/package[@name='com.aliyun.iot.aep.sdk']/interface[@name='IoTSmart.ICountryListGetCallBack']"
		[Register ("com/aliyun/iot/aep/sdk/IoTSmart$ICountryListGetCallBack", "", "Com.Aliyun.Iot.Aep.Sdk.IoTSmart/ICountryListGetCallBackInvoker")]
		public partial interface ICountryListGetCallBack : IJavaObject, IJavaPeerable {

			// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.iot.aep.sdk']/interface[@name='IoTSmart.ICountryListGetCallBack']/method[@name='onFail' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='int'] and parameter[3][@type='java.lang.String']]"
			[Register ("onFail", "(Ljava/lang/String;ILjava/lang/String;)V", "GetOnFail_Ljava_lang_String_ILjava_lang_String_Handler:Com.Aliyun.Iot.Aep.Sdk.IoTSmart/ICountryListGetCallBackInvoker, SdkFramework")]
			void OnFail (string p0, int p1, string p2);

			// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.iot.aep.sdk']/interface[@name='IoTSmart.ICountryListGetCallBack']/method[@name='onSucess' and count(parameter)=1 and parameter[1][@type='java.util.List&lt;com.aliyun.iot.aep.sdk.IoTSmart.Country&gt;']]"
			[Register ("onSucess", "(Ljava/util/List;)V", "GetOnSucess_Ljava_util_List_Handler:Com.Aliyun.Iot.Aep.Sdk.IoTSmart/ICountryListGetCallBackInvoker, SdkFramework")]
			void OnSucess (global::System.Collections.Generic.IList<global::Com.Aliyun.Iot.Aep.Sdk.IoTSmart.Country> p0);

		}

		[global::Android.Runtime.Register ("com/aliyun/iot/aep/sdk/IoTSmart$ICountryListGetCallBack", DoNotGenerateAcw=true)]
		internal partial class ICountryListGetCallBackInvoker : global::Java.Lang.Object, ICountryListGetCallBack {

			static readonly JniPeerMembers _members = new XAPeerMembers ("com/aliyun/iot/aep/sdk/IoTSmart$ICountryListGetCallBack", typeof (ICountryListGetCallBackInvoker));

			static IntPtr java_class_ref {
				get { return _members.JniPeerType.PeerReference.Handle; }
			}

			public override global::Java.Interop.JniPeerMembers JniPeerMembers {
				get { return _members; }
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return _members.ManagedPeerType; }
			}

			IntPtr class_ref;

			public static ICountryListGetCallBack GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<ICountryListGetCallBack> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "com.aliyun.iot.aep.sdk.IoTSmart.ICountryListGetCallBack"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public ICountryListGetCallBackInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			static Delegate cb_onFail_Ljava_lang_String_ILjava_lang_String_;
#pragma warning disable 0169
			static Delegate GetOnFail_Ljava_lang_String_ILjava_lang_String_Handler ()
			{
				if (cb_onFail_Ljava_lang_String_ILjava_lang_String_ == null)
					cb_onFail_Ljava_lang_String_ILjava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, int, IntPtr>) n_OnFail_Ljava_lang_String_ILjava_lang_String_);
				return cb_onFail_Ljava_lang_String_ILjava_lang_String_;
			}

			static void n_OnFail_Ljava_lang_String_ILjava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1, IntPtr native_p2)
			{
				global::Com.Aliyun.Iot.Aep.Sdk.IoTSmart.ICountryListGetCallBack __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Iot.Aep.Sdk.IoTSmart.ICountryListGetCallBack> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
				string p2 = JNIEnv.GetString (native_p2, JniHandleOwnership.DoNotTransfer);
				__this.OnFail (p0, p1, p2);
			}
#pragma warning restore 0169

			IntPtr id_onFail_Ljava_lang_String_ILjava_lang_String_;
			public unsafe void OnFail (string p0, int p1, string p2)
			{
				if (id_onFail_Ljava_lang_String_ILjava_lang_String_ == IntPtr.Zero)
					id_onFail_Ljava_lang_String_ILjava_lang_String_ = JNIEnv.GetMethodID (class_ref, "onFail", "(Ljava/lang/String;ILjava/lang/String;)V");
				IntPtr native_p0 = JNIEnv.NewString (p0);
				IntPtr native_p2 = JNIEnv.NewString (p2);
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (native_p2);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onFail_Ljava_lang_String_ILjava_lang_String_, __args);
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p2);
			}

			static Delegate cb_onSucess_Ljava_util_List_;
#pragma warning disable 0169
			static Delegate GetOnSucess_Ljava_util_List_Handler ()
			{
				if (cb_onSucess_Ljava_util_List_ == null)
					cb_onSucess_Ljava_util_List_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnSucess_Ljava_util_List_);
				return cb_onSucess_Ljava_util_List_;
			}

			static void n_OnSucess_Ljava_util_List_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Aliyun.Iot.Aep.Sdk.IoTSmart.ICountryListGetCallBack __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Iot.Aep.Sdk.IoTSmart.ICountryListGetCallBack> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				var p0 = global::Android.Runtime.JavaList<global::Com.Aliyun.Iot.Aep.Sdk.IoTSmart.Country>.FromJniHandle (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.OnSucess (p0);
			}
#pragma warning restore 0169

			IntPtr id_onSucess_Ljava_util_List_;
			public unsafe void OnSucess (global::System.Collections.Generic.IList<global::Com.Aliyun.Iot.Aep.Sdk.IoTSmart.Country> p0)
			{
				if (id_onSucess_Ljava_util_List_ == IntPtr.Zero)
					id_onSucess_Ljava_util_List_ = JNIEnv.GetMethodID (class_ref, "onSucess", "(Ljava/util/List;)V");
				IntPtr native_p0 = global::Android.Runtime.JavaList<global::Com.Aliyun.Iot.Aep.Sdk.IoTSmart.Country>.ToLocalJniHandle (p0);
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onSucess_Ljava_util_List_, __args);
				JNIEnv.DeleteLocalRef (native_p0);
			}

		}


		// Metadata.xml XPath interface reference: path="/api/package[@name='com.aliyun.iot.aep.sdk']/interface[@name='IoTSmart.ICountrySelectCallBack']"
		[Register ("com/aliyun/iot/aep/sdk/IoTSmart$ICountrySelectCallBack", "", "Com.Aliyun.Iot.Aep.Sdk.IoTSmart/ICountrySelectCallBackInvoker")]
		public partial interface ICountrySelectCallBack : IJavaObject, IJavaPeerable {

			// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.iot.aep.sdk']/interface[@name='IoTSmart.ICountrySelectCallBack']/method[@name='onCountrySelect' and count(parameter)=1 and parameter[1][@type='com.aliyun.iot.aep.sdk.IoTSmart.Country']]"
			[Register ("onCountrySelect", "(Lcom/aliyun/iot/aep/sdk/IoTSmart$Country;)V", "GetOnCountrySelect_Lcom_aliyun_iot_aep_sdk_IoTSmart_Country_Handler:Com.Aliyun.Iot.Aep.Sdk.IoTSmart/ICountrySelectCallBackInvoker, SdkFramework")]
			void OnCountrySelect (global::Com.Aliyun.Iot.Aep.Sdk.IoTSmart.Country p0);

		}

		[global::Android.Runtime.Register ("com/aliyun/iot/aep/sdk/IoTSmart$ICountrySelectCallBack", DoNotGenerateAcw=true)]
		internal partial class ICountrySelectCallBackInvoker : global::Java.Lang.Object, ICountrySelectCallBack {

			static readonly JniPeerMembers _members = new XAPeerMembers ("com/aliyun/iot/aep/sdk/IoTSmart$ICountrySelectCallBack", typeof (ICountrySelectCallBackInvoker));

			static IntPtr java_class_ref {
				get { return _members.JniPeerType.PeerReference.Handle; }
			}

			public override global::Java.Interop.JniPeerMembers JniPeerMembers {
				get { return _members; }
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return _members.ManagedPeerType; }
			}

			IntPtr class_ref;

			public static ICountrySelectCallBack GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<ICountrySelectCallBack> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "com.aliyun.iot.aep.sdk.IoTSmart.ICountrySelectCallBack"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public ICountrySelectCallBackInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			static Delegate cb_onCountrySelect_Lcom_aliyun_iot_aep_sdk_IoTSmart_Country_;
#pragma warning disable 0169
			static Delegate GetOnCountrySelect_Lcom_aliyun_iot_aep_sdk_IoTSmart_Country_Handler ()
			{
				if (cb_onCountrySelect_Lcom_aliyun_iot_aep_sdk_IoTSmart_Country_ == null)
					cb_onCountrySelect_Lcom_aliyun_iot_aep_sdk_IoTSmart_Country_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnCountrySelect_Lcom_aliyun_iot_aep_sdk_IoTSmart_Country_);
				return cb_onCountrySelect_Lcom_aliyun_iot_aep_sdk_IoTSmart_Country_;
			}

			static void n_OnCountrySelect_Lcom_aliyun_iot_aep_sdk_IoTSmart_Country_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Aliyun.Iot.Aep.Sdk.IoTSmart.ICountrySelectCallBack __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Iot.Aep.Sdk.IoTSmart.ICountrySelectCallBack> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Com.Aliyun.Iot.Aep.Sdk.IoTSmart.Country p0 = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Iot.Aep.Sdk.IoTSmart.Country> (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.OnCountrySelect (p0);
			}
#pragma warning restore 0169

			IntPtr id_onCountrySelect_Lcom_aliyun_iot_aep_sdk_IoTSmart_Country_;
			public unsafe void OnCountrySelect (global::Com.Aliyun.Iot.Aep.Sdk.IoTSmart.Country p0)
			{
				if (id_onCountrySelect_Lcom_aliyun_iot_aep_sdk_IoTSmart_Country_ == IntPtr.Zero)
					id_onCountrySelect_Lcom_aliyun_iot_aep_sdk_IoTSmart_Country_ = JNIEnv.GetMethodID (class_ref, "onCountrySelect", "(Lcom/aliyun/iot/aep/sdk/IoTSmart$Country;)V");
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onCountrySelect_Lcom_aliyun_iot_aep_sdk_IoTSmart_Country_, __args);
			}

		}


		// Metadata.xml XPath interface reference: path="/api/package[@name='com.aliyun.iot.aep.sdk']/interface[@name='IoTSmart.ICountrySetCallBack']"
		[Register ("com/aliyun/iot/aep/sdk/IoTSmart$ICountrySetCallBack", "", "Com.Aliyun.Iot.Aep.Sdk.IoTSmart/ICountrySetCallBackInvoker")]
		public partial interface ICountrySetCallBack : IJavaObject, IJavaPeerable {

			// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.iot.aep.sdk']/interface[@name='IoTSmart.ICountrySetCallBack']/method[@name='onCountrySet' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("onCountrySet", "(Z)V", "GetOnCountrySet_ZHandler:Com.Aliyun.Iot.Aep.Sdk.IoTSmart/ICountrySetCallBackInvoker, SdkFramework")]
			void OnCountrySet (bool p0);

		}

		[global::Android.Runtime.Register ("com/aliyun/iot/aep/sdk/IoTSmart$ICountrySetCallBack", DoNotGenerateAcw=true)]
		internal partial class ICountrySetCallBackInvoker : global::Java.Lang.Object, ICountrySetCallBack {

			static readonly JniPeerMembers _members = new XAPeerMembers ("com/aliyun/iot/aep/sdk/IoTSmart$ICountrySetCallBack", typeof (ICountrySetCallBackInvoker));

			static IntPtr java_class_ref {
				get { return _members.JniPeerType.PeerReference.Handle; }
			}

			public override global::Java.Interop.JniPeerMembers JniPeerMembers {
				get { return _members; }
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return _members.ManagedPeerType; }
			}

			IntPtr class_ref;

			public static ICountrySetCallBack GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<ICountrySetCallBack> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "com.aliyun.iot.aep.sdk.IoTSmart.ICountrySetCallBack"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public ICountrySetCallBackInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			static Delegate cb_onCountrySet_Z;
#pragma warning disable 0169
			static Delegate GetOnCountrySet_ZHandler ()
			{
				if (cb_onCountrySet_Z == null)
					cb_onCountrySet_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_OnCountrySet_Z);
				return cb_onCountrySet_Z;
			}

			static void n_OnCountrySet_Z (IntPtr jnienv, IntPtr native__this, bool p0)
			{
				global::Com.Aliyun.Iot.Aep.Sdk.IoTSmart.ICountrySetCallBack __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Iot.Aep.Sdk.IoTSmart.ICountrySetCallBack> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.OnCountrySet (p0);
			}
#pragma warning restore 0169

			IntPtr id_onCountrySet_Z;
			public unsafe void OnCountrySet (bool p0)
			{
				if (id_onCountrySet_Z == IntPtr.Zero)
					id_onCountrySet_Z = JNIEnv.GetMethodID (class_ref, "onCountrySet", "(Z)V");
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onCountrySet_Z, __args);
			}

		}


		// Metadata.xml XPath class reference: path="/api/package[@name='com.aliyun.iot.aep.sdk']/class[@name='IoTSmart.InitConfig']"
		[global::Android.Runtime.Register ("com/aliyun/iot/aep/sdk/IoTSmart$InitConfig", DoNotGenerateAcw=true)]
		public partial class InitConfig : global::Java.Lang.Object, global::Java.IO.ISerializable {

			static readonly JniPeerMembers _members = new XAPeerMembers ("com/aliyun/iot/aep/sdk/IoTSmart$InitConfig", typeof (InitConfig));
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

			protected InitConfig (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.aliyun.iot.aep.sdk']/class[@name='IoTSmart.InitConfig']/constructor[@name='IoTSmart.InitConfig' and count(parameter)=0]"
			[Register (".ctor", "()V", "")]
			public unsafe InitConfig ()
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

			static Delegate cb_isDebug;
#pragma warning disable 0169
			static Delegate GetIsDebugHandler ()
			{
				if (cb_isDebug == null)
					cb_isDebug = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsDebug);
				return cb_isDebug;
			}

			static bool n_IsDebug (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Aliyun.Iot.Aep.Sdk.IoTSmart.InitConfig __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Iot.Aep.Sdk.IoTSmart.InitConfig> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return __this.IsDebug;
			}
#pragma warning restore 0169

			public virtual unsafe bool IsDebug {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.iot.aep.sdk']/class[@name='IoTSmart.InitConfig']/method[@name='isDebug' and count(parameter)=0]"
				[Register ("isDebug", "()Z", "GetIsDebugHandler")]
				get {
					const string __id = "isDebug.()Z";
					try {
						var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
						return __rm;
					} finally {
					}
				}
			}

			static Delegate cb_getProductEnv;
#pragma warning disable 0169
			static Delegate GetGetProductEnvHandler ()
			{
				if (cb_getProductEnv == null)
					cb_getProductEnv = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetProductEnv);
				return cb_getProductEnv;
			}

			static IntPtr n_GetProductEnv (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Aliyun.Iot.Aep.Sdk.IoTSmart.InitConfig __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Iot.Aep.Sdk.IoTSmart.InitConfig> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.NewString (__this.ProductEnv);
			}
#pragma warning restore 0169

			public virtual unsafe string ProductEnv {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.iot.aep.sdk']/class[@name='IoTSmart.InitConfig']/method[@name='getProductEnv' and count(parameter)=0]"
				[Register ("getProductEnv", "()Ljava/lang/String;", "GetGetProductEnvHandler")]
				get {
					const string __id = "getProductEnv.()Ljava/lang/String;";
					try {
						var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
						return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
					} finally {
					}
				}
			}

			static Delegate cb_getPushConfig;
#pragma warning disable 0169
			static Delegate GetGetPushConfigHandler ()
			{
				if (cb_getPushConfig == null)
					cb_getPushConfig = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetPushConfig);
				return cb_getPushConfig;
			}

			static IntPtr n_GetPushConfig (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Aliyun.Iot.Aep.Sdk.IoTSmart.InitConfig __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Iot.Aep.Sdk.IoTSmart.InitConfig> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.PushConfig);
			}
#pragma warning restore 0169

			public virtual unsafe global::Com.Aliyun.Iot.Aep.Sdk.IoTSmart.PushConfig PushConfig {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.iot.aep.sdk']/class[@name='IoTSmart.InitConfig']/method[@name='getPushConfig' and count(parameter)=0]"
				[Register ("getPushConfig", "()Lcom/aliyun/iot/aep/sdk/IoTSmart$PushConfig;", "GetGetPushConfigHandler")]
				get {
					const string __id = "getPushConfig.()Lcom/aliyun/iot/aep/sdk/IoTSmart$PushConfig;";
					try {
						var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
						return global::Java.Lang.Object.GetObject<global::Com.Aliyun.Iot.Aep.Sdk.IoTSmart.PushConfig> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
					} finally {
					}
				}
			}

			static Delegate cb_getRegionType;
#pragma warning disable 0169
			static Delegate GetGetRegionTypeHandler ()
			{
				if (cb_getRegionType == null)
					cb_getRegionType = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetRegionType);
				return cb_getRegionType;
			}

			static int n_GetRegionType (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Aliyun.Iot.Aep.Sdk.IoTSmart.InitConfig __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Iot.Aep.Sdk.IoTSmart.InitConfig> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return __this.RegionType;
			}
#pragma warning restore 0169

			public virtual unsafe int RegionType {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.iot.aep.sdk']/class[@name='IoTSmart.InitConfig']/method[@name='getRegionType' and count(parameter)=0]"
				[Register ("getRegionType", "()I", "GetGetRegionTypeHandler")]
				get {
					const string __id = "getRegionType.()I";
					try {
						var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
						return __rm;
					} finally {
					}
				}
			}

			static Delegate cb_setDebug_Z;
#pragma warning disable 0169
			static Delegate GetSetDebug_ZHandler ()
			{
				if (cb_setDebug_Z == null)
					cb_setDebug_Z = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool, IntPtr>) n_SetDebug_Z);
				return cb_setDebug_Z;
			}

			static IntPtr n_SetDebug_Z (IntPtr jnienv, IntPtr native__this, bool debug)
			{
				global::Com.Aliyun.Iot.Aep.Sdk.IoTSmart.InitConfig __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Iot.Aep.Sdk.IoTSmart.InitConfig> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.SetDebug (debug));
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.iot.aep.sdk']/class[@name='IoTSmart.InitConfig']/method[@name='setDebug' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setDebug", "(Z)Lcom/aliyun/iot/aep/sdk/IoTSmart$InitConfig;", "GetSetDebug_ZHandler")]
			public virtual unsafe global::Com.Aliyun.Iot.Aep.Sdk.IoTSmart.InitConfig SetDebug (bool debug)
			{
				const string __id = "setDebug.(Z)Lcom/aliyun/iot/aep/sdk/IoTSmart$InitConfig;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (debug);
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Aliyun.Iot.Aep.Sdk.IoTSmart.InitConfig> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			static Delegate cb_setProductEnv_Ljava_lang_String_;
#pragma warning disable 0169
			static Delegate GetSetProductEnv_Ljava_lang_String_Handler ()
			{
				if (cb_setProductEnv_Ljava_lang_String_ == null)
					cb_setProductEnv_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_SetProductEnv_Ljava_lang_String_);
				return cb_setProductEnv_Ljava_lang_String_;
			}

			static IntPtr n_SetProductEnv_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_productEnv)
			{
				global::Com.Aliyun.Iot.Aep.Sdk.IoTSmart.InitConfig __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Iot.Aep.Sdk.IoTSmart.InitConfig> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				string productEnv = JNIEnv.GetString (native_productEnv, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetProductEnv (productEnv));
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.iot.aep.sdk']/class[@name='IoTSmart.InitConfig']/method[@name='setProductEnv' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setProductEnv", "(Ljava/lang/String;)Lcom/aliyun/iot/aep/sdk/IoTSmart$InitConfig;", "GetSetProductEnv_Ljava_lang_String_Handler")]
			public virtual unsafe global::Com.Aliyun.Iot.Aep.Sdk.IoTSmart.InitConfig SetProductEnv (string productEnv)
			{
				const string __id = "setProductEnv.(Ljava/lang/String;)Lcom/aliyun/iot/aep/sdk/IoTSmart$InitConfig;";
				IntPtr native_productEnv = JNIEnv.NewString (productEnv);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_productEnv);
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Aliyun.Iot.Aep.Sdk.IoTSmart.InitConfig> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					JNIEnv.DeleteLocalRef (native_productEnv);
				}
			}

			static Delegate cb_setPushConfig_Lcom_aliyun_iot_aep_sdk_IoTSmart_PushConfig_;
#pragma warning disable 0169
			static Delegate GetSetPushConfig_Lcom_aliyun_iot_aep_sdk_IoTSmart_PushConfig_Handler ()
			{
				if (cb_setPushConfig_Lcom_aliyun_iot_aep_sdk_IoTSmart_PushConfig_ == null)
					cb_setPushConfig_Lcom_aliyun_iot_aep_sdk_IoTSmart_PushConfig_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_SetPushConfig_Lcom_aliyun_iot_aep_sdk_IoTSmart_PushConfig_);
				return cb_setPushConfig_Lcom_aliyun_iot_aep_sdk_IoTSmart_PushConfig_;
			}

			static IntPtr n_SetPushConfig_Lcom_aliyun_iot_aep_sdk_IoTSmart_PushConfig_ (IntPtr jnienv, IntPtr native__this, IntPtr native_pushConfig)
			{
				global::Com.Aliyun.Iot.Aep.Sdk.IoTSmart.InitConfig __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Iot.Aep.Sdk.IoTSmart.InitConfig> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Com.Aliyun.Iot.Aep.Sdk.IoTSmart.PushConfig pushConfig = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Iot.Aep.Sdk.IoTSmart.PushConfig> (native_pushConfig, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetPushConfig (pushConfig));
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.iot.aep.sdk']/class[@name='IoTSmart.InitConfig']/method[@name='setPushConfig' and count(parameter)=1 and parameter[1][@type='com.aliyun.iot.aep.sdk.IoTSmart.PushConfig']]"
			[Register ("setPushConfig", "(Lcom/aliyun/iot/aep/sdk/IoTSmart$PushConfig;)Lcom/aliyun/iot/aep/sdk/IoTSmart$InitConfig;", "GetSetPushConfig_Lcom_aliyun_iot_aep_sdk_IoTSmart_PushConfig_Handler")]
			public virtual unsafe global::Com.Aliyun.Iot.Aep.Sdk.IoTSmart.InitConfig SetPushConfig (global::Com.Aliyun.Iot.Aep.Sdk.IoTSmart.PushConfig pushConfig)
			{
				const string __id = "setPushConfig.(Lcom/aliyun/iot/aep/sdk/IoTSmart$PushConfig;)Lcom/aliyun/iot/aep/sdk/IoTSmart$InitConfig;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((pushConfig == null) ? IntPtr.Zero : ((global::Java.Lang.Object) pushConfig).Handle);
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Aliyun.Iot.Aep.Sdk.IoTSmart.InitConfig> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			static Delegate cb_setRegionType_I;
#pragma warning disable 0169
			static Delegate GetSetRegionType_IHandler ()
			{
				if (cb_setRegionType_I == null)
					cb_setRegionType_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr>) n_SetRegionType_I);
				return cb_setRegionType_I;
			}

			static IntPtr n_SetRegionType_I (IntPtr jnienv, IntPtr native__this, int regionType)
			{
				global::Com.Aliyun.Iot.Aep.Sdk.IoTSmart.InitConfig __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Iot.Aep.Sdk.IoTSmart.InitConfig> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.SetRegionType (regionType));
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.iot.aep.sdk']/class[@name='IoTSmart.InitConfig']/method[@name='setRegionType' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setRegionType", "(I)Lcom/aliyun/iot/aep/sdk/IoTSmart$InitConfig;", "GetSetRegionType_IHandler")]
			public virtual unsafe global::Com.Aliyun.Iot.Aep.Sdk.IoTSmart.InitConfig SetRegionType (int regionType)
			{
				const string __id = "setRegionType.(I)Lcom/aliyun/iot/aep/sdk/IoTSmart$InitConfig;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (regionType);
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Aliyun.Iot.Aep.Sdk.IoTSmart.InitConfig> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.aliyun.iot.aep.sdk']/class[@name='IoTSmart.PushConfig']"
		[global::Android.Runtime.Register ("com/aliyun/iot/aep/sdk/IoTSmart$PushConfig", DoNotGenerateAcw=true)]
		public partial class PushConfig : global::Java.Lang.Object, global::Java.IO.ISerializable {



			// Metadata.xml XPath field reference: path="/api/package[@name='com.aliyun.iot.aep.sdk']/class[@name='IoTSmart.PushConfig']/field[@name='fcmApplicationId']"
			[Register ("fcmApplicationId")]
			public string FcmApplicationId {
				get {
					const string __id = "fcmApplicationId.Ljava/lang/String;";

					var __v = _members.InstanceFields.GetObjectValue (__id, this);
					return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
				set {
					const string __id = "fcmApplicationId.Ljava/lang/String;";

					IntPtr native_value = JNIEnv.NewString (value);
					try {
						_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
					} finally {
						JNIEnv.DeleteLocalRef (native_value);
					}
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.aliyun.iot.aep.sdk']/class[@name='IoTSmart.PushConfig']/field[@name='fcmSendId']"
			[Register ("fcmSendId")]
			public string FcmSendId {
				get {
					const string __id = "fcmSendId.Ljava/lang/String;";

					var __v = _members.InstanceFields.GetObjectValue (__id, this);
					return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
				set {
					const string __id = "fcmSendId.Ljava/lang/String;";

					IntPtr native_value = JNIEnv.NewString (value);
					try {
						_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
					} finally {
						JNIEnv.DeleteLocalRef (native_value);
					}
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.aliyun.iot.aep.sdk']/class[@name='IoTSmart.PushConfig']/field[@name='oppoAppKey']"
			[Register ("oppoAppKey")]
			public string OppoAppKey {
				get {
					const string __id = "oppoAppKey.Ljava/lang/String;";

					var __v = _members.InstanceFields.GetObjectValue (__id, this);
					return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
				set {
					const string __id = "oppoAppKey.Ljava/lang/String;";

					IntPtr native_value = JNIEnv.NewString (value);
					try {
						_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
					} finally {
						JNIEnv.DeleteLocalRef (native_value);
					}
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.aliyun.iot.aep.sdk']/class[@name='IoTSmart.PushConfig']/field[@name='oppoAppSecret']"
			[Register ("oppoAppSecret")]
			public string OppoAppSecret {
				get {
					const string __id = "oppoAppSecret.Ljava/lang/String;";

					var __v = _members.InstanceFields.GetObjectValue (__id, this);
					return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
				set {
					const string __id = "oppoAppSecret.Ljava/lang/String;";

					IntPtr native_value = JNIEnv.NewString (value);
					try {
						_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
					} finally {
						JNIEnv.DeleteLocalRef (native_value);
					}
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.aliyun.iot.aep.sdk']/class[@name='IoTSmart.PushConfig']/field[@name='xiaomiAppId']"
			[Register ("xiaomiAppId")]
			public string XiaomiAppId {
				get {
					const string __id = "xiaomiAppId.Ljava/lang/String;";

					var __v = _members.InstanceFields.GetObjectValue (__id, this);
					return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
				set {
					const string __id = "xiaomiAppId.Ljava/lang/String;";

					IntPtr native_value = JNIEnv.NewString (value);
					try {
						_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
					} finally {
						JNIEnv.DeleteLocalRef (native_value);
					}
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.aliyun.iot.aep.sdk']/class[@name='IoTSmart.PushConfig']/field[@name='xiaomiAppkey']"
			[Register ("xiaomiAppkey")]
			public string XiaomiAppkey {
				get {
					const string __id = "xiaomiAppkey.Ljava/lang/String;";

					var __v = _members.InstanceFields.GetObjectValue (__id, this);
					return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
				set {
					const string __id = "xiaomiAppkey.Ljava/lang/String;";

					IntPtr native_value = JNIEnv.NewString (value);
					try {
						_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
					} finally {
						JNIEnv.DeleteLocalRef (native_value);
					}
				}
			}
			static readonly JniPeerMembers _members = new XAPeerMembers ("com/aliyun/iot/aep/sdk/IoTSmart$PushConfig", typeof (PushConfig));
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

			protected PushConfig (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.aliyun.iot.aep.sdk']/class[@name='IoTSmart.PushConfig']/constructor[@name='IoTSmart.PushConfig' and count(parameter)=0]"
			[Register (".ctor", "()V", "")]
			public unsafe PushConfig ()
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

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/aliyun/iot/aep/sdk/IoTSmart", typeof (IoTSmart));
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

		protected IoTSmart (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.aliyun.iot.aep.sdk']/class[@name='IoTSmart']/constructor[@name='IoTSmart' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe IoTSmart ()
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

		public static unsafe string Language {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.iot.aep.sdk']/class[@name='IoTSmart']/method[@name='getLanguage' and count(parameter)=0]"
			[Register ("getLanguage", "()Ljava/lang/String;", "")]
			get {
				const string __id = "getLanguage.()Ljava/lang/String;";
				try {
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.iot.aep.sdk']/class[@name='IoTSmart']/method[@name='setLanguage' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setLanguage", "(Ljava/lang/String;)V", "")]
			set {
				const string __id = "setLanguage.(Ljava/lang/String;)V";
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_value);
					_members.StaticMethods.InvokeVoidMethod (__id, __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.iot.aep.sdk']/class[@name='IoTSmart']/method[@name='getCountry' and count(parameter)=0]"
		[Register ("getCountry", "()Lcom/aliyun/iot/aep/sdk/IoTSmart$Country;", "")]
		public static unsafe global::Com.Aliyun.Iot.Aep.Sdk.IoTSmart.Country GetCountry ()
		{
			const string __id = "getCountry.()Lcom/aliyun/iot/aep/sdk/IoTSmart$Country;";
			try {
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
				return global::Java.Lang.Object.GetObject<global::Com.Aliyun.Iot.Aep.Sdk.IoTSmart.Country> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.iot.aep.sdk']/class[@name='IoTSmart']/method[@name='getCountryList' and count(parameter)=1 and parameter[1][@type='com.aliyun.iot.aep.sdk.IoTSmart.ICountryListGetCallBack']]"
		[Register ("getCountryList", "(Lcom/aliyun/iot/aep/sdk/IoTSmart$ICountryListGetCallBack;)V", "")]
		public static unsafe void GetCountryList (global::Com.Aliyun.Iot.Aep.Sdk.IoTSmart.ICountryListGetCallBack @callback)
		{
			const string __id = "getCountryList.(Lcom/aliyun/iot/aep/sdk/IoTSmart$ICountryListGetCallBack;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((@callback == null) ? IntPtr.Zero : ((global::Java.Lang.Object) @callback).Handle);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.iot.aep.sdk']/class[@name='IoTSmart']/method[@name='setCountry' and count(parameter)=2 and parameter[1][@type='com.aliyun.iot.aep.sdk.IoTSmart.Country'] and parameter[2][@type='com.aliyun.iot.aep.sdk.IoTSmart.ICountrySetCallBack']]"
		[Register ("setCountry", "(Lcom/aliyun/iot/aep/sdk/IoTSmart$Country;Lcom/aliyun/iot/aep/sdk/IoTSmart$ICountrySetCallBack;)V", "")]
		public static unsafe void SetCountry (global::Com.Aliyun.Iot.Aep.Sdk.IoTSmart.Country country, global::Com.Aliyun.Iot.Aep.Sdk.IoTSmart.ICountrySetCallBack callBack)
		{
			const string __id = "setCountry.(Lcom/aliyun/iot/aep/sdk/IoTSmart$Country;Lcom/aliyun/iot/aep/sdk/IoTSmart$ICountrySetCallBack;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((country == null) ? IntPtr.Zero : ((global::Java.Lang.Object) country).Handle);
				__args [1] = new JniArgumentValue ((callBack == null) ? IntPtr.Zero : ((global::Java.Lang.Object) callBack).Handle);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.iot.aep.sdk']/class[@name='IoTSmart']/method[@name='setDebug' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("setDebug", "(Z)V", "")]
		public static unsafe void SetDebug (bool debug)
		{
			const string __id = "setDebug.(Z)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (debug);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.iot.aep.sdk']/class[@name='IoTSmart']/method[@name='setDebugLevel' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setDebugLevel", "(I)V", "")]
		public static unsafe void SetDebugLevel (int level)
		{
			const string __id = "setDebugLevel.(I)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (level);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.iot.aep.sdk']/class[@name='IoTSmart']/method[@name='showCountryList' and count(parameter)=1 and parameter[1][@type='com.aliyun.iot.aep.sdk.IoTSmart.ICountrySelectCallBack']]"
		[Register ("showCountryList", "(Lcom/aliyun/iot/aep/sdk/IoTSmart$ICountrySelectCallBack;)V", "")]
		public static unsafe void ShowCountryList (global::Com.Aliyun.Iot.Aep.Sdk.IoTSmart.ICountrySelectCallBack callBack)
		{
			const string __id = "showCountryList.(Lcom/aliyun/iot/aep/sdk/IoTSmart$ICountrySelectCallBack;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((callBack == null) ? IntPtr.Zero : ((global::Java.Lang.Object) callBack).Handle);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
			}
		}

	}
}
