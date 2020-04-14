using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Aliyun.Alink.Linksdk.Tools.Tracker {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.aliyun.alink.linksdk.tools.tracker']/class[@name='AliCloudUtSdkTracker']"
	[global::Android.Runtime.Register ("com/aliyun/alink/linksdk/tools/tracker/AliCloudUtSdkTracker", DoNotGenerateAcw=true)]
	public partial class AliCloudUtSdkTracker : global::Com.Aliyun.Alink.Linksdk.Tools.Tracker.BaseSdkTrack {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/aliyun/alink/linksdk/tools/tracker/AliCloudUtSdkTracker", typeof (AliCloudUtSdkTracker));
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

		protected AliCloudUtSdkTracker (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.aliyun.alink.linksdk.tools.tracker']/class[@name='AliCloudUtSdkTracker']/constructor[@name='AliCloudUtSdkTracker' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe AliCloudUtSdkTracker ()
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

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.aliyun.alink.linksdk.tools.tracker']/class[@name='AliCloudUtSdkTracker']/constructor[@name='AliCloudUtSdkTracker' and count(parameter)=1 and parameter[1][@type='android.app.Application']]"
		[Register (".ctor", "(Landroid/app/Application;)V", "")]
		public unsafe AliCloudUtSdkTracker (global::Android.App.Application context)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Landroid/app/Application;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((context == null) ? IntPtr.Zero : ((global::Java.Lang.Object) context).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_init_Landroid_app_Application_;
#pragma warning disable 0169
		static Delegate GetInit_Landroid_app_Application_Handler ()
		{
			if (cb_init_Landroid_app_Application_ == null)
				cb_init_Landroid_app_Application_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_Init_Landroid_app_Application_);
			return cb_init_Landroid_app_Application_;
		}

		static void n_Init_Landroid_app_Application_ (IntPtr jnienv, IntPtr native__this, IntPtr native_context)
		{
			global::Com.Aliyun.Alink.Linksdk.Tools.Tracker.AliCloudUtSdkTracker __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Tools.Tracker.AliCloudUtSdkTracker> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.App.Application context = global::Java.Lang.Object.GetObject<global::Android.App.Application> (native_context, JniHandleOwnership.DoNotTransfer);
			__this.Init (context);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.tools.tracker']/class[@name='AliCloudUtSdkTracker']/method[@name='init' and count(parameter)=1 and parameter[1][@type='android.app.Application']]"
		[Register ("init", "(Landroid/app/Application;)V", "GetInit_Landroid_app_Application_Handler")]
		public virtual unsafe void Init (global::Android.App.Application context)
		{
			const string __id = "init.(Landroid/app/Application;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((context == null) ? IntPtr.Zero : ((global::Java.Lang.Object) context).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

	}
}
