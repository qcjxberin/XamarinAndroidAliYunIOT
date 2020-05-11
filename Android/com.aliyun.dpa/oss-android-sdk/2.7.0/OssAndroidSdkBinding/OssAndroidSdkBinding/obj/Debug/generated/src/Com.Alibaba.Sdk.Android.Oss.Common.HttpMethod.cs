using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Alibaba.Sdk.Android.Oss.Common {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.alibaba.sdk.android.oss.common']/class[@name='HttpMethod']"
	[global::Android.Runtime.Register ("com/alibaba/sdk/android/oss/common/HttpMethod", DoNotGenerateAcw=true)]
	public sealed partial class HttpMethod : global::Java.Lang.Enum {



		// Metadata.xml XPath field reference: path="/api/package[@name='com.alibaba.sdk.android.oss.common']/class[@name='HttpMethod']/field[@name='DELETE']"
		[Register ("DELETE")]
		public static global::Com.Alibaba.Sdk.Android.Oss.Common.HttpMethod Delete {
			get {
				const string __id = "DELETE.Lcom/alibaba/sdk/android/oss/common/HttpMethod;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.Common.HttpMethod> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.alibaba.sdk.android.oss.common']/class[@name='HttpMethod']/field[@name='GET']"
		[Register ("GET")]
		public static global::Com.Alibaba.Sdk.Android.Oss.Common.HttpMethod Get {
			get {
				const string __id = "GET.Lcom/alibaba/sdk/android/oss/common/HttpMethod;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.Common.HttpMethod> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.alibaba.sdk.android.oss.common']/class[@name='HttpMethod']/field[@name='HEAD']"
		[Register ("HEAD")]
		public static global::Com.Alibaba.Sdk.Android.Oss.Common.HttpMethod Head {
			get {
				const string __id = "HEAD.Lcom/alibaba/sdk/android/oss/common/HttpMethod;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.Common.HttpMethod> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.alibaba.sdk.android.oss.common']/class[@name='HttpMethod']/field[@name='OPTIONS']"
		[Register ("OPTIONS")]
		public static global::Com.Alibaba.Sdk.Android.Oss.Common.HttpMethod Options {
			get {
				const string __id = "OPTIONS.Lcom/alibaba/sdk/android/oss/common/HttpMethod;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.Common.HttpMethod> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.alibaba.sdk.android.oss.common']/class[@name='HttpMethod']/field[@name='POST']"
		[Register ("POST")]
		public static global::Com.Alibaba.Sdk.Android.Oss.Common.HttpMethod Post {
			get {
				const string __id = "POST.Lcom/alibaba/sdk/android/oss/common/HttpMethod;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.Common.HttpMethod> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.alibaba.sdk.android.oss.common']/class[@name='HttpMethod']/field[@name='PUT']"
		[Register ("PUT")]
		public static global::Com.Alibaba.Sdk.Android.Oss.Common.HttpMethod Put {
			get {
				const string __id = "PUT.Lcom/alibaba/sdk/android/oss/common/HttpMethod;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.Common.HttpMethod> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/alibaba/sdk/android/oss/common/HttpMethod", typeof (HttpMethod));
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

		internal HttpMethod (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.oss.common']/class[@name='HttpMethod']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("valueOf", "(Ljava/lang/String;)Lcom/alibaba/sdk/android/oss/common/HttpMethod;", "")]
		public static unsafe global::Com.Alibaba.Sdk.Android.Oss.Common.HttpMethod ValueOf (string name)
		{
			const string __id = "valueOf.(Ljava/lang/String;)Lcom/alibaba/sdk/android/oss/common/HttpMethod;";
			IntPtr native_name = JNIEnv.NewString (name);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_name);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.Common.HttpMethod> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_name);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.oss.common']/class[@name='HttpMethod']/method[@name='values' and count(parameter)=0]"
		[Register ("values", "()[Lcom/alibaba/sdk/android/oss/common/HttpMethod;", "")]
		public static unsafe global::Com.Alibaba.Sdk.Android.Oss.Common.HttpMethod[] Values ()
		{
			const string __id = "values.()[Lcom/alibaba/sdk/android/oss/common/HttpMethod;";
			try {
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
				return (global::Com.Alibaba.Sdk.Android.Oss.Common.HttpMethod[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (global::Com.Alibaba.Sdk.Android.Oss.Common.HttpMethod));
			} finally {
			}
		}

	}
}
