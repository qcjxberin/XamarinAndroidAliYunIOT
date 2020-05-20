using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Okhttp3.Internal.Http {

	// Metadata.xml XPath class reference: path="/api/package[@name='okhttp3.internal.http']/class[@name='StatusLine']"
	[global::Android.Runtime.Register ("okhttp3/internal/http/StatusLine", DoNotGenerateAcw=true)]
	public sealed partial class StatusLine : global::Java.Lang.Object {


		// Metadata.xml XPath field reference: path="/api/package[@name='okhttp3.internal.http']/class[@name='StatusLine']/field[@name='HTTP_CONTINUE']"
		[Register ("HTTP_CONTINUE")]
		public const int HttpContinue = (int) 100;

		// Metadata.xml XPath field reference: path="/api/package[@name='okhttp3.internal.http']/class[@name='StatusLine']/field[@name='HTTP_PERM_REDIRECT']"
		[Register ("HTTP_PERM_REDIRECT")]
		public const int HttpPermRedirect = (int) 308;

		// Metadata.xml XPath field reference: path="/api/package[@name='okhttp3.internal.http']/class[@name='StatusLine']/field[@name='HTTP_TEMP_REDIRECT']"
		[Register ("HTTP_TEMP_REDIRECT")]
		public const int HttpTempRedirect = (int) 307;


		// Metadata.xml XPath field reference: path="/api/package[@name='okhttp3.internal.http']/class[@name='StatusLine']/field[@name='code']"
		[Register ("code")]
		public int Code {
			get {
				const string __id = "code.I";

				var __v = _members.InstanceFields.GetInt32Value (__id, this);
				return __v;
			}
			set {
				const string __id = "code.I";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='okhttp3.internal.http']/class[@name='StatusLine']/field[@name='message']"
		[Register ("message")]
		public string Message {
			get {
				const string __id = "message.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "message.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='okhttp3.internal.http']/class[@name='StatusLine']/field[@name='protocol']"
		[Register ("protocol")]
		public global::Okhttp3.Protocol Protocol {
			get {
				const string __id = "protocol.Lokhttp3/Protocol;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return global::Java.Lang.Object.GetObject<global::Okhttp3.Protocol> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "protocol.Lokhttp3/Protocol;";

				IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}
		static readonly JniPeerMembers _members = new XAPeerMembers ("okhttp3/internal/http/StatusLine", typeof (StatusLine));
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

		internal StatusLine (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='okhttp3.internal.http']/class[@name='StatusLine']/constructor[@name='StatusLine' and count(parameter)=3 and parameter[1][@type='okhttp3.Protocol'] and parameter[2][@type='int'] and parameter[3][@type='java.lang.String']]"
		[Register (".ctor", "(Lokhttp3/Protocol;ILjava/lang/String;)V", "")]
		public unsafe StatusLine (global::Okhttp3.Protocol protocol, int code, string message)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Lokhttp3/Protocol;ILjava/lang/String;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_message = JNIEnv.NewString (message);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((protocol == null) ? IntPtr.Zero : ((global::Java.Lang.Object) protocol).Handle);
				__args [1] = new JniArgumentValue (code);
				__args [2] = new JniArgumentValue (native_message);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_message);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3.internal.http']/class[@name='StatusLine']/method[@name='get' and count(parameter)=1 and parameter[1][@type='okhttp3.Response']]"
		[Register ("get", "(Lokhttp3/Response;)Lokhttp3/internal/http/StatusLine;", "")]
		public static unsafe global::Okhttp3.Internal.Http.StatusLine Get (global::Okhttp3.Response response)
		{
			const string __id = "get.(Lokhttp3/Response;)Lokhttp3/internal/http/StatusLine;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((response == null) ? IntPtr.Zero : ((global::Java.Lang.Object) response).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Okhttp3.Internal.Http.StatusLine> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3.internal.http']/class[@name='StatusLine']/method[@name='parse' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("parse", "(Ljava/lang/String;)Lokhttp3/internal/http/StatusLine;", "")]
		public static unsafe global::Okhttp3.Internal.Http.StatusLine Parse (string statusLine)
		{
			const string __id = "parse.(Ljava/lang/String;)Lokhttp3/internal/http/StatusLine;";
			IntPtr native_statusLine = JNIEnv.NewString (statusLine);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_statusLine);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Okhttp3.Internal.Http.StatusLine> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_statusLine);
			}
		}

	}
}
