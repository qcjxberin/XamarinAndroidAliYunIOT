using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Component.Cloud {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.lpbs.component.cloud']/interface[@name='IDevInfoTrans.IDevInfoTransListener']"
	[Register ("com/aliyun/alink/linksdk/alcs/lpbs/component/cloud/IDevInfoTrans$IDevInfoTransListener", "", "Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Component.Cloud.IDevInfoTransDevInfoTransListenerInvoker")]
	public partial interface IDevInfoTransDevInfoTransListener : IJavaObject, IJavaPeerable {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.lpbs.component.cloud']/interface[@name='IDevInfoTrans.IDevInfoTransListener']/method[@name='onComplete' and count(parameter)=2 and parameter[1][@type='boolean'] and parameter[2][@type='java.lang.Object']]"
		[Register ("onComplete", "(ZLjava/lang/Object;)V", "GetOnComplete_ZLjava_lang_Object_Handler:Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Component.Cloud.IDevInfoTransDevInfoTransListenerInvoker, AndroidAlcsLpbsBinding")]
		void OnComplete (bool p0, global::Java.Lang.Object p1);

	}

	[global::Android.Runtime.Register ("com/aliyun/alink/linksdk/alcs/lpbs/component/cloud/IDevInfoTrans$IDevInfoTransListener", DoNotGenerateAcw=true)]
	internal partial class IDevInfoTransDevInfoTransListenerInvoker : global::Java.Lang.Object, IDevInfoTransDevInfoTransListener {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/aliyun/alink/linksdk/alcs/lpbs/component/cloud/IDevInfoTrans$IDevInfoTransListener", typeof (IDevInfoTransDevInfoTransListenerInvoker));

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

		public static IDevInfoTransDevInfoTransListener GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IDevInfoTransDevInfoTransListener> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.aliyun.alink.linksdk.alcs.lpbs.component.cloud.IDevInfoTrans.IDevInfoTransListener"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IDevInfoTransDevInfoTransListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_onComplete_ZLjava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetOnComplete_ZLjava_lang_Object_Handler ()
		{
			if (cb_onComplete_ZLjava_lang_Object_ == null)
				cb_onComplete_ZLjava_lang_Object_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool, IntPtr>) n_OnComplete_ZLjava_lang_Object_);
			return cb_onComplete_ZLjava_lang_Object_;
		}

		static void n_OnComplete_ZLjava_lang_Object_ (IntPtr jnienv, IntPtr native__this, bool p0, IntPtr native_p1)
		{
			global::Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Component.Cloud.IDevInfoTransDevInfoTransListener __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Component.Cloud.IDevInfoTransDevInfoTransListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object p1 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.OnComplete (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_onComplete_ZLjava_lang_Object_;
		public unsafe void OnComplete (bool p0, global::Java.Lang.Object p1)
		{
			if (id_onComplete_ZLjava_lang_Object_ == IntPtr.Zero)
				id_onComplete_ZLjava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "onComplete", "(ZLjava/lang/Object;)V");
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (p0);
			__args [1] = new JValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onComplete_ZLjava_lang_Object_, __args);
		}

	}

	// event args for com.aliyun.alink.linksdk.alcs.lpbs.component.cloud.IDevInfoTrans.IDevInfoTransListener.onComplete
	public partial class DevInfoTransDevInfoTransEventArgs : global::System.EventArgs {

		public DevInfoTransDevInfoTransEventArgs (bool p0, global::Java.Lang.Object p1)
		{
			this.p0 = p0;
			this.p1 = p1;
		}

		bool p0;
		public bool P0 {
			get { return p0; }
		}

		global::Java.Lang.Object p1;
		public global::Java.Lang.Object P1 {
			get { return p1; }
		}
	}

	[global::Android.Runtime.Register ("mono/com/aliyun/alink/linksdk/alcs/lpbs/component/cloud/IDevInfoTrans_IDevInfoTransListenerImplementor")]
	internal sealed partial class IDevInfoTransDevInfoTransListenerImplementor : global::Java.Lang.Object, IDevInfoTransDevInfoTransListener {

		object sender;

		public IDevInfoTransDevInfoTransListenerImplementor (object sender)
			: base (
				global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/com/aliyun/alink/linksdk/alcs/lpbs/component/cloud/IDevInfoTrans_IDevInfoTransListenerImplementor", "()V"),
				JniHandleOwnership.TransferLocalRef)
		{
			global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "()V");
			this.sender = sender;
		}

#pragma warning disable 0649
		public EventHandler<DevInfoTransDevInfoTransEventArgs> Handler;
#pragma warning restore 0649

		public void OnComplete (bool p0, global::Java.Lang.Object p1)
		{
			var __h = Handler;
			if (__h != null)
				__h (sender, new DevInfoTransDevInfoTransEventArgs (p0, p1));
		}

		internal static bool __IsEmpty (IDevInfoTransDevInfoTransListenerImplementor value)
		{
			return value.Handler == null;
		}
	}


	// Metadata.xml XPath interface reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.lpbs.component.cloud']/interface[@name='IDevInfoTrans']"
	[Register ("com/aliyun/alink/linksdk/alcs/lpbs/component/cloud/IDevInfoTrans", "", "Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Component.Cloud.IDevInfoTransInvoker")]
	public partial interface IDevInfoTrans : IJavaObject, IJavaPeerable {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.lpbs.component.cloud']/interface[@name='IDevInfoTrans']/method[@name='init' and count(parameter)=2 and parameter[1][@type='com.aliyun.alink.linksdk.alcs.lpbs.data.PalDiscoveryDeviceInfo'] and parameter[2][@type='com.aliyun.alink.linksdk.alcs.lpbs.component.cloud.IDevInfoTrans.IDevInfoTransListener']]"
		[Register ("init", "(Lcom/aliyun/alink/linksdk/alcs/lpbs/data/PalDiscoveryDeviceInfo;Lcom/aliyun/alink/linksdk/alcs/lpbs/component/cloud/IDevInfoTrans$IDevInfoTransListener;)V", "GetInit_Lcom_aliyun_alink_linksdk_alcs_lpbs_data_PalDiscoveryDeviceInfo_Lcom_aliyun_alink_linksdk_alcs_lpbs_component_cloud_IDevInfoTrans_IDevInfoTransListener_Handler:Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Component.Cloud.IDevInfoTransInvoker, AndroidAlcsLpbsBinding")]
		void Init (global::Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Data.PalDiscoveryDeviceInfo p0, global::Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Component.Cloud.IDevInfoTransDevInfoTransListener p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.lpbs.component.cloud']/interface[@name='IDevInfoTrans']/method[@name='toAliIoTDeviceInfo' and count(parameter)=1 and parameter[1][@type='com.aliyun.alink.linksdk.alcs.lpbs.data.PalDeviceInfo']]"
		[Register ("toAliIoTDeviceInfo", "(Lcom/aliyun/alink/linksdk/alcs/lpbs/data/PalDeviceInfo;)Lcom/aliyun/alink/linksdk/alcs/lpbs/data/PalDeviceInfo;", "GetToAliIoTDeviceInfo_Lcom_aliyun_alink_linksdk_alcs_lpbs_data_PalDeviceInfo_Handler:Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Component.Cloud.IDevInfoTransInvoker, AndroidAlcsLpbsBinding")]
		global::Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Data.PalDeviceInfo ToAliIoTDeviceInfo (global::Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Data.PalDeviceInfo p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.lpbs.component.cloud']/interface[@name='IDevInfoTrans']/method[@name='toPrivateDeviceInfo' and count(parameter)=1 and parameter[1][@type='com.aliyun.alink.linksdk.alcs.lpbs.data.PalDeviceInfo']]"
		[Register ("toPrivateDeviceInfo", "(Lcom/aliyun/alink/linksdk/alcs/lpbs/data/PalDeviceInfo;)Lcom/aliyun/alink/linksdk/alcs/lpbs/data/PalDeviceInfo;", "GetToPrivateDeviceInfo_Lcom_aliyun_alink_linksdk_alcs_lpbs_data_PalDeviceInfo_Handler:Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Component.Cloud.IDevInfoTransInvoker, AndroidAlcsLpbsBinding")]
		global::Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Data.PalDeviceInfo ToPrivateDeviceInfo (global::Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Data.PalDeviceInfo p0);

	}

	[global::Android.Runtime.Register ("com/aliyun/alink/linksdk/alcs/lpbs/component/cloud/IDevInfoTrans", DoNotGenerateAcw=true)]
	internal partial class IDevInfoTransInvoker : global::Java.Lang.Object, IDevInfoTrans {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/aliyun/alink/linksdk/alcs/lpbs/component/cloud/IDevInfoTrans", typeof (IDevInfoTransInvoker));

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

		public static IDevInfoTrans GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IDevInfoTrans> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.aliyun.alink.linksdk.alcs.lpbs.component.cloud.IDevInfoTrans"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IDevInfoTransInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_init_Lcom_aliyun_alink_linksdk_alcs_lpbs_data_PalDiscoveryDeviceInfo_Lcom_aliyun_alink_linksdk_alcs_lpbs_component_cloud_IDevInfoTrans_IDevInfoTransListener_;
#pragma warning disable 0169
		static Delegate GetInit_Lcom_aliyun_alink_linksdk_alcs_lpbs_data_PalDiscoveryDeviceInfo_Lcom_aliyun_alink_linksdk_alcs_lpbs_component_cloud_IDevInfoTrans_IDevInfoTransListener_Handler ()
		{
			if (cb_init_Lcom_aliyun_alink_linksdk_alcs_lpbs_data_PalDiscoveryDeviceInfo_Lcom_aliyun_alink_linksdk_alcs_lpbs_component_cloud_IDevInfoTrans_IDevInfoTransListener_ == null)
				cb_init_Lcom_aliyun_alink_linksdk_alcs_lpbs_data_PalDiscoveryDeviceInfo_Lcom_aliyun_alink_linksdk_alcs_lpbs_component_cloud_IDevInfoTrans_IDevInfoTransListener_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_Init_Lcom_aliyun_alink_linksdk_alcs_lpbs_data_PalDiscoveryDeviceInfo_Lcom_aliyun_alink_linksdk_alcs_lpbs_component_cloud_IDevInfoTrans_IDevInfoTransListener_);
			return cb_init_Lcom_aliyun_alink_linksdk_alcs_lpbs_data_PalDiscoveryDeviceInfo_Lcom_aliyun_alink_linksdk_alcs_lpbs_component_cloud_IDevInfoTrans_IDevInfoTransListener_;
		}

		static void n_Init_Lcom_aliyun_alink_linksdk_alcs_lpbs_data_PalDiscoveryDeviceInfo_Lcom_aliyun_alink_linksdk_alcs_lpbs_component_cloud_IDevInfoTrans_IDevInfoTransListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Component.Cloud.IDevInfoTrans __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Component.Cloud.IDevInfoTrans> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Data.PalDiscoveryDeviceInfo p0 = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Data.PalDiscoveryDeviceInfo> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Component.Cloud.IDevInfoTransDevInfoTransListener p1 = (global::Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Component.Cloud.IDevInfoTransDevInfoTransListener)global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Component.Cloud.IDevInfoTransDevInfoTransListener> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.Init (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_init_Lcom_aliyun_alink_linksdk_alcs_lpbs_data_PalDiscoveryDeviceInfo_Lcom_aliyun_alink_linksdk_alcs_lpbs_component_cloud_IDevInfoTrans_IDevInfoTransListener_;
		public unsafe void Init (global::Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Data.PalDiscoveryDeviceInfo p0, global::Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Component.Cloud.IDevInfoTransDevInfoTransListener p1)
		{
			if (id_init_Lcom_aliyun_alink_linksdk_alcs_lpbs_data_PalDiscoveryDeviceInfo_Lcom_aliyun_alink_linksdk_alcs_lpbs_component_cloud_IDevInfoTrans_IDevInfoTransListener_ == IntPtr.Zero)
				id_init_Lcom_aliyun_alink_linksdk_alcs_lpbs_data_PalDiscoveryDeviceInfo_Lcom_aliyun_alink_linksdk_alcs_lpbs_component_cloud_IDevInfoTrans_IDevInfoTransListener_ = JNIEnv.GetMethodID (class_ref, "init", "(Lcom/aliyun/alink/linksdk/alcs/lpbs/data/PalDiscoveryDeviceInfo;Lcom/aliyun/alink/linksdk/alcs/lpbs/component/cloud/IDevInfoTrans$IDevInfoTransListener;)V");
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			__args [1] = new JValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_init_Lcom_aliyun_alink_linksdk_alcs_lpbs_data_PalDiscoveryDeviceInfo_Lcom_aliyun_alink_linksdk_alcs_lpbs_component_cloud_IDevInfoTrans_IDevInfoTransListener_, __args);
		}

		static Delegate cb_toAliIoTDeviceInfo_Lcom_aliyun_alink_linksdk_alcs_lpbs_data_PalDeviceInfo_;
#pragma warning disable 0169
		static Delegate GetToAliIoTDeviceInfo_Lcom_aliyun_alink_linksdk_alcs_lpbs_data_PalDeviceInfo_Handler ()
		{
			if (cb_toAliIoTDeviceInfo_Lcom_aliyun_alink_linksdk_alcs_lpbs_data_PalDeviceInfo_ == null)
				cb_toAliIoTDeviceInfo_Lcom_aliyun_alink_linksdk_alcs_lpbs_data_PalDeviceInfo_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_ToAliIoTDeviceInfo_Lcom_aliyun_alink_linksdk_alcs_lpbs_data_PalDeviceInfo_);
			return cb_toAliIoTDeviceInfo_Lcom_aliyun_alink_linksdk_alcs_lpbs_data_PalDeviceInfo_;
		}

		static IntPtr n_ToAliIoTDeviceInfo_Lcom_aliyun_alink_linksdk_alcs_lpbs_data_PalDeviceInfo_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Component.Cloud.IDevInfoTrans __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Component.Cloud.IDevInfoTrans> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Data.PalDeviceInfo p0 = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Data.PalDeviceInfo> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.ToAliIoTDeviceInfo (p0));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_toAliIoTDeviceInfo_Lcom_aliyun_alink_linksdk_alcs_lpbs_data_PalDeviceInfo_;
		public unsafe global::Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Data.PalDeviceInfo ToAliIoTDeviceInfo (global::Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Data.PalDeviceInfo p0)
		{
			if (id_toAliIoTDeviceInfo_Lcom_aliyun_alink_linksdk_alcs_lpbs_data_PalDeviceInfo_ == IntPtr.Zero)
				id_toAliIoTDeviceInfo_Lcom_aliyun_alink_linksdk_alcs_lpbs_data_PalDeviceInfo_ = JNIEnv.GetMethodID (class_ref, "toAliIoTDeviceInfo", "(Lcom/aliyun/alink/linksdk/alcs/lpbs/data/PalDeviceInfo;)Lcom/aliyun/alink/linksdk/alcs/lpbs/data/PalDeviceInfo;");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			global::Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Data.PalDeviceInfo __ret = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Data.PalDeviceInfo> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_toAliIoTDeviceInfo_Lcom_aliyun_alink_linksdk_alcs_lpbs_data_PalDeviceInfo_, __args), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static Delegate cb_toPrivateDeviceInfo_Lcom_aliyun_alink_linksdk_alcs_lpbs_data_PalDeviceInfo_;
#pragma warning disable 0169
		static Delegate GetToPrivateDeviceInfo_Lcom_aliyun_alink_linksdk_alcs_lpbs_data_PalDeviceInfo_Handler ()
		{
			if (cb_toPrivateDeviceInfo_Lcom_aliyun_alink_linksdk_alcs_lpbs_data_PalDeviceInfo_ == null)
				cb_toPrivateDeviceInfo_Lcom_aliyun_alink_linksdk_alcs_lpbs_data_PalDeviceInfo_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_ToPrivateDeviceInfo_Lcom_aliyun_alink_linksdk_alcs_lpbs_data_PalDeviceInfo_);
			return cb_toPrivateDeviceInfo_Lcom_aliyun_alink_linksdk_alcs_lpbs_data_PalDeviceInfo_;
		}

		static IntPtr n_ToPrivateDeviceInfo_Lcom_aliyun_alink_linksdk_alcs_lpbs_data_PalDeviceInfo_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Component.Cloud.IDevInfoTrans __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Component.Cloud.IDevInfoTrans> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Data.PalDeviceInfo p0 = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Data.PalDeviceInfo> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.ToPrivateDeviceInfo (p0));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_toPrivateDeviceInfo_Lcom_aliyun_alink_linksdk_alcs_lpbs_data_PalDeviceInfo_;
		public unsafe global::Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Data.PalDeviceInfo ToPrivateDeviceInfo (global::Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Data.PalDeviceInfo p0)
		{
			if (id_toPrivateDeviceInfo_Lcom_aliyun_alink_linksdk_alcs_lpbs_data_PalDeviceInfo_ == IntPtr.Zero)
				id_toPrivateDeviceInfo_Lcom_aliyun_alink_linksdk_alcs_lpbs_data_PalDeviceInfo_ = JNIEnv.GetMethodID (class_ref, "toPrivateDeviceInfo", "(Lcom/aliyun/alink/linksdk/alcs/lpbs/data/PalDeviceInfo;)Lcom/aliyun/alink/linksdk/alcs/lpbs/data/PalDeviceInfo;");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			global::Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Data.PalDeviceInfo __ret = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Data.PalDeviceInfo> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_toPrivateDeviceInfo_Lcom_aliyun_alink_linksdk_alcs_lpbs_data_PalDeviceInfo_, __args), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

	}

}
