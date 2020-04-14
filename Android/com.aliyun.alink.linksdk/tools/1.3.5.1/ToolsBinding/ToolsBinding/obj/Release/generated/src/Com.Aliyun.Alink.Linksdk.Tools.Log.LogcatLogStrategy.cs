using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Aliyun.Alink.Linksdk.Tools.Log {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.aliyun.alink.linksdk.tools.log']/class[@name='LogcatLogStrategy']"
	[global::Android.Runtime.Register ("com/aliyun/alink/linksdk/tools/log/LogcatLogStrategy", DoNotGenerateAcw=true)]
	public partial class LogcatLogStrategy : global::Java.Lang.Object, global::Com.Aliyun.Alink.Linksdk.Tools.Log.ILogStrategy {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/aliyun/alink/linksdk/tools/log/LogcatLogStrategy", typeof (LogcatLogStrategy));
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

		protected LogcatLogStrategy (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.aliyun.alink.linksdk.tools.log']/class[@name='LogcatLogStrategy']/constructor[@name='LogcatLogStrategy' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe LogcatLogStrategy ()
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

		static Delegate cb_isSupport;
#pragma warning disable 0169
		static Delegate GetIsSupportHandler ()
		{
			if (cb_isSupport == null)
				cb_isSupport = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsSupport);
			return cb_isSupport;
		}

		static bool n_IsSupport (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Aliyun.Alink.Linksdk.Tools.Log.LogcatLogStrategy __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Tools.Log.LogcatLogStrategy> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsSupport;
		}
#pragma warning restore 0169

		public virtual unsafe bool IsSupport {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.tools.log']/class[@name='LogcatLogStrategy']/method[@name='isSupport' and count(parameter)=0]"
			[Register ("isSupport", "()Z", "GetIsSupportHandler")]
			get {
				const string __id = "isSupport.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_log_ILjava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetLog_ILjava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_log_ILjava_lang_String_Ljava_lang_String_ == null)
				cb_log_ILjava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int, IntPtr, IntPtr>) n_Log_ILjava_lang_String_Ljava_lang_String_);
			return cb_log_ILjava_lang_String_Ljava_lang_String_;
		}

		static void n_Log_ILjava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, int priority, IntPtr native_tag, IntPtr native_message)
		{
			global::Com.Aliyun.Alink.Linksdk.Tools.Log.LogcatLogStrategy __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Tools.Log.LogcatLogStrategy> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string tag = JNIEnv.GetString (native_tag, JniHandleOwnership.DoNotTransfer);
			string message = JNIEnv.GetString (native_message, JniHandleOwnership.DoNotTransfer);
			__this.Log (priority, tag, message);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.tools.log']/class[@name='LogcatLogStrategy']/method[@name='log' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String']]"
		[Register ("log", "(ILjava/lang/String;Ljava/lang/String;)V", "GetLog_ILjava_lang_String_Ljava_lang_String_Handler")]
		public virtual unsafe void Log (int priority, string tag, string message)
		{
			const string __id = "log.(ILjava/lang/String;Ljava/lang/String;)V";
			IntPtr native_tag = JNIEnv.NewString (tag);
			IntPtr native_message = JNIEnv.NewString (message);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (priority);
				__args [1] = new JniArgumentValue (native_tag);
				__args [2] = new JniArgumentValue (native_message);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_tag);
				JNIEnv.DeleteLocalRef (native_message);
			}
		}

	}
}
