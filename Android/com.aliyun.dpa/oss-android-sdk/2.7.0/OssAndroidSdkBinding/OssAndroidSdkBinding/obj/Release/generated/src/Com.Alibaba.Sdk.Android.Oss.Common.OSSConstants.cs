using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Alibaba.Sdk.Android.Oss.Common {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.alibaba.sdk.android.oss.common']/class[@name='OSSConstants']"
	[global::Android.Runtime.Register ("com/alibaba/sdk/android/oss/common/OSSConstants", DoNotGenerateAcw=true)]
	public sealed partial class OSSConstants : global::Java.Lang.Object {


		// Metadata.xml XPath field reference: path="/api/package[@name='com.alibaba.sdk.android.oss.common']/class[@name='OSSConstants']/field[@name='DEFAULT_BASE_THREAD_POOL_SIZE']"
		[Register ("DEFAULT_BASE_THREAD_POOL_SIZE")]
		public const int DefaultBaseThreadPoolSize = (int) 5;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.alibaba.sdk.android.oss.common']/class[@name='OSSConstants']/field[@name='DEFAULT_BUFFER_SIZE']"
		[Register ("DEFAULT_BUFFER_SIZE")]
		public const int DefaultBufferSize = (int) 8192;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.alibaba.sdk.android.oss.common']/class[@name='OSSConstants']/field[@name='DEFAULT_CHARSET_NAME']"
		[Register ("DEFAULT_CHARSET_NAME")]
		public const string DefaultCharsetName = (string) "utf-8";


		// Metadata.xml XPath field reference: path="/api/package[@name='com.alibaba.sdk.android.oss.common']/class[@name='OSSConstants']/field[@name='DEFAULT_CNAME_EXCLUDE_LIST']"
		[Register ("DEFAULT_CNAME_EXCLUDE_LIST")]
		public static IList<string> DefaultCnameExcludeList {
			get {
				const string __id = "DEFAULT_CNAME_EXCLUDE_LIST.[Ljava/lang/String;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Android.Runtime.JavaArray<string>.FromJniHandle (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Metadata.xml XPath field reference: path="/api/package[@name='com.alibaba.sdk.android.oss.common']/class[@name='OSSConstants']/field[@name='DEFAULT_FILE_SIZE_LIMIT']"
		[Register ("DEFAULT_FILE_SIZE_LIMIT")]
		public const long DefaultFileSizeLimit = (long) 5368709120;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.alibaba.sdk.android.oss.common']/class[@name='OSSConstants']/field[@name='DEFAULT_OBJECT_CONTENT_TYPE']"
		[Register ("DEFAULT_OBJECT_CONTENT_TYPE")]
		public const string DefaultObjectContentType = (string) "application/octet-stream";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.alibaba.sdk.android.oss.common']/class[@name='OSSConstants']/field[@name='DEFAULT_OSS_ENDPOINT']"
		[Register ("DEFAULT_OSS_ENDPOINT")]
		public const string DefaultOssEndpoint = (string) "http://oss-cn-hangzhou.aliyuncs.com";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.alibaba.sdk.android.oss.common']/class[@name='OSSConstants']/field[@name='DEFAULT_RETRY_COUNT']"
		[Register ("DEFAULT_RETRY_COUNT")]
		public const int DefaultRetryCount = (int) 2;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.alibaba.sdk.android.oss.common']/class[@name='OSSConstants']/field[@name='DEFAULT_STREAM_BUFFER_SIZE']"
		[Register ("DEFAULT_STREAM_BUFFER_SIZE")]
		public const int DefaultStreamBufferSize = (int) 131072;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.alibaba.sdk.android.oss.common']/class[@name='OSSConstants']/field[@name='DEFAULT_XML_ENCODING']"
		[Register ("DEFAULT_XML_ENCODING")]
		public const string DefaultXmlEncoding = (string) "utf-8";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.alibaba.sdk.android.oss.common']/class[@name='OSSConstants']/field[@name='KB']"
		[Register ("KB")]
		public const int Kb = (int) 1024;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.alibaba.sdk.android.oss.common']/class[@name='OSSConstants']/field[@name='MIN_PART_SIZE_LIMIT']"
		[Register ("MIN_PART_SIZE_LIMIT")]
		public const long MinPartSizeLimit = (long) 102400;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.alibaba.sdk.android.oss.common']/class[@name='OSSConstants']/field[@name='OBJECT_NAME_MAX_LENGTH']"
		[Register ("OBJECT_NAME_MAX_LENGTH")]
		public const int ObjectNameMaxLength = (int) 1024;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.alibaba.sdk.android.oss.common']/class[@name='OSSConstants']/field[@name='RESOURCE_NAME_COMMON']"
		[Register ("RESOURCE_NAME_COMMON")]
		public const string ResourceNameCommon = (string) "common";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.alibaba.sdk.android.oss.common']/class[@name='OSSConstants']/field[@name='RESOURCE_NAME_OSS']"
		[Register ("RESOURCE_NAME_OSS")]
		public const string ResourceNameOss = (string) "oss";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.alibaba.sdk.android.oss.common']/class[@name='OSSConstants']/field[@name='SDK_VERSION']"
		[Register ("SDK_VERSION")]
		public const string SdkVersion = (string) "2.7.0";
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/alibaba/sdk/android/oss/common/OSSConstants", typeof (OSSConstants));
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

		internal OSSConstants (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.alibaba.sdk.android.oss.common']/class[@name='OSSConstants']/constructor[@name='OSSConstants' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe OSSConstants ()
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

	}
}
