using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Okhttp3.Internal.Http {

	// Metadata.xml XPath interface reference: path="/api/package[@name='okhttp3.internal.http']/interface[@name='UnrepeatableRequestBody']"
	[Register ("okhttp3/internal/http/UnrepeatableRequestBody", "", "Okhttp3.Internal.Http.IUnrepeatableRequestBodyInvoker")]
	public partial interface IUnrepeatableRequestBody : IJavaObject, IJavaPeerable {

	}

	[global::Android.Runtime.Register ("okhttp3/internal/http/UnrepeatableRequestBody", DoNotGenerateAcw=true)]
	internal partial class IUnrepeatableRequestBodyInvoker : global::Java.Lang.Object, IUnrepeatableRequestBody {

		static readonly JniPeerMembers _members = new XAPeerMembers ("okhttp3/internal/http/UnrepeatableRequestBody", typeof (IUnrepeatableRequestBodyInvoker));

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

		public static IUnrepeatableRequestBody GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IUnrepeatableRequestBody> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "okhttp3.internal.http.UnrepeatableRequestBody"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IUnrepeatableRequestBodyInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

	}

}
