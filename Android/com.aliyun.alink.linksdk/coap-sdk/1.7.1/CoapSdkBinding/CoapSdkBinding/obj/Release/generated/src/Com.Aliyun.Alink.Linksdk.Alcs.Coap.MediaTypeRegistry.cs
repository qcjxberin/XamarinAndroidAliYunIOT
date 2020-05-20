using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Aliyun.Alink.Linksdk.Alcs.Coap {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.coap']/class[@name='MediaTypeRegistry']"
	[global::Android.Runtime.Register ("com/aliyun/alink/linksdk/alcs/coap/MediaTypeRegistry", DoNotGenerateAcw=true)]
	public partial class MediaTypeRegistry : global::Java.Lang.Object {


		// Metadata.xml XPath field reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.coap']/class[@name='MediaTypeRegistry']/field[@name='APPLICATION_ATOM_XML']"
		[Register ("APPLICATION_ATOM_XML")]
		public const int ApplicationAtomXml = (int) 45;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.coap']/class[@name='MediaTypeRegistry']/field[@name='APPLICATION_CBOR']"
		[Register ("APPLICATION_CBOR")]
		public const int ApplicationCbor = (int) 60;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.coap']/class[@name='MediaTypeRegistry']/field[@name='APPLICATION_EXI']"
		[Register ("APPLICATION_EXI")]
		public const int ApplicationExi = (int) 47;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.coap']/class[@name='MediaTypeRegistry']/field[@name='APPLICATION_FASTINFOSET']"
		[Register ("APPLICATION_FASTINFOSET")]
		public const int ApplicationFastinfoset = (int) 48;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.coap']/class[@name='MediaTypeRegistry']/field[@name='APPLICATION_JSON']"
		[Register ("APPLICATION_JSON")]
		public const int ApplicationJson = (int) 50;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.coap']/class[@name='MediaTypeRegistry']/field[@name='APPLICATION_LINK_FORMAT']"
		[Register ("APPLICATION_LINK_FORMAT")]
		public const int ApplicationLinkFormat = (int) 40;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.coap']/class[@name='MediaTypeRegistry']/field[@name='APPLICATION_OCTET_STREAM']"
		[Register ("APPLICATION_OCTET_STREAM")]
		public const int ApplicationOctetStream = (int) 42;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.coap']/class[@name='MediaTypeRegistry']/field[@name='APPLICATION_RDF_XML']"
		[Register ("APPLICATION_RDF_XML")]
		public const int ApplicationRdfXml = (int) 43;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.coap']/class[@name='MediaTypeRegistry']/field[@name='APPLICATION_SOAP_FASTINFOSET']"
		[Register ("APPLICATION_SOAP_FASTINFOSET")]
		public const int ApplicationSoapFastinfoset = (int) 49;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.coap']/class[@name='MediaTypeRegistry']/field[@name='APPLICATION_SOAP_XML']"
		[Register ("APPLICATION_SOAP_XML")]
		public const int ApplicationSoapXml = (int) 44;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.coap']/class[@name='MediaTypeRegistry']/field[@name='APPLICATION_VND_OMA_LWM2M_JSON']"
		[Register ("APPLICATION_VND_OMA_LWM2M_JSON")]
		public const int ApplicationVndOmaLwm2mJson = (int) 11543;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.coap']/class[@name='MediaTypeRegistry']/field[@name='APPLICATION_VND_OMA_LWM2M_TLV']"
		[Register ("APPLICATION_VND_OMA_LWM2M_TLV")]
		public const int ApplicationVndOmaLwm2mTlv = (int) 11542;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.coap']/class[@name='MediaTypeRegistry']/field[@name='APPLICATION_XML']"
		[Register ("APPLICATION_XML")]
		public const int ApplicationXml = (int) 41;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.coap']/class[@name='MediaTypeRegistry']/field[@name='APPLICATION_XMPP_XML']"
		[Register ("APPLICATION_XMPP_XML")]
		public const int ApplicationXmppXml = (int) 46;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.coap']/class[@name='MediaTypeRegistry']/field[@name='APPLICATION_X_OBIX_BINARY']"
		[Register ("APPLICATION_X_OBIX_BINARY")]
		public const int ApplicationXObixBinary = (int) 51;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.coap']/class[@name='MediaTypeRegistry']/field[@name='AUDIO_RAW']"
		[Register ("AUDIO_RAW")]
		public const int AudioRaw = (int) 25;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.coap']/class[@name='MediaTypeRegistry']/field[@name='IMAGE_GIF']"
		[Register ("IMAGE_GIF")]
		public const int ImageGif = (int) 21;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.coap']/class[@name='MediaTypeRegistry']/field[@name='IMAGE_JPEG']"
		[Register ("IMAGE_JPEG")]
		public const int ImageJpeg = (int) 22;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.coap']/class[@name='MediaTypeRegistry']/field[@name='IMAGE_PNG']"
		[Register ("IMAGE_PNG")]
		public const int ImagePng = (int) 23;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.coap']/class[@name='MediaTypeRegistry']/field[@name='IMAGE_TIFF']"
		[Register ("IMAGE_TIFF")]
		public const int ImageTiff = (int) 24;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.coap']/class[@name='MediaTypeRegistry']/field[@name='TEXT_CSV']"
		[Register ("TEXT_CSV")]
		public const int TextCsv = (int) 2;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.coap']/class[@name='MediaTypeRegistry']/field[@name='TEXT_HTML']"
		[Register ("TEXT_HTML")]
		public const int TextHtml = (int) 3;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.coap']/class[@name='MediaTypeRegistry']/field[@name='TEXT_PLAIN']"
		[Register ("TEXT_PLAIN")]
		public const int TextPlain = (int) 0;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.coap']/class[@name='MediaTypeRegistry']/field[@name='TEXT_XML']"
		[Register ("TEXT_XML")]
		public const int TextXml = (int) 1;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.coap']/class[@name='MediaTypeRegistry']/field[@name='UNDEFINED']"
		[Register ("UNDEFINED")]
		public const int Undefined = (int) -1;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.coap']/class[@name='MediaTypeRegistry']/field[@name='VIDEO_RAW']"
		[Register ("VIDEO_RAW")]
		public const int VideoRaw = (int) 26;
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/aliyun/alink/linksdk/alcs/coap/MediaTypeRegistry", typeof (MediaTypeRegistry));
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

		protected MediaTypeRegistry (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.coap']/class[@name='MediaTypeRegistry']/constructor[@name='MediaTypeRegistry' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe MediaTypeRegistry ()
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

		public static unsafe global::System.Collections.Generic.ICollection<global::Java.Lang.Integer> AllMediaTypes {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.coap']/class[@name='MediaTypeRegistry']/method[@name='getAllMediaTypes' and count(parameter)=0]"
			[Register ("getAllMediaTypes", "()Ljava/util/Set;", "")]
			get {
				const string __id = "getAllMediaTypes.()Ljava/util/Set;";
				try {
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
					return global::Android.Runtime.JavaSet<global::Java.Lang.Integer>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.coap']/class[@name='MediaTypeRegistry']/method[@name='isPrintable' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("isPrintable", "(I)Z", "")]
		public static unsafe bool IsPrintable (int mediaType)
		{
			const string __id = "isPrintable.(I)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (mediaType);
				var __rm = _members.StaticMethods.InvokeBooleanMethod (__id, __args);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.coap']/class[@name='MediaTypeRegistry']/method[@name='parse' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("parse", "(Ljava/lang/String;)I", "")]
		public static unsafe int Parse (string type)
		{
			const string __id = "parse.(Ljava/lang/String;)I";
			IntPtr native_type = JNIEnv.NewString (type);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_type);
				var __rm = _members.StaticMethods.InvokeInt32Method (__id, __args);
				return __rm;
			} finally {
				JNIEnv.DeleteLocalRef (native_type);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.coap']/class[@name='MediaTypeRegistry']/method[@name='parseWildcard' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("parseWildcard", "(Ljava/lang/String;)[Ljava/lang/Integer;", "")]
		public static unsafe global::Java.Lang.Integer[] ParseWildcard (string regex)
		{
			const string __id = "parseWildcard.(Ljava/lang/String;)[Ljava/lang/Integer;";
			IntPtr native_regex = JNIEnv.NewString (regex);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_regex);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return (global::Java.Lang.Integer[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (global::Java.Lang.Integer));
			} finally {
				JNIEnv.DeleteLocalRef (native_regex);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.coap']/class[@name='MediaTypeRegistry']/method[@name='toFileExtension' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("toFileExtension", "(I)Ljava/lang/String;", "")]
		public static unsafe string ToFileExtension (int mediaType)
		{
			const string __id = "toFileExtension.(I)Ljava/lang/String;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (mediaType);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.coap']/class[@name='MediaTypeRegistry']/method[@name='toString' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("toString", "(I)Ljava/lang/String;", "")]
		public static new unsafe string ToString (int mediaType)
		{
			const string __id = "toString.(I)Ljava/lang/String;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (mediaType);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}
}
