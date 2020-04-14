using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Aliyun.Iot.Aep.Routerexternal {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.aliyun.iot.aep.routerexternal']/class[@name='RouterExternal']"
	[global::Android.Runtime.Register ("com/aliyun/iot/aep/routerexternal/RouterExternal", DoNotGenerateAcw=true)]
	public partial class RouterExternal : global::Java.Lang.Object {

		// Metadata.xml XPath class reference: path="/api/package[@name='com.aliyun.iot.aep.routerexternal']/class[@name='RouterExternal.SingletonHolder']"
		[global::Android.Runtime.Register ("com/aliyun/iot/aep/routerexternal/RouterExternal$SingletonHolder", DoNotGenerateAcw=true)]
		public partial class SingletonHolder : global::Java.Lang.Object {

			static readonly JniPeerMembers _members = new XAPeerMembers ("com/aliyun/iot/aep/routerexternal/RouterExternal$SingletonHolder", typeof (SingletonHolder));
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

			protected SingletonHolder (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/aliyun/iot/aep/routerexternal/RouterExternal", typeof (RouterExternal));
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

		protected RouterExternal (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		public static unsafe global::Com.Aliyun.Iot.Aep.Routerexternal.RouterExternal Instance {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.iot.aep.routerexternal']/class[@name='RouterExternal']/method[@name='getInstance' and count(parameter)=0]"
			[Register ("getInstance", "()Lcom/aliyun/iot/aep/routerexternal/RouterExternal;", "")]
			get {
				const string __id = "getInstance.()Lcom/aliyun/iot/aep/routerexternal/RouterExternal;";
				try {
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
					return global::Java.Lang.Object.GetObject<global::Com.Aliyun.Iot.Aep.Routerexternal.RouterExternal> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_init_Landroid_content_Context_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetInit_Landroid_content_Context_Ljava_lang_String_Handler ()
		{
			if (cb_init_Landroid_content_Context_Ljava_lang_String_ == null)
				cb_init_Landroid_content_Context_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_Init_Landroid_content_Context_Ljava_lang_String_);
			return cb_init_Landroid_content_Context_Ljava_lang_String_;
		}

		static void n_Init_Landroid_content_Context_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Aliyun.Iot.Aep.Routerexternal.RouterExternal __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Iot.Aep.Routerexternal.RouterExternal> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.Context p0 = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.Init (p0, p1);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.iot.aep.routerexternal']/class[@name='RouterExternal']/method[@name='init' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.String']]"
		[Register ("init", "(Landroid/content/Context;Ljava/lang/String;)V", "GetInit_Landroid_content_Context_Ljava_lang_String_Handler")]
		public virtual unsafe void Init (global::Android.Content.Context p0, string p1)
		{
			const string __id = "init.(Landroid/content/Context;Ljava/lang/String;)V";
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue (native_p1);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static Delegate cb_registerNativeCodeUrl_Ljava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetRegisterNativeCodeUrl_Ljava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_registerNativeCodeUrl_Ljava_lang_String_Ljava_lang_String_ == null)
				cb_registerNativeCodeUrl_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_RegisterNativeCodeUrl_Ljava_lang_String_Ljava_lang_String_);
			return cb_registerNativeCodeUrl_Ljava_lang_String_Ljava_lang_String_;
		}

		static void n_RegisterNativeCodeUrl_Ljava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Aliyun.Iot.Aep.Routerexternal.RouterExternal __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Iot.Aep.Routerexternal.RouterExternal> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.RegisterNativeCodeUrl (p0, p1);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.iot.aep.routerexternal']/class[@name='RouterExternal']/method[@name='registerNativeCodeUrl' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("registerNativeCodeUrl", "(Ljava/lang/String;Ljava/lang/String;)V", "GetRegisterNativeCodeUrl_Ljava_lang_String_Ljava_lang_String_Handler")]
		public virtual unsafe void RegisterNativeCodeUrl (string p0, string p1)
		{
			const string __id = "registerNativeCodeUrl.(Ljava/lang/String;Ljava/lang/String;)V";
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_p0);
				__args [1] = new JniArgumentValue (native_p1);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static Delegate cb_registerNativePages_Ljava_util_List_Lcom_aliyun_iot_aep_component_router_IUrlHandler_;
#pragma warning disable 0169
		static Delegate GetRegisterNativePages_Ljava_util_List_Lcom_aliyun_iot_aep_component_router_IUrlHandler_Handler ()
		{
			if (cb_registerNativePages_Ljava_util_List_Lcom_aliyun_iot_aep_component_router_IUrlHandler_ == null)
				cb_registerNativePages_Ljava_util_List_Lcom_aliyun_iot_aep_component_router_IUrlHandler_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_RegisterNativePages_Ljava_util_List_Lcom_aliyun_iot_aep_component_router_IUrlHandler_);
			return cb_registerNativePages_Ljava_util_List_Lcom_aliyun_iot_aep_component_router_IUrlHandler_;
		}

		static void n_RegisterNativePages_Ljava_util_List_Lcom_aliyun_iot_aep_component_router_IUrlHandler_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Aliyun.Iot.Aep.Routerexternal.RouterExternal __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Iot.Aep.Routerexternal.RouterExternal> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Android.Runtime.JavaList<string>.FromJniHandle (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Com.Aliyun.Iot.Aep.Component.Router.IUrlHandler p1 = (global::Com.Aliyun.Iot.Aep.Component.Router.IUrlHandler)global::Java.Lang.Object.GetObject<global::Com.Aliyun.Iot.Aep.Component.Router.IUrlHandler> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.RegisterNativePages (p0, p1);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.iot.aep.routerexternal']/class[@name='RouterExternal']/method[@name='registerNativePages' and count(parameter)=2 and parameter[1][@type='java.util.List&lt;java.lang.String&gt;'] and parameter[2][@type='com.aliyun.iot.aep.component.router.IUrlHandler']]"
		[Register ("registerNativePages", "(Ljava/util/List;Lcom/aliyun/iot/aep/component/router/IUrlHandler;)V", "GetRegisterNativePages_Ljava_util_List_Lcom_aliyun_iot_aep_component_router_IUrlHandler_Handler")]
		public virtual unsafe void RegisterNativePages (global::System.Collections.Generic.IList<string> p0, global::Com.Aliyun.Iot.Aep.Component.Router.IUrlHandler p1)
		{
			const string __id = "registerNativePages.(Ljava/util/List;Lcom/aliyun/iot/aep/component/router/IUrlHandler;)V";
			IntPtr native_p0 = global::Android.Runtime.JavaList<string>.ToLocalJniHandle (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_p0);
				__args [1] = new JniArgumentValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_removeRouterCache_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetRemoveRouterCache_Ljava_lang_String_Handler ()
		{
			if (cb_removeRouterCache_Ljava_lang_String_ == null)
				cb_removeRouterCache_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_RemoveRouterCache_Ljava_lang_String_);
			return cb_removeRouterCache_Ljava_lang_String_;
		}

		static void n_RemoveRouterCache_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Aliyun.Iot.Aep.Routerexternal.RouterExternal __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Iot.Aep.Routerexternal.RouterExternal> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.RemoveRouterCache (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.iot.aep.routerexternal']/class[@name='RouterExternal']/method[@name='removeRouterCache' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("removeRouterCache", "(Ljava/lang/String;)V", "GetRemoveRouterCache_Ljava_lang_String_Handler")]
		public virtual unsafe void RemoveRouterCache (string p0)
		{
			const string __id = "removeRouterCache.(Ljava/lang/String;)V";
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_p0);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

	}
}
