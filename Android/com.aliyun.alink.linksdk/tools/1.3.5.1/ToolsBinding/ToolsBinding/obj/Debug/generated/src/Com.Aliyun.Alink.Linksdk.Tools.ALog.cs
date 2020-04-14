using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Aliyun.Alink.Linksdk.Tools {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.aliyun.alink.linksdk.tools']/class[@name='ALog']"
	[global::Android.Runtime.Register ("com/aliyun/alink/linksdk/tools/ALog", DoNotGenerateAcw=true)]
	public partial class ALog : global::Java.Lang.Object {


		// Metadata.xml XPath field reference: path="/api/package[@name='com.aliyun.alink.linksdk.tools']/class[@name='ALog']/field[@name='LEVEL_DEBUG']"
		[Register ("LEVEL_DEBUG")]
		public const sbyte LevelDebug = (sbyte) 1;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.aliyun.alink.linksdk.tools']/class[@name='ALog']/field[@name='LEVEL_ERROR']"
		[Register ("LEVEL_ERROR")]
		public const sbyte LevelError = (sbyte) 4;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.aliyun.alink.linksdk.tools']/class[@name='ALog']/field[@name='LEVEL_INFO']"
		[Register ("LEVEL_INFO")]
		public const sbyte LevelInfo = (sbyte) 2;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.aliyun.alink.linksdk.tools']/class[@name='ALog']/field[@name='LEVEL_WARNING']"
		[Register ("LEVEL_WARNING")]
		public const sbyte LevelWarning = (sbyte) 3;
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/aliyun/alink/linksdk/tools/ALog", typeof (ALog));
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

		protected ALog (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.aliyun.alink.linksdk.tools']/class[@name='ALog']/constructor[@name='ALog' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe ALog ()
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

		public static unsafe sbyte Level {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.tools']/class[@name='ALog']/method[@name='getLevel' and count(parameter)=0]"
			[Register ("getLevel", "()B", "")]
			get {
				const string __id = "getLevel.()B";
				try {
					var __rm = _members.StaticMethods.InvokeSByteMethod (__id, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.tools']/class[@name='ALog']/method[@name='setLevel' and count(parameter)=1 and parameter[1][@type='byte']]"
			[Register ("setLevel", "(B)V", "")]
			set {
				const string __id = "setLevel.(B)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.StaticMethods.InvokeVoidMethod (__id, __args);
				} finally {
				}
			}
		}

		public static unsafe global::Com.Aliyun.Alink.Linksdk.Tools.Log.LogStrategyType LogStrategyType {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.tools']/class[@name='ALog']/method[@name='getLogStrategyType' and count(parameter)=0]"
			[Register ("getLogStrategyType", "()Lcom/aliyun/alink/linksdk/tools/log/LogStrategyType;", "")]
			get {
				const string __id = "getLogStrategyType.()Lcom/aliyun/alink/linksdk/tools/log/LogStrategyType;";
				try {
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
					return global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Tools.Log.LogStrategyType> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.tools']/class[@name='ALog']/method[@name='setLogStrategyType' and count(parameter)=1 and parameter[1][@type='com.aliyun.alink.linksdk.tools.log.LogStrategyType']]"
			[Register ("setLogStrategyType", "(Lcom/aliyun/alink/linksdk/tools/log/LogStrategyType;)V", "")]
			set {
				const string __id = "setLogStrategyType.(Lcom/aliyun/alink/linksdk/tools/log/LogStrategyType;)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((value == null) ? IntPtr.Zero : ((global::Java.Lang.Object) value).Handle);
					_members.StaticMethods.InvokeVoidMethod (__id, __args);
				} finally {
				}
			}
		}

		public static unsafe global::Com.Aliyun.Alink.Linksdk.Tools.Log.ILogUpload LogUpload {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.tools']/class[@name='ALog']/method[@name='getLogUpload' and count(parameter)=0]"
			[Register ("getLogUpload", "()Lcom/aliyun/alink/linksdk/tools/log/ILogUpload;", "")]
			get {
				const string __id = "getLogUpload.()Lcom/aliyun/alink/linksdk/tools/log/ILogUpload;";
				try {
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
					return global::Java.Lang.Object.GetObject<global::Com.Aliyun.Alink.Linksdk.Tools.Log.ILogUpload> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.tools']/class[@name='ALog']/method[@name='setLogUpload' and count(parameter)=1 and parameter[1][@type='com.aliyun.alink.linksdk.tools.log.ILogUpload']]"
			[Register ("setLogUpload", "(Lcom/aliyun/alink/linksdk/tools/log/ILogUpload;)V", "")]
			set {
				const string __id = "setLogUpload.(Lcom/aliyun/alink/linksdk/tools/log/ILogUpload;)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((value == null) ? IntPtr.Zero : ((global::Java.Lang.Object) value).Handle);
					_members.StaticMethods.InvokeVoidMethod (__id, __args);
				} finally {
				}
			}
		}

		public static unsafe sbyte UploadLevel {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.tools']/class[@name='ALog']/method[@name='getUploadLevel' and count(parameter)=0]"
			[Register ("getUploadLevel", "()B", "")]
			get {
				const string __id = "getUploadLevel.()B";
				try {
					var __rm = _members.StaticMethods.InvokeSByteMethod (__id, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.tools']/class[@name='ALog']/method[@name='setUploadLevel' and count(parameter)=1 and parameter[1][@type='byte']]"
			[Register ("setUploadLevel", "(B)V", "")]
			set {
				const string __id = "setUploadLevel.(B)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.StaticMethods.InvokeVoidMethod (__id, __args);
				} finally {
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.tools']/class[@name='ALog']/method[@name='d' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("d", "(Ljava/lang/String;Ljava/lang/String;)V", "")]
		public static unsafe void D (string tag, string msg)
		{
			const string __id = "d.(Ljava/lang/String;Ljava/lang/String;)V";
			IntPtr native_tag = JNIEnv.NewString (tag);
			IntPtr native_msg = JNIEnv.NewString (msg);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_tag);
				__args [1] = new JniArgumentValue (native_msg);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_tag);
				JNIEnv.DeleteLocalRef (native_msg);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.tools']/class[@name='ALog']/method[@name='e' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("e", "(Ljava/lang/String;Ljava/lang/String;)V", "")]
		public static unsafe void E (string tag, string msg)
		{
			const string __id = "e.(Ljava/lang/String;Ljava/lang/String;)V";
			IntPtr native_tag = JNIEnv.NewString (tag);
			IntPtr native_msg = JNIEnv.NewString (msg);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_tag);
				__args [1] = new JniArgumentValue (native_msg);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_tag);
				JNIEnv.DeleteLocalRef (native_msg);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.tools']/class[@name='ALog']/method[@name='e' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.Exception']]"
		[Register ("e", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/Exception;)V", "")]
		public static unsafe void E (string tag, string @where, global::Java.Lang.Exception ex)
		{
			const string __id = "e.(Ljava/lang/String;Ljava/lang/String;Ljava/lang/Exception;)V";
			IntPtr native_tag = JNIEnv.NewString (tag);
			IntPtr native__where = JNIEnv.NewString (@where);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (native_tag);
				__args [1] = new JniArgumentValue (native__where);
				__args [2] = new JniArgumentValue ((ex == null) ? IntPtr.Zero : ((global::Java.Lang.Throwable) ex).Handle);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_tag);
				JNIEnv.DeleteLocalRef (native__where);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.tools']/class[@name='ALog']/method[@name='e' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String']]"
		[Register ("e", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V", "")]
		public static unsafe void E (string tag, string @where, string msg)
		{
			const string __id = "e.(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V";
			IntPtr native_tag = JNIEnv.NewString (tag);
			IntPtr native__where = JNIEnv.NewString (@where);
			IntPtr native_msg = JNIEnv.NewString (msg);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (native_tag);
				__args [1] = new JniArgumentValue (native__where);
				__args [2] = new JniArgumentValue (native_msg);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_tag);
				JNIEnv.DeleteLocalRef (native__where);
				JNIEnv.DeleteLocalRef (native_msg);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.tools']/class[@name='ALog']/method[@name='i' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("i", "(Ljava/lang/String;Ljava/lang/String;)V", "")]
		public static unsafe void I (string tag, string msg)
		{
			const string __id = "i.(Ljava/lang/String;Ljava/lang/String;)V";
			IntPtr native_tag = JNIEnv.NewString (tag);
			IntPtr native_msg = JNIEnv.NewString (msg);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_tag);
				__args [1] = new JniArgumentValue (native_msg);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_tag);
				JNIEnv.DeleteLocalRef (native_msg);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.tools']/class[@name='ALog']/method[@name='llog' and count(parameter)=3 and parameter[1][@type='byte'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String']]"
		[Register ("llog", "(BLjava/lang/String;Ljava/lang/String;)V", "")]
		public static unsafe void Llog (sbyte priority, string tag, string msg)
		{
			const string __id = "llog.(BLjava/lang/String;Ljava/lang/String;)V";
			IntPtr native_tag = JNIEnv.NewString (tag);
			IntPtr native_msg = JNIEnv.NewString (msg);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (priority);
				__args [1] = new JniArgumentValue (native_tag);
				__args [2] = new JniArgumentValue (native_msg);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_tag);
				JNIEnv.DeleteLocalRef (native_msg);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.tools']/class[@name='ALog']/method[@name='makeLogTag' and count(parameter)=1 and parameter[1][@type='java.lang.Class']]"
		[Register ("makeLogTag", "(Ljava/lang/Class;)Ljava/lang/String;", "")]
		public static unsafe string MakeLogTag (global::Java.Lang.Class cls)
		{
			const string __id = "makeLogTag.(Ljava/lang/Class;)Ljava/lang/String;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((cls == null) ? IntPtr.Zero : ((global::Java.Lang.Object) cls).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.tools']/class[@name='ALog']/method[@name='makeLogTag' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("makeLogTag", "(Ljava/lang/String;)Ljava/lang/String;", "")]
		public static unsafe string MakeLogTag (string str)
		{
			const string __id = "makeLogTag.(Ljava/lang/String;)Ljava/lang/String;";
			IntPtr native_str = JNIEnv.NewString (str);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_str);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_str);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.tools']/class[@name='ALog']/method[@name='setLogDispatcher' and count(parameter)=1 and parameter[1][@type='com.aliyun.alink.linksdk.tools.log.ILogDispatcher']]"
		[Register ("setLogDispatcher", "(Lcom/aliyun/alink/linksdk/tools/log/ILogDispatcher;)V", "")]
		public static unsafe void SetLogDispatcher (global::Com.Aliyun.Alink.Linksdk.Tools.Log.ILogDispatcher logDispatcher)
		{
			const string __id = "setLogDispatcher.(Lcom/aliyun/alink/linksdk/tools/log/ILogDispatcher;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((logDispatcher == null) ? IntPtr.Zero : ((global::Java.Lang.Object) logDispatcher).Handle);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.alink.linksdk.tools']/class[@name='ALog']/method[@name='w' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("w", "(Ljava/lang/String;Ljava/lang/String;)V", "")]
		public static unsafe void W (string tag, string msg)
		{
			const string __id = "w.(Ljava/lang/String;Ljava/lang/String;)V";
			IntPtr native_tag = JNIEnv.NewString (tag);
			IntPtr native_msg = JNIEnv.NewString (msg);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_tag);
				__args [1] = new JniArgumentValue (native_msg);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_tag);
				JNIEnv.DeleteLocalRef (native_msg);
			}
		}

	}
}
