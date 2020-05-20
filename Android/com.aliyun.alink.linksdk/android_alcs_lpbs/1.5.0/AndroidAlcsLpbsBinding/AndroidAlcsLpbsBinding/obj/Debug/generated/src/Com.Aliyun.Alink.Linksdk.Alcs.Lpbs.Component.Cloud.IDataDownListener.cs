using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Component.Cloud {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.lpbs.component.cloud']/interface[@name='IDataDownListener']"
	[Register ("com/aliyun/alink/linksdk/alcs/lpbs/component/cloud/IDataDownListener", "", "Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Component.Cloud.IDataDownListenerInvoker")]
	public partial interface IDataDownListener : IJavaObject, IJavaPeerable {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.alcs.lpbs.component.cloud']/interface[@name='IDataDownListener']/method[@name='onDataDown' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='byte[]']]"
		[Register ("onDataDown", "(Ljava/lang/String;[B)V", "GetOnDataDown_Ljava_lang_String_arrayBHandler:Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Component.Cloud.IDataDownListenerInvoker, AndroidAlcsLpbsBinding")]
		void OnDataDown (string p0, byte[] p1);

	}

	[global::Android.Runtime.Register ("com/aliyun/alink/linksdk/alcs/lpbs/component/cloud/IDataDownListener", DoNotGenerateAcw=true)]
	internal partial class IDataDownListenerInvoker : global::Java.Lang.Object, IDataDownListener {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/aliyun/alink/linksdk/alcs/lpbs/component/cloud/IDataDownListener", typeof (IDataDownListenerInvoker));

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

		public static IDataDownListener GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IDataDownListener> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.aliyun.alink.linksdk.alcs.lpbs.component.cloud.IDataDownListener"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IDataDownListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_onDataDown_Ljava_lang_String_arrayB;
#pragma warning disable 0169
		static Delegate GetOnDataDown_Ljava_lang_String_arrayBHandler ()
		{
			if (cb_onDataDown_Ljava_lang_String_arrayB == null)
				cb_onDataDown_Ljava_lang_String_arrayB = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_OnDataDown_Ljava_lang_String_arrayB);
			return cb_onDataDown_Ljava_lang_String_arrayB;
		}

		static void n_OnDataDown_Ljava_lang_String_arrayB (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Component.Cloud.IDataDownListener __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Alcs.Lpbs.Component.Cloud.IDataDownListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			byte[] p1 = (byte[]) JNIEnv.GetArray (native_p1, JniHandleOwnership.DoNotTransfer, typeof (byte));
			__this.OnDataDown (p0, p1);
			if (p1 != null)
				JNIEnv.CopyArray (p1, native_p1);
		}
#pragma warning restore 0169

		IntPtr id_onDataDown_Ljava_lang_String_arrayB;
		public unsafe void OnDataDown (string p0, byte[] p1)
		{
			if (id_onDataDown_Ljava_lang_String_arrayB == IntPtr.Zero)
				id_onDataDown_Ljava_lang_String_arrayB = JNIEnv.GetMethodID (class_ref, "onDataDown", "(Ljava/lang/String;[B)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewArray (p1);
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (native_p0);
			__args [1] = new JValue (native_p1);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onDataDown_Ljava_lang_String_arrayB, __args);
			JNIEnv.DeleteLocalRef (native_p0);
			if (p1 != null) {
				JNIEnv.CopyArray (native_p1, p1);
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

	}

	// event args for com.aliyun.alink.linksdk.alcs.lpbs.component.cloud.IDataDownListener.onDataDown
	public partial class DataDownEventArgs : global::System.EventArgs {

		public DataDownEventArgs (string p0, byte[] p1)
		{
			this.p0 = p0;
			this.p1 = p1;
		}

		string p0;
		public string P0 {
			get { return p0; }
		}

		byte[] p1;
		public byte[] P1 {
			get { return p1; }
		}
	}

	[global::Android.Runtime.Register ("mono/com/aliyun/alink/linksdk/alcs/lpbs/component/cloud/IDataDownListenerImplementor")]
	internal sealed partial class IDataDownListenerImplementor : global::Java.Lang.Object, IDataDownListener {

		object sender;

		public IDataDownListenerImplementor (object sender)
			: base (
				global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/com/aliyun/alink/linksdk/alcs/lpbs/component/cloud/IDataDownListenerImplementor", "()V"),
				JniHandleOwnership.TransferLocalRef)
		{
			global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "()V");
			this.sender = sender;
		}

#pragma warning disable 0649
		public EventHandler<DataDownEventArgs> Handler;
#pragma warning restore 0649

		public void OnDataDown (string p0, byte[] p1)
		{
			var __h = Handler;
			if (__h != null)
				__h (sender, new DataDownEventArgs (p0, p1));
		}

		internal static bool __IsEmpty (IDataDownListenerImplementor value)
		{
			return value.Handler == null;
		}
	}

}
