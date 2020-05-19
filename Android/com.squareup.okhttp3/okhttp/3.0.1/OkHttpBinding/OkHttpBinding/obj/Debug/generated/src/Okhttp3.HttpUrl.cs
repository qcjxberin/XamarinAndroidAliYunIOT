using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Okhttp3 {

	// Metadata.xml XPath class reference: path="/api/package[@name='okhttp3']/class[@name='HttpUrl']"
	[global::Android.Runtime.Register ("okhttp3/HttpUrl", DoNotGenerateAcw=true)]
	public sealed partial class HttpUrl : global::Java.Lang.Object {

		// Metadata.xml XPath class reference: path="/api/package[@name='okhttp3']/class[@name='HttpUrl.Builder']"
		[global::Android.Runtime.Register ("okhttp3/HttpUrl$Builder", DoNotGenerateAcw=true)]
		public sealed partial class Builder : global::Java.Lang.Object {

			// Metadata.xml XPath class reference: path="/api/package[@name='okhttp3']/class[@name='HttpUrl.Builder.ParseResult']"
			[global::Android.Runtime.Register ("okhttp3/HttpUrl$Builder$ParseResult", DoNotGenerateAcw=true)]
			public sealed partial class ParseResult : global::Java.Lang.Enum {



				// Metadata.xml XPath field reference: path="/api/package[@name='okhttp3']/class[@name='HttpUrl.Builder.ParseResult']/field[@name='INVALID_HOST']"
				[Register ("INVALID_HOST")]
				public static global::Okhttp3.HttpUrl.Builder.ParseResult InvalidHost {
					get {
						const string __id = "INVALID_HOST.Lokhttp3/HttpUrl$Builder$ParseResult;";

						var __v = _members.StaticFields.GetObjectValue (__id);
						return global::Java.Lang.Object.GetObject<global::Okhttp3.HttpUrl.Builder.ParseResult> (__v.Handle, JniHandleOwnership.TransferLocalRef);
					}
				}


				// Metadata.xml XPath field reference: path="/api/package[@name='okhttp3']/class[@name='HttpUrl.Builder.ParseResult']/field[@name='INVALID_PORT']"
				[Register ("INVALID_PORT")]
				public static global::Okhttp3.HttpUrl.Builder.ParseResult InvalidPort {
					get {
						const string __id = "INVALID_PORT.Lokhttp3/HttpUrl$Builder$ParseResult;";

						var __v = _members.StaticFields.GetObjectValue (__id);
						return global::Java.Lang.Object.GetObject<global::Okhttp3.HttpUrl.Builder.ParseResult> (__v.Handle, JniHandleOwnership.TransferLocalRef);
					}
				}


				// Metadata.xml XPath field reference: path="/api/package[@name='okhttp3']/class[@name='HttpUrl.Builder.ParseResult']/field[@name='MISSING_SCHEME']"
				[Register ("MISSING_SCHEME")]
				public static global::Okhttp3.HttpUrl.Builder.ParseResult MissingScheme {
					get {
						const string __id = "MISSING_SCHEME.Lokhttp3/HttpUrl$Builder$ParseResult;";

						var __v = _members.StaticFields.GetObjectValue (__id);
						return global::Java.Lang.Object.GetObject<global::Okhttp3.HttpUrl.Builder.ParseResult> (__v.Handle, JniHandleOwnership.TransferLocalRef);
					}
				}


				// Metadata.xml XPath field reference: path="/api/package[@name='okhttp3']/class[@name='HttpUrl.Builder.ParseResult']/field[@name='SUCCESS']"
				[Register ("SUCCESS")]
				public static global::Okhttp3.HttpUrl.Builder.ParseResult Success {
					get {
						const string __id = "SUCCESS.Lokhttp3/HttpUrl$Builder$ParseResult;";

						var __v = _members.StaticFields.GetObjectValue (__id);
						return global::Java.Lang.Object.GetObject<global::Okhttp3.HttpUrl.Builder.ParseResult> (__v.Handle, JniHandleOwnership.TransferLocalRef);
					}
				}


				// Metadata.xml XPath field reference: path="/api/package[@name='okhttp3']/class[@name='HttpUrl.Builder.ParseResult']/field[@name='UNSUPPORTED_SCHEME']"
				[Register ("UNSUPPORTED_SCHEME")]
				public static global::Okhttp3.HttpUrl.Builder.ParseResult UnsupportedScheme {
					get {
						const string __id = "UNSUPPORTED_SCHEME.Lokhttp3/HttpUrl$Builder$ParseResult;";

						var __v = _members.StaticFields.GetObjectValue (__id);
						return global::Java.Lang.Object.GetObject<global::Okhttp3.HttpUrl.Builder.ParseResult> (__v.Handle, JniHandleOwnership.TransferLocalRef);
					}
				}
				static readonly JniPeerMembers _members = new XAPeerMembers ("okhttp3/HttpUrl$Builder$ParseResult", typeof (ParseResult));
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

				internal ParseResult (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

				// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3']/class[@name='HttpUrl.Builder.ParseResult']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
				[Register ("valueOf", "(Ljava/lang/String;)Ljava/lang/Enum;", "")]
				public static unsafe global::Java.Lang.Enum ValueOf (string name)
				{
					const string __id = "valueOf.(Ljava/lang/String;)Ljava/lang/Enum;";
					IntPtr native_name = JNIEnv.NewString (name);
					try {
						JniArgumentValue* __args = stackalloc JniArgumentValue [1];
						__args [0] = new JniArgumentValue (native_name);
						var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
						return global::Java.Lang.Object.GetObject<global::Java.Lang.Enum> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
					} finally {
						JNIEnv.DeleteLocalRef (native_name);
					}
				}

				// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3']/class[@name='HttpUrl.Builder.ParseResult']/method[@name='values' and count(parameter)=0]"
				[Register ("values", "()[Lokhttp3/HttpUrl$Builder$ParseResult;", "")]
				public static unsafe global::Okhttp3.HttpUrl.Builder.ParseResult[] Values ()
				{
					const string __id = "values.()[Lokhttp3/HttpUrl$Builder$ParseResult;";
					try {
						var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
						return (global::Okhttp3.HttpUrl.Builder.ParseResult[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (global::Okhttp3.HttpUrl.Builder.ParseResult));
					} finally {
					}
				}

			}

			static readonly JniPeerMembers _members = new XAPeerMembers ("okhttp3/HttpUrl$Builder", typeof (Builder));
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

			// Metadata.xml XPath constructor reference: path="/api/package[@name='okhttp3']/class[@name='HttpUrl.Builder']/constructor[@name='HttpUrl.Builder' and count(parameter)=0]"
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

			// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3']/class[@name='HttpUrl.Builder']/method[@name='addEncodedPathSegment' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("addEncodedPathSegment", "(Ljava/lang/String;)Lokhttp3/HttpUrl$Builder;", "")]
			public unsafe global::Okhttp3.HttpUrl.Builder AddEncodedPathSegment (string encodedPathSegment)
			{
				const string __id = "addEncodedPathSegment.(Ljava/lang/String;)Lokhttp3/HttpUrl$Builder;";
				IntPtr native_encodedPathSegment = JNIEnv.NewString (encodedPathSegment);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_encodedPathSegment);
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Okhttp3.HttpUrl.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					JNIEnv.DeleteLocalRef (native_encodedPathSegment);
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3']/class[@name='HttpUrl.Builder']/method[@name='addEncodedQueryParameter' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
			[Register ("addEncodedQueryParameter", "(Ljava/lang/String;Ljava/lang/String;)Lokhttp3/HttpUrl$Builder;", "")]
			public unsafe global::Okhttp3.HttpUrl.Builder AddEncodedQueryParameter (string encodedName, string encodedValue)
			{
				const string __id = "addEncodedQueryParameter.(Ljava/lang/String;Ljava/lang/String;)Lokhttp3/HttpUrl$Builder;";
				IntPtr native_encodedName = JNIEnv.NewString (encodedName);
				IntPtr native_encodedValue = JNIEnv.NewString (encodedValue);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [2];
					__args [0] = new JniArgumentValue (native_encodedName);
					__args [1] = new JniArgumentValue (native_encodedValue);
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Okhttp3.HttpUrl.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					JNIEnv.DeleteLocalRef (native_encodedName);
					JNIEnv.DeleteLocalRef (native_encodedValue);
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3']/class[@name='HttpUrl.Builder']/method[@name='addPathSegment' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("addPathSegment", "(Ljava/lang/String;)Lokhttp3/HttpUrl$Builder;", "")]
			public unsafe global::Okhttp3.HttpUrl.Builder AddPathSegment (string pathSegment)
			{
				const string __id = "addPathSegment.(Ljava/lang/String;)Lokhttp3/HttpUrl$Builder;";
				IntPtr native_pathSegment = JNIEnv.NewString (pathSegment);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_pathSegment);
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Okhttp3.HttpUrl.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					JNIEnv.DeleteLocalRef (native_pathSegment);
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3']/class[@name='HttpUrl.Builder']/method[@name='addQueryParameter' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
			[Register ("addQueryParameter", "(Ljava/lang/String;Ljava/lang/String;)Lokhttp3/HttpUrl$Builder;", "")]
			public unsafe global::Okhttp3.HttpUrl.Builder AddQueryParameter (string name, string value)
			{
				const string __id = "addQueryParameter.(Ljava/lang/String;Ljava/lang/String;)Lokhttp3/HttpUrl$Builder;";
				IntPtr native_name = JNIEnv.NewString (name);
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [2];
					__args [0] = new JniArgumentValue (native_name);
					__args [1] = new JniArgumentValue (native_value);
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Okhttp3.HttpUrl.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					JNIEnv.DeleteLocalRef (native_name);
					JNIEnv.DeleteLocalRef (native_value);
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3']/class[@name='HttpUrl.Builder']/method[@name='build' and count(parameter)=0]"
			[Register ("build", "()Lokhttp3/HttpUrl;", "")]
			public unsafe global::Okhttp3.HttpUrl Build ()
			{
				const string __id = "build.()Lokhttp3/HttpUrl;";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Okhttp3.HttpUrl> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3']/class[@name='HttpUrl.Builder']/method[@name='encodedFragment' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("encodedFragment", "(Ljava/lang/String;)Lokhttp3/HttpUrl$Builder;", "")]
			public unsafe global::Okhttp3.HttpUrl.Builder EncodedFragment (string encodedFragment)
			{
				const string __id = "encodedFragment.(Ljava/lang/String;)Lokhttp3/HttpUrl$Builder;";
				IntPtr native_encodedFragment = JNIEnv.NewString (encodedFragment);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_encodedFragment);
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Okhttp3.HttpUrl.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					JNIEnv.DeleteLocalRef (native_encodedFragment);
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3']/class[@name='HttpUrl.Builder']/method[@name='encodedPassword' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("encodedPassword", "(Ljava/lang/String;)Lokhttp3/HttpUrl$Builder;", "")]
			public unsafe global::Okhttp3.HttpUrl.Builder EncodedPassword (string encodedPassword)
			{
				const string __id = "encodedPassword.(Ljava/lang/String;)Lokhttp3/HttpUrl$Builder;";
				IntPtr native_encodedPassword = JNIEnv.NewString (encodedPassword);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_encodedPassword);
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Okhttp3.HttpUrl.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					JNIEnv.DeleteLocalRef (native_encodedPassword);
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3']/class[@name='HttpUrl.Builder']/method[@name='encodedPath' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("encodedPath", "(Ljava/lang/String;)Lokhttp3/HttpUrl$Builder;", "")]
			public unsafe global::Okhttp3.HttpUrl.Builder EncodedPath (string encodedPath)
			{
				const string __id = "encodedPath.(Ljava/lang/String;)Lokhttp3/HttpUrl$Builder;";
				IntPtr native_encodedPath = JNIEnv.NewString (encodedPath);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_encodedPath);
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Okhttp3.HttpUrl.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					JNIEnv.DeleteLocalRef (native_encodedPath);
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3']/class[@name='HttpUrl.Builder']/method[@name='encodedQuery' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("encodedQuery", "(Ljava/lang/String;)Lokhttp3/HttpUrl$Builder;", "")]
			public unsafe global::Okhttp3.HttpUrl.Builder EncodedQuery (string encodedQuery)
			{
				const string __id = "encodedQuery.(Ljava/lang/String;)Lokhttp3/HttpUrl$Builder;";
				IntPtr native_encodedQuery = JNIEnv.NewString (encodedQuery);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_encodedQuery);
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Okhttp3.HttpUrl.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					JNIEnv.DeleteLocalRef (native_encodedQuery);
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3']/class[@name='HttpUrl.Builder']/method[@name='encodedUsername' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("encodedUsername", "(Ljava/lang/String;)Lokhttp3/HttpUrl$Builder;", "")]
			public unsafe global::Okhttp3.HttpUrl.Builder EncodedUsername (string encodedUsername)
			{
				const string __id = "encodedUsername.(Ljava/lang/String;)Lokhttp3/HttpUrl$Builder;";
				IntPtr native_encodedUsername = JNIEnv.NewString (encodedUsername);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_encodedUsername);
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Okhttp3.HttpUrl.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					JNIEnv.DeleteLocalRef (native_encodedUsername);
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3']/class[@name='HttpUrl.Builder']/method[@name='fragment' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("fragment", "(Ljava/lang/String;)Lokhttp3/HttpUrl$Builder;", "")]
			public unsafe global::Okhttp3.HttpUrl.Builder Fragment (string fragment)
			{
				const string __id = "fragment.(Ljava/lang/String;)Lokhttp3/HttpUrl$Builder;";
				IntPtr native_fragment = JNIEnv.NewString (fragment);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_fragment);
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Okhttp3.HttpUrl.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					JNIEnv.DeleteLocalRef (native_fragment);
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3']/class[@name='HttpUrl.Builder']/method[@name='host' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("host", "(Ljava/lang/String;)Lokhttp3/HttpUrl$Builder;", "")]
			public unsafe global::Okhttp3.HttpUrl.Builder Host (string host)
			{
				const string __id = "host.(Ljava/lang/String;)Lokhttp3/HttpUrl$Builder;";
				IntPtr native_host = JNIEnv.NewString (host);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_host);
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Okhttp3.HttpUrl.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					JNIEnv.DeleteLocalRef (native_host);
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3']/class[@name='HttpUrl.Builder']/method[@name='password' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("password", "(Ljava/lang/String;)Lokhttp3/HttpUrl$Builder;", "")]
			public unsafe global::Okhttp3.HttpUrl.Builder Password (string password)
			{
				const string __id = "password.(Ljava/lang/String;)Lokhttp3/HttpUrl$Builder;";
				IntPtr native_password = JNIEnv.NewString (password);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_password);
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Okhttp3.HttpUrl.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					JNIEnv.DeleteLocalRef (native_password);
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3']/class[@name='HttpUrl.Builder']/method[@name='port' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("port", "(I)Lokhttp3/HttpUrl$Builder;", "")]
			public unsafe global::Okhttp3.HttpUrl.Builder Port (int port)
			{
				const string __id = "port.(I)Lokhttp3/HttpUrl$Builder;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (port);
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Okhttp3.HttpUrl.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3']/class[@name='HttpUrl.Builder']/method[@name='query' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("query", "(Ljava/lang/String;)Lokhttp3/HttpUrl$Builder;", "")]
			public unsafe global::Okhttp3.HttpUrl.Builder Query (string query)
			{
				const string __id = "query.(Ljava/lang/String;)Lokhttp3/HttpUrl$Builder;";
				IntPtr native_query = JNIEnv.NewString (query);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_query);
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Okhttp3.HttpUrl.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					JNIEnv.DeleteLocalRef (native_query);
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3']/class[@name='HttpUrl.Builder']/method[@name='removeAllEncodedQueryParameters' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("removeAllEncodedQueryParameters", "(Ljava/lang/String;)Lokhttp3/HttpUrl$Builder;", "")]
			public unsafe global::Okhttp3.HttpUrl.Builder RemoveAllEncodedQueryParameters (string encodedName)
			{
				const string __id = "removeAllEncodedQueryParameters.(Ljava/lang/String;)Lokhttp3/HttpUrl$Builder;";
				IntPtr native_encodedName = JNIEnv.NewString (encodedName);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_encodedName);
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Okhttp3.HttpUrl.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					JNIEnv.DeleteLocalRef (native_encodedName);
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3']/class[@name='HttpUrl.Builder']/method[@name='removeAllQueryParameters' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("removeAllQueryParameters", "(Ljava/lang/String;)Lokhttp3/HttpUrl$Builder;", "")]
			public unsafe global::Okhttp3.HttpUrl.Builder RemoveAllQueryParameters (string name)
			{
				const string __id = "removeAllQueryParameters.(Ljava/lang/String;)Lokhttp3/HttpUrl$Builder;";
				IntPtr native_name = JNIEnv.NewString (name);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_name);
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Okhttp3.HttpUrl.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					JNIEnv.DeleteLocalRef (native_name);
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3']/class[@name='HttpUrl.Builder']/method[@name='removePathSegment' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("removePathSegment", "(I)Lokhttp3/HttpUrl$Builder;", "")]
			public unsafe global::Okhttp3.HttpUrl.Builder RemovePathSegment (int index)
			{
				const string __id = "removePathSegment.(I)Lokhttp3/HttpUrl$Builder;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (index);
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Okhttp3.HttpUrl.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3']/class[@name='HttpUrl.Builder']/method[@name='scheme' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("scheme", "(Ljava/lang/String;)Lokhttp3/HttpUrl$Builder;", "")]
			public unsafe global::Okhttp3.HttpUrl.Builder Scheme (string scheme)
			{
				const string __id = "scheme.(Ljava/lang/String;)Lokhttp3/HttpUrl$Builder;";
				IntPtr native_scheme = JNIEnv.NewString (scheme);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_scheme);
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Okhttp3.HttpUrl.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					JNIEnv.DeleteLocalRef (native_scheme);
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3']/class[@name='HttpUrl.Builder']/method[@name='setEncodedPathSegment' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='java.lang.String']]"
			[Register ("setEncodedPathSegment", "(ILjava/lang/String;)Lokhttp3/HttpUrl$Builder;", "")]
			public unsafe global::Okhttp3.HttpUrl.Builder SetEncodedPathSegment (int index, string encodedPathSegment)
			{
				const string __id = "setEncodedPathSegment.(ILjava/lang/String;)Lokhttp3/HttpUrl$Builder;";
				IntPtr native_encodedPathSegment = JNIEnv.NewString (encodedPathSegment);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [2];
					__args [0] = new JniArgumentValue (index);
					__args [1] = new JniArgumentValue (native_encodedPathSegment);
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Okhttp3.HttpUrl.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					JNIEnv.DeleteLocalRef (native_encodedPathSegment);
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3']/class[@name='HttpUrl.Builder']/method[@name='setEncodedQueryParameter' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
			[Register ("setEncodedQueryParameter", "(Ljava/lang/String;Ljava/lang/String;)Lokhttp3/HttpUrl$Builder;", "")]
			public unsafe global::Okhttp3.HttpUrl.Builder SetEncodedQueryParameter (string encodedName, string encodedValue)
			{
				const string __id = "setEncodedQueryParameter.(Ljava/lang/String;Ljava/lang/String;)Lokhttp3/HttpUrl$Builder;";
				IntPtr native_encodedName = JNIEnv.NewString (encodedName);
				IntPtr native_encodedValue = JNIEnv.NewString (encodedValue);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [2];
					__args [0] = new JniArgumentValue (native_encodedName);
					__args [1] = new JniArgumentValue (native_encodedValue);
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Okhttp3.HttpUrl.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					JNIEnv.DeleteLocalRef (native_encodedName);
					JNIEnv.DeleteLocalRef (native_encodedValue);
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3']/class[@name='HttpUrl.Builder']/method[@name='setPathSegment' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='java.lang.String']]"
			[Register ("setPathSegment", "(ILjava/lang/String;)Lokhttp3/HttpUrl$Builder;", "")]
			public unsafe global::Okhttp3.HttpUrl.Builder SetPathSegment (int index, string pathSegment)
			{
				const string __id = "setPathSegment.(ILjava/lang/String;)Lokhttp3/HttpUrl$Builder;";
				IntPtr native_pathSegment = JNIEnv.NewString (pathSegment);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [2];
					__args [0] = new JniArgumentValue (index);
					__args [1] = new JniArgumentValue (native_pathSegment);
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Okhttp3.HttpUrl.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					JNIEnv.DeleteLocalRef (native_pathSegment);
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3']/class[@name='HttpUrl.Builder']/method[@name='setQueryParameter' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
			[Register ("setQueryParameter", "(Ljava/lang/String;Ljava/lang/String;)Lokhttp3/HttpUrl$Builder;", "")]
			public unsafe global::Okhttp3.HttpUrl.Builder SetQueryParameter (string name, string value)
			{
				const string __id = "setQueryParameter.(Ljava/lang/String;Ljava/lang/String;)Lokhttp3/HttpUrl$Builder;";
				IntPtr native_name = JNIEnv.NewString (name);
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [2];
					__args [0] = new JniArgumentValue (native_name);
					__args [1] = new JniArgumentValue (native_value);
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Okhttp3.HttpUrl.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					JNIEnv.DeleteLocalRef (native_name);
					JNIEnv.DeleteLocalRef (native_value);
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3']/class[@name='HttpUrl.Builder']/method[@name='username' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("username", "(Ljava/lang/String;)Lokhttp3/HttpUrl$Builder;", "")]
			public unsafe global::Okhttp3.HttpUrl.Builder Username (string username)
			{
				const string __id = "username.(Ljava/lang/String;)Lokhttp3/HttpUrl$Builder;";
				IntPtr native_username = JNIEnv.NewString (username);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_username);
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Okhttp3.HttpUrl.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					JNIEnv.DeleteLocalRef (native_username);
				}
			}

		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("okhttp3/HttpUrl", typeof (HttpUrl));
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

		internal HttpUrl (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		public unsafe bool IsHttps {
			// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3']/class[@name='HttpUrl']/method[@name='isHttps' and count(parameter)=0]"
			[Register ("isHttps", "()Z", "")]
			get {
				const string __id = "isHttps.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3']/class[@name='HttpUrl']/method[@name='defaultPort' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("defaultPort", "(Ljava/lang/String;)I", "")]
		public static unsafe int DefaultPort (string scheme)
		{
			const string __id = "defaultPort.(Ljava/lang/String;)I";
			IntPtr native_scheme = JNIEnv.NewString (scheme);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_scheme);
				var __rm = _members.StaticMethods.InvokeInt32Method (__id, __args);
				return __rm;
			} finally {
				JNIEnv.DeleteLocalRef (native_scheme);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3']/class[@name='HttpUrl']/method[@name='encodedFragment' and count(parameter)=0]"
		[Register ("encodedFragment", "()Ljava/lang/String;", "")]
		public unsafe string EncodedFragment ()
		{
			const string __id = "encodedFragment.()Ljava/lang/String;";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3']/class[@name='HttpUrl']/method[@name='encodedPassword' and count(parameter)=0]"
		[Register ("encodedPassword", "()Ljava/lang/String;", "")]
		public unsafe string EncodedPassword ()
		{
			const string __id = "encodedPassword.()Ljava/lang/String;";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3']/class[@name='HttpUrl']/method[@name='encodedPath' and count(parameter)=0]"
		[Register ("encodedPath", "()Ljava/lang/String;", "")]
		public unsafe string EncodedPath ()
		{
			const string __id = "encodedPath.()Ljava/lang/String;";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3']/class[@name='HttpUrl']/method[@name='encodedPathSegments' and count(parameter)=0]"
		[Register ("encodedPathSegments", "()Ljava/util/List;", "")]
		public unsafe global::System.Collections.Generic.IList<string> EncodedPathSegments ()
		{
			const string __id = "encodedPathSegments.()Ljava/util/List;";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
				return global::Android.Runtime.JavaList<string>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3']/class[@name='HttpUrl']/method[@name='encodedQuery' and count(parameter)=0]"
		[Register ("encodedQuery", "()Ljava/lang/String;", "")]
		public unsafe string EncodedQuery ()
		{
			const string __id = "encodedQuery.()Ljava/lang/String;";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3']/class[@name='HttpUrl']/method[@name='encodedUsername' and count(parameter)=0]"
		[Register ("encodedUsername", "()Ljava/lang/String;", "")]
		public unsafe string EncodedUsername ()
		{
			const string __id = "encodedUsername.()Ljava/lang/String;";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3']/class[@name='HttpUrl']/method[@name='fragment' and count(parameter)=0]"
		[Register ("fragment", "()Ljava/lang/String;", "")]
		public unsafe string Fragment ()
		{
			const string __id = "fragment.()Ljava/lang/String;";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3']/class[@name='HttpUrl']/method[@name='get' and count(parameter)=1 and parameter[1][@type='java.net.URI']]"
		[Register ("get", "(Ljava/net/URI;)Lokhttp3/HttpUrl;", "")]
		public static unsafe global::Okhttp3.HttpUrl Get (global::Java.Net.URI uri)
		{
			const string __id = "get.(Ljava/net/URI;)Lokhttp3/HttpUrl;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((uri == null) ? IntPtr.Zero : ((global::Java.Lang.Object) uri).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Okhttp3.HttpUrl> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3']/class[@name='HttpUrl']/method[@name='get' and count(parameter)=1 and parameter[1][@type='java.net.URL']]"
		[Register ("get", "(Ljava/net/URL;)Lokhttp3/HttpUrl;", "")]
		public static unsafe global::Okhttp3.HttpUrl Get (global::Java.Net.URL url)
		{
			const string __id = "get.(Ljava/net/URL;)Lokhttp3/HttpUrl;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((url == null) ? IntPtr.Zero : ((global::Java.Lang.Object) url).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Okhttp3.HttpUrl> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3']/class[@name='HttpUrl']/method[@name='host' and count(parameter)=0]"
		[Register ("host", "()Ljava/lang/String;", "")]
		public unsafe string Host ()
		{
			const string __id = "host.()Ljava/lang/String;";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3']/class[@name='HttpUrl']/method[@name='newBuilder' and count(parameter)=0]"
		[Register ("newBuilder", "()Lokhttp3/HttpUrl$Builder;", "")]
		public unsafe global::Okhttp3.HttpUrl.Builder NewBuilder ()
		{
			const string __id = "newBuilder.()Lokhttp3/HttpUrl$Builder;";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Okhttp3.HttpUrl.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3']/class[@name='HttpUrl']/method[@name='newBuilder' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("newBuilder", "(Ljava/lang/String;)Lokhttp3/HttpUrl$Builder;", "")]
		public unsafe global::Okhttp3.HttpUrl.Builder NewBuilder (string link)
		{
			const string __id = "newBuilder.(Ljava/lang/String;)Lokhttp3/HttpUrl$Builder;";
			IntPtr native_link = JNIEnv.NewString (link);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_link);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Okhttp3.HttpUrl.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_link);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3']/class[@name='HttpUrl']/method[@name='parse' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("parse", "(Ljava/lang/String;)Lokhttp3/HttpUrl;", "")]
		public static unsafe global::Okhttp3.HttpUrl Parse (string url)
		{
			const string __id = "parse.(Ljava/lang/String;)Lokhttp3/HttpUrl;";
			IntPtr native_url = JNIEnv.NewString (url);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_url);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Okhttp3.HttpUrl> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_url);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3']/class[@name='HttpUrl']/method[@name='password' and count(parameter)=0]"
		[Register ("password", "()Ljava/lang/String;", "")]
		public unsafe string Password ()
		{
			const string __id = "password.()Ljava/lang/String;";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3']/class[@name='HttpUrl']/method[@name='pathSegments' and count(parameter)=0]"
		[Register ("pathSegments", "()Ljava/util/List;", "")]
		public unsafe global::System.Collections.Generic.IList<string> PathSegments ()
		{
			const string __id = "pathSegments.()Ljava/util/List;";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
				return global::Android.Runtime.JavaList<string>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3']/class[@name='HttpUrl']/method[@name='pathSize' and count(parameter)=0]"
		[Register ("pathSize", "()I", "")]
		public unsafe int PathSize ()
		{
			const string __id = "pathSize.()I";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, null);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3']/class[@name='HttpUrl']/method[@name='port' and count(parameter)=0]"
		[Register ("port", "()I", "")]
		public unsafe int Port ()
		{
			const string __id = "port.()I";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, null);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3']/class[@name='HttpUrl']/method[@name='query' and count(parameter)=0]"
		[Register ("query", "()Ljava/lang/String;", "")]
		public unsafe string Query ()
		{
			const string __id = "query.()Ljava/lang/String;";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3']/class[@name='HttpUrl']/method[@name='queryParameter' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("queryParameter", "(Ljava/lang/String;)Ljava/lang/String;", "")]
		public unsafe string QueryParameter (string name)
		{
			const string __id = "queryParameter.(Ljava/lang/String;)Ljava/lang/String;";
			IntPtr native_name = JNIEnv.NewString (name);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_name);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_name);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3']/class[@name='HttpUrl']/method[@name='queryParameterName' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("queryParameterName", "(I)Ljava/lang/String;", "")]
		public unsafe string QueryParameterName (int index)
		{
			const string __id = "queryParameterName.(I)Ljava/lang/String;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (index);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3']/class[@name='HttpUrl']/method[@name='queryParameterNames' and count(parameter)=0]"
		[Register ("queryParameterNames", "()Ljava/util/Set;", "")]
		public unsafe global::System.Collections.Generic.ICollection<string> QueryParameterNames ()
		{
			const string __id = "queryParameterNames.()Ljava/util/Set;";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
				return global::Android.Runtime.JavaSet<string>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3']/class[@name='HttpUrl']/method[@name='queryParameterValue' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("queryParameterValue", "(I)Ljava/lang/String;", "")]
		public unsafe string QueryParameterValue (int index)
		{
			const string __id = "queryParameterValue.(I)Ljava/lang/String;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (index);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3']/class[@name='HttpUrl']/method[@name='queryParameterValues' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("queryParameterValues", "(Ljava/lang/String;)Ljava/util/List;", "")]
		public unsafe global::System.Collections.Generic.IList<string> QueryParameterValues (string name)
		{
			const string __id = "queryParameterValues.(Ljava/lang/String;)Ljava/util/List;";
			IntPtr native_name = JNIEnv.NewString (name);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_name);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Android.Runtime.JavaList<string>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_name);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3']/class[@name='HttpUrl']/method[@name='querySize' and count(parameter)=0]"
		[Register ("querySize", "()I", "")]
		public unsafe int QuerySize ()
		{
			const string __id = "querySize.()I";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, null);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3']/class[@name='HttpUrl']/method[@name='resolve' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("resolve", "(Ljava/lang/String;)Lokhttp3/HttpUrl;", "")]
		public unsafe global::Okhttp3.HttpUrl Resolve (string link)
		{
			const string __id = "resolve.(Ljava/lang/String;)Lokhttp3/HttpUrl;";
			IntPtr native_link = JNIEnv.NewString (link);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_link);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Okhttp3.HttpUrl> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_link);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3']/class[@name='HttpUrl']/method[@name='scheme' and count(parameter)=0]"
		[Register ("scheme", "()Ljava/lang/String;", "")]
		public unsafe string Scheme ()
		{
			const string __id = "scheme.()Ljava/lang/String;";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3']/class[@name='HttpUrl']/method[@name='uri' and count(parameter)=0]"
		[Register ("uri", "()Ljava/net/URI;", "")]
		public unsafe global::Java.Net.URI Uri ()
		{
			const string __id = "uri.()Ljava/net/URI;";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Java.Net.URI> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3']/class[@name='HttpUrl']/method[@name='url' and count(parameter)=0]"
		[Register ("url", "()Ljava/net/URL;", "")]
		public unsafe global::Java.Net.URL Url ()
		{
			const string __id = "url.()Ljava/net/URL;";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Java.Net.URL> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3']/class[@name='HttpUrl']/method[@name='username' and count(parameter)=0]"
		[Register ("username", "()Ljava/lang/String;", "")]
		public unsafe string Username ()
		{
			const string __id = "username.()Ljava/lang/String;";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}
}
