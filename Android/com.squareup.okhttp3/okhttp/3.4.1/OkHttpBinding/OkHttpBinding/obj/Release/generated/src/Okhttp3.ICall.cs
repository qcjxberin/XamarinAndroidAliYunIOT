using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Okhttp3 {

	// Metadata.xml XPath interface reference: path="/api/package[@name='okhttp3']/interface[@name='Call.Factory']"
	[Register ("okhttp3/Call$Factory", "", "Okhttp3.ICallFactoryInvoker")]
	public partial interface ICallFactory : IJavaObject, IJavaPeerable {

		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3']/interface[@name='Call.Factory']/method[@name='newCall' and count(parameter)=1 and parameter[1][@type='okhttp3.Request']]"
		[Register ("newCall", "(Lokhttp3/Request;)Lokhttp3/Call;", "GetNewCall_Lokhttp3_Request_Handler:Okhttp3.ICallFactoryInvoker, OkHttpBinding")]
		global::Okhttp3.ICall NewCall (global::Okhttp3.Request p0);

	}

	[global::Android.Runtime.Register ("okhttp3/Call$Factory", DoNotGenerateAcw=true)]
	internal partial class ICallFactoryInvoker : global::Java.Lang.Object, ICallFactory {

		static readonly JniPeerMembers _members = new XAPeerMembers ("okhttp3/Call$Factory", typeof (ICallFactoryInvoker));

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

		public static ICallFactory GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<ICallFactory> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "okhttp3.Call.Factory"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public ICallFactoryInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_newCall_Lokhttp3_Request_;
#pragma warning disable 0169
		static Delegate GetNewCall_Lokhttp3_Request_Handler ()
		{
			if (cb_newCall_Lokhttp3_Request_ == null)
				cb_newCall_Lokhttp3_Request_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_NewCall_Lokhttp3_Request_);
			return cb_newCall_Lokhttp3_Request_;
		}

		static IntPtr n_NewCall_Lokhttp3_Request_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Okhttp3.ICallFactory __this = global::Java.Lang.Object.GetObject<global::Okhttp3.ICallFactory> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Okhttp3.Request p0 = global::Java.Lang.Object.GetObject<global::Okhttp3.Request> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.NewCall (p0));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_newCall_Lokhttp3_Request_;
		public unsafe global::Okhttp3.ICall NewCall (global::Okhttp3.Request p0)
		{
			if (id_newCall_Lokhttp3_Request_ == IntPtr.Zero)
				id_newCall_Lokhttp3_Request_ = JNIEnv.GetMethodID (class_ref, "newCall", "(Lokhttp3/Request;)Lokhttp3/Call;");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			global::Okhttp3.ICall __ret = global::Java.Lang.Object.GetObject<global::Okhttp3.ICall> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_newCall_Lokhttp3_Request_, __args), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

	}


	// Metadata.xml XPath interface reference: path="/api/package[@name='okhttp3']/interface[@name='Call']"
	[Register ("okhttp3/Call", "", "Okhttp3.ICallInvoker")]
	public partial interface ICall : IJavaObject, IJavaPeerable {

		bool IsCanceled {
			// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3']/interface[@name='Call']/method[@name='isCanceled' and count(parameter)=0]"
			[Register ("isCanceled", "()Z", "GetIsCanceledHandler:Okhttp3.ICallInvoker, OkHttpBinding")] get;
		}

		bool IsExecuted {
			// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3']/interface[@name='Call']/method[@name='isExecuted' and count(parameter)=0]"
			[Register ("isExecuted", "()Z", "GetIsExecutedHandler:Okhttp3.ICallInvoker, OkHttpBinding")] get;
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3']/interface[@name='Call']/method[@name='cancel' and count(parameter)=0]"
		[Register ("cancel", "()V", "GetCancelHandler:Okhttp3.ICallInvoker, OkHttpBinding")]
		void Cancel ();

		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3']/interface[@name='Call']/method[@name='enqueue' and count(parameter)=1 and parameter[1][@type='okhttp3.Callback']]"
		[Register ("enqueue", "(Lokhttp3/Callback;)V", "GetEnqueue_Lokhttp3_Callback_Handler:Okhttp3.ICallInvoker, OkHttpBinding")]
		void Enqueue (global::Okhttp3.ICallback p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3']/interface[@name='Call']/method[@name='execute' and count(parameter)=0]"
		[Register ("execute", "()Lokhttp3/Response;", "GetExecuteHandler:Okhttp3.ICallInvoker, OkHttpBinding")]
		global::Okhttp3.Response Execute ();

		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3']/interface[@name='Call']/method[@name='request' and count(parameter)=0]"
		[Register ("request", "()Lokhttp3/Request;", "GetRequestHandler:Okhttp3.ICallInvoker, OkHttpBinding")]
		global::Okhttp3.Request Request ();

	}

	[global::Android.Runtime.Register ("okhttp3/Call", DoNotGenerateAcw=true)]
	internal partial class ICallInvoker : global::Java.Lang.Object, ICall {

		static readonly JniPeerMembers _members = new XAPeerMembers ("okhttp3/Call", typeof (ICallInvoker));

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

		public static ICall GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<ICall> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "okhttp3.Call"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public ICallInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_isCanceled;
#pragma warning disable 0169
		static Delegate GetIsCanceledHandler ()
		{
			if (cb_isCanceled == null)
				cb_isCanceled = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsCanceled);
			return cb_isCanceled;
		}

		static bool n_IsCanceled (IntPtr jnienv, IntPtr native__this)
		{
			global::Okhttp3.ICall __this = global::Java.Lang.Object.GetObject<global::Okhttp3.ICall> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsCanceled;
		}
#pragma warning restore 0169

		IntPtr id_isCanceled;
		public unsafe bool IsCanceled {
			get {
				if (id_isCanceled == IntPtr.Zero)
					id_isCanceled = JNIEnv.GetMethodID (class_ref, "isCanceled", "()Z");
				return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isCanceled);
			}
		}

		static Delegate cb_isExecuted;
#pragma warning disable 0169
		static Delegate GetIsExecutedHandler ()
		{
			if (cb_isExecuted == null)
				cb_isExecuted = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsExecuted);
			return cb_isExecuted;
		}

		static bool n_IsExecuted (IntPtr jnienv, IntPtr native__this)
		{
			global::Okhttp3.ICall __this = global::Java.Lang.Object.GetObject<global::Okhttp3.ICall> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsExecuted;
		}
#pragma warning restore 0169

		IntPtr id_isExecuted;
		public unsafe bool IsExecuted {
			get {
				if (id_isExecuted == IntPtr.Zero)
					id_isExecuted = JNIEnv.GetMethodID (class_ref, "isExecuted", "()Z");
				return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isExecuted);
			}
		}

		static Delegate cb_cancel;
#pragma warning disable 0169
		static Delegate GetCancelHandler ()
		{
			if (cb_cancel == null)
				cb_cancel = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Cancel);
			return cb_cancel;
		}

		static void n_Cancel (IntPtr jnienv, IntPtr native__this)
		{
			global::Okhttp3.ICall __this = global::Java.Lang.Object.GetObject<global::Okhttp3.ICall> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Cancel ();
		}
#pragma warning restore 0169

		IntPtr id_cancel;
		public unsafe void Cancel ()
		{
			if (id_cancel == IntPtr.Zero)
				id_cancel = JNIEnv.GetMethodID (class_ref, "cancel", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_cancel);
		}

		static Delegate cb_enqueue_Lokhttp3_Callback_;
#pragma warning disable 0169
		static Delegate GetEnqueue_Lokhttp3_Callback_Handler ()
		{
			if (cb_enqueue_Lokhttp3_Callback_ == null)
				cb_enqueue_Lokhttp3_Callback_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_Enqueue_Lokhttp3_Callback_);
			return cb_enqueue_Lokhttp3_Callback_;
		}

		static void n_Enqueue_Lokhttp3_Callback_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Okhttp3.ICall __this = global::Java.Lang.Object.GetObject<global::Okhttp3.ICall> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Okhttp3.ICallback p0 = (global::Okhttp3.ICallback)global::Java.Lang.Object.GetObject<global::Okhttp3.ICallback> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Enqueue (p0);
		}
#pragma warning restore 0169

		IntPtr id_enqueue_Lokhttp3_Callback_;
		public unsafe void Enqueue (global::Okhttp3.ICallback p0)
		{
			if (id_enqueue_Lokhttp3_Callback_ == IntPtr.Zero)
				id_enqueue_Lokhttp3_Callback_ = JNIEnv.GetMethodID (class_ref, "enqueue", "(Lokhttp3/Callback;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_enqueue_Lokhttp3_Callback_, __args);
		}

		static Delegate cb_execute;
#pragma warning disable 0169
		static Delegate GetExecuteHandler ()
		{
			if (cb_execute == null)
				cb_execute = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_Execute);
			return cb_execute;
		}

		static IntPtr n_Execute (IntPtr jnienv, IntPtr native__this)
		{
			global::Okhttp3.ICall __this = global::Java.Lang.Object.GetObject<global::Okhttp3.ICall> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Execute ());
		}
#pragma warning restore 0169

		IntPtr id_execute;
		public unsafe global::Okhttp3.Response Execute ()
		{
			if (id_execute == IntPtr.Zero)
				id_execute = JNIEnv.GetMethodID (class_ref, "execute", "()Lokhttp3/Response;");
			return global::Java.Lang.Object.GetObject<global::Okhttp3.Response> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_execute), JniHandleOwnership.TransferLocalRef);
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
			global::Okhttp3.ICall __this = global::Java.Lang.Object.GetObject<global::Okhttp3.ICall> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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

}
