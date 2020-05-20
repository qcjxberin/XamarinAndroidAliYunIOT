using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Org.Eclipse.Paho.Client.Mqttv3.Logging {

	[Register ("org/eclipse/paho/client/mqttv3/logging/Logger", DoNotGenerateAcw=true)]
	public abstract class Logger : Java.Lang.Object {

		internal Logger ()
		{
		}
	}

	[Register ("org/eclipse/paho/client/mqttv3/logging/Logger", DoNotGenerateAcw=true)]
	[global::System.Obsolete ("Use the 'Logger' type. This type will be removed in a future release.", error: true)]
	public abstract class LoggerConsts : Logger {

		private LoggerConsts ()
		{
		}
	}

	// Metadata.xml XPath interface reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.logging']/interface[@name='Logger']"
	[Register ("org/eclipse/paho/client/mqttv3/logging/Logger", "", "Org.Eclipse.Paho.Client.Mqttv3.Logging.ILoggerInvoker")]
	public partial interface ILogger : IJavaObject, IJavaPeerable {

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.logging']/interface[@name='Logger']/method[@name='config' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String']]"
		[Register ("config", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V", "GetConfig_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Handler:Org.Eclipse.Paho.Client.Mqttv3.Logging.ILoggerInvoker, OpenSourcePahoBinding")]
		void Config (string p0, string p1, string p2);

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.logging']/interface[@name='Logger']/method[@name='config' and count(parameter)=4 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='java.lang.Object[]']]"
		[Register ("config", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;[Ljava/lang/Object;)V", "GetConfig_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_arrayLjava_lang_Object_Handler:Org.Eclipse.Paho.Client.Mqttv3.Logging.ILoggerInvoker, OpenSourcePahoBinding")]
		void Config (string p0, string p1, string p2, global::Java.Lang.Object[] p3);

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.logging']/interface[@name='Logger']/method[@name='config' and count(parameter)=5 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='java.lang.Object[]'] and parameter[5][@type='java.lang.Throwable']]"
		[Register ("config", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;[Ljava/lang/Object;Ljava/lang/Throwable;)V", "GetConfig_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_arrayLjava_lang_Object_Ljava_lang_Throwable_Handler:Org.Eclipse.Paho.Client.Mqttv3.Logging.ILoggerInvoker, OpenSourcePahoBinding")]
		void Config (string p0, string p1, string p2, global::Java.Lang.Object[] p3, global::Java.Lang.Throwable p4);

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.logging']/interface[@name='Logger']/method[@name='dumpTrace' and count(parameter)=0]"
		[Register ("dumpTrace", "()V", "GetDumpTraceHandler:Org.Eclipse.Paho.Client.Mqttv3.Logging.ILoggerInvoker, OpenSourcePahoBinding")]
		void DumpTrace ();

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.logging']/interface[@name='Logger']/method[@name='fine' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String']]"
		[Register ("fine", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V", "GetFine_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Handler:Org.Eclipse.Paho.Client.Mqttv3.Logging.ILoggerInvoker, OpenSourcePahoBinding")]
		void Fine (string p0, string p1, string p2);

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.logging']/interface[@name='Logger']/method[@name='fine' and count(parameter)=4 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='java.lang.Object[]']]"
		[Register ("fine", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;[Ljava/lang/Object;)V", "GetFine_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_arrayLjava_lang_Object_Handler:Org.Eclipse.Paho.Client.Mqttv3.Logging.ILoggerInvoker, OpenSourcePahoBinding")]
		void Fine (string p0, string p1, string p2, global::Java.Lang.Object[] p3);

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.logging']/interface[@name='Logger']/method[@name='fine' and count(parameter)=5 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='java.lang.Object[]'] and parameter[5][@type='java.lang.Throwable']]"
		[Register ("fine", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;[Ljava/lang/Object;Ljava/lang/Throwable;)V", "GetFine_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_arrayLjava_lang_Object_Ljava_lang_Throwable_Handler:Org.Eclipse.Paho.Client.Mqttv3.Logging.ILoggerInvoker, OpenSourcePahoBinding")]
		void Fine (string p0, string p1, string p2, global::Java.Lang.Object[] p3, global::Java.Lang.Throwable p4);

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.logging']/interface[@name='Logger']/method[@name='finer' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String']]"
		[Register ("finer", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V", "GetFiner_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Handler:Org.Eclipse.Paho.Client.Mqttv3.Logging.ILoggerInvoker, OpenSourcePahoBinding")]
		void Finer (string p0, string p1, string p2);

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.logging']/interface[@name='Logger']/method[@name='finer' and count(parameter)=4 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='java.lang.Object[]']]"
		[Register ("finer", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;[Ljava/lang/Object;)V", "GetFiner_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_arrayLjava_lang_Object_Handler:Org.Eclipse.Paho.Client.Mqttv3.Logging.ILoggerInvoker, OpenSourcePahoBinding")]
		void Finer (string p0, string p1, string p2, global::Java.Lang.Object[] p3);

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.logging']/interface[@name='Logger']/method[@name='finer' and count(parameter)=5 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='java.lang.Object[]'] and parameter[5][@type='java.lang.Throwable']]"
		[Register ("finer", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;[Ljava/lang/Object;Ljava/lang/Throwable;)V", "GetFiner_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_arrayLjava_lang_Object_Ljava_lang_Throwable_Handler:Org.Eclipse.Paho.Client.Mqttv3.Logging.ILoggerInvoker, OpenSourcePahoBinding")]
		void Finer (string p0, string p1, string p2, global::Java.Lang.Object[] p3, global::Java.Lang.Throwable p4);

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.logging']/interface[@name='Logger']/method[@name='finest' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String']]"
		[Register ("finest", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V", "GetFinest_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Handler:Org.Eclipse.Paho.Client.Mqttv3.Logging.ILoggerInvoker, OpenSourcePahoBinding")]
		void Finest (string p0, string p1, string p2);

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.logging']/interface[@name='Logger']/method[@name='finest' and count(parameter)=4 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='java.lang.Object[]']]"
		[Register ("finest", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;[Ljava/lang/Object;)V", "GetFinest_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_arrayLjava_lang_Object_Handler:Org.Eclipse.Paho.Client.Mqttv3.Logging.ILoggerInvoker, OpenSourcePahoBinding")]
		void Finest (string p0, string p1, string p2, global::Java.Lang.Object[] p3);

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.logging']/interface[@name='Logger']/method[@name='finest' and count(parameter)=5 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='java.lang.Object[]'] and parameter[5][@type='java.lang.Throwable']]"
		[Register ("finest", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;[Ljava/lang/Object;Ljava/lang/Throwable;)V", "GetFinest_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_arrayLjava_lang_Object_Ljava_lang_Throwable_Handler:Org.Eclipse.Paho.Client.Mqttv3.Logging.ILoggerInvoker, OpenSourcePahoBinding")]
		void Finest (string p0, string p1, string p2, global::Java.Lang.Object[] p3, global::Java.Lang.Throwable p4);

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.logging']/interface[@name='Logger']/method[@name='formatMessage' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.Object[]']]"
		[Register ("formatMessage", "(Ljava/lang/String;[Ljava/lang/Object;)Ljava/lang/String;", "GetFormatMessage_Ljava_lang_String_arrayLjava_lang_Object_Handler:Org.Eclipse.Paho.Client.Mqttv3.Logging.ILoggerInvoker, OpenSourcePahoBinding")]
		string FormatMessage (string p0, global::Java.Lang.Object[] p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.logging']/interface[@name='Logger']/method[@name='info' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String']]"
		[Register ("info", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V", "GetInfo_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Handler:Org.Eclipse.Paho.Client.Mqttv3.Logging.ILoggerInvoker, OpenSourcePahoBinding")]
		void Info (string p0, string p1, string p2);

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.logging']/interface[@name='Logger']/method[@name='info' and count(parameter)=4 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='java.lang.Object[]']]"
		[Register ("info", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;[Ljava/lang/Object;)V", "GetInfo_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_arrayLjava_lang_Object_Handler:Org.Eclipse.Paho.Client.Mqttv3.Logging.ILoggerInvoker, OpenSourcePahoBinding")]
		void Info (string p0, string p1, string p2, global::Java.Lang.Object[] p3);

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.logging']/interface[@name='Logger']/method[@name='info' and count(parameter)=5 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='java.lang.Object[]'] and parameter[5][@type='java.lang.Throwable']]"
		[Register ("info", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;[Ljava/lang/Object;Ljava/lang/Throwable;)V", "GetInfo_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_arrayLjava_lang_Object_Ljava_lang_Throwable_Handler:Org.Eclipse.Paho.Client.Mqttv3.Logging.ILoggerInvoker, OpenSourcePahoBinding")]
		void Info (string p0, string p1, string p2, global::Java.Lang.Object[] p3, global::Java.Lang.Throwable p4);

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.logging']/interface[@name='Logger']/method[@name='initialise' and count(parameter)=3 and parameter[1][@type='java.util.ResourceBundle'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String']]"
		[Register ("initialise", "(Ljava/util/ResourceBundle;Ljava/lang/String;Ljava/lang/String;)V", "GetInitialise_Ljava_util_ResourceBundle_Ljava_lang_String_Ljava_lang_String_Handler:Org.Eclipse.Paho.Client.Mqttv3.Logging.ILoggerInvoker, OpenSourcePahoBinding")]
		void Initialise (global::Java.Util.ResourceBundle p0, string p1, string p2);

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.logging']/interface[@name='Logger']/method[@name='isLoggable' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("isLoggable", "(I)Z", "GetIsLoggable_IHandler:Org.Eclipse.Paho.Client.Mqttv3.Logging.ILoggerInvoker, OpenSourcePahoBinding")]
		bool IsLoggable (int p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.logging']/interface[@name='Logger']/method[@name='log' and count(parameter)=6 and parameter[1][@type='int'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='java.lang.String'] and parameter[5][@type='java.lang.Object[]'] and parameter[6][@type='java.lang.Throwable']]"
		[Register ("log", "(ILjava/lang/String;Ljava/lang/String;Ljava/lang/String;[Ljava/lang/Object;Ljava/lang/Throwable;)V", "GetLog_ILjava_lang_String_Ljava_lang_String_Ljava_lang_String_arrayLjava_lang_Object_Ljava_lang_Throwable_Handler:Org.Eclipse.Paho.Client.Mqttv3.Logging.ILoggerInvoker, OpenSourcePahoBinding")]
		void Log (int p0, string p1, string p2, string p3, global::Java.Lang.Object[] p4, global::Java.Lang.Throwable p5);

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.logging']/interface[@name='Logger']/method[@name='setResourceName' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("setResourceName", "(Ljava/lang/String;)V", "GetSetResourceName_Ljava_lang_String_Handler:Org.Eclipse.Paho.Client.Mqttv3.Logging.ILoggerInvoker, OpenSourcePahoBinding")]
		void SetResourceName (string p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.logging']/interface[@name='Logger']/method[@name='severe' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String']]"
		[Register ("severe", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V", "GetSevere_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Handler:Org.Eclipse.Paho.Client.Mqttv3.Logging.ILoggerInvoker, OpenSourcePahoBinding")]
		void Severe (string p0, string p1, string p2);

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.logging']/interface[@name='Logger']/method[@name='severe' and count(parameter)=4 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='java.lang.Object[]']]"
		[Register ("severe", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;[Ljava/lang/Object;)V", "GetSevere_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_arrayLjava_lang_Object_Handler:Org.Eclipse.Paho.Client.Mqttv3.Logging.ILoggerInvoker, OpenSourcePahoBinding")]
		void Severe (string p0, string p1, string p2, global::Java.Lang.Object[] p3);

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.logging']/interface[@name='Logger']/method[@name='severe' and count(parameter)=5 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='java.lang.Object[]'] and parameter[5][@type='java.lang.Throwable']]"
		[Register ("severe", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;[Ljava/lang/Object;Ljava/lang/Throwable;)V", "GetSevere_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_arrayLjava_lang_Object_Ljava_lang_Throwable_Handler:Org.Eclipse.Paho.Client.Mqttv3.Logging.ILoggerInvoker, OpenSourcePahoBinding")]
		void Severe (string p0, string p1, string p2, global::Java.Lang.Object[] p3, global::Java.Lang.Throwable p4);

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.logging']/interface[@name='Logger']/method[@name='trace' and count(parameter)=6 and parameter[1][@type='int'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='java.lang.String'] and parameter[5][@type='java.lang.Object[]'] and parameter[6][@type='java.lang.Throwable']]"
		[Register ("trace", "(ILjava/lang/String;Ljava/lang/String;Ljava/lang/String;[Ljava/lang/Object;Ljava/lang/Throwable;)V", "GetTrace_ILjava_lang_String_Ljava_lang_String_Ljava_lang_String_arrayLjava_lang_Object_Ljava_lang_Throwable_Handler:Org.Eclipse.Paho.Client.Mqttv3.Logging.ILoggerInvoker, OpenSourcePahoBinding")]
		void Trace (int p0, string p1, string p2, string p3, global::Java.Lang.Object[] p4, global::Java.Lang.Throwable p5);

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.logging']/interface[@name='Logger']/method[@name='warning' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String']]"
		[Register ("warning", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V", "GetWarning_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Handler:Org.Eclipse.Paho.Client.Mqttv3.Logging.ILoggerInvoker, OpenSourcePahoBinding")]
		void Warning (string p0, string p1, string p2);

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.logging']/interface[@name='Logger']/method[@name='warning' and count(parameter)=4 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='java.lang.Object[]']]"
		[Register ("warning", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;[Ljava/lang/Object;)V", "GetWarning_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_arrayLjava_lang_Object_Handler:Org.Eclipse.Paho.Client.Mqttv3.Logging.ILoggerInvoker, OpenSourcePahoBinding")]
		void Warning (string p0, string p1, string p2, global::Java.Lang.Object[] p3);

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.logging']/interface[@name='Logger']/method[@name='warning' and count(parameter)=5 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='java.lang.Object[]'] and parameter[5][@type='java.lang.Throwable']]"
		[Register ("warning", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;[Ljava/lang/Object;Ljava/lang/Throwable;)V", "GetWarning_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_arrayLjava_lang_Object_Ljava_lang_Throwable_Handler:Org.Eclipse.Paho.Client.Mqttv3.Logging.ILoggerInvoker, OpenSourcePahoBinding")]
		void Warning (string p0, string p1, string p2, global::Java.Lang.Object[] p3, global::Java.Lang.Throwable p4);

	}

	[global::Android.Runtime.Register ("org/eclipse/paho/client/mqttv3/logging/Logger", DoNotGenerateAcw=true)]
	internal partial class ILoggerInvoker : global::Java.Lang.Object, ILogger {

		static readonly JniPeerMembers _members = new XAPeerMembers ("org/eclipse/paho/client/mqttv3/logging/Logger", typeof (ILoggerInvoker));

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

		public static ILogger GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<ILogger> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "org.eclipse.paho.client.mqttv3.logging.Logger"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public ILoggerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_config_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetConfig_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_config_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ == null)
				cb_config_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_Config_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_);
			return cb_config_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_;
		}

		static void n_Config_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2)
		{
			global::Org.Eclipse.Paho.Client.Mqttv3.Logging.ILogger __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.Logging.ILogger> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			string p2 = JNIEnv.GetString (native_p2, JniHandleOwnership.DoNotTransfer);
			__this.Config (p0, p1, p2);
		}
#pragma warning restore 0169

		IntPtr id_config_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_;
		public unsafe void Config (string p0, string p1, string p2)
		{
			if (id_config_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_config_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "config", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p2 = JNIEnv.NewString (p2);
			JValue* __args = stackalloc JValue [3];
			__args [0] = new JValue (native_p0);
			__args [1] = new JValue (native_p1);
			__args [2] = new JValue (native_p2);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_config_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_, __args);
			JNIEnv.DeleteLocalRef (native_p0);
			JNIEnv.DeleteLocalRef (native_p1);
			JNIEnv.DeleteLocalRef (native_p2);
		}

		static Delegate cb_config_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_arrayLjava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetConfig_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_arrayLjava_lang_Object_Handler ()
		{
			if (cb_config_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_arrayLjava_lang_Object_ == null)
				cb_config_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_arrayLjava_lang_Object_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_Config_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_arrayLjava_lang_Object_);
			return cb_config_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_arrayLjava_lang_Object_;
		}

		static void n_Config_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_arrayLjava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2, IntPtr native_p3)
		{
			global::Org.Eclipse.Paho.Client.Mqttv3.Logging.ILogger __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.Logging.ILogger> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			string p2 = JNIEnv.GetString (native_p2, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object[] p3 = (global::Java.Lang.Object[]) JNIEnv.GetArray (native_p3, JniHandleOwnership.DoNotTransfer, typeof (global::Java.Lang.Object));
			__this.Config (p0, p1, p2, p3);
			if (p3 != null)
				JNIEnv.CopyArray (p3, native_p3);
		}
#pragma warning restore 0169

		IntPtr id_config_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_arrayLjava_lang_Object_;
		public unsafe void Config (string p0, string p1, string p2, global::Java.Lang.Object[] p3)
		{
			if (id_config_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_arrayLjava_lang_Object_ == IntPtr.Zero)
				id_config_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_arrayLjava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "config", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;[Ljava/lang/Object;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p2 = JNIEnv.NewString (p2);
			IntPtr native_p3 = JNIEnv.NewArray (p3);
			JValue* __args = stackalloc JValue [4];
			__args [0] = new JValue (native_p0);
			__args [1] = new JValue (native_p1);
			__args [2] = new JValue (native_p2);
			__args [3] = new JValue (native_p3);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_config_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_arrayLjava_lang_Object_, __args);
			JNIEnv.DeleteLocalRef (native_p0);
			JNIEnv.DeleteLocalRef (native_p1);
			JNIEnv.DeleteLocalRef (native_p2);
			if (p3 != null) {
				JNIEnv.CopyArray (native_p3, p3);
				JNIEnv.DeleteLocalRef (native_p3);
			}
		}

		static Delegate cb_config_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_arrayLjava_lang_Object_Ljava_lang_Throwable_;
#pragma warning disable 0169
		static Delegate GetConfig_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_arrayLjava_lang_Object_Ljava_lang_Throwable_Handler ()
		{
			if (cb_config_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_arrayLjava_lang_Object_Ljava_lang_Throwable_ == null)
				cb_config_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_arrayLjava_lang_Object_Ljava_lang_Throwable_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_Config_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_arrayLjava_lang_Object_Ljava_lang_Throwable_);
			return cb_config_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_arrayLjava_lang_Object_Ljava_lang_Throwable_;
		}

		static void n_Config_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_arrayLjava_lang_Object_Ljava_lang_Throwable_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2, IntPtr native_p3, IntPtr native_p4)
		{
			global::Org.Eclipse.Paho.Client.Mqttv3.Logging.ILogger __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.Logging.ILogger> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			string p2 = JNIEnv.GetString (native_p2, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object[] p3 = (global::Java.Lang.Object[]) JNIEnv.GetArray (native_p3, JniHandleOwnership.DoNotTransfer, typeof (global::Java.Lang.Object));
			global::Java.Lang.Throwable p4 = global::Java.Lang.Object.GetObject<global::Java.Lang.Throwable> (native_p4, JniHandleOwnership.DoNotTransfer);
			__this.Config (p0, p1, p2, p3, p4);
			if (p3 != null)
				JNIEnv.CopyArray (p3, native_p3);
		}
#pragma warning restore 0169

		IntPtr id_config_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_arrayLjava_lang_Object_Ljava_lang_Throwable_;
		public unsafe void Config (string p0, string p1, string p2, global::Java.Lang.Object[] p3, global::Java.Lang.Throwable p4)
		{
			if (id_config_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_arrayLjava_lang_Object_Ljava_lang_Throwable_ == IntPtr.Zero)
				id_config_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_arrayLjava_lang_Object_Ljava_lang_Throwable_ = JNIEnv.GetMethodID (class_ref, "config", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;[Ljava/lang/Object;Ljava/lang/Throwable;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p2 = JNIEnv.NewString (p2);
			IntPtr native_p3 = JNIEnv.NewArray (p3);
			JValue* __args = stackalloc JValue [5];
			__args [0] = new JValue (native_p0);
			__args [1] = new JValue (native_p1);
			__args [2] = new JValue (native_p2);
			__args [3] = new JValue (native_p3);
			__args [4] = new JValue ((p4 == null) ? IntPtr.Zero : ((global::Java.Lang.Throwable) p4).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_config_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_arrayLjava_lang_Object_Ljava_lang_Throwable_, __args);
			JNIEnv.DeleteLocalRef (native_p0);
			JNIEnv.DeleteLocalRef (native_p1);
			JNIEnv.DeleteLocalRef (native_p2);
			if (p3 != null) {
				JNIEnv.CopyArray (native_p3, p3);
				JNIEnv.DeleteLocalRef (native_p3);
			}
		}

		static Delegate cb_dumpTrace;
#pragma warning disable 0169
		static Delegate GetDumpTraceHandler ()
		{
			if (cb_dumpTrace == null)
				cb_dumpTrace = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_DumpTrace);
			return cb_dumpTrace;
		}

		static void n_DumpTrace (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Eclipse.Paho.Client.Mqttv3.Logging.ILogger __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.Logging.ILogger> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.DumpTrace ();
		}
#pragma warning restore 0169

		IntPtr id_dumpTrace;
		public unsafe void DumpTrace ()
		{
			if (id_dumpTrace == IntPtr.Zero)
				id_dumpTrace = JNIEnv.GetMethodID (class_ref, "dumpTrace", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_dumpTrace);
		}

		static Delegate cb_fine_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetFine_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_fine_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ == null)
				cb_fine_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_Fine_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_);
			return cb_fine_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_;
		}

		static void n_Fine_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2)
		{
			global::Org.Eclipse.Paho.Client.Mqttv3.Logging.ILogger __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.Logging.ILogger> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			string p2 = JNIEnv.GetString (native_p2, JniHandleOwnership.DoNotTransfer);
			__this.Fine (p0, p1, p2);
		}
#pragma warning restore 0169

		IntPtr id_fine_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_;
		public unsafe void Fine (string p0, string p1, string p2)
		{
			if (id_fine_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_fine_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "fine", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p2 = JNIEnv.NewString (p2);
			JValue* __args = stackalloc JValue [3];
			__args [0] = new JValue (native_p0);
			__args [1] = new JValue (native_p1);
			__args [2] = new JValue (native_p2);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_fine_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_, __args);
			JNIEnv.DeleteLocalRef (native_p0);
			JNIEnv.DeleteLocalRef (native_p1);
			JNIEnv.DeleteLocalRef (native_p2);
		}

		static Delegate cb_fine_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_arrayLjava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetFine_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_arrayLjava_lang_Object_Handler ()
		{
			if (cb_fine_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_arrayLjava_lang_Object_ == null)
				cb_fine_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_arrayLjava_lang_Object_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_Fine_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_arrayLjava_lang_Object_);
			return cb_fine_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_arrayLjava_lang_Object_;
		}

		static void n_Fine_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_arrayLjava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2, IntPtr native_p3)
		{
			global::Org.Eclipse.Paho.Client.Mqttv3.Logging.ILogger __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.Logging.ILogger> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			string p2 = JNIEnv.GetString (native_p2, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object[] p3 = (global::Java.Lang.Object[]) JNIEnv.GetArray (native_p3, JniHandleOwnership.DoNotTransfer, typeof (global::Java.Lang.Object));
			__this.Fine (p0, p1, p2, p3);
			if (p3 != null)
				JNIEnv.CopyArray (p3, native_p3);
		}
#pragma warning restore 0169

		IntPtr id_fine_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_arrayLjava_lang_Object_;
		public unsafe void Fine (string p0, string p1, string p2, global::Java.Lang.Object[] p3)
		{
			if (id_fine_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_arrayLjava_lang_Object_ == IntPtr.Zero)
				id_fine_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_arrayLjava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "fine", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;[Ljava/lang/Object;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p2 = JNIEnv.NewString (p2);
			IntPtr native_p3 = JNIEnv.NewArray (p3);
			JValue* __args = stackalloc JValue [4];
			__args [0] = new JValue (native_p0);
			__args [1] = new JValue (native_p1);
			__args [2] = new JValue (native_p2);
			__args [3] = new JValue (native_p3);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_fine_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_arrayLjava_lang_Object_, __args);
			JNIEnv.DeleteLocalRef (native_p0);
			JNIEnv.DeleteLocalRef (native_p1);
			JNIEnv.DeleteLocalRef (native_p2);
			if (p3 != null) {
				JNIEnv.CopyArray (native_p3, p3);
				JNIEnv.DeleteLocalRef (native_p3);
			}
		}

		static Delegate cb_fine_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_arrayLjava_lang_Object_Ljava_lang_Throwable_;
#pragma warning disable 0169
		static Delegate GetFine_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_arrayLjava_lang_Object_Ljava_lang_Throwable_Handler ()
		{
			if (cb_fine_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_arrayLjava_lang_Object_Ljava_lang_Throwable_ == null)
				cb_fine_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_arrayLjava_lang_Object_Ljava_lang_Throwable_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_Fine_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_arrayLjava_lang_Object_Ljava_lang_Throwable_);
			return cb_fine_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_arrayLjava_lang_Object_Ljava_lang_Throwable_;
		}

		static void n_Fine_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_arrayLjava_lang_Object_Ljava_lang_Throwable_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2, IntPtr native_p3, IntPtr native_p4)
		{
			global::Org.Eclipse.Paho.Client.Mqttv3.Logging.ILogger __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.Logging.ILogger> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			string p2 = JNIEnv.GetString (native_p2, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object[] p3 = (global::Java.Lang.Object[]) JNIEnv.GetArray (native_p3, JniHandleOwnership.DoNotTransfer, typeof (global::Java.Lang.Object));
			global::Java.Lang.Throwable p4 = global::Java.Lang.Object.GetObject<global::Java.Lang.Throwable> (native_p4, JniHandleOwnership.DoNotTransfer);
			__this.Fine (p0, p1, p2, p3, p4);
			if (p3 != null)
				JNIEnv.CopyArray (p3, native_p3);
		}
#pragma warning restore 0169

		IntPtr id_fine_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_arrayLjava_lang_Object_Ljava_lang_Throwable_;
		public unsafe void Fine (string p0, string p1, string p2, global::Java.Lang.Object[] p3, global::Java.Lang.Throwable p4)
		{
			if (id_fine_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_arrayLjava_lang_Object_Ljava_lang_Throwable_ == IntPtr.Zero)
				id_fine_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_arrayLjava_lang_Object_Ljava_lang_Throwable_ = JNIEnv.GetMethodID (class_ref, "fine", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;[Ljava/lang/Object;Ljava/lang/Throwable;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p2 = JNIEnv.NewString (p2);
			IntPtr native_p3 = JNIEnv.NewArray (p3);
			JValue* __args = stackalloc JValue [5];
			__args [0] = new JValue (native_p0);
			__args [1] = new JValue (native_p1);
			__args [2] = new JValue (native_p2);
			__args [3] = new JValue (native_p3);
			__args [4] = new JValue ((p4 == null) ? IntPtr.Zero : ((global::Java.Lang.Throwable) p4).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_fine_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_arrayLjava_lang_Object_Ljava_lang_Throwable_, __args);
			JNIEnv.DeleteLocalRef (native_p0);
			JNIEnv.DeleteLocalRef (native_p1);
			JNIEnv.DeleteLocalRef (native_p2);
			if (p3 != null) {
				JNIEnv.CopyArray (native_p3, p3);
				JNIEnv.DeleteLocalRef (native_p3);
			}
		}

		static Delegate cb_finer_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetFiner_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_finer_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ == null)
				cb_finer_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_Finer_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_);
			return cb_finer_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_;
		}

		static void n_Finer_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2)
		{
			global::Org.Eclipse.Paho.Client.Mqttv3.Logging.ILogger __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.Logging.ILogger> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			string p2 = JNIEnv.GetString (native_p2, JniHandleOwnership.DoNotTransfer);
			__this.Finer (p0, p1, p2);
		}
#pragma warning restore 0169

		IntPtr id_finer_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_;
		public unsafe void Finer (string p0, string p1, string p2)
		{
			if (id_finer_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_finer_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "finer", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p2 = JNIEnv.NewString (p2);
			JValue* __args = stackalloc JValue [3];
			__args [0] = new JValue (native_p0);
			__args [1] = new JValue (native_p1);
			__args [2] = new JValue (native_p2);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_finer_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_, __args);
			JNIEnv.DeleteLocalRef (native_p0);
			JNIEnv.DeleteLocalRef (native_p1);
			JNIEnv.DeleteLocalRef (native_p2);
		}

		static Delegate cb_finer_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_arrayLjava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetFiner_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_arrayLjava_lang_Object_Handler ()
		{
			if (cb_finer_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_arrayLjava_lang_Object_ == null)
				cb_finer_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_arrayLjava_lang_Object_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_Finer_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_arrayLjava_lang_Object_);
			return cb_finer_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_arrayLjava_lang_Object_;
		}

		static void n_Finer_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_arrayLjava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2, IntPtr native_p3)
		{
			global::Org.Eclipse.Paho.Client.Mqttv3.Logging.ILogger __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.Logging.ILogger> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			string p2 = JNIEnv.GetString (native_p2, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object[] p3 = (global::Java.Lang.Object[]) JNIEnv.GetArray (native_p3, JniHandleOwnership.DoNotTransfer, typeof (global::Java.Lang.Object));
			__this.Finer (p0, p1, p2, p3);
			if (p3 != null)
				JNIEnv.CopyArray (p3, native_p3);
		}
#pragma warning restore 0169

		IntPtr id_finer_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_arrayLjava_lang_Object_;
		public unsafe void Finer (string p0, string p1, string p2, global::Java.Lang.Object[] p3)
		{
			if (id_finer_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_arrayLjava_lang_Object_ == IntPtr.Zero)
				id_finer_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_arrayLjava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "finer", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;[Ljava/lang/Object;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p2 = JNIEnv.NewString (p2);
			IntPtr native_p3 = JNIEnv.NewArray (p3);
			JValue* __args = stackalloc JValue [4];
			__args [0] = new JValue (native_p0);
			__args [1] = new JValue (native_p1);
			__args [2] = new JValue (native_p2);
			__args [3] = new JValue (native_p3);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_finer_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_arrayLjava_lang_Object_, __args);
			JNIEnv.DeleteLocalRef (native_p0);
			JNIEnv.DeleteLocalRef (native_p1);
			JNIEnv.DeleteLocalRef (native_p2);
			if (p3 != null) {
				JNIEnv.CopyArray (native_p3, p3);
				JNIEnv.DeleteLocalRef (native_p3);
			}
		}

		static Delegate cb_finer_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_arrayLjava_lang_Object_Ljava_lang_Throwable_;
#pragma warning disable 0169
		static Delegate GetFiner_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_arrayLjava_lang_Object_Ljava_lang_Throwable_Handler ()
		{
			if (cb_finer_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_arrayLjava_lang_Object_Ljava_lang_Throwable_ == null)
				cb_finer_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_arrayLjava_lang_Object_Ljava_lang_Throwable_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_Finer_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_arrayLjava_lang_Object_Ljava_lang_Throwable_);
			return cb_finer_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_arrayLjava_lang_Object_Ljava_lang_Throwable_;
		}

		static void n_Finer_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_arrayLjava_lang_Object_Ljava_lang_Throwable_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2, IntPtr native_p3, IntPtr native_p4)
		{
			global::Org.Eclipse.Paho.Client.Mqttv3.Logging.ILogger __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.Logging.ILogger> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			string p2 = JNIEnv.GetString (native_p2, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object[] p3 = (global::Java.Lang.Object[]) JNIEnv.GetArray (native_p3, JniHandleOwnership.DoNotTransfer, typeof (global::Java.Lang.Object));
			global::Java.Lang.Throwable p4 = global::Java.Lang.Object.GetObject<global::Java.Lang.Throwable> (native_p4, JniHandleOwnership.DoNotTransfer);
			__this.Finer (p0, p1, p2, p3, p4);
			if (p3 != null)
				JNIEnv.CopyArray (p3, native_p3);
		}
#pragma warning restore 0169

		IntPtr id_finer_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_arrayLjava_lang_Object_Ljava_lang_Throwable_;
		public unsafe void Finer (string p0, string p1, string p2, global::Java.Lang.Object[] p3, global::Java.Lang.Throwable p4)
		{
			if (id_finer_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_arrayLjava_lang_Object_Ljava_lang_Throwable_ == IntPtr.Zero)
				id_finer_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_arrayLjava_lang_Object_Ljava_lang_Throwable_ = JNIEnv.GetMethodID (class_ref, "finer", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;[Ljava/lang/Object;Ljava/lang/Throwable;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p2 = JNIEnv.NewString (p2);
			IntPtr native_p3 = JNIEnv.NewArray (p3);
			JValue* __args = stackalloc JValue [5];
			__args [0] = new JValue (native_p0);
			__args [1] = new JValue (native_p1);
			__args [2] = new JValue (native_p2);
			__args [3] = new JValue (native_p3);
			__args [4] = new JValue ((p4 == null) ? IntPtr.Zero : ((global::Java.Lang.Throwable) p4).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_finer_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_arrayLjava_lang_Object_Ljava_lang_Throwable_, __args);
			JNIEnv.DeleteLocalRef (native_p0);
			JNIEnv.DeleteLocalRef (native_p1);
			JNIEnv.DeleteLocalRef (native_p2);
			if (p3 != null) {
				JNIEnv.CopyArray (native_p3, p3);
				JNIEnv.DeleteLocalRef (native_p3);
			}
		}

		static Delegate cb_finest_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetFinest_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_finest_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ == null)
				cb_finest_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_Finest_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_);
			return cb_finest_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_;
		}

		static void n_Finest_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2)
		{
			global::Org.Eclipse.Paho.Client.Mqttv3.Logging.ILogger __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.Logging.ILogger> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			string p2 = JNIEnv.GetString (native_p2, JniHandleOwnership.DoNotTransfer);
			__this.Finest (p0, p1, p2);
		}
#pragma warning restore 0169

		IntPtr id_finest_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_;
		public unsafe void Finest (string p0, string p1, string p2)
		{
			if (id_finest_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_finest_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "finest", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p2 = JNIEnv.NewString (p2);
			JValue* __args = stackalloc JValue [3];
			__args [0] = new JValue (native_p0);
			__args [1] = new JValue (native_p1);
			__args [2] = new JValue (native_p2);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_finest_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_, __args);
			JNIEnv.DeleteLocalRef (native_p0);
			JNIEnv.DeleteLocalRef (native_p1);
			JNIEnv.DeleteLocalRef (native_p2);
		}

		static Delegate cb_finest_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_arrayLjava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetFinest_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_arrayLjava_lang_Object_Handler ()
		{
			if (cb_finest_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_arrayLjava_lang_Object_ == null)
				cb_finest_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_arrayLjava_lang_Object_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_Finest_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_arrayLjava_lang_Object_);
			return cb_finest_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_arrayLjava_lang_Object_;
		}

		static void n_Finest_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_arrayLjava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2, IntPtr native_p3)
		{
			global::Org.Eclipse.Paho.Client.Mqttv3.Logging.ILogger __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.Logging.ILogger> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			string p2 = JNIEnv.GetString (native_p2, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object[] p3 = (global::Java.Lang.Object[]) JNIEnv.GetArray (native_p3, JniHandleOwnership.DoNotTransfer, typeof (global::Java.Lang.Object));
			__this.Finest (p0, p1, p2, p3);
			if (p3 != null)
				JNIEnv.CopyArray (p3, native_p3);
		}
#pragma warning restore 0169

		IntPtr id_finest_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_arrayLjava_lang_Object_;
		public unsafe void Finest (string p0, string p1, string p2, global::Java.Lang.Object[] p3)
		{
			if (id_finest_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_arrayLjava_lang_Object_ == IntPtr.Zero)
				id_finest_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_arrayLjava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "finest", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;[Ljava/lang/Object;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p2 = JNIEnv.NewString (p2);
			IntPtr native_p3 = JNIEnv.NewArray (p3);
			JValue* __args = stackalloc JValue [4];
			__args [0] = new JValue (native_p0);
			__args [1] = new JValue (native_p1);
			__args [2] = new JValue (native_p2);
			__args [3] = new JValue (native_p3);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_finest_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_arrayLjava_lang_Object_, __args);
			JNIEnv.DeleteLocalRef (native_p0);
			JNIEnv.DeleteLocalRef (native_p1);
			JNIEnv.DeleteLocalRef (native_p2);
			if (p3 != null) {
				JNIEnv.CopyArray (native_p3, p3);
				JNIEnv.DeleteLocalRef (native_p3);
			}
		}

		static Delegate cb_finest_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_arrayLjava_lang_Object_Ljava_lang_Throwable_;
#pragma warning disable 0169
		static Delegate GetFinest_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_arrayLjava_lang_Object_Ljava_lang_Throwable_Handler ()
		{
			if (cb_finest_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_arrayLjava_lang_Object_Ljava_lang_Throwable_ == null)
				cb_finest_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_arrayLjava_lang_Object_Ljava_lang_Throwable_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_Finest_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_arrayLjava_lang_Object_Ljava_lang_Throwable_);
			return cb_finest_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_arrayLjava_lang_Object_Ljava_lang_Throwable_;
		}

		static void n_Finest_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_arrayLjava_lang_Object_Ljava_lang_Throwable_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2, IntPtr native_p3, IntPtr native_p4)
		{
			global::Org.Eclipse.Paho.Client.Mqttv3.Logging.ILogger __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.Logging.ILogger> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			string p2 = JNIEnv.GetString (native_p2, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object[] p3 = (global::Java.Lang.Object[]) JNIEnv.GetArray (native_p3, JniHandleOwnership.DoNotTransfer, typeof (global::Java.Lang.Object));
			global::Java.Lang.Throwable p4 = global::Java.Lang.Object.GetObject<global::Java.Lang.Throwable> (native_p4, JniHandleOwnership.DoNotTransfer);
			__this.Finest (p0, p1, p2, p3, p4);
			if (p3 != null)
				JNIEnv.CopyArray (p3, native_p3);
		}
#pragma warning restore 0169

		IntPtr id_finest_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_arrayLjava_lang_Object_Ljava_lang_Throwable_;
		public unsafe void Finest (string p0, string p1, string p2, global::Java.Lang.Object[] p3, global::Java.Lang.Throwable p4)
		{
			if (id_finest_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_arrayLjava_lang_Object_Ljava_lang_Throwable_ == IntPtr.Zero)
				id_finest_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_arrayLjava_lang_Object_Ljava_lang_Throwable_ = JNIEnv.GetMethodID (class_ref, "finest", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;[Ljava/lang/Object;Ljava/lang/Throwable;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p2 = JNIEnv.NewString (p2);
			IntPtr native_p3 = JNIEnv.NewArray (p3);
			JValue* __args = stackalloc JValue [5];
			__args [0] = new JValue (native_p0);
			__args [1] = new JValue (native_p1);
			__args [2] = new JValue (native_p2);
			__args [3] = new JValue (native_p3);
			__args [4] = new JValue ((p4 == null) ? IntPtr.Zero : ((global::Java.Lang.Throwable) p4).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_finest_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_arrayLjava_lang_Object_Ljava_lang_Throwable_, __args);
			JNIEnv.DeleteLocalRef (native_p0);
			JNIEnv.DeleteLocalRef (native_p1);
			JNIEnv.DeleteLocalRef (native_p2);
			if (p3 != null) {
				JNIEnv.CopyArray (native_p3, p3);
				JNIEnv.DeleteLocalRef (native_p3);
			}
		}

		static Delegate cb_formatMessage_Ljava_lang_String_arrayLjava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetFormatMessage_Ljava_lang_String_arrayLjava_lang_Object_Handler ()
		{
			if (cb_formatMessage_Ljava_lang_String_arrayLjava_lang_Object_ == null)
				cb_formatMessage_Ljava_lang_String_arrayLjava_lang_Object_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_FormatMessage_Ljava_lang_String_arrayLjava_lang_Object_);
			return cb_formatMessage_Ljava_lang_String_arrayLjava_lang_Object_;
		}

		static IntPtr n_FormatMessage_Ljava_lang_String_arrayLjava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Org.Eclipse.Paho.Client.Mqttv3.Logging.ILogger __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.Logging.ILogger> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object[] p1 = (global::Java.Lang.Object[]) JNIEnv.GetArray (native_p1, JniHandleOwnership.DoNotTransfer, typeof (global::Java.Lang.Object));
			IntPtr __ret = JNIEnv.NewString (__this.FormatMessage (p0, p1));
			if (p1 != null)
				JNIEnv.CopyArray (p1, native_p1);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_formatMessage_Ljava_lang_String_arrayLjava_lang_Object_;
		public unsafe string FormatMessage (string p0, global::Java.Lang.Object[] p1)
		{
			if (id_formatMessage_Ljava_lang_String_arrayLjava_lang_Object_ == IntPtr.Zero)
				id_formatMessage_Ljava_lang_String_arrayLjava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "formatMessage", "(Ljava/lang/String;[Ljava/lang/Object;)Ljava/lang/String;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewArray (p1);
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (native_p0);
			__args [1] = new JValue (native_p1);
			string __ret = JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_formatMessage_Ljava_lang_String_arrayLjava_lang_Object_, __args), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			if (p1 != null) {
				JNIEnv.CopyArray (native_p1, p1);
				JNIEnv.DeleteLocalRef (native_p1);
			}
			return __ret;
		}

		static Delegate cb_info_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetInfo_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_info_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ == null)
				cb_info_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_Info_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_);
			return cb_info_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_;
		}

		static void n_Info_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2)
		{
			global::Org.Eclipse.Paho.Client.Mqttv3.Logging.ILogger __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.Logging.ILogger> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			string p2 = JNIEnv.GetString (native_p2, JniHandleOwnership.DoNotTransfer);
			__this.Info (p0, p1, p2);
		}
#pragma warning restore 0169

		IntPtr id_info_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_;
		public unsafe void Info (string p0, string p1, string p2)
		{
			if (id_info_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_info_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "info", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p2 = JNIEnv.NewString (p2);
			JValue* __args = stackalloc JValue [3];
			__args [0] = new JValue (native_p0);
			__args [1] = new JValue (native_p1);
			__args [2] = new JValue (native_p2);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_info_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_, __args);
			JNIEnv.DeleteLocalRef (native_p0);
			JNIEnv.DeleteLocalRef (native_p1);
			JNIEnv.DeleteLocalRef (native_p2);
		}

		static Delegate cb_info_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_arrayLjava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetInfo_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_arrayLjava_lang_Object_Handler ()
		{
			if (cb_info_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_arrayLjava_lang_Object_ == null)
				cb_info_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_arrayLjava_lang_Object_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_Info_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_arrayLjava_lang_Object_);
			return cb_info_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_arrayLjava_lang_Object_;
		}

		static void n_Info_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_arrayLjava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2, IntPtr native_p3)
		{
			global::Org.Eclipse.Paho.Client.Mqttv3.Logging.ILogger __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.Logging.ILogger> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			string p2 = JNIEnv.GetString (native_p2, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object[] p3 = (global::Java.Lang.Object[]) JNIEnv.GetArray (native_p3, JniHandleOwnership.DoNotTransfer, typeof (global::Java.Lang.Object));
			__this.Info (p0, p1, p2, p3);
			if (p3 != null)
				JNIEnv.CopyArray (p3, native_p3);
		}
#pragma warning restore 0169

		IntPtr id_info_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_arrayLjava_lang_Object_;
		public unsafe void Info (string p0, string p1, string p2, global::Java.Lang.Object[] p3)
		{
			if (id_info_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_arrayLjava_lang_Object_ == IntPtr.Zero)
				id_info_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_arrayLjava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "info", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;[Ljava/lang/Object;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p2 = JNIEnv.NewString (p2);
			IntPtr native_p3 = JNIEnv.NewArray (p3);
			JValue* __args = stackalloc JValue [4];
			__args [0] = new JValue (native_p0);
			__args [1] = new JValue (native_p1);
			__args [2] = new JValue (native_p2);
			__args [3] = new JValue (native_p3);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_info_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_arrayLjava_lang_Object_, __args);
			JNIEnv.DeleteLocalRef (native_p0);
			JNIEnv.DeleteLocalRef (native_p1);
			JNIEnv.DeleteLocalRef (native_p2);
			if (p3 != null) {
				JNIEnv.CopyArray (native_p3, p3);
				JNIEnv.DeleteLocalRef (native_p3);
			}
		}

		static Delegate cb_info_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_arrayLjava_lang_Object_Ljava_lang_Throwable_;
#pragma warning disable 0169
		static Delegate GetInfo_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_arrayLjava_lang_Object_Ljava_lang_Throwable_Handler ()
		{
			if (cb_info_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_arrayLjava_lang_Object_Ljava_lang_Throwable_ == null)
				cb_info_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_arrayLjava_lang_Object_Ljava_lang_Throwable_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_Info_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_arrayLjava_lang_Object_Ljava_lang_Throwable_);
			return cb_info_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_arrayLjava_lang_Object_Ljava_lang_Throwable_;
		}

		static void n_Info_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_arrayLjava_lang_Object_Ljava_lang_Throwable_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2, IntPtr native_p3, IntPtr native_p4)
		{
			global::Org.Eclipse.Paho.Client.Mqttv3.Logging.ILogger __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.Logging.ILogger> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			string p2 = JNIEnv.GetString (native_p2, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object[] p3 = (global::Java.Lang.Object[]) JNIEnv.GetArray (native_p3, JniHandleOwnership.DoNotTransfer, typeof (global::Java.Lang.Object));
			global::Java.Lang.Throwable p4 = global::Java.Lang.Object.GetObject<global::Java.Lang.Throwable> (native_p4, JniHandleOwnership.DoNotTransfer);
			__this.Info (p0, p1, p2, p3, p4);
			if (p3 != null)
				JNIEnv.CopyArray (p3, native_p3);
		}
#pragma warning restore 0169

		IntPtr id_info_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_arrayLjava_lang_Object_Ljava_lang_Throwable_;
		public unsafe void Info (string p0, string p1, string p2, global::Java.Lang.Object[] p3, global::Java.Lang.Throwable p4)
		{
			if (id_info_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_arrayLjava_lang_Object_Ljava_lang_Throwable_ == IntPtr.Zero)
				id_info_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_arrayLjava_lang_Object_Ljava_lang_Throwable_ = JNIEnv.GetMethodID (class_ref, "info", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;[Ljava/lang/Object;Ljava/lang/Throwable;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p2 = JNIEnv.NewString (p2);
			IntPtr native_p3 = JNIEnv.NewArray (p3);
			JValue* __args = stackalloc JValue [5];
			__args [0] = new JValue (native_p0);
			__args [1] = new JValue (native_p1);
			__args [2] = new JValue (native_p2);
			__args [3] = new JValue (native_p3);
			__args [4] = new JValue ((p4 == null) ? IntPtr.Zero : ((global::Java.Lang.Throwable) p4).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_info_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_arrayLjava_lang_Object_Ljava_lang_Throwable_, __args);
			JNIEnv.DeleteLocalRef (native_p0);
			JNIEnv.DeleteLocalRef (native_p1);
			JNIEnv.DeleteLocalRef (native_p2);
			if (p3 != null) {
				JNIEnv.CopyArray (native_p3, p3);
				JNIEnv.DeleteLocalRef (native_p3);
			}
		}

		static Delegate cb_initialise_Ljava_util_ResourceBundle_Ljava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetInitialise_Ljava_util_ResourceBundle_Ljava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_initialise_Ljava_util_ResourceBundle_Ljava_lang_String_Ljava_lang_String_ == null)
				cb_initialise_Ljava_util_ResourceBundle_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_Initialise_Ljava_util_ResourceBundle_Ljava_lang_String_Ljava_lang_String_);
			return cb_initialise_Ljava_util_ResourceBundle_Ljava_lang_String_Ljava_lang_String_;
		}

		static void n_Initialise_Ljava_util_ResourceBundle_Ljava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2)
		{
			global::Org.Eclipse.Paho.Client.Mqttv3.Logging.ILogger __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.Logging.ILogger> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Util.ResourceBundle p0 = global::Java.Lang.Object.GetObject<global::Java.Util.ResourceBundle> (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			string p2 = JNIEnv.GetString (native_p2, JniHandleOwnership.DoNotTransfer);
			__this.Initialise (p0, p1, p2);
		}
#pragma warning restore 0169

		IntPtr id_initialise_Ljava_util_ResourceBundle_Ljava_lang_String_Ljava_lang_String_;
		public unsafe void Initialise (global::Java.Util.ResourceBundle p0, string p1, string p2)
		{
			if (id_initialise_Ljava_util_ResourceBundle_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_initialise_Ljava_util_ResourceBundle_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "initialise", "(Ljava/util/ResourceBundle;Ljava/lang/String;Ljava/lang/String;)V");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p2 = JNIEnv.NewString (p2);
			JValue* __args = stackalloc JValue [3];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			__args [1] = new JValue (native_p1);
			__args [2] = new JValue (native_p2);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_initialise_Ljava_util_ResourceBundle_Ljava_lang_String_Ljava_lang_String_, __args);
			JNIEnv.DeleteLocalRef (native_p1);
			JNIEnv.DeleteLocalRef (native_p2);
		}

		static Delegate cb_isLoggable_I;
#pragma warning disable 0169
		static Delegate GetIsLoggable_IHandler ()
		{
			if (cb_isLoggable_I == null)
				cb_isLoggable_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, bool>) n_IsLoggable_I);
			return cb_isLoggable_I;
		}

		static bool n_IsLoggable_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Org.Eclipse.Paho.Client.Mqttv3.Logging.ILogger __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.Logging.ILogger> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsLoggable (p0);
		}
#pragma warning restore 0169

		IntPtr id_isLoggable_I;
		public unsafe bool IsLoggable (int p0)
		{
			if (id_isLoggable_I == IntPtr.Zero)
				id_isLoggable_I = JNIEnv.GetMethodID (class_ref, "isLoggable", "(I)Z");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isLoggable_I, __args);
		}

		static Delegate cb_log_ILjava_lang_String_Ljava_lang_String_Ljava_lang_String_arrayLjava_lang_Object_Ljava_lang_Throwable_;
#pragma warning disable 0169
		static Delegate GetLog_ILjava_lang_String_Ljava_lang_String_Ljava_lang_String_arrayLjava_lang_Object_Ljava_lang_Throwable_Handler ()
		{
			if (cb_log_ILjava_lang_String_Ljava_lang_String_Ljava_lang_String_arrayLjava_lang_Object_Ljava_lang_Throwable_ == null)
				cb_log_ILjava_lang_String_Ljava_lang_String_Ljava_lang_String_arrayLjava_lang_Object_Ljava_lang_Throwable_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_Log_ILjava_lang_String_Ljava_lang_String_Ljava_lang_String_arrayLjava_lang_Object_Ljava_lang_Throwable_);
			return cb_log_ILjava_lang_String_Ljava_lang_String_Ljava_lang_String_arrayLjava_lang_Object_Ljava_lang_Throwable_;
		}

		static void n_Log_ILjava_lang_String_Ljava_lang_String_Ljava_lang_String_arrayLjava_lang_Object_Ljava_lang_Throwable_ (IntPtr jnienv, IntPtr native__this, int p0, IntPtr native_p1, IntPtr native_p2, IntPtr native_p3, IntPtr native_p4, IntPtr native_p5)
		{
			global::Org.Eclipse.Paho.Client.Mqttv3.Logging.ILogger __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.Logging.ILogger> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			string p2 = JNIEnv.GetString (native_p2, JniHandleOwnership.DoNotTransfer);
			string p3 = JNIEnv.GetString (native_p3, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object[] p4 = (global::Java.Lang.Object[]) JNIEnv.GetArray (native_p4, JniHandleOwnership.DoNotTransfer, typeof (global::Java.Lang.Object));
			global::Java.Lang.Throwable p5 = global::Java.Lang.Object.GetObject<global::Java.Lang.Throwable> (native_p5, JniHandleOwnership.DoNotTransfer);
			__this.Log (p0, p1, p2, p3, p4, p5);
			if (p4 != null)
				JNIEnv.CopyArray (p4, native_p4);
		}
#pragma warning restore 0169

		IntPtr id_log_ILjava_lang_String_Ljava_lang_String_Ljava_lang_String_arrayLjava_lang_Object_Ljava_lang_Throwable_;
		public unsafe void Log (int p0, string p1, string p2, string p3, global::Java.Lang.Object[] p4, global::Java.Lang.Throwable p5)
		{
			if (id_log_ILjava_lang_String_Ljava_lang_String_Ljava_lang_String_arrayLjava_lang_Object_Ljava_lang_Throwable_ == IntPtr.Zero)
				id_log_ILjava_lang_String_Ljava_lang_String_Ljava_lang_String_arrayLjava_lang_Object_Ljava_lang_Throwable_ = JNIEnv.GetMethodID (class_ref, "log", "(ILjava/lang/String;Ljava/lang/String;Ljava/lang/String;[Ljava/lang/Object;Ljava/lang/Throwable;)V");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p2 = JNIEnv.NewString (p2);
			IntPtr native_p3 = JNIEnv.NewString (p3);
			IntPtr native_p4 = JNIEnv.NewArray (p4);
			JValue* __args = stackalloc JValue [6];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (native_p1);
			__args [2] = new JValue (native_p2);
			__args [3] = new JValue (native_p3);
			__args [4] = new JValue (native_p4);
			__args [5] = new JValue ((p5 == null) ? IntPtr.Zero : ((global::Java.Lang.Throwable) p5).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_log_ILjava_lang_String_Ljava_lang_String_Ljava_lang_String_arrayLjava_lang_Object_Ljava_lang_Throwable_, __args);
			JNIEnv.DeleteLocalRef (native_p1);
			JNIEnv.DeleteLocalRef (native_p2);
			JNIEnv.DeleteLocalRef (native_p3);
			if (p4 != null) {
				JNIEnv.CopyArray (native_p4, p4);
				JNIEnv.DeleteLocalRef (native_p4);
			}
		}

		static Delegate cb_setResourceName_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetResourceName_Ljava_lang_String_Handler ()
		{
			if (cb_setResourceName_Ljava_lang_String_ == null)
				cb_setResourceName_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetResourceName_Ljava_lang_String_);
			return cb_setResourceName_Ljava_lang_String_;
		}

		static void n_SetResourceName_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Org.Eclipse.Paho.Client.Mqttv3.Logging.ILogger __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.Logging.ILogger> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetResourceName (p0);
		}
#pragma warning restore 0169

		IntPtr id_setResourceName_Ljava_lang_String_;
		public unsafe void SetResourceName (string p0)
		{
			if (id_setResourceName_Ljava_lang_String_ == IntPtr.Zero)
				id_setResourceName_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setResourceName", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setResourceName_Ljava_lang_String_, __args);
			JNIEnv.DeleteLocalRef (native_p0);
		}

		static Delegate cb_severe_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSevere_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_severe_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ == null)
				cb_severe_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_Severe_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_);
			return cb_severe_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_;
		}

		static void n_Severe_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2)
		{
			global::Org.Eclipse.Paho.Client.Mqttv3.Logging.ILogger __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.Logging.ILogger> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			string p2 = JNIEnv.GetString (native_p2, JniHandleOwnership.DoNotTransfer);
			__this.Severe (p0, p1, p2);
		}
#pragma warning restore 0169

		IntPtr id_severe_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_;
		public unsafe void Severe (string p0, string p1, string p2)
		{
			if (id_severe_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_severe_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "severe", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p2 = JNIEnv.NewString (p2);
			JValue* __args = stackalloc JValue [3];
			__args [0] = new JValue (native_p0);
			__args [1] = new JValue (native_p1);
			__args [2] = new JValue (native_p2);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_severe_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_, __args);
			JNIEnv.DeleteLocalRef (native_p0);
			JNIEnv.DeleteLocalRef (native_p1);
			JNIEnv.DeleteLocalRef (native_p2);
		}

		static Delegate cb_severe_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_arrayLjava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetSevere_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_arrayLjava_lang_Object_Handler ()
		{
			if (cb_severe_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_arrayLjava_lang_Object_ == null)
				cb_severe_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_arrayLjava_lang_Object_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_Severe_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_arrayLjava_lang_Object_);
			return cb_severe_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_arrayLjava_lang_Object_;
		}

		static void n_Severe_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_arrayLjava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2, IntPtr native_p3)
		{
			global::Org.Eclipse.Paho.Client.Mqttv3.Logging.ILogger __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.Logging.ILogger> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			string p2 = JNIEnv.GetString (native_p2, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object[] p3 = (global::Java.Lang.Object[]) JNIEnv.GetArray (native_p3, JniHandleOwnership.DoNotTransfer, typeof (global::Java.Lang.Object));
			__this.Severe (p0, p1, p2, p3);
			if (p3 != null)
				JNIEnv.CopyArray (p3, native_p3);
		}
#pragma warning restore 0169

		IntPtr id_severe_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_arrayLjava_lang_Object_;
		public unsafe void Severe (string p0, string p1, string p2, global::Java.Lang.Object[] p3)
		{
			if (id_severe_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_arrayLjava_lang_Object_ == IntPtr.Zero)
				id_severe_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_arrayLjava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "severe", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;[Ljava/lang/Object;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p2 = JNIEnv.NewString (p2);
			IntPtr native_p3 = JNIEnv.NewArray (p3);
			JValue* __args = stackalloc JValue [4];
			__args [0] = new JValue (native_p0);
			__args [1] = new JValue (native_p1);
			__args [2] = new JValue (native_p2);
			__args [3] = new JValue (native_p3);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_severe_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_arrayLjava_lang_Object_, __args);
			JNIEnv.DeleteLocalRef (native_p0);
			JNIEnv.DeleteLocalRef (native_p1);
			JNIEnv.DeleteLocalRef (native_p2);
			if (p3 != null) {
				JNIEnv.CopyArray (native_p3, p3);
				JNIEnv.DeleteLocalRef (native_p3);
			}
		}

		static Delegate cb_severe_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_arrayLjava_lang_Object_Ljava_lang_Throwable_;
#pragma warning disable 0169
		static Delegate GetSevere_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_arrayLjava_lang_Object_Ljava_lang_Throwable_Handler ()
		{
			if (cb_severe_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_arrayLjava_lang_Object_Ljava_lang_Throwable_ == null)
				cb_severe_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_arrayLjava_lang_Object_Ljava_lang_Throwable_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_Severe_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_arrayLjava_lang_Object_Ljava_lang_Throwable_);
			return cb_severe_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_arrayLjava_lang_Object_Ljava_lang_Throwable_;
		}

		static void n_Severe_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_arrayLjava_lang_Object_Ljava_lang_Throwable_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2, IntPtr native_p3, IntPtr native_p4)
		{
			global::Org.Eclipse.Paho.Client.Mqttv3.Logging.ILogger __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.Logging.ILogger> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			string p2 = JNIEnv.GetString (native_p2, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object[] p3 = (global::Java.Lang.Object[]) JNIEnv.GetArray (native_p3, JniHandleOwnership.DoNotTransfer, typeof (global::Java.Lang.Object));
			global::Java.Lang.Throwable p4 = global::Java.Lang.Object.GetObject<global::Java.Lang.Throwable> (native_p4, JniHandleOwnership.DoNotTransfer);
			__this.Severe (p0, p1, p2, p3, p4);
			if (p3 != null)
				JNIEnv.CopyArray (p3, native_p3);
		}
#pragma warning restore 0169

		IntPtr id_severe_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_arrayLjava_lang_Object_Ljava_lang_Throwable_;
		public unsafe void Severe (string p0, string p1, string p2, global::Java.Lang.Object[] p3, global::Java.Lang.Throwable p4)
		{
			if (id_severe_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_arrayLjava_lang_Object_Ljava_lang_Throwable_ == IntPtr.Zero)
				id_severe_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_arrayLjava_lang_Object_Ljava_lang_Throwable_ = JNIEnv.GetMethodID (class_ref, "severe", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;[Ljava/lang/Object;Ljava/lang/Throwable;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p2 = JNIEnv.NewString (p2);
			IntPtr native_p3 = JNIEnv.NewArray (p3);
			JValue* __args = stackalloc JValue [5];
			__args [0] = new JValue (native_p0);
			__args [1] = new JValue (native_p1);
			__args [2] = new JValue (native_p2);
			__args [3] = new JValue (native_p3);
			__args [4] = new JValue ((p4 == null) ? IntPtr.Zero : ((global::Java.Lang.Throwable) p4).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_severe_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_arrayLjava_lang_Object_Ljava_lang_Throwable_, __args);
			JNIEnv.DeleteLocalRef (native_p0);
			JNIEnv.DeleteLocalRef (native_p1);
			JNIEnv.DeleteLocalRef (native_p2);
			if (p3 != null) {
				JNIEnv.CopyArray (native_p3, p3);
				JNIEnv.DeleteLocalRef (native_p3);
			}
		}

		static Delegate cb_trace_ILjava_lang_String_Ljava_lang_String_Ljava_lang_String_arrayLjava_lang_Object_Ljava_lang_Throwable_;
#pragma warning disable 0169
		static Delegate GetTrace_ILjava_lang_String_Ljava_lang_String_Ljava_lang_String_arrayLjava_lang_Object_Ljava_lang_Throwable_Handler ()
		{
			if (cb_trace_ILjava_lang_String_Ljava_lang_String_Ljava_lang_String_arrayLjava_lang_Object_Ljava_lang_Throwable_ == null)
				cb_trace_ILjava_lang_String_Ljava_lang_String_Ljava_lang_String_arrayLjava_lang_Object_Ljava_lang_Throwable_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_Trace_ILjava_lang_String_Ljava_lang_String_Ljava_lang_String_arrayLjava_lang_Object_Ljava_lang_Throwable_);
			return cb_trace_ILjava_lang_String_Ljava_lang_String_Ljava_lang_String_arrayLjava_lang_Object_Ljava_lang_Throwable_;
		}

		static void n_Trace_ILjava_lang_String_Ljava_lang_String_Ljava_lang_String_arrayLjava_lang_Object_Ljava_lang_Throwable_ (IntPtr jnienv, IntPtr native__this, int p0, IntPtr native_p1, IntPtr native_p2, IntPtr native_p3, IntPtr native_p4, IntPtr native_p5)
		{
			global::Org.Eclipse.Paho.Client.Mqttv3.Logging.ILogger __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.Logging.ILogger> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			string p2 = JNIEnv.GetString (native_p2, JniHandleOwnership.DoNotTransfer);
			string p3 = JNIEnv.GetString (native_p3, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object[] p4 = (global::Java.Lang.Object[]) JNIEnv.GetArray (native_p4, JniHandleOwnership.DoNotTransfer, typeof (global::Java.Lang.Object));
			global::Java.Lang.Throwable p5 = global::Java.Lang.Object.GetObject<global::Java.Lang.Throwable> (native_p5, JniHandleOwnership.DoNotTransfer);
			__this.Trace (p0, p1, p2, p3, p4, p5);
			if (p4 != null)
				JNIEnv.CopyArray (p4, native_p4);
		}
#pragma warning restore 0169

		IntPtr id_trace_ILjava_lang_String_Ljava_lang_String_Ljava_lang_String_arrayLjava_lang_Object_Ljava_lang_Throwable_;
		public unsafe void Trace (int p0, string p1, string p2, string p3, global::Java.Lang.Object[] p4, global::Java.Lang.Throwable p5)
		{
			if (id_trace_ILjava_lang_String_Ljava_lang_String_Ljava_lang_String_arrayLjava_lang_Object_Ljava_lang_Throwable_ == IntPtr.Zero)
				id_trace_ILjava_lang_String_Ljava_lang_String_Ljava_lang_String_arrayLjava_lang_Object_Ljava_lang_Throwable_ = JNIEnv.GetMethodID (class_ref, "trace", "(ILjava/lang/String;Ljava/lang/String;Ljava/lang/String;[Ljava/lang/Object;Ljava/lang/Throwable;)V");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p2 = JNIEnv.NewString (p2);
			IntPtr native_p3 = JNIEnv.NewString (p3);
			IntPtr native_p4 = JNIEnv.NewArray (p4);
			JValue* __args = stackalloc JValue [6];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (native_p1);
			__args [2] = new JValue (native_p2);
			__args [3] = new JValue (native_p3);
			__args [4] = new JValue (native_p4);
			__args [5] = new JValue ((p5 == null) ? IntPtr.Zero : ((global::Java.Lang.Throwable) p5).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_trace_ILjava_lang_String_Ljava_lang_String_Ljava_lang_String_arrayLjava_lang_Object_Ljava_lang_Throwable_, __args);
			JNIEnv.DeleteLocalRef (native_p1);
			JNIEnv.DeleteLocalRef (native_p2);
			JNIEnv.DeleteLocalRef (native_p3);
			if (p4 != null) {
				JNIEnv.CopyArray (native_p4, p4);
				JNIEnv.DeleteLocalRef (native_p4);
			}
		}

		static Delegate cb_warning_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetWarning_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_warning_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ == null)
				cb_warning_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_Warning_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_);
			return cb_warning_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_;
		}

		static void n_Warning_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2)
		{
			global::Org.Eclipse.Paho.Client.Mqttv3.Logging.ILogger __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.Logging.ILogger> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			string p2 = JNIEnv.GetString (native_p2, JniHandleOwnership.DoNotTransfer);
			__this.Warning (p0, p1, p2);
		}
#pragma warning restore 0169

		IntPtr id_warning_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_;
		public unsafe void Warning (string p0, string p1, string p2)
		{
			if (id_warning_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_warning_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "warning", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p2 = JNIEnv.NewString (p2);
			JValue* __args = stackalloc JValue [3];
			__args [0] = new JValue (native_p0);
			__args [1] = new JValue (native_p1);
			__args [2] = new JValue (native_p2);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_warning_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_, __args);
			JNIEnv.DeleteLocalRef (native_p0);
			JNIEnv.DeleteLocalRef (native_p1);
			JNIEnv.DeleteLocalRef (native_p2);
		}

		static Delegate cb_warning_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_arrayLjava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetWarning_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_arrayLjava_lang_Object_Handler ()
		{
			if (cb_warning_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_arrayLjava_lang_Object_ == null)
				cb_warning_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_arrayLjava_lang_Object_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_Warning_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_arrayLjava_lang_Object_);
			return cb_warning_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_arrayLjava_lang_Object_;
		}

		static void n_Warning_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_arrayLjava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2, IntPtr native_p3)
		{
			global::Org.Eclipse.Paho.Client.Mqttv3.Logging.ILogger __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.Logging.ILogger> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			string p2 = JNIEnv.GetString (native_p2, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object[] p3 = (global::Java.Lang.Object[]) JNIEnv.GetArray (native_p3, JniHandleOwnership.DoNotTransfer, typeof (global::Java.Lang.Object));
			__this.Warning (p0, p1, p2, p3);
			if (p3 != null)
				JNIEnv.CopyArray (p3, native_p3);
		}
#pragma warning restore 0169

		IntPtr id_warning_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_arrayLjava_lang_Object_;
		public unsafe void Warning (string p0, string p1, string p2, global::Java.Lang.Object[] p3)
		{
			if (id_warning_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_arrayLjava_lang_Object_ == IntPtr.Zero)
				id_warning_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_arrayLjava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "warning", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;[Ljava/lang/Object;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p2 = JNIEnv.NewString (p2);
			IntPtr native_p3 = JNIEnv.NewArray (p3);
			JValue* __args = stackalloc JValue [4];
			__args [0] = new JValue (native_p0);
			__args [1] = new JValue (native_p1);
			__args [2] = new JValue (native_p2);
			__args [3] = new JValue (native_p3);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_warning_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_arrayLjava_lang_Object_, __args);
			JNIEnv.DeleteLocalRef (native_p0);
			JNIEnv.DeleteLocalRef (native_p1);
			JNIEnv.DeleteLocalRef (native_p2);
			if (p3 != null) {
				JNIEnv.CopyArray (native_p3, p3);
				JNIEnv.DeleteLocalRef (native_p3);
			}
		}

		static Delegate cb_warning_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_arrayLjava_lang_Object_Ljava_lang_Throwable_;
#pragma warning disable 0169
		static Delegate GetWarning_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_arrayLjava_lang_Object_Ljava_lang_Throwable_Handler ()
		{
			if (cb_warning_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_arrayLjava_lang_Object_Ljava_lang_Throwable_ == null)
				cb_warning_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_arrayLjava_lang_Object_Ljava_lang_Throwable_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_Warning_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_arrayLjava_lang_Object_Ljava_lang_Throwable_);
			return cb_warning_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_arrayLjava_lang_Object_Ljava_lang_Throwable_;
		}

		static void n_Warning_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_arrayLjava_lang_Object_Ljava_lang_Throwable_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2, IntPtr native_p3, IntPtr native_p4)
		{
			global::Org.Eclipse.Paho.Client.Mqttv3.Logging.ILogger __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.Logging.ILogger> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			string p2 = JNIEnv.GetString (native_p2, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object[] p3 = (global::Java.Lang.Object[]) JNIEnv.GetArray (native_p3, JniHandleOwnership.DoNotTransfer, typeof (global::Java.Lang.Object));
			global::Java.Lang.Throwable p4 = global::Java.Lang.Object.GetObject<global::Java.Lang.Throwable> (native_p4, JniHandleOwnership.DoNotTransfer);
			__this.Warning (p0, p1, p2, p3, p4);
			if (p3 != null)
				JNIEnv.CopyArray (p3, native_p3);
		}
#pragma warning restore 0169

		IntPtr id_warning_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_arrayLjava_lang_Object_Ljava_lang_Throwable_;
		public unsafe void Warning (string p0, string p1, string p2, global::Java.Lang.Object[] p3, global::Java.Lang.Throwable p4)
		{
			if (id_warning_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_arrayLjava_lang_Object_Ljava_lang_Throwable_ == IntPtr.Zero)
				id_warning_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_arrayLjava_lang_Object_Ljava_lang_Throwable_ = JNIEnv.GetMethodID (class_ref, "warning", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;[Ljava/lang/Object;Ljava/lang/Throwable;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p2 = JNIEnv.NewString (p2);
			IntPtr native_p3 = JNIEnv.NewArray (p3);
			JValue* __args = stackalloc JValue [5];
			__args [0] = new JValue (native_p0);
			__args [1] = new JValue (native_p1);
			__args [2] = new JValue (native_p2);
			__args [3] = new JValue (native_p3);
			__args [4] = new JValue ((p4 == null) ? IntPtr.Zero : ((global::Java.Lang.Throwable) p4).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_warning_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_arrayLjava_lang_Object_Ljava_lang_Throwable_, __args);
			JNIEnv.DeleteLocalRef (native_p0);
			JNIEnv.DeleteLocalRef (native_p1);
			JNIEnv.DeleteLocalRef (native_p2);
			if (p3 != null) {
				JNIEnv.CopyArray (native_p3, p3);
				JNIEnv.DeleteLocalRef (native_p3);
			}
		}

	}

}
