using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Aliyun.Iot.Aep.Sdk.Framework.Sdk {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.aliyun.iot.aep.sdk.framework.sdk']/class[@name='SimpleSDKDelegateImp']"
	[global::Android.Runtime.Register ("com/aliyun/iot/aep/sdk/framework/sdk/SimpleSDKDelegateImp", DoNotGenerateAcw=true)]
	public abstract partial class SimpleSDKDelegateImp : global::Java.Lang.Object, global::Com.Aliyun.Iot.Aep.Sdk.Framework.Sdk.ISDKDelegate {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/aliyun/iot/aep/sdk/framework/sdk/SimpleSDKDelegateImp", typeof (SimpleSDKDelegateImp));
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

		protected SimpleSDKDelegateImp (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.aliyun.iot.aep.sdk.framework.sdk']/class[@name='SimpleSDKDelegateImp']/constructor[@name='SimpleSDKDelegateImp' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe SimpleSDKDelegateImp ()
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

		static Delegate cb_canBeenInitialized_Ljava_util_Map_;
#pragma warning disable 0169
		static Delegate GetCanBeenInitialized_Ljava_util_Map_Handler ()
		{
			if (cb_canBeenInitialized_Ljava_util_Map_ == null)
				cb_canBeenInitialized_Ljava_util_Map_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_CanBeenInitialized_Ljava_util_Map_);
			return cb_canBeenInitialized_Ljava_util_Map_;
		}

		static bool n_CanBeenInitialized_Ljava_util_Map_ (IntPtr jnienv, IntPtr native__this, IntPtr native_args)
		{
			global::Com.Aliyun.Iot.Aep.Sdk.Framework.Sdk.SimpleSDKDelegateImp __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Iot.Aep.Sdk.Framework.Sdk.SimpleSDKDelegateImp> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var args = global::Android.Runtime.JavaDictionary<string, string>.FromJniHandle (native_args, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.CanBeenInitialized (args);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.iot.aep.sdk.framework.sdk']/class[@name='SimpleSDKDelegateImp']/method[@name='canBeenInitialized' and count(parameter)=1 and parameter[1][@type='java.util.Map&lt;java.lang.String, java.lang.String&gt;']]"
		[Register ("canBeenInitialized", "(Ljava/util/Map;)Z", "GetCanBeenInitialized_Ljava_util_Map_Handler")]
		public virtual unsafe bool CanBeenInitialized (global::System.Collections.Generic.IDictionary<string, string> args)
		{
			const string __id = "canBeenInitialized.(Ljava/util/Map;)Z";
			IntPtr native_args = global::Android.Runtime.JavaDictionary<string, string>.ToLocalJniHandle (args);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_args);
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
				JNIEnv.DeleteLocalRef (native_args);
			}
		}

		static Delegate cb_init_Landroid_app_Application_Lcom_aliyun_iot_aep_sdk_framework_sdk_SDKConfigure_Ljava_util_Map_;
#pragma warning disable 0169
		static Delegate GetInit_Landroid_app_Application_Lcom_aliyun_iot_aep_sdk_framework_sdk_SDKConfigure_Ljava_util_Map_Handler ()
		{
			if (cb_init_Landroid_app_Application_Lcom_aliyun_iot_aep_sdk_framework_sdk_SDKConfigure_Ljava_util_Map_ == null)
				cb_init_Landroid_app_Application_Lcom_aliyun_iot_aep_sdk_framework_sdk_SDKConfigure_Ljava_util_Map_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, int>) n_Init_Landroid_app_Application_Lcom_aliyun_iot_aep_sdk_framework_sdk_SDKConfigure_Ljava_util_Map_);
			return cb_init_Landroid_app_Application_Lcom_aliyun_iot_aep_sdk_framework_sdk_SDKConfigure_Ljava_util_Map_;
		}

		static int n_Init_Landroid_app_Application_Lcom_aliyun_iot_aep_sdk_framework_sdk_SDKConfigure_Ljava_util_Map_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2)
		{
			global::Com.Aliyun.Iot.Aep.Sdk.Framework.Sdk.SimpleSDKDelegateImp __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Iot.Aep.Sdk.Framework.Sdk.SimpleSDKDelegateImp> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.App.Application p0 = global::Java.Lang.Object.GetObject<global::Android.App.Application> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Com.Aliyun.Iot.Aep.Sdk.Framework.Sdk.SDKConfigure p1 = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Iot.Aep.Sdk.Framework.Sdk.SDKConfigure> (native_p1, JniHandleOwnership.DoNotTransfer);
			var p2 = global::Android.Runtime.JavaDictionary<string, string>.FromJniHandle (native_p2, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.Init (p0, p1, p2);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.iot.aep.sdk.framework.sdk']/interface[@name='ISDKDelegate']/method[@name='init' and count(parameter)=3 and parameter[1][@type='android.app.Application'] and parameter[2][@type='com.aliyun.iot.aep.sdk.framework.sdk.SDKConfigure'] and parameter[3][@type='java.util.Map&lt;java.lang.String, java.lang.String&gt;']]"
		[Register ("init", "(Landroid/app/Application;Lcom/aliyun/iot/aep/sdk/framework/sdk/SDKConfigure;Ljava/util/Map;)I", "GetInit_Landroid_app_Application_Lcom_aliyun_iot_aep_sdk_framework_sdk_SDKConfigure_Ljava_util_Map_Handler")]
		public abstract int Init (global::Android.App.Application p0, global::Com.Aliyun.Iot.Aep.Sdk.Framework.Sdk.SDKConfigure p1, global::System.Collections.Generic.IDictionary<string, string> p2);

	}

	[global::Android.Runtime.Register ("com/aliyun/iot/aep/sdk/framework/sdk/SimpleSDKDelegateImp", DoNotGenerateAcw=true)]
	internal partial class SimpleSDKDelegateImpInvoker : SimpleSDKDelegateImp {

		public SimpleSDKDelegateImpInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/aliyun/iot/aep/sdk/framework/sdk/SimpleSDKDelegateImp", typeof (SimpleSDKDelegateImpInvoker));

		public override global::Java.Interop.JniPeerMembers JniPeerMembers {
			get { return _members; }
		}

		protected override global::System.Type ThresholdType {
			get { return _members.ManagedPeerType; }
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.iot.aep.sdk.framework.sdk']/interface[@name='ISDKDelegate']/method[@name='init' and count(parameter)=3 and parameter[1][@type='android.app.Application'] and parameter[2][@type='com.aliyun.iot.aep.sdk.framework.sdk.SDKConfigure'] and parameter[3][@type='java.util.Map&lt;java.lang.String, java.lang.String&gt;']]"
		[Register ("init", "(Landroid/app/Application;Lcom/aliyun/iot/aep/sdk/framework/sdk/SDKConfigure;Ljava/util/Map;)I", "GetInit_Landroid_app_Application_Lcom_aliyun_iot_aep_sdk_framework_sdk_SDKConfigure_Ljava_util_Map_Handler")]
		public override unsafe int Init (global::Android.App.Application p0, global::Com.Aliyun.Iot.Aep.Sdk.Framework.Sdk.SDKConfigure p1, global::System.Collections.Generic.IDictionary<string, string> p2)
		{
			const string __id = "init.(Landroid/app/Application;Lcom/aliyun/iot/aep/sdk/framework/sdk/SDKConfigure;Ljava/util/Map;)I";
			IntPtr native_p2 = global::Android.Runtime.JavaDictionary<string, string>.ToLocalJniHandle (p2);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
				__args [2] = new JniArgumentValue (native_p2);
				var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, __args);
				return __rm;
			} finally {
				JNIEnv.DeleteLocalRef (native_p2);
			}
		}

	}

}
