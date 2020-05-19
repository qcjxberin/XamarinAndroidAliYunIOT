using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Okhttp3.Internal.Framed {

	// Metadata.xml XPath interface reference: path="/api/package[@name='okhttp3.internal.framed']/interface[@name='FrameWriter']"
	[Register ("okhttp3/internal/framed/FrameWriter", "", "Okhttp3.Internal.Framed.IFrameWriterInvoker")]
	public partial interface IFrameWriter : global::Java.IO.ICloseable {

		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3.internal.framed']/interface[@name='FrameWriter']/method[@name='applyAndAckSettings' and count(parameter)=1 and parameter[1][@type='okhttp3.internal.framed.Settings']]"
		[Register ("applyAndAckSettings", "(Lokhttp3/internal/framed/Settings;)V", "GetApplyAndAckSettings_Lokhttp3_internal_framed_Settings_Handler:Okhttp3.Internal.Framed.IFrameWriterInvoker, OkHttpBinding")]
		void ApplyAndAckSettings (global::Okhttp3.Internal.Framed.Settings p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3.internal.framed']/interface[@name='FrameWriter']/method[@name='connectionPreface' and count(parameter)=0]"
		[Register ("connectionPreface", "()V", "GetConnectionPrefaceHandler:Okhttp3.Internal.Framed.IFrameWriterInvoker, OkHttpBinding")]
		void ConnectionPreface ();

		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3.internal.framed']/interface[@name='FrameWriter']/method[@name='flush' and count(parameter)=0]"
		[Register ("flush", "()V", "GetFlushHandler:Okhttp3.Internal.Framed.IFrameWriterInvoker, OkHttpBinding")]
		void Flush ();

		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3.internal.framed']/interface[@name='FrameWriter']/method[@name='goAway' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='okhttp3.internal.framed.ErrorCode'] and parameter[3][@type='byte[]']]"
		[Register ("goAway", "(ILokhttp3/internal/framed/ErrorCode;[B)V", "GetGoAway_ILokhttp3_internal_framed_ErrorCode_arrayBHandler:Okhttp3.Internal.Framed.IFrameWriterInvoker, OkHttpBinding")]
		void GoAway (int p0, global::Okhttp3.Internal.Framed.ErrorCode p1, byte[] p2);

		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3.internal.framed']/interface[@name='FrameWriter']/method[@name='headers' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='java.util.List&lt;okhttp3.internal.framed.Header&gt;']]"
		[Register ("headers", "(ILjava/util/List;)V", "GetHeaders_ILjava_util_List_Handler:Okhttp3.Internal.Framed.IFrameWriterInvoker, OkHttpBinding")]
		void Headers (int p0, global::System.Collections.Generic.IList<global::Okhttp3.Internal.Framed.Header> p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3.internal.framed']/interface[@name='FrameWriter']/method[@name='maxDataLength' and count(parameter)=0]"
		[Register ("maxDataLength", "()I", "GetMaxDataLengthHandler:Okhttp3.Internal.Framed.IFrameWriterInvoker, OkHttpBinding")]
		int MaxDataLength ();

		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3.internal.framed']/interface[@name='FrameWriter']/method[@name='ping' and count(parameter)=3 and parameter[1][@type='boolean'] and parameter[2][@type='int'] and parameter[3][@type='int']]"
		[Register ("ping", "(ZII)V", "GetPing_ZIIHandler:Okhttp3.Internal.Framed.IFrameWriterInvoker, OkHttpBinding")]
		void Ping (bool p0, int p1, int p2);

		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3.internal.framed']/interface[@name='FrameWriter']/method[@name='pushPromise' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='java.util.List&lt;okhttp3.internal.framed.Header&gt;']]"
		[Register ("pushPromise", "(IILjava/util/List;)V", "GetPushPromise_IILjava_util_List_Handler:Okhttp3.Internal.Framed.IFrameWriterInvoker, OkHttpBinding")]
		void PushPromise (int p0, int p1, global::System.Collections.Generic.IList<global::Okhttp3.Internal.Framed.Header> p2);

		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3.internal.framed']/interface[@name='FrameWriter']/method[@name='rstStream' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='okhttp3.internal.framed.ErrorCode']]"
		[Register ("rstStream", "(ILokhttp3/internal/framed/ErrorCode;)V", "GetRstStream_ILokhttp3_internal_framed_ErrorCode_Handler:Okhttp3.Internal.Framed.IFrameWriterInvoker, OkHttpBinding")]
		void RstStream (int p0, global::Okhttp3.Internal.Framed.ErrorCode p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3.internal.framed']/interface[@name='FrameWriter']/method[@name='settings' and count(parameter)=1 and parameter[1][@type='okhttp3.internal.framed.Settings']]"
		[Register ("settings", "(Lokhttp3/internal/framed/Settings;)V", "GetSettings_Lokhttp3_internal_framed_Settings_Handler:Okhttp3.Internal.Framed.IFrameWriterInvoker, OkHttpBinding")]
		void Settings (global::Okhttp3.Internal.Framed.Settings p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3.internal.framed']/interface[@name='FrameWriter']/method[@name='synReply' and count(parameter)=3 and parameter[1][@type='boolean'] and parameter[2][@type='int'] and parameter[3][@type='java.util.List&lt;okhttp3.internal.framed.Header&gt;']]"
		[Register ("synReply", "(ZILjava/util/List;)V", "GetSynReply_ZILjava_util_List_Handler:Okhttp3.Internal.Framed.IFrameWriterInvoker, OkHttpBinding")]
		void SynReply (bool p0, int p1, global::System.Collections.Generic.IList<global::Okhttp3.Internal.Framed.Header> p2);

		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3.internal.framed']/interface[@name='FrameWriter']/method[@name='synStream' and count(parameter)=5 and parameter[1][@type='boolean'] and parameter[2][@type='boolean'] and parameter[3][@type='int'] and parameter[4][@type='int'] and parameter[5][@type='java.util.List&lt;okhttp3.internal.framed.Header&gt;']]"
		[Register ("synStream", "(ZZIILjava/util/List;)V", "GetSynStream_ZZIILjava_util_List_Handler:Okhttp3.Internal.Framed.IFrameWriterInvoker, OkHttpBinding")]
		void SynStream (bool p0, bool p1, int p2, int p3, global::System.Collections.Generic.IList<global::Okhttp3.Internal.Framed.Header> p4);

		// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3.internal.framed']/interface[@name='FrameWriter']/method[@name='windowUpdate' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='long']]"
		[Register ("windowUpdate", "(IJ)V", "GetWindowUpdate_IJHandler:Okhttp3.Internal.Framed.IFrameWriterInvoker, OkHttpBinding")]
		void WindowUpdate (int p0, long p1);

	}

	[global::Android.Runtime.Register ("okhttp3/internal/framed/FrameWriter", DoNotGenerateAcw=true)]
	internal partial class IFrameWriterInvoker : global::Java.Lang.Object, IFrameWriter {

		static readonly JniPeerMembers _members = new XAPeerMembers ("okhttp3/internal/framed/FrameWriter", typeof (IFrameWriterInvoker));

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

		public static IFrameWriter GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IFrameWriter> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "okhttp3.internal.framed.FrameWriter"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IFrameWriterInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_applyAndAckSettings_Lokhttp3_internal_framed_Settings_;
#pragma warning disable 0169
		static Delegate GetApplyAndAckSettings_Lokhttp3_internal_framed_Settings_Handler ()
		{
			if (cb_applyAndAckSettings_Lokhttp3_internal_framed_Settings_ == null)
				cb_applyAndAckSettings_Lokhttp3_internal_framed_Settings_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_ApplyAndAckSettings_Lokhttp3_internal_framed_Settings_);
			return cb_applyAndAckSettings_Lokhttp3_internal_framed_Settings_;
		}

		static void n_ApplyAndAckSettings_Lokhttp3_internal_framed_Settings_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Okhttp3.Internal.Framed.IFrameWriter __this = global::Java.Lang.Object.GetObject<global::Okhttp3.Internal.Framed.IFrameWriter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Okhttp3.Internal.Framed.Settings p0 = global::Java.Lang.Object.GetObject<global::Okhttp3.Internal.Framed.Settings> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.ApplyAndAckSettings (p0);
		}
#pragma warning restore 0169

		IntPtr id_applyAndAckSettings_Lokhttp3_internal_framed_Settings_;
		public unsafe void ApplyAndAckSettings (global::Okhttp3.Internal.Framed.Settings p0)
		{
			if (id_applyAndAckSettings_Lokhttp3_internal_framed_Settings_ == IntPtr.Zero)
				id_applyAndAckSettings_Lokhttp3_internal_framed_Settings_ = JNIEnv.GetMethodID (class_ref, "applyAndAckSettings", "(Lokhttp3/internal/framed/Settings;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_applyAndAckSettings_Lokhttp3_internal_framed_Settings_, __args);
		}

		static Delegate cb_connectionPreface;
#pragma warning disable 0169
		static Delegate GetConnectionPrefaceHandler ()
		{
			if (cb_connectionPreface == null)
				cb_connectionPreface = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_ConnectionPreface);
			return cb_connectionPreface;
		}

		static void n_ConnectionPreface (IntPtr jnienv, IntPtr native__this)
		{
			global::Okhttp3.Internal.Framed.IFrameWriter __this = global::Java.Lang.Object.GetObject<global::Okhttp3.Internal.Framed.IFrameWriter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ConnectionPreface ();
		}
#pragma warning restore 0169

		IntPtr id_connectionPreface;
		public unsafe void ConnectionPreface ()
		{
			if (id_connectionPreface == IntPtr.Zero)
				id_connectionPreface = JNIEnv.GetMethodID (class_ref, "connectionPreface", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_connectionPreface);
		}

		static Delegate cb_flush;
#pragma warning disable 0169
		static Delegate GetFlushHandler ()
		{
			if (cb_flush == null)
				cb_flush = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Flush);
			return cb_flush;
		}

		static void n_Flush (IntPtr jnienv, IntPtr native__this)
		{
			global::Okhttp3.Internal.Framed.IFrameWriter __this = global::Java.Lang.Object.GetObject<global::Okhttp3.Internal.Framed.IFrameWriter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Flush ();
		}
#pragma warning restore 0169

		IntPtr id_flush;
		public unsafe void Flush ()
		{
			if (id_flush == IntPtr.Zero)
				id_flush = JNIEnv.GetMethodID (class_ref, "flush", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_flush);
		}

		static Delegate cb_goAway_ILokhttp3_internal_framed_ErrorCode_arrayB;
#pragma warning disable 0169
		static Delegate GetGoAway_ILokhttp3_internal_framed_ErrorCode_arrayBHandler ()
		{
			if (cb_goAway_ILokhttp3_internal_framed_ErrorCode_arrayB == null)
				cb_goAway_ILokhttp3_internal_framed_ErrorCode_arrayB = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int, IntPtr, IntPtr>) n_GoAway_ILokhttp3_internal_framed_ErrorCode_arrayB);
			return cb_goAway_ILokhttp3_internal_framed_ErrorCode_arrayB;
		}

		static void n_GoAway_ILokhttp3_internal_framed_ErrorCode_arrayB (IntPtr jnienv, IntPtr native__this, int p0, IntPtr native_p1, IntPtr native_p2)
		{
			global::Okhttp3.Internal.Framed.IFrameWriter __this = global::Java.Lang.Object.GetObject<global::Okhttp3.Internal.Framed.IFrameWriter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Okhttp3.Internal.Framed.ErrorCode p1 = global::Java.Lang.Object.GetObject<global::Okhttp3.Internal.Framed.ErrorCode> (native_p1, JniHandleOwnership.DoNotTransfer);
			byte[] p2 = (byte[]) JNIEnv.GetArray (native_p2, JniHandleOwnership.DoNotTransfer, typeof (byte));
			__this.GoAway (p0, p1, p2);
			if (p2 != null)
				JNIEnv.CopyArray (p2, native_p2);
		}
#pragma warning restore 0169

		IntPtr id_goAway_ILokhttp3_internal_framed_ErrorCode_arrayB;
		public unsafe void GoAway (int p0, global::Okhttp3.Internal.Framed.ErrorCode p1, byte[] p2)
		{
			if (id_goAway_ILokhttp3_internal_framed_ErrorCode_arrayB == IntPtr.Zero)
				id_goAway_ILokhttp3_internal_framed_ErrorCode_arrayB = JNIEnv.GetMethodID (class_ref, "goAway", "(ILokhttp3/internal/framed/ErrorCode;[B)V");
			IntPtr native_p2 = JNIEnv.NewArray (p2);
			JValue* __args = stackalloc JValue [3];
			__args [0] = new JValue (p0);
			__args [1] = new JValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
			__args [2] = new JValue (native_p2);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_goAway_ILokhttp3_internal_framed_ErrorCode_arrayB, __args);
			if (p2 != null) {
				JNIEnv.CopyArray (native_p2, p2);
				JNIEnv.DeleteLocalRef (native_p2);
			}
		}

		static Delegate cb_headers_ILjava_util_List_;
#pragma warning disable 0169
		static Delegate GetHeaders_ILjava_util_List_Handler ()
		{
			if (cb_headers_ILjava_util_List_ == null)
				cb_headers_ILjava_util_List_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int, IntPtr>) n_Headers_ILjava_util_List_);
			return cb_headers_ILjava_util_List_;
		}

		static void n_Headers_ILjava_util_List_ (IntPtr jnienv, IntPtr native__this, int p0, IntPtr native_p1)
		{
			global::Okhttp3.Internal.Framed.IFrameWriter __this = global::Java.Lang.Object.GetObject<global::Okhttp3.Internal.Framed.IFrameWriter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p1 = global::Android.Runtime.JavaList<global::Okhttp3.Internal.Framed.Header>.FromJniHandle (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.Headers (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_headers_ILjava_util_List_;
		public unsafe void Headers (int p0, global::System.Collections.Generic.IList<global::Okhttp3.Internal.Framed.Header> p1)
		{
			if (id_headers_ILjava_util_List_ == IntPtr.Zero)
				id_headers_ILjava_util_List_ = JNIEnv.GetMethodID (class_ref, "headers", "(ILjava/util/List;)V");
			IntPtr native_p1 = global::Android.Runtime.JavaList<global::Okhttp3.Internal.Framed.Header>.ToLocalJniHandle (p1);
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (native_p1);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_headers_ILjava_util_List_, __args);
			JNIEnv.DeleteLocalRef (native_p1);
		}

		static Delegate cb_maxDataLength;
#pragma warning disable 0169
		static Delegate GetMaxDataLengthHandler ()
		{
			if (cb_maxDataLength == null)
				cb_maxDataLength = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_MaxDataLength);
			return cb_maxDataLength;
		}

		static int n_MaxDataLength (IntPtr jnienv, IntPtr native__this)
		{
			global::Okhttp3.Internal.Framed.IFrameWriter __this = global::Java.Lang.Object.GetObject<global::Okhttp3.Internal.Framed.IFrameWriter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.MaxDataLength ();
		}
#pragma warning restore 0169

		IntPtr id_maxDataLength;
		public unsafe int MaxDataLength ()
		{
			if (id_maxDataLength == IntPtr.Zero)
				id_maxDataLength = JNIEnv.GetMethodID (class_ref, "maxDataLength", "()I");
			return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_maxDataLength);
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
			global::Okhttp3.Internal.Framed.IFrameWriter __this = global::Java.Lang.Object.GetObject<global::Okhttp3.Internal.Framed.IFrameWriter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			global::Okhttp3.Internal.Framed.IFrameWriter __this = global::Java.Lang.Object.GetObject<global::Okhttp3.Internal.Framed.IFrameWriter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			global::Okhttp3.Internal.Framed.IFrameWriter __this = global::Java.Lang.Object.GetObject<global::Okhttp3.Internal.Framed.IFrameWriter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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

		static Delegate cb_settings_Lokhttp3_internal_framed_Settings_;
#pragma warning disable 0169
		static Delegate GetSettings_Lokhttp3_internal_framed_Settings_Handler ()
		{
			if (cb_settings_Lokhttp3_internal_framed_Settings_ == null)
				cb_settings_Lokhttp3_internal_framed_Settings_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_Settings_Lokhttp3_internal_framed_Settings_);
			return cb_settings_Lokhttp3_internal_framed_Settings_;
		}

		static void n_Settings_Lokhttp3_internal_framed_Settings_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Okhttp3.Internal.Framed.IFrameWriter __this = global::Java.Lang.Object.GetObject<global::Okhttp3.Internal.Framed.IFrameWriter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Okhttp3.Internal.Framed.Settings p0 = global::Java.Lang.Object.GetObject<global::Okhttp3.Internal.Framed.Settings> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Settings (p0);
		}
#pragma warning restore 0169

		IntPtr id_settings_Lokhttp3_internal_framed_Settings_;
		public unsafe void Settings (global::Okhttp3.Internal.Framed.Settings p0)
		{
			if (id_settings_Lokhttp3_internal_framed_Settings_ == IntPtr.Zero)
				id_settings_Lokhttp3_internal_framed_Settings_ = JNIEnv.GetMethodID (class_ref, "settings", "(Lokhttp3/internal/framed/Settings;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_settings_Lokhttp3_internal_framed_Settings_, __args);
		}

		static Delegate cb_synReply_ZILjava_util_List_;
#pragma warning disable 0169
		static Delegate GetSynReply_ZILjava_util_List_Handler ()
		{
			if (cb_synReply_ZILjava_util_List_ == null)
				cb_synReply_ZILjava_util_List_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool, int, IntPtr>) n_SynReply_ZILjava_util_List_);
			return cb_synReply_ZILjava_util_List_;
		}

		static void n_SynReply_ZILjava_util_List_ (IntPtr jnienv, IntPtr native__this, bool p0, int p1, IntPtr native_p2)
		{
			global::Okhttp3.Internal.Framed.IFrameWriter __this = global::Java.Lang.Object.GetObject<global::Okhttp3.Internal.Framed.IFrameWriter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p2 = global::Android.Runtime.JavaList<global::Okhttp3.Internal.Framed.Header>.FromJniHandle (native_p2, JniHandleOwnership.DoNotTransfer);
			__this.SynReply (p0, p1, p2);
		}
#pragma warning restore 0169

		IntPtr id_synReply_ZILjava_util_List_;
		public unsafe void SynReply (bool p0, int p1, global::System.Collections.Generic.IList<global::Okhttp3.Internal.Framed.Header> p2)
		{
			if (id_synReply_ZILjava_util_List_ == IntPtr.Zero)
				id_synReply_ZILjava_util_List_ = JNIEnv.GetMethodID (class_ref, "synReply", "(ZILjava/util/List;)V");
			IntPtr native_p2 = global::Android.Runtime.JavaList<global::Okhttp3.Internal.Framed.Header>.ToLocalJniHandle (p2);
			JValue* __args = stackalloc JValue [3];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (p1);
			__args [2] = new JValue (native_p2);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_synReply_ZILjava_util_List_, __args);
			JNIEnv.DeleteLocalRef (native_p2);
		}

		static Delegate cb_synStream_ZZIILjava_util_List_;
#pragma warning disable 0169
		static Delegate GetSynStream_ZZIILjava_util_List_Handler ()
		{
			if (cb_synStream_ZZIILjava_util_List_ == null)
				cb_synStream_ZZIILjava_util_List_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool, bool, int, int, IntPtr>) n_SynStream_ZZIILjava_util_List_);
			return cb_synStream_ZZIILjava_util_List_;
		}

		static void n_SynStream_ZZIILjava_util_List_ (IntPtr jnienv, IntPtr native__this, bool p0, bool p1, int p2, int p3, IntPtr native_p4)
		{
			global::Okhttp3.Internal.Framed.IFrameWriter __this = global::Java.Lang.Object.GetObject<global::Okhttp3.Internal.Framed.IFrameWriter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p4 = global::Android.Runtime.JavaList<global::Okhttp3.Internal.Framed.Header>.FromJniHandle (native_p4, JniHandleOwnership.DoNotTransfer);
			__this.SynStream (p0, p1, p2, p3, p4);
		}
#pragma warning restore 0169

		IntPtr id_synStream_ZZIILjava_util_List_;
		public unsafe void SynStream (bool p0, bool p1, int p2, int p3, global::System.Collections.Generic.IList<global::Okhttp3.Internal.Framed.Header> p4)
		{
			if (id_synStream_ZZIILjava_util_List_ == IntPtr.Zero)
				id_synStream_ZZIILjava_util_List_ = JNIEnv.GetMethodID (class_ref, "synStream", "(ZZIILjava/util/List;)V");
			IntPtr native_p4 = global::Android.Runtime.JavaList<global::Okhttp3.Internal.Framed.Header>.ToLocalJniHandle (p4);
			JValue* __args = stackalloc JValue [5];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (p1);
			__args [2] = new JValue (p2);
			__args [3] = new JValue (p3);
			__args [4] = new JValue (native_p4);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_synStream_ZZIILjava_util_List_, __args);
			JNIEnv.DeleteLocalRef (native_p4);
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
			global::Okhttp3.Internal.Framed.IFrameWriter __this = global::Java.Lang.Object.GetObject<global::Okhttp3.Internal.Framed.IFrameWriter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			global::Okhttp3.Internal.Framed.IFrameWriter __this = global::Java.Lang.Object.GetObject<global::Okhttp3.Internal.Framed.IFrameWriter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
