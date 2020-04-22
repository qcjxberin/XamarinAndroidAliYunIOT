using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Aliyun.Iot.Aep.Sdk.Page {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.aliyun.iot.aep.sdk.page']/class[@name='LocationUtil']"
	[global::Android.Runtime.Register ("com/aliyun/iot/aep/sdk/page/LocationUtil", DoNotGenerateAcw=true)]
	public partial class LocationUtil : global::Java.Lang.Object {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/aliyun/iot/aep/sdk/page/LocationUtil", typeof (LocationUtil));
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

		protected LocationUtil (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.aliyun.iot.aep.sdk.page']/class[@name='LocationUtil']/constructor[@name='LocationUtil' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe LocationUtil ()
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

		// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.iot.aep.sdk.page']/class[@name='LocationUtil']/method[@name='cancelLocating' and count(parameter)=0]"
		[Register ("cancelLocating", "()V", "")]
		public static unsafe void CancelLocating ()
		{
			const string __id = "cancelLocating.()V";
			try {
				_members.StaticMethods.InvokeVoidMethod (__id, null);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.iot.aep.sdk.page']/class[@name='LocationUtil']/method[@name='isLocationEnabled' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("isLocationEnabled", "(Landroid/content/Context;)Z", "")]
		public static unsafe bool IsLocationEnabled (global::Android.Content.Context context)
		{
			const string __id = "isLocationEnabled.(Landroid/content/Context;)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((context == null) ? IntPtr.Zero : ((global::Java.Lang.Object) context).Handle);
				var __rm = _members.StaticMethods.InvokeBooleanMethod (__id, __args);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.iot.aep.sdk.page']/class[@name='LocationUtil']/method[@name='remindStartLocateService' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("remindStartLocateService", "(Landroid/content/Context;)V", "")]
		public static unsafe void RemindStartLocateService (global::Android.Content.Context context)
		{
			const string __id = "remindStartLocateService.(Landroid/content/Context;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((context == null) ? IntPtr.Zero : ((global::Java.Lang.Object) context).Handle);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.iot.aep.sdk.page']/class[@name='LocationUtil']/method[@name='requestLocation' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("requestLocation", "(Landroid/content/Context;)V", "")]
		public static unsafe void RequestLocation (global::Android.Content.Context context)
		{
			const string __id = "requestLocation.(Landroid/content/Context;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((context == null) ? IntPtr.Zero : ((global::Java.Lang.Object) context).Handle);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
			}
		}

	}
}
