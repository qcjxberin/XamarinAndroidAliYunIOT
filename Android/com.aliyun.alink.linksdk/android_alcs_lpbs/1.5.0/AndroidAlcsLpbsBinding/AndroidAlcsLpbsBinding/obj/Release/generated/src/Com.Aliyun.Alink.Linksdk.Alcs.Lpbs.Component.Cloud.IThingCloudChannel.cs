using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Component.Cloud {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.lpbs.component.cloud']/interface[@name='IThingCloudChannel.IChannelActionListener']"
	[Register ("com/aliyun/alink/linksdk/alcs/lpbs/component/cloud/IThingCloudChannel$IChannelActionListener", "", "Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Component.Cloud.IThingCloudChannelChannelActionListenerInvoker")]
	public partial interface IThingCloudChannelChannelActionListener : IJavaObject, IJavaPeerable {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.lpbs.component.cloud']/interface[@name='IThingCloudChannel.IChannelActionListener']/method[@name='onFailed' and count(parameter)=1 and parameter[1][@type='com.aliyun.alink.linksdk.tools.AError']]"
		[Register ("onFailed", "(Lcom/aliyun/alink/linksdk/tools/AError;)V", "GetOnFailed_Lcom_aliyun_alink_linksdk_tools_AError_Handler:Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Component.Cloud.IThingCloudChannelChannelActionListenerInvoker, AndroidAlcsLpbsBinding")]
		void OnFailed (global::Com.Aliyun.Alink.Linksdk.Tools.AError p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.lpbs.component.cloud']/interface[@name='IThingCloudChannel.IChannelActionListener']/method[@name='onSuccess' and count(parameter)=0]"
		[Register ("onSuccess", "()V", "GetOnSuccessHandler:Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Component.Cloud.IThingCloudChannelChannelActionListenerInvoker, AndroidAlcsLpbsBinding")]
		void OnSuccess ();

	}

	[global::Android.Runtime.Register ("com/aliyun/alink/linksdk/alcs/lpbs/component/cloud/IThingCloudChannel$IChannelActionListener", DoNotGenerateAcw=true)]
	internal partial class IThingCloudChannelChannelActionListenerInvoker : global::Java.Lang.Object, IThingCloudChannelChannelActionListener {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/aliyun/alink/linksdk/alcs/lpbs/component/cloud/IThingCloudChannel$IChannelActionListener", typeof (IThingCloudChannelChannelActionListenerInvoker));

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

		public static IThingCloudChannelChannelActionListener GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IThingCloudChannelChannelActionListener> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.aliyun.alink.linksdk.alcs.lpbs.component.cloud.IThingCloudChannel.IChannelActionListener"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IThingCloudChannelChannelActionListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_onFailed_Lcom_aliyun_alink_linksdk_tools_AError_;
#pragma warning disable 0169
		static Delegate GetOnFailed_Lcom_aliyun_alink_linksdk_tools_AError_Handler ()
		{
			if (cb_onFailed_Lcom_aliyun_alink_linksdk_tools_AError_ == null)
				cb_onFailed_Lcom_aliyun_alink_linksdk_tools_AError_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnFailed_Lcom_aliyun_alink_linksdk_tools_AError_);
			return cb_onFailed_Lcom_aliyun_alink_linksdk_tools_AError_;
		}

		static void n_OnFailed_Lcom_aliyun_alink_linksdk_tools_AError_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Component.Cloud.IThingCloudChannelChannelActionListener __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Component.Cloud.IThingCloudChannelChannelActionListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Aliyun.Alink.Linksdk.Tools.AError p0 = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Tools.AError> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnFailed (p0);
		}
#pragma warning restore 0169

		IntPtr id_onFailed_Lcom_aliyun_alink_linksdk_tools_AError_;
		public unsafe void OnFailed (global::Com.Aliyun.Alink.Linksdk.Tools.AError p0)
		{
			if (id_onFailed_Lcom_aliyun_alink_linksdk_tools_AError_ == IntPtr.Zero)
				id_onFailed_Lcom_aliyun_alink_linksdk_tools_AError_ = JNIEnv.GetMethodID (class_ref, "onFailed", "(Lcom/aliyun/alink/linksdk/tools/AError;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onFailed_Lcom_aliyun_alink_linksdk_tools_AError_, __args);
		}

		static Delegate cb_onSuccess;
#pragma warning disable 0169
		static Delegate GetOnSuccessHandler ()
		{
			if (cb_onSuccess == null)
				cb_onSuccess = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_OnSuccess);
			return cb_onSuccess;
		}

		static void n_OnSuccess (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Component.Cloud.IThingCloudChannelChannelActionListener __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Component.Cloud.IThingCloudChannelChannelActionListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnSuccess ();
		}
#pragma warning restore 0169

		IntPtr id_onSuccess;
		public unsafe void OnSuccess ()
		{
			if (id_onSuccess == IntPtr.Zero)
				id_onSuccess = JNIEnv.GetMethodID (class_ref, "onSuccess", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onSuccess);
		}

	}

	// event args for com.aliyun.alink.linksdk.alcs.lpbs.component.cloud.IThingCloudChannel.IChannelActionListener.onFailed
	public partial class FailedEventArgs : global::System.EventArgs {

		public FailedEventArgs (global::Com.Aliyun.Alink.Linksdk.Tools.AError p0)
		{
			this.p0 = p0;
		}

		global::Com.Aliyun.Alink.Linksdk.Tools.AError p0;
		public global::Com.Aliyun.Alink.Linksdk.Tools.AError P0 {
			get { return p0; }
		}
	}

	[global::Android.Runtime.Register ("mono/com/aliyun/alink/linksdk/alcs/lpbs/component/cloud/IThingCloudChannel_IChannelActionListenerImplementor")]
	internal sealed partial class IThingCloudChannelChannelActionListenerImplementor : global::Java.Lang.Object, IThingCloudChannelChannelActionListener {

		object sender;

		public IThingCloudChannelChannelActionListenerImplementor (object sender)
			: base (
				global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/com/aliyun/alink/linksdk/alcs/lpbs/component/cloud/IThingCloudChannel_IChannelActionListenerImplementor", "()V"),
				JniHandleOwnership.TransferLocalRef)
		{
			global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "()V");
			this.sender = sender;
		}

#pragma warning disable 0649
		public EventHandler<FailedEventArgs> OnFailedHandler;
#pragma warning restore 0649

		public void OnFailed (global::Com.Aliyun.Alink.Linksdk.Tools.AError p0)
		{
			var __h = OnFailedHandler;
			if (__h != null)
				__h (sender, new FailedEventArgs (p0));
		}
#pragma warning disable 0649
		public EventHandler OnSuccessHandler;
#pragma warning restore 0649

		public void OnSuccess ()
		{
			var __h = OnSuccessHandler;
			if (__h != null)
				__h (sender, new EventArgs ());
		}

		internal static bool __IsEmpty (IThingCloudChannelChannelActionListenerImplementor value)
		{
			return value.OnFailedHandler == null && value.OnSuccessHandler == null;
		}
	}


	// Metadata.xml XPath interface reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.lpbs.component.cloud']/interface[@name='IThingCloudChannel']"
	[Register ("com/aliyun/alink/linksdk/alcs/lpbs/component/cloud/IThingCloudChannel", "", "Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Component.Cloud.IThingCloudChannelInvoker")]
	public partial interface IThingCloudChannel : IJavaObject, IJavaPeerable {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.lpbs.component.cloud']/interface[@name='IThingCloudChannel']/method[@name='addDownDataListener' and count(parameter)=1 and parameter[1][@type='com.aliyun.alink.linksdk.alcs.lpbs.component.cloud.IDataDownListener']]"
		[Register ("addDownDataListener", "(Lcom/aliyun/alink/linksdk/alcs/lpbs/component/cloud/IDataDownListener;)V", "GetAddDownDataListener_Lcom_aliyun_alink_linksdk_alcs_lpbs_component_cloud_IDataDownListener_Handler:Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Component.Cloud.IThingCloudChannelInvoker, AndroidAlcsLpbsBinding")]
		void AddDownDataListener (global::Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Component.Cloud.IDataDownListener p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.lpbs.component.cloud']/interface[@name='IThingCloudChannel']/method[@name='removeDownDataListener' and count(parameter)=1 and parameter[1][@type='com.aliyun.alink.linksdk.alcs.lpbs.component.cloud.IDataDownListener']]"
		[Register ("removeDownDataListener", "(Lcom/aliyun/alink/linksdk/alcs/lpbs/component/cloud/IDataDownListener;)V", "GetRemoveDownDataListener_Lcom_aliyun_alink_linksdk_alcs_lpbs_component_cloud_IDataDownListener_Handler:Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Component.Cloud.IThingCloudChannelInvoker, AndroidAlcsLpbsBinding")]
		void RemoveDownDataListener (global::Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Component.Cloud.IDataDownListener p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.lpbs.component.cloud']/interface[@name='IThingCloudChannel']/method[@name='reportData' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='byte[]']]"
		[Register ("reportData", "(Ljava/lang/String;[B)V", "GetReportData_Ljava_lang_String_arrayBHandler:Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Component.Cloud.IThingCloudChannelInvoker, AndroidAlcsLpbsBinding")]
		void ReportData (string p0, byte[] p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.lpbs.component.cloud']/interface[@name='IThingCloudChannel']/method[@name='reportData' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.Object'] and parameter[3][@type='com.aliyun.alink.linksdk.alcs.lpbs.component.cloud.IThingCloudChannel.IChannelActionListener']]"
		[Register ("reportData", "(Ljava/lang/String;Ljava/lang/Object;Lcom/aliyun/alink/linksdk/alcs/lpbs/component/cloud/IThingCloudChannel$IChannelActionListener;)V", "GetReportData_Ljava_lang_String_Ljava_lang_Object_Lcom_aliyun_alink_linksdk_alcs_lpbs_component_cloud_IThingCloudChannel_IChannelActionListener_Handler:Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Component.Cloud.IThingCloudChannelInvoker, AndroidAlcsLpbsBinding")]
		void ReportData (string p0, global::Java.Lang.Object p1, global::Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Component.Cloud.IThingCloudChannelChannelActionListener p2);

	}

	[global::Android.Runtime.Register ("com/aliyun/alink/linksdk/alcs/lpbs/component/cloud/IThingCloudChannel", DoNotGenerateAcw=true)]
	internal partial class IThingCloudChannelInvoker : global::Java.Lang.Object, IThingCloudChannel {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/aliyun/alink/linksdk/alcs/lpbs/component/cloud/IThingCloudChannel", typeof (IThingCloudChannelInvoker));

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

		public static IThingCloudChannel GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IThingCloudChannel> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.aliyun.alink.linksdk.alcs.lpbs.component.cloud.IThingCloudChannel"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IThingCloudChannelInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_addDownDataListener_Lcom_aliyun_alink_linksdk_alcs_lpbs_component_cloud_IDataDownListener_;
#pragma warning disable 0169
		static Delegate GetAddDownDataListener_Lcom_aliyun_alink_linksdk_alcs_lpbs_component_cloud_IDataDownListener_Handler ()
		{
			if (cb_addDownDataListener_Lcom_aliyun_alink_linksdk_alcs_lpbs_component_cloud_IDataDownListener_ == null)
				cb_addDownDataListener_Lcom_aliyun_alink_linksdk_alcs_lpbs_component_cloud_IDataDownListener_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_AddDownDataListener_Lcom_aliyun_alink_linksdk_alcs_lpbs_component_cloud_IDataDownListener_);
			return cb_addDownDataListener_Lcom_aliyun_alink_linksdk_alcs_lpbs_component_cloud_IDataDownListener_;
		}

		static void n_AddDownDataListener_Lcom_aliyun_alink_linksdk_alcs_lpbs_component_cloud_IDataDownListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Component.Cloud.IThingCloudChannel __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Component.Cloud.IThingCloudChannel> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Component.Cloud.IDataDownListener p0 = (global::Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Component.Cloud.IDataDownListener)global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Component.Cloud.IDataDownListener> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.AddDownDataListener (p0);
		}
#pragma warning restore 0169

		IntPtr id_addDownDataListener_Lcom_aliyun_alink_linksdk_alcs_lpbs_component_cloud_IDataDownListener_;
		public unsafe void AddDownDataListener (global::Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Component.Cloud.IDataDownListener p0)
		{
			if (id_addDownDataListener_Lcom_aliyun_alink_linksdk_alcs_lpbs_component_cloud_IDataDownListener_ == IntPtr.Zero)
				id_addDownDataListener_Lcom_aliyun_alink_linksdk_alcs_lpbs_component_cloud_IDataDownListener_ = JNIEnv.GetMethodID (class_ref, "addDownDataListener", "(Lcom/aliyun/alink/linksdk/alcs/lpbs/component/cloud/IDataDownListener;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_addDownDataListener_Lcom_aliyun_alink_linksdk_alcs_lpbs_component_cloud_IDataDownListener_, __args);
		}

		static Delegate cb_removeDownDataListener_Lcom_aliyun_alink_linksdk_alcs_lpbs_component_cloud_IDataDownListener_;
#pragma warning disable 0169
		static Delegate GetRemoveDownDataListener_Lcom_aliyun_alink_linksdk_alcs_lpbs_component_cloud_IDataDownListener_Handler ()
		{
			if (cb_removeDownDataListener_Lcom_aliyun_alink_linksdk_alcs_lpbs_component_cloud_IDataDownListener_ == null)
				cb_removeDownDataListener_Lcom_aliyun_alink_linksdk_alcs_lpbs_component_cloud_IDataDownListener_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_RemoveDownDataListener_Lcom_aliyun_alink_linksdk_alcs_lpbs_component_cloud_IDataDownListener_);
			return cb_removeDownDataListener_Lcom_aliyun_alink_linksdk_alcs_lpbs_component_cloud_IDataDownListener_;
		}

		static void n_RemoveDownDataListener_Lcom_aliyun_alink_linksdk_alcs_lpbs_component_cloud_IDataDownListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Component.Cloud.IThingCloudChannel __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Component.Cloud.IThingCloudChannel> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Component.Cloud.IDataDownListener p0 = (global::Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Component.Cloud.IDataDownListener)global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Component.Cloud.IDataDownListener> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.RemoveDownDataListener (p0);
		}
#pragma warning restore 0169

		IntPtr id_removeDownDataListener_Lcom_aliyun_alink_linksdk_alcs_lpbs_component_cloud_IDataDownListener_;
		public unsafe void RemoveDownDataListener (global::Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Component.Cloud.IDataDownListener p0)
		{
			if (id_removeDownDataListener_Lcom_aliyun_alink_linksdk_alcs_lpbs_component_cloud_IDataDownListener_ == IntPtr.Zero)
				id_removeDownDataListener_Lcom_aliyun_alink_linksdk_alcs_lpbs_component_cloud_IDataDownListener_ = JNIEnv.GetMethodID (class_ref, "removeDownDataListener", "(Lcom/aliyun/alink/linksdk/alcs/lpbs/component/cloud/IDataDownListener;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_removeDownDataListener_Lcom_aliyun_alink_linksdk_alcs_lpbs_component_cloud_IDataDownListener_, __args);
		}

		static Delegate cb_reportData_Ljava_lang_String_arrayB;
#pragma warning disable 0169
		static Delegate GetReportData_Ljava_lang_String_arrayBHandler ()
		{
			if (cb_reportData_Ljava_lang_String_arrayB == null)
				cb_reportData_Ljava_lang_String_arrayB = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_ReportData_Ljava_lang_String_arrayB);
			return cb_reportData_Ljava_lang_String_arrayB;
		}

		static void n_ReportData_Ljava_lang_String_arrayB (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Component.Cloud.IThingCloudChannel __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Component.Cloud.IThingCloudChannel> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			byte[] p1 = (byte[]) JNIEnv.GetArray (native_p1, JniHandleOwnership.DoNotTransfer, typeof (byte));
			__this.ReportData (p0, p1);
			if (p1 != null)
				JNIEnv.CopyArray (p1, native_p1);
		}
#pragma warning restore 0169

		IntPtr id_reportData_Ljava_lang_String_arrayB;
		public unsafe void ReportData (string p0, byte[] p1)
		{
			if (id_reportData_Ljava_lang_String_arrayB == IntPtr.Zero)
				id_reportData_Ljava_lang_String_arrayB = JNIEnv.GetMethodID (class_ref, "reportData", "(Ljava/lang/String;[B)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewArray (p1);
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (native_p0);
			__args [1] = new JValue (native_p1);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_reportData_Ljava_lang_String_arrayB, __args);
			JNIEnv.DeleteLocalRef (native_p0);
			if (p1 != null) {
				JNIEnv.CopyArray (native_p1, p1);
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static Delegate cb_reportData_Ljava_lang_String_Ljava_lang_Object_Lcom_aliyun_alink_linksdk_alcs_lpbs_component_cloud_IThingCloudChannel_IChannelActionListener_;
#pragma warning disable 0169
		static Delegate GetReportData_Ljava_lang_String_Ljava_lang_Object_Lcom_aliyun_alink_linksdk_alcs_lpbs_component_cloud_IThingCloudChannel_IChannelActionListener_Handler ()
		{
			if (cb_reportData_Ljava_lang_String_Ljava_lang_Object_Lcom_aliyun_alink_linksdk_alcs_lpbs_component_cloud_IThingCloudChannel_IChannelActionListener_ == null)
				cb_reportData_Ljava_lang_String_Ljava_lang_Object_Lcom_aliyun_alink_linksdk_alcs_lpbs_component_cloud_IThingCloudChannel_IChannelActionListener_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_ReportData_Ljava_lang_String_Ljava_lang_Object_Lcom_aliyun_alink_linksdk_alcs_lpbs_component_cloud_IThingCloudChannel_IChannelActionListener_);
			return cb_reportData_Ljava_lang_String_Ljava_lang_Object_Lcom_aliyun_alink_linksdk_alcs_lpbs_component_cloud_IThingCloudChannel_IChannelActionListener_;
		}

		static void n_ReportData_Ljava_lang_String_Ljava_lang_Object_Lcom_aliyun_alink_linksdk_alcs_lpbs_component_cloud_IThingCloudChannel_IChannelActionListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2)
		{
			global::Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Component.Cloud.IThingCloudChannel __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Component.Cloud.IThingCloudChannel> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object p1 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p1, JniHandleOwnership.DoNotTransfer);
			global::Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Component.Cloud.IThingCloudChannelChannelActionListener p2 = (global::Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Component.Cloud.IThingCloudChannelChannelActionListener)global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Component.Cloud.IThingCloudChannelChannelActionListener> (native_p2, JniHandleOwnership.DoNotTransfer);
			__this.ReportData (p0, p1, p2);
		}
#pragma warning restore 0169

		IntPtr id_reportData_Ljava_lang_String_Ljava_lang_Object_Lcom_aliyun_alink_linksdk_alcs_lpbs_component_cloud_IThingCloudChannel_IChannelActionListener_;
		public unsafe void ReportData (string p0, global::Java.Lang.Object p1, global::Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Component.Cloud.IThingCloudChannelChannelActionListener p2)
		{
			if (id_reportData_Ljava_lang_String_Ljava_lang_Object_Lcom_aliyun_alink_linksdk_alcs_lpbs_component_cloud_IThingCloudChannel_IChannelActionListener_ == IntPtr.Zero)
				id_reportData_Ljava_lang_String_Ljava_lang_Object_Lcom_aliyun_alink_linksdk_alcs_lpbs_component_cloud_IThingCloudChannel_IChannelActionListener_ = JNIEnv.GetMethodID (class_ref, "reportData", "(Ljava/lang/String;Ljava/lang/Object;Lcom/aliyun/alink/linksdk/alcs/lpbs/component/cloud/IThingCloudChannel$IChannelActionListener;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			JValue* __args = stackalloc JValue [3];
			__args [0] = new JValue (native_p0);
			__args [1] = new JValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
			__args [2] = new JValue ((p2 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p2).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_reportData_Ljava_lang_String_Ljava_lang_Object_Lcom_aliyun_alink_linksdk_alcs_lpbs_component_cloud_IThingCloudChannel_IChannelActionListener_, __args);
			JNIEnv.DeleteLocalRef (native_p0);
		}

	}

}
