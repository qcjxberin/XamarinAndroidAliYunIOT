using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Okhttp3.Internal.Http2 {

	// Metadata.xml XPath class reference: path="/api/package[@name='okhttp3.internal.http2']/class[@name='Header']"
	[global::Android.Runtime.Register ("okhttp3/internal/http2/Header", DoNotGenerateAcw=true)]
	public sealed partial class Header : global::Java.Lang.Object {


		// Metadata.xml XPath field reference: path="/api/package[@name='okhttp3.internal.http2']/class[@name='Header']/field[@name='RESPONSE_STATUS_UTF8']"
		[Register ("RESPONSE_STATUS_UTF8")]
		public const string ResponseStatusUtf8 = (string) ":status";

		// Metadata.xml XPath field reference: path="/api/package[@name='okhttp3.internal.http2']/class[@name='Header']/field[@name='TARGET_AUTHORITY_UTF8']"
		[Register ("TARGET_AUTHORITY_UTF8")]
		public const string TargetAuthorityUtf8 = (string) ":authority";

		// Metadata.xml XPath field reference: path="/api/package[@name='okhttp3.internal.http2']/class[@name='Header']/field[@name='TARGET_METHOD_UTF8']"
		[Register ("TARGET_METHOD_UTF8")]
		public const string TargetMethodUtf8 = (string) ":method";

		// Metadata.xml XPath field reference: path="/api/package[@name='okhttp3.internal.http2']/class[@name='Header']/field[@name='TARGET_PATH_UTF8']"
		[Register ("TARGET_PATH_UTF8")]
		public const string TargetPathUtf8 = (string) ":path";

		// Metadata.xml XPath field reference: path="/api/package[@name='okhttp3.internal.http2']/class[@name='Header']/field[@name='TARGET_SCHEME_UTF8']"
		[Register ("TARGET_SCHEME_UTF8")]
		public const string TargetSchemeUtf8 = (string) ":scheme";
		// Metadata.xml XPath interface reference: path="/api/package[@name='okhttp3.internal.http2']/interface[@name='Header.Listener']"
		[Register ("okhttp3/internal/http2/Header$Listener", "", "Okhttp3.Internal.Http2.Header/IListenerInvoker")]
		public partial interface IListener : IJavaObject, IJavaPeerable {

			// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3.internal.http2']/interface[@name='Header.Listener']/method[@name='onHeaders' and count(parameter)=1 and parameter[1][@type='okhttp3.Headers']]"
			[Register ("onHeaders", "(Lokhttp3/Headers;)V", "GetOnHeaders_Lokhttp3_Headers_Handler:Okhttp3.Internal.Http2.Header/IListenerInvoker, OkHttpBinding")]
			void OnHeaders (global::Okhttp3.Headers p0);

		}

		[global::Android.Runtime.Register ("okhttp3/internal/http2/Header$Listener", DoNotGenerateAcw=true)]
		internal partial class IListenerInvoker : global::Java.Lang.Object, IListener {

			static readonly JniPeerMembers _members = new XAPeerMembers ("okhttp3/internal/http2/Header$Listener", typeof (IListenerInvoker));

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

			public static IListener GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<IListener> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "okhttp3.internal.http2.Header.Listener"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public IListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			static Delegate cb_onHeaders_Lokhttp3_Headers_;
#pragma warning disable 0169
			static Delegate GetOnHeaders_Lokhttp3_Headers_Handler ()
			{
				if (cb_onHeaders_Lokhttp3_Headers_ == null)
					cb_onHeaders_Lokhttp3_Headers_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnHeaders_Lokhttp3_Headers_);
				return cb_onHeaders_Lokhttp3_Headers_;
			}

			static void n_OnHeaders_Lokhttp3_Headers_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Okhttp3.Internal.Http2.Header.IListener __this = global::Java.Lang.Object.GetObject<global::Okhttp3.Internal.Http2.Header.IListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Okhttp3.Headers p0 = global::Java.Lang.Object.GetObject<global::Okhttp3.Headers> (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.OnHeaders (p0);
			}
#pragma warning restore 0169

			IntPtr id_onHeaders_Lokhttp3_Headers_;
			public unsafe void OnHeaders (global::Okhttp3.Headers p0)
			{
				if (id_onHeaders_Lokhttp3_Headers_ == IntPtr.Zero)
					id_onHeaders_Lokhttp3_Headers_ = JNIEnv.GetMethodID (class_ref, "onHeaders", "(Lokhttp3/Headers;)V");
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onHeaders_Lokhttp3_Headers_, __args);
			}

		}

		// event args for okhttp3.internal.http2.Header.Listener.onHeaders
		public partial class EventArgs : global::System.EventArgs {

			public EventArgs (global::Okhttp3.Headers p0)
			{
				this.p0 = p0;
			}

			global::Okhttp3.Headers p0;
			public global::Okhttp3.Headers P0 {
				get { return p0; }
			}
		}

		[global::Android.Runtime.Register ("mono/okhttp3/internal/http2/Header_ListenerImplementor")]
		internal sealed partial class IListenerImplementor : global::Java.Lang.Object, IListener {

			object sender;

			public IListenerImplementor (object sender)
				: base (
					global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/okhttp3/internal/http2/Header_ListenerImplementor", "()V"),
					JniHandleOwnership.TransferLocalRef)
			{
				global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "()V");
				this.sender = sender;
			}

#pragma warning disable 0649
			public EventHandler<EventArgs> Handler;
#pragma warning restore 0649

			public void OnHeaders (global::Okhttp3.Headers p0)
			{
				var __h = Handler;
				if (__h != null)
					__h (sender, new EventArgs (p0));
			}

			internal static bool __IsEmpty (IListenerImplementor value)
			{
				return value.Handler == null;
			}
		}


		static readonly JniPeerMembers _members = new XAPeerMembers ("okhttp3/internal/http2/Header", typeof (Header));
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

		internal Header (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='okhttp3.internal.http2']/class[@name='Header']/constructor[@name='Header' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register (".ctor", "(Ljava/lang/String;Ljava/lang/String;)V", "")]
		public unsafe Header (string name, string value)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Ljava/lang/String;Ljava/lang/String;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_name = JNIEnv.NewString (name);
			IntPtr native_value = JNIEnv.NewString (value);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_name);
				__args [1] = new JniArgumentValue (native_value);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_name);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

	}
}
