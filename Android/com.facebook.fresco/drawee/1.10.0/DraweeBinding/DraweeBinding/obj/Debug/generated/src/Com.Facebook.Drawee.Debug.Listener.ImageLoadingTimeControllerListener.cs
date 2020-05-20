using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Facebook.Drawee.Debug.Listener {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.facebook.drawee.debug.listener']/class[@name='ImageLoadingTimeControllerListener']"
	[global::Android.Runtime.Register ("com/facebook/drawee/debug/listener/ImageLoadingTimeControllerListener", DoNotGenerateAcw=true)]
	public partial class ImageLoadingTimeControllerListener : global::Com.Facebook.Drawee.Controller.BaseControllerListener {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/facebook/drawee/debug/listener/ImageLoadingTimeControllerListener", typeof (ImageLoadingTimeControllerListener));
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

		protected ImageLoadingTimeControllerListener (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.facebook.drawee.debug.listener']/class[@name='ImageLoadingTimeControllerListener']/constructor[@name='ImageLoadingTimeControllerListener' and count(parameter)=1 and parameter[1][@type='com.facebook.drawee.debug.listener.ImageLoadingTimeListener']]"
		[Register (".ctor", "(Lcom/facebook/drawee/debug/listener/ImageLoadingTimeListener;)V", "")]
		public unsafe ImageLoadingTimeControllerListener (global::Com.Facebook.Drawee.Debug.Listener.IImageLoadingTimeListener imageLoadingTimeListener)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Lcom/facebook/drawee/debug/listener/ImageLoadingTimeListener;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((imageLoadingTimeListener == null) ? IntPtr.Zero : ((global::Java.Lang.Object) imageLoadingTimeListener).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_onFinalImageSet_Ljava_lang_String_Ljava_lang_Object_Landroid_graphics_drawable_Animatable_;
#pragma warning disable 0169
		static Delegate GetOnFinalImageSet_Ljava_lang_String_Ljava_lang_Object_Landroid_graphics_drawable_Animatable_Handler ()
		{
			if (cb_onFinalImageSet_Ljava_lang_String_Ljava_lang_Object_Landroid_graphics_drawable_Animatable_ == null)
				cb_onFinalImageSet_Ljava_lang_String_Ljava_lang_Object_Landroid_graphics_drawable_Animatable_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_OnFinalImageSet_Ljava_lang_String_Ljava_lang_Object_Landroid_graphics_drawable_Animatable_);
			return cb_onFinalImageSet_Ljava_lang_String_Ljava_lang_Object_Landroid_graphics_drawable_Animatable_;
		}

		static void n_OnFinalImageSet_Ljava_lang_String_Ljava_lang_Object_Landroid_graphics_drawable_Animatable_ (IntPtr jnienv, IntPtr native__this, IntPtr native_id, IntPtr native_imageInfo, IntPtr native_animatable)
		{
			global::Com.Facebook.Drawee.Debug.Listener.ImageLoadingTimeControllerListener __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Drawee.Debug.Listener.ImageLoadingTimeControllerListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string id = JNIEnv.GetString (native_id, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object imageInfo = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_imageInfo, JniHandleOwnership.DoNotTransfer);
			global::Android.Graphics.Drawables.IAnimatable animatable = (global::Android.Graphics.Drawables.IAnimatable)global::Java.Lang.Object.GetObject<global::Android.Graphics.Drawables.IAnimatable> (native_animatable, JniHandleOwnership.DoNotTransfer);
			__this.OnFinalImageSet (id, imageInfo, animatable);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.drawee.debug.listener']/class[@name='ImageLoadingTimeControllerListener']/method[@name='onFinalImageSet' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.Object'] and parameter[3][@type='android.graphics.drawable.Animatable']]"
		[Register ("onFinalImageSet", "(Ljava/lang/String;Ljava/lang/Object;Landroid/graphics/drawable/Animatable;)V", "GetOnFinalImageSet_Ljava_lang_String_Ljava_lang_Object_Landroid_graphics_drawable_Animatable_Handler")]
		public override unsafe void OnFinalImageSet (string id, global::Java.Lang.Object imageInfo, global::Android.Graphics.Drawables.IAnimatable animatable)
		{
			const string __id = "onFinalImageSet.(Ljava/lang/String;Ljava/lang/Object;Landroid/graphics/drawable/Animatable;)V";
			IntPtr native_id = JNIEnv.NewString (id);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (native_id);
				__args [1] = new JniArgumentValue ((imageInfo == null) ? IntPtr.Zero : ((global::Java.Lang.Object) imageInfo).Handle);
				__args [2] = new JniArgumentValue ((animatable == null) ? IntPtr.Zero : ((global::Java.Lang.Object) animatable).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_id);
			}
		}

	}
}
