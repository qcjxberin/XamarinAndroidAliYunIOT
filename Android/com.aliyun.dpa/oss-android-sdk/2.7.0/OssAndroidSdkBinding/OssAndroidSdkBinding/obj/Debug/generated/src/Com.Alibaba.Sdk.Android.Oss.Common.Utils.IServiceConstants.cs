using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Alibaba.Sdk.Android.Oss.Common.Utils {

	[Register ("com/alibaba/sdk/android/oss/common/utils/ServiceConstants", DoNotGenerateAcw=true)]
	public abstract class ServiceConstants : Java.Lang.Object {

		internal ServiceConstants ()
		{
		}

		// Metadata.xml XPath field reference: path="/api/package[@name='com.alibaba.sdk.android.oss.common.utils']/interface[@name='ServiceConstants']/field[@name='DEFAULT_ENCODING']"
		[Register ("DEFAULT_ENCODING")]
		public const string DefaultEncoding = (string) "utf-8";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.alibaba.sdk.android.oss.common.utils']/interface[@name='ServiceConstants']/field[@name='RESOURCE_NAME_COMMON']"
		[Register ("RESOURCE_NAME_COMMON")]
		public const string ResourceNameCommon = (string) "common";
	}

	[Register ("com/alibaba/sdk/android/oss/common/utils/ServiceConstants", DoNotGenerateAcw=true)]
	[global::System.Obsolete ("Use the 'ServiceConstants' type. This type will be removed in a future release.", error: true)]
	public abstract class ServiceConstantsConsts : ServiceConstants {

		private ServiceConstantsConsts ()
		{
		}
	}

}
