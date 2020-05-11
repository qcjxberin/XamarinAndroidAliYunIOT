using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Alibaba.Sdk.Android.Oss.Internal {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.alibaba.sdk.android.oss.internal']/class[@name='OSSRetryType']"
	[global::Android.Runtime.Register ("com/alibaba/sdk/android/oss/internal/OSSRetryType", DoNotGenerateAcw=true)]
	public sealed partial class OSSRetryType : global::Java.Lang.Enum {



		// Metadata.xml XPath field reference: path="/api/package[@name='com.alibaba.sdk.android.oss.internal']/class[@name='OSSRetryType']/field[@name='OSSRetryTypeShouldFixedTimeSkewedAndRetry']"
		[Register ("OSSRetryTypeShouldFixedTimeSkewedAndRetry")]
		public static global::Com.Alibaba.Sdk.Android.Oss.Internal.OSSRetryType OSSRetryTypeShouldFixedTimeSkewedAndRetry {
			get {
				const string __id = "OSSRetryTypeShouldFixedTimeSkewedAndRetry.Lcom/alibaba/sdk/android/oss/internal/OSSRetryType;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.Internal.OSSRetryType> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.alibaba.sdk.android.oss.internal']/class[@name='OSSRetryType']/field[@name='OSSRetryTypeShouldNotRetry']"
		[Register ("OSSRetryTypeShouldNotRetry")]
		public static global::Com.Alibaba.Sdk.Android.Oss.Internal.OSSRetryType OSSRetryTypeShouldNotRetry {
			get {
				const string __id = "OSSRetryTypeShouldNotRetry.Lcom/alibaba/sdk/android/oss/internal/OSSRetryType;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.Internal.OSSRetryType> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.alibaba.sdk.android.oss.internal']/class[@name='OSSRetryType']/field[@name='OSSRetryTypeShouldRetry']"
		[Register ("OSSRetryTypeShouldRetry")]
		public static global::Com.Alibaba.Sdk.Android.Oss.Internal.OSSRetryType OSSRetryTypeShouldRetry {
			get {
				const string __id = "OSSRetryTypeShouldRetry.Lcom/alibaba/sdk/android/oss/internal/OSSRetryType;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.Internal.OSSRetryType> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/alibaba/sdk/android/oss/internal/OSSRetryType", typeof (OSSRetryType));
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

		internal OSSRetryType (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.oss.internal']/class[@name='OSSRetryType']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("valueOf", "(Ljava/lang/String;)Lcom/alibaba/sdk/android/oss/internal/OSSRetryType;", "")]
		public static unsafe global::Com.Alibaba.Sdk.Android.Oss.Internal.OSSRetryType ValueOf (string name)
		{
			const string __id = "valueOf.(Ljava/lang/String;)Lcom/alibaba/sdk/android/oss/internal/OSSRetryType;";
			IntPtr native_name = JNIEnv.NewString (name);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_name);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.Internal.OSSRetryType> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_name);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.oss.internal']/class[@name='OSSRetryType']/method[@name='values' and count(parameter)=0]"
		[Register ("values", "()[Lcom/alibaba/sdk/android/oss/internal/OSSRetryType;", "")]
		public static unsafe global::Com.Alibaba.Sdk.Android.Oss.Internal.OSSRetryType[] Values ()
		{
			const string __id = "values.()[Lcom/alibaba/sdk/android/oss/internal/OSSRetryType;";
			try {
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
				return (global::Com.Alibaba.Sdk.Android.Oss.Internal.OSSRetryType[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (global::Com.Alibaba.Sdk.Android.Oss.Internal.OSSRetryType));
			} finally {
			}
		}

	}
}
