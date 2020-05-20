using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Facebook.Drawee.Backends.Pipeline.Info {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.facebook.drawee.backends.pipeline.info']/interface[@name='ImageOriginListener']"
	[Register ("com/facebook/drawee/backends/pipeline/info/ImageOriginListener", "", "Com.Facebook.Drawee.Backends.Pipeline.Info.IImageOriginListenerInvoker")]
	public partial interface IImageOriginListener : IJavaObject, IJavaPeerable {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.drawee.backends.pipeline.info']/interface[@name='ImageOriginListener']/method[@name='onImageLoaded' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='int'] and parameter[3][@type='boolean']]"
		[Register ("onImageLoaded", "(Ljava/lang/String;IZ)V", "GetOnImageLoaded_Ljava_lang_String_IZHandler:Com.Facebook.Drawee.Backends.Pipeline.Info.IImageOriginListenerInvoker, FrescoBinding")]
		void OnImageLoaded (string p0, [global::Android.Runtime.IntDef (Type = "Com.Facebook.Drawee.Backends.Pipeline.Info.IImageOrigin", Fields = new string [] {"Unknown", "Network", "Disk", "MemoryEncoded", "MemoryBitmap"})]int p1, bool p2);

	}

	[global::Android.Runtime.Register ("com/facebook/drawee/backends/pipeline/info/ImageOriginListener", DoNotGenerateAcw=true)]
	internal partial class IImageOriginListenerInvoker : global::Java.Lang.Object, IImageOriginListener {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/facebook/drawee/backends/pipeline/info/ImageOriginListener", typeof (IImageOriginListenerInvoker));

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

		public static IImageOriginListener GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IImageOriginListener> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.facebook.drawee.backends.pipeline.info.ImageOriginListener"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IImageOriginListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_onImageLoaded_Ljava_lang_String_IZ;
#pragma warning disable 0169
		static Delegate GetOnImageLoaded_Ljava_lang_String_IZHandler ()
		{
			if (cb_onImageLoaded_Ljava_lang_String_IZ == null)
				cb_onImageLoaded_Ljava_lang_String_IZ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, int, bool>) n_OnImageLoaded_Ljava_lang_String_IZ);
			return cb_onImageLoaded_Ljava_lang_String_IZ;
		}

		static void n_OnImageLoaded_Ljava_lang_String_IZ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1, bool p2)
		{
			global::Com.Facebook.Drawee.Backends.Pipeline.Info.IImageOriginListener __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Drawee.Backends.Pipeline.Info.IImageOriginListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnImageLoaded (p0, p1, p2);
		}
#pragma warning restore 0169

		IntPtr id_onImageLoaded_Ljava_lang_String_IZ;
		public unsafe void OnImageLoaded (string p0, [global::Android.Runtime.IntDef (Type = "Com.Facebook.Drawee.Backends.Pipeline.Info.IImageOrigin", Fields = new string [] {"Unknown", "Network", "Disk", "MemoryEncoded", "MemoryBitmap"})]int p1, bool p2)
		{
			if (id_onImageLoaded_Ljava_lang_String_IZ == IntPtr.Zero)
				id_onImageLoaded_Ljava_lang_String_IZ = JNIEnv.GetMethodID (class_ref, "onImageLoaded", "(Ljava/lang/String;IZ)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			JValue* __args = stackalloc JValue [3];
			__args [0] = new JValue (native_p0);
			__args [1] = new JValue (p1);
			__args [2] = new JValue (p2);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onImageLoaded_Ljava_lang_String_IZ, __args);
			JNIEnv.DeleteLocalRef (native_p0);
		}

	}

	// event args for com.facebook.drawee.backends.pipeline.info.ImageOriginListener.onImageLoaded
	public partial class ImageOriginEventArgs : global::System.EventArgs {

		public ImageOriginEventArgs (string p0, int p1, bool p2)
		{
			this.p0 = p0;
			this.p1 = p1;
			this.p2 = p2;
		}

		string p0;
		public string P0 {
			get { return p0; }
		}

		int p1;
		public int P1 {
			get { return p1; }
		}

		bool p2;
		public bool P2 {
			get { return p2; }
		}
	}

	[global::Android.Runtime.Register ("mono/com/facebook/drawee/backends/pipeline/info/ImageOriginListenerImplementor")]
	internal sealed partial class IImageOriginListenerImplementor : global::Java.Lang.Object, IImageOriginListener {

		object sender;

		public IImageOriginListenerImplementor (object sender)
			: base (
				global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/com/facebook/drawee/backends/pipeline/info/ImageOriginListenerImplementor", "()V"),
				JniHandleOwnership.TransferLocalRef)
		{
			global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "()V");
			this.sender = sender;
		}

#pragma warning disable 0649
		public EventHandler<ImageOriginEventArgs> Handler;
#pragma warning restore 0649

		public void OnImageLoaded (string p0, [global::Android.Runtime.IntDef (Type = "Com.Facebook.Drawee.Backends.Pipeline.Info.IImageOrigin", Fields = new string [] {"Unknown", "Network", "Disk", "MemoryEncoded", "MemoryBitmap"})]int p1, bool p2)
		{
			var __h = Handler;
			if (__h != null)
				__h (sender, new ImageOriginEventArgs (p0, p1, p2));
		}

		internal static bool __IsEmpty (IImageOriginListenerImplementor value)
		{
			return value.Handler == null;
		}
	}

}
