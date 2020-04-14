using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Aliyun.Iot.Aep.Component.Router {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.aliyun.iot.aep.component.router']/class[@name='BaseUrlHandler']"
	[global::Android.Runtime.Register ("com/aliyun/iot/aep/component/router/BaseUrlHandler", DoNotGenerateAcw=true)]
	public abstract partial class BaseUrlHandler : global::Java.Lang.Object, global::Com.Aliyun.Iot.Aep.Component.Router.IUrlHandler {



		// Metadata.xml XPath field reference: path="/api/package[@name='com.aliyun.iot.aep.component.router']/class[@name='BaseUrlHandler']/field[@name='mUrls']"
		[Register ("mUrls")]
		protected global::System.Collections.IList MUrls {
			get {
				const string __id = "mUrls.Ljava/util/List;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return global::Android.Runtime.JavaList.FromJniHandle (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "mUrls.Ljava/util/List;";

				IntPtr native_value = global::Android.Runtime.JavaList.ToLocalJniHandle (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/aliyun/iot/aep/component/router/BaseUrlHandler", typeof (BaseUrlHandler));
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

		protected BaseUrlHandler (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.aliyun.iot.aep.component.router']/class[@name='BaseUrlHandler']/constructor[@name='BaseUrlHandler' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe BaseUrlHandler ()
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

		static Delegate cb_getUrls;
#pragma warning disable 0169
		static Delegate GetGetUrlsHandler ()
		{
			if (cb_getUrls == null)
				cb_getUrls = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetUrls);
			return cb_getUrls;
		}

		static IntPtr n_GetUrls (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Aliyun.Iot.Aep.Component.Router.BaseUrlHandler __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Iot.Aep.Component.Router.BaseUrlHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaList<string>.ToLocalJniHandle (__this.Urls);
		}
#pragma warning restore 0169

		public virtual unsafe global::System.Collections.Generic.IList<string> Urls {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.iot.aep.component.router']/class[@name='BaseUrlHandler']/method[@name='getUrls' and count(parameter)=0]"
			[Register ("getUrls", "()Ljava/util/List;", "GetGetUrlsHandler")]
			get {
				const string __id = "getUrls.()Ljava/util/List;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Android.Runtime.JavaList<string>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
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
			global::Com.Aliyun.Iot.Aep.Component.Router.BaseUrlHandler __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Iot.Aep.Component.Router.BaseUrlHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.Context context = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (native_context, JniHandleOwnership.DoNotTransfer);
			string url = JNIEnv.GetString (native_url, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.Bundle bundle = global::Java.Lang.Object.GetObject<global::Android.OS.Bundle> (native_bundle, JniHandleOwnership.DoNotTransfer);
			__this.OnUrlHandle (context, url, bundle, startActForResult, reqCode);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.iot.aep.component.router']/class[@name='BaseUrlHandler']/method[@name='onUrlHandle' and count(parameter)=5 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='android.os.Bundle'] and parameter[4][@type='boolean'] and parameter[5][@type='int']]"
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

	}

	[global::Android.Runtime.Register ("com/aliyun/iot/aep/component/router/BaseUrlHandler", DoNotGenerateAcw=true)]
	internal partial class BaseUrlHandlerInvoker : BaseUrlHandler {

		public BaseUrlHandlerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/aliyun/iot/aep/component/router/BaseUrlHandler", typeof (BaseUrlHandlerInvoker));

		public override global::Java.Interop.JniPeerMembers JniPeerMembers {
			get { return _members; }
		}

		protected override global::System.Type ThresholdType {
			get { return _members.ManagedPeerType; }
		}

	}

}
