using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Okhttp3.Internal.WS {

	// Metadata.xml XPath class reference: path="/api/package[@name='okhttp3.internal.ws']/class[@name='WebSocketReader']"
	[global::Android.Runtime.Register ("okhttp3/internal/ws/WebSocketReader", DoNotGenerateAcw=true)]
	public sealed partial class WebSocketReader : global::Java.Lang.Object {

		// Metadata.xml XPath interface reference: path="/api/package[@name='okhttp3.internal.ws']/interface[@name='WebSocketReader.FrameCallback']"
		[Register ("okhttp3/internal/ws/WebSocketReader$FrameCallback", "", "Okhttp3.Internal.WS.WebSocketReader/IFrameCallbackInvoker")]
		public partial interface IFrameCallback : IJavaObject, IJavaPeerable {

			// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3.internal.ws']/interface[@name='WebSocketReader.FrameCallback']/method[@name='onReadClose' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='java.lang.String']]"
			[Register ("onReadClose", "(ILjava/lang/String;)V", "GetOnReadClose_ILjava_lang_String_Handler:Okhttp3.Internal.WS.WebSocketReader/IFrameCallbackInvoker, OkHttpBinding")]
			void OnReadClose (int p0, string p1);

			// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3.internal.ws']/interface[@name='WebSocketReader.FrameCallback']/method[@name='onReadMessage' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("onReadMessage", "(Ljava/lang/String;)V", "GetOnReadMessage_Ljava_lang_String_Handler:Okhttp3.Internal.WS.WebSocketReader/IFrameCallbackInvoker, OkHttpBinding")]
			void OnReadMessage (string p0);

			// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3.internal.ws']/interface[@name='WebSocketReader.FrameCallback']/method[@name='onReadMessage' and count(parameter)=1 and parameter[1][@type='okio.ByteString']]"
			[Register ("onReadMessage", "(Lokio/ByteString;)V", "GetOnReadMessage_Lokio_ByteString_Handler:Okhttp3.Internal.WS.WebSocketReader/IFrameCallbackInvoker, OkHttpBinding")]
			void OnReadMessage (global::Okio.ByteString p0);

			// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3.internal.ws']/interface[@name='WebSocketReader.FrameCallback']/method[@name='onReadPing' and count(parameter)=1 and parameter[1][@type='okio.ByteString']]"
			[Register ("onReadPing", "(Lokio/ByteString;)V", "GetOnReadPing_Lokio_ByteString_Handler:Okhttp3.Internal.WS.WebSocketReader/IFrameCallbackInvoker, OkHttpBinding")]
			void OnReadPing (global::Okio.ByteString p0);

			// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3.internal.ws']/interface[@name='WebSocketReader.FrameCallback']/method[@name='onReadPong' and count(parameter)=1 and parameter[1][@type='okio.ByteString']]"
			[Register ("onReadPong", "(Lokio/ByteString;)V", "GetOnReadPong_Lokio_ByteString_Handler:Okhttp3.Internal.WS.WebSocketReader/IFrameCallbackInvoker, OkHttpBinding")]
			void OnReadPong (global::Okio.ByteString p0);

		}

		[global::Android.Runtime.Register ("okhttp3/internal/ws/WebSocketReader$FrameCallback", DoNotGenerateAcw=true)]
		internal partial class IFrameCallbackInvoker : global::Java.Lang.Object, IFrameCallback {

			static readonly JniPeerMembers _members = new XAPeerMembers ("okhttp3/internal/ws/WebSocketReader$FrameCallback", typeof (IFrameCallbackInvoker));

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

			public static IFrameCallback GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<IFrameCallback> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "okhttp3.internal.ws.WebSocketReader.FrameCallback"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public IFrameCallbackInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			static Delegate cb_onReadClose_ILjava_lang_String_;
#pragma warning disable 0169
			static Delegate GetOnReadClose_ILjava_lang_String_Handler ()
			{
				if (cb_onReadClose_ILjava_lang_String_ == null)
					cb_onReadClose_ILjava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int, IntPtr>) n_OnReadClose_ILjava_lang_String_);
				return cb_onReadClose_ILjava_lang_String_;
			}

			static void n_OnReadClose_ILjava_lang_String_ (IntPtr jnienv, IntPtr native__this, int p0, IntPtr native_p1)
			{
				global::Okhttp3.Internal.WS.WebSocketReader.IFrameCallback __this = global::Java.Lang.Object.GetObject<global::Okhttp3.Internal.WS.WebSocketReader.IFrameCallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
				__this.OnReadClose (p0, p1);
			}
#pragma warning restore 0169

			IntPtr id_onReadClose_ILjava_lang_String_;
			public unsafe void OnReadClose (int p0, string p1)
			{
				if (id_onReadClose_ILjava_lang_String_ == IntPtr.Zero)
					id_onReadClose_ILjava_lang_String_ = JNIEnv.GetMethodID (class_ref, "onReadClose", "(ILjava/lang/String;)V");
				IntPtr native_p1 = JNIEnv.NewString (p1);
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onReadClose_ILjava_lang_String_, __args);
				JNIEnv.DeleteLocalRef (native_p1);
			}

			static Delegate cb_onReadMessage_Ljava_lang_String_;
#pragma warning disable 0169
			static Delegate GetOnReadMessage_Ljava_lang_String_Handler ()
			{
				if (cb_onReadMessage_Ljava_lang_String_ == null)
					cb_onReadMessage_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnReadMessage_Ljava_lang_String_);
				return cb_onReadMessage_Ljava_lang_String_;
			}

			static void n_OnReadMessage_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Okhttp3.Internal.WS.WebSocketReader.IFrameCallback __this = global::Java.Lang.Object.GetObject<global::Okhttp3.Internal.WS.WebSocketReader.IFrameCallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.OnReadMessage (p0);
			}
#pragma warning restore 0169

			IntPtr id_onReadMessage_Ljava_lang_String_;
			public unsafe void OnReadMessage (string p0)
			{
				if (id_onReadMessage_Ljava_lang_String_ == IntPtr.Zero)
					id_onReadMessage_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "onReadMessage", "(Ljava/lang/String;)V");
				IntPtr native_p0 = JNIEnv.NewString (p0);
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onReadMessage_Ljava_lang_String_, __args);
				JNIEnv.DeleteLocalRef (native_p0);
			}

			static Delegate cb_onReadMessage_Lokio_ByteString_;
#pragma warning disable 0169
			static Delegate GetOnReadMessage_Lokio_ByteString_Handler ()
			{
				if (cb_onReadMessage_Lokio_ByteString_ == null)
					cb_onReadMessage_Lokio_ByteString_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnReadMessage_Lokio_ByteString_);
				return cb_onReadMessage_Lokio_ByteString_;
			}

			static void n_OnReadMessage_Lokio_ByteString_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Okhttp3.Internal.WS.WebSocketReader.IFrameCallback __this = global::Java.Lang.Object.GetObject<global::Okhttp3.Internal.WS.WebSocketReader.IFrameCallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Okio.ByteString p0 = global::Java.Lang.Object.GetObject<global::Okio.ByteString> (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.OnReadMessage (p0);
			}
#pragma warning restore 0169

			IntPtr id_onReadMessage_Lokio_ByteString_;
			public unsafe void OnReadMessage (global::Okio.ByteString p0)
			{
				if (id_onReadMessage_Lokio_ByteString_ == IntPtr.Zero)
					id_onReadMessage_Lokio_ByteString_ = JNIEnv.GetMethodID (class_ref, "onReadMessage", "(Lokio/ByteString;)V");
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onReadMessage_Lokio_ByteString_, __args);
			}

			static Delegate cb_onReadPing_Lokio_ByteString_;
#pragma warning disable 0169
			static Delegate GetOnReadPing_Lokio_ByteString_Handler ()
			{
				if (cb_onReadPing_Lokio_ByteString_ == null)
					cb_onReadPing_Lokio_ByteString_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnReadPing_Lokio_ByteString_);
				return cb_onReadPing_Lokio_ByteString_;
			}

			static void n_OnReadPing_Lokio_ByteString_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Okhttp3.Internal.WS.WebSocketReader.IFrameCallback __this = global::Java.Lang.Object.GetObject<global::Okhttp3.Internal.WS.WebSocketReader.IFrameCallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Okio.ByteString p0 = global::Java.Lang.Object.GetObject<global::Okio.ByteString> (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.OnReadPing (p0);
			}
#pragma warning restore 0169

			IntPtr id_onReadPing_Lokio_ByteString_;
			public unsafe void OnReadPing (global::Okio.ByteString p0)
			{
				if (id_onReadPing_Lokio_ByteString_ == IntPtr.Zero)
					id_onReadPing_Lokio_ByteString_ = JNIEnv.GetMethodID (class_ref, "onReadPing", "(Lokio/ByteString;)V");
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onReadPing_Lokio_ByteString_, __args);
			}

			static Delegate cb_onReadPong_Lokio_ByteString_;
#pragma warning disable 0169
			static Delegate GetOnReadPong_Lokio_ByteString_Handler ()
			{
				if (cb_onReadPong_Lokio_ByteString_ == null)
					cb_onReadPong_Lokio_ByteString_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnReadPong_Lokio_ByteString_);
				return cb_onReadPong_Lokio_ByteString_;
			}

			static void n_OnReadPong_Lokio_ByteString_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Okhttp3.Internal.WS.WebSocketReader.IFrameCallback __this = global::Java.Lang.Object.GetObject<global::Okhttp3.Internal.WS.WebSocketReader.IFrameCallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Okio.ByteString p0 = global::Java.Lang.Object.GetObject<global::Okio.ByteString> (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.OnReadPong (p0);
			}
#pragma warning restore 0169

			IntPtr id_onReadPong_Lokio_ByteString_;
			public unsafe void OnReadPong (global::Okio.ByteString p0)
			{
				if (id_onReadPong_Lokio_ByteString_ == IntPtr.Zero)
					id_onReadPong_Lokio_ByteString_ = JNIEnv.GetMethodID (class_ref, "onReadPong", "(Lokio/ByteString;)V");
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onReadPong_Lokio_ByteString_, __args);
			}

		}


		static readonly JniPeerMembers _members = new XAPeerMembers ("okhttp3/internal/ws/WebSocketReader", typeof (WebSocketReader));
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

		internal WebSocketReader (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

	}
}
