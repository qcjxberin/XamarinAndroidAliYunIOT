using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Facebook.Drawee.Backends.Pipeline.Info {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.facebook.drawee.backends.pipeline.info']/interface[@name='ImagePerfDataListener']"
	[Register ("com/facebook/drawee/backends/pipeline/info/ImagePerfDataListener", "", "Com.Facebook.Drawee.Backends.Pipeline.Info.IImagePerfDataListenerInvoker")]
	public partial interface IImagePerfDataListener : IJavaObject, IJavaPeerable {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.drawee.backends.pipeline.info']/interface[@name='ImagePerfDataListener']/method[@name='onImagePerfDataUpdated' and count(parameter)=2 and parameter[1][@type='com.facebook.drawee.backends.pipeline.info.ImagePerfData'] and parameter[2][@type='int']]"
		[Register ("onImagePerfDataUpdated", "(Lcom/facebook/drawee/backends/pipeline/info/ImagePerfData;I)V", "GetOnImagePerfDataUpdated_Lcom_facebook_drawee_backends_pipeline_info_ImagePerfData_IHandler:Com.Facebook.Drawee.Backends.Pipeline.Info.IImagePerfDataListenerInvoker, FrescoBinding")]
		void OnImagePerfDataUpdated (global::Com.Facebook.Drawee.Backends.Pipeline.Info.ImagePerfData p0, [global::Android.Runtime.IntDef (Type = "Com.Facebook.Drawee.Backends.Pipeline.Info.IImageLoadStatus", Fields = new string [] {"Unknown", "Requested", "OriginAvailable", "IntermediateAvailable", "Success", "Canceled", "Error"})]int p1);

	}

	[global::Android.Runtime.Register ("com/facebook/drawee/backends/pipeline/info/ImagePerfDataListener", DoNotGenerateAcw=true)]
	internal partial class IImagePerfDataListenerInvoker : global::Java.Lang.Object, IImagePerfDataListener {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/facebook/drawee/backends/pipeline/info/ImagePerfDataListener", typeof (IImagePerfDataListenerInvoker));

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

		public static IImagePerfDataListener GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IImagePerfDataListener> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.facebook.drawee.backends.pipeline.info.ImagePerfDataListener"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IImagePerfDataListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_onImagePerfDataUpdated_Lcom_facebook_drawee_backends_pipeline_info_ImagePerfData_I;
#pragma warning disable 0169
		static Delegate GetOnImagePerfDataUpdated_Lcom_facebook_drawee_backends_pipeline_info_ImagePerfData_IHandler ()
		{
			if (cb_onImagePerfDataUpdated_Lcom_facebook_drawee_backends_pipeline_info_ImagePerfData_I == null)
				cb_onImagePerfDataUpdated_Lcom_facebook_drawee_backends_pipeline_info_ImagePerfData_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, int>) n_OnImagePerfDataUpdated_Lcom_facebook_drawee_backends_pipeline_info_ImagePerfData_I);
			return cb_onImagePerfDataUpdated_Lcom_facebook_drawee_backends_pipeline_info_ImagePerfData_I;
		}

		static void n_OnImagePerfDataUpdated_Lcom_facebook_drawee_backends_pipeline_info_ImagePerfData_I (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1)
		{
			global::Com.Facebook.Drawee.Backends.Pipeline.Info.IImagePerfDataListener __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Drawee.Backends.Pipeline.Info.IImagePerfDataListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Facebook.Drawee.Backends.Pipeline.Info.ImagePerfData p0 = global::Java.Lang.Object.GetObject<global::Com.Facebook.Drawee.Backends.Pipeline.Info.ImagePerfData> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnImagePerfDataUpdated (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_onImagePerfDataUpdated_Lcom_facebook_drawee_backends_pipeline_info_ImagePerfData_I;
		public unsafe void OnImagePerfDataUpdated (global::Com.Facebook.Drawee.Backends.Pipeline.Info.ImagePerfData p0, [global::Android.Runtime.IntDef (Type = "Com.Facebook.Drawee.Backends.Pipeline.Info.IImageLoadStatus", Fields = new string [] {"Unknown", "Requested", "OriginAvailable", "IntermediateAvailable", "Success", "Canceled", "Error"})]int p1)
		{
			if (id_onImagePerfDataUpdated_Lcom_facebook_drawee_backends_pipeline_info_ImagePerfData_I == IntPtr.Zero)
				id_onImagePerfDataUpdated_Lcom_facebook_drawee_backends_pipeline_info_ImagePerfData_I = JNIEnv.GetMethodID (class_ref, "onImagePerfDataUpdated", "(Lcom/facebook/drawee/backends/pipeline/info/ImagePerfData;I)V");
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			__args [1] = new JValue (p1);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onImagePerfDataUpdated_Lcom_facebook_drawee_backends_pipeline_info_ImagePerfData_I, __args);
		}

	}

	// event args for com.facebook.drawee.backends.pipeline.info.ImagePerfDataListener.onImagePerfDataUpdated
	public partial class ImagePerfDataEventArgs : global::System.EventArgs {

		public ImagePerfDataEventArgs (global::Com.Facebook.Drawee.Backends.Pipeline.Info.ImagePerfData p0, int p1)
		{
			this.p0 = p0;
			this.p1 = p1;
		}

		global::Com.Facebook.Drawee.Backends.Pipeline.Info.ImagePerfData p0;
		public global::Com.Facebook.Drawee.Backends.Pipeline.Info.ImagePerfData P0 {
			get { return p0; }
		}

		int p1;
		public int P1 {
			get { return p1; }
		}
	}

	[global::Android.Runtime.Register ("mono/com/facebook/drawee/backends/pipeline/info/ImagePerfDataListenerImplementor")]
	internal sealed partial class IImagePerfDataListenerImplementor : global::Java.Lang.Object, IImagePerfDataListener {

		object sender;

		public IImagePerfDataListenerImplementor (object sender)
			: base (
				global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/com/facebook/drawee/backends/pipeline/info/ImagePerfDataListenerImplementor", "()V"),
				JniHandleOwnership.TransferLocalRef)
		{
			global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "()V");
			this.sender = sender;
		}

#pragma warning disable 0649
		public EventHandler<ImagePerfDataEventArgs> Handler;
#pragma warning restore 0649

		public void OnImagePerfDataUpdated (global::Com.Facebook.Drawee.Backends.Pipeline.Info.ImagePerfData p0, [global::Android.Runtime.IntDef (Type = "Com.Facebook.Drawee.Backends.Pipeline.Info.IImageLoadStatus", Fields = new string [] {"Unknown", "Requested", "OriginAvailable", "IntermediateAvailable", "Success", "Canceled", "Error"})]int p1)
		{
			var __h = Handler;
			if (__h != null)
				__h (sender, new ImagePerfDataEventArgs (p0, p1));
		}

		internal static bool __IsEmpty (IImagePerfDataListenerImplementor value)
		{
			return value.Handler == null;
		}
	}

}
