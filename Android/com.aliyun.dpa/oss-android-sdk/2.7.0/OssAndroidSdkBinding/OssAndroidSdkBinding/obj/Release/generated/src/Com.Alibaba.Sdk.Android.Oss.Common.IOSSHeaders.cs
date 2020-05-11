using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Alibaba.Sdk.Android.Oss.Common {

	[Register ("com/alibaba/sdk/android/oss/common/OSSHeaders", DoNotGenerateAcw=true)]
	public abstract class OSSHeaders : Java.Lang.Object {

		internal OSSHeaders ()
		{
		}

		// Metadata.xml XPath field reference: path="/api/package[@name='com.alibaba.sdk.android.oss.common']/interface[@name='OSSHeaders']/field[@name='ACCESS_CONTROL_ALLOW_HEADERS']"
		[Register ("ACCESS_CONTROL_ALLOW_HEADERS")]
		public const string AccessControlAllowHeaders = (string) "Access-Control-Allow-Headers";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.alibaba.sdk.android.oss.common']/interface[@name='OSSHeaders']/field[@name='ACCESS_CONTROL_ALLOW_METHODS']"
		[Register ("ACCESS_CONTROL_ALLOW_METHODS")]
		public const string AccessControlAllowMethods = (string) "Access-Control-Allow-Methods";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.alibaba.sdk.android.oss.common']/interface[@name='OSSHeaders']/field[@name='ACCESS_CONTROL_ALLOW_ORIGIN']"
		[Register ("ACCESS_CONTROL_ALLOW_ORIGIN")]
		public const string AccessControlAllowOrigin = (string) "Access-Control-Allow-Origin";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.alibaba.sdk.android.oss.common']/interface[@name='OSSHeaders']/field[@name='ACCESS_CONTROL_EXPOSE_HEADERS']"
		[Register ("ACCESS_CONTROL_EXPOSE_HEADERS")]
		public const string AccessControlExposeHeaders = (string) "Access-Control-Expose-Headers";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.alibaba.sdk.android.oss.common']/interface[@name='OSSHeaders']/field[@name='ACCESS_CONTROL_MAX_AGE']"
		[Register ("ACCESS_CONTROL_MAX_AGE")]
		public const string AccessControlMaxAge = (string) "Access-Control-Max-Age";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.alibaba.sdk.android.oss.common']/interface[@name='OSSHeaders']/field[@name='ACCESS_CONTROL_REQUEST_HEADER']"
		[Register ("ACCESS_CONTROL_REQUEST_HEADER")]
		public const string AccessControlRequestHeader = (string) "Access-Control-Request-Headers";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.alibaba.sdk.android.oss.common']/interface[@name='OSSHeaders']/field[@name='ACCESS_CONTROL_REQUEST_METHOD']"
		[Register ("ACCESS_CONTROL_REQUEST_METHOD")]
		public const string AccessControlRequestMethod = (string) "Access-Control-Request-Method";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.alibaba.sdk.android.oss.common']/interface[@name='OSSHeaders']/field[@name='COPY_OBJECT_METADATA_DIRECTIVE']"
		[Register ("COPY_OBJECT_METADATA_DIRECTIVE")]
		public const string CopyObjectMetadataDirective = (string) "x-oss-metadata-directive";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.alibaba.sdk.android.oss.common']/interface[@name='OSSHeaders']/field[@name='COPY_OBJECT_SOURCE']"
		[Register ("COPY_OBJECT_SOURCE")]
		public const string CopyObjectSource = (string) "x-oss-copy-source";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.alibaba.sdk.android.oss.common']/interface[@name='OSSHeaders']/field[@name='COPY_OBJECT_SOURCE_IF_MATCH']"
		[Register ("COPY_OBJECT_SOURCE_IF_MATCH")]
		public const string CopyObjectSourceIfMatch = (string) "x-oss-copy-source-if-match";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.alibaba.sdk.android.oss.common']/interface[@name='OSSHeaders']/field[@name='COPY_OBJECT_SOURCE_IF_MODIFIED_SINCE']"
		[Register ("COPY_OBJECT_SOURCE_IF_MODIFIED_SINCE")]
		public const string CopyObjectSourceIfModifiedSince = (string) "x-oss-copy-source-if-modified-since";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.alibaba.sdk.android.oss.common']/interface[@name='OSSHeaders']/field[@name='COPY_OBJECT_SOURCE_IF_NONE_MATCH']"
		[Register ("COPY_OBJECT_SOURCE_IF_NONE_MATCH")]
		public const string CopyObjectSourceIfNoneMatch = (string) "x-oss-copy-source-if-none-match";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.alibaba.sdk.android.oss.common']/interface[@name='OSSHeaders']/field[@name='COPY_OBJECT_SOURCE_IF_UNMODIFIED_SINCE']"
		[Register ("COPY_OBJECT_SOURCE_IF_UNMODIFIED_SINCE")]
		public const string CopyObjectSourceIfUnmodifiedSince = (string) "x-oss-copy-source-if-unmodified-since";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.alibaba.sdk.android.oss.common']/interface[@name='OSSHeaders']/field[@name='COPY_SOURCE_RANGE']"
		[Register ("COPY_SOURCE_RANGE")]
		public const string CopySourceRange = (string) "x-oss-copy-source-range";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.alibaba.sdk.android.oss.common']/interface[@name='OSSHeaders']/field[@name='GET_OBJECT_IF_MATCH']"
		[Register ("GET_OBJECT_IF_MATCH")]
		public const string GetObjectIfMatch = (string) "If-Match";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.alibaba.sdk.android.oss.common']/interface[@name='OSSHeaders']/field[@name='GET_OBJECT_IF_MODIFIED_SINCE']"
		[Register ("GET_OBJECT_IF_MODIFIED_SINCE")]
		public const string GetObjectIfModifiedSince = (string) "If-Modified-Since";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.alibaba.sdk.android.oss.common']/interface[@name='OSSHeaders']/field[@name='GET_OBJECT_IF_NONE_MATCH']"
		[Register ("GET_OBJECT_IF_NONE_MATCH")]
		public const string GetObjectIfNoneMatch = (string) "If-None-Match";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.alibaba.sdk.android.oss.common']/interface[@name='OSSHeaders']/field[@name='GET_OBJECT_IF_UNMODIFIED_SINCE']"
		[Register ("GET_OBJECT_IF_UNMODIFIED_SINCE")]
		public const string GetObjectIfUnmodifiedSince = (string) "If-Unmodified-Since";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.alibaba.sdk.android.oss.common']/interface[@name='OSSHeaders']/field[@name='HEAD_OBJECT_IF_MATCH']"
		[Register ("HEAD_OBJECT_IF_MATCH")]
		public const string HeadObjectIfMatch = (string) "If-Match";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.alibaba.sdk.android.oss.common']/interface[@name='OSSHeaders']/field[@name='HEAD_OBJECT_IF_MODIFIED_SINCE']"
		[Register ("HEAD_OBJECT_IF_MODIFIED_SINCE")]
		public const string HeadObjectIfModifiedSince = (string) "If-Modified-Since";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.alibaba.sdk.android.oss.common']/interface[@name='OSSHeaders']/field[@name='HEAD_OBJECT_IF_NONE_MATCH']"
		[Register ("HEAD_OBJECT_IF_NONE_MATCH")]
		public const string HeadObjectIfNoneMatch = (string) "If-None-Match";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.alibaba.sdk.android.oss.common']/interface[@name='OSSHeaders']/field[@name='HEAD_OBJECT_IF_UNMODIFIED_SINCE']"
		[Register ("HEAD_OBJECT_IF_UNMODIFIED_SINCE")]
		public const string HeadObjectIfUnmodifiedSince = (string) "If-Unmodified-Since";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.alibaba.sdk.android.oss.common']/interface[@name='OSSHeaders']/field[@name='ORIGIN']"
		[Register ("ORIGIN")]
		public const string Origin = (string) "origin";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.alibaba.sdk.android.oss.common']/interface[@name='OSSHeaders']/field[@name='OSS_CANNED_ACL']"
		[Register ("OSS_CANNED_ACL")]
		public const string OssCannedAcl = (string) "x-oss-acl";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.alibaba.sdk.android.oss.common']/interface[@name='OSSHeaders']/field[@name='OSS_HASH_CRC64_ECMA']"
		[Register ("OSS_HASH_CRC64_ECMA")]
		public const string OssHashCrc64Ecma = (string) "x-oss-hash-crc64ecma";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.alibaba.sdk.android.oss.common']/interface[@name='OSSHeaders']/field[@name='OSS_HASH_SHA1']"
		[Register ("OSS_HASH_SHA1")]
		public const string OssHashSha1 = (string) "x-oss-hash-sha1";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.alibaba.sdk.android.oss.common']/interface[@name='OSSHeaders']/field[@name='OSS_HEADER_REQUEST_ID']"
		[Register ("OSS_HEADER_REQUEST_ID")]
		public const string OssHeaderRequestId = (string) "x-oss-request-id";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.alibaba.sdk.android.oss.common']/interface[@name='OSSHeaders']/field[@name='OSS_NEXT_APPEND_POSITION']"
		[Register ("OSS_NEXT_APPEND_POSITION")]
		public const string OssNextAppendPosition = (string) "x-oss-next-append-position";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.alibaba.sdk.android.oss.common']/interface[@name='OSSHeaders']/field[@name='OSS_OBJECT_TYPE']"
		[Register ("OSS_OBJECT_TYPE")]
		public const string OssObjectType = (string) "x-oss-object-type";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.alibaba.sdk.android.oss.common']/interface[@name='OSSHeaders']/field[@name='OSS_PREFIX']"
		[Register ("OSS_PREFIX")]
		public const string OssPrefix = (string) "x-oss-";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.alibaba.sdk.android.oss.common']/interface[@name='OSSHeaders']/field[@name='OSS_SECURITY_TOKEN']"
		[Register ("OSS_SECURITY_TOKEN")]
		public const string OssSecurityToken = (string) "x-oss-security-token";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.alibaba.sdk.android.oss.common']/interface[@name='OSSHeaders']/field[@name='OSS_SERVER_SIDE_ENCRYPTION']"
		[Register ("OSS_SERVER_SIDE_ENCRYPTION")]
		public const string OssServerSideEncryption = (string) "x-oss-server-side-encryption";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.alibaba.sdk.android.oss.common']/interface[@name='OSSHeaders']/field[@name='OSS_USER_METADATA_PREFIX']"
		[Register ("OSS_USER_METADATA_PREFIX")]
		public const string OssUserMetadataPrefix = (string) "x-oss-meta-";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.alibaba.sdk.android.oss.common']/interface[@name='OSSHeaders']/field[@name='OSS_VERSION_ID']"
		[Register ("OSS_VERSION_ID")]
		public const string OssVersionId = (string) "x-oss-version-id";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.alibaba.sdk.android.oss.common']/interface[@name='OSSHeaders']/field[@name='STORAGE_CLASS']"
		[Register ("STORAGE_CLASS")]
		public const string StorageClass = (string) "x-oss-storage-class";

		// The following are fields from: com.alibaba.sdk.android.oss.common.utils.HttpHeaders

		// Metadata.xml XPath field reference: path="/api/package[@name='com.alibaba.sdk.android.oss.common.utils']/interface[@name='HttpHeaders']/field[@name='AUTHORIZATION']"
		[Register ("AUTHORIZATION")]
		public const string Authorization = (string) "Authorization";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.alibaba.sdk.android.oss.common.utils']/interface[@name='HttpHeaders']/field[@name='CACHE_CONTROL']"
		[Register ("CACHE_CONTROL")]
		public const string CacheControl = (string) "Cache-Control";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.alibaba.sdk.android.oss.common.utils']/interface[@name='HttpHeaders']/field[@name='CONTENT_DISPOSITION']"
		[Register ("CONTENT_DISPOSITION")]
		public const string ContentDisposition = (string) "Content-Disposition";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.alibaba.sdk.android.oss.common.utils']/interface[@name='HttpHeaders']/field[@name='CONTENT_ENCODING']"
		[Register ("CONTENT_ENCODING")]
		public const string ContentEncoding = (string) "Content-Encoding";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.alibaba.sdk.android.oss.common.utils']/interface[@name='HttpHeaders']/field[@name='CONTENT_LENGTH']"
		[Register ("CONTENT_LENGTH")]
		public const string ContentLength = (string) "Content-Length";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.alibaba.sdk.android.oss.common.utils']/interface[@name='HttpHeaders']/field[@name='CONTENT_MD5']"
		[Register ("CONTENT_MD5")]
		public const string ContentMd5 = (string) "Content-MD5";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.alibaba.sdk.android.oss.common.utils']/interface[@name='HttpHeaders']/field[@name='CONTENT_TYPE']"
		[Register ("CONTENT_TYPE")]
		public const string ContentType = (string) "Content-Type";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.alibaba.sdk.android.oss.common.utils']/interface[@name='HttpHeaders']/field[@name='DATE']"
		[Register ("DATE")]
		public const string Date = (string) "Date";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.alibaba.sdk.android.oss.common.utils']/interface[@name='HttpHeaders']/field[@name='ETAG']"
		[Register ("ETAG")]
		public const string Etag = (string) "ETag";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.alibaba.sdk.android.oss.common.utils']/interface[@name='HttpHeaders']/field[@name='EXPIRES']"
		[Register ("EXPIRES")]
		public const string Expires = (string) "Expires";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.alibaba.sdk.android.oss.common.utils']/interface[@name='HttpHeaders']/field[@name='HOST']"
		[Register ("HOST")]
		public const string Host = (string) "Host";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.alibaba.sdk.android.oss.common.utils']/interface[@name='HttpHeaders']/field[@name='LAST_MODIFIED']"
		[Register ("LAST_MODIFIED")]
		public const string LastModified = (string) "Last-Modified";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.alibaba.sdk.android.oss.common.utils']/interface[@name='HttpHeaders']/field[@name='LOCATION']"
		[Register ("LOCATION")]
		public const string Location = (string) "Location";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.alibaba.sdk.android.oss.common.utils']/interface[@name='HttpHeaders']/field[@name='RANGE']"
		[Register ("RANGE")]
		public const string Range = (string) "Range";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.alibaba.sdk.android.oss.common.utils']/interface[@name='HttpHeaders']/field[@name='USER_AGENT']"
		[Register ("USER_AGENT")]
		public const string UserAgent = (string) "User-Agent";
	}

	[Register ("com/alibaba/sdk/android/oss/common/OSSHeaders", DoNotGenerateAcw=true)]
	[global::System.Obsolete ("Use the 'OSSHeaders' type. This type will be removed in a future release.", error: true)]
	public abstract class OSSHeadersConsts : OSSHeaders {

		private OSSHeadersConsts ()
		{
		}
	}

}
