using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Org.Eclipse.Paho.Client.Mqttv3.Persist {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.persist']/class[@name='PersistanceFileFilter']"
	[global::Android.Runtime.Register ("org/eclipse/paho/client/mqttv3/persist/PersistanceFileFilter", DoNotGenerateAcw=true)]
	public partial class PersistanceFileFilter : global::Java.Lang.Object, global::Java.IO.IFileFilter {

		static readonly JniPeerMembers _members = new XAPeerMembers ("org/eclipse/paho/client/mqttv3/persist/PersistanceFileFilter", typeof (PersistanceFileFilter));
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

		protected PersistanceFileFilter (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.persist']/class[@name='PersistanceFileFilter']/constructor[@name='PersistanceFileFilter' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register (".ctor", "(Ljava/lang/String;)V", "")]
		public unsafe PersistanceFileFilter (string fileExtension)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Ljava/lang/String;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_fileExtension = JNIEnv.NewString (fileExtension);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_fileExtension);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_fileExtension);
			}
		}

		static Delegate cb_accept_Ljava_io_File_;
#pragma warning disable 0169
		static Delegate GetAccept_Ljava_io_File_Handler ()
		{
			if (cb_accept_Ljava_io_File_ == null)
				cb_accept_Ljava_io_File_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_Accept_Ljava_io_File_);
			return cb_accept_Ljava_io_File_;
		}

		static bool n_Accept_Ljava_io_File_ (IntPtr jnienv, IntPtr native__this, IntPtr native_pathname)
		{
			global::Org.Eclipse.Paho.Client.Mqttv3.Persist.PersistanceFileFilter __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.Persist.PersistanceFileFilter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.IO.File pathname = global::Java.Lang.Object.GetObject<global::Java.IO.File> (native_pathname, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.Accept (pathname);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.persist']/class[@name='PersistanceFileFilter']/method[@name='accept' and count(parameter)=1 and parameter[1][@type='java.io.File']]"
		[Register ("accept", "(Ljava/io/File;)Z", "GetAccept_Ljava_io_File_Handler")]
		public virtual unsafe bool Accept (global::Java.IO.File pathname)
		{
			const string __id = "accept.(Ljava/io/File;)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((pathname == null) ? IntPtr.Zero : ((global::Java.Lang.Object) pathname).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
			}
		}

	}
}
