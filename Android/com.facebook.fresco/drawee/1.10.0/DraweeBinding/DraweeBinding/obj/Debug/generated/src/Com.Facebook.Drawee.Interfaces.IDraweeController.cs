using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Facebook.Drawee.Interfaces {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.facebook.drawee.interfaces']/interface[@name='DraweeController']"
	[Register ("com/facebook/drawee/interfaces/DraweeController", "", "Com.Facebook.Drawee.Interfaces.IDraweeControllerInvoker")]
	public partial interface IDraweeController : IJavaObject, IJavaPeerable {

		global::Android.Graphics.Drawables.IAnimatable Animatable {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.drawee.interfaces']/interface[@name='DraweeController']/method[@name='getAnimatable' and count(parameter)=0]"
			[Register ("getAnimatable", "()Landroid/graphics/drawable/Animatable;", "GetGetAnimatableHandler:Com.Facebook.Drawee.Interfaces.IDraweeControllerInvoker, DraweeBinding")] get;
		}

		string ContentDescription {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.drawee.interfaces']/interface[@name='DraweeController']/method[@name='getContentDescription' and count(parameter)=0]"
			[Register ("getContentDescription", "()Ljava/lang/String;", "GetGetContentDescriptionHandler:Com.Facebook.Drawee.Interfaces.IDraweeControllerInvoker, DraweeBinding")] get;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.drawee.interfaces']/interface[@name='DraweeController']/method[@name='setContentDescription' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setContentDescription", "(Ljava/lang/String;)V", "GetSetContentDescription_Ljava_lang_String_Handler:Com.Facebook.Drawee.Interfaces.IDraweeControllerInvoker, DraweeBinding")] set;
		}

		global::Com.Facebook.Drawee.Interfaces.IDraweeHierarchy Hierarchy {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.drawee.interfaces']/interface[@name='DraweeController']/method[@name='getHierarchy' and count(parameter)=0]"
			[Register ("getHierarchy", "()Lcom/facebook/drawee/interfaces/DraweeHierarchy;", "GetGetHierarchyHandler:Com.Facebook.Drawee.Interfaces.IDraweeControllerInvoker, DraweeBinding")] get;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.drawee.interfaces']/interface[@name='DraweeController']/method[@name='setHierarchy' and count(parameter)=1 and parameter[1][@type='com.facebook.drawee.interfaces.DraweeHierarchy']]"
			[Register ("setHierarchy", "(Lcom/facebook/drawee/interfaces/DraweeHierarchy;)V", "GetSetHierarchy_Lcom_facebook_drawee_interfaces_DraweeHierarchy_Handler:Com.Facebook.Drawee.Interfaces.IDraweeControllerInvoker, DraweeBinding")] set;
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.drawee.interfaces']/interface[@name='DraweeController']/method[@name='isSameImageRequest' and count(parameter)=1 and parameter[1][@type='com.facebook.drawee.interfaces.DraweeController']]"
		[Register ("isSameImageRequest", "(Lcom/facebook/drawee/interfaces/DraweeController;)Z", "GetIsSameImageRequest_Lcom_facebook_drawee_interfaces_DraweeController_Handler:Com.Facebook.Drawee.Interfaces.IDraweeControllerInvoker, DraweeBinding")]
		bool IsSameImageRequest (global::Com.Facebook.Drawee.Interfaces.IDraweeController p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.drawee.interfaces']/interface[@name='DraweeController']/method[@name='onAttach' and count(parameter)=0]"
		[Register ("onAttach", "()V", "GetOnAttachHandler:Com.Facebook.Drawee.Interfaces.IDraweeControllerInvoker, DraweeBinding")]
		void OnAttach ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.drawee.interfaces']/interface[@name='DraweeController']/method[@name='onDetach' and count(parameter)=0]"
		[Register ("onDetach", "()V", "GetOnDetachHandler:Com.Facebook.Drawee.Interfaces.IDraweeControllerInvoker, DraweeBinding")]
		void OnDetach ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.drawee.interfaces']/interface[@name='DraweeController']/method[@name='onTouchEvent' and count(parameter)=1 and parameter[1][@type='android.view.MotionEvent']]"
		[Register ("onTouchEvent", "(Landroid/view/MotionEvent;)Z", "GetOnTouchEvent_Landroid_view_MotionEvent_Handler:Com.Facebook.Drawee.Interfaces.IDraweeControllerInvoker, DraweeBinding")]
		bool OnTouchEvent (global::Android.Views.MotionEvent p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.drawee.interfaces']/interface[@name='DraweeController']/method[@name='onViewportVisibilityHint' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("onViewportVisibilityHint", "(Z)V", "GetOnViewportVisibilityHint_ZHandler:Com.Facebook.Drawee.Interfaces.IDraweeControllerInvoker, DraweeBinding")]
		void OnViewportVisibilityHint (bool p0);

	}

	[global::Android.Runtime.Register ("com/facebook/drawee/interfaces/DraweeController", DoNotGenerateAcw=true)]
	internal partial class IDraweeControllerInvoker : global::Java.Lang.Object, IDraweeController {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/facebook/drawee/interfaces/DraweeController", typeof (IDraweeControllerInvoker));

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

		public static IDraweeController GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IDraweeController> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.facebook.drawee.interfaces.DraweeController"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IDraweeControllerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_getAnimatable;
#pragma warning disable 0169
		static Delegate GetGetAnimatableHandler ()
		{
			if (cb_getAnimatable == null)
				cb_getAnimatable = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetAnimatable);
			return cb_getAnimatable;
		}

		static IntPtr n_GetAnimatable (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Facebook.Drawee.Interfaces.IDraweeController __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Drawee.Interfaces.IDraweeController> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Animatable);
		}
#pragma warning restore 0169

		IntPtr id_getAnimatable;
		public unsafe global::Android.Graphics.Drawables.IAnimatable Animatable {
			get {
				if (id_getAnimatable == IntPtr.Zero)
					id_getAnimatable = JNIEnv.GetMethodID (class_ref, "getAnimatable", "()Landroid/graphics/drawable/Animatable;");
				return global::Java.Lang.Object.GetObject<global::Android.Graphics.Drawables.IAnimatable> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getAnimatable), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getContentDescription;
#pragma warning disable 0169
		static Delegate GetGetContentDescriptionHandler ()
		{
			if (cb_getContentDescription == null)
				cb_getContentDescription = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetContentDescription);
			return cb_getContentDescription;
		}

		static IntPtr n_GetContentDescription (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Facebook.Drawee.Interfaces.IDraweeController __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Drawee.Interfaces.IDraweeController> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.ContentDescription);
		}
#pragma warning restore 0169

		static Delegate cb_setContentDescription_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetContentDescription_Ljava_lang_String_Handler ()
		{
			if (cb_setContentDescription_Ljava_lang_String_ == null)
				cb_setContentDescription_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetContentDescription_Ljava_lang_String_);
			return cb_setContentDescription_Ljava_lang_String_;
		}

		static void n_SetContentDescription_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Facebook.Drawee.Interfaces.IDraweeController __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Drawee.Interfaces.IDraweeController> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.ContentDescription = p0;
		}
#pragma warning restore 0169

		IntPtr id_getContentDescription;
		IntPtr id_setContentDescription_Ljava_lang_String_;
		public unsafe string ContentDescription {
			get {
				if (id_getContentDescription == IntPtr.Zero)
					id_getContentDescription = JNIEnv.GetMethodID (class_ref, "getContentDescription", "()Ljava/lang/String;");
				return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getContentDescription), JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (id_setContentDescription_Ljava_lang_String_ == IntPtr.Zero)
					id_setContentDescription_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setContentDescription", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_value);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setContentDescription_Ljava_lang_String_, __args);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static Delegate cb_getHierarchy;
#pragma warning disable 0169
		static Delegate GetGetHierarchyHandler ()
		{
			if (cb_getHierarchy == null)
				cb_getHierarchy = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetHierarchy);
			return cb_getHierarchy;
		}

		static IntPtr n_GetHierarchy (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Facebook.Drawee.Interfaces.IDraweeController __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Drawee.Interfaces.IDraweeController> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Hierarchy);
		}
#pragma warning restore 0169

		static Delegate cb_setHierarchy_Lcom_facebook_drawee_interfaces_DraweeHierarchy_;
#pragma warning disable 0169
		static Delegate GetSetHierarchy_Lcom_facebook_drawee_interfaces_DraweeHierarchy_Handler ()
		{
			if (cb_setHierarchy_Lcom_facebook_drawee_interfaces_DraweeHierarchy_ == null)
				cb_setHierarchy_Lcom_facebook_drawee_interfaces_DraweeHierarchy_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetHierarchy_Lcom_facebook_drawee_interfaces_DraweeHierarchy_);
			return cb_setHierarchy_Lcom_facebook_drawee_interfaces_DraweeHierarchy_;
		}

		static void n_SetHierarchy_Lcom_facebook_drawee_interfaces_DraweeHierarchy_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Facebook.Drawee.Interfaces.IDraweeController __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Drawee.Interfaces.IDraweeController> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Facebook.Drawee.Interfaces.IDraweeHierarchy p0 = (global::Com.Facebook.Drawee.Interfaces.IDraweeHierarchy)global::Java.Lang.Object.GetObject<global::Com.Facebook.Drawee.Interfaces.IDraweeHierarchy> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Hierarchy = p0;
		}
#pragma warning restore 0169

		IntPtr id_getHierarchy;
		IntPtr id_setHierarchy_Lcom_facebook_drawee_interfaces_DraweeHierarchy_;
		public unsafe global::Com.Facebook.Drawee.Interfaces.IDraweeHierarchy Hierarchy {
			get {
				if (id_getHierarchy == IntPtr.Zero)
					id_getHierarchy = JNIEnv.GetMethodID (class_ref, "getHierarchy", "()Lcom/facebook/drawee/interfaces/DraweeHierarchy;");
				return global::Java.Lang.Object.GetObject<global::Com.Facebook.Drawee.Interfaces.IDraweeHierarchy> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getHierarchy), JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (id_setHierarchy_Lcom_facebook_drawee_interfaces_DraweeHierarchy_ == IntPtr.Zero)
					id_setHierarchy_Lcom_facebook_drawee_interfaces_DraweeHierarchy_ = JNIEnv.GetMethodID (class_ref, "setHierarchy", "(Lcom/facebook/drawee/interfaces/DraweeHierarchy;)V");
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue ((value == null) ? IntPtr.Zero : ((global::Java.Lang.Object) value).Handle);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setHierarchy_Lcom_facebook_drawee_interfaces_DraweeHierarchy_, __args);
			}
		}

		static Delegate cb_isSameImageRequest_Lcom_facebook_drawee_interfaces_DraweeController_;
#pragma warning disable 0169
		static Delegate GetIsSameImageRequest_Lcom_facebook_drawee_interfaces_DraweeController_Handler ()
		{
			if (cb_isSameImageRequest_Lcom_facebook_drawee_interfaces_DraweeController_ == null)
				cb_isSameImageRequest_Lcom_facebook_drawee_interfaces_DraweeController_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_IsSameImageRequest_Lcom_facebook_drawee_interfaces_DraweeController_);
			return cb_isSameImageRequest_Lcom_facebook_drawee_interfaces_DraweeController_;
		}

		static bool n_IsSameImageRequest_Lcom_facebook_drawee_interfaces_DraweeController_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Facebook.Drawee.Interfaces.IDraweeController __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Drawee.Interfaces.IDraweeController> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Facebook.Drawee.Interfaces.IDraweeController p0 = (global::Com.Facebook.Drawee.Interfaces.IDraweeController)global::Java.Lang.Object.GetObject<global::Com.Facebook.Drawee.Interfaces.IDraweeController> (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.IsSameImageRequest (p0);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_isSameImageRequest_Lcom_facebook_drawee_interfaces_DraweeController_;
		public unsafe bool IsSameImageRequest (global::Com.Facebook.Drawee.Interfaces.IDraweeController p0)
		{
			if (id_isSameImageRequest_Lcom_facebook_drawee_interfaces_DraweeController_ == IntPtr.Zero)
				id_isSameImageRequest_Lcom_facebook_drawee_interfaces_DraweeController_ = JNIEnv.GetMethodID (class_ref, "isSameImageRequest", "(Lcom/facebook/drawee/interfaces/DraweeController;)Z");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			bool __ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isSameImageRequest_Lcom_facebook_drawee_interfaces_DraweeController_, __args);
			return __ret;
		}

		static Delegate cb_onAttach;
#pragma warning disable 0169
		static Delegate GetOnAttachHandler ()
		{
			if (cb_onAttach == null)
				cb_onAttach = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_OnAttach);
			return cb_onAttach;
		}

		static void n_OnAttach (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Facebook.Drawee.Interfaces.IDraweeController __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Drawee.Interfaces.IDraweeController> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnAttach ();
		}
#pragma warning restore 0169

		IntPtr id_onAttach;
		public unsafe void OnAttach ()
		{
			if (id_onAttach == IntPtr.Zero)
				id_onAttach = JNIEnv.GetMethodID (class_ref, "onAttach", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onAttach);
		}

		static Delegate cb_onDetach;
#pragma warning disable 0169
		static Delegate GetOnDetachHandler ()
		{
			if (cb_onDetach == null)
				cb_onDetach = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_OnDetach);
			return cb_onDetach;
		}

		static void n_OnDetach (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Facebook.Drawee.Interfaces.IDraweeController __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Drawee.Interfaces.IDraweeController> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnDetach ();
		}
#pragma warning restore 0169

		IntPtr id_onDetach;
		public unsafe void OnDetach ()
		{
			if (id_onDetach == IntPtr.Zero)
				id_onDetach = JNIEnv.GetMethodID (class_ref, "onDetach", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onDetach);
		}

		static Delegate cb_onTouchEvent_Landroid_view_MotionEvent_;
#pragma warning disable 0169
		static Delegate GetOnTouchEvent_Landroid_view_MotionEvent_Handler ()
		{
			if (cb_onTouchEvent_Landroid_view_MotionEvent_ == null)
				cb_onTouchEvent_Landroid_view_MotionEvent_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_OnTouchEvent_Landroid_view_MotionEvent_);
			return cb_onTouchEvent_Landroid_view_MotionEvent_;
		}

		static bool n_OnTouchEvent_Landroid_view_MotionEvent_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Facebook.Drawee.Interfaces.IDraweeController __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Drawee.Interfaces.IDraweeController> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Views.MotionEvent p0 = global::Java.Lang.Object.GetObject<global::Android.Views.MotionEvent> (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.OnTouchEvent (p0);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_onTouchEvent_Landroid_view_MotionEvent_;
		public unsafe bool OnTouchEvent (global::Android.Views.MotionEvent p0)
		{
			if (id_onTouchEvent_Landroid_view_MotionEvent_ == IntPtr.Zero)
				id_onTouchEvent_Landroid_view_MotionEvent_ = JNIEnv.GetMethodID (class_ref, "onTouchEvent", "(Landroid/view/MotionEvent;)Z");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			bool __ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_onTouchEvent_Landroid_view_MotionEvent_, __args);
			return __ret;
		}

		static Delegate cb_onViewportVisibilityHint_Z;
#pragma warning disable 0169
		static Delegate GetOnViewportVisibilityHint_ZHandler ()
		{
			if (cb_onViewportVisibilityHint_Z == null)
				cb_onViewportVisibilityHint_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_OnViewportVisibilityHint_Z);
			return cb_onViewportVisibilityHint_Z;
		}

		static void n_OnViewportVisibilityHint_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::Com.Facebook.Drawee.Interfaces.IDraweeController __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Drawee.Interfaces.IDraweeController> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnViewportVisibilityHint (p0);
		}
#pragma warning restore 0169

		IntPtr id_onViewportVisibilityHint_Z;
		public unsafe void OnViewportVisibilityHint (bool p0)
		{
			if (id_onViewportVisibilityHint_Z == IntPtr.Zero)
				id_onViewportVisibilityHint_Z = JNIEnv.GetMethodID (class_ref, "onViewportVisibilityHint", "(Z)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onViewportVisibilityHint_Z, __args);
		}

	}

}
