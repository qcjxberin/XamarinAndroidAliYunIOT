using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Facebook.Drawee.View {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.facebook.drawee.view']/class[@name='DraweeHolder']"
	[global::Android.Runtime.Register ("com/facebook/drawee/view/DraweeHolder", DoNotGenerateAcw=true)]
	[global::Java.Interop.JavaTypeParameters (new string [] {"DH extends com.facebook.drawee.interfaces.DraweeHierarchy"})]
	public partial class DraweeHolder : global::Java.Lang.Object, global::Com.Facebook.Drawee.Drawable.IVisibilityCallback {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/facebook/drawee/view/DraweeHolder", typeof (DraweeHolder));
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

		protected DraweeHolder (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.facebook.drawee.view']/class[@name='DraweeHolder']/constructor[@name='DraweeHolder' and count(parameter)=1 and parameter[1][@type='DH']]"
		[Register (".ctor", "(Lcom/facebook/drawee/interfaces/DraweeHierarchy;)V", "")]
		public unsafe DraweeHolder (global::Java.Lang.Object hierarchy)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Lcom/facebook/drawee/interfaces/DraweeHierarchy;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_hierarchy = JNIEnv.ToLocalJniHandle (hierarchy);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_hierarchy);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_hierarchy);
			}
		}

		static Delegate cb_getController;
#pragma warning disable 0169
		static Delegate GetGetControllerHandler ()
		{
			if (cb_getController == null)
				cb_getController = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetController);
			return cb_getController;
		}

		static IntPtr n_GetController (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Facebook.Drawee.View.DraweeHolder __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Drawee.View.DraweeHolder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Controller);
		}
#pragma warning restore 0169

		static Delegate cb_setController_Lcom_facebook_drawee_interfaces_DraweeController_;
#pragma warning disable 0169
		static Delegate GetSetController_Lcom_facebook_drawee_interfaces_DraweeController_Handler ()
		{
			if (cb_setController_Lcom_facebook_drawee_interfaces_DraweeController_ == null)
				cb_setController_Lcom_facebook_drawee_interfaces_DraweeController_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetController_Lcom_facebook_drawee_interfaces_DraweeController_);
			return cb_setController_Lcom_facebook_drawee_interfaces_DraweeController_;
		}

		static void n_SetController_Lcom_facebook_drawee_interfaces_DraweeController_ (IntPtr jnienv, IntPtr native__this, IntPtr native_draweeController)
		{
			global::Com.Facebook.Drawee.View.DraweeHolder __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Drawee.View.DraweeHolder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Facebook.Drawee.Interfaces.IDraweeController draweeController = (global::Com.Facebook.Drawee.Interfaces.IDraweeController)global::Java.Lang.Object.GetObject<global::Com.Facebook.Drawee.Interfaces.IDraweeController> (native_draweeController, JniHandleOwnership.DoNotTransfer);
			__this.Controller = draweeController;
		}
#pragma warning restore 0169

		public virtual unsafe global::Com.Facebook.Drawee.Interfaces.IDraweeController Controller {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.drawee.view']/class[@name='DraweeHolder']/method[@name='getController' and count(parameter)=0]"
			[Register ("getController", "()Lcom/facebook/drawee/interfaces/DraweeController;", "GetGetControllerHandler")]
			get {
				const string __id = "getController.()Lcom/facebook/drawee/interfaces/DraweeController;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Facebook.Drawee.Interfaces.IDraweeController> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.drawee.view']/class[@name='DraweeHolder']/method[@name='setController' and count(parameter)=1 and parameter[1][@type='com.facebook.drawee.interfaces.DraweeController']]"
			[Register ("setController", "(Lcom/facebook/drawee/interfaces/DraweeController;)V", "GetSetController_Lcom_facebook_drawee_interfaces_DraweeController_Handler")]
			set {
				const string __id = "setController.(Lcom/facebook/drawee/interfaces/DraweeController;)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((value == null) ? IntPtr.Zero : ((global::Java.Lang.Object) value).Handle);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getDraweeEventTracker;
#pragma warning disable 0169
		static Delegate GetGetDraweeEventTrackerHandler ()
		{
			if (cb_getDraweeEventTracker == null)
				cb_getDraweeEventTracker = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetDraweeEventTracker);
			return cb_getDraweeEventTracker;
		}

		static IntPtr n_GetDraweeEventTracker (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Facebook.Drawee.View.DraweeHolder __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Drawee.View.DraweeHolder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.DraweeEventTracker);
		}
#pragma warning restore 0169

		protected virtual unsafe global::Com.Facebook.Drawee.Components.DraweeEventTracker DraweeEventTracker {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.drawee.view']/class[@name='DraweeHolder']/method[@name='getDraweeEventTracker' and count(parameter)=0]"
			[Register ("getDraweeEventTracker", "()Lcom/facebook/drawee/components/DraweeEventTracker;", "GetGetDraweeEventTrackerHandler")]
			get {
				const string __id = "getDraweeEventTracker.()Lcom/facebook/drawee/components/DraweeEventTracker;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Facebook.Drawee.Components.DraweeEventTracker> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_hasHierarchy;
#pragma warning disable 0169
		static Delegate GetHasHierarchyHandler ()
		{
			if (cb_hasHierarchy == null)
				cb_hasHierarchy = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_HasHierarchy);
			return cb_hasHierarchy;
		}

		static bool n_HasHierarchy (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Facebook.Drawee.View.DraweeHolder __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Drawee.View.DraweeHolder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.HasHierarchy;
		}
#pragma warning restore 0169

		public virtual unsafe bool HasHierarchy {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.drawee.view']/class[@name='DraweeHolder']/method[@name='hasHierarchy' and count(parameter)=0]"
			[Register ("hasHierarchy", "()Z", "GetHasHierarchyHandler")]
			get {
				const string __id = "hasHierarchy.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
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
			global::Com.Facebook.Drawee.View.DraweeHolder __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Drawee.View.DraweeHolder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			global::Com.Facebook.Drawee.View.DraweeHolder __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Drawee.View.DraweeHolder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object hierarchy = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_hierarchy, JniHandleOwnership.DoNotTransfer);
			__this.Hierarchy = hierarchy;
		}
#pragma warning restore 0169

		public virtual unsafe global::Java.Lang.Object Hierarchy {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.drawee.view']/class[@name='DraweeHolder']/method[@name='getHierarchy' and count(parameter)=0]"
			[Register ("getHierarchy", "()Lcom/facebook/drawee/interfaces/DraweeHierarchy;", "GetGetHierarchyHandler")]
			get {
				const string __id = "getHierarchy.()Lcom/facebook/drawee/interfaces/DraweeHierarchy;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.drawee.view']/class[@name='DraweeHolder']/method[@name='setHierarchy' and count(parameter)=1 and parameter[1][@type='DH']]"
			[Register ("setHierarchy", "(Lcom/facebook/drawee/interfaces/DraweeHierarchy;)V", "GetSetHierarchy_Lcom_facebook_drawee_interfaces_DraweeHierarchy_Handler")]
			set {
				const string __id = "setHierarchy.(Lcom/facebook/drawee/interfaces/DraweeHierarchy;)V";
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_isAttached;
#pragma warning disable 0169
		static Delegate GetIsAttachedHandler ()
		{
			if (cb_isAttached == null)
				cb_isAttached = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsAttached);
			return cb_isAttached;
		}

		static bool n_IsAttached (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Facebook.Drawee.View.DraweeHolder __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Drawee.View.DraweeHolder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsAttached;
		}
#pragma warning restore 0169

		public virtual unsafe bool IsAttached {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.drawee.view']/class[@name='DraweeHolder']/method[@name='isAttached' and count(parameter)=0]"
			[Register ("isAttached", "()Z", "GetIsAttachedHandler")]
			get {
				const string __id = "isAttached.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_getTopLevelDrawable;
#pragma warning disable 0169
		static Delegate GetGetTopLevelDrawableHandler ()
		{
			if (cb_getTopLevelDrawable == null)
				cb_getTopLevelDrawable = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetTopLevelDrawable);
			return cb_getTopLevelDrawable;
		}

		static IntPtr n_GetTopLevelDrawable (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Facebook.Drawee.View.DraweeHolder __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Drawee.View.DraweeHolder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.TopLevelDrawable);
		}
#pragma warning restore 0169

		public virtual unsafe global::Android.Graphics.Drawables.Drawable TopLevelDrawable {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.drawee.view']/class[@name='DraweeHolder']/method[@name='getTopLevelDrawable' and count(parameter)=0]"
			[Register ("getTopLevelDrawable", "()Landroid/graphics/drawable/Drawable;", "GetGetTopLevelDrawableHandler")]
			get {
				const string __id = "getTopLevelDrawable.()Landroid/graphics/drawable/Drawable;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Android.Graphics.Drawables.Drawable> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.drawee.view']/class[@name='DraweeHolder']/method[@name='create' and count(parameter)=2 and parameter[1][@type='DH'] and parameter[2][@type='android.content.Context']]"
		[Register ("create", "(Lcom/facebook/drawee/interfaces/DraweeHierarchy;Landroid/content/Context;)Lcom/facebook/drawee/view/DraweeHolder;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"DH extends com.facebook.drawee.interfaces.DraweeHierarchy"})]
		public static unsafe global::Com.Facebook.Drawee.View.DraweeHolder Create (global::Java.Lang.Object hierarchy, global::Android.Content.Context context)
		{
			const string __id = "create.(Lcom/facebook/drawee/interfaces/DraweeHierarchy;Landroid/content/Context;)Lcom/facebook/drawee/view/DraweeHolder;";
			IntPtr native_hierarchy = JNIEnv.ToLocalJniHandle (hierarchy);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_hierarchy);
				__args [1] = new JniArgumentValue ((context == null) ? IntPtr.Zero : ((global::Java.Lang.Object) context).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Facebook.Drawee.View.DraweeHolder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_hierarchy);
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
			global::Com.Facebook.Drawee.View.DraweeHolder __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Drawee.View.DraweeHolder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnAttach ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.drawee.view']/class[@name='DraweeHolder']/method[@name='onAttach' and count(parameter)=0]"
		[Register ("onAttach", "()V", "GetOnAttachHandler")]
		public virtual unsafe void OnAttach ()
		{
			const string __id = "onAttach.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
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
			global::Com.Facebook.Drawee.View.DraweeHolder __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Drawee.View.DraweeHolder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnDetach ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.drawee.view']/class[@name='DraweeHolder']/method[@name='onDetach' and count(parameter)=0]"
		[Register ("onDetach", "()V", "GetOnDetachHandler")]
		public virtual unsafe void OnDetach ()
		{
			const string __id = "onDetach.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_onDraw;
#pragma warning disable 0169
		static Delegate GetOnDrawHandler ()
		{
			if (cb_onDraw == null)
				cb_onDraw = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_OnDraw);
			return cb_onDraw;
		}

		static void n_OnDraw (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Facebook.Drawee.View.DraweeHolder __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Drawee.View.DraweeHolder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnDraw ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.drawee.view']/class[@name='DraweeHolder']/method[@name='onDraw' and count(parameter)=0]"
		[Register ("onDraw", "()V", "GetOnDrawHandler")]
		public virtual unsafe void OnDraw ()
		{
			const string __id = "onDraw.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
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
			global::Com.Facebook.Drawee.View.DraweeHolder __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Drawee.View.DraweeHolder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Views.MotionEvent e = global::Java.Lang.Object.GetObject<global::Android.Views.MotionEvent> (native_e, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.OnTouchEvent (e);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.drawee.view']/class[@name='DraweeHolder']/method[@name='onTouchEvent' and count(parameter)=1 and parameter[1][@type='android.view.MotionEvent']]"
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

		static Delegate cb_onVisibilityChange_Z;
#pragma warning disable 0169
		static Delegate GetOnVisibilityChange_ZHandler ()
		{
			if (cb_onVisibilityChange_Z == null)
				cb_onVisibilityChange_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_OnVisibilityChange_Z);
			return cb_onVisibilityChange_Z;
		}

		static void n_OnVisibilityChange_Z (IntPtr jnienv, IntPtr native__this, bool isVisible)
		{
			global::Com.Facebook.Drawee.View.DraweeHolder __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Drawee.View.DraweeHolder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnVisibilityChange (isVisible);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.drawee.view']/class[@name='DraweeHolder']/method[@name='onVisibilityChange' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("onVisibilityChange", "(Z)V", "GetOnVisibilityChange_ZHandler")]
		public virtual unsafe void OnVisibilityChange (bool isVisible)
		{
			const string __id = "onVisibilityChange.(Z)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (isVisible);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_registerWithContext_Landroid_content_Context_;
#pragma warning disable 0169
		static Delegate GetRegisterWithContext_Landroid_content_Context_Handler ()
		{
			if (cb_registerWithContext_Landroid_content_Context_ == null)
				cb_registerWithContext_Landroid_content_Context_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_RegisterWithContext_Landroid_content_Context_);
			return cb_registerWithContext_Landroid_content_Context_;
		}

		static void n_RegisterWithContext_Landroid_content_Context_ (IntPtr jnienv, IntPtr native__this, IntPtr native_context)
		{
			global::Com.Facebook.Drawee.View.DraweeHolder __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Drawee.View.DraweeHolder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.Context context = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (native_context, JniHandleOwnership.DoNotTransfer);
			__this.RegisterWithContext (context);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.drawee.view']/class[@name='DraweeHolder']/method[@name='registerWithContext' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("registerWithContext", "(Landroid/content/Context;)V", "GetRegisterWithContext_Landroid_content_Context_Handler")]
		public virtual unsafe void RegisterWithContext (global::Android.Content.Context context)
		{
			const string __id = "registerWithContext.(Landroid/content/Context;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((context == null) ? IntPtr.Zero : ((global::Java.Lang.Object) context).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

	}
}
