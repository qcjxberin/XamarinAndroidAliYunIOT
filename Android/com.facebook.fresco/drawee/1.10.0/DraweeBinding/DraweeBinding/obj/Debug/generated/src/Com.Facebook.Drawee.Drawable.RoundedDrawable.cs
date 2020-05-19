using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Facebook.Drawee.Drawable {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.facebook.drawee.drawable']/class[@name='RoundedDrawable']"
	[global::Android.Runtime.Register ("com/facebook/drawee/drawable/RoundedDrawable", DoNotGenerateAcw=true)]
	public abstract partial class RoundedDrawable : global::Android.Graphics.Drawables.Drawable, global::Com.Facebook.Drawee.Drawable.IRounded, global::Com.Facebook.Drawee.Drawable.ITransformAwareDrawable {



		// Metadata.xml XPath field reference: path="/api/package[@name='com.facebook.drawee.drawable']/class[@name='RoundedDrawable']/field[@name='mBorderColor']"
		[Register ("mBorderColor")]
		protected int MBorderColor {
			get {
				const string __id = "mBorderColor.I";

				var __v = _members.InstanceFields.GetInt32Value (__id, this);
				return __v;
			}
			set {
				const string __id = "mBorderColor.I";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.facebook.drawee.drawable']/class[@name='RoundedDrawable']/field[@name='mBorderPath']"
		[Register ("mBorderPath")]
		protected global::Android.Graphics.Path MBorderPath {
			get {
				const string __id = "mBorderPath.Landroid/graphics/Path;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return global::Java.Lang.Object.GetObject<global::Android.Graphics.Path> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "mBorderPath.Landroid/graphics/Path;";

				IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.facebook.drawee.drawable']/class[@name='RoundedDrawable']/field[@name='mBorderWidth']"
		[Register ("mBorderWidth")]
		protected float MBorderWidth {
			get {
				const string __id = "mBorderWidth.F";

				var __v = _members.InstanceFields.GetSingleValue (__id, this);
				return __v;
			}
			set {
				const string __id = "mBorderWidth.F";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.facebook.drawee.drawable']/class[@name='RoundedDrawable']/field[@name='mIsCircle']"
		[Register ("mIsCircle")]
		protected bool MIsCircle {
			get {
				const string __id = "mIsCircle.Z";

				var __v = _members.InstanceFields.GetBooleanValue (__id, this);
				return __v;
			}
			set {
				const string __id = "mIsCircle.Z";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.facebook.drawee.drawable']/class[@name='RoundedDrawable']/field[@name='mIsShaderTransformDirty']"
		[Register ("mIsShaderTransformDirty")]
		protected bool MIsShaderTransformDirty {
			get {
				const string __id = "mIsShaderTransformDirty.Z";

				var __v = _members.InstanceFields.GetBooleanValue (__id, this);
				return __v;
			}
			set {
				const string __id = "mIsShaderTransformDirty.Z";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.facebook.drawee.drawable']/class[@name='RoundedDrawable']/field[@name='mPath']"
		[Register ("mPath")]
		protected global::Android.Graphics.Path MPath {
			get {
				const string __id = "mPath.Landroid/graphics/Path;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return global::Java.Lang.Object.GetObject<global::Android.Graphics.Path> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "mPath.Landroid/graphics/Path;";

				IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.facebook.drawee.drawable']/class[@name='RoundedDrawable']/field[@name='mRadiiNonZero']"
		[Register ("mRadiiNonZero")]
		protected bool MRadiiNonZero {
			get {
				const string __id = "mRadiiNonZero.Z";

				var __v = _members.InstanceFields.GetBooleanValue (__id, this);
				return __v;
			}
			set {
				const string __id = "mRadiiNonZero.Z";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/facebook/drawee/drawable/RoundedDrawable", typeof (RoundedDrawable));
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

		protected RoundedDrawable (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

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
			global::Com.Facebook.Drawee.Drawable.RoundedDrawable __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Drawee.Drawable.RoundedDrawable> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.BorderColor;
		}
#pragma warning restore 0169

		public virtual unsafe int BorderColor {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.drawee.drawable']/class[@name='RoundedDrawable']/method[@name='getBorderColor' and count(parameter)=0]"
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
			global::Com.Facebook.Drawee.Drawable.RoundedDrawable __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Drawee.Drawable.RoundedDrawable> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.BorderWidth;
		}
#pragma warning restore 0169

		public virtual unsafe float BorderWidth {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.drawee.drawable']/class[@name='RoundedDrawable']/method[@name='getBorderWidth' and count(parameter)=0]"
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
			global::Com.Facebook.Drawee.Drawable.RoundedDrawable __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Drawee.Drawable.RoundedDrawable> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			global::Com.Facebook.Drawee.Drawable.RoundedDrawable __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Drawee.Drawable.RoundedDrawable> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Circle = isCircle;
		}
#pragma warning restore 0169

		public virtual unsafe bool Circle {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.drawee.drawable']/class[@name='RoundedDrawable']/method[@name='isCircle' and count(parameter)=0]"
			[Register ("isCircle", "()Z", "GetIsCircleHandler")]
			get {
				const string __id = "isCircle.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.drawee.drawable']/class[@name='RoundedDrawable']/method[@name='setCircle' and count(parameter)=1 and parameter[1][@type='boolean']]"
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
			global::Com.Facebook.Drawee.Drawable.RoundedDrawable __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Drawee.Drawable.RoundedDrawable> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Opacity;
		}
#pragma warning restore 0169

		public override unsafe int Opacity {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.drawee.drawable']/class[@name='RoundedDrawable']/method[@name='getOpacity' and count(parameter)=0]"
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
			global::Com.Facebook.Drawee.Drawable.RoundedDrawable __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Drawee.Drawable.RoundedDrawable> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			global::Com.Facebook.Drawee.Drawable.RoundedDrawable __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Drawee.Drawable.RoundedDrawable> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Padding = padding;
		}
#pragma warning restore 0169

		public virtual unsafe float Padding {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.drawee.drawable']/class[@name='RoundedDrawable']/method[@name='getPadding' and count(parameter)=0]"
			[Register ("getPadding", "()F", "GetGetPaddingHandler")]
			get {
				const string __id = "getPadding.()F";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualSingleMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.drawee.drawable']/class[@name='RoundedDrawable']/method[@name='setPadding' and count(parameter)=1 and parameter[1][@type='float']]"
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
			global::Com.Facebook.Drawee.Drawable.RoundedDrawable __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Drawee.Drawable.RoundedDrawable> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			global::Com.Facebook.Drawee.Drawable.RoundedDrawable __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Drawee.Drawable.RoundedDrawable> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ScaleDownInsideBorders = scaleDownInsideBorders;
		}
#pragma warning restore 0169

		public virtual unsafe bool ScaleDownInsideBorders {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.drawee.drawable']/class[@name='RoundedDrawable']/method[@name='getScaleDownInsideBorders' and count(parameter)=0]"
			[Register ("getScaleDownInsideBorders", "()Z", "GetGetScaleDownInsideBordersHandler")]
			get {
				const string __id = "getScaleDownInsideBorders.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.drawee.drawable']/class[@name='RoundedDrawable']/method[@name='setScaleDownInsideBorders' and count(parameter)=1 and parameter[1][@type='boolean']]"
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
			global::Com.Facebook.Drawee.Drawable.RoundedDrawable __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Drawee.Drawable.RoundedDrawable> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Graphics.Canvas canvas = global::Java.Lang.Object.GetObject<global::Android.Graphics.Canvas> (native_canvas, JniHandleOwnership.DoNotTransfer);
			__this.Draw (canvas);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.drawee.drawable']/class[@name='RoundedDrawable']/method[@name='draw' and count(parameter)=1 and parameter[1][@type='android.graphics.Canvas']]"
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
			global::Com.Facebook.Drawee.Drawable.RoundedDrawable __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Drawee.Drawable.RoundedDrawable> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.GetRadii ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.drawee.drawable']/class[@name='RoundedDrawable']/method[@name='getRadii' and count(parameter)=0]"
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
			global::Com.Facebook.Drawee.Drawable.RoundedDrawable __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Drawee.Drawable.RoundedDrawable> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetAlpha (alpha);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.drawee.drawable']/class[@name='RoundedDrawable']/method[@name='setAlpha' and count(parameter)=1 and parameter[1][@type='int']]"
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
			global::Com.Facebook.Drawee.Drawable.RoundedDrawable __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Drawee.Drawable.RoundedDrawable> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetBorder (color, width);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.drawee.drawable']/class[@name='RoundedDrawable']/method[@name='setBorder' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='float']]"
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
			global::Com.Facebook.Drawee.Drawable.RoundedDrawable __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Drawee.Drawable.RoundedDrawable> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Graphics.ColorFilter colorFilter = global::Java.Lang.Object.GetObject<global::Android.Graphics.ColorFilter> (native_colorFilter, JniHandleOwnership.DoNotTransfer);
			__this.SetColorFilter (colorFilter);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.drawee.drawable']/class[@name='RoundedDrawable']/method[@name='setColorFilter' and count(parameter)=1 and parameter[1][@type='android.graphics.ColorFilter']]"
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
			global::Com.Facebook.Drawee.Drawable.RoundedDrawable __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Drawee.Drawable.RoundedDrawable> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			float[] radii = (float[]) JNIEnv.GetArray (native_radii, JniHandleOwnership.DoNotTransfer, typeof (float));
			__this.SetRadii (radii);
			if (radii != null)
				JNIEnv.CopyArray (radii, native_radii);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.drawee.drawable']/class[@name='RoundedDrawable']/method[@name='setRadii' and count(parameter)=1 and parameter[1][@type='float[]']]"
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
			global::Com.Facebook.Drawee.Drawable.RoundedDrawable __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Drawee.Drawable.RoundedDrawable> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetRadius (radius);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.drawee.drawable']/class[@name='RoundedDrawable']/method[@name='setRadius' and count(parameter)=1 and parameter[1][@type='float']]"
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

		static Delegate cb_setTransformCallback_Lcom_facebook_drawee_drawable_TransformCallback_;
#pragma warning disable 0169
		static Delegate GetSetTransformCallback_Lcom_facebook_drawee_drawable_TransformCallback_Handler ()
		{
			if (cb_setTransformCallback_Lcom_facebook_drawee_drawable_TransformCallback_ == null)
				cb_setTransformCallback_Lcom_facebook_drawee_drawable_TransformCallback_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetTransformCallback_Lcom_facebook_drawee_drawable_TransformCallback_);
			return cb_setTransformCallback_Lcom_facebook_drawee_drawable_TransformCallback_;
		}

		static void n_SetTransformCallback_Lcom_facebook_drawee_drawable_TransformCallback_ (IntPtr jnienv, IntPtr native__this, IntPtr native_transformCallback)
		{
			global::Com.Facebook.Drawee.Drawable.RoundedDrawable __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Drawee.Drawable.RoundedDrawable> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Facebook.Drawee.Drawable.ITransformCallback transformCallback = (global::Com.Facebook.Drawee.Drawable.ITransformCallback)global::Java.Lang.Object.GetObject<global::Com.Facebook.Drawee.Drawable.ITransformCallback> (native_transformCallback, JniHandleOwnership.DoNotTransfer);
			__this.SetTransformCallback (transformCallback);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.drawee.drawable']/class[@name='RoundedDrawable']/method[@name='setTransformCallback' and count(parameter)=1 and parameter[1][@type='com.facebook.drawee.drawable.TransformCallback']]"
		[Register ("setTransformCallback", "(Lcom/facebook/drawee/drawable/TransformCallback;)V", "GetSetTransformCallback_Lcom_facebook_drawee_drawable_TransformCallback_Handler")]
		public virtual unsafe void SetTransformCallback (global::Com.Facebook.Drawee.Drawable.ITransformCallback transformCallback)
		{
			const string __id = "setTransformCallback.(Lcom/facebook/drawee/drawable/TransformCallback;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((transformCallback == null) ? IntPtr.Zero : ((global::Java.Lang.Object) transformCallback).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_updatePath;
#pragma warning disable 0169
		static Delegate GetUpdatePathHandler ()
		{
			if (cb_updatePath == null)
				cb_updatePath = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_UpdatePath);
			return cb_updatePath;
		}

		static void n_UpdatePath (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Facebook.Drawee.Drawable.RoundedDrawable __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Drawee.Drawable.RoundedDrawable> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.UpdatePath ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.drawee.drawable']/class[@name='RoundedDrawable']/method[@name='updatePath' and count(parameter)=0]"
		[Register ("updatePath", "()V", "GetUpdatePathHandler")]
		protected virtual unsafe void UpdatePath ()
		{
			const string __id = "updatePath.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_updateTransform;
#pragma warning disable 0169
		static Delegate GetUpdateTransformHandler ()
		{
			if (cb_updateTransform == null)
				cb_updateTransform = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_UpdateTransform);
			return cb_updateTransform;
		}

		static void n_UpdateTransform (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Facebook.Drawee.Drawable.RoundedDrawable __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Drawee.Drawable.RoundedDrawable> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.UpdateTransform ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.drawee.drawable']/class[@name='RoundedDrawable']/method[@name='updateTransform' and count(parameter)=0]"
		[Register ("updateTransform", "()V", "GetUpdateTransformHandler")]
		protected virtual unsafe void UpdateTransform ()
		{
			const string __id = "updateTransform.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

	}

	[global::Android.Runtime.Register ("com/facebook/drawee/drawable/RoundedDrawable", DoNotGenerateAcw=true)]
	internal partial class RoundedDrawableInvoker : RoundedDrawable {

		public RoundedDrawableInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/facebook/drawee/drawable/RoundedDrawable", typeof (RoundedDrawableInvoker));

		public override global::Java.Interop.JniPeerMembers JniPeerMembers {
			get { return _members; }
		}

		protected override global::System.Type ThresholdType {
			get { return _members.ManagedPeerType; }
		}

	}

}
