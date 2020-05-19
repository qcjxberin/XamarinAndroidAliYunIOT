using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Facebook.Drawee.Backends.Pipeline.Info.Internal {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.facebook.drawee.backends.pipeline.info.internal']/class[@name='ImagePerfRequestListener']"
	[global::Android.Runtime.Register ("com/facebook/drawee/backends/pipeline/info/internal/ImagePerfRequestListener", DoNotGenerateAcw=true)]
	public partial class ImagePerfRequestListener : global::Com.Facebook.Imagepipeline.Listener.BaseRequestListener {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/facebook/drawee/backends/pipeline/info/internal/ImagePerfRequestListener", typeof (ImagePerfRequestListener));
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

		protected ImagePerfRequestListener (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.facebook.drawee.backends.pipeline.info.internal']/class[@name='ImagePerfRequestListener']/constructor[@name='ImagePerfRequestListener' and count(parameter)=2 and parameter[1][@type='com.facebook.common.time.MonotonicClock'] and parameter[2][@type='com.facebook.drawee.backends.pipeline.info.ImagePerfState']]"
		[Register (".ctor", "(Lcom/facebook/common/time/MonotonicClock;Lcom/facebook/drawee/backends/pipeline/info/ImagePerfState;)V", "")]
		public unsafe ImagePerfRequestListener (global::Com.Facebook.Common.Time.IMonotonicClock monotonicClock, global::Com.Facebook.Drawee.Backends.Pipeline.Info.ImagePerfState imagePerfState)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Lcom/facebook/common/time/MonotonicClock;Lcom/facebook/drawee/backends/pipeline/info/ImagePerfState;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((monotonicClock == null) ? IntPtr.Zero : ((global::Java.Lang.Object) monotonicClock).Handle);
				__args [1] = new JniArgumentValue ((imagePerfState == null) ? IntPtr.Zero : ((global::Java.Lang.Object) imagePerfState).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
			}
		}

	}
}
