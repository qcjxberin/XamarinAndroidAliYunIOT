using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Facebook.Drawee.Drawable {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.facebook.drawee.drawable']/class[@name='ProgressBarDrawable']"
	[global::Android.Runtime.Register ("com/facebook/drawee/drawable/ProgressBarDrawable", DoNotGenerateAcw=true)]
	public partial class ProgressBarDrawable : global::Android.Graphics.Drawables.Drawable, global::Com.Facebook.Drawee.Drawable.ICloneableDrawable {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/facebook/drawee/drawable/ProgressBarDrawable", typeof (ProgressBarDrawable));
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

		protected ProgressBarDrawable (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.facebook.drawee.drawable']/class[@name='ProgressBarDrawable']/constructor[@name='ProgressBarDrawable' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe ProgressBarDrawable ()
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

		static Delegate cb_getBackgroundColor;
#pragma warning disable 0169
		static Delegate GetGetBackgroundColorHandler ()
		{
			if (cb_getBackgroundColor == null)
				cb_getBackgroundColor = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetBackgroundColor);
			return cb_getBackgroundColor;
		}

		static int n_GetBackgroundColor (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Facebook.Drawee.Drawable.ProgressBarDrawable __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Drawee.Drawable.ProgressBarDrawable> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.BackgroundColor;
		}
#pragma warning restore 0169

		static Delegate cb_setBackgroundColor_I;
#pragma warning disable 0169
		static Delegate GetSetBackgroundColor_IHandler ()
		{
			if (cb_setBackgroundColor_I == null)
				cb_setBackgroundColor_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetBackgroundColor_I);
			return cb_setBackgroundColor_I;
		}

		static void n_SetBackgroundColor_I (IntPtr jnienv, IntPtr native__this, int backgroundColor)
		{
			global::Com.Facebook.Drawee.Drawable.ProgressBarDrawable __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Drawee.Drawable.ProgressBarDrawable> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.BackgroundColor = backgroundColor;
		}
#pragma warning restore 0169

		public virtual unsafe int BackgroundColor {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.drawee.drawable']/class[@name='ProgressBarDrawable']/method[@name='getBackgroundColor' and count(parameter)=0]"
			[Register ("getBackgroundColor", "()I", "GetGetBackgroundColorHandler")]
			get {
				const string __id = "getBackgroundColor.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.drawee.drawable']/class[@name='ProgressBarDrawable']/method[@name='setBackgroundColor' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setBackgroundColor", "(I)V", "GetSetBackgroundColor_IHandler")]
			set {
				const string __id = "setBackgroundColor.(I)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getBarWidth;
#pragma warning disable 0169
		static Delegate GetGetBarWidthHandler ()
		{
			if (cb_getBarWidth == null)
				cb_getBarWidth = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetBarWidth);
			return cb_getBarWidth;
		}

		static int n_GetBarWidth (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Facebook.Drawee.Drawable.ProgressBarDrawable __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Drawee.Drawable.ProgressBarDrawable> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.BarWidth;
		}
#pragma warning restore 0169

		static Delegate cb_setBarWidth_I;
#pragma warning disable 0169
		static Delegate GetSetBarWidth_IHandler ()
		{
			if (cb_setBarWidth_I == null)
				cb_setBarWidth_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetBarWidth_I);
			return cb_setBarWidth_I;
		}

		static void n_SetBarWidth_I (IntPtr jnienv, IntPtr native__this, int barWidth)
		{
			global::Com.Facebook.Drawee.Drawable.ProgressBarDrawable __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Drawee.Drawable.ProgressBarDrawable> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.BarWidth = barWidth;
		}
#pragma warning restore 0169

		public virtual unsafe int BarWidth {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.drawee.drawable']/class[@name='ProgressBarDrawable']/method[@name='getBarWidth' and count(parameter)=0]"
			[Register ("getBarWidth", "()I", "GetGetBarWidthHandler")]
			get {
				const string __id = "getBarWidth.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.drawee.drawable']/class[@name='ProgressBarDrawable']/method[@name='setBarWidth' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setBarWidth", "(I)V", "GetSetBarWidth_IHandler")]
			set {
				const string __id = "setBarWidth.(I)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getColor;
#pragma warning disable 0169
		static Delegate GetGetColorHandler ()
		{
			if (cb_getColor == null)
				cb_getColor = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetColor);
			return cb_getColor;
		}

		static int n_GetColor (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Facebook.Drawee.Drawable.ProgressBarDrawable __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Drawee.Drawable.ProgressBarDrawable> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Color;
		}
#pragma warning restore 0169

		static Delegate cb_setColor_I;
#pragma warning disable 0169
		static Delegate GetSetColor_IHandler ()
		{
			if (cb_setColor_I == null)
				cb_setColor_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetColor_I);
			return cb_setColor_I;
		}

		static void n_SetColor_I (IntPtr jnienv, IntPtr native__this, int color)
		{
			global::Com.Facebook.Drawee.Drawable.ProgressBarDrawable __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Drawee.Drawable.ProgressBarDrawable> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Color = color;
		}
#pragma warning restore 0169

		public virtual unsafe int Color {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.drawee.drawable']/class[@name='ProgressBarDrawable']/method[@name='getColor' and count(parameter)=0]"
			[Register ("getColor", "()I", "GetGetColorHandler")]
			get {
				const string __id = "getColor.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.drawee.drawable']/class[@name='ProgressBarDrawable']/method[@name='setColor' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setColor", "(I)V", "GetSetColor_IHandler")]
			set {
				const string __id = "setColor.(I)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getHideWhenZero;
#pragma warning disable 0169
		static Delegate GetGetHideWhenZeroHandler ()
		{
			if (cb_getHideWhenZero == null)
				cb_getHideWhenZero = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_GetHideWhenZero);
			return cb_getHideWhenZero;
		}

		static bool n_GetHideWhenZero (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Facebook.Drawee.Drawable.ProgressBarDrawable __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Drawee.Drawable.ProgressBarDrawable> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.HideWhenZero;
		}
#pragma warning restore 0169

		static Delegate cb_setHideWhenZero_Z;
#pragma warning disable 0169
		static Delegate GetSetHideWhenZero_ZHandler ()
		{
			if (cb_setHideWhenZero_Z == null)
				cb_setHideWhenZero_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_SetHideWhenZero_Z);
			return cb_setHideWhenZero_Z;
		}

		static void n_SetHideWhenZero_Z (IntPtr jnienv, IntPtr native__this, bool hideWhenZero)
		{
			global::Com.Facebook.Drawee.Drawable.ProgressBarDrawable __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Drawee.Drawable.ProgressBarDrawable> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.HideWhenZero = hideWhenZero;
		}
#pragma warning restore 0169

		public virtual unsafe bool HideWhenZero {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.drawee.drawable']/class[@name='ProgressBarDrawable']/method[@name='getHideWhenZero' and count(parameter)=0]"
			[Register ("getHideWhenZero", "()Z", "GetGetHideWhenZeroHandler")]
			get {
				const string __id = "getHideWhenZero.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.drawee.drawable']/class[@name='ProgressBarDrawable']/method[@name='setHideWhenZero' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setHideWhenZero", "(Z)V", "GetSetHideWhenZero_ZHandler")]
			set {
				const string __id = "setHideWhenZero.(Z)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getIsVertical;
#pragma warning disable 0169
		static Delegate GetGetIsVerticalHandler ()
		{
			if (cb_getIsVertical == null)
				cb_getIsVertical = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_GetIsVertical);
			return cb_getIsVertical;
		}

		static bool n_GetIsVertical (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Facebook.Drawee.Drawable.ProgressBarDrawable __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Drawee.Drawable.ProgressBarDrawable> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsVertical;
		}
#pragma warning restore 0169

		static Delegate cb_setIsVertical_Z;
#pragma warning disable 0169
		static Delegate GetSetIsVertical_ZHandler ()
		{
			if (cb_setIsVertical_Z == null)
				cb_setIsVertical_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_SetIsVertical_Z);
			return cb_setIsVertical_Z;
		}

		static void n_SetIsVertical_Z (IntPtr jnienv, IntPtr native__this, bool isVertical)
		{
			global::Com.Facebook.Drawee.Drawable.ProgressBarDrawable __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Drawee.Drawable.ProgressBarDrawable> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.IsVertical = isVertical;
		}
#pragma warning restore 0169

		public virtual unsafe bool IsVertical {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.drawee.drawable']/class[@name='ProgressBarDrawable']/method[@name='getIsVertical' and count(parameter)=0]"
			[Register ("getIsVertical", "()Z", "GetGetIsVerticalHandler")]
			get {
				const string __id = "getIsVertical.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.drawee.drawable']/class[@name='ProgressBarDrawable']/method[@name='setIsVertical' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setIsVertical", "(Z)V", "GetSetIsVertical_ZHandler")]
			set {
				const string __id = "setIsVertical.(Z)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getOpacity;
#pragma warning disable 0169
		static Delegate GetGetOpacityHandler ()
		{
			if (cb_getOpacity == null)
				cb_getOpacity = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetOpacity);
			return cb_getOpacity;
		}

		static int n_GetOpacity (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Facebook.Drawee.Drawable.ProgressBarDrawable __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Drawee.Drawable.ProgressBarDrawable> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Opacity;
		}
#pragma warning restore 0169

		public override unsafe int Opacity {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.drawee.drawable']/class[@name='ProgressBarDrawable']/method[@name='getOpacity' and count(parameter)=0]"
			[Register ("getOpacity", "()I", "GetGetOpacityHandler")]
			get {
				const string __id = "getOpacity.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_getRadius;
#pragma warning disable 0169
		static Delegate GetGetRadiusHandler ()
		{
			if (cb_getRadius == null)
				cb_getRadius = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetRadius);
			return cb_getRadius;
		}

		static int n_GetRadius (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Facebook.Drawee.Drawable.ProgressBarDrawable __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Drawee.Drawable.ProgressBarDrawable> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Radius;
		}
#pragma warning restore 0169

		static Delegate cb_setRadius_I;
#pragma warning disable 0169
		static Delegate GetSetRadius_IHandler ()
		{
			if (cb_setRadius_I == null)
				cb_setRadius_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetRadius_I);
			return cb_setRadius_I;
		}

		static void n_SetRadius_I (IntPtr jnienv, IntPtr native__this, int radius)
		{
			global::Com.Facebook.Drawee.Drawable.ProgressBarDrawable __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Drawee.Drawable.ProgressBarDrawable> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Radius = radius;
		}
#pragma warning restore 0169

		public virtual unsafe int Radius {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.drawee.drawable']/class[@name='ProgressBarDrawable']/method[@name='getRadius' and count(parameter)=0]"
			[Register ("getRadius", "()I", "GetGetRadiusHandler")]
			get {
				const string __id = "getRadius.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.drawee.drawable']/class[@name='ProgressBarDrawable']/method[@name='setRadius' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setRadius", "(I)V", "GetSetRadius_IHandler")]
			set {
				const string __id = "setRadius.(I)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_cloneDrawable;
#pragma warning disable 0169
		static Delegate GetCloneDrawableHandler ()
		{
			if (cb_cloneDrawable == null)
				cb_cloneDrawable = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_CloneDrawable);
			return cb_cloneDrawable;
		}

		static IntPtr n_CloneDrawable (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Facebook.Drawee.Drawable.ProgressBarDrawable __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Drawee.Drawable.ProgressBarDrawable> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.CloneDrawable ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.drawee.drawable']/class[@name='ProgressBarDrawable']/method[@name='cloneDrawable' and count(parameter)=0]"
		[Register ("cloneDrawable", "()Landroid/graphics/drawable/Drawable;", "GetCloneDrawableHandler")]
		public virtual unsafe global::Android.Graphics.Drawables.Drawable CloneDrawable ()
		{
			const string __id = "cloneDrawable.()Landroid/graphics/drawable/Drawable;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Android.Graphics.Drawables.Drawable> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_draw_Landroid_graphics_Canvas_;
#pragma warning disable 0169
		static Delegate GetDraw_Landroid_graphics_Canvas_Handler ()
		{
			if (cb_draw_Landroid_graphics_Canvas_ == null)
				cb_draw_Landroid_graphics_Canvas_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_Draw_Landroid_graphics_Canvas_);
			return cb_draw_Landroid_graphics_Canvas_;
		}

		static void n_Draw_Landroid_graphics_Canvas_ (IntPtr jnienv, IntPtr native__this, IntPtr native_canvas)
		{
			global::Com.Facebook.Drawee.Drawable.ProgressBarDrawable __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Drawee.Drawable.ProgressBarDrawable> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Graphics.Canvas canvas = global::Java.Lang.Object.GetObject<global::Android.Graphics.Canvas> (native_canvas, JniHandleOwnership.DoNotTransfer);
			__this.Draw (canvas);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.drawee.drawable']/class[@name='ProgressBarDrawable']/method[@name='draw' and count(parameter)=1 and parameter[1][@type='android.graphics.Canvas']]"
		[Register ("draw", "(Landroid/graphics/Canvas;)V", "GetDraw_Landroid_graphics_Canvas_Handler")]
		public override unsafe void Draw (global::Android.Graphics.Canvas canvas)
		{
			const string __id = "draw.(Landroid/graphics/Canvas;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((canvas == null) ? IntPtr.Zero : ((global::Java.Lang.Object) canvas).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_setAlpha_I;
#pragma warning disable 0169
		static Delegate GetSetAlpha_IHandler ()
		{
			if (cb_setAlpha_I == null)
				cb_setAlpha_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetAlpha_I);
			return cb_setAlpha_I;
		}

		static void n_SetAlpha_I (IntPtr jnienv, IntPtr native__this, int alpha)
		{
			global::Com.Facebook.Drawee.Drawable.ProgressBarDrawable __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Drawee.Drawable.ProgressBarDrawable> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetAlpha (alpha);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.drawee.drawable']/class[@name='ProgressBarDrawable']/method[@name='setAlpha' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setAlpha", "(I)V", "GetSetAlpha_IHandler")]
		public override unsafe void SetAlpha (int alpha)
		{
			const string __id = "setAlpha.(I)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (alpha);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_setColorFilter_Landroid_graphics_ColorFilter_;
#pragma warning disable 0169
		static Delegate GetSetColorFilter_Landroid_graphics_ColorFilter_Handler ()
		{
			if (cb_setColorFilter_Landroid_graphics_ColorFilter_ == null)
				cb_setColorFilter_Landroid_graphics_ColorFilter_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetColorFilter_Landroid_graphics_ColorFilter_);
			return cb_setColorFilter_Landroid_graphics_ColorFilter_;
		}

		static void n_SetColorFilter_Landroid_graphics_ColorFilter_ (IntPtr jnienv, IntPtr native__this, IntPtr native_cf)
		{
			global::Com.Facebook.Drawee.Drawable.ProgressBarDrawable __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Drawee.Drawable.ProgressBarDrawable> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Graphics.ColorFilter cf = global::Java.Lang.Object.GetObject<global::Android.Graphics.ColorFilter> (native_cf, JniHandleOwnership.DoNotTransfer);
			__this.SetColorFilter (cf);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.drawee.drawable']/class[@name='ProgressBarDrawable']/method[@name='setColorFilter' and count(parameter)=1 and parameter[1][@type='android.graphics.ColorFilter']]"
		[Register ("setColorFilter", "(Landroid/graphics/ColorFilter;)V", "GetSetColorFilter_Landroid_graphics_ColorFilter_Handler")]
		public override unsafe void SetColorFilter (global::Android.Graphics.ColorFilter cf)
		{
			const string __id = "setColorFilter.(Landroid/graphics/ColorFilter;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((cf == null) ? IntPtr.Zero : ((global::Java.Lang.Object) cf).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_setPadding_I;
#pragma warning disable 0169
		static Delegate GetSetPadding_IHandler ()
		{
			if (cb_setPadding_I == null)
				cb_setPadding_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetPadding_I);
			return cb_setPadding_I;
		}

		static void n_SetPadding_I (IntPtr jnienv, IntPtr native__this, int padding)
		{
			global::Com.Facebook.Drawee.Drawable.ProgressBarDrawable __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Drawee.Drawable.ProgressBarDrawable> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetPadding (padding);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.drawee.drawable']/class[@name='ProgressBarDrawable']/method[@name='setPadding' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setPadding", "(I)V", "GetSetPadding_IHandler")]
		public virtual unsafe void SetPadding (int padding)
		{
			const string __id = "setPadding.(I)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (padding);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

	}
}
