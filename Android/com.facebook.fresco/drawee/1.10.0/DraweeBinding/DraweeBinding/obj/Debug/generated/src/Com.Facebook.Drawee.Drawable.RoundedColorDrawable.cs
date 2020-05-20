using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Facebook.Drawee.Drawable {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.facebook.drawee.drawable']/class[@name='RoundedColorDrawable']"
	[global::Android.Runtime.Register ("com/facebook/drawee/drawable/RoundedColorDrawable", DoNotGenerateAcw=true)]
	public partial class RoundedColorDrawable : global::Android.Graphics.Drawables.Drawable, global::Com.Facebook.Drawee.Drawable.IRounded {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/facebook/drawee/drawable/RoundedColorDrawable", typeof (RoundedColorDrawable));
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

		protected RoundedColorDrawable (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.facebook.drawee.drawable']/class[@name='RoundedColorDrawable']/constructor[@name='RoundedColorDrawable' and count(parameter)=2 and parameter[1][@type='float'] and parameter[2][@type='int']]"
		[Register (".ctor", "(FI)V", "")]
		public unsafe RoundedColorDrawable (float radius, int color)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(FI)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (radius);
				__args [1] = new JniArgumentValue (color);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.facebook.drawee.drawable']/class[@name='RoundedColorDrawable']/constructor[@name='RoundedColorDrawable' and count(parameter)=2 and parameter[1][@type='float[]'] and parameter[2][@type='int']]"
		[Register (".ctor", "([FI)V", "")]
		public unsafe RoundedColorDrawable (float[] radii, int color)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "([FI)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_radii = JNIEnv.NewArray (radii);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_radii);
				__args [1] = new JniArgumentValue (color);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				if (radii != null) {
					JNIEnv.CopyArray (native_radii, radii);
					JNIEnv.DeleteLocalRef (native_radii);
				}
			}
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.facebook.drawee.drawable']/class[@name='RoundedColorDrawable']/constructor[@name='RoundedColorDrawable' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register (".ctor", "(I)V", "")]
		public unsafe RoundedColorDrawable (int color)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(I)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (color);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_getBorderColor;
#pragma warning disable 0169
		static Delegate GetGetBorderColorHandler ()
		{
			if (cb_getBorderColor == null)
				cb_getBorderColor = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetBorderColor);
			return cb_getBorderColor;
		}

		static int n_GetBorderColor (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Facebook.Drawee.Drawable.RoundedColorDrawable __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Drawee.Drawable.RoundedColorDrawable> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.BorderColor;
		}
#pragma warning restore 0169

		public virtual unsafe int BorderColor {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.drawee.drawable']/class[@name='RoundedColorDrawable']/method[@name='getBorderColor' and count(parameter)=0]"
			[Register ("getBorderColor", "()I", "GetGetBorderColorHandler")]
			get {
				const string __id = "getBorderColor.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_getBorderWidth;
#pragma warning disable 0169
		static Delegate GetGetBorderWidthHandler ()
		{
			if (cb_getBorderWidth == null)
				cb_getBorderWidth = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, float>) n_GetBorderWidth);
			return cb_getBorderWidth;
		}

		static float n_GetBorderWidth (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Facebook.Drawee.Drawable.RoundedColorDrawable __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Drawee.Drawable.RoundedColorDrawable> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.BorderWidth;
		}
#pragma warning restore 0169

		public virtual unsafe float BorderWidth {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.drawee.drawable']/class[@name='RoundedColorDrawable']/method[@name='getBorderWidth' and count(parameter)=0]"
			[Register ("getBorderWidth", "()F", "GetGetBorderWidthHandler")]
			get {
				const string __id = "getBorderWidth.()F";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualSingleMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_isCircle;
#pragma warning disable 0169
		static Delegate GetIsCircleHandler ()
		{
			if (cb_isCircle == null)
				cb_isCircle = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsCircle);
			return cb_isCircle;
		}

		static bool n_IsCircle (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Facebook.Drawee.Drawable.RoundedColorDrawable __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Drawee.Drawable.RoundedColorDrawable> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Circle;
		}
#pragma warning restore 0169

		static Delegate cb_setCircle_Z;
#pragma warning disable 0169
		static Delegate GetSetCircle_ZHandler ()
		{
			if (cb_setCircle_Z == null)
				cb_setCircle_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_SetCircle_Z);
			return cb_setCircle_Z;
		}

		static void n_SetCircle_Z (IntPtr jnienv, IntPtr native__this, bool isCircle)
		{
			global::Com.Facebook.Drawee.Drawable.RoundedColorDrawable __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Drawee.Drawable.RoundedColorDrawable> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Circle = isCircle;
		}
#pragma warning restore 0169

		public virtual unsafe bool Circle {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.drawee.drawable']/class[@name='RoundedColorDrawable']/method[@name='isCircle' and count(parameter)=0]"
			[Register ("isCircle", "()Z", "GetIsCircleHandler")]
			get {
				const string __id = "isCircle.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.drawee.drawable']/class[@name='RoundedColorDrawable']/method[@name='setCircle' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setCircle", "(Z)V", "GetSetCircle_ZHandler")]
			set {
				const string __id = "setCircle.(Z)V";
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
			global::Com.Facebook.Drawee.Drawable.RoundedColorDrawable __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Drawee.Drawable.RoundedColorDrawable> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			global::Com.Facebook.Drawee.Drawable.RoundedColorDrawable __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Drawee.Drawable.RoundedColorDrawable> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Color = color;
		}
#pragma warning restore 0169

		public virtual unsafe int Color {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.drawee.drawable']/class[@name='RoundedColorDrawable']/method[@name='getColor' and count(parameter)=0]"
			[Register ("getColor", "()I", "GetGetColorHandler")]
			get {
				const string __id = "getColor.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.drawee.drawable']/class[@name='RoundedColorDrawable']/method[@name='setColor' and count(parameter)=1 and parameter[1][@type='int']]"
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
			global::Com.Facebook.Drawee.Drawable.RoundedColorDrawable __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Drawee.Drawable.RoundedColorDrawable> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Opacity;
		}
#pragma warning restore 0169

		public override unsafe int Opacity {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.drawee.drawable']/class[@name='RoundedColorDrawable']/method[@name='getOpacity' and count(parameter)=0]"
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

		static Delegate cb_getPadding;
#pragma warning disable 0169
		static Delegate GetGetPaddingHandler ()
		{
			if (cb_getPadding == null)
				cb_getPadding = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, float>) n_GetPadding);
			return cb_getPadding;
		}

		static float n_GetPadding (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Facebook.Drawee.Drawable.RoundedColorDrawable __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Drawee.Drawable.RoundedColorDrawable> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Padding;
		}
#pragma warning restore 0169

		static Delegate cb_setPadding_F;
#pragma warning disable 0169
		static Delegate GetSetPadding_FHandler ()
		{
			if (cb_setPadding_F == null)
				cb_setPadding_F = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, float>) n_SetPadding_F);
			return cb_setPadding_F;
		}

		static void n_SetPadding_F (IntPtr jnienv, IntPtr native__this, float padding)
		{
			global::Com.Facebook.Drawee.Drawable.RoundedColorDrawable __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Drawee.Drawable.RoundedColorDrawable> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Padding = padding;
		}
#pragma warning restore 0169

		public virtual unsafe float Padding {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.drawee.drawable']/class[@name='RoundedColorDrawable']/method[@name='getPadding' and count(parameter)=0]"
			[Register ("getPadding", "()F", "GetGetPaddingHandler")]
			get {
				const string __id = "getPadding.()F";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualSingleMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.drawee.drawable']/class[@name='RoundedColorDrawable']/method[@name='setPadding' and count(parameter)=1 and parameter[1][@type='float']]"
			[Register ("setPadding", "(F)V", "GetSetPadding_FHandler")]
			set {
				const string __id = "setPadding.(F)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getScaleDownInsideBorders;
#pragma warning disable 0169
		static Delegate GetGetScaleDownInsideBordersHandler ()
		{
			if (cb_getScaleDownInsideBorders == null)
				cb_getScaleDownInsideBorders = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_GetScaleDownInsideBorders);
			return cb_getScaleDownInsideBorders;
		}

		static bool n_GetScaleDownInsideBorders (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Facebook.Drawee.Drawable.RoundedColorDrawable __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Drawee.Drawable.RoundedColorDrawable> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ScaleDownInsideBorders;
		}
#pragma warning restore 0169

		static Delegate cb_setScaleDownInsideBorders_Z;
#pragma warning disable 0169
		static Delegate GetSetScaleDownInsideBorders_ZHandler ()
		{
			if (cb_setScaleDownInsideBorders_Z == null)
				cb_setScaleDownInsideBorders_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_SetScaleDownInsideBorders_Z);
			return cb_setScaleDownInsideBorders_Z;
		}

		static void n_SetScaleDownInsideBorders_Z (IntPtr jnienv, IntPtr native__this, bool scaleDownInsideBorders)
		{
			global::Com.Facebook.Drawee.Drawable.RoundedColorDrawable __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Drawee.Drawable.RoundedColorDrawable> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ScaleDownInsideBorders = scaleDownInsideBorders;
		}
#pragma warning restore 0169

		public virtual unsafe bool ScaleDownInsideBorders {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.drawee.drawable']/class[@name='RoundedColorDrawable']/method[@name='getScaleDownInsideBorders' and count(parameter)=0]"
			[Register ("getScaleDownInsideBorders", "()Z", "GetGetScaleDownInsideBordersHandler")]
			get {
				const string __id = "getScaleDownInsideBorders.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.drawee.drawable']/class[@name='RoundedColorDrawable']/method[@name='setScaleDownInsideBorders' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setScaleDownInsideBorders", "(Z)V", "GetSetScaleDownInsideBorders_ZHandler")]
			set {
				const string __id = "setScaleDownInsideBorders.(Z)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
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
			global::Com.Facebook.Drawee.Drawable.RoundedColorDrawable __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Drawee.Drawable.RoundedColorDrawable> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Graphics.Canvas canvas = global::Java.Lang.Object.GetObject<global::Android.Graphics.Canvas> (native_canvas, JniHandleOwnership.DoNotTransfer);
			__this.Draw (canvas);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.drawee.drawable']/class[@name='RoundedColorDrawable']/method[@name='draw' and count(parameter)=1 and parameter[1][@type='android.graphics.Canvas']]"
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

		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.drawee.drawable']/class[@name='RoundedColorDrawable']/method[@name='fromColorDrawable' and count(parameter)=1 and parameter[1][@type='android.graphics.drawable.ColorDrawable']]"
		[Register ("fromColorDrawable", "(Landroid/graphics/drawable/ColorDrawable;)Lcom/facebook/drawee/drawable/RoundedColorDrawable;", "")]
		public static unsafe global::Com.Facebook.Drawee.Drawable.RoundedColorDrawable FromColorDrawable (global::Android.Graphics.Drawables.ColorDrawable colorDrawable)
		{
			const string __id = "fromColorDrawable.(Landroid/graphics/drawable/ColorDrawable;)Lcom/facebook/drawee/drawable/RoundedColorDrawable;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((colorDrawable == null) ? IntPtr.Zero : ((global::Java.Lang.Object) colorDrawable).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Facebook.Drawee.Drawable.RoundedColorDrawable> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_getRadii;
#pragma warning disable 0169
		static Delegate GetGetRadiiHandler ()
		{
			if (cb_getRadii == null)
				cb_getRadii = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetRadii);
			return cb_getRadii;
		}

		static IntPtr n_GetRadii (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Facebook.Drawee.Drawable.RoundedColorDrawable __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Drawee.Drawable.RoundedColorDrawable> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.GetRadii ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.drawee.drawable']/class[@name='RoundedColorDrawable']/method[@name='getRadii' and count(parameter)=0]"
		[Register ("getRadii", "()[F", "GetGetRadiiHandler")]
		public virtual unsafe float[] GetRadii ()
		{
			const string __id = "getRadii.()[F";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return (float[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (float));
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
			global::Com.Facebook.Drawee.Drawable.RoundedColorDrawable __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Drawee.Drawable.RoundedColorDrawable> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetAlpha (alpha);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.drawee.drawable']/class[@name='RoundedColorDrawable']/method[@name='setAlpha' and count(parameter)=1 and parameter[1][@type='int']]"
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

		static Delegate cb_setBorder_IF;
#pragma warning disable 0169
		static Delegate GetSetBorder_IFHandler ()
		{
			if (cb_setBorder_IF == null)
				cb_setBorder_IF = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int, float>) n_SetBorder_IF);
			return cb_setBorder_IF;
		}

		static void n_SetBorder_IF (IntPtr jnienv, IntPtr native__this, int color, float width)
		{
			global::Com.Facebook.Drawee.Drawable.RoundedColorDrawable __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Drawee.Drawable.RoundedColorDrawable> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetBorder (color, width);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.drawee.drawable']/class[@name='RoundedColorDrawable']/method[@name='setBorder' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='float']]"
		[Register ("setBorder", "(IF)V", "GetSetBorder_IFHandler")]
		public virtual unsafe void SetBorder (int color, float width)
		{
			const string __id = "setBorder.(IF)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (color);
				__args [1] = new JniArgumentValue (width);
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

		static void n_SetColorFilter_Landroid_graphics_ColorFilter_ (IntPtr jnienv, IntPtr native__this, IntPtr native_colorFilter)
		{
			global::Com.Facebook.Drawee.Drawable.RoundedColorDrawable __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Drawee.Drawable.RoundedColorDrawable> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Graphics.ColorFilter colorFilter = global::Java.Lang.Object.GetObject<global::Android.Graphics.ColorFilter> (native_colorFilter, JniHandleOwnership.DoNotTransfer);
			__this.SetColorFilter (colorFilter);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.drawee.drawable']/class[@name='RoundedColorDrawable']/method[@name='setColorFilter' and count(parameter)=1 and parameter[1][@type='android.graphics.ColorFilter']]"
		[Register ("setColorFilter", "(Landroid/graphics/ColorFilter;)V", "GetSetColorFilter_Landroid_graphics_ColorFilter_Handler")]
		public override unsafe void SetColorFilter (global::Android.Graphics.ColorFilter colorFilter)
		{
			const string __id = "setColorFilter.(Landroid/graphics/ColorFilter;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((colorFilter == null) ? IntPtr.Zero : ((global::Java.Lang.Object) colorFilter).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_setRadii_arrayF;
#pragma warning disable 0169
		static Delegate GetSetRadii_arrayFHandler ()
		{
			if (cb_setRadii_arrayF == null)
				cb_setRadii_arrayF = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetRadii_arrayF);
			return cb_setRadii_arrayF;
		}

		static void n_SetRadii_arrayF (IntPtr jnienv, IntPtr native__this, IntPtr native_radii)
		{
			global::Com.Facebook.Drawee.Drawable.RoundedColorDrawable __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Drawee.Drawable.RoundedColorDrawable> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			float[] radii = (float[]) JNIEnv.GetArray (native_radii, JniHandleOwnership.DoNotTransfer, typeof (float));
			__this.SetRadii (radii);
			if (radii != null)
				JNIEnv.CopyArray (radii, native_radii);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.drawee.drawable']/class[@name='RoundedColorDrawable']/method[@name='setRadii' and count(parameter)=1 and parameter[1][@type='float[]']]"
		[Register ("setRadii", "([F)V", "GetSetRadii_arrayFHandler")]
		public virtual unsafe void SetRadii (float[] radii)
		{
			const string __id = "setRadii.([F)V";
			IntPtr native_radii = JNIEnv.NewArray (radii);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_radii);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				if (radii != null) {
					JNIEnv.CopyArray (native_radii, radii);
					JNIEnv.DeleteLocalRef (native_radii);
				}
			}
		}

		static Delegate cb_setRadius_F;
#pragma warning disable 0169
		static Delegate GetSetRadius_FHandler ()
		{
			if (cb_setRadius_F == null)
				cb_setRadius_F = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, float>) n_SetRadius_F);
			return cb_setRadius_F;
		}

		static void n_SetRadius_F (IntPtr jnienv, IntPtr native__this, float radius)
		{
			global::Com.Facebook.Drawee.Drawable.RoundedColorDrawable __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Drawee.Drawable.RoundedColorDrawable> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetRadius (radius);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.drawee.drawable']/class[@name='RoundedColorDrawable']/method[@name='setRadius' and count(parameter)=1 and parameter[1][@type='float']]"
		[Register ("setRadius", "(F)V", "GetSetRadius_FHandler")]
		public virtual unsafe void SetRadius (float radius)
		{
			const string __id = "setRadius.(F)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (radius);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

	}
}
