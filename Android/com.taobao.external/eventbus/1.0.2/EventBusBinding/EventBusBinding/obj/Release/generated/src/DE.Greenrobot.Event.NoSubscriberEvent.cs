using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace DE.Greenrobot.Event {

	// Metadata.xml XPath class reference: path="/api/package[@name='de.greenrobot.event']/class[@name='NoSubscriberEvent']"
	[global::Android.Runtime.Register ("de/greenrobot/event/NoSubscriberEvent", DoNotGenerateAcw=true)]
	public sealed partial class NoSubscriberEvent : global::Java.Lang.Object {



		// Metadata.xml XPath field reference: path="/api/package[@name='de.greenrobot.event']/class[@name='NoSubscriberEvent']/field[@name='eventBus']"
		[Register ("eventBus")]
		public global::DE.Greenrobot.Event.EventBus EventBus {
			get {
				const string __id = "eventBus.Lde/greenrobot/event/EventBus;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return global::Java.Lang.Object.GetObject<global::DE.Greenrobot.Event.EventBus> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "eventBus.Lde/greenrobot/event/EventBus;";

				IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='de.greenrobot.event']/class[@name='NoSubscriberEvent']/field[@name='originalEvent']"
		[Register ("originalEvent")]
		public global::Java.Lang.Object OriginalEvent {
			get {
				const string __id = "originalEvent.Ljava/lang/Object;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "originalEvent.Ljava/lang/Object;";

				IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}
		static readonly JniPeerMembers _members = new XAPeerMembers ("de/greenrobot/event/NoSubscriberEvent", typeof (NoSubscriberEvent));
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

		internal NoSubscriberEvent (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='de.greenrobot.event']/class[@name='NoSubscriberEvent']/constructor[@name='NoSubscriberEvent' and count(parameter)=2 and parameter[1][@type='de.greenrobot.event.EventBus'] and parameter[2][@type='java.lang.Object']]"
		[Register (".ctor", "(Lde/greenrobot/event/EventBus;Ljava/lang/Object;)V", "")]
		public unsafe NoSubscriberEvent (global::DE.Greenrobot.Event.EventBus eventBus, global::Java.Lang.Object originalEvent)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Lde/greenrobot/event/EventBus;Ljava/lang/Object;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((eventBus == null) ? IntPtr.Zero : ((global::Java.Lang.Object) eventBus).Handle);
				__args [1] = new JniArgumentValue ((originalEvent == null) ? IntPtr.Zero : ((global::Java.Lang.Object) originalEvent).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
			}
		}

	}
}
