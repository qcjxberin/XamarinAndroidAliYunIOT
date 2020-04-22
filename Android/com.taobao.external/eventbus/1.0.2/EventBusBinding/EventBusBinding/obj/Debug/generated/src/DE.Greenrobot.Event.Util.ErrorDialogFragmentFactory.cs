using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace DE.Greenrobot.Event.Util {

	// Metadata.xml XPath class reference: path="/api/package[@name='de.greenrobot.event.util']/class[@name='ErrorDialogFragmentFactory']"
	[global::Android.Runtime.Register ("de/greenrobot/event/util/ErrorDialogFragmentFactory", DoNotGenerateAcw=true)]
	[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
	public abstract partial class ErrorDialogFragmentFactory : global::Java.Lang.Object {



		// Metadata.xml XPath field reference: path="/api/package[@name='de.greenrobot.event.util']/class[@name='ErrorDialogFragmentFactory']/field[@name='config']"
		[Register ("config")]
		protected global::DE.Greenrobot.Event.Util.ErrorDialogConfig Config {
			get {
				const string __id = "config.Lde/greenrobot/event/util/ErrorDialogConfig;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return global::Java.Lang.Object.GetObject<global::DE.Greenrobot.Event.Util.ErrorDialogConfig> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "config.Lde/greenrobot/event/util/ErrorDialogConfig;";

				IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}
		// Metadata.xml XPath class reference: path="/api/package[@name='de.greenrobot.event.util']/class[@name='ErrorDialogFragmentFactory.Honeycomb']"
		[global::Android.Runtime.Register ("de/greenrobot/event/util/ErrorDialogFragmentFactory$Honeycomb", DoNotGenerateAcw=true)]
		public partial class Honeycomb : global::DE.Greenrobot.Event.Util.ErrorDialogFragmentFactory {

			static readonly JniPeerMembers _members = new XAPeerMembers ("de/greenrobot/event/util/ErrorDialogFragmentFactory$Honeycomb", typeof (Honeycomb));
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

			protected Honeycomb (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			// Metadata.xml XPath constructor reference: path="/api/package[@name='de.greenrobot.event.util']/class[@name='ErrorDialogFragmentFactory.Honeycomb']/constructor[@name='ErrorDialogFragmentFactory.Honeycomb' and count(parameter)=1 and parameter[1][@type='de.greenrobot.event.util.ErrorDialogConfig']]"
			[Register (".ctor", "(Lde/greenrobot/event/util/ErrorDialogConfig;)V", "")]
			public unsafe Honeycomb (global::DE.Greenrobot.Event.Util.ErrorDialogConfig config)
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				const string __id = "(Lde/greenrobot/event/util/ErrorDialogConfig;)V";

				if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
					return;

				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((config == null) ? IntPtr.Zero : ((global::Java.Lang.Object) config).Handle);
					var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
					SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
					_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
				} finally {
				}
			}

			static Delegate cb_createErrorFragment_Lde_greenrobot_event_util_ThrowableFailureEvent_Landroid_os_Bundle_;
#pragma warning disable 0169
			static Delegate GetCreateErrorFragment_Lde_greenrobot_event_util_ThrowableFailureEvent_Landroid_os_Bundle_Handler ()
			{
				if (cb_createErrorFragment_Lde_greenrobot_event_util_ThrowableFailureEvent_Landroid_os_Bundle_ == null)
					cb_createErrorFragment_Lde_greenrobot_event_util_ThrowableFailureEvent_Landroid_os_Bundle_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_CreateErrorFragment_Lde_greenrobot_event_util_ThrowableFailureEvent_Landroid_os_Bundle_);
				return cb_createErrorFragment_Lde_greenrobot_event_util_ThrowableFailureEvent_Landroid_os_Bundle_;
			}

			static IntPtr n_CreateErrorFragment_Lde_greenrobot_event_util_ThrowableFailureEvent_Landroid_os_Bundle_ (IntPtr jnienv, IntPtr native__this, IntPtr native_e, IntPtr native_arguments)
			{
				global::DE.Greenrobot.Event.Util.ErrorDialogFragmentFactory.Honeycomb __this = global::Java.Lang.Object.GetObject<global::DE.Greenrobot.Event.Util.ErrorDialogFragmentFactory.Honeycomb> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::DE.Greenrobot.Event.Util.ThrowableFailureEvent e = global::Java.Lang.Object.GetObject<global::DE.Greenrobot.Event.Util.ThrowableFailureEvent> (native_e, JniHandleOwnership.DoNotTransfer);
				global::Android.OS.Bundle arguments = global::Java.Lang.Object.GetObject<global::Android.OS.Bundle> (native_arguments, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.CreateErrorFragment (e, arguments));
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='de.greenrobot.event.util']/class[@name='ErrorDialogFragmentFactory.Honeycomb']/method[@name='createErrorFragment' and count(parameter)=2 and parameter[1][@type='de.greenrobot.event.util.ThrowableFailureEvent'] and parameter[2][@type='android.os.Bundle']]"
			[Register ("createErrorFragment", "(Lde/greenrobot/event/util/ThrowableFailureEvent;Landroid/os/Bundle;)Landroid/app/Fragment;", "GetCreateErrorFragment_Lde_greenrobot_event_util_ThrowableFailureEvent_Landroid_os_Bundle_Handler")]
			protected virtual unsafe global::Android.App.Fragment CreateErrorFragment (global::DE.Greenrobot.Event.Util.ThrowableFailureEvent e, global::Android.OS.Bundle arguments)
			{
				const string __id = "createErrorFragment.(Lde/greenrobot/event/util/ThrowableFailureEvent;Landroid/os/Bundle;)Landroid/app/Fragment;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [2];
					__args [0] = new JniArgumentValue ((e == null) ? IntPtr.Zero : ((global::Java.Lang.Object) e).Handle);
					__args [1] = new JniArgumentValue ((arguments == null) ? IntPtr.Zero : ((global::Java.Lang.Object) arguments).Handle);
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Android.App.Fragment> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("de/greenrobot/event/util/ErrorDialogFragmentFactory", typeof (ErrorDialogFragmentFactory));
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

		protected ErrorDialogFragmentFactory (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='de.greenrobot.event.util']/class[@name='ErrorDialogFragmentFactory']/constructor[@name='ErrorDialogFragmentFactory' and count(parameter)=1 and parameter[1][@type='de.greenrobot.event.util.ErrorDialogConfig']]"
		[Register (".ctor", "(Lde/greenrobot/event/util/ErrorDialogConfig;)V", "")]
		protected unsafe ErrorDialogFragmentFactory (global::DE.Greenrobot.Event.Util.ErrorDialogConfig config)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Lde/greenrobot/event/util/ErrorDialogConfig;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((config == null) ? IntPtr.Zero : ((global::Java.Lang.Object) config).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_createErrorFragment_Lde_greenrobot_event_util_ThrowableFailureEvent_Landroid_os_Bundle_;
#pragma warning disable 0169
		static Delegate GetCreateErrorFragment_Lde_greenrobot_event_util_ThrowableFailureEvent_Landroid_os_Bundle_Handler ()
		{
			if (cb_createErrorFragment_Lde_greenrobot_event_util_ThrowableFailureEvent_Landroid_os_Bundle_ == null)
				cb_createErrorFragment_Lde_greenrobot_event_util_ThrowableFailureEvent_Landroid_os_Bundle_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_CreateErrorFragment_Lde_greenrobot_event_util_ThrowableFailureEvent_Landroid_os_Bundle_);
			return cb_createErrorFragment_Lde_greenrobot_event_util_ThrowableFailureEvent_Landroid_os_Bundle_;
		}

		static IntPtr n_CreateErrorFragment_Lde_greenrobot_event_util_ThrowableFailureEvent_Landroid_os_Bundle_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::DE.Greenrobot.Event.Util.ErrorDialogFragmentFactory __this = global::Java.Lang.Object.GetObject<global::DE.Greenrobot.Event.Util.ErrorDialogFragmentFactory> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::DE.Greenrobot.Event.Util.ThrowableFailureEvent p0 = global::Java.Lang.Object.GetObject<global::DE.Greenrobot.Event.Util.ThrowableFailureEvent> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.Bundle p1 = global::Java.Lang.Object.GetObject<global::Android.OS.Bundle> (native_p1, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.CreateErrorFragment (p0, p1));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='de.greenrobot.event.util']/class[@name='ErrorDialogFragmentFactory']/method[@name='createErrorFragment' and count(parameter)=2 and parameter[1][@type='de.greenrobot.event.util.ThrowableFailureEvent'] and parameter[2][@type='android.os.Bundle']]"
		[Register ("createErrorFragment", "(Lde/greenrobot/event/util/ThrowableFailureEvent;Landroid/os/Bundle;)Ljava/lang/Object;", "GetCreateErrorFragment_Lde_greenrobot_event_util_ThrowableFailureEvent_Landroid_os_Bundle_Handler")]
		protected abstract global::Java.Lang.Object CreateErrorFragment (global::DE.Greenrobot.Event.Util.ThrowableFailureEvent p0, global::Android.OS.Bundle p1);

		static Delegate cb_getMessageFor_Lde_greenrobot_event_util_ThrowableFailureEvent_Landroid_os_Bundle_;
#pragma warning disable 0169
		static Delegate GetGetMessageFor_Lde_greenrobot_event_util_ThrowableFailureEvent_Landroid_os_Bundle_Handler ()
		{
			if (cb_getMessageFor_Lde_greenrobot_event_util_ThrowableFailureEvent_Landroid_os_Bundle_ == null)
				cb_getMessageFor_Lde_greenrobot_event_util_ThrowableFailureEvent_Landroid_os_Bundle_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_GetMessageFor_Lde_greenrobot_event_util_ThrowableFailureEvent_Landroid_os_Bundle_);
			return cb_getMessageFor_Lde_greenrobot_event_util_ThrowableFailureEvent_Landroid_os_Bundle_;
		}

		static IntPtr n_GetMessageFor_Lde_greenrobot_event_util_ThrowableFailureEvent_Landroid_os_Bundle_ (IntPtr jnienv, IntPtr native__this, IntPtr native_e, IntPtr native_arguments)
		{
			global::DE.Greenrobot.Event.Util.ErrorDialogFragmentFactory __this = global::Java.Lang.Object.GetObject<global::DE.Greenrobot.Event.Util.ErrorDialogFragmentFactory> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::DE.Greenrobot.Event.Util.ThrowableFailureEvent e = global::Java.Lang.Object.GetObject<global::DE.Greenrobot.Event.Util.ThrowableFailureEvent> (native_e, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.Bundle arguments = global::Java.Lang.Object.GetObject<global::Android.OS.Bundle> (native_arguments, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewString (__this.GetMessageFor (e, arguments));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='de.greenrobot.event.util']/class[@name='ErrorDialogFragmentFactory']/method[@name='getMessageFor' and count(parameter)=2 and parameter[1][@type='de.greenrobot.event.util.ThrowableFailureEvent'] and parameter[2][@type='android.os.Bundle']]"
		[Register ("getMessageFor", "(Lde/greenrobot/event/util/ThrowableFailureEvent;Landroid/os/Bundle;)Ljava/lang/String;", "GetGetMessageFor_Lde_greenrobot_event_util_ThrowableFailureEvent_Landroid_os_Bundle_Handler")]
		protected virtual unsafe string GetMessageFor (global::DE.Greenrobot.Event.Util.ThrowableFailureEvent e, global::Android.OS.Bundle arguments)
		{
			const string __id = "getMessageFor.(Lde/greenrobot/event/util/ThrowableFailureEvent;Landroid/os/Bundle;)Ljava/lang/String;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((e == null) ? IntPtr.Zero : ((global::Java.Lang.Object) e).Handle);
				__args [1] = new JniArgumentValue ((arguments == null) ? IntPtr.Zero : ((global::Java.Lang.Object) arguments).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_getTitleFor_Lde_greenrobot_event_util_ThrowableFailureEvent_Landroid_os_Bundle_;
#pragma warning disable 0169
		static Delegate GetGetTitleFor_Lde_greenrobot_event_util_ThrowableFailureEvent_Landroid_os_Bundle_Handler ()
		{
			if (cb_getTitleFor_Lde_greenrobot_event_util_ThrowableFailureEvent_Landroid_os_Bundle_ == null)
				cb_getTitleFor_Lde_greenrobot_event_util_ThrowableFailureEvent_Landroid_os_Bundle_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_GetTitleFor_Lde_greenrobot_event_util_ThrowableFailureEvent_Landroid_os_Bundle_);
			return cb_getTitleFor_Lde_greenrobot_event_util_ThrowableFailureEvent_Landroid_os_Bundle_;
		}

		static IntPtr n_GetTitleFor_Lde_greenrobot_event_util_ThrowableFailureEvent_Landroid_os_Bundle_ (IntPtr jnienv, IntPtr native__this, IntPtr native_e, IntPtr native_arguments)
		{
			global::DE.Greenrobot.Event.Util.ErrorDialogFragmentFactory __this = global::Java.Lang.Object.GetObject<global::DE.Greenrobot.Event.Util.ErrorDialogFragmentFactory> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::DE.Greenrobot.Event.Util.ThrowableFailureEvent e = global::Java.Lang.Object.GetObject<global::DE.Greenrobot.Event.Util.ThrowableFailureEvent> (native_e, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.Bundle arguments = global::Java.Lang.Object.GetObject<global::Android.OS.Bundle> (native_arguments, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewString (__this.GetTitleFor (e, arguments));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='de.greenrobot.event.util']/class[@name='ErrorDialogFragmentFactory']/method[@name='getTitleFor' and count(parameter)=2 and parameter[1][@type='de.greenrobot.event.util.ThrowableFailureEvent'] and parameter[2][@type='android.os.Bundle']]"
		[Register ("getTitleFor", "(Lde/greenrobot/event/util/ThrowableFailureEvent;Landroid/os/Bundle;)Ljava/lang/String;", "GetGetTitleFor_Lde_greenrobot_event_util_ThrowableFailureEvent_Landroid_os_Bundle_Handler")]
		protected virtual unsafe string GetTitleFor (global::DE.Greenrobot.Event.Util.ThrowableFailureEvent e, global::Android.OS.Bundle arguments)
		{
			const string __id = "getTitleFor.(Lde/greenrobot/event/util/ThrowableFailureEvent;Landroid/os/Bundle;)Ljava/lang/String;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((e == null) ? IntPtr.Zero : ((global::Java.Lang.Object) e).Handle);
				__args [1] = new JniArgumentValue ((arguments == null) ? IntPtr.Zero : ((global::Java.Lang.Object) arguments).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_prepareErrorFragment_Lde_greenrobot_event_util_ThrowableFailureEvent_ZLandroid_os_Bundle_;
#pragma warning disable 0169
		static Delegate GetPrepareErrorFragment_Lde_greenrobot_event_util_ThrowableFailureEvent_ZLandroid_os_Bundle_Handler ()
		{
			if (cb_prepareErrorFragment_Lde_greenrobot_event_util_ThrowableFailureEvent_ZLandroid_os_Bundle_ == null)
				cb_prepareErrorFragment_Lde_greenrobot_event_util_ThrowableFailureEvent_ZLandroid_os_Bundle_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool, IntPtr, IntPtr>) n_PrepareErrorFragment_Lde_greenrobot_event_util_ThrowableFailureEvent_ZLandroid_os_Bundle_);
			return cb_prepareErrorFragment_Lde_greenrobot_event_util_ThrowableFailureEvent_ZLandroid_os_Bundle_;
		}

		static IntPtr n_PrepareErrorFragment_Lde_greenrobot_event_util_ThrowableFailureEvent_ZLandroid_os_Bundle_ (IntPtr jnienv, IntPtr native__this, IntPtr native_e, bool finishAfterDialog, IntPtr native_argumentsForErrorDialog)
		{
			global::DE.Greenrobot.Event.Util.ErrorDialogFragmentFactory __this = global::Java.Lang.Object.GetObject<global::DE.Greenrobot.Event.Util.ErrorDialogFragmentFactory> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::DE.Greenrobot.Event.Util.ThrowableFailureEvent e = global::Java.Lang.Object.GetObject<global::DE.Greenrobot.Event.Util.ThrowableFailureEvent> (native_e, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.Bundle argumentsForErrorDialog = global::Java.Lang.Object.GetObject<global::Android.OS.Bundle> (native_argumentsForErrorDialog, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.PrepareErrorFragment (e, finishAfterDialog, argumentsForErrorDialog));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='de.greenrobot.event.util']/class[@name='ErrorDialogFragmentFactory']/method[@name='prepareErrorFragment' and count(parameter)=3 and parameter[1][@type='de.greenrobot.event.util.ThrowableFailureEvent'] and parameter[2][@type='boolean'] and parameter[3][@type='android.os.Bundle']]"
		[Register ("prepareErrorFragment", "(Lde/greenrobot/event/util/ThrowableFailureEvent;ZLandroid/os/Bundle;)Ljava/lang/Object;", "GetPrepareErrorFragment_Lde_greenrobot_event_util_ThrowableFailureEvent_ZLandroid_os_Bundle_Handler")]
		protected virtual unsafe global::Java.Lang.Object PrepareErrorFragment (global::DE.Greenrobot.Event.Util.ThrowableFailureEvent e, bool finishAfterDialog, global::Android.OS.Bundle argumentsForErrorDialog)
		{
			const string __id = "prepareErrorFragment.(Lde/greenrobot/event/util/ThrowableFailureEvent;ZLandroid/os/Bundle;)Ljava/lang/Object;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((e == null) ? IntPtr.Zero : ((global::Java.Lang.Object) e).Handle);
				__args [1] = new JniArgumentValue (finishAfterDialog);
				__args [2] = new JniArgumentValue ((argumentsForErrorDialog == null) ? IntPtr.Zero : ((global::Java.Lang.Object) argumentsForErrorDialog).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}

	[global::Android.Runtime.Register ("de/greenrobot/event/util/ErrorDialogFragmentFactory", DoNotGenerateAcw=true)]
	internal partial class ErrorDialogFragmentFactoryInvoker : ErrorDialogFragmentFactory {

		public ErrorDialogFragmentFactoryInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

		static readonly JniPeerMembers _members = new XAPeerMembers ("de/greenrobot/event/util/ErrorDialogFragmentFactory", typeof (ErrorDialogFragmentFactoryInvoker));

		public override global::Java.Interop.JniPeerMembers JniPeerMembers {
			get { return _members; }
		}

		protected override global::System.Type ThresholdType {
			get { return _members.ManagedPeerType; }
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='de.greenrobot.event.util']/class[@name='ErrorDialogFragmentFactory']/method[@name='createErrorFragment' and count(parameter)=2 and parameter[1][@type='de.greenrobot.event.util.ThrowableFailureEvent'] and parameter[2][@type='android.os.Bundle']]"
		[Register ("createErrorFragment", "(Lde/greenrobot/event/util/ThrowableFailureEvent;Landroid/os/Bundle;)Ljava/lang/Object;", "GetCreateErrorFragment_Lde_greenrobot_event_util_ThrowableFailureEvent_Landroid_os_Bundle_Handler")]
		protected override unsafe global::Java.Lang.Object CreateErrorFragment (global::DE.Greenrobot.Event.Util.ThrowableFailureEvent p0, global::Android.OS.Bundle p1)
		{
			const string __id = "createErrorFragment.(Lde/greenrobot/event/util/ThrowableFailureEvent;Landroid/os/Bundle;)Ljava/lang/Object;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}

}
