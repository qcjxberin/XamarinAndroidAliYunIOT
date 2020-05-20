using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Facebook.Drawee.Components {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.facebook.drawee.components']/class[@name='DeferredReleaser']"
	[global::Android.Runtime.Register ("com/facebook/drawee/components/DeferredReleaser", DoNotGenerateAcw=true)]
	public partial class DeferredReleaser : global::Java.Lang.Object {

		// Metadata.xml XPath interface reference: path="/api/package[@name='com.facebook.drawee.components']/interface[@name='DeferredReleaser.Releasable']"
		[Register ("com/facebook/drawee/components/DeferredReleaser$Releasable", "", "Com.Facebook.Drawee.Components.DeferredReleaser/IReleasableInvoker")]
		public partial interface IReleasable : IJavaObject, IJavaPeerable {

			// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.drawee.components']/interface[@name='DeferredReleaser.Releasable']/method[@name='release' and count(parameter)=0]"
			[Register ("release", "()V", "GetReleaseHandler:Com.Facebook.Drawee.Components.DeferredReleaser/IReleasableInvoker, DraweeBinding")]
			void Release ();

		}

		[global::Android.Runtime.Register ("com/facebook/drawee/components/DeferredReleaser$Releasable", DoNotGenerateAcw=true)]
		internal partial class IReleasableInvoker : global::Java.Lang.Object, IReleasable {

			static readonly JniPeerMembers _members = new XAPeerMembers ("com/facebook/drawee/components/DeferredReleaser$Releasable", typeof (IReleasableInvoker));

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

			public static IReleasable GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<IReleasable> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "com.facebook.drawee.components.DeferredReleaser.Releasable"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public IReleasableInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			static Delegate cb_release;
#pragma warning disable 0169
			static Delegate GetReleaseHandler ()
			{
				if (cb_release == null)
					cb_release = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Release);
				return cb_release;
			}

			static void n_Release (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Facebook.Drawee.Components.DeferredReleaser.IReleasable __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Drawee.Components.DeferredReleaser.IReleasable> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.Release ();
			}
#pragma warning restore 0169

			IntPtr id_release;
			public unsafe void Release ()
			{
				if (id_release == IntPtr.Zero)
					id_release = JNIEnv.GetMethodID (class_ref, "release", "()V");
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_release);
			}

		}


		static readonly JniPeerMembers _members = new XAPeerMembers ("com/facebook/drawee/components/DeferredReleaser", typeof (DeferredReleaser));
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

		protected DeferredReleaser (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.facebook.drawee.components']/class[@name='DeferredReleaser']/constructor[@name='DeferredReleaser' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe DeferredReleaser ()
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

		public static unsafe global::Com.Facebook.Drawee.Components.DeferredReleaser Instance {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.drawee.components']/class[@name='DeferredReleaser']/method[@name='getInstance' and count(parameter)=0]"
			[Register ("getInstance", "()Lcom/facebook/drawee/components/DeferredReleaser;", "")]
			get {
				const string __id = "getInstance.()Lcom/facebook/drawee/components/DeferredReleaser;";
				try {
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
					return global::Java.Lang.Object.GetObject<global::Com.Facebook.Drawee.Components.DeferredReleaser> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_cancelDeferredRelease_Lcom_facebook_drawee_components_DeferredReleaser_Releasable_;
#pragma warning disable 0169
		static Delegate GetCancelDeferredRelease_Lcom_facebook_drawee_components_DeferredReleaser_Releasable_Handler ()
		{
			if (cb_cancelDeferredRelease_Lcom_facebook_drawee_components_DeferredReleaser_Releasable_ == null)
				cb_cancelDeferredRelease_Lcom_facebook_drawee_components_DeferredReleaser_Releasable_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_CancelDeferredRelease_Lcom_facebook_drawee_components_DeferredReleaser_Releasable_);
			return cb_cancelDeferredRelease_Lcom_facebook_drawee_components_DeferredReleaser_Releasable_;
		}

		static void n_CancelDeferredRelease_Lcom_facebook_drawee_components_DeferredReleaser_Releasable_ (IntPtr jnienv, IntPtr native__this, IntPtr native_releasable)
		{
			global::Com.Facebook.Drawee.Components.DeferredReleaser __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Drawee.Components.DeferredReleaser> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Facebook.Drawee.Components.DeferredReleaser.IReleasable releasable = (global::Com.Facebook.Drawee.Components.DeferredReleaser.IReleasable)global::Java.Lang.Object.GetObject<global::Com.Facebook.Drawee.Components.DeferredReleaser.IReleasable> (native_releasable, JniHandleOwnership.DoNotTransfer);
			__this.CancelDeferredRelease (releasable);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.drawee.components']/class[@name='DeferredReleaser']/method[@name='cancelDeferredRelease' and count(parameter)=1 and parameter[1][@type='com.facebook.drawee.components.DeferredReleaser.Releasable']]"
		[Register ("cancelDeferredRelease", "(Lcom/facebook/drawee/components/DeferredReleaser$Releasable;)V", "GetCancelDeferredRelease_Lcom_facebook_drawee_components_DeferredReleaser_Releasable_Handler")]
		public virtual unsafe void CancelDeferredRelease (global::Com.Facebook.Drawee.Components.DeferredReleaser.IReleasable releasable)
		{
			const string __id = "cancelDeferredRelease.(Lcom/facebook/drawee/components/DeferredReleaser$Releasable;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((releasable == null) ? IntPtr.Zero : ((global::Java.Lang.Object) releasable).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_scheduleDeferredRelease_Lcom_facebook_drawee_components_DeferredReleaser_Releasable_;
#pragma warning disable 0169
		static Delegate GetScheduleDeferredRelease_Lcom_facebook_drawee_components_DeferredReleaser_Releasable_Handler ()
		{
			if (cb_scheduleDeferredRelease_Lcom_facebook_drawee_components_DeferredReleaser_Releasable_ == null)
				cb_scheduleDeferredRelease_Lcom_facebook_drawee_components_DeferredReleaser_Releasable_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_ScheduleDeferredRelease_Lcom_facebook_drawee_components_DeferredReleaser_Releasable_);
			return cb_scheduleDeferredRelease_Lcom_facebook_drawee_components_DeferredReleaser_Releasable_;
		}

		static void n_ScheduleDeferredRelease_Lcom_facebook_drawee_components_DeferredReleaser_Releasable_ (IntPtr jnienv, IntPtr native__this, IntPtr native_releasable)
		{
			global::Com.Facebook.Drawee.Components.DeferredReleaser __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Drawee.Components.DeferredReleaser> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Facebook.Drawee.Components.DeferredReleaser.IReleasable releasable = (global::Com.Facebook.Drawee.Components.DeferredReleaser.IReleasable)global::Java.Lang.Object.GetObject<global::Com.Facebook.Drawee.Components.DeferredReleaser.IReleasable> (native_releasable, JniHandleOwnership.DoNotTransfer);
			__this.ScheduleDeferredRelease (releasable);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.drawee.components']/class[@name='DeferredReleaser']/method[@name='scheduleDeferredRelease' and count(parameter)=1 and parameter[1][@type='com.facebook.drawee.components.DeferredReleaser.Releasable']]"
		[Register ("scheduleDeferredRelease", "(Lcom/facebook/drawee/components/DeferredReleaser$Releasable;)V", "GetScheduleDeferredRelease_Lcom_facebook_drawee_components_DeferredReleaser_Releasable_Handler")]
		public virtual unsafe void ScheduleDeferredRelease (global::Com.Facebook.Drawee.Components.DeferredReleaser.IReleasable releasable)
		{
			const string __id = "scheduleDeferredRelease.(Lcom/facebook/drawee/components/DeferredReleaser$Releasable;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((releasable == null) ? IntPtr.Zero : ((global::Java.Lang.Object) releasable).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

	}
}
