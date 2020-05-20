using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Org.Eclipse.Paho.Client.Mqttv3.Util {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.util']/class[@name='Strings']"
	[global::Android.Runtime.Register ("org/eclipse/paho/client/mqttv3/util/Strings", DoNotGenerateAcw=true)]
	public sealed partial class Strings : global::Java.Lang.Object {

		static readonly JniPeerMembers _members = new XAPeerMembers ("org/eclipse/paho/client/mqttv3/util/Strings", typeof (Strings));
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

		internal Strings (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.util']/class[@name='Strings']/method[@name='containsAny' and count(parameter)=2 and parameter[1][@type='java.lang.CharSequence'] and parameter[2][@type='char[]']]"
		[Register ("containsAny", "(Ljava/lang/CharSequence;[C)Z", "")]
		public static unsafe bool ContainsAny (global::Java.Lang.ICharSequence cs, char[] searchChars)
		{
			const string __id = "containsAny.(Ljava/lang/CharSequence;[C)Z";
			IntPtr native_cs = CharSequence.ToLocalJniHandle (cs);
			IntPtr native_searchChars = JNIEnv.NewArray (searchChars);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_cs);
				__args [1] = new JniArgumentValue (native_searchChars);
				var __rm = _members.StaticMethods.InvokeBooleanMethod (__id, __args);
				return __rm;
			} finally {
				JNIEnv.DeleteLocalRef (native_cs);
				if (searchChars != null) {
					JNIEnv.CopyArray (native_searchChars, searchChars);
					JNIEnv.DeleteLocalRef (native_searchChars);
				}
			}
		}

		public static bool ContainsAny (string cs, char[] searchChars)
		{
			global::Java.Lang.String jls_cs = cs == null ? null : new global::Java.Lang.String (cs);
			bool __result = ContainsAny (jls_cs, searchChars);
			var __rsval = __result;
			jls_cs?.Dispose ();
			return __rsval;
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.util']/class[@name='Strings']/method[@name='containsAny' and count(parameter)=2 and parameter[1][@type='java.lang.CharSequence'] and parameter[2][@type='java.lang.CharSequence']]"
		[Register ("containsAny", "(Ljava/lang/CharSequence;Ljava/lang/CharSequence;)Z", "")]
		public static unsafe bool ContainsAny (global::Java.Lang.ICharSequence cs, global::Java.Lang.ICharSequence searchChars)
		{
			const string __id = "containsAny.(Ljava/lang/CharSequence;Ljava/lang/CharSequence;)Z";
			IntPtr native_cs = CharSequence.ToLocalJniHandle (cs);
			IntPtr native_searchChars = CharSequence.ToLocalJniHandle (searchChars);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_cs);
				__args [1] = new JniArgumentValue (native_searchChars);
				var __rm = _members.StaticMethods.InvokeBooleanMethod (__id, __args);
				return __rm;
			} finally {
				JNIEnv.DeleteLocalRef (native_cs);
				JNIEnv.DeleteLocalRef (native_searchChars);
			}
		}

		public static bool ContainsAny (string cs, string searchChars)
		{
			global::Java.Lang.String jls_cs = cs == null ? null : new global::Java.Lang.String (cs);
			global::Java.Lang.String jls_searchChars = searchChars == null ? null : new global::Java.Lang.String (searchChars);
			bool __result = ContainsAny (jls_cs, jls_searchChars);
			var __rsval = __result;
			jls_cs?.Dispose ();
			jls_searchChars?.Dispose ();
			return __rsval;
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.util']/class[@name='Strings']/method[@name='countMatches' and count(parameter)=2 and parameter[1][@type='java.lang.CharSequence'] and parameter[2][@type='java.lang.CharSequence']]"
		[Register ("countMatches", "(Ljava/lang/CharSequence;Ljava/lang/CharSequence;)I", "")]
		public static unsafe int CountMatches (global::Java.Lang.ICharSequence str, global::Java.Lang.ICharSequence sub)
		{
			const string __id = "countMatches.(Ljava/lang/CharSequence;Ljava/lang/CharSequence;)I";
			IntPtr native_str = CharSequence.ToLocalJniHandle (str);
			IntPtr native_sub = CharSequence.ToLocalJniHandle (sub);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_str);
				__args [1] = new JniArgumentValue (native_sub);
				var __rm = _members.StaticMethods.InvokeInt32Method (__id, __args);
				return __rm;
			} finally {
				JNIEnv.DeleteLocalRef (native_str);
				JNIEnv.DeleteLocalRef (native_sub);
			}
		}

		public static int CountMatches (string str, string sub)
		{
			global::Java.Lang.String jls_str = str == null ? null : new global::Java.Lang.String (str);
			global::Java.Lang.String jls_sub = sub == null ? null : new global::Java.Lang.String (sub);
			int __result = CountMatches (jls_str, jls_sub);
			var __rsval = __result;
			jls_str?.Dispose ();
			jls_sub?.Dispose ();
			return __rsval;
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.util']/class[@name='Strings']/method[@name='equalsAny' and count(parameter)=2 and parameter[1][@type='java.lang.CharSequence'] and parameter[2][@type='java.lang.CharSequence[]']]"
		[Register ("equalsAny", "(Ljava/lang/CharSequence;[Ljava/lang/CharSequence;)Z", "")]
		public static unsafe bool EqualsAny (global::Java.Lang.ICharSequence cs, global::Java.Lang.ICharSequence[] strs)
		{
			const string __id = "equalsAny.(Ljava/lang/CharSequence;[Ljava/lang/CharSequence;)Z";
			IntPtr native_cs = CharSequence.ToLocalJniHandle (cs);
			IntPtr native_strs = JNIEnv.NewArray (strs);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_cs);
				__args [1] = new JniArgumentValue (native_strs);
				var __rm = _members.StaticMethods.InvokeBooleanMethod (__id, __args);
				return __rm;
			} finally {
				JNIEnv.DeleteLocalRef (native_cs);
				if (strs != null) {
					JNIEnv.CopyArray (native_strs, strs);
					JNIEnv.DeleteLocalRef (native_strs);
				}
			}
		}

		public static bool EqualsAny (string cs, string[] strs)
		{
			global::Java.Lang.String jls_cs = cs == null ? null : new global::Java.Lang.String (cs);
			global::Java.Lang.ICharSequence[] jlca_strs = CharSequence.ArrayFromStringArray(strs);
			bool __result = EqualsAny (jls_cs, jlca_strs);
			var __rsval = __result;
			jls_cs?.Dispose ();
			if (jlca_strs != null) foreach (global::Java.Lang.String s in jlca_strs) s?.Dispose ();
			return __rsval;
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.util']/class[@name='Strings']/method[@name='isEmpty' and count(parameter)=1 and parameter[1][@type='java.lang.CharSequence']]"
		[Register ("isEmpty", "(Ljava/lang/CharSequence;)Z", "")]
		public static unsafe bool IsEmpty (global::Java.Lang.ICharSequence cs)
		{
			const string __id = "isEmpty.(Ljava/lang/CharSequence;)Z";
			IntPtr native_cs = CharSequence.ToLocalJniHandle (cs);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_cs);
				var __rm = _members.StaticMethods.InvokeBooleanMethod (__id, __args);
				return __rm;
			} finally {
				JNIEnv.DeleteLocalRef (native_cs);
			}
		}

		public static bool IsEmpty (string cs)
		{
			global::Java.Lang.String jls_cs = cs == null ? null : new global::Java.Lang.String (cs);
			bool __result = IsEmpty (jls_cs);
			var __rsval = __result;
			jls_cs?.Dispose ();
			return __rsval;
		}

	}
}
