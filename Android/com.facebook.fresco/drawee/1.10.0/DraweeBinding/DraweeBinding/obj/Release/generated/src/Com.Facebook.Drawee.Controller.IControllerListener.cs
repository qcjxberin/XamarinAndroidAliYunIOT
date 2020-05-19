using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Facebook.Drawee.Controller {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.facebook.drawee.controller']/interface[@name='ControllerListener']"
	[Register ("com/facebook/drawee/controller/ControllerListener", "", "Com.Facebook.Drawee.Controller.IControllerListenerInvoker")]
	[global::Java.Interop.JavaTypeParameters (new string [] {"INFO"})]
	public partial interface IControllerListener : IJavaObject, IJavaPeerable {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.drawee.controller']/interface[@name='ControllerListener']/method[@name='onFailure' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.Throwable']]"
		[Register ("onFailure", "(Ljava/lang/String;Ljava/lang/Throwable;)V", "GetOnFailure_Ljava_lang_String_Ljava_lang_Throwable_Handler:Com.Facebook.Drawee.Controller.IControllerListenerInvoker, DraweeBinding")]
		void OnFailure (string p0, global::Java.Lang.Throwable p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.drawee.controller']/interface[@name='ControllerListener']/method[@name='onFinalImageSet' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='INFO'] and parameter[3][@type='android.graphics.drawable.Animatable']]"
		[Register ("onFinalImageSet", "(Ljava/lang/String;Ljava/lang/Object;Landroid/graphics/drawable/Animatable;)V", "GetOnFinalImageSet_Ljava_lang_String_Ljava_lang_Object_Landroid_graphics_drawable_Animatable_Handler:Com.Facebook.Drawee.Controller.IControllerListenerInvoker, DraweeBinding")]
		void OnFinalImageSet (string p0, global::Java.Lang.Object p1, global::Android.Graphics.Drawables.IAnimatable p2);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.drawee.controller']/interface[@name='ControllerListener']/method[@name='onIntermediateImageFailed' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.Throwable']]"
		[Register ("onIntermediateImageFailed", "(Ljava/lang/String;Ljava/lang/Throwable;)V", "GetOnIntermediateImageFailed_Ljava_lang_String_Ljava_lang_Throwable_Handler:Com.Facebook.Drawee.Controller.IControllerListenerInvoker, DraweeBinding")]
		void OnIntermediateImageFailed (string p0, global::Java.Lang.Throwable p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.drawee.controller']/interface[@name='ControllerListener']/method[@name='onIntermediateImageSet' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='INFO']]"
		[Register ("onIntermediateImageSet", "(Ljava/lang/String;Ljava/lang/Object;)V", "GetOnIntermediateImageSet_Ljava_lang_String_Ljava_lang_Object_Handler:Com.Facebook.Drawee.Controller.IControllerListenerInvoker, DraweeBinding")]
		void OnIntermediateImageSet (string p0, global::Java.Lang.Object p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.drawee.controller']/interface[@name='ControllerListener']/method[@name='onRelease' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("onRelease", "(Ljava/lang/String;)V", "GetOnRelease_Ljava_lang_String_Handler:Com.Facebook.Drawee.Controller.IControllerListenerInvoker, DraweeBinding")]
		void OnRelease (string p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.drawee.controller']/interface[@name='ControllerListener']/method[@name='onSubmit' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.Object']]"
		[Register ("onSubmit", "(Ljava/lang/String;Ljava/lang/Object;)V", "GetOnSubmit_Ljava_lang_String_Ljava_lang_Object_Handler:Com.Facebook.Drawee.Controller.IControllerListenerInvoker, DraweeBinding")]
		void OnSubmit (string p0, global::Java.Lang.Object p1);

	}

	[global::Android.Runtime.Register ("com/facebook/drawee/controller/ControllerListener", DoNotGenerateAcw=true)]
	internal partial class IControllerListenerInvoker : global::Java.Lang.Object, IControllerListener {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/facebook/drawee/controller/ControllerListener", typeof (IControllerListenerInvoker));

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

		public static IControllerListener GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IControllerListener> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.facebook.drawee.controller.ControllerListener"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IControllerListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_onFailure_Ljava_lang_String_Ljava_lang_Throwable_;
#pragma warning disable 0169
		static Delegate GetOnFailure_Ljava_lang_String_Ljava_lang_Throwable_Handler ()
		{
			if (cb_onFailure_Ljava_lang_String_Ljava_lang_Throwable_ == null)
				cb_onFailure_Ljava_lang_String_Ljava_lang_Throwable_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_OnFailure_Ljava_lang_String_Ljava_lang_Throwable_);
			return cb_onFailure_Ljava_lang_String_Ljava_lang_Throwable_;
		}

		static void n_OnFailure_Ljava_lang_String_Ljava_lang_Throwable_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Facebook.Drawee.Controller.IControllerListener __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Drawee.Controller.IControllerListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Throwable p1 = global::Java.Lang.Object.GetObject<global::Java.Lang.Throwable> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.OnFailure (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_onFailure_Ljava_lang_String_Ljava_lang_Throwable_;
		public unsafe void OnFailure (string p0, global::Java.Lang.Throwable p1)
		{
			if (id_onFailure_Ljava_lang_String_Ljava_lang_Throwable_ == IntPtr.Zero)
				id_onFailure_Ljava_lang_String_Ljava_lang_Throwable_ = JNIEnv.GetMethodID (class_ref, "onFailure", "(Ljava/lang/String;Ljava/lang/Throwable;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (native_p0);
			__args [1] = new JValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Throwable) p1).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onFailure_Ljava_lang_String_Ljava_lang_Throwable_, __args);
			JNIEnv.DeleteLocalRef (native_p0);
		}

		static Delegate cb_onFinalImageSet_Ljava_lang_String_Ljava_lang_Object_Landroid_graphics_drawable_Animatable_;
#pragma warning disable 0169
		static Delegate GetOnFinalImageSet_Ljava_lang_String_Ljava_lang_Object_Landroid_graphics_drawable_Animatable_Handler ()
		{
			if (cb_onFinalImageSet_Ljava_lang_String_Ljava_lang_Object_Landroid_graphics_drawable_Animatable_ == null)
				cb_onFinalImageSet_Ljava_lang_String_Ljava_lang_Object_Landroid_graphics_drawable_Animatable_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_OnFinalImageSet_Ljava_lang_String_Ljava_lang_Object_Landroid_graphics_drawable_Animatable_);
			return cb_onFinalImageSet_Ljava_lang_String_Ljava_lang_Object_Landroid_graphics_drawable_Animatable_;
		}

		static void n_OnFinalImageSet_Ljava_lang_String_Ljava_lang_Object_Landroid_graphics_drawable_Animatable_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2)
		{
			global::Com.Facebook.Drawee.Controller.IControllerListener __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Drawee.Controller.IControllerListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object p1 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p1, JniHandleOwnership.DoNotTransfer);
			global::Android.Graphics.Drawables.IAnimatable p2 = (global::Android.Graphics.Drawables.IAnimatable)global::Java.Lang.Object.GetObject<global::Android.Graphics.Drawables.IAnimatable> (native_p2, JniHandleOwnership.DoNotTransfer);
			__this.OnFinalImageSet (p0, p1, p2);
		}
#pragma warning restore 0169

		IntPtr id_onFinalImageSet_Ljava_lang_String_Ljava_lang_Object_Landroid_graphics_drawable_Animatable_;
		public unsafe void OnFinalImageSet (string p0, global::Java.Lang.Object p1, global::Android.Graphics.Drawables.IAnimatable p2)
		{
			if (id_onFinalImageSet_Ljava_lang_String_Ljava_lang_Object_Landroid_graphics_drawable_Animatable_ == IntPtr.Zero)
				id_onFinalImageSet_Ljava_lang_String_Ljava_lang_Object_Landroid_graphics_drawable_Animatable_ = JNIEnv.GetMethodID (class_ref, "onFinalImageSet", "(Ljava/lang/String;Ljava/lang/Object;Landroid/graphics/drawable/Animatable;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.ToLocalJniHandle (p1);
			JValue* __args = stackalloc JValue [3];
			__args [0] = new JValue (native_p0);
			__args [1] = new JValue (native_p1);
			__args [2] = new JValue ((p2 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p2).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onFinalImageSet_Ljava_lang_String_Ljava_lang_Object_Landroid_graphics_drawable_Animatable_, __args);
			JNIEnv.DeleteLocalRef (native_p0);
			JNIEnv.DeleteLocalRef (native_p1);
		}

		static Delegate cb_onIntermediateImageFailed_Ljava_lang_String_Ljava_lang_Throwable_;
#pragma warning disable 0169
		static Delegate GetOnIntermediateImageFailed_Ljava_lang_String_Ljava_lang_Throwable_Handler ()
		{
			if (cb_onIntermediateImageFailed_Ljava_lang_String_Ljava_lang_Throwable_ == null)
				cb_onIntermediateImageFailed_Ljava_lang_String_Ljava_lang_Throwable_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_OnIntermediateImageFailed_Ljava_lang_String_Ljava_lang_Throwable_);
			return cb_onIntermediateImageFailed_Ljava_lang_String_Ljava_lang_Throwable_;
		}

		static void n_OnIntermediateImageFailed_Ljava_lang_String_Ljava_lang_Throwable_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Facebook.Drawee.Controller.IControllerListener __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Drawee.Controller.IControllerListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Throwable p1 = global::Java.Lang.Object.GetObject<global::Java.Lang.Throwable> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.OnIntermediateImageFailed (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_onIntermediateImageFailed_Ljava_lang_String_Ljava_lang_Throwable_;
		public unsafe void OnIntermediateImageFailed (string p0, global::Java.Lang.Throwable p1)
		{
			if (id_onIntermediateImageFailed_Ljava_lang_String_Ljava_lang_Throwable_ == IntPtr.Zero)
				id_onIntermediateImageFailed_Ljava_lang_String_Ljava_lang_Throwable_ = JNIEnv.GetMethodID (class_ref, "onIntermediateImageFailed", "(Ljava/lang/String;Ljava/lang/Throwable;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (native_p0);
			__args [1] = new JValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Throwable) p1).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onIntermediateImageFailed_Ljava_lang_String_Ljava_lang_Throwable_, __args);
			JNIEnv.DeleteLocalRef (native_p0);
		}

		static Delegate cb_onIntermediateImageSet_Ljava_lang_String_Ljava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetOnIntermediateImageSet_Ljava_lang_String_Ljava_lang_Object_Handler ()
		{
			if (cb_onIntermediateImageSet_Ljava_lang_String_Ljava_lang_Object_ == null)
				cb_onIntermediateImageSet_Ljava_lang_String_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_OnIntermediateImageSet_Ljava_lang_String_Ljava_lang_Object_);
			return cb_onIntermediateImageSet_Ljava_lang_String_Ljava_lang_Object_;
		}

		static void n_OnIntermediateImageSet_Ljava_lang_String_Ljava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Facebook.Drawee.Controller.IControllerListener __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Drawee.Controller.IControllerListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object p1 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.OnIntermediateImageSet (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_onIntermediateImageSet_Ljava_lang_String_Ljava_lang_Object_;
		public unsafe void OnIntermediateImageSet (string p0, global::Java.Lang.Object p1)
		{
			if (id_onIntermediateImageSet_Ljava_lang_String_Ljava_lang_Object_ == IntPtr.Zero)
				id_onIntermediateImageSet_Ljava_lang_String_Ljava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "onIntermediateImageSet", "(Ljava/lang/String;Ljava/lang/Object;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.ToLocalJniHandle (p1);
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (native_p0);
			__args [1] = new JValue (native_p1);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onIntermediateImageSet_Ljava_lang_String_Ljava_lang_Object_, __args);
			JNIEnv.DeleteLocalRef (native_p0);
			JNIEnv.DeleteLocalRef (native_p1);
		}

		static Delegate cb_onRelease_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetOnRelease_Ljava_lang_String_Handler ()
		{
			if (cb_onRelease_Ljava_lang_String_ == null)
				cb_onRelease_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnRelease_Ljava_lang_String_);
			return cb_onRelease_Ljava_lang_String_;
		}

		static void n_OnRelease_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Facebook.Drawee.Controller.IControllerListener __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Drawee.Controller.IControllerListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnRelease (p0);
		}
#pragma warning restore 0169

		IntPtr id_onRelease_Ljava_lang_String_;
		public unsafe void OnRelease (string p0)
		{
			if (id_onRelease_Ljava_lang_String_ == IntPtr.Zero)
				id_onRelease_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "onRelease", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onRelease_Ljava_lang_String_, __args);
			JNIEnv.DeleteLocalRef (native_p0);
		}

		static Delegate cb_onSubmit_Ljava_lang_String_Ljava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetOnSubmit_Ljava_lang_String_Ljava_lang_Object_Handler ()
		{
			if (cb_onSubmit_Ljava_lang_String_Ljava_lang_Object_ == null)
				cb_onSubmit_Ljava_lang_String_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_OnSubmit_Ljava_lang_String_Ljava_lang_Object_);
			return cb_onSubmit_Ljava_lang_String_Ljava_lang_Object_;
		}

		static void n_OnSubmit_Ljava_lang_String_Ljava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Facebook.Drawee.Controller.IControllerListener __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Drawee.Controller.IControllerListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object p1 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.OnSubmit (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_onSubmit_Ljava_lang_String_Ljava_lang_Object_;
		public unsafe void OnSubmit (string p0, global::Java.Lang.Object p1)
		{
			if (id_onSubmit_Ljava_lang_String_Ljava_lang_Object_ == IntPtr.Zero)
				id_onSubmit_Ljava_lang_String_Ljava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "onSubmit", "(Ljava/lang/String;Ljava/lang/Object;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (native_p0);
			__args [1] = new JValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onSubmit_Ljava_lang_String_Ljava_lang_Object_, __args);
			JNIEnv.DeleteLocalRef (native_p0);
		}

	}

	// event args for com.facebook.drawee.controller.ControllerListener.onFailure
	public partial class FailureEventArgs : global::System.EventArgs {

		public FailureEventArgs (string p0, global::Java.Lang.Throwable p1)
		{
			this.p0 = p0;
			this.p1 = p1;
		}

		string p0;
		public string P0 {
			get { return p0; }
		}

		global::Java.Lang.Throwable p1;
		public global::Java.Lang.Throwable P1 {
			get { return p1; }
		}
	}

	// event args for com.facebook.drawee.controller.ControllerListener.onFinalImageSet
	public partial class FinalImageSetEventArgs : global::System.EventArgs {

		public FinalImageSetEventArgs (string p0, global::Java.Lang.Object p1, global::Android.Graphics.Drawables.IAnimatable p2)
		{
			this.p0 = p0;
			this.p1 = p1;
			this.p2 = p2;
		}

		string p0;
		public string P0 {
			get { return p0; }
		}

		global::Java.Lang.Object p1;
		public global::Java.Lang.Object P1 {
			get { return p1; }
		}

		global::Android.Graphics.Drawables.IAnimatable p2;
		public global::Android.Graphics.Drawables.IAnimatable P2 {
			get { return p2; }
		}
	}

	// event args for com.facebook.drawee.controller.ControllerListener.onIntermediateImageFailed
	public partial class IntermediateImageFailedEventArgs : global::System.EventArgs {

		public IntermediateImageFailedEventArgs (string p0, global::Java.Lang.Throwable p1)
		{
			this.p0 = p0;
			this.p1 = p1;
		}

		string p0;
		public string P0 {
			get { return p0; }
		}

		global::Java.Lang.Throwable p1;
		public global::Java.Lang.Throwable P1 {
			get { return p1; }
		}
	}

	// event args for com.facebook.drawee.controller.ControllerListener.onIntermediateImageSet
	public partial class IntermediateImageSetEventArgs : global::System.EventArgs {

		public IntermediateImageSetEventArgs (string p0, global::Java.Lang.Object p1)
		{
			this.p0 = p0;
			this.p1 = p1;
		}

		string p0;
		public string P0 {
			get { return p0; }
		}

		global::Java.Lang.Object p1;
		public global::Java.Lang.Object P1 {
			get { return p1; }
		}
	}

	// event args for com.facebook.drawee.controller.ControllerListener.onRelease
	public partial class ReleaseEventArgs : global::System.EventArgs {

		public ReleaseEventArgs (string p0)
		{
			this.p0 = p0;
		}

		string p0;
		public string P0 {
			get { return p0; }
		}
	}

	// event args for com.facebook.drawee.controller.ControllerListener.onSubmit
	public partial class SubmitEventArgs : global::System.EventArgs {

		public SubmitEventArgs (string p0, global::Java.Lang.Object p1)
		{
			this.p0 = p0;
			this.p1 = p1;
		}

		string p0;
		public string P0 {
			get { return p0; }
		}

		global::Java.Lang.Object p1;
		public global::Java.Lang.Object P1 {
			get { return p1; }
		}
	}

	[global::Android.Runtime.Register ("mono/com/facebook/drawee/controller/ControllerListenerImplementor")]
	internal sealed partial class IControllerListenerImplementor : global::Java.Lang.Object, IControllerListener {

		object sender;

		public IControllerListenerImplementor (object sender)
			: base (
				global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/com/facebook/drawee/controller/ControllerListenerImplementor", "()V"),
				JniHandleOwnership.TransferLocalRef)
		{
			global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "()V");
			this.sender = sender;
		}

#pragma warning disable 0649
		public EventHandler<FailureEventArgs> OnFailureHandler;
#pragma warning restore 0649

		public void OnFailure (string p0, global::Java.Lang.Throwable p1)
		{
			var __h = OnFailureHandler;
			if (__h != null)
				__h (sender, new FailureEventArgs (p0, p1));
		}
#pragma warning disable 0649
		public EventHandler<FinalImageSetEventArgs> OnFinalImageSetHandler;
#pragma warning restore 0649

		public void OnFinalImageSet (string p0, global::Java.Lang.Object p1, global::Android.Graphics.Drawables.IAnimatable p2)
		{
			var __h = OnFinalImageSetHandler;
			if (__h != null)
				__h (sender, new FinalImageSetEventArgs (p0, p1, p2));
		}
#pragma warning disable 0649
		public EventHandler<IntermediateImageFailedEventArgs> OnIntermediateImageFailedHandler;
#pragma warning restore 0649

		public void OnIntermediateImageFailed (string p0, global::Java.Lang.Throwable p1)
		{
			var __h = OnIntermediateImageFailedHandler;
			if (__h != null)
				__h (sender, new IntermediateImageFailedEventArgs (p0, p1));
		}
#pragma warning disable 0649
		public EventHandler<IntermediateImageSetEventArgs> OnIntermediateImageSetHandler;
#pragma warning restore 0649

		public void OnIntermediateImageSet (string p0, global::Java.Lang.Object p1)
		{
			var __h = OnIntermediateImageSetHandler;
			if (__h != null)
				__h (sender, new IntermediateImageSetEventArgs (p0, p1));
		}
#pragma warning disable 0649
		public EventHandler<ReleaseEventArgs> OnReleaseHandler;
#pragma warning restore 0649

		public void OnRelease (string p0)
		{
			var __h = OnReleaseHandler;
			if (__h != null)
				__h (sender, new ReleaseEventArgs (p0));
		}
#pragma warning disable 0649
		public EventHandler<SubmitEventArgs> OnSubmitHandler;
#pragma warning restore 0649

		public void OnSubmit (string p0, global::Java.Lang.Object p1)
		{
			var __h = OnSubmitHandler;
			if (__h != null)
				__h (sender, new SubmitEventArgs (p0, p1));
		}

		internal static bool __IsEmpty (IControllerListenerImplementor value)
		{
			return value.OnFailureHandler == null && value.OnFinalImageSetHandler == null && value.OnIntermediateImageFailedHandler == null && value.OnIntermediateImageSetHandler == null && value.OnReleaseHandler == null && value.OnSubmitHandler == null;
		}
	}

}
