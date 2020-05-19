using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Facebook.Drawee.Backends.Pipeline.Info {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.facebook.drawee.backends.pipeline.info']/class[@name='ImagePerfMonitor']"
	[global::Android.Runtime.Register ("com/facebook/drawee/backends/pipeline/info/ImagePerfMonitor", DoNotGenerateAcw=true)]
	public partial class ImagePerfMonitor : global::Com.Facebook.Imagepipeline.Listener.BaseRequestListener {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/facebook/drawee/backends/pipeline/info/ImagePerfMonitor", typeof (ImagePerfMonitor));
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

		protected ImagePerfMonitor (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.facebook.drawee.backends.pipeline.info']/class[@name='ImagePerfMonitor']/constructor[@name='ImagePerfMonitor' and count(parameter)=2 and parameter[1][@type='com.facebook.common.time.MonotonicClock'] and parameter[2][@type='com.facebook.drawee.backends.pipeline.PipelineDraweeController']]"
		[Register (".ctor", "(Lcom/facebook/common/time/MonotonicClock;Lcom/facebook/drawee/backends/pipeline/PipelineDraweeController;)V", "")]
		public unsafe ImagePerfMonitor (global::Com.Facebook.Common.Time.IMonotonicClock monotonicClock, global::Com.Facebook.Drawee.Backends.Pipeline.PipelineDraweeController pipelineDraweeController)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Lcom/facebook/common/time/MonotonicClock;Lcom/facebook/drawee/backends/pipeline/PipelineDraweeController;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((monotonicClock == null) ? IntPtr.Zero : ((global::Java.Lang.Object) monotonicClock).Handle);
				__args [1] = new JniArgumentValue ((pipelineDraweeController == null) ? IntPtr.Zero : ((global::Java.Lang.Object) pipelineDraweeController).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_addImagePerfDataListener_Lcom_facebook_drawee_backends_pipeline_info_ImagePerfDataListener_;
#pragma warning disable 0169
		static Delegate GetAddImagePerfDataListener_Lcom_facebook_drawee_backends_pipeline_info_ImagePerfDataListener_Handler ()
		{
			if (cb_addImagePerfDataListener_Lcom_facebook_drawee_backends_pipeline_info_ImagePerfDataListener_ == null)
				cb_addImagePerfDataListener_Lcom_facebook_drawee_backends_pipeline_info_ImagePerfDataListener_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_AddImagePerfDataListener_Lcom_facebook_drawee_backends_pipeline_info_ImagePerfDataListener_);
			return cb_addImagePerfDataListener_Lcom_facebook_drawee_backends_pipeline_info_ImagePerfDataListener_;
		}

		static void n_AddImagePerfDataListener_Lcom_facebook_drawee_backends_pipeline_info_ImagePerfDataListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_imagePerfDataListener)
		{
			global::Com.Facebook.Drawee.Backends.Pipeline.Info.ImagePerfMonitor __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Drawee.Backends.Pipeline.Info.ImagePerfMonitor> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Facebook.Drawee.Backends.Pipeline.Info.IImagePerfDataListener imagePerfDataListener = (global::Com.Facebook.Drawee.Backends.Pipeline.Info.IImagePerfDataListener)global::Java.Lang.Object.GetObject<global::Com.Facebook.Drawee.Backends.Pipeline.Info.IImagePerfDataListener> (native_imagePerfDataListener, JniHandleOwnership.DoNotTransfer);
			__this.AddImagePerfDataListener (imagePerfDataListener);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.drawee.backends.pipeline.info']/class[@name='ImagePerfMonitor']/method[@name='addImagePerfDataListener' and count(parameter)=1 and parameter[1][@type='com.facebook.drawee.backends.pipeline.info.ImagePerfDataListener']]"
		[Register ("addImagePerfDataListener", "(Lcom/facebook/drawee/backends/pipeline/info/ImagePerfDataListener;)V", "GetAddImagePerfDataListener_Lcom_facebook_drawee_backends_pipeline_info_ImagePerfDataListener_Handler")]
		public virtual unsafe void AddImagePerfDataListener (global::Com.Facebook.Drawee.Backends.Pipeline.Info.IImagePerfDataListener imagePerfDataListener)
		{
			const string __id = "addImagePerfDataListener.(Lcom/facebook/drawee/backends/pipeline/info/ImagePerfDataListener;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((imagePerfDataListener == null) ? IntPtr.Zero : ((global::Java.Lang.Object) imagePerfDataListener).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_clearImagePerfDataListeners;
#pragma warning disable 0169
		static Delegate GetClearImagePerfDataListenersHandler ()
		{
			if (cb_clearImagePerfDataListeners == null)
				cb_clearImagePerfDataListeners = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_ClearImagePerfDataListeners);
			return cb_clearImagePerfDataListeners;
		}

		static void n_ClearImagePerfDataListeners (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Facebook.Drawee.Backends.Pipeline.Info.ImagePerfMonitor __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Drawee.Backends.Pipeline.Info.ImagePerfMonitor> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ClearImagePerfDataListeners ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.drawee.backends.pipeline.info']/class[@name='ImagePerfMonitor']/method[@name='clearImagePerfDataListeners' and count(parameter)=0]"
		[Register ("clearImagePerfDataListeners", "()V", "GetClearImagePerfDataListenersHandler")]
		public virtual unsafe void ClearImagePerfDataListeners ()
		{
			const string __id = "clearImagePerfDataListeners.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_notifyListeners_Lcom_facebook_drawee_backends_pipeline_info_ImagePerfState_I;
#pragma warning disable 0169
		static Delegate GetNotifyListeners_Lcom_facebook_drawee_backends_pipeline_info_ImagePerfState_IHandler ()
		{
			if (cb_notifyListeners_Lcom_facebook_drawee_backends_pipeline_info_ImagePerfState_I == null)
				cb_notifyListeners_Lcom_facebook_drawee_backends_pipeline_info_ImagePerfState_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, int>) n_NotifyListeners_Lcom_facebook_drawee_backends_pipeline_info_ImagePerfState_I);
			return cb_notifyListeners_Lcom_facebook_drawee_backends_pipeline_info_ImagePerfState_I;
		}

		static void n_NotifyListeners_Lcom_facebook_drawee_backends_pipeline_info_ImagePerfState_I (IntPtr jnienv, IntPtr native__this, IntPtr native_state, int imageLoadStatus)
		{
			global::Com.Facebook.Drawee.Backends.Pipeline.Info.ImagePerfMonitor __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Drawee.Backends.Pipeline.Info.ImagePerfMonitor> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Facebook.Drawee.Backends.Pipeline.Info.ImagePerfState state = global::Java.Lang.Object.GetObject<global::Com.Facebook.Drawee.Backends.Pipeline.Info.ImagePerfState> (native_state, JniHandleOwnership.DoNotTransfer);
			__this.NotifyListeners (state, imageLoadStatus);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.drawee.backends.pipeline.info']/class[@name='ImagePerfMonitor']/method[@name='notifyListeners' and count(parameter)=2 and parameter[1][@type='com.facebook.drawee.backends.pipeline.info.ImagePerfState'] and parameter[2][@type='int']]"
		[Register ("notifyListeners", "(Lcom/facebook/drawee/backends/pipeline/info/ImagePerfState;I)V", "GetNotifyListeners_Lcom_facebook_drawee_backends_pipeline_info_ImagePerfState_IHandler")]
		public virtual unsafe void NotifyListeners (global::Com.Facebook.Drawee.Backends.Pipeline.Info.ImagePerfState state, [global::Android.Runtime.IntDef (Type = "Com.Facebook.Drawee.Backends.Pipeline.Info.IImageLoadStatus", Fields = new string [] {"Unknown", "Requested", "OriginAvailable", "IntermediateAvailable", "Success", "Canceled", "Error"})]int imageLoadStatus)
		{
			const string __id = "notifyListeners.(Lcom/facebook/drawee/backends/pipeline/info/ImagePerfState;I)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((state == null) ? IntPtr.Zero : ((global::Java.Lang.Object) state).Handle);
				__args [1] = new JniArgumentValue (imageLoadStatus);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_removeImagePerfDataListener_Lcom_facebook_drawee_backends_pipeline_info_ImagePerfDataListener_;
#pragma warning disable 0169
		static Delegate GetRemoveImagePerfDataListener_Lcom_facebook_drawee_backends_pipeline_info_ImagePerfDataListener_Handler ()
		{
			if (cb_removeImagePerfDataListener_Lcom_facebook_drawee_backends_pipeline_info_ImagePerfDataListener_ == null)
				cb_removeImagePerfDataListener_Lcom_facebook_drawee_backends_pipeline_info_ImagePerfDataListener_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_RemoveImagePerfDataListener_Lcom_facebook_drawee_backends_pipeline_info_ImagePerfDataListener_);
			return cb_removeImagePerfDataListener_Lcom_facebook_drawee_backends_pipeline_info_ImagePerfDataListener_;
		}

		static void n_RemoveImagePerfDataListener_Lcom_facebook_drawee_backends_pipeline_info_ImagePerfDataListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_imagePerfDataListener)
		{
			global::Com.Facebook.Drawee.Backends.Pipeline.Info.ImagePerfMonitor __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Drawee.Backends.Pipeline.Info.ImagePerfMonitor> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Facebook.Drawee.Backends.Pipeline.Info.IImagePerfDataListener imagePerfDataListener = (global::Com.Facebook.Drawee.Backends.Pipeline.Info.IImagePerfDataListener)global::Java.Lang.Object.GetObject<global::Com.Facebook.Drawee.Backends.Pipeline.Info.IImagePerfDataListener> (native_imagePerfDataListener, JniHandleOwnership.DoNotTransfer);
			__this.RemoveImagePerfDataListener (imagePerfDataListener);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.drawee.backends.pipeline.info']/class[@name='ImagePerfMonitor']/method[@name='removeImagePerfDataListener' and count(parameter)=1 and parameter[1][@type='com.facebook.drawee.backends.pipeline.info.ImagePerfDataListener']]"
		[Register ("removeImagePerfDataListener", "(Lcom/facebook/drawee/backends/pipeline/info/ImagePerfDataListener;)V", "GetRemoveImagePerfDataListener_Lcom_facebook_drawee_backends_pipeline_info_ImagePerfDataListener_Handler")]
		public virtual unsafe void RemoveImagePerfDataListener (global::Com.Facebook.Drawee.Backends.Pipeline.Info.IImagePerfDataListener imagePerfDataListener)
		{
			const string __id = "removeImagePerfDataListener.(Lcom/facebook/drawee/backends/pipeline/info/ImagePerfDataListener;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((imagePerfDataListener == null) ? IntPtr.Zero : ((global::Java.Lang.Object) imagePerfDataListener).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_reset;
#pragma warning disable 0169
		static Delegate GetResetHandler ()
		{
			if (cb_reset == null)
				cb_reset = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Reset);
			return cb_reset;
		}

		static void n_Reset (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Facebook.Drawee.Backends.Pipeline.Info.ImagePerfMonitor __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Drawee.Backends.Pipeline.Info.ImagePerfMonitor> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Reset ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.drawee.backends.pipeline.info']/class[@name='ImagePerfMonitor']/method[@name='reset' and count(parameter)=0]"
		[Register ("reset", "()V", "GetResetHandler")]
		public virtual unsafe void Reset ()
		{
			const string __id = "reset.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_setEnabled_Z;
#pragma warning disable 0169
		static Delegate GetSetEnabled_ZHandler ()
		{
			if (cb_setEnabled_Z == null)
				cb_setEnabled_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_SetEnabled_Z);
			return cb_setEnabled_Z;
		}

		static void n_SetEnabled_Z (IntPtr jnienv, IntPtr native__this, bool enabled)
		{
			global::Com.Facebook.Drawee.Backends.Pipeline.Info.ImagePerfMonitor __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Drawee.Backends.Pipeline.Info.ImagePerfMonitor> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetEnabled (enabled);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.drawee.backends.pipeline.info']/class[@name='ImagePerfMonitor']/method[@name='setEnabled' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("setEnabled", "(Z)V", "GetSetEnabled_ZHandler")]
		public virtual unsafe void SetEnabled (bool enabled)
		{
			const string __id = "setEnabled.(Z)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (enabled);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

#region "Event implementation for Com.Facebook.Drawee.Backends.Pipeline.Info.IImagePerfDataListener"
		public event EventHandler<global::Com.Facebook.Drawee.Backends.Pipeline.Info.ImagePerfDataEventArgs> ImagePerfData {
			add {
				global::Java.Interop.EventHelper.AddEventHandler<global::Com.Facebook.Drawee.Backends.Pipeline.Info.IImagePerfDataListener, global::Com.Facebook.Drawee.Backends.Pipeline.Info.IImagePerfDataListenerImplementor>(
						ref weak_implementor_AddImagePerfDataListener,
						__CreateIImagePerfDataListenerImplementor,
						AddImagePerfDataListener,
						__h => __h.Handler += value);
			}
			remove {
				global::Java.Interop.EventHelper.RemoveEventHandler<global::Com.Facebook.Drawee.Backends.Pipeline.Info.IImagePerfDataListener, global::Com.Facebook.Drawee.Backends.Pipeline.Info.IImagePerfDataListenerImplementor>(
						ref weak_implementor_AddImagePerfDataListener,
						global::Com.Facebook.Drawee.Backends.Pipeline.Info.IImagePerfDataListenerImplementor.__IsEmpty,
						__v => RemoveImagePerfDataListener (__v),
						__h => __h.Handler -= value);
			}
		}

		WeakReference weak_implementor_AddImagePerfDataListener;

		global::Com.Facebook.Drawee.Backends.Pipeline.Info.IImagePerfDataListenerImplementor __CreateIImagePerfDataListenerImplementor ()
		{
			return new global::Com.Facebook.Drawee.Backends.Pipeline.Info.IImagePerfDataListenerImplementor (this);
		}
#endregion
	}
}
