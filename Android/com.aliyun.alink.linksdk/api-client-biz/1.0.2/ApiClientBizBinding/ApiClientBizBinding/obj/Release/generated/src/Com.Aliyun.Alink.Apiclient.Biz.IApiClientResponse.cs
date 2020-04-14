using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Aliyun.Alink.Apiclient.Biz {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.aliyun.alink.apiclient.biz']/interface[@name='IApiClientResponse']"
	[Register ("com/aliyun/alink/apiclient/biz/IApiClientResponse", "", "Com.Aliyun.Alink.Apiclient.Biz.IApiClientResponseInvoker")]
	public partial interface IApiClientResponse : IJavaObject, IJavaPeerable {

		int Code {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.apiclient.biz']/interface[@name='IApiClientResponse']/method[@name='getCode' and count(parameter)=0]"
			[Register ("getCode", "()I", "GetGetCodeHandler:Com.Aliyun.Alink.Apiclient.Biz.IApiClientResponseInvoker, ApiClientBizBinding")] get;
		}

		global::Java.Lang.Object Data {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.apiclient.biz']/interface[@name='IApiClientResponse']/method[@name='getData' and count(parameter)=0]"
			[Register ("getData", "()Ljava/lang/Object;", "GetGetDataHandler:Com.Aliyun.Alink.Apiclient.Biz.IApiClientResponseInvoker, ApiClientBizBinding")] get;
		}

		string Id {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.apiclient.biz']/interface[@name='IApiClientResponse']/method[@name='getId' and count(parameter)=0]"
			[Register ("getId", "()Ljava/lang/String;", "GetGetIdHandler:Com.Aliyun.Alink.Apiclient.Biz.IApiClientResponseInvoker, ApiClientBizBinding")] get;
		}

		string LocalizedMsg {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.apiclient.biz']/interface[@name='IApiClientResponse']/method[@name='getLocalizedMsg' and count(parameter)=0]"
			[Register ("getLocalizedMsg", "()Ljava/lang/String;", "GetGetLocalizedMsgHandler:Com.Aliyun.Alink.Apiclient.Biz.IApiClientResponseInvoker, ApiClientBizBinding")] get;
		}

		string Message {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.apiclient.biz']/interface[@name='IApiClientResponse']/method[@name='getMessage' and count(parameter)=0]"
			[Register ("getMessage", "()Ljava/lang/String;", "GetGetMessageHandler:Com.Aliyun.Alink.Apiclient.Biz.IApiClientResponseInvoker, ApiClientBizBinding")] get;
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.apiclient.biz']/interface[@name='IApiClientResponse']/method[@name='getRawData' and count(parameter)=0]"
		[Register ("getRawData", "()[B", "GetGetRawDataHandler:Com.Aliyun.Alink.Apiclient.Biz.IApiClientResponseInvoker, ApiClientBizBinding")]
		byte[] GetRawData ();

	}

	[global::Android.Runtime.Register ("com/aliyun/alink/apiclient/biz/IApiClientResponse", DoNotGenerateAcw=true)]
	internal partial class IApiClientResponseInvoker : global::Java.Lang.Object, IApiClientResponse {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/aliyun/alink/apiclient/biz/IApiClientResponse", typeof (IApiClientResponseInvoker));

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

		public static IApiClientResponse GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IApiClientResponse> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.aliyun.alink.apiclient.biz.IApiClientResponse"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IApiClientResponseInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_getCode;
#pragma warning disable 0169
		static Delegate GetGetCodeHandler ()
		{
			if (cb_getCode == null)
				cb_getCode = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetCode);
			return cb_getCode;
		}

		static int n_GetCode (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Aliyun.Alink.Apiclient.Biz.IApiClientResponse __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Apiclient.Biz.IApiClientResponse> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Code;
		}
#pragma warning restore 0169

		IntPtr id_getCode;
		public unsafe int Code {
			get {
				if (id_getCode == IntPtr.Zero)
					id_getCode = JNIEnv.GetMethodID (class_ref, "getCode", "()I");
				return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getCode);
			}
		}

		static Delegate cb_getData;
#pragma warning disable 0169
		static Delegate GetGetDataHandler ()
		{
			if (cb_getData == null)
				cb_getData = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetData);
			return cb_getData;
		}

		static IntPtr n_GetData (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Aliyun.Alink.Apiclient.Biz.IApiClientResponse __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Apiclient.Biz.IApiClientResponse> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Data);
		}
#pragma warning restore 0169

		IntPtr id_getData;
		public unsafe global::Java.Lang.Object Data {
			get {
				if (id_getData == IntPtr.Zero)
					id_getData = JNIEnv.GetMethodID (class_ref, "getData", "()Ljava/lang/Object;");
				return global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getData), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getId;
#pragma warning disable 0169
		static Delegate GetGetIdHandler ()
		{
			if (cb_getId == null)
				cb_getId = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetId);
			return cb_getId;
		}

		static IntPtr n_GetId (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Aliyun.Alink.Apiclient.Biz.IApiClientResponse __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Apiclient.Biz.IApiClientResponse> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Id);
		}
#pragma warning restore 0169

		IntPtr id_getId;
		public unsafe string Id {
			get {
				if (id_getId == IntPtr.Zero)
					id_getId = JNIEnv.GetMethodID (class_ref, "getId", "()Ljava/lang/String;");
				return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getId), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getLocalizedMsg;
#pragma warning disable 0169
		static Delegate GetGetLocalizedMsgHandler ()
		{
			if (cb_getLocalizedMsg == null)
				cb_getLocalizedMsg = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetLocalizedMsg);
			return cb_getLocalizedMsg;
		}

		static IntPtr n_GetLocalizedMsg (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Aliyun.Alink.Apiclient.Biz.IApiClientResponse __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Apiclient.Biz.IApiClientResponse> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.LocalizedMsg);
		}
#pragma warning restore 0169

		IntPtr id_getLocalizedMsg;
		public unsafe string LocalizedMsg {
			get {
				if (id_getLocalizedMsg == IntPtr.Zero)
					id_getLocalizedMsg = JNIEnv.GetMethodID (class_ref, "getLocalizedMsg", "()Ljava/lang/String;");
				return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getLocalizedMsg), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getMessage;
#pragma warning disable 0169
		static Delegate GetGetMessageHandler ()
		{
			if (cb_getMessage == null)
				cb_getMessage = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetMessage);
			return cb_getMessage;
		}

		static IntPtr n_GetMessage (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Aliyun.Alink.Apiclient.Biz.IApiClientResponse __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Apiclient.Biz.IApiClientResponse> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Message);
		}
#pragma warning restore 0169

		IntPtr id_getMessage;
		public unsafe string Message {
			get {
				if (id_getMessage == IntPtr.Zero)
					id_getMessage = JNIEnv.GetMethodID (class_ref, "getMessage", "()Ljava/lang/String;");
				return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getMessage), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getRawData;
#pragma warning disable 0169
		static Delegate GetGetRawDataHandler ()
		{
			if (cb_getRawData == null)
				cb_getRawData = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetRawData);
			return cb_getRawData;
		}

		static IntPtr n_GetRawData (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Aliyun.Alink.Apiclient.Biz.IApiClientResponse __this = global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Apiclient.Biz.IApiClientResponse> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.GetRawData ());
		}
#pragma warning restore 0169

		IntPtr id_getRawData;
		public unsafe byte[] GetRawData ()
		{
			if (id_getRawData == IntPtr.Zero)
				id_getRawData = JNIEnv.GetMethodID (class_ref, "getRawData", "()[B");
			return (byte[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getRawData), JniHandleOwnership.TransferLocalRef, typeof (byte));
		}

	}

}
