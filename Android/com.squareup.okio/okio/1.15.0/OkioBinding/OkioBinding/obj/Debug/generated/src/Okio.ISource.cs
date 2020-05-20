using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Okio {

	// Metadata.xml XPath interface reference: path="/api/package[@name='okio']/interface[@name='Source']"
	[Register ("okio/Source", "", "Okio.ISourceInvoker")]
	public partial interface ISource : global::Java.IO.ICloseable {

		// Metadata.xml XPath method reference: path="/api/package[@name='okio']/interface[@name='Source']/method[@name='close' and count(parameter)=0]"
		[Register ("close", "()V", "GetCloseHandler:Okio.ISourceInvoker, OkioBinding")]
		void Close ();

		// Metadata.xml XPath method reference: path="/api/package[@name='okio']/interface[@name='Source']/method[@name='read' and count(parameter)=2 and parameter[1][@type='okio.Buffer'] and parameter[2][@type='long']]"
		[Register ("read", "(Lokio/Buffer;J)J", "GetRead_Lokio_Buffer_JHandler:Okio.ISourceInvoker, OkioBinding")]
		long Read (global::Okio.Buffer p0, long p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='okio']/interface[@name='Source']/method[@name='timeout' and count(parameter)=0]"
		[Register ("timeout", "()Lokio/Timeout;", "GetTimeoutHandler:Okio.ISourceInvoker, OkioBinding")]
		global::Okio.Timeout Timeout ();

	}

	[global::Android.Runtime.Register ("okio/Source", DoNotGenerateAcw=true)]
	internal partial class ISourceInvoker : global::Java.Lang.Object, ISource {

		static readonly JniPeerMembers _members = new XAPeerMembers ("okio/Source", typeof (ISourceInvoker));

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

		public static ISource GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<ISource> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "okio.Source"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public ISourceInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
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
			global::Okio.ISource __this = global::Java.Lang.Object.GetObject<global::Okio.ISource> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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

		static Delegate cb_read_Lokio_Buffer_J;
#pragma warning disable 0169
		static Delegate GetRead_Lokio_Buffer_JHandler ()
		{
			if (cb_read_Lokio_Buffer_J == null)
				cb_read_Lokio_Buffer_J = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, long, long>) n_Read_Lokio_Buffer_J);
			return cb_read_Lokio_Buffer_J;
		}

		static long n_Read_Lokio_Buffer_J (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, long p1)
		{
			global::Okio.ISource __this = global::Java.Lang.Object.GetObject<global::Okio.ISource> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Okio.Buffer p0 = global::Java.Lang.Object.GetObject<global::Okio.Buffer> (native_p0, JniHandleOwnership.DoNotTransfer);
			long __ret = __this.Read (p0, p1);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_read_Lokio_Buffer_J;
		public unsafe long Read (global::Okio.Buffer p0, long p1)
		{
			if (id_read_Lokio_Buffer_J == IntPtr.Zero)
				id_read_Lokio_Buffer_J = JNIEnv.GetMethodID (class_ref, "read", "(Lokio/Buffer;J)J");
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			__args [1] = new JValue (p1);
			long __ret = JNIEnv.CallLongMethod (((global::Java.Lang.Object) this).Handle, id_read_Lokio_Buffer_J, __args);
			return __ret;
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
			global::Okio.ISource __this = global::Java.Lang.Object.GetObject<global::Okio.ISource> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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

	}

}
