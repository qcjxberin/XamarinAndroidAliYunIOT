using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Facebook.Drawee.Drawable {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.facebook.drawee.drawable']/interface[@name='VisibilityCallback']"
	[Register ("com/facebook/drawee/drawable/VisibilityCallback", "", "Com.Facebook.Drawee.Drawable.IVisibilityCallbackInvoker")]
	public partial interface IVisibilityCallback : IJavaObject, IJavaPeerable {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.drawee.drawable']/interface[@name='VisibilityCallback']/method[@name='onDraw' and count(parameter)=0]"
		[Register ("onDraw", "()V", "GetOnDrawHandler:Com.Facebook.Drawee.Drawable.IVisibilityCallbackInvoker, DraweeBinding")]
		void OnDraw ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.drawee.drawable']/interface[@name='VisibilityCallback']/method[@name='onVisibilityChange' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("onVisibilityChange", "(Z)V", "GetOnVisibilityChange_ZHandler:Com.Facebook.Drawee.Drawable.IVisibilityCallbackInvoker, DraweeBinding")]
		void OnVisibilityChange (bool p0);

	}

	[global::Android.Runtime.Register ("com/facebook/drawee/drawable/VisibilityCallback", DoNotGenerateAcw=true)]
	internal partial class IVisibilityCallbackInvoker : global::Java.Lang.Object, IVisibilityCallback {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/facebook/drawee/drawable/VisibilityCallback", typeof (IVisibilityCallbackInvoker));

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

		public static IVisibilityCallback GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IVisibilityCallback> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.facebook.drawee.drawable.VisibilityCallback"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IVisibilityCallbackInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
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
			global::Com.Facebook.Drawee.Drawable.IVisibilityCallback __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Drawee.Drawable.IVisibilityCallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnDraw ();
		}
#pragma warning restore 0169

		IntPtr id_onDraw;
		public unsafe void OnDraw ()
		{
			if (id_onDraw == IntPtr.Zero)
				id_onDraw = JNIEnv.GetMethodID (class_ref, "onDraw", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onDraw);
		}

		static Delegate cb_onVisibilityChange_Z;
#pragma warning disable 0169
		static Delegate GetOnVisibilityChange_ZHandler ()
		{
			if (cb_onVisibilityChange_Z == null)
				cb_onVisibilityChange_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_OnVisibilityChange_Z);
			return cb_onVisibilityChange_Z;
		}

		static void n_OnVisibilityChange_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::Com.Facebook.Drawee.Drawable.IVisibilityCallback __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Drawee.Drawable.IVisibilityCallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnVisibilityChange (p0);
		}
#pragma warning restore 0169

		IntPtr id_onVisibilityChange_Z;
		public unsafe void OnVisibilityChange (bool p0)
		{
			if (id_onVisibilityChange_Z == IntPtr.Zero)
				id_onVisibilityChange_Z = JNIEnv.GetMethodID (class_ref, "onVisibilityChange", "(Z)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onVisibilityChange_Z, __args);
		}

	}

}
