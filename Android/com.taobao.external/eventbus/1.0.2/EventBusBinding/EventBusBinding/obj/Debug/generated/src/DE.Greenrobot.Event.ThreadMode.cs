using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace DE.Greenrobot.Event {

	// Metadata.xml XPath class reference: path="/api/package[@name='de.greenrobot.event']/class[@name='ThreadMode']"
	[global::Android.Runtime.Register ("de/greenrobot/event/ThreadMode", DoNotGenerateAcw=true)]
	public sealed partial class ThreadMode : global::Java.Lang.Enum {



		// Metadata.xml XPath field reference: path="/api/package[@name='de.greenrobot.event']/class[@name='ThreadMode']/field[@name='Async']"
		[Register ("Async")]
		public static global::DE.Greenrobot.Event.ThreadMode Async {
			get {
				const string __id = "Async.Lde/greenrobot/event/ThreadMode;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::DE.Greenrobot.Event.ThreadMode> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='de.greenrobot.event']/class[@name='ThreadMode']/field[@name='BackgroundThread']"
		[Register ("BackgroundThread")]
		public static global::DE.Greenrobot.Event.ThreadMode BackgroundThread {
			get {
				const string __id = "BackgroundThread.Lde/greenrobot/event/ThreadMode;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::DE.Greenrobot.Event.ThreadMode> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='de.greenrobot.event']/class[@name='ThreadMode']/field[@name='MainThread']"
		[Register ("MainThread")]
		public static global::DE.Greenrobot.Event.ThreadMode MainThread {
			get {
				const string __id = "MainThread.Lde/greenrobot/event/ThreadMode;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::DE.Greenrobot.Event.ThreadMode> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='de.greenrobot.event']/class[@name='ThreadMode']/field[@name='PostThread']"
		[Register ("PostThread")]
		public static global::DE.Greenrobot.Event.ThreadMode PostThread {
			get {
				const string __id = "PostThread.Lde/greenrobot/event/ThreadMode;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::DE.Greenrobot.Event.ThreadMode> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}
		static readonly JniPeerMembers _members = new XAPeerMembers ("de/greenrobot/event/ThreadMode", typeof (ThreadMode));
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

		internal ThreadMode (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath method reference: path="/api/package[@name='de.greenrobot.event']/class[@name='ThreadMode']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("valueOf", "(Ljava/lang/String;)Lde/greenrobot/event/ThreadMode;", "")]
		public static unsafe global::DE.Greenrobot.Event.ThreadMode ValueOf (string p0)
		{
			const string __id = "valueOf.(Ljava/lang/String;)Lde/greenrobot/event/ThreadMode;";
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_p0);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::DE.Greenrobot.Event.ThreadMode> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='de.greenrobot.event']/class[@name='ThreadMode']/method[@name='values' and count(parameter)=0]"
		[Register ("values", "()[Lde/greenrobot/event/ThreadMode;", "")]
		public static unsafe global::DE.Greenrobot.Event.ThreadMode[] Values ()
		{
			const string __id = "values.()[Lde/greenrobot/event/ThreadMode;";
			try {
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
				return (global::DE.Greenrobot.Event.ThreadMode[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (global::DE.Greenrobot.Event.ThreadMode));
			} finally {
			}
		}

	}
}
