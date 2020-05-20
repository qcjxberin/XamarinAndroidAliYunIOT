using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Facebook.Drawee.Backends.Pipeline {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.facebook.drawee.backends.pipeline']/class[@name='Fresco']"
	[global::Android.Runtime.Register ("com/facebook/drawee/backends/pipeline/Fresco", DoNotGenerateAcw=true)]
	public partial class Fresco : global::Java.Lang.Object {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/facebook/drawee/backends/pipeline/Fresco", typeof (Fresco));
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

		protected Fresco (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		public static unsafe global::Com.Facebook.Drawee.Backends.Pipeline.PipelineDraweeControllerBuilderSupplier DraweeControllerBuilderSupplier {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.drawee.backends.pipeline']/class[@name='Fresco']/method[@name='getDraweeControllerBuilderSupplier' and count(parameter)=0]"
			[Register ("getDraweeControllerBuilderSupplier", "()Lcom/facebook/drawee/backends/pipeline/PipelineDraweeControllerBuilderSupplier;", "")]
			get {
				const string __id = "getDraweeControllerBuilderSupplier.()Lcom/facebook/drawee/backends/pipeline/PipelineDraweeControllerBuilderSupplier;";
				try {
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
					return global::Java.Lang.Object.GetObject<global::Com.Facebook.Drawee.Backends.Pipeline.PipelineDraweeControllerBuilderSupplier> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		public static unsafe bool HasBeenInitialized {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.drawee.backends.pipeline']/class[@name='Fresco']/method[@name='hasBeenInitialized' and count(parameter)=0]"
			[Register ("hasBeenInitialized", "()Z", "")]
			get {
				const string __id = "hasBeenInitialized.()Z";
				try {
					var __rm = _members.StaticMethods.InvokeBooleanMethod (__id, null);
					return __rm;
				} finally {
				}
			}
		}

		public static unsafe global::Com.Facebook.Imagepipeline.Core.ImagePipeline ImagePipeline {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.drawee.backends.pipeline']/class[@name='Fresco']/method[@name='getImagePipeline' and count(parameter)=0]"
			[Register ("getImagePipeline", "()Lcom/facebook/imagepipeline/core/ImagePipeline;", "")]
			get {
				const string __id = "getImagePipeline.()Lcom/facebook/imagepipeline/core/ImagePipeline;";
				try {
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
					return global::Java.Lang.Object.GetObject<global::Com.Facebook.Imagepipeline.Core.ImagePipeline> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		public static unsafe global::Com.Facebook.Imagepipeline.Core.ImagePipelineFactory ImagePipelineFactory {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.drawee.backends.pipeline']/class[@name='Fresco']/method[@name='getImagePipelineFactory' and count(parameter)=0]"
			[Register ("getImagePipelineFactory", "()Lcom/facebook/imagepipeline/core/ImagePipelineFactory;", "")]
			get {
				const string __id = "getImagePipelineFactory.()Lcom/facebook/imagepipeline/core/ImagePipelineFactory;";
				try {
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
					return global::Java.Lang.Object.GetObject<global::Com.Facebook.Imagepipeline.Core.ImagePipelineFactory> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.drawee.backends.pipeline']/class[@name='Fresco']/method[@name='initialize' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("initialize", "(Landroid/content/Context;)V", "")]
		public static unsafe void Initialize (global::Android.Content.Context context)
		{
			const string __id = "initialize.(Landroid/content/Context;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((context == null) ? IntPtr.Zero : ((global::Java.Lang.Object) context).Handle);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.drawee.backends.pipeline']/class[@name='Fresco']/method[@name='initialize' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='com.facebook.imagepipeline.core.ImagePipelineConfig']]"
		[Register ("initialize", "(Landroid/content/Context;Lcom/facebook/imagepipeline/core/ImagePipelineConfig;)V", "")]
		public static unsafe void Initialize (global::Android.Content.Context context, global::Com.Facebook.Imagepipeline.Core.ImagePipelineConfig imagePipelineConfig)
		{
			const string __id = "initialize.(Landroid/content/Context;Lcom/facebook/imagepipeline/core/ImagePipelineConfig;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((context == null) ? IntPtr.Zero : ((global::Java.Lang.Object) context).Handle);
				__args [1] = new JniArgumentValue ((imagePipelineConfig == null) ? IntPtr.Zero : ((global::Java.Lang.Object) imagePipelineConfig).Handle);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.drawee.backends.pipeline']/class[@name='Fresco']/method[@name='initialize' and count(parameter)=3 and parameter[1][@type='android.content.Context'] and parameter[2][@type='com.facebook.imagepipeline.core.ImagePipelineConfig'] and parameter[3][@type='com.facebook.drawee.backends.pipeline.DraweeConfig']]"
		[Register ("initialize", "(Landroid/content/Context;Lcom/facebook/imagepipeline/core/ImagePipelineConfig;Lcom/facebook/drawee/backends/pipeline/DraweeConfig;)V", "")]
		public static unsafe void Initialize (global::Android.Content.Context context, global::Com.Facebook.Imagepipeline.Core.ImagePipelineConfig imagePipelineConfig, global::Com.Facebook.Drawee.Backends.Pipeline.DraweeConfig draweeConfig)
		{
			const string __id = "initialize.(Landroid/content/Context;Lcom/facebook/imagepipeline/core/ImagePipelineConfig;Lcom/facebook/drawee/backends/pipeline/DraweeConfig;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((context == null) ? IntPtr.Zero : ((global::Java.Lang.Object) context).Handle);
				__args [1] = new JniArgumentValue ((imagePipelineConfig == null) ? IntPtr.Zero : ((global::Java.Lang.Object) imagePipelineConfig).Handle);
				__args [2] = new JniArgumentValue ((draweeConfig == null) ? IntPtr.Zero : ((global::Java.Lang.Object) draweeConfig).Handle);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.drawee.backends.pipeline']/class[@name='Fresco']/method[@name='newDraweeControllerBuilder' and count(parameter)=0]"
		[Register ("newDraweeControllerBuilder", "()Lcom/facebook/drawee/backends/pipeline/PipelineDraweeControllerBuilder;", "")]
		public static unsafe global::Com.Facebook.Drawee.Backends.Pipeline.PipelineDraweeControllerBuilder NewDraweeControllerBuilder ()
		{
			const string __id = "newDraweeControllerBuilder.()Lcom/facebook/drawee/backends/pipeline/PipelineDraweeControllerBuilder;";
			try {
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
				return global::Java.Lang.Object.GetObject<global::Com.Facebook.Drawee.Backends.Pipeline.PipelineDraweeControllerBuilder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.drawee.backends.pipeline']/class[@name='Fresco']/method[@name='shutDown' and count(parameter)=0]"
		[Register ("shutDown", "()V", "")]
		public static unsafe void ShutDown ()
		{
			const string __id = "shutDown.()V";
			try {
				_members.StaticMethods.InvokeVoidMethod (__id, null);
			} finally {
			}
		}

	}
}
