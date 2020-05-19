using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Facebook.Drawee.Controller {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.facebook.drawee.controller']/class[@name='BaseControllerListener']"
	[global::Android.Runtime.Register ("com/facebook/drawee/controller/BaseControllerListener", DoNotGenerateAcw=true)]
	[global::Java.Interop.JavaTypeParameters (new string [] {"INFO"})]
	public partial class BaseControllerListener : global::Java.Lang.Object, global::Com.Facebook.Drawee.Controller.IControllerListener {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/facebook/drawee/controller/BaseControllerListener", typeof (BaseControllerListener));
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

		protected BaseControllerListener (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.facebook.drawee.controller']/class[@name='BaseControllerListener']/constructor[@name='BaseControllerListener' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe BaseControllerListener ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "()V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), null);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, null);
			} finally {
			}
		}

		[global::Java.Interop.JavaTypeParameters (new string [] {"INFO"})]
		public static unsafe global::Com.Facebook.Drawee.Controller.IControllerListener NoOpListener {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.drawee.controller']/class[@name='BaseControllerListener']/method[@name='getNoOpListener' and count(parameter)=0]"
			[Register ("getNoOpListener", "()Lcom/facebook/drawee/controller/ControllerListener;", "")]
			get {
				const string __id = "getNoOpListener.()Lcom/facebook/drawee/controller/ControllerListener;";
				try {
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
					return global::Java.Lang.Object.GetObject<global::Com.Facebook.Drawee.Controller.IControllerListener> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_onFailure_Ljava_lang_String_Ljava_lang_Throwable_;
#pragma warning disable 0169
		static Delegate GetOnFailure_Ljava_lang_String_Ljava_lang_Throwable_Handler ()
		{
			if (cb_onFailure_Ljava_lang_String_Ljava_lang_Throwable_ == null)
				cb_onFailure_Ljava_lang_String_Ljava_lang_Throwable_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_OnFailure_Ljava_lang_String_Ljava_lang_Throwable_);
			return cb_onFailure_Ljava_lang_String_Ljava_lang_Throwable_;
		}

		static void n_OnFailure_Ljava_lang_String_Ljava_lang_Throwable_ (IntPtr jnienv, IntPtr native__this, IntPtr native_id, IntPtr native_throwable)
		{
			global::Com.Facebook.Drawee.Controller.BaseControllerListener __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Drawee.Controller.BaseControllerListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string id = JNIEnv.GetString (native_id, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Throwable throwable = global::Java.Lang.Object.GetObject<global::Java.Lang.Throwable> (native_throwable, JniHandleOwnership.DoNotTransfer);
			__this.OnFailure (id, throwable);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.drawee.controller']/class[@name='BaseControllerListener']/method[@name='onFailure' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.Throwable']]"
		[Register ("onFailure", "(Ljava/lang/String;Ljava/lang/Throwable;)V", "GetOnFailure_Ljava_lang_String_Ljava_lang_Throwable_Handler")]
		public virtual unsafe void OnFailure (string id, global::Java.Lang.Throwable throwable)
		{
			const string __id = "onFailure.(Ljava/lang/String;Ljava/lang/Throwable;)V";
			IntPtr native_id = JNIEnv.NewString (id);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_id);
				__args [1] = new JniArgumentValue ((throwable == null) ? IntPtr.Zero : ((global::Java.Lang.Throwable) throwable).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_id);
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
			global::Com.Facebook.Drawee.Controller.BaseControllerListener __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Drawee.Controller.BaseControllerListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string id = JNIEnv.GetString (native_id, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object imageInfo = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_imageInfo, JniHandleOwnership.DoNotTransfer);
			global::Android.Graphics.Drawables.IAnimatable animatable = (global::Android.Graphics.Drawables.IAnimatable)global::Java.Lang.Object.GetObject<global::Android.Graphics.Drawables.IAnimatable> (native_animatable, JniHandleOwnership.DoNotTransfer);
			__this.OnFinalImageSet (id, imageInfo, animatable);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.drawee.controller']/class[@name='BaseControllerListener']/method[@name='onFinalImageSet' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='INFO'] and parameter[3][@type='android.graphics.drawable.Animatable']]"
		[Register ("onFinalImageSet", "(Ljava/lang/String;Ljava/lang/Object;Landroid/graphics/drawable/Animatable;)V", "GetOnFinalImageSet_Ljava_lang_String_Ljava_lang_Object_Landroid_graphics_drawable_Animatable_Handler")]
		public virtual unsafe void OnFinalImageSet (string id, global::Java.Lang.Object imageInfo, global::Android.Graphics.Drawables.IAnimatable animatable)
		{
			const string __id = "onFinalImageSet.(Ljava/lang/String;Ljava/lang/Object;Landroid/graphics/drawable/Animatable;)V";
			IntPtr native_id = JNIEnv.NewString (id);
			IntPtr native_imageInfo = JNIEnv.ToLocalJniHandle (imageInfo);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (native_id);
				__args [1] = new JniArgumentValue (native_imageInfo);
				__args [2] = new JniArgumentValue ((animatable == null) ? IntPtr.Zero : ((global::Java.Lang.Object) animatable).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_id);
				JNIEnv.DeleteLocalRef (native_imageInfo);
			}
		}

		static Delegate cb_onIntermediateImageFailed_Ljava_lang_String_Ljava_lang_Throwable_;
#pragma warning disable 0169
		static Delegate GetOnIntermediateImageFailed_Ljava_lang_String_Ljava_lang_Throwable_Handler ()
		{
			if (cb_onIntermediateImageFailed_Ljava_lang_String_Ljava_lang_Throwable_ == null)
				cb_onIntermediateImageFailed_Ljava_lang_String_Ljava_lang_Throwable_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_OnIntermediateImageFailed_Ljava_lang_String_Ljava_lang_Throwable_);
			return cb_onIntermediateImageFailed_Ljava_lang_String_Ljava_lang_Throwable_;
		}

		static void n_OnIntermediateImageFailed_Ljava_lang_String_Ljava_lang_Throwable_ (IntPtr jnienv, IntPtr native__this, IntPtr native_id, IntPtr native_throwable)
		{
			global::Com.Facebook.Drawee.Controller.BaseControllerListener __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Drawee.Controller.BaseControllerListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string id = JNIEnv.GetString (native_id, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Throwable throwable = global::Java.Lang.Object.GetObject<global::Java.Lang.Throwable> (native_throwable, JniHandleOwnership.DoNotTransfer);
			__this.OnIntermediateImageFailed (id, throwable);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.drawee.controller']/class[@name='BaseControllerListener']/method[@name='onIntermediateImageFailed' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.Throwable']]"
		[Register ("onIntermediateImageFailed", "(Ljava/lang/String;Ljava/lang/Throwable;)V", "GetOnIntermediateImageFailed_Ljava_lang_String_Ljava_lang_Throwable_Handler")]
		public virtual unsafe void OnIntermediateImageFailed (string id, global::Java.Lang.Throwable throwable)
		{
			const string __id = "onIntermediateImageFailed.(Ljava/lang/String;Ljava/lang/Throwable;)V";
			IntPtr native_id = JNIEnv.NewString (id);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_id);
				__args [1] = new JniArgumentValue ((throwable == null) ? IntPtr.Zero : ((global::Java.Lang.Throwable) throwable).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_id);
			}
		}

		static Delegate cb_onIntermediateImageSet_Ljava_lang_String_Ljava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetOnIntermediateImageSet_Ljava_lang_String_Ljava_lang_Object_Handler ()
		{
			if (cb_onIntermediateImageSet_Ljava_lang_String_Ljava_lang_Object_ == null)
				cb_onIntermediateImageSet_Ljava_lang_String_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_OnIntermediateImageSet_Ljava_lang_String_Ljava_lang_Object_);
			return cb_onIntermediateImageSet_Ljava_lang_String_Ljava_lang_Object_;
		}

		static void n_OnIntermediateImageSet_Ljava_lang_String_Ljava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_id, IntPtr native_imageInfo)
		{
			global::Com.Facebook.Drawee.Controller.BaseControllerListener __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Drawee.Controller.BaseControllerListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string id = JNIEnv.GetString (native_id, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object imageInfo = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_imageInfo, JniHandleOwnership.DoNotTransfer);
			__this.OnIntermediateImageSet (id, imageInfo);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.drawee.controller']/class[@name='BaseControllerListener']/method[@name='onIntermediateImageSet' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='INFO']]"
		[Register ("onIntermediateImageSet", "(Ljava/lang/String;Ljava/lang/Object;)V", "GetOnIntermediateImageSet_Ljava_lang_String_Ljava_lang_Object_Handler")]
		public virtual unsafe void OnIntermediateImageSet (string id, global::Java.Lang.Object imageInfo)
		{
			const string __id = "onIntermediateImageSet.(Ljava/lang/String;Ljava/lang/Object;)V";
			IntPtr native_id = JNIEnv.NewString (id);
			IntPtr native_imageInfo = JNIEnv.ToLocalJniHandle (imageInfo);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_id);
				__args [1] = new JniArgumentValue (native_imageInfo);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_id);
				JNIEnv.DeleteLocalRef (native_imageInfo);
			}
		}

		static Delegate cb_onRelease_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetOnRelease_Ljava_lang_String_Handler ()
		{
			if (cb_onRelease_Ljava_lang_String_ == null)
				cb_onRelease_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnRelease_Ljava_lang_String_);
			return cb_onRelease_Ljava_lang_String_;
		}

		static void n_OnRelease_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_id)
		{
			global::Com.Facebook.Drawee.Controller.BaseControllerListener __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Drawee.Controller.BaseControllerListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string id = JNIEnv.GetString (native_id, JniHandleOwnership.DoNotTransfer);
			__this.OnRelease (id);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.drawee.controller']/class[@name='BaseControllerListener']/method[@name='onRelease' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("onRelease", "(Ljava/lang/String;)V", "GetOnRelease_Ljava_lang_String_Handler")]
		public virtual unsafe void OnRelease (string id)
		{
			const string __id = "onRelease.(Ljava/lang/String;)V";
			IntPtr native_id = JNIEnv.NewString (id);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_id);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_id);
			}
		}

		static Delegate cb_onSubmit_Ljava_lang_String_Ljava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetOnSubmit_Ljava_lang_String_Ljava_lang_Object_Handler ()
		{
			if (cb_onSubmit_Ljava_lang_String_Ljava_lang_Object_ == null)
				cb_onSubmit_Ljava_lang_String_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_OnSubmit_Ljava_lang_String_Ljava_lang_Object_);
			return cb_onSubmit_Ljava_lang_String_Ljava_lang_Object_;
		}

		static void n_OnSubmit_Ljava_lang_String_Ljava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_id, IntPtr native_callerContext)
		{
			global::Com.Facebook.Drawee.Controller.BaseControllerListener __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Drawee.Controller.BaseControllerListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string id = JNIEnv.GetString (native_id, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object callerContext = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_callerContext, JniHandleOwnership.DoNotTransfer);
			__this.OnSubmit (id, callerContext);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.drawee.controller']/class[@name='BaseControllerListener']/method[@name='onSubmit' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.Object']]"
		[Register ("onSubmit", "(Ljava/lang/String;Ljava/lang/Object;)V", "GetOnSubmit_Ljava_lang_String_Ljava_lang_Object_Handler")]
		public virtual unsafe void OnSubmit (string id, global::Java.Lang.Object callerContext)
		{
			const string __id = "onSubmit.(Ljava/lang/String;Ljava/lang/Object;)V";
			IntPtr native_id = JNIEnv.NewString (id);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_id);
				__args [1] = new JniArgumentValue ((callerContext == null) ? IntPtr.Zero : ((global::Java.Lang.Object) callerContext).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_id);
			}
		}

	}
}
