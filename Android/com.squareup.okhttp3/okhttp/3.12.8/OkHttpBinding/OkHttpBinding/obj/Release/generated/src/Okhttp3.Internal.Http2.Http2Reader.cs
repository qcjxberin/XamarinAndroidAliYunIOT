using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Okhttp3.Internal.Http2 {

	// Metadata.xml XPath class reference: path="/api/package[@name='okhttp3.internal.http2']/class[@name='Http2Reader']"
	[global::Android.Runtime.Register ("okhttp3/internal/http2/Http2Reader", DoNotGenerateAcw=true)]
	public sealed partial class Http2Reader : global::Java.Lang.Object, global::Java.IO.ICloseable {

		// Metadata.xml XPath interface reference: path="/api/package[@name='okhttp3.internal.http2']/interface[@name='Http2Reader.Handler']"
		[Register ("okhttp3/internal/http2/Http2Reader$Handler", "", "Okhttp3.Internal.Http2.Http2Reader/IHandlerInvoker")]
		public partial interface IHandler : IJavaObject, IJavaPeerable {

			// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3.internal.http2']/interface[@name='Http2Reader.Handler']/method[@name='ackSettings' and count(parameter)=0]"
			[Register ("ackSettings", "()V", "GetAckSettingsHandler:Okhttp3.Internal.Http2.Http2Reader/IHandlerInvoker, OkHttpBinding")]
			void AckSettings ();

			// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3.internal.http2']/interface[@name='Http2Reader.Handler']/method[@name='headers' and count(parameter)=4 and parameter[1][@type='boolean'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='java.util.List&lt;okhttp3.internal.http2.Header&gt;']]"
			[Register ("headers", "(ZIILjava/util/List;)V", "GetHeaders_ZIILjava_util_List_Handler:Okhttp3.Internal.Http2.Http2Reader/IHandlerInvoker, OkHttpBinding")]
			void Headers (bool p0, int p1, int p2, global::System.Collections.Generic.IList<global::Okhttp3.Internal.Http2.Header> p3);

			// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3.internal.http2']/interface[@name='Http2Reader.Handler']/method[@name='ping' and count(parameter)=3 and parameter[1][@type='boolean'] and parameter[2][@type='int'] and parameter[3][@type='int']]"
			[Register ("ping", "(ZII)V", "GetPing_ZIIHandler:Okhttp3.Internal.Http2.Http2Reader/IHandlerInvoker, OkHttpBinding")]
			void Ping (bool p0, int p1, int p2);

			// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3.internal.http2']/interface[@name='Http2Reader.Handler']/method[@name='priority' and count(parameter)=4 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='boolean']]"
			[Register ("priority", "(IIIZ)V", "GetPriority_IIIZHandler:Okhttp3.Internal.Http2.Http2Reader/IHandlerInvoker, OkHttpBinding")]
			void Priority (int p0, int p1, int p2, bool p3);

			// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3.internal.http2']/interface[@name='Http2Reader.Handler']/method[@name='pushPromise' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='java.util.List&lt;okhttp3.internal.http2.Header&gt;']]"
			[Register ("pushPromise", "(IILjava/util/List;)V", "GetPushPromise_IILjava_util_List_Handler:Okhttp3.Internal.Http2.Http2Reader/IHandlerInvoker, OkHttpBinding")]
			void PushPromise (int p0, int p1, global::System.Collections.Generic.IList<global::Okhttp3.Internal.Http2.Header> p2);

			// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3.internal.http2']/interface[@name='Http2Reader.Handler']/method[@name='rstStream' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='okhttp3.internal.http2.ErrorCode']]"
			[Register ("rstStream", "(ILokhttp3/internal/http2/ErrorCode;)V", "GetRstStream_ILokhttp3_internal_http2_ErrorCode_Handler:Okhttp3.Internal.Http2.Http2Reader/IHandlerInvoker, OkHttpBinding")]
			void RstStream (int p0, global::Okhttp3.Internal.Http2.ErrorCode p1);

			// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3.internal.http2']/interface[@name='Http2Reader.Handler']/method[@name='settings' and count(parameter)=2 and parameter[1][@type='boolean'] and parameter[2][@type='okhttp3.internal.http2.Settings']]"
			[Register ("settings", "(ZLokhttp3/internal/http2/Settings;)V", "GetSettings_ZLokhttp3_internal_http2_Settings_Handler:Okhttp3.Internal.Http2.Http2Reader/IHandlerInvoker, OkHttpBinding")]
			void Settings (bool p0, global::Okhttp3.Internal.Http2.Settings p1);

			// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3.internal.http2']/interface[@name='Http2Reader.Handler']/method[@name='windowUpdate' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='long']]"
			[Register ("windowUpdate", "(IJ)V", "GetWindowUpdate_IJHandler:Okhttp3.Internal.Http2.Http2Reader/IHandlerInvoker, OkHttpBinding")]
			void WindowUpdate (int p0, long p1);

		}

		[global::Android.Runtime.Register ("okhttp3/internal/http2/Http2Reader$Handler", DoNotGenerateAcw=true)]
		internal partial class IHandlerInvoker : global::Java.Lang.Object, IHandler {

			static readonly JniPeerMembers _members = new XAPeerMembers ("okhttp3/internal/http2/Http2Reader$Handler", typeof (IHandlerInvoker));

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

			public static IHandler GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<IHandler> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "okhttp3.internal.http2.Http2Reader.Handler"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public IHandlerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			static Delegate cb_ackSettings;
#pragma warning disable 0169
			static Delegate GetAckSettingsHandler ()
			{
				if (cb_ackSettings == null)
					cb_ackSettings = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_AckSettings);
				return cb_ackSettings;
			}

			static void n_AckSettings (IntPtr jnienv, IntPtr native__this)
			{
				global::Okhttp3.Internal.Http2.Http2Reader.IHandler __this = global::Java.Lang.Object.GetObject<global::Okhttp3.Internal.Http2.Http2Reader.IHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.AckSettings ();
			}
#pragma warning restore 0169

			IntPtr id_ackSettings;
			public unsafe void AckSettings ()
			{
				if (id_ackSettings == IntPtr.Zero)
					id_ackSettings = JNIEnv.GetMethodID (class_ref, "ackSettings", "()V");
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_ackSettings);
			}

			static Delegate cb_headers_ZIILjava_util_List_;
#pragma warning disable 0169
			static Delegate GetHeaders_ZIILjava_util_List_Handler ()
			{
				if (cb_headers_ZIILjava_util_List_ == null)
					cb_headers_ZIILjava_util_List_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool, int, int, IntPtr>) n_Headers_ZIILjava_util_List_);
				return cb_headers_ZIILjava_util_List_;
			}

			static void n_Headers_ZIILjava_util_List_ (IntPtr jnienv, IntPtr native__this, bool p0, int p1, int p2, IntPtr native_p3)
			{
				global::Okhttp3.Internal.Http2.Http2Reader.IHandler __this = global::Java.Lang.Object.GetObject<global::Okhttp3.Internal.Http2.Http2Reader.IHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				var p3 = global::Android.Runtime.JavaList<global::Okhttp3.Internal.Http2.Header>.FromJniHandle (native_p3, JniHandleOwnership.DoNotTransfer);
				__this.Headers (p0, p1, p2, p3);
			}
#pragma warning restore 0169

			IntPtr id_headers_ZIILjava_util_List_;
			public unsafe void Headers (bool p0, int p1, int p2, global::System.Collections.Generic.IList<global::Okhttp3.Internal.Http2.Header> p3)
			{
				if (id_headers_ZIILjava_util_List_ == IntPtr.Zero)
					id_headers_ZIILjava_util_List_ = JNIEnv.GetMethodID (class_ref, "headers", "(ZIILjava/util/List;)V");
				IntPtr native_p3 = global::Android.Runtime.JavaList<global::Okhttp3.Internal.Http2.Header>.ToLocalJniHandle (p3);
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (native_p3);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_headers_ZIILjava_util_List_, __args);
				JNIEnv.DeleteLocalRef (native_p3);
			}

			static Delegate cb_ping_ZII;
#pragma warning disable 0169
			static Delegate GetPing_ZIIHandler ()
			{
				if (cb_ping_ZII == null)
					cb_ping_ZII = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool, int, int>) n_Ping_ZII);
				return cb_ping_ZII;
			}

			static void n_Ping_ZII (IntPtr jnienv, IntPtr native__this, bool p0, int p1, int p2)
			{
				global::Okhttp3.Internal.Http2.Http2Reader.IHandler __this = global::Java.Lang.Object.GetObject<global::Okhttp3.Internal.Http2.Http2Reader.IHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.Ping (p0, p1, p2);
			}
#pragma warning restore 0169

			IntPtr id_ping_ZII;
			public unsafe void Ping (bool p0, int p1, int p2)
			{
				if (id_ping_ZII == IntPtr.Zero)
					id_ping_ZII = JNIEnv.GetMethodID (class_ref, "ping", "(ZII)V");
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_ping_ZII, __args);
			}

			static Delegate cb_priority_IIIZ;
#pragma warning disable 0169
			static Delegate GetPriority_IIIZHandler ()
			{
				if (cb_priority_IIIZ == null)
					cb_priority_IIIZ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int, int, int, bool>) n_Priority_IIIZ);
				return cb_priority_IIIZ;
			}

			static void n_Priority_IIIZ (IntPtr jnienv, IntPtr native__this, int p0, int p1, int p2, bool p3)
			{
				global::Okhttp3.Internal.Http2.Http2Reader.IHandler __this = global::Java.Lang.Object.GetObject<global::Okhttp3.Internal.Http2.Http2Reader.IHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.Priority (p0, p1, p2, p3);
			}
#pragma warning restore 0169

			IntPtr id_priority_IIIZ;
			public unsafe void Priority (int p0, int p1, int p2, bool p3)
			{
				if (id_priority_IIIZ == IntPtr.Zero)
					id_priority_IIIZ = JNIEnv.GetMethodID (class_ref, "priority", "(IIIZ)V");
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_priority_IIIZ, __args);
			}

			static Delegate cb_pushPromise_IILjava_util_List_;
#pragma warning disable 0169
			static Delegate GetPushPromise_IILjava_util_List_Handler ()
			{
				if (cb_pushPromise_IILjava_util_List_ == null)
					cb_pushPromise_IILjava_util_List_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int, int, IntPtr>) n_PushPromise_IILjava_util_List_);
				return cb_pushPromise_IILjava_util_List_;
			}

			static void n_PushPromise_IILjava_util_List_ (IntPtr jnienv, IntPtr native__this, int p0, int p1, IntPtr native_p2)
			{
				global::Okhttp3.Internal.Http2.Http2Reader.IHandler __this = global::Java.Lang.Object.GetObject<global::Okhttp3.Internal.Http2.Http2Reader.IHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				var p2 = global::Android.Runtime.JavaList<global::Okhttp3.Internal.Http2.Header>.FromJniHandle (native_p2, JniHandleOwnership.DoNotTransfer);
				__this.PushPromise (p0, p1, p2);
			}
#pragma warning restore 0169

			IntPtr id_pushPromise_IILjava_util_List_;
			public unsafe void PushPromise (int p0, int p1, global::System.Collections.Generic.IList<global::Okhttp3.Internal.Http2.Header> p2)
			{
				if (id_pushPromise_IILjava_util_List_ == IntPtr.Zero)
					id_pushPromise_IILjava_util_List_ = JNIEnv.GetMethodID (class_ref, "pushPromise", "(IILjava/util/List;)V");
				IntPtr native_p2 = global::Android.Runtime.JavaList<global::Okhttp3.Internal.Http2.Header>.ToLocalJniHandle (p2);
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (native_p2);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_pushPromise_IILjava_util_List_, __args);
				JNIEnv.DeleteLocalRef (native_p2);
			}

			static Delegate cb_rstStream_ILokhttp3_internal_http2_ErrorCode_;
#pragma warning disable 0169
			static Delegate GetRstStream_ILokhttp3_internal_http2_ErrorCode_Handler ()
			{
				if (cb_rstStream_ILokhttp3_internal_http2_ErrorCode_ == null)
					cb_rstStream_ILokhttp3_internal_http2_ErrorCode_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int, IntPtr>) n_RstStream_ILokhttp3_internal_http2_ErrorCode_);
				return cb_rstStream_ILokhttp3_internal_http2_ErrorCode_;
			}

			static void n_RstStream_ILokhttp3_internal_http2_ErrorCode_ (IntPtr jnienv, IntPtr native__this, int p0, IntPtr native_p1)
			{
				global::Okhttp3.Internal.Http2.Http2Reader.IHandler __this = global::Java.Lang.Object.GetObject<global::Okhttp3.Internal.Http2.Http2Reader.IHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Okhttp3.Internal.Http2.ErrorCode p1 = global::Java.Lang.Object.GetObject<global::Okhttp3.Internal.Http2.ErrorCode> (native_p1, JniHandleOwnership.DoNotTransfer);
				__this.RstStream (p0, p1);
			}
#pragma warning restore 0169

			IntPtr id_rstStream_ILokhttp3_internal_http2_ErrorCode_;
			public unsafe void RstStream (int p0, global::Okhttp3.Internal.Http2.ErrorCode p1)
			{
				if (id_rstStream_ILokhttp3_internal_http2_ErrorCode_ == IntPtr.Zero)
					id_rstStream_ILokhttp3_internal_http2_ErrorCode_ = JNIEnv.GetMethodID (class_ref, "rstStream", "(ILokhttp3/internal/http2/ErrorCode;)V");
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_rstStream_ILokhttp3_internal_http2_ErrorCode_, __args);
			}

			static Delegate cb_settings_ZLokhttp3_internal_http2_Settings_;
#pragma warning disable 0169
			static Delegate GetSettings_ZLokhttp3_internal_http2_Settings_Handler ()
			{
				if (cb_settings_ZLokhttp3_internal_http2_Settings_ == null)
					cb_settings_ZLokhttp3_internal_http2_Settings_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool, IntPtr>) n_Settings_ZLokhttp3_internal_http2_Settings_);
				return cb_settings_ZLokhttp3_internal_http2_Settings_;
			}

			static void n_Settings_ZLokhttp3_internal_http2_Settings_ (IntPtr jnienv, IntPtr native__this, bool p0, IntPtr native_p1)
			{
				global::Okhttp3.Internal.Http2.Http2Reader.IHandler __this = global::Java.Lang.Object.GetObject<global::Okhttp3.Internal.Http2.Http2Reader.IHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Okhttp3.Internal.Http2.Settings p1 = global::Java.Lang.Object.GetObject<global::Okhttp3.Internal.Http2.Settings> (native_p1, JniHandleOwnership.DoNotTransfer);
				__this.Settings (p0, p1);
			}
#pragma warning restore 0169

			IntPtr id_settings_ZLokhttp3_internal_http2_Settings_;
			public unsafe void Settings (bool p0, global::Okhttp3.Internal.Http2.Settings p1)
			{
				if (id_settings_ZLokhttp3_internal_http2_Settings_ == IntPtr.Zero)
					id_settings_ZLokhttp3_internal_http2_Settings_ = JNIEnv.GetMethodID (class_ref, "settings", "(ZLokhttp3/internal/http2/Settings;)V");
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_settings_ZLokhttp3_internal_http2_Settings_, __args);
			}

			static Delegate cb_windowUpdate_IJ;
#pragma warning disable 0169
			static Delegate GetWindowUpdate_IJHandler ()
			{
				if (cb_windowUpdate_IJ == null)
					cb_windowUpdate_IJ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int, long>) n_WindowUpdate_IJ);
				return cb_windowUpdate_IJ;
			}

			static void n_WindowUpdate_IJ (IntPtr jnienv, IntPtr native__this, int p0, long p1)
			{
				global::Okhttp3.Internal.Http2.Http2Reader.IHandler __this = global::Java.Lang.Object.GetObject<global::Okhttp3.Internal.Http2.Http2Reader.IHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.WindowUpdate (p0, p1);
			}
#pragma warning restore 0169

			IntPtr id_windowUpdate_IJ;
			public unsafe void WindowUpdate (int p0, long p1)
			{
				if (id_windowUpdate_IJ == IntPtr.Zero)
					id_windowUpdate_IJ = JNIEnv.GetMethodID (class_ref, "windowUpdate", "(IJ)V");
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_windowUpdate_IJ, __args);
			}

		}


		static readonly JniPeerMembers _members = new XAPeerMembers ("okhttp3/internal/http2/Http2Reader", typeof (Http2Reader));
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

		internal Http2Reader (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3.internal.http2']/class[@name='Http2Reader']/method[@name='close' and count(parameter)=0]"
		[Register ("close", "()V", "")]
		public unsafe void Close ()
		{
			const string __id = "close.()V";
			try {
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, null);
			} finally {
			}
		}

	}
}
