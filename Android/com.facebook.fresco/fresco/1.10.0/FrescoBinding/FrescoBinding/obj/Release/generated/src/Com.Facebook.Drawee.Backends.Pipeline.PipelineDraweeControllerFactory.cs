using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Facebook.Drawee.Backends.Pipeline {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.facebook.drawee.backends.pipeline']/class[@name='PipelineDraweeControllerFactory']"
	[global::Android.Runtime.Register ("com/facebook/drawee/backends/pipeline/PipelineDraweeControllerFactory", DoNotGenerateAcw=true)]
	public partial class PipelineDraweeControllerFactory : global::Java.Lang.Object {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/facebook/drawee/backends/pipeline/PipelineDraweeControllerFactory", typeof (PipelineDraweeControllerFactory));
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

		protected PipelineDraweeControllerFactory (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.facebook.drawee.backends.pipeline']/class[@name='PipelineDraweeControllerFactory']/constructor[@name='PipelineDraweeControllerFactory' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe PipelineDraweeControllerFactory ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "()V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), null);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_init_Landroid_content_res_Resources_Lcom_facebook_drawee_components_DeferredReleaser_Lcom_facebook_imagepipeline_drawable_DrawableFactory_Ljava_util_concurrent_Executor_Lcom_facebook_imagepipeline_cache_MemoryCache_Lcom_facebook_common_internal_ImmutableList_Lcom_facebook_common_internal_Supplier_;
#pragma warning disable 0169
		static Delegate GetInit_Landroid_content_res_Resources_Lcom_facebook_drawee_components_DeferredReleaser_Lcom_facebook_imagepipeline_drawable_DrawableFactory_Ljava_util_concurrent_Executor_Lcom_facebook_imagepipeline_cache_MemoryCache_Lcom_facebook_common_internal_ImmutableList_Lcom_facebook_common_internal_Supplier_Handler ()
		{
			if (cb_init_Landroid_content_res_Resources_Lcom_facebook_drawee_components_DeferredReleaser_Lcom_facebook_imagepipeline_drawable_DrawableFactory_Ljava_util_concurrent_Executor_Lcom_facebook_imagepipeline_cache_MemoryCache_Lcom_facebook_common_internal_ImmutableList_Lcom_facebook_common_internal_Supplier_ == null)
				cb_init_Landroid_content_res_Resources_Lcom_facebook_drawee_components_DeferredReleaser_Lcom_facebook_imagepipeline_drawable_DrawableFactory_Ljava_util_concurrent_Executor_Lcom_facebook_imagepipeline_cache_MemoryCache_Lcom_facebook_common_internal_ImmutableList_Lcom_facebook_common_internal_Supplier_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_Init_Landroid_content_res_Resources_Lcom_facebook_drawee_components_DeferredReleaser_Lcom_facebook_imagepipeline_drawable_DrawableFactory_Ljava_util_concurrent_Executor_Lcom_facebook_imagepipeline_cache_MemoryCache_Lcom_facebook_common_internal_ImmutableList_Lcom_facebook_common_internal_Supplier_);
			return cb_init_Landroid_content_res_Resources_Lcom_facebook_drawee_components_DeferredReleaser_Lcom_facebook_imagepipeline_drawable_DrawableFactory_Ljava_util_concurrent_Executor_Lcom_facebook_imagepipeline_cache_MemoryCache_Lcom_facebook_common_internal_ImmutableList_Lcom_facebook_common_internal_Supplier_;
		}

		static void n_Init_Landroid_content_res_Resources_Lcom_facebook_drawee_components_DeferredReleaser_Lcom_facebook_imagepipeline_drawable_DrawableFactory_Ljava_util_concurrent_Executor_Lcom_facebook_imagepipeline_cache_MemoryCache_Lcom_facebook_common_internal_ImmutableList_Lcom_facebook_common_internal_Supplier_ (IntPtr jnienv, IntPtr native__this, IntPtr native_resources, IntPtr native_deferredReleaser, IntPtr native_animatedDrawableFactory, IntPtr native_uiThreadExecutor, IntPtr native_memoryCache, IntPtr native_drawableFactories, IntPtr native_debugOverlayEnabledSupplier)
		{
			global::Com.Facebook.Drawee.Backends.Pipeline.PipelineDraweeControllerFactory __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Drawee.Backends.Pipeline.PipelineDraweeControllerFactory> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.Res.Resources resources = global::Java.Lang.Object.GetObject<global::Android.Content.Res.Resources> (native_resources, JniHandleOwnership.DoNotTransfer);
			global::Com.Facebook.Drawee.Components.DeferredReleaser deferredReleaser = global::Java.Lang.Object.GetObject<global::Com.Facebook.Drawee.Components.DeferredReleaser> (native_deferredReleaser, JniHandleOwnership.DoNotTransfer);
			global::Com.Facebook.Imagepipeline.Drawable.IDrawableFactory animatedDrawableFactory = (global::Com.Facebook.Imagepipeline.Drawable.IDrawableFactory)global::Java.Lang.Object.GetObject<global::Com.Facebook.Imagepipeline.Drawable.IDrawableFactory> (native_animatedDrawableFactory, JniHandleOwnership.DoNotTransfer);
			global::Java.Util.Concurrent.IExecutor uiThreadExecutor = (global::Java.Util.Concurrent.IExecutor)global::Java.Lang.Object.GetObject<global::Java.Util.Concurrent.IExecutor> (native_uiThreadExecutor, JniHandleOwnership.DoNotTransfer);
			global::Com.Facebook.Imagepipeline.Cache.IMemoryCache memoryCache = (global::Com.Facebook.Imagepipeline.Cache.IMemoryCache)global::Java.Lang.Object.GetObject<global::Com.Facebook.Imagepipeline.Cache.IMemoryCache> (native_memoryCache, JniHandleOwnership.DoNotTransfer);
			global::Com.Facebook.Common.Internal.ImmutableList drawableFactories = global::Java.Lang.Object.GetObject<global::Com.Facebook.Common.Internal.ImmutableList> (native_drawableFactories, JniHandleOwnership.DoNotTransfer);
			global::Com.Facebook.Common.Internal.ISupplier debugOverlayEnabledSupplier = (global::Com.Facebook.Common.Internal.ISupplier)global::Java.Lang.Object.GetObject<global::Com.Facebook.Common.Internal.ISupplier> (native_debugOverlayEnabledSupplier, JniHandleOwnership.DoNotTransfer);
			__this.Init (resources, deferredReleaser, animatedDrawableFactory, uiThreadExecutor, memoryCache, drawableFactories, debugOverlayEnabledSupplier);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.drawee.backends.pipeline']/class[@name='PipelineDraweeControllerFactory']/method[@name='init' and count(parameter)=7 and parameter[1][@type='android.content.res.Resources'] and parameter[2][@type='com.facebook.drawee.components.DeferredReleaser'] and parameter[3][@type='com.facebook.imagepipeline.drawable.DrawableFactory'] and parameter[4][@type='java.util.concurrent.Executor'] and parameter[5][@type='com.facebook.imagepipeline.cache.MemoryCache&lt;com.facebook.cache.common.CacheKey, com.facebook.imagepipeline.image.CloseableImage&gt;'] and parameter[6][@type='com.facebook.common.internal.ImmutableList&lt;com.facebook.imagepipeline.drawable.DrawableFactory&gt;'] and parameter[7][@type='com.facebook.common.internal.Supplier&lt;java.lang.Boolean&gt;']]"
		[Register ("init", "(Landroid/content/res/Resources;Lcom/facebook/drawee/components/DeferredReleaser;Lcom/facebook/imagepipeline/drawable/DrawableFactory;Ljava/util/concurrent/Executor;Lcom/facebook/imagepipeline/cache/MemoryCache;Lcom/facebook/common/internal/ImmutableList;Lcom/facebook/common/internal/Supplier;)V", "GetInit_Landroid_content_res_Resources_Lcom_facebook_drawee_components_DeferredReleaser_Lcom_facebook_imagepipeline_drawable_DrawableFactory_Ljava_util_concurrent_Executor_Lcom_facebook_imagepipeline_cache_MemoryCache_Lcom_facebook_common_internal_ImmutableList_Lcom_facebook_common_internal_Supplier_Handler")]
		public virtual unsafe void Init (global::Android.Content.Res.Resources resources, global::Com.Facebook.Drawee.Components.DeferredReleaser deferredReleaser, global::Com.Facebook.Imagepipeline.Drawable.IDrawableFactory animatedDrawableFactory, global::Java.Util.Concurrent.IExecutor uiThreadExecutor, global::Com.Facebook.Imagepipeline.Cache.IMemoryCache memoryCache, global::Com.Facebook.Common.Internal.ImmutableList drawableFactories, global::Com.Facebook.Common.Internal.ISupplier debugOverlayEnabledSupplier)
		{
			const string __id = "init.(Landroid/content/res/Resources;Lcom/facebook/drawee/components/DeferredReleaser;Lcom/facebook/imagepipeline/drawable/DrawableFactory;Ljava/util/concurrent/Executor;Lcom/facebook/imagepipeline/cache/MemoryCache;Lcom/facebook/common/internal/ImmutableList;Lcom/facebook/common/internal/Supplier;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [7];
				__args [0] = new JniArgumentValue ((resources == null) ? IntPtr.Zero : ((global::Java.Lang.Object) resources).Handle);
				__args [1] = new JniArgumentValue ((deferredReleaser == null) ? IntPtr.Zero : ((global::Java.Lang.Object) deferredReleaser).Handle);
				__args [2] = new JniArgumentValue ((animatedDrawableFactory == null) ? IntPtr.Zero : ((global::Java.Lang.Object) animatedDrawableFactory).Handle);
				__args [3] = new JniArgumentValue ((uiThreadExecutor == null) ? IntPtr.Zero : ((global::Java.Lang.Object) uiThreadExecutor).Handle);
				__args [4] = new JniArgumentValue ((memoryCache == null) ? IntPtr.Zero : ((global::Java.Lang.Object) memoryCache).Handle);
				__args [5] = new JniArgumentValue ((drawableFactories == null) ? IntPtr.Zero : ((global::Java.Lang.Object) drawableFactories).Handle);
				__args [6] = new JniArgumentValue ((debugOverlayEnabledSupplier == null) ? IntPtr.Zero : ((global::Java.Lang.Object) debugOverlayEnabledSupplier).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_internalCreateController_Landroid_content_res_Resources_Lcom_facebook_drawee_components_DeferredReleaser_Lcom_facebook_imagepipeline_drawable_DrawableFactory_Ljava_util_concurrent_Executor_Lcom_facebook_imagepipeline_cache_MemoryCache_Lcom_facebook_common_internal_ImmutableList_;
#pragma warning disable 0169
		static Delegate GetInternalCreateController_Landroid_content_res_Resources_Lcom_facebook_drawee_components_DeferredReleaser_Lcom_facebook_imagepipeline_drawable_DrawableFactory_Ljava_util_concurrent_Executor_Lcom_facebook_imagepipeline_cache_MemoryCache_Lcom_facebook_common_internal_ImmutableList_Handler ()
		{
			if (cb_internalCreateController_Landroid_content_res_Resources_Lcom_facebook_drawee_components_DeferredReleaser_Lcom_facebook_imagepipeline_drawable_DrawableFactory_Ljava_util_concurrent_Executor_Lcom_facebook_imagepipeline_cache_MemoryCache_Lcom_facebook_common_internal_ImmutableList_ == null)
				cb_internalCreateController_Landroid_content_res_Resources_Lcom_facebook_drawee_components_DeferredReleaser_Lcom_facebook_imagepipeline_drawable_DrawableFactory_Ljava_util_concurrent_Executor_Lcom_facebook_imagepipeline_cache_MemoryCache_Lcom_facebook_common_internal_ImmutableList_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_InternalCreateController_Landroid_content_res_Resources_Lcom_facebook_drawee_components_DeferredReleaser_Lcom_facebook_imagepipeline_drawable_DrawableFactory_Ljava_util_concurrent_Executor_Lcom_facebook_imagepipeline_cache_MemoryCache_Lcom_facebook_common_internal_ImmutableList_);
			return cb_internalCreateController_Landroid_content_res_Resources_Lcom_facebook_drawee_components_DeferredReleaser_Lcom_facebook_imagepipeline_drawable_DrawableFactory_Ljava_util_concurrent_Executor_Lcom_facebook_imagepipeline_cache_MemoryCache_Lcom_facebook_common_internal_ImmutableList_;
		}

		static IntPtr n_InternalCreateController_Landroid_content_res_Resources_Lcom_facebook_drawee_components_DeferredReleaser_Lcom_facebook_imagepipeline_drawable_DrawableFactory_Ljava_util_concurrent_Executor_Lcom_facebook_imagepipeline_cache_MemoryCache_Lcom_facebook_common_internal_ImmutableList_ (IntPtr jnienv, IntPtr native__this, IntPtr native_resources, IntPtr native_deferredReleaser, IntPtr native_animatedDrawableFactory, IntPtr native_uiThreadExecutor, IntPtr native_memoryCache, IntPtr native_drawableFactories)
		{
			global::Com.Facebook.Drawee.Backends.Pipeline.PipelineDraweeControllerFactory __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Drawee.Backends.Pipeline.PipelineDraweeControllerFactory> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.Res.Resources resources = global::Java.Lang.Object.GetObject<global::Android.Content.Res.Resources> (native_resources, JniHandleOwnership.DoNotTransfer);
			global::Com.Facebook.Drawee.Components.DeferredReleaser deferredReleaser = global::Java.Lang.Object.GetObject<global::Com.Facebook.Drawee.Components.DeferredReleaser> (native_deferredReleaser, JniHandleOwnership.DoNotTransfer);
			global::Com.Facebook.Imagepipeline.Drawable.IDrawableFactory animatedDrawableFactory = (global::Com.Facebook.Imagepipeline.Drawable.IDrawableFactory)global::Java.Lang.Object.GetObject<global::Com.Facebook.Imagepipeline.Drawable.IDrawableFactory> (native_animatedDrawableFactory, JniHandleOwnership.DoNotTransfer);
			global::Java.Util.Concurrent.IExecutor uiThreadExecutor = (global::Java.Util.Concurrent.IExecutor)global::Java.Lang.Object.GetObject<global::Java.Util.Concurrent.IExecutor> (native_uiThreadExecutor, JniHandleOwnership.DoNotTransfer);
			global::Com.Facebook.Imagepipeline.Cache.IMemoryCache memoryCache = (global::Com.Facebook.Imagepipeline.Cache.IMemoryCache)global::Java.Lang.Object.GetObject<global::Com.Facebook.Imagepipeline.Cache.IMemoryCache> (native_memoryCache, JniHandleOwnership.DoNotTransfer);
			global::Com.Facebook.Common.Internal.ImmutableList drawableFactories = global::Java.Lang.Object.GetObject<global::Com.Facebook.Common.Internal.ImmutableList> (native_drawableFactories, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.InternalCreateController (resources, deferredReleaser, animatedDrawableFactory, uiThreadExecutor, memoryCache, drawableFactories));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.drawee.backends.pipeline']/class[@name='PipelineDraweeControllerFactory']/method[@name='internalCreateController' and count(parameter)=6 and parameter[1][@type='android.content.res.Resources'] and parameter[2][@type='com.facebook.drawee.components.DeferredReleaser'] and parameter[3][@type='com.facebook.imagepipeline.drawable.DrawableFactory'] and parameter[4][@type='java.util.concurrent.Executor'] and parameter[5][@type='com.facebook.imagepipeline.cache.MemoryCache&lt;com.facebook.cache.common.CacheKey, com.facebook.imagepipeline.image.CloseableImage&gt;'] and parameter[6][@type='com.facebook.common.internal.ImmutableList&lt;com.facebook.imagepipeline.drawable.DrawableFactory&gt;']]"
		[Register ("internalCreateController", "(Landroid/content/res/Resources;Lcom/facebook/drawee/components/DeferredReleaser;Lcom/facebook/imagepipeline/drawable/DrawableFactory;Ljava/util/concurrent/Executor;Lcom/facebook/imagepipeline/cache/MemoryCache;Lcom/facebook/common/internal/ImmutableList;)Lcom/facebook/drawee/backends/pipeline/PipelineDraweeController;", "GetInternalCreateController_Landroid_content_res_Resources_Lcom_facebook_drawee_components_DeferredReleaser_Lcom_facebook_imagepipeline_drawable_DrawableFactory_Ljava_util_concurrent_Executor_Lcom_facebook_imagepipeline_cache_MemoryCache_Lcom_facebook_common_internal_ImmutableList_Handler")]
		protected virtual unsafe global::Com.Facebook.Drawee.Backends.Pipeline.PipelineDraweeController InternalCreateController (global::Android.Content.Res.Resources resources, global::Com.Facebook.Drawee.Components.DeferredReleaser deferredReleaser, global::Com.Facebook.Imagepipeline.Drawable.IDrawableFactory animatedDrawableFactory, global::Java.Util.Concurrent.IExecutor uiThreadExecutor, global::Com.Facebook.Imagepipeline.Cache.IMemoryCache memoryCache, global::Com.Facebook.Common.Internal.ImmutableList drawableFactories)
		{
			const string __id = "internalCreateController.(Landroid/content/res/Resources;Lcom/facebook/drawee/components/DeferredReleaser;Lcom/facebook/imagepipeline/drawable/DrawableFactory;Ljava/util/concurrent/Executor;Lcom/facebook/imagepipeline/cache/MemoryCache;Lcom/facebook/common/internal/ImmutableList;)Lcom/facebook/drawee/backends/pipeline/PipelineDraweeController;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [6];
				__args [0] = new JniArgumentValue ((resources == null) ? IntPtr.Zero : ((global::Java.Lang.Object) resources).Handle);
				__args [1] = new JniArgumentValue ((deferredReleaser == null) ? IntPtr.Zero : ((global::Java.Lang.Object) deferredReleaser).Handle);
				__args [2] = new JniArgumentValue ((animatedDrawableFactory == null) ? IntPtr.Zero : ((global::Java.Lang.Object) animatedDrawableFactory).Handle);
				__args [3] = new JniArgumentValue ((uiThreadExecutor == null) ? IntPtr.Zero : ((global::Java.Lang.Object) uiThreadExecutor).Handle);
				__args [4] = new JniArgumentValue ((memoryCache == null) ? IntPtr.Zero : ((global::Java.Lang.Object) memoryCache).Handle);
				__args [5] = new JniArgumentValue ((drawableFactories == null) ? IntPtr.Zero : ((global::Java.Lang.Object) drawableFactories).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Facebook.Drawee.Backends.Pipeline.PipelineDraweeController> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_newController;
#pragma warning disable 0169
		static Delegate GetNewControllerHandler ()
		{
			if (cb_newController == null)
				cb_newController = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_NewController);
			return cb_newController;
		}

		static IntPtr n_NewController (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Facebook.Drawee.Backends.Pipeline.PipelineDraweeControllerFactory __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Drawee.Backends.Pipeline.PipelineDraweeControllerFactory> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.NewController ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.drawee.backends.pipeline']/class[@name='PipelineDraweeControllerFactory']/method[@name='newController' and count(parameter)=0]"
		[Register ("newController", "()Lcom/facebook/drawee/backends/pipeline/PipelineDraweeController;", "GetNewControllerHandler")]
		public virtual unsafe global::Com.Facebook.Drawee.Backends.Pipeline.PipelineDraweeController NewController ()
		{
			const string __id = "newController.()Lcom/facebook/drawee/backends/pipeline/PipelineDraweeController;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Com.Facebook.Drawee.Backends.Pipeline.PipelineDraweeController> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}
}
