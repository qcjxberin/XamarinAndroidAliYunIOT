using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace DE.Greenrobot.Event.Util {

	// Metadata.xml XPath class reference: path="/api/package[@name='de.greenrobot.event.util']/class[@name='ThrowableFailureEvent']"
	[global::Android.Runtime.Register ("de/greenrobot/event/util/ThrowableFailureEvent", DoNotGenerateAcw=true)]
	public partial class ThrowableFailureEvent : global::Java.Lang.Object {



		// Metadata.xml XPath field reference: path="/api/package[@name='de.greenrobot.event.util']/class[@name='ThrowableFailureEvent']/field[@name='suppressErrorUi']"
		[Register ("suppressErrorUi")]
		protected bool SuppressErrorUi {
			get {
				const string __id = "suppressErrorUi.Z";

				var __v = _members.InstanceFields.GetBooleanValue (__id, this);
				return __v;
			}
			set {
				const string __id = "suppressErrorUi.Z";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}
		static readonly JniPeerMembers _members = new XAPeerMembers ("de/greenrobot/event/util/ThrowableFailureEvent", typeof (ThrowableFailureEvent));
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

		protected ThrowableFailureEvent (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='de.greenrobot.event.util']/class[@name='ThrowableFailureEvent']/constructor[@name='ThrowableFailureEvent' and count(parameter)=1 and parameter[1][@type='java.lang.Throwable']]"
		[Register (".ctor", "(Ljava/lang/Throwable;)V", "")]
		public unsafe ThrowableFailureEvent (global::Java.Lang.Throwable throwable)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Ljava/lang/Throwable;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((throwable == null) ? IntPtr.Zero : ((global::Java.Lang.Throwable) throwable).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='de.greenrobot.event.util']/class[@name='ThrowableFailureEvent']/constructor[@name='ThrowableFailureEvent' and count(parameter)=2 and parameter[1][@type='java.lang.Throwable'] and parameter[2][@type='boolean']]"
		[Register (".ctor", "(Ljava/lang/Throwable;Z)V", "")]
		public unsafe ThrowableFailureEvent (global::Java.Lang.Throwable throwable, bool suppressErrorUi)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Ljava/lang/Throwable;Z)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((throwable == null) ? IntPtr.Zero : ((global::Java.Lang.Throwable) throwable).Handle);
				__args [1] = new JniArgumentValue (suppressErrorUi);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_isSuppressErrorUi;
#pragma warning disable 0169
		static Delegate GetIsSuppressErrorUiHandler ()
		{
			if (cb_isSuppressErrorUi == null)
				cb_isSuppressErrorUi = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsSuppressErrorUi);
			return cb_isSuppressErrorUi;
		}

		static bool n_IsSuppressErrorUi (IntPtr jnienv, IntPtr native__this)
		{
			global::DE.Greenrobot.Event.Util.ThrowableFailureEvent __this = global::Java.Lang.Object.GetObject<global::DE.Greenrobot.Event.Util.ThrowableFailureEvent> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsSuppressErrorUi;
		}
#pragma warning restore 0169

		public virtual unsafe bool IsSuppressErrorUi {
			// Metadata.xml XPath method reference: path="/api/package[@name='de.greenrobot.event.util']/class[@name='ThrowableFailureEvent']/method[@name='isSuppressErrorUi' and count(parameter)=0]"
			[Register ("isSuppressErrorUi", "()Z", "GetIsSuppressErrorUiHandler")]
			get {
				const string __id = "isSuppressErrorUi.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_getThrowable;
#pragma warning disable 0169
		static Delegate GetGetThrowableHandler ()
		{
			if (cb_getThrowable == null)
				cb_getThrowable = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetThrowable);
			return cb_getThrowable;
		}

		static IntPtr n_GetThrowable (IntPtr jnienv, IntPtr native__this)
		{
			global::DE.Greenrobot.Event.Util.ThrowableFailureEvent __this = global::Java.Lang.Object.GetObject<global::DE.Greenrobot.Event.Util.ThrowableFailureEvent> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Throwable);
		}
#pragma warning restore 0169

		public virtual unsafe global::Java.Lang.Throwable Throwable {
			// Metadata.xml XPath method reference: path="/api/package[@name='de.greenrobot.event.util']/class[@name='ThrowableFailureEvent']/method[@name='getThrowable' and count(parameter)=0]"
			[Register ("getThrowable", "()Ljava/lang/Throwable;", "GetGetThrowableHandler")]
			get {
				const string __id = "getThrowable.()Ljava/lang/Throwable;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Java.Lang.Throwable> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

	}
}
