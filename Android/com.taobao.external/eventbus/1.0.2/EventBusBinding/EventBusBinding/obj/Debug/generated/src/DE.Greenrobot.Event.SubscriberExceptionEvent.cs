using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace DE.Greenrobot.Event {

	// Metadata.xml XPath class reference: path="/api/package[@name='de.greenrobot.event']/class[@name='SubscriberExceptionEvent']"
	[global::Android.Runtime.Register ("de/greenrobot/event/SubscriberExceptionEvent", DoNotGenerateAcw=true)]
	public sealed partial class SubscriberExceptionEvent : global::Java.Lang.Object {



		// Metadata.xml XPath field reference: path="/api/package[@name='de.greenrobot.event']/class[@name='SubscriberExceptionEvent']/field[@name='causingEvent']"
		[Register ("causingEvent")]
		public global::Java.Lang.Object CausingEvent {
			get {
				const string __id = "causingEvent.Ljava/lang/Object;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "causingEvent.Ljava/lang/Object;";

				IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='de.greenrobot.event']/class[@name='SubscriberExceptionEvent']/field[@name='causingSubscriber']"
		[Register ("causingSubscriber")]
		public global::Java.Lang.Object CausingSubscriber {
			get {
				const string __id = "causingSubscriber.Ljava/lang/Object;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "causingSubscriber.Ljava/lang/Object;";

				IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='de.greenrobot.event']/class[@name='SubscriberExceptionEvent']/field[@name='eventBus']"
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


		// Metadata.xml XPath field reference: path="/api/package[@name='de.greenrobot.event']/class[@name='SubscriberExceptionEvent']/field[@name='throwable']"
		[Register ("throwable")]
		public global::Java.Lang.Throwable Throwable {
			get {
				const string __id = "throwable.Ljava/lang/Throwable;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return global::Java.Lang.Object.GetObject<global::Java.Lang.Throwable> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "throwable.Ljava/lang/Throwable;";

				IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}
		static readonly JniPeerMembers _members = new XAPeerMembers ("de/greenrobot/event/SubscriberExceptionEvent", typeof (SubscriberExceptionEvent));
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

		internal SubscriberExceptionEvent (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='de.greenrobot.event']/class[@name='SubscriberExceptionEvent']/constructor[@name='SubscriberExceptionEvent' and count(parameter)=4 and parameter[1][@type='de.greenrobot.event.EventBus'] and parameter[2][@type='java.lang.Throwable'] and parameter[3][@type='java.lang.Object'] and parameter[4][@type='java.lang.Object']]"
		[Register (".ctor", "(Lde/greenrobot/event/EventBus;Ljava/lang/Throwable;Ljava/lang/Object;Ljava/lang/Object;)V", "")]
		public unsafe SubscriberExceptionEvent (global::DE.Greenrobot.Event.EventBus eventBus, global::Java.Lang.Throwable throwable, global::Java.Lang.Object causingEvent, global::Java.Lang.Object causingSubscriber)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Lde/greenrobot/event/EventBus;Ljava/lang/Throwable;Ljava/lang/Object;Ljava/lang/Object;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue ((eventBus == null) ? IntPtr.Zero : ((global::Java.Lang.Object) eventBus).Handle);
				__args [1] = new JniArgumentValue ((throwable == null) ? IntPtr.Zero : ((global::Java.Lang.Throwable) throwable).Handle);
				__args [2] = new JniArgumentValue ((causingEvent == null) ? IntPtr.Zero : ((global::Java.Lang.Object) causingEvent).Handle);
				__args [3] = new JniArgumentValue ((causingSubscriber == null) ? IntPtr.Zero : ((global::Java.Lang.Object) causingSubscriber).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
			}
		}

	}
}
