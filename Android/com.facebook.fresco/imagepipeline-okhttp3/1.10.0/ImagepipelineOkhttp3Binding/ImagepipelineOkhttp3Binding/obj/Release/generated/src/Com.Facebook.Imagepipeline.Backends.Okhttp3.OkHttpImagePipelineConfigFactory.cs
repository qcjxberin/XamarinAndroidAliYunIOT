using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Facebook.Imagepipeline.Backends.Okhttp3 {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.facebook.imagepipeline.backends.okhttp3']/class[@name='OkHttpImagePipelineConfigFactory']"
	[global::Android.Runtime.Register ("com/facebook/imagepipeline/backends/okhttp3/OkHttpImagePipelineConfigFactory", DoNotGenerateAcw=true)]
	public partial class OkHttpImagePipelineConfigFactory : global::Java.Lang.Object {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/facebook/imagepipeline/backends/okhttp3/OkHttpImagePipelineConfigFactory", typeof (OkHttpImagePipelineConfigFactory));
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

		protected OkHttpImagePipelineConfigFactory (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.facebook.imagepipeline.backends.okhttp3']/class[@name='OkHttpImagePipelineConfigFactory']/constructor[@name='OkHttpImagePipelineConfigFactory' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe OkHttpImagePipelineConfigFactory ()
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

		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.imagepipeline.backends.okhttp3']/class[@name='OkHttpImagePipelineConfigFactory']/method[@name='newBuilder' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='okhttp3.OkHttpClient']]"
		[Register ("newBuilder", "(Landroid/content/Context;Lokhttp3/OkHttpClient;)Lcom/facebook/imagepipeline/core/ImagePipelineConfig$Builder;", "")]
		public static unsafe global::Com.Facebook.Imagepipeline.Core.ImagePipelineConfig.Builder NewBuilder (global::Android.Content.Context context, global::Okhttp3.OkHttpClient okHttpClient)
		{
			const string __id = "newBuilder.(Landroid/content/Context;Lokhttp3/OkHttpClient;)Lcom/facebook/imagepipeline/core/ImagePipelineConfig$Builder;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((context == null) ? IntPtr.Zero : ((global::Java.Lang.Object) context).Handle);
				__args [1] = new JniArgumentValue ((okHttpClient == null) ? IntPtr.Zero : ((global::Java.Lang.Object) okHttpClient).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Facebook.Imagepipeline.Core.ImagePipelineConfig.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}
}
