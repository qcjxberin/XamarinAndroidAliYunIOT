using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Facebook.Drawee.Drawable {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.facebook.drawee.drawable']/interface[@name='Rounded']"
	[Register ("com/facebook/drawee/drawable/Rounded", "", "Com.Facebook.Drawee.Drawable.IRoundedInvoker")]
	public partial interface IRounded : IJavaObject, IJavaPeerable {

		int BorderColor {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.drawee.drawable']/interface[@name='Rounded']/method[@name='getBorderColor' and count(parameter)=0]"
			[Register ("getBorderColor", "()I", "GetGetBorderColorHandler:Com.Facebook.Drawee.Drawable.IRoundedInvoker, DraweeBinding")] get;
		}

		float BorderWidth {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.drawee.drawable']/interface[@name='Rounded']/method[@name='getBorderWidth' and count(parameter)=0]"
			[Register ("getBorderWidth", "()F", "GetGetBorderWidthHandler:Com.Facebook.Drawee.Drawable.IRoundedInvoker, DraweeBinding")] get;
		}

		bool Circle {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.drawee.drawable']/interface[@name='Rounded']/method[@name='isCircle' and count(parameter)=0]"
			[Register ("isCircle", "()Z", "GetIsCircleHandler:Com.Facebook.Drawee.Drawable.IRoundedInvoker, DraweeBinding")] get;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.drawee.drawable']/interface[@name='Rounded']/method[@name='setCircle' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setCircle", "(Z)V", "GetSetCircle_ZHandler:Com.Facebook.Drawee.Drawable.IRoundedInvoker, DraweeBinding")] set;
		}

		float Padding {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.drawee.drawable']/interface[@name='Rounded']/method[@name='getPadding' and count(parameter)=0]"
			[Register ("getPadding", "()F", "GetGetPaddingHandler:Com.Facebook.Drawee.Drawable.IRoundedInvoker, DraweeBinding")] get;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.drawee.drawable']/interface[@name='Rounded']/method[@name='setPadding' and count(parameter)=1 and parameter[1][@type='float']]"
			[Register ("setPadding", "(F)V", "GetSetPadding_FHandler:Com.Facebook.Drawee.Drawable.IRoundedInvoker, DraweeBinding")] set;
		}

		bool ScaleDownInsideBorders {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.drawee.drawable']/interface[@name='Rounded']/method[@name='getScaleDownInsideBorders' and count(parameter)=0]"
			[Register ("getScaleDownInsideBorders", "()Z", "GetGetScaleDownInsideBordersHandler:Com.Facebook.Drawee.Drawable.IRoundedInvoker, DraweeBinding")] get;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.drawee.drawable']/interface[@name='Rounded']/method[@name='setScaleDownInsideBorders' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setScaleDownInsideBorders", "(Z)V", "GetSetScaleDownInsideBorders_ZHandler:Com.Facebook.Drawee.Drawable.IRoundedInvoker, DraweeBinding")] set;
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.drawee.drawable']/interface[@name='Rounded']/method[@name='getRadii' and count(parameter)=0]"
		[Register ("getRadii", "()[F", "GetGetRadiiHandler:Com.Facebook.Drawee.Drawable.IRoundedInvoker, DraweeBinding")]
		float[] GetRadii ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.drawee.drawable']/interface[@name='Rounded']/method[@name='setBorder' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='float']]"
		[Register ("setBorder", "(IF)V", "GetSetBorder_IFHandler:Com.Facebook.Drawee.Drawable.IRoundedInvoker, DraweeBinding")]
		void SetBorder (int p0, float p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.drawee.drawable']/interface[@name='Rounded']/method[@name='setRadii' and count(parameter)=1 and parameter[1][@type='float[]']]"
		[Register ("setRadii", "([F)V", "GetSetRadii_arrayFHandler:Com.Facebook.Drawee.Drawable.IRoundedInvoker, DraweeBinding")]
		void SetRadii (float[] p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.drawee.drawable']/interface[@name='Rounded']/method[@name='setRadius' and count(parameter)=1 and parameter[1][@type='float']]"
		[Register ("setRadius", "(F)V", "GetSetRadius_FHandler:Com.Facebook.Drawee.Drawable.IRoundedInvoker, DraweeBinding")]
		void SetRadius (float p0);

	}

	[global::Android.Runtime.Register ("com/facebook/drawee/drawable/Rounded", DoNotGenerateAcw=true)]
	internal partial class IRoundedInvoker : global::Java.Lang.Object, IRounded {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/facebook/drawee/drawable/Rounded", typeof (IRoundedInvoker));

		static IntPtr java_class_ref {
			get { return _members.JniPeerType.PeerReference.Handle; }
		}

		public override global::Java.Interop.JniPeerMembers JniPeerMembers {
			get { return _members; }
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return _members.ManagedPeerType; }
		}

		IntPtr class_ref;

		public static IRounded GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IRounded> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.facebook.drawee.drawable.Rounded"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IRoundedInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
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
			global::Com.Facebook.Drawee.Drawable.IRounded __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Drawee.Drawable.IRounded> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.BorderColor;
		}
#pragma warning restore 0169

		IntPtr id_getBorderColor;
		public unsafe int BorderColor {
			get {
				if (id_getBorderColor == IntPtr.Zero)
					id_getBorderColor = JNIEnv.GetMethodID (class_ref, "getBorderColor", "()I");
				return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getBorderColor);
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
			global::Com.Facebook.Drawee.Drawable.IRounded __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Drawee.Drawable.IRounded> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.BorderWidth;
		}
#pragma warning restore 0169

		IntPtr id_getBorderWidth;
		public unsafe float BorderWidth {
			get {
				if (id_getBorderWidth == IntPtr.Zero)
					id_getBorderWidth = JNIEnv.GetMethodID (class_ref, "getBorderWidth", "()F");
				return JNIEnv.CallFloatMethod (((global::Java.Lang.Object) this).Handle, id_getBorderWidth);
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
			global::Com.Facebook.Drawee.Drawable.IRounded __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Drawee.Drawable.IRounded> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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

		static void n_SetCircle_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::Com.Facebook.Drawee.Drawable.IRounded __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Drawee.Drawable.IRounded> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Circle = p0;
		}
#pragma warning restore 0169

		IntPtr id_isCircle;
		IntPtr id_setCircle_Z;
		public unsafe bool Circle {
			get {
				if (id_isCircle == IntPtr.Zero)
					id_isCircle = JNIEnv.GetMethodID (class_ref, "isCircle", "()Z");
				return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isCircle);
			}
			set {
				if (id_setCircle_Z == IntPtr.Zero)
					id_setCircle_Z = JNIEnv.GetMethodID (class_ref, "setCircle", "(Z)V");
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (value);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setCircle_Z, __args);
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
			global::Com.Facebook.Drawee.Drawable.IRounded __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Drawee.Drawable.IRounded> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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

		static void n_SetPadding_F (IntPtr jnienv, IntPtr native__this, float p0)
		{
			global::Com.Facebook.Drawee.Drawable.IRounded __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Drawee.Drawable.IRounded> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Padding = p0;
		}
#pragma warning restore 0169

		IntPtr id_getPadding;
		IntPtr id_setPadding_F;
		public unsafe float Padding {
			get {
				if (id_getPadding == IntPtr.Zero)
					id_getPadding = JNIEnv.GetMethodID (class_ref, "getPadding", "()F");
				return JNIEnv.CallFloatMethod (((global::Java.Lang.Object) this).Handle, id_getPadding);
			}
			set {
				if (id_setPadding_F == IntPtr.Zero)
					id_setPadding_F = JNIEnv.GetMethodID (class_ref, "setPadding", "(F)V");
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (value);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setPadding_F, __args);
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
			global::Com.Facebook.Drawee.Drawable.IRounded __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Drawee.Drawable.IRounded> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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

		static void n_SetScaleDownInsideBorders_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::Com.Facebook.Drawee.Drawable.IRounded __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Drawee.Drawable.IRounded> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ScaleDownInsideBorders = p0;
		}
#pragma warning restore 0169

		IntPtr id_getScaleDownInsideBorders;
		IntPtr id_setScaleDownInsideBorders_Z;
		public unsafe bool ScaleDownInsideBorders {
			get {
				if (id_getScaleDownInsideBorders == IntPtr.Zero)
					id_getScaleDownInsideBorders = JNIEnv.GetMethodID (class_ref, "getScaleDownInsideBorders", "()Z");
				return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_getScaleDownInsideBorders);
			}
			set {
				if (id_setScaleDownInsideBorders_Z == IntPtr.Zero)
					id_setScaleDownInsideBorders_Z = JNIEnv.GetMethodID (class_ref, "setScaleDownInsideBorders", "(Z)V");
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (value);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setScaleDownInsideBorders_Z, __args);
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
			global::Com.Facebook.Drawee.Drawable.IRounded __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Drawee.Drawable.IRounded> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.GetRadii ());
		}
#pragma warning restore 0169

		IntPtr id_getRadii;
		public unsafe float[] GetRadii ()
		{
			if (id_getRadii == IntPtr.Zero)
				id_getRadii = JNIEnv.GetMethodID (class_ref, "getRadii", "()[F");
			return (float[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getRadii), JniHandleOwnership.TransferLocalRef, typeof (float));
		}

		static Delegate cb_setBorder_IF;
#pragma warning disable 0169
		static Delegate GetSetBorder_IFHandler ()
		{
			if (cb_setBorder_IF == null)
				cb_setBorder_IF = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int, float>) n_SetBorder_IF);
			return cb_setBorder_IF;
		}

		static void n_SetBorder_IF (IntPtr jnienv, IntPtr native__this, int p0, float p1)
		{
			global::Com.Facebook.Drawee.Drawable.IRounded __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Drawee.Drawable.IRounded> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetBorder (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_setBorder_IF;
		public unsafe void SetBorder (int p0, float p1)
		{
			if (id_setBorder_IF == IntPtr.Zero)
				id_setBorder_IF = JNIEnv.GetMethodID (class_ref, "setBorder", "(IF)V");
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (p1);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setBorder_IF, __args);
		}

		static Delegate cb_setRadii_arrayF;
#pragma warning disable 0169
		static Delegate GetSetRadii_arrayFHandler ()
		{
			if (cb_setRadii_arrayF == null)
				cb_setRadii_arrayF = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetRadii_arrayF);
			return cb_setRadii_arrayF;
		}

		static void n_SetRadii_arrayF (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Facebook.Drawee.Drawable.IRounded __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Drawee.Drawable.IRounded> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			float[] p0 = (float[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (float));
			__this.SetRadii (p0);
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
		}
#pragma warning restore 0169

		IntPtr id_setRadii_arrayF;
		public unsafe void SetRadii (float[] p0)
		{
			if (id_setRadii_arrayF == IntPtr.Zero)
				id_setRadii_arrayF = JNIEnv.GetMethodID (class_ref, "setRadii", "([F)V");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setRadii_arrayF, __args);
			if (p0 != null) {
				JNIEnv.CopyArray (native_p0, p0);
				JNIEnv.DeleteLocalRef (native_p0);
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

		static void n_SetRadius_F (IntPtr jnienv, IntPtr native__this, float p0)
		{
			global::Com.Facebook.Drawee.Drawable.IRounded __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Drawee.Drawable.IRounded> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetRadius (p0);
		}
#pragma warning restore 0169

		IntPtr id_setRadius_F;
		public unsafe void SetRadius (float p0)
		{
			if (id_setRadius_F == IntPtr.Zero)
				id_setRadius_F = JNIEnv.GetMethodID (class_ref, "setRadius", "(F)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setRadius_F, __args);
		}

	}

}
