using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Facebook.Drawee.Drawable {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.facebook.drawee.drawable']/interface[@name='CloneableDrawable']"
	[Register ("com/facebook/drawee/drawable/CloneableDrawable", "", "Com.Facebook.Drawee.Drawable.ICloneableDrawableInvoker")]
	public partial interface ICloneableDrawable : IJavaObject, IJavaPeerable {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.drawee.drawable']/interface[@name='CloneableDrawable']/method[@name='cloneDrawable' and count(parameter)=0]"
		[Register ("cloneDrawable", "()Landroid/graphics/drawable/Drawable;", "GetCloneDrawableHandler:Com.Facebook.Drawee.Drawable.ICloneableDrawableInvoker, DraweeBinding")]
		global::Android.Graphics.Drawables.Drawable CloneDrawable ();

	}

	[global::Android.Runtime.Register ("com/facebook/drawee/drawable/CloneableDrawable", DoNotGenerateAcw=true)]
	internal partial class ICloneableDrawableInvoker : global::Java.Lang.Object, ICloneableDrawable {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/facebook/drawee/drawable/CloneableDrawable", typeof (ICloneableDrawableInvoker));

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

		public static ICloneableDrawable GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<ICloneableDrawable> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.facebook.drawee.drawable.CloneableDrawable"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public ICloneableDrawableInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
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
			global::Com.Facebook.Drawee.Drawable.ICloneableDrawable __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Drawee.Drawable.ICloneableDrawable> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.CloneDrawable ());
		}
#pragma warning restore 0169

		IntPtr id_cloneDrawable;
		public unsafe global::Android.Graphics.Drawables.Drawable CloneDrawable ()
		{
			if (id_cloneDrawable == IntPtr.Zero)
				id_cloneDrawable = JNIEnv.GetMethodID (class_ref, "cloneDrawable", "()Landroid/graphics/drawable/Drawable;");
			return global::Java.Lang.Object.GetObject<global::Android.Graphics.Drawables.Drawable> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_cloneDrawable), JniHandleOwnership.TransferLocalRef);
		}

	}

}
