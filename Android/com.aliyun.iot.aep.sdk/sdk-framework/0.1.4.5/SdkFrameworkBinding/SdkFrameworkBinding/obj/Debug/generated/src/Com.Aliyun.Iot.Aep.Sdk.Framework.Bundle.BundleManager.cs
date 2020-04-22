using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Aliyun.Iot.Aep.Sdk.Framework.Bundle {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.aliyun.iot.aep.sdk.framework.bundle']/class[@name='BundleManager']"
	[global::Android.Runtime.Register ("com/aliyun/iot/aep/sdk/framework/bundle/BundleManager", DoNotGenerateAcw=true)]
	public partial class BundleManager : global::Java.Lang.Object {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/aliyun/iot/aep/sdk/framework/bundle/BundleManager", typeof (BundleManager));
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

		protected BundleManager (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.aliyun.iot.aep.sdk.framework.bundle']/class[@name='BundleManager']/constructor[@name='BundleManager' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe BundleManager ()
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

		// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.iot.aep.sdk.framework.bundle']/class[@name='BundleManager']/method[@name='init' and count(parameter)=2 and parameter[1][@type='android.app.Application'] and parameter[2][@type='com.aliyun.iot.aep.sdk.framework.bundle.IBundleRegister']]"
		[Register ("init", "(Landroid/app/Application;Lcom/aliyun/iot/aep/sdk/framework/bundle/IBundleRegister;)I", "")]
		public static unsafe int Init (global::Android.App.Application app, global::Com.Aliyun.Iot.Aep.Sdk.Framework.Bundle.IBundleRegister bundleRegister)
		{
			const string __id = "init.(Landroid/app/Application;Lcom/aliyun/iot/aep/sdk/framework/bundle/IBundleRegister;)I";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((app == null) ? IntPtr.Zero : ((global::Java.Lang.Object) app).Handle);
				__args [1] = new JniArgumentValue ((bundleRegister == null) ? IntPtr.Zero : ((global::Java.Lang.Object) bundleRegister).Handle);
				var __rm = _members.StaticMethods.InvokeInt32Method (__id, __args);
				return __rm;
			} finally {
			}
		}

	}
}
