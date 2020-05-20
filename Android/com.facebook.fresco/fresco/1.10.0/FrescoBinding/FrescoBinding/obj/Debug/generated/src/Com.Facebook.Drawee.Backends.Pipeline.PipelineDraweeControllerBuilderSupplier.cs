using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Facebook.Drawee.Backends.Pipeline {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.facebook.drawee.backends.pipeline']/class[@name='PipelineDraweeControllerBuilderSupplier']"
	[global::Android.Runtime.Register ("com/facebook/drawee/backends/pipeline/PipelineDraweeControllerBuilderSupplier", DoNotGenerateAcw=true)]
	public partial class PipelineDraweeControllerBuilderSupplier : global::Java.Lang.Object, global::Com.Facebook.Common.Internal.ISupplier {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/facebook/drawee/backends/pipeline/PipelineDraweeControllerBuilderSupplier", typeof (PipelineDraweeControllerBuilderSupplier));
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

		protected PipelineDraweeControllerBuilderSupplier (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.facebook.drawee.backends.pipeline']/class[@name='PipelineDraweeControllerBuilderSupplier']/constructor[@name='PipelineDraweeControllerBuilderSupplier' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register (".ctor", "(Landroid/content/Context;)V", "")]
		public unsafe PipelineDraweeControllerBuilderSupplier (global::Android.Content.Context context)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Landroid/content/Context;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((context == null) ? IntPtr.Zero : ((global::Java.Lang.Object) context).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.facebook.drawee.backends.pipeline']/class[@name='PipelineDraweeControllerBuilderSupplier']/constructor[@name='PipelineDraweeControllerBuilderSupplier' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='com.facebook.drawee.backends.pipeline.DraweeConfig']]"
		[Register (".ctor", "(Landroid/content/Context;Lcom/facebook/drawee/backends/pipeline/DraweeConfig;)V", "")]
		public unsafe PipelineDraweeControllerBuilderSupplier (global::Android.Content.Context context, global::Com.Facebook.Drawee.Backends.Pipeline.DraweeConfig draweeConfig)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Landroid/content/Context;Lcom/facebook/drawee/backends/pipeline/DraweeConfig;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((context == null) ? IntPtr.Zero : ((global::Java.Lang.Object) context).Handle);
				__args [1] = new JniArgumentValue ((draweeConfig == null) ? IntPtr.Zero : ((global::Java.Lang.Object) draweeConfig).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.facebook.drawee.backends.pipeline']/class[@name='PipelineDraweeControllerBuilderSupplier']/constructor[@name='PipelineDraweeControllerBuilderSupplier' and count(parameter)=3 and parameter[1][@type='android.content.Context'] and parameter[2][@type='com.facebook.imagepipeline.core.ImagePipelineFactory'] and parameter[3][@type='com.facebook.drawee.backends.pipeline.DraweeConfig']]"
		[Register (".ctor", "(Landroid/content/Context;Lcom/facebook/imagepipeline/core/ImagePipelineFactory;Lcom/facebook/drawee/backends/pipeline/DraweeConfig;)V", "")]
		public unsafe PipelineDraweeControllerBuilderSupplier (global::Android.Content.Context context, global::Com.Facebook.Imagepipeline.Core.ImagePipelineFactory imagePipelineFactory, global::Com.Facebook.Drawee.Backends.Pipeline.DraweeConfig draweeConfig)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Landroid/content/Context;Lcom/facebook/imagepipeline/core/ImagePipelineFactory;Lcom/facebook/drawee/backends/pipeline/DraweeConfig;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((context == null) ? IntPtr.Zero : ((global::Java.Lang.Object) context).Handle);
				__args [1] = new JniArgumentValue ((imagePipelineFactory == null) ? IntPtr.Zero : ((global::Java.Lang.Object) imagePipelineFactory).Handle);
				__args [2] = new JniArgumentValue ((draweeConfig == null) ? IntPtr.Zero : ((global::Java.Lang.Object) draweeConfig).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.facebook.drawee.backends.pipeline']/class[@name='PipelineDraweeControllerBuilderSupplier']/constructor[@name='PipelineDraweeControllerBuilderSupplier' and count(parameter)=4 and parameter[1][@type='android.content.Context'] and parameter[2][@type='com.facebook.imagepipeline.core.ImagePipelineFactory'] and parameter[3][@type='java.util.Set&lt;com.facebook.drawee.controller.ControllerListener&gt;'] and parameter[4][@type='com.facebook.drawee.backends.pipeline.DraweeConfig']]"
		[Register (".ctor", "(Landroid/content/Context;Lcom/facebook/imagepipeline/core/ImagePipelineFactory;Ljava/util/Set;Lcom/facebook/drawee/backends/pipeline/DraweeConfig;)V", "")]
		public unsafe PipelineDraweeControllerBuilderSupplier (global::Android.Content.Context context, global::Com.Facebook.Imagepipeline.Core.ImagePipelineFactory imagePipelineFactory, global::System.Collections.Generic.ICollection<global::Com.Facebook.Drawee.Controller.IControllerListener> boundControllerListeners, global::Com.Facebook.Drawee.Backends.Pipeline.DraweeConfig draweeConfig)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Landroid/content/Context;Lcom/facebook/imagepipeline/core/ImagePipelineFactory;Ljava/util/Set;Lcom/facebook/drawee/backends/pipeline/DraweeConfig;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_boundControllerListeners = global::Android.Runtime.JavaSet<global::Com.Facebook.Drawee.Controller.IControllerListener>.ToLocalJniHandle (boundControllerListeners);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue ((context == null) ? IntPtr.Zero : ((global::Java.Lang.Object) context).Handle);
				__args [1] = new JniArgumentValue ((imagePipelineFactory == null) ? IntPtr.Zero : ((global::Java.Lang.Object) imagePipelineFactory).Handle);
				__args [2] = new JniArgumentValue (native_boundControllerListeners);
				__args [3] = new JniArgumentValue ((draweeConfig == null) ? IntPtr.Zero : ((global::Java.Lang.Object) draweeConfig).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_boundControllerListeners);
			}
		}

		static Delegate cb_get;
#pragma warning disable 0169
		static Delegate GetRawGetHandler ()
		{
			if (cb_get == null)
				cb_get = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_RawGet);
			return cb_get;
		}

		static IntPtr n_RawGet (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Facebook.Drawee.Backends.Pipeline.PipelineDraweeControllerBuilderSupplier __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Drawee.Backends.Pipeline.PipelineDraweeControllerBuilderSupplier> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.RawGet ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.drawee.backends.pipeline']/class[@name='PipelineDraweeControllerBuilderSupplier']/method[@name='get' and count(parameter)=0]"
		[Register ("get", "()Lcom/facebook/drawee/backends/pipeline/PipelineDraweeControllerBuilder;", "GetRawGetHandler")]
		public virtual unsafe global::Com.Facebook.Drawee.Backends.Pipeline.PipelineDraweeControllerBuilder RawGet ()
		{
			const string __id = "get.()Lcom/facebook/drawee/backends/pipeline/PipelineDraweeControllerBuilder;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Com.Facebook.Drawee.Backends.Pipeline.PipelineDraweeControllerBuilder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}
}
