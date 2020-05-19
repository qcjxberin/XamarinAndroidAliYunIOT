using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Facebook.Drawee.Drawable {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.facebook.drawee.drawable']/class[@name='ScaleTypeDrawable']"
	[global::Android.Runtime.Register ("com/facebook/drawee/drawable/ScaleTypeDrawable", DoNotGenerateAcw=true)]
	public partial class ScaleTypeDrawable : global::Com.Facebook.Drawee.Drawable.ForwardingDrawable {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/facebook/drawee/drawable/ScaleTypeDrawable", typeof (ScaleTypeDrawable));
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

		protected ScaleTypeDrawable (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.facebook.drawee.drawable']/class[@name='ScaleTypeDrawable']/constructor[@name='ScaleTypeDrawable' and count(parameter)=2 and parameter[1][@type='android.graphics.drawable.Drawable'] and parameter[2][@type='com.facebook.drawee.drawable.ScalingUtils.ScaleType']]"
		[Register (".ctor", "(Landroid/graphics/drawable/Drawable;Lcom/facebook/drawee/drawable/ScalingUtils$ScaleType;)V", "")]
		public unsafe ScaleTypeDrawable (global::Android.Graphics.Drawables.Drawable drawable, global::Com.Facebook.Drawee.Drawable.ScalingUtils.IScaleType scaleType)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Landroid/graphics/drawable/Drawable;Lcom/facebook/drawee/drawable/ScalingUtils$ScaleType;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((drawable == null) ? IntPtr.Zero : ((global::Java.Lang.Object) drawable).Handle);
				__args [1] = new JniArgumentValue ((scaleType == null) ? IntPtr.Zero : ((global::Java.Lang.Object) scaleType).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_getFocusPoint;
#pragma warning disable 0169
		static Delegate GetGetFocusPointHandler ()
		{
			if (cb_getFocusPoint == null)
				cb_getFocusPoint = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetFocusPoint);
			return cb_getFocusPoint;
		}

		static IntPtr n_GetFocusPoint (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Facebook.Drawee.Drawable.ScaleTypeDrawable __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Drawee.Drawable.ScaleTypeDrawable> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.FocusPoint);
		}
#pragma warning restore 0169

		static Delegate cb_setFocusPoint_Landroid_graphics_PointF_;
#pragma warning disable 0169
		static Delegate GetSetFocusPoint_Landroid_graphics_PointF_Handler ()
		{
			if (cb_setFocusPoint_Landroid_graphics_PointF_ == null)
				cb_setFocusPoint_Landroid_graphics_PointF_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetFocusPoint_Landroid_graphics_PointF_);
			return cb_setFocusPoint_Landroid_graphics_PointF_;
		}

		static void n_SetFocusPoint_Landroid_graphics_PointF_ (IntPtr jnienv, IntPtr native__this, IntPtr native_focusPoint)
		{
			global::Com.Facebook.Drawee.Drawable.ScaleTypeDrawable __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Drawee.Drawable.ScaleTypeDrawable> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Graphics.PointF focusPoint = global::Java.Lang.Object.GetObject<global::Android.Graphics.PointF> (native_focusPoint, JniHandleOwnership.DoNotTransfer);
			__this.FocusPoint = focusPoint;
		}
#pragma warning restore 0169

		public virtual unsafe global::Android.Graphics.PointF FocusPoint {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.drawee.drawable']/class[@name='ScaleTypeDrawable']/method[@name='getFocusPoint' and count(parameter)=0]"
			[Register ("getFocusPoint", "()Landroid/graphics/PointF;", "GetGetFocusPointHandler")]
			get {
				const string __id = "getFocusPoint.()Landroid/graphics/PointF;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Android.Graphics.PointF> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.drawee.drawable']/class[@name='ScaleTypeDrawable']/method[@name='setFocusPoint' and count(parameter)=1 and parameter[1][@type='android.graphics.PointF']]"
			[Register ("setFocusPoint", "(Landroid/graphics/PointF;)V", "GetSetFocusPoint_Landroid_graphics_PointF_Handler")]
			set {
				const string __id = "setFocusPoint.(Landroid/graphics/PointF;)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((value == null) ? IntPtr.Zero : ((global::Java.Lang.Object) value).Handle);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getScaleType;
#pragma warning disable 0169
		static Delegate GetGetScaleTypeHandler ()
		{
			if (cb_getScaleType == null)
				cb_getScaleType = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetScaleType);
			return cb_getScaleType;
		}

		static IntPtr n_GetScaleType (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Facebook.Drawee.Drawable.ScaleTypeDrawable __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Drawee.Drawable.ScaleTypeDrawable> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.ScaleType);
		}
#pragma warning restore 0169

		static Delegate cb_setScaleType_Lcom_facebook_drawee_drawable_ScalingUtils_ScaleType_;
#pragma warning disable 0169
		static Delegate GetSetScaleType_Lcom_facebook_drawee_drawable_ScalingUtils_ScaleType_Handler ()
		{
			if (cb_setScaleType_Lcom_facebook_drawee_drawable_ScalingUtils_ScaleType_ == null)
				cb_setScaleType_Lcom_facebook_drawee_drawable_ScalingUtils_ScaleType_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetScaleType_Lcom_facebook_drawee_drawable_ScalingUtils_ScaleType_);
			return cb_setScaleType_Lcom_facebook_drawee_drawable_ScalingUtils_ScaleType_;
		}

		static void n_SetScaleType_Lcom_facebook_drawee_drawable_ScalingUtils_ScaleType_ (IntPtr jnienv, IntPtr native__this, IntPtr native_scaleType)
		{
			global::Com.Facebook.Drawee.Drawable.ScaleTypeDrawable __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Drawee.Drawable.ScaleTypeDrawable> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Facebook.Drawee.Drawable.ScalingUtils.IScaleType scaleType = (global::Com.Facebook.Drawee.Drawable.ScalingUtils.IScaleType)global::Java.Lang.Object.GetObject<global::Com.Facebook.Drawee.Drawable.ScalingUtils.IScaleType> (native_scaleType, JniHandleOwnership.DoNotTransfer);
			__this.ScaleType = scaleType;
		}
#pragma warning restore 0169

		public virtual unsafe global::Com.Facebook.Drawee.Drawable.ScalingUtils.IScaleType ScaleType {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.drawee.drawable']/class[@name='ScaleTypeDrawable']/method[@name='getScaleType' and count(parameter)=0]"
			[Register ("getScaleType", "()Lcom/facebook/drawee/drawable/ScalingUtils$ScaleType;", "GetGetScaleTypeHandler")]
			get {
				const string __id = "getScaleType.()Lcom/facebook/drawee/drawable/ScalingUtils$ScaleType;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Facebook.Drawee.Drawable.ScalingUtils.IScaleType> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.drawee.drawable']/class[@name='ScaleTypeDrawable']/method[@name='setScaleType' and count(parameter)=1 and parameter[1][@type='com.facebook.drawee.drawable.ScalingUtils.ScaleType']]"
			[Register ("setScaleType", "(Lcom/facebook/drawee/drawable/ScalingUtils$ScaleType;)V", "GetSetScaleType_Lcom_facebook_drawee_drawable_ScalingUtils_ScaleType_Handler")]
			set {
				const string __id = "setScaleType.(Lcom/facebook/drawee/drawable/ScalingUtils$ScaleType;)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((value == null) ? IntPtr.Zero : ((global::Java.Lang.Object) value).Handle);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

	}
}
