using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Okio {

	// Metadata.xml XPath interface reference: path="/api/package[@name='okio']/interface[@name='Sink']"
	[Register ("okio/Sink", "", "Okio.ISinkInvoker")]
	public partial interface ISink : global::Java.IO.ICloseable, global::Java.IO.IFlushable {

		// Metadata.xml XPath method reference: path="/api/package[@name='okio']/interface[@name='Sink']/method[@name='close' and count(parameter)=0]"
		[Register ("close", "()V", "GetCloseHandler:Okio.ISinkInvoker, OkioBinding")]
		void Close ();

		// Metadata.xml XPath method reference: path="/api/package[@name='okio']/interface[@name='Sink']/method[@name='flush' and count(parameter)=0]"
		[Register ("flush", "()V", "GetFlushHandler:Okio.ISinkInvoker, OkioBinding")]
		void Flush ();

		// Metadata.xml XPath method reference: path="/api/package[@name='okio']/interface[@name='Sink']/method[@name='timeout' and count(parameter)=0]"
		[Register ("timeout", "()Lokio/Timeout;", "GetTimeoutHandler:Okio.ISinkInvoker, OkioBinding")]
		global::Okio.Timeout Timeout ();

		// Metadata.xml XPath method reference: path="/api/package[@name='okio']/interface[@name='Sink']/method[@name='write' and count(parameter)=2 and parameter[1][@type='okio.Buffer'] and parameter[2][@type='long']]"
		[Register ("write", "(Lokio/Buffer;J)V", "GetWrite_Lokio_Buffer_JHandler:Okio.ISinkInvoker, OkioBinding")]
		void Write (global::Okio.Buffer p0, long p1);

	}

	[global::Android.Runtime.Register ("okio/Sink", DoNotGenerateAcw=true)]
	internal partial class ISinkInvoker : global::Java.Lang.Object, ISink {

		static readonly JniPeerMembers _members = new XAPeerMembers ("okio/Sink", typeof (ISinkInvoker));

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

		public static ISink GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<ISink> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "okio.Sink"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public ISinkInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
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
			global::Okio.ISink __this = global::Java.Lang.Object.GetObject<global::Okio.ISink> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			global::Okio.ISink __this = global::Java.Lang.Object.GetObject<global::Okio.ISink> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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

		static Delegate cb_timeout;
#pragma warning disable 0169
		static Delegate GetTimeoutHandler ()
		{
			if (cb_timeout == null)
				cb_timeout = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_Timeout);
			return cb_timeout;
		}

		static IntPtr n_Timeout (IntPtr jnienv, IntPtr native__this)
		{
			global::Okio.ISink __this = global::Java.Lang.Object.GetObject<global::Okio.ISink> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Timeout ());
		}
#pragma warning restore 0169

		IntPtr id_timeout;
		public unsafe global::Okio.Timeout Timeout ()
		{
			if (id_timeout == IntPtr.Zero)
				id_timeout = JNIEnv.GetMethodID (class_ref, "timeout", "()Lokio/Timeout;");
			return global::Java.Lang.Object.GetObject<global::Okio.Timeout> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_timeout), JniHandleOwnership.TransferLocalRef);
		}

		static Delegate cb_write_Lokio_Buffer_J;
#pragma warning disable 0169
		static Delegate GetWrite_Lokio_Buffer_JHandler ()
		{
			if (cb_write_Lokio_Buffer_J == null)
				cb_write_Lokio_Buffer_J = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, long>) n_Write_Lokio_Buffer_J);
			return cb_write_Lokio_Buffer_J;
		}

		static void n_Write_Lokio_Buffer_J (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, long p1)
		{
			global::Okio.ISink __this = global::Java.Lang.Object.GetObject<global::Okio.ISink> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Okio.Buffer p0 = global::Java.Lang.Object.GetObject<global::Okio.Buffer> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Write (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_write_Lokio_Buffer_J;
		public unsafe void Write (global::Okio.Buffer p0, long p1)
		{
			if (id_write_Lokio_Buffer_J == IntPtr.Zero)
				id_write_Lokio_Buffer_J = JNIEnv.GetMethodID (class_ref, "write", "(Lokio/Buffer;J)V");
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			__args [1] = new JValue (p1);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_write_Lokio_Buffer_J, __args);
		}

	}

}
