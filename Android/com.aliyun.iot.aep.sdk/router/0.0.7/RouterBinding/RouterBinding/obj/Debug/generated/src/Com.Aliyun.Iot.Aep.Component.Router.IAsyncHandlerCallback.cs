using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Aliyun.Iot.Aep.Component.Router {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.aliyun.iot.aep.component.router']/interface[@name='IAsyncHandlerCallback']"
	[Register ("com/aliyun/iot/aep/component/router/IAsyncHandlerCallback", "", "Com.Aliyun.Iot.Aep.Component.Router.IAsyncHandlerCallbackInvoker")]
	public partial interface IAsyncHandlerCallback : IJavaObject, IJavaPeerable {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.iot.aep.component.router']/interface[@name='IAsyncHandlerCallback']/method[@name='asyncHandle' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("asyncHandle", "(Z)V", "GetAsyncHandle_ZHandler:Com.Aliyun.Iot.Aep.Component.Router.IAsyncHandlerCallbackInvoker, RouterBinding")]
		void AsyncHandle (bool p0);

	}

	[global::Android.Runtime.Register ("com/aliyun/iot/aep/component/router/IAsyncHandlerCallback", DoNotGenerateAcw=true)]
	internal partial class IAsyncHandlerCallbackInvoker : global::Java.Lang.Object, IAsyncHandlerCallback {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/aliyun/iot/aep/component/router/IAsyncHandlerCallback", typeof (IAsyncHandlerCallbackInvoker));

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

		public static IAsyncHandlerCallback GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IAsyncHandlerCallback> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.aliyun.iot.aep.component.router.IAsyncHandlerCallback"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IAsyncHandlerCallbackInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_asyncHandle_Z;
#pragma warning disable 0169
		static Delegate GetAsyncHandle_ZHandler ()
		{
			if (cb_asyncHandle_Z == null)
				cb_asyncHandle_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_AsyncHandle_Z);
			return cb_asyncHandle_Z;
		}

		static void n_AsyncHandle_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::Com.Aliyun.Iot.Aep.Component.Router.IAsyncHandlerCallback __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Iot.Aep.Component.Router.IAsyncHandlerCallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.AsyncHandle (p0);
		}
#pragma warning restore 0169

		IntPtr id_asyncHandle_Z;
		public unsafe void AsyncHandle (bool p0)
		{
			if (id_asyncHandle_Z == IntPtr.Zero)
				id_asyncHandle_Z = JNIEnv.GetMethodID (class_ref, "asyncHandle", "(Z)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_asyncHandle_Z, __args);
		}

	}

}
