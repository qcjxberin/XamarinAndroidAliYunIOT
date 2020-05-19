using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Facebook.Drawee.Backends.Pipeline.Info {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.facebook.drawee.backends.pipeline.info']/class[@name='ImagePerfUtils']"
	[global::Android.Runtime.Register ("com/facebook/drawee/backends/pipeline/info/ImagePerfUtils", DoNotGenerateAcw=true)]
	public partial class ImagePerfUtils : global::Java.Lang.Object {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/facebook/drawee/backends/pipeline/info/ImagePerfUtils", typeof (ImagePerfUtils));
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

		protected ImagePerfUtils (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.drawee.backends.pipeline.info']/class[@name='ImagePerfUtils']/method[@name='toString' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("toString", "(I)Ljava/lang/String;", "")]
		public static new unsafe string ToString ([global::Android.Runtime.IntDef (Type = "Com.Facebook.Drawee.Backends.Pipeline.Info.IImageLoadStatus", Fields = new string [] {"Unknown", "Requested", "OriginAvailable", "IntermediateAvailable", "Success", "Canceled", "Error"})]int imageLoadStatus)
		{
			const string __id = "toString.(I)Ljava/lang/String;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (imageLoadStatus);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}
}
