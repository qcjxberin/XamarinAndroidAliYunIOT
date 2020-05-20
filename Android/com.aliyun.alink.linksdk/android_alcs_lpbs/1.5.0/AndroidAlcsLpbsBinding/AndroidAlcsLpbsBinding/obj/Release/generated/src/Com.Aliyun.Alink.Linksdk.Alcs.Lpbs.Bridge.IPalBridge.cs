using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Bridge {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.lpbs.bridge']/interface[@name='IPalBridge']"
	[Register ("com/aliyun/alink/linksdk/alcs/lpbs/bridge/IPalBridge", "", "Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Bridge.IPalBridgeInvoker")]
	public partial interface IPalBridge : IJavaObject, IJavaPeerable {

		global::Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Bridge.IPalAuthRegister PalAuthRegister {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.lpbs.bridge']/interface[@name='IPalBridge']/method[@name='getPalAuthRegister' and count(parameter)=0]"
			[Register ("getPalAuthRegister", "()Lcom/aliyun/alink/linksdk/alcs/lpbs/bridge/IPalAuthRegister;", "GetGetPalAuthRegisterHandler:Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Bridge.IPalBridgeInvoker, AndroidAlcsLpbsBinding")] get;
		}

		global::Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Bridge.IPalDiscovery PalDiscovery {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.lpbs.bridge']/interface[@name='IPalBridge']/method[@name='getPalDiscovery' and count(parameter)=0]"
			[Register ("getPalDiscovery", "()Lcom/aliyun/alink/linksdk/alcs/lpbs/bridge/IPalDiscovery;", "GetGetPalDiscoveryHandler:Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Bridge.IPalBridgeInvoker, AndroidAlcsLpbsBinding")] get;
		}

		global::Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Bridge.IPalProbe PalProbe {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.lpbs.bridge']/interface[@name='IPalBridge']/method[@name='getPalProbe' and count(parameter)=0]"
			[Register ("getPalProbe", "()Lcom/aliyun/alink/linksdk/alcs/lpbs/bridge/IPalProbe;", "GetGetPalProbeHandler:Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Bridge.IPalBridgeInvoker, AndroidAlcsLpbsBinding")] get;
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.lpbs.bridge']/interface[@name='IPalBridge']/method[@name='deInitBridge' and count(parameter)=0]"
		[Register ("deInitBridge", "()V", "GetDeInitBridgeHandler:Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Bridge.IPalBridgeInvoker, AndroidAlcsLpbsBinding")]
		void DeInitBridge ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.lpbs.bridge']/interface[@name='IPalBridge']/method[@name='getGroupConnect' and count(parameter)=1 and parameter[1][@type='com.aliyun.alink.linksdk.alcs.lpbs.data.group.PalGroupInfo']]"
		[Register ("getGroupConnect", "(Lcom/aliyun/alink/linksdk/alcs/lpbs/data/group/PalGroupInfo;)Lcom/aliyun/alink/linksdk/alcs/lpbs/bridge/IPalGroupConnect;", "GetGetGroupConnect_Lcom_aliyun_alink_linksdk_alcs_lpbs_data_group_PalGroupInfo_Handler:Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Bridge.IPalBridgeInvoker, AndroidAlcsLpbsBinding")]
		global::Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Bridge.IPalGroupConnect GetGroupConnect (global::Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Data.Group.PalGroupInfo p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.lpbs.bridge']/interface[@name='IPalBridge']/method[@name='getPalConnect' and count(parameter)=1 and parameter[1][@type='com.aliyun.alink.linksdk.alcs.lpbs.data.PalDeviceInfo']]"
		[Register ("getPalConnect", "(Lcom/aliyun/alink/linksdk/alcs/lpbs/data/PalDeviceInfo;)Lcom/aliyun/alink/linksdk/alcs/lpbs/bridge/IPalConnect;", "GetGetPalConnect_Lcom_aliyun_alink_linksdk_alcs_lpbs_data_PalDeviceInfo_Handler:Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Bridge.IPalBridgeInvoker, AndroidAlcsLpbsBinding")]
		global::Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Bridge.IPalConnect GetPalConnect (global::Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Data.PalDeviceInfo p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.lpbs.bridge']/interface[@name='IPalBridge']/method[@name='initBridge' and count(parameter)=1 and parameter[1][@type='com.aliyun.alink.linksdk.alcs.lpbs.data.PalInitData']]"
		[Register ("initBridge", "(Lcom/aliyun/alink/linksdk/alcs/lpbs/data/PalInitData;)V", "GetInitBridge_Lcom_aliyun_alink_linksdk_alcs_lpbs_data_PalInitData_Handler:Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Bridge.IPalBridgeInvoker, AndroidAlcsLpbsBinding")]
		void InitBridge (global::Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Data.PalInitData p0);

	}

	[global::Android.Runtime.Register ("com/aliyun/alink/linksdk/alcs/lpbs/bridge/IPalBridge", DoNotGenerateAcw=true)]
	internal partial class IPalBridgeInvoker : global::Java.Lang.Object, IPalBridge {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/aliyun/alink/linksdk/alcs/lpbs/bridge/IPalBridge", typeof (IPalBridgeInvoker));

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

		public static IPalBridge GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IPalBridge> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.aliyun.alink.linksdk.alcs.lpbs.bridge.IPalBridge"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IPalBridgeInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_getPalAuthRegister;
#pragma warning disable 0169
		static Delegate GetGetPalAuthRegisterHandler ()
		{
			if (cb_getPalAuthRegister == null)
				cb_getPalAuthRegister = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetPalAuthRegister);
			return cb_getPalAuthRegister;
		}

		static IntPtr n_GetPalAuthRegister (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Bridge.IPalBridge __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Bridge.IPalBridge> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.PalAuthRegister);
		}
#pragma warning restore 0169

		IntPtr id_getPalAuthRegister;
		public unsafe global::Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Bridge.IPalAuthRegister PalAuthRegister {
			get {
				if (id_getPalAuthRegister == IntPtr.Zero)
					id_getPalAuthRegister = JNIEnv.GetMethodID (class_ref, "getPalAuthRegister", "()Lcom/aliyun/alink/linksdk/alcs/lpbs/bridge/IPalAuthRegister;");
				return global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Bridge.IPalAuthRegister> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getPalAuthRegister), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getPalDiscovery;
#pragma warning disable 0169
		static Delegate GetGetPalDiscoveryHandler ()
		{
			if (cb_getPalDiscovery == null)
				cb_getPalDiscovery = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetPalDiscovery);
			return cb_getPalDiscovery;
		}

		static IntPtr n_GetPalDiscovery (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Bridge.IPalBridge __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Bridge.IPalBridge> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.PalDiscovery);
		}
#pragma warning restore 0169

		IntPtr id_getPalDiscovery;
		public unsafe global::Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Bridge.IPalDiscovery PalDiscovery {
			get {
				if (id_getPalDiscovery == IntPtr.Zero)
					id_getPalDiscovery = JNIEnv.GetMethodID (class_ref, "getPalDiscovery", "()Lcom/aliyun/alink/linksdk/alcs/lpbs/bridge/IPalDiscovery;");
				return global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Bridge.IPalDiscovery> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getPalDiscovery), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getPalProbe;
#pragma warning disable 0169
		static Delegate GetGetPalProbeHandler ()
		{
			if (cb_getPalProbe == null)
				cb_getPalProbe = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetPalProbe);
			return cb_getPalProbe;
		}

		static IntPtr n_GetPalProbe (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Bridge.IPalBridge __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Bridge.IPalBridge> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.PalProbe);
		}
#pragma warning restore 0169

		IntPtr id_getPalProbe;
		public unsafe global::Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Bridge.IPalProbe PalProbe {
			get {
				if (id_getPalProbe == IntPtr.Zero)
					id_getPalProbe = JNIEnv.GetMethodID (class_ref, "getPalProbe", "()Lcom/aliyun/alink/linksdk/alcs/lpbs/bridge/IPalProbe;");
				return global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Bridge.IPalProbe> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getPalProbe), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_deInitBridge;
#pragma warning disable 0169
		static Delegate GetDeInitBridgeHandler ()
		{
			if (cb_deInitBridge == null)
				cb_deInitBridge = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_DeInitBridge);
			return cb_deInitBridge;
		}

		static void n_DeInitBridge (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Bridge.IPalBridge __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Bridge.IPalBridge> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.DeInitBridge ();
		}
#pragma warning restore 0169

		IntPtr id_deInitBridge;
		public unsafe void DeInitBridge ()
		{
			if (id_deInitBridge == IntPtr.Zero)
				id_deInitBridge = JNIEnv.GetMethodID (class_ref, "deInitBridge", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_deInitBridge);
		}

		static Delegate cb_getGroupConnect_Lcom_aliyun_alink_linksdk_alcs_lpbs_data_group_PalGroupInfo_;
#pragma warning disable 0169
		static Delegate GetGetGroupConnect_Lcom_aliyun_alink_linksdk_alcs_lpbs_data_group_PalGroupInfo_Handler ()
		{
			if (cb_getGroupConnect_Lcom_aliyun_alink_linksdk_alcs_lpbs_data_group_PalGroupInfo_ == null)
				cb_getGroupConnect_Lcom_aliyun_alink_linksdk_alcs_lpbs_data_group_PalGroupInfo_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_GetGroupConnect_Lcom_aliyun_alink_linksdk_alcs_lpbs_data_group_PalGroupInfo_);
			return cb_getGroupConnect_Lcom_aliyun_alink_linksdk_alcs_lpbs_data_group_PalGroupInfo_;
		}

		static IntPtr n_GetGroupConnect_Lcom_aliyun_alink_linksdk_alcs_lpbs_data_group_PalGroupInfo_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Bridge.IPalBridge __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Bridge.IPalBridge> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Data.Group.PalGroupInfo p0 = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Data.Group.PalGroupInfo> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetGroupConnect (p0));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_getGroupConnect_Lcom_aliyun_alink_linksdk_alcs_lpbs_data_group_PalGroupInfo_;
		public unsafe global::Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Bridge.IPalGroupConnect GetGroupConnect (global::Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Data.Group.PalGroupInfo p0)
		{
			if (id_getGroupConnect_Lcom_aliyun_alink_linksdk_alcs_lpbs_data_group_PalGroupInfo_ == IntPtr.Zero)
				id_getGroupConnect_Lcom_aliyun_alink_linksdk_alcs_lpbs_data_group_PalGroupInfo_ = JNIEnv.GetMethodID (class_ref, "getGroupConnect", "(Lcom/aliyun/alink/linksdk/alcs/lpbs/data/group/PalGroupInfo;)Lcom/aliyun/alink/linksdk/alcs/lpbs/bridge/IPalGroupConnect;");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			global::Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Bridge.IPalGroupConnect __ret = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Bridge.IPalGroupConnect> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getGroupConnect_Lcom_aliyun_alink_linksdk_alcs_lpbs_data_group_PalGroupInfo_, __args), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static Delegate cb_getPalConnect_Lcom_aliyun_alink_linksdk_alcs_lpbs_data_PalDeviceInfo_;
#pragma warning disable 0169
		static Delegate GetGetPalConnect_Lcom_aliyun_alink_linksdk_alcs_lpbs_data_PalDeviceInfo_Handler ()
		{
			if (cb_getPalConnect_Lcom_aliyun_alink_linksdk_alcs_lpbs_data_PalDeviceInfo_ == null)
				cb_getPalConnect_Lcom_aliyun_alink_linksdk_alcs_lpbs_data_PalDeviceInfo_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_GetPalConnect_Lcom_aliyun_alink_linksdk_alcs_lpbs_data_PalDeviceInfo_);
			return cb_getPalConnect_Lcom_aliyun_alink_linksdk_alcs_lpbs_data_PalDeviceInfo_;
		}

		static IntPtr n_GetPalConnect_Lcom_aliyun_alink_linksdk_alcs_lpbs_data_PalDeviceInfo_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Bridge.IPalBridge __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Bridge.IPalBridge> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Data.PalDeviceInfo p0 = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Data.PalDeviceInfo> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetPalConnect (p0));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_getPalConnect_Lcom_aliyun_alink_linksdk_alcs_lpbs_data_PalDeviceInfo_;
		public unsafe global::Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Bridge.IPalConnect GetPalConnect (global::Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Data.PalDeviceInfo p0)
		{
			if (id_getPalConnect_Lcom_aliyun_alink_linksdk_alcs_lpbs_data_PalDeviceInfo_ == IntPtr.Zero)
				id_getPalConnect_Lcom_aliyun_alink_linksdk_alcs_lpbs_data_PalDeviceInfo_ = JNIEnv.GetMethodID (class_ref, "getPalConnect", "(Lcom/aliyun/alink/linksdk/alcs/lpbs/data/PalDeviceInfo;)Lcom/aliyun/alink/linksdk/alcs/lpbs/bridge/IPalConnect;");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			global::Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Bridge.IPalConnect __ret = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Bridge.IPalConnect> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getPalConnect_Lcom_aliyun_alink_linksdk_alcs_lpbs_data_PalDeviceInfo_, __args), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static Delegate cb_initBridge_Lcom_aliyun_alink_linksdk_alcs_lpbs_data_PalInitData_;
#pragma warning disable 0169
		static Delegate GetInitBridge_Lcom_aliyun_alink_linksdk_alcs_lpbs_data_PalInitData_Handler ()
		{
			if (cb_initBridge_Lcom_aliyun_alink_linksdk_alcs_lpbs_data_PalInitData_ == null)
				cb_initBridge_Lcom_aliyun_alink_linksdk_alcs_lpbs_data_PalInitData_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_InitBridge_Lcom_aliyun_alink_linksdk_alcs_lpbs_data_PalInitData_);
			return cb_initBridge_Lcom_aliyun_alink_linksdk_alcs_lpbs_data_PalInitData_;
		}

		static void n_InitBridge_Lcom_aliyun_alink_linksdk_alcs_lpbs_data_PalInitData_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Bridge.IPalBridge __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Bridge.IPalBridge> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Data.PalInitData p0 = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Data.PalInitData> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.InitBridge (p0);
		}
#pragma warning restore 0169

		IntPtr id_initBridge_Lcom_aliyun_alink_linksdk_alcs_lpbs_data_PalInitData_;
		public unsafe void InitBridge (global::Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Data.PalInitData p0)
		{
			if (id_initBridge_Lcom_aliyun_alink_linksdk_alcs_lpbs_data_PalInitData_ == IntPtr.Zero)
				id_initBridge_Lcom_aliyun_alink_linksdk_alcs_lpbs_data_PalInitData_ = JNIEnv.GetMethodID (class_ref, "initBridge", "(Lcom/aliyun/alink/linksdk/alcs/lpbs/data/PalInitData;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_initBridge_Lcom_aliyun_alink_linksdk_alcs_lpbs_data_PalInitData_, __args);
		}

	}

}
