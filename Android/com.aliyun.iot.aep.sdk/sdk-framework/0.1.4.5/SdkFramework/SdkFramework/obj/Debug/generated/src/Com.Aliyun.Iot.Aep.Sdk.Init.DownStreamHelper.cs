using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Aliyun.Iot.Aep.Sdk.Init {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.aliyun.iot.aep.sdk.init']/class[@name='DownStreamHelper']"
	[global::Android.Runtime.Register ("com/aliyun/iot/aep/sdk/init/DownStreamHelper", DoNotGenerateAcw=true)]
	public partial class DownStreamHelper : global::Java.Lang.Object {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/aliyun/iot/aep/sdk/init/DownStreamHelper", typeof (DownStreamHelper));
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

		protected DownStreamHelper (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		public static unsafe global::Com.Aliyun.Iot.Aep.Sdk.Init.DownStreamHelper Instance {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.iot.aep.sdk.init']/class[@name='DownStreamHelper']/method[@name='getInstance' and count(parameter)=0]"
			[Register ("getInstance", "()Lcom/aliyun/iot/aep/sdk/init/DownStreamHelper;", "")]
			get {
				const string __id = "getInstance.()Lcom/aliyun/iot/aep/sdk/init/DownStreamHelper;";
				try {
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
					return global::Java.Lang.Object.GetObject<global::Com.Aliyun.Iot.Aep.Sdk.Init.DownStreamHelper> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_initBreeze_Landroid_app_Application_;
#pragma warning disable 0169
		static Delegate GetInitBreeze_Landroid_app_Application_Handler ()
		{
			if (cb_initBreeze_Landroid_app_Application_ == null)
				cb_initBreeze_Landroid_app_Application_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_InitBreeze_Landroid_app_Application_);
			return cb_initBreeze_Landroid_app_Application_;
		}

		static void n_InitBreeze_Landroid_app_Application_ (IntPtr jnienv, IntPtr native__this, IntPtr native_app)
		{
			global::Com.Aliyun.Iot.Aep.Sdk.Init.DownStreamHelper __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Iot.Aep.Sdk.Init.DownStreamHelper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.App.Application app = global::Java.Lang.Object.GetObject<global::Android.App.Application> (native_app, JniHandleOwnership.DoNotTransfer);
			__this.InitBreeze (app);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.iot.aep.sdk.init']/class[@name='DownStreamHelper']/method[@name='initBreeze' and count(parameter)=1 and parameter[1][@type='android.app.Application']]"
		[Register ("initBreeze", "(Landroid/app/Application;)V", "GetInitBreeze_Landroid_app_Application_Handler")]
		public virtual unsafe void InitBreeze (global::Android.App.Application app)
		{
			const string __id = "initBreeze.(Landroid/app/Application;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((app == null) ? IntPtr.Zero : ((global::Java.Lang.Object) app).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_startMqtt_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetStartMqtt_Ljava_lang_String_Handler ()
		{
			if (cb_startMqtt_Ljava_lang_String_ == null)
				cb_startMqtt_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_StartMqtt_Ljava_lang_String_);
			return cb_startMqtt_Ljava_lang_String_;
		}

		static void n_StartMqtt_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_host)
		{
			global::Com.Aliyun.Iot.Aep.Sdk.Init.DownStreamHelper __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Iot.Aep.Sdk.Init.DownStreamHelper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string host = JNIEnv.GetString (native_host, JniHandleOwnership.DoNotTransfer);
			__this.StartMqtt (host);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.iot.aep.sdk.init']/class[@name='DownStreamHelper']/method[@name='startMqtt' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("startMqtt", "(Ljava/lang/String;)V", "GetStartMqtt_Ljava_lang_String_Handler")]
		public virtual unsafe void StartMqtt (string host)
		{
			const string __id = "startMqtt.(Ljava/lang/String;)V";
			IntPtr native_host = JNIEnv.NewString (host);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_host);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_host);
			}
		}

	}
}
