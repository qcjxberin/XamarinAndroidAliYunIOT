using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Aliyun.Iot.Aep.Sdk.Init {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.aliyun.iot.aep.sdk.init']/class[@name='PushManagerHelper']"
	[global::Android.Runtime.Register ("com/aliyun/iot/aep/sdk/init/PushManagerHelper", DoNotGenerateAcw=true)]
	public partial class PushManagerHelper : global::Java.Lang.Object {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/aliyun/iot/aep/sdk/init/PushManagerHelper", typeof (PushManagerHelper));
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

		protected PushManagerHelper (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		public static unsafe global::Com.Aliyun.Iot.Aep.Sdk.Init.PushManagerHelper Instance {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.iot.aep.sdk.init']/class[@name='PushManagerHelper']/method[@name='getInstance' and count(parameter)=0]"
			[Register ("getInstance", "()Lcom/aliyun/iot/aep/sdk/init/PushManagerHelper;", "")]
			get {
				const string __id = "getInstance.()Lcom/aliyun/iot/aep/sdk/init/PushManagerHelper;";
				try {
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
					return global::Java.Lang.Object.GetObject<global::Com.Aliyun.Iot.Aep.Sdk.Init.PushManagerHelper> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_bindUser;
#pragma warning disable 0169
		static Delegate GetBindUserHandler ()
		{
			if (cb_bindUser == null)
				cb_bindUser = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_BindUser);
			return cb_bindUser;
		}

		static void n_BindUser (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Aliyun.Iot.Aep.Sdk.Init.PushManagerHelper __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Iot.Aep.Sdk.Init.PushManagerHelper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.BindUser ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.iot.aep.sdk.init']/class[@name='PushManagerHelper']/method[@name='bindUser' and count(parameter)=0]"
		[Register ("bindUser", "()V", "GetBindUserHandler")]
		public virtual unsafe void BindUser ()
		{
			const string __id = "bindUser.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_init_Landroid_app_Application_;
#pragma warning disable 0169
		static Delegate GetInit_Landroid_app_Application_Handler ()
		{
			if (cb_init_Landroid_app_Application_ == null)
				cb_init_Landroid_app_Application_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_Init_Landroid_app_Application_);
			return cb_init_Landroid_app_Application_;
		}

		static void n_Init_Landroid_app_Application_ (IntPtr jnienv, IntPtr native__this, IntPtr native_app)
		{
			global::Com.Aliyun.Iot.Aep.Sdk.Init.PushManagerHelper __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Iot.Aep.Sdk.Init.PushManagerHelper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.App.Application app = global::Java.Lang.Object.GetObject<global::Android.App.Application> (native_app, JniHandleOwnership.DoNotTransfer);
			__this.Init (app);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.iot.aep.sdk.init']/class[@name='PushManagerHelper']/method[@name='init' and count(parameter)=1 and parameter[1][@type='android.app.Application']]"
		[Register ("init", "(Landroid/app/Application;)V", "GetInit_Landroid_app_Application_Handler")]
		public virtual unsafe void Init (global::Android.App.Application app)
		{
			const string __id = "init.(Landroid/app/Application;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((app == null) ? IntPtr.Zero : ((global::Java.Lang.Object) app).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_initPush_Landroid_app_Application_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetInitPush_Landroid_app_Application_Ljava_lang_String_Handler ()
		{
			if (cb_initPush_Landroid_app_Application_Ljava_lang_String_ == null)
				cb_initPush_Landroid_app_Application_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_InitPush_Landroid_app_Application_Ljava_lang_String_);
			return cb_initPush_Landroid_app_Application_Ljava_lang_String_;
		}

		static void n_InitPush_Landroid_app_Application_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_app, IntPtr native_regionName)
		{
			global::Com.Aliyun.Iot.Aep.Sdk.Init.PushManagerHelper __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Iot.Aep.Sdk.Init.PushManagerHelper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.App.Application app = global::Java.Lang.Object.GetObject<global::Android.App.Application> (native_app, JniHandleOwnership.DoNotTransfer);
			string regionName = JNIEnv.GetString (native_regionName, JniHandleOwnership.DoNotTransfer);
			__this.InitPush (app, regionName);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.iot.aep.sdk.init']/class[@name='PushManagerHelper']/method[@name='initPush' and count(parameter)=2 and parameter[1][@type='android.app.Application'] and parameter[2][@type='java.lang.String']]"
		[Register ("initPush", "(Landroid/app/Application;Ljava/lang/String;)V", "GetInitPush_Landroid_app_Application_Ljava_lang_String_Handler")]
		public virtual unsafe void InitPush (global::Android.App.Application app, string regionName)
		{
			const string __id = "initPush.(Landroid/app/Application;Ljava/lang/String;)V";
			IntPtr native_regionName = JNIEnv.NewString (regionName);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((app == null) ? IntPtr.Zero : ((global::Java.Lang.Object) app).Handle);
				__args [1] = new JniArgumentValue (native_regionName);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_regionName);
			}
		}

		static Delegate cb_unbindUser;
#pragma warning disable 0169
		static Delegate GetUnbindUserHandler ()
		{
			if (cb_unbindUser == null)
				cb_unbindUser = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_UnbindUser);
			return cb_unbindUser;
		}

		static void n_UnbindUser (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Aliyun.Iot.Aep.Sdk.Init.PushManagerHelper __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Iot.Aep.Sdk.Init.PushManagerHelper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.UnbindUser ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.iot.aep.sdk.init']/class[@name='PushManagerHelper']/method[@name='unbindUser' and count(parameter)=0]"
		[Register ("unbindUser", "()V", "GetUnbindUserHandler")]
		public virtual unsafe void UnbindUser ()
		{
			const string __id = "unbindUser.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

	}
}
