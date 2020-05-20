using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Component.Cloud {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.lpbs.component.cloud']/interface[@name='ICloudChannelFactory.FactoryListener']"
	[Register ("com/aliyun/alink/linksdk/alcs/lpbs/component/cloud/ICloudChannelFactory$FactoryListener", "", "Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Component.Cloud.ICloudChannelFactoryFactoryListenerInvoker")]
	public partial interface ICloudChannelFactoryFactoryListener : IJavaObject, IJavaPeerable {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.lpbs.component.cloud']/interface[@name='ICloudChannelFactory.FactoryListener']/method[@name='onCreate' and count(parameter)=2 and parameter[1][@type='com.aliyun.alink.linksdk.alcs.lpbs.data.PalDeviceInfo'] and parameter[2][@type='com.aliyun.alink.linksdk.alcs.lpbs.component.cloud.IThingCloudChannel']]"
		[Register ("onCreate", "(Lcom/aliyun/alink/linksdk/alcs/lpbs/data/PalDeviceInfo;Lcom/aliyun/alink/linksdk/alcs/lpbs/component/cloud/IThingCloudChannel;)V", "GetOnCreate_Lcom_aliyun_alink_linksdk_alcs_lpbs_data_PalDeviceInfo_Lcom_aliyun_alink_linksdk_alcs_lpbs_component_cloud_IThingCloudChannel_Handler:Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Component.Cloud.ICloudChannelFactoryFactoryListenerInvoker, AndroidAlcsLpbsBinding")]
		void OnCreate (global::Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Data.PalDeviceInfo p0, global::Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Component.Cloud.IThingCloudChannel p1);

	}

	[global::Android.Runtime.Register ("com/aliyun/alink/linksdk/alcs/lpbs/component/cloud/ICloudChannelFactory$FactoryListener", DoNotGenerateAcw=true)]
	internal partial class ICloudChannelFactoryFactoryListenerInvoker : global::Java.Lang.Object, ICloudChannelFactoryFactoryListener {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/aliyun/alink/linksdk/alcs/lpbs/component/cloud/ICloudChannelFactory$FactoryListener", typeof (ICloudChannelFactoryFactoryListenerInvoker));

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

		public static ICloudChannelFactoryFactoryListener GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<ICloudChannelFactoryFactoryListener> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.aliyun.alink.linksdk.alcs.lpbs.component.cloud.ICloudChannelFactory.FactoryListener"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public ICloudChannelFactoryFactoryListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_onCreate_Lcom_aliyun_alink_linksdk_alcs_lpbs_data_PalDeviceInfo_Lcom_aliyun_alink_linksdk_alcs_lpbs_component_cloud_IThingCloudChannel_;
#pragma warning disable 0169
		static Delegate GetOnCreate_Lcom_aliyun_alink_linksdk_alcs_lpbs_data_PalDeviceInfo_Lcom_aliyun_alink_linksdk_alcs_lpbs_component_cloud_IThingCloudChannel_Handler ()
		{
			if (cb_onCreate_Lcom_aliyun_alink_linksdk_alcs_lpbs_data_PalDeviceInfo_Lcom_aliyun_alink_linksdk_alcs_lpbs_component_cloud_IThingCloudChannel_ == null)
				cb_onCreate_Lcom_aliyun_alink_linksdk_alcs_lpbs_data_PalDeviceInfo_Lcom_aliyun_alink_linksdk_alcs_lpbs_component_cloud_IThingCloudChannel_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_OnCreate_Lcom_aliyun_alink_linksdk_alcs_lpbs_data_PalDeviceInfo_Lcom_aliyun_alink_linksdk_alcs_lpbs_component_cloud_IThingCloudChannel_);
			return cb_onCreate_Lcom_aliyun_alink_linksdk_alcs_lpbs_data_PalDeviceInfo_Lcom_aliyun_alink_linksdk_alcs_lpbs_component_cloud_IThingCloudChannel_;
		}

		static void n_OnCreate_Lcom_aliyun_alink_linksdk_alcs_lpbs_data_PalDeviceInfo_Lcom_aliyun_alink_linksdk_alcs_lpbs_component_cloud_IThingCloudChannel_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Component.Cloud.ICloudChannelFactoryFactoryListener __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Component.Cloud.ICloudChannelFactoryFactoryListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Data.PalDeviceInfo p0 = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Data.PalDeviceInfo> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Component.Cloud.IThingCloudChannel p1 = (global::Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Component.Cloud.IThingCloudChannel)global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Component.Cloud.IThingCloudChannel> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.OnCreate (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_onCreate_Lcom_aliyun_alink_linksdk_alcs_lpbs_data_PalDeviceInfo_Lcom_aliyun_alink_linksdk_alcs_lpbs_component_cloud_IThingCloudChannel_;
		public unsafe void OnCreate (global::Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Data.PalDeviceInfo p0, global::Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Component.Cloud.IThingCloudChannel p1)
		{
			if (id_onCreate_Lcom_aliyun_alink_linksdk_alcs_lpbs_data_PalDeviceInfo_Lcom_aliyun_alink_linksdk_alcs_lpbs_component_cloud_IThingCloudChannel_ == IntPtr.Zero)
				id_onCreate_Lcom_aliyun_alink_linksdk_alcs_lpbs_data_PalDeviceInfo_Lcom_aliyun_alink_linksdk_alcs_lpbs_component_cloud_IThingCloudChannel_ = JNIEnv.GetMethodID (class_ref, "onCreate", "(Lcom/aliyun/alink/linksdk/alcs/lpbs/data/PalDeviceInfo;Lcom/aliyun/alink/linksdk/alcs/lpbs/component/cloud/IThingCloudChannel;)V");
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			__args [1] = new JValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onCreate_Lcom_aliyun_alink_linksdk_alcs_lpbs_data_PalDeviceInfo_Lcom_aliyun_alink_linksdk_alcs_lpbs_component_cloud_IThingCloudChannel_, __args);
		}

	}

	// event args for com.aliyun.alink.linksdk.alcs.lpbs.component.cloud.ICloudChannelFactory.FactoryListener.onCreate
	public partial class CloudChannelFactoryFactoryEventArgs : global::System.EventArgs {

		public CloudChannelFactoryFactoryEventArgs (global::Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Data.PalDeviceInfo p0, global::Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Component.Cloud.IThingCloudChannel p1)
		{
			this.p0 = p0;
			this.p1 = p1;
		}

		global::Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Data.PalDeviceInfo p0;
		public global::Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Data.PalDeviceInfo P0 {
			get { return p0; }
		}

		global::Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Component.Cloud.IThingCloudChannel p1;
		public global::Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Component.Cloud.IThingCloudChannel P1 {
			get { return p1; }
		}
	}

	[global::Android.Runtime.Register ("mono/com/aliyun/alink/linksdk/alcs/lpbs/component/cloud/ICloudChannelFactory_FactoryListenerImplementor")]
	internal sealed partial class ICloudChannelFactoryFactoryListenerImplementor : global::Java.Lang.Object, ICloudChannelFactoryFactoryListener {

		object sender;

		public ICloudChannelFactoryFactoryListenerImplementor (object sender)
			: base (
				global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/com/aliyun/alink/linksdk/alcs/lpbs/component/cloud/ICloudChannelFactory_FactoryListenerImplementor", "()V"),
				JniHandleOwnership.TransferLocalRef)
		{
			global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "()V");
			this.sender = sender;
		}

#pragma warning disable 0649
		public EventHandler<CloudChannelFactoryFactoryEventArgs> Handler;
#pragma warning restore 0649

		public void OnCreate (global::Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Data.PalDeviceInfo p0, global::Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Component.Cloud.IThingCloudChannel p1)
		{
			var __h = Handler;
			if (__h != null)
				__h (sender, new CloudChannelFactoryFactoryEventArgs (p0, p1));
		}

		internal static bool __IsEmpty (ICloudChannelFactoryFactoryListenerImplementor value)
		{
			return value.Handler == null;
		}
	}


	// Metadata.xml XPath interface reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.lpbs.component.cloud']/interface[@name='ICloudChannelFactory']"
	[Register ("com/aliyun/alink/linksdk/alcs/lpbs/component/cloud/ICloudChannelFactory", "", "Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Component.Cloud.ICloudChannelFactoryInvoker")]
	public partial interface ICloudChannelFactory : IJavaObject, IJavaPeerable {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.lpbs.component.cloud']/interface[@name='ICloudChannelFactory']/method[@name='createCloudChannel' and count(parameter)=3 and parameter[1][@type='com.aliyun.alink.linksdk.alcs.lpbs.data.PalDeviceInfo'] and parameter[2][@type='java.util.Map&lt;java.lang.String, java.lang.Object&gt;'] and parameter[3][@type='com.aliyun.alink.linksdk.alcs.lpbs.component.cloud.ICloudChannelFactory.FactoryListener']]"
		[Register ("createCloudChannel", "(Lcom/aliyun/alink/linksdk/alcs/lpbs/data/PalDeviceInfo;Ljava/util/Map;Lcom/aliyun/alink/linksdk/alcs/lpbs/component/cloud/ICloudChannelFactory$FactoryListener;)V", "GetCreateCloudChannel_Lcom_aliyun_alink_linksdk_alcs_lpbs_data_PalDeviceInfo_Ljava_util_Map_Lcom_aliyun_alink_linksdk_alcs_lpbs_component_cloud_ICloudChannelFactory_FactoryListener_Handler:Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Component.Cloud.ICloudChannelFactoryInvoker, AndroidAlcsLpbsBinding")]
		void CreateCloudChannel (global::Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Data.PalDeviceInfo p0, global::System.Collections.Generic.IDictionary<string, global::Java.Lang.Object> p1, global::Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Component.Cloud.ICloudChannelFactoryFactoryListener p2);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.lpbs.component.cloud']/interface[@name='ICloudChannelFactory']/method[@name='releaseCloudChannel' and count(parameter)=1 and parameter[1][@type='com.aliyun.alink.linksdk.alcs.lpbs.data.PalDeviceInfo']]"
		[Register ("releaseCloudChannel", "(Lcom/aliyun/alink/linksdk/alcs/lpbs/data/PalDeviceInfo;)V", "GetReleaseCloudChannel_Lcom_aliyun_alink_linksdk_alcs_lpbs_data_PalDeviceInfo_Handler:Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Component.Cloud.ICloudChannelFactoryInvoker, AndroidAlcsLpbsBinding")]
		void ReleaseCloudChannel (global::Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Data.PalDeviceInfo p0);

	}

	[global::Android.Runtime.Register ("com/aliyun/alink/linksdk/alcs/lpbs/component/cloud/ICloudChannelFactory", DoNotGenerateAcw=true)]
	internal partial class ICloudChannelFactoryInvoker : global::Java.Lang.Object, ICloudChannelFactory {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/aliyun/alink/linksdk/alcs/lpbs/component/cloud/ICloudChannelFactory", typeof (ICloudChannelFactoryInvoker));

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

		public static ICloudChannelFactory GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<ICloudChannelFactory> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.aliyun.alink.linksdk.alcs.lpbs.component.cloud.ICloudChannelFactory"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public ICloudChannelFactoryInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_createCloudChannel_Lcom_aliyun_alink_linksdk_alcs_lpbs_data_PalDeviceInfo_Ljava_util_Map_Lcom_aliyun_alink_linksdk_alcs_lpbs_component_cloud_ICloudChannelFactory_FactoryListener_;
#pragma warning disable 0169
		static Delegate GetCreateCloudChannel_Lcom_aliyun_alink_linksdk_alcs_lpbs_data_PalDeviceInfo_Ljava_util_Map_Lcom_aliyun_alink_linksdk_alcs_lpbs_component_cloud_ICloudChannelFactory_FactoryListener_Handler ()
		{
			if (cb_createCloudChannel_Lcom_aliyun_alink_linksdk_alcs_lpbs_data_PalDeviceInfo_Ljava_util_Map_Lcom_aliyun_alink_linksdk_alcs_lpbs_component_cloud_ICloudChannelFactory_FactoryListener_ == null)
				cb_createCloudChannel_Lcom_aliyun_alink_linksdk_alcs_lpbs_data_PalDeviceInfo_Ljava_util_Map_Lcom_aliyun_alink_linksdk_alcs_lpbs_component_cloud_ICloudChannelFactory_FactoryListener_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_CreateCloudChannel_Lcom_aliyun_alink_linksdk_alcs_lpbs_data_PalDeviceInfo_Ljava_util_Map_Lcom_aliyun_alink_linksdk_alcs_lpbs_component_cloud_ICloudChannelFactory_FactoryListener_);
			return cb_createCloudChannel_Lcom_aliyun_alink_linksdk_alcs_lpbs_data_PalDeviceInfo_Ljava_util_Map_Lcom_aliyun_alink_linksdk_alcs_lpbs_component_cloud_ICloudChannelFactory_FactoryListener_;
		}

		static void n_CreateCloudChannel_Lcom_aliyun_alink_linksdk_alcs_lpbs_data_PalDeviceInfo_Ljava_util_Map_Lcom_aliyun_alink_linksdk_alcs_lpbs_component_cloud_ICloudChannelFactory_FactoryListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2)
		{
			global::Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Component.Cloud.ICloudChannelFactory __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Component.Cloud.ICloudChannelFactory> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Data.PalDeviceInfo p0 = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Data.PalDeviceInfo> (native_p0, JniHandleOwnership.DoNotTransfer);
			var p1 = global::Android.Runtime.JavaDictionary<string, global::Java.Lang.Object>.FromJniHandle (native_p1, JniHandleOwnership.DoNotTransfer);
			global::Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Component.Cloud.ICloudChannelFactoryFactoryListener p2 = (global::Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Component.Cloud.ICloudChannelFactoryFactoryListener)global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Component.Cloud.ICloudChannelFactoryFactoryListener> (native_p2, JniHandleOwnership.DoNotTransfer);
			__this.CreateCloudChannel (p0, p1, p2);
		}
#pragma warning restore 0169

		IntPtr id_createCloudChannel_Lcom_aliyun_alink_linksdk_alcs_lpbs_data_PalDeviceInfo_Ljava_util_Map_Lcom_aliyun_alink_linksdk_alcs_lpbs_component_cloud_ICloudChannelFactory_FactoryListener_;
		public unsafe void CreateCloudChannel (global::Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Data.PalDeviceInfo p0, global::System.Collections.Generic.IDictionary<string, global::Java.Lang.Object> p1, global::Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Component.Cloud.ICloudChannelFactoryFactoryListener p2)
		{
			if (id_createCloudChannel_Lcom_aliyun_alink_linksdk_alcs_lpbs_data_PalDeviceInfo_Ljava_util_Map_Lcom_aliyun_alink_linksdk_alcs_lpbs_component_cloud_ICloudChannelFactory_FactoryListener_ == IntPtr.Zero)
				id_createCloudChannel_Lcom_aliyun_alink_linksdk_alcs_lpbs_data_PalDeviceInfo_Ljava_util_Map_Lcom_aliyun_alink_linksdk_alcs_lpbs_component_cloud_ICloudChannelFactory_FactoryListener_ = JNIEnv.GetMethodID (class_ref, "createCloudChannel", "(Lcom/aliyun/alink/linksdk/alcs/lpbs/data/PalDeviceInfo;Ljava/util/Map;Lcom/aliyun/alink/linksdk/alcs/lpbs/component/cloud/ICloudChannelFactory$FactoryListener;)V");
			IntPtr native_p1 = global::Android.Runtime.JavaDictionary<string, global::Java.Lang.Object>.ToLocalJniHandle (p1);
			JValue* __args = stackalloc JValue [3];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			__args [1] = new JValue (native_p1);
			__args [2] = new JValue ((p2 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p2).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_createCloudChannel_Lcom_aliyun_alink_linksdk_alcs_lpbs_data_PalDeviceInfo_Ljava_util_Map_Lcom_aliyun_alink_linksdk_alcs_lpbs_component_cloud_ICloudChannelFactory_FactoryListener_, __args);
			JNIEnv.DeleteLocalRef (native_p1);
		}

		static Delegate cb_releaseCloudChannel_Lcom_aliyun_alink_linksdk_alcs_lpbs_data_PalDeviceInfo_;
#pragma warning disable 0169
		static Delegate GetReleaseCloudChannel_Lcom_aliyun_alink_linksdk_alcs_lpbs_data_PalDeviceInfo_Handler ()
		{
			if (cb_releaseCloudChannel_Lcom_aliyun_alink_linksdk_alcs_lpbs_data_PalDeviceInfo_ == null)
				cb_releaseCloudChannel_Lcom_aliyun_alink_linksdk_alcs_lpbs_data_PalDeviceInfo_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_ReleaseCloudChannel_Lcom_aliyun_alink_linksdk_alcs_lpbs_data_PalDeviceInfo_);
			return cb_releaseCloudChannel_Lcom_aliyun_alink_linksdk_alcs_lpbs_data_PalDeviceInfo_;
		}

		static void n_ReleaseCloudChannel_Lcom_aliyun_alink_linksdk_alcs_lpbs_data_PalDeviceInfo_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Component.Cloud.ICloudChannelFactory __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Component.Cloud.ICloudChannelFactory> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Data.PalDeviceInfo p0 = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Data.PalDeviceInfo> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.ReleaseCloudChannel (p0);
		}
#pragma warning restore 0169

		IntPtr id_releaseCloudChannel_Lcom_aliyun_alink_linksdk_alcs_lpbs_data_PalDeviceInfo_;
		public unsafe void ReleaseCloudChannel (global::Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Data.PalDeviceInfo p0)
		{
			if (id_releaseCloudChannel_Lcom_aliyun_alink_linksdk_alcs_lpbs_data_PalDeviceInfo_ == IntPtr.Zero)
				id_releaseCloudChannel_Lcom_aliyun_alink_linksdk_alcs_lpbs_data_PalDeviceInfo_ = JNIEnv.GetMethodID (class_ref, "releaseCloudChannel", "(Lcom/aliyun/alink/linksdk/alcs/lpbs/data/PalDeviceInfo;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_releaseCloudChannel_Lcom_aliyun_alink_linksdk_alcs_lpbs_data_PalDeviceInfo_, __args);
		}

	}

}
