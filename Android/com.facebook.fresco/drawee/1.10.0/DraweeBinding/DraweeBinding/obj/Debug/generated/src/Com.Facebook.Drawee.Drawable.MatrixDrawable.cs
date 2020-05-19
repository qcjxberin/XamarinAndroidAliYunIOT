using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Facebook.Drawee.Drawable {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.facebook.drawee.drawable']/class[@name='MatrixDrawable']"
	[global::Android.Runtime.Register ("com/facebook/drawee/drawable/MatrixDrawable", DoNotGenerateAcw=true)]
	public partial class MatrixDrawable : global::Com.Facebook.Drawee.Drawable.ForwardingDrawable {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/facebook/drawee/drawable/MatrixDrawable", typeof (MatrixDrawable));
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

		protected MatrixDrawable (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.facebook.drawee.drawable']/class[@name='MatrixDrawable']/constructor[@name='MatrixDrawable' and count(parameter)=2 and parameter[1][@type='android.graphics.drawable.Drawable'] and parameter[2][@type='android.graphics.Matrix']]"
		[Register (".ctor", "(Landroid/graphics/drawable/Drawable;Landroid/graphics/Matrix;)V", "")]
		public unsafe MatrixDrawable (global::Android.Graphics.Drawables.Drawable drawable, global::Android.Graphics.Matrix matrix)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Landroid/graphics/drawable/Drawable;Landroid/graphics/Matrix;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((drawable == null) ? IntPtr.Zero : ((global::Java.Lang.Object) drawable).Handle);
				__args [1] = new JniArgumentValue ((matrix == null) ? IntPtr.Zero : ((global::Java.Lang.Object) matrix).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_getMatrix;
#pragma warning disable 0169
		static Delegate GetGetMatrixHandler ()
		{
			if (cb_getMatrix == null)
				cb_getMatrix = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetMatrix);
			return cb_getMatrix;
		}

		static IntPtr n_GetMatrix (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Facebook.Drawee.Drawable.MatrixDrawable __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Drawee.Drawable.MatrixDrawable> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Matrix);
		}
#pragma warning restore 0169

		static Delegate cb_setMatrix_Landroid_graphics_Matrix_;
#pragma warning disable 0169
		static Delegate GetSetMatrix_Landroid_graphics_Matrix_Handler ()
		{
			if (cb_setMatrix_Landroid_graphics_Matrix_ == null)
				cb_setMatrix_Landroid_graphics_Matrix_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetMatrix_Landroid_graphics_Matrix_);
			return cb_setMatrix_Landroid_graphics_Matrix_;
		}

		static void n_SetMatrix_Landroid_graphics_Matrix_ (IntPtr jnienv, IntPtr native__this, IntPtr native_matrix)
		{
			global::Com.Facebook.Drawee.Drawable.MatrixDrawable __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Drawee.Drawable.MatrixDrawable> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Graphics.Matrix matrix = global::Java.Lang.Object.GetObject<global::Android.Graphics.Matrix> (native_matrix, JniHandleOwnership.DoNotTransfer);
			__this.Matrix = matrix;
		}
#pragma warning restore 0169

		public virtual unsafe global::Android.Graphics.Matrix Matrix {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.drawee.drawable']/class[@name='MatrixDrawable']/method[@name='getMatrix' and count(parameter)=0]"
			[Register ("getMatrix", "()Landroid/graphics/Matrix;", "GetGetMatrixHandler")]
			get {
				const string __id = "getMatrix.()Landroid/graphics/Matrix;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Android.Graphics.Matrix> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.drawee.drawable']/class[@name='MatrixDrawable']/method[@name='setMatrix' and count(parameter)=1 and parameter[1][@type='android.graphics.Matrix']]"
			[Register ("setMatrix", "(Landroid/graphics/Matrix;)V", "GetSetMatrix_Landroid_graphics_Matrix_Handler")]
			set {
				const string __id = "setMatrix.(Landroid/graphics/Matrix;)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((value == null) ? IntPtr.Zero : ((global::Java.Lang.Object) value).Handle);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

	}
}
