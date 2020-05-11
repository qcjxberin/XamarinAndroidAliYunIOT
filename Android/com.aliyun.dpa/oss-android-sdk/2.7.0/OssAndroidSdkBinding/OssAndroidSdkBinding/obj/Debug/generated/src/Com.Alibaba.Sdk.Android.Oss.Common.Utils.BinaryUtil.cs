using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Alibaba.Sdk.Android.Oss.Common.Utils {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.alibaba.sdk.android.oss.common.utils']/class[@name='BinaryUtil']"
	[global::Android.Runtime.Register ("com/alibaba/sdk/android/oss/common/utils/BinaryUtil", DoNotGenerateAcw=true)]
	public partial class BinaryUtil : global::Java.Lang.Object {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/alibaba/sdk/android/oss/common/utils/BinaryUtil", typeof (BinaryUtil));
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

		protected BinaryUtil (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.alibaba.sdk.android.oss.common.utils']/class[@name='BinaryUtil']/constructor[@name='BinaryUtil' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe BinaryUtil ()
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

		// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.oss.common.utils']/class[@name='BinaryUtil']/method[@name='calculateBase64Md5' and count(parameter)=1 and parameter[1][@type='byte[]']]"
		[Register ("calculateBase64Md5", "([B)Ljava/lang/String;", "")]
		public static unsafe string CalculateBase64Md5 (byte[] binaryData)
		{
			const string __id = "calculateBase64Md5.([B)Ljava/lang/String;";
			IntPtr native_binaryData = JNIEnv.NewArray (binaryData);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_binaryData);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				if (binaryData != null) {
					JNIEnv.CopyArray (native_binaryData, binaryData);
					JNIEnv.DeleteLocalRef (native_binaryData);
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.oss.common.utils']/class[@name='BinaryUtil']/method[@name='calculateBase64Md5' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("calculateBase64Md5", "(Ljava/lang/String;)Ljava/lang/String;", "")]
		public static unsafe string CalculateBase64Md5 (string filePath)
		{
			const string __id = "calculateBase64Md5.(Ljava/lang/String;)Ljava/lang/String;";
			IntPtr native_filePath = JNIEnv.NewString (filePath);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_filePath);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_filePath);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.oss.common.utils']/class[@name='BinaryUtil']/method[@name='calculateMd5' and count(parameter)=1 and parameter[1][@type='byte[]']]"
		[Register ("calculateMd5", "([B)[B", "")]
		public static unsafe byte[] CalculateMd5 (byte[] binaryData)
		{
			const string __id = "calculateMd5.([B)[B";
			IntPtr native_binaryData = JNIEnv.NewArray (binaryData);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_binaryData);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return (byte[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (byte));
			} finally {
				if (binaryData != null) {
					JNIEnv.CopyArray (native_binaryData, binaryData);
					JNIEnv.DeleteLocalRef (native_binaryData);
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.oss.common.utils']/class[@name='BinaryUtil']/method[@name='calculateMd5' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("calculateMd5", "(Ljava/lang/String;)[B", "")]
		public static unsafe byte[] CalculateMd5 (string filePath)
		{
			const string __id = "calculateMd5.(Ljava/lang/String;)[B";
			IntPtr native_filePath = JNIEnv.NewString (filePath);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_filePath);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return (byte[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (byte));
			} finally {
				JNIEnv.DeleteLocalRef (native_filePath);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.oss.common.utils']/class[@name='BinaryUtil']/method[@name='calculateMd5Str' and count(parameter)=1 and parameter[1][@type='byte[]']]"
		[Register ("calculateMd5Str", "([B)Ljava/lang/String;", "")]
		public static unsafe string CalculateMd5Str (byte[] binaryData)
		{
			const string __id = "calculateMd5Str.([B)Ljava/lang/String;";
			IntPtr native_binaryData = JNIEnv.NewArray (binaryData);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_binaryData);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				if (binaryData != null) {
					JNIEnv.CopyArray (native_binaryData, binaryData);
					JNIEnv.DeleteLocalRef (native_binaryData);
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.oss.common.utils']/class[@name='BinaryUtil']/method[@name='calculateMd5Str' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("calculateMd5Str", "(Ljava/lang/String;)Ljava/lang/String;", "")]
		public static unsafe string CalculateMd5Str (string filePath)
		{
			const string __id = "calculateMd5Str.(Ljava/lang/String;)Ljava/lang/String;";
			IntPtr native_filePath = JNIEnv.NewString (filePath);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_filePath);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_filePath);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.oss.common.utils']/class[@name='BinaryUtil']/method[@name='fileToSHA1' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("fileToSHA1", "(Ljava/lang/String;)Ljava/lang/String;", "")]
		public static unsafe string FileToSHA1 (string filePath)
		{
			const string __id = "fileToSHA1.(Ljava/lang/String;)Ljava/lang/String;";
			IntPtr native_filePath = JNIEnv.NewString (filePath);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_filePath);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_filePath);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.oss.common.utils']/class[@name='BinaryUtil']/method[@name='fromBase64String' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("fromBase64String", "(Ljava/lang/String;)[B", "")]
		public static unsafe byte[] FromBase64String (string base64String)
		{
			const string __id = "fromBase64String.(Ljava/lang/String;)[B";
			IntPtr native_base64String = JNIEnv.NewString (base64String);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_base64String);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return (byte[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (byte));
			} finally {
				JNIEnv.DeleteLocalRef (native_base64String);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.oss.common.utils']/class[@name='BinaryUtil']/method[@name='getMd5StrFromBytes' and count(parameter)=1 and parameter[1][@type='byte[]']]"
		[Register ("getMd5StrFromBytes", "([B)Ljava/lang/String;", "")]
		public static unsafe string GetMd5StrFromBytes (byte[] md5bytes)
		{
			const string __id = "getMd5StrFromBytes.([B)Ljava/lang/String;";
			IntPtr native_md5bytes = JNIEnv.NewArray (md5bytes);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_md5bytes);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				if (md5bytes != null) {
					JNIEnv.CopyArray (native_md5bytes, md5bytes);
					JNIEnv.DeleteLocalRef (native_md5bytes);
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.oss.common.utils']/class[@name='BinaryUtil']/method[@name='toBase64String' and count(parameter)=1 and parameter[1][@type='byte[]']]"
		[Register ("toBase64String", "([B)Ljava/lang/String;", "")]
		public static unsafe string ToBase64String (byte[] binaryData)
		{
			const string __id = "toBase64String.([B)Ljava/lang/String;";
			IntPtr native_binaryData = JNIEnv.NewArray (binaryData);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_binaryData);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				if (binaryData != null) {
					JNIEnv.CopyArray (native_binaryData, binaryData);
					JNIEnv.DeleteLocalRef (native_binaryData);
				}
			}
		}

	}
}
