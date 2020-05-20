using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Org.Eclipse.Paho.Client.Mqttv3.Persist {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.persist']/class[@name='PersistanceFileNameFilter']"
	[global::Android.Runtime.Register ("org/eclipse/paho/client/mqttv3/persist/PersistanceFileNameFilter", DoNotGenerateAcw=true)]
	public partial class PersistanceFileNameFilter : global::Java.Lang.Object, global::Java.IO.IFilenameFilter {

		static readonly JniPeerMembers _members = new XAPeerMembers ("org/eclipse/paho/client/mqttv3/persist/PersistanceFileNameFilter", typeof (PersistanceFileNameFilter));
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

		protected PersistanceFileNameFilter (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.persist']/class[@name='PersistanceFileNameFilter']/constructor[@name='PersistanceFileNameFilter' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register (".ctor", "(Ljava/lang/String;)V", "")]
		public unsafe PersistanceFileNameFilter (string fileExtension)
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

		static Delegate cb_accept_Ljava_io_File_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetAccept_Ljava_io_File_Ljava_lang_String_Handler ()
		{
			if (cb_accept_Ljava_io_File_Ljava_lang_String_ == null)
				cb_accept_Ljava_io_File_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, bool>) n_Accept_Ljava_io_File_Ljava_lang_String_);
			return cb_accept_Ljava_io_File_Ljava_lang_String_;
		}

		static bool n_Accept_Ljava_io_File_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_dir, IntPtr native_name)
		{
			global::Org.Eclipse.Paho.Client.Mqttv3.Persist.PersistanceFileNameFilter __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.Persist.PersistanceFileNameFilter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.IO.File dir = global::Java.Lang.Object.GetObject<global::Java.IO.File> (native_dir, JniHandleOwnership.DoNotTransfer);
			string name = JNIEnv.GetString (native_name, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.Accept (dir, name);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.persist']/class[@name='PersistanceFileNameFilter']/method[@name='accept' and count(parameter)=2 and parameter[1][@type='java.io.File'] and parameter[2][@type='java.lang.String']]"
		[Register ("accept", "(Ljava/io/File;Ljava/lang/String;)Z", "GetAccept_Ljava_io_File_Ljava_lang_String_Handler")]
		public virtual unsafe bool Accept (global::Java.IO.File dir, string name)
		{
			const string __id = "accept.(Ljava/io/File;Ljava/lang/String;)Z";
			IntPtr native_name = JNIEnv.NewString (name);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((dir == null) ? IntPtr.Zero : ((global::Java.Lang.Object) dir).Handle);
				__args [1] = new JniArgumentValue (native_name);
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
				JNIEnv.DeleteLocalRef (native_name);
			}
		}

	}
}
