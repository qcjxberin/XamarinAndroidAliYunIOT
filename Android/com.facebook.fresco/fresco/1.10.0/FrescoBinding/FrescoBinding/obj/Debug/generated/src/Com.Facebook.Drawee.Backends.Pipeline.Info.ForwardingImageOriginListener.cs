using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Facebook.Drawee.Backends.Pipeline.Info {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.facebook.drawee.backends.pipeline.info']/class[@name='ForwardingImageOriginListener']"
	[global::Android.Runtime.Register ("com/facebook/drawee/backends/pipeline/info/ForwardingImageOriginListener", DoNotGenerateAcw=true)]
	public partial class ForwardingImageOriginListener : global::Java.Lang.Object, global::Com.Facebook.Drawee.Backends.Pipeline.Info.IImageOriginListener {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/facebook/drawee/backends/pipeline/info/ForwardingImageOriginListener", typeof (ForwardingImageOriginListener));
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

		protected ForwardingImageOriginListener (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.facebook.drawee.backends.pipeline.info']/class[@name='ForwardingImageOriginListener']/constructor[@name='ForwardingImageOriginListener' and count(parameter)=1 and parameter[1][@type='com.facebook.drawee.backends.pipeline.info.ImageOriginListener...']]"
		[Register (".ctor", "([Lcom/facebook/drawee/backends/pipeline/info/ImageOriginListener;)V", "")]
		public unsafe ForwardingImageOriginListener (params global::Com.Facebook.Drawee.Backends.Pipeline.Info.IImageOriginListener[] imageOriginListeners)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "([Lcom/facebook/drawee/backends/pipeline/info/ImageOriginListener;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_imageOriginListeners = JNIEnv.NewArray (imageOriginListeners);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_imageOriginListeners);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				if (imageOriginListeners != null) {
					JNIEnv.CopyArray (native_imageOriginListeners, imageOriginListeners);
					JNIEnv.DeleteLocalRef (native_imageOriginListeners);
				}
			}
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.facebook.drawee.backends.pipeline.info']/class[@name='ForwardingImageOriginListener']/constructor[@name='ForwardingImageOriginListener' and count(parameter)=1 and parameter[1][@type='java.util.Set&lt;com.facebook.drawee.backends.pipeline.info.ImageOriginListener&gt;']]"
		[Register (".ctor", "(Ljava/util/Set;)V", "")]
		public unsafe ForwardingImageOriginListener (global::System.Collections.Generic.ICollection<global::Com.Facebook.Drawee.Backends.Pipeline.Info.IImageOriginListener> imageOriginListeners)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Ljava/util/Set;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_imageOriginListeners = global::Android.Runtime.JavaSet<global::Com.Facebook.Drawee.Backends.Pipeline.Info.IImageOriginListener>.ToLocalJniHandle (imageOriginListeners);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_imageOriginListeners);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_imageOriginListeners);
			}
		}

		static Delegate cb_addImageOriginListener_Lcom_facebook_drawee_backends_pipeline_info_ImageOriginListener_;
#pragma warning disable 0169
		static Delegate GetAddImageOriginListener_Lcom_facebook_drawee_backends_pipeline_info_ImageOriginListener_Handler ()
		{
			if (cb_addImageOriginListener_Lcom_facebook_drawee_backends_pipeline_info_ImageOriginListener_ == null)
				cb_addImageOriginListener_Lcom_facebook_drawee_backends_pipeline_info_ImageOriginListener_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_AddImageOriginListener_Lcom_facebook_drawee_backends_pipeline_info_ImageOriginListener_);
			return cb_addImageOriginListener_Lcom_facebook_drawee_backends_pipeline_info_ImageOriginListener_;
		}

		static void n_AddImageOriginListener_Lcom_facebook_drawee_backends_pipeline_info_ImageOriginListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_listener)
		{
			global::Com.Facebook.Drawee.Backends.Pipeline.Info.ForwardingImageOriginListener __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Drawee.Backends.Pipeline.Info.ForwardingImageOriginListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Facebook.Drawee.Backends.Pipeline.Info.IImageOriginListener listener = (global::Com.Facebook.Drawee.Backends.Pipeline.Info.IImageOriginListener)global::Java.Lang.Object.GetObject<global::Com.Facebook.Drawee.Backends.Pipeline.Info.IImageOriginListener> (native_listener, JniHandleOwnership.DoNotTransfer);
			__this.AddImageOriginListener (listener);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.drawee.backends.pipeline.info']/class[@name='ForwardingImageOriginListener']/method[@name='addImageOriginListener' and count(parameter)=1 and parameter[1][@type='com.facebook.drawee.backends.pipeline.info.ImageOriginListener']]"
		[Register ("addImageOriginListener", "(Lcom/facebook/drawee/backends/pipeline/info/ImageOriginListener;)V", "GetAddImageOriginListener_Lcom_facebook_drawee_backends_pipeline_info_ImageOriginListener_Handler")]
		public virtual unsafe void AddImageOriginListener (global::Com.Facebook.Drawee.Backends.Pipeline.Info.IImageOriginListener listener)
		{
			const string __id = "addImageOriginListener.(Lcom/facebook/drawee/backends/pipeline/info/ImageOriginListener;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((listener == null) ? IntPtr.Zero : ((global::Java.Lang.Object) listener).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
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
			global::Com.Facebook.Drawee.Backends.Pipeline.Info.ForwardingImageOriginListener __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Drawee.Backends.Pipeline.Info.ForwardingImageOriginListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string controllerId = JNIEnv.GetString (native_controllerId, JniHandleOwnership.DoNotTransfer);
			__this.OnImageLoaded (controllerId, imageOrigin, successful);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.drawee.backends.pipeline.info']/class[@name='ForwardingImageOriginListener']/method[@name='onImageLoaded' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='int'] and parameter[3][@type='boolean']]"
		[Register ("onImageLoaded", "(Ljava/lang/String;IZ)V", "GetOnImageLoaded_Ljava_lang_String_IZHandler")]
		public virtual unsafe void OnImageLoaded (string controllerId, int imageOrigin, bool successful)
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

		static Delegate cb_removeImageOriginListener_Lcom_facebook_drawee_backends_pipeline_info_ImageOriginListener_;
#pragma warning disable 0169
		static Delegate GetRemoveImageOriginListener_Lcom_facebook_drawee_backends_pipeline_info_ImageOriginListener_Handler ()
		{
			if (cb_removeImageOriginListener_Lcom_facebook_drawee_backends_pipeline_info_ImageOriginListener_ == null)
				cb_removeImageOriginListener_Lcom_facebook_drawee_backends_pipeline_info_ImageOriginListener_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_RemoveImageOriginListener_Lcom_facebook_drawee_backends_pipeline_info_ImageOriginListener_);
			return cb_removeImageOriginListener_Lcom_facebook_drawee_backends_pipeline_info_ImageOriginListener_;
		}

		static void n_RemoveImageOriginListener_Lcom_facebook_drawee_backends_pipeline_info_ImageOriginListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_listener)
		{
			global::Com.Facebook.Drawee.Backends.Pipeline.Info.ForwardingImageOriginListener __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Drawee.Backends.Pipeline.Info.ForwardingImageOriginListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Facebook.Drawee.Backends.Pipeline.Info.IImageOriginListener listener = (global::Com.Facebook.Drawee.Backends.Pipeline.Info.IImageOriginListener)global::Java.Lang.Object.GetObject<global::Com.Facebook.Drawee.Backends.Pipeline.Info.IImageOriginListener> (native_listener, JniHandleOwnership.DoNotTransfer);
			__this.RemoveImageOriginListener (listener);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.drawee.backends.pipeline.info']/class[@name='ForwardingImageOriginListener']/method[@name='removeImageOriginListener' and count(parameter)=1 and parameter[1][@type='com.facebook.drawee.backends.pipeline.info.ImageOriginListener']]"
		[Register ("removeImageOriginListener", "(Lcom/facebook/drawee/backends/pipeline/info/ImageOriginListener;)V", "GetRemoveImageOriginListener_Lcom_facebook_drawee_backends_pipeline_info_ImageOriginListener_Handler")]
		public virtual unsafe void RemoveImageOriginListener (global::Com.Facebook.Drawee.Backends.Pipeline.Info.IImageOriginListener listener)
		{
			const string __id = "removeImageOriginListener.(Lcom/facebook/drawee/backends/pipeline/info/ImageOriginListener;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((listener == null) ? IntPtr.Zero : ((global::Java.Lang.Object) listener).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

#region "Event implementation for Com.Facebook.Drawee.Backends.Pipeline.Info.IImageOriginListener"
		public event EventHandler<global::Com.Facebook.Drawee.Backends.Pipeline.Info.ImageOriginEventArgs> ImageOrigin {
			add {
				global::Java.Interop.EventHelper.AddEventHandler<global::Com.Facebook.Drawee.Backends.Pipeline.Info.IImageOriginListener, global::Com.Facebook.Drawee.Backends.Pipeline.Info.IImageOriginListenerImplementor>(
						ref weak_implementor_AddImageOriginListener,
						__CreateIImageOriginListenerImplementor,
						AddImageOriginListener,
						__h => __h.Handler += value);
			}
			remove {
				global::Java.Interop.EventHelper.RemoveEventHandler<global::Com.Facebook.Drawee.Backends.Pipeline.Info.IImageOriginListener, global::Com.Facebook.Drawee.Backends.Pipeline.Info.IImageOriginListenerImplementor>(
						ref weak_implementor_AddImageOriginListener,
						global::Com.Facebook.Drawee.Backends.Pipeline.Info.IImageOriginListenerImplementor.__IsEmpty,
						__v => RemoveImageOriginListener (__v),
						__h => __h.Handler -= value);
			}
		}

		WeakReference weak_implementor_AddImageOriginListener;

		global::Com.Facebook.Drawee.Backends.Pipeline.Info.IImageOriginListenerImplementor __CreateIImageOriginListenerImplementor ()
		{
			return new global::Com.Facebook.Drawee.Backends.Pipeline.Info.IImageOriginListenerImplementor (this);
		}
#endregion
	}
}
