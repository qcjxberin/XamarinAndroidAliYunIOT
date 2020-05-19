using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Facebook.Drawee.Components {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.facebook.drawee.components']/class[@name='RetryManager']"
	[global::Android.Runtime.Register ("com/facebook/drawee/components/RetryManager", DoNotGenerateAcw=true)]
	public partial class RetryManager : global::Java.Lang.Object {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/facebook/drawee/components/RetryManager", typeof (RetryManager));
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

		protected RetryManager (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.facebook.drawee.components']/class[@name='RetryManager']/constructor[@name='RetryManager' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe RetryManager ()
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

		static Delegate cb_isTapToRetryEnabled;
#pragma warning disable 0169
		static Delegate GetIsTapToRetryEnabledHandler ()
		{
			if (cb_isTapToRetryEnabled == null)
				cb_isTapToRetryEnabled = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsTapToRetryEnabled);
			return cb_isTapToRetryEnabled;
		}

		static bool n_IsTapToRetryEnabled (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Facebook.Drawee.Components.RetryManager __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Drawee.Components.RetryManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.TapToRetryEnabled;
		}
#pragma warning restore 0169

		static Delegate cb_setTapToRetryEnabled_Z;
#pragma warning disable 0169
		static Delegate GetSetTapToRetryEnabled_ZHandler ()
		{
			if (cb_setTapToRetryEnabled_Z == null)
				cb_setTapToRetryEnabled_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_SetTapToRetryEnabled_Z);
			return cb_setTapToRetryEnabled_Z;
		}

		static void n_SetTapToRetryEnabled_Z (IntPtr jnienv, IntPtr native__this, bool tapToRetryEnabled)
		{
			global::Com.Facebook.Drawee.Components.RetryManager __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Drawee.Components.RetryManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.TapToRetryEnabled = tapToRetryEnabled;
		}
#pragma warning restore 0169

		public virtual unsafe bool TapToRetryEnabled {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.drawee.components']/class[@name='RetryManager']/method[@name='isTapToRetryEnabled' and count(parameter)=0]"
			[Register ("isTapToRetryEnabled", "()Z", "GetIsTapToRetryEnabledHandler")]
			get {
				const string __id = "isTapToRetryEnabled.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.drawee.components']/class[@name='RetryManager']/method[@name='setTapToRetryEnabled' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setTapToRetryEnabled", "(Z)V", "GetSetTapToRetryEnabled_ZHandler")]
			set {
				const string __id = "setTapToRetryEnabled.(Z)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_init;
#pragma warning disable 0169
		static Delegate GetInitHandler ()
		{
			if (cb_init == null)
				cb_init = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Init);
			return cb_init;
		}

		static void n_Init (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Facebook.Drawee.Components.RetryManager __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Drawee.Components.RetryManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Init ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.drawee.components']/class[@name='RetryManager']/method[@name='init' and count(parameter)=0]"
		[Register ("init", "()V", "GetInitHandler")]
		public virtual unsafe void Init ()
		{
			const string __id = "init.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.drawee.components']/class[@name='RetryManager']/method[@name='newInstance' and count(parameter)=0]"
		[Register ("newInstance", "()Lcom/facebook/drawee/components/RetryManager;", "")]
		public static unsafe global::Com.Facebook.Drawee.Components.RetryManager NewInstance ()
		{
			const string __id = "newInstance.()Lcom/facebook/drawee/components/RetryManager;";
			try {
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
				return global::Java.Lang.Object.GetObject<global::Com.Facebook.Drawee.Components.RetryManager> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_notifyTapToRetry;
#pragma warning disable 0169
		static Delegate GetNotifyTapToRetryHandler ()
		{
			if (cb_notifyTapToRetry == null)
				cb_notifyTapToRetry = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_NotifyTapToRetry);
			return cb_notifyTapToRetry;
		}

		static void n_NotifyTapToRetry (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Facebook.Drawee.Components.RetryManager __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Drawee.Components.RetryManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.NotifyTapToRetry ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.drawee.components']/class[@name='RetryManager']/method[@name='notifyTapToRetry' and count(parameter)=0]"
		[Register ("notifyTapToRetry", "()V", "GetNotifyTapToRetryHandler")]
		public virtual unsafe void NotifyTapToRetry ()
		{
			const string __id = "notifyTapToRetry.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
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
			global::Com.Facebook.Drawee.Components.RetryManager __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Drawee.Components.RetryManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Reset ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.drawee.components']/class[@name='RetryManager']/method[@name='reset' and count(parameter)=0]"
		[Register ("reset", "()V", "GetResetHandler")]
		public virtual unsafe void Reset ()
		{
			const string __id = "reset.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_setMaxTapToRetryAttemps_I;
#pragma warning disable 0169
		static Delegate GetSetMaxTapToRetryAttemps_IHandler ()
		{
			if (cb_setMaxTapToRetryAttemps_I == null)
				cb_setMaxTapToRetryAttemps_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetMaxTapToRetryAttemps_I);
			return cb_setMaxTapToRetryAttemps_I;
		}

		static void n_SetMaxTapToRetryAttemps_I (IntPtr jnienv, IntPtr native__this, int maxTapToRetryAttemps)
		{
			global::Com.Facebook.Drawee.Components.RetryManager __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Drawee.Components.RetryManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetMaxTapToRetryAttemps (maxTapToRetryAttemps);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.drawee.components']/class[@name='RetryManager']/method[@name='setMaxTapToRetryAttemps' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setMaxTapToRetryAttemps", "(I)V", "GetSetMaxTapToRetryAttemps_IHandler")]
		public virtual unsafe void SetMaxTapToRetryAttemps (int maxTapToRetryAttemps)
		{
			const string __id = "setMaxTapToRetryAttemps.(I)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (maxTapToRetryAttemps);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_shouldRetryOnTap;
#pragma warning disable 0169
		static Delegate GetShouldRetryOnTapHandler ()
		{
			if (cb_shouldRetryOnTap == null)
				cb_shouldRetryOnTap = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_ShouldRetryOnTap);
			return cb_shouldRetryOnTap;
		}

		static bool n_ShouldRetryOnTap (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Facebook.Drawee.Components.RetryManager __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Drawee.Components.RetryManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ShouldRetryOnTap ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.drawee.components']/class[@name='RetryManager']/method[@name='shouldRetryOnTap' and count(parameter)=0]"
		[Register ("shouldRetryOnTap", "()Z", "GetShouldRetryOnTapHandler")]
		public virtual unsafe bool ShouldRetryOnTap ()
		{
			const string __id = "shouldRetryOnTap.()Z";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
				return __rm;
			} finally {
			}
		}

	}
}
