using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Facebook.Drawee.Backends.Pipeline.Info {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.facebook.drawee.backends.pipeline.info']/class[@name='ImageOriginRequestListener']"
	[global::Android.Runtime.Register ("com/facebook/drawee/backends/pipeline/info/ImageOriginRequestListener", DoNotGenerateAcw=true)]
	public partial class ImageOriginRequestListener : global::Com.Facebook.Imagepipeline.Listener.BaseRequestListener {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/facebook/drawee/backends/pipeline/info/ImageOriginRequestListener", typeof (ImageOriginRequestListener));
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

		protected ImageOriginRequestListener (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.facebook.drawee.backends.pipeline.info']/class[@name='ImageOriginRequestListener']/constructor[@name='ImageOriginRequestListener' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='com.facebook.drawee.backends.pipeline.info.ImageOriginListener']]"
		[Register (".ctor", "(Ljava/lang/String;Lcom/facebook/drawee/backends/pipeline/info/ImageOriginListener;)V", "")]
		public unsafe ImageOriginRequestListener (string controllerId, global::Com.Facebook.Drawee.Backends.Pipeline.Info.IImageOriginListener imageOriginLister)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Ljava/lang/String;Lcom/facebook/drawee/backends/pipeline/info/ImageOriginListener;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_controllerId = JNIEnv.NewString (controllerId);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_controllerId);
				__args [1] = new JniArgumentValue ((imageOriginLister == null) ? IntPtr.Zero : ((global::Java.Lang.Object) imageOriginLister).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_controllerId);
			}
		}

		static Delegate cb_init_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetInit_Ljava_lang_String_Handler ()
		{
			if (cb_init_Ljava_lang_String_ == null)
				cb_init_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_Init_Ljava_lang_String_);
			return cb_init_Ljava_lang_String_;
		}

		static void n_Init_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_controllerId)
		{
			global::Com.Facebook.Drawee.Backends.Pipeline.Info.ImageOriginRequestListener __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Drawee.Backends.Pipeline.Info.ImageOriginRequestListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string controllerId = JNIEnv.GetString (native_controllerId, JniHandleOwnership.DoNotTransfer);
			__this.Init (controllerId);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.drawee.backends.pipeline.info']/class[@name='ImageOriginRequestListener']/method[@name='init' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("init", "(Ljava/lang/String;)V", "GetInit_Ljava_lang_String_Handler")]
		public virtual unsafe void Init (string controllerId)
		{
			const string __id = "init.(Ljava/lang/String;)V";
			IntPtr native_controllerId = JNIEnv.NewString (controllerId);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_controllerId);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_controllerId);
			}
		}

	}
}
