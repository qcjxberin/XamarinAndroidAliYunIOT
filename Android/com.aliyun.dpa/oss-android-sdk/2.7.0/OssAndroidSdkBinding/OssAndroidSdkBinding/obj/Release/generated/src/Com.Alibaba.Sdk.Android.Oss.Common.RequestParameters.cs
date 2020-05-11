using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Alibaba.Sdk.Android.Oss.Common {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.alibaba.sdk.android.oss.common']/class[@name='RequestParameters']"
	[global::Android.Runtime.Register ("com/alibaba/sdk/android/oss/common/RequestParameters", DoNotGenerateAcw=true)]
	public sealed partial class RequestParameters : global::Java.Lang.Object {


		// Metadata.xml XPath field reference: path="/api/package[@name='com.alibaba.sdk.android.oss.common']/class[@name='RequestParameters']/field[@name='DELIMITER']"
		[Register ("DELIMITER")]
		public const string Delimiter = (string) "delimiter";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.alibaba.sdk.android.oss.common']/class[@name='RequestParameters']/field[@name='ENCODING_TYPE']"
		[Register ("ENCODING_TYPE")]
		public const string EncodingType = (string) "encoding-type";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.alibaba.sdk.android.oss.common']/class[@name='RequestParameters']/field[@name='KEY_MARKER']"
		[Register ("KEY_MARKER")]
		public const string KeyMarker = (string) "key-marker";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.alibaba.sdk.android.oss.common']/class[@name='RequestParameters']/field[@name='MARKER']"
		[Register ("MARKER")]
		public const string Marker = (string) "marker";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.alibaba.sdk.android.oss.common']/class[@name='RequestParameters']/field[@name='MAX_KEYS']"
		[Register ("MAX_KEYS")]
		public const string MaxKeys = (string) "max-keys";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.alibaba.sdk.android.oss.common']/class[@name='RequestParameters']/field[@name='MAX_PARTS']"
		[Register ("MAX_PARTS")]
		public const string MaxParts = (string) "max-parts";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.alibaba.sdk.android.oss.common']/class[@name='RequestParameters']/field[@name='MAX_UPLOADS']"
		[Register ("MAX_UPLOADS")]
		public const string MaxUploads = (string) "max-uploads";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.alibaba.sdk.android.oss.common']/class[@name='RequestParameters']/field[@name='OSS_ACCESS_KEY_ID']"
		[Register ("OSS_ACCESS_KEY_ID")]
		public const string OssAccessKeyId = (string) "OSSAccessKeyId";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.alibaba.sdk.android.oss.common']/class[@name='RequestParameters']/field[@name='PART_NUMBER']"
		[Register ("PART_NUMBER")]
		public const string PartNumber = (string) "partNumber";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.alibaba.sdk.android.oss.common']/class[@name='RequestParameters']/field[@name='PART_NUMBER_MARKER']"
		[Register ("PART_NUMBER_MARKER")]
		public const string PartNumberMarker = (string) "part-number-marker";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.alibaba.sdk.android.oss.common']/class[@name='RequestParameters']/field[@name='POSITION']"
		[Register ("POSITION")]
		public const string Position = (string) "position";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.alibaba.sdk.android.oss.common']/class[@name='RequestParameters']/field[@name='PREFIX']"
		[Register ("PREFIX")]
		public const string Prefix = (string) "prefix";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.alibaba.sdk.android.oss.common']/class[@name='RequestParameters']/field[@name='RESPONSE_HEADER_CACHE_CONTROL']"
		[Register ("RESPONSE_HEADER_CACHE_CONTROL")]
		public const string ResponseHeaderCacheControl = (string) "response-cache-control";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.alibaba.sdk.android.oss.common']/class[@name='RequestParameters']/field[@name='RESPONSE_HEADER_CONTENT_DISPOSITION']"
		[Register ("RESPONSE_HEADER_CONTENT_DISPOSITION")]
		public const string ResponseHeaderContentDisposition = (string) "response-content-disposition";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.alibaba.sdk.android.oss.common']/class[@name='RequestParameters']/field[@name='RESPONSE_HEADER_CONTENT_ENCODING']"
		[Register ("RESPONSE_HEADER_CONTENT_ENCODING")]
		public const string ResponseHeaderContentEncoding = (string) "response-content-encoding";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.alibaba.sdk.android.oss.common']/class[@name='RequestParameters']/field[@name='RESPONSE_HEADER_CONTENT_LANGUAGE']"
		[Register ("RESPONSE_HEADER_CONTENT_LANGUAGE")]
		public const string ResponseHeaderContentLanguage = (string) "response-content-language";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.alibaba.sdk.android.oss.common']/class[@name='RequestParameters']/field[@name='RESPONSE_HEADER_CONTENT_TYPE']"
		[Register ("RESPONSE_HEADER_CONTENT_TYPE")]
		public const string ResponseHeaderContentType = (string) "response-content-type";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.alibaba.sdk.android.oss.common']/class[@name='RequestParameters']/field[@name='RESPONSE_HEADER_EXPIRES']"
		[Register ("RESPONSE_HEADER_EXPIRES")]
		public const string ResponseHeaderExpires = (string) "response-expires";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.alibaba.sdk.android.oss.common']/class[@name='RequestParameters']/field[@name='SECURITY_TOKEN']"
		[Register ("SECURITY_TOKEN")]
		public const string SecurityToken = (string) "security-token";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.alibaba.sdk.android.oss.common']/class[@name='RequestParameters']/field[@name='SIGNATURE']"
		[Register ("SIGNATURE")]
		public const string Signature = (string) "Signature";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.alibaba.sdk.android.oss.common']/class[@name='RequestParameters']/field[@name='SUBRESOURCE_ACL']"
		[Register ("SUBRESOURCE_ACL")]
		public const string SubresourceAcl = (string) "acl";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.alibaba.sdk.android.oss.common']/class[@name='RequestParameters']/field[@name='SUBRESOURCE_APPEND']"
		[Register ("SUBRESOURCE_APPEND")]
		public const string SubresourceAppend = (string) "append";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.alibaba.sdk.android.oss.common']/class[@name='RequestParameters']/field[@name='SUBRESOURCE_CORS']"
		[Register ("SUBRESOURCE_CORS")]
		public const string SubresourceCors = (string) "cors";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.alibaba.sdk.android.oss.common']/class[@name='RequestParameters']/field[@name='SUBRESOURCE_DELETE']"
		[Register ("SUBRESOURCE_DELETE")]
		public const string SubresourceDelete = (string) "delete";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.alibaba.sdk.android.oss.common']/class[@name='RequestParameters']/field[@name='SUBRESOURCE_LIFECYCLE']"
		[Register ("SUBRESOURCE_LIFECYCLE")]
		public const string SubresourceLifecycle = (string) "lifecycle";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.alibaba.sdk.android.oss.common']/class[@name='RequestParameters']/field[@name='SUBRESOURCE_LOCATION']"
		[Register ("SUBRESOURCE_LOCATION")]
		public const string SubresourceLocation = (string) "location";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.alibaba.sdk.android.oss.common']/class[@name='RequestParameters']/field[@name='SUBRESOURCE_LOGGING']"
		[Register ("SUBRESOURCE_LOGGING")]
		public const string SubresourceLogging = (string) "logging";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.alibaba.sdk.android.oss.common']/class[@name='RequestParameters']/field[@name='SUBRESOURCE_REFERER']"
		[Register ("SUBRESOURCE_REFERER")]
		public const string SubresourceReferer = (string) "referer";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.alibaba.sdk.android.oss.common']/class[@name='RequestParameters']/field[@name='SUBRESOURCE_SEQUENTIAL']"
		[Register ("SUBRESOURCE_SEQUENTIAL")]
		public const string SubresourceSequential = (string) "sequential";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.alibaba.sdk.android.oss.common']/class[@name='RequestParameters']/field[@name='SUBRESOURCE_UPLOADS']"
		[Register ("SUBRESOURCE_UPLOADS")]
		public const string SubresourceUploads = (string) "uploads";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.alibaba.sdk.android.oss.common']/class[@name='RequestParameters']/field[@name='SUBRESOURCE_WEBSITE']"
		[Register ("SUBRESOURCE_WEBSITE")]
		public const string SubresourceWebsite = (string) "website";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.alibaba.sdk.android.oss.common']/class[@name='RequestParameters']/field[@name='UPLOAD_ID']"
		[Register ("UPLOAD_ID")]
		public const string UploadId = (string) "uploadId";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.alibaba.sdk.android.oss.common']/class[@name='RequestParameters']/field[@name='UPLOAD_ID_MARKER']"
		[Register ("UPLOAD_ID_MARKER")]
		public const string UploadIdMarker = (string) "upload-id-marker";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.alibaba.sdk.android.oss.common']/class[@name='RequestParameters']/field[@name='X_OSS_PROCESS']"
		[Register ("X_OSS_PROCESS")]
		public const string XOssProcess = (string) "x-oss-process";
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/alibaba/sdk/android/oss/common/RequestParameters", typeof (RequestParameters));
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

		internal RequestParameters (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.alibaba.sdk.android.oss.common']/class[@name='RequestParameters']/constructor[@name='RequestParameters' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe RequestParameters ()
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
