using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Facebook.Drawee.Drawable {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.facebook.drawee.drawable']/class[@name='RoundedCornersDrawable']"
	[global::Android.Runtime.Register ("com/facebook/drawee/drawable/RoundedCornersDrawable", DoNotGenerateAcw=true)]
	public partial class RoundedCornersDrawable : global::Com.Facebook.Drawee.Drawable.ForwardingDrawable, global::Com.Facebook.Drawee.Drawable.IRounded {

		// Metadata.xml XPath class reference: path="/api/package[@name='com.facebook.drawee.drawable']/class[@name='RoundedCornersDrawable.Type']"
		[global::Android.Runtime.Register ("com/facebook/drawee/drawable/RoundedCornersDrawable$Type", DoNotGenerateAcw=true)]
		public sealed partial class Type : global::Java.Lang.Enum {



			// Metadata.xml XPath field reference: path="/api/package[@name='com.facebook.drawee.drawable']/class[@name='RoundedCornersDrawable.Type']/field[@name='CLIPPING']"
			[Register ("CLIPPING")]
			public static global::Com.Facebook.Drawee.Drawable.RoundedCornersDrawable.Type Clipping {
				get {
					const string __id = "CLIPPING.Lcom/facebook/drawee/drawable/RoundedCornersDrawable$Type;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Facebook.Drawee.Drawable.RoundedCornersDrawable.Type> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.facebook.drawee.drawable']/class[@name='RoundedCornersDrawable.Type']/field[@name='OVERLAY_COLOR']"
			[Register ("OVERLAY_COLOR")]
			public static global::Com.Facebook.Drawee.Drawable.RoundedCornersDrawable.Type OverlayColor {
				get {
					const string __id = "OVERLAY_COLOR.Lcom/facebook/drawee/drawable/RoundedCornersDrawable$Type;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Facebook.Drawee.Drawable.RoundedCornersDrawable.Type> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}
			static readonly JniPeerMembers _members = new XAPeerMembers ("com/facebook/drawee/drawable/RoundedCornersDrawable$Type", typeof (Type));
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

			internal Type (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.drawee.drawable']/class[@name='RoundedCornersDrawable.Type']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("valueOf", "(Ljava/lang/String;)Lcom/facebook/drawee/drawable/RoundedCornersDrawable$Type;", "")]
			public static unsafe global::Com.Facebook.Drawee.Drawable.RoundedCornersDrawable.Type ValueOf (string name)
			{
				const string __id = "valueOf.(Ljava/lang/String;)Lcom/facebook/drawee/drawable/RoundedCornersDrawable$Type;";
				IntPtr native_name = JNIEnv.NewString (name);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_name);
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Facebook.Drawee.Drawable.RoundedCornersDrawable.Type> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					JNIEnv.DeleteLocalRef (native_name);
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.drawee.drawable']/class[@name='RoundedCornersDrawable.Type']/method[@name='values' and count(parameter)=0]"
			[Register ("values", "()[Lcom/facebook/drawee/drawable/RoundedCornersDrawable$Type;", "")]
			public static unsafe global::Com.Facebook.Drawee.Drawable.RoundedCornersDrawable.Type[] Values ()
			{
				const string __id = "values.()[Lcom/facebook/drawee/drawable/RoundedCornersDrawable$Type;";
				try {
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
					return (global::Com.Facebook.Drawee.Drawable.RoundedCornersDrawable.Type[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (global::Com.Facebook.Drawee.Drawable.RoundedCornersDrawable.Type));
				} finally {
				}
			}

		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/facebook/drawee/drawable/RoundedCornersDrawable", typeof (RoundedCornersDrawable));
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

		protected RoundedCornersDrawable (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.facebook.drawee.drawable']/class[@name='RoundedCornersDrawable']/constructor[@name='RoundedCornersDrawable' and count(parameter)=1 and parameter[1][@type='android.graphics.drawable.Drawable']]"
		[Register (".ctor", "(Landroid/graphics/drawable/Drawable;)V", "")]
		public unsafe RoundedCornersDrawable (global::Android.Graphics.Drawables.Drawable drawable)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Landroid/graphics/drawable/Drawable;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((drawable == null) ? IntPtr.Zero : ((global::Java.Lang.Object) drawable).Handle);
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
			global::Com.Facebook.Drawee.Drawable.RoundedCornersDrawable __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Drawee.Drawable.RoundedCornersDrawable> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.BorderColor;
		}
#pragma warning restore 0169

		public virtual unsafe int BorderColor {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.drawee.drawable']/class[@name='RoundedCornersDrawable']/method[@name='getBorderColor' and count(parameter)=0]"
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
			global::Com.Facebook.Drawee.Drawable.RoundedCornersDrawable __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Drawee.Drawable.RoundedCornersDrawable> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.BorderWidth;
		}
#pragma warning restore 0169

		public virtual unsafe float BorderWidth {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.drawee.drawable']/class[@name='RoundedCornersDrawable']/method[@name='getBorderWidth' and count(parameter)=0]"
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
			global::Com.Facebook.Drawee.Drawable.RoundedCornersDrawable __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Drawee.Drawable.RoundedCornersDrawable> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			global::Com.Facebook.Drawee.Drawable.RoundedCornersDrawable __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Drawee.Drawable.RoundedCornersDrawable> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Circle = isCircle;
		}
#pragma warning restore 0169

		public virtual unsafe bool Circle {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.drawee.drawable']/class[@name='RoundedCornersDrawable']/method[@name='isCircle' and count(parameter)=0]"
			[Register ("isCircle", "()Z", "GetIsCircleHandler")]
			get {
				const string __id = "isCircle.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.drawee.drawable']/class[@name='RoundedCornersDrawable']/method[@name='setCircle' and count(parameter)=1 and parameter[1][@type='boolean']]"
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

		static Delegate cb_getOverlayColor;
#pragma warning disable 0169
		static Delegate GetGetOverlayColorHandler ()
		{
			if (cb_getOverlayColor == null)
				cb_getOverlayColor = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetOverlayColor);
			return cb_getOverlayColor;
		}

		static int n_GetOverlayColor (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Facebook.Drawee.Drawable.RoundedCornersDrawable __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Drawee.Drawable.RoundedCornersDrawable> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.OverlayColor;
		}
#pragma warning restore 0169

		static Delegate cb_setOverlayColor_I;
#pragma warning disable 0169
		static Delegate GetSetOverlayColor_IHandler ()
		{
			if (cb_setOverlayColor_I == null)
				cb_setOverlayColor_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetOverlayColor_I);
			return cb_setOverlayColor_I;
		}

		static void n_SetOverlayColor_I (IntPtr jnienv, IntPtr native__this, int overlayColor)
		{
			global::Com.Facebook.Drawee.Drawable.RoundedCornersDrawable __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Drawee.Drawable.RoundedCornersDrawable> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OverlayColor = overlayColor;
		}
#pragma warning restore 0169

		public virtual unsafe int OverlayColor {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.drawee.drawable']/class[@name='RoundedCornersDrawable']/method[@name='getOverlayColor' and count(parameter)=0]"
			[Register ("getOverlayColor", "()I", "GetGetOverlayColorHandler")]
			get {
				const string __id = "getOverlayColor.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.drawee.drawable']/class[@name='RoundedCornersDrawable']/method[@name='setOverlayColor' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setOverlayColor", "(I)V", "GetSetOverlayColor_IHandler")]
			set {
				const string __id = "setOverlayColor.(I)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
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
			global::Com.Facebook.Drawee.Drawable.RoundedCornersDrawable __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Drawee.Drawable.RoundedCornersDrawable> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			global::Com.Facebook.Drawee.Drawable.RoundedCornersDrawable __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Drawee.Drawable.RoundedCornersDrawable> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Padding = padding;
		}
#pragma warning restore 0169

		public virtual unsafe float Padding {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.drawee.drawable']/class[@name='RoundedCornersDrawable']/method[@name='getPadding' and count(parameter)=0]"
			[Register ("getPadding", "()F", "GetGetPaddingHandler")]
			get {
				const string __id = "getPadding.()F";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualSingleMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.drawee.drawable']/class[@name='RoundedCornersDrawable']/method[@name='setPadding' and count(parameter)=1 and parameter[1][@type='float']]"
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
			global::Com.Facebook.Drawee.Drawable.RoundedCornersDrawable __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Drawee.Drawable.RoundedCornersDrawable> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			global::Com.Facebook.Drawee.Drawable.RoundedCornersDrawable __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Drawee.Drawable.RoundedCornersDrawable> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ScaleDownInsideBorders = scaleDownInsideBorders;
		}
#pragma warning restore 0169

		public virtual unsafe bool ScaleDownInsideBorders {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.drawee.drawable']/class[@name='RoundedCornersDrawable']/method[@name='getScaleDownInsideBorders' and count(parameter)=0]"
			[Register ("getScaleDownInsideBorders", "()Z", "GetGetScaleDownInsideBordersHandler")]
			get {
				const string __id = "getScaleDownInsideBorders.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.drawee.drawable']/class[@name='RoundedCornersDrawable']/method[@name='setScaleDownInsideBorders' and count(parameter)=1 and parameter[1][@type='boolean']]"
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
			global::Com.Facebook.Drawee.Drawable.RoundedCornersDrawable __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Drawee.Drawable.RoundedCornersDrawable> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.GetRadii ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.drawee.drawable']/class[@name='RoundedCornersDrawable']/method[@name='getRadii' and count(parameter)=0]"
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
			global::Com.Facebook.Drawee.Drawable.RoundedCornersDrawable __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Drawee.Drawable.RoundedCornersDrawable> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetBorder (color, width);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.drawee.drawable']/class[@name='RoundedCornersDrawable']/method[@name='setBorder' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='float']]"
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
			global::Com.Facebook.Drawee.Drawable.RoundedCornersDrawable __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Drawee.Drawable.RoundedCornersDrawable> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			float[] radii = (float[]) JNIEnv.GetArray (native_radii, JniHandleOwnership.DoNotTransfer, typeof (float));
			__this.SetRadii (radii);
			if (radii != null)
				JNIEnv.CopyArray (radii, native_radii);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.drawee.drawable']/class[@name='RoundedCornersDrawable']/method[@name='setRadii' and count(parameter)=1 and parameter[1][@type='float[]']]"
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
			global::Com.Facebook.Drawee.Drawable.RoundedCornersDrawable __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Drawee.Drawable.RoundedCornersDrawable> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetRadius (radius);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.drawee.drawable']/class[@name='RoundedCornersDrawable']/method[@name='setRadius' and count(parameter)=1 and parameter[1][@type='float']]"
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

		static Delegate cb_setType_Lcom_facebook_drawee_drawable_RoundedCornersDrawable_Type_;
#pragma warning disable 0169
		static Delegate GetSetType_Lcom_facebook_drawee_drawable_RoundedCornersDrawable_Type_Handler ()
		{
			if (cb_setType_Lcom_facebook_drawee_drawable_RoundedCornersDrawable_Type_ == null)
				cb_setType_Lcom_facebook_drawee_drawable_RoundedCornersDrawable_Type_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetType_Lcom_facebook_drawee_drawable_RoundedCornersDrawable_Type_);
			return cb_setType_Lcom_facebook_drawee_drawable_RoundedCornersDrawable_Type_;
		}

		static void n_SetType_Lcom_facebook_drawee_drawable_RoundedCornersDrawable_Type_ (IntPtr jnienv, IntPtr native__this, IntPtr native_type)
		{
			global::Com.Facebook.Drawee.Drawable.RoundedCornersDrawable __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Drawee.Drawable.RoundedCornersDrawable> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Facebook.Drawee.Drawable.RoundedCornersDrawable.Type type = global::Java.Lang.Object.GetObject<global::Com.Facebook.Drawee.Drawable.RoundedCornersDrawable.Type> (native_type, JniHandleOwnership.DoNotTransfer);
			__this.SetType (type);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.drawee.drawable']/class[@name='RoundedCornersDrawable']/method[@name='setType' and count(parameter)=1 and parameter[1][@type='com.facebook.drawee.drawable.RoundedCornersDrawable.Type']]"
		[Register ("setType", "(Lcom/facebook/drawee/drawable/RoundedCornersDrawable$Type;)V", "GetSetType_Lcom_facebook_drawee_drawable_RoundedCornersDrawable_Type_Handler")]
		public virtual unsafe void SetType (global::Com.Facebook.Drawee.Drawable.RoundedCornersDrawable.Type type)
		{
			const string __id = "setType.(Lcom/facebook/drawee/drawable/RoundedCornersDrawable$Type;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((type == null) ? IntPtr.Zero : ((global::Java.Lang.Object) type).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

	}
}
