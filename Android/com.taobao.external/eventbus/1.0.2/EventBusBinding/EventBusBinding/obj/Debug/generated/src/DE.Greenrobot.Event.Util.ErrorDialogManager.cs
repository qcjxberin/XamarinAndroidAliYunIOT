using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace DE.Greenrobot.Event.Util {

	// Metadata.xml XPath class reference: path="/api/package[@name='de.greenrobot.event.util']/class[@name='ErrorDialogManager']"
	[global::Android.Runtime.Register ("de/greenrobot/event/util/ErrorDialogManager", DoNotGenerateAcw=true)]
	public partial class ErrorDialogManager : global::Java.Lang.Object {


		// Metadata.xml XPath field reference: path="/api/package[@name='de.greenrobot.event.util']/class[@name='ErrorDialogManager']/field[@name='KEY_EVENT_TYPE_ON_CLOSE']"
		[Register ("KEY_EVENT_TYPE_ON_CLOSE")]
		public const string KeyEventTypeOnClose = (string) "de.greenrobot.eventbus.errordialog.event_type_on_close";

		// Metadata.xml XPath field reference: path="/api/package[@name='de.greenrobot.event.util']/class[@name='ErrorDialogManager']/field[@name='KEY_FINISH_AFTER_DIALOG']"
		[Register ("KEY_FINISH_AFTER_DIALOG")]
		public const string KeyFinishAfterDialog = (string) "de.greenrobot.eventbus.errordialog.finish_after_dialog";

		// Metadata.xml XPath field reference: path="/api/package[@name='de.greenrobot.event.util']/class[@name='ErrorDialogManager']/field[@name='KEY_ICON_ID']"
		[Register ("KEY_ICON_ID")]
		public const string KeyIconId = (string) "de.greenrobot.eventbus.errordialog.icon_id";

		// Metadata.xml XPath field reference: path="/api/package[@name='de.greenrobot.event.util']/class[@name='ErrorDialogManager']/field[@name='KEY_MESSAGE']"
		[Register ("KEY_MESSAGE")]
		public const string KeyMessage = (string) "de.greenrobot.eventbus.errordialog.message";

		// Metadata.xml XPath field reference: path="/api/package[@name='de.greenrobot.event.util']/class[@name='ErrorDialogManager']/field[@name='KEY_TITLE']"
		[Register ("KEY_TITLE")]
		public const string KeyTitle = (string) "de.greenrobot.eventbus.errordialog.title";

		// Metadata.xml XPath field reference: path="/api/package[@name='de.greenrobot.event.util']/class[@name='ErrorDialogManager']/field[@name='TAG_ERROR_DIALOG']"
		[Register ("TAG_ERROR_DIALOG")]
		protected const string TagErrorDialog = (string) "de.greenrobot.eventbus.error_dialog";

		// Metadata.xml XPath field reference: path="/api/package[@name='de.greenrobot.event.util']/class[@name='ErrorDialogManager']/field[@name='TAG_ERROR_DIALOG_MANAGER']"
		[Register ("TAG_ERROR_DIALOG_MANAGER")]
		protected const string TagErrorDialogManager = (string) "de.greenrobot.eventbus.error_dialog_manager";


		// Metadata.xml XPath field reference: path="/api/package[@name='de.greenrobot.event.util']/class[@name='ErrorDialogManager']/field[@name='factory']"
		[Register ("factory")]
		public static global::DE.Greenrobot.Event.Util.ErrorDialogFragmentFactory Factory {
			get {
				const string __id = "factory.Lde/greenrobot/event/util/ErrorDialogFragmentFactory;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::DE.Greenrobot.Event.Util.ErrorDialogFragmentFactory> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "factory.Lde/greenrobot/event/util/ErrorDialogFragmentFactory;";

				IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
				try {
					_members.StaticFields.SetValue (__id, new JniObjectReference (native_value));
				} finally {
					global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}
		// Metadata.xml XPath class reference: path="/api/package[@name='de.greenrobot.event.util']/class[@name='ErrorDialogManager.HoneycombManagerFragment']"
		[global::Android.Runtime.Register ("de/greenrobot/event/util/ErrorDialogManager$HoneycombManagerFragment", DoNotGenerateAcw=true)]
		public partial class HoneycombManagerFragment : global::Android.App.Fragment {



			// Metadata.xml XPath field reference: path="/api/package[@name='de.greenrobot.event.util']/class[@name='ErrorDialogManager.HoneycombManagerFragment']/field[@name='argumentsForErrorDialog']"
			[Register ("argumentsForErrorDialog")]
			protected global::Android.OS.Bundle ArgumentsForErrorDialog {
				get {
					const string __id = "argumentsForErrorDialog.Landroid/os/Bundle;";

					var __v = _members.InstanceFields.GetObjectValue (__id, this);
					return global::Java.Lang.Object.GetObject<global::Android.OS.Bundle> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
				set {
					const string __id = "argumentsForErrorDialog.Landroid/os/Bundle;";

					IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
					try {
						_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
					} finally {
						global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
					}
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='de.greenrobot.event.util']/class[@name='ErrorDialogManager.HoneycombManagerFragment']/field[@name='finishAfterDialog']"
			[Register ("finishAfterDialog")]
			protected bool FinishAfterDialog {
				get {
					const string __id = "finishAfterDialog.Z";

					var __v = _members.InstanceFields.GetBooleanValue (__id, this);
					return __v;
				}
				set {
					const string __id = "finishAfterDialog.Z";

					try {
						_members.InstanceFields.SetValue (__id, this, value);
					} finally {
					}
				}
			}
			static readonly JniPeerMembers _members = new XAPeerMembers ("de/greenrobot/event/util/ErrorDialogManager$HoneycombManagerFragment", typeof (HoneycombManagerFragment));
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

			protected HoneycombManagerFragment (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			// Metadata.xml XPath constructor reference: path="/api/package[@name='de.greenrobot.event.util']/class[@name='ErrorDialogManager.HoneycombManagerFragment']/constructor[@name='ErrorDialogManager.HoneycombManagerFragment' and count(parameter)=0]"
			[Register (".ctor", "()V", "")]
			public unsafe HoneycombManagerFragment ()
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

			// Metadata.xml XPath method reference: path="/api/package[@name='de.greenrobot.event.util']/class[@name='ErrorDialogManager.HoneycombManagerFragment']/method[@name='attachTo' and count(parameter)=3 and parameter[1][@type='android.app.Activity'] and parameter[2][@type='boolean'] and parameter[3][@type='android.os.Bundle']]"
			[Register ("attachTo", "(Landroid/app/Activity;ZLandroid/os/Bundle;)V", "")]
			public static unsafe void AttachTo (global::Android.App.Activity activity, bool finishAfterDialog, global::Android.OS.Bundle argumentsForErrorDialog)
			{
				const string __id = "attachTo.(Landroid/app/Activity;ZLandroid/os/Bundle;)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [3];
					__args [0] = new JniArgumentValue ((activity == null) ? IntPtr.Zero : ((global::Java.Lang.Object) activity).Handle);
					__args [1] = new JniArgumentValue (finishAfterDialog);
					__args [2] = new JniArgumentValue ((argumentsForErrorDialog == null) ? IntPtr.Zero : ((global::Java.Lang.Object) argumentsForErrorDialog).Handle);
					_members.StaticMethods.InvokeVoidMethod (__id, __args);
				} finally {
				}
			}

			static Delegate cb_onEventMainThread_Lde_greenrobot_event_util_ThrowableFailureEvent_;
#pragma warning disable 0169
			static Delegate GetOnEventMainThread_Lde_greenrobot_event_util_ThrowableFailureEvent_Handler ()
			{
				if (cb_onEventMainThread_Lde_greenrobot_event_util_ThrowableFailureEvent_ == null)
					cb_onEventMainThread_Lde_greenrobot_event_util_ThrowableFailureEvent_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnEventMainThread_Lde_greenrobot_event_util_ThrowableFailureEvent_);
				return cb_onEventMainThread_Lde_greenrobot_event_util_ThrowableFailureEvent_;
			}

			static void n_OnEventMainThread_Lde_greenrobot_event_util_ThrowableFailureEvent_ (IntPtr jnienv, IntPtr native__this, IntPtr native_e)
			{
				global::DE.Greenrobot.Event.Util.ErrorDialogManager.HoneycombManagerFragment __this = global::Java.Lang.Object.GetObject<global::DE.Greenrobot.Event.Util.ErrorDialogManager.HoneycombManagerFragment> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::DE.Greenrobot.Event.Util.ThrowableFailureEvent e = global::Java.Lang.Object.GetObject<global::DE.Greenrobot.Event.Util.ThrowableFailureEvent> (native_e, JniHandleOwnership.DoNotTransfer);
				__this.OnEventMainThread (e);
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='de.greenrobot.event.util']/class[@name='ErrorDialogManager.HoneycombManagerFragment']/method[@name='onEventMainThread' and count(parameter)=1 and parameter[1][@type='de.greenrobot.event.util.ThrowableFailureEvent']]"
			[Register ("onEventMainThread", "(Lde/greenrobot/event/util/ThrowableFailureEvent;)V", "GetOnEventMainThread_Lde_greenrobot_event_util_ThrowableFailureEvent_Handler")]
			public virtual unsafe void OnEventMainThread (global::DE.Greenrobot.Event.Util.ThrowableFailureEvent e)
			{
				const string __id = "onEventMainThread.(Lde/greenrobot/event/util/ThrowableFailureEvent;)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((e == null) ? IntPtr.Zero : ((global::Java.Lang.Object) e).Handle);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}

		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("de/greenrobot/event/util/ErrorDialogManager", typeof (ErrorDialogManager));
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

		protected ErrorDialogManager (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='de.greenrobot.event.util']/class[@name='ErrorDialogManager']/constructor[@name='ErrorDialogManager' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe ErrorDialogManager ()
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

		// Metadata.xml XPath method reference: path="/api/package[@name='de.greenrobot.event.util']/class[@name='ErrorDialogManager']/method[@name='attachTo' and count(parameter)=1 and parameter[1][@type='android.app.Activity']]"
		[Register ("attachTo", "(Landroid/app/Activity;)V", "")]
		public static unsafe void AttachTo (global::Android.App.Activity activity)
		{
			const string __id = "attachTo.(Landroid/app/Activity;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((activity == null) ? IntPtr.Zero : ((global::Java.Lang.Object) activity).Handle);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='de.greenrobot.event.util']/class[@name='ErrorDialogManager']/method[@name='attachTo' and count(parameter)=2 and parameter[1][@type='android.app.Activity'] and parameter[2][@type='boolean']]"
		[Register ("attachTo", "(Landroid/app/Activity;Z)V", "")]
		public static unsafe void AttachTo (global::Android.App.Activity activity, bool finishAfterDialog)
		{
			const string __id = "attachTo.(Landroid/app/Activity;Z)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((activity == null) ? IntPtr.Zero : ((global::Java.Lang.Object) activity).Handle);
				__args [1] = new JniArgumentValue (finishAfterDialog);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='de.greenrobot.event.util']/class[@name='ErrorDialogManager']/method[@name='attachTo' and count(parameter)=3 and parameter[1][@type='android.app.Activity'] and parameter[2][@type='boolean'] and parameter[3][@type='android.os.Bundle']]"
		[Register ("attachTo", "(Landroid/app/Activity;ZLandroid/os/Bundle;)V", "")]
		public static unsafe void AttachTo (global::Android.App.Activity activity, bool finishAfterDialog, global::Android.OS.Bundle argumentsForErrorDialog)
		{
			const string __id = "attachTo.(Landroid/app/Activity;ZLandroid/os/Bundle;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((activity == null) ? IntPtr.Zero : ((global::Java.Lang.Object) activity).Handle);
				__args [1] = new JniArgumentValue (finishAfterDialog);
				__args [2] = new JniArgumentValue ((argumentsForErrorDialog == null) ? IntPtr.Zero : ((global::Java.Lang.Object) argumentsForErrorDialog).Handle);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='de.greenrobot.event.util']/class[@name='ErrorDialogManager']/method[@name='checkLogException' and count(parameter)=1 and parameter[1][@type='de.greenrobot.event.util.ThrowableFailureEvent']]"
		[Register ("checkLogException", "(Lde/greenrobot/event/util/ThrowableFailureEvent;)V", "")]
		protected static unsafe void CheckLogException (global::DE.Greenrobot.Event.Util.ThrowableFailureEvent e)
		{
			const string __id = "checkLogException.(Lde/greenrobot/event/util/ThrowableFailureEvent;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((e == null) ? IntPtr.Zero : ((global::Java.Lang.Object) e).Handle);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
			}
		}

	}
}
