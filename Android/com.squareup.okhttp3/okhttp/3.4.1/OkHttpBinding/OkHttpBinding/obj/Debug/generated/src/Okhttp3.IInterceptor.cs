using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Okhttp3 {

	// Metadata.xml XPath interface reference: path="/api/package[@name='okhttp3']/interface[@name='Interceptor.Chain']"
	[Register ("okhttp3/Interceptor$Chain", "", "Okhttp3.IInterceptorChainInvoker")]
	public partial interface IInterceptorChain : IJavaObject, IJavaPeerable {

		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3']/interface[@name='Interceptor.Chain']/method[@name='connection' and count(parameter)=0]"
		[Register ("connection", "()Lokhttp3/Connection;", "GetConnectionHandler:Okhttp3.IInterceptorChainInvoker, OkHttpBinding")]
		global::Okhttp3.IConnection Connection ();

		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3']/interface[@name='Interceptor.Chain']/method[@name='proceed' and count(parameter)=1 and parameter[1][@type='okhttp3.Request']]"
		[Register ("proceed", "(Lokhttp3/Request;)Lokhttp3/Response;", "GetProceed_Lokhttp3_Request_Handler:Okhttp3.IInterceptorChainInvoker, OkHttpBinding")]
		global::Okhttp3.Response Proceed (global::Okhttp3.Request p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3']/interface[@name='Interceptor.Chain']/method[@name='request' and count(parameter)=0]"
		[Register ("request", "()Lokhttp3/Request;", "GetRequestHandler:Okhttp3.IInterceptorChainInvoker, OkHttpBinding")]
		global::Okhttp3.Request Request ();

	}

	[global::Android.Runtime.Register ("okhttp3/Interceptor$Chain", DoNotGenerateAcw=true)]
	internal partial class IInterceptorChainInvoker : global::Java.Lang.Object, IInterceptorChain {

		static readonly JniPeerMembers _members = new XAPeerMembers ("okhttp3/Interceptor$Chain", typeof (IInterceptorChainInvoker));

		static IntPtr java_class_ref {
			get { return _members.JniPeerType.PeerReference.Handle; }
		}

		public override global::Java.Interop.JniPeerMembers JniPeerMembers {
			get { return _members; }
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return _members.ManagedPeerType; }
		}

		IntPtr class_ref;

		public static IInterceptorChain GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IInterceptorChain> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "okhttp3.Interceptor.Chain"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IInterceptorChainInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

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
			global::Okhttp3.IInterceptorChain __this = global::Java.Lang.Object.GetObject<global::Okhttp3.IInterceptorChain> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Connection ());
		}
#pragma warning restore 0169

		IntPtr id_connection;
		public unsafe global::Okhttp3.IConnection Connection ()
		{
			if (id_connection == IntPtr.Zero)
				id_connection = JNIEnv.GetMethodID (class_ref, "connection", "()Lokhttp3/Connection;");
			return global::Java.Lang.Object.GetObject<global::Okhttp3.IConnection> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_connection), JniHandleOwnership.TransferLocalRef);
		}

		static Delegate cb_proceed_Lokhttp3_Request_;
#pragma warning disable 0169
		static Delegate GetProceed_Lokhttp3_Request_Handler ()
		{
			if (cb_proceed_Lokhttp3_Request_ == null)
				cb_proceed_Lokhttp3_Request_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_Proceed_Lokhttp3_Request_);
			return cb_proceed_Lokhttp3_Request_;
		}

		static IntPtr n_Proceed_Lokhttp3_Request_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Okhttp3.IInterceptorChain __this = global::Java.Lang.Object.GetObject<global::Okhttp3.IInterceptorChain> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Okhttp3.Request p0 = global::Java.Lang.Object.GetObject<global::Okhttp3.Request> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Proceed (p0));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_proceed_Lokhttp3_Request_;
		public unsafe global::Okhttp3.Response Proceed (global::Okhttp3.Request p0)
		{
			if (id_proceed_Lokhttp3_Request_ == IntPtr.Zero)
				id_proceed_Lokhttp3_Request_ = JNIEnv.GetMethodID (class_ref, "proceed", "(Lokhttp3/Request;)Lokhttp3/Response;");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			global::Okhttp3.Response __ret = global::Java.Lang.Object.GetObject<global::Okhttp3.Response> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_proceed_Lokhttp3_Request_, __args), JniHandleOwnership.TransferLocalRef);
			return __ret;
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
			global::Okhttp3.IInterceptorChain __this = global::Java.Lang.Object.GetObject<global::Okhttp3.IInterceptorChain> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Request ());
		}
#pragma warning restore 0169

		IntPtr id_request;
		public unsafe global::Okhttp3.Request Request ()
		{
			if (id_request == IntPtr.Zero)
				id_request = JNIEnv.GetMethodID (class_ref, "request", "()Lokhttp3/Request;");
			return global::Java.Lang.Object.GetObject<global::Okhttp3.Request> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_request), JniHandleOwnership.TransferLocalRef);
		}

	}


	// Metadata.xml XPath interface reference: path="/api/package[@name='okhttp3']/interface[@name='Interceptor']"
	[Register ("okhttp3/Interceptor", "", "Okhttp3.IInterceptorInvoker")]
	public partial interface IInterceptor : IJavaObject, IJavaPeerable {

		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3']/interface[@name='Interceptor']/method[@name='intercept' and count(parameter)=1 and parameter[1][@type='okhttp3.Interceptor.Chain']]"
		[Register ("intercept", "(Lokhttp3/Interceptor$Chain;)Lokhttp3/Response;", "GetIntercept_Lokhttp3_Interceptor_Chain_Handler:Okhttp3.IInterceptorInvoker, OkHttpBinding")]
		global::Okhttp3.Response Intercept (global::Okhttp3.IInterceptorChain p0);

	}

	[global::Android.Runtime.Register ("okhttp3/Interceptor", DoNotGenerateAcw=true)]
	internal partial class IInterceptorInvoker : global::Java.Lang.Object, IInterceptor {

		static readonly JniPeerMembers _members = new XAPeerMembers ("okhttp3/Interceptor", typeof (IInterceptorInvoker));

		static IntPtr java_class_ref {
			get { return _members.JniPeerType.PeerReference.Handle; }
		}

		public override global::Java.Interop.JniPeerMembers JniPeerMembers {
			get { return _members; }
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return _members.ManagedPeerType; }
		}

		IntPtr class_ref;

		public static IInterceptor GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IInterceptor> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "okhttp3.Interceptor"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IInterceptorInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_intercept_Lokhttp3_Interceptor_Chain_;
#pragma warning disable 0169
		static Delegate GetIntercept_Lokhttp3_Interceptor_Chain_Handler ()
		{
			if (cb_intercept_Lokhttp3_Interceptor_Chain_ == null)
				cb_intercept_Lokhttp3_Interceptor_Chain_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_Intercept_Lokhttp3_Interceptor_Chain_);
			return cb_intercept_Lokhttp3_Interceptor_Chain_;
		}

		static IntPtr n_Intercept_Lokhttp3_Interceptor_Chain_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Okhttp3.IInterceptor __this = global::Java.Lang.Object.GetObject<global::Okhttp3.IInterceptor> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Okhttp3.IInterceptorChain p0 = (global::Okhttp3.IInterceptorChain)global::Java.Lang.Object.GetObject<global::Okhttp3.IInterceptorChain> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Intercept (p0));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_intercept_Lokhttp3_Interceptor_Chain_;
		public unsafe global::Okhttp3.Response Intercept (global::Okhttp3.IInterceptorChain p0)
		{
			if (id_intercept_Lokhttp3_Interceptor_Chain_ == IntPtr.Zero)
				id_intercept_Lokhttp3_Interceptor_Chain_ = JNIEnv.GetMethodID (class_ref, "intercept", "(Lokhttp3/Interceptor$Chain;)Lokhttp3/Response;");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			global::Okhttp3.Response __ret = global::Java.Lang.Object.GetObject<global::Okhttp3.Response> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_intercept_Lokhttp3_Interceptor_Chain_, __args), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

	}

}
