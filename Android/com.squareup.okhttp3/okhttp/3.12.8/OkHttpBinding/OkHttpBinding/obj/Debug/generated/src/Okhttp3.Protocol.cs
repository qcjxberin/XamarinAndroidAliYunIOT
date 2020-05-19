using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Okhttp3 {

	// Metadata.xml XPath class reference: path="/api/package[@name='okhttp3']/class[@name='Protocol']"
	[global::Android.Runtime.Register ("okhttp3/Protocol", DoNotGenerateAcw=true)]
	public sealed partial class Protocol : global::Java.Lang.Enum {



		// Metadata.xml XPath field reference: path="/api/package[@name='okhttp3']/class[@name='Protocol']/field[@name='H2_PRIOR_KNOWLEDGE']"
		[Register ("H2_PRIOR_KNOWLEDGE")]
		public static global::Okhttp3.Protocol H2PriorKnowledge {
			get {
				const string __id = "H2_PRIOR_KNOWLEDGE.Lokhttp3/Protocol;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Okhttp3.Protocol> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='okhttp3']/class[@name='Protocol']/field[@name='HTTP_1_0']"
		[Register ("HTTP_1_0")]
		public static global::Okhttp3.Protocol Http10 {
			get {
				const string __id = "HTTP_1_0.Lokhttp3/Protocol;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Okhttp3.Protocol> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='okhttp3']/class[@name='Protocol']/field[@name='HTTP_1_1']"
		[Register ("HTTP_1_1")]
		public static global::Okhttp3.Protocol Http11 {
			get {
				const string __id = "HTTP_1_1.Lokhttp3/Protocol;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Okhttp3.Protocol> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='okhttp3']/class[@name='Protocol']/field[@name='HTTP_2']"
		[Register ("HTTP_2")]
		public static global::Okhttp3.Protocol Http2 {
			get {
				const string __id = "HTTP_2.Lokhttp3/Protocol;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Okhttp3.Protocol> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='okhttp3']/class[@name='Protocol']/field[@name='QUIC']"
		[Register ("QUIC")]
		public static global::Okhttp3.Protocol Quic {
			get {
				const string __id = "QUIC.Lokhttp3/Protocol;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Okhttp3.Protocol> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='okhttp3']/class[@name='Protocol']/field[@name='SPDY_3']"
		[Register ("SPDY_3")]
		public static global::Okhttp3.Protocol Spdy3 {
			get {
				const string __id = "SPDY_3.Lokhttp3/Protocol;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Okhttp3.Protocol> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}
		static readonly JniPeerMembers _members = new XAPeerMembers ("okhttp3/Protocol", typeof (Protocol));
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

		internal Protocol (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3']/class[@name='Protocol']/method[@name='get' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("get", "(Ljava/lang/String;)Lokhttp3/Protocol;", "")]
		public static unsafe global::Okhttp3.Protocol Get (string protocol)
		{
			const string __id = "get.(Ljava/lang/String;)Lokhttp3/Protocol;";
			IntPtr native_protocol = JNIEnv.NewString (protocol);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_protocol);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Okhttp3.Protocol> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_protocol);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3']/class[@name='Protocol']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("valueOf", "(Ljava/lang/String;)Lokhttp3/Protocol;", "")]
		public static unsafe global::Okhttp3.Protocol ValueOf (string name)
		{
			const string __id = "valueOf.(Ljava/lang/String;)Lokhttp3/Protocol;";
			IntPtr native_name = JNIEnv.NewString (name);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_name);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Okhttp3.Protocol> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_name);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3']/class[@name='Protocol']/method[@name='values' and count(parameter)=0]"
		[Register ("values", "()[Lokhttp3/Protocol;", "")]
		public static unsafe global::Okhttp3.Protocol[] Values ()
		{
			const string __id = "values.()[Lokhttp3/Protocol;";
			try {
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
				return (global::Okhttp3.Protocol[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (global::Okhttp3.Protocol));
			} finally {
			}
		}

	}
}
