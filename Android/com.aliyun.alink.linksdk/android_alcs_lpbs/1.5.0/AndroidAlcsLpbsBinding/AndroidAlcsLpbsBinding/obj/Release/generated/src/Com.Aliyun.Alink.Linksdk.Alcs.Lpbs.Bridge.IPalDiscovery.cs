using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Bridge {

	[Register ("com/aliyun/alink/linksdk/alcs/lpbs/bridge/IPalDiscovery", DoNotGenerateAcw=true)]
	public abstract class PalDiscovery : Java.Lang.Object {

		internal PalDiscovery ()
		{
		}

		// Metadata.xml XPath field reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.lpbs.bridge']/interface[@name='IPalDiscovery']/field[@name='DISCOVERY_TYPE_FINISH']"
		[Register ("DISCOVERY_TYPE_FINISH")]
		public const int DiscoveryTypeFinish = (int) 0;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.lpbs.bridge']/interface[@name='IPalDiscovery']/field[@name='DISCOVERY_TYPE_FOUND']"
		[Register ("DISCOVERY_TYPE_FOUND")]
		public const int DiscoveryTypeFound = (int) 1;
	}

	[Register ("com/aliyun/alink/linksdk/alcs/lpbs/bridge/IPalDiscovery", DoNotGenerateAcw=true)]
	[global::System.Obsolete ("Use the 'PalDiscovery' type. This type will be removed in a future release.", error: true)]
	public abstract class PalDiscoveryConsts : PalDiscovery {

		private PalDiscoveryConsts ()
		{
		}
	}

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.lpbs.bridge']/interface[@name='IPalDiscovery']"
	[Register ("com/aliyun/alink/linksdk/alcs/lpbs/bridge/IPalDiscovery", "", "Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Bridge.IPalDiscoveryInvoker")]
	public partial interface IPalDiscovery : IJavaObject, IJavaPeerable {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.lpbs.bridge']/interface[@name='IPalDiscovery']/method[@name='startDiscovery' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='com.aliyun.alink.linksdk.alcs.lpbs.data.PalDiscoveryConfig'] and parameter[3][@type='com.aliyun.alink.linksdk.alcs.lpbs.listener.PalDiscoveryListener']]"
		[Register ("startDiscovery", "(ILcom/aliyun/alink/linksdk/alcs/lpbs/data/PalDiscoveryConfig;Lcom/aliyun/alink/linksdk/alcs/lpbs/listener/PalDiscoveryListener;)Z", "GetStartDiscovery_ILcom_aliyun_alink_linksdk_alcs_lpbs_data_PalDiscoveryConfig_Lcom_aliyun_alink_linksdk_alcs_lpbs_listener_PalDiscoveryListener_Handler:Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Bridge.IPalDiscoveryInvoker, AndroidAlcsLpbsBinding")]
		bool StartDiscovery (int p0, global::Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Data.PalDiscoveryConfig p1, global::Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Listener.IPalDiscoveryListener p2);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.lpbs.bridge']/interface[@name='IPalDiscovery']/method[@name='startDiscovery' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='com.aliyun.alink.linksdk.alcs.lpbs.listener.PalDiscoveryListener']]"
		[Register ("startDiscovery", "(ILcom/aliyun/alink/linksdk/alcs/lpbs/listener/PalDiscoveryListener;)Z", "GetStartDiscovery_ILcom_aliyun_alink_linksdk_alcs_lpbs_listener_PalDiscoveryListener_Handler:Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Bridge.IPalDiscoveryInvoker, AndroidAlcsLpbsBinding")]
		bool StartDiscovery (int p0, global::Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Listener.IPalDiscoveryListener p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.lpbs.bridge']/interface[@name='IPalDiscovery']/method[@name='startNotifyMonitor' and count(parameter)=1 and parameter[1][@type='com.aliyun.alink.linksdk.alcs.lpbs.listener.PalDiscoveryListener']]"
		[Register ("startNotifyMonitor", "(Lcom/aliyun/alink/linksdk/alcs/lpbs/listener/PalDiscoveryListener;)Z", "GetStartNotifyMonitor_Lcom_aliyun_alink_linksdk_alcs_lpbs_listener_PalDiscoveryListener_Handler:Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Bridge.IPalDiscoveryInvoker, AndroidAlcsLpbsBinding")]
		bool StartNotifyMonitor (global::Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Listener.IPalDiscoveryListener p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.lpbs.bridge']/interface[@name='IPalDiscovery']/method[@name='stopDiscovery' and count(parameter)=0]"
		[Register ("stopDiscovery", "()Z", "GetStopDiscoveryHandler:Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Bridge.IPalDiscoveryInvoker, AndroidAlcsLpbsBinding")]
		bool StopDiscovery ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.lpbs.bridge']/interface[@name='IPalDiscovery']/method[@name='stopNotifyMonitor' and count(parameter)=0]"
		[Register ("stopNotifyMonitor", "()Z", "GetStopNotifyMonitorHandler:Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Bridge.IPalDiscoveryInvoker, AndroidAlcsLpbsBinding")]
		bool StopNotifyMonitor ();

	}

	[global::Android.Runtime.Register ("com/aliyun/alink/linksdk/alcs/lpbs/bridge/IPalDiscovery", DoNotGenerateAcw=true)]
	internal partial class IPalDiscoveryInvoker : global::Java.Lang.Object, IPalDiscovery {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/aliyun/alink/linksdk/alcs/lpbs/bridge/IPalDiscovery", typeof (IPalDiscoveryInvoker));

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

		public static IPalDiscovery GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IPalDiscovery> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.aliyun.alink.linksdk.alcs.lpbs.bridge.IPalDiscovery"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IPalDiscoveryInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_startDiscovery_ILcom_aliyun_alink_linksdk_alcs_lpbs_data_PalDiscoveryConfig_Lcom_aliyun_alink_linksdk_alcs_lpbs_listener_PalDiscoveryListener_;
#pragma warning disable 0169
		static Delegate GetStartDiscovery_ILcom_aliyun_alink_linksdk_alcs_lpbs_data_PalDiscoveryConfig_Lcom_aliyun_alink_linksdk_alcs_lpbs_listener_PalDiscoveryListener_Handler ()
		{
			if (cb_startDiscovery_ILcom_aliyun_alink_linksdk_alcs_lpbs_data_PalDiscoveryConfig_Lcom_aliyun_alink_linksdk_alcs_lpbs_listener_PalDiscoveryListener_ == null)
				cb_startDiscovery_ILcom_aliyun_alink_linksdk_alcs_lpbs_data_PalDiscoveryConfig_Lcom_aliyun_alink_linksdk_alcs_lpbs_listener_PalDiscoveryListener_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr, IntPtr, bool>) n_StartDiscovery_ILcom_aliyun_alink_linksdk_alcs_lpbs_data_PalDiscoveryConfig_Lcom_aliyun_alink_linksdk_alcs_lpbs_listener_PalDiscoveryListener_);
			return cb_startDiscovery_ILcom_aliyun_alink_linksdk_alcs_lpbs_data_PalDiscoveryConfig_Lcom_aliyun_alink_linksdk_alcs_lpbs_listener_PalDiscoveryListener_;
		}

		static bool n_StartDiscovery_ILcom_aliyun_alink_linksdk_alcs_lpbs_data_PalDiscoveryConfig_Lcom_aliyun_alink_linksdk_alcs_lpbs_listener_PalDiscoveryListener_ (IntPtr jnienv, IntPtr native__this, int p0, IntPtr native_p1, IntPtr native_p2)
		{
			global::Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Bridge.IPalDiscovery __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Bridge.IPalDiscovery> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Data.PalDiscoveryConfig p1 = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Data.PalDiscoveryConfig> (native_p1, JniHandleOwnership.DoNotTransfer);
			global::Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Listener.IPalDiscoveryListener p2 = (global::Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Listener.IPalDiscoveryListener)global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Listener.IPalDiscoveryListener> (native_p2, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.StartDiscovery (p0, p1, p2);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_startDiscovery_ILcom_aliyun_alink_linksdk_alcs_lpbs_data_PalDiscoveryConfig_Lcom_aliyun_alink_linksdk_alcs_lpbs_listener_PalDiscoveryListener_;
		public unsafe bool StartDiscovery (int p0, global::Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Data.PalDiscoveryConfig p1, global::Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Listener.IPalDiscoveryListener p2)
		{
			if (id_startDiscovery_ILcom_aliyun_alink_linksdk_alcs_lpbs_data_PalDiscoveryConfig_Lcom_aliyun_alink_linksdk_alcs_lpbs_listener_PalDiscoveryListener_ == IntPtr.Zero)
				id_startDiscovery_ILcom_aliyun_alink_linksdk_alcs_lpbs_data_PalDiscoveryConfig_Lcom_aliyun_alink_linksdk_alcs_lpbs_listener_PalDiscoveryListener_ = JNIEnv.GetMethodID (class_ref, "startDiscovery", "(ILcom/aliyun/alink/linksdk/alcs/lpbs/data/PalDiscoveryConfig;Lcom/aliyun/alink/linksdk/alcs/lpbs/listener/PalDiscoveryListener;)Z");
			JValue* __args = stackalloc JValue [3];
			__args [0] = new JValue (p0);
			__args [1] = new JValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
			__args [2] = new JValue ((p2 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p2).Handle);
			bool __ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_startDiscovery_ILcom_aliyun_alink_linksdk_alcs_lpbs_data_PalDiscoveryConfig_Lcom_aliyun_alink_linksdk_alcs_lpbs_listener_PalDiscoveryListener_, __args);
			return __ret;
		}

		static Delegate cb_startDiscovery_ILcom_aliyun_alink_linksdk_alcs_lpbs_listener_PalDiscoveryListener_;
#pragma warning disable 0169
		static Delegate GetStartDiscovery_ILcom_aliyun_alink_linksdk_alcs_lpbs_listener_PalDiscoveryListener_Handler ()
		{
			if (cb_startDiscovery_ILcom_aliyun_alink_linksdk_alcs_lpbs_listener_PalDiscoveryListener_ == null)
				cb_startDiscovery_ILcom_aliyun_alink_linksdk_alcs_lpbs_listener_PalDiscoveryListener_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr, bool>) n_StartDiscovery_ILcom_aliyun_alink_linksdk_alcs_lpbs_listener_PalDiscoveryListener_);
			return cb_startDiscovery_ILcom_aliyun_alink_linksdk_alcs_lpbs_listener_PalDiscoveryListener_;
		}

		static bool n_StartDiscovery_ILcom_aliyun_alink_linksdk_alcs_lpbs_listener_PalDiscoveryListener_ (IntPtr jnienv, IntPtr native__this, int p0, IntPtr native_p1)
		{
			global::Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Bridge.IPalDiscovery __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Bridge.IPalDiscovery> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Listener.IPalDiscoveryListener p1 = (global::Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Listener.IPalDiscoveryListener)global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Listener.IPalDiscoveryListener> (native_p1, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.StartDiscovery (p0, p1);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_startDiscovery_ILcom_aliyun_alink_linksdk_alcs_lpbs_listener_PalDiscoveryListener_;
		public unsafe bool StartDiscovery (int p0, global::Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Listener.IPalDiscoveryListener p1)
		{
			if (id_startDiscovery_ILcom_aliyun_alink_linksdk_alcs_lpbs_listener_PalDiscoveryListener_ == IntPtr.Zero)
				id_startDiscovery_ILcom_aliyun_alink_linksdk_alcs_lpbs_listener_PalDiscoveryListener_ = JNIEnv.GetMethodID (class_ref, "startDiscovery", "(ILcom/aliyun/alink/linksdk/alcs/lpbs/listener/PalDiscoveryListener;)Z");
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (p0);
			__args [1] = new JValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
			bool __ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_startDiscovery_ILcom_aliyun_alink_linksdk_alcs_lpbs_listener_PalDiscoveryListener_, __args);
			return __ret;
		}

		static Delegate cb_startNotifyMonitor_Lcom_aliyun_alink_linksdk_alcs_lpbs_listener_PalDiscoveryListener_;
#pragma warning disable 0169
		static Delegate GetStartNotifyMonitor_Lcom_aliyun_alink_linksdk_alcs_lpbs_listener_PalDiscoveryListener_Handler ()
		{
			if (cb_startNotifyMonitor_Lcom_aliyun_alink_linksdk_alcs_lpbs_listener_PalDiscoveryListener_ == null)
				cb_startNotifyMonitor_Lcom_aliyun_alink_linksdk_alcs_lpbs_listener_PalDiscoveryListener_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_StartNotifyMonitor_Lcom_aliyun_alink_linksdk_alcs_lpbs_listener_PalDiscoveryListener_);
			return cb_startNotifyMonitor_Lcom_aliyun_alink_linksdk_alcs_lpbs_listener_PalDiscoveryListener_;
		}

		static bool n_StartNotifyMonitor_Lcom_aliyun_alink_linksdk_alcs_lpbs_listener_PalDiscoveryListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Bridge.IPalDiscovery __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Bridge.IPalDiscovery> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Listener.IPalDiscoveryListener p0 = (global::Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Listener.IPalDiscoveryListener)global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Listener.IPalDiscoveryListener> (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.StartNotifyMonitor (p0);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_startNotifyMonitor_Lcom_aliyun_alink_linksdk_alcs_lpbs_listener_PalDiscoveryListener_;
		public unsafe bool StartNotifyMonitor (global::Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Listener.IPalDiscoveryListener p0)
		{
			if (id_startNotifyMonitor_Lcom_aliyun_alink_linksdk_alcs_lpbs_listener_PalDiscoveryListener_ == IntPtr.Zero)
				id_startNotifyMonitor_Lcom_aliyun_alink_linksdk_alcs_lpbs_listener_PalDiscoveryListener_ = JNIEnv.GetMethodID (class_ref, "startNotifyMonitor", "(Lcom/aliyun/alink/linksdk/alcs/lpbs/listener/PalDiscoveryListener;)Z");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			bool __ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_startNotifyMonitor_Lcom_aliyun_alink_linksdk_alcs_lpbs_listener_PalDiscoveryListener_, __args);
			return __ret;
		}

		static Delegate cb_stopDiscovery;
#pragma warning disable 0169
		static Delegate GetStopDiscoveryHandler ()
		{
			if (cb_stopDiscovery == null)
				cb_stopDiscovery = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_StopDiscovery);
			return cb_stopDiscovery;
		}

		static bool n_StopDiscovery (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Bridge.IPalDiscovery __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Bridge.IPalDiscovery> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.StopDiscovery ();
		}
#pragma warning restore 0169

		IntPtr id_stopDiscovery;
		public unsafe bool StopDiscovery ()
		{
			if (id_stopDiscovery == IntPtr.Zero)
				id_stopDiscovery = JNIEnv.GetMethodID (class_ref, "stopDiscovery", "()Z");
			return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_stopDiscovery);
		}

		static Delegate cb_stopNotifyMonitor;
#pragma warning disable 0169
		static Delegate GetStopNotifyMonitorHandler ()
		{
			if (cb_stopNotifyMonitor == null)
				cb_stopNotifyMonitor = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_StopNotifyMonitor);
			return cb_stopNotifyMonitor;
		}

		static bool n_StopNotifyMonitor (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Bridge.IPalDiscovery __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Bridge.IPalDiscovery> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.StopNotifyMonitor ();
		}
#pragma warning restore 0169

		IntPtr id_stopNotifyMonitor;
		public unsafe bool StopNotifyMonitor ()
		{
			if (id_stopNotifyMonitor == IntPtr.Zero)
				id_stopNotifyMonitor = JNIEnv.GetMethodID (class_ref, "stopNotifyMonitor", "()Z");
			return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_stopNotifyMonitor);
		}

	}

}
