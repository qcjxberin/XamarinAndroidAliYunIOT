using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Okhttp3 {

	// Metadata.xml XPath class reference: path="/api/package[@name='okhttp3']/class[@name='Cookie']"
	[global::Android.Runtime.Register ("okhttp3/Cookie", DoNotGenerateAcw=true)]
	public sealed partial class Cookie : global::Java.Lang.Object {

		// Metadata.xml XPath class reference: path="/api/package[@name='okhttp3']/class[@name='Cookie.Builder']"
		[global::Android.Runtime.Register ("okhttp3/Cookie$Builder", DoNotGenerateAcw=true)]
		public sealed partial class Builder : global::Java.Lang.Object {

			static readonly JniPeerMembers _members = new XAPeerMembers ("okhttp3/Cookie$Builder", typeof (Builder));
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

			internal Builder (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			// Metadata.xml XPath constructor reference: path="/api/package[@name='okhttp3']/class[@name='Cookie.Builder']/constructor[@name='Cookie.Builder' and count(parameter)=0]"
			[Register (".ctor", "()V", "")]
			public unsafe Builder ()
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

			// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3']/class[@name='Cookie.Builder']/method[@name='build' and count(parameter)=0]"
			[Register ("build", "()Lokhttp3/Cookie;", "")]
			public unsafe global::Okhttp3.Cookie Build ()
			{
				const string __id = "build.()Lokhttp3/Cookie;";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Okhttp3.Cookie> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3']/class[@name='Cookie.Builder']/method[@name='domain' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("domain", "(Ljava/lang/String;)Lokhttp3/Cookie$Builder;", "")]
			public unsafe global::Okhttp3.Cookie.Builder Domain (string domain)
			{
				const string __id = "domain.(Ljava/lang/String;)Lokhttp3/Cookie$Builder;";
				IntPtr native_domain = JNIEnv.NewString (domain);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_domain);
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Okhttp3.Cookie.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					JNIEnv.DeleteLocalRef (native_domain);
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3']/class[@name='Cookie.Builder']/method[@name='expiresAt' and count(parameter)=1 and parameter[1][@type='long']]"
			[Register ("expiresAt", "(J)Lokhttp3/Cookie$Builder;", "")]
			public unsafe global::Okhttp3.Cookie.Builder ExpiresAt (long expiresAt)
			{
				const string __id = "expiresAt.(J)Lokhttp3/Cookie$Builder;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (expiresAt);
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Okhttp3.Cookie.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3']/class[@name='Cookie.Builder']/method[@name='hostOnlyDomain' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("hostOnlyDomain", "(Ljava/lang/String;)Lokhttp3/Cookie$Builder;", "")]
			public unsafe global::Okhttp3.Cookie.Builder HostOnlyDomain (string domain)
			{
				const string __id = "hostOnlyDomain.(Ljava/lang/String;)Lokhttp3/Cookie$Builder;";
				IntPtr native_domain = JNIEnv.NewString (domain);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_domain);
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Okhttp3.Cookie.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					JNIEnv.DeleteLocalRef (native_domain);
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3']/class[@name='Cookie.Builder']/method[@name='httpOnly' and count(parameter)=0]"
			[Register ("httpOnly", "()Lokhttp3/Cookie$Builder;", "")]
			public unsafe global::Okhttp3.Cookie.Builder HttpOnly ()
			{
				const string __id = "httpOnly.()Lokhttp3/Cookie$Builder;";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Okhttp3.Cookie.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3']/class[@name='Cookie.Builder']/method[@name='name' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("name", "(Ljava/lang/String;)Lokhttp3/Cookie$Builder;", "")]
			public unsafe global::Okhttp3.Cookie.Builder Name (string name)
			{
				const string __id = "name.(Ljava/lang/String;)Lokhttp3/Cookie$Builder;";
				IntPtr native_name = JNIEnv.NewString (name);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_name);
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Okhttp3.Cookie.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					JNIEnv.DeleteLocalRef (native_name);
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3']/class[@name='Cookie.Builder']/method[@name='path' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("path", "(Ljava/lang/String;)Lokhttp3/Cookie$Builder;", "")]
			public unsafe global::Okhttp3.Cookie.Builder Path (string path)
			{
				const string __id = "path.(Ljava/lang/String;)Lokhttp3/Cookie$Builder;";
				IntPtr native_path = JNIEnv.NewString (path);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_path);
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Okhttp3.Cookie.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					JNIEnv.DeleteLocalRef (native_path);
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3']/class[@name='Cookie.Builder']/method[@name='secure' and count(parameter)=0]"
			[Register ("secure", "()Lokhttp3/Cookie$Builder;", "")]
			public unsafe global::Okhttp3.Cookie.Builder Secure ()
			{
				const string __id = "secure.()Lokhttp3/Cookie$Builder;";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Okhttp3.Cookie.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3']/class[@name='Cookie.Builder']/method[@name='value' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("value", "(Ljava/lang/String;)Lokhttp3/Cookie$Builder;", "")]
			public unsafe global::Okhttp3.Cookie.Builder Value (string value)
			{
				const string __id = "value.(Ljava/lang/String;)Lokhttp3/Cookie$Builder;";
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_value);
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Okhttp3.Cookie.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}

		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("okhttp3/Cookie", typeof (Cookie));
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

		internal Cookie (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3']/class[@name='Cookie']/method[@name='domain' and count(parameter)=0]"
		[Register ("domain", "()Ljava/lang/String;", "")]
		public unsafe string Domain ()
		{
			const string __id = "domain.()Ljava/lang/String;";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3']/class[@name='Cookie']/method[@name='expiresAt' and count(parameter)=0]"
		[Register ("expiresAt", "()J", "")]
		public unsafe long ExpiresAt ()
		{
			const string __id = "expiresAt.()J";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractInt64Method (__id, this, null);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3']/class[@name='Cookie']/method[@name='hostOnly' and count(parameter)=0]"
		[Register ("hostOnly", "()Z", "")]
		public unsafe bool HostOnly ()
		{
			const string __id = "hostOnly.()Z";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractBooleanMethod (__id, this, null);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3']/class[@name='Cookie']/method[@name='httpOnly' and count(parameter)=0]"
		[Register ("httpOnly", "()Z", "")]
		public unsafe bool HttpOnly ()
		{
			const string __id = "httpOnly.()Z";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractBooleanMethod (__id, this, null);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3']/class[@name='Cookie']/method[@name='matches' and count(parameter)=1 and parameter[1][@type='okhttp3.HttpUrl']]"
		[Register ("matches", "(Lokhttp3/HttpUrl;)Z", "")]
		public unsafe bool Matches (global::Okhttp3.HttpUrl url)
		{
			const string __id = "matches.(Lokhttp3/HttpUrl;)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((url == null) ? IntPtr.Zero : ((global::Java.Lang.Object) url).Handle);
				var __rm = _members.InstanceMethods.InvokeAbstractBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3']/class[@name='Cookie']/method[@name='name' and count(parameter)=0]"
		[Register ("name", "()Ljava/lang/String;", "")]
		public unsafe string Name ()
		{
			const string __id = "name.()Ljava/lang/String;";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3']/class[@name='Cookie']/method[@name='parse' and count(parameter)=2 and parameter[1][@type='okhttp3.HttpUrl'] and parameter[2][@type='java.lang.String']]"
		[Register ("parse", "(Lokhttp3/HttpUrl;Ljava/lang/String;)Lokhttp3/Cookie;", "")]
		public static unsafe global::Okhttp3.Cookie Parse (global::Okhttp3.HttpUrl url, string setCookie)
		{
			const string __id = "parse.(Lokhttp3/HttpUrl;Ljava/lang/String;)Lokhttp3/Cookie;";
			IntPtr native_setCookie = JNIEnv.NewString (setCookie);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((url == null) ? IntPtr.Zero : ((global::Java.Lang.Object) url).Handle);
				__args [1] = new JniArgumentValue (native_setCookie);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Okhttp3.Cookie> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_setCookie);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3']/class[@name='Cookie']/method[@name='parseAll' and count(parameter)=2 and parameter[1][@type='okhttp3.HttpUrl'] and parameter[2][@type='okhttp3.Headers']]"
		[Register ("parseAll", "(Lokhttp3/HttpUrl;Lokhttp3/Headers;)Ljava/util/List;", "")]
		public static unsafe global::System.Collections.Generic.IList<global::Okhttp3.Cookie> ParseAll (global::Okhttp3.HttpUrl url, global::Okhttp3.Headers headers)
		{
			const string __id = "parseAll.(Lokhttp3/HttpUrl;Lokhttp3/Headers;)Ljava/util/List;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((url == null) ? IntPtr.Zero : ((global::Java.Lang.Object) url).Handle);
				__args [1] = new JniArgumentValue ((headers == null) ? IntPtr.Zero : ((global::Java.Lang.Object) headers).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Android.Runtime.JavaList<global::Okhttp3.Cookie>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3']/class[@name='Cookie']/method[@name='path' and count(parameter)=0]"
		[Register ("path", "()Ljava/lang/String;", "")]
		public unsafe string Path ()
		{
			const string __id = "path.()Ljava/lang/String;";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3']/class[@name='Cookie']/method[@name='persistent' and count(parameter)=0]"
		[Register ("persistent", "()Z", "")]
		public unsafe bool Persistent ()
		{
			const string __id = "persistent.()Z";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractBooleanMethod (__id, this, null);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3']/class[@name='Cookie']/method[@name='secure' and count(parameter)=0]"
		[Register ("secure", "()Z", "")]
		public unsafe bool Secure ()
		{
			const string __id = "secure.()Z";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractBooleanMethod (__id, this, null);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3']/class[@name='Cookie']/method[@name='value' and count(parameter)=0]"
		[Register ("value", "()Ljava/lang/String;", "")]
		public unsafe string Value ()
		{
			const string __id = "value.()Ljava/lang/String;";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}
}
