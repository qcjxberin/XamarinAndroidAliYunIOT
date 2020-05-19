using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Facebook.Drawee.Backends.Pipeline {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.facebook.drawee.backends.pipeline']/class[@name='DraweeConfig']"
	[global::Android.Runtime.Register ("com/facebook/drawee/backends/pipeline/DraweeConfig", DoNotGenerateAcw=true)]
	public partial class DraweeConfig : global::Java.Lang.Object {

		// Metadata.xml XPath class reference: path="/api/package[@name='com.facebook.drawee.backends.pipeline']/class[@name='DraweeConfig.Builder']"
		[global::Android.Runtime.Register ("com/facebook/drawee/backends/pipeline/DraweeConfig$Builder", DoNotGenerateAcw=true)]
		public partial class Builder : global::Java.Lang.Object {

			static readonly JniPeerMembers _members = new XAPeerMembers ("com/facebook/drawee/backends/pipeline/DraweeConfig$Builder", typeof (Builder));
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

			protected Builder (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.facebook.drawee.backends.pipeline']/class[@name='DraweeConfig.Builder']/constructor[@name='DraweeConfig.Builder' and count(parameter)=0]"
			[Register (".ctor", "()V", "")]
			public unsafe Builder ()
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

			static Delegate cb_addCustomDrawableFactory_Lcom_facebook_imagepipeline_drawable_DrawableFactory_;
#pragma warning disable 0169
			static Delegate GetAddCustomDrawableFactory_Lcom_facebook_imagepipeline_drawable_DrawableFactory_Handler ()
			{
				if (cb_addCustomDrawableFactory_Lcom_facebook_imagepipeline_drawable_DrawableFactory_ == null)
					cb_addCustomDrawableFactory_Lcom_facebook_imagepipeline_drawable_DrawableFactory_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_AddCustomDrawableFactory_Lcom_facebook_imagepipeline_drawable_DrawableFactory_);
				return cb_addCustomDrawableFactory_Lcom_facebook_imagepipeline_drawable_DrawableFactory_;
			}

			static IntPtr n_AddCustomDrawableFactory_Lcom_facebook_imagepipeline_drawable_DrawableFactory_ (IntPtr jnienv, IntPtr native__this, IntPtr native_factory)
			{
				global::Com.Facebook.Drawee.Backends.Pipeline.DraweeConfig.Builder __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Drawee.Backends.Pipeline.DraweeConfig.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Com.Facebook.Imagepipeline.Drawable.IDrawableFactory factory = (global::Com.Facebook.Imagepipeline.Drawable.IDrawableFactory)global::Java.Lang.Object.GetObject<global::Com.Facebook.Imagepipeline.Drawable.IDrawableFactory> (native_factory, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.AddCustomDrawableFactory (factory));
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.drawee.backends.pipeline']/class[@name='DraweeConfig.Builder']/method[@name='addCustomDrawableFactory' and count(parameter)=1 and parameter[1][@type='com.facebook.imagepipeline.drawable.DrawableFactory']]"
			[Register ("addCustomDrawableFactory", "(Lcom/facebook/imagepipeline/drawable/DrawableFactory;)Lcom/facebook/drawee/backends/pipeline/DraweeConfig$Builder;", "GetAddCustomDrawableFactory_Lcom_facebook_imagepipeline_drawable_DrawableFactory_Handler")]
			public virtual unsafe global::Com.Facebook.Drawee.Backends.Pipeline.DraweeConfig.Builder AddCustomDrawableFactory (global::Com.Facebook.Imagepipeline.Drawable.IDrawableFactory factory)
			{
				const string __id = "addCustomDrawableFactory.(Lcom/facebook/imagepipeline/drawable/DrawableFactory;)Lcom/facebook/drawee/backends/pipeline/DraweeConfig$Builder;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((factory == null) ? IntPtr.Zero : ((global::Java.Lang.Object) factory).Handle);
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Facebook.Drawee.Backends.Pipeline.DraweeConfig.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			static Delegate cb_build;
#pragma warning disable 0169
			static Delegate GetBuildHandler ()
			{
				if (cb_build == null)
					cb_build = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_Build);
				return cb_build;
			}

			static IntPtr n_Build (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Facebook.Drawee.Backends.Pipeline.DraweeConfig.Builder __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Drawee.Backends.Pipeline.DraweeConfig.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.Build ());
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.drawee.backends.pipeline']/class[@name='DraweeConfig.Builder']/method[@name='build' and count(parameter)=0]"
			[Register ("build", "()Lcom/facebook/drawee/backends/pipeline/DraweeConfig;", "GetBuildHandler")]
			public virtual unsafe global::Com.Facebook.Drawee.Backends.Pipeline.DraweeConfig Build ()
			{
				const string __id = "build.()Lcom/facebook/drawee/backends/pipeline/DraweeConfig;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Facebook.Drawee.Backends.Pipeline.DraweeConfig> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			static Delegate cb_setDebugOverlayEnabledSupplier_Lcom_facebook_common_internal_Supplier_;
#pragma warning disable 0169
			static Delegate GetSetDebugOverlayEnabledSupplier_Lcom_facebook_common_internal_Supplier_Handler ()
			{
				if (cb_setDebugOverlayEnabledSupplier_Lcom_facebook_common_internal_Supplier_ == null)
					cb_setDebugOverlayEnabledSupplier_Lcom_facebook_common_internal_Supplier_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_SetDebugOverlayEnabledSupplier_Lcom_facebook_common_internal_Supplier_);
				return cb_setDebugOverlayEnabledSupplier_Lcom_facebook_common_internal_Supplier_;
			}

			static IntPtr n_SetDebugOverlayEnabledSupplier_Lcom_facebook_common_internal_Supplier_ (IntPtr jnienv, IntPtr native__this, IntPtr native_debugOverlayEnabledSupplier)
			{
				global::Com.Facebook.Drawee.Backends.Pipeline.DraweeConfig.Builder __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Drawee.Backends.Pipeline.DraweeConfig.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Com.Facebook.Common.Internal.ISupplier debugOverlayEnabledSupplier = (global::Com.Facebook.Common.Internal.ISupplier)global::Java.Lang.Object.GetObject<global::Com.Facebook.Common.Internal.ISupplier> (native_debugOverlayEnabledSupplier, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetDebugOverlayEnabledSupplier (debugOverlayEnabledSupplier));
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.drawee.backends.pipeline']/class[@name='DraweeConfig.Builder']/method[@name='setDebugOverlayEnabledSupplier' and count(parameter)=1 and parameter[1][@type='com.facebook.common.internal.Supplier&lt;java.lang.Boolean&gt;']]"
			[Register ("setDebugOverlayEnabledSupplier", "(Lcom/facebook/common/internal/Supplier;)Lcom/facebook/drawee/backends/pipeline/DraweeConfig$Builder;", "GetSetDebugOverlayEnabledSupplier_Lcom_facebook_common_internal_Supplier_Handler")]
			public virtual unsafe global::Com.Facebook.Drawee.Backends.Pipeline.DraweeConfig.Builder SetDebugOverlayEnabledSupplier (global::Com.Facebook.Common.Internal.ISupplier debugOverlayEnabledSupplier)
			{
				const string __id = "setDebugOverlayEnabledSupplier.(Lcom/facebook/common/internal/Supplier;)Lcom/facebook/drawee/backends/pipeline/DraweeConfig$Builder;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((debugOverlayEnabledSupplier == null) ? IntPtr.Zero : ((global::Java.Lang.Object) debugOverlayEnabledSupplier).Handle);
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Facebook.Drawee.Backends.Pipeline.DraweeConfig.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			static Delegate cb_setDrawDebugOverlay_Z;
#pragma warning disable 0169
			static Delegate GetSetDrawDebugOverlay_ZHandler ()
			{
				if (cb_setDrawDebugOverlay_Z == null)
					cb_setDrawDebugOverlay_Z = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool, IntPtr>) n_SetDrawDebugOverlay_Z);
				return cb_setDrawDebugOverlay_Z;
			}

			static IntPtr n_SetDrawDebugOverlay_Z (IntPtr jnienv, IntPtr native__this, bool drawDebugOverlay)
			{
				global::Com.Facebook.Drawee.Backends.Pipeline.DraweeConfig.Builder __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Drawee.Backends.Pipeline.DraweeConfig.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.SetDrawDebugOverlay (drawDebugOverlay));
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.drawee.backends.pipeline']/class[@name='DraweeConfig.Builder']/method[@name='setDrawDebugOverlay' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setDrawDebugOverlay", "(Z)Lcom/facebook/drawee/backends/pipeline/DraweeConfig$Builder;", "GetSetDrawDebugOverlay_ZHandler")]
			public virtual unsafe global::Com.Facebook.Drawee.Backends.Pipeline.DraweeConfig.Builder SetDrawDebugOverlay (bool drawDebugOverlay)
			{
				const string __id = "setDrawDebugOverlay.(Z)Lcom/facebook/drawee/backends/pipeline/DraweeConfig$Builder;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (drawDebugOverlay);
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Facebook.Drawee.Backends.Pipeline.DraweeConfig.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			static Delegate cb_setPipelineDraweeControllerFactory_Lcom_facebook_drawee_backends_pipeline_PipelineDraweeControllerFactory_;
#pragma warning disable 0169
			static Delegate GetSetPipelineDraweeControllerFactory_Lcom_facebook_drawee_backends_pipeline_PipelineDraweeControllerFactory_Handler ()
			{
				if (cb_setPipelineDraweeControllerFactory_Lcom_facebook_drawee_backends_pipeline_PipelineDraweeControllerFactory_ == null)
					cb_setPipelineDraweeControllerFactory_Lcom_facebook_drawee_backends_pipeline_PipelineDraweeControllerFactory_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_SetPipelineDraweeControllerFactory_Lcom_facebook_drawee_backends_pipeline_PipelineDraweeControllerFactory_);
				return cb_setPipelineDraweeControllerFactory_Lcom_facebook_drawee_backends_pipeline_PipelineDraweeControllerFactory_;
			}

			static IntPtr n_SetPipelineDraweeControllerFactory_Lcom_facebook_drawee_backends_pipeline_PipelineDraweeControllerFactory_ (IntPtr jnienv, IntPtr native__this, IntPtr native_factory)
			{
				global::Com.Facebook.Drawee.Backends.Pipeline.DraweeConfig.Builder __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Drawee.Backends.Pipeline.DraweeConfig.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Com.Facebook.Drawee.Backends.Pipeline.PipelineDraweeControllerFactory factory = global::Java.Lang.Object.GetObject<global::Com.Facebook.Drawee.Backends.Pipeline.PipelineDraweeControllerFactory> (native_factory, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetPipelineDraweeControllerFactory (factory));
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.drawee.backends.pipeline']/class[@name='DraweeConfig.Builder']/method[@name='setPipelineDraweeControllerFactory' and count(parameter)=1 and parameter[1][@type='com.facebook.drawee.backends.pipeline.PipelineDraweeControllerFactory']]"
			[Register ("setPipelineDraweeControllerFactory", "(Lcom/facebook/drawee/backends/pipeline/PipelineDraweeControllerFactory;)Lcom/facebook/drawee/backends/pipeline/DraweeConfig$Builder;", "GetSetPipelineDraweeControllerFactory_Lcom_facebook_drawee_backends_pipeline_PipelineDraweeControllerFactory_Handler")]
			public virtual unsafe global::Com.Facebook.Drawee.Backends.Pipeline.DraweeConfig.Builder SetPipelineDraweeControllerFactory (global::Com.Facebook.Drawee.Backends.Pipeline.PipelineDraweeControllerFactory factory)
			{
				const string __id = "setPipelineDraweeControllerFactory.(Lcom/facebook/drawee/backends/pipeline/PipelineDraweeControllerFactory;)Lcom/facebook/drawee/backends/pipeline/DraweeConfig$Builder;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((factory == null) ? IntPtr.Zero : ((global::Java.Lang.Object) factory).Handle);
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Facebook.Drawee.Backends.Pipeline.DraweeConfig.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/facebook/drawee/backends/pipeline/DraweeConfig", typeof (DraweeConfig));
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

		protected DraweeConfig (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static Delegate cb_getCustomDrawableFactories;
#pragma warning disable 0169
		static Delegate GetGetCustomDrawableFactoriesHandler ()
		{
			if (cb_getCustomDrawableFactories == null)
				cb_getCustomDrawableFactories = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetCustomDrawableFactories);
			return cb_getCustomDrawableFactories;
		}

		static IntPtr n_GetCustomDrawableFactories (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Facebook.Drawee.Backends.Pipeline.DraweeConfig __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Drawee.Backends.Pipeline.DraweeConfig> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.CustomDrawableFactories);
		}
#pragma warning restore 0169

		public virtual unsafe global::Com.Facebook.Common.Internal.ImmutableList CustomDrawableFactories {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.drawee.backends.pipeline']/class[@name='DraweeConfig']/method[@name='getCustomDrawableFactories' and count(parameter)=0]"
			[Register ("getCustomDrawableFactories", "()Lcom/facebook/common/internal/ImmutableList;", "GetGetCustomDrawableFactoriesHandler")]
			get {
				const string __id = "getCustomDrawableFactories.()Lcom/facebook/common/internal/ImmutableList;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Facebook.Common.Internal.ImmutableList> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getDebugOverlayEnabledSupplier;
#pragma warning disable 0169
		static Delegate GetGetDebugOverlayEnabledSupplierHandler ()
		{
			if (cb_getDebugOverlayEnabledSupplier == null)
				cb_getDebugOverlayEnabledSupplier = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetDebugOverlayEnabledSupplier);
			return cb_getDebugOverlayEnabledSupplier;
		}

		static IntPtr n_GetDebugOverlayEnabledSupplier (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Facebook.Drawee.Backends.Pipeline.DraweeConfig __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Drawee.Backends.Pipeline.DraweeConfig> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.DebugOverlayEnabledSupplier);
		}
#pragma warning restore 0169

		public virtual unsafe global::Com.Facebook.Common.Internal.ISupplier DebugOverlayEnabledSupplier {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.drawee.backends.pipeline']/class[@name='DraweeConfig']/method[@name='getDebugOverlayEnabledSupplier' and count(parameter)=0]"
			[Register ("getDebugOverlayEnabledSupplier", "()Lcom/facebook/common/internal/Supplier;", "GetGetDebugOverlayEnabledSupplierHandler")]
			get {
				const string __id = "getDebugOverlayEnabledSupplier.()Lcom/facebook/common/internal/Supplier;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Facebook.Common.Internal.ISupplier> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getPipelineDraweeControllerFactory;
#pragma warning disable 0169
		static Delegate GetGetPipelineDraweeControllerFactoryHandler ()
		{
			if (cb_getPipelineDraweeControllerFactory == null)
				cb_getPipelineDraweeControllerFactory = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetPipelineDraweeControllerFactory);
			return cb_getPipelineDraweeControllerFactory;
		}

		static IntPtr n_GetPipelineDraweeControllerFactory (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Facebook.Drawee.Backends.Pipeline.DraweeConfig __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Drawee.Backends.Pipeline.DraweeConfig> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.PipelineDraweeControllerFactory);
		}
#pragma warning restore 0169

		public virtual unsafe global::Com.Facebook.Drawee.Backends.Pipeline.PipelineDraweeControllerFactory PipelineDraweeControllerFactory {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.drawee.backends.pipeline']/class[@name='DraweeConfig']/method[@name='getPipelineDraweeControllerFactory' and count(parameter)=0]"
			[Register ("getPipelineDraweeControllerFactory", "()Lcom/facebook/drawee/backends/pipeline/PipelineDraweeControllerFactory;", "GetGetPipelineDraweeControllerFactoryHandler")]
			get {
				const string __id = "getPipelineDraweeControllerFactory.()Lcom/facebook/drawee/backends/pipeline/PipelineDraweeControllerFactory;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Facebook.Drawee.Backends.Pipeline.PipelineDraweeControllerFactory> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.drawee.backends.pipeline']/class[@name='DraweeConfig']/method[@name='newBuilder' and count(parameter)=0]"
		[Register ("newBuilder", "()Lcom/facebook/drawee/backends/pipeline/DraweeConfig$Builder;", "")]
		public static unsafe global::Com.Facebook.Drawee.Backends.Pipeline.DraweeConfig.Builder NewBuilder ()
		{
			const string __id = "newBuilder.()Lcom/facebook/drawee/backends/pipeline/DraweeConfig$Builder;";
			try {
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
				return global::Java.Lang.Object.GetObject<global::Com.Facebook.Drawee.Backends.Pipeline.DraweeConfig.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}
}
