using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Google.Gson {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.google.gson']/class[@name='FieldAttributes']"
	[global::Android.Runtime.Register ("com/google/gson/FieldAttributes", DoNotGenerateAcw=true)]
	public sealed partial class FieldAttributes : global::Java.Lang.Object {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/google/gson/FieldAttributes", typeof (FieldAttributes));
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

		internal FieldAttributes (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.google.gson']/class[@name='FieldAttributes']/constructor[@name='FieldAttributes' and count(parameter)=1 and parameter[1][@type='java.lang.reflect.Field']]"
		[Register (".ctor", "(Ljava/lang/reflect/Field;)V", "")]
		public unsafe FieldAttributes (global::Java.Lang.Reflect.Field f)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Ljava/lang/reflect/Field;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((f == null) ? IntPtr.Zero : ((global::Java.Lang.Object) f).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
			}
		}

		public unsafe global::System.Collections.Generic.ICollection<global::Java.Lang.Annotation.IAnnotation> Annotations {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.gson']/class[@name='FieldAttributes']/method[@name='getAnnotations' and count(parameter)=0]"
			[Register ("getAnnotations", "()Ljava/util/Collection;", "")]
			get {
				const string __id = "getAnnotations.()Ljava/util/Collection;";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
					return global::Android.Runtime.JavaCollection<global::Java.Lang.Annotation.IAnnotation>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		public unsafe global::Java.Lang.Class DeclaredClass {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.gson']/class[@name='FieldAttributes']/method[@name='getDeclaredClass' and count(parameter)=0]"
			[Register ("getDeclaredClass", "()Ljava/lang/Class;", "")]
			get {
				const string __id = "getDeclaredClass.()Ljava/lang/Class;";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Java.Lang.Class> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		public unsafe global::Java.Lang.Reflect.IType DeclaredType {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.gson']/class[@name='FieldAttributes']/method[@name='getDeclaredType' and count(parameter)=0]"
			[Register ("getDeclaredType", "()Ljava/lang/reflect/Type;", "")]
			get {
				const string __id = "getDeclaredType.()Ljava/lang/reflect/Type;";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Java.Lang.Reflect.IType> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		public unsafe global::Java.Lang.Class DeclaringClass {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.gson']/class[@name='FieldAttributes']/method[@name='getDeclaringClass' and count(parameter)=0]"
			[Register ("getDeclaringClass", "()Ljava/lang/Class;", "")]
			get {
				const string __id = "getDeclaringClass.()Ljava/lang/Class;";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Java.Lang.Class> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		public unsafe string Name {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.gson']/class[@name='FieldAttributes']/method[@name='getName' and count(parameter)=0]"
			[Register ("getName", "()Ljava/lang/String;", "")]
			get {
				const string __id = "getName.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.gson']/class[@name='FieldAttributes']/method[@name='getAnnotation' and count(parameter)=1 and parameter[1][@type='java.lang.Class&lt;T&gt;']]"
		[Register ("getAnnotation", "(Ljava/lang/Class;)Ljava/lang/annotation/Annotation;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T extends java.lang.annotation.Annotation"})]
		public unsafe global::Java.Lang.Object GetAnnotation (global::Java.Lang.Class annotation)
		{
			const string __id = "getAnnotation.(Ljava/lang/Class;)Ljava/lang/annotation/Annotation;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((annotation == null) ? IntPtr.Zero : ((global::Java.Lang.Object) annotation).Handle);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.gson']/class[@name='FieldAttributes']/method[@name='hasModifier' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("hasModifier", "(I)Z", "")]
		public unsafe bool HasModifier (int modifier)
		{
			const string __id = "hasModifier.(I)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (modifier);
				var __rm = _members.InstanceMethods.InvokeAbstractBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
			}
		}

	}
}
