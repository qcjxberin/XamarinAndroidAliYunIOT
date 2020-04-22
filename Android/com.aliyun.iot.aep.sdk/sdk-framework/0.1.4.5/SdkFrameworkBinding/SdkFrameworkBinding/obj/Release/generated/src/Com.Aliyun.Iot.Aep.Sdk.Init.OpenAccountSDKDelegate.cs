using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Aliyun.Iot.Aep.Sdk.Init {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.aliyun.iot.aep.sdk.init']/class[@name='OpenAccountSDKDelegate']"
	[global::Android.Runtime.Register ("com/aliyun/iot/aep/sdk/init/OpenAccountSDKDelegate", DoNotGenerateAcw=true)]
	public sealed partial class OpenAccountSDKDelegate : global::Com.Aliyun.Iot.Aep.Sdk.Framework.Sdk.SimpleSDKDelegateImp {


		// Metadata.xml XPath field reference: path="/api/package[@name='com.aliyun.iot.aep.sdk.init']/class[@name='OpenAccountSDKDelegate']/field[@name='ACTION_OA_INIT_DONE']"
		[Register ("ACTION_OA_INIT_DONE")]
		public const string ActionOaInitDone = (string) "ACTION_OA_INIT_DONE";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.aliyun.iot.aep.sdk.init']/class[@name='OpenAccountSDKDelegate']/field[@name='ENV_KEY_API_CLIENT_API_ENV']"
		[Register ("ENV_KEY_API_CLIENT_API_ENV")]
		public const string EnvKeyApiClientApiEnv = (string) "KEY_API_CLIENT_API_ENV";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.aliyun.iot.aep.sdk.init']/class[@name='OpenAccountSDKDelegate']/field[@name='SUCCESS']"
		[Register ("SUCCESS")]
		public const string Success = (string) "success";
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/aliyun/iot/aep/sdk/init/OpenAccountSDKDelegate", typeof (OpenAccountSDKDelegate));
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

		internal OpenAccountSDKDelegate (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.aliyun.iot.aep.sdk.init']/class[@name='OpenAccountSDKDelegate']/constructor[@name='OpenAccountSDKDelegate' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe OpenAccountSDKDelegate ()
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

		// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.iot.aep.sdk.init']/class[@name='OpenAccountSDKDelegate']/method[@name='init' and count(parameter)=3 and parameter[1][@type='android.app.Application'] and parameter[2][@type='com.aliyun.iot.aep.sdk.framework.sdk.SDKConfigure'] and parameter[3][@type='java.util.Map&lt;java.lang.String, java.lang.String&gt;']]"
		[Register ("init", "(Landroid/app/Application;Lcom/aliyun/iot/aep/sdk/framework/sdk/SDKConfigure;Ljava/util/Map;)I", "")]
		public override unsafe int Init (global::Android.App.Application app, global::Com.Aliyun.Iot.Aep.Sdk.Framework.Sdk.SDKConfigure configure, global::System.Collections.Generic.IDictionary<string, string> args)
		{
			const string __id = "init.(Landroid/app/Application;Lcom/aliyun/iot/aep/sdk/framework/sdk/SDKConfigure;Ljava/util/Map;)I";
			IntPtr native_args = global::Android.Runtime.JavaDictionary<string, string>.ToLocalJniHandle (args);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((app == null) ? IntPtr.Zero : ((global::Java.Lang.Object) app).Handle);
				__args [1] = new JniArgumentValue ((configure == null) ? IntPtr.Zero : ((global::Java.Lang.Object) configure).Handle);
				__args [2] = new JniArgumentValue (native_args);
				var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, __args);
				return __rm;
			} finally {
				JNIEnv.DeleteLocalRef (native_args);
			}
		}

	}
}
