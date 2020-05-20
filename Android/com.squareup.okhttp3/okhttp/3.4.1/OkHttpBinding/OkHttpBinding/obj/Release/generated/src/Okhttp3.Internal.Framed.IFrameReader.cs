using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Okhttp3.Internal.Framed {

	// Metadata.xml XPath interface reference: path="/api/package[@name='okhttp3.internal.framed']/interface[@name='FrameReader.Handler']"
	[Register ("okhttp3/internal/framed/FrameReader$Handler", "", "Okhttp3.Internal.Framed.IFrameReaderHandlerInvoker")]
	public partial interface IFrameReaderHandler : IJavaObject, IJavaPeerable {

		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3.internal.framed']/interface[@name='FrameReader.Handler']/method[@name='ackSettings' and count(parameter)=0]"
		[Register ("ackSettings", "()V", "GetAckSettingsHandler:Okhttp3.Internal.Framed.IFrameReaderHandlerInvoker, OkHttpBinding")]
		void AckSettings ();

		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3.internal.framed']/interface[@name='FrameReader.Handler']/method[@name='headers' and count(parameter)=6 and parameter[1][@type='boolean'] and parameter[2][@type='boolean'] and parameter[3][@type='int'] and parameter[4][@type='int'] and parameter[5][@type='java.util.List&lt;okhttp3.internal.framed.Header&gt;'] and parameter[6][@type='okhttp3.internal.framed.HeadersMode']]"
		[Register ("headers", "(ZZIILjava/util/List;Lokhttp3/internal/framed/HeadersMode;)V", "GetHeaders_ZZIILjava_util_List_Lokhttp3_internal_framed_HeadersMode_Handler:Okhttp3.Internal.Framed.IFrameReaderHandlerInvoker, OkHttpBinding")]
		void Headers (bool p0, bool p1, int p2, int p3, global::System.Collections.Generic.IList<global::Okhttp3.Internal.Framed.Header> p4, global::Okhttp3.Internal.Framed.HeadersMode p5);

		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3.internal.framed']/interface[@name='FrameReader.Handler']/method[@name='ping' and count(parameter)=3 and parameter[1][@type='boolean'] and parameter[2][@type='int'] and parameter[3][@type='int']]"
		[Register ("ping", "(ZII)V", "GetPing_ZIIHandler:Okhttp3.Internal.Framed.IFrameReaderHandlerInvoker, OkHttpBinding")]
		void Ping (bool p0, int p1, int p2);

		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3.internal.framed']/interface[@name='FrameReader.Handler']/method[@name='priority' and count(parameter)=4 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='boolean']]"
		[Register ("priority", "(IIIZ)V", "GetPriority_IIIZHandler:Okhttp3.Internal.Framed.IFrameReaderHandlerInvoker, OkHttpBinding")]
		void Priority (int p0, int p1, int p2, bool p3);

		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3.internal.framed']/interface[@name='FrameReader.Handler']/method[@name='pushPromise' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='java.util.List&lt;okhttp3.internal.framed.Header&gt;']]"
		[Register ("pushPromise", "(IILjava/util/List;)V", "GetPushPromise_IILjava_util_List_Handler:Okhttp3.Internal.Framed.IFrameReaderHandlerInvoker, OkHttpBinding")]
		void PushPromise (int p0, int p1, global::System.Collections.Generic.IList<global::Okhttp3.Internal.Framed.Header> p2);

		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3.internal.framed']/interface[@name='FrameReader.Handler']/method[@name='rstStream' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='okhttp3.internal.framed.ErrorCode']]"
		[Register ("rstStream", "(ILokhttp3/internal/framed/ErrorCode;)V", "GetRstStream_ILokhttp3_internal_framed_ErrorCode_Handler:Okhttp3.Internal.Framed.IFrameReaderHandlerInvoker, OkHttpBinding")]
		void RstStream (int p0, global::Okhttp3.Internal.Framed.ErrorCode p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3.internal.framed']/interface[@name='FrameReader.Handler']/method[@name='settings' and count(parameter)=2 and parameter[1][@type='boolean'] and parameter[2][@type='okhttp3.internal.framed.Settings']]"
		[Register ("settings", "(ZLokhttp3/internal/framed/Settings;)V", "GetSettings_ZLokhttp3_internal_framed_Settings_Handler:Okhttp3.Internal.Framed.IFrameReaderHandlerInvoker, OkHttpBinding")]
		void Settings (bool p0, global::Okhttp3.Internal.Framed.Settings p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3.internal.framed']/interface[@name='FrameReader.Handler']/method[@name='windowUpdate' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='long']]"
		[Register ("windowUpdate", "(IJ)V", "GetWindowUpdate_IJHandler:Okhttp3.Internal.Framed.IFrameReaderHandlerInvoker, OkHttpBinding")]
		void WindowUpdate (int p0, long p1);

	}

	[global::Android.Runtime.Register ("okhttp3/internal/framed/FrameReader$Handler", DoNotGenerateAcw=true)]
	internal partial class IFrameReaderHandlerInvoker : global::Java.Lang.Object, IFrameReaderHandler {

		static readonly JniPeerMembers _members = new XAPeerMembers ("okhttp3/internal/framed/FrameReader$Handler", typeof (IFrameReaderHandlerInvoker));

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

		public static IFrameReaderHandler GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IFrameReaderHandler> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "okhttp3.internal.framed.FrameReader.Handler"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IFrameReaderHandlerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
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
			global::Okhttp3.Internal.Framed.IFrameReaderHandler __this = global::Java.Lang.Object.GetObject<global::Okhttp3.Internal.Framed.IFrameReaderHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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

		static Delegate cb_headers_ZZIILjava_util_List_Lokhttp3_internal_framed_HeadersMode_;
#pragma warning disable 0169
		static Delegate GetHeaders_ZZIILjava_util_List_Lokhttp3_internal_framed_HeadersMode_Handler ()
		{
			if (cb_headers_ZZIILjava_util_List_Lokhttp3_internal_framed_HeadersMode_ == null)
				cb_headers_ZZIILjava_util_List_Lokhttp3_internal_framed_HeadersMode_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool, bool, int, int, IntPtr, IntPtr>) n_Headers_ZZIILjava_util_List_Lokhttp3_internal_framed_HeadersMode_);
			return cb_headers_ZZIILjava_util_List_Lokhttp3_internal_framed_HeadersMode_;
		}

		static void n_Headers_ZZIILjava_util_List_Lokhttp3_internal_framed_HeadersMode_ (IntPtr jnienv, IntPtr native__this, bool p0, bool p1, int p2, int p3, IntPtr native_p4, IntPtr native_p5)
		{
			global::Okhttp3.Internal.Framed.IFrameReaderHandler __this = global::Java.Lang.Object.GetObject<global::Okhttp3.Internal.Framed.IFrameReaderHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p4 = global::Android.Runtime.JavaList<global::Okhttp3.Internal.Framed.Header>.FromJniHandle (native_p4, JniHandleOwnership.DoNotTransfer);
			global::Okhttp3.Internal.Framed.HeadersMode p5 = global::Java.Lang.Object.GetObject<global::Okhttp3.Internal.Framed.HeadersMode> (native_p5, JniHandleOwnership.DoNotTransfer);
			__this.Headers (p0, p1, p2, p3, p4, p5);
		}
#pragma warning restore 0169

		IntPtr id_headers_ZZIILjava_util_List_Lokhttp3_internal_framed_HeadersMode_;
		public unsafe void Headers (bool p0, bool p1, int p2, int p3, global::System.Collections.Generic.IList<global::Okhttp3.Internal.Framed.Header> p4, global::Okhttp3.Internal.Framed.HeadersMode p5)
		{
			if (id_headers_ZZIILjava_util_List_Lokhttp3_internal_framed_HeadersMode_ == IntPtr.Zero)
				id_headers_ZZIILjava_util_List_Lokhttp3_internal_framed_HeadersMode_ = JNIEnv.GetMethodID (class_ref, "headers", "(ZZIILjava/util/List;Lokhttp3/internal/framed/HeadersMode;)V");
			IntPtr native_p4 = global::Android.Runtime.JavaList<global::Okhttp3.Internal.Framed.Header>.ToLocalJniHandle (p4);
			JValue* __args = stackalloc JValue [6];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (p1);
			__args [2] = new JValue (p2);
			__args [3] = new JValue (p3);
			__args [4] = new JValue (native_p4);
			__args [5] = new JValue ((p5 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p5).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_headers_ZZIILjava_util_List_Lokhttp3_internal_framed_HeadersMode_, __args);
			JNIEnv.DeleteLocalRef (native_p4);
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
			global::Okhttp3.Internal.Framed.IFrameReaderHandler __this = global::Java.Lang.Object.GetObject<global::Okhttp3.Internal.Framed.IFrameReaderHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			global::Okhttp3.Internal.Framed.IFrameReaderHandler __this = global::Java.Lang.Object.GetObject<global::Okhttp3.Internal.Framed.IFrameReaderHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			global::Okhttp3.Internal.Framed.IFrameReaderHandler __this = global::Java.Lang.Object.GetObject<global::Okhttp3.Internal.Framed.IFrameReaderHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p2 = global::Android.Runtime.JavaList<global::Okhttp3.Internal.Framed.Header>.FromJniHandle (native_p2, JniHandleOwnership.DoNotTransfer);
			__this.PushPromise (p0, p1, p2);
		}
#pragma warning restore 0169

		IntPtr id_pushPromise_IILjava_util_List_;
		public unsafe void PushPromise (int p0, int p1, global::System.Collections.Generic.IList<global::Okhttp3.Internal.Framed.Header> p2)
		{
			if (id_pushPromise_IILjava_util_List_ == IntPtr.Zero)
				id_pushPromise_IILjava_util_List_ = JNIEnv.GetMethodID (class_ref, "pushPromise", "(IILjava/util/List;)V");
			IntPtr native_p2 = global::Android.Runtime.JavaList<global::Okhttp3.Internal.Framed.Header>.ToLocalJniHandle (p2);
			JValue* __args = stackalloc JValue [3];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (p1);
			__args [2] = new JValue (native_p2);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_pushPromise_IILjava_util_List_, __args);
			JNIEnv.DeleteLocalRef (native_p2);
		}

		static Delegate cb_rstStream_ILokhttp3_internal_framed_ErrorCode_;
#pragma warning disable 0169
		static Delegate GetRstStream_ILokhttp3_internal_framed_ErrorCode_Handler ()
		{
			if (cb_rstStream_ILokhttp3_internal_framed_ErrorCode_ == null)
				cb_rstStream_ILokhttp3_internal_framed_ErrorCode_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int, IntPtr>) n_RstStream_ILokhttp3_internal_framed_ErrorCode_);
			return cb_rstStream_ILokhttp3_internal_framed_ErrorCode_;
		}

		static void n_RstStream_ILokhttp3_internal_framed_ErrorCode_ (IntPtr jnienv, IntPtr native__this, int p0, IntPtr native_p1)
		{
			global::Okhttp3.Internal.Framed.IFrameReaderHandler __this = global::Java.Lang.Object.GetObject<global::Okhttp3.Internal.Framed.IFrameReaderHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Okhttp3.Internal.Framed.ErrorCode p1 = global::Java.Lang.Object.GetObject<global::Okhttp3.Internal.Framed.ErrorCode> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.RstStream (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_rstStream_ILokhttp3_internal_framed_ErrorCode_;
		public unsafe void RstStream (int p0, global::Okhttp3.Internal.Framed.ErrorCode p1)
		{
			if (id_rstStream_ILokhttp3_internal_framed_ErrorCode_ == IntPtr.Zero)
				id_rstStream_ILokhttp3_internal_framed_ErrorCode_ = JNIEnv.GetMethodID (class_ref, "rstStream", "(ILokhttp3/internal/framed/ErrorCode;)V");
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (p0);
			__args [1] = new JValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_rstStream_ILokhttp3_internal_framed_ErrorCode_, __args);
		}

		static Delegate cb_settings_ZLokhttp3_internal_framed_Settings_;
#pragma warning disable 0169
		static Delegate GetSettings_ZLokhttp3_internal_framed_Settings_Handler ()
		{
			if (cb_settings_ZLokhttp3_internal_framed_Settings_ == null)
				cb_settings_ZLokhttp3_internal_framed_Settings_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool, IntPtr>) n_Settings_ZLokhttp3_internal_framed_Settings_);
			return cb_settings_ZLokhttp3_internal_framed_Settings_;
		}

		static void n_Settings_ZLokhttp3_internal_framed_Settings_ (IntPtr jnienv, IntPtr native__this, bool p0, IntPtr native_p1)
		{
			global::Okhttp3.Internal.Framed.IFrameReaderHandler __this = global::Java.Lang.Object.GetObject<global::Okhttp3.Internal.Framed.IFrameReaderHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Okhttp3.Internal.Framed.Settings p1 = global::Java.Lang.Object.GetObject<global::Okhttp3.Internal.Framed.Settings> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.Settings (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_settings_ZLokhttp3_internal_framed_Settings_;
		public unsafe void Settings (bool p0, global::Okhttp3.Internal.Framed.Settings p1)
		{
			if (id_settings_ZLokhttp3_internal_framed_Settings_ == IntPtr.Zero)
				id_settings_ZLokhttp3_internal_framed_Settings_ = JNIEnv.GetMethodID (class_ref, "settings", "(ZLokhttp3/internal/framed/Settings;)V");
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (p0);
			__args [1] = new JValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_settings_ZLokhttp3_internal_framed_Settings_, __args);
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
			global::Okhttp3.Internal.Framed.IFrameReaderHandler __this = global::Java.Lang.Object.GetObject<global::Okhttp3.Internal.Framed.IFrameReaderHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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


	// Metadata.xml XPath interface reference: path="/api/package[@name='okhttp3.internal.framed']/interface[@name='FrameReader']"
	[Register ("okhttp3/internal/framed/FrameReader", "", "Okhttp3.Internal.Framed.IFrameReaderInvoker")]
	public partial interface IFrameReader : global::Java.IO.ICloseable {

		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3.internal.framed']/interface[@name='FrameReader']/method[@name='nextFrame' and count(parameter)=1 and parameter[1][@type='okhttp3.internal.framed.FrameReader.Handler']]"
		[Register ("nextFrame", "(Lokhttp3/internal/framed/FrameReader$Handler;)Z", "GetNextFrame_Lokhttp3_internal_framed_FrameReader_Handler_Handler:Okhttp3.Internal.Framed.IFrameReaderInvoker, OkHttpBinding")]
		bool NextFrame (global::Okhttp3.Internal.Framed.IFrameReaderHandler p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3.internal.framed']/interface[@name='FrameReader']/method[@name='readConnectionPreface' and count(parameter)=0]"
		[Register ("readConnectionPreface", "()V", "GetReadConnectionPrefaceHandler:Okhttp3.Internal.Framed.IFrameReaderInvoker, OkHttpBinding")]
		void ReadConnectionPreface ();

	}

	[global::Android.Runtime.Register ("okhttp3/internal/framed/FrameReader", DoNotGenerateAcw=true)]
	internal partial class IFrameReaderInvoker : global::Java.Lang.Object, IFrameReader {

		static readonly JniPeerMembers _members = new XAPeerMembers ("okhttp3/internal/framed/FrameReader", typeof (IFrameReaderInvoker));

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

		public static IFrameReader GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IFrameReader> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "okhttp3.internal.framed.FrameReader"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IFrameReaderInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_nextFrame_Lokhttp3_internal_framed_FrameReader_Handler_;
#pragma warning disable 0169
		static Delegate GetNextFrame_Lokhttp3_internal_framed_FrameReader_Handler_Handler ()
		{
			if (cb_nextFrame_Lokhttp3_internal_framed_FrameReader_Handler_ == null)
				cb_nextFrame_Lokhttp3_internal_framed_FrameReader_Handler_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_NextFrame_Lokhttp3_internal_framed_FrameReader_Handler_);
			return cb_nextFrame_Lokhttp3_internal_framed_FrameReader_Handler_;
		}

		static bool n_NextFrame_Lokhttp3_internal_framed_FrameReader_Handler_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Okhttp3.Internal.Framed.IFrameReader __this = global::Java.Lang.Object.GetObject<global::Okhttp3.Internal.Framed.IFrameReader> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Okhttp3.Internal.Framed.IFrameReaderHandler p0 = (global::Okhttp3.Internal.Framed.IFrameReaderHandler)global::Java.Lang.Object.GetObject<global::Okhttp3.Internal.Framed.IFrameReaderHandler> (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.NextFrame (p0);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_nextFrame_Lokhttp3_internal_framed_FrameReader_Handler_;
		public unsafe bool NextFrame (global::Okhttp3.Internal.Framed.IFrameReaderHandler p0)
		{
			if (id_nextFrame_Lokhttp3_internal_framed_FrameReader_Handler_ == IntPtr.Zero)
				id_nextFrame_Lokhttp3_internal_framed_FrameReader_Handler_ = JNIEnv.GetMethodID (class_ref, "nextFrame", "(Lokhttp3/internal/framed/FrameReader$Handler;)Z");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			bool __ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_nextFrame_Lokhttp3_internal_framed_FrameReader_Handler_, __args);
			return __ret;
		}

		static Delegate cb_readConnectionPreface;
#pragma warning disable 0169
		static Delegate GetReadConnectionPrefaceHandler ()
		{
			if (cb_readConnectionPreface == null)
				cb_readConnectionPreface = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_ReadConnectionPreface);
			return cb_readConnectionPreface;
		}

		static void n_ReadConnectionPreface (IntPtr jnienv, IntPtr native__this)
		{
			global::Okhttp3.Internal.Framed.IFrameReader __this = global::Java.Lang.Object.GetObject<global::Okhttp3.Internal.Framed.IFrameReader> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ReadConnectionPreface ();
		}
#pragma warning restore 0169

		IntPtr id_readConnectionPreface;
		public unsafe void ReadConnectionPreface ()
		{
			if (id_readConnectionPreface == IntPtr.Zero)
				id_readConnectionPreface = JNIEnv.GetMethodID (class_ref, "readConnectionPreface", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_readConnectionPreface);
		}

		static Delegate cb_close;
#pragma warning disable 0169
		static Delegate GetCloseHandler ()
		{
			if (cb_close == null)
				cb_close = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Close);
			return cb_close;
		}

		static void n_Close (IntPtr jnienv, IntPtr native__this)
		{
			global::Okhttp3.Internal.Framed.IFrameReader __this = global::Java.Lang.Object.GetObject<global::Okhttp3.Internal.Framed.IFrameReader> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Close ();
		}
#pragma warning restore 0169

		IntPtr id_close;
		public unsafe void Close ()
		{
			if (id_close == IntPtr.Zero)
				id_close = JNIEnv.GetMethodID (class_ref, "close", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_close);
		}

	}

}
