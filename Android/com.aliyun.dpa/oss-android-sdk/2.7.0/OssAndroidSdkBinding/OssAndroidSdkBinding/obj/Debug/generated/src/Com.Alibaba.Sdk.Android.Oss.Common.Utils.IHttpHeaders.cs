using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Alibaba.Sdk.Android.Oss.Common.Utils {

	[Register ("com/alibaba/sdk/android/oss/common/utils/HttpHeaders", DoNotGenerateAcw=true)]
	public abstract class HttpHeaders : Java.Lang.Object {

		internal HttpHeaders ()
		{
		}

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

	[Register ("com/alibaba/sdk/android/oss/common/utils/HttpHeaders", DoNotGenerateAcw=true)]
	[global::System.Obsolete ("Use the 'HttpHeaders' type. This type will be removed in a future release.", error: true)]
	public abstract class HttpHeadersConsts : HttpHeaders {

		private HttpHeadersConsts ()
		{
		}
	}

}
