using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Facebook.Drawee.Generic {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.facebook.drawee.generic']/class[@name='RoundingParams']"
	[global::Android.Runtime.Register ("com/facebook/drawee/generic/RoundingParams", DoNotGenerateAcw=true)]
	public partial class RoundingParams : global::Java.Lang.Object {

		// Metadata.xml XPath class reference: path="/api/package[@name='com.facebook.drawee.generic']/class[@name='RoundingParams.RoundingMethod']"
		[global::Android.Runtime.Register ("com/facebook/drawee/generic/RoundingParams$RoundingMethod", DoNotGenerateAcw=true)]
		public sealed partial class RoundingMethod : global::Java.Lang.Enum {



			// Metadata.xml XPath field reference: path="/api/package[@name='com.facebook.drawee.generic']/class[@name='RoundingParams.RoundingMethod']/field[@name='BITMAP_ONLY']"
			[Register ("BITMAP_ONLY")]
			public static global::Com.Facebook.Drawee.Generic.RoundingParams.RoundingMethod BitmapOnly {
				get {
					const string __id = "BITMAP_ONLY.Lcom/facebook/drawee/generic/RoundingParams$RoundingMethod;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Facebook.Drawee.Generic.RoundingParams.RoundingMethod> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.facebook.drawee.generic']/class[@name='RoundingParams.RoundingMethod']/field[@name='OVERLAY_COLOR']"
			[Register ("OVERLAY_COLOR")]
			public static global::Com.Facebook.Drawee.Generic.RoundingParams.RoundingMethod OverlayColor {
				get {
					const string __id = "OVERLAY_COLOR.Lcom/facebook/drawee/generic/RoundingParams$RoundingMethod;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Facebook.Drawee.Generic.RoundingParams.RoundingMethod> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}
			static readonly JniPeerMembers _members = new XAPeerMembers ("com/facebook/drawee/generic/RoundingParams$RoundingMethod", typeof (RoundingMethod));
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

			internal RoundingMethod (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.drawee.generic']/class[@name='RoundingParams.RoundingMethod']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("valueOf", "(Ljava/lang/String;)Lcom/facebook/drawee/generic/RoundingParams$RoundingMethod;", "")]
			public static unsafe global::Com.Facebook.Drawee.Generic.RoundingParams.RoundingMethod ValueOf (string name)
			{
				const string __id = "valueOf.(Ljava/lang/String;)Lcom/facebook/drawee/generic/RoundingParams$RoundingMethod;";
				IntPtr native_name = JNIEnv.NewString (name);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_name);
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Facebook.Drawee.Generic.RoundingParams.RoundingMethod> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					JNIEnv.DeleteLocalRef (native_name);
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.drawee.generic']/class[@name='RoundingParams.RoundingMethod']/method[@name='values' and count(parameter)=0]"
			[Register ("values", "()[Lcom/facebook/drawee/generic/RoundingParams$RoundingMethod;", "")]
			public static unsafe global::Com.Facebook.Drawee.Generic.RoundingParams.RoundingMethod[] Values ()
			{
				const string __id = "values.()[Lcom/facebook/drawee/generic/RoundingParams$RoundingMethod;";
				try {
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
					return (global::Com.Facebook.Drawee.Generic.RoundingParams.RoundingMethod[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (global::Com.Facebook.Drawee.Generic.RoundingParams.RoundingMethod));
				} finally {
				}
			}

		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/facebook/drawee/generic/RoundingParams", typeof (RoundingParams));
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

		protected RoundingParams (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.facebook.drawee.generic']/class[@name='RoundingParams']/constructor[@name='RoundingParams' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe RoundingParams ()
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
			global::Com.Facebook.Drawee.Generic.RoundingParams __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Drawee.Generic.RoundingParams> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.BorderColor;
		}
#pragma warning restore 0169

		public virtual unsafe int BorderColor {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.drawee.generic']/class[@name='RoundingParams']/method[@name='getBorderColor' and count(parameter)=0]"
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
			global::Com.Facebook.Drawee.Generic.RoundingParams __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Drawee.Generic.RoundingParams> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.BorderWidth;
		}
#pragma warning restore 0169

		public virtual unsafe float BorderWidth {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.drawee.generic']/class[@name='RoundingParams']/method[@name='getBorderWidth' and count(parameter)=0]"
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
			global::Com.Facebook.Drawee.Generic.RoundingParams __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Drawee.Generic.RoundingParams> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.OverlayColor;
		}
#pragma warning restore 0169

		public virtual unsafe int OverlayColor {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.drawee.generic']/class[@name='RoundingParams']/method[@name='getOverlayColor' and count(parameter)=0]"
			[Register ("getOverlayColor", "()I", "GetGetOverlayColorHandler")]
			get {
				const string __id = "getOverlayColor.()I";
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
			global::Com.Facebook.Drawee.Generic.RoundingParams __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Drawee.Generic.RoundingParams> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Padding;
		}
#pragma warning restore 0169

		public virtual unsafe float Padding {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.drawee.generic']/class[@name='RoundingParams']/method[@name='getPadding' and count(parameter)=0]"
			[Register ("getPadding", "()F", "GetGetPaddingHandler")]
			get {
				const string __id = "getPadding.()F";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualSingleMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_getRoundAsCircle;
#pragma warning disable 0169
		static Delegate GetGetRoundAsCircleHandler ()
		{
			if (cb_getRoundAsCircle == null)
				cb_getRoundAsCircle = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_GetRoundAsCircle);
			return cb_getRoundAsCircle;
		}

		static bool n_GetRoundAsCircle (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Facebook.Drawee.Generic.RoundingParams __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Drawee.Generic.RoundingParams> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.RoundAsCircle;
		}
#pragma warning restore 0169

		public virtual unsafe bool RoundAsCircle {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.drawee.generic']/class[@name='RoundingParams']/method[@name='getRoundAsCircle' and count(parameter)=0]"
			[Register ("getRoundAsCircle", "()Z", "GetGetRoundAsCircleHandler")]
			get {
				const string __id = "getRoundAsCircle.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
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
			global::Com.Facebook.Drawee.Generic.RoundingParams __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Drawee.Generic.RoundingParams> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ScaleDownInsideBorders;
		}
#pragma warning restore 0169

		public virtual unsafe bool ScaleDownInsideBorders {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.drawee.generic']/class[@name='RoundingParams']/method[@name='getScaleDownInsideBorders' and count(parameter)=0]"
			[Register ("getScaleDownInsideBorders", "()Z", "GetGetScaleDownInsideBordersHandler")]
			get {
				const string __id = "getScaleDownInsideBorders.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.drawee.generic']/class[@name='RoundingParams']/method[@name='asCircle' and count(parameter)=0]"
		[Register ("asCircle", "()Lcom/facebook/drawee/generic/RoundingParams;", "")]
		public static unsafe global::Com.Facebook.Drawee.Generic.RoundingParams AsCircle ()
		{
			const string __id = "asCircle.()Lcom/facebook/drawee/generic/RoundingParams;";
			try {
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
				return global::Java.Lang.Object.GetObject<global::Com.Facebook.Drawee.Generic.RoundingParams> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.drawee.generic']/class[@name='RoundingParams']/method[@name='fromCornersRadii' and count(parameter)=4 and parameter[1][@type='float'] and parameter[2][@type='float'] and parameter[3][@type='float'] and parameter[4][@type='float']]"
		[Register ("fromCornersRadii", "(FFFF)Lcom/facebook/drawee/generic/RoundingParams;", "")]
		public static unsafe global::Com.Facebook.Drawee.Generic.RoundingParams FromCornersRadii (float topLeft, float topRight, float bottomRight, float bottomLeft)
		{
			const string __id = "fromCornersRadii.(FFFF)Lcom/facebook/drawee/generic/RoundingParams;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue (topLeft);
				__args [1] = new JniArgumentValue (topRight);
				__args [2] = new JniArgumentValue (bottomRight);
				__args [3] = new JniArgumentValue (bottomLeft);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Facebook.Drawee.Generic.RoundingParams> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.drawee.generic']/class[@name='RoundingParams']/method[@name='fromCornersRadii' and count(parameter)=1 and parameter[1][@type='float[]']]"
		[Register ("fromCornersRadii", "([F)Lcom/facebook/drawee/generic/RoundingParams;", "")]
		public static unsafe global::Com.Facebook.Drawee.Generic.RoundingParams FromCornersRadii (float[] radii)
		{
			const string __id = "fromCornersRadii.([F)Lcom/facebook/drawee/generic/RoundingParams;";
			IntPtr native_radii = JNIEnv.NewArray (radii);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_radii);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Facebook.Drawee.Generic.RoundingParams> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				if (radii != null) {
					JNIEnv.CopyArray (native_radii, radii);
					JNIEnv.DeleteLocalRef (native_radii);
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.drawee.generic']/class[@name='RoundingParams']/method[@name='fromCornersRadius' and count(parameter)=1 and parameter[1][@type='float']]"
		[Register ("fromCornersRadius", "(F)Lcom/facebook/drawee/generic/RoundingParams;", "")]
		public static unsafe global::Com.Facebook.Drawee.Generic.RoundingParams FromCornersRadius (float radius)
		{
			const string __id = "fromCornersRadius.(F)Lcom/facebook/drawee/generic/RoundingParams;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (radius);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Facebook.Drawee.Generic.RoundingParams> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_getCornersRadii;
#pragma warning disable 0169
		static Delegate GetGetCornersRadiiHandler ()
		{
			if (cb_getCornersRadii == null)
				cb_getCornersRadii = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetCornersRadii);
			return cb_getCornersRadii;
		}

		static IntPtr n_GetCornersRadii (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Facebook.Drawee.Generic.RoundingParams __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Drawee.Generic.RoundingParams> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.GetCornersRadii ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.drawee.generic']/class[@name='RoundingParams']/method[@name='getCornersRadii' and count(parameter)=0]"
		[Register ("getCornersRadii", "()[F", "GetGetCornersRadiiHandler")]
		public virtual unsafe float[] GetCornersRadii ()
		{
			const string __id = "getCornersRadii.()[F";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return (float[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (float));
			} finally {
			}
		}

		static Delegate cb_getRoundingMethod;
#pragma warning disable 0169
		static Delegate GetGetRoundingMethodHandler ()
		{
			if (cb_getRoundingMethod == null)
				cb_getRoundingMethod = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetRoundingMethod);
			return cb_getRoundingMethod;
		}

		static IntPtr n_GetRoundingMethod (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Facebook.Drawee.Generic.RoundingParams __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Drawee.Generic.RoundingParams> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.GetRoundingMethod ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.drawee.generic']/class[@name='RoundingParams']/method[@name='getRoundingMethod' and count(parameter)=0]"
		[Register ("getRoundingMethod", "()Lcom/facebook/drawee/generic/RoundingParams$RoundingMethod;", "GetGetRoundingMethodHandler")]
		public virtual unsafe global::Com.Facebook.Drawee.Generic.RoundingParams.RoundingMethod GetRoundingMethod ()
		{
			const string __id = "getRoundingMethod.()Lcom/facebook/drawee/generic/RoundingParams$RoundingMethod;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Com.Facebook.Drawee.Generic.RoundingParams.RoundingMethod> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_setBorder_IF;
#pragma warning disable 0169
		static Delegate GetSetBorder_IFHandler ()
		{
			if (cb_setBorder_IF == null)
				cb_setBorder_IF = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, float, IntPtr>) n_SetBorder_IF);
			return cb_setBorder_IF;
		}

		static IntPtr n_SetBorder_IF (IntPtr jnienv, IntPtr native__this, int color, float width)
		{
			global::Com.Facebook.Drawee.Generic.RoundingParams __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Drawee.Generic.RoundingParams> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.SetBorder (color, width));
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.drawee.generic']/class[@name='RoundingParams']/method[@name='setBorder' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='float']]"
		[Register ("setBorder", "(IF)Lcom/facebook/drawee/generic/RoundingParams;", "GetSetBorder_IFHandler")]
		public virtual unsafe global::Com.Facebook.Drawee.Generic.RoundingParams SetBorder (int color, float width)
		{
			const string __id = "setBorder.(IF)Lcom/facebook/drawee/generic/RoundingParams;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (color);
				__args [1] = new JniArgumentValue (width);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Facebook.Drawee.Generic.RoundingParams> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_setBorderColor_I;
#pragma warning disable 0169
		static Delegate GetSetBorderColor_IHandler ()
		{
			if (cb_setBorderColor_I == null)
				cb_setBorderColor_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr>) n_SetBorderColor_I);
			return cb_setBorderColor_I;
		}

		static IntPtr n_SetBorderColor_I (IntPtr jnienv, IntPtr native__this, int color)
		{
			global::Com.Facebook.Drawee.Generic.RoundingParams __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Drawee.Generic.RoundingParams> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.SetBorderColor (color));
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.drawee.generic']/class[@name='RoundingParams']/method[@name='setBorderColor' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setBorderColor", "(I)Lcom/facebook/drawee/generic/RoundingParams;", "GetSetBorderColor_IHandler")]
		public virtual unsafe global::Com.Facebook.Drawee.Generic.RoundingParams SetBorderColor (int color)
		{
			const string __id = "setBorderColor.(I)Lcom/facebook/drawee/generic/RoundingParams;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (color);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Facebook.Drawee.Generic.RoundingParams> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_setBorderWidth_F;
#pragma warning disable 0169
		static Delegate GetSetBorderWidth_FHandler ()
		{
			if (cb_setBorderWidth_F == null)
				cb_setBorderWidth_F = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, float, IntPtr>) n_SetBorderWidth_F);
			return cb_setBorderWidth_F;
		}

		static IntPtr n_SetBorderWidth_F (IntPtr jnienv, IntPtr native__this, float width)
		{
			global::Com.Facebook.Drawee.Generic.RoundingParams __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Drawee.Generic.RoundingParams> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.SetBorderWidth (width));
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.drawee.generic']/class[@name='RoundingParams']/method[@name='setBorderWidth' and count(parameter)=1 and parameter[1][@type='float']]"
		[Register ("setBorderWidth", "(F)Lcom/facebook/drawee/generic/RoundingParams;", "GetSetBorderWidth_FHandler")]
		public virtual unsafe global::Com.Facebook.Drawee.Generic.RoundingParams SetBorderWidth (float width)
		{
			const string __id = "setBorderWidth.(F)Lcom/facebook/drawee/generic/RoundingParams;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (width);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Facebook.Drawee.Generic.RoundingParams> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_setCornersRadii_FFFF;
#pragma warning disable 0169
		static Delegate GetSetCornersRadii_FFFFHandler ()
		{
			if (cb_setCornersRadii_FFFF == null)
				cb_setCornersRadii_FFFF = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, float, float, float, float, IntPtr>) n_SetCornersRadii_FFFF);
			return cb_setCornersRadii_FFFF;
		}

		static IntPtr n_SetCornersRadii_FFFF (IntPtr jnienv, IntPtr native__this, float topLeft, float topRight, float bottomRight, float bottomLeft)
		{
			global::Com.Facebook.Drawee.Generic.RoundingParams __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Drawee.Generic.RoundingParams> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.SetCornersRadii (topLeft, topRight, bottomRight, bottomLeft));
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.drawee.generic']/class[@name='RoundingParams']/method[@name='setCornersRadii' and count(parameter)=4 and parameter[1][@type='float'] and parameter[2][@type='float'] and parameter[3][@type='float'] and parameter[4][@type='float']]"
		[Register ("setCornersRadii", "(FFFF)Lcom/facebook/drawee/generic/RoundingParams;", "GetSetCornersRadii_FFFFHandler")]
		public virtual unsafe global::Com.Facebook.Drawee.Generic.RoundingParams SetCornersRadii (float topLeft, float topRight, float bottomRight, float bottomLeft)
		{
			const string __id = "setCornersRadii.(FFFF)Lcom/facebook/drawee/generic/RoundingParams;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue (topLeft);
				__args [1] = new JniArgumentValue (topRight);
				__args [2] = new JniArgumentValue (bottomRight);
				__args [3] = new JniArgumentValue (bottomLeft);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Facebook.Drawee.Generic.RoundingParams> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_setCornersRadii_arrayF;
#pragma warning disable 0169
		static Delegate GetSetCornersRadii_arrayFHandler ()
		{
			if (cb_setCornersRadii_arrayF == null)
				cb_setCornersRadii_arrayF = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_SetCornersRadii_arrayF);
			return cb_setCornersRadii_arrayF;
		}

		static IntPtr n_SetCornersRadii_arrayF (IntPtr jnienv, IntPtr native__this, IntPtr native_radii)
		{
			global::Com.Facebook.Drawee.Generic.RoundingParams __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Drawee.Generic.RoundingParams> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			float[] radii = (float[]) JNIEnv.GetArray (native_radii, JniHandleOwnership.DoNotTransfer, typeof (float));
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetCornersRadii (radii));
			if (radii != null)
				JNIEnv.CopyArray (radii, native_radii);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.drawee.generic']/class[@name='RoundingParams']/method[@name='setCornersRadii' and count(parameter)=1 and parameter[1][@type='float[]']]"
		[Register ("setCornersRadii", "([F)Lcom/facebook/drawee/generic/RoundingParams;", "GetSetCornersRadii_arrayFHandler")]
		public virtual unsafe global::Com.Facebook.Drawee.Generic.RoundingParams SetCornersRadii (float[] radii)
		{
			const string __id = "setCornersRadii.([F)Lcom/facebook/drawee/generic/RoundingParams;";
			IntPtr native_radii = JNIEnv.NewArray (radii);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_radii);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Facebook.Drawee.Generic.RoundingParams> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				if (radii != null) {
					JNIEnv.CopyArray (native_radii, radii);
					JNIEnv.DeleteLocalRef (native_radii);
				}
			}
		}

		static Delegate cb_setCornersRadius_F;
#pragma warning disable 0169
		static Delegate GetSetCornersRadius_FHandler ()
		{
			if (cb_setCornersRadius_F == null)
				cb_setCornersRadius_F = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, float, IntPtr>) n_SetCornersRadius_F);
			return cb_setCornersRadius_F;
		}

		static IntPtr n_SetCornersRadius_F (IntPtr jnienv, IntPtr native__this, float radius)
		{
			global::Com.Facebook.Drawee.Generic.RoundingParams __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Drawee.Generic.RoundingParams> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.SetCornersRadius (radius));
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.drawee.generic']/class[@name='RoundingParams']/method[@name='setCornersRadius' and count(parameter)=1 and parameter[1][@type='float']]"
		[Register ("setCornersRadius", "(F)Lcom/facebook/drawee/generic/RoundingParams;", "GetSetCornersRadius_FHandler")]
		public virtual unsafe global::Com.Facebook.Drawee.Generic.RoundingParams SetCornersRadius (float radius)
		{
			const string __id = "setCornersRadius.(F)Lcom/facebook/drawee/generic/RoundingParams;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (radius);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Facebook.Drawee.Generic.RoundingParams> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_setOverlayColor_I;
#pragma warning disable 0169
		static Delegate GetSetOverlayColor_IHandler ()
		{
			if (cb_setOverlayColor_I == null)
				cb_setOverlayColor_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr>) n_SetOverlayColor_I);
			return cb_setOverlayColor_I;
		}

		static IntPtr n_SetOverlayColor_I (IntPtr jnienv, IntPtr native__this, int overlayColor)
		{
			global::Com.Facebook.Drawee.Generic.RoundingParams __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Drawee.Generic.RoundingParams> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.SetOverlayColor (overlayColor));
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.drawee.generic']/class[@name='RoundingParams']/method[@name='setOverlayColor' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setOverlayColor", "(I)Lcom/facebook/drawee/generic/RoundingParams;", "GetSetOverlayColor_IHandler")]
		public virtual unsafe global::Com.Facebook.Drawee.Generic.RoundingParams SetOverlayColor (int overlayColor)
		{
			const string __id = "setOverlayColor.(I)Lcom/facebook/drawee/generic/RoundingParams;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (overlayColor);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Facebook.Drawee.Generic.RoundingParams> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_setPadding_F;
#pragma warning disable 0169
		static Delegate GetSetPadding_FHandler ()
		{
			if (cb_setPadding_F == null)
				cb_setPadding_F = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, float, IntPtr>) n_SetPadding_F);
			return cb_setPadding_F;
		}

		static IntPtr n_SetPadding_F (IntPtr jnienv, IntPtr native__this, float padding)
		{
			global::Com.Facebook.Drawee.Generic.RoundingParams __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Drawee.Generic.RoundingParams> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.SetPadding (padding));
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.drawee.generic']/class[@name='RoundingParams']/method[@name='setPadding' and count(parameter)=1 and parameter[1][@type='float']]"
		[Register ("setPadding", "(F)Lcom/facebook/drawee/generic/RoundingParams;", "GetSetPadding_FHandler")]
		public virtual unsafe global::Com.Facebook.Drawee.Generic.RoundingParams SetPadding (float padding)
		{
			const string __id = "setPadding.(F)Lcom/facebook/drawee/generic/RoundingParams;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (padding);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Facebook.Drawee.Generic.RoundingParams> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_setRoundAsCircle_Z;
#pragma warning disable 0169
		static Delegate GetSetRoundAsCircle_ZHandler ()
		{
			if (cb_setRoundAsCircle_Z == null)
				cb_setRoundAsCircle_Z = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool, IntPtr>) n_SetRoundAsCircle_Z);
			return cb_setRoundAsCircle_Z;
		}

		static IntPtr n_SetRoundAsCircle_Z (IntPtr jnienv, IntPtr native__this, bool roundAsCircle)
		{
			global::Com.Facebook.Drawee.Generic.RoundingParams __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Drawee.Generic.RoundingParams> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.SetRoundAsCircle (roundAsCircle));
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.drawee.generic']/class[@name='RoundingParams']/method[@name='setRoundAsCircle' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("setRoundAsCircle", "(Z)Lcom/facebook/drawee/generic/RoundingParams;", "GetSetRoundAsCircle_ZHandler")]
		public virtual unsafe global::Com.Facebook.Drawee.Generic.RoundingParams SetRoundAsCircle (bool roundAsCircle)
		{
			const string __id = "setRoundAsCircle.(Z)Lcom/facebook/drawee/generic/RoundingParams;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (roundAsCircle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Facebook.Drawee.Generic.RoundingParams> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_setRoundingMethod_Lcom_facebook_drawee_generic_RoundingParams_RoundingMethod_;
#pragma warning disable 0169
		static Delegate GetSetRoundingMethod_Lcom_facebook_drawee_generic_RoundingParams_RoundingMethod_Handler ()
		{
			if (cb_setRoundingMethod_Lcom_facebook_drawee_generic_RoundingParams_RoundingMethod_ == null)
				cb_setRoundingMethod_Lcom_facebook_drawee_generic_RoundingParams_RoundingMethod_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_SetRoundingMethod_Lcom_facebook_drawee_generic_RoundingParams_RoundingMethod_);
			return cb_setRoundingMethod_Lcom_facebook_drawee_generic_RoundingParams_RoundingMethod_;
		}

		static IntPtr n_SetRoundingMethod_Lcom_facebook_drawee_generic_RoundingParams_RoundingMethod_ (IntPtr jnienv, IntPtr native__this, IntPtr native_roundingMethod)
		{
			global::Com.Facebook.Drawee.Generic.RoundingParams __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Drawee.Generic.RoundingParams> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Facebook.Drawee.Generic.RoundingParams.RoundingMethod roundingMethod = global::Java.Lang.Object.GetObject<global::Com.Facebook.Drawee.Generic.RoundingParams.RoundingMethod> (native_roundingMethod, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetRoundingMethod (roundingMethod));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.drawee.generic']/class[@name='RoundingParams']/method[@name='setRoundingMethod' and count(parameter)=1 and parameter[1][@type='com.facebook.drawee.generic.RoundingParams.RoundingMethod']]"
		[Register ("setRoundingMethod", "(Lcom/facebook/drawee/generic/RoundingParams$RoundingMethod;)Lcom/facebook/drawee/generic/RoundingParams;", "GetSetRoundingMethod_Lcom_facebook_drawee_generic_RoundingParams_RoundingMethod_Handler")]
		public virtual unsafe global::Com.Facebook.Drawee.Generic.RoundingParams SetRoundingMethod (global::Com.Facebook.Drawee.Generic.RoundingParams.RoundingMethod roundingMethod)
		{
			const string __id = "setRoundingMethod.(Lcom/facebook/drawee/generic/RoundingParams$RoundingMethod;)Lcom/facebook/drawee/generic/RoundingParams;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((roundingMethod == null) ? IntPtr.Zero : ((global::Java.Lang.Object) roundingMethod).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Facebook.Drawee.Generic.RoundingParams> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_setScaleDownInsideBorders_Z;
#pragma warning disable 0169
		static Delegate GetSetScaleDownInsideBorders_ZHandler ()
		{
			if (cb_setScaleDownInsideBorders_Z == null)
				cb_setScaleDownInsideBorders_Z = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool, IntPtr>) n_SetScaleDownInsideBorders_Z);
			return cb_setScaleDownInsideBorders_Z;
		}

		static IntPtr n_SetScaleDownInsideBorders_Z (IntPtr jnienv, IntPtr native__this, bool scaleDownInsideBorders)
		{
			global::Com.Facebook.Drawee.Generic.RoundingParams __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Drawee.Generic.RoundingParams> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.SetScaleDownInsideBorders (scaleDownInsideBorders));
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.drawee.generic']/class[@name='RoundingParams']/method[@name='setScaleDownInsideBorders' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("setScaleDownInsideBorders", "(Z)Lcom/facebook/drawee/generic/RoundingParams;", "GetSetScaleDownInsideBorders_ZHandler")]
		public virtual unsafe global::Com.Facebook.Drawee.Generic.RoundingParams SetScaleDownInsideBorders (bool scaleDownInsideBorders)
		{
			const string __id = "setScaleDownInsideBorders.(Z)Lcom/facebook/drawee/generic/RoundingParams;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (scaleDownInsideBorders);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Facebook.Drawee.Generic.RoundingParams> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}
}
