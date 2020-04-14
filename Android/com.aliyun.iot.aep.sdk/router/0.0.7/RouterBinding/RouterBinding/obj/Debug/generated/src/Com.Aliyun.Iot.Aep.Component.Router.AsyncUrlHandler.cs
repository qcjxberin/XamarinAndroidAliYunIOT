using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Aliyun.Iot.Aep.Component.Router {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.aliyun.iot.aep.component.router']/class[@name='AsyncUrlHandler']"
	[global::Android.Runtime.Register ("com/aliyun/iot/aep/component/router/AsyncUrlHandler", DoNotGenerateAcw=true)]
	public abstract partial class AsyncUrlHandler : global::Java.Lang.Object, global::Com.Aliyun.Iot.Aep.Component.Router.IUrlHandler {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/aliyun/iot/aep/component/router/AsyncUrlHandler", typeof (AsyncUrlHandler));
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

		protected AsyncUrlHandler (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.aliyun.iot.aep.component.router']/class[@name='AsyncUrlHandler']/constructor[@name='AsyncUrlHandler' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe AsyncUrlHandler ()
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

		static Delegate cb_onUrlHandle_Landroid_content_Context_Ljava_lang_String_Landroid_os_Bundle_ZI;
#pragma warning disable 0169
		static Delegate GetOnUrlHandle_Landroid_content_Context_Ljava_lang_String_Landroid_os_Bundle_ZIHandler ()
		{
			if (cb_onUrlHandle_Landroid_content_Context_Ljava_lang_String_Landroid_os_Bundle_ZI == null)
				cb_onUrlHandle_Landroid_content_Context_Ljava_lang_String_Landroid_os_Bundle_ZI = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, bool, int>) n_OnUrlHandle_Landroid_content_Context_Ljava_lang_String_Landroid_os_Bundle_ZI);
			return cb_onUrlHandle_Landroid_content_Context_Ljava_lang_String_Landroid_os_Bundle_ZI;
		}

		static void n_OnUrlHandle_Landroid_content_Context_Ljava_lang_String_Landroid_os_Bundle_ZI (IntPtr jnienv, IntPtr native__this, IntPtr native_context, IntPtr native_url, IntPtr native_bundle, bool startActForResult, int reqCode)
		{
			global::Com.Aliyun.Iot.Aep.Component.Router.AsyncUrlHandler __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Iot.Aep.Component.Router.AsyncUrlHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.Context context = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (native_context, JniHandleOwnership.DoNotTransfer);
			string url = JNIEnv.GetString (native_url, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.Bundle bundle = global::Java.Lang.Object.GetObject<global::Android.OS.Bundle> (native_bundle, JniHandleOwnership.DoNotTransfer);
			__this.OnUrlHandle (context, url, bundle, startActForResult, reqCode);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.iot.aep.component.router']/class[@name='AsyncUrlHandler']/method[@name='onUrlHandle' and count(parameter)=5 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='android.os.Bundle'] and parameter[4][@type='boolean'] and parameter[5][@type='int']]"
		[Register ("onUrlHandle", "(Landroid/content/Context;Ljava/lang/String;Landroid/os/Bundle;ZI)V", "GetOnUrlHandle_Landroid_content_Context_Ljava_lang_String_Landroid_os_Bundle_ZIHandler")]
		public virtual unsafe void OnUrlHandle (global::Android.Content.Context context, string url, global::Android.OS.Bundle bundle, bool startActForResult, int reqCode)
		{
			const string __id = "onUrlHandle.(Landroid/content/Context;Ljava/lang/String;Landroid/os/Bundle;ZI)V";
			IntPtr native_url = JNIEnv.NewString (url);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [5];
				__args [0] = new JniArgumentValue ((context == null) ? IntPtr.Zero : ((global::Java.Lang.Object) context).Handle);
				__args [1] = new JniArgumentValue (native_url);
				__args [2] = new JniArgumentValue ((bundle == null) ? IntPtr.Zero : ((global::Java.Lang.Object) bundle).Handle);
				__args [3] = new JniArgumentValue (startActForResult);
				__args [4] = new JniArgumentValue (reqCode);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_url);
			}
		}

		static Delegate cb_onUrlHandle_Landroid_content_Context_Ljava_lang_String_Landroid_os_Bundle_ZILcom_aliyun_iot_aep_component_router_IAsyncHandlerCallback_;
#pragma warning disable 0169
		static Delegate GetOnUrlHandle_Landroid_content_Context_Ljava_lang_String_Landroid_os_Bundle_ZILcom_aliyun_iot_aep_component_router_IAsyncHandlerCallback_Handler ()
		{
			if (cb_onUrlHandle_Landroid_content_Context_Ljava_lang_String_Landroid_os_Bundle_ZILcom_aliyun_iot_aep_component_router_IAsyncHandlerCallback_ == null)
				cb_onUrlHandle_Landroid_content_Context_Ljava_lang_String_Landroid_os_Bundle_ZILcom_aliyun_iot_aep_component_router_IAsyncHandlerCallback_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, bool, int, IntPtr>) n_OnUrlHandle_Landroid_content_Context_Ljava_lang_String_Landroid_os_Bundle_ZILcom_aliyun_iot_aep_component_router_IAsyncHandlerCallback_);
			return cb_onUrlHandle_Landroid_content_Context_Ljava_lang_String_Landroid_os_Bundle_ZILcom_aliyun_iot_aep_component_router_IAsyncHandlerCallback_;
		}

		static void n_OnUrlHandle_Landroid_content_Context_Ljava_lang_String_Landroid_os_Bundle_ZILcom_aliyun_iot_aep_component_router_IAsyncHandlerCallback_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2, bool p3, int p4, IntPtr native_p5)
		{
			global::Com.Aliyun.Iot.Aep.Component.Router.AsyncUrlHandler __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Iot.Aep.Component.Router.AsyncUrlHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.Context p0 = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.Bundle p2 = global::Java.Lang.Object.GetObject<global::Android.OS.Bundle> (native_p2, JniHandleOwnership.DoNotTransfer);
			global::Com.Aliyun.Iot.Aep.Component.Router.IAsyncHandlerCallback p5 = (global::Com.Aliyun.Iot.Aep.Component.Router.IAsyncHandlerCallback)global::Java.Lang.Object.GetObject<global::Com.Aliyun.Iot.Aep.Component.Router.IAsyncHandlerCallback> (native_p5, JniHandleOwnership.DoNotTransfer);
			__this.OnUrlHandle (p0, p1, p2, p3, p4, p5);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.iot.aep.component.router']/class[@name='AsyncUrlHandler']/method[@name='onUrlHandle' and count(parameter)=6 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='android.os.Bundle'] and parameter[4][@type='boolean'] and parameter[5][@type='int'] and parameter[6][@type='com.aliyun.iot.aep.component.router.IAsyncHandlerCallback']]"
		[Register ("onUrlHandle", "(Landroid/content/Context;Ljava/lang/String;Landroid/os/Bundle;ZILcom/aliyun/iot/aep/component/router/IAsyncHandlerCallback;)V", "GetOnUrlHandle_Landroid_content_Context_Ljava_lang_String_Landroid_os_Bundle_ZILcom_aliyun_iot_aep_component_router_IAsyncHandlerCallback_Handler")]
		protected abstract void OnUrlHandle (global::Android.Content.Context p0, string p1, global::Android.OS.Bundle p2, bool p3, int p4, global::Com.Aliyun.Iot.Aep.Component.Router.IAsyncHandlerCallback p5);

	}

	[global::Android.Runtime.Register ("com/aliyun/iot/aep/component/router/AsyncUrlHandler", DoNotGenerateAcw=true)]
	internal partial class AsyncUrlHandlerInvoker : AsyncUrlHandler {

		public AsyncUrlHandlerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/aliyun/iot/aep/component/router/AsyncUrlHandler", typeof (AsyncUrlHandlerInvoker));

		public override global::Java.Interop.JniPeerMembers JniPeerMembers {
			get { return _members; }
		}

		protected override global::System.Type ThresholdType {
			get { return _members.ManagedPeerType; }
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.iot.aep.component.router']/class[@name='AsyncUrlHandler']/method[@name='onUrlHandle' and count(parameter)=6 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='android.os.Bundle'] and parameter[4][@type='boolean'] and parameter[5][@type='int'] and parameter[6][@type='com.aliyun.iot.aep.component.router.IAsyncHandlerCallback']]"
		[Register ("onUrlHandle", "(Landroid/content/Context;Ljava/lang/String;Landroid/os/Bundle;ZILcom/aliyun/iot/aep/component/router/IAsyncHandlerCallback;)V", "GetOnUrlHandle_Landroid_content_Context_Ljava_lang_String_Landroid_os_Bundle_ZILcom_aliyun_iot_aep_component_router_IAsyncHandlerCallback_Handler")]
		protected override unsafe void OnUrlHandle (global::Android.Content.Context p0, string p1, global::Android.OS.Bundle p2, bool p3, int p4, global::Com.Aliyun.Iot.Aep.Component.Router.IAsyncHandlerCallback p5)
		{
			const string __id = "onUrlHandle.(Landroid/content/Context;Ljava/lang/String;Landroid/os/Bundle;ZILcom/aliyun/iot/aep/component/router/IAsyncHandlerCallback;)V";
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [6];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue (native_p1);
				__args [2] = new JniArgumentValue ((p2 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p2).Handle);
				__args [3] = new JniArgumentValue (p3);
				__args [4] = new JniArgumentValue (p4);
				__args [5] = new JniArgumentValue ((p5 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p5).Handle);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

	}

}
