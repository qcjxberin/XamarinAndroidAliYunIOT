using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace DE.Greenrobot.Event.Util {

	// Metadata.xml XPath class reference: path="/api/package[@name='de.greenrobot.event.util']/class[@name='ErrorDialogFragments']"
	[global::Android.Runtime.Register ("de/greenrobot/event/util/ErrorDialogFragments", DoNotGenerateAcw=true)]
	public partial class ErrorDialogFragments : global::Java.Lang.Object {



		// Metadata.xml XPath field reference: path="/api/package[@name='de.greenrobot.event.util']/class[@name='ErrorDialogFragments']/field[@name='ERROR_DIALOG_ICON']"
		[Register ("ERROR_DIALOG_ICON")]
		public static int ErrorDialogIcon {
			get {
				const string __id = "ERROR_DIALOG_ICON.I";

				var __v = _members.StaticFields.GetInt32Value (__id);
				return __v;
			}
			set {
				const string __id = "ERROR_DIALOG_ICON.I";

				try {
					_members.StaticFields.SetValue (__id, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='de.greenrobot.event.util']/class[@name='ErrorDialogFragments']/field[@name='EVENT_TYPE_ON_CLICK']"
		[Register ("EVENT_TYPE_ON_CLICK")]
		public static global::Java.Lang.Class EventTypeOnClick {
			get {
				const string __id = "EVENT_TYPE_ON_CLICK.Ljava/lang/Class;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Java.Lang.Class> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "EVENT_TYPE_ON_CLICK.Ljava/lang/Class;";

				IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
				try {
					_members.StaticFields.SetValue (__id, new JniObjectReference (native_value));
				} finally {
					global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}
		// Metadata.xml XPath class reference: path="/api/package[@name='de.greenrobot.event.util']/class[@name='ErrorDialogFragments.Honeycomb']"
		[global::Android.Runtime.Register ("de/greenrobot/event/util/ErrorDialogFragments$Honeycomb", DoNotGenerateAcw=true)]
		public partial class Honeycomb : global::Android.App.DialogFragment, global::Android.Content.IDialogInterfaceOnClickListener {

			static readonly JniPeerMembers _members = new XAPeerMembers ("de/greenrobot/event/util/ErrorDialogFragments$Honeycomb", typeof (Honeycomb));
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

			// Metadata.xml XPath constructor reference: path="/api/package[@name='de.greenrobot.event.util']/class[@name='ErrorDialogFragments.Honeycomb']/constructor[@name='ErrorDialogFragments.Honeycomb' and count(parameter)=0]"
			[Register (".ctor", "()V", "")]
			public unsafe Honeycomb ()
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

			static Delegate cb_onClick_Landroid_content_DialogInterface_I;
#pragma warning disable 0169
			static Delegate GetOnClick_Landroid_content_DialogInterface_IHandler ()
			{
				if (cb_onClick_Landroid_content_DialogInterface_I == null)
					cb_onClick_Landroid_content_DialogInterface_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, int>) n_OnClick_Landroid_content_DialogInterface_I);
				return cb_onClick_Landroid_content_DialogInterface_I;
			}

			static void n_OnClick_Landroid_content_DialogInterface_I (IntPtr jnienv, IntPtr native__this, IntPtr native_dialog, int which)
			{
				global::DE.Greenrobot.Event.Util.ErrorDialogFragments.Honeycomb __this = global::Java.Lang.Object.GetObject<global::DE.Greenrobot.Event.Util.ErrorDialogFragments.Honeycomb> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Android.Content.IDialogInterface dialog = (global::Android.Content.IDialogInterface)global::Java.Lang.Object.GetObject<global::Android.Content.IDialogInterface> (native_dialog, JniHandleOwnership.DoNotTransfer);
				__this.OnClick (dialog, which);
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='de.greenrobot.event.util']/class[@name='ErrorDialogFragments.Honeycomb']/method[@name='onClick' and count(parameter)=2 and parameter[1][@type='android.content.DialogInterface'] and parameter[2][@type='int']]"
			[Register ("onClick", "(Landroid/content/DialogInterface;I)V", "GetOnClick_Landroid_content_DialogInterface_IHandler")]
			public virtual unsafe void OnClick (global::Android.Content.IDialogInterface dialog, int which)
			{
				const string __id = "onClick.(Landroid/content/DialogInterface;I)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [2];
					__args [0] = new JniArgumentValue ((dialog == null) ? IntPtr.Zero : ((global::Java.Lang.Object) dialog).Handle);
					__args [1] = new JniArgumentValue (which);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}

		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("de/greenrobot/event/util/ErrorDialogFragments", typeof (ErrorDialogFragments));
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

		protected ErrorDialogFragments (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='de.greenrobot.event.util']/class[@name='ErrorDialogFragments']/constructor[@name='ErrorDialogFragments' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe ErrorDialogFragments ()
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

		// Metadata.xml XPath method reference: path="/api/package[@name='de.greenrobot.event.util']/class[@name='ErrorDialogFragments']/method[@name='createDialog' and count(parameter)=3 and parameter[1][@type='android.content.Context'] and parameter[2][@type='android.os.Bundle'] and parameter[3][@type='android.content.DialogInterface.OnClickListener']]"
		[Register ("createDialog", "(Landroid/content/Context;Landroid/os/Bundle;Landroid/content/DialogInterface$OnClickListener;)Landroid/app/Dialog;", "")]
		public static unsafe global::Android.App.Dialog CreateDialog (global::Android.Content.Context context, global::Android.OS.Bundle arguments, global::Android.Content.IDialogInterfaceOnClickListener onClickListener)
		{
			const string __id = "createDialog.(Landroid/content/Context;Landroid/os/Bundle;Landroid/content/DialogInterface$OnClickListener;)Landroid/app/Dialog;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((context == null) ? IntPtr.Zero : ((global::Java.Lang.Object) context).Handle);
				__args [1] = new JniArgumentValue ((arguments == null) ? IntPtr.Zero : ((global::Java.Lang.Object) arguments).Handle);
				__args [2] = new JniArgumentValue ((onClickListener == null) ? IntPtr.Zero : ((global::Java.Lang.Object) onClickListener).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Android.App.Dialog> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='de.greenrobot.event.util']/class[@name='ErrorDialogFragments']/method[@name='handleOnClick' and count(parameter)=4 and parameter[1][@type='android.content.DialogInterface'] and parameter[2][@type='int'] and parameter[3][@type='android.app.Activity'] and parameter[4][@type='android.os.Bundle']]"
		[Register ("handleOnClick", "(Landroid/content/DialogInterface;ILandroid/app/Activity;Landroid/os/Bundle;)V", "")]
		public static unsafe void HandleOnClick (global::Android.Content.IDialogInterface dialog, int which, global::Android.App.Activity activity, global::Android.OS.Bundle arguments)
		{
			const string __id = "handleOnClick.(Landroid/content/DialogInterface;ILandroid/app/Activity;Landroid/os/Bundle;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue ((dialog == null) ? IntPtr.Zero : ((global::Java.Lang.Object) dialog).Handle);
				__args [1] = new JniArgumentValue (which);
				__args [2] = new JniArgumentValue ((activity == null) ? IntPtr.Zero : ((global::Java.Lang.Object) activity).Handle);
				__args [3] = new JniArgumentValue ((arguments == null) ? IntPtr.Zero : ((global::Java.Lang.Object) arguments).Handle);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
			}
		}

	}
}
