using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Facebook.Drawee.View {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.facebook.drawee.view']/class[@name='DraweeView']"
	[global::Android.Runtime.Register ("com/facebook/drawee/view/DraweeView", DoNotGenerateAcw=true)]
	[global::Java.Interop.JavaTypeParameters (new string [] {"DH extends com.facebook.drawee.interfaces.DraweeHierarchy"})]
	public partial class DraweeView : global::Android.Widget.ImageView {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/facebook/drawee/view/DraweeView", typeof (DraweeView));
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

		protected DraweeView (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.facebook.drawee.view']/class[@name='DraweeView']/constructor[@name='DraweeView' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register (".ctor", "(Landroid/content/Context;)V", "")]
		public unsafe DraweeView (global::Android.Content.Context context)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Landroid/content/Context;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((context == null) ? IntPtr.Zero : ((global::Java.Lang.Object) context).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.facebook.drawee.view']/class[@name='DraweeView']/constructor[@name='DraweeView' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='android.util.AttributeSet']]"
		[Register (".ctor", "(Landroid/content/Context;Landroid/util/AttributeSet;)V", "")]
		public unsafe DraweeView (global::Android.Content.Context context, global::Android.Util.IAttributeSet attrs)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Landroid/content/Context;Landroid/util/AttributeSet;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((context == null) ? IntPtr.Zero : ((global::Java.Lang.Object) context).Handle);
				__args [1] = new JniArgumentValue ((attrs == null) ? IntPtr.Zero : ((global::Java.Lang.Object) attrs).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.facebook.drawee.view']/class[@name='DraweeView']/constructor[@name='DraweeView' and count(parameter)=3 and parameter[1][@type='android.content.Context'] and parameter[2][@type='android.util.AttributeSet'] and parameter[3][@type='int']]"
		[Register (".ctor", "(Landroid/content/Context;Landroid/util/AttributeSet;I)V", "")]
		public unsafe DraweeView (global::Android.Content.Context context, global::Android.Util.IAttributeSet attrs, int defStyle)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Landroid/content/Context;Landroid/util/AttributeSet;I)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((context == null) ? IntPtr.Zero : ((global::Java.Lang.Object) context).Handle);
				__args [1] = new JniArgumentValue ((attrs == null) ? IntPtr.Zero : ((global::Java.Lang.Object) attrs).Handle);
				__args [2] = new JniArgumentValue (defStyle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.facebook.drawee.view']/class[@name='DraweeView']/constructor[@name='DraweeView' and count(parameter)=4 and parameter[1][@type='android.content.Context'] and parameter[2][@type='android.util.AttributeSet'] and parameter[3][@type='int'] and parameter[4][@type='int']]"
		[Register (".ctor", "(Landroid/content/Context;Landroid/util/AttributeSet;II)V", "")]
		public unsafe DraweeView (global::Android.Content.Context context, global::Android.Util.IAttributeSet attrs, int defStyleAttr, int defStyleRes)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Landroid/content/Context;Landroid/util/AttributeSet;II)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue ((context == null) ? IntPtr.Zero : ((global::Java.Lang.Object) context).Handle);
				__args [1] = new JniArgumentValue ((attrs == null) ? IntPtr.Zero : ((global::Java.Lang.Object) attrs).Handle);
				__args [2] = new JniArgumentValue (defStyleAttr);
				__args [3] = new JniArgumentValue (defStyleRes);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_getAspectRatio;
#pragma warning disable 0169
		static Delegate GetGetAspectRatioHandler ()
		{
			if (cb_getAspectRatio == null)
				cb_getAspectRatio = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, float>) n_GetAspectRatio);
			return cb_getAspectRatio;
		}

		static float n_GetAspectRatio (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Facebook.Drawee.View.DraweeView __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Drawee.View.DraweeView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.AspectRatio;
		}
#pragma warning restore 0169

		static Delegate cb_setAspectRatio_F;
#pragma warning disable 0169
		static Delegate GetSetAspectRatio_FHandler ()
		{
			if (cb_setAspectRatio_F == null)
				cb_setAspectRatio_F = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, float>) n_SetAspectRatio_F);
			return cb_setAspectRatio_F;
		}

		static void n_SetAspectRatio_F (IntPtr jnienv, IntPtr native__this, float aspectRatio)
		{
			global::Com.Facebook.Drawee.View.DraweeView __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Drawee.View.DraweeView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.AspectRatio = aspectRatio;
		}
#pragma warning restore 0169

		public virtual unsafe float AspectRatio {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.drawee.view']/class[@name='DraweeView']/method[@name='getAspectRatio' and count(parameter)=0]"
			[Register ("getAspectRatio", "()F", "GetGetAspectRatioHandler")]
			get {
				const string __id = "getAspectRatio.()F";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualSingleMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.drawee.view']/class[@name='DraweeView']/method[@name='setAspectRatio' and count(parameter)=1 and parameter[1][@type='float']]"
			[Register ("setAspectRatio", "(F)V", "GetSetAspectRatio_FHandler")]
			set {
				const string __id = "setAspectRatio.(F)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
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
			global::Com.Facebook.Drawee.View.DraweeView __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Drawee.View.DraweeView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			global::Com.Facebook.Drawee.View.DraweeView __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Drawee.View.DraweeView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Facebook.Drawee.Interfaces.IDraweeController draweeController = (global::Com.Facebook.Drawee.Interfaces.IDraweeController)global::Java.Lang.Object.GetObject<global::Com.Facebook.Drawee.Interfaces.IDraweeController> (native_draweeController, JniHandleOwnership.DoNotTransfer);
			__this.Controller = draweeController;
		}
#pragma warning restore 0169

		public virtual unsafe global::Com.Facebook.Drawee.Interfaces.IDraweeController Controller {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.drawee.view']/class[@name='DraweeView']/method[@name='getController' and count(parameter)=0]"
			[Register ("getController", "()Lcom/facebook/drawee/interfaces/DraweeController;", "GetGetControllerHandler")]
			get {
				const string __id = "getController.()Lcom/facebook/drawee/interfaces/DraweeController;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Facebook.Drawee.Interfaces.IDraweeController> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.drawee.view']/class[@name='DraweeView']/method[@name='setController' and count(parameter)=1 and parameter[1][@type='com.facebook.drawee.interfaces.DraweeController']]"
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

		static Delegate cb_hasController;
#pragma warning disable 0169
		static Delegate GetHasControllerHandler ()
		{
			if (cb_hasController == null)
				cb_hasController = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_HasController);
			return cb_hasController;
		}

		static bool n_HasController (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Facebook.Drawee.View.DraweeView __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Drawee.View.DraweeView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.HasController;
		}
#pragma warning restore 0169

		public virtual unsafe bool HasController {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.drawee.view']/class[@name='DraweeView']/method[@name='hasController' and count(parameter)=0]"
			[Register ("hasController", "()Z", "GetHasControllerHandler")]
			get {
				const string __id = "hasController.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
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
			global::Com.Facebook.Drawee.View.DraweeView __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Drawee.View.DraweeView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.HasHierarchy;
		}
#pragma warning restore 0169

		public virtual unsafe bool HasHierarchy {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.drawee.view']/class[@name='DraweeView']/method[@name='hasHierarchy' and count(parameter)=0]"
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
			global::Com.Facebook.Drawee.View.DraweeView __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Drawee.View.DraweeView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			global::Com.Facebook.Drawee.View.DraweeView __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Drawee.View.DraweeView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object hierarchy = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_hierarchy, JniHandleOwnership.DoNotTransfer);
			__this.Hierarchy = hierarchy;
		}
#pragma warning restore 0169

		public virtual unsafe global::Java.Lang.Object Hierarchy {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.drawee.view']/class[@name='DraweeView']/method[@name='getHierarchy' and count(parameter)=0]"
			[Register ("getHierarchy", "()Lcom/facebook/drawee/interfaces/DraweeHierarchy;", "GetGetHierarchyHandler")]
			get {
				const string __id = "getHierarchy.()Lcom/facebook/drawee/interfaces/DraweeHierarchy;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.drawee.view']/class[@name='DraweeView']/method[@name='setHierarchy' and count(parameter)=1 and parameter[1][@type='DH']]"
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
			global::Com.Facebook.Drawee.View.DraweeView __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Drawee.View.DraweeView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.TopLevelDrawable);
		}
#pragma warning restore 0169

		public virtual unsafe global::Android.Graphics.Drawables.Drawable TopLevelDrawable {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.drawee.view']/class[@name='DraweeView']/method[@name='getTopLevelDrawable' and count(parameter)=0]"
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

		static Delegate cb_doAttach;
#pragma warning disable 0169
		static Delegate GetDoAttachHandler ()
		{
			if (cb_doAttach == null)
				cb_doAttach = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_DoAttach);
			return cb_doAttach;
		}

		static void n_DoAttach (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Facebook.Drawee.View.DraweeView __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Drawee.View.DraweeView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.DoAttach ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.drawee.view']/class[@name='DraweeView']/method[@name='doAttach' and count(parameter)=0]"
		[Register ("doAttach", "()V", "GetDoAttachHandler")]
		protected virtual unsafe void DoAttach ()
		{
			const string __id = "doAttach.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_doDetach;
#pragma warning disable 0169
		static Delegate GetDoDetachHandler ()
		{
			if (cb_doDetach == null)
				cb_doDetach = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_DoDetach);
			return cb_doDetach;
		}

		static void n_DoDetach (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Facebook.Drawee.View.DraweeView __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Drawee.View.DraweeView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.DoDetach ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.drawee.view']/class[@name='DraweeView']/method[@name='doDetach' and count(parameter)=0]"
		[Register ("doDetach", "()V", "GetDoDetachHandler")]
		protected virtual unsafe void DoDetach ()
		{
			const string __id = "doDetach.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
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
			global::Com.Facebook.Drawee.View.DraweeView __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Drawee.View.DraweeView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnAttach ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.drawee.view']/class[@name='DraweeView']/method[@name='onAttach' and count(parameter)=0]"
		[Register ("onAttach", "()V", "GetOnAttachHandler")]
		protected virtual unsafe void OnAttach ()
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
			global::Com.Facebook.Drawee.View.DraweeView __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Drawee.View.DraweeView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnDetach ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.drawee.view']/class[@name='DraweeView']/method[@name='onDetach' and count(parameter)=0]"
		[Register ("onDetach", "()V", "GetOnDetachHandler")]
		protected virtual unsafe void OnDetach ()
		{
			const string __id = "onDetach.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.drawee.view']/class[@name='DraweeView']/method[@name='setGlobalLegacyVisibilityHandlingEnabled' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("setGlobalLegacyVisibilityHandlingEnabled", "(Z)V", "")]
		public static unsafe void SetGlobalLegacyVisibilityHandlingEnabled (bool legacyVisibilityHandlingEnabled)
		{
			const string __id = "setGlobalLegacyVisibilityHandlingEnabled.(Z)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (legacyVisibilityHandlingEnabled);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
			}
		}

		static Delegate cb_setLegacyVisibilityHandlingEnabled_Z;
#pragma warning disable 0169
		static Delegate GetSetLegacyVisibilityHandlingEnabled_ZHandler ()
		{
			if (cb_setLegacyVisibilityHandlingEnabled_Z == null)
				cb_setLegacyVisibilityHandlingEnabled_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_SetLegacyVisibilityHandlingEnabled_Z);
			return cb_setLegacyVisibilityHandlingEnabled_Z;
		}

		static void n_SetLegacyVisibilityHandlingEnabled_Z (IntPtr jnienv, IntPtr native__this, bool legacyVisibilityHandlingEnabled)
		{
			global::Com.Facebook.Drawee.View.DraweeView __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Drawee.View.DraweeView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetLegacyVisibilityHandlingEnabled (legacyVisibilityHandlingEnabled);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.drawee.view']/class[@name='DraweeView']/method[@name='setLegacyVisibilityHandlingEnabled' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("setLegacyVisibilityHandlingEnabled", "(Z)V", "GetSetLegacyVisibilityHandlingEnabled_ZHandler")]
		public virtual unsafe void SetLegacyVisibilityHandlingEnabled (bool legacyVisibilityHandlingEnabled)
		{
			const string __id = "setLegacyVisibilityHandlingEnabled.(Z)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (legacyVisibilityHandlingEnabled);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

	}
}
