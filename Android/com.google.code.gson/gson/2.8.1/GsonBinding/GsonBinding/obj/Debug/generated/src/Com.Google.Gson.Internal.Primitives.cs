using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Google.Gson.Internal {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.google.gson.internal']/class[@name='Primitives']"
	[global::Android.Runtime.Register ("com/google/gson/internal/Primitives", DoNotGenerateAcw=true)]
	public sealed partial class Primitives : global::Java.Lang.Object {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/google/gson/internal/Primitives", typeof (Primitives));
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

		internal Primitives (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.gson.internal']/class[@name='Primitives']/method[@name='isPrimitive' and count(parameter)=1 and parameter[1][@type='java.lang.reflect.Type']]"
		[Register ("isPrimitive", "(Ljava/lang/reflect/Type;)Z", "")]
		public static unsafe bool IsPrimitive (global::Java.Lang.Reflect.IType type)
		{
			const string __id = "isPrimitive.(Ljava/lang/reflect/Type;)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((type == null) ? IntPtr.Zero : ((global::Java.Lang.Object) type).Handle);
				var __rm = _members.StaticMethods.InvokeBooleanMethod (__id, __args);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.gson.internal']/class[@name='Primitives']/method[@name='isWrapperType' and count(parameter)=1 and parameter[1][@type='java.lang.reflect.Type']]"
		[Register ("isWrapperType", "(Ljava/lang/reflect/Type;)Z", "")]
		public static unsafe bool IsWrapperType (global::Java.Lang.Reflect.IType type)
		{
			const string __id = "isWrapperType.(Ljava/lang/reflect/Type;)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((type == null) ? IntPtr.Zero : ((global::Java.Lang.Object) type).Handle);
				var __rm = _members.StaticMethods.InvokeBooleanMethod (__id, __args);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.gson.internal']/class[@name='Primitives']/method[@name='unwrap' and count(parameter)=1 and parameter[1][@type='java.lang.Class&lt;T&gt;']]"
		[Register ("unwrap", "(Ljava/lang/Class;)Ljava/lang/Class;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
		public static unsafe global::Java.Lang.Class Unwrap (global::Java.Lang.Class type)
		{
			const string __id = "unwrap.(Ljava/lang/Class;)Ljava/lang/Class;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((type == null) ? IntPtr.Zero : ((global::Java.Lang.Object) type).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Java.Lang.Class> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.gson.internal']/class[@name='Primitives']/method[@name='wrap' and count(parameter)=1 and parameter[1][@type='java.lang.Class&lt;T&gt;']]"
		[Register ("wrap", "(Ljava/lang/Class;)Ljava/lang/Class;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
		public static unsafe global::Java.Lang.Class Wrap (global::Java.Lang.Class type)
		{
			const string __id = "wrap.(Ljava/lang/Class;)Ljava/lang/Class;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((type == null) ? IntPtr.Zero : ((global::Java.Lang.Object) type).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Java.Lang.Class> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}
}
