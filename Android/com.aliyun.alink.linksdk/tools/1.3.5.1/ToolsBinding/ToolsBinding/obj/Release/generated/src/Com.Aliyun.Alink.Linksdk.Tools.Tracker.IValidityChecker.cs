using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Aliyun.Alink.Linksdk.Tools.Tracker {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.aliyun.alink.linksdk.tools.tracker']/interface[@name='IValidityChecker']"
	[Register ("com/aliyun/alink/linksdk/tools/tracker/IValidityChecker", "", "Com.Aliyun.Alink.Linksdk.Tools.Tracker.IValidityCheckerInvoker")]
	public partial interface IValidityChecker : IJavaObject, IJavaPeerable {

		bool IsSupport {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.tools.tracker']/interface[@name='IValidityChecker']/method[@name='isSupport' and count(parameter)=0]"
			[Register ("isSupport", "()Z", "GetIsSupportHandler:Com.Aliyun.Alink.Linksdk.Tools.Tracker.IValidityCheckerInvoker, ToolsBinding")] get;
		}

	}

	[global::Android.Runtime.Register ("com/aliyun/alink/linksdk/tools/tracker/IValidityChecker", DoNotGenerateAcw=true)]
	internal partial class IValidityCheckerInvoker : global::Java.Lang.Object, IValidityChecker {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/aliyun/alink/linksdk/tools/tracker/IValidityChecker", typeof (IValidityCheckerInvoker));

		static IntPtr java_class_ref {
			get { return _members.JniPeerType.PeerReference.Handle; }
		}

		public override global::Java.Interop.JniPeerMembers JniPeerMembers {
			get { return _members; }
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return _members.ManagedPeerType; }
		}

		IntPtr class_ref;

		public static IValidityChecker GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IValidityChecker> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.aliyun.alink.linksdk.tools.tracker.IValidityChecker"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IValidityCheckerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_isSupport;
#pragma warning disable 0169
		static Delegate GetIsSupportHandler ()
		{
			if (cb_isSupport == null)
				cb_isSupport = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsSupport);
			return cb_isSupport;
		}

		static bool n_IsSupport (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Aliyun.Alink.Linksdk.Tools.Tracker.IValidityChecker __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Tools.Tracker.IValidityChecker> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsSupport;
		}
#pragma warning restore 0169

		IntPtr id_isSupport;
		public unsafe bool IsSupport {
			get {
				if (id_isSupport == IntPtr.Zero)
					id_isSupport = JNIEnv.GetMethodID (class_ref, "isSupport", "()Z");
				return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isSupport);
			}
		}

	}

}
