using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Aliyun.Iot.Aep.Sdk.Page {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.aliyun.iot.aep.sdk.page']/class[@name='LocateHandler']"
	[global::Android.Runtime.Register ("com/aliyun/iot/aep/sdk/page/LocateHandler", DoNotGenerateAcw=true)]
	public partial class LocateHandler : global::Android.OS.Handler {

		// Metadata.xml XPath interface reference: path="/api/package[@name='com.aliyun.iot.aep.sdk.page']/interface[@name='LocateHandler.OnLocationListener']"
		[Register ("com/aliyun/iot/aep/sdk/page/LocateHandler$OnLocationListener", "", "Com.Aliyun.Iot.Aep.Sdk.Page.LocateHandler/IOnLocationListenerInvoker")]
		public partial interface IOnLocationListener : IJavaObject, IJavaPeerable {

			// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.iot.aep.sdk.page']/interface[@name='LocateHandler.OnLocationListener']/method[@name='onContinuedLocate' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("onContinuedLocate", "(Ljava/lang/String;)V", "GetOnContinuedLocate_Ljava_lang_String_Handler:Com.Aliyun.Iot.Aep.Sdk.Page.LocateHandler/IOnLocationListenerInvoker, SdkFramework")]
			void OnContinuedLocate (string p0);

			// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.iot.aep.sdk.page']/interface[@name='LocateHandler.OnLocationListener']/method[@name='onFailLocate' and count(parameter)=0]"
			[Register ("onFailLocate", "()V", "GetOnFailLocateHandler:Com.Aliyun.Iot.Aep.Sdk.Page.LocateHandler/IOnLocationListenerInvoker, SdkFramework")]
			void OnFailLocate ();

			// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.iot.aep.sdk.page']/interface[@name='LocateHandler.OnLocationListener']/method[@name='onSuccessLocate' and count(parameter)=1 and parameter[1][@type='com.aliyun.iot.aep.sdk.IoTSmart.Country']]"
			[Register ("onSuccessLocate", "(Lcom/aliyun/iot/aep/sdk/IoTSmart$Country;)V", "GetOnSuccessLocate_Lcom_aliyun_iot_aep_sdk_IoTSmart_Country_Handler:Com.Aliyun.Iot.Aep.Sdk.Page.LocateHandler/IOnLocationListenerInvoker, SdkFramework")]
			void OnSuccessLocate (global::Com.Aliyun.Iot.Aep.Sdk.IoTSmart.Country p0);

		}

		[global::Android.Runtime.Register ("com/aliyun/iot/aep/sdk/page/LocateHandler$OnLocationListener", DoNotGenerateAcw=true)]
		internal partial class IOnLocationListenerInvoker : global::Java.Lang.Object, IOnLocationListener {

			static readonly JniPeerMembers _members = new XAPeerMembers ("com/aliyun/iot/aep/sdk/page/LocateHandler$OnLocationListener", typeof (IOnLocationListenerInvoker));

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

			public static IOnLocationListener GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<IOnLocationListener> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "com.aliyun.iot.aep.sdk.page.LocateHandler.OnLocationListener"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public IOnLocationListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			static Delegate cb_onContinuedLocate_Ljava_lang_String_;
#pragma warning disable 0169
			static Delegate GetOnContinuedLocate_Ljava_lang_String_Handler ()
			{
				if (cb_onContinuedLocate_Ljava_lang_String_ == null)
					cb_onContinuedLocate_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnContinuedLocate_Ljava_lang_String_);
				return cb_onContinuedLocate_Ljava_lang_String_;
			}

			static void n_OnContinuedLocate_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Aliyun.Iot.Aep.Sdk.Page.LocateHandler.IOnLocationListener __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Iot.Aep.Sdk.Page.LocateHandler.IOnLocationListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.OnContinuedLocate (p0);
			}
#pragma warning restore 0169

			IntPtr id_onContinuedLocate_Ljava_lang_String_;
			public unsafe void OnContinuedLocate (string p0)
			{
				if (id_onContinuedLocate_Ljava_lang_String_ == IntPtr.Zero)
					id_onContinuedLocate_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "onContinuedLocate", "(Ljava/lang/String;)V");
				IntPtr native_p0 = JNIEnv.NewString (p0);
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onContinuedLocate_Ljava_lang_String_, __args);
				JNIEnv.DeleteLocalRef (native_p0);
			}

			static Delegate cb_onFailLocate;
#pragma warning disable 0169
			static Delegate GetOnFailLocateHandler ()
			{
				if (cb_onFailLocate == null)
					cb_onFailLocate = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_OnFailLocate);
				return cb_onFailLocate;
			}

			static void n_OnFailLocate (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Aliyun.Iot.Aep.Sdk.Page.LocateHandler.IOnLocationListener __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Iot.Aep.Sdk.Page.LocateHandler.IOnLocationListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.OnFailLocate ();
			}
#pragma warning restore 0169

			IntPtr id_onFailLocate;
			public unsafe void OnFailLocate ()
			{
				if (id_onFailLocate == IntPtr.Zero)
					id_onFailLocate = JNIEnv.GetMethodID (class_ref, "onFailLocate", "()V");
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onFailLocate);
			}

			static Delegate cb_onSuccessLocate_Lcom_aliyun_iot_aep_sdk_IoTSmart_Country_;
#pragma warning disable 0169
			static Delegate GetOnSuccessLocate_Lcom_aliyun_iot_aep_sdk_IoTSmart_Country_Handler ()
			{
				if (cb_onSuccessLocate_Lcom_aliyun_iot_aep_sdk_IoTSmart_Country_ == null)
					cb_onSuccessLocate_Lcom_aliyun_iot_aep_sdk_IoTSmart_Country_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnSuccessLocate_Lcom_aliyun_iot_aep_sdk_IoTSmart_Country_);
				return cb_onSuccessLocate_Lcom_aliyun_iot_aep_sdk_IoTSmart_Country_;
			}

			static void n_OnSuccessLocate_Lcom_aliyun_iot_aep_sdk_IoTSmart_Country_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Aliyun.Iot.Aep.Sdk.Page.LocateHandler.IOnLocationListener __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Iot.Aep.Sdk.Page.LocateHandler.IOnLocationListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Com.Aliyun.Iot.Aep.Sdk.IoTSmart.Country p0 = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Iot.Aep.Sdk.IoTSmart.Country> (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.OnSuccessLocate (p0);
			}
#pragma warning restore 0169

			IntPtr id_onSuccessLocate_Lcom_aliyun_iot_aep_sdk_IoTSmart_Country_;
			public unsafe void OnSuccessLocate (global::Com.Aliyun.Iot.Aep.Sdk.IoTSmart.Country p0)
			{
				if (id_onSuccessLocate_Lcom_aliyun_iot_aep_sdk_IoTSmart_Country_ == IntPtr.Zero)
					id_onSuccessLocate_Lcom_aliyun_iot_aep_sdk_IoTSmart_Country_ = JNIEnv.GetMethodID (class_ref, "onSuccessLocate", "(Lcom/aliyun/iot/aep/sdk/IoTSmart$Country;)V");
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onSuccessLocate_Lcom_aliyun_iot_aep_sdk_IoTSmart_Country_, __args);
			}

		}

		// event args for com.aliyun.iot.aep.sdk.page.LocateHandler.OnLocationListener.onContinuedLocate
		public partial class ContinuedLocateEventArgs : global::System.EventArgs {

			public ContinuedLocateEventArgs (string p0)
			{
				this.p0 = p0;
			}

			string p0;
			public string P0 {
				get { return p0; }
			}
		}

		// event args for com.aliyun.iot.aep.sdk.page.LocateHandler.OnLocationListener.onSuccessLocate
		public partial class SuccessLocateEventArgs : global::System.EventArgs {

			public SuccessLocateEventArgs (global::Com.Aliyun.Iot.Aep.Sdk.IoTSmart.Country p0)
			{
				this.p0 = p0;
			}

			global::Com.Aliyun.Iot.Aep.Sdk.IoTSmart.Country p0;
			public global::Com.Aliyun.Iot.Aep.Sdk.IoTSmart.Country P0 {
				get { return p0; }
			}
		}

		[global::Android.Runtime.Register ("mono/com/aliyun/iot/aep/sdk/page/LocateHandler_OnLocationListenerImplementor")]
		internal sealed partial class IOnLocationListenerImplementor : global::Java.Lang.Object, IOnLocationListener {

			object sender;

			public IOnLocationListenerImplementor (object sender)
				: base (
					global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/com/aliyun/iot/aep/sdk/page/LocateHandler_OnLocationListenerImplementor", "()V"),
					JniHandleOwnership.TransferLocalRef)
			{
				global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "()V");
				this.sender = sender;
			}

#pragma warning disable 0649
			public EventHandler<ContinuedLocateEventArgs> OnContinuedLocateHandler;
#pragma warning restore 0649

			public void OnContinuedLocate (string p0)
			{
				var __h = OnContinuedLocateHandler;
				if (__h != null)
					__h (sender, new ContinuedLocateEventArgs (p0));
			}
#pragma warning disable 0649
			public EventHandler OnFailLocateHandler;
#pragma warning restore 0649

			public void OnFailLocate ()
			{
				var __h = OnFailLocateHandler;
				if (__h != null)
					__h (sender, new EventArgs ());
			}
#pragma warning disable 0649
			public EventHandler<SuccessLocateEventArgs> OnSuccessLocateHandler;
#pragma warning restore 0649

			public void OnSuccessLocate (global::Com.Aliyun.Iot.Aep.Sdk.IoTSmart.Country p0)
			{
				var __h = OnSuccessLocateHandler;
				if (__h != null)
					__h (sender, new SuccessLocateEventArgs (p0));
			}

			internal static bool __IsEmpty (IOnLocationListenerImplementor value)
			{
				return value.OnContinuedLocateHandler == null && value.OnFailLocateHandler == null && value.OnSuccessLocateHandler == null;
			}
		}


		static readonly JniPeerMembers _members = new XAPeerMembers ("com/aliyun/iot/aep/sdk/page/LocateHandler", typeof (LocateHandler));
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

		protected LocateHandler (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.aliyun.iot.aep.sdk.page']/class[@name='LocateHandler']/constructor[@name='LocateHandler' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe LocateHandler ()
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
