using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Aliyun.Alink.Linksdk.Alcs.Coap.Resources {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.coap.resources']/class[@name='LinkFormat']"
	[global::Android.Runtime.Register ("com/aliyun/alink/linksdk/alcs/coap/resources/LinkFormat", DoNotGenerateAcw=true)]
	public partial class LinkFormat : global::Java.Lang.Object {



		// Metadata.xml XPath field reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.coap.resources']/class[@name='LinkFormat']/field[@name='CARDINAL']"
		[Register ("CARDINAL")]
		public static global::Java.Util.Regex.Pattern Cardinal {
			get {
				const string __id = "CARDINAL.Ljava/util/regex/Pattern;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Java.Util.Regex.Pattern> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Metadata.xml XPath field reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.coap.resources']/class[@name='LinkFormat']/field[@name='COAP_PERM_DELETE']"
		[Register ("COAP_PERM_DELETE")]
		public const int CoapPermDelete = (int) 8;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.coap.resources']/class[@name='LinkFormat']/field[@name='COAP_PERM_GET']"
		[Register ("COAP_PERM_GET")]
		public const int CoapPermGet = (int) 1;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.coap.resources']/class[@name='LinkFormat']/field[@name='COAP_PERM_GET_POST']"
		[Register ("COAP_PERM_GET_POST")]
		public const int CoapPermGetPost = (int) 3;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.coap.resources']/class[@name='LinkFormat']/field[@name='COAP_PERM_NONE']"
		[Register ("COAP_PERM_NONE")]
		public const int CoapPermNone = (int) 0;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.coap.resources']/class[@name='LinkFormat']/field[@name='COAP_PERM_OBSERVE']"
		[Register ("COAP_PERM_OBSERVE")]
		public const int CoapPermObserve = (int) 256;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.coap.resources']/class[@name='LinkFormat']/field[@name='COAP_PERM_POST']"
		[Register ("COAP_PERM_POST")]
		public const int CoapPermPost = (int) 2;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.coap.resources']/class[@name='LinkFormat']/field[@name='COAP_PERM_PUT']"
		[Register ("COAP_PERM_PUT")]
		public const int CoapPermPut = (int) 4;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.coap.resources']/class[@name='LinkFormat']/field[@name='CONTENT_TYPE']"
		[Register ("CONTENT_TYPE")]
		public const string ContentType = (string) "ct";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.coap.resources']/class[@name='LinkFormat']/field[@name='CONTEXT']"
		[Register ("CONTEXT")]
		public const string Context = (string) "con";


		// Metadata.xml XPath field reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.coap.resources']/class[@name='LinkFormat']/field[@name='DELIMITER']"
		[Register ("DELIMITER")]
		public static global::Java.Util.Regex.Pattern Delimiter {
			get {
				const string __id = "DELIMITER.Ljava/util/regex/Pattern;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Java.Util.Regex.Pattern> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Metadata.xml XPath field reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.coap.resources']/class[@name='LinkFormat']/field[@name='DOMAIN']"
		[Register ("DOMAIN")]
		public const string Domain = (string) "d";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.coap.resources']/class[@name='LinkFormat']/field[@name='END_POINT']"
		[Register ("END_POINT")]
		public const string EndPoint = (string) "ep";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.coap.resources']/class[@name='LinkFormat']/field[@name='END_POINT_TYPE']"
		[Register ("END_POINT_TYPE")]
		public const string EndPointType = (string) "et";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.coap.resources']/class[@name='LinkFormat']/field[@name='HOST']"
		[Register ("HOST")]
		public const string Host = (string) "h";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.coap.resources']/class[@name='LinkFormat']/field[@name='INSTANCE']"
		[Register ("INSTANCE")]
		public const string Instance = (string) "ins";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.coap.resources']/class[@name='LinkFormat']/field[@name='INTERFACE_DESCRIPTION']"
		[Register ("INTERFACE_DESCRIPTION")]
		public const string InterfaceDescription = (string) "if";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.coap.resources']/class[@name='LinkFormat']/field[@name='LIFE_TIME']"
		[Register ("LIFE_TIME")]
		public const string LifeTime = (string) "lt";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.coap.resources']/class[@name='LinkFormat']/field[@name='LINK']"
		[Register ("LINK")]
		public const string Link = (string) "href";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.coap.resources']/class[@name='LinkFormat']/field[@name='MAX_SIZE_ESTIMATE']"
		[Register ("MAX_SIZE_ESTIMATE")]
		public const string MaxSizeEstimate = (string) "sz";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.coap.resources']/class[@name='LinkFormat']/field[@name='OBSERVABLE']"
		[Register ("OBSERVABLE")]
		public const string Observable = (string) "obs";


		// Metadata.xml XPath field reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.coap.resources']/class[@name='LinkFormat']/field[@name='QUOTED_STRING']"
		[Register ("QUOTED_STRING")]
		public static global::Java.Util.Regex.Pattern QuotedString {
			get {
				const string __id = "QUOTED_STRING.Ljava/util/regex/Pattern;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Java.Util.Regex.Pattern> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Metadata.xml XPath field reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.coap.resources']/class[@name='LinkFormat']/field[@name='RESOURCE_TYPE']"
		[Register ("RESOURCE_TYPE")]
		public const string ResourceType = (string) "rt";


		// Metadata.xml XPath field reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.coap.resources']/class[@name='LinkFormat']/field[@name='SEPARATOR']"
		[Register ("SEPARATOR")]
		public static global::Java.Util.Regex.Pattern Separator {
			get {
				const string __id = "SEPARATOR.Ljava/util/regex/Pattern;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Java.Util.Regex.Pattern> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Metadata.xml XPath field reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.coap.resources']/class[@name='LinkFormat']/field[@name='TITLE']"
		[Register ("TITLE")]
		public const string Title = (string) "title";


		// Metadata.xml XPath field reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.coap.resources']/class[@name='LinkFormat']/field[@name='WORD']"
		[Register ("WORD")]
		public static global::Java.Util.Regex.Pattern Word {
			get {
				const string __id = "WORD.Ljava/util/regex/Pattern;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Java.Util.Regex.Pattern> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/aliyun/alink/linksdk/alcs/coap/resources/LinkFormat", typeof (LinkFormat));
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

		protected LinkFormat (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.coap.resources']/class[@name='LinkFormat']/constructor[@name='LinkFormat' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe LinkFormat ()
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

		// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.coap.resources']/class[@name='LinkFormat']/method[@name='matches' and count(parameter)=2 and parameter[1][@type='com.aliyun.alink.linksdk.alcs.coap.resources.Resource'] and parameter[2][@type='java.util.List&lt;java.lang.String&gt;']]"
		[Register ("matches", "(Lcom/aliyun/alink/linksdk/alcs/coap/resources/Resource;Ljava/util/List;)Z", "")]
		public static unsafe bool Matches (global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.Resources.IResource resource, global::System.Collections.Generic.IList<string> queries)
		{
			const string __id = "matches.(Lcom/aliyun/alink/linksdk/alcs/coap/resources/Resource;Ljava/util/List;)Z";
			IntPtr native_queries = global::Android.Runtime.JavaList<string>.ToLocalJniHandle (queries);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((resource == null) ? IntPtr.Zero : ((global::Java.Lang.Object) resource).Handle);
				__args [1] = new JniArgumentValue (native_queries);
				var __rm = _members.StaticMethods.InvokeBooleanMethod (__id, __args);
				return __rm;
			} finally {
				JNIEnv.DeleteLocalRef (native_queries);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.coap.resources']/class[@name='LinkFormat']/method[@name='serializeAttribute' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.util.List&lt;java.lang.String&gt;']]"
		[Register ("serializeAttribute", "(Ljava/lang/String;Ljava/util/List;)Ljava/lang/StringBuilder;", "")]
		public static unsafe global::Java.Lang.StringBuilder SerializeAttribute (string key, global::System.Collections.Generic.IList<string> values)
		{
			const string __id = "serializeAttribute.(Ljava/lang/String;Ljava/util/List;)Ljava/lang/StringBuilder;";
			IntPtr native_key = JNIEnv.NewString (key);
			IntPtr native_values = global::Android.Runtime.JavaList<string>.ToLocalJniHandle (values);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_key);
				__args [1] = new JniArgumentValue (native_values);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Java.Lang.StringBuilder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_key);
				JNIEnv.DeleteLocalRef (native_values);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.coap.resources']/class[@name='LinkFormat']/method[@name='serializeAttributes' and count(parameter)=1 and parameter[1][@type='com.aliyun.alink.linksdk.alcs.coap.resources.ResourceAttributes']]"
		[Register ("serializeAttributes", "(Lcom/aliyun/alink/linksdk/alcs/coap/resources/ResourceAttributes;)Ljava/lang/StringBuilder;", "")]
		public static unsafe global::Java.Lang.StringBuilder SerializeAttributes (global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.Resources.ResourceAttributes attributes)
		{
			const string __id = "serializeAttributes.(Lcom/aliyun/alink/linksdk/alcs/coap/resources/ResourceAttributes;)Ljava/lang/StringBuilder;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((attributes == null) ? IntPtr.Zero : ((global::Java.Lang.Object) attributes).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Java.Lang.StringBuilder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.coap.resources']/class[@name='LinkFormat']/method[@name='serializeResource' and count(parameter)=1 and parameter[1][@type='com.aliyun.alink.linksdk.alcs.coap.resources.Resource']]"
		[Register ("serializeResource", "(Lcom/aliyun/alink/linksdk/alcs/coap/resources/Resource;)Ljava/lang/StringBuilder;", "")]
		public static unsafe global::Java.Lang.StringBuilder SerializeResource (global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.Resources.IResource resource)
		{
			const string __id = "serializeResource.(Lcom/aliyun/alink/linksdk/alcs/coap/resources/Resource;)Ljava/lang/StringBuilder;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((resource == null) ? IntPtr.Zero : ((global::Java.Lang.Object) resource).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Java.Lang.StringBuilder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.coap.resources']/class[@name='LinkFormat']/method[@name='serializeTree' and count(parameter)=1 and parameter[1][@type='com.aliyun.alink.linksdk.alcs.coap.resources.Resource']]"
		[Register ("serializeTree", "(Lcom/aliyun/alink/linksdk/alcs/coap/resources/Resource;)Ljava/lang/String;", "")]
		public static unsafe string SerializeTree (global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.Resources.IResource resource)
		{
			const string __id = "serializeTree.(Lcom/aliyun/alink/linksdk/alcs/coap/resources/Resource;)Ljava/lang/String;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((resource == null) ? IntPtr.Zero : ((global::Java.Lang.Object) resource).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.coap.resources']/class[@name='LinkFormat']/method[@name='serializeTree' and count(parameter)=3 and parameter[1][@type='com.aliyun.alink.linksdk.alcs.coap.resources.Resource'] and parameter[2][@type='java.util.List&lt;java.lang.String&gt;'] and parameter[3][@type='java.lang.StringBuilder']]"
		[Register ("serializeTree", "(Lcom/aliyun/alink/linksdk/alcs/coap/resources/Resource;Ljava/util/List;Ljava/lang/StringBuilder;)V", "")]
		public static unsafe void SerializeTree (global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.Resources.IResource resource, global::System.Collections.Generic.IList<string> queries, global::Java.Lang.StringBuilder buffer)
		{
			const string __id = "serializeTree.(Lcom/aliyun/alink/linksdk/alcs/coap/resources/Resource;Ljava/util/List;Ljava/lang/StringBuilder;)V";
			IntPtr native_queries = global::Android.Runtime.JavaList<string>.ToLocalJniHandle (queries);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((resource == null) ? IntPtr.Zero : ((global::Java.Lang.Object) resource).Handle);
				__args [1] = new JniArgumentValue (native_queries);
				__args [2] = new JniArgumentValue ((buffer == null) ? IntPtr.Zero : ((global::Java.Lang.Object) buffer).Handle);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_queries);
			}
		}

	}
}
