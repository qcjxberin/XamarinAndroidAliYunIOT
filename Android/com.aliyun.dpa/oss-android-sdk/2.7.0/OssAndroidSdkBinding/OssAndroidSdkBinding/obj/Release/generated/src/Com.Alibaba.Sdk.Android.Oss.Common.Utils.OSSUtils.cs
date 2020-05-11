using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Alibaba.Sdk.Android.Oss.Common.Utils {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.alibaba.sdk.android.oss.common.utils']/class[@name='OSSUtils']"
	[global::Android.Runtime.Register ("com/alibaba/sdk/android/oss/common/utils/OSSUtils", DoNotGenerateAcw=true)]
	public partial class OSSUtils : global::Java.Lang.Object {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/alibaba/sdk/android/oss/common/utils/OSSUtils", typeof (OSSUtils));
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

		protected OSSUtils (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.alibaba.sdk.android.oss.common.utils']/class[@name='OSSUtils']/constructor[@name='OSSUtils' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe OSSUtils ()
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

		// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.oss.common.utils']/class[@name='OSSUtils']/method[@name='addDateHeader' and count(parameter)=3 and parameter[1][@type='java.util.Map&lt;java.lang.String, java.lang.String&gt;'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.util.Date']]"
		[Register ("addDateHeader", "(Ljava/util/Map;Ljava/lang/String;Ljava/util/Date;)V", "")]
		public static unsafe void AddDateHeader (global::System.Collections.Generic.IDictionary<string, string> headers, string header, global::Java.Util.Date value)
		{
			const string __id = "addDateHeader.(Ljava/util/Map;Ljava/lang/String;Ljava/util/Date;)V";
			IntPtr native_headers = global::Android.Runtime.JavaDictionary<string, string>.ToLocalJniHandle (headers);
			IntPtr native_header = JNIEnv.NewString (header);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (native_headers);
				__args [1] = new JniArgumentValue (native_header);
				__args [2] = new JniArgumentValue ((value == null) ? IntPtr.Zero : ((global::Java.Lang.Object) value).Handle);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_headers);
				JNIEnv.DeleteLocalRef (native_header);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.oss.common.utils']/class[@name='OSSUtils']/method[@name='addHeader' and count(parameter)=3 and parameter[1][@type='java.util.Map&lt;java.lang.String, java.lang.String&gt;'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String']]"
		[Register ("addHeader", "(Ljava/util/Map;Ljava/lang/String;Ljava/lang/String;)V", "")]
		public static unsafe void AddHeader (global::System.Collections.Generic.IDictionary<string, string> headers, string header, string value)
		{
			const string __id = "addHeader.(Ljava/util/Map;Ljava/lang/String;Ljava/lang/String;)V";
			IntPtr native_headers = global::Android.Runtime.JavaDictionary<string, string>.ToLocalJniHandle (headers);
			IntPtr native_header = JNIEnv.NewString (header);
			IntPtr native_value = JNIEnv.NewString (value);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (native_headers);
				__args [1] = new JniArgumentValue (native_header);
				__args [2] = new JniArgumentValue (native_value);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_headers);
				JNIEnv.DeleteLocalRef (native_header);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.oss.common.utils']/class[@name='OSSUtils']/method[@name='addStringListHeader' and count(parameter)=3 and parameter[1][@type='java.util.Map&lt;java.lang.String, java.lang.String&gt;'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.util.List&lt;java.lang.String&gt;']]"
		[Register ("addStringListHeader", "(Ljava/util/Map;Ljava/lang/String;Ljava/util/List;)V", "")]
		public static unsafe void AddStringListHeader (global::System.Collections.Generic.IDictionary<string, string> headers, string header, global::System.Collections.Generic.IList<string> values)
		{
			const string __id = "addStringListHeader.(Ljava/util/Map;Ljava/lang/String;Ljava/util/List;)V";
			IntPtr native_headers = global::Android.Runtime.JavaDictionary<string, string>.ToLocalJniHandle (headers);
			IntPtr native_header = JNIEnv.NewString (header);
			IntPtr native_values = global::Android.Runtime.JavaList<string>.ToLocalJniHandle (values);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (native_headers);
				__args [1] = new JniArgumentValue (native_header);
				__args [2] = new JniArgumentValue (native_values);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_headers);
				JNIEnv.DeleteLocalRef (native_header);
				JNIEnv.DeleteLocalRef (native_values);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.oss.common.utils']/class[@name='OSSUtils']/method[@name='assertTrue' and count(parameter)=2 and parameter[1][@type='boolean'] and parameter[2][@type='java.lang.String']]"
		[Register ("assertTrue", "(ZLjava/lang/String;)V", "")]
		public static unsafe void AssertTrue (bool condition, string message)
		{
			const string __id = "assertTrue.(ZLjava/lang/String;)V";
			IntPtr native_message = JNIEnv.NewString (message);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (condition);
				__args [1] = new JniArgumentValue (native_message);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_message);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.oss.common.utils']/class[@name='OSSUtils']/method[@name='buildBaseLogInfo' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("buildBaseLogInfo", "(Landroid/content/Context;)Ljava/lang/String;", "")]
		public static unsafe string BuildBaseLogInfo (global::Android.Content.Context context)
		{
			const string __id = "buildBaseLogInfo.(Landroid/content/Context;)Ljava/lang/String;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((context == null) ? IntPtr.Zero : ((global::Java.Lang.Object) context).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.oss.common.utils']/class[@name='OSSUtils']/method[@name='buildCanonicalString' and count(parameter)=1 and parameter[1][@type='com.alibaba.sdk.android.oss.internal.RequestMessage']]"
		[Register ("buildCanonicalString", "(Lcom/alibaba/sdk/android/oss/internal/RequestMessage;)Ljava/lang/String;", "")]
		public static unsafe string BuildCanonicalString (global::Com.Alibaba.Sdk.Android.Oss.Internal.RequestMessage request)
		{
			const string __id = "buildCanonicalString.(Lcom/alibaba/sdk/android/oss/internal/RequestMessage;)Ljava/lang/String;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((request == null) ? IntPtr.Zero : ((global::Java.Lang.Object) request).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.oss.common.utils']/class[@name='OSSUtils']/method[@name='buildCanonicalizedResource' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.util.Map&lt;java.lang.String, java.lang.String&gt;']]"
		[Register ("buildCanonicalizedResource", "(Ljava/lang/String;Ljava/lang/String;Ljava/util/Map;)Ljava/lang/String;", "")]
		public static unsafe string BuildCanonicalizedResource (string bucketName, string objectKey, global::System.Collections.Generic.IDictionary<string, string> parameters)
		{
			const string __id = "buildCanonicalizedResource.(Ljava/lang/String;Ljava/lang/String;Ljava/util/Map;)Ljava/lang/String;";
			IntPtr native_bucketName = JNIEnv.NewString (bucketName);
			IntPtr native_objectKey = JNIEnv.NewString (objectKey);
			IntPtr native_parameters = global::Android.Runtime.JavaDictionary<string, string>.ToLocalJniHandle (parameters);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (native_bucketName);
				__args [1] = new JniArgumentValue (native_objectKey);
				__args [2] = new JniArgumentValue (native_parameters);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_bucketName);
				JNIEnv.DeleteLocalRef (native_objectKey);
				JNIEnv.DeleteLocalRef (native_parameters);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.oss.common.utils']/class[@name='OSSUtils']/method[@name='buildCanonicalizedResource' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.util.Map&lt;java.lang.String, java.lang.String&gt;']]"
		[Register ("buildCanonicalizedResource", "(Ljava/lang/String;Ljava/util/Map;)Ljava/lang/String;", "")]
		public static unsafe string BuildCanonicalizedResource (string resourcePath, global::System.Collections.Generic.IDictionary<string, string> parameters)
		{
			const string __id = "buildCanonicalizedResource.(Ljava/lang/String;Ljava/util/Map;)Ljava/lang/String;";
			IntPtr native_resourcePath = JNIEnv.NewString (resourcePath);
			IntPtr native_parameters = global::Android.Runtime.JavaDictionary<string, string>.ToLocalJniHandle (parameters);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_resourcePath);
				__args [1] = new JniArgumentValue (native_parameters);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_resourcePath);
				JNIEnv.DeleteLocalRef (native_parameters);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.oss.common.utils']/class[@name='OSSUtils']/method[@name='buildTriggerCallbackBody' and count(parameter)=2 and parameter[1][@type='java.util.Map&lt;java.lang.String, java.lang.String&gt;'] and parameter[2][@type='java.util.Map&lt;java.lang.String, java.lang.String&gt;']]"
		[Register ("buildTriggerCallbackBody", "(Ljava/util/Map;Ljava/util/Map;)Ljava/lang/String;", "")]
		public static unsafe string BuildTriggerCallbackBody (global::System.Collections.Generic.IDictionary<string, string> callbackParams, global::System.Collections.Generic.IDictionary<string, string> callbackVars)
		{
			const string __id = "buildTriggerCallbackBody.(Ljava/util/Map;Ljava/util/Map;)Ljava/lang/String;";
			IntPtr native_callbackParams = global::Android.Runtime.JavaDictionary<string, string>.ToLocalJniHandle (callbackParams);
			IntPtr native_callbackVars = global::Android.Runtime.JavaDictionary<string, string>.ToLocalJniHandle (callbackVars);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_callbackParams);
				__args [1] = new JniArgumentValue (native_callbackVars);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_callbackParams);
				JNIEnv.DeleteLocalRef (native_callbackVars);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.oss.common.utils']/class[@name='OSSUtils']/method[@name='buildXMLFromPartEtagList' and count(parameter)=1 and parameter[1][@type='java.util.List&lt;com.alibaba.sdk.android.oss.model.PartETag&gt;']]"
		[Register ("buildXMLFromPartEtagList", "(Ljava/util/List;)Ljava/lang/String;", "")]
		public static unsafe string BuildXMLFromPartEtagList (global::System.Collections.Generic.IList<global::Com.Alibaba.Sdk.Android.Oss.Model.PartETag> partETagList)
		{
			const string __id = "buildXMLFromPartEtagList.(Ljava/util/List;)Ljava/lang/String;";
			IntPtr native_partETagList = global::Android.Runtime.JavaList<global::Com.Alibaba.Sdk.Android.Oss.Model.PartETag>.ToLocalJniHandle (partETagList);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_partETagList);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_partETagList);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.oss.common.utils']/class[@name='OSSUtils']/method[@name='checkChecksum' and count(parameter)=3 and parameter[1][@type='java.lang.Long'] and parameter[2][@type='java.lang.Long'] and parameter[3][@type='java.lang.String']]"
		[Register ("checkChecksum", "(Ljava/lang/Long;Ljava/lang/Long;Ljava/lang/String;)V", "")]
		public static unsafe void CheckChecksum (global::Java.Lang.Long clientChecksum, global::Java.Lang.Long serverChecksum, string requestId)
		{
			const string __id = "checkChecksum.(Ljava/lang/Long;Ljava/lang/Long;Ljava/lang/String;)V";
			IntPtr native_requestId = JNIEnv.NewString (requestId);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((clientChecksum == null) ? IntPtr.Zero : ((global::Java.Lang.Object) clientChecksum).Handle);
				__args [1] = new JniArgumentValue ((serverChecksum == null) ? IntPtr.Zero : ((global::Java.Lang.Object) serverChecksum).Handle);
				__args [2] = new JniArgumentValue (native_requestId);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_requestId);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.oss.common.utils']/class[@name='OSSUtils']/method[@name='checkParamRange' and count(parameter)=5 and parameter[1][@type='long'] and parameter[2][@type='long'] and parameter[3][@type='boolean'] and parameter[4][@type='long'] and parameter[5][@type='boolean']]"
		[Register ("checkParamRange", "(JJZJZ)Z", "")]
		public static unsafe bool CheckParamRange (long param, long from, bool leftInclusive, long to, bool rightInclusive)
		{
			const string __id = "checkParamRange.(JJZJZ)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [5];
				__args [0] = new JniArgumentValue (param);
				__args [1] = new JniArgumentValue (from);
				__args [2] = new JniArgumentValue (leftInclusive);
				__args [3] = new JniArgumentValue (to);
				__args [4] = new JniArgumentValue (rightInclusive);
				var __rm = _members.StaticMethods.InvokeBooleanMethod (__id, __args);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.oss.common.utils']/class[@name='OSSUtils']/method[@name='determineContentType' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String']]"
		[Register ("determineContentType", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;", "")]
		public static unsafe string DetermineContentType (string initValue, string srcPath, string toObjectKey)
		{
			const string __id = "determineContentType.(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;";
			IntPtr native_initValue = JNIEnv.NewString (initValue);
			IntPtr native_srcPath = JNIEnv.NewString (srcPath);
			IntPtr native_toObjectKey = JNIEnv.NewString (toObjectKey);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (native_initValue);
				__args [1] = new JniArgumentValue (native_srcPath);
				__args [2] = new JniArgumentValue (native_toObjectKey);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_initValue);
				JNIEnv.DeleteLocalRef (native_srcPath);
				JNIEnv.DeleteLocalRef (native_toObjectKey);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.oss.common.utils']/class[@name='OSSUtils']/method[@name='doesRequestNeedObjectKey' and count(parameter)=1 and parameter[1][@type='com.alibaba.sdk.android.oss.model.OSSRequest']]"
		[Register ("doesRequestNeedObjectKey", "(Lcom/alibaba/sdk/android/oss/model/OSSRequest;)Z", "")]
		public static unsafe bool DoesRequestNeedObjectKey (global::Com.Alibaba.Sdk.Android.Oss.Model.OSSRequest request)
		{
			const string __id = "doesRequestNeedObjectKey.(Lcom/alibaba/sdk/android/oss/model/OSSRequest;)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((request == null) ? IntPtr.Zero : ((global::Java.Lang.Object) request).Handle);
				var __rm = _members.StaticMethods.InvokeBooleanMethod (__id, __args);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.oss.common.utils']/class[@name='OSSUtils']/method[@name='ensureBucketNameValid' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("ensureBucketNameValid", "(Ljava/lang/String;)V", "")]
		public static unsafe void EnsureBucketNameValid (string bucketName)
		{
			const string __id = "ensureBucketNameValid.(Ljava/lang/String;)V";
			IntPtr native_bucketName = JNIEnv.NewString (bucketName);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_bucketName);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_bucketName);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.oss.common.utils']/class[@name='OSSUtils']/method[@name='ensureObjectKeyValid' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("ensureObjectKeyValid", "(Ljava/lang/String;)V", "")]
		public static unsafe void EnsureObjectKeyValid (string objectKey)
		{
			const string __id = "ensureObjectKeyValid.(Ljava/lang/String;)V";
			IntPtr native_objectKey = JNIEnv.NewString (objectKey);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_objectKey);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_objectKey);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.oss.common.utils']/class[@name='OSSUtils']/method[@name='ensureRequestValid' and count(parameter)=2 and parameter[1][@type='com.alibaba.sdk.android.oss.model.OSSRequest'] and parameter[2][@type='com.alibaba.sdk.android.oss.internal.RequestMessage']]"
		[Register ("ensureRequestValid", "(Lcom/alibaba/sdk/android/oss/model/OSSRequest;Lcom/alibaba/sdk/android/oss/internal/RequestMessage;)V", "")]
		public static unsafe void EnsureRequestValid (global::Com.Alibaba.Sdk.Android.Oss.Model.OSSRequest request, global::Com.Alibaba.Sdk.Android.Oss.Internal.RequestMessage message)
		{
			const string __id = "ensureRequestValid.(Lcom/alibaba/sdk/android/oss/model/OSSRequest;Lcom/alibaba/sdk/android/oss/internal/RequestMessage;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((request == null) ? IntPtr.Zero : ((global::Java.Lang.Object) request).Handle);
				__args [1] = new JniArgumentValue ((message == null) ? IntPtr.Zero : ((global::Java.Lang.Object) message).Handle);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.oss.common.utils']/class[@name='OSSUtils']/method[@name='isCname' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("isCname", "(Ljava/lang/String;)Z", "")]
		public static unsafe bool IsCname (string host)
		{
			const string __id = "isCname.(Ljava/lang/String;)Z";
			IntPtr native_host = JNIEnv.NewString (host);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_host);
				var __rm = _members.StaticMethods.InvokeBooleanMethod (__id, __args);
				return __rm;
			} finally {
				JNIEnv.DeleteLocalRef (native_host);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.oss.common.utils']/class[@name='OSSUtils']/method[@name='isEmptyString' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("isEmptyString", "(Ljava/lang/String;)Z", "")]
		public static unsafe bool IsEmptyString (string str)
		{
			const string __id = "isEmptyString.(Ljava/lang/String;)Z";
			IntPtr native_str = JNIEnv.NewString (str);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_str);
				var __rm = _members.StaticMethods.InvokeBooleanMethod (__id, __args);
				return __rm;
			} finally {
				JNIEnv.DeleteLocalRef (native_str);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.oss.common.utils']/class[@name='OSSUtils']/method[@name='isIP' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("isIP", "(Ljava/lang/String;)Z", "")]
		public static unsafe bool IsIP (string addr)
		{
			const string __id = "isIP.(Ljava/lang/String;)Z";
			IntPtr native_addr = JNIEnv.NewString (addr);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_addr);
				var __rm = _members.StaticMethods.InvokeBooleanMethod (__id, __args);
				return __rm;
			} finally {
				JNIEnv.DeleteLocalRef (native_addr);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.oss.common.utils']/class[@name='OSSUtils']/method[@name='isInCustomCnameExcludeList' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.util.List&lt;java.lang.String&gt;']]"
		[Register ("isInCustomCnameExcludeList", "(Ljava/lang/String;Ljava/util/List;)Z", "")]
		public static unsafe bool IsInCustomCnameExcludeList (string endpoint, global::System.Collections.Generic.IList<string> customCnameExludeList)
		{
			const string __id = "isInCustomCnameExcludeList.(Ljava/lang/String;Ljava/util/List;)Z";
			IntPtr native_endpoint = JNIEnv.NewString (endpoint);
			IntPtr native_customCnameExludeList = global::Android.Runtime.JavaList<string>.ToLocalJniHandle (customCnameExludeList);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_endpoint);
				__args [1] = new JniArgumentValue (native_customCnameExludeList);
				var __rm = _members.StaticMethods.InvokeBooleanMethod (__id, __args);
				return __rm;
			} finally {
				JNIEnv.DeleteLocalRef (native_endpoint);
				JNIEnv.DeleteLocalRef (native_customCnameExludeList);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.oss.common.utils']/class[@name='OSSUtils']/method[@name='join' and count(parameter)=1 and parameter[1][@type='java.util.List&lt;java.lang.String&gt;']]"
		[Register ("join", "(Ljava/util/List;)Ljava/lang/String;", "")]
		public static unsafe string Join (global::System.Collections.Generic.IList<string> strings)
		{
			const string __id = "join.(Ljava/util/List;)Ljava/lang/String;";
			IntPtr native_strings = global::Android.Runtime.JavaList<string>.ToLocalJniHandle (strings);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_strings);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_strings);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.oss.common.utils']/class[@name='OSSUtils']/method[@name='paramToQueryString' and count(parameter)=2 and parameter[1][@type='java.util.Map&lt;java.lang.String, java.lang.String&gt;'] and parameter[2][@type='java.lang.String']]"
		[Register ("paramToQueryString", "(Ljava/util/Map;Ljava/lang/String;)Ljava/lang/String;", "")]
		public static unsafe string ParamToQueryString (global::System.Collections.Generic.IDictionary<string, string> @params, string charset)
		{
			const string __id = "paramToQueryString.(Ljava/util/Map;Ljava/lang/String;)Ljava/lang/String;";
			IntPtr native__params = global::Android.Runtime.JavaDictionary<string, string>.ToLocalJniHandle (@params);
			IntPtr native_charset = JNIEnv.NewString (charset);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native__params);
				__args [1] = new JniArgumentValue (native_charset);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native__params);
				JNIEnv.DeleteLocalRef (native_charset);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.oss.common.utils']/class[@name='OSSUtils']/method[@name='populateCopyObjectHeaders' and count(parameter)=2 and parameter[1][@type='com.alibaba.sdk.android.oss.model.CopyObjectRequest'] and parameter[2][@type='java.util.Map&lt;java.lang.String, java.lang.String&gt;']]"
		[Register ("populateCopyObjectHeaders", "(Lcom/alibaba/sdk/android/oss/model/CopyObjectRequest;Ljava/util/Map;)V", "")]
		public static unsafe void PopulateCopyObjectHeaders (global::Com.Alibaba.Sdk.Android.Oss.Model.CopyObjectRequest copyObjectRequest, global::System.Collections.Generic.IDictionary<string, string> headers)
		{
			const string __id = "populateCopyObjectHeaders.(Lcom/alibaba/sdk/android/oss/model/CopyObjectRequest;Ljava/util/Map;)V";
			IntPtr native_headers = global::Android.Runtime.JavaDictionary<string, string>.ToLocalJniHandle (headers);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((copyObjectRequest == null) ? IntPtr.Zero : ((global::Java.Lang.Object) copyObjectRequest).Handle);
				__args [1] = new JniArgumentValue (native_headers);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_headers);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.oss.common.utils']/class[@name='OSSUtils']/method[@name='populateListObjectsRequestParameters' and count(parameter)=2 and parameter[1][@type='com.alibaba.sdk.android.oss.model.ListObjectsRequest'] and parameter[2][@type='java.util.Map&lt;java.lang.String, java.lang.String&gt;']]"
		[Register ("populateListObjectsRequestParameters", "(Lcom/alibaba/sdk/android/oss/model/ListObjectsRequest;Ljava/util/Map;)V", "")]
		public static unsafe void PopulateListObjectsRequestParameters (global::Com.Alibaba.Sdk.Android.Oss.Model.ListObjectsRequest listObjectsRequest, global::System.Collections.Generic.IDictionary<string, string> @params)
		{
			const string __id = "populateListObjectsRequestParameters.(Lcom/alibaba/sdk/android/oss/model/ListObjectsRequest;Ljava/util/Map;)V";
			IntPtr native__params = global::Android.Runtime.JavaDictionary<string, string>.ToLocalJniHandle (@params);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((listObjectsRequest == null) ? IntPtr.Zero : ((global::Java.Lang.Object) listObjectsRequest).Handle);
				__args [1] = new JniArgumentValue (native__params);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native__params);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.oss.common.utils']/class[@name='OSSUtils']/method[@name='populateMapToBase64JsonString' and count(parameter)=1 and parameter[1][@type='java.util.Map&lt;java.lang.String, java.lang.String&gt;']]"
		[Register ("populateMapToBase64JsonString", "(Ljava/util/Map;)Ljava/lang/String;", "")]
		public static unsafe string PopulateMapToBase64JsonString (global::System.Collections.Generic.IDictionary<string, string> map)
		{
			const string __id = "populateMapToBase64JsonString.(Ljava/util/Map;)Ljava/lang/String;";
			IntPtr native_map = global::Android.Runtime.JavaDictionary<string, string>.ToLocalJniHandle (map);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_map);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_map);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.oss.common.utils']/class[@name='OSSUtils']/method[@name='populateRequestMetadata' and count(parameter)=2 and parameter[1][@type='java.util.Map&lt;java.lang.String, java.lang.String&gt;'] and parameter[2][@type='com.alibaba.sdk.android.oss.model.ObjectMetadata']]"
		[Register ("populateRequestMetadata", "(Ljava/util/Map;Lcom/alibaba/sdk/android/oss/model/ObjectMetadata;)V", "")]
		public static unsafe void PopulateRequestMetadata (global::System.Collections.Generic.IDictionary<string, string> headers, global::Com.Alibaba.Sdk.Android.Oss.Model.ObjectMetadata metadata)
		{
			const string __id = "populateRequestMetadata.(Ljava/util/Map;Lcom/alibaba/sdk/android/oss/model/ObjectMetadata;)V";
			IntPtr native_headers = global::Android.Runtime.JavaDictionary<string, string>.ToLocalJniHandle (headers);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_headers);
				__args [1] = new JniArgumentValue ((metadata == null) ? IntPtr.Zero : ((global::Java.Lang.Object) metadata).Handle);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_headers);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.oss.common.utils']/class[@name='OSSUtils']/method[@name='removeHeader' and count(parameter)=2 and parameter[1][@type='java.util.Map&lt;java.lang.String, java.lang.String&gt;'] and parameter[2][@type='java.lang.String']]"
		[Register ("removeHeader", "(Ljava/util/Map;Ljava/lang/String;)V", "")]
		public static unsafe void RemoveHeader (global::System.Collections.Generic.IDictionary<string, string> headers, string header)
		{
			const string __id = "removeHeader.(Ljava/util/Map;Ljava/lang/String;)V";
			IntPtr native_headers = global::Android.Runtime.JavaDictionary<string, string>.ToLocalJniHandle (headers);
			IntPtr native_header = JNIEnv.NewString (header);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_headers);
				__args [1] = new JniArgumentValue (native_header);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_headers);
				JNIEnv.DeleteLocalRef (native_header);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.oss.common.utils']/class[@name='OSSUtils']/method[@name='sign' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String']]"
		[Register ("sign", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;", "")]
		public static unsafe string Sign (string accessKey, string screctKey, string content)
		{
			const string __id = "sign.(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;";
			IntPtr native_accessKey = JNIEnv.NewString (accessKey);
			IntPtr native_screctKey = JNIEnv.NewString (screctKey);
			IntPtr native_content = JNIEnv.NewString (content);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (native_accessKey);
				__args [1] = new JniArgumentValue (native_screctKey);
				__args [2] = new JniArgumentValue (native_content);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_accessKey);
				JNIEnv.DeleteLocalRef (native_screctKey);
				JNIEnv.DeleteLocalRef (native_content);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.oss.common.utils']/class[@name='OSSUtils']/method[@name='signRequest' and count(parameter)=1 and parameter[1][@type='com.alibaba.sdk.android.oss.internal.RequestMessage']]"
		[Register ("signRequest", "(Lcom/alibaba/sdk/android/oss/internal/RequestMessage;)V", "")]
		public static unsafe void SignRequest (global::Com.Alibaba.Sdk.Android.Oss.Internal.RequestMessage message)
		{
			const string __id = "signRequest.(Lcom/alibaba/sdk/android/oss/internal/RequestMessage;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((message == null) ? IntPtr.Zero : ((global::Java.Lang.Object) message).Handle);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.oss.common.utils']/class[@name='OSSUtils']/method[@name='validateBucketName' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("validateBucketName", "(Ljava/lang/String;)Z", "")]
		public static unsafe bool ValidateBucketName (string bucketName)
		{
			const string __id = "validateBucketName.(Ljava/lang/String;)Z";
			IntPtr native_bucketName = JNIEnv.NewString (bucketName);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_bucketName);
				var __rm = _members.StaticMethods.InvokeBooleanMethod (__id, __args);
				return __rm;
			} finally {
				JNIEnv.DeleteLocalRef (native_bucketName);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.oss.common.utils']/class[@name='OSSUtils']/method[@name='validateObjectKey' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("validateObjectKey", "(Ljava/lang/String;)Z", "")]
		public static unsafe bool ValidateObjectKey (string objectKey)
		{
			const string __id = "validateObjectKey.(Ljava/lang/String;)Z";
			IntPtr native_objectKey = JNIEnv.NewString (objectKey);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_objectKey);
				var __rm = _members.StaticMethods.InvokeBooleanMethod (__id, __args);
				return __rm;
			} finally {
				JNIEnv.DeleteLocalRef (native_objectKey);
			}
		}

	}
}
