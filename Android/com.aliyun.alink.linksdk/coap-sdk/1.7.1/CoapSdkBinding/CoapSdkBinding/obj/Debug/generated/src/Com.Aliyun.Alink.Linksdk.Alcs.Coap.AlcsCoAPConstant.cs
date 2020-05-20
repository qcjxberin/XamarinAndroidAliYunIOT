using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Aliyun.Alink.Linksdk.Alcs.Coap {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.coap']/class[@name='AlcsCoAPConstant']"
	[global::Android.Runtime.Register ("com/aliyun/alink/linksdk/alcs/coap/AlcsCoAPConstant", DoNotGenerateAcw=true)]
	public sealed partial class AlcsCoAPConstant : global::Java.Lang.Object {


		// Metadata.xml XPath field reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.coap']/class[@name='AlcsCoAPConstant']/field[@name='COAP_RECV_RESP_TIMEOUT']"
		[Register ("COAP_RECV_RESP_TIMEOUT")]
		public const int CoapRecvRespTimeout = (int) 1;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.coap']/class[@name='AlcsCoAPConstant']/field[@name='COAP_REQUEST_SUCCESS']"
		[Register ("COAP_REQUEST_SUCCESS")]
		public const int CoapRequestSuccess = (int) 0;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.coap']/class[@name='AlcsCoAPConstant']/field[@name='COAP_SECURE_TCP_URI_SCHEME']"
		[Register ("COAP_SECURE_TCP_URI_SCHEME")]
		public const string CoapSecureTcpUriScheme = (string) "coaps+tcp";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.coap']/class[@name='AlcsCoAPConstant']/field[@name='COAP_SECURE_URI_SCHEME']"
		[Register ("COAP_SECURE_URI_SCHEME")]
		public const string CoapSecureUriScheme = (string) "coaps";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.coap']/class[@name='AlcsCoAPConstant']/field[@name='COAP_TCP_URI_SCHEME']"
		[Register ("COAP_TCP_URI_SCHEME")]
		public const string CoapTcpUriScheme = (string) "coap+tcp";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.coap']/class[@name='AlcsCoAPConstant']/field[@name='COAP_URI_SCHEME']"
		[Register ("COAP_URI_SCHEME")]
		public const string CoapUriScheme = (string) "coap";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.coap']/class[@name='AlcsCoAPConstant']/field[@name='DEFAULT_COAP_PORT']"
		[Register ("DEFAULT_COAP_PORT")]
		public const int DefaultCoapPort = (int) 5683;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.coap']/class[@name='AlcsCoAPConstant']/field[@name='DEFAULT_COAP_SECURE_PORT']"
		[Register ("DEFAULT_COAP_SECURE_PORT")]
		public const int DefaultCoapSecurePort = (int) 5684;


		// Metadata.xml XPath field reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.coap']/class[@name='AlcsCoAPConstant']/field[@name='UTF8_CHARSET']"
		[Register ("UTF8_CHARSET")]
		public static global::Java.Nio.Charset.Charset Utf8Charset {
			get {
				const string __id = "UTF8_CHARSET.Ljava/nio/charset/Charset;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Java.Nio.Charset.Charset> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Metadata.xml XPath field reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.coap']/class[@name='AlcsCoAPConstant']/field[@name='VERSION']"
		[Register ("VERSION")]
		public const int Version = (int) 1;
		// Metadata.xml XPath class reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.coap']/class[@name='AlcsCoAPConstant.Code']"
		[global::Android.Runtime.Register ("com/aliyun/alink/linksdk/alcs/coap/AlcsCoAPConstant$Code", DoNotGenerateAcw=true)]
		public sealed partial class Code : global::Java.Lang.Enum {



			// Metadata.xml XPath field reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.coap']/class[@name='AlcsCoAPConstant.Code']/field[@name='DELETE']"
			[Register ("DELETE")]
			public static global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.AlcsCoAPConstant.Code Delete {
				get {
					const string __id = "DELETE.Lcom/aliyun/alink/linksdk/alcs/coap/AlcsCoAPConstant$Code;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.AlcsCoAPConstant.Code> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.coap']/class[@name='AlcsCoAPConstant.Code']/field[@name='GET']"
			[Register ("GET")]
			public static global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.AlcsCoAPConstant.Code Get {
				get {
					const string __id = "GET.Lcom/aliyun/alink/linksdk/alcs/coap/AlcsCoAPConstant$Code;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.AlcsCoAPConstant.Code> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.coap']/class[@name='AlcsCoAPConstant.Code']/field[@name='POST']"
			[Register ("POST")]
			public static global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.AlcsCoAPConstant.Code Post {
				get {
					const string __id = "POST.Lcom/aliyun/alink/linksdk/alcs/coap/AlcsCoAPConstant$Code;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.AlcsCoAPConstant.Code> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.coap']/class[@name='AlcsCoAPConstant.Code']/field[@name='PUT']"
			[Register ("PUT")]
			public static global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.AlcsCoAPConstant.Code Put {
				get {
					const string __id = "PUT.Lcom/aliyun/alink/linksdk/alcs/coap/AlcsCoAPConstant$Code;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.AlcsCoAPConstant.Code> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.coap']/class[@name='AlcsCoAPConstant.Code']/field[@name='value']"
			[Register ("value")]
			public int Value {
				get {
					const string __id = "value.I";

					var __v = _members.InstanceFields.GetInt32Value (__id, this);
					return __v;
				}
				set {
					const string __id = "value.I";

					try {
						_members.InstanceFields.SetValue (__id, this, value);
					} finally {
					}
				}
			}
			static readonly JniPeerMembers _members = new XAPeerMembers ("com/aliyun/alink/linksdk/alcs/coap/AlcsCoAPConstant$Code", typeof (Code));
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

			internal Code (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.coap']/class[@name='AlcsCoAPConstant.Code']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("valueOf", "(I)Lcom/aliyun/alink/linksdk/alcs/coap/AlcsCoAPConstant$Code;", "")]
			public static unsafe global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.AlcsCoAPConstant.Code ValueOf (int value)
			{
				const string __id = "valueOf.(I)Lcom/aliyun/alink/linksdk/alcs/coap/AlcsCoAPConstant$Code;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.AlcsCoAPConstant.Code> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.coap']/class[@name='AlcsCoAPConstant.Code']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("valueOf", "(Ljava/lang/String;)Lcom/aliyun/alink/linksdk/alcs/coap/AlcsCoAPConstant$Code;", "")]
			public static unsafe global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.AlcsCoAPConstant.Code ValueOf (string name)
			{
				const string __id = "valueOf.(Ljava/lang/String;)Lcom/aliyun/alink/linksdk/alcs/coap/AlcsCoAPConstant$Code;";
				IntPtr native_name = JNIEnv.NewString (name);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_name);
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.AlcsCoAPConstant.Code> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					JNIEnv.DeleteLocalRef (native_name);
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.coap']/class[@name='AlcsCoAPConstant.Code']/method[@name='values' and count(parameter)=0]"
			[Register ("values", "()[Lcom/aliyun/alink/linksdk/alcs/coap/AlcsCoAPConstant$Code;", "")]
			public static unsafe global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.AlcsCoAPConstant.Code[] Values ()
			{
				const string __id = "values.()[Lcom/aliyun/alink/linksdk/alcs/coap/AlcsCoAPConstant$Code;";
				try {
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
					return (global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.AlcsCoAPConstant.Code[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.AlcsCoAPConstant.Code));
				} finally {
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.coap']/class[@name='AlcsCoAPConstant.CodeClass']"
		[global::Android.Runtime.Register ("com/aliyun/alink/linksdk/alcs/coap/AlcsCoAPConstant$CodeClass", DoNotGenerateAcw=true)]
		public sealed partial class CodeClass : global::Java.Lang.Enum {



			// Metadata.xml XPath field reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.coap']/class[@name='AlcsCoAPConstant.CodeClass']/field[@name='ERROR_RESPONSE']"
			[Register ("ERROR_RESPONSE")]
			public static global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.AlcsCoAPConstant.CodeClass ErrorResponse {
				get {
					const string __id = "ERROR_RESPONSE.Lcom/aliyun/alink/linksdk/alcs/coap/AlcsCoAPConstant$CodeClass;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.AlcsCoAPConstant.CodeClass> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.coap']/class[@name='AlcsCoAPConstant.CodeClass']/field[@name='REQUEST']"
			[Register ("REQUEST")]
			public static global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.AlcsCoAPConstant.CodeClass Request {
				get {
					const string __id = "REQUEST.Lcom/aliyun/alink/linksdk/alcs/coap/AlcsCoAPConstant$CodeClass;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.AlcsCoAPConstant.CodeClass> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.coap']/class[@name='AlcsCoAPConstant.CodeClass']/field[@name='SERVER_ERROR_RESPONSE']"
			[Register ("SERVER_ERROR_RESPONSE")]
			public static global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.AlcsCoAPConstant.CodeClass ServerErrorResponse {
				get {
					const string __id = "SERVER_ERROR_RESPONSE.Lcom/aliyun/alink/linksdk/alcs/coap/AlcsCoAPConstant$CodeClass;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.AlcsCoAPConstant.CodeClass> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.coap']/class[@name='AlcsCoAPConstant.CodeClass']/field[@name='SIGNAL']"
			[Register ("SIGNAL")]
			public static global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.AlcsCoAPConstant.CodeClass Signal {
				get {
					const string __id = "SIGNAL.Lcom/aliyun/alink/linksdk/alcs/coap/AlcsCoAPConstant$CodeClass;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.AlcsCoAPConstant.CodeClass> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.coap']/class[@name='AlcsCoAPConstant.CodeClass']/field[@name='SUCCESS_RESPONSE']"
			[Register ("SUCCESS_RESPONSE")]
			public static global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.AlcsCoAPConstant.CodeClass SuccessResponse {
				get {
					const string __id = "SUCCESS_RESPONSE.Lcom/aliyun/alink/linksdk/alcs/coap/AlcsCoAPConstant$CodeClass;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.AlcsCoAPConstant.CodeClass> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.coap']/class[@name='AlcsCoAPConstant.CodeClass']/field[@name='value']"
			[Register ("value")]
			public int Value {
				get {
					const string __id = "value.I";

					var __v = _members.InstanceFields.GetInt32Value (__id, this);
					return __v;
				}
				set {
					const string __id = "value.I";

					try {
						_members.InstanceFields.SetValue (__id, this, value);
					} finally {
					}
				}
			}
			static readonly JniPeerMembers _members = new XAPeerMembers ("com/aliyun/alink/linksdk/alcs/coap/AlcsCoAPConstant$CodeClass", typeof (CodeClass));
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

			internal CodeClass (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.coap']/class[@name='AlcsCoAPConstant.CodeClass']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("valueOf", "(I)Lcom/aliyun/alink/linksdk/alcs/coap/AlcsCoAPConstant$CodeClass;", "")]
			public static unsafe global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.AlcsCoAPConstant.CodeClass ValueOf (int value)
			{
				const string __id = "valueOf.(I)Lcom/aliyun/alink/linksdk/alcs/coap/AlcsCoAPConstant$CodeClass;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.AlcsCoAPConstant.CodeClass> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.coap']/class[@name='AlcsCoAPConstant.CodeClass']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("valueOf", "(Ljava/lang/String;)Lcom/aliyun/alink/linksdk/alcs/coap/AlcsCoAPConstant$CodeClass;", "")]
			public static unsafe global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.AlcsCoAPConstant.CodeClass ValueOf (string name)
			{
				const string __id = "valueOf.(Ljava/lang/String;)Lcom/aliyun/alink/linksdk/alcs/coap/AlcsCoAPConstant$CodeClass;";
				IntPtr native_name = JNIEnv.NewString (name);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_name);
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.AlcsCoAPConstant.CodeClass> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					JNIEnv.DeleteLocalRef (native_name);
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.coap']/class[@name='AlcsCoAPConstant.CodeClass']/method[@name='values' and count(parameter)=0]"
			[Register ("values", "()[Lcom/aliyun/alink/linksdk/alcs/coap/AlcsCoAPConstant$CodeClass;", "")]
			public static unsafe global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.AlcsCoAPConstant.CodeClass[] Values ()
			{
				const string __id = "values.()[Lcom/aliyun/alink/linksdk/alcs/coap/AlcsCoAPConstant$CodeClass;";
				try {
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
					return (global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.AlcsCoAPConstant.CodeClass[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.AlcsCoAPConstant.CodeClass));
				} finally {
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.coap']/class[@name='AlcsCoAPConstant.MessageFormat']"
		[global::Android.Runtime.Register ("com/aliyun/alink/linksdk/alcs/coap/AlcsCoAPConstant$MessageFormat", DoNotGenerateAcw=true)]
		public sealed partial class MessageFormat : global::Java.Lang.Object {


			// Metadata.xml XPath field reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.coap']/class[@name='AlcsCoAPConstant.MessageFormat']/field[@name='CODE_BITS']"
			[Register ("CODE_BITS")]
			public const int CodeBits = (int) 8;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.coap']/class[@name='AlcsCoAPConstant.MessageFormat']/field[@name='EMPTY_CODE']"
			[Register ("EMPTY_CODE")]
			public const int EmptyCode = (int) 0;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.coap']/class[@name='AlcsCoAPConstant.MessageFormat']/field[@name='LENGTH_NIBBLE_BITS']"
			[Register ("LENGTH_NIBBLE_BITS")]
			public const int LengthNibbleBits = (int) 4;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.coap']/class[@name='AlcsCoAPConstant.MessageFormat']/field[@name='MESSAGE_ID_BITS']"
			[Register ("MESSAGE_ID_BITS")]
			public const int MessageIdBits = (int) 16;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.coap']/class[@name='AlcsCoAPConstant.MessageFormat']/field[@name='OPTION_DELTA_BITS']"
			[Register ("OPTION_DELTA_BITS")]
			public const int OptionDeltaBits = (int) 4;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.coap']/class[@name='AlcsCoAPConstant.MessageFormat']/field[@name='OPTION_LENGTH_BITS']"
			[Register ("OPTION_LENGTH_BITS")]
			public const int OptionLengthBits = (int) 4;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.coap']/class[@name='AlcsCoAPConstant.MessageFormat']/field[@name='PAYLOAD_MARKER']"
			[Register ("PAYLOAD_MARKER")]
			public const sbyte PayloadMarker = (sbyte) -1;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.coap']/class[@name='AlcsCoAPConstant.MessageFormat']/field[@name='REQUEST_CODE_LOWER_BOUND']"
			[Register ("REQUEST_CODE_LOWER_BOUND")]
			public const int RequestCodeLowerBound = (int) 1;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.coap']/class[@name='AlcsCoAPConstant.MessageFormat']/field[@name='REQUEST_CODE_UPPER_BOUND']"
			[Register ("REQUEST_CODE_UPPER_BOUND")]
			public const int RequestCodeUpperBound = (int) 31;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.coap']/class[@name='AlcsCoAPConstant.MessageFormat']/field[@name='RESPONSE_CODE_LOWER_BOUND']"
			[Register ("RESPONSE_CODE_LOWER_BOUND")]
			public const int ResponseCodeLowerBound = (int) 64;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.coap']/class[@name='AlcsCoAPConstant.MessageFormat']/field[@name='RESPONSE_CODE_UPPER_BOUND']"
			[Register ("RESPONSE_CODE_UPPER_BOUND")]
			public const int ResponseCodeUpperBound = (int) 191;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.coap']/class[@name='AlcsCoAPConstant.MessageFormat']/field[@name='TOKEN_LENGTH_BITS']"
			[Register ("TOKEN_LENGTH_BITS")]
			public const int TokenLengthBits = (int) 4;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.coap']/class[@name='AlcsCoAPConstant.MessageFormat']/field[@name='TYPE_BITS']"
			[Register ("TYPE_BITS")]
			public const int TypeBits = (int) 2;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.coap']/class[@name='AlcsCoAPConstant.MessageFormat']/field[@name='VERSION']"
			[Register ("VERSION")]
			public const int Version = (int) 1;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.coap']/class[@name='AlcsCoAPConstant.MessageFormat']/field[@name='VERSION_BITS']"
			[Register ("VERSION_BITS")]
			public const int VersionBits = (int) 2;
			static readonly JniPeerMembers _members = new XAPeerMembers ("com/aliyun/alink/linksdk/alcs/coap/AlcsCoAPConstant$MessageFormat", typeof (MessageFormat));
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

			internal MessageFormat (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.coap']/class[@name='AlcsCoAPConstant.ResponseCode']"
		[global::Android.Runtime.Register ("com/aliyun/alink/linksdk/alcs/coap/AlcsCoAPConstant$ResponseCode", DoNotGenerateAcw=true)]
		public sealed partial class ResponseCode : global::Java.Lang.Enum {



			// Metadata.xml XPath field reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.coap']/class[@name='AlcsCoAPConstant.ResponseCode']/field[@name='BAD_GATEWAY']"
			[Register ("BAD_GATEWAY")]
			public static global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.AlcsCoAPConstant.ResponseCode BadGateway {
				get {
					const string __id = "BAD_GATEWAY.Lcom/aliyun/alink/linksdk/alcs/coap/AlcsCoAPConstant$ResponseCode;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.AlcsCoAPConstant.ResponseCode> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.coap']/class[@name='AlcsCoAPConstant.ResponseCode']/field[@name='BAD_OPTION']"
			[Register ("BAD_OPTION")]
			public static global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.AlcsCoAPConstant.ResponseCode BadOption {
				get {
					const string __id = "BAD_OPTION.Lcom/aliyun/alink/linksdk/alcs/coap/AlcsCoAPConstant$ResponseCode;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.AlcsCoAPConstant.ResponseCode> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.coap']/class[@name='AlcsCoAPConstant.ResponseCode']/field[@name='BAD_REQUEST']"
			[Register ("BAD_REQUEST")]
			public static global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.AlcsCoAPConstant.ResponseCode BadRequest {
				get {
					const string __id = "BAD_REQUEST.Lcom/aliyun/alink/linksdk/alcs/coap/AlcsCoAPConstant$ResponseCode;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.AlcsCoAPConstant.ResponseCode> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.coap']/class[@name='AlcsCoAPConstant.ResponseCode']/field[@name='CHANGED']"
			[Register ("CHANGED")]
			public static global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.AlcsCoAPConstant.ResponseCode Changed {
				get {
					const string __id = "CHANGED.Lcom/aliyun/alink/linksdk/alcs/coap/AlcsCoAPConstant$ResponseCode;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.AlcsCoAPConstant.ResponseCode> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.coap']/class[@name='AlcsCoAPConstant.ResponseCode']/field[@name='CONTENT']"
			[Register ("CONTENT")]
			public static global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.AlcsCoAPConstant.ResponseCode Content {
				get {
					const string __id = "CONTENT.Lcom/aliyun/alink/linksdk/alcs/coap/AlcsCoAPConstant$ResponseCode;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.AlcsCoAPConstant.ResponseCode> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.coap']/class[@name='AlcsCoAPConstant.ResponseCode']/field[@name='CONTINUE']"
			[Register ("CONTINUE")]
			public static global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.AlcsCoAPConstant.ResponseCode Continue {
				get {
					const string __id = "CONTINUE.Lcom/aliyun/alink/linksdk/alcs/coap/AlcsCoAPConstant$ResponseCode;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.AlcsCoAPConstant.ResponseCode> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.coap']/class[@name='AlcsCoAPConstant.ResponseCode']/field[@name='CREATED']"
			[Register ("CREATED")]
			public static global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.AlcsCoAPConstant.ResponseCode Created {
				get {
					const string __id = "CREATED.Lcom/aliyun/alink/linksdk/alcs/coap/AlcsCoAPConstant$ResponseCode;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.AlcsCoAPConstant.ResponseCode> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.coap']/class[@name='AlcsCoAPConstant.ResponseCode']/field[@name='DELETED']"
			[Register ("DELETED")]
			public static global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.AlcsCoAPConstant.ResponseCode Deleted {
				get {
					const string __id = "DELETED.Lcom/aliyun/alink/linksdk/alcs/coap/AlcsCoAPConstant$ResponseCode;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.AlcsCoAPConstant.ResponseCode> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.coap']/class[@name='AlcsCoAPConstant.ResponseCode']/field[@name='FORBIDDEN']"
			[Register ("FORBIDDEN")]
			public static global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.AlcsCoAPConstant.ResponseCode Forbidden {
				get {
					const string __id = "FORBIDDEN.Lcom/aliyun/alink/linksdk/alcs/coap/AlcsCoAPConstant$ResponseCode;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.AlcsCoAPConstant.ResponseCode> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.coap']/class[@name='AlcsCoAPConstant.ResponseCode']/field[@name='GATEWAY_TIMEOUT']"
			[Register ("GATEWAY_TIMEOUT")]
			public static global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.AlcsCoAPConstant.ResponseCode GatewayTimeout {
				get {
					const string __id = "GATEWAY_TIMEOUT.Lcom/aliyun/alink/linksdk/alcs/coap/AlcsCoAPConstant$ResponseCode;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.AlcsCoAPConstant.ResponseCode> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.coap']/class[@name='AlcsCoAPConstant.ResponseCode']/field[@name='INTERNAL_SERVER_ERROR']"
			[Register ("INTERNAL_SERVER_ERROR")]
			public static global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.AlcsCoAPConstant.ResponseCode InternalServerError {
				get {
					const string __id = "INTERNAL_SERVER_ERROR.Lcom/aliyun/alink/linksdk/alcs/coap/AlcsCoAPConstant$ResponseCode;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.AlcsCoAPConstant.ResponseCode> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.coap']/class[@name='AlcsCoAPConstant.ResponseCode']/field[@name='METHOD_NOT_ALLOWED']"
			[Register ("METHOD_NOT_ALLOWED")]
			public static global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.AlcsCoAPConstant.ResponseCode MethodNotAllowed {
				get {
					const string __id = "METHOD_NOT_ALLOWED.Lcom/aliyun/alink/linksdk/alcs/coap/AlcsCoAPConstant$ResponseCode;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.AlcsCoAPConstant.ResponseCode> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.coap']/class[@name='AlcsCoAPConstant.ResponseCode']/field[@name='NOT_ACCEPTABLE']"
			[Register ("NOT_ACCEPTABLE")]
			public static global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.AlcsCoAPConstant.ResponseCode NotAcceptable {
				get {
					const string __id = "NOT_ACCEPTABLE.Lcom/aliyun/alink/linksdk/alcs/coap/AlcsCoAPConstant$ResponseCode;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.AlcsCoAPConstant.ResponseCode> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.coap']/class[@name='AlcsCoAPConstant.ResponseCode']/field[@name='NOT_FOUND']"
			[Register ("NOT_FOUND")]
			public static global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.AlcsCoAPConstant.ResponseCode NotFound {
				get {
					const string __id = "NOT_FOUND.Lcom/aliyun/alink/linksdk/alcs/coap/AlcsCoAPConstant$ResponseCode;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.AlcsCoAPConstant.ResponseCode> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.coap']/class[@name='AlcsCoAPConstant.ResponseCode']/field[@name='NOT_IMPLEMENTED']"
			[Register ("NOT_IMPLEMENTED")]
			public static global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.AlcsCoAPConstant.ResponseCode NotImplemented {
				get {
					const string __id = "NOT_IMPLEMENTED.Lcom/aliyun/alink/linksdk/alcs/coap/AlcsCoAPConstant$ResponseCode;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.AlcsCoAPConstant.ResponseCode> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.coap']/class[@name='AlcsCoAPConstant.ResponseCode']/field[@name='PRECONDITION_FAILED']"
			[Register ("PRECONDITION_FAILED")]
			public static global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.AlcsCoAPConstant.ResponseCode PreconditionFailed {
				get {
					const string __id = "PRECONDITION_FAILED.Lcom/aliyun/alink/linksdk/alcs/coap/AlcsCoAPConstant$ResponseCode;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.AlcsCoAPConstant.ResponseCode> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.coap']/class[@name='AlcsCoAPConstant.ResponseCode']/field[@name='PROXY_NOT_SUPPORTED']"
			[Register ("PROXY_NOT_SUPPORTED")]
			public static global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.AlcsCoAPConstant.ResponseCode ProxyNotSupported {
				get {
					const string __id = "PROXY_NOT_SUPPORTED.Lcom/aliyun/alink/linksdk/alcs/coap/AlcsCoAPConstant$ResponseCode;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.AlcsCoAPConstant.ResponseCode> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.coap']/class[@name='AlcsCoAPConstant.ResponseCode']/field[@name='REQUEST_ENTITY_INCOMPLETE']"
			[Register ("REQUEST_ENTITY_INCOMPLETE")]
			public static global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.AlcsCoAPConstant.ResponseCode RequestEntityIncomplete {
				get {
					const string __id = "REQUEST_ENTITY_INCOMPLETE.Lcom/aliyun/alink/linksdk/alcs/coap/AlcsCoAPConstant$ResponseCode;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.AlcsCoAPConstant.ResponseCode> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.coap']/class[@name='AlcsCoAPConstant.ResponseCode']/field[@name='REQUEST_ENTITY_TOO_LARGE']"
			[Register ("REQUEST_ENTITY_TOO_LARGE")]
			public static global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.AlcsCoAPConstant.ResponseCode RequestEntityTooLarge {
				get {
					const string __id = "REQUEST_ENTITY_TOO_LARGE.Lcom/aliyun/alink/linksdk/alcs/coap/AlcsCoAPConstant$ResponseCode;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.AlcsCoAPConstant.ResponseCode> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.coap']/class[@name='AlcsCoAPConstant.ResponseCode']/field[@name='SERVICE_UNAVAILABLE']"
			[Register ("SERVICE_UNAVAILABLE")]
			public static global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.AlcsCoAPConstant.ResponseCode ServiceUnavailable {
				get {
					const string __id = "SERVICE_UNAVAILABLE.Lcom/aliyun/alink/linksdk/alcs/coap/AlcsCoAPConstant$ResponseCode;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.AlcsCoAPConstant.ResponseCode> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.coap']/class[@name='AlcsCoAPConstant.ResponseCode']/field[@name='UNAUTHORIZED']"
			[Register ("UNAUTHORIZED")]
			public static global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.AlcsCoAPConstant.ResponseCode Unauthorized {
				get {
					const string __id = "UNAUTHORIZED.Lcom/aliyun/alink/linksdk/alcs/coap/AlcsCoAPConstant$ResponseCode;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.AlcsCoAPConstant.ResponseCode> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.coap']/class[@name='AlcsCoAPConstant.ResponseCode']/field[@name='UNSUPPORTED_CONTENT_FORMAT']"
			[Register ("UNSUPPORTED_CONTENT_FORMAT")]
			public static global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.AlcsCoAPConstant.ResponseCode UnsupportedContentFormat {
				get {
					const string __id = "UNSUPPORTED_CONTENT_FORMAT.Lcom/aliyun/alink/linksdk/alcs/coap/AlcsCoAPConstant$ResponseCode;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.AlcsCoAPConstant.ResponseCode> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.coap']/class[@name='AlcsCoAPConstant.ResponseCode']/field[@name='VALID']"
			[Register ("VALID")]
			public static global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.AlcsCoAPConstant.ResponseCode Valid {
				get {
					const string __id = "VALID.Lcom/aliyun/alink/linksdk/alcs/coap/AlcsCoAPConstant$ResponseCode;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.AlcsCoAPConstant.ResponseCode> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.coap']/class[@name='AlcsCoAPConstant.ResponseCode']/field[@name='_UNKNOWN_SUCCESS_CODE']"
			[Register ("_UNKNOWN_SUCCESS_CODE")]
			public static global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.AlcsCoAPConstant.ResponseCode UnknownSuccessCode {
				get {
					const string __id = "_UNKNOWN_SUCCESS_CODE.Lcom/aliyun/alink/linksdk/alcs/coap/AlcsCoAPConstant$ResponseCode;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.AlcsCoAPConstant.ResponseCode> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.coap']/class[@name='AlcsCoAPConstant.ResponseCode']/field[@name='codeClass']"
			[Register ("codeClass")]
			public int CodeClass {
				get {
					const string __id = "codeClass.I";

					var __v = _members.InstanceFields.GetInt32Value (__id, this);
					return __v;
				}
				set {
					const string __id = "codeClass.I";

					try {
						_members.InstanceFields.SetValue (__id, this, value);
					} finally {
					}
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.coap']/class[@name='AlcsCoAPConstant.ResponseCode']/field[@name='codeDetail']"
			[Register ("codeDetail")]
			public int CodeDetail {
				get {
					const string __id = "codeDetail.I";

					var __v = _members.InstanceFields.GetInt32Value (__id, this);
					return __v;
				}
				set {
					const string __id = "codeDetail.I";

					try {
						_members.InstanceFields.SetValue (__id, this, value);
					} finally {
					}
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.coap']/class[@name='AlcsCoAPConstant.ResponseCode']/field[@name='value']"
			[Register ("value")]
			public int Value {
				get {
					const string __id = "value.I";

					var __v = _members.InstanceFields.GetInt32Value (__id, this);
					return __v;
				}
				set {
					const string __id = "value.I";

					try {
						_members.InstanceFields.SetValue (__id, this, value);
					} finally {
					}
				}
			}
			static readonly JniPeerMembers _members = new XAPeerMembers ("com/aliyun/alink/linksdk/alcs/coap/AlcsCoAPConstant$ResponseCode", typeof (ResponseCode));
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

			internal ResponseCode (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.coap']/class[@name='AlcsCoAPConstant.ResponseCode']/method[@name='isClientError' and count(parameter)=1 and parameter[1][@type='com.aliyun.alink.linksdk.alcs.coap.AlcsCoAPConstant.ResponseCode']]"
			[Register ("isClientError", "(Lcom/aliyun/alink/linksdk/alcs/coap/AlcsCoAPConstant$ResponseCode;)Z", "")]
			public static unsafe bool IsClientError (global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.AlcsCoAPConstant.ResponseCode code)
			{
				const string __id = "isClientError.(Lcom/aliyun/alink/linksdk/alcs/coap/AlcsCoAPConstant$ResponseCode;)Z";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((code == null) ? IntPtr.Zero : ((global::Java.Lang.Object) code).Handle);
					var __rm = _members.StaticMethods.InvokeBooleanMethod (__id, __args);
					return __rm;
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.coap']/class[@name='AlcsCoAPConstant.ResponseCode']/method[@name='isServerError' and count(parameter)=1 and parameter[1][@type='com.aliyun.alink.linksdk.alcs.coap.AlcsCoAPConstant.ResponseCode']]"
			[Register ("isServerError", "(Lcom/aliyun/alink/linksdk/alcs/coap/AlcsCoAPConstant$ResponseCode;)Z", "")]
			public static unsafe bool IsServerError (global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.AlcsCoAPConstant.ResponseCode code)
			{
				const string __id = "isServerError.(Lcom/aliyun/alink/linksdk/alcs/coap/AlcsCoAPConstant$ResponseCode;)Z";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((code == null) ? IntPtr.Zero : ((global::Java.Lang.Object) code).Handle);
					var __rm = _members.StaticMethods.InvokeBooleanMethod (__id, __args);
					return __rm;
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.coap']/class[@name='AlcsCoAPConstant.ResponseCode']/method[@name='isSuccess' and count(parameter)=1 and parameter[1][@type='com.aliyun.alink.linksdk.alcs.coap.AlcsCoAPConstant.ResponseCode']]"
			[Register ("isSuccess", "(Lcom/aliyun/alink/linksdk/alcs/coap/AlcsCoAPConstant$ResponseCode;)Z", "")]
			public static unsafe bool IsSuccess (global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.AlcsCoAPConstant.ResponseCode code)
			{
				const string __id = "isSuccess.(Lcom/aliyun/alink/linksdk/alcs/coap/AlcsCoAPConstant$ResponseCode;)Z";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((code == null) ? IntPtr.Zero : ((global::Java.Lang.Object) code).Handle);
					var __rm = _members.StaticMethods.InvokeBooleanMethod (__id, __args);
					return __rm;
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.coap']/class[@name='AlcsCoAPConstant.ResponseCode']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("valueOf", "(I)Lcom/aliyun/alink/linksdk/alcs/coap/AlcsCoAPConstant$ResponseCode;", "")]
			public static unsafe global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.AlcsCoAPConstant.ResponseCode ValueOf (int value)
			{
				const string __id = "valueOf.(I)Lcom/aliyun/alink/linksdk/alcs/coap/AlcsCoAPConstant$ResponseCode;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.AlcsCoAPConstant.ResponseCode> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.coap']/class[@name='AlcsCoAPConstant.ResponseCode']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("valueOf", "(Ljava/lang/String;)Lcom/aliyun/alink/linksdk/alcs/coap/AlcsCoAPConstant$ResponseCode;", "")]
			public static unsafe global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.AlcsCoAPConstant.ResponseCode ValueOf (string name)
			{
				const string __id = "valueOf.(Ljava/lang/String;)Lcom/aliyun/alink/linksdk/alcs/coap/AlcsCoAPConstant$ResponseCode;";
				IntPtr native_name = JNIEnv.NewString (name);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_name);
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.AlcsCoAPConstant.ResponseCode> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					JNIEnv.DeleteLocalRef (native_name);
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.coap']/class[@name='AlcsCoAPConstant.ResponseCode']/method[@name='values' and count(parameter)=0]"
			[Register ("values", "()[Lcom/aliyun/alink/linksdk/alcs/coap/AlcsCoAPConstant$ResponseCode;", "")]
			public static unsafe global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.AlcsCoAPConstant.ResponseCode[] Values ()
			{
				const string __id = "values.()[Lcom/aliyun/alink/linksdk/alcs/coap/AlcsCoAPConstant$ResponseCode;";
				try {
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
					return (global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.AlcsCoAPConstant.ResponseCode[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.AlcsCoAPConstant.ResponseCode));
				} finally {
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.coap']/class[@name='AlcsCoAPConstant.Type']"
		[global::Android.Runtime.Register ("com/aliyun/alink/linksdk/alcs/coap/AlcsCoAPConstant$Type", DoNotGenerateAcw=true)]
		public sealed partial class Type : global::Java.Lang.Enum {



			// Metadata.xml XPath field reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.coap']/class[@name='AlcsCoAPConstant.Type']/field[@name='ACK']"
			[Register ("ACK")]
			public static global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.AlcsCoAPConstant.Type Ack {
				get {
					const string __id = "ACK.Lcom/aliyun/alink/linksdk/alcs/coap/AlcsCoAPConstant$Type;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.AlcsCoAPConstant.Type> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.coap']/class[@name='AlcsCoAPConstant.Type']/field[@name='CON']"
			[Register ("CON")]
			public static global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.AlcsCoAPConstant.Type Con {
				get {
					const string __id = "CON.Lcom/aliyun/alink/linksdk/alcs/coap/AlcsCoAPConstant$Type;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.AlcsCoAPConstant.Type> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.coap']/class[@name='AlcsCoAPConstant.Type']/field[@name='NON']"
			[Register ("NON")]
			public static global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.AlcsCoAPConstant.Type Non {
				get {
					const string __id = "NON.Lcom/aliyun/alink/linksdk/alcs/coap/AlcsCoAPConstant$Type;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.AlcsCoAPConstant.Type> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.coap']/class[@name='AlcsCoAPConstant.Type']/field[@name='RST']"
			[Register ("RST")]
			public static global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.AlcsCoAPConstant.Type Rst {
				get {
					const string __id = "RST.Lcom/aliyun/alink/linksdk/alcs/coap/AlcsCoAPConstant$Type;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.AlcsCoAPConstant.Type> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.coap']/class[@name='AlcsCoAPConstant.Type']/field[@name='value']"
			[Register ("value")]
			public int Value {
				get {
					const string __id = "value.I";

					var __v = _members.InstanceFields.GetInt32Value (__id, this);
					return __v;
				}
				set {
					const string __id = "value.I";

					try {
						_members.InstanceFields.SetValue (__id, this, value);
					} finally {
					}
				}
			}
			static readonly JniPeerMembers _members = new XAPeerMembers ("com/aliyun/alink/linksdk/alcs/coap/AlcsCoAPConstant$Type", typeof (Type));
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

			internal Type (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.coap']/class[@name='AlcsCoAPConstant.Type']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("valueOf", "(I)Lcom/aliyun/alink/linksdk/alcs/coap/AlcsCoAPConstant$Type;", "")]
			public static unsafe global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.AlcsCoAPConstant.Type ValueOf (int value)
			{
				const string __id = "valueOf.(I)Lcom/aliyun/alink/linksdk/alcs/coap/AlcsCoAPConstant$Type;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.AlcsCoAPConstant.Type> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.coap']/class[@name='AlcsCoAPConstant.Type']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("valueOf", "(Ljava/lang/String;)Lcom/aliyun/alink/linksdk/alcs/coap/AlcsCoAPConstant$Type;", "")]
			public static unsafe global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.AlcsCoAPConstant.Type ValueOf (string name)
			{
				const string __id = "valueOf.(Ljava/lang/String;)Lcom/aliyun/alink/linksdk/alcs/coap/AlcsCoAPConstant$Type;";
				IntPtr native_name = JNIEnv.NewString (name);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_name);
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.AlcsCoAPConstant.Type> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					JNIEnv.DeleteLocalRef (native_name);
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.coap']/class[@name='AlcsCoAPConstant.Type']/method[@name='values' and count(parameter)=0]"
			[Register ("values", "()[Lcom/aliyun/alink/linksdk/alcs/coap/AlcsCoAPConstant$Type;", "")]
			public static unsafe global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.AlcsCoAPConstant.Type[] Values ()
			{
				const string __id = "values.()[Lcom/aliyun/alink/linksdk/alcs/coap/AlcsCoAPConstant$Type;";
				try {
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
					return (global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.AlcsCoAPConstant.Type[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (global::Com.Aliyun.Alink.Linksdk.Alcs.Coap.AlcsCoAPConstant.Type));
				} finally {
				}
			}

		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/aliyun/alink/linksdk/alcs/coap/AlcsCoAPConstant", typeof (AlcsCoAPConstant));
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

		internal AlcsCoAPConstant (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.coap']/class[@name='AlcsCoAPConstant']/method[@name='formatCode' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("formatCode", "(I)Ljava/lang/String;", "")]
		public static unsafe string FormatCode (int code)
		{
			const string __id = "formatCode.(I)Ljava/lang/String;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (code);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.coap']/class[@name='AlcsCoAPConstant']/method[@name='getCodeClass' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("getCodeClass", "(I)I", "")]
		public static unsafe int GetCodeClass (int code)
		{
			const string __id = "getCodeClass.(I)I";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (code);
				var __rm = _members.StaticMethods.InvokeInt32Method (__id, __args);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.coap']/class[@name='AlcsCoAPConstant']/method[@name='getCodeDetail' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("getCodeDetail", "(I)I", "")]
		public static unsafe int GetCodeDetail (int code)
		{
			const string __id = "getCodeDetail.(I)I";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (code);
				var __rm = _members.StaticMethods.InvokeInt32Method (__id, __args);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.coap']/class[@name='AlcsCoAPConstant']/method[@name='getDefaultPort' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("getDefaultPort", "(Ljava/lang/String;)I", "")]
		public static unsafe int GetDefaultPort (string uriScheme)
		{
			const string __id = "getDefaultPort.(Ljava/lang/String;)I";
			IntPtr native_uriScheme = JNIEnv.NewString (uriScheme);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_uriScheme);
				var __rm = _members.StaticMethods.InvokeInt32Method (__id, __args);
				return __rm;
			} finally {
				JNIEnv.DeleteLocalRef (native_uriScheme);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.coap']/class[@name='AlcsCoAPConstant']/method[@name='isEmptyMessage' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("isEmptyMessage", "(I)Z", "")]
		public static unsafe bool IsEmptyMessage (int code)
		{
			const string __id = "isEmptyMessage.(I)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (code);
				var __rm = _members.StaticMethods.InvokeBooleanMethod (__id, __args);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.coap']/class[@name='AlcsCoAPConstant']/method[@name='isRequest' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("isRequest", "(I)Z", "")]
		public static unsafe bool IsRequest (int code)
		{
			const string __id = "isRequest.(I)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (code);
				var __rm = _members.StaticMethods.InvokeBooleanMethod (__id, __args);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.coap']/class[@name='AlcsCoAPConstant']/method[@name='isResponse' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("isResponse", "(I)Z", "")]
		public static unsafe bool IsResponse (int code)
		{
			const string __id = "isResponse.(I)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (code);
				var __rm = _members.StaticMethods.InvokeBooleanMethod (__id, __args);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.coap']/class[@name='AlcsCoAPConstant']/method[@name='isSecureScheme' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("isSecureScheme", "(Ljava/lang/String;)Z", "")]
		public static unsafe bool IsSecureScheme (string uriScheme)
		{
			const string __id = "isSecureScheme.(Ljava/lang/String;)Z";
			IntPtr native_uriScheme = JNIEnv.NewString (uriScheme);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_uriScheme);
				var __rm = _members.StaticMethods.InvokeBooleanMethod (__id, __args);
				return __rm;
			} finally {
				JNIEnv.DeleteLocalRef (native_uriScheme);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.coap']/class[@name='AlcsCoAPConstant']/method[@name='isSupportedScheme' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("isSupportedScheme", "(Ljava/lang/String;)Z", "")]
		public static unsafe bool IsSupportedScheme (string uriScheme)
		{
			const string __id = "isSupportedScheme.(Ljava/lang/String;)Z";
			IntPtr native_uriScheme = JNIEnv.NewString (uriScheme);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_uriScheme);
				var __rm = _members.StaticMethods.InvokeBooleanMethod (__id, __args);
				return __rm;
			} finally {
				JNIEnv.DeleteLocalRef (native_uriScheme);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.coap']/class[@name='AlcsCoAPConstant']/method[@name='isTcpScheme' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("isTcpScheme", "(Ljava/lang/String;)Z", "")]
		public static unsafe bool IsTcpScheme (string uriScheme)
		{
			const string __id = "isTcpScheme.(Ljava/lang/String;)Z";
			IntPtr native_uriScheme = JNIEnv.NewString (uriScheme);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_uriScheme);
				var __rm = _members.StaticMethods.InvokeBooleanMethod (__id, __args);
				return __rm;
			} finally {
				JNIEnv.DeleteLocalRef (native_uriScheme);
			}
		}

	}
}
