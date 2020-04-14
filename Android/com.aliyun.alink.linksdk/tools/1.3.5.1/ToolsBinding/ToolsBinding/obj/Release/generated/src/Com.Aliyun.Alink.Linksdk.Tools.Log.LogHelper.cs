using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Aliyun.Alink.Linksdk.Tools.Log {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.aliyun.alink.linksdk.tools.log']/class[@name='LogHelper']"
	[global::Android.Runtime.Register ("com/aliyun/alink/linksdk/tools/log/LogHelper", DoNotGenerateAcw=true)]
	public partial class LogHelper : global::Java.Lang.Object {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/aliyun/alink/linksdk/tools/log/LogHelper", typeof (LogHelper));
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

		protected LogHelper (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.aliyun.alink.linksdk.tools.log']/class[@name='LogHelper']/constructor[@name='LogHelper' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe LogHelper ()
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

		// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.tools.log']/class[@name='LogHelper']/method[@name='getLogLevel' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("getLogLevel", "(I)Ljava/lang/String;", "")]
		public static unsafe string GetLogLevel (int priority)
		{
			const string __id = "getLogLevel.(I)Ljava/lang/String;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (priority);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.tools.log']/class[@name='LogHelper']/method[@name='print' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String']]"
		[Register ("print", "(ILjava/lang/String;Ljava/lang/String;)V", "")]
		public static unsafe void Print (int priority, string tag, string message)
		{
			const string __id = "print.(ILjava/lang/String;Ljava/lang/String;)V";
			IntPtr native_tag = JNIEnv.NewString (tag);
			IntPtr native_message = JNIEnv.NewString (message);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (priority);
				__args [1] = new JniArgumentValue (native_tag);
				__args [2] = new JniArgumentValue (native_message);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_tag);
				JNIEnv.DeleteLocalRef (native_message);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.tools.log']/class[@name='LogHelper']/method[@name='targetStackTraceMSg' and count(parameter)=0]"
		[Register ("targetStackTraceMSg", "()Ljava/lang/String;", "")]
		public static unsafe string TargetStackTraceMSg ()
		{
			const string __id = "targetStackTraceMSg.()Ljava/lang/String;";
			try {
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}
}
