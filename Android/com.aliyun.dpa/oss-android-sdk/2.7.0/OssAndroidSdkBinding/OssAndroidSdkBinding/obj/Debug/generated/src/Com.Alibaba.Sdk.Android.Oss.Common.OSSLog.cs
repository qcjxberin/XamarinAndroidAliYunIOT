using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Alibaba.Sdk.Android.Oss.Common {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.alibaba.sdk.android.oss.common']/class[@name='OSSLog']"
	[global::Android.Runtime.Register ("com/alibaba/sdk/android/oss/common/OSSLog", DoNotGenerateAcw=true)]
	public partial class OSSLog : global::Java.Lang.Object {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/alibaba/sdk/android/oss/common/OSSLog", typeof (OSSLog));
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

		protected OSSLog (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.alibaba.sdk.android.oss.common']/class[@name='OSSLog']/constructor[@name='OSSLog' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe OSSLog ()
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

		public static unsafe bool IsEnableLog {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.oss.common']/class[@name='OSSLog']/method[@name='isEnableLog' and count(parameter)=0]"
			[Register ("isEnableLog", "()Z", "")]
			get {
				const string __id = "isEnableLog.()Z";
				try {
					var __rm = _members.StaticMethods.InvokeBooleanMethod (__id, null);
					return __rm;
				} finally {
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.oss.common']/class[@name='OSSLog']/method[@name='disableLog' and count(parameter)=0]"
		[Register ("disableLog", "()V", "")]
		public static unsafe void DisableLog ()
		{
			const string __id = "disableLog.()V";
			try {
				_members.StaticMethods.InvokeVoidMethod (__id, null);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.oss.common']/class[@name='OSSLog']/method[@name='enableLog' and count(parameter)=0]"
		[Register ("enableLog", "()V", "")]
		public static unsafe void EnableLog ()
		{
			const string __id = "enableLog.()V";
			try {
				_members.StaticMethods.InvokeVoidMethod (__id, null);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.oss.common']/class[@name='OSSLog']/method[@name='logDebug' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("logDebug", "(Ljava/lang/String;)V", "")]
		public static unsafe void LogDebug (string msg)
		{
			const string __id = "logDebug.(Ljava/lang/String;)V";
			IntPtr native_msg = JNIEnv.NewString (msg);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_msg);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_msg);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.oss.common']/class[@name='OSSLog']/method[@name='logDebug' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='boolean']]"
		[Register ("logDebug", "(Ljava/lang/String;Z)V", "")]
		public static unsafe void LogDebug (string msg, bool write2local)
		{
			const string __id = "logDebug.(Ljava/lang/String;Z)V";
			IntPtr native_msg = JNIEnv.NewString (msg);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_msg);
				__args [1] = new JniArgumentValue (write2local);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_msg);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.oss.common']/class[@name='OSSLog']/method[@name='logDebug' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("logDebug", "(Ljava/lang/String;Ljava/lang/String;)V", "")]
		public static unsafe void LogDebug (string tag, string msg)
		{
			const string __id = "logDebug.(Ljava/lang/String;Ljava/lang/String;)V";
			IntPtr native_tag = JNIEnv.NewString (tag);
			IntPtr native_msg = JNIEnv.NewString (msg);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_tag);
				__args [1] = new JniArgumentValue (native_msg);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_tag);
				JNIEnv.DeleteLocalRef (native_msg);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.oss.common']/class[@name='OSSLog']/method[@name='logDebug' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='boolean']]"
		[Register ("logDebug", "(Ljava/lang/String;Ljava/lang/String;Z)V", "")]
		public static unsafe void LogDebug (string tag, string msg, bool write2local)
		{
			const string __id = "logDebug.(Ljava/lang/String;Ljava/lang/String;Z)V";
			IntPtr native_tag = JNIEnv.NewString (tag);
			IntPtr native_msg = JNIEnv.NewString (msg);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (native_tag);
				__args [1] = new JniArgumentValue (native_msg);
				__args [2] = new JniArgumentValue (write2local);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_tag);
				JNIEnv.DeleteLocalRef (native_msg);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.oss.common']/class[@name='OSSLog']/method[@name='logError' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("logError", "(Ljava/lang/String;)V", "")]
		public static unsafe void LogError (string msg)
		{
			const string __id = "logError.(Ljava/lang/String;)V";
			IntPtr native_msg = JNIEnv.NewString (msg);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_msg);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_msg);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.oss.common']/class[@name='OSSLog']/method[@name='logError' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='boolean']]"
		[Register ("logError", "(Ljava/lang/String;Z)V", "")]
		public static unsafe void LogError (string msg, bool write2local)
		{
			const string __id = "logError.(Ljava/lang/String;Z)V";
			IntPtr native_msg = JNIEnv.NewString (msg);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_msg);
				__args [1] = new JniArgumentValue (write2local);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_msg);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.oss.common']/class[@name='OSSLog']/method[@name='logError' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("logError", "(Ljava/lang/String;Ljava/lang/String;)V", "")]
		public static unsafe void LogError (string tag, string msg)
		{
			const string __id = "logError.(Ljava/lang/String;Ljava/lang/String;)V";
			IntPtr native_tag = JNIEnv.NewString (tag);
			IntPtr native_msg = JNIEnv.NewString (msg);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_tag);
				__args [1] = new JniArgumentValue (native_msg);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_tag);
				JNIEnv.DeleteLocalRef (native_msg);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.oss.common']/class[@name='OSSLog']/method[@name='logError' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='boolean']]"
		[Register ("logError", "(Ljava/lang/String;Ljava/lang/String;Z)V", "")]
		public static unsafe void LogError (string tag, string msg, bool write2local)
		{
			const string __id = "logError.(Ljava/lang/String;Ljava/lang/String;Z)V";
			IntPtr native_tag = JNIEnv.NewString (tag);
			IntPtr native_msg = JNIEnv.NewString (msg);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (native_tag);
				__args [1] = new JniArgumentValue (native_msg);
				__args [2] = new JniArgumentValue (write2local);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_tag);
				JNIEnv.DeleteLocalRef (native_msg);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.oss.common']/class[@name='OSSLog']/method[@name='logInfo' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("logInfo", "(Ljava/lang/String;)V", "")]
		public static unsafe void LogInfo (string msg)
		{
			const string __id = "logInfo.(Ljava/lang/String;)V";
			IntPtr native_msg = JNIEnv.NewString (msg);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_msg);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_msg);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.oss.common']/class[@name='OSSLog']/method[@name='logInfo' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='boolean']]"
		[Register ("logInfo", "(Ljava/lang/String;Z)V", "")]
		public static unsafe void LogInfo (string msg, bool write2local)
		{
			const string __id = "logInfo.(Ljava/lang/String;Z)V";
			IntPtr native_msg = JNIEnv.NewString (msg);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_msg);
				__args [1] = new JniArgumentValue (write2local);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_msg);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.oss.common']/class[@name='OSSLog']/method[@name='logThrowable2Local' and count(parameter)=1 and parameter[1][@type='java.lang.Throwable']]"
		[Register ("logThrowable2Local", "(Ljava/lang/Throwable;)V", "")]
		public static unsafe void LogThrowable2Local (global::Java.Lang.Throwable throwable)
		{
			const string __id = "logThrowable2Local.(Ljava/lang/Throwable;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((throwable == null) ? IntPtr.Zero : ((global::Java.Lang.Throwable) throwable).Handle);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.oss.common']/class[@name='OSSLog']/method[@name='logVerbose' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("logVerbose", "(Ljava/lang/String;)V", "")]
		public static unsafe void LogVerbose (string msg)
		{
			const string __id = "logVerbose.(Ljava/lang/String;)V";
			IntPtr native_msg = JNIEnv.NewString (msg);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_msg);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_msg);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.oss.common']/class[@name='OSSLog']/method[@name='logVerbose' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='boolean']]"
		[Register ("logVerbose", "(Ljava/lang/String;Z)V", "")]
		public static unsafe void LogVerbose (string msg, bool write2local)
		{
			const string __id = "logVerbose.(Ljava/lang/String;Z)V";
			IntPtr native_msg = JNIEnv.NewString (msg);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_msg);
				__args [1] = new JniArgumentValue (write2local);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_msg);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.oss.common']/class[@name='OSSLog']/method[@name='logWarn' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("logWarn", "(Ljava/lang/String;)V", "")]
		public static unsafe void LogWarn (string msg)
		{
			const string __id = "logWarn.(Ljava/lang/String;)V";
			IntPtr native_msg = JNIEnv.NewString (msg);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_msg);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_msg);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.oss.common']/class[@name='OSSLog']/method[@name='logWarn' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='boolean']]"
		[Register ("logWarn", "(Ljava/lang/String;Z)V", "")]
		public static unsafe void LogWarn (string msg, bool write2local)
		{
			const string __id = "logWarn.(Ljava/lang/String;Z)V";
			IntPtr native_msg = JNIEnv.NewString (msg);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_msg);
				__args [1] = new JniArgumentValue (write2local);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_msg);
			}
		}

	}
}
