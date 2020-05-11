using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Alibaba.Sdk.Android.Oss.Model {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.alibaba.sdk.android.oss.model']/class[@name='CannedAccessControlList']"
	[global::Android.Runtime.Register ("com/alibaba/sdk/android/oss/model/CannedAccessControlList", DoNotGenerateAcw=true)]
	public sealed partial class CannedAccessControlList : global::Java.Lang.Enum {



		// Metadata.xml XPath field reference: path="/api/package[@name='com.alibaba.sdk.android.oss.model']/class[@name='CannedAccessControlList']/field[@name='Private']"
		[Register ("Private")]
		public static global::Com.Alibaba.Sdk.Android.Oss.Model.CannedAccessControlList Private {
			get {
				const string __id = "Private.Lcom/alibaba/sdk/android/oss/model/CannedAccessControlList;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.Model.CannedAccessControlList> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.alibaba.sdk.android.oss.model']/class[@name='CannedAccessControlList']/field[@name='PublicRead']"
		[Register ("PublicRead")]
		public static global::Com.Alibaba.Sdk.Android.Oss.Model.CannedAccessControlList PublicRead {
			get {
				const string __id = "PublicRead.Lcom/alibaba/sdk/android/oss/model/CannedAccessControlList;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.Model.CannedAccessControlList> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.alibaba.sdk.android.oss.model']/class[@name='CannedAccessControlList']/field[@name='PublicReadWrite']"
		[Register ("PublicReadWrite")]
		public static global::Com.Alibaba.Sdk.Android.Oss.Model.CannedAccessControlList PublicReadWrite {
			get {
				const string __id = "PublicReadWrite.Lcom/alibaba/sdk/android/oss/model/CannedAccessControlList;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.Model.CannedAccessControlList> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/alibaba/sdk/android/oss/model/CannedAccessControlList", typeof (CannedAccessControlList));
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

		internal CannedAccessControlList (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.oss.model']/class[@name='CannedAccessControlList']/method[@name='parseACL' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("parseACL", "(Ljava/lang/String;)Lcom/alibaba/sdk/android/oss/model/CannedAccessControlList;", "")]
		public static unsafe global::Com.Alibaba.Sdk.Android.Oss.Model.CannedAccessControlList ParseACL (string aclStr)
		{
			const string __id = "parseACL.(Ljava/lang/String;)Lcom/alibaba/sdk/android/oss/model/CannedAccessControlList;";
			IntPtr native_aclStr = JNIEnv.NewString (aclStr);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_aclStr);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.Model.CannedAccessControlList> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_aclStr);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.oss.model']/class[@name='CannedAccessControlList']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("valueOf", "(Ljava/lang/String;)Lcom/alibaba/sdk/android/oss/model/CannedAccessControlList;", "")]
		public static unsafe global::Com.Alibaba.Sdk.Android.Oss.Model.CannedAccessControlList ValueOf (string name)
		{
			const string __id = "valueOf.(Ljava/lang/String;)Lcom/alibaba/sdk/android/oss/model/CannedAccessControlList;";
			IntPtr native_name = JNIEnv.NewString (name);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_name);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Oss.Model.CannedAccessControlList> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_name);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.oss.model']/class[@name='CannedAccessControlList']/method[@name='values' and count(parameter)=0]"
		[Register ("values", "()[Lcom/alibaba/sdk/android/oss/model/CannedAccessControlList;", "")]
		public static unsafe global::Com.Alibaba.Sdk.Android.Oss.Model.CannedAccessControlList[] Values ()
		{
			const string __id = "values.()[Lcom/alibaba/sdk/android/oss/model/CannedAccessControlList;";
			try {
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
				return (global::Com.Alibaba.Sdk.Android.Oss.Model.CannedAccessControlList[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (global::Com.Alibaba.Sdk.Android.Oss.Model.CannedAccessControlList));
			} finally {
			}
		}

	}
}
