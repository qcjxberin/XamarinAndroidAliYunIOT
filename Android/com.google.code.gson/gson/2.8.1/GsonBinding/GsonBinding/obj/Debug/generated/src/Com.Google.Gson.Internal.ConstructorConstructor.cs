using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Google.Gson.Internal {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.google.gson.internal']/class[@name='ConstructorConstructor']"
	[global::Android.Runtime.Register ("com/google/gson/internal/ConstructorConstructor", DoNotGenerateAcw=true)]
	public sealed partial class ConstructorConstructor : global::Java.Lang.Object {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/google/gson/internal/ConstructorConstructor", typeof (ConstructorConstructor));
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

		internal ConstructorConstructor (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.google.gson.internal']/class[@name='ConstructorConstructor']/constructor[@name='ConstructorConstructor' and count(parameter)=1 and parameter[1][@type='java.util.Map&lt;java.lang.reflect.Type, com.google.gson.InstanceCreator&lt;?&gt;&gt;']]"
		[Register (".ctor", "(Ljava/util/Map;)V", "")]
		public unsafe ConstructorConstructor (global::System.Collections.Generic.IDictionary<global::Java.Lang.Reflect.IType, global::Com.Google.Gson.IInstanceCreator> instanceCreators)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Ljava/util/Map;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_instanceCreators = global::Android.Runtime.JavaDictionary<global::Java.Lang.Reflect.IType, global::Com.Google.Gson.IInstanceCreator>.ToLocalJniHandle (instanceCreators);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_instanceCreators);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_instanceCreators);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.gson.internal']/class[@name='ConstructorConstructor']/method[@name='get' and count(parameter)=1 and parameter[1][@type='com.google.gson.reflect.TypeToken&lt;T&gt;']]"
		[Register ("get", "(Lcom/google/gson/reflect/TypeToken;)Lcom/google/gson/internal/ObjectConstructor;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
		public unsafe global::Com.Google.Gson.Internal.IObjectConstructor Get (global::Com.Google.Gson.Reflect.TypeToken typeToken)
		{
			const string __id = "get.(Lcom/google/gson/reflect/TypeToken;)Lcom/google/gson/internal/ObjectConstructor;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((typeToken == null) ? IntPtr.Zero : ((global::Java.Lang.Object) typeToken).Handle);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Google.Gson.Internal.IObjectConstructor> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}
}
