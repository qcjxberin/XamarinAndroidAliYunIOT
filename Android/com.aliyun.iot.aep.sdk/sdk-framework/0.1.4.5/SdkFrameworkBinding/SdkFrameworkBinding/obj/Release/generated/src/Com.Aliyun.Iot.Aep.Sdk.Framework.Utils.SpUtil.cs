using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Aliyun.Iot.Aep.Sdk.Framework.Utils {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.aliyun.iot.aep.sdk.framework.utils']/class[@name='SpUtil']"
	[global::Android.Runtime.Register ("com/aliyun/iot/aep/sdk/framework/utils/SpUtil", DoNotGenerateAcw=true)]
	public partial class SpUtil : global::Java.Lang.Object {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/aliyun/iot/aep/sdk/framework/utils/SpUtil", typeof (SpUtil));
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

		protected SpUtil (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.aliyun.iot.aep.sdk.framework.utils']/class[@name='SpUtil']/constructor[@name='SpUtil' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe SpUtil ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "()V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), null);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, null);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.iot.aep.sdk.framework.utils']/class[@name='SpUtil']/method[@name='clean' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("clean", "(Landroid/content/Context;)V", "")]
		public static unsafe void Clean (global::Android.Content.Context context)
		{
			const string __id = "clean.(Landroid/content/Context;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((context == null) ? IntPtr.Zero : ((global::Java.Lang.Object) context).Handle);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.iot.aep.sdk.framework.utils']/class[@name='SpUtil']/method[@name='getBoolean' and count(parameter)=3 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='boolean']]"
		[Register ("getBoolean", "(Landroid/content/Context;Ljava/lang/String;Z)Z", "")]
		public static unsafe bool GetBoolean (global::Android.Content.Context context, string key, bool defValue)
		{
			const string __id = "getBoolean.(Landroid/content/Context;Ljava/lang/String;Z)Z";
			IntPtr native_key = JNIEnv.NewString (key);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((context == null) ? IntPtr.Zero : ((global::Java.Lang.Object) context).Handle);
				__args [1] = new JniArgumentValue (native_key);
				__args [2] = new JniArgumentValue (defValue);
				var __rm = _members.StaticMethods.InvokeBooleanMethod (__id, __args);
				return __rm;
			} finally {
				JNIEnv.DeleteLocalRef (native_key);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.iot.aep.sdk.framework.utils']/class[@name='SpUtil']/method[@name='getInt' and count(parameter)=3 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='int']]"
		[Register ("getInt", "(Landroid/content/Context;Ljava/lang/String;I)I", "")]
		public static unsafe int GetInt (global::Android.Content.Context context, string key, int defValue)
		{
			const string __id = "getInt.(Landroid/content/Context;Ljava/lang/String;I)I";
			IntPtr native_key = JNIEnv.NewString (key);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((context == null) ? IntPtr.Zero : ((global::Java.Lang.Object) context).Handle);
				__args [1] = new JniArgumentValue (native_key);
				__args [2] = new JniArgumentValue (defValue);
				var __rm = _members.StaticMethods.InvokeInt32Method (__id, __args);
				return __rm;
			} finally {
				JNIEnv.DeleteLocalRef (native_key);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.iot.aep.sdk.framework.utils']/class[@name='SpUtil']/method[@name='getList' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.String']]"
		[Register ("getList", "(Landroid/content/Context;Ljava/lang/String;)Ljava/util/List;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"E extends java.io.Serializable"})]
		public static unsafe global::System.Collections.IList GetList (global::Android.Content.Context context, string key)
		{
			const string __id = "getList.(Landroid/content/Context;Ljava/lang/String;)Ljava/util/List;";
			IntPtr native_key = JNIEnv.NewString (key);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((context == null) ? IntPtr.Zero : ((global::Java.Lang.Object) context).Handle);
				__args [1] = new JniArgumentValue (native_key);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Android.Runtime.JavaList.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_key);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.iot.aep.sdk.framework.utils']/class[@name='SpUtil']/method[@name='getLong' and count(parameter)=3 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='long']]"
		[Register ("getLong", "(Landroid/content/Context;Ljava/lang/String;J)J", "")]
		public static unsafe long GetLong (global::Android.Content.Context context, string key, long defValue)
		{
			const string __id = "getLong.(Landroid/content/Context;Ljava/lang/String;J)J";
			IntPtr native_key = JNIEnv.NewString (key);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((context == null) ? IntPtr.Zero : ((global::Java.Lang.Object) context).Handle);
				__args [1] = new JniArgumentValue (native_key);
				__args [2] = new JniArgumentValue (defValue);
				var __rm = _members.StaticMethods.InvokeInt64Method (__id, __args);
				return __rm;
			} finally {
				JNIEnv.DeleteLocalRef (native_key);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.iot.aep.sdk.framework.utils']/class[@name='SpUtil']/method[@name='getMap' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.String']]"
		[Register ("getMap", "(Landroid/content/Context;Ljava/lang/String;)Ljava/util/Map;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"K extends java.lang.String", "V extends java.lang.String"})]
		public static unsafe global::System.Collections.IDictionary GetMap (global::Android.Content.Context context, string key)
		{
			const string __id = "getMap.(Landroid/content/Context;Ljava/lang/String;)Ljava/util/Map;";
			IntPtr native_key = JNIEnv.NewString (key);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((context == null) ? IntPtr.Zero : ((global::Java.Lang.Object) context).Handle);
				__args [1] = new JniArgumentValue (native_key);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Android.Runtime.JavaDictionary.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_key);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.iot.aep.sdk.framework.utils']/class[@name='SpUtil']/method[@name='getObject' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.String']]"
		[Register ("getObject", "(Landroid/content/Context;Ljava/lang/String;)Ljava/io/Serializable;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T extends java.io.Serializable"})]
		public static unsafe global::Java.Lang.Object GetObject (global::Android.Content.Context context, string key)
		{
			const string __id = "getObject.(Landroid/content/Context;Ljava/lang/String;)Ljava/io/Serializable;";
			IntPtr native_key = JNIEnv.NewString (key);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((context == null) ? IntPtr.Zero : ((global::Java.Lang.Object) context).Handle);
				__args [1] = new JniArgumentValue (native_key);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_key);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.iot.aep.sdk.framework.utils']/class[@name='SpUtil']/method[@name='getString' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.String']]"
		[Register ("getString", "(Landroid/content/Context;Ljava/lang/String;)Ljava/lang/String;", "")]
		public static unsafe string GetString (global::Android.Content.Context context, string key)
		{
			const string __id = "getString.(Landroid/content/Context;Ljava/lang/String;)Ljava/lang/String;";
			IntPtr native_key = JNIEnv.NewString (key);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((context == null) ? IntPtr.Zero : ((global::Java.Lang.Object) context).Handle);
				__args [1] = new JniArgumentValue (native_key);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_key);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.iot.aep.sdk.framework.utils']/class[@name='SpUtil']/method[@name='putBoolean' and count(parameter)=3 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='boolean']]"
		[Register ("putBoolean", "(Landroid/content/Context;Ljava/lang/String;Z)V", "")]
		public static unsafe void PutBoolean (global::Android.Content.Context context, string key, bool value)
		{
			const string __id = "putBoolean.(Landroid/content/Context;Ljava/lang/String;Z)V";
			IntPtr native_key = JNIEnv.NewString (key);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((context == null) ? IntPtr.Zero : ((global::Java.Lang.Object) context).Handle);
				__args [1] = new JniArgumentValue (native_key);
				__args [2] = new JniArgumentValue (value);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_key);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.iot.aep.sdk.framework.utils']/class[@name='SpUtil']/method[@name='putInt' and count(parameter)=3 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='int']]"
		[Register ("putInt", "(Landroid/content/Context;Ljava/lang/String;I)V", "")]
		public static unsafe void PutInt (global::Android.Content.Context context, string key, int value)
		{
			const string __id = "putInt.(Landroid/content/Context;Ljava/lang/String;I)V";
			IntPtr native_key = JNIEnv.NewString (key);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((context == null) ? IntPtr.Zero : ((global::Java.Lang.Object) context).Handle);
				__args [1] = new JniArgumentValue (native_key);
				__args [2] = new JniArgumentValue (value);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_key);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.iot.aep.sdk.framework.utils']/class[@name='SpUtil']/method[@name='putList' and count(parameter)=3 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.util.List&lt;? extends java.io.Serializable&gt;']]"
		[Register ("putList", "(Landroid/content/Context;Ljava/lang/String;Ljava/util/List;)V", "")]
		public static unsafe void PutList (global::Android.Content.Context context, string key, global::System.Collections.Generic.IList<global::Java.IO.ISerializable> list)
		{
			const string __id = "putList.(Landroid/content/Context;Ljava/lang/String;Ljava/util/List;)V";
			IntPtr native_key = JNIEnv.NewString (key);
			IntPtr native_list = global::Android.Runtime.JavaList<global::Java.IO.ISerializable>.ToLocalJniHandle (list);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((context == null) ? IntPtr.Zero : ((global::Java.Lang.Object) context).Handle);
				__args [1] = new JniArgumentValue (native_key);
				__args [2] = new JniArgumentValue (native_list);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_key);
				JNIEnv.DeleteLocalRef (native_list);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.iot.aep.sdk.framework.utils']/class[@name='SpUtil']/method[@name='putLong' and count(parameter)=3 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='long']]"
		[Register ("putLong", "(Landroid/content/Context;Ljava/lang/String;J)V", "")]
		public static unsafe void PutLong (global::Android.Content.Context context, string key, long value)
		{
			const string __id = "putLong.(Landroid/content/Context;Ljava/lang/String;J)V";
			IntPtr native_key = JNIEnv.NewString (key);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((context == null) ? IntPtr.Zero : ((global::Java.Lang.Object) context).Handle);
				__args [1] = new JniArgumentValue (native_key);
				__args [2] = new JniArgumentValue (value);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_key);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.iot.aep.sdk.framework.utils']/class[@name='SpUtil']/method[@name='putMap' and count(parameter)=3 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.util.Map&lt;K, V&gt;']]"
		[Register ("putMap", "(Landroid/content/Context;Ljava/lang/String;Ljava/util/Map;)V", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"K extends java.lang.String", "V extends java.lang.String"})]
		public static unsafe void PutMap (global::Android.Content.Context context, string key, global::System.Collections.IDictionary map)
		{
			const string __id = "putMap.(Landroid/content/Context;Ljava/lang/String;Ljava/util/Map;)V";
			IntPtr native_key = JNIEnv.NewString (key);
			IntPtr native_map = global::Android.Runtime.JavaDictionary.ToLocalJniHandle (map);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((context == null) ? IntPtr.Zero : ((global::Java.Lang.Object) context).Handle);
				__args [1] = new JniArgumentValue (native_key);
				__args [2] = new JniArgumentValue (native_map);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_key);
				JNIEnv.DeleteLocalRef (native_map);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.iot.aep.sdk.framework.utils']/class[@name='SpUtil']/method[@name='putObject' and count(parameter)=3 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='T']]"
		[Register ("putObject", "(Landroid/content/Context;Ljava/lang/String;Ljava/io/Serializable;)V", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T extends java.io.Serializable"})]
		public static unsafe void PutObject (global::Android.Content.Context context, string key, global::Java.Lang.Object obj)
		{
			const string __id = "putObject.(Landroid/content/Context;Ljava/lang/String;Ljava/io/Serializable;)V";
			IntPtr native_key = JNIEnv.NewString (key);
			IntPtr native_obj = JNIEnv.ToLocalJniHandle (obj);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((context == null) ? IntPtr.Zero : ((global::Java.Lang.Object) context).Handle);
				__args [1] = new JniArgumentValue (native_key);
				__args [2] = new JniArgumentValue (native_obj);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_key);
				JNIEnv.DeleteLocalRef (native_obj);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.iot.aep.sdk.framework.utils']/class[@name='SpUtil']/method[@name='putString' and count(parameter)=3 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String']]"
		[Register ("putString", "(Landroid/content/Context;Ljava/lang/String;Ljava/lang/String;)V", "")]
		public static unsafe void PutString (global::Android.Content.Context context, string key, string value)
		{
			const string __id = "putString.(Landroid/content/Context;Ljava/lang/String;Ljava/lang/String;)V";
			IntPtr native_key = JNIEnv.NewString (key);
			IntPtr native_value = JNIEnv.NewString (value);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((context == null) ? IntPtr.Zero : ((global::Java.Lang.Object) context).Handle);
				__args [1] = new JniArgumentValue (native_key);
				__args [2] = new JniArgumentValue (native_value);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_key);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.iot.aep.sdk.framework.utils']/class[@name='SpUtil']/method[@name='remove' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.String']]"
		[Register ("remove", "(Landroid/content/Context;Ljava/lang/String;)V", "")]
		public static unsafe void Remove (global::Android.Content.Context context, string key)
		{
			const string __id = "remove.(Landroid/content/Context;Ljava/lang/String;)V";
			IntPtr native_key = JNIEnv.NewString (key);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((context == null) ? IntPtr.Zero : ((global::Java.Lang.Object) context).Handle);
				__args [1] = new JniArgumentValue (native_key);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_key);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.iot.aep.sdk.framework.utils']/class[@name='SpUtil']/method[@name='remove' and count(parameter)=3 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.Object']]"
		[Register ("remove", "(Landroid/content/Context;Ljava/lang/String;Ljava/lang/Object;)V", "")]
		public static unsafe void Remove (global::Android.Content.Context context, string tag, global::Java.Lang.Object @object)
		{
			const string __id = "remove.(Landroid/content/Context;Ljava/lang/String;Ljava/lang/Object;)V";
			IntPtr native_tag = JNIEnv.NewString (tag);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((context == null) ? IntPtr.Zero : ((global::Java.Lang.Object) context).Handle);
				__args [1] = new JniArgumentValue (native_tag);
				__args [2] = new JniArgumentValue ((@object == null) ? IntPtr.Zero : ((global::Java.Lang.Object) @object).Handle);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_tag);
			}
		}

	}
}
