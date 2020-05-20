using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Org.Eclipse.Paho.Client.Mqttv3.Logging {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.logging']/class[@name='SimpleLogFormatter']"
	[global::Android.Runtime.Register ("org/eclipse/paho/client/mqttv3/logging/SimpleLogFormatter", DoNotGenerateAcw=true)]
	public partial class SimpleLogFormatter : global::Java.Util.Logging.Formatter {

		static readonly JniPeerMembers _members = new XAPeerMembers ("org/eclipse/paho/client/mqttv3/logging/SimpleLogFormatter", typeof (SimpleLogFormatter));
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

		protected SimpleLogFormatter (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.logging']/class[@name='SimpleLogFormatter']/constructor[@name='SimpleLogFormatter' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe SimpleLogFormatter ()
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

		static Delegate cb_format_Ljava_util_logging_LogRecord_;
#pragma warning disable 0169
		static Delegate GetFormat_Ljava_util_logging_LogRecord_Handler ()
		{
			if (cb_format_Ljava_util_logging_LogRecord_ == null)
				cb_format_Ljava_util_logging_LogRecord_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_Format_Ljava_util_logging_LogRecord_);
			return cb_format_Ljava_util_logging_LogRecord_;
		}

		static IntPtr n_Format_Ljava_util_logging_LogRecord_ (IntPtr jnienv, IntPtr native__this, IntPtr native_r)
		{
			global::Org.Eclipse.Paho.Client.Mqttv3.Logging.SimpleLogFormatter __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.Logging.SimpleLogFormatter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Util.Logging.LogRecord r = global::Java.Lang.Object.GetObject<global::Java.Util.Logging.LogRecord> (native_r, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewString (__this.Format (r));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.logging']/class[@name='SimpleLogFormatter']/method[@name='format' and count(parameter)=1 and parameter[1][@type='java.util.logging.LogRecord']]"
		[Register ("format", "(Ljava/util/logging/LogRecord;)Ljava/lang/String;", "GetFormat_Ljava_util_logging_LogRecord_Handler")]
		public override unsafe string Format (global::Java.Util.Logging.LogRecord r)
		{
			const string __id = "format.(Ljava/util/logging/LogRecord;)Ljava/lang/String;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((r == null) ? IntPtr.Zero : ((global::Java.Lang.Object) r).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.logging']/class[@name='SimpleLogFormatter']/method[@name='left' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='int'] and parameter[3][@type='char']]"
		[Register ("left", "(Ljava/lang/String;IC)Ljava/lang/String;", "")]
		public static unsafe string Left (string s, int width, char fillChar)
		{
			const string __id = "left.(Ljava/lang/String;IC)Ljava/lang/String;";
			IntPtr native_s = JNIEnv.NewString (s);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (native_s);
				__args [1] = new JniArgumentValue (width);
				__args [2] = new JniArgumentValue (fillChar);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_s);
			}
		}

	}
}
