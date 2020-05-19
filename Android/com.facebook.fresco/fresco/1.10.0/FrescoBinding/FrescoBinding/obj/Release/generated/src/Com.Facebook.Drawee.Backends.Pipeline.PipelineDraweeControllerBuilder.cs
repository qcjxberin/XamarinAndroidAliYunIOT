using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Facebook.Drawee.Backends.Pipeline {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.facebook.drawee.backends.pipeline']/class[@name='PipelineDraweeControllerBuilder']"
	[global::Android.Runtime.Register ("com/facebook/drawee/backends/pipeline/PipelineDraweeControllerBuilder", DoNotGenerateAcw=true)]
	public partial class PipelineDraweeControllerBuilder : global::Com.Facebook.Drawee.Controller.AbstractDraweeControllerBuilder {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/facebook/drawee/backends/pipeline/PipelineDraweeControllerBuilder", typeof (PipelineDraweeControllerBuilder));
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

		protected PipelineDraweeControllerBuilder (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.facebook.drawee.backends.pipeline']/class[@name='PipelineDraweeControllerBuilder']/constructor[@name='PipelineDraweeControllerBuilder' and count(parameter)=4 and parameter[1][@type='android.content.Context'] and parameter[2][@type='com.facebook.drawee.backends.pipeline.PipelineDraweeControllerFactory'] and parameter[3][@type='com.facebook.imagepipeline.core.ImagePipeline'] and parameter[4][@type='java.util.Set&lt;com.facebook.drawee.controller.ControllerListener&gt;']]"
		[Register (".ctor", "(Landroid/content/Context;Lcom/facebook/drawee/backends/pipeline/PipelineDraweeControllerFactory;Lcom/facebook/imagepipeline/core/ImagePipeline;Ljava/util/Set;)V", "")]
		public unsafe PipelineDraweeControllerBuilder (global::Android.Content.Context context, global::Com.Facebook.Drawee.Backends.Pipeline.PipelineDraweeControllerFactory pipelineDraweeControllerFactory, global::Com.Facebook.Imagepipeline.Core.ImagePipeline imagePipeline, global::System.Collections.Generic.ICollection<global::Com.Facebook.Drawee.Controller.IControllerListener> boundControllerListeners)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Landroid/content/Context;Lcom/facebook/drawee/backends/pipeline/PipelineDraweeControllerFactory;Lcom/facebook/imagepipeline/core/ImagePipeline;Ljava/util/Set;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_boundControllerListeners = global::Android.Runtime.JavaSet<global::Com.Facebook.Drawee.Controller.IControllerListener>.ToLocalJniHandle (boundControllerListeners);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue ((context == null) ? IntPtr.Zero : ((global::Java.Lang.Object) context).Handle);
				__args [1] = new JniArgumentValue ((pipelineDraweeControllerFactory == null) ? IntPtr.Zero : ((global::Java.Lang.Object) pipelineDraweeControllerFactory).Handle);
				__args [2] = new JniArgumentValue ((imagePipeline == null) ? IntPtr.Zero : ((global::Java.Lang.Object) imagePipeline).Handle);
				__args [3] = new JniArgumentValue (native_boundControllerListeners);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_boundControllerListeners);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.drawee.backends.pipeline']/class[@name='PipelineDraweeControllerBuilder']/method[@name='convertCacheLevelToRequestLevel' and count(parameter)=1 and parameter[1][@type='com.facebook.drawee.controller.AbstractDraweeControllerBuilder.CacheLevel']]"
		[Register ("convertCacheLevelToRequestLevel", "(Lcom/facebook/drawee/controller/AbstractDraweeControllerBuilder$CacheLevel;)Lcom/facebook/imagepipeline/request/ImageRequest$RequestLevel;", "")]
		public static unsafe global::Com.Facebook.Imagepipeline.Request.ImageRequest.RequestLevel ConvertCacheLevelToRequestLevel (global::Com.Facebook.Drawee.Controller.AbstractDraweeControllerBuilder.CacheLevel cacheLevel)
		{
			const string __id = "convertCacheLevelToRequestLevel.(Lcom/facebook/drawee/controller/AbstractDraweeControllerBuilder$CacheLevel;)Lcom/facebook/imagepipeline/request/ImageRequest$RequestLevel;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((cacheLevel == null) ? IntPtr.Zero : ((global::Java.Lang.Object) cacheLevel).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Facebook.Imagepipeline.Request.ImageRequest.RequestLevel> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_getRequestListener_Lcom_facebook_drawee_interfaces_DraweeController_;
#pragma warning disable 0169
		static Delegate GetGetRequestListener_Lcom_facebook_drawee_interfaces_DraweeController_Handler ()
		{
			if (cb_getRequestListener_Lcom_facebook_drawee_interfaces_DraweeController_ == null)
				cb_getRequestListener_Lcom_facebook_drawee_interfaces_DraweeController_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_GetRequestListener_Lcom_facebook_drawee_interfaces_DraweeController_);
			return cb_getRequestListener_Lcom_facebook_drawee_interfaces_DraweeController_;
		}

		static IntPtr n_GetRequestListener_Lcom_facebook_drawee_interfaces_DraweeController_ (IntPtr jnienv, IntPtr native__this, IntPtr native_controller)
		{
			global::Com.Facebook.Drawee.Backends.Pipeline.PipelineDraweeControllerBuilder __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Drawee.Backends.Pipeline.PipelineDraweeControllerBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Facebook.Drawee.Interfaces.IDraweeController controller = (global::Com.Facebook.Drawee.Interfaces.IDraweeController)global::Java.Lang.Object.GetObject<global::Com.Facebook.Drawee.Interfaces.IDraweeController> (native_controller, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetRequestListener (controller));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.drawee.backends.pipeline']/class[@name='PipelineDraweeControllerBuilder']/method[@name='getRequestListener' and count(parameter)=1 and parameter[1][@type='com.facebook.drawee.interfaces.DraweeController']]"
		[Register ("getRequestListener", "(Lcom/facebook/drawee/interfaces/DraweeController;)Lcom/facebook/imagepipeline/listener/RequestListener;", "GetGetRequestListener_Lcom_facebook_drawee_interfaces_DraweeController_Handler")]
		protected virtual unsafe global::Com.Facebook.Imagepipeline.Listener.IRequestListener GetRequestListener (global::Com.Facebook.Drawee.Interfaces.IDraweeController controller)
		{
			const string __id = "getRequestListener.(Lcom/facebook/drawee/interfaces/DraweeController;)Lcom/facebook/imagepipeline/listener/RequestListener;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((controller == null) ? IntPtr.Zero : ((global::Java.Lang.Object) controller).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Facebook.Imagepipeline.Listener.IRequestListener> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_setCustomDrawableFactories_Lcom_facebook_common_internal_ImmutableList_;
#pragma warning disable 0169
		static Delegate GetSetCustomDrawableFactories_Lcom_facebook_common_internal_ImmutableList_Handler ()
		{
			if (cb_setCustomDrawableFactories_Lcom_facebook_common_internal_ImmutableList_ == null)
				cb_setCustomDrawableFactories_Lcom_facebook_common_internal_ImmutableList_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_SetCustomDrawableFactories_Lcom_facebook_common_internal_ImmutableList_);
			return cb_setCustomDrawableFactories_Lcom_facebook_common_internal_ImmutableList_;
		}

		static IntPtr n_SetCustomDrawableFactories_Lcom_facebook_common_internal_ImmutableList_ (IntPtr jnienv, IntPtr native__this, IntPtr native_customDrawableFactories)
		{
			global::Com.Facebook.Drawee.Backends.Pipeline.PipelineDraweeControllerBuilder __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Drawee.Backends.Pipeline.PipelineDraweeControllerBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Facebook.Common.Internal.ImmutableList customDrawableFactories = global::Java.Lang.Object.GetObject<global::Com.Facebook.Common.Internal.ImmutableList> (native_customDrawableFactories, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetCustomDrawableFactories (customDrawableFactories));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.drawee.backends.pipeline']/class[@name='PipelineDraweeControllerBuilder']/method[@name='setCustomDrawableFactories' and count(parameter)=1 and parameter[1][@type='com.facebook.common.internal.ImmutableList&lt;com.facebook.imagepipeline.drawable.DrawableFactory&gt;']]"
		[Register ("setCustomDrawableFactories", "(Lcom/facebook/common/internal/ImmutableList;)Lcom/facebook/drawee/backends/pipeline/PipelineDraweeControllerBuilder;", "GetSetCustomDrawableFactories_Lcom_facebook_common_internal_ImmutableList_Handler")]
		public virtual unsafe global::Com.Facebook.Drawee.Backends.Pipeline.PipelineDraweeControllerBuilder SetCustomDrawableFactories (global::Com.Facebook.Common.Internal.ImmutableList customDrawableFactories)
		{
			const string __id = "setCustomDrawableFactories.(Lcom/facebook/common/internal/ImmutableList;)Lcom/facebook/drawee/backends/pipeline/PipelineDraweeControllerBuilder;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((customDrawableFactories == null) ? IntPtr.Zero : ((global::Java.Lang.Object) customDrawableFactories).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Facebook.Drawee.Backends.Pipeline.PipelineDraweeControllerBuilder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_setCustomDrawableFactories_arrayLcom_facebook_imagepipeline_drawable_DrawableFactory_;
#pragma warning disable 0169
		static Delegate GetSetCustomDrawableFactories_arrayLcom_facebook_imagepipeline_drawable_DrawableFactory_Handler ()
		{
			if (cb_setCustomDrawableFactories_arrayLcom_facebook_imagepipeline_drawable_DrawableFactory_ == null)
				cb_setCustomDrawableFactories_arrayLcom_facebook_imagepipeline_drawable_DrawableFactory_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_SetCustomDrawableFactories_arrayLcom_facebook_imagepipeline_drawable_DrawableFactory_);
			return cb_setCustomDrawableFactories_arrayLcom_facebook_imagepipeline_drawable_DrawableFactory_;
		}

		static IntPtr n_SetCustomDrawableFactories_arrayLcom_facebook_imagepipeline_drawable_DrawableFactory_ (IntPtr jnienv, IntPtr native__this, IntPtr native_drawableFactories)
		{
			global::Com.Facebook.Drawee.Backends.Pipeline.PipelineDraweeControllerBuilder __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Drawee.Backends.Pipeline.PipelineDraweeControllerBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Facebook.Imagepipeline.Drawable.IDrawableFactory[] drawableFactories = (global::Com.Facebook.Imagepipeline.Drawable.IDrawableFactory[]) JNIEnv.GetArray (native_drawableFactories, JniHandleOwnership.DoNotTransfer, typeof (global::Com.Facebook.Imagepipeline.Drawable.IDrawableFactory));
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetCustomDrawableFactories (drawableFactories));
			if (drawableFactories != null)
				JNIEnv.CopyArray (drawableFactories, native_drawableFactories);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.drawee.backends.pipeline']/class[@name='PipelineDraweeControllerBuilder']/method[@name='setCustomDrawableFactories' and count(parameter)=1 and parameter[1][@type='com.facebook.imagepipeline.drawable.DrawableFactory...']]"
		[Register ("setCustomDrawableFactories", "([Lcom/facebook/imagepipeline/drawable/DrawableFactory;)Lcom/facebook/drawee/backends/pipeline/PipelineDraweeControllerBuilder;", "GetSetCustomDrawableFactories_arrayLcom_facebook_imagepipeline_drawable_DrawableFactory_Handler")]
		public virtual unsafe global::Com.Facebook.Drawee.Backends.Pipeline.PipelineDraweeControllerBuilder SetCustomDrawableFactories (params global::Com.Facebook.Imagepipeline.Drawable.IDrawableFactory[] drawableFactories)
		{
			const string __id = "setCustomDrawableFactories.([Lcom/facebook/imagepipeline/drawable/DrawableFactory;)Lcom/facebook/drawee/backends/pipeline/PipelineDraweeControllerBuilder;";
			IntPtr native_drawableFactories = JNIEnv.NewArray (drawableFactories);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_drawableFactories);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Facebook.Drawee.Backends.Pipeline.PipelineDraweeControllerBuilder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				if (drawableFactories != null) {
					JNIEnv.CopyArray (native_drawableFactories, drawableFactories);
					JNIEnv.DeleteLocalRef (native_drawableFactories);
				}
			}
		}

		static Delegate cb_setCustomDrawableFactory_Lcom_facebook_imagepipeline_drawable_DrawableFactory_;
#pragma warning disable 0169
		static Delegate GetSetCustomDrawableFactory_Lcom_facebook_imagepipeline_drawable_DrawableFactory_Handler ()
		{
			if (cb_setCustomDrawableFactory_Lcom_facebook_imagepipeline_drawable_DrawableFactory_ == null)
				cb_setCustomDrawableFactory_Lcom_facebook_imagepipeline_drawable_DrawableFactory_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_SetCustomDrawableFactory_Lcom_facebook_imagepipeline_drawable_DrawableFactory_);
			return cb_setCustomDrawableFactory_Lcom_facebook_imagepipeline_drawable_DrawableFactory_;
		}

		static IntPtr n_SetCustomDrawableFactory_Lcom_facebook_imagepipeline_drawable_DrawableFactory_ (IntPtr jnienv, IntPtr native__this, IntPtr native_drawableFactory)
		{
			global::Com.Facebook.Drawee.Backends.Pipeline.PipelineDraweeControllerBuilder __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Drawee.Backends.Pipeline.PipelineDraweeControllerBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Facebook.Imagepipeline.Drawable.IDrawableFactory drawableFactory = (global::Com.Facebook.Imagepipeline.Drawable.IDrawableFactory)global::Java.Lang.Object.GetObject<global::Com.Facebook.Imagepipeline.Drawable.IDrawableFactory> (native_drawableFactory, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetCustomDrawableFactory (drawableFactory));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.drawee.backends.pipeline']/class[@name='PipelineDraweeControllerBuilder']/method[@name='setCustomDrawableFactory' and count(parameter)=1 and parameter[1][@type='com.facebook.imagepipeline.drawable.DrawableFactory']]"
		[Register ("setCustomDrawableFactory", "(Lcom/facebook/imagepipeline/drawable/DrawableFactory;)Lcom/facebook/drawee/backends/pipeline/PipelineDraweeControllerBuilder;", "GetSetCustomDrawableFactory_Lcom_facebook_imagepipeline_drawable_DrawableFactory_Handler")]
		public virtual unsafe global::Com.Facebook.Drawee.Backends.Pipeline.PipelineDraweeControllerBuilder SetCustomDrawableFactory (global::Com.Facebook.Imagepipeline.Drawable.IDrawableFactory drawableFactory)
		{
			const string __id = "setCustomDrawableFactory.(Lcom/facebook/imagepipeline/drawable/DrawableFactory;)Lcom/facebook/drawee/backends/pipeline/PipelineDraweeControllerBuilder;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((drawableFactory == null) ? IntPtr.Zero : ((global::Java.Lang.Object) drawableFactory).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Facebook.Drawee.Backends.Pipeline.PipelineDraweeControllerBuilder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_setImageOriginListener_Lcom_facebook_drawee_backends_pipeline_info_ImageOriginListener_;
#pragma warning disable 0169
		static Delegate GetSetImageOriginListener_Lcom_facebook_drawee_backends_pipeline_info_ImageOriginListener_Handler ()
		{
			if (cb_setImageOriginListener_Lcom_facebook_drawee_backends_pipeline_info_ImageOriginListener_ == null)
				cb_setImageOriginListener_Lcom_facebook_drawee_backends_pipeline_info_ImageOriginListener_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_SetImageOriginListener_Lcom_facebook_drawee_backends_pipeline_info_ImageOriginListener_);
			return cb_setImageOriginListener_Lcom_facebook_drawee_backends_pipeline_info_ImageOriginListener_;
		}

		static IntPtr n_SetImageOriginListener_Lcom_facebook_drawee_backends_pipeline_info_ImageOriginListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_imageOriginListener)
		{
			global::Com.Facebook.Drawee.Backends.Pipeline.PipelineDraweeControllerBuilder __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Drawee.Backends.Pipeline.PipelineDraweeControllerBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Facebook.Drawee.Backends.Pipeline.Info.IImageOriginListener imageOriginListener = (global::Com.Facebook.Drawee.Backends.Pipeline.Info.IImageOriginListener)global::Java.Lang.Object.GetObject<global::Com.Facebook.Drawee.Backends.Pipeline.Info.IImageOriginListener> (native_imageOriginListener, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetImageOriginListener (imageOriginListener));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.drawee.backends.pipeline']/class[@name='PipelineDraweeControllerBuilder']/method[@name='setImageOriginListener' and count(parameter)=1 and parameter[1][@type='com.facebook.drawee.backends.pipeline.info.ImageOriginListener']]"
		[Register ("setImageOriginListener", "(Lcom/facebook/drawee/backends/pipeline/info/ImageOriginListener;)Lcom/facebook/drawee/backends/pipeline/PipelineDraweeControllerBuilder;", "GetSetImageOriginListener_Lcom_facebook_drawee_backends_pipeline_info_ImageOriginListener_Handler")]
		public virtual unsafe global::Com.Facebook.Drawee.Backends.Pipeline.PipelineDraweeControllerBuilder SetImageOriginListener (global::Com.Facebook.Drawee.Backends.Pipeline.Info.IImageOriginListener imageOriginListener)
		{
			const string __id = "setImageOriginListener.(Lcom/facebook/drawee/backends/pipeline/info/ImageOriginListener;)Lcom/facebook/drawee/backends/pipeline/PipelineDraweeControllerBuilder;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((imageOriginListener == null) ? IntPtr.Zero : ((global::Java.Lang.Object) imageOriginListener).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Facebook.Drawee.Backends.Pipeline.PipelineDraweeControllerBuilder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_setPerfDataListener_Lcom_facebook_drawee_backends_pipeline_info_ImagePerfDataListener_;
#pragma warning disable 0169
		static Delegate GetSetPerfDataListener_Lcom_facebook_drawee_backends_pipeline_info_ImagePerfDataListener_Handler ()
		{
			if (cb_setPerfDataListener_Lcom_facebook_drawee_backends_pipeline_info_ImagePerfDataListener_ == null)
				cb_setPerfDataListener_Lcom_facebook_drawee_backends_pipeline_info_ImagePerfDataListener_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_SetPerfDataListener_Lcom_facebook_drawee_backends_pipeline_info_ImagePerfDataListener_);
			return cb_setPerfDataListener_Lcom_facebook_drawee_backends_pipeline_info_ImagePerfDataListener_;
		}

		static IntPtr n_SetPerfDataListener_Lcom_facebook_drawee_backends_pipeline_info_ImagePerfDataListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_imagePerfDataListener)
		{
			global::Com.Facebook.Drawee.Backends.Pipeline.PipelineDraweeControllerBuilder __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Drawee.Backends.Pipeline.PipelineDraweeControllerBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Facebook.Drawee.Backends.Pipeline.Info.IImagePerfDataListener imagePerfDataListener = (global::Com.Facebook.Drawee.Backends.Pipeline.Info.IImagePerfDataListener)global::Java.Lang.Object.GetObject<global::Com.Facebook.Drawee.Backends.Pipeline.Info.IImagePerfDataListener> (native_imagePerfDataListener, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetPerfDataListener (imagePerfDataListener));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.drawee.backends.pipeline']/class[@name='PipelineDraweeControllerBuilder']/method[@name='setPerfDataListener' and count(parameter)=1 and parameter[1][@type='com.facebook.drawee.backends.pipeline.info.ImagePerfDataListener']]"
		[Register ("setPerfDataListener", "(Lcom/facebook/drawee/backends/pipeline/info/ImagePerfDataListener;)Lcom/facebook/drawee/backends/pipeline/PipelineDraweeControllerBuilder;", "GetSetPerfDataListener_Lcom_facebook_drawee_backends_pipeline_info_ImagePerfDataListener_Handler")]
		public virtual unsafe global::Com.Facebook.Drawee.Backends.Pipeline.PipelineDraweeControllerBuilder SetPerfDataListener (global::Com.Facebook.Drawee.Backends.Pipeline.Info.IImagePerfDataListener imagePerfDataListener)
		{
			const string __id = "setPerfDataListener.(Lcom/facebook/drawee/backends/pipeline/info/ImagePerfDataListener;)Lcom/facebook/drawee/backends/pipeline/PipelineDraweeControllerBuilder;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((imagePerfDataListener == null) ? IntPtr.Zero : ((global::Java.Lang.Object) imagePerfDataListener).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Facebook.Drawee.Backends.Pipeline.PipelineDraweeControllerBuilder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_setUri_Landroid_net_Uri_;
#pragma warning disable 0169
		static Delegate GetRawSetUri_Landroid_net_Uri_Handler ()
		{
			if (cb_setUri_Landroid_net_Uri_ == null)
				cb_setUri_Landroid_net_Uri_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_RawSetUri_Landroid_net_Uri_);
			return cb_setUri_Landroid_net_Uri_;
		}

		static IntPtr n_RawSetUri_Landroid_net_Uri_ (IntPtr jnienv, IntPtr native__this, IntPtr native_uri)
		{
			global::Com.Facebook.Drawee.Backends.Pipeline.PipelineDraweeControllerBuilder __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Drawee.Backends.Pipeline.PipelineDraweeControllerBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Net.Uri uri = global::Java.Lang.Object.GetObject<global::Android.Net.Uri> (native_uri, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.RawSetUri (uri));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.drawee.backends.pipeline']/class[@name='PipelineDraweeControllerBuilder']/method[@name='setUri' and count(parameter)=1 and parameter[1][@type='android.net.Uri']]"
		[Register ("setUri", "(Landroid/net/Uri;)Lcom/facebook/drawee/backends/pipeline/PipelineDraweeControllerBuilder;", "GetRawSetUri_Landroid_net_Uri_Handler")]
		public virtual unsafe global::Com.Facebook.Drawee.Backends.Pipeline.PipelineDraweeControllerBuilder RawSetUri (global::Android.Net.Uri uri)
		{
			const string __id = "setUri.(Landroid/net/Uri;)Lcom/facebook/drawee/backends/pipeline/PipelineDraweeControllerBuilder;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((uri == null) ? IntPtr.Zero : ((global::Java.Lang.Object) uri).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Facebook.Drawee.Backends.Pipeline.PipelineDraweeControllerBuilder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_setUri_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetRawSetUri_Ljava_lang_String_Handler ()
		{
			if (cb_setUri_Ljava_lang_String_ == null)
				cb_setUri_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_RawSetUri_Ljava_lang_String_);
			return cb_setUri_Ljava_lang_String_;
		}

		static IntPtr n_RawSetUri_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_uriString)
		{
			global::Com.Facebook.Drawee.Backends.Pipeline.PipelineDraweeControllerBuilder __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Drawee.Backends.Pipeline.PipelineDraweeControllerBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string uriString = JNIEnv.GetString (native_uriString, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.RawSetUri (uriString));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.drawee.backends.pipeline']/class[@name='PipelineDraweeControllerBuilder']/method[@name='setUri' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("setUri", "(Ljava/lang/String;)Lcom/facebook/drawee/backends/pipeline/PipelineDraweeControllerBuilder;", "GetRawSetUri_Ljava_lang_String_Handler")]
		public virtual unsafe global::Com.Facebook.Drawee.Backends.Pipeline.PipelineDraweeControllerBuilder RawSetUri (string uriString)
		{
			const string __id = "setUri.(Ljava/lang/String;)Lcom/facebook/drawee/backends/pipeline/PipelineDraweeControllerBuilder;";
			IntPtr native_uriString = JNIEnv.NewString (uriString);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_uriString);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Facebook.Drawee.Backends.Pipeline.PipelineDraweeControllerBuilder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_uriString);
			}
		}

	}
}
