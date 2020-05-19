using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Facebook.Drawee.Interfaces {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.facebook.drawee.interfaces']/interface[@name='DraweeHierarchy']"
	[Register ("com/facebook/drawee/interfaces/DraweeHierarchy", "", "Com.Facebook.Drawee.Interfaces.IDraweeHierarchyInvoker")]
	public partial interface IDraweeHierarchy : IJavaObject, IJavaPeerable {

		global::Android.Graphics.Drawables.Drawable TopLevelDrawable {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.drawee.interfaces']/interface[@name='DraweeHierarchy']/method[@name='getTopLevelDrawable' and count(parameter)=0]"
			[Register ("getTopLevelDrawable", "()Landroid/graphics/drawable/Drawable;", "GetGetTopLevelDrawableHandler:Com.Facebook.Drawee.Interfaces.IDraweeHierarchyInvoker, DraweeBinding")] get;
		}

	}

	[global::Android.Runtime.Register ("com/facebook/drawee/interfaces/DraweeHierarchy", DoNotGenerateAcw=true)]
	internal partial class IDraweeHierarchyInvoker : global::Java.Lang.Object, IDraweeHierarchy {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/facebook/drawee/interfaces/DraweeHierarchy", typeof (IDraweeHierarchyInvoker));

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

		public static IDraweeHierarchy GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IDraweeHierarchy> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.facebook.drawee.interfaces.DraweeHierarchy"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IDraweeHierarchyInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_getTopLevelDrawable;
#pragma warning disable 0169
		static Delegate GetGetTopLevelDrawableHandler ()
		{
			if (cb_getTopLevelDrawable == null)
				cb_getTopLevelDrawable = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetTopLevelDrawable);
			return cb_getTopLevelDrawable;
		}

		static IntPtr n_GetTopLevelDrawable (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Facebook.Drawee.Interfaces.IDraweeHierarchy __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Drawee.Interfaces.IDraweeHierarchy> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.TopLevelDrawable);
		}
#pragma warning restore 0169

		IntPtr id_getTopLevelDrawable;
		public unsafe global::Android.Graphics.Drawables.Drawable TopLevelDrawable {
			get {
				if (id_getTopLevelDrawable == IntPtr.Zero)
					id_getTopLevelDrawable = JNIEnv.GetMethodID (class_ref, "getTopLevelDrawable", "()Landroid/graphics/drawable/Drawable;");
				return global::Java.Lang.Object.GetObject<global::Android.Graphics.Drawables.Drawable> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getTopLevelDrawable), JniHandleOwnership.TransferLocalRef);
			}
		}

	}

}
