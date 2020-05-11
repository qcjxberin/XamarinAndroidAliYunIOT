using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Alibaba.Sdk.Android.Oss.Common.Utils {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.alibaba.sdk.android.oss.common.utils']/class[@name='IOUtils']"
	[global::Android.Runtime.Register ("com/alibaba/sdk/android/oss/common/utils/IOUtils", DoNotGenerateAcw=true)]
	public partial class IOUtils : global::Java.Lang.Object {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/alibaba/sdk/android/oss/common/utils/IOUtils", typeof (IOUtils));
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

		protected IOUtils (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.alibaba.sdk.android.oss.common.utils']/class[@name='IOUtils']/constructor[@name='IOUtils' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe IOUtils ()
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

		// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.oss.common.utils']/class[@name='IOUtils']/method[@name='readStreamAsBytesArray' and count(parameter)=1 and parameter[1][@type='java.io.InputStream']]"
		[Register ("readStreamAsBytesArray", "(Ljava/io/InputStream;)[B", "")]
		public static unsafe byte[] ReadStreamAsBytesArray (global::System.IO.Stream @in)
		{
			const string __id = "readStreamAsBytesArray.(Ljava/io/InputStream;)[B";
			IntPtr native__in = global::Android.Runtime.InputStreamAdapter.ToLocalJniHandle (@in);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native__in);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return (byte[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (byte));
			} finally {
				JNIEnv.DeleteLocalRef (native__in);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.oss.common.utils']/class[@name='IOUtils']/method[@name='readStreamAsBytesArray' and count(parameter)=2 and parameter[1][@type='java.io.InputStream'] and parameter[2][@type='int']]"
		[Register ("readStreamAsBytesArray", "(Ljava/io/InputStream;I)[B", "")]
		public static unsafe byte[] ReadStreamAsBytesArray (global::System.IO.Stream @in, int readLength)
		{
			const string __id = "readStreamAsBytesArray.(Ljava/io/InputStream;I)[B";
			IntPtr native__in = global::Android.Runtime.InputStreamAdapter.ToLocalJniHandle (@in);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native__in);
				__args [1] = new JniArgumentValue (readLength);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return (byte[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (byte));
			} finally {
				JNIEnv.DeleteLocalRef (native__in);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.oss.common.utils']/class[@name='IOUtils']/method[@name='readStreamAsString' and count(parameter)=2 and parameter[1][@type='java.io.InputStream'] and parameter[2][@type='java.lang.String']]"
		[Register ("readStreamAsString", "(Ljava/io/InputStream;Ljava/lang/String;)Ljava/lang/String;", "")]
		public static unsafe string ReadStreamAsString (global::System.IO.Stream @in, string charset)
		{
			const string __id = "readStreamAsString.(Ljava/io/InputStream;Ljava/lang/String;)Ljava/lang/String;";
			IntPtr native__in = global::Android.Runtime.InputStreamAdapter.ToLocalJniHandle (@in);
			IntPtr native_charset = JNIEnv.NewString (charset);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native__in);
				__args [1] = new JniArgumentValue (native_charset);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native__in);
				JNIEnv.DeleteLocalRef (native_charset);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.oss.common.utils']/class[@name='IOUtils']/method[@name='safeClose' and count(parameter)=1 and parameter[1][@type='java.io.InputStream']]"
		[Register ("safeClose", "(Ljava/io/InputStream;)V", "")]
		public static unsafe void SafeClose (global::System.IO.Stream inputStream)
		{
			const string __id = "safeClose.(Ljava/io/InputStream;)V";
			IntPtr native_inputStream = global::Android.Runtime.InputStreamAdapter.ToLocalJniHandle (inputStream);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_inputStream);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_inputStream);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.oss.common.utils']/class[@name='IOUtils']/method[@name='safeClose' and count(parameter)=1 and parameter[1][@type='java.io.OutputStream']]"
		[Register ("safeClose", "(Ljava/io/OutputStream;)V", "")]
		public static unsafe void RawSafeClose (global::System.IO.Stream outputStream)
		{
			const string __id = "safeClose.(Ljava/io/OutputStream;)V";
			IntPtr native_outputStream = global::Android.Runtime.OutputStreamAdapter.ToLocalJniHandle (outputStream);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_outputStream);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_outputStream);
			}
		}

	}
}
