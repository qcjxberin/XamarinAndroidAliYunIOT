using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Facebook.Drawee.Controller {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.facebook.drawee.controller']/class[@name='AbstractDraweeController']"
	[global::Android.Runtime.Register ("com/facebook/drawee/controller/AbstractDraweeController", DoNotGenerateAcw=true)]
	[global::Java.Interop.JavaTypeParameters (new string [] {"T", "INFO"})]
	public abstract partial class AbstractDraweeController : global::Java.Lang.Object, global::Com.Facebook.Drawee.Components.DeferredReleaser.IReleasable, global::Com.Facebook.Drawee.Gestures.GestureDetector.IClickListener, global::Com.Facebook.Drawee.Interfaces.IDraweeController {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/facebook/drawee/controller/AbstractDraweeController", typeof (AbstractDraweeController));
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

		protected AbstractDraweeController (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.facebook.drawee.controller']/class[@name='AbstractDraweeController']/constructor[@name='AbstractDraweeController' and count(parameter)=4 and parameter[1][@type='com.facebook.drawee.components.DeferredReleaser'] and parameter[2][@type='java.util.concurrent.Executor'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='java.lang.Object']]"
		[Register (".ctor", "(Lcom/facebook/drawee/components/DeferredReleaser;Ljava/util/concurrent/Executor;Ljava/lang/String;Ljava/lang/Object;)V", "")]
		public unsafe AbstractDraweeController (global::Com.Facebook.Drawee.Components.DeferredReleaser deferredReleaser, global::Java.Util.Concurrent.IExecutor uiThreadImmediateExecutor, string id, global::Java.Lang.Object callerContext)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Lcom/facebook/drawee/components/DeferredReleaser;Ljava/util/concurrent/Executor;Ljava/lang/String;Ljava/lang/Object;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_id = JNIEnv.NewString (id);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue ((deferredReleaser == null) ? IntPtr.Zero : ((global::Java.Lang.Object) deferredReleaser).Handle);
				__args [1] = new JniArgumentValue ((uiThreadImmediateExecutor == null) ? IntPtr.Zero : ((global::Java.Lang.Object) uiThreadImmediateExecutor).Handle);
				__args [2] = new JniArgumentValue (native_id);
				__args [3] = new JniArgumentValue ((callerContext == null) ? IntPtr.Zero : ((global::Java.Lang.Object) callerContext).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_id);
			}
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
			global::Com.Facebook.Drawee.Controller.AbstractDraweeController __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Drawee.Controller.AbstractDraweeController> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Animatable);
		}
#pragma warning restore 0169

		public virtual unsafe global::Android.Graphics.Drawables.IAnimatable Animatable {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.drawee.controller']/class[@name='AbstractDraweeController']/method[@name='getAnimatable' and count(parameter)=0]"
			[Register ("getAnimatable", "()Landroid/graphics/drawable/Animatable;", "GetGetAnimatableHandler")]
			get {
				const string __id = "getAnimatable.()Landroid/graphics/drawable/Animatable;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Android.Graphics.Drawables.IAnimatable> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getCachedImage;
#pragma warning disable 0169
		static Delegate GetGetCachedImageHandler ()
		{
			if (cb_getCachedImage == null)
				cb_getCachedImage = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetCachedImage);
			return cb_getCachedImage;
		}

		static IntPtr n_GetCachedImage (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Facebook.Drawee.Controller.AbstractDraweeController __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Drawee.Controller.AbstractDraweeController> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.CachedImage);
		}
#pragma warning restore 0169

		protected virtual unsafe global::Java.Lang.Object CachedImage {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.drawee.controller']/class[@name='AbstractDraweeController']/method[@name='getCachedImage' and count(parameter)=0]"
			[Register ("getCachedImage", "()Ljava/lang/Object;", "GetGetCachedImageHandler")]
			get {
				const string __id = "getCachedImage.()Ljava/lang/Object;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getCallerContext;
#pragma warning disable 0169
		static Delegate GetGetCallerContextHandler ()
		{
			if (cb_getCallerContext == null)
				cb_getCallerContext = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetCallerContext);
			return cb_getCallerContext;
		}

		static IntPtr n_GetCallerContext (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Facebook.Drawee.Controller.AbstractDraweeController __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Drawee.Controller.AbstractDraweeController> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.CallerContext);
		}
#pragma warning restore 0169

		public virtual unsafe global::Java.Lang.Object CallerContext {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.drawee.controller']/class[@name='AbstractDraweeController']/method[@name='getCallerContext' and count(parameter)=0]"
			[Register ("getCallerContext", "()Ljava/lang/Object;", "GetGetCallerContextHandler")]
			get {
				const string __id = "getCallerContext.()Ljava/lang/Object;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
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
			global::Com.Facebook.Drawee.Controller.AbstractDraweeController __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Drawee.Controller.AbstractDraweeController> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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

		static void n_SetContentDescription_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_contentDescription)
		{
			global::Com.Facebook.Drawee.Controller.AbstractDraweeController __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Drawee.Controller.AbstractDraweeController> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string contentDescription = JNIEnv.GetString (native_contentDescription, JniHandleOwnership.DoNotTransfer);
			__this.ContentDescription = contentDescription;
		}
#pragma warning restore 0169

		public virtual unsafe string ContentDescription {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.drawee.controller']/class[@name='AbstractDraweeController']/method[@name='getContentDescription' and count(parameter)=0]"
			[Register ("getContentDescription", "()Ljava/lang/String;", "GetGetContentDescriptionHandler")]
			get {
				const string __id = "getContentDescription.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.drawee.controller']/class[@name='AbstractDraweeController']/method[@name='setContentDescription' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setContentDescription", "(Ljava/lang/String;)V", "GetSetContentDescription_Ljava_lang_String_Handler")]
			set {
				const string __id = "setContentDescription.(Ljava/lang/String;)V";
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getControllerListener;
#pragma warning disable 0169
		static Delegate GetGetControllerListenerHandler ()
		{
			if (cb_getControllerListener == null)
				cb_getControllerListener = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetControllerListener);
			return cb_getControllerListener;
		}

		static IntPtr n_GetControllerListener (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Facebook.Drawee.Controller.AbstractDraweeController __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Drawee.Controller.AbstractDraweeController> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.ControllerListener);
		}
#pragma warning restore 0169

		protected virtual unsafe global::Com.Facebook.Drawee.Controller.IControllerListener ControllerListener {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.drawee.controller']/class[@name='AbstractDraweeController']/method[@name='getControllerListener' and count(parameter)=0]"
			[Register ("getControllerListener", "()Lcom/facebook/drawee/controller/ControllerListener;", "GetGetControllerListenerHandler")]
			get {
				const string __id = "getControllerListener.()Lcom/facebook/drawee/controller/ControllerListener;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Facebook.Drawee.Controller.IControllerListener> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getControllerOverlay;
#pragma warning disable 0169
		static Delegate GetGetControllerOverlayHandler ()
		{
			if (cb_getControllerOverlay == null)
				cb_getControllerOverlay = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetControllerOverlay);
			return cb_getControllerOverlay;
		}

		static IntPtr n_GetControllerOverlay (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Facebook.Drawee.Controller.AbstractDraweeController __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Drawee.Controller.AbstractDraweeController> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.ControllerOverlay);
		}
#pragma warning restore 0169

		static Delegate cb_setControllerOverlay_Landroid_graphics_drawable_Drawable_;
#pragma warning disable 0169
		static Delegate GetSetControllerOverlay_Landroid_graphics_drawable_Drawable_Handler ()
		{
			if (cb_setControllerOverlay_Landroid_graphics_drawable_Drawable_ == null)
				cb_setControllerOverlay_Landroid_graphics_drawable_Drawable_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetControllerOverlay_Landroid_graphics_drawable_Drawable_);
			return cb_setControllerOverlay_Landroid_graphics_drawable_Drawable_;
		}

		static void n_SetControllerOverlay_Landroid_graphics_drawable_Drawable_ (IntPtr jnienv, IntPtr native__this, IntPtr native_controllerOverlay)
		{
			global::Com.Facebook.Drawee.Controller.AbstractDraweeController __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Drawee.Controller.AbstractDraweeController> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Graphics.Drawables.Drawable controllerOverlay = global::Java.Lang.Object.GetObject<global::Android.Graphics.Drawables.Drawable> (native_controllerOverlay, JniHandleOwnership.DoNotTransfer);
			__this.ControllerOverlay = controllerOverlay;
		}
#pragma warning restore 0169

		protected virtual unsafe global::Android.Graphics.Drawables.Drawable ControllerOverlay {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.drawee.controller']/class[@name='AbstractDraweeController']/method[@name='getControllerOverlay' and count(parameter)=0]"
			[Register ("getControllerOverlay", "()Landroid/graphics/drawable/Drawable;", "GetGetControllerOverlayHandler")]
			get {
				const string __id = "getControllerOverlay.()Landroid/graphics/drawable/Drawable;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Android.Graphics.Drawables.Drawable> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.drawee.controller']/class[@name='AbstractDraweeController']/method[@name='setControllerOverlay' and count(parameter)=1 and parameter[1][@type='android.graphics.drawable.Drawable']]"
			[Register ("setControllerOverlay", "(Landroid/graphics/drawable/Drawable;)V", "GetSetControllerOverlay_Landroid_graphics_drawable_Drawable_Handler")]
			set {
				const string __id = "setControllerOverlay.(Landroid/graphics/drawable/Drawable;)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((value == null) ? IntPtr.Zero : ((global::Java.Lang.Object) value).Handle);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getDataSource;
#pragma warning disable 0169
		static Delegate GetGetDataSourceHandler ()
		{
			if (cb_getDataSource == null)
				cb_getDataSource = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetDataSource);
			return cb_getDataSource;
		}

		static IntPtr n_GetDataSource (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Facebook.Drawee.Controller.AbstractDraweeController __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Drawee.Controller.AbstractDraweeController> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.DataSource);
		}
#pragma warning restore 0169

		protected abstract global::Com.Facebook.Datasource.IDataSource DataSource {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.drawee.controller']/class[@name='AbstractDraweeController']/method[@name='getDataSource' and count(parameter)=0]"
			[Register ("getDataSource", "()Lcom/facebook/datasource/DataSource;", "GetGetDataSourceHandler")] get;
		}

		static Delegate cb_getGestureDetector;
#pragma warning disable 0169
		static Delegate GetGetGestureDetectorHandler ()
		{
			if (cb_getGestureDetector == null)
				cb_getGestureDetector = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetGestureDetector);
			return cb_getGestureDetector;
		}

		static IntPtr n_GetGestureDetector (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Facebook.Drawee.Controller.AbstractDraweeController __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Drawee.Controller.AbstractDraweeController> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.GestureDetector);
		}
#pragma warning restore 0169

		static Delegate cb_setGestureDetector_Lcom_facebook_drawee_gestures_GestureDetector_;
#pragma warning disable 0169
		static Delegate GetSetGestureDetector_Lcom_facebook_drawee_gestures_GestureDetector_Handler ()
		{
			if (cb_setGestureDetector_Lcom_facebook_drawee_gestures_GestureDetector_ == null)
				cb_setGestureDetector_Lcom_facebook_drawee_gestures_GestureDetector_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetGestureDetector_Lcom_facebook_drawee_gestures_GestureDetector_);
			return cb_setGestureDetector_Lcom_facebook_drawee_gestures_GestureDetector_;
		}

		static void n_SetGestureDetector_Lcom_facebook_drawee_gestures_GestureDetector_ (IntPtr jnienv, IntPtr native__this, IntPtr native_gestureDetector)
		{
			global::Com.Facebook.Drawee.Controller.AbstractDraweeController __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Drawee.Controller.AbstractDraweeController> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Facebook.Drawee.Gestures.GestureDetector gestureDetector = global::Java.Lang.Object.GetObject<global::Com.Facebook.Drawee.Gestures.GestureDetector> (native_gestureDetector, JniHandleOwnership.DoNotTransfer);
			__this.GestureDetector = gestureDetector;
		}
#pragma warning restore 0169

		protected virtual unsafe global::Com.Facebook.Drawee.Gestures.GestureDetector GestureDetector {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.drawee.controller']/class[@name='AbstractDraweeController']/method[@name='getGestureDetector' and count(parameter)=0]"
			[Register ("getGestureDetector", "()Lcom/facebook/drawee/gestures/GestureDetector;", "GetGetGestureDetectorHandler")]
			get {
				const string __id = "getGestureDetector.()Lcom/facebook/drawee/gestures/GestureDetector;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Facebook.Drawee.Gestures.GestureDetector> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.drawee.controller']/class[@name='AbstractDraweeController']/method[@name='setGestureDetector' and count(parameter)=1 and parameter[1][@type='com.facebook.drawee.gestures.GestureDetector']]"
			[Register ("setGestureDetector", "(Lcom/facebook/drawee/gestures/GestureDetector;)V", "GetSetGestureDetector_Lcom_facebook_drawee_gestures_GestureDetector_Handler")]
			set {
				const string __id = "setGestureDetector.(Lcom/facebook/drawee/gestures/GestureDetector;)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((value == null) ? IntPtr.Zero : ((global::Java.Lang.Object) value).Handle);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
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
			global::Com.Facebook.Drawee.Controller.AbstractDraweeController __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Drawee.Controller.AbstractDraweeController> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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

		static void n_SetHierarchy_Lcom_facebook_drawee_interfaces_DraweeHierarchy_ (IntPtr jnienv, IntPtr native__this, IntPtr native_hierarchy)
		{
			global::Com.Facebook.Drawee.Controller.AbstractDraweeController __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Drawee.Controller.AbstractDraweeController> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Facebook.Drawee.Interfaces.IDraweeHierarchy hierarchy = (global::Com.Facebook.Drawee.Interfaces.IDraweeHierarchy)global::Java.Lang.Object.GetObject<global::Com.Facebook.Drawee.Interfaces.IDraweeHierarchy> (native_hierarchy, JniHandleOwnership.DoNotTransfer);
			__this.Hierarchy = hierarchy;
		}
#pragma warning restore 0169

		public virtual unsafe global::Com.Facebook.Drawee.Interfaces.IDraweeHierarchy Hierarchy {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.drawee.controller']/class[@name='AbstractDraweeController']/method[@name='getHierarchy' and count(parameter)=0]"
			[Register ("getHierarchy", "()Lcom/facebook/drawee/interfaces/DraweeHierarchy;", "GetGetHierarchyHandler")]
			get {
				const string __id = "getHierarchy.()Lcom/facebook/drawee/interfaces/DraweeHierarchy;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Facebook.Drawee.Interfaces.IDraweeHierarchy> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.drawee.controller']/class[@name='AbstractDraweeController']/method[@name='setHierarchy' and count(parameter)=1 and parameter[1][@type='com.facebook.drawee.interfaces.DraweeHierarchy']]"
			[Register ("setHierarchy", "(Lcom/facebook/drawee/interfaces/DraweeHierarchy;)V", "GetSetHierarchy_Lcom_facebook_drawee_interfaces_DraweeHierarchy_Handler")]
			set {
				const string __id = "setHierarchy.(Lcom/facebook/drawee/interfaces/DraweeHierarchy;)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((value == null) ? IntPtr.Zero : ((global::Java.Lang.Object) value).Handle);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getId;
#pragma warning disable 0169
		static Delegate GetGetIdHandler ()
		{
			if (cb_getId == null)
				cb_getId = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetId);
			return cb_getId;
		}

		static IntPtr n_GetId (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Facebook.Drawee.Controller.AbstractDraweeController __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Drawee.Controller.AbstractDraweeController> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Id);
		}
#pragma warning restore 0169

		public virtual unsafe string Id {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.drawee.controller']/class[@name='AbstractDraweeController']/method[@name='getId' and count(parameter)=0]"
			[Register ("getId", "()Ljava/lang/String;", "GetGetIdHandler")]
			get {
				const string __id = "getId.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getRetryManager;
#pragma warning disable 0169
		static Delegate GetGetRetryManagerHandler ()
		{
			if (cb_getRetryManager == null)
				cb_getRetryManager = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetRetryManager);
			return cb_getRetryManager;
		}

		static IntPtr n_GetRetryManager (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Facebook.Drawee.Controller.AbstractDraweeController __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Drawee.Controller.AbstractDraweeController> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.RetryManager);
		}
#pragma warning restore 0169

		protected virtual unsafe global::Com.Facebook.Drawee.Components.RetryManager RetryManager {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.drawee.controller']/class[@name='AbstractDraweeController']/method[@name='getRetryManager' and count(parameter)=0]"
			[Register ("getRetryManager", "()Lcom/facebook/drawee/components/RetryManager;", "GetGetRetryManagerHandler")]
			get {
				const string __id = "getRetryManager.()Lcom/facebook/drawee/components/RetryManager;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Facebook.Drawee.Components.RetryManager> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_addControllerListener_Lcom_facebook_drawee_controller_ControllerListener_;
#pragma warning disable 0169
		static Delegate GetAddControllerListener_Lcom_facebook_drawee_controller_ControllerListener_Handler ()
		{
			if (cb_addControllerListener_Lcom_facebook_drawee_controller_ControllerListener_ == null)
				cb_addControllerListener_Lcom_facebook_drawee_controller_ControllerListener_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_AddControllerListener_Lcom_facebook_drawee_controller_ControllerListener_);
			return cb_addControllerListener_Lcom_facebook_drawee_controller_ControllerListener_;
		}

		static void n_AddControllerListener_Lcom_facebook_drawee_controller_ControllerListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_controllerListener)
		{
			global::Com.Facebook.Drawee.Controller.AbstractDraweeController __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Drawee.Controller.AbstractDraweeController> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Facebook.Drawee.Controller.IControllerListener controllerListener = (global::Com.Facebook.Drawee.Controller.IControllerListener)global::Java.Lang.Object.GetObject<global::Com.Facebook.Drawee.Controller.IControllerListener> (native_controllerListener, JniHandleOwnership.DoNotTransfer);
			__this.AddControllerListener (controllerListener);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.drawee.controller']/class[@name='AbstractDraweeController']/method[@name='addControllerListener' and count(parameter)=1 and parameter[1][@type='com.facebook.drawee.controller.ControllerListener&lt;? super INFO&gt;']]"
		[Register ("addControllerListener", "(Lcom/facebook/drawee/controller/ControllerListener;)V", "GetAddControllerListener_Lcom_facebook_drawee_controller_ControllerListener_Handler")]
		public virtual unsafe void AddControllerListener (global::Com.Facebook.Drawee.Controller.IControllerListener controllerListener)
		{
			const string __id = "addControllerListener.(Lcom/facebook/drawee/controller/ControllerListener;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((controllerListener == null) ? IntPtr.Zero : ((global::Java.Lang.Object) controllerListener).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_createDrawable_Ljava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetCreateDrawable_Ljava_lang_Object_Handler ()
		{
			if (cb_createDrawable_Ljava_lang_Object_ == null)
				cb_createDrawable_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_CreateDrawable_Ljava_lang_Object_);
			return cb_createDrawable_Ljava_lang_Object_;
		}

		static IntPtr n_CreateDrawable_Ljava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Facebook.Drawee.Controller.AbstractDraweeController __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Drawee.Controller.AbstractDraweeController> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.CreateDrawable (p0));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.drawee.controller']/class[@name='AbstractDraweeController']/method[@name='createDrawable' and count(parameter)=1 and parameter[1][@type='T']]"
		[Register ("createDrawable", "(Ljava/lang/Object;)Landroid/graphics/drawable/Drawable;", "GetCreateDrawable_Ljava_lang_Object_Handler")]
		protected abstract global::Android.Graphics.Drawables.Drawable CreateDrawable (global::Java.Lang.Object p0);

		static Delegate cb_getImageClass_Ljava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetGetImageClass_Ljava_lang_Object_Handler ()
		{
			if (cb_getImageClass_Ljava_lang_Object_ == null)
				cb_getImageClass_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_GetImageClass_Ljava_lang_Object_);
			return cb_getImageClass_Ljava_lang_Object_;
		}

		static IntPtr n_GetImageClass_Ljava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_image)
		{
			global::Com.Facebook.Drawee.Controller.AbstractDraweeController __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Drawee.Controller.AbstractDraweeController> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object image = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_image, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewString (__this.GetImageClass (image));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.drawee.controller']/class[@name='AbstractDraweeController']/method[@name='getImageClass' and count(parameter)=1 and parameter[1][@type='T']]"
		[Register ("getImageClass", "(Ljava/lang/Object;)Ljava/lang/String;", "GetGetImageClass_Ljava_lang_Object_Handler")]
		protected virtual unsafe string GetImageClass (global::Java.Lang.Object image)
		{
			const string __id = "getImageClass.(Ljava/lang/Object;)Ljava/lang/String;";
			IntPtr native_image = JNIEnv.ToLocalJniHandle (image);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_image);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_image);
			}
		}

		static Delegate cb_getImageHash_Ljava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetGetImageHash_Ljava_lang_Object_Handler ()
		{
			if (cb_getImageHash_Ljava_lang_Object_ == null)
				cb_getImageHash_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, int>) n_GetImageHash_Ljava_lang_Object_);
			return cb_getImageHash_Ljava_lang_Object_;
		}

		static int n_GetImageHash_Ljava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_image)
		{
			global::Com.Facebook.Drawee.Controller.AbstractDraweeController __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Drawee.Controller.AbstractDraweeController> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object image = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_image, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.GetImageHash (image);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.drawee.controller']/class[@name='AbstractDraweeController']/method[@name='getImageHash' and count(parameter)=1 and parameter[1][@type='T']]"
		[Register ("getImageHash", "(Ljava/lang/Object;)I", "GetGetImageHash_Ljava_lang_Object_Handler")]
		protected virtual unsafe int GetImageHash (global::Java.Lang.Object image)
		{
			const string __id = "getImageHash.(Ljava/lang/Object;)I";
			IntPtr native_image = JNIEnv.ToLocalJniHandle (image);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_image);
				var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, __args);
				return __rm;
			} finally {
				JNIEnv.DeleteLocalRef (native_image);
			}
		}

		static Delegate cb_getImageInfo_Ljava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetGetImageInfo_Ljava_lang_Object_Handler ()
		{
			if (cb_getImageInfo_Ljava_lang_Object_ == null)
				cb_getImageInfo_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_GetImageInfo_Ljava_lang_Object_);
			return cb_getImageInfo_Ljava_lang_Object_;
		}

		static IntPtr n_GetImageInfo_Ljava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Facebook.Drawee.Controller.AbstractDraweeController __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Drawee.Controller.AbstractDraweeController> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetImageInfo (p0));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.drawee.controller']/class[@name='AbstractDraweeController']/method[@name='getImageInfo' and count(parameter)=1 and parameter[1][@type='T']]"
		[Register ("getImageInfo", "(Ljava/lang/Object;)Ljava/lang/Object;", "GetGetImageInfo_Ljava_lang_Object_Handler")]
		protected abstract global::Java.Lang.Object GetImageInfo (global::Java.Lang.Object p0);

		static Delegate cb_initialize_Ljava_lang_String_Ljava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetInitialize_Ljava_lang_String_Ljava_lang_Object_Handler ()
		{
			if (cb_initialize_Ljava_lang_String_Ljava_lang_Object_ == null)
				cb_initialize_Ljava_lang_String_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_Initialize_Ljava_lang_String_Ljava_lang_Object_);
			return cb_initialize_Ljava_lang_String_Ljava_lang_Object_;
		}

		static void n_Initialize_Ljava_lang_String_Ljava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_id, IntPtr native_callerContext)
		{
			global::Com.Facebook.Drawee.Controller.AbstractDraweeController __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Drawee.Controller.AbstractDraweeController> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string id = JNIEnv.GetString (native_id, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object callerContext = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_callerContext, JniHandleOwnership.DoNotTransfer);
			__this.Initialize (id, callerContext);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.drawee.controller']/class[@name='AbstractDraweeController']/method[@name='initialize' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.Object']]"
		[Register ("initialize", "(Ljava/lang/String;Ljava/lang/Object;)V", "GetInitialize_Ljava_lang_String_Ljava_lang_Object_Handler")]
		protected virtual unsafe void Initialize (string id, global::Java.Lang.Object callerContext)
		{
			const string __id = "initialize.(Ljava/lang/String;Ljava/lang/Object;)V";
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
			global::Com.Facebook.Drawee.Controller.AbstractDraweeController __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Drawee.Controller.AbstractDraweeController> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnAttach ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.drawee.controller']/class[@name='AbstractDraweeController']/method[@name='onAttach' and count(parameter)=0]"
		[Register ("onAttach", "()V", "GetOnAttachHandler")]
		public virtual unsafe void OnAttach ()
		{
			const string __id = "onAttach.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_onClick;
#pragma warning disable 0169
		static Delegate GetOnClickHandler ()
		{
			if (cb_onClick == null)
				cb_onClick = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_OnClick);
			return cb_onClick;
		}

		static bool n_OnClick (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Facebook.Drawee.Controller.AbstractDraweeController __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Drawee.Controller.AbstractDraweeController> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.OnClick ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.drawee.controller']/class[@name='AbstractDraweeController']/method[@name='onClick' and count(parameter)=0]"
		[Register ("onClick", "()Z", "GetOnClickHandler")]
		public virtual unsafe bool OnClick ()
		{
			const string __id = "onClick.()Z";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
				return __rm;
			} finally {
			}
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
			global::Com.Facebook.Drawee.Controller.AbstractDraweeController __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Drawee.Controller.AbstractDraweeController> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnDetach ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.drawee.controller']/class[@name='AbstractDraweeController']/method[@name='onDetach' and count(parameter)=0]"
		[Register ("onDetach", "()V", "GetOnDetachHandler")]
		public virtual unsafe void OnDetach ()
		{
			const string __id = "onDetach.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_onImageLoadedFromCacheImmediately_Ljava_lang_String_Ljava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetOnImageLoadedFromCacheImmediately_Ljava_lang_String_Ljava_lang_Object_Handler ()
		{
			if (cb_onImageLoadedFromCacheImmediately_Ljava_lang_String_Ljava_lang_Object_ == null)
				cb_onImageLoadedFromCacheImmediately_Ljava_lang_String_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_OnImageLoadedFromCacheImmediately_Ljava_lang_String_Ljava_lang_Object_);
			return cb_onImageLoadedFromCacheImmediately_Ljava_lang_String_Ljava_lang_Object_;
		}

		static void n_OnImageLoadedFromCacheImmediately_Ljava_lang_String_Ljava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_id, IntPtr native_cachedImage)
		{
			global::Com.Facebook.Drawee.Controller.AbstractDraweeController __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Drawee.Controller.AbstractDraweeController> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string id = JNIEnv.GetString (native_id, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object cachedImage = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_cachedImage, JniHandleOwnership.DoNotTransfer);
			__this.OnImageLoadedFromCacheImmediately (id, cachedImage);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.drawee.controller']/class[@name='AbstractDraweeController']/method[@name='onImageLoadedFromCacheImmediately' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='T']]"
		[Register ("onImageLoadedFromCacheImmediately", "(Ljava/lang/String;Ljava/lang/Object;)V", "GetOnImageLoadedFromCacheImmediately_Ljava_lang_String_Ljava_lang_Object_Handler")]
		protected virtual unsafe void OnImageLoadedFromCacheImmediately (string id, global::Java.Lang.Object cachedImage)
		{
			const string __id = "onImageLoadedFromCacheImmediately.(Ljava/lang/String;Ljava/lang/Object;)V";
			IntPtr native_id = JNIEnv.NewString (id);
			IntPtr native_cachedImage = JNIEnv.ToLocalJniHandle (cachedImage);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_id);
				__args [1] = new JniArgumentValue (native_cachedImage);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_id);
				JNIEnv.DeleteLocalRef (native_cachedImage);
			}
		}

		static Delegate cb_onTouchEvent_Landroid_view_MotionEvent_;
#pragma warning disable 0169
		static Delegate GetOnTouchEvent_Landroid_view_MotionEvent_Handler ()
		{
			if (cb_onTouchEvent_Landroid_view_MotionEvent_ == null)
				cb_onTouchEvent_Landroid_view_MotionEvent_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_OnTouchEvent_Landroid_view_MotionEvent_);
			return cb_onTouchEvent_Landroid_view_MotionEvent_;
		}

		static bool n_OnTouchEvent_Landroid_view_MotionEvent_ (IntPtr jnienv, IntPtr native__this, IntPtr native_e)
		{
			global::Com.Facebook.Drawee.Controller.AbstractDraweeController __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Drawee.Controller.AbstractDraweeController> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Views.MotionEvent e = global::Java.Lang.Object.GetObject<global::Android.Views.MotionEvent> (native_e, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.OnTouchEvent (e);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.drawee.controller']/class[@name='AbstractDraweeController']/method[@name='onTouchEvent' and count(parameter)=1 and parameter[1][@type='android.view.MotionEvent']]"
		[Register ("onTouchEvent", "(Landroid/view/MotionEvent;)Z", "GetOnTouchEvent_Landroid_view_MotionEvent_Handler")]
		public virtual unsafe bool OnTouchEvent (global::Android.Views.MotionEvent e)
		{
			const string __id = "onTouchEvent.(Landroid/view/MotionEvent;)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((e == null) ? IntPtr.Zero : ((global::Java.Lang.Object) e).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_onViewportVisibilityHint_Z;
#pragma warning disable 0169
		static Delegate GetOnViewportVisibilityHint_ZHandler ()
		{
			if (cb_onViewportVisibilityHint_Z == null)
				cb_onViewportVisibilityHint_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_OnViewportVisibilityHint_Z);
			return cb_onViewportVisibilityHint_Z;
		}

		static void n_OnViewportVisibilityHint_Z (IntPtr jnienv, IntPtr native__this, bool isVisibleInViewportHint)
		{
			global::Com.Facebook.Drawee.Controller.AbstractDraweeController __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Drawee.Controller.AbstractDraweeController> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnViewportVisibilityHint (isVisibleInViewportHint);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.drawee.controller']/class[@name='AbstractDraweeController']/method[@name='onViewportVisibilityHint' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("onViewportVisibilityHint", "(Z)V", "GetOnViewportVisibilityHint_ZHandler")]
		public virtual unsafe void OnViewportVisibilityHint (bool isVisibleInViewportHint)
		{
			const string __id = "onViewportVisibilityHint.(Z)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (isVisibleInViewportHint);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_release;
#pragma warning disable 0169
		static Delegate GetReleaseHandler ()
		{
			if (cb_release == null)
				cb_release = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Release);
			return cb_release;
		}

		static void n_Release (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Facebook.Drawee.Controller.AbstractDraweeController __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Drawee.Controller.AbstractDraweeController> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Release ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.drawee.controller']/class[@name='AbstractDraweeController']/method[@name='release' and count(parameter)=0]"
		[Register ("release", "()V", "GetReleaseHandler")]
		public virtual unsafe void Release ()
		{
			const string __id = "release.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_releaseDrawable_Landroid_graphics_drawable_Drawable_;
#pragma warning disable 0169
		static Delegate GetReleaseDrawable_Landroid_graphics_drawable_Drawable_Handler ()
		{
			if (cb_releaseDrawable_Landroid_graphics_drawable_Drawable_ == null)
				cb_releaseDrawable_Landroid_graphics_drawable_Drawable_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_ReleaseDrawable_Landroid_graphics_drawable_Drawable_);
			return cb_releaseDrawable_Landroid_graphics_drawable_Drawable_;
		}

		static void n_ReleaseDrawable_Landroid_graphics_drawable_Drawable_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Facebook.Drawee.Controller.AbstractDraweeController __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Drawee.Controller.AbstractDraweeController> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Graphics.Drawables.Drawable p0 = global::Java.Lang.Object.GetObject<global::Android.Graphics.Drawables.Drawable> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.ReleaseDrawable (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.drawee.controller']/class[@name='AbstractDraweeController']/method[@name='releaseDrawable' and count(parameter)=1 and parameter[1][@type='android.graphics.drawable.Drawable']]"
		[Register ("releaseDrawable", "(Landroid/graphics/drawable/Drawable;)V", "GetReleaseDrawable_Landroid_graphics_drawable_Drawable_Handler")]
		protected abstract void ReleaseDrawable (global::Android.Graphics.Drawables.Drawable p0);

		static Delegate cb_releaseImage_Ljava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetReleaseImage_Ljava_lang_Object_Handler ()
		{
			if (cb_releaseImage_Ljava_lang_Object_ == null)
				cb_releaseImage_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_ReleaseImage_Ljava_lang_Object_);
			return cb_releaseImage_Ljava_lang_Object_;
		}

		static void n_ReleaseImage_Ljava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Facebook.Drawee.Controller.AbstractDraweeController __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Drawee.Controller.AbstractDraweeController> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.ReleaseImage (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.drawee.controller']/class[@name='AbstractDraweeController']/method[@name='releaseImage' and count(parameter)=1 and parameter[1][@type='T']]"
		[Register ("releaseImage", "(Ljava/lang/Object;)V", "GetReleaseImage_Ljava_lang_Object_Handler")]
		protected abstract void ReleaseImage (global::Java.Lang.Object p0);

		static Delegate cb_removeControllerListener_Lcom_facebook_drawee_controller_ControllerListener_;
#pragma warning disable 0169
		static Delegate GetRemoveControllerListener_Lcom_facebook_drawee_controller_ControllerListener_Handler ()
		{
			if (cb_removeControllerListener_Lcom_facebook_drawee_controller_ControllerListener_ == null)
				cb_removeControllerListener_Lcom_facebook_drawee_controller_ControllerListener_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_RemoveControllerListener_Lcom_facebook_drawee_controller_ControllerListener_);
			return cb_removeControllerListener_Lcom_facebook_drawee_controller_ControllerListener_;
		}

		static void n_RemoveControllerListener_Lcom_facebook_drawee_controller_ControllerListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_controllerListener)
		{
			global::Com.Facebook.Drawee.Controller.AbstractDraweeController __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Drawee.Controller.AbstractDraweeController> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Facebook.Drawee.Controller.IControllerListener controllerListener = (global::Com.Facebook.Drawee.Controller.IControllerListener)global::Java.Lang.Object.GetObject<global::Com.Facebook.Drawee.Controller.IControllerListener> (native_controllerListener, JniHandleOwnership.DoNotTransfer);
			__this.RemoveControllerListener (controllerListener);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.drawee.controller']/class[@name='AbstractDraweeController']/method[@name='removeControllerListener' and count(parameter)=1 and parameter[1][@type='com.facebook.drawee.controller.ControllerListener&lt;? super INFO&gt;']]"
		[Register ("removeControllerListener", "(Lcom/facebook/drawee/controller/ControllerListener;)V", "GetRemoveControllerListener_Lcom_facebook_drawee_controller_ControllerListener_Handler")]
		public virtual unsafe void RemoveControllerListener (global::Com.Facebook.Drawee.Controller.IControllerListener controllerListener)
		{
			const string __id = "removeControllerListener.(Lcom/facebook/drawee/controller/ControllerListener;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((controllerListener == null) ? IntPtr.Zero : ((global::Java.Lang.Object) controllerListener).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_setControllerViewportVisibilityListener_Lcom_facebook_drawee_controller_ControllerViewportVisibilityListener_;
#pragma warning disable 0169
		static Delegate GetSetControllerViewportVisibilityListener_Lcom_facebook_drawee_controller_ControllerViewportVisibilityListener_Handler ()
		{
			if (cb_setControllerViewportVisibilityListener_Lcom_facebook_drawee_controller_ControllerViewportVisibilityListener_ == null)
				cb_setControllerViewportVisibilityListener_Lcom_facebook_drawee_controller_ControllerViewportVisibilityListener_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetControllerViewportVisibilityListener_Lcom_facebook_drawee_controller_ControllerViewportVisibilityListener_);
			return cb_setControllerViewportVisibilityListener_Lcom_facebook_drawee_controller_ControllerViewportVisibilityListener_;
		}

		static void n_SetControllerViewportVisibilityListener_Lcom_facebook_drawee_controller_ControllerViewportVisibilityListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_controllerViewportVisibilityListener)
		{
			global::Com.Facebook.Drawee.Controller.AbstractDraweeController __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Drawee.Controller.AbstractDraweeController> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Facebook.Drawee.Controller.IControllerViewportVisibilityListener controllerViewportVisibilityListener = (global::Com.Facebook.Drawee.Controller.IControllerViewportVisibilityListener)global::Java.Lang.Object.GetObject<global::Com.Facebook.Drawee.Controller.IControllerViewportVisibilityListener> (native_controllerViewportVisibilityListener, JniHandleOwnership.DoNotTransfer);
			__this.SetControllerViewportVisibilityListener (controllerViewportVisibilityListener);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.drawee.controller']/class[@name='AbstractDraweeController']/method[@name='setControllerViewportVisibilityListener' and count(parameter)=1 and parameter[1][@type='com.facebook.drawee.controller.ControllerViewportVisibilityListener']]"
		[Register ("setControllerViewportVisibilityListener", "(Lcom/facebook/drawee/controller/ControllerViewportVisibilityListener;)V", "GetSetControllerViewportVisibilityListener_Lcom_facebook_drawee_controller_ControllerViewportVisibilityListener_Handler")]
		public virtual unsafe void SetControllerViewportVisibilityListener (global::Com.Facebook.Drawee.Controller.IControllerViewportVisibilityListener controllerViewportVisibilityListener)
		{
			const string __id = "setControllerViewportVisibilityListener.(Lcom/facebook/drawee/controller/ControllerViewportVisibilityListener;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((controllerViewportVisibilityListener == null) ? IntPtr.Zero : ((global::Java.Lang.Object) controllerViewportVisibilityListener).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_setRetainImageOnFailure_Z;
#pragma warning disable 0169
		static Delegate GetSetRetainImageOnFailure_ZHandler ()
		{
			if (cb_setRetainImageOnFailure_Z == null)
				cb_setRetainImageOnFailure_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_SetRetainImageOnFailure_Z);
			return cb_setRetainImageOnFailure_Z;
		}

		static void n_SetRetainImageOnFailure_Z (IntPtr jnienv, IntPtr native__this, bool enabled)
		{
			global::Com.Facebook.Drawee.Controller.AbstractDraweeController __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Drawee.Controller.AbstractDraweeController> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetRetainImageOnFailure (enabled);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.drawee.controller']/class[@name='AbstractDraweeController']/method[@name='setRetainImageOnFailure' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("setRetainImageOnFailure", "(Z)V", "GetSetRetainImageOnFailure_ZHandler")]
		protected virtual unsafe void SetRetainImageOnFailure (bool enabled)
		{
			const string __id = "setRetainImageOnFailure.(Z)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (enabled);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_shouldHandleGesture;
#pragma warning disable 0169
		static Delegate GetShouldHandleGestureHandler ()
		{
			if (cb_shouldHandleGesture == null)
				cb_shouldHandleGesture = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_ShouldHandleGesture);
			return cb_shouldHandleGesture;
		}

		static bool n_ShouldHandleGesture (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Facebook.Drawee.Controller.AbstractDraweeController __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Drawee.Controller.AbstractDraweeController> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ShouldHandleGesture ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.drawee.controller']/class[@name='AbstractDraweeController']/method[@name='shouldHandleGesture' and count(parameter)=0]"
		[Register ("shouldHandleGesture", "()Z", "GetShouldHandleGestureHandler")]
		protected virtual unsafe bool ShouldHandleGesture ()
		{
			const string __id = "shouldHandleGesture.()Z";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_submitRequest;
#pragma warning disable 0169
		static Delegate GetSubmitRequestHandler ()
		{
			if (cb_submitRequest == null)
				cb_submitRequest = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_SubmitRequest);
			return cb_submitRequest;
		}

		static void n_SubmitRequest (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Facebook.Drawee.Controller.AbstractDraweeController __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Drawee.Controller.AbstractDraweeController> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SubmitRequest ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.drawee.controller']/class[@name='AbstractDraweeController']/method[@name='submitRequest' and count(parameter)=0]"
		[Register ("submitRequest", "()V", "GetSubmitRequestHandler")]
		protected virtual unsafe void SubmitRequest ()
		{
			const string __id = "submitRequest.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

#region "Event implementation for Com.Facebook.Drawee.Controller.IControllerViewportVisibilityListener"
		public event EventHandler<global::Com.Facebook.Drawee.Controller.DraweeViewportEntryEventArgs> DraweeViewportEntry {
			add {
				global::Java.Interop.EventHelper.AddEventHandler<global::Com.Facebook.Drawee.Controller.IControllerViewportVisibilityListener, global::Com.Facebook.Drawee.Controller.IControllerViewportVisibilityListenerImplementor>(
						ref weak_implementor_SetControllerViewportVisibilityListener,
						__CreateIControllerViewportVisibilityListenerImplementor,
						SetControllerViewportVisibilityListener,
						__h => __h.OnDraweeViewportEntryHandler += value);
			}
			remove {
				global::Java.Interop.EventHelper.RemoveEventHandler<global::Com.Facebook.Drawee.Controller.IControllerViewportVisibilityListener, global::Com.Facebook.Drawee.Controller.IControllerViewportVisibilityListenerImplementor>(
						ref weak_implementor_SetControllerViewportVisibilityListener,
						global::Com.Facebook.Drawee.Controller.IControllerViewportVisibilityListenerImplementor.__IsEmpty,
						__v => SetControllerViewportVisibilityListener (null),
						__h => __h.OnDraweeViewportEntryHandler -= value);
			}
		}

		public event EventHandler<global::Com.Facebook.Drawee.Controller.DraweeViewportExitEventArgs> DraweeViewportExit {
			add {
				global::Java.Interop.EventHelper.AddEventHandler<global::Com.Facebook.Drawee.Controller.IControllerViewportVisibilityListener, global::Com.Facebook.Drawee.Controller.IControllerViewportVisibilityListenerImplementor>(
						ref weak_implementor_SetControllerViewportVisibilityListener,
						__CreateIControllerViewportVisibilityListenerImplementor,
						SetControllerViewportVisibilityListener,
						__h => __h.OnDraweeViewportExitHandler += value);
			}
			remove {
				global::Java.Interop.EventHelper.RemoveEventHandler<global::Com.Facebook.Drawee.Controller.IControllerViewportVisibilityListener, global::Com.Facebook.Drawee.Controller.IControllerViewportVisibilityListenerImplementor>(
						ref weak_implementor_SetControllerViewportVisibilityListener,
						global::Com.Facebook.Drawee.Controller.IControllerViewportVisibilityListenerImplementor.__IsEmpty,
						__v => SetControllerViewportVisibilityListener (null),
						__h => __h.OnDraweeViewportExitHandler -= value);
			}
		}

		WeakReference weak_implementor_SetControllerViewportVisibilityListener;

		global::Com.Facebook.Drawee.Controller.IControllerViewportVisibilityListenerImplementor __CreateIControllerViewportVisibilityListenerImplementor ()
		{
			return new global::Com.Facebook.Drawee.Controller.IControllerViewportVisibilityListenerImplementor (this);
		}
#endregion
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
			global::Com.Facebook.Drawee.Controller.AbstractDraweeController __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Drawee.Controller.AbstractDraweeController> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Facebook.Drawee.Interfaces.IDraweeController p0 = (global::Com.Facebook.Drawee.Interfaces.IDraweeController)global::Java.Lang.Object.GetObject<global::Com.Facebook.Drawee.Interfaces.IDraweeController> (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.IsSameImageRequest (p0);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.drawee.interfaces']/interface[@name='DraweeController']/method[@name='isSameImageRequest' and count(parameter)=1 and parameter[1][@type='com.facebook.drawee.interfaces.DraweeController']]"
		[Register ("isSameImageRequest", "(Lcom/facebook/drawee/interfaces/DraweeController;)Z", "GetIsSameImageRequest_Lcom_facebook_drawee_interfaces_DraweeController_Handler")]
		public abstract bool IsSameImageRequest (global::Com.Facebook.Drawee.Interfaces.IDraweeController p0);

	}

	[global::Android.Runtime.Register ("com/facebook/drawee/controller/AbstractDraweeController", DoNotGenerateAcw=true)]
	internal partial class AbstractDraweeControllerInvoker : AbstractDraweeController {

		public AbstractDraweeControllerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/facebook/drawee/controller/AbstractDraweeController", typeof (AbstractDraweeControllerInvoker));

		public override global::Java.Interop.JniPeerMembers JniPeerMembers {
			get { return _members; }
		}

		protected override global::System.Type ThresholdType {
			get { return _members.ManagedPeerType; }
		}

		protected override unsafe global::Com.Facebook.Datasource.IDataSource DataSource {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.drawee.controller']/class[@name='AbstractDraweeController']/method[@name='getDataSource' and count(parameter)=0]"
			[Register ("getDataSource", "()Lcom/facebook/datasource/DataSource;", "GetGetDataSourceHandler")]
			get {
				const string __id = "getDataSource.()Lcom/facebook/datasource/DataSource;";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Facebook.Datasource.IDataSource> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.drawee.controller']/class[@name='AbstractDraweeController']/method[@name='createDrawable' and count(parameter)=1 and parameter[1][@type='T']]"
		[Register ("createDrawable", "(Ljava/lang/Object;)Landroid/graphics/drawable/Drawable;", "GetCreateDrawable_Ljava_lang_Object_Handler")]
		protected override unsafe global::Android.Graphics.Drawables.Drawable CreateDrawable (global::Java.Lang.Object p0)
		{
			const string __id = "createDrawable.(Ljava/lang/Object;)Landroid/graphics/drawable/Drawable;";
			IntPtr native_p0 = JNIEnv.ToLocalJniHandle (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_p0);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Android.Graphics.Drawables.Drawable> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.drawee.controller']/class[@name='AbstractDraweeController']/method[@name='getImageInfo' and count(parameter)=1 and parameter[1][@type='T']]"
		[Register ("getImageInfo", "(Ljava/lang/Object;)Ljava/lang/Object;", "GetGetImageInfo_Ljava_lang_Object_Handler")]
		protected override unsafe global::Java.Lang.Object GetImageInfo (global::Java.Lang.Object p0)
		{
			const string __id = "getImageInfo.(Ljava/lang/Object;)Ljava/lang/Object;";
			IntPtr native_p0 = JNIEnv.ToLocalJniHandle (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_p0);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.drawee.controller']/class[@name='AbstractDraweeController']/method[@name='releaseDrawable' and count(parameter)=1 and parameter[1][@type='android.graphics.drawable.Drawable']]"
		[Register ("releaseDrawable", "(Landroid/graphics/drawable/Drawable;)V", "GetReleaseDrawable_Landroid_graphics_drawable_Drawable_Handler")]
		protected override unsafe void ReleaseDrawable (global::Android.Graphics.Drawables.Drawable p0)
		{
			const string __id = "releaseDrawable.(Landroid/graphics/drawable/Drawable;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.drawee.controller']/class[@name='AbstractDraweeController']/method[@name='releaseImage' and count(parameter)=1 and parameter[1][@type='T']]"
		[Register ("releaseImage", "(Ljava/lang/Object;)V", "GetReleaseImage_Ljava_lang_Object_Handler")]
		protected override unsafe void ReleaseImage (global::Java.Lang.Object p0)
		{
			const string __id = "releaseImage.(Ljava/lang/Object;)V";
			IntPtr native_p0 = JNIEnv.ToLocalJniHandle (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_p0);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.drawee.interfaces']/interface[@name='DraweeController']/method[@name='isSameImageRequest' and count(parameter)=1 and parameter[1][@type='com.facebook.drawee.interfaces.DraweeController']]"
		[Register ("isSameImageRequest", "(Lcom/facebook/drawee/interfaces/DraweeController;)Z", "GetIsSameImageRequest_Lcom_facebook_drawee_interfaces_DraweeController_Handler")]
		public override unsafe bool IsSameImageRequest (global::Com.Facebook.Drawee.Interfaces.IDraweeController p0)
		{
			const string __id = "isSameImageRequest.(Lcom/facebook/drawee/interfaces/DraweeController;)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				var __rm = _members.InstanceMethods.InvokeAbstractBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
			}
		}

	}

}
