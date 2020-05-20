using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Okhttp3.Internal.Framed {

	// Metadata.xml XPath interface reference: path="/api/package[@name='okhttp3.internal.framed']/interface[@name='Variant']"
	[Register ("okhttp3/internal/framed/Variant", "", "Okhttp3.Internal.Framed.IVariantInvoker")]
	public partial interface IVariant : IJavaObject, IJavaPeerable {

		global::Okhttp3.Protocol Protocol {
			// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3.internal.framed']/interface[@name='Variant']/method[@name='getProtocol' and count(parameter)=0]"
			[Register ("getProtocol", "()Lokhttp3/Protocol;", "GetGetProtocolHandler:Okhttp3.Internal.Framed.IVariantInvoker, OkHttpBinding")] get;
		}

	}

	[global::Android.Runtime.Register ("okhttp3/internal/framed/Variant", DoNotGenerateAcw=true)]
	internal partial class IVariantInvoker : global::Java.Lang.Object, IVariant {

		static readonly JniPeerMembers _members = new XAPeerMembers ("okhttp3/internal/framed/Variant", typeof (IVariantInvoker));

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

		public static IVariant GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IVariant> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "okhttp3.internal.framed.Variant"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IVariantInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_getProtocol;
#pragma warning disable 0169
		static Delegate GetGetProtocolHandler ()
		{
			if (cb_getProtocol == null)
				cb_getProtocol = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetProtocol);
			return cb_getProtocol;
		}

		static IntPtr n_GetProtocol (IntPtr jnienv, IntPtr native__this)
		{
			global::Okhttp3.Internal.Framed.IVariant __this = global::Java.Lang.Object.GetObject<global::Okhttp3.Internal.Framed.IVariant> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Protocol);
		}
#pragma warning restore 0169

		IntPtr id_getProtocol;
		public unsafe global::Okhttp3.Protocol Protocol {
			get {
				if (id_getProtocol == IntPtr.Zero)
					id_getProtocol = JNIEnv.GetMethodID (class_ref, "getProtocol", "()Lokhttp3/Protocol;");
				return global::Java.Lang.Object.GetObject<global::Okhttp3.Protocol> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getProtocol), JniHandleOwnership.TransferLocalRef);
			}
		}

	}

}
