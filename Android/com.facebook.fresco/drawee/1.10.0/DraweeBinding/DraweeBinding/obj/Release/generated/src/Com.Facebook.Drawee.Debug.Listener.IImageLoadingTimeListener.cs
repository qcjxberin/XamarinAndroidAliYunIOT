using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Facebook.Drawee.Debug.Listener {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.facebook.drawee.debug.listener']/interface[@name='ImageLoadingTimeListener']"
	[Register ("com/facebook/drawee/debug/listener/ImageLoadingTimeListener", "", "Com.Facebook.Drawee.Debug.Listener.IImageLoadingTimeListenerInvoker")]
	public partial interface IImageLoadingTimeListener : IJavaObject, IJavaPeerable {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.drawee.debug.listener']/interface[@name='ImageLoadingTimeListener']/method[@name='onFinalImageSet' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register ("onFinalImageSet", "(J)V", "GetOnFinalImageSet_JHandler:Com.Facebook.Drawee.Debug.Listener.IImageLoadingTimeListenerInvoker, DraweeBinding")]
		void OnFinalImageSet (long p0);

	}

	[global::Android.Runtime.Register ("com/facebook/drawee/debug/listener/ImageLoadingTimeListener", DoNotGenerateAcw=true)]
	internal partial class IImageLoadingTimeListenerInvoker : global::Java.Lang.Object, IImageLoadingTimeListener {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/facebook/drawee/debug/listener/ImageLoadingTimeListener", typeof (IImageLoadingTimeListenerInvoker));

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

		public static IImageLoadingTimeListener GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IImageLoadingTimeListener> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.facebook.drawee.debug.listener.ImageLoadingTimeListener"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IImageLoadingTimeListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_onFinalImageSet_J;
#pragma warning disable 0169
		static Delegate GetOnFinalImageSet_JHandler ()
		{
			if (cb_onFinalImageSet_J == null)
				cb_onFinalImageSet_J = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, long>) n_OnFinalImageSet_J);
			return cb_onFinalImageSet_J;
		}

		static void n_OnFinalImageSet_J (IntPtr jnienv, IntPtr native__this, long p0)
		{
			global::Com.Facebook.Drawee.Debug.Listener.IImageLoadingTimeListener __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Drawee.Debug.Listener.IImageLoadingTimeListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnFinalImageSet (p0);
		}
#pragma warning restore 0169

		IntPtr id_onFinalImageSet_J;
		public unsafe void OnFinalImageSet (long p0)
		{
			if (id_onFinalImageSet_J == IntPtr.Zero)
				id_onFinalImageSet_J = JNIEnv.GetMethodID (class_ref, "onFinalImageSet", "(J)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onFinalImageSet_J, __args);
		}

	}

	// event args for com.facebook.drawee.debug.listener.ImageLoadingTimeListener.onFinalImageSet
	public partial class ImageLoadingTimeEventArgs : global::System.EventArgs {

		public ImageLoadingTimeEventArgs (long p0)
		{
			this.p0 = p0;
		}

		long p0;
		public long P0 {
			get { return p0; }
		}
	}

	[global::Android.Runtime.Register ("mono/com/facebook/drawee/debug/listener/ImageLoadingTimeListenerImplementor")]
	internal sealed partial class IImageLoadingTimeListenerImplementor : global::Java.Lang.Object, IImageLoadingTimeListener {

		object sender;

		public IImageLoadingTimeListenerImplementor (object sender)
			: base (
				global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/com/facebook/drawee/debug/listener/ImageLoadingTimeListenerImplementor", "()V"),
				JniHandleOwnership.TransferLocalRef)
		{
			global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "()V");
			this.sender = sender;
		}

#pragma warning disable 0649
		public EventHandler<ImageLoadingTimeEventArgs> Handler;
#pragma warning restore 0649

		public void OnFinalImageSet (long p0)
		{
			var __h = Handler;
			if (__h != null)
				__h (sender, new ImageLoadingTimeEventArgs (p0));
		}

		internal static bool __IsEmpty (IImageLoadingTimeListenerImplementor value)
		{
			return value.Handler == null;
		}
	}

}
