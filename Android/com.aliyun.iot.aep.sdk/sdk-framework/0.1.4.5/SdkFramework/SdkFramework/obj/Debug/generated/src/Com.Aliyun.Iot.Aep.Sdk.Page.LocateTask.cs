using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Aliyun.Iot.Aep.Sdk.Page {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.aliyun.iot.aep.sdk.page']/class[@name='LocateTask']"
	[global::Android.Runtime.Register ("com/aliyun/iot/aep/sdk/page/LocateTask", DoNotGenerateAcw=true)]
	public partial class LocateTask : global::Java.Lang.Object {


		// Metadata.xml XPath field reference: path="/api/package[@name='com.aliyun.iot.aep.sdk.page']/class[@name='LocateTask']/field[@name='TAG']"
		[Register ("TAG")]
		public const string Tag = (string) "LocateTask";
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/aliyun/iot/aep/sdk/page/LocateTask", typeof (LocateTask));
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

		protected LocateTask (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.aliyun.iot.aep.sdk.page']/class[@name='LocateTask']/constructor[@name='LocateTask' and count(parameter)=3 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.util.List&lt;com.aliyun.iot.aep.sdk.IoTSmart.Country&gt;'] and parameter[3][@type='com.aliyun.iot.aep.sdk.page.LocateHandler.OnLocationListener']]"
		[Register (".ctor", "(Landroid/content/Context;Ljava/util/List;Lcom/aliyun/iot/aep/sdk/page/LocateHandler$OnLocationListener;)V", "")]
		public unsafe LocateTask (global::Android.Content.Context context, global::System.Collections.Generic.IList<global::Com.Aliyun.Iot.Aep.Sdk.IoTSmart.Country> countries, global::Com.Aliyun.Iot.Aep.Sdk.Page.LocateHandler.IOnLocationListener locationListener)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Landroid/content/Context;Ljava/util/List;Lcom/aliyun/iot/aep/sdk/page/LocateHandler$OnLocationListener;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_countries = global::Android.Runtime.JavaList<global::Com.Aliyun.Iot.Aep.Sdk.IoTSmart.Country>.ToLocalJniHandle (countries);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((context == null) ? IntPtr.Zero : ((global::Java.Lang.Object) context).Handle);
				__args [1] = new JniArgumentValue (native_countries);
				__args [2] = new JniArgumentValue ((locationListener == null) ? IntPtr.Zero : ((global::Java.Lang.Object) locationListener).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_countries);
			}
		}

		static Delegate cb_startLocation;
#pragma warning disable 0169
		static Delegate GetStartLocationHandler ()
		{
			if (cb_startLocation == null)
				cb_startLocation = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_StartLocation);
			return cb_startLocation;
		}

		static void n_StartLocation (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Aliyun.Iot.Aep.Sdk.Page.LocateTask __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Iot.Aep.Sdk.Page.LocateTask> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.StartLocation ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.iot.aep.sdk.page']/class[@name='LocateTask']/method[@name='startLocation' and count(parameter)=0]"
		[Register ("startLocation", "()V", "GetStartLocationHandler")]
		public virtual unsafe void StartLocation ()
		{
			const string __id = "startLocation.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_stopLocation;
#pragma warning disable 0169
		static Delegate GetStopLocationHandler ()
		{
			if (cb_stopLocation == null)
				cb_stopLocation = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_StopLocation);
			return cb_stopLocation;
		}

		static void n_StopLocation (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Aliyun.Iot.Aep.Sdk.Page.LocateTask __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Iot.Aep.Sdk.Page.LocateTask> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.StopLocation ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.iot.aep.sdk.page']/class[@name='LocateTask']/method[@name='stopLocation' and count(parameter)=0]"
		[Register ("stopLocation", "()V", "GetStopLocationHandler")]
		public virtual unsafe void StopLocation ()
		{
			const string __id = "stopLocation.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

	}
}
