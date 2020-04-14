using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Aliyun.Alink.Linksdk.Tools.Log {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.aliyun.alink.linksdk.tools.log']/class[@name='HLoggerFactory']"
	[global::Android.Runtime.Register ("com/aliyun/alink/linksdk/tools/log/HLoggerFactory", DoNotGenerateAcw=true)]
	public partial class HLoggerFactory : global::Java.Lang.Object {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/aliyun/alink/linksdk/tools/log/HLoggerFactory", typeof (HLoggerFactory));
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

		protected HLoggerFactory (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.aliyun.alink.linksdk.tools.log']/class[@name='HLoggerFactory']/constructor[@name='HLoggerFactory' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe HLoggerFactory ()
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

		static Delegate cb_getInstance_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetGetInstance_Ljava_lang_String_Handler ()
		{
			if (cb_getInstance_Ljava_lang_String_ == null)
				cb_getInstance_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_GetInstance_Ljava_lang_String_);
			return cb_getInstance_Ljava_lang_String_;
		}

		static IntPtr n_GetInstance_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_name)
		{
			global::Com.Aliyun.Alink.Linksdk.Tools.Log.HLoggerFactory __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Tools.Log.HLoggerFactory> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string name = JNIEnv.GetString (native_name, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetInstance (name));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.tools.log']/class[@name='HLoggerFactory']/method[@name='getInstance' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("getInstance", "(Ljava/lang/String;)Lcom/aliyun/alink/linksdk/tools/log/ILogger;", "GetGetInstance_Ljava_lang_String_Handler")]
		public virtual unsafe global::Com.Aliyun.Alink.Linksdk.Tools.Log.ILogger GetInstance (string name)
		{
			const string __id = "getInstance.(Ljava/lang/String;)Lcom/aliyun/alink/linksdk/tools/log/ILogger;";
			IntPtr native_name = JNIEnv.NewString (name);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_name);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Tools.Log.ILogger> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_name);
			}
		}

		static Delegate cb_setLogger_Lcom_aliyun_alink_linksdk_tools_log_ILogger_;
#pragma warning disable 0169
		static Delegate GetSetLogger_Lcom_aliyun_alink_linksdk_tools_log_ILogger_Handler ()
		{
			if (cb_setLogger_Lcom_aliyun_alink_linksdk_tools_log_ILogger_ == null)
				cb_setLogger_Lcom_aliyun_alink_linksdk_tools_log_ILogger_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetLogger_Lcom_aliyun_alink_linksdk_tools_log_ILogger_);
			return cb_setLogger_Lcom_aliyun_alink_linksdk_tools_log_ILogger_;
		}

		static void n_SetLogger_Lcom_aliyun_alink_linksdk_tools_log_ILogger_ (IntPtr jnienv, IntPtr native__this, IntPtr native_logger)
		{
			global::Com.Aliyun.Alink.Linksdk.Tools.Log.HLoggerFactory __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Tools.Log.HLoggerFactory> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Aliyun.Alink.Linksdk.Tools.Log.ILogger logger = (global::Com.Aliyun.Alink.Linksdk.Tools.Log.ILogger)global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Tools.Log.ILogger> (native_logger, JniHandleOwnership.DoNotTransfer);
			__this.SetLogger (logger);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.tools.log']/class[@name='HLoggerFactory']/method[@name='setLogger' and count(parameter)=1 and parameter[1][@type='com.aliyun.alink.linksdk.tools.log.ILogger']]"
		[Register ("setLogger", "(Lcom/aliyun/alink/linksdk/tools/log/ILogger;)V", "GetSetLogger_Lcom_aliyun_alink_linksdk_tools_log_ILogger_Handler")]
		public virtual unsafe void SetLogger (global::Com.Aliyun.Alink.Linksdk.Tools.Log.ILogger logger)
		{
			const string __id = "setLogger.(Lcom/aliyun/alink/linksdk/tools/log/ILogger;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((logger == null) ? IntPtr.Zero : ((global::Java.Lang.Object) logger).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

	}
}
