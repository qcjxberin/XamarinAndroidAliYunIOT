using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Facebook.Drawee.Backends.Pipeline {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.facebook.drawee.backends.pipeline']/class[@name='PipelineDraweeController']"
	[global::Android.Runtime.Register ("com/facebook/drawee/backends/pipeline/PipelineDraweeController", DoNotGenerateAcw=true)]
	public partial class PipelineDraweeController : global::Com.Facebook.Drawee.Controller.AbstractDraweeController {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/facebook/drawee/backends/pipeline/PipelineDraweeController", typeof (PipelineDraweeController));
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

		protected PipelineDraweeController (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.facebook.drawee.backends.pipeline']/class[@name='PipelineDraweeController']/constructor[@name='PipelineDraweeController' and count(parameter)=6 and parameter[1][@type='android.content.res.Resources'] and parameter[2][@type='com.facebook.drawee.components.DeferredReleaser'] and parameter[3][@type='com.facebook.imagepipeline.drawable.DrawableFactory'] and parameter[4][@type='java.util.concurrent.Executor'] and parameter[5][@type='com.facebook.imagepipeline.cache.MemoryCache&lt;com.facebook.cache.common.CacheKey, com.facebook.imagepipeline.image.CloseableImage&gt;'] and parameter[6][@type='com.facebook.common.internal.ImmutableList&lt;com.facebook.imagepipeline.drawable.DrawableFactory&gt;']]"
		[Register (".ctor", "(Landroid/content/res/Resources;Lcom/facebook/drawee/components/DeferredReleaser;Lcom/facebook/imagepipeline/drawable/DrawableFactory;Ljava/util/concurrent/Executor;Lcom/facebook/imagepipeline/cache/MemoryCache;Lcom/facebook/common/internal/ImmutableList;)V", "")]
		public unsafe PipelineDraweeController (global::Android.Content.Res.Resources resources, global::Com.Facebook.Drawee.Components.DeferredReleaser deferredReleaser, global::Com.Facebook.Imagepipeline.Drawable.IDrawableFactory animatedDrawableFactory, global::Java.Util.Concurrent.IExecutor uiThreadExecutor, global::Com.Facebook.Imagepipeline.Cache.IMemoryCache memoryCache, global::Com.Facebook.Common.Internal.ImmutableList globalDrawableFactories)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Landroid/content/res/Resources;Lcom/facebook/drawee/components/DeferredReleaser;Lcom/facebook/imagepipeline/drawable/DrawableFactory;Ljava/util/concurrent/Executor;Lcom/facebook/imagepipeline/cache/MemoryCache;Lcom/facebook/common/internal/ImmutableList;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [6];
				__args [0] = new JniArgumentValue ((resources == null) ? IntPtr.Zero : ((global::Java.Lang.Object) resources).Handle);
				__args [1] = new JniArgumentValue ((deferredReleaser == null) ? IntPtr.Zero : ((global::Java.Lang.Object) deferredReleaser).Handle);
				__args [2] = new JniArgumentValue ((animatedDrawableFactory == null) ? IntPtr.Zero : ((global::Java.Lang.Object) animatedDrawableFactory).Handle);
				__args [3] = new JniArgumentValue ((uiThreadExecutor == null) ? IntPtr.Zero : ((global::Java.Lang.Object) uiThreadExecutor).Handle);
				__args [4] = new JniArgumentValue ((memoryCache == null) ? IntPtr.Zero : ((global::Java.Lang.Object) memoryCache).Handle);
				__args [5] = new JniArgumentValue ((globalDrawableFactories == null) ? IntPtr.Zero : ((global::Java.Lang.Object) globalDrawableFactories).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_getCacheKey;
#pragma warning disable 0169
		static Delegate GetGetCacheKeyHandler ()
		{
			if (cb_getCacheKey == null)
				cb_getCacheKey = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetCacheKey);
			return cb_getCacheKey;
		}

		static IntPtr n_GetCacheKey (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Facebook.Drawee.Backends.Pipeline.PipelineDraweeController __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Drawee.Backends.Pipeline.PipelineDraweeController> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.CacheKey);
		}
#pragma warning restore 0169

		protected virtual unsafe global::Com.Facebook.Cache.Common.ICacheKey CacheKey {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.drawee.backends.pipeline']/class[@name='PipelineDraweeController']/method[@name='getCacheKey' and count(parameter)=0]"
			[Register ("getCacheKey", "()Lcom/facebook/cache/common/CacheKey;", "GetGetCacheKeyHandler")]
			get {
				const string __id = "getCacheKey.()Lcom/facebook/cache/common/CacheKey;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Facebook.Cache.Common.ICacheKey> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getDataSource;
#pragma warning disable 0169
		static Delegate GetGetDataSourceHandler ()
		{
			if (cb_getDataSource == null)
				cb_getDataSource = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetDataSource);
			return cb_getDataSource;
		}

		static IntPtr n_GetDataSource (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Facebook.Drawee.Backends.Pipeline.PipelineDraweeController __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Drawee.Backends.Pipeline.PipelineDraweeController> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.DataSource);
		}
#pragma warning restore 0169

		protected override unsafe global::Com.Facebook.Datasource.IDataSource DataSource {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.drawee.backends.pipeline']/class[@name='PipelineDraweeController']/method[@name='getDataSource' and count(parameter)=0]"
			[Register ("getDataSource", "()Lcom/facebook/datasource/DataSource;", "GetGetDataSourceHandler")]
			get {
				const string __id = "getDataSource.()Lcom/facebook/datasource/DataSource;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Facebook.Datasource.IDataSource> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getDataSourceSupplier;
#pragma warning disable 0169
		static Delegate GetGetDataSourceSupplierHandler ()
		{
			if (cb_getDataSourceSupplier == null)
				cb_getDataSourceSupplier = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetDataSourceSupplier);
			return cb_getDataSourceSupplier;
		}

		static IntPtr n_GetDataSourceSupplier (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Facebook.Drawee.Backends.Pipeline.PipelineDraweeController __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Drawee.Backends.Pipeline.PipelineDraweeController> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.DataSourceSupplier);
		}
#pragma warning restore 0169

		protected virtual unsafe global::Com.Facebook.Common.Internal.ISupplier DataSourceSupplier {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.drawee.backends.pipeline']/class[@name='PipelineDraweeController']/method[@name='getDataSourceSupplier' and count(parameter)=0]"
			[Register ("getDataSourceSupplier", "()Lcom/facebook/common/internal/Supplier;", "GetGetDataSourceSupplierHandler")]
			get {
				const string __id = "getDataSourceSupplier.()Lcom/facebook/common/internal/Supplier;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Facebook.Common.Internal.ISupplier> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getRequestListener;
#pragma warning disable 0169
		static Delegate GetGetRequestListenerHandler ()
		{
			if (cb_getRequestListener == null)
				cb_getRequestListener = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetRequestListener);
			return cb_getRequestListener;
		}

		static IntPtr n_GetRequestListener (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Facebook.Drawee.Backends.Pipeline.PipelineDraweeController __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Drawee.Backends.Pipeline.PipelineDraweeController> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.RequestListener);
		}
#pragma warning restore 0169

		public virtual unsafe global::Com.Facebook.Imagepipeline.Listener.IRequestListener RequestListener {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.drawee.backends.pipeline']/class[@name='PipelineDraweeController']/method[@name='getRequestListener' and count(parameter)=0]"
			[Register ("getRequestListener", "()Lcom/facebook/imagepipeline/listener/RequestListener;", "GetGetRequestListenerHandler")]
			get {
				const string __id = "getRequestListener.()Lcom/facebook/imagepipeline/listener/RequestListener;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Facebook.Imagepipeline.Listener.IRequestListener> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getResources;
#pragma warning disable 0169
		static Delegate GetGetResourcesHandler ()
		{
			if (cb_getResources == null)
				cb_getResources = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetResources);
			return cb_getResources;
		}

		static IntPtr n_GetResources (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Facebook.Drawee.Backends.Pipeline.PipelineDraweeController __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Drawee.Backends.Pipeline.PipelineDraweeController> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Resources);
		}
#pragma warning restore 0169

		protected virtual unsafe global::Android.Content.Res.Resources Resources {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.drawee.backends.pipeline']/class[@name='PipelineDraweeController']/method[@name='getResources' and count(parameter)=0]"
			[Register ("getResources", "()Landroid/content/res/Resources;", "GetGetResourcesHandler")]
			get {
				const string __id = "getResources.()Landroid/content/res/Resources;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Android.Content.Res.Resources> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
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

		static void n_AddImageOriginListener_Lcom_facebook_drawee_backends_pipeline_info_ImageOriginListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_imageOriginListener)
		{
			global::Com.Facebook.Drawee.Backends.Pipeline.PipelineDraweeController __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Drawee.Backends.Pipeline.PipelineDraweeController> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Facebook.Drawee.Backends.Pipeline.Info.IImageOriginListener imageOriginListener = (global::Com.Facebook.Drawee.Backends.Pipeline.Info.IImageOriginListener)global::Java.Lang.Object.GetObject<global::Com.Facebook.Drawee.Backends.Pipeline.Info.IImageOriginListener> (native_imageOriginListener, JniHandleOwnership.DoNotTransfer);
			__this.AddImageOriginListener (imageOriginListener);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.drawee.backends.pipeline']/class[@name='PipelineDraweeController']/method[@name='addImageOriginListener' and count(parameter)=1 and parameter[1][@type='com.facebook.drawee.backends.pipeline.info.ImageOriginListener']]"
		[Register ("addImageOriginListener", "(Lcom/facebook/drawee/backends/pipeline/info/ImageOriginListener;)V", "GetAddImageOriginListener_Lcom_facebook_drawee_backends_pipeline_info_ImageOriginListener_Handler")]
		public virtual unsafe void AddImageOriginListener (global::Com.Facebook.Drawee.Backends.Pipeline.Info.IImageOriginListener imageOriginListener)
		{
			const string __id = "addImageOriginListener.(Lcom/facebook/drawee/backends/pipeline/info/ImageOriginListener;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((imageOriginListener == null) ? IntPtr.Zero : ((global::Java.Lang.Object) imageOriginListener).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_addRequestListener_Lcom_facebook_imagepipeline_listener_RequestListener_;
#pragma warning disable 0169
		static Delegate GetAddRequestListener_Lcom_facebook_imagepipeline_listener_RequestListener_Handler ()
		{
			if (cb_addRequestListener_Lcom_facebook_imagepipeline_listener_RequestListener_ == null)
				cb_addRequestListener_Lcom_facebook_imagepipeline_listener_RequestListener_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_AddRequestListener_Lcom_facebook_imagepipeline_listener_RequestListener_);
			return cb_addRequestListener_Lcom_facebook_imagepipeline_listener_RequestListener_;
		}

		static void n_AddRequestListener_Lcom_facebook_imagepipeline_listener_RequestListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_requestListener)
		{
			global::Com.Facebook.Drawee.Backends.Pipeline.PipelineDraweeController __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Drawee.Backends.Pipeline.PipelineDraweeController> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Facebook.Imagepipeline.Listener.IRequestListener requestListener = (global::Com.Facebook.Imagepipeline.Listener.IRequestListener)global::Java.Lang.Object.GetObject<global::Com.Facebook.Imagepipeline.Listener.IRequestListener> (native_requestListener, JniHandleOwnership.DoNotTransfer);
			__this.AddRequestListener (requestListener);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.drawee.backends.pipeline']/class[@name='PipelineDraweeController']/method[@name='addRequestListener' and count(parameter)=1 and parameter[1][@type='com.facebook.imagepipeline.listener.RequestListener']]"
		[Register ("addRequestListener", "(Lcom/facebook/imagepipeline/listener/RequestListener;)V", "GetAddRequestListener_Lcom_facebook_imagepipeline_listener_RequestListener_Handler")]
		public virtual unsafe void AddRequestListener (global::Com.Facebook.Imagepipeline.Listener.IRequestListener requestListener)
		{
			const string __id = "addRequestListener.(Lcom/facebook/imagepipeline/listener/RequestListener;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((requestListener == null) ? IntPtr.Zero : ((global::Java.Lang.Object) requestListener).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_clearImageOriginListeners;
#pragma warning disable 0169
		static Delegate GetClearImageOriginListenersHandler ()
		{
			if (cb_clearImageOriginListeners == null)
				cb_clearImageOriginListeners = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_ClearImageOriginListeners);
			return cb_clearImageOriginListeners;
		}

		static void n_ClearImageOriginListeners (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Facebook.Drawee.Backends.Pipeline.PipelineDraweeController __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Drawee.Backends.Pipeline.PipelineDraweeController> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ClearImageOriginListeners ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.drawee.backends.pipeline']/class[@name='PipelineDraweeController']/method[@name='clearImageOriginListeners' and count(parameter)=0]"
		[Register ("clearImageOriginListeners", "()V", "GetClearImageOriginListenersHandler")]
		protected virtual unsafe void ClearImageOriginListeners ()
		{
			const string __id = "clearImageOriginListeners.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_getImageHash_Lcom_facebook_common_references_CloseableReference_;
#pragma warning disable 0169
		static Delegate GetGetImageHash_Lcom_facebook_common_references_CloseableReference_Handler ()
		{
			if (cb_getImageHash_Lcom_facebook_common_references_CloseableReference_ == null)
				cb_getImageHash_Lcom_facebook_common_references_CloseableReference_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, int>) n_GetImageHash_Lcom_facebook_common_references_CloseableReference_);
			return cb_getImageHash_Lcom_facebook_common_references_CloseableReference_;
		}

		static int n_GetImageHash_Lcom_facebook_common_references_CloseableReference_ (IntPtr jnienv, IntPtr native__this, IntPtr native_image)
		{
			global::Com.Facebook.Drawee.Backends.Pipeline.PipelineDraweeController __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Drawee.Backends.Pipeline.PipelineDraweeController> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Facebook.Common.References.CloseableReference image = global::Java.Lang.Object.GetObject<global::Com.Facebook.Common.References.CloseableReference> (native_image, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.GetImageHash (image);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.drawee.backends.pipeline']/class[@name='PipelineDraweeController']/method[@name='getImageHash' and count(parameter)=1 and parameter[1][@type='com.facebook.common.references.CloseableReference&lt;com.facebook.imagepipeline.image.CloseableImage&gt;']]"
		[Register ("getImageHash", "(Lcom/facebook/common/references/CloseableReference;)I", "GetGetImageHash_Lcom_facebook_common_references_CloseableReference_Handler")]
		protected virtual unsafe int GetImageHash (global::Com.Facebook.Common.References.CloseableReference image)
		{
			const string __id = "getImageHash.(Lcom/facebook/common/references/CloseableReference;)I";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((image == null) ? IntPtr.Zero : ((global::Java.Lang.Object) image).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, __args);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_initialize_Lcom_facebook_common_internal_Supplier_Ljava_lang_String_Lcom_facebook_cache_common_CacheKey_Ljava_lang_Object_Lcom_facebook_common_internal_ImmutableList_Lcom_facebook_drawee_backends_pipeline_info_ImageOriginListener_;
#pragma warning disable 0169
		static Delegate GetInitialize_Lcom_facebook_common_internal_Supplier_Ljava_lang_String_Lcom_facebook_cache_common_CacheKey_Ljava_lang_Object_Lcom_facebook_common_internal_ImmutableList_Lcom_facebook_drawee_backends_pipeline_info_ImageOriginListener_Handler ()
		{
			if (cb_initialize_Lcom_facebook_common_internal_Supplier_Ljava_lang_String_Lcom_facebook_cache_common_CacheKey_Ljava_lang_Object_Lcom_facebook_common_internal_ImmutableList_Lcom_facebook_drawee_backends_pipeline_info_ImageOriginListener_ == null)
				cb_initialize_Lcom_facebook_common_internal_Supplier_Ljava_lang_String_Lcom_facebook_cache_common_CacheKey_Ljava_lang_Object_Lcom_facebook_common_internal_ImmutableList_Lcom_facebook_drawee_backends_pipeline_info_ImageOriginListener_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_Initialize_Lcom_facebook_common_internal_Supplier_Ljava_lang_String_Lcom_facebook_cache_common_CacheKey_Ljava_lang_Object_Lcom_facebook_common_internal_ImmutableList_Lcom_facebook_drawee_backends_pipeline_info_ImageOriginListener_);
			return cb_initialize_Lcom_facebook_common_internal_Supplier_Ljava_lang_String_Lcom_facebook_cache_common_CacheKey_Ljava_lang_Object_Lcom_facebook_common_internal_ImmutableList_Lcom_facebook_drawee_backends_pipeline_info_ImageOriginListener_;
		}

		static void n_Initialize_Lcom_facebook_common_internal_Supplier_Ljava_lang_String_Lcom_facebook_cache_common_CacheKey_Ljava_lang_Object_Lcom_facebook_common_internal_ImmutableList_Lcom_facebook_drawee_backends_pipeline_info_ImageOriginListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_dataSourceSupplier, IntPtr native_id, IntPtr native_cacheKey, IntPtr native_callerContext, IntPtr native_customDrawableFactories, IntPtr native_imageOriginListener)
		{
			global::Com.Facebook.Drawee.Backends.Pipeline.PipelineDraweeController __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Drawee.Backends.Pipeline.PipelineDraweeController> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Facebook.Common.Internal.ISupplier dataSourceSupplier = (global::Com.Facebook.Common.Internal.ISupplier)global::Java.Lang.Object.GetObject<global::Com.Facebook.Common.Internal.ISupplier> (native_dataSourceSupplier, JniHandleOwnership.DoNotTransfer);
			string id = JNIEnv.GetString (native_id, JniHandleOwnership.DoNotTransfer);
			global::Com.Facebook.Cache.Common.ICacheKey cacheKey = (global::Com.Facebook.Cache.Common.ICacheKey)global::Java.Lang.Object.GetObject<global::Com.Facebook.Cache.Common.ICacheKey> (native_cacheKey, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object callerContext = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_callerContext, JniHandleOwnership.DoNotTransfer);
			global::Com.Facebook.Common.Internal.ImmutableList customDrawableFactories = global::Java.Lang.Object.GetObject<global::Com.Facebook.Common.Internal.ImmutableList> (native_customDrawableFactories, JniHandleOwnership.DoNotTransfer);
			global::Com.Facebook.Drawee.Backends.Pipeline.Info.IImageOriginListener imageOriginListener = (global::Com.Facebook.Drawee.Backends.Pipeline.Info.IImageOriginListener)global::Java.Lang.Object.GetObject<global::Com.Facebook.Drawee.Backends.Pipeline.Info.IImageOriginListener> (native_imageOriginListener, JniHandleOwnership.DoNotTransfer);
			__this.Initialize (dataSourceSupplier, id, cacheKey, callerContext, customDrawableFactories, imageOriginListener);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.drawee.backends.pipeline']/class[@name='PipelineDraweeController']/method[@name='initialize' and count(parameter)=6 and parameter[1][@type='com.facebook.common.internal.Supplier&lt;com.facebook.datasource.DataSource&lt;com.facebook.common.references.CloseableReference&lt;com.facebook.imagepipeline.image.CloseableImage&gt;&gt;&gt;'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='com.facebook.cache.common.CacheKey'] and parameter[4][@type='java.lang.Object'] and parameter[5][@type='com.facebook.common.internal.ImmutableList&lt;com.facebook.imagepipeline.drawable.DrawableFactory&gt;'] and parameter[6][@type='com.facebook.drawee.backends.pipeline.info.ImageOriginListener']]"
		[Register ("initialize", "(Lcom/facebook/common/internal/Supplier;Ljava/lang/String;Lcom/facebook/cache/common/CacheKey;Ljava/lang/Object;Lcom/facebook/common/internal/ImmutableList;Lcom/facebook/drawee/backends/pipeline/info/ImageOriginListener;)V", "GetInitialize_Lcom_facebook_common_internal_Supplier_Ljava_lang_String_Lcom_facebook_cache_common_CacheKey_Ljava_lang_Object_Lcom_facebook_common_internal_ImmutableList_Lcom_facebook_drawee_backends_pipeline_info_ImageOriginListener_Handler")]
		public virtual unsafe void Initialize (global::Com.Facebook.Common.Internal.ISupplier dataSourceSupplier, string id, global::Com.Facebook.Cache.Common.ICacheKey cacheKey, global::Java.Lang.Object callerContext, global::Com.Facebook.Common.Internal.ImmutableList customDrawableFactories, global::Com.Facebook.Drawee.Backends.Pipeline.Info.IImageOriginListener imageOriginListener)
		{
			const string __id = "initialize.(Lcom/facebook/common/internal/Supplier;Ljava/lang/String;Lcom/facebook/cache/common/CacheKey;Ljava/lang/Object;Lcom/facebook/common/internal/ImmutableList;Lcom/facebook/drawee/backends/pipeline/info/ImageOriginListener;)V";
			IntPtr native_id = JNIEnv.NewString (id);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [6];
				__args [0] = new JniArgumentValue ((dataSourceSupplier == null) ? IntPtr.Zero : ((global::Java.Lang.Object) dataSourceSupplier).Handle);
				__args [1] = new JniArgumentValue (native_id);
				__args [2] = new JniArgumentValue ((cacheKey == null) ? IntPtr.Zero : ((global::Java.Lang.Object) cacheKey).Handle);
				__args [3] = new JniArgumentValue ((callerContext == null) ? IntPtr.Zero : ((global::Java.Lang.Object) callerContext).Handle);
				__args [4] = new JniArgumentValue ((customDrawableFactories == null) ? IntPtr.Zero : ((global::Java.Lang.Object) customDrawableFactories).Handle);
				__args [5] = new JniArgumentValue ((imageOriginListener == null) ? IntPtr.Zero : ((global::Java.Lang.Object) imageOriginListener).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_id);
			}
		}

		static Delegate cb_initializePerformanceMonitoring_Lcom_facebook_drawee_backends_pipeline_info_ImagePerfDataListener_;
#pragma warning disable 0169
		static Delegate GetInitializePerformanceMonitoring_Lcom_facebook_drawee_backends_pipeline_info_ImagePerfDataListener_Handler ()
		{
			if (cb_initializePerformanceMonitoring_Lcom_facebook_drawee_backends_pipeline_info_ImagePerfDataListener_ == null)
				cb_initializePerformanceMonitoring_Lcom_facebook_drawee_backends_pipeline_info_ImagePerfDataListener_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_InitializePerformanceMonitoring_Lcom_facebook_drawee_backends_pipeline_info_ImagePerfDataListener_);
			return cb_initializePerformanceMonitoring_Lcom_facebook_drawee_backends_pipeline_info_ImagePerfDataListener_;
		}

		static void n_InitializePerformanceMonitoring_Lcom_facebook_drawee_backends_pipeline_info_ImagePerfDataListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_imagePerfDataListener)
		{
			global::Com.Facebook.Drawee.Backends.Pipeline.PipelineDraweeController __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Drawee.Backends.Pipeline.PipelineDraweeController> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Facebook.Drawee.Backends.Pipeline.Info.IImagePerfDataListener imagePerfDataListener = (global::Com.Facebook.Drawee.Backends.Pipeline.Info.IImagePerfDataListener)global::Java.Lang.Object.GetObject<global::Com.Facebook.Drawee.Backends.Pipeline.Info.IImagePerfDataListener> (native_imagePerfDataListener, JniHandleOwnership.DoNotTransfer);
			__this.InitializePerformanceMonitoring (imagePerfDataListener);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.drawee.backends.pipeline']/class[@name='PipelineDraweeController']/method[@name='initializePerformanceMonitoring' and count(parameter)=1 and parameter[1][@type='com.facebook.drawee.backends.pipeline.info.ImagePerfDataListener']]"
		[Register ("initializePerformanceMonitoring", "(Lcom/facebook/drawee/backends/pipeline/info/ImagePerfDataListener;)V", "GetInitializePerformanceMonitoring_Lcom_facebook_drawee_backends_pipeline_info_ImagePerfDataListener_Handler")]
		protected virtual unsafe void InitializePerformanceMonitoring (global::Com.Facebook.Drawee.Backends.Pipeline.Info.IImagePerfDataListener imagePerfDataListener)
		{
			const string __id = "initializePerformanceMonitoring.(Lcom/facebook/drawee/backends/pipeline/info/ImagePerfDataListener;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((imagePerfDataListener == null) ? IntPtr.Zero : ((global::Java.Lang.Object) imagePerfDataListener).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_isSameImageRequest_Lcom_facebook_drawee_interfaces_DraweeController_;
#pragma warning disable 0169
		static Delegate GetIsSameImageRequest_Lcom_facebook_drawee_interfaces_DraweeController_Handler ()
		{
			if (cb_isSameImageRequest_Lcom_facebook_drawee_interfaces_DraweeController_ == null)
				cb_isSameImageRequest_Lcom_facebook_drawee_interfaces_DraweeController_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_IsSameImageRequest_Lcom_facebook_drawee_interfaces_DraweeController_);
			return cb_isSameImageRequest_Lcom_facebook_drawee_interfaces_DraweeController_;
		}

		static bool n_IsSameImageRequest_Lcom_facebook_drawee_interfaces_DraweeController_ (IntPtr jnienv, IntPtr native__this, IntPtr native_other)
		{
			global::Com.Facebook.Drawee.Backends.Pipeline.PipelineDraweeController __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Drawee.Backends.Pipeline.PipelineDraweeController> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Facebook.Drawee.Interfaces.IDraweeController other = (global::Com.Facebook.Drawee.Interfaces.IDraweeController)global::Java.Lang.Object.GetObject<global::Com.Facebook.Drawee.Interfaces.IDraweeController> (native_other, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.IsSameImageRequest (other);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.drawee.backends.pipeline']/class[@name='PipelineDraweeController']/method[@name='isSameImageRequest' and count(parameter)=1 and parameter[1][@type='com.facebook.drawee.interfaces.DraweeController']]"
		[Register ("isSameImageRequest", "(Lcom/facebook/drawee/interfaces/DraweeController;)Z", "GetIsSameImageRequest_Lcom_facebook_drawee_interfaces_DraweeController_Handler")]
		public override unsafe bool IsSameImageRequest (global::Com.Facebook.Drawee.Interfaces.IDraweeController other)
		{
			const string __id = "isSameImageRequest.(Lcom/facebook/drawee/interfaces/DraweeController;)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((other == null) ? IntPtr.Zero : ((global::Java.Lang.Object) other).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_onImageLoadedFromCacheImmediately_Ljava_lang_String_Lcom_facebook_common_references_CloseableReference_;
#pragma warning disable 0169
		static Delegate GetOnImageLoadedFromCacheImmediately_Ljava_lang_String_Lcom_facebook_common_references_CloseableReference_Handler ()
		{
			if (cb_onImageLoadedFromCacheImmediately_Ljava_lang_String_Lcom_facebook_common_references_CloseableReference_ == null)
				cb_onImageLoadedFromCacheImmediately_Ljava_lang_String_Lcom_facebook_common_references_CloseableReference_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_OnImageLoadedFromCacheImmediately_Ljava_lang_String_Lcom_facebook_common_references_CloseableReference_);
			return cb_onImageLoadedFromCacheImmediately_Ljava_lang_String_Lcom_facebook_common_references_CloseableReference_;
		}

		static void n_OnImageLoadedFromCacheImmediately_Ljava_lang_String_Lcom_facebook_common_references_CloseableReference_ (IntPtr jnienv, IntPtr native__this, IntPtr native_id, IntPtr native_cachedImage)
		{
			global::Com.Facebook.Drawee.Backends.Pipeline.PipelineDraweeController __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Drawee.Backends.Pipeline.PipelineDraweeController> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string id = JNIEnv.GetString (native_id, JniHandleOwnership.DoNotTransfer);
			global::Com.Facebook.Common.References.CloseableReference cachedImage = global::Java.Lang.Object.GetObject<global::Com.Facebook.Common.References.CloseableReference> (native_cachedImage, JniHandleOwnership.DoNotTransfer);
			__this.OnImageLoadedFromCacheImmediately (id, cachedImage);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.drawee.backends.pipeline']/class[@name='PipelineDraweeController']/method[@name='onImageLoadedFromCacheImmediately' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='com.facebook.common.references.CloseableReference&lt;com.facebook.imagepipeline.image.CloseableImage&gt;']]"
		[Register ("onImageLoadedFromCacheImmediately", "(Ljava/lang/String;Lcom/facebook/common/references/CloseableReference;)V", "GetOnImageLoadedFromCacheImmediately_Ljava_lang_String_Lcom_facebook_common_references_CloseableReference_Handler")]
		protected virtual unsafe void OnImageLoadedFromCacheImmediately (string id, global::Com.Facebook.Common.References.CloseableReference cachedImage)
		{
			const string __id = "onImageLoadedFromCacheImmediately.(Ljava/lang/String;Lcom/facebook/common/references/CloseableReference;)V";
			IntPtr native_id = JNIEnv.NewString (id);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_id);
				__args [1] = new JniArgumentValue ((cachedImage == null) ? IntPtr.Zero : ((global::Java.Lang.Object) cachedImage).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_id);
			}
		}

		static Delegate cb_releaseDrawable_Landroid_graphics_drawable_Drawable_;
#pragma warning disable 0169
		static Delegate GetReleaseDrawable_Landroid_graphics_drawable_Drawable_Handler ()
		{
			if (cb_releaseDrawable_Landroid_graphics_drawable_Drawable_ == null)
				cb_releaseDrawable_Landroid_graphics_drawable_Drawable_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_ReleaseDrawable_Landroid_graphics_drawable_Drawable_);
			return cb_releaseDrawable_Landroid_graphics_drawable_Drawable_;
		}

		static void n_ReleaseDrawable_Landroid_graphics_drawable_Drawable_ (IntPtr jnienv, IntPtr native__this, IntPtr native_drawable)
		{
			global::Com.Facebook.Drawee.Backends.Pipeline.PipelineDraweeController __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Drawee.Backends.Pipeline.PipelineDraweeController> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Graphics.Drawables.Drawable drawable = global::Java.Lang.Object.GetObject<global::Android.Graphics.Drawables.Drawable> (native_drawable, JniHandleOwnership.DoNotTransfer);
			__this.ReleaseDrawable (drawable);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.drawee.backends.pipeline']/class[@name='PipelineDraweeController']/method[@name='releaseDrawable' and count(parameter)=1 and parameter[1][@type='android.graphics.drawable.Drawable']]"
		[Register ("releaseDrawable", "(Landroid/graphics/drawable/Drawable;)V", "GetReleaseDrawable_Landroid_graphics_drawable_Drawable_Handler")]
		protected override unsafe void ReleaseDrawable (global::Android.Graphics.Drawables.Drawable drawable)
		{
			const string __id = "releaseDrawable.(Landroid/graphics/drawable/Drawable;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((drawable == null) ? IntPtr.Zero : ((global::Java.Lang.Object) drawable).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
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

		static void n_RemoveImageOriginListener_Lcom_facebook_drawee_backends_pipeline_info_ImageOriginListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_imageOriginListener)
		{
			global::Com.Facebook.Drawee.Backends.Pipeline.PipelineDraweeController __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Drawee.Backends.Pipeline.PipelineDraweeController> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Facebook.Drawee.Backends.Pipeline.Info.IImageOriginListener imageOriginListener = (global::Com.Facebook.Drawee.Backends.Pipeline.Info.IImageOriginListener)global::Java.Lang.Object.GetObject<global::Com.Facebook.Drawee.Backends.Pipeline.Info.IImageOriginListener> (native_imageOriginListener, JniHandleOwnership.DoNotTransfer);
			__this.RemoveImageOriginListener (imageOriginListener);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.drawee.backends.pipeline']/class[@name='PipelineDraweeController']/method[@name='removeImageOriginListener' and count(parameter)=1 and parameter[1][@type='com.facebook.drawee.backends.pipeline.info.ImageOriginListener']]"
		[Register ("removeImageOriginListener", "(Lcom/facebook/drawee/backends/pipeline/info/ImageOriginListener;)V", "GetRemoveImageOriginListener_Lcom_facebook_drawee_backends_pipeline_info_ImageOriginListener_Handler")]
		public virtual unsafe void RemoveImageOriginListener (global::Com.Facebook.Drawee.Backends.Pipeline.Info.IImageOriginListener imageOriginListener)
		{
			const string __id = "removeImageOriginListener.(Lcom/facebook/drawee/backends/pipeline/info/ImageOriginListener;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((imageOriginListener == null) ? IntPtr.Zero : ((global::Java.Lang.Object) imageOriginListener).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_removeRequestListener_Lcom_facebook_imagepipeline_listener_RequestListener_;
#pragma warning disable 0169
		static Delegate GetRemoveRequestListener_Lcom_facebook_imagepipeline_listener_RequestListener_Handler ()
		{
			if (cb_removeRequestListener_Lcom_facebook_imagepipeline_listener_RequestListener_ == null)
				cb_removeRequestListener_Lcom_facebook_imagepipeline_listener_RequestListener_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_RemoveRequestListener_Lcom_facebook_imagepipeline_listener_RequestListener_);
			return cb_removeRequestListener_Lcom_facebook_imagepipeline_listener_RequestListener_;
		}

		static void n_RemoveRequestListener_Lcom_facebook_imagepipeline_listener_RequestListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_requestListener)
		{
			global::Com.Facebook.Drawee.Backends.Pipeline.PipelineDraweeController __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Drawee.Backends.Pipeline.PipelineDraweeController> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Facebook.Imagepipeline.Listener.IRequestListener requestListener = (global::Com.Facebook.Imagepipeline.Listener.IRequestListener)global::Java.Lang.Object.GetObject<global::Com.Facebook.Imagepipeline.Listener.IRequestListener> (native_requestListener, JniHandleOwnership.DoNotTransfer);
			__this.RemoveRequestListener (requestListener);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.drawee.backends.pipeline']/class[@name='PipelineDraweeController']/method[@name='removeRequestListener' and count(parameter)=1 and parameter[1][@type='com.facebook.imagepipeline.listener.RequestListener']]"
		[Register ("removeRequestListener", "(Lcom/facebook/imagepipeline/listener/RequestListener;)V", "GetRemoveRequestListener_Lcom_facebook_imagepipeline_listener_RequestListener_Handler")]
		public virtual unsafe void RemoveRequestListener (global::Com.Facebook.Imagepipeline.Listener.IRequestListener requestListener)
		{
			const string __id = "removeRequestListener.(Lcom/facebook/imagepipeline/listener/RequestListener;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((requestListener == null) ? IntPtr.Zero : ((global::Java.Lang.Object) requestListener).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_setCustomDrawableFactories_Lcom_facebook_common_internal_ImmutableList_;
#pragma warning disable 0169
		static Delegate GetSetCustomDrawableFactories_Lcom_facebook_common_internal_ImmutableList_Handler ()
		{
			if (cb_setCustomDrawableFactories_Lcom_facebook_common_internal_ImmutableList_ == null)
				cb_setCustomDrawableFactories_Lcom_facebook_common_internal_ImmutableList_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetCustomDrawableFactories_Lcom_facebook_common_internal_ImmutableList_);
			return cb_setCustomDrawableFactories_Lcom_facebook_common_internal_ImmutableList_;
		}

		static void n_SetCustomDrawableFactories_Lcom_facebook_common_internal_ImmutableList_ (IntPtr jnienv, IntPtr native__this, IntPtr native_customDrawableFactories)
		{
			global::Com.Facebook.Drawee.Backends.Pipeline.PipelineDraweeController __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Drawee.Backends.Pipeline.PipelineDraweeController> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Facebook.Common.Internal.ImmutableList customDrawableFactories = global::Java.Lang.Object.GetObject<global::Com.Facebook.Common.Internal.ImmutableList> (native_customDrawableFactories, JniHandleOwnership.DoNotTransfer);
			__this.SetCustomDrawableFactories (customDrawableFactories);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.drawee.backends.pipeline']/class[@name='PipelineDraweeController']/method[@name='setCustomDrawableFactories' and count(parameter)=1 and parameter[1][@type='com.facebook.common.internal.ImmutableList&lt;com.facebook.imagepipeline.drawable.DrawableFactory&gt;']]"
		[Register ("setCustomDrawableFactories", "(Lcom/facebook/common/internal/ImmutableList;)V", "GetSetCustomDrawableFactories_Lcom_facebook_common_internal_ImmutableList_Handler")]
		public virtual unsafe void SetCustomDrawableFactories (global::Com.Facebook.Common.Internal.ImmutableList customDrawableFactories)
		{
			const string __id = "setCustomDrawableFactories.(Lcom/facebook/common/internal/ImmutableList;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((customDrawableFactories == null) ? IntPtr.Zero : ((global::Java.Lang.Object) customDrawableFactories).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_setDrawDebugOverlay_Z;
#pragma warning disable 0169
		static Delegate GetSetDrawDebugOverlay_ZHandler ()
		{
			if (cb_setDrawDebugOverlay_Z == null)
				cb_setDrawDebugOverlay_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_SetDrawDebugOverlay_Z);
			return cb_setDrawDebugOverlay_Z;
		}

		static void n_SetDrawDebugOverlay_Z (IntPtr jnienv, IntPtr native__this, bool drawDebugOverlay)
		{
			global::Com.Facebook.Drawee.Backends.Pipeline.PipelineDraweeController __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Drawee.Backends.Pipeline.PipelineDraweeController> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetDrawDebugOverlay (drawDebugOverlay);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.drawee.backends.pipeline']/class[@name='PipelineDraweeController']/method[@name='setDrawDebugOverlay' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("setDrawDebugOverlay", "(Z)V", "GetSetDrawDebugOverlay_ZHandler")]
		public virtual unsafe void SetDrawDebugOverlay (bool drawDebugOverlay)
		{
			const string __id = "setDrawDebugOverlay.(Z)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (drawDebugOverlay);
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
