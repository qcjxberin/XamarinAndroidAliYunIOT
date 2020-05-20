using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Okhttp3.Internal.Huc {

	// Metadata.xml XPath class reference: path="/api/package[@name='okhttp3.internal.huc']/class[@name='OkHttpsURLConnection']"
	[global::Android.Runtime.Register ("okhttp3/internal/huc/OkHttpsURLConnection", DoNotGenerateAcw=true)]
	public sealed partial class OkHttpsURLConnection : global::Javax.Net.Ssl.HttpsURLConnection {

		static readonly JniPeerMembers _members = new XAPeerMembers ("okhttp3/internal/huc/OkHttpsURLConnection", typeof (OkHttpsURLConnection));
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

		internal OkHttpsURLConnection (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='okhttp3.internal.huc']/class[@name='OkHttpsURLConnection']/constructor[@name='OkHttpsURLConnection' and count(parameter)=2 and parameter[1][@type='java.net.URL'] and parameter[2][@type='okhttp3.OkHttpClient']]"
		[Register (".ctor", "(Ljava/net/URL;Lokhttp3/OkHttpClient;)V", "")]
		public unsafe OkHttpsURLConnection (global::Java.Net.URL url, global::Okhttp3.OkHttpClient client)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Ljava/net/URL;Lokhttp3/OkHttpClient;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((url == null) ? IntPtr.Zero : ((global::Java.Lang.Object) url).Handle);
				__args [1] = new JniArgumentValue ((client == null) ? IntPtr.Zero : ((global::Java.Lang.Object) client).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='okhttp3.internal.huc']/class[@name='OkHttpsURLConnection']/constructor[@name='OkHttpsURLConnection' and count(parameter)=3 and parameter[1][@type='java.net.URL'] and parameter[2][@type='okhttp3.OkHttpClient'] and parameter[3][@type='okhttp3.internal.URLFilter']]"
		[Register (".ctor", "(Ljava/net/URL;Lokhttp3/OkHttpClient;Lokhttp3/internal/URLFilter;)V", "")]
		public unsafe OkHttpsURLConnection (global::Java.Net.URL url, global::Okhttp3.OkHttpClient client, global::Okhttp3.Internal.IURLFilter filter)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Ljava/net/URL;Lokhttp3/OkHttpClient;Lokhttp3/internal/URLFilter;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((url == null) ? IntPtr.Zero : ((global::Java.Lang.Object) url).Handle);
				__args [1] = new JniArgumentValue ((client == null) ? IntPtr.Zero : ((global::Java.Lang.Object) client).Handle);
				__args [2] = new JniArgumentValue ((filter == null) ? IntPtr.Zero : ((global::Java.Lang.Object) filter).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='okhttp3.internal.huc']/class[@name='OkHttpsURLConnection']/constructor[@name='OkHttpsURLConnection' and count(parameter)=1 and parameter[1][@type='okhttp3.internal.huc.OkHttpURLConnection']]"
		[Register (".ctor", "(Lokhttp3/internal/huc/OkHttpURLConnection;)V", "")]
		public unsafe OkHttpsURLConnection (global::Okhttp3.Internal.Huc.OkHttpURLConnection @delegate)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Lokhttp3/internal/huc/OkHttpURLConnection;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((@delegate == null) ? IntPtr.Zero : ((global::Java.Lang.Object) @delegate).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
			}
		}

		public override unsafe bool AllowUserInteraction {
			// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3.internal.huc']/class[@name='OkHttpsURLConnection']/method[@name='getAllowUserInteraction' and count(parameter)=0]"
			[Register ("getAllowUserInteraction", "()Z", "")]
			get {
				const string __id = "getAllowUserInteraction.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3.internal.huc']/class[@name='OkHttpsURLConnection']/method[@name='setAllowUserInteraction' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setAllowUserInteraction", "(Z)V", "")]
			set {
				const string __id = "setAllowUserInteraction.(Z)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		public override unsafe string CipherSuite {
			// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3.internal.huc']/class[@name='OkHttpsURLConnection']/method[@name='getCipherSuite' and count(parameter)=0]"
			[Register ("getCipherSuite", "()Ljava/lang/String;", "")]
			get {
				const string __id = "getCipherSuite.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		public override unsafe int ConnectTimeout {
			// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3.internal.huc']/class[@name='OkHttpsURLConnection']/method[@name='getConnectTimeout' and count(parameter)=0]"
			[Register ("getConnectTimeout", "()I", "")]
			get {
				const string __id = "getConnectTimeout.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3.internal.huc']/class[@name='OkHttpsURLConnection']/method[@name='setConnectTimeout' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setConnectTimeout", "(I)V", "")]
			set {
				const string __id = "setConnectTimeout.(I)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		public override unsafe global::Java.Lang.Object Content {
			// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3.internal.huc']/class[@name='OkHttpsURLConnection']/method[@name='getContent' and count(parameter)=0]"
			[Register ("getContent", "()Ljava/lang/Object;", "")]
			get {
				const string __id = "getContent.()Ljava/lang/Object;";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		public override unsafe string ContentEncoding {
			// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3.internal.huc']/class[@name='OkHttpsURLConnection']/method[@name='getContentEncoding' and count(parameter)=0]"
			[Register ("getContentEncoding", "()Ljava/lang/String;", "")]
			get {
				const string __id = "getContentEncoding.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		public override unsafe int ContentLength {
			// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3.internal.huc']/class[@name='OkHttpsURLConnection']/method[@name='getContentLength' and count(parameter)=0]"
			[Register ("getContentLength", "()I", "")]
			get {
				const string __id = "getContentLength.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		public override unsafe long ContentLengthLong {
			// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3.internal.huc']/class[@name='OkHttpsURLConnection']/method[@name='getContentLengthLong' and count(parameter)=0]"
			[Register ("getContentLengthLong", "()J", "")]
			get {
				const string __id = "getContentLengthLong.()J";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractInt64Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		public override unsafe string ContentType {
			// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3.internal.huc']/class[@name='OkHttpsURLConnection']/method[@name='getContentType' and count(parameter)=0]"
			[Register ("getContentType", "()Ljava/lang/String;", "")]
			get {
				const string __id = "getContentType.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		public override unsafe long Date {
			// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3.internal.huc']/class[@name='OkHttpsURLConnection']/method[@name='getDate' and count(parameter)=0]"
			[Register ("getDate", "()J", "")]
			get {
				const string __id = "getDate.()J";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractInt64Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		public override unsafe bool DefaultUseCaches {
			// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3.internal.huc']/class[@name='OkHttpsURLConnection']/method[@name='getDefaultUseCaches' and count(parameter)=0]"
			[Register ("getDefaultUseCaches", "()Z", "")]
			get {
				const string __id = "getDefaultUseCaches.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3.internal.huc']/class[@name='OkHttpsURLConnection']/method[@name='setDefaultUseCaches' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setDefaultUseCaches", "(Z)V", "")]
			set {
				const string __id = "setDefaultUseCaches.(Z)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		public override unsafe bool DoInput {
			// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3.internal.huc']/class[@name='OkHttpsURLConnection']/method[@name='getDoInput' and count(parameter)=0]"
			[Register ("getDoInput", "()Z", "")]
			get {
				const string __id = "getDoInput.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3.internal.huc']/class[@name='OkHttpsURLConnection']/method[@name='setDoInput' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setDoInput", "(Z)V", "")]
			set {
				const string __id = "setDoInput.(Z)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		public override unsafe bool DoOutput {
			// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3.internal.huc']/class[@name='OkHttpsURLConnection']/method[@name='getDoOutput' and count(parameter)=0]"
			[Register ("getDoOutput", "()Z", "")]
			get {
				const string __id = "getDoOutput.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3.internal.huc']/class[@name='OkHttpsURLConnection']/method[@name='setDoOutput' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setDoOutput", "(Z)V", "")]
			set {
				const string __id = "setDoOutput.(Z)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		public override unsafe global::System.IO.Stream ErrorStream {
			// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3.internal.huc']/class[@name='OkHttpsURLConnection']/method[@name='getErrorStream' and count(parameter)=0]"
			[Register ("getErrorStream", "()Ljava/io/InputStream;", "")]
			get {
				const string __id = "getErrorStream.()Ljava/io/InputStream;";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
					return global::Android.Runtime.InputStreamInvoker.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		public override unsafe long Expiration {
			// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3.internal.huc']/class[@name='OkHttpsURLConnection']/method[@name='getExpiration' and count(parameter)=0]"
			[Register ("getExpiration", "()J", "")]
			get {
				const string __id = "getExpiration.()J";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractInt64Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		public override unsafe global::Javax.Net.Ssl.IHostnameVerifier HostnameVerifier {
			// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3.internal.huc']/class[@name='OkHttpsURLConnection']/method[@name='getHostnameVerifier' and count(parameter)=0]"
			[Register ("getHostnameVerifier", "()Ljavax/net/ssl/HostnameVerifier;", "")]
			get {
				const string __id = "getHostnameVerifier.()Ljavax/net/ssl/HostnameVerifier;";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Javax.Net.Ssl.IHostnameVerifier> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3.internal.huc']/class[@name='OkHttpsURLConnection']/method[@name='setHostnameVerifier' and count(parameter)=1 and parameter[1][@type='javax.net.ssl.HostnameVerifier']]"
			[Register ("setHostnameVerifier", "(Ljavax/net/ssl/HostnameVerifier;)V", "")]
			set {
				const string __id = "setHostnameVerifier.(Ljavax/net/ssl/HostnameVerifier;)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((value == null) ? IntPtr.Zero : ((global::Java.Lang.Object) value).Handle);
					_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		public override unsafe long IfModifiedSince {
			// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3.internal.huc']/class[@name='OkHttpsURLConnection']/method[@name='getIfModifiedSince' and count(parameter)=0]"
			[Register ("getIfModifiedSince", "()J", "")]
			get {
				const string __id = "getIfModifiedSince.()J";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractInt64Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3.internal.huc']/class[@name='OkHttpsURLConnection']/method[@name='setIfModifiedSince' and count(parameter)=1 and parameter[1][@type='long']]"
			[Register ("setIfModifiedSince", "(J)V", "")]
			set {
				const string __id = "setIfModifiedSince.(J)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		public override unsafe global::System.IO.Stream InputStream {
			// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3.internal.huc']/class[@name='OkHttpsURLConnection']/method[@name='getInputStream' and count(parameter)=0]"
			[Register ("getInputStream", "()Ljava/io/InputStream;", "")]
			get {
				const string __id = "getInputStream.()Ljava/io/InputStream;";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
					return global::Android.Runtime.InputStreamInvoker.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		public override unsafe bool InstanceFollowRedirects {
			// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3.internal.huc']/class[@name='OkHttpsURLConnection']/method[@name='getInstanceFollowRedirects' and count(parameter)=0]"
			[Register ("getInstanceFollowRedirects", "()Z", "")]
			get {
				const string __id = "getInstanceFollowRedirects.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3.internal.huc']/class[@name='OkHttpsURLConnection']/method[@name='setInstanceFollowRedirects' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setInstanceFollowRedirects", "(Z)V", "")]
			set {
				const string __id = "setInstanceFollowRedirects.(Z)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		public override unsafe long LastModified {
			// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3.internal.huc']/class[@name='OkHttpsURLConnection']/method[@name='getLastModified' and count(parameter)=0]"
			[Register ("getLastModified", "()J", "")]
			get {
				const string __id = "getLastModified.()J";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractInt64Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		public override unsafe global::Java.Security.IPrincipal LocalPrincipal {
			// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3.internal.huc']/class[@name='OkHttpsURLConnection']/method[@name='getLocalPrincipal' and count(parameter)=0]"
			[Register ("getLocalPrincipal", "()Ljava/security/Principal;", "")]
			get {
				const string __id = "getLocalPrincipal.()Ljava/security/Principal;";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Java.Security.IPrincipal> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		public override unsafe global::System.IO.Stream OutputStream {
			// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3.internal.huc']/class[@name='OkHttpsURLConnection']/method[@name='getOutputStream' and count(parameter)=0]"
			[Register ("getOutputStream", "()Ljava/io/OutputStream;", "")]
			get {
				const string __id = "getOutputStream.()Ljava/io/OutputStream;";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
					return global::Android.Runtime.OutputStreamInvoker.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		public override unsafe global::Java.Security.IPrincipal PeerPrincipal {
			// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3.internal.huc']/class[@name='OkHttpsURLConnection']/method[@name='getPeerPrincipal' and count(parameter)=0]"
			[Register ("getPeerPrincipal", "()Ljava/security/Principal;", "")]
			get {
				const string __id = "getPeerPrincipal.()Ljava/security/Principal;";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Java.Security.IPrincipal> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		public override unsafe global::Java.Security.Permission Permission {
			// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3.internal.huc']/class[@name='OkHttpsURLConnection']/method[@name='getPermission' and count(parameter)=0]"
			[Register ("getPermission", "()Ljava/security/Permission;", "")]
			get {
				const string __id = "getPermission.()Ljava/security/Permission;";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Java.Security.Permission> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		public override unsafe int ReadTimeout {
			// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3.internal.huc']/class[@name='OkHttpsURLConnection']/method[@name='getReadTimeout' and count(parameter)=0]"
			[Register ("getReadTimeout", "()I", "")]
			get {
				const string __id = "getReadTimeout.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3.internal.huc']/class[@name='OkHttpsURLConnection']/method[@name='setReadTimeout' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setReadTimeout", "(I)V", "")]
			set {
				const string __id = "setReadTimeout.(I)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		public override unsafe string RequestMethod {
			// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3.internal.huc']/class[@name='OkHttpsURLConnection']/method[@name='getRequestMethod' and count(parameter)=0]"
			[Register ("getRequestMethod", "()Ljava/lang/String;", "")]
			get {
				const string __id = "getRequestMethod.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3.internal.huc']/class[@name='OkHttpsURLConnection']/method[@name='setRequestMethod' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setRequestMethod", "(Ljava/lang/String;)V", "")]
			set {
				const string __id = "setRequestMethod.(Ljava/lang/String;)V";
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_value);
					_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		public override unsafe string ResponseMessage {
			// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3.internal.huc']/class[@name='OkHttpsURLConnection']/method[@name='getResponseMessage' and count(parameter)=0]"
			[Register ("getResponseMessage", "()Ljava/lang/String;", "")]
			get {
				const string __id = "getResponseMessage.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		public override unsafe global::Javax.Net.Ssl.SSLSocketFactory SSLSocketFactory {
			// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3.internal.huc']/class[@name='OkHttpsURLConnection']/method[@name='getSSLSocketFactory' and count(parameter)=0]"
			[Register ("getSSLSocketFactory", "()Ljavax/net/ssl/SSLSocketFactory;", "")]
			get {
				const string __id = "getSSLSocketFactory.()Ljavax/net/ssl/SSLSocketFactory;";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Javax.Net.Ssl.SSLSocketFactory> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3.internal.huc']/class[@name='OkHttpsURLConnection']/method[@name='setSSLSocketFactory' and count(parameter)=1 and parameter[1][@type='javax.net.ssl.SSLSocketFactory']]"
			[Register ("setSSLSocketFactory", "(Ljavax/net/ssl/SSLSocketFactory;)V", "")]
			set {
				const string __id = "setSSLSocketFactory.(Ljavax/net/ssl/SSLSocketFactory;)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((value == null) ? IntPtr.Zero : ((global::Java.Lang.Object) value).Handle);
					_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		public override unsafe global::Java.Net.URL URL {
			// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3.internal.huc']/class[@name='OkHttpsURLConnection']/method[@name='getURL' and count(parameter)=0]"
			[Register ("getURL", "()Ljava/net/URL;", "")]
			get {
				const string __id = "getURL.()Ljava/net/URL;";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Java.Net.URL> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		public override unsafe bool UseCaches {
			// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3.internal.huc']/class[@name='OkHttpsURLConnection']/method[@name='getUseCaches' and count(parameter)=0]"
			[Register ("getUseCaches", "()Z", "")]
			get {
				const string __id = "getUseCaches.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3.internal.huc']/class[@name='OkHttpsURLConnection']/method[@name='setUseCaches' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setUseCaches", "(Z)V", "")]
			set {
				const string __id = "setUseCaches.(Z)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3.internal.huc']/class[@name='OkHttpsURLConnection']/method[@name='addRequestProperty' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("addRequestProperty", "(Ljava/lang/String;Ljava/lang/String;)V", "")]
		public override unsafe void AddRequestProperty (string p0, string p1)
		{
			const string __id = "addRequestProperty.(Ljava/lang/String;Ljava/lang/String;)V";
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_p0);
				__args [1] = new JniArgumentValue (native_p1);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3.internal.huc']/class[@name='OkHttpsURLConnection']/method[@name='connect' and count(parameter)=0]"
		[Register ("connect", "()V", "")]
		public override unsafe void Connect ()
		{
			const string __id = "connect.()V";
			try {
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, null);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3.internal.huc']/class[@name='OkHttpsURLConnection']/method[@name='disconnect' and count(parameter)=0]"
		[Register ("disconnect", "()V", "")]
		public override unsafe void Disconnect ()
		{
			const string __id = "disconnect.()V";
			try {
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, null);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3.internal.huc']/class[@name='OkHttpsURLConnection']/method[@name='getContent' and count(parameter)=1 and parameter[1][@type='java.lang.Class[]']]"
		[Register ("getContent", "([Ljava/lang/Class;)Ljava/lang/Object;", "")]
		public override unsafe global::Java.Lang.Object GetContent (global::Java.Lang.Class[] p0)
		{
			const string __id = "getContent.([Ljava/lang/Class;)Ljava/lang/Object;";
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_p0);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3.internal.huc']/class[@name='OkHttpsURLConnection']/method[@name='getHeaderField' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("getHeaderField", "(I)Ljava/lang/String;", "")]
		public override unsafe string GetHeaderField (int p0)
		{
			const string __id = "getHeaderField.(I)Ljava/lang/String;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (p0);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3.internal.huc']/class[@name='OkHttpsURLConnection']/method[@name='getHeaderField' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("getHeaderField", "(Ljava/lang/String;)Ljava/lang/String;", "")]
		public override unsafe string GetHeaderField (string p0)
		{
			const string __id = "getHeaderField.(Ljava/lang/String;)Ljava/lang/String;";
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_p0);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3.internal.huc']/class[@name='OkHttpsURLConnection']/method[@name='getHeaderFieldDate' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='long']]"
		[Register ("getHeaderFieldDate", "(Ljava/lang/String;J)J", "")]
		public override unsafe long GetHeaderFieldDate (string p0, long p1)
		{
			const string __id = "getHeaderFieldDate.(Ljava/lang/String;J)J";
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_p0);
				__args [1] = new JniArgumentValue (p1);
				var __rm = _members.InstanceMethods.InvokeAbstractInt64Method (__id, this, __args);
				return __rm;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3.internal.huc']/class[@name='OkHttpsURLConnection']/method[@name='getHeaderFieldInt' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='int']]"
		[Register ("getHeaderFieldInt", "(Ljava/lang/String;I)I", "")]
		public override unsafe int GetHeaderFieldInt (string p0, int p1)
		{
			const string __id = "getHeaderFieldInt.(Ljava/lang/String;I)I";
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_p0);
				__args [1] = new JniArgumentValue (p1);
				var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, __args);
				return __rm;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3.internal.huc']/class[@name='OkHttpsURLConnection']/method[@name='getHeaderFieldKey' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("getHeaderFieldKey", "(I)Ljava/lang/String;", "")]
		public override unsafe string GetHeaderFieldKey (int p0)
		{
			const string __id = "getHeaderFieldKey.(I)Ljava/lang/String;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (p0);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3.internal.huc']/class[@name='OkHttpsURLConnection']/method[@name='getHeaderFieldLong' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='long']]"
		[Register ("getHeaderFieldLong", "(Ljava/lang/String;J)J", "")]
		public override unsafe long GetHeaderFieldLong (string p0, long p1)
		{
			const string __id = "getHeaderFieldLong.(Ljava/lang/String;J)J";
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_p0);
				__args [1] = new JniArgumentValue (p1);
				var __rm = _members.InstanceMethods.InvokeAbstractInt64Method (__id, this, __args);
				return __rm;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3.internal.huc']/class[@name='OkHttpsURLConnection']/method[@name='getLocalCertificates' and count(parameter)=0]"
		[Register ("getLocalCertificates", "()[Ljava/security/cert/Certificate;", "")]
		public override unsafe global::Java.Security.Cert.Certificate[] GetLocalCertificates ()
		{
			const string __id = "getLocalCertificates.()[Ljava/security/cert/Certificate;";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
				return (global::Java.Security.Cert.Certificate[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (global::Java.Security.Cert.Certificate));
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3.internal.huc']/class[@name='OkHttpsURLConnection']/method[@name='getRequestProperty' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("getRequestProperty", "(Ljava/lang/String;)Ljava/lang/String;", "")]
		public override unsafe string GetRequestProperty (string p0)
		{
			const string __id = "getRequestProperty.(Ljava/lang/String;)Ljava/lang/String;";
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_p0);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3.internal.huc']/class[@name='OkHttpsURLConnection']/method[@name='getServerCertificates' and count(parameter)=0]"
		[Register ("getServerCertificates", "()[Ljava/security/cert/Certificate;", "")]
		public override unsafe global::Java.Security.Cert.Certificate[] GetServerCertificates ()
		{
			const string __id = "getServerCertificates.()[Ljava/security/cert/Certificate;";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
				return (global::Java.Security.Cert.Certificate[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (global::Java.Security.Cert.Certificate));
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3.internal.huc']/class[@name='OkHttpsURLConnection']/method[@name='handshake' and count(parameter)=0]"
		[Register ("handshake", "()Lokhttp3/Handshake;", "")]
		protected unsafe global::Okhttp3.Handshake Handshake ()
		{
			const string __id = "handshake.()Lokhttp3/Handshake;";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Okhttp3.Handshake> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3.internal.huc']/class[@name='OkHttpsURLConnection']/method[@name='setChunkedStreamingMode' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setChunkedStreamingMode", "(I)V", "")]
		public override unsafe void SetChunkedStreamingMode (int p0)
		{
			const string __id = "setChunkedStreamingMode.(I)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (p0);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3.internal.huc']/class[@name='OkHttpsURLConnection']/method[@name='setFixedLengthStreamingMode' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setFixedLengthStreamingMode", "(I)V", "")]
		public override unsafe void SetFixedLengthStreamingMode (int p0)
		{
			const string __id = "setFixedLengthStreamingMode.(I)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (p0);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3.internal.huc']/class[@name='OkHttpsURLConnection']/method[@name='setFixedLengthStreamingMode' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register ("setFixedLengthStreamingMode", "(J)V", "")]
		public override unsafe void SetFixedLengthStreamingMode (long p0)
		{
			const string __id = "setFixedLengthStreamingMode.(J)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (p0);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3.internal.huc']/class[@name='OkHttpsURLConnection']/method[@name='setRequestProperty' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("setRequestProperty", "(Ljava/lang/String;Ljava/lang/String;)V", "")]
		public override unsafe void SetRequestProperty (string p0, string p1)
		{
			const string __id = "setRequestProperty.(Ljava/lang/String;Ljava/lang/String;)V";
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_p0);
				__args [1] = new JniArgumentValue (native_p1);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3.internal.huc']/class[@name='OkHttpsURLConnection']/method[@name='toString' and count(parameter)=0]"
		[Register ("toString", "()Ljava/lang/String;", "")]
		public override unsafe string ToString ()
		{
			const string __id = "toString.()Ljava/lang/String;";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3.internal.huc']/class[@name='OkHttpsURLConnection']/method[@name='usingProxy' and count(parameter)=0]"
		[Register ("usingProxy", "()Z", "")]
		public override unsafe bool UsingProxy ()
		{
			const string __id = "usingProxy.()Z";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractBooleanMethod (__id, this, null);
				return __rm;
			} finally {
			}
		}

	}
}
