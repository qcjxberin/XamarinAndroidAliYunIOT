using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Facebook.Drawee.View {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.facebook.drawee.view']/class[@name='DraweeTransition']"
	[global::Android.Runtime.Register ("com/facebook/drawee/view/DraweeTransition", DoNotGenerateAcw=true)]
	public partial class DraweeTransition : global::Android.Transitions.Transition {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/facebook/drawee/view/DraweeTransition", typeof (DraweeTransition));
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

		protected DraweeTransition (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.facebook.drawee.view']/class[@name='DraweeTransition']/constructor[@name='DraweeTransition' and count(parameter)=2 and parameter[1][@type='com.facebook.drawee.drawable.ScalingUtils.ScaleType'] and parameter[2][@type='com.facebook.drawee.drawable.ScalingUtils.ScaleType']]"
		[Register (".ctor", "(Lcom/facebook/drawee/drawable/ScalingUtils$ScaleType;Lcom/facebook/drawee/drawable/ScalingUtils$ScaleType;)V", "")]
		public unsafe DraweeTransition (global::Com.Facebook.Drawee.Drawable.ScalingUtils.IScaleType fromScale, global::Com.Facebook.Drawee.Drawable.ScalingUtils.IScaleType toScale)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Lcom/facebook/drawee/drawable/ScalingUtils$ScaleType;Lcom/facebook/drawee/drawable/ScalingUtils$ScaleType;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((fromScale == null) ? IntPtr.Zero : ((global::Java.Lang.Object) fromScale).Handle);
				__args [1] = new JniArgumentValue ((toScale == null) ? IntPtr.Zero : ((global::Java.Lang.Object) toScale).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.facebook.drawee.view']/class[@name='DraweeTransition']/constructor[@name='DraweeTransition' and count(parameter)=4 and parameter[1][@type='com.facebook.drawee.drawable.ScalingUtils.ScaleType'] and parameter[2][@type='com.facebook.drawee.drawable.ScalingUtils.ScaleType'] and parameter[3][@type='android.graphics.PointF'] and parameter[4][@type='android.graphics.PointF']]"
		[Register (".ctor", "(Lcom/facebook/drawee/drawable/ScalingUtils$ScaleType;Lcom/facebook/drawee/drawable/ScalingUtils$ScaleType;Landroid/graphics/PointF;Landroid/graphics/PointF;)V", "")]
		public unsafe DraweeTransition (global::Com.Facebook.Drawee.Drawable.ScalingUtils.IScaleType fromScale, global::Com.Facebook.Drawee.Drawable.ScalingUtils.IScaleType toScale, global::Android.Graphics.PointF fromFocusPoint, global::Android.Graphics.PointF toFocusPoint)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Lcom/facebook/drawee/drawable/ScalingUtils$ScaleType;Lcom/facebook/drawee/drawable/ScalingUtils$ScaleType;Landroid/graphics/PointF;Landroid/graphics/PointF;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue ((fromScale == null) ? IntPtr.Zero : ((global::Java.Lang.Object) fromScale).Handle);
				__args [1] = new JniArgumentValue ((toScale == null) ? IntPtr.Zero : ((global::Java.Lang.Object) toScale).Handle);
				__args [2] = new JniArgumentValue ((fromFocusPoint == null) ? IntPtr.Zero : ((global::Java.Lang.Object) fromFocusPoint).Handle);
				__args [3] = new JniArgumentValue ((toFocusPoint == null) ? IntPtr.Zero : ((global::Java.Lang.Object) toFocusPoint).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_captureEndValues_Landroid_transition_TransitionValues_;
#pragma warning disable 0169
		static Delegate GetCaptureEndValues_Landroid_transition_TransitionValues_Handler ()
		{
			if (cb_captureEndValues_Landroid_transition_TransitionValues_ == null)
				cb_captureEndValues_Landroid_transition_TransitionValues_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_CaptureEndValues_Landroid_transition_TransitionValues_);
			return cb_captureEndValues_Landroid_transition_TransitionValues_;
		}

		static void n_CaptureEndValues_Landroid_transition_TransitionValues_ (IntPtr jnienv, IntPtr native__this, IntPtr native_transitionValues)
		{
			global::Com.Facebook.Drawee.View.DraweeTransition __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Drawee.View.DraweeTransition> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Transitions.TransitionValues transitionValues = global::Java.Lang.Object.GetObject<global::Android.Transitions.TransitionValues> (native_transitionValues, JniHandleOwnership.DoNotTransfer);
			__this.CaptureEndValues (transitionValues);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.drawee.view']/class[@name='DraweeTransition']/method[@name='captureEndValues' and count(parameter)=1 and parameter[1][@type='android.transition.TransitionValues']]"
		[Register ("captureEndValues", "(Landroid/transition/TransitionValues;)V", "GetCaptureEndValues_Landroid_transition_TransitionValues_Handler")]
		public override unsafe void CaptureEndValues (global::Android.Transitions.TransitionValues transitionValues)
		{
			const string __id = "captureEndValues.(Landroid/transition/TransitionValues;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((transitionValues == null) ? IntPtr.Zero : ((global::Java.Lang.Object) transitionValues).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_captureStartValues_Landroid_transition_TransitionValues_;
#pragma warning disable 0169
		static Delegate GetCaptureStartValues_Landroid_transition_TransitionValues_Handler ()
		{
			if (cb_captureStartValues_Landroid_transition_TransitionValues_ == null)
				cb_captureStartValues_Landroid_transition_TransitionValues_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_CaptureStartValues_Landroid_transition_TransitionValues_);
			return cb_captureStartValues_Landroid_transition_TransitionValues_;
		}

		static void n_CaptureStartValues_Landroid_transition_TransitionValues_ (IntPtr jnienv, IntPtr native__this, IntPtr native_transitionValues)
		{
			global::Com.Facebook.Drawee.View.DraweeTransition __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Drawee.View.DraweeTransition> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Transitions.TransitionValues transitionValues = global::Java.Lang.Object.GetObject<global::Android.Transitions.TransitionValues> (native_transitionValues, JniHandleOwnership.DoNotTransfer);
			__this.CaptureStartValues (transitionValues);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.drawee.view']/class[@name='DraweeTransition']/method[@name='captureStartValues' and count(parameter)=1 and parameter[1][@type='android.transition.TransitionValues']]"
		[Register ("captureStartValues", "(Landroid/transition/TransitionValues;)V", "GetCaptureStartValues_Landroid_transition_TransitionValues_Handler")]
		public override unsafe void CaptureStartValues (global::Android.Transitions.TransitionValues transitionValues)
		{
			const string __id = "captureStartValues.(Landroid/transition/TransitionValues;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((transitionValues == null) ? IntPtr.Zero : ((global::Java.Lang.Object) transitionValues).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.drawee.view']/class[@name='DraweeTransition']/method[@name='createTransitionSet' and count(parameter)=2 and parameter[1][@type='com.facebook.drawee.drawable.ScalingUtils.ScaleType'] and parameter[2][@type='com.facebook.drawee.drawable.ScalingUtils.ScaleType']]"
		[Register ("createTransitionSet", "(Lcom/facebook/drawee/drawable/ScalingUtils$ScaleType;Lcom/facebook/drawee/drawable/ScalingUtils$ScaleType;)Landroid/transition/TransitionSet;", "")]
		public static unsafe global::Android.Transitions.TransitionSet CreateTransitionSet (global::Com.Facebook.Drawee.Drawable.ScalingUtils.IScaleType fromScale, global::Com.Facebook.Drawee.Drawable.ScalingUtils.IScaleType toScale)
		{
			const string __id = "createTransitionSet.(Lcom/facebook/drawee/drawable/ScalingUtils$ScaleType;Lcom/facebook/drawee/drawable/ScalingUtils$ScaleType;)Landroid/transition/TransitionSet;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((fromScale == null) ? IntPtr.Zero : ((global::Java.Lang.Object) fromScale).Handle);
				__args [1] = new JniArgumentValue ((toScale == null) ? IntPtr.Zero : ((global::Java.Lang.Object) toScale).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Android.Transitions.TransitionSet> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.drawee.view']/class[@name='DraweeTransition']/method[@name='createTransitionSet' and count(parameter)=4 and parameter[1][@type='com.facebook.drawee.drawable.ScalingUtils.ScaleType'] and parameter[2][@type='com.facebook.drawee.drawable.ScalingUtils.ScaleType'] and parameter[3][@type='android.graphics.PointF'] and parameter[4][@type='android.graphics.PointF']]"
		[Register ("createTransitionSet", "(Lcom/facebook/drawee/drawable/ScalingUtils$ScaleType;Lcom/facebook/drawee/drawable/ScalingUtils$ScaleType;Landroid/graphics/PointF;Landroid/graphics/PointF;)Landroid/transition/TransitionSet;", "")]
		public static unsafe global::Android.Transitions.TransitionSet CreateTransitionSet (global::Com.Facebook.Drawee.Drawable.ScalingUtils.IScaleType fromScale, global::Com.Facebook.Drawee.Drawable.ScalingUtils.IScaleType toScale, global::Android.Graphics.PointF fromFocusPoint, global::Android.Graphics.PointF toFocusPoint)
		{
			const string __id = "createTransitionSet.(Lcom/facebook/drawee/drawable/ScalingUtils$ScaleType;Lcom/facebook/drawee/drawable/ScalingUtils$ScaleType;Landroid/graphics/PointF;Landroid/graphics/PointF;)Landroid/transition/TransitionSet;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue ((fromScale == null) ? IntPtr.Zero : ((global::Java.Lang.Object) fromScale).Handle);
				__args [1] = new JniArgumentValue ((toScale == null) ? IntPtr.Zero : ((global::Java.Lang.Object) toScale).Handle);
				__args [2] = new JniArgumentValue ((fromFocusPoint == null) ? IntPtr.Zero : ((global::Java.Lang.Object) fromFocusPoint).Handle);
				__args [3] = new JniArgumentValue ((toFocusPoint == null) ? IntPtr.Zero : ((global::Java.Lang.Object) toFocusPoint).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Android.Transitions.TransitionSet> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}
}
