using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Aliyun.Iot.Aep.Component.Router {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.aliyun.iot.aep.component.router']/class[@name='Router']"
	[global::Android.Runtime.Register ("com/aliyun/iot/aep/component/router/Router", DoNotGenerateAcw=true)]
	public partial class Router : global::Java.Lang.Object {

		// Metadata.xml XPath interface reference: path="/api/package[@name='com.aliyun.iot.aep.component.router']/interface[@name='Router.UrlInterceptor']"
		[Register ("com/aliyun/iot/aep/component/router/Router$UrlInterceptor", "", "Com.Aliyun.Iot.Aep.Component.Router.Router/IUrlInterceptorInvoker")]
		public partial interface IUrlInterceptor : IJavaObject, IJavaPeerable {

			// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.iot.aep.component.router']/interface[@name='Router.UrlInterceptor']/method[@name='onIntercept' and count(parameter)=1 and parameter[1][@type='com.aliyun.iot.aep.component.router.RouterRequest']]"
			[Register ("onIntercept", "(Lcom/aliyun/iot/aep/component/router/RouterRequest;)Lcom/aliyun/iot/aep/component/router/RouterRequest;", "GetOnIntercept_Lcom_aliyun_iot_aep_component_router_RouterRequest_Handler:Com.Aliyun.Iot.Aep.Component.Router.Router/IUrlInterceptorInvoker, RouterBinding")]
			global::Com.Aliyun.Iot.Aep.Component.Router.RouterRequest OnIntercept (global::Com.Aliyun.Iot.Aep.Component.Router.RouterRequest p0);

		}

		[global::Android.Runtime.Register ("com/aliyun/iot/aep/component/router/Router$UrlInterceptor", DoNotGenerateAcw=true)]
		internal partial class IUrlInterceptorInvoker : global::Java.Lang.Object, IUrlInterceptor {

			static readonly JniPeerMembers _members = new XAPeerMembers ("com/aliyun/iot/aep/component/router/Router$UrlInterceptor", typeof (IUrlInterceptorInvoker));

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

			public static IUrlInterceptor GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<IUrlInterceptor> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "com.aliyun.iot.aep.component.router.Router.UrlInterceptor"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public IUrlInterceptorInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			static Delegate cb_onIntercept_Lcom_aliyun_iot_aep_component_router_RouterRequest_;
#pragma warning disable 0169
			static Delegate GetOnIntercept_Lcom_aliyun_iot_aep_component_router_RouterRequest_Handler ()
			{
				if (cb_onIntercept_Lcom_aliyun_iot_aep_component_router_RouterRequest_ == null)
					cb_onIntercept_Lcom_aliyun_iot_aep_component_router_RouterRequest_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_OnIntercept_Lcom_aliyun_iot_aep_component_router_RouterRequest_);
				return cb_onIntercept_Lcom_aliyun_iot_aep_component_router_RouterRequest_;
			}

			static IntPtr n_OnIntercept_Lcom_aliyun_iot_aep_component_router_RouterRequest_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Aliyun.Iot.Aep.Component.Router.Router.IUrlInterceptor __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Iot.Aep.Component.Router.Router.IUrlInterceptor> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Com.Aliyun.Iot.Aep.Component.Router.RouterRequest p0 = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Iot.Aep.Component.Router.RouterRequest> (native_p0, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.OnIntercept (p0));
				return __ret;
			}
#pragma warning restore 0169

			IntPtr id_onIntercept_Lcom_aliyun_iot_aep_component_router_RouterRequest_;
			public unsafe global::Com.Aliyun.Iot.Aep.Component.Router.RouterRequest OnIntercept (global::Com.Aliyun.Iot.Aep.Component.Router.RouterRequest p0)
			{
				if (id_onIntercept_Lcom_aliyun_iot_aep_component_router_RouterRequest_ == IntPtr.Zero)
					id_onIntercept_Lcom_aliyun_iot_aep_component_router_RouterRequest_ = JNIEnv.GetMethodID (class_ref, "onIntercept", "(Lcom/aliyun/iot/aep/component/router/RouterRequest;)Lcom/aliyun/iot/aep/component/router/RouterRequest;");
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				global::Com.Aliyun.Iot.Aep.Component.Router.RouterRequest __ret = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Iot.Aep.Component.Router.RouterRequest> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_onIntercept_Lcom_aliyun_iot_aep_component_router_RouterRequest_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			}

		}


		static readonly JniPeerMembers _members = new XAPeerMembers ("com/aliyun/iot/aep/component/router/Router", typeof (Router));
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

		protected Router (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		public static unsafe global::Com.Aliyun.Iot.Aep.Component.Router.Router Instance {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.iot.aep.component.router']/class[@name='Router']/method[@name='getInstance' and count(parameter)=0]"
			[Register ("getInstance", "()Lcom/aliyun/iot/aep/component/router/Router;", "")]
			get {
				const string __id = "getInstance.()Lcom/aliyun/iot/aep/component/router/Router;";
				try {
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
					return global::Java.Lang.Object.GetObject<global::Com.Aliyun.Iot.Aep.Component.Router.Router> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_addUrlInterceptor_Lcom_aliyun_iot_aep_component_router_Router_UrlInterceptor_;
#pragma warning disable 0169
		static Delegate GetAddUrlInterceptor_Lcom_aliyun_iot_aep_component_router_Router_UrlInterceptor_Handler ()
		{
			if (cb_addUrlInterceptor_Lcom_aliyun_iot_aep_component_router_Router_UrlInterceptor_ == null)
				cb_addUrlInterceptor_Lcom_aliyun_iot_aep_component_router_Router_UrlInterceptor_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_AddUrlInterceptor_Lcom_aliyun_iot_aep_component_router_Router_UrlInterceptor_);
			return cb_addUrlInterceptor_Lcom_aliyun_iot_aep_component_router_Router_UrlInterceptor_;
		}

		static void n_AddUrlInterceptor_Lcom_aliyun_iot_aep_component_router_Router_UrlInterceptor_ (IntPtr jnienv, IntPtr native__this, IntPtr native_interceptor)
		{
			global::Com.Aliyun.Iot.Aep.Component.Router.Router __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Iot.Aep.Component.Router.Router> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Aliyun.Iot.Aep.Component.Router.Router.IUrlInterceptor interceptor = (global::Com.Aliyun.Iot.Aep.Component.Router.Router.IUrlInterceptor)global::Java.Lang.Object.GetObject<global::Com.Aliyun.Iot.Aep.Component.Router.Router.IUrlInterceptor> (native_interceptor, JniHandleOwnership.DoNotTransfer);
			__this.AddUrlInterceptor (interceptor);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.iot.aep.component.router']/class[@name='Router']/method[@name='addUrlInterceptor' and count(parameter)=1 and parameter[1][@type='com.aliyun.iot.aep.component.router.Router.UrlInterceptor']]"
		[Register ("addUrlInterceptor", "(Lcom/aliyun/iot/aep/component/router/Router$UrlInterceptor;)V", "GetAddUrlInterceptor_Lcom_aliyun_iot_aep_component_router_Router_UrlInterceptor_Handler")]
		public virtual unsafe void AddUrlInterceptor (global::Com.Aliyun.Iot.Aep.Component.Router.Router.IUrlInterceptor interceptor)
		{
			const string __id = "addUrlInterceptor.(Lcom/aliyun/iot/aep/component/router/Router$UrlInterceptor;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((interceptor == null) ? IntPtr.Zero : ((global::Java.Lang.Object) interceptor).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_getModuleUrlHandler_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetGetModuleUrlHandler_Ljava_lang_String_Handler ()
		{
			if (cb_getModuleUrlHandler_Ljava_lang_String_ == null)
				cb_getModuleUrlHandler_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_GetModuleUrlHandler_Ljava_lang_String_);
			return cb_getModuleUrlHandler_Ljava_lang_String_;
		}

		static IntPtr n_GetModuleUrlHandler_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_url)
		{
			global::Com.Aliyun.Iot.Aep.Component.Router.Router __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Iot.Aep.Component.Router.Router> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string url = JNIEnv.GetString (native_url, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetModuleUrlHandler (url));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.iot.aep.component.router']/class[@name='Router']/method[@name='getModuleUrlHandler' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("getModuleUrlHandler", "(Ljava/lang/String;)Lcom/aliyun/iot/aep/component/router/IUrlHandler;", "GetGetModuleUrlHandler_Ljava_lang_String_Handler")]
		public virtual unsafe global::Com.Aliyun.Iot.Aep.Component.Router.IUrlHandler GetModuleUrlHandler (string url)
		{
			const string __id = "getModuleUrlHandler.(Ljava/lang/String;)Lcom/aliyun/iot/aep/component/router/IUrlHandler;";
			IntPtr native_url = JNIEnv.NewString (url);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_url);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Aliyun.Iot.Aep.Component.Router.IUrlHandler> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_url);
			}
		}

		static Delegate cb_registerModuleUrlHandler_Ljava_lang_String_Lcom_aliyun_iot_aep_component_router_IUrlHandler_;
#pragma warning disable 0169
		static Delegate GetRegisterModuleUrlHandler_Ljava_lang_String_Lcom_aliyun_iot_aep_component_router_IUrlHandler_Handler ()
		{
			if (cb_registerModuleUrlHandler_Ljava_lang_String_Lcom_aliyun_iot_aep_component_router_IUrlHandler_ == null)
				cb_registerModuleUrlHandler_Ljava_lang_String_Lcom_aliyun_iot_aep_component_router_IUrlHandler_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_RegisterModuleUrlHandler_Ljava_lang_String_Lcom_aliyun_iot_aep_component_router_IUrlHandler_);
			return cb_registerModuleUrlHandler_Ljava_lang_String_Lcom_aliyun_iot_aep_component_router_IUrlHandler_;
		}

		static void n_RegisterModuleUrlHandler_Ljava_lang_String_Lcom_aliyun_iot_aep_component_router_IUrlHandler_ (IntPtr jnienv, IntPtr native__this, IntPtr native_url, IntPtr native_handler)
		{
			global::Com.Aliyun.Iot.Aep.Component.Router.Router __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Iot.Aep.Component.Router.Router> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string url = JNIEnv.GetString (native_url, JniHandleOwnership.DoNotTransfer);
			global::Com.Aliyun.Iot.Aep.Component.Router.IUrlHandler handler = (global::Com.Aliyun.Iot.Aep.Component.Router.IUrlHandler)global::Java.Lang.Object.GetObject<global::Com.Aliyun.Iot.Aep.Component.Router.IUrlHandler> (native_handler, JniHandleOwnership.DoNotTransfer);
			__this.RegisterModuleUrlHandler (url, handler);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.iot.aep.component.router']/class[@name='Router']/method[@name='registerModuleUrlHandler' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='com.aliyun.iot.aep.component.router.IUrlHandler']]"
		[Register ("registerModuleUrlHandler", "(Ljava/lang/String;Lcom/aliyun/iot/aep/component/router/IUrlHandler;)V", "GetRegisterModuleUrlHandler_Ljava_lang_String_Lcom_aliyun_iot_aep_component_router_IUrlHandler_Handler")]
		public virtual unsafe void RegisterModuleUrlHandler (string url, global::Com.Aliyun.Iot.Aep.Component.Router.IUrlHandler handler)
		{
			const string __id = "registerModuleUrlHandler.(Ljava/lang/String;Lcom/aliyun/iot/aep/component/router/IUrlHandler;)V";
			IntPtr native_url = JNIEnv.NewString (url);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_url);
				__args [1] = new JniArgumentValue ((handler == null) ? IntPtr.Zero : ((global::Java.Lang.Object) handler).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_url);
			}
		}

		static Delegate cb_registerModuleUrlHandler_Ljava_util_List_Lcom_aliyun_iot_aep_component_router_IUrlHandler_;
#pragma warning disable 0169
		static Delegate GetRegisterModuleUrlHandler_Ljava_util_List_Lcom_aliyun_iot_aep_component_router_IUrlHandler_Handler ()
		{
			if (cb_registerModuleUrlHandler_Ljava_util_List_Lcom_aliyun_iot_aep_component_router_IUrlHandler_ == null)
				cb_registerModuleUrlHandler_Ljava_util_List_Lcom_aliyun_iot_aep_component_router_IUrlHandler_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_RegisterModuleUrlHandler_Ljava_util_List_Lcom_aliyun_iot_aep_component_router_IUrlHandler_);
			return cb_registerModuleUrlHandler_Ljava_util_List_Lcom_aliyun_iot_aep_component_router_IUrlHandler_;
		}

		static void n_RegisterModuleUrlHandler_Ljava_util_List_Lcom_aliyun_iot_aep_component_router_IUrlHandler_ (IntPtr jnienv, IntPtr native__this, IntPtr native_urls, IntPtr native_handler)
		{
			global::Com.Aliyun.Iot.Aep.Component.Router.Router __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Iot.Aep.Component.Router.Router> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var urls = global::Android.Runtime.JavaList<string>.FromJniHandle (native_urls, JniHandleOwnership.DoNotTransfer);
			global::Com.Aliyun.Iot.Aep.Component.Router.IUrlHandler handler = (global::Com.Aliyun.Iot.Aep.Component.Router.IUrlHandler)global::Java.Lang.Object.GetObject<global::Com.Aliyun.Iot.Aep.Component.Router.IUrlHandler> (native_handler, JniHandleOwnership.DoNotTransfer);
			__this.RegisterModuleUrlHandler (urls, handler);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.iot.aep.component.router']/class[@name='Router']/method[@name='registerModuleUrlHandler' and count(parameter)=2 and parameter[1][@type='java.util.List&lt;java.lang.String&gt;'] and parameter[2][@type='com.aliyun.iot.aep.component.router.IUrlHandler']]"
		[Register ("registerModuleUrlHandler", "(Ljava/util/List;Lcom/aliyun/iot/aep/component/router/IUrlHandler;)V", "GetRegisterModuleUrlHandler_Ljava_util_List_Lcom_aliyun_iot_aep_component_router_IUrlHandler_Handler")]
		public virtual unsafe void RegisterModuleUrlHandler (global::System.Collections.Generic.IList<string> urls, global::Com.Aliyun.Iot.Aep.Component.Router.IUrlHandler handler)
		{
			const string __id = "registerModuleUrlHandler.(Ljava/util/List;Lcom/aliyun/iot/aep/component/router/IUrlHandler;)V";
			IntPtr native_urls = global::Android.Runtime.JavaList<string>.ToLocalJniHandle (urls);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_urls);
				__args [1] = new JniArgumentValue ((handler == null) ? IntPtr.Zero : ((global::Java.Lang.Object) handler).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_urls);
			}
		}

		static Delegate cb_registerRegexUrlHandler_Ljava_lang_String_Lcom_aliyun_iot_aep_component_router_IUrlHandler_;
#pragma warning disable 0169
		static Delegate GetRegisterRegexUrlHandler_Ljava_lang_String_Lcom_aliyun_iot_aep_component_router_IUrlHandler_Handler ()
		{
			if (cb_registerRegexUrlHandler_Ljava_lang_String_Lcom_aliyun_iot_aep_component_router_IUrlHandler_ == null)
				cb_registerRegexUrlHandler_Ljava_lang_String_Lcom_aliyun_iot_aep_component_router_IUrlHandler_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_RegisterRegexUrlHandler_Ljava_lang_String_Lcom_aliyun_iot_aep_component_router_IUrlHandler_);
			return cb_registerRegexUrlHandler_Ljava_lang_String_Lcom_aliyun_iot_aep_component_router_IUrlHandler_;
		}

		static void n_RegisterRegexUrlHandler_Ljava_lang_String_Lcom_aliyun_iot_aep_component_router_IUrlHandler_ (IntPtr jnienv, IntPtr native__this, IntPtr native_regexUrl, IntPtr native_handler)
		{
			global::Com.Aliyun.Iot.Aep.Component.Router.Router __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Iot.Aep.Component.Router.Router> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string regexUrl = JNIEnv.GetString (native_regexUrl, JniHandleOwnership.DoNotTransfer);
			global::Com.Aliyun.Iot.Aep.Component.Router.IUrlHandler handler = (global::Com.Aliyun.Iot.Aep.Component.Router.IUrlHandler)global::Java.Lang.Object.GetObject<global::Com.Aliyun.Iot.Aep.Component.Router.IUrlHandler> (native_handler, JniHandleOwnership.DoNotTransfer);
			__this.RegisterRegexUrlHandler (regexUrl, handler);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.iot.aep.component.router']/class[@name='Router']/method[@name='registerRegexUrlHandler' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='com.aliyun.iot.aep.component.router.IUrlHandler']]"
		[Register ("registerRegexUrlHandler", "(Ljava/lang/String;Lcom/aliyun/iot/aep/component/router/IUrlHandler;)V", "GetRegisterRegexUrlHandler_Ljava_lang_String_Lcom_aliyun_iot_aep_component_router_IUrlHandler_Handler")]
		public virtual unsafe void RegisterRegexUrlHandler (string regexUrl, global::Com.Aliyun.Iot.Aep.Component.Router.IUrlHandler handler)
		{
			const string __id = "registerRegexUrlHandler.(Ljava/lang/String;Lcom/aliyun/iot/aep/component/router/IUrlHandler;)V";
			IntPtr native_regexUrl = JNIEnv.NewString (regexUrl);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_regexUrl);
				__args [1] = new JniArgumentValue ((handler == null) ? IntPtr.Zero : ((global::Java.Lang.Object) handler).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_regexUrl);
			}
		}

		static Delegate cb_removeUrlInterceptor_Lcom_aliyun_iot_aep_component_router_Router_UrlInterceptor_;
#pragma warning disable 0169
		static Delegate GetRemoveUrlInterceptor_Lcom_aliyun_iot_aep_component_router_Router_UrlInterceptor_Handler ()
		{
			if (cb_removeUrlInterceptor_Lcom_aliyun_iot_aep_component_router_Router_UrlInterceptor_ == null)
				cb_removeUrlInterceptor_Lcom_aliyun_iot_aep_component_router_Router_UrlInterceptor_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_RemoveUrlInterceptor_Lcom_aliyun_iot_aep_component_router_Router_UrlInterceptor_);
			return cb_removeUrlInterceptor_Lcom_aliyun_iot_aep_component_router_Router_UrlInterceptor_;
		}

		static void n_RemoveUrlInterceptor_Lcom_aliyun_iot_aep_component_router_Router_UrlInterceptor_ (IntPtr jnienv, IntPtr native__this, IntPtr native_interceptor)
		{
			global::Com.Aliyun.Iot.Aep.Component.Router.Router __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Iot.Aep.Component.Router.Router> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Aliyun.Iot.Aep.Component.Router.Router.IUrlInterceptor interceptor = (global::Com.Aliyun.Iot.Aep.Component.Router.Router.IUrlInterceptor)global::Java.Lang.Object.GetObject<global::Com.Aliyun.Iot.Aep.Component.Router.Router.IUrlInterceptor> (native_interceptor, JniHandleOwnership.DoNotTransfer);
			__this.RemoveUrlInterceptor (interceptor);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.iot.aep.component.router']/class[@name='Router']/method[@name='removeUrlInterceptor' and count(parameter)=1 and parameter[1][@type='com.aliyun.iot.aep.component.router.Router.UrlInterceptor']]"
		[Register ("removeUrlInterceptor", "(Lcom/aliyun/iot/aep/component/router/Router$UrlInterceptor;)V", "GetRemoveUrlInterceptor_Lcom_aliyun_iot_aep_component_router_Router_UrlInterceptor_Handler")]
		public virtual unsafe void RemoveUrlInterceptor (global::Com.Aliyun.Iot.Aep.Component.Router.Router.IUrlInterceptor interceptor)
		{
			const string __id = "removeUrlInterceptor.(Lcom/aliyun/iot/aep/component/router/Router$UrlInterceptor;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((interceptor == null) ? IntPtr.Zero : ((global::Java.Lang.Object) interceptor).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_setDefaultUrlHandler_Lcom_aliyun_iot_aep_component_router_DefaultUrlHandler_;
#pragma warning disable 0169
		static Delegate GetSetDefaultUrlHandler_Lcom_aliyun_iot_aep_component_router_DefaultUrlHandler_Handler ()
		{
			if (cb_setDefaultUrlHandler_Lcom_aliyun_iot_aep_component_router_DefaultUrlHandler_ == null)
				cb_setDefaultUrlHandler_Lcom_aliyun_iot_aep_component_router_DefaultUrlHandler_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetDefaultUrlHandler_Lcom_aliyun_iot_aep_component_router_DefaultUrlHandler_);
			return cb_setDefaultUrlHandler_Lcom_aliyun_iot_aep_component_router_DefaultUrlHandler_;
		}

		static void n_SetDefaultUrlHandler_Lcom_aliyun_iot_aep_component_router_DefaultUrlHandler_ (IntPtr jnienv, IntPtr native__this, IntPtr native_defaultUrlHandler)
		{
			global::Com.Aliyun.Iot.Aep.Component.Router.Router __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Iot.Aep.Component.Router.Router> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Aliyun.Iot.Aep.Component.Router.DefaultUrlHandler defaultUrlHandler = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Iot.Aep.Component.Router.DefaultUrlHandler> (native_defaultUrlHandler, JniHandleOwnership.DoNotTransfer);
			__this.SetDefaultUrlHandler (defaultUrlHandler);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.iot.aep.component.router']/class[@name='Router']/method[@name='setDefaultUrlHandler' and count(parameter)=1 and parameter[1][@type='com.aliyun.iot.aep.component.router.DefaultUrlHandler']]"
		[Register ("setDefaultUrlHandler", "(Lcom/aliyun/iot/aep/component/router/DefaultUrlHandler;)V", "GetSetDefaultUrlHandler_Lcom_aliyun_iot_aep_component_router_DefaultUrlHandler_Handler")]
		public virtual unsafe void SetDefaultUrlHandler (global::Com.Aliyun.Iot.Aep.Component.Router.DefaultUrlHandler defaultUrlHandler)
		{
			const string __id = "setDefaultUrlHandler.(Lcom/aliyun/iot/aep/component/router/DefaultUrlHandler;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((defaultUrlHandler == null) ? IntPtr.Zero : ((global::Java.Lang.Object) defaultUrlHandler).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_toUrl_Landroid_content_Context_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetToUrl_Landroid_content_Context_Ljava_lang_String_Handler ()
		{
			if (cb_toUrl_Landroid_content_Context_Ljava_lang_String_ == null)
				cb_toUrl_Landroid_content_Context_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, bool>) n_ToUrl_Landroid_content_Context_Ljava_lang_String_);
			return cb_toUrl_Landroid_content_Context_Ljava_lang_String_;
		}

		static bool n_ToUrl_Landroid_content_Context_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_context, IntPtr native_url)
		{
			global::Com.Aliyun.Iot.Aep.Component.Router.Router __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Iot.Aep.Component.Router.Router> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.Context context = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (native_context, JniHandleOwnership.DoNotTransfer);
			string url = JNIEnv.GetString (native_url, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.ToUrl (context, url);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.iot.aep.component.router']/class[@name='Router']/method[@name='toUrl' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.String']]"
		[Register ("toUrl", "(Landroid/content/Context;Ljava/lang/String;)Z", "GetToUrl_Landroid_content_Context_Ljava_lang_String_Handler")]
		public virtual unsafe bool ToUrl (global::Android.Content.Context context, string url)
		{
			const string __id = "toUrl.(Landroid/content/Context;Ljava/lang/String;)Z";
			IntPtr native_url = JNIEnv.NewString (url);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((context == null) ? IntPtr.Zero : ((global::Java.Lang.Object) context).Handle);
				__args [1] = new JniArgumentValue (native_url);
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
				JNIEnv.DeleteLocalRef (native_url);
			}
		}

		static Delegate cb_toUrl_Landroid_content_Context_Ljava_lang_String_Landroid_os_Bundle_;
#pragma warning disable 0169
		static Delegate GetToUrl_Landroid_content_Context_Ljava_lang_String_Landroid_os_Bundle_Handler ()
		{
			if (cb_toUrl_Landroid_content_Context_Ljava_lang_String_Landroid_os_Bundle_ == null)
				cb_toUrl_Landroid_content_Context_Ljava_lang_String_Landroid_os_Bundle_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, bool>) n_ToUrl_Landroid_content_Context_Ljava_lang_String_Landroid_os_Bundle_);
			return cb_toUrl_Landroid_content_Context_Ljava_lang_String_Landroid_os_Bundle_;
		}

		static bool n_ToUrl_Landroid_content_Context_Ljava_lang_String_Landroid_os_Bundle_ (IntPtr jnienv, IntPtr native__this, IntPtr native_context, IntPtr native_url, IntPtr native_bundle)
		{
			global::Com.Aliyun.Iot.Aep.Component.Router.Router __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Iot.Aep.Component.Router.Router> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.Context context = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (native_context, JniHandleOwnership.DoNotTransfer);
			string url = JNIEnv.GetString (native_url, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.Bundle bundle = global::Java.Lang.Object.GetObject<global::Android.OS.Bundle> (native_bundle, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.ToUrl (context, url, bundle);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.iot.aep.component.router']/class[@name='Router']/method[@name='toUrl' and count(parameter)=3 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='android.os.Bundle']]"
		[Register ("toUrl", "(Landroid/content/Context;Ljava/lang/String;Landroid/os/Bundle;)Z", "GetToUrl_Landroid_content_Context_Ljava_lang_String_Landroid_os_Bundle_Handler")]
		public virtual unsafe bool ToUrl (global::Android.Content.Context context, string url, global::Android.OS.Bundle bundle)
		{
			const string __id = "toUrl.(Landroid/content/Context;Ljava/lang/String;Landroid/os/Bundle;)Z";
			IntPtr native_url = JNIEnv.NewString (url);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((context == null) ? IntPtr.Zero : ((global::Java.Lang.Object) context).Handle);
				__args [1] = new JniArgumentValue (native_url);
				__args [2] = new JniArgumentValue ((bundle == null) ? IntPtr.Zero : ((global::Java.Lang.Object) bundle).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
				JNIEnv.DeleteLocalRef (native_url);
			}
		}

		static Delegate cb_toUrl_Landroid_content_Context_Ljava_lang_String_Landroid_os_Bundle_I;
#pragma warning disable 0169
		static Delegate GetToUrl_Landroid_content_Context_Ljava_lang_String_Landroid_os_Bundle_IHandler ()
		{
			if (cb_toUrl_Landroid_content_Context_Ljava_lang_String_Landroid_os_Bundle_I == null)
				cb_toUrl_Landroid_content_Context_Ljava_lang_String_Landroid_os_Bundle_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, int, bool>) n_ToUrl_Landroid_content_Context_Ljava_lang_String_Landroid_os_Bundle_I);
			return cb_toUrl_Landroid_content_Context_Ljava_lang_String_Landroid_os_Bundle_I;
		}

		static bool n_ToUrl_Landroid_content_Context_Ljava_lang_String_Landroid_os_Bundle_I (IntPtr jnienv, IntPtr native__this, IntPtr native_context, IntPtr native_url, IntPtr native_bundle, int requestCode)
		{
			global::Com.Aliyun.Iot.Aep.Component.Router.Router __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Iot.Aep.Component.Router.Router> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.Context context = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (native_context, JniHandleOwnership.DoNotTransfer);
			string url = JNIEnv.GetString (native_url, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.Bundle bundle = global::Java.Lang.Object.GetObject<global::Android.OS.Bundle> (native_bundle, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.ToUrl (context, url, bundle, requestCode);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.iot.aep.component.router']/class[@name='Router']/method[@name='toUrl' and count(parameter)=4 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='android.os.Bundle'] and parameter[4][@type='int']]"
		[Register ("toUrl", "(Landroid/content/Context;Ljava/lang/String;Landroid/os/Bundle;I)Z", "GetToUrl_Landroid_content_Context_Ljava_lang_String_Landroid_os_Bundle_IHandler")]
		public virtual unsafe bool ToUrl (global::Android.Content.Context context, string url, global::Android.OS.Bundle bundle, int requestCode)
		{
			const string __id = "toUrl.(Landroid/content/Context;Ljava/lang/String;Landroid/os/Bundle;I)Z";
			IntPtr native_url = JNIEnv.NewString (url);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue ((context == null) ? IntPtr.Zero : ((global::Java.Lang.Object) context).Handle);
				__args [1] = new JniArgumentValue (native_url);
				__args [2] = new JniArgumentValue ((bundle == null) ? IntPtr.Zero : ((global::Java.Lang.Object) bundle).Handle);
				__args [3] = new JniArgumentValue (requestCode);
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
				JNIEnv.DeleteLocalRef (native_url);
			}
		}

		static Delegate cb_toUrl_Landroid_content_Context_Ljava_lang_String_Landroid_os_Bundle_ILcom_aliyun_iot_aep_component_router_IAsyncHandlerCallback_;
#pragma warning disable 0169
		static Delegate GetToUrl_Landroid_content_Context_Ljava_lang_String_Landroid_os_Bundle_ILcom_aliyun_iot_aep_component_router_IAsyncHandlerCallback_Handler ()
		{
			if (cb_toUrl_Landroid_content_Context_Ljava_lang_String_Landroid_os_Bundle_ILcom_aliyun_iot_aep_component_router_IAsyncHandlerCallback_ == null)
				cb_toUrl_Landroid_content_Context_Ljava_lang_String_Landroid_os_Bundle_ILcom_aliyun_iot_aep_component_router_IAsyncHandlerCallback_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, int, IntPtr, bool>) n_ToUrl_Landroid_content_Context_Ljava_lang_String_Landroid_os_Bundle_ILcom_aliyun_iot_aep_component_router_IAsyncHandlerCallback_);
			return cb_toUrl_Landroid_content_Context_Ljava_lang_String_Landroid_os_Bundle_ILcom_aliyun_iot_aep_component_router_IAsyncHandlerCallback_;
		}

		static bool n_ToUrl_Landroid_content_Context_Ljava_lang_String_Landroid_os_Bundle_ILcom_aliyun_iot_aep_component_router_IAsyncHandlerCallback_ (IntPtr jnienv, IntPtr native__this, IntPtr native_context, IntPtr native_url, IntPtr native_bundle, int requestCode, IntPtr native__callback)
		{
			global::Com.Aliyun.Iot.Aep.Component.Router.Router __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Iot.Aep.Component.Router.Router> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.Context context = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (native_context, JniHandleOwnership.DoNotTransfer);
			string url = JNIEnv.GetString (native_url, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.Bundle bundle = global::Java.Lang.Object.GetObject<global::Android.OS.Bundle> (native_bundle, JniHandleOwnership.DoNotTransfer);
			global::Com.Aliyun.Iot.Aep.Component.Router.IAsyncHandlerCallback @callback = (global::Com.Aliyun.Iot.Aep.Component.Router.IAsyncHandlerCallback)global::Java.Lang.Object.GetObject<global::Com.Aliyun.Iot.Aep.Component.Router.IAsyncHandlerCallback> (native__callback, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.ToUrl (context, url, bundle, requestCode, @callback);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.iot.aep.component.router']/class[@name='Router']/method[@name='toUrl' and count(parameter)=5 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='android.os.Bundle'] and parameter[4][@type='int'] and parameter[5][@type='com.aliyun.iot.aep.component.router.IAsyncHandlerCallback']]"
		[Register ("toUrl", "(Landroid/content/Context;Ljava/lang/String;Landroid/os/Bundle;ILcom/aliyun/iot/aep/component/router/IAsyncHandlerCallback;)Z", "GetToUrl_Landroid_content_Context_Ljava_lang_String_Landroid_os_Bundle_ILcom_aliyun_iot_aep_component_router_IAsyncHandlerCallback_Handler")]
		public virtual unsafe bool ToUrl (global::Android.Content.Context context, string url, global::Android.OS.Bundle bundle, int requestCode, global::Com.Aliyun.Iot.Aep.Component.Router.IAsyncHandlerCallback @callback)
		{
			const string __id = "toUrl.(Landroid/content/Context;Ljava/lang/String;Landroid/os/Bundle;ILcom/aliyun/iot/aep/component/router/IAsyncHandlerCallback;)Z";
			IntPtr native_url = JNIEnv.NewString (url);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [5];
				__args [0] = new JniArgumentValue ((context == null) ? IntPtr.Zero : ((global::Java.Lang.Object) context).Handle);
				__args [1] = new JniArgumentValue (native_url);
				__args [2] = new JniArgumentValue ((bundle == null) ? IntPtr.Zero : ((global::Java.Lang.Object) bundle).Handle);
				__args [3] = new JniArgumentValue (requestCode);
				__args [4] = new JniArgumentValue ((@callback == null) ? IntPtr.Zero : ((global::Java.Lang.Object) @callback).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
				JNIEnv.DeleteLocalRef (native_url);
			}
		}

		static Delegate cb_toUrlForResult_Landroid_app_Activity_Ljava_lang_String_I;
#pragma warning disable 0169
		static Delegate GetToUrlForResult_Landroid_app_Activity_Ljava_lang_String_IHandler ()
		{
			if (cb_toUrlForResult_Landroid_app_Activity_Ljava_lang_String_I == null)
				cb_toUrlForResult_Landroid_app_Activity_Ljava_lang_String_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, int, bool>) n_ToUrlForResult_Landroid_app_Activity_Ljava_lang_String_I);
			return cb_toUrlForResult_Landroid_app_Activity_Ljava_lang_String_I;
		}

		static bool n_ToUrlForResult_Landroid_app_Activity_Ljava_lang_String_I (IntPtr jnienv, IntPtr native__this, IntPtr native_act, IntPtr native_url, int requestCode)
		{
			global::Com.Aliyun.Iot.Aep.Component.Router.Router __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Iot.Aep.Component.Router.Router> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.App.Activity act = global::Java.Lang.Object.GetObject<global::Android.App.Activity> (native_act, JniHandleOwnership.DoNotTransfer);
			string url = JNIEnv.GetString (native_url, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.ToUrlForResult (act, url, requestCode);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.iot.aep.component.router']/class[@name='Router']/method[@name='toUrlForResult' and count(parameter)=3 and parameter[1][@type='android.app.Activity'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='int']]"
		[Register ("toUrlForResult", "(Landroid/app/Activity;Ljava/lang/String;I)Z", "GetToUrlForResult_Landroid_app_Activity_Ljava_lang_String_IHandler")]
		public virtual unsafe bool ToUrlForResult (global::Android.App.Activity act, string url, int requestCode)
		{
			const string __id = "toUrlForResult.(Landroid/app/Activity;Ljava/lang/String;I)Z";
			IntPtr native_url = JNIEnv.NewString (url);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((act == null) ? IntPtr.Zero : ((global::Java.Lang.Object) act).Handle);
				__args [1] = new JniArgumentValue (native_url);
				__args [2] = new JniArgumentValue (requestCode);
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
				JNIEnv.DeleteLocalRef (native_url);
			}
		}

		static Delegate cb_toUrlForResult_Landroid_app_Activity_Ljava_lang_String_ILandroid_os_Bundle_;
#pragma warning disable 0169
		static Delegate GetToUrlForResult_Landroid_app_Activity_Ljava_lang_String_ILandroid_os_Bundle_Handler ()
		{
			if (cb_toUrlForResult_Landroid_app_Activity_Ljava_lang_String_ILandroid_os_Bundle_ == null)
				cb_toUrlForResult_Landroid_app_Activity_Ljava_lang_String_ILandroid_os_Bundle_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, int, IntPtr, bool>) n_ToUrlForResult_Landroid_app_Activity_Ljava_lang_String_ILandroid_os_Bundle_);
			return cb_toUrlForResult_Landroid_app_Activity_Ljava_lang_String_ILandroid_os_Bundle_;
		}

		static bool n_ToUrlForResult_Landroid_app_Activity_Ljava_lang_String_ILandroid_os_Bundle_ (IntPtr jnienv, IntPtr native__this, IntPtr native_act, IntPtr native_url, int requestCode, IntPtr native_bundle)
		{
			global::Com.Aliyun.Iot.Aep.Component.Router.Router __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Iot.Aep.Component.Router.Router> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.App.Activity act = global::Java.Lang.Object.GetObject<global::Android.App.Activity> (native_act, JniHandleOwnership.DoNotTransfer);
			string url = JNIEnv.GetString (native_url, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.Bundle bundle = global::Java.Lang.Object.GetObject<global::Android.OS.Bundle> (native_bundle, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.ToUrlForResult (act, url, requestCode, bundle);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.iot.aep.component.router']/class[@name='Router']/method[@name='toUrlForResult' and count(parameter)=4 and parameter[1][@type='android.app.Activity'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='int'] and parameter[4][@type='android.os.Bundle']]"
		[Register ("toUrlForResult", "(Landroid/app/Activity;Ljava/lang/String;ILandroid/os/Bundle;)Z", "GetToUrlForResult_Landroid_app_Activity_Ljava_lang_String_ILandroid_os_Bundle_Handler")]
		public virtual unsafe bool ToUrlForResult (global::Android.App.Activity act, string url, int requestCode, global::Android.OS.Bundle bundle)
		{
			const string __id = "toUrlForResult.(Landroid/app/Activity;Ljava/lang/String;ILandroid/os/Bundle;)Z";
			IntPtr native_url = JNIEnv.NewString (url);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue ((act == null) ? IntPtr.Zero : ((global::Java.Lang.Object) act).Handle);
				__args [1] = new JniArgumentValue (native_url);
				__args [2] = new JniArgumentValue (requestCode);
				__args [3] = new JniArgumentValue ((bundle == null) ? IntPtr.Zero : ((global::Java.Lang.Object) bundle).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
				JNIEnv.DeleteLocalRef (native_url);
			}
		}

	}
}
