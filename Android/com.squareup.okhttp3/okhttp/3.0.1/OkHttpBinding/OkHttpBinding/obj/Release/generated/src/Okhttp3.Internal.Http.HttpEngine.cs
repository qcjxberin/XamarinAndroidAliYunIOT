using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Okhttp3.Internal.Http {

	// Metadata.xml XPath class reference: path="/api/package[@name='okhttp3.internal.http']/class[@name='HttpEngine']"
	[global::Android.Runtime.Register ("okhttp3/internal/http/HttpEngine", DoNotGenerateAcw=true)]
	public sealed partial class HttpEngine : global::Java.Lang.Object {


		// Metadata.xml XPath field reference: path="/api/package[@name='okhttp3.internal.http']/class[@name='HttpEngine']/field[@name='MAX_FOLLOW_UPS']"
		[Register ("MAX_FOLLOW_UPS")]
		public const int MaxFollowUps = (int) 20;


		// Metadata.xml XPath field reference: path="/api/package[@name='okhttp3.internal.http']/class[@name='HttpEngine']/field[@name='bufferRequestBody']"
		[Register ("bufferRequestBody")]
		public bool BufferRequestBody {
			get {
				const string __id = "bufferRequestBody.Z";

				var __v = _members.InstanceFields.GetBooleanValue (__id, this);
				return __v;
			}
			set {
				const string __id = "bufferRequestBody.Z";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='okhttp3.internal.http']/class[@name='HttpEngine']/field[@name='streamAllocation']"
		[Register ("streamAllocation")]
		public global::Okhttp3.Internal.Http.StreamAllocation StreamAllocation {
			get {
				const string __id = "streamAllocation.Lokhttp3/internal/http/StreamAllocation;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return global::Java.Lang.Object.GetObject<global::Okhttp3.Internal.Http.StreamAllocation> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "streamAllocation.Lokhttp3/internal/http/StreamAllocation;";

				IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}
		// Metadata.xml XPath class reference: path="/api/package[@name='okhttp3.internal.http']/class[@name='HttpEngine.NetworkInterceptorChain']"
		[global::Android.Runtime.Register ("okhttp3/internal/http/HttpEngine$NetworkInterceptorChain", DoNotGenerateAcw=true)]
		public partial class NetworkInterceptorChain : global::Java.Lang.Object, global::Okhttp3.IInterceptorChain {

			static readonly JniPeerMembers _members = new XAPeerMembers ("okhttp3/internal/http/HttpEngine$NetworkInterceptorChain", typeof (NetworkInterceptorChain));
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

			protected NetworkInterceptorChain (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static Delegate cb_connection;
#pragma warning disable 0169
			static Delegate GetConnectionHandler ()
			{
				if (cb_connection == null)
					cb_connection = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_Connection);
				return cb_connection;
			}

			static IntPtr n_Connection (IntPtr jnienv, IntPtr native__this)
			{
				global::Okhttp3.Internal.Http.HttpEngine.NetworkInterceptorChain __this = global::Java.Lang.Object.GetObject<global::Okhttp3.Internal.Http.HttpEngine.NetworkInterceptorChain> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.Connection ());
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3.internal.http']/class[@name='HttpEngine.NetworkInterceptorChain']/method[@name='connection' and count(parameter)=0]"
			[Register ("connection", "()Lokhttp3/Connection;", "GetConnectionHandler")]
			public virtual unsafe global::Okhttp3.IConnection Connection ()
			{
				const string __id = "connection.()Lokhttp3/Connection;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Okhttp3.IConnection> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			static Delegate cb_proceed_Lokhttp3_Request_;
#pragma warning disable 0169
			static Delegate GetProceed_Lokhttp3_Request_Handler ()
			{
				if (cb_proceed_Lokhttp3_Request_ == null)
					cb_proceed_Lokhttp3_Request_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_Proceed_Lokhttp3_Request_);
				return cb_proceed_Lokhttp3_Request_;
			}

			static IntPtr n_Proceed_Lokhttp3_Request_ (IntPtr jnienv, IntPtr native__this, IntPtr native_request)
			{
				global::Okhttp3.Internal.Http.HttpEngine.NetworkInterceptorChain __this = global::Java.Lang.Object.GetObject<global::Okhttp3.Internal.Http.HttpEngine.NetworkInterceptorChain> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Okhttp3.Request request = global::Java.Lang.Object.GetObject<global::Okhttp3.Request> (native_request, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Proceed (request));
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3.internal.http']/class[@name='HttpEngine.NetworkInterceptorChain']/method[@name='proceed' and count(parameter)=1 and parameter[1][@type='okhttp3.Request']]"
			[Register ("proceed", "(Lokhttp3/Request;)Lokhttp3/Response;", "GetProceed_Lokhttp3_Request_Handler")]
			public virtual unsafe global::Okhttp3.Response Proceed (global::Okhttp3.Request request)
			{
				const string __id = "proceed.(Lokhttp3/Request;)Lokhttp3/Response;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((request == null) ? IntPtr.Zero : ((global::Java.Lang.Object) request).Handle);
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Okhttp3.Response> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			static Delegate cb_request;
#pragma warning disable 0169
			static Delegate GetRequestHandler ()
			{
				if (cb_request == null)
					cb_request = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_Request);
				return cb_request;
			}

			static IntPtr n_Request (IntPtr jnienv, IntPtr native__this)
			{
				global::Okhttp3.Internal.Http.HttpEngine.NetworkInterceptorChain __this = global::Java.Lang.Object.GetObject<global::Okhttp3.Internal.Http.HttpEngine.NetworkInterceptorChain> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.Request ());
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3.internal.http']/class[@name='HttpEngine.NetworkInterceptorChain']/method[@name='request' and count(parameter)=0]"
			[Register ("request", "()Lokhttp3/Request;", "GetRequestHandler")]
			public virtual unsafe global::Okhttp3.Request Request ()
			{
				const string __id = "request.()Lokhttp3/Request;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Okhttp3.Request> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("okhttp3/internal/http/HttpEngine", typeof (HttpEngine));
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

		internal HttpEngine (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		public unsafe global::Okhttp3.IConnection Connection {
			// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3.internal.http']/class[@name='HttpEngine']/method[@name='getConnection' and count(parameter)=0]"
			[Register ("getConnection", "()Lokhttp3/Connection;", "")]
			get {
				const string __id = "getConnection.()Lokhttp3/Connection;";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Okhttp3.IConnection> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		public unsafe bool HasResponse {
			// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3.internal.http']/class[@name='HttpEngine']/method[@name='hasResponse' and count(parameter)=0]"
			[Register ("hasResponse", "()Z", "")]
			get {
				const string __id = "hasResponse.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		public unsafe global::Okhttp3.Request Request {
			// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3.internal.http']/class[@name='HttpEngine']/method[@name='getRequest' and count(parameter)=0]"
			[Register ("getRequest", "()Lokhttp3/Request;", "")]
			get {
				const string __id = "getRequest.()Lokhttp3/Request;";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Okhttp3.Request> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		public unsafe global::Okhttp3.Response Response {
			// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3.internal.http']/class[@name='HttpEngine']/method[@name='getResponse' and count(parameter)=0]"
			[Register ("getResponse", "()Lokhttp3/Response;", "")]
			get {
				const string __id = "getResponse.()Lokhttp3/Response;";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Okhttp3.Response> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3.internal.http']/class[@name='HttpEngine']/method[@name='cancel' and count(parameter)=0]"
		[Register ("cancel", "()V", "")]
		public unsafe void Cancel ()
		{
			const string __id = "cancel.()V";
			try {
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, null);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3.internal.http']/class[@name='HttpEngine']/method[@name='close' and count(parameter)=0]"
		[Register ("close", "()Lokhttp3/internal/http/StreamAllocation;", "")]
		public unsafe global::Okhttp3.Internal.Http.StreamAllocation Close ()
		{
			const string __id = "close.()Lokhttp3/internal/http/StreamAllocation;";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Okhttp3.Internal.Http.StreamAllocation> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3.internal.http']/class[@name='HttpEngine']/method[@name='followUpRequest' and count(parameter)=0]"
		[Register ("followUpRequest", "()Lokhttp3/Request;", "")]
		public unsafe global::Okhttp3.Request FollowUpRequest ()
		{
			const string __id = "followUpRequest.()Lokhttp3/Request;";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Okhttp3.Request> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3.internal.http']/class[@name='HttpEngine']/method[@name='hasBody' and count(parameter)=1 and parameter[1][@type='okhttp3.Response']]"
		[Register ("hasBody", "(Lokhttp3/Response;)Z", "")]
		public static unsafe bool HasBody (global::Okhttp3.Response response)
		{
			const string __id = "hasBody.(Lokhttp3/Response;)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((response == null) ? IntPtr.Zero : ((global::Java.Lang.Object) response).Handle);
				var __rm = _members.StaticMethods.InvokeBooleanMethod (__id, __args);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3.internal.http']/class[@name='HttpEngine']/method[@name='readResponse' and count(parameter)=0]"
		[Register ("readResponse", "()V", "")]
		public unsafe void ReadResponse ()
		{
			const string __id = "readResponse.()V";
			try {
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, null);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3.internal.http']/class[@name='HttpEngine']/method[@name='receiveHeaders' and count(parameter)=1 and parameter[1][@type='okhttp3.Headers']]"
		[Register ("receiveHeaders", "(Lokhttp3/Headers;)V", "")]
		public unsafe void ReceiveHeaders (global::Okhttp3.Headers headers)
		{
			const string __id = "receiveHeaders.(Lokhttp3/Headers;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((headers == null) ? IntPtr.Zero : ((global::Java.Lang.Object) headers).Handle);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3.internal.http']/class[@name='HttpEngine']/method[@name='recover' and count(parameter)=1 and parameter[1][@type='java.io.IOException']]"
		[Register ("recover", "(Ljava/io/IOException;)Lokhttp3/internal/http/HttpEngine;", "")]
		public unsafe global::Okhttp3.Internal.Http.HttpEngine Recover (global::Java.IO.IOException e)
		{
			const string __id = "recover.(Ljava/io/IOException;)Lokhttp3/internal/http/HttpEngine;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((e == null) ? IntPtr.Zero : ((global::Java.Lang.Throwable) e).Handle);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Okhttp3.Internal.Http.HttpEngine> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3.internal.http']/class[@name='HttpEngine']/method[@name='releaseStreamAllocation' and count(parameter)=0]"
		[Register ("releaseStreamAllocation", "()V", "")]
		public unsafe void ReleaseStreamAllocation ()
		{
			const string __id = "releaseStreamAllocation.()V";
			try {
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, null);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3.internal.http']/class[@name='HttpEngine']/method[@name='sameConnection' and count(parameter)=1 and parameter[1][@type='okhttp3.HttpUrl']]"
		[Register ("sameConnection", "(Lokhttp3/HttpUrl;)Z", "")]
		public unsafe bool SameConnection (global::Okhttp3.HttpUrl followUp)
		{
			const string __id = "sameConnection.(Lokhttp3/HttpUrl;)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((followUp == null) ? IntPtr.Zero : ((global::Java.Lang.Object) followUp).Handle);
				var __rm = _members.InstanceMethods.InvokeAbstractBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3.internal.http']/class[@name='HttpEngine']/method[@name='sendRequest' and count(parameter)=0]"
		[Register ("sendRequest", "()V", "")]
		public unsafe void SendRequest ()
		{
			const string __id = "sendRequest.()V";
			try {
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, null);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3.internal.http']/class[@name='HttpEngine']/method[@name='writingRequestHeaders' and count(parameter)=0]"
		[Register ("writingRequestHeaders", "()V", "")]
		public unsafe void WritingRequestHeaders ()
		{
			const string __id = "writingRequestHeaders.()V";
			try {
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, null);
			} finally {
			}
		}

	}
}
