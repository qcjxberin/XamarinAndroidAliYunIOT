using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Facebook.Drawee.Backends.Pipeline.Info.Internal {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.facebook.drawee.backends.pipeline.info.internal']/class[@name='ImagePerfImageOriginListener']"
	[global::Android.Runtime.Register ("com/facebook/drawee/backends/pipeline/info/internal/ImagePerfImageOriginListener", DoNotGenerateAcw=true)]
	public partial class ImagePerfImageOriginListener : global::Java.Lang.Object, global::Com.Facebook.Drawee.Backends.Pipeline.Info.IImageOriginListener {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/facebook/drawee/backends/pipeline/info/internal/ImagePerfImageOriginListener", typeof (ImagePerfImageOriginListener));
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

		protected ImagePerfImageOriginListener (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.facebook.drawee.backends.pipeline.info.internal']/class[@name='ImagePerfImageOriginListener']/constructor[@name='ImagePerfImageOriginListener' and count(parameter)=2 and parameter[1][@type='com.facebook.drawee.backends.pipeline.info.ImagePerfState'] and parameter[2][@type='com.facebook.drawee.backends.pipeline.info.ImagePerfMonitor']]"
		[Register (".ctor", "(Lcom/facebook/drawee/backends/pipeline/info/ImagePerfState;Lcom/facebook/drawee/backends/pipeline/info/ImagePerfMonitor;)V", "")]
		public unsafe ImagePerfImageOriginListener (global::Com.Facebook.Drawee.Backends.Pipeline.Info.ImagePerfState imagePerfState, global::Com.Facebook.Drawee.Backends.Pipeline.Info.ImagePerfMonitor imagePerfMonitor)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Lcom/facebook/drawee/backends/pipeline/info/ImagePerfState;Lcom/facebook/drawee/backends/pipeline/info/ImagePerfMonitor;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((imagePerfState == null) ? IntPtr.Zero : ((global::Java.Lang.Object) imagePerfState).Handle);
				__args [1] = new JniArgumentValue ((imagePerfMonitor == null) ? IntPtr.Zero : ((global::Java.Lang.Object) imagePerfMonitor).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_onImageLoaded_Ljava_lang_String_IZ;
#pragma warning disable 0169
		static Delegate GetOnImageLoaded_Ljava_lang_String_IZHandler ()
		{
			if (cb_onImageLoaded_Ljava_lang_String_IZ == null)
				cb_onImageLoaded_Ljava_lang_String_IZ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, int, bool>) n_OnImageLoaded_Ljava_lang_String_IZ);
			return cb_onImageLoaded_Ljava_lang_String_IZ;
		}

		static void n_OnImageLoaded_Ljava_lang_String_IZ (IntPtr jnienv, IntPtr native__this, IntPtr native_controllerId, int imageOrigin, bool successful)
		{
			global::Com.Facebook.Drawee.Backends.Pipeline.Info.Internal.ImagePerfImageOriginListener __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Drawee.Backends.Pipeline.Info.Internal.ImagePerfImageOriginListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string controllerId = JNIEnv.GetString (native_controllerId, JniHandleOwnership.DoNotTransfer);
			__this.OnImageLoaded (controllerId, imageOrigin, successful);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.drawee.backends.pipeline.info.internal']/class[@name='ImagePerfImageOriginListener']/method[@name='onImageLoaded' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='int'] and parameter[3][@type='boolean']]"
		[Register ("onImageLoaded", "(Ljava/lang/String;IZ)V", "GetOnImageLoaded_Ljava_lang_String_IZHandler")]
		public virtual unsafe void OnImageLoaded (string controllerId, [global::Android.Runtime.IntDef (Type = "Com.Facebook.Drawee.Backends.Pipeline.Info.IImageOrigin", Fields = new string [] {"Unknown", "Network", "Disk", "MemoryEncoded", "MemoryBitmap"})]int imageOrigin, bool successful)
		{
			const string __id = "onImageLoaded.(Ljava/lang/String;IZ)V";
			IntPtr native_controllerId = JNIEnv.NewString (controllerId);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (native_controllerId);
				__args [1] = new JniArgumentValue (imageOrigin);
				__args [2] = new JniArgumentValue (successful);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_controllerId);
			}
		}

	}
}
