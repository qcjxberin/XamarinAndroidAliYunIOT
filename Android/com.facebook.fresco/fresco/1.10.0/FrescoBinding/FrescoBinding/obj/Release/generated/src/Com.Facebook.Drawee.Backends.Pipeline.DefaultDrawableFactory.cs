using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Facebook.Drawee.Backends.Pipeline {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.facebook.drawee.backends.pipeline']/class[@name='DefaultDrawableFactory']"
	[global::Android.Runtime.Register ("com/facebook/drawee/backends/pipeline/DefaultDrawableFactory", DoNotGenerateAcw=true)]
	public partial class DefaultDrawableFactory : global::Java.Lang.Object, global::Com.Facebook.Imagepipeline.Drawable.IDrawableFactory {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/facebook/drawee/backends/pipeline/DefaultDrawableFactory", typeof (DefaultDrawableFactory));
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

		protected DefaultDrawableFactory (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.facebook.drawee.backends.pipeline']/class[@name='DefaultDrawableFactory']/constructor[@name='DefaultDrawableFactory' and count(parameter)=2 and parameter[1][@type='android.content.res.Resources'] and parameter[2][@type='com.facebook.imagepipeline.drawable.DrawableFactory']]"
		[Register (".ctor", "(Landroid/content/res/Resources;Lcom/facebook/imagepipeline/drawable/DrawableFactory;)V", "")]
		public unsafe DefaultDrawableFactory (global::Android.Content.Res.Resources resources, global::Com.Facebook.Imagepipeline.Drawable.IDrawableFactory animatedDrawableFactory)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Landroid/content/res/Resources;Lcom/facebook/imagepipeline/drawable/DrawableFactory;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((resources == null) ? IntPtr.Zero : ((global::Java.Lang.Object) resources).Handle);
				__args [1] = new JniArgumentValue ((animatedDrawableFactory == null) ? IntPtr.Zero : ((global::Java.Lang.Object) animatedDrawableFactory).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_createDrawable_Lcom_facebook_imagepipeline_image_CloseableImage_;
#pragma warning disable 0169
		static Delegate GetCreateDrawable_Lcom_facebook_imagepipeline_image_CloseableImage_Handler ()
		{
			if (cb_createDrawable_Lcom_facebook_imagepipeline_image_CloseableImage_ == null)
				cb_createDrawable_Lcom_facebook_imagepipeline_image_CloseableImage_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_CreateDrawable_Lcom_facebook_imagepipeline_image_CloseableImage_);
			return cb_createDrawable_Lcom_facebook_imagepipeline_image_CloseableImage_;
		}

		static IntPtr n_CreateDrawable_Lcom_facebook_imagepipeline_image_CloseableImage_ (IntPtr jnienv, IntPtr native__this, IntPtr native_closeableImage)
		{
			global::Com.Facebook.Drawee.Backends.Pipeline.DefaultDrawableFactory __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Drawee.Backends.Pipeline.DefaultDrawableFactory> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Facebook.Imagepipeline.Image.CloseableImage closeableImage = global::Java.Lang.Object.GetObject<global::Com.Facebook.Imagepipeline.Image.CloseableImage> (native_closeableImage, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.CreateDrawable (closeableImage));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.drawee.backends.pipeline']/class[@name='DefaultDrawableFactory']/method[@name='createDrawable' and count(parameter)=1 and parameter[1][@type='com.facebook.imagepipeline.image.CloseableImage']]"
		[Register ("createDrawable", "(Lcom/facebook/imagepipeline/image/CloseableImage;)Landroid/graphics/drawable/Drawable;", "GetCreateDrawable_Lcom_facebook_imagepipeline_image_CloseableImage_Handler")]
		public virtual unsafe global::Android.Graphics.Drawables.Drawable CreateDrawable (global::Com.Facebook.Imagepipeline.Image.CloseableImage closeableImage)
		{
			const string __id = "createDrawable.(Lcom/facebook/imagepipeline/image/CloseableImage;)Landroid/graphics/drawable/Drawable;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((closeableImage == null) ? IntPtr.Zero : ((global::Java.Lang.Object) closeableImage).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Android.Graphics.Drawables.Drawable> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_supportsImageType_Lcom_facebook_imagepipeline_image_CloseableImage_;
#pragma warning disable 0169
		static Delegate GetSupportsImageType_Lcom_facebook_imagepipeline_image_CloseableImage_Handler ()
		{
			if (cb_supportsImageType_Lcom_facebook_imagepipeline_image_CloseableImage_ == null)
				cb_supportsImageType_Lcom_facebook_imagepipeline_image_CloseableImage_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_SupportsImageType_Lcom_facebook_imagepipeline_image_CloseableImage_);
			return cb_supportsImageType_Lcom_facebook_imagepipeline_image_CloseableImage_;
		}

		static bool n_SupportsImageType_Lcom_facebook_imagepipeline_image_CloseableImage_ (IntPtr jnienv, IntPtr native__this, IntPtr native_image)
		{
			global::Com.Facebook.Drawee.Backends.Pipeline.DefaultDrawableFactory __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Drawee.Backends.Pipeline.DefaultDrawableFactory> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Facebook.Imagepipeline.Image.CloseableImage image = global::Java.Lang.Object.GetObject<global::Com.Facebook.Imagepipeline.Image.CloseableImage> (native_image, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.SupportsImageType (image);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.drawee.backends.pipeline']/class[@name='DefaultDrawableFactory']/method[@name='supportsImageType' and count(parameter)=1 and parameter[1][@type='com.facebook.imagepipeline.image.CloseableImage']]"
		[Register ("supportsImageType", "(Lcom/facebook/imagepipeline/image/CloseableImage;)Z", "GetSupportsImageType_Lcom_facebook_imagepipeline_image_CloseableImage_Handler")]
		public virtual unsafe bool SupportsImageType (global::Com.Facebook.Imagepipeline.Image.CloseableImage image)
		{
			const string __id = "supportsImageType.(Lcom/facebook/imagepipeline/image/CloseableImage;)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((image == null) ? IntPtr.Zero : ((global::Java.Lang.Object) image).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
			}
		}

	}
}
