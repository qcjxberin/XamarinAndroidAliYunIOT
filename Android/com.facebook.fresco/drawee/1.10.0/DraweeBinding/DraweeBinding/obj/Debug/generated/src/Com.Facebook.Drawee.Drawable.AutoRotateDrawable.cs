using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Facebook.Drawee.Drawable {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.facebook.drawee.drawable']/class[@name='AutoRotateDrawable']"
	[global::Android.Runtime.Register ("com/facebook/drawee/drawable/AutoRotateDrawable", DoNotGenerateAcw=true)]
	public partial class AutoRotateDrawable : global::Com.Facebook.Drawee.Drawable.ForwardingDrawable, global::Com.Facebook.Drawee.Drawable.ICloneableDrawable, global::Java.Lang.IRunnable {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/facebook/drawee/drawable/AutoRotateDrawable", typeof (AutoRotateDrawable));
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

		protected AutoRotateDrawable (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.facebook.drawee.drawable']/class[@name='AutoRotateDrawable']/constructor[@name='AutoRotateDrawable' and count(parameter)=2 and parameter[1][@type='android.graphics.drawable.Drawable'] and parameter[2][@type='int']]"
		[Register (".ctor", "(Landroid/graphics/drawable/Drawable;I)V", "")]
		public unsafe AutoRotateDrawable (global::Android.Graphics.Drawables.Drawable drawable, int interval)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Landroid/graphics/drawable/Drawable;I)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((drawable == null) ? IntPtr.Zero : ((global::Java.Lang.Object) drawable).Handle);
				__args [1] = new JniArgumentValue (interval);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.facebook.drawee.drawable']/class[@name='AutoRotateDrawable']/constructor[@name='AutoRotateDrawable' and count(parameter)=3 and parameter[1][@type='android.graphics.drawable.Drawable'] and parameter[2][@type='int'] and parameter[3][@type='boolean']]"
		[Register (".ctor", "(Landroid/graphics/drawable/Drawable;IZ)V", "")]
		public unsafe AutoRotateDrawable (global::Android.Graphics.Drawables.Drawable drawable, int interval, bool clockwise)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Landroid/graphics/drawable/Drawable;IZ)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((drawable == null) ? IntPtr.Zero : ((global::Java.Lang.Object) drawable).Handle);
				__args [1] = new JniArgumentValue (interval);
				__args [2] = new JniArgumentValue (clockwise);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_cloneDrawable;
#pragma warning disable 0169
		static Delegate GetRawCloneDrawableHandler ()
		{
			if (cb_cloneDrawable == null)
				cb_cloneDrawable = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_RawCloneDrawable);
			return cb_cloneDrawable;
		}

		static IntPtr n_RawCloneDrawable (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Facebook.Drawee.Drawable.AutoRotateDrawable __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Drawee.Drawable.AutoRotateDrawable> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.RawCloneDrawable ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.drawee.drawable']/class[@name='AutoRotateDrawable']/method[@name='cloneDrawable' and count(parameter)=0]"
		[Register ("cloneDrawable", "()Lcom/facebook/drawee/drawable/AutoRotateDrawable;", "GetRawCloneDrawableHandler")]
		public virtual unsafe global::Com.Facebook.Drawee.Drawable.AutoRotateDrawable RawCloneDrawable ()
		{
			const string __id = "cloneDrawable.()Lcom/facebook/drawee/drawable/AutoRotateDrawable;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Com.Facebook.Drawee.Drawable.AutoRotateDrawable> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_reset;
#pragma warning disable 0169
		static Delegate GetResetHandler ()
		{
			if (cb_reset == null)
				cb_reset = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Reset);
			return cb_reset;
		}

		static void n_Reset (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Facebook.Drawee.Drawable.AutoRotateDrawable __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Drawee.Drawable.AutoRotateDrawable> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Reset ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.drawee.drawable']/class[@name='AutoRotateDrawable']/method[@name='reset' and count(parameter)=0]"
		[Register ("reset", "()V", "GetResetHandler")]
		public virtual unsafe void Reset ()
		{
			const string __id = "reset.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_run;
#pragma warning disable 0169
		static Delegate GetRunHandler ()
		{
			if (cb_run == null)
				cb_run = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Run);
			return cb_run;
		}

		static void n_Run (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Facebook.Drawee.Drawable.AutoRotateDrawable __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Drawee.Drawable.AutoRotateDrawable> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Run ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.drawee.drawable']/class[@name='AutoRotateDrawable']/method[@name='run' and count(parameter)=0]"
		[Register ("run", "()V", "GetRunHandler")]
		public virtual unsafe void Run ()
		{
			const string __id = "run.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_setClockwise_Z;
#pragma warning disable 0169
		static Delegate GetSetClockwise_ZHandler ()
		{
			if (cb_setClockwise_Z == null)
				cb_setClockwise_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_SetClockwise_Z);
			return cb_setClockwise_Z;
		}

		static void n_SetClockwise_Z (IntPtr jnienv, IntPtr native__this, bool clockwise)
		{
			global::Com.Facebook.Drawee.Drawable.AutoRotateDrawable __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Drawee.Drawable.AutoRotateDrawable> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetClockwise (clockwise);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.drawee.drawable']/class[@name='AutoRotateDrawable']/method[@name='setClockwise' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("setClockwise", "(Z)V", "GetSetClockwise_ZHandler")]
		public virtual unsafe void SetClockwise (bool clockwise)
		{
			const string __id = "setClockwise.(Z)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (clockwise);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

	}
}
