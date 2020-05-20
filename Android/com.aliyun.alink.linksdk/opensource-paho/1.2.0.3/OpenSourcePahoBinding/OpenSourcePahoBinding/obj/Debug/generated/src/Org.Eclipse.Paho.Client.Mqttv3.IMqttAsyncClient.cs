using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Org.Eclipse.Paho.Client.Mqttv3 {

	// Metadata.xml XPath interface reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3']/interface[@name='IMqttAsyncClient']"
	[Register ("org/eclipse/paho/client/mqttv3/IMqttAsyncClient", "", "Org.Eclipse.Paho.Client.Mqttv3.IMqttAsyncClientInvoker")]
	public partial interface IMqttAsyncClient : IJavaObject, IJavaPeerable {

		string ClientId {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3']/interface[@name='IMqttAsyncClient']/method[@name='getClientId' and count(parameter)=0]"
			[Register ("getClientId", "()Ljava/lang/String;", "GetGetClientIdHandler:Org.Eclipse.Paho.Client.Mqttv3.IMqttAsyncClientInvoker, OpenSourcePahoBinding")] get;
		}

		bool IsConnected {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3']/interface[@name='IMqttAsyncClient']/method[@name='isConnected' and count(parameter)=0]"
			[Register ("isConnected", "()Z", "GetIsConnectedHandler:Org.Eclipse.Paho.Client.Mqttv3.IMqttAsyncClientInvoker, OpenSourcePahoBinding")] get;
		}

		string ServerURI {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3']/interface[@name='IMqttAsyncClient']/method[@name='getServerURI' and count(parameter)=0]"
			[Register ("getServerURI", "()Ljava/lang/String;", "GetGetServerURIHandler:Org.Eclipse.Paho.Client.Mqttv3.IMqttAsyncClientInvoker, OpenSourcePahoBinding")] get;
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3']/interface[@name='IMqttAsyncClient']/method[@name='close' and count(parameter)=0]"
		[Register ("close", "()V", "GetCloseHandler:Org.Eclipse.Paho.Client.Mqttv3.IMqttAsyncClientInvoker, OpenSourcePahoBinding")]
		void Close ();

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3']/interface[@name='IMqttAsyncClient']/method[@name='connect' and count(parameter)=0]"
		[Register ("connect", "()Lorg/eclipse/paho/client/mqttv3/IMqttToken;", "GetConnectHandler:Org.Eclipse.Paho.Client.Mqttv3.IMqttAsyncClientInvoker, OpenSourcePahoBinding")]
		global::Org.Eclipse.Paho.Client.Mqttv3.IMqttToken Connect ();

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3']/interface[@name='IMqttAsyncClient']/method[@name='connect' and count(parameter)=2 and parameter[1][@type='java.lang.Object'] and parameter[2][@type='org.eclipse.paho.client.mqttv3.IMqttActionListener']]"
		[Register ("connect", "(Ljava/lang/Object;Lorg/eclipse/paho/client/mqttv3/IMqttActionListener;)Lorg/eclipse/paho/client/mqttv3/IMqttToken;", "GetConnect_Ljava_lang_Object_Lorg_eclipse_paho_client_mqttv3_IMqttActionListener_Handler:Org.Eclipse.Paho.Client.Mqttv3.IMqttAsyncClientInvoker, OpenSourcePahoBinding")]
		global::Org.Eclipse.Paho.Client.Mqttv3.IMqttToken Connect (global::Java.Lang.Object p0, global::Org.Eclipse.Paho.Client.Mqttv3.IMqttActionListener p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3']/interface[@name='IMqttAsyncClient']/method[@name='connect' and count(parameter)=1 and parameter[1][@type='org.eclipse.paho.client.mqttv3.MqttConnectOptions']]"
		[Register ("connect", "(Lorg/eclipse/paho/client/mqttv3/MqttConnectOptions;)Lorg/eclipse/paho/client/mqttv3/IMqttToken;", "GetConnect_Lorg_eclipse_paho_client_mqttv3_MqttConnectOptions_Handler:Org.Eclipse.Paho.Client.Mqttv3.IMqttAsyncClientInvoker, OpenSourcePahoBinding")]
		global::Org.Eclipse.Paho.Client.Mqttv3.IMqttToken Connect (global::Org.Eclipse.Paho.Client.Mqttv3.MqttConnectOptions p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3']/interface[@name='IMqttAsyncClient']/method[@name='connect' and count(parameter)=3 and parameter[1][@type='org.eclipse.paho.client.mqttv3.MqttConnectOptions'] and parameter[2][@type='java.lang.Object'] and parameter[3][@type='org.eclipse.paho.client.mqttv3.IMqttActionListener']]"
		[Register ("connect", "(Lorg/eclipse/paho/client/mqttv3/MqttConnectOptions;Ljava/lang/Object;Lorg/eclipse/paho/client/mqttv3/IMqttActionListener;)Lorg/eclipse/paho/client/mqttv3/IMqttToken;", "GetConnect_Lorg_eclipse_paho_client_mqttv3_MqttConnectOptions_Ljava_lang_Object_Lorg_eclipse_paho_client_mqttv3_IMqttActionListener_Handler:Org.Eclipse.Paho.Client.Mqttv3.IMqttAsyncClientInvoker, OpenSourcePahoBinding")]
		global::Org.Eclipse.Paho.Client.Mqttv3.IMqttToken Connect (global::Org.Eclipse.Paho.Client.Mqttv3.MqttConnectOptions p0, global::Java.Lang.Object p1, global::Org.Eclipse.Paho.Client.Mqttv3.IMqttActionListener p2);

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3']/interface[@name='IMqttAsyncClient']/method[@name='disconnect' and count(parameter)=0]"
		[Register ("disconnect", "()Lorg/eclipse/paho/client/mqttv3/IMqttToken;", "GetDisconnectHandler:Org.Eclipse.Paho.Client.Mqttv3.IMqttAsyncClientInvoker, OpenSourcePahoBinding")]
		global::Org.Eclipse.Paho.Client.Mqttv3.IMqttToken Disconnect ();

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3']/interface[@name='IMqttAsyncClient']/method[@name='disconnect' and count(parameter)=2 and parameter[1][@type='java.lang.Object'] and parameter[2][@type='org.eclipse.paho.client.mqttv3.IMqttActionListener']]"
		[Register ("disconnect", "(Ljava/lang/Object;Lorg/eclipse/paho/client/mqttv3/IMqttActionListener;)Lorg/eclipse/paho/client/mqttv3/IMqttToken;", "GetDisconnect_Ljava_lang_Object_Lorg_eclipse_paho_client_mqttv3_IMqttActionListener_Handler:Org.Eclipse.Paho.Client.Mqttv3.IMqttAsyncClientInvoker, OpenSourcePahoBinding")]
		global::Org.Eclipse.Paho.Client.Mqttv3.IMqttToken Disconnect (global::Java.Lang.Object p0, global::Org.Eclipse.Paho.Client.Mqttv3.IMqttActionListener p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3']/interface[@name='IMqttAsyncClient']/method[@name='disconnect' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register ("disconnect", "(J)Lorg/eclipse/paho/client/mqttv3/IMqttToken;", "GetDisconnect_JHandler:Org.Eclipse.Paho.Client.Mqttv3.IMqttAsyncClientInvoker, OpenSourcePahoBinding")]
		global::Org.Eclipse.Paho.Client.Mqttv3.IMqttToken Disconnect (long p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3']/interface[@name='IMqttAsyncClient']/method[@name='disconnect' and count(parameter)=3 and parameter[1][@type='long'] and parameter[2][@type='java.lang.Object'] and parameter[3][@type='org.eclipse.paho.client.mqttv3.IMqttActionListener']]"
		[Register ("disconnect", "(JLjava/lang/Object;Lorg/eclipse/paho/client/mqttv3/IMqttActionListener;)Lorg/eclipse/paho/client/mqttv3/IMqttToken;", "GetDisconnect_JLjava_lang_Object_Lorg_eclipse_paho_client_mqttv3_IMqttActionListener_Handler:Org.Eclipse.Paho.Client.Mqttv3.IMqttAsyncClientInvoker, OpenSourcePahoBinding")]
		global::Org.Eclipse.Paho.Client.Mqttv3.IMqttToken Disconnect (long p0, global::Java.Lang.Object p1, global::Org.Eclipse.Paho.Client.Mqttv3.IMqttActionListener p2);

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3']/interface[@name='IMqttAsyncClient']/method[@name='disconnectForcibly' and count(parameter)=0]"
		[Register ("disconnectForcibly", "()V", "GetDisconnectForciblyHandler:Org.Eclipse.Paho.Client.Mqttv3.IMqttAsyncClientInvoker, OpenSourcePahoBinding")]
		void DisconnectForcibly ();

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3']/interface[@name='IMqttAsyncClient']/method[@name='disconnectForcibly' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register ("disconnectForcibly", "(J)V", "GetDisconnectForcibly_JHandler:Org.Eclipse.Paho.Client.Mqttv3.IMqttAsyncClientInvoker, OpenSourcePahoBinding")]
		void DisconnectForcibly (long p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3']/interface[@name='IMqttAsyncClient']/method[@name='disconnectForcibly' and count(parameter)=2 and parameter[1][@type='long'] and parameter[2][@type='long']]"
		[Register ("disconnectForcibly", "(JJ)V", "GetDisconnectForcibly_JJHandler:Org.Eclipse.Paho.Client.Mqttv3.IMqttAsyncClientInvoker, OpenSourcePahoBinding")]
		void DisconnectForcibly (long p0, long p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3']/interface[@name='IMqttAsyncClient']/method[@name='getPendingDeliveryTokens' and count(parameter)=0]"
		[Register ("getPendingDeliveryTokens", "()[Lorg/eclipse/paho/client/mqttv3/IMqttDeliveryToken;", "GetGetPendingDeliveryTokensHandler:Org.Eclipse.Paho.Client.Mqttv3.IMqttAsyncClientInvoker, OpenSourcePahoBinding")]
		global::Org.Eclipse.Paho.Client.Mqttv3.IMqttDeliveryToken[] GetPendingDeliveryTokens ();

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3']/interface[@name='IMqttAsyncClient']/method[@name='messageArrivedComplete' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
		[Register ("messageArrivedComplete", "(II)V", "GetMessageArrivedComplete_IIHandler:Org.Eclipse.Paho.Client.Mqttv3.IMqttAsyncClientInvoker, OpenSourcePahoBinding")]
		void MessageArrivedComplete (int p0, int p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3']/interface[@name='IMqttAsyncClient']/method[@name='publish' and count(parameter)=4 and parameter[1][@type='java.lang.String'] and parameter[2][@type='byte[]'] and parameter[3][@type='int'] and parameter[4][@type='boolean']]"
		[Register ("publish", "(Ljava/lang/String;[BIZ)Lorg/eclipse/paho/client/mqttv3/IMqttDeliveryToken;", "GetPublish_Ljava_lang_String_arrayBIZHandler:Org.Eclipse.Paho.Client.Mqttv3.IMqttAsyncClientInvoker, OpenSourcePahoBinding")]
		global::Org.Eclipse.Paho.Client.Mqttv3.IMqttDeliveryToken Publish (string p0, byte[] p1, int p2, bool p3);

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3']/interface[@name='IMqttAsyncClient']/method[@name='publish' and count(parameter)=6 and parameter[1][@type='java.lang.String'] and parameter[2][@type='byte[]'] and parameter[3][@type='int'] and parameter[4][@type='boolean'] and parameter[5][@type='java.lang.Object'] and parameter[6][@type='org.eclipse.paho.client.mqttv3.IMqttActionListener']]"
		[Register ("publish", "(Ljava/lang/String;[BIZLjava/lang/Object;Lorg/eclipse/paho/client/mqttv3/IMqttActionListener;)Lorg/eclipse/paho/client/mqttv3/IMqttDeliveryToken;", "GetPublish_Ljava_lang_String_arrayBIZLjava_lang_Object_Lorg_eclipse_paho_client_mqttv3_IMqttActionListener_Handler:Org.Eclipse.Paho.Client.Mqttv3.IMqttAsyncClientInvoker, OpenSourcePahoBinding")]
		global::Org.Eclipse.Paho.Client.Mqttv3.IMqttDeliveryToken Publish (string p0, byte[] p1, int p2, bool p3, global::Java.Lang.Object p4, global::Org.Eclipse.Paho.Client.Mqttv3.IMqttActionListener p5);

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3']/interface[@name='IMqttAsyncClient']/method[@name='publish' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='org.eclipse.paho.client.mqttv3.MqttMessage']]"
		[Register ("publish", "(Ljava/lang/String;Lorg/eclipse/paho/client/mqttv3/MqttMessage;)Lorg/eclipse/paho/client/mqttv3/IMqttDeliveryToken;", "GetPublish_Ljava_lang_String_Lorg_eclipse_paho_client_mqttv3_MqttMessage_Handler:Org.Eclipse.Paho.Client.Mqttv3.IMqttAsyncClientInvoker, OpenSourcePahoBinding")]
		global::Org.Eclipse.Paho.Client.Mqttv3.IMqttDeliveryToken Publish (string p0, global::Org.Eclipse.Paho.Client.Mqttv3.MqttMessage p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3']/interface[@name='IMqttAsyncClient']/method[@name='publish' and count(parameter)=4 and parameter[1][@type='java.lang.String'] and parameter[2][@type='org.eclipse.paho.client.mqttv3.MqttMessage'] and parameter[3][@type='java.lang.Object'] and parameter[4][@type='org.eclipse.paho.client.mqttv3.IMqttActionListener']]"
		[Register ("publish", "(Ljava/lang/String;Lorg/eclipse/paho/client/mqttv3/MqttMessage;Ljava/lang/Object;Lorg/eclipse/paho/client/mqttv3/IMqttActionListener;)Lorg/eclipse/paho/client/mqttv3/IMqttDeliveryToken;", "GetPublish_Ljava_lang_String_Lorg_eclipse_paho_client_mqttv3_MqttMessage_Ljava_lang_Object_Lorg_eclipse_paho_client_mqttv3_IMqttActionListener_Handler:Org.Eclipse.Paho.Client.Mqttv3.IMqttAsyncClientInvoker, OpenSourcePahoBinding")]
		global::Org.Eclipse.Paho.Client.Mqttv3.IMqttDeliveryToken Publish (string p0, global::Org.Eclipse.Paho.Client.Mqttv3.MqttMessage p1, global::Java.Lang.Object p2, global::Org.Eclipse.Paho.Client.Mqttv3.IMqttActionListener p3);

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3']/interface[@name='IMqttAsyncClient']/method[@name='setCallback' and count(parameter)=1 and parameter[1][@type='org.eclipse.paho.client.mqttv3.MqttCallback']]"
		[Register ("setCallback", "(Lorg/eclipse/paho/client/mqttv3/MqttCallback;)V", "GetSetCallback_Lorg_eclipse_paho_client_mqttv3_MqttCallback_Handler:Org.Eclipse.Paho.Client.Mqttv3.IMqttAsyncClientInvoker, OpenSourcePahoBinding")]
		void SetCallback (global::Org.Eclipse.Paho.Client.Mqttv3.IMqttCallback p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3']/interface[@name='IMqttAsyncClient']/method[@name='setManualAcks' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("setManualAcks", "(Z)V", "GetSetManualAcks_ZHandler:Org.Eclipse.Paho.Client.Mqttv3.IMqttAsyncClientInvoker, OpenSourcePahoBinding")]
		void SetManualAcks (bool p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3']/interface[@name='IMqttAsyncClient']/method[@name='subscribe' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='int']]"
		[Register ("subscribe", "(Ljava/lang/String;I)Lorg/eclipse/paho/client/mqttv3/IMqttToken;", "GetSubscribe_Ljava_lang_String_IHandler:Org.Eclipse.Paho.Client.Mqttv3.IMqttAsyncClientInvoker, OpenSourcePahoBinding")]
		global::Org.Eclipse.Paho.Client.Mqttv3.IMqttToken Subscribe (string p0, int p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3']/interface[@name='IMqttAsyncClient']/method[@name='subscribe' and count(parameter)=4 and parameter[1][@type='java.lang.String'] and parameter[2][@type='int'] and parameter[3][@type='java.lang.Object'] and parameter[4][@type='org.eclipse.paho.client.mqttv3.IMqttActionListener']]"
		[Register ("subscribe", "(Ljava/lang/String;ILjava/lang/Object;Lorg/eclipse/paho/client/mqttv3/IMqttActionListener;)Lorg/eclipse/paho/client/mqttv3/IMqttToken;", "GetSubscribe_Ljava_lang_String_ILjava_lang_Object_Lorg_eclipse_paho_client_mqttv3_IMqttActionListener_Handler:Org.Eclipse.Paho.Client.Mqttv3.IMqttAsyncClientInvoker, OpenSourcePahoBinding")]
		global::Org.Eclipse.Paho.Client.Mqttv3.IMqttToken Subscribe (string p0, int p1, global::Java.Lang.Object p2, global::Org.Eclipse.Paho.Client.Mqttv3.IMqttActionListener p3);

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3']/interface[@name='IMqttAsyncClient']/method[@name='subscribe' and count(parameter)=5 and parameter[1][@type='java.lang.String'] and parameter[2][@type='int'] and parameter[3][@type='java.lang.Object'] and parameter[4][@type='org.eclipse.paho.client.mqttv3.IMqttActionListener'] and parameter[5][@type='org.eclipse.paho.client.mqttv3.IMqttMessageListener']]"
		[Register ("subscribe", "(Ljava/lang/String;ILjava/lang/Object;Lorg/eclipse/paho/client/mqttv3/IMqttActionListener;Lorg/eclipse/paho/client/mqttv3/IMqttMessageListener;)Lorg/eclipse/paho/client/mqttv3/IMqttToken;", "GetSubscribe_Ljava_lang_String_ILjava_lang_Object_Lorg_eclipse_paho_client_mqttv3_IMqttActionListener_Lorg_eclipse_paho_client_mqttv3_IMqttMessageListener_Handler:Org.Eclipse.Paho.Client.Mqttv3.IMqttAsyncClientInvoker, OpenSourcePahoBinding")]
		global::Org.Eclipse.Paho.Client.Mqttv3.IMqttToken Subscribe (string p0, int p1, global::Java.Lang.Object p2, global::Org.Eclipse.Paho.Client.Mqttv3.IMqttActionListener p3, global::Org.Eclipse.Paho.Client.Mqttv3.IMqttMessageListener p4);

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3']/interface[@name='IMqttAsyncClient']/method[@name='subscribe' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='int'] and parameter[3][@type='org.eclipse.paho.client.mqttv3.IMqttMessageListener']]"
		[Register ("subscribe", "(Ljava/lang/String;ILorg/eclipse/paho/client/mqttv3/IMqttMessageListener;)Lorg/eclipse/paho/client/mqttv3/IMqttToken;", "GetSubscribe_Ljava_lang_String_ILorg_eclipse_paho_client_mqttv3_IMqttMessageListener_Handler:Org.Eclipse.Paho.Client.Mqttv3.IMqttAsyncClientInvoker, OpenSourcePahoBinding")]
		global::Org.Eclipse.Paho.Client.Mqttv3.IMqttToken Subscribe (string p0, int p1, global::Org.Eclipse.Paho.Client.Mqttv3.IMqttMessageListener p2);

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3']/interface[@name='IMqttAsyncClient']/method[@name='subscribe' and count(parameter)=2 and parameter[1][@type='java.lang.String[]'] and parameter[2][@type='int[]']]"
		[Register ("subscribe", "([Ljava/lang/String;[I)Lorg/eclipse/paho/client/mqttv3/IMqttToken;", "GetSubscribe_arrayLjava_lang_String_arrayIHandler:Org.Eclipse.Paho.Client.Mqttv3.IMqttAsyncClientInvoker, OpenSourcePahoBinding")]
		global::Org.Eclipse.Paho.Client.Mqttv3.IMqttToken Subscribe (string[] p0, int[] p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3']/interface[@name='IMqttAsyncClient']/method[@name='subscribe' and count(parameter)=4 and parameter[1][@type='java.lang.String[]'] and parameter[2][@type='int[]'] and parameter[3][@type='java.lang.Object'] and parameter[4][@type='org.eclipse.paho.client.mqttv3.IMqttActionListener']]"
		[Register ("subscribe", "([Ljava/lang/String;[ILjava/lang/Object;Lorg/eclipse/paho/client/mqttv3/IMqttActionListener;)Lorg/eclipse/paho/client/mqttv3/IMqttToken;", "GetSubscribe_arrayLjava_lang_String_arrayILjava_lang_Object_Lorg_eclipse_paho_client_mqttv3_IMqttActionListener_Handler:Org.Eclipse.Paho.Client.Mqttv3.IMqttAsyncClientInvoker, OpenSourcePahoBinding")]
		global::Org.Eclipse.Paho.Client.Mqttv3.IMqttToken Subscribe (string[] p0, int[] p1, global::Java.Lang.Object p2, global::Org.Eclipse.Paho.Client.Mqttv3.IMqttActionListener p3);

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3']/interface[@name='IMqttAsyncClient']/method[@name='subscribe' and count(parameter)=5 and parameter[1][@type='java.lang.String[]'] and parameter[2][@type='int[]'] and parameter[3][@type='java.lang.Object'] and parameter[4][@type='org.eclipse.paho.client.mqttv3.IMqttActionListener'] and parameter[5][@type='org.eclipse.paho.client.mqttv3.IMqttMessageListener[]']]"
		[Register ("subscribe", "([Ljava/lang/String;[ILjava/lang/Object;Lorg/eclipse/paho/client/mqttv3/IMqttActionListener;[Lorg/eclipse/paho/client/mqttv3/IMqttMessageListener;)Lorg/eclipse/paho/client/mqttv3/IMqttToken;", "GetSubscribe_arrayLjava_lang_String_arrayILjava_lang_Object_Lorg_eclipse_paho_client_mqttv3_IMqttActionListener_arrayLorg_eclipse_paho_client_mqttv3_IMqttMessageListener_Handler:Org.Eclipse.Paho.Client.Mqttv3.IMqttAsyncClientInvoker, OpenSourcePahoBinding")]
		global::Org.Eclipse.Paho.Client.Mqttv3.IMqttToken Subscribe (string[] p0, int[] p1, global::Java.Lang.Object p2, global::Org.Eclipse.Paho.Client.Mqttv3.IMqttActionListener p3, global::Org.Eclipse.Paho.Client.Mqttv3.IMqttMessageListener[] p4);

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3']/interface[@name='IMqttAsyncClient']/method[@name='subscribe' and count(parameter)=3 and parameter[1][@type='java.lang.String[]'] and parameter[2][@type='int[]'] and parameter[3][@type='org.eclipse.paho.client.mqttv3.IMqttMessageListener[]']]"
		[Register ("subscribe", "([Ljava/lang/String;[I[Lorg/eclipse/paho/client/mqttv3/IMqttMessageListener;)Lorg/eclipse/paho/client/mqttv3/IMqttToken;", "GetSubscribe_arrayLjava_lang_String_arrayIarrayLorg_eclipse_paho_client_mqttv3_IMqttMessageListener_Handler:Org.Eclipse.Paho.Client.Mqttv3.IMqttAsyncClientInvoker, OpenSourcePahoBinding")]
		global::Org.Eclipse.Paho.Client.Mqttv3.IMqttToken Subscribe (string[] p0, int[] p1, global::Org.Eclipse.Paho.Client.Mqttv3.IMqttMessageListener[] p2);

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3']/interface[@name='IMqttAsyncClient']/method[@name='unsubscribe' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("unsubscribe", "(Ljava/lang/String;)Lorg/eclipse/paho/client/mqttv3/IMqttToken;", "GetUnsubscribe_Ljava_lang_String_Handler:Org.Eclipse.Paho.Client.Mqttv3.IMqttAsyncClientInvoker, OpenSourcePahoBinding")]
		global::Org.Eclipse.Paho.Client.Mqttv3.IMqttToken Unsubscribe (string p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3']/interface[@name='IMqttAsyncClient']/method[@name='unsubscribe' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.Object'] and parameter[3][@type='org.eclipse.paho.client.mqttv3.IMqttActionListener']]"
		[Register ("unsubscribe", "(Ljava/lang/String;Ljava/lang/Object;Lorg/eclipse/paho/client/mqttv3/IMqttActionListener;)Lorg/eclipse/paho/client/mqttv3/IMqttToken;", "GetUnsubscribe_Ljava_lang_String_Ljava_lang_Object_Lorg_eclipse_paho_client_mqttv3_IMqttActionListener_Handler:Org.Eclipse.Paho.Client.Mqttv3.IMqttAsyncClientInvoker, OpenSourcePahoBinding")]
		global::Org.Eclipse.Paho.Client.Mqttv3.IMqttToken Unsubscribe (string p0, global::Java.Lang.Object p1, global::Org.Eclipse.Paho.Client.Mqttv3.IMqttActionListener p2);

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3']/interface[@name='IMqttAsyncClient']/method[@name='unsubscribe' and count(parameter)=1 and parameter[1][@type='java.lang.String[]']]"
		[Register ("unsubscribe", "([Ljava/lang/String;)Lorg/eclipse/paho/client/mqttv3/IMqttToken;", "GetUnsubscribe_arrayLjava_lang_String_Handler:Org.Eclipse.Paho.Client.Mqttv3.IMqttAsyncClientInvoker, OpenSourcePahoBinding")]
		global::Org.Eclipse.Paho.Client.Mqttv3.IMqttToken Unsubscribe (string[] p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3']/interface[@name='IMqttAsyncClient']/method[@name='unsubscribe' and count(parameter)=3 and parameter[1][@type='java.lang.String[]'] and parameter[2][@type='java.lang.Object'] and parameter[3][@type='org.eclipse.paho.client.mqttv3.IMqttActionListener']]"
		[Register ("unsubscribe", "([Ljava/lang/String;Ljava/lang/Object;Lorg/eclipse/paho/client/mqttv3/IMqttActionListener;)Lorg/eclipse/paho/client/mqttv3/IMqttToken;", "GetUnsubscribe_arrayLjava_lang_String_Ljava_lang_Object_Lorg_eclipse_paho_client_mqttv3_IMqttActionListener_Handler:Org.Eclipse.Paho.Client.Mqttv3.IMqttAsyncClientInvoker, OpenSourcePahoBinding")]
		global::Org.Eclipse.Paho.Client.Mqttv3.IMqttToken Unsubscribe (string[] p0, global::Java.Lang.Object p1, global::Org.Eclipse.Paho.Client.Mqttv3.IMqttActionListener p2);

	}

	[global::Android.Runtime.Register ("org/eclipse/paho/client/mqttv3/IMqttAsyncClient", DoNotGenerateAcw=true)]
	internal partial class IMqttAsyncClientInvoker : global::Java.Lang.Object, IMqttAsyncClient {

		static readonly JniPeerMembers _members = new XAPeerMembers ("org/eclipse/paho/client/mqttv3/IMqttAsyncClient", typeof (IMqttAsyncClientInvoker));

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

		public static IMqttAsyncClient GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IMqttAsyncClient> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "org.eclipse.paho.client.mqttv3.IMqttAsyncClient"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IMqttAsyncClientInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_getClientId;
#pragma warning disable 0169
		static Delegate GetGetClientIdHandler ()
		{
			if (cb_getClientId == null)
				cb_getClientId = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetClientId);
			return cb_getClientId;
		}

		static IntPtr n_GetClientId (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Eclipse.Paho.Client.Mqttv3.IMqttAsyncClient __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.IMqttAsyncClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.ClientId);
		}
#pragma warning restore 0169

		IntPtr id_getClientId;
		public unsafe string ClientId {
			get {
				if (id_getClientId == IntPtr.Zero)
					id_getClientId = JNIEnv.GetMethodID (class_ref, "getClientId", "()Ljava/lang/String;");
				return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getClientId), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_isConnected;
#pragma warning disable 0169
		static Delegate GetIsConnectedHandler ()
		{
			if (cb_isConnected == null)
				cb_isConnected = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsConnected);
			return cb_isConnected;
		}

		static bool n_IsConnected (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Eclipse.Paho.Client.Mqttv3.IMqttAsyncClient __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.IMqttAsyncClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsConnected;
		}
#pragma warning restore 0169

		IntPtr id_isConnected;
		public unsafe bool IsConnected {
			get {
				if (id_isConnected == IntPtr.Zero)
					id_isConnected = JNIEnv.GetMethodID (class_ref, "isConnected", "()Z");
				return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isConnected);
			}
		}

		static Delegate cb_getServerURI;
#pragma warning disable 0169
		static Delegate GetGetServerURIHandler ()
		{
			if (cb_getServerURI == null)
				cb_getServerURI = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetServerURI);
			return cb_getServerURI;
		}

		static IntPtr n_GetServerURI (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Eclipse.Paho.Client.Mqttv3.IMqttAsyncClient __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.IMqttAsyncClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.ServerURI);
		}
#pragma warning restore 0169

		IntPtr id_getServerURI;
		public unsafe string ServerURI {
			get {
				if (id_getServerURI == IntPtr.Zero)
					id_getServerURI = JNIEnv.GetMethodID (class_ref, "getServerURI", "()Ljava/lang/String;");
				return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getServerURI), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_close;
#pragma warning disable 0169
		static Delegate GetCloseHandler ()
		{
			if (cb_close == null)
				cb_close = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Close);
			return cb_close;
		}

		static void n_Close (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Eclipse.Paho.Client.Mqttv3.IMqttAsyncClient __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.IMqttAsyncClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Close ();
		}
#pragma warning restore 0169

		IntPtr id_close;
		public unsafe void Close ()
		{
			if (id_close == IntPtr.Zero)
				id_close = JNIEnv.GetMethodID (class_ref, "close", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_close);
		}

		static Delegate cb_connect;
#pragma warning disable 0169
		static Delegate GetConnectHandler ()
		{
			if (cb_connect == null)
				cb_connect = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_Connect);
			return cb_connect;
		}

		static IntPtr n_Connect (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Eclipse.Paho.Client.Mqttv3.IMqttAsyncClient __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.IMqttAsyncClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Connect ());
		}
#pragma warning restore 0169

		IntPtr id_connect;
		public unsafe global::Org.Eclipse.Paho.Client.Mqttv3.IMqttToken Connect ()
		{
			if (id_connect == IntPtr.Zero)
				id_connect = JNIEnv.GetMethodID (class_ref, "connect", "()Lorg/eclipse/paho/client/mqttv3/IMqttToken;");
			return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.IMqttToken> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_connect), JniHandleOwnership.TransferLocalRef);
		}

		static Delegate cb_connect_Ljava_lang_Object_Lorg_eclipse_paho_client_mqttv3_IMqttActionListener_;
#pragma warning disable 0169
		static Delegate GetConnect_Ljava_lang_Object_Lorg_eclipse_paho_client_mqttv3_IMqttActionListener_Handler ()
		{
			if (cb_connect_Ljava_lang_Object_Lorg_eclipse_paho_client_mqttv3_IMqttActionListener_ == null)
				cb_connect_Ljava_lang_Object_Lorg_eclipse_paho_client_mqttv3_IMqttActionListener_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_Connect_Ljava_lang_Object_Lorg_eclipse_paho_client_mqttv3_IMqttActionListener_);
			return cb_connect_Ljava_lang_Object_Lorg_eclipse_paho_client_mqttv3_IMqttActionListener_;
		}

		static IntPtr n_Connect_Ljava_lang_Object_Lorg_eclipse_paho_client_mqttv3_IMqttActionListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Org.Eclipse.Paho.Client.Mqttv3.IMqttAsyncClient __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.IMqttAsyncClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Org.Eclipse.Paho.Client.Mqttv3.IMqttActionListener p1 = (global::Org.Eclipse.Paho.Client.Mqttv3.IMqttActionListener)global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.IMqttActionListener> (native_p1, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Connect (p0, p1));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_connect_Ljava_lang_Object_Lorg_eclipse_paho_client_mqttv3_IMqttActionListener_;
		public unsafe global::Org.Eclipse.Paho.Client.Mqttv3.IMqttToken Connect (global::Java.Lang.Object p0, global::Org.Eclipse.Paho.Client.Mqttv3.IMqttActionListener p1)
		{
			if (id_connect_Ljava_lang_Object_Lorg_eclipse_paho_client_mqttv3_IMqttActionListener_ == IntPtr.Zero)
				id_connect_Ljava_lang_Object_Lorg_eclipse_paho_client_mqttv3_IMqttActionListener_ = JNIEnv.GetMethodID (class_ref, "connect", "(Ljava/lang/Object;Lorg/eclipse/paho/client/mqttv3/IMqttActionListener;)Lorg/eclipse/paho/client/mqttv3/IMqttToken;");
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			__args [1] = new JValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
			global::Org.Eclipse.Paho.Client.Mqttv3.IMqttToken __ret = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.IMqttToken> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_connect_Ljava_lang_Object_Lorg_eclipse_paho_client_mqttv3_IMqttActionListener_, __args), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static Delegate cb_connect_Lorg_eclipse_paho_client_mqttv3_MqttConnectOptions_;
#pragma warning disable 0169
		static Delegate GetConnect_Lorg_eclipse_paho_client_mqttv3_MqttConnectOptions_Handler ()
		{
			if (cb_connect_Lorg_eclipse_paho_client_mqttv3_MqttConnectOptions_ == null)
				cb_connect_Lorg_eclipse_paho_client_mqttv3_MqttConnectOptions_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_Connect_Lorg_eclipse_paho_client_mqttv3_MqttConnectOptions_);
			return cb_connect_Lorg_eclipse_paho_client_mqttv3_MqttConnectOptions_;
		}

		static IntPtr n_Connect_Lorg_eclipse_paho_client_mqttv3_MqttConnectOptions_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Org.Eclipse.Paho.Client.Mqttv3.IMqttAsyncClient __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.IMqttAsyncClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Org.Eclipse.Paho.Client.Mqttv3.MqttConnectOptions p0 = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.MqttConnectOptions> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Connect (p0));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_connect_Lorg_eclipse_paho_client_mqttv3_MqttConnectOptions_;
		public unsafe global::Org.Eclipse.Paho.Client.Mqttv3.IMqttToken Connect (global::Org.Eclipse.Paho.Client.Mqttv3.MqttConnectOptions p0)
		{
			if (id_connect_Lorg_eclipse_paho_client_mqttv3_MqttConnectOptions_ == IntPtr.Zero)
				id_connect_Lorg_eclipse_paho_client_mqttv3_MqttConnectOptions_ = JNIEnv.GetMethodID (class_ref, "connect", "(Lorg/eclipse/paho/client/mqttv3/MqttConnectOptions;)Lorg/eclipse/paho/client/mqttv3/IMqttToken;");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			global::Org.Eclipse.Paho.Client.Mqttv3.IMqttToken __ret = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.IMqttToken> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_connect_Lorg_eclipse_paho_client_mqttv3_MqttConnectOptions_, __args), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static Delegate cb_connect_Lorg_eclipse_paho_client_mqttv3_MqttConnectOptions_Ljava_lang_Object_Lorg_eclipse_paho_client_mqttv3_IMqttActionListener_;
#pragma warning disable 0169
		static Delegate GetConnect_Lorg_eclipse_paho_client_mqttv3_MqttConnectOptions_Ljava_lang_Object_Lorg_eclipse_paho_client_mqttv3_IMqttActionListener_Handler ()
		{
			if (cb_connect_Lorg_eclipse_paho_client_mqttv3_MqttConnectOptions_Ljava_lang_Object_Lorg_eclipse_paho_client_mqttv3_IMqttActionListener_ == null)
				cb_connect_Lorg_eclipse_paho_client_mqttv3_MqttConnectOptions_Ljava_lang_Object_Lorg_eclipse_paho_client_mqttv3_IMqttActionListener_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_Connect_Lorg_eclipse_paho_client_mqttv3_MqttConnectOptions_Ljava_lang_Object_Lorg_eclipse_paho_client_mqttv3_IMqttActionListener_);
			return cb_connect_Lorg_eclipse_paho_client_mqttv3_MqttConnectOptions_Ljava_lang_Object_Lorg_eclipse_paho_client_mqttv3_IMqttActionListener_;
		}

		static IntPtr n_Connect_Lorg_eclipse_paho_client_mqttv3_MqttConnectOptions_Ljava_lang_Object_Lorg_eclipse_paho_client_mqttv3_IMqttActionListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2)
		{
			global::Org.Eclipse.Paho.Client.Mqttv3.IMqttAsyncClient __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.IMqttAsyncClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Org.Eclipse.Paho.Client.Mqttv3.MqttConnectOptions p0 = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.MqttConnectOptions> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object p1 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p1, JniHandleOwnership.DoNotTransfer);
			global::Org.Eclipse.Paho.Client.Mqttv3.IMqttActionListener p2 = (global::Org.Eclipse.Paho.Client.Mqttv3.IMqttActionListener)global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.IMqttActionListener> (native_p2, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Connect (p0, p1, p2));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_connect_Lorg_eclipse_paho_client_mqttv3_MqttConnectOptions_Ljava_lang_Object_Lorg_eclipse_paho_client_mqttv3_IMqttActionListener_;
		public unsafe global::Org.Eclipse.Paho.Client.Mqttv3.IMqttToken Connect (global::Org.Eclipse.Paho.Client.Mqttv3.MqttConnectOptions p0, global::Java.Lang.Object p1, global::Org.Eclipse.Paho.Client.Mqttv3.IMqttActionListener p2)
		{
			if (id_connect_Lorg_eclipse_paho_client_mqttv3_MqttConnectOptions_Ljava_lang_Object_Lorg_eclipse_paho_client_mqttv3_IMqttActionListener_ == IntPtr.Zero)
				id_connect_Lorg_eclipse_paho_client_mqttv3_MqttConnectOptions_Ljava_lang_Object_Lorg_eclipse_paho_client_mqttv3_IMqttActionListener_ = JNIEnv.GetMethodID (class_ref, "connect", "(Lorg/eclipse/paho/client/mqttv3/MqttConnectOptions;Ljava/lang/Object;Lorg/eclipse/paho/client/mqttv3/IMqttActionListener;)Lorg/eclipse/paho/client/mqttv3/IMqttToken;");
			JValue* __args = stackalloc JValue [3];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			__args [1] = new JValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
			__args [2] = new JValue ((p2 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p2).Handle);
			global::Org.Eclipse.Paho.Client.Mqttv3.IMqttToken __ret = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.IMqttToken> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_connect_Lorg_eclipse_paho_client_mqttv3_MqttConnectOptions_Ljava_lang_Object_Lorg_eclipse_paho_client_mqttv3_IMqttActionListener_, __args), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static Delegate cb_disconnect;
#pragma warning disable 0169
		static Delegate GetDisconnectHandler ()
		{
			if (cb_disconnect == null)
				cb_disconnect = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_Disconnect);
			return cb_disconnect;
		}

		static IntPtr n_Disconnect (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Eclipse.Paho.Client.Mqttv3.IMqttAsyncClient __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.IMqttAsyncClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Disconnect ());
		}
#pragma warning restore 0169

		IntPtr id_disconnect;
		public unsafe global::Org.Eclipse.Paho.Client.Mqttv3.IMqttToken Disconnect ()
		{
			if (id_disconnect == IntPtr.Zero)
				id_disconnect = JNIEnv.GetMethodID (class_ref, "disconnect", "()Lorg/eclipse/paho/client/mqttv3/IMqttToken;");
			return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.IMqttToken> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_disconnect), JniHandleOwnership.TransferLocalRef);
		}

		static Delegate cb_disconnect_Ljava_lang_Object_Lorg_eclipse_paho_client_mqttv3_IMqttActionListener_;
#pragma warning disable 0169
		static Delegate GetDisconnect_Ljava_lang_Object_Lorg_eclipse_paho_client_mqttv3_IMqttActionListener_Handler ()
		{
			if (cb_disconnect_Ljava_lang_Object_Lorg_eclipse_paho_client_mqttv3_IMqttActionListener_ == null)
				cb_disconnect_Ljava_lang_Object_Lorg_eclipse_paho_client_mqttv3_IMqttActionListener_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_Disconnect_Ljava_lang_Object_Lorg_eclipse_paho_client_mqttv3_IMqttActionListener_);
			return cb_disconnect_Ljava_lang_Object_Lorg_eclipse_paho_client_mqttv3_IMqttActionListener_;
		}

		static IntPtr n_Disconnect_Ljava_lang_Object_Lorg_eclipse_paho_client_mqttv3_IMqttActionListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Org.Eclipse.Paho.Client.Mqttv3.IMqttAsyncClient __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.IMqttAsyncClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Org.Eclipse.Paho.Client.Mqttv3.IMqttActionListener p1 = (global::Org.Eclipse.Paho.Client.Mqttv3.IMqttActionListener)global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.IMqttActionListener> (native_p1, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Disconnect (p0, p1));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_disconnect_Ljava_lang_Object_Lorg_eclipse_paho_client_mqttv3_IMqttActionListener_;
		public unsafe global::Org.Eclipse.Paho.Client.Mqttv3.IMqttToken Disconnect (global::Java.Lang.Object p0, global::Org.Eclipse.Paho.Client.Mqttv3.IMqttActionListener p1)
		{
			if (id_disconnect_Ljava_lang_Object_Lorg_eclipse_paho_client_mqttv3_IMqttActionListener_ == IntPtr.Zero)
				id_disconnect_Ljava_lang_Object_Lorg_eclipse_paho_client_mqttv3_IMqttActionListener_ = JNIEnv.GetMethodID (class_ref, "disconnect", "(Ljava/lang/Object;Lorg/eclipse/paho/client/mqttv3/IMqttActionListener;)Lorg/eclipse/paho/client/mqttv3/IMqttToken;");
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			__args [1] = new JValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
			global::Org.Eclipse.Paho.Client.Mqttv3.IMqttToken __ret = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.IMqttToken> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_disconnect_Ljava_lang_Object_Lorg_eclipse_paho_client_mqttv3_IMqttActionListener_, __args), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static Delegate cb_disconnect_J;
#pragma warning disable 0169
		static Delegate GetDisconnect_JHandler ()
		{
			if (cb_disconnect_J == null)
				cb_disconnect_J = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long, IntPtr>) n_Disconnect_J);
			return cb_disconnect_J;
		}

		static IntPtr n_Disconnect_J (IntPtr jnienv, IntPtr native__this, long p0)
		{
			global::Org.Eclipse.Paho.Client.Mqttv3.IMqttAsyncClient __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.IMqttAsyncClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Disconnect (p0));
		}
#pragma warning restore 0169

		IntPtr id_disconnect_J;
		public unsafe global::Org.Eclipse.Paho.Client.Mqttv3.IMqttToken Disconnect (long p0)
		{
			if (id_disconnect_J == IntPtr.Zero)
				id_disconnect_J = JNIEnv.GetMethodID (class_ref, "disconnect", "(J)Lorg/eclipse/paho/client/mqttv3/IMqttToken;");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.IMqttToken> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_disconnect_J, __args), JniHandleOwnership.TransferLocalRef);
		}

		static Delegate cb_disconnect_JLjava_lang_Object_Lorg_eclipse_paho_client_mqttv3_IMqttActionListener_;
#pragma warning disable 0169
		static Delegate GetDisconnect_JLjava_lang_Object_Lorg_eclipse_paho_client_mqttv3_IMqttActionListener_Handler ()
		{
			if (cb_disconnect_JLjava_lang_Object_Lorg_eclipse_paho_client_mqttv3_IMqttActionListener_ == null)
				cb_disconnect_JLjava_lang_Object_Lorg_eclipse_paho_client_mqttv3_IMqttActionListener_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long, IntPtr, IntPtr, IntPtr>) n_Disconnect_JLjava_lang_Object_Lorg_eclipse_paho_client_mqttv3_IMqttActionListener_);
			return cb_disconnect_JLjava_lang_Object_Lorg_eclipse_paho_client_mqttv3_IMqttActionListener_;
		}

		static IntPtr n_Disconnect_JLjava_lang_Object_Lorg_eclipse_paho_client_mqttv3_IMqttActionListener_ (IntPtr jnienv, IntPtr native__this, long p0, IntPtr native_p1, IntPtr native_p2)
		{
			global::Org.Eclipse.Paho.Client.Mqttv3.IMqttAsyncClient __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.IMqttAsyncClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object p1 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p1, JniHandleOwnership.DoNotTransfer);
			global::Org.Eclipse.Paho.Client.Mqttv3.IMqttActionListener p2 = (global::Org.Eclipse.Paho.Client.Mqttv3.IMqttActionListener)global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.IMqttActionListener> (native_p2, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Disconnect (p0, p1, p2));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_disconnect_JLjava_lang_Object_Lorg_eclipse_paho_client_mqttv3_IMqttActionListener_;
		public unsafe global::Org.Eclipse.Paho.Client.Mqttv3.IMqttToken Disconnect (long p0, global::Java.Lang.Object p1, global::Org.Eclipse.Paho.Client.Mqttv3.IMqttActionListener p2)
		{
			if (id_disconnect_JLjava_lang_Object_Lorg_eclipse_paho_client_mqttv3_IMqttActionListener_ == IntPtr.Zero)
				id_disconnect_JLjava_lang_Object_Lorg_eclipse_paho_client_mqttv3_IMqttActionListener_ = JNIEnv.GetMethodID (class_ref, "disconnect", "(JLjava/lang/Object;Lorg/eclipse/paho/client/mqttv3/IMqttActionListener;)Lorg/eclipse/paho/client/mqttv3/IMqttToken;");
			JValue* __args = stackalloc JValue [3];
			__args [0] = new JValue (p0);
			__args [1] = new JValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
			__args [2] = new JValue ((p2 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p2).Handle);
			global::Org.Eclipse.Paho.Client.Mqttv3.IMqttToken __ret = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.IMqttToken> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_disconnect_JLjava_lang_Object_Lorg_eclipse_paho_client_mqttv3_IMqttActionListener_, __args), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static Delegate cb_disconnectForcibly;
#pragma warning disable 0169
		static Delegate GetDisconnectForciblyHandler ()
		{
			if (cb_disconnectForcibly == null)
				cb_disconnectForcibly = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_DisconnectForcibly);
			return cb_disconnectForcibly;
		}

		static void n_DisconnectForcibly (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Eclipse.Paho.Client.Mqttv3.IMqttAsyncClient __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.IMqttAsyncClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.DisconnectForcibly ();
		}
#pragma warning restore 0169

		IntPtr id_disconnectForcibly;
		public unsafe void DisconnectForcibly ()
		{
			if (id_disconnectForcibly == IntPtr.Zero)
				id_disconnectForcibly = JNIEnv.GetMethodID (class_ref, "disconnectForcibly", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_disconnectForcibly);
		}

		static Delegate cb_disconnectForcibly_J;
#pragma warning disable 0169
		static Delegate GetDisconnectForcibly_JHandler ()
		{
			if (cb_disconnectForcibly_J == null)
				cb_disconnectForcibly_J = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, long>) n_DisconnectForcibly_J);
			return cb_disconnectForcibly_J;
		}

		static void n_DisconnectForcibly_J (IntPtr jnienv, IntPtr native__this, long p0)
		{
			global::Org.Eclipse.Paho.Client.Mqttv3.IMqttAsyncClient __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.IMqttAsyncClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.DisconnectForcibly (p0);
		}
#pragma warning restore 0169

		IntPtr id_disconnectForcibly_J;
		public unsafe void DisconnectForcibly (long p0)
		{
			if (id_disconnectForcibly_J == IntPtr.Zero)
				id_disconnectForcibly_J = JNIEnv.GetMethodID (class_ref, "disconnectForcibly", "(J)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_disconnectForcibly_J, __args);
		}

		static Delegate cb_disconnectForcibly_JJ;
#pragma warning disable 0169
		static Delegate GetDisconnectForcibly_JJHandler ()
		{
			if (cb_disconnectForcibly_JJ == null)
				cb_disconnectForcibly_JJ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, long, long>) n_DisconnectForcibly_JJ);
			return cb_disconnectForcibly_JJ;
		}

		static void n_DisconnectForcibly_JJ (IntPtr jnienv, IntPtr native__this, long p0, long p1)
		{
			global::Org.Eclipse.Paho.Client.Mqttv3.IMqttAsyncClient __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.IMqttAsyncClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.DisconnectForcibly (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_disconnectForcibly_JJ;
		public unsafe void DisconnectForcibly (long p0, long p1)
		{
			if (id_disconnectForcibly_JJ == IntPtr.Zero)
				id_disconnectForcibly_JJ = JNIEnv.GetMethodID (class_ref, "disconnectForcibly", "(JJ)V");
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (p1);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_disconnectForcibly_JJ, __args);
		}

		static Delegate cb_getPendingDeliveryTokens;
#pragma warning disable 0169
		static Delegate GetGetPendingDeliveryTokensHandler ()
		{
			if (cb_getPendingDeliveryTokens == null)
				cb_getPendingDeliveryTokens = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetPendingDeliveryTokens);
			return cb_getPendingDeliveryTokens;
		}

		static IntPtr n_GetPendingDeliveryTokens (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Eclipse.Paho.Client.Mqttv3.IMqttAsyncClient __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.IMqttAsyncClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.GetPendingDeliveryTokens ());
		}
#pragma warning restore 0169

		IntPtr id_getPendingDeliveryTokens;
		public unsafe global::Org.Eclipse.Paho.Client.Mqttv3.IMqttDeliveryToken[] GetPendingDeliveryTokens ()
		{
			if (id_getPendingDeliveryTokens == IntPtr.Zero)
				id_getPendingDeliveryTokens = JNIEnv.GetMethodID (class_ref, "getPendingDeliveryTokens", "()[Lorg/eclipse/paho/client/mqttv3/IMqttDeliveryToken;");
			return (global::Org.Eclipse.Paho.Client.Mqttv3.IMqttDeliveryToken[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getPendingDeliveryTokens), JniHandleOwnership.TransferLocalRef, typeof (global::Org.Eclipse.Paho.Client.Mqttv3.IMqttDeliveryToken));
		}

		static Delegate cb_messageArrivedComplete_II;
#pragma warning disable 0169
		static Delegate GetMessageArrivedComplete_IIHandler ()
		{
			if (cb_messageArrivedComplete_II == null)
				cb_messageArrivedComplete_II = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int, int>) n_MessageArrivedComplete_II);
			return cb_messageArrivedComplete_II;
		}

		static void n_MessageArrivedComplete_II (IntPtr jnienv, IntPtr native__this, int p0, int p1)
		{
			global::Org.Eclipse.Paho.Client.Mqttv3.IMqttAsyncClient __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.IMqttAsyncClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.MessageArrivedComplete (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_messageArrivedComplete_II;
		public unsafe void MessageArrivedComplete (int p0, int p1)
		{
			if (id_messageArrivedComplete_II == IntPtr.Zero)
				id_messageArrivedComplete_II = JNIEnv.GetMethodID (class_ref, "messageArrivedComplete", "(II)V");
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (p1);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_messageArrivedComplete_II, __args);
		}

		static Delegate cb_publish_Ljava_lang_String_arrayBIZ;
#pragma warning disable 0169
		static Delegate GetPublish_Ljava_lang_String_arrayBIZHandler ()
		{
			if (cb_publish_Ljava_lang_String_arrayBIZ == null)
				cb_publish_Ljava_lang_String_arrayBIZ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, int, bool, IntPtr>) n_Publish_Ljava_lang_String_arrayBIZ);
			return cb_publish_Ljava_lang_String_arrayBIZ;
		}

		static IntPtr n_Publish_Ljava_lang_String_arrayBIZ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, int p2, bool p3)
		{
			global::Org.Eclipse.Paho.Client.Mqttv3.IMqttAsyncClient __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.IMqttAsyncClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			byte[] p1 = (byte[]) JNIEnv.GetArray (native_p1, JniHandleOwnership.DoNotTransfer, typeof (byte));
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Publish (p0, p1, p2, p3));
			if (p1 != null)
				JNIEnv.CopyArray (p1, native_p1);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_publish_Ljava_lang_String_arrayBIZ;
		public unsafe global::Org.Eclipse.Paho.Client.Mqttv3.IMqttDeliveryToken Publish (string p0, byte[] p1, int p2, bool p3)
		{
			if (id_publish_Ljava_lang_String_arrayBIZ == IntPtr.Zero)
				id_publish_Ljava_lang_String_arrayBIZ = JNIEnv.GetMethodID (class_ref, "publish", "(Ljava/lang/String;[BIZ)Lorg/eclipse/paho/client/mqttv3/IMqttDeliveryToken;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewArray (p1);
			JValue* __args = stackalloc JValue [4];
			__args [0] = new JValue (native_p0);
			__args [1] = new JValue (native_p1);
			__args [2] = new JValue (p2);
			__args [3] = new JValue (p3);
			global::Org.Eclipse.Paho.Client.Mqttv3.IMqttDeliveryToken __ret = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.IMqttDeliveryToken> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_publish_Ljava_lang_String_arrayBIZ, __args), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			if (p1 != null) {
				JNIEnv.CopyArray (native_p1, p1);
				JNIEnv.DeleteLocalRef (native_p1);
			}
			return __ret;
		}

		static Delegate cb_publish_Ljava_lang_String_arrayBIZLjava_lang_Object_Lorg_eclipse_paho_client_mqttv3_IMqttActionListener_;
#pragma warning disable 0169
		static Delegate GetPublish_Ljava_lang_String_arrayBIZLjava_lang_Object_Lorg_eclipse_paho_client_mqttv3_IMqttActionListener_Handler ()
		{
			if (cb_publish_Ljava_lang_String_arrayBIZLjava_lang_Object_Lorg_eclipse_paho_client_mqttv3_IMqttActionListener_ == null)
				cb_publish_Ljava_lang_String_arrayBIZLjava_lang_Object_Lorg_eclipse_paho_client_mqttv3_IMqttActionListener_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, int, bool, IntPtr, IntPtr, IntPtr>) n_Publish_Ljava_lang_String_arrayBIZLjava_lang_Object_Lorg_eclipse_paho_client_mqttv3_IMqttActionListener_);
			return cb_publish_Ljava_lang_String_arrayBIZLjava_lang_Object_Lorg_eclipse_paho_client_mqttv3_IMqttActionListener_;
		}

		static IntPtr n_Publish_Ljava_lang_String_arrayBIZLjava_lang_Object_Lorg_eclipse_paho_client_mqttv3_IMqttActionListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, int p2, bool p3, IntPtr native_p4, IntPtr native_p5)
		{
			global::Org.Eclipse.Paho.Client.Mqttv3.IMqttAsyncClient __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.IMqttAsyncClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			byte[] p1 = (byte[]) JNIEnv.GetArray (native_p1, JniHandleOwnership.DoNotTransfer, typeof (byte));
			global::Java.Lang.Object p4 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p4, JniHandleOwnership.DoNotTransfer);
			global::Org.Eclipse.Paho.Client.Mqttv3.IMqttActionListener p5 = (global::Org.Eclipse.Paho.Client.Mqttv3.IMqttActionListener)global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.IMqttActionListener> (native_p5, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Publish (p0, p1, p2, p3, p4, p5));
			if (p1 != null)
				JNIEnv.CopyArray (p1, native_p1);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_publish_Ljava_lang_String_arrayBIZLjava_lang_Object_Lorg_eclipse_paho_client_mqttv3_IMqttActionListener_;
		public unsafe global::Org.Eclipse.Paho.Client.Mqttv3.IMqttDeliveryToken Publish (string p0, byte[] p1, int p2, bool p3, global::Java.Lang.Object p4, global::Org.Eclipse.Paho.Client.Mqttv3.IMqttActionListener p5)
		{
			if (id_publish_Ljava_lang_String_arrayBIZLjava_lang_Object_Lorg_eclipse_paho_client_mqttv3_IMqttActionListener_ == IntPtr.Zero)
				id_publish_Ljava_lang_String_arrayBIZLjava_lang_Object_Lorg_eclipse_paho_client_mqttv3_IMqttActionListener_ = JNIEnv.GetMethodID (class_ref, "publish", "(Ljava/lang/String;[BIZLjava/lang/Object;Lorg/eclipse/paho/client/mqttv3/IMqttActionListener;)Lorg/eclipse/paho/client/mqttv3/IMqttDeliveryToken;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewArray (p1);
			JValue* __args = stackalloc JValue [6];
			__args [0] = new JValue (native_p0);
			__args [1] = new JValue (native_p1);
			__args [2] = new JValue (p2);
			__args [3] = new JValue (p3);
			__args [4] = new JValue ((p4 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p4).Handle);
			__args [5] = new JValue ((p5 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p5).Handle);
			global::Org.Eclipse.Paho.Client.Mqttv3.IMqttDeliveryToken __ret = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.IMqttDeliveryToken> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_publish_Ljava_lang_String_arrayBIZLjava_lang_Object_Lorg_eclipse_paho_client_mqttv3_IMqttActionListener_, __args), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			if (p1 != null) {
				JNIEnv.CopyArray (native_p1, p1);
				JNIEnv.DeleteLocalRef (native_p1);
			}
			return __ret;
		}

		static Delegate cb_publish_Ljava_lang_String_Lorg_eclipse_paho_client_mqttv3_MqttMessage_;
#pragma warning disable 0169
		static Delegate GetPublish_Ljava_lang_String_Lorg_eclipse_paho_client_mqttv3_MqttMessage_Handler ()
		{
			if (cb_publish_Ljava_lang_String_Lorg_eclipse_paho_client_mqttv3_MqttMessage_ == null)
				cb_publish_Ljava_lang_String_Lorg_eclipse_paho_client_mqttv3_MqttMessage_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_Publish_Ljava_lang_String_Lorg_eclipse_paho_client_mqttv3_MqttMessage_);
			return cb_publish_Ljava_lang_String_Lorg_eclipse_paho_client_mqttv3_MqttMessage_;
		}

		static IntPtr n_Publish_Ljava_lang_String_Lorg_eclipse_paho_client_mqttv3_MqttMessage_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Org.Eclipse.Paho.Client.Mqttv3.IMqttAsyncClient __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.IMqttAsyncClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Org.Eclipse.Paho.Client.Mqttv3.MqttMessage p1 = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.MqttMessage> (native_p1, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Publish (p0, p1));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_publish_Ljava_lang_String_Lorg_eclipse_paho_client_mqttv3_MqttMessage_;
		public unsafe global::Org.Eclipse.Paho.Client.Mqttv3.IMqttDeliveryToken Publish (string p0, global::Org.Eclipse.Paho.Client.Mqttv3.MqttMessage p1)
		{
			if (id_publish_Ljava_lang_String_Lorg_eclipse_paho_client_mqttv3_MqttMessage_ == IntPtr.Zero)
				id_publish_Ljava_lang_String_Lorg_eclipse_paho_client_mqttv3_MqttMessage_ = JNIEnv.GetMethodID (class_ref, "publish", "(Ljava/lang/String;Lorg/eclipse/paho/client/mqttv3/MqttMessage;)Lorg/eclipse/paho/client/mqttv3/IMqttDeliveryToken;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (native_p0);
			__args [1] = new JValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
			global::Org.Eclipse.Paho.Client.Mqttv3.IMqttDeliveryToken __ret = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.IMqttDeliveryToken> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_publish_Ljava_lang_String_Lorg_eclipse_paho_client_mqttv3_MqttMessage_, __args), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static Delegate cb_publish_Ljava_lang_String_Lorg_eclipse_paho_client_mqttv3_MqttMessage_Ljava_lang_Object_Lorg_eclipse_paho_client_mqttv3_IMqttActionListener_;
#pragma warning disable 0169
		static Delegate GetPublish_Ljava_lang_String_Lorg_eclipse_paho_client_mqttv3_MqttMessage_Ljava_lang_Object_Lorg_eclipse_paho_client_mqttv3_IMqttActionListener_Handler ()
		{
			if (cb_publish_Ljava_lang_String_Lorg_eclipse_paho_client_mqttv3_MqttMessage_Ljava_lang_Object_Lorg_eclipse_paho_client_mqttv3_IMqttActionListener_ == null)
				cb_publish_Ljava_lang_String_Lorg_eclipse_paho_client_mqttv3_MqttMessage_Ljava_lang_Object_Lorg_eclipse_paho_client_mqttv3_IMqttActionListener_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_Publish_Ljava_lang_String_Lorg_eclipse_paho_client_mqttv3_MqttMessage_Ljava_lang_Object_Lorg_eclipse_paho_client_mqttv3_IMqttActionListener_);
			return cb_publish_Ljava_lang_String_Lorg_eclipse_paho_client_mqttv3_MqttMessage_Ljava_lang_Object_Lorg_eclipse_paho_client_mqttv3_IMqttActionListener_;
		}

		static IntPtr n_Publish_Ljava_lang_String_Lorg_eclipse_paho_client_mqttv3_MqttMessage_Ljava_lang_Object_Lorg_eclipse_paho_client_mqttv3_IMqttActionListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2, IntPtr native_p3)
		{
			global::Org.Eclipse.Paho.Client.Mqttv3.IMqttAsyncClient __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.IMqttAsyncClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Org.Eclipse.Paho.Client.Mqttv3.MqttMessage p1 = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.MqttMessage> (native_p1, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object p2 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p2, JniHandleOwnership.DoNotTransfer);
			global::Org.Eclipse.Paho.Client.Mqttv3.IMqttActionListener p3 = (global::Org.Eclipse.Paho.Client.Mqttv3.IMqttActionListener)global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.IMqttActionListener> (native_p3, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Publish (p0, p1, p2, p3));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_publish_Ljava_lang_String_Lorg_eclipse_paho_client_mqttv3_MqttMessage_Ljava_lang_Object_Lorg_eclipse_paho_client_mqttv3_IMqttActionListener_;
		public unsafe global::Org.Eclipse.Paho.Client.Mqttv3.IMqttDeliveryToken Publish (string p0, global::Org.Eclipse.Paho.Client.Mqttv3.MqttMessage p1, global::Java.Lang.Object p2, global::Org.Eclipse.Paho.Client.Mqttv3.IMqttActionListener p3)
		{
			if (id_publish_Ljava_lang_String_Lorg_eclipse_paho_client_mqttv3_MqttMessage_Ljava_lang_Object_Lorg_eclipse_paho_client_mqttv3_IMqttActionListener_ == IntPtr.Zero)
				id_publish_Ljava_lang_String_Lorg_eclipse_paho_client_mqttv3_MqttMessage_Ljava_lang_Object_Lorg_eclipse_paho_client_mqttv3_IMqttActionListener_ = JNIEnv.GetMethodID (class_ref, "publish", "(Ljava/lang/String;Lorg/eclipse/paho/client/mqttv3/MqttMessage;Ljava/lang/Object;Lorg/eclipse/paho/client/mqttv3/IMqttActionListener;)Lorg/eclipse/paho/client/mqttv3/IMqttDeliveryToken;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			JValue* __args = stackalloc JValue [4];
			__args [0] = new JValue (native_p0);
			__args [1] = new JValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
			__args [2] = new JValue ((p2 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p2).Handle);
			__args [3] = new JValue ((p3 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p3).Handle);
			global::Org.Eclipse.Paho.Client.Mqttv3.IMqttDeliveryToken __ret = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.IMqttDeliveryToken> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_publish_Ljava_lang_String_Lorg_eclipse_paho_client_mqttv3_MqttMessage_Ljava_lang_Object_Lorg_eclipse_paho_client_mqttv3_IMqttActionListener_, __args), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static Delegate cb_setCallback_Lorg_eclipse_paho_client_mqttv3_MqttCallback_;
#pragma warning disable 0169
		static Delegate GetSetCallback_Lorg_eclipse_paho_client_mqttv3_MqttCallback_Handler ()
		{
			if (cb_setCallback_Lorg_eclipse_paho_client_mqttv3_MqttCallback_ == null)
				cb_setCallback_Lorg_eclipse_paho_client_mqttv3_MqttCallback_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetCallback_Lorg_eclipse_paho_client_mqttv3_MqttCallback_);
			return cb_setCallback_Lorg_eclipse_paho_client_mqttv3_MqttCallback_;
		}

		static void n_SetCallback_Lorg_eclipse_paho_client_mqttv3_MqttCallback_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Org.Eclipse.Paho.Client.Mqttv3.IMqttAsyncClient __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.IMqttAsyncClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Org.Eclipse.Paho.Client.Mqttv3.IMqttCallback p0 = (global::Org.Eclipse.Paho.Client.Mqttv3.IMqttCallback)global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.IMqttCallback> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetCallback (p0);
		}
#pragma warning restore 0169

		IntPtr id_setCallback_Lorg_eclipse_paho_client_mqttv3_MqttCallback_;
		public unsafe void SetCallback (global::Org.Eclipse.Paho.Client.Mqttv3.IMqttCallback p0)
		{
			if (id_setCallback_Lorg_eclipse_paho_client_mqttv3_MqttCallback_ == IntPtr.Zero)
				id_setCallback_Lorg_eclipse_paho_client_mqttv3_MqttCallback_ = JNIEnv.GetMethodID (class_ref, "setCallback", "(Lorg/eclipse/paho/client/mqttv3/MqttCallback;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setCallback_Lorg_eclipse_paho_client_mqttv3_MqttCallback_, __args);
		}

		static Delegate cb_setManualAcks_Z;
#pragma warning disable 0169
		static Delegate GetSetManualAcks_ZHandler ()
		{
			if (cb_setManualAcks_Z == null)
				cb_setManualAcks_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_SetManualAcks_Z);
			return cb_setManualAcks_Z;
		}

		static void n_SetManualAcks_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::Org.Eclipse.Paho.Client.Mqttv3.IMqttAsyncClient __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.IMqttAsyncClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetManualAcks (p0);
		}
#pragma warning restore 0169

		IntPtr id_setManualAcks_Z;
		public unsafe void SetManualAcks (bool p0)
		{
			if (id_setManualAcks_Z == IntPtr.Zero)
				id_setManualAcks_Z = JNIEnv.GetMethodID (class_ref, "setManualAcks", "(Z)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setManualAcks_Z, __args);
		}

		static Delegate cb_subscribe_Ljava_lang_String_I;
#pragma warning disable 0169
		static Delegate GetSubscribe_Ljava_lang_String_IHandler ()
		{
			if (cb_subscribe_Ljava_lang_String_I == null)
				cb_subscribe_Ljava_lang_String_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, int, IntPtr>) n_Subscribe_Ljava_lang_String_I);
			return cb_subscribe_Ljava_lang_String_I;
		}

		static IntPtr n_Subscribe_Ljava_lang_String_I (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1)
		{
			global::Org.Eclipse.Paho.Client.Mqttv3.IMqttAsyncClient __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.IMqttAsyncClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Subscribe (p0, p1));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_subscribe_Ljava_lang_String_I;
		public unsafe global::Org.Eclipse.Paho.Client.Mqttv3.IMqttToken Subscribe (string p0, int p1)
		{
			if (id_subscribe_Ljava_lang_String_I == IntPtr.Zero)
				id_subscribe_Ljava_lang_String_I = JNIEnv.GetMethodID (class_ref, "subscribe", "(Ljava/lang/String;I)Lorg/eclipse/paho/client/mqttv3/IMqttToken;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (native_p0);
			__args [1] = new JValue (p1);
			global::Org.Eclipse.Paho.Client.Mqttv3.IMqttToken __ret = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.IMqttToken> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_subscribe_Ljava_lang_String_I, __args), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static Delegate cb_subscribe_Ljava_lang_String_ILjava_lang_Object_Lorg_eclipse_paho_client_mqttv3_IMqttActionListener_;
#pragma warning disable 0169
		static Delegate GetSubscribe_Ljava_lang_String_ILjava_lang_Object_Lorg_eclipse_paho_client_mqttv3_IMqttActionListener_Handler ()
		{
			if (cb_subscribe_Ljava_lang_String_ILjava_lang_Object_Lorg_eclipse_paho_client_mqttv3_IMqttActionListener_ == null)
				cb_subscribe_Ljava_lang_String_ILjava_lang_Object_Lorg_eclipse_paho_client_mqttv3_IMqttActionListener_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, int, IntPtr, IntPtr, IntPtr>) n_Subscribe_Ljava_lang_String_ILjava_lang_Object_Lorg_eclipse_paho_client_mqttv3_IMqttActionListener_);
			return cb_subscribe_Ljava_lang_String_ILjava_lang_Object_Lorg_eclipse_paho_client_mqttv3_IMqttActionListener_;
		}

		static IntPtr n_Subscribe_Ljava_lang_String_ILjava_lang_Object_Lorg_eclipse_paho_client_mqttv3_IMqttActionListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1, IntPtr native_p2, IntPtr native_p3)
		{
			global::Org.Eclipse.Paho.Client.Mqttv3.IMqttAsyncClient __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.IMqttAsyncClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object p2 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p2, JniHandleOwnership.DoNotTransfer);
			global::Org.Eclipse.Paho.Client.Mqttv3.IMqttActionListener p3 = (global::Org.Eclipse.Paho.Client.Mqttv3.IMqttActionListener)global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.IMqttActionListener> (native_p3, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Subscribe (p0, p1, p2, p3));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_subscribe_Ljava_lang_String_ILjava_lang_Object_Lorg_eclipse_paho_client_mqttv3_IMqttActionListener_;
		public unsafe global::Org.Eclipse.Paho.Client.Mqttv3.IMqttToken Subscribe (string p0, int p1, global::Java.Lang.Object p2, global::Org.Eclipse.Paho.Client.Mqttv3.IMqttActionListener p3)
		{
			if (id_subscribe_Ljava_lang_String_ILjava_lang_Object_Lorg_eclipse_paho_client_mqttv3_IMqttActionListener_ == IntPtr.Zero)
				id_subscribe_Ljava_lang_String_ILjava_lang_Object_Lorg_eclipse_paho_client_mqttv3_IMqttActionListener_ = JNIEnv.GetMethodID (class_ref, "subscribe", "(Ljava/lang/String;ILjava/lang/Object;Lorg/eclipse/paho/client/mqttv3/IMqttActionListener;)Lorg/eclipse/paho/client/mqttv3/IMqttToken;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			JValue* __args = stackalloc JValue [4];
			__args [0] = new JValue (native_p0);
			__args [1] = new JValue (p1);
			__args [2] = new JValue ((p2 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p2).Handle);
			__args [3] = new JValue ((p3 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p3).Handle);
			global::Org.Eclipse.Paho.Client.Mqttv3.IMqttToken __ret = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.IMqttToken> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_subscribe_Ljava_lang_String_ILjava_lang_Object_Lorg_eclipse_paho_client_mqttv3_IMqttActionListener_, __args), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static Delegate cb_subscribe_Ljava_lang_String_ILjava_lang_Object_Lorg_eclipse_paho_client_mqttv3_IMqttActionListener_Lorg_eclipse_paho_client_mqttv3_IMqttMessageListener_;
#pragma warning disable 0169
		static Delegate GetSubscribe_Ljava_lang_String_ILjava_lang_Object_Lorg_eclipse_paho_client_mqttv3_IMqttActionListener_Lorg_eclipse_paho_client_mqttv3_IMqttMessageListener_Handler ()
		{
			if (cb_subscribe_Ljava_lang_String_ILjava_lang_Object_Lorg_eclipse_paho_client_mqttv3_IMqttActionListener_Lorg_eclipse_paho_client_mqttv3_IMqttMessageListener_ == null)
				cb_subscribe_Ljava_lang_String_ILjava_lang_Object_Lorg_eclipse_paho_client_mqttv3_IMqttActionListener_Lorg_eclipse_paho_client_mqttv3_IMqttMessageListener_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, int, IntPtr, IntPtr, IntPtr, IntPtr>) n_Subscribe_Ljava_lang_String_ILjava_lang_Object_Lorg_eclipse_paho_client_mqttv3_IMqttActionListener_Lorg_eclipse_paho_client_mqttv3_IMqttMessageListener_);
			return cb_subscribe_Ljava_lang_String_ILjava_lang_Object_Lorg_eclipse_paho_client_mqttv3_IMqttActionListener_Lorg_eclipse_paho_client_mqttv3_IMqttMessageListener_;
		}

		static IntPtr n_Subscribe_Ljava_lang_String_ILjava_lang_Object_Lorg_eclipse_paho_client_mqttv3_IMqttActionListener_Lorg_eclipse_paho_client_mqttv3_IMqttMessageListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1, IntPtr native_p2, IntPtr native_p3, IntPtr native_p4)
		{
			global::Org.Eclipse.Paho.Client.Mqttv3.IMqttAsyncClient __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.IMqttAsyncClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object p2 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p2, JniHandleOwnership.DoNotTransfer);
			global::Org.Eclipse.Paho.Client.Mqttv3.IMqttActionListener p3 = (global::Org.Eclipse.Paho.Client.Mqttv3.IMqttActionListener)global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.IMqttActionListener> (native_p3, JniHandleOwnership.DoNotTransfer);
			global::Org.Eclipse.Paho.Client.Mqttv3.IMqttMessageListener p4 = (global::Org.Eclipse.Paho.Client.Mqttv3.IMqttMessageListener)global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.IMqttMessageListener> (native_p4, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Subscribe (p0, p1, p2, p3, p4));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_subscribe_Ljava_lang_String_ILjava_lang_Object_Lorg_eclipse_paho_client_mqttv3_IMqttActionListener_Lorg_eclipse_paho_client_mqttv3_IMqttMessageListener_;
		public unsafe global::Org.Eclipse.Paho.Client.Mqttv3.IMqttToken Subscribe (string p0, int p1, global::Java.Lang.Object p2, global::Org.Eclipse.Paho.Client.Mqttv3.IMqttActionListener p3, global::Org.Eclipse.Paho.Client.Mqttv3.IMqttMessageListener p4)
		{
			if (id_subscribe_Ljava_lang_String_ILjava_lang_Object_Lorg_eclipse_paho_client_mqttv3_IMqttActionListener_Lorg_eclipse_paho_client_mqttv3_IMqttMessageListener_ == IntPtr.Zero)
				id_subscribe_Ljava_lang_String_ILjava_lang_Object_Lorg_eclipse_paho_client_mqttv3_IMqttActionListener_Lorg_eclipse_paho_client_mqttv3_IMqttMessageListener_ = JNIEnv.GetMethodID (class_ref, "subscribe", "(Ljava/lang/String;ILjava/lang/Object;Lorg/eclipse/paho/client/mqttv3/IMqttActionListener;Lorg/eclipse/paho/client/mqttv3/IMqttMessageListener;)Lorg/eclipse/paho/client/mqttv3/IMqttToken;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			JValue* __args = stackalloc JValue [5];
			__args [0] = new JValue (native_p0);
			__args [1] = new JValue (p1);
			__args [2] = new JValue ((p2 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p2).Handle);
			__args [3] = new JValue ((p3 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p3).Handle);
			__args [4] = new JValue ((p4 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p4).Handle);
			global::Org.Eclipse.Paho.Client.Mqttv3.IMqttToken __ret = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.IMqttToken> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_subscribe_Ljava_lang_String_ILjava_lang_Object_Lorg_eclipse_paho_client_mqttv3_IMqttActionListener_Lorg_eclipse_paho_client_mqttv3_IMqttMessageListener_, __args), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static Delegate cb_subscribe_Ljava_lang_String_ILorg_eclipse_paho_client_mqttv3_IMqttMessageListener_;
#pragma warning disable 0169
		static Delegate GetSubscribe_Ljava_lang_String_ILorg_eclipse_paho_client_mqttv3_IMqttMessageListener_Handler ()
		{
			if (cb_subscribe_Ljava_lang_String_ILorg_eclipse_paho_client_mqttv3_IMqttMessageListener_ == null)
				cb_subscribe_Ljava_lang_String_ILorg_eclipse_paho_client_mqttv3_IMqttMessageListener_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, int, IntPtr, IntPtr>) n_Subscribe_Ljava_lang_String_ILorg_eclipse_paho_client_mqttv3_IMqttMessageListener_);
			return cb_subscribe_Ljava_lang_String_ILorg_eclipse_paho_client_mqttv3_IMqttMessageListener_;
		}

		static IntPtr n_Subscribe_Ljava_lang_String_ILorg_eclipse_paho_client_mqttv3_IMqttMessageListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1, IntPtr native_p2)
		{
			global::Org.Eclipse.Paho.Client.Mqttv3.IMqttAsyncClient __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.IMqttAsyncClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Org.Eclipse.Paho.Client.Mqttv3.IMqttMessageListener p2 = (global::Org.Eclipse.Paho.Client.Mqttv3.IMqttMessageListener)global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.IMqttMessageListener> (native_p2, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Subscribe (p0, p1, p2));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_subscribe_Ljava_lang_String_ILorg_eclipse_paho_client_mqttv3_IMqttMessageListener_;
		public unsafe global::Org.Eclipse.Paho.Client.Mqttv3.IMqttToken Subscribe (string p0, int p1, global::Org.Eclipse.Paho.Client.Mqttv3.IMqttMessageListener p2)
		{
			if (id_subscribe_Ljava_lang_String_ILorg_eclipse_paho_client_mqttv3_IMqttMessageListener_ == IntPtr.Zero)
				id_subscribe_Ljava_lang_String_ILorg_eclipse_paho_client_mqttv3_IMqttMessageListener_ = JNIEnv.GetMethodID (class_ref, "subscribe", "(Ljava/lang/String;ILorg/eclipse/paho/client/mqttv3/IMqttMessageListener;)Lorg/eclipse/paho/client/mqttv3/IMqttToken;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			JValue* __args = stackalloc JValue [3];
			__args [0] = new JValue (native_p0);
			__args [1] = new JValue (p1);
			__args [2] = new JValue ((p2 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p2).Handle);
			global::Org.Eclipse.Paho.Client.Mqttv3.IMqttToken __ret = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.IMqttToken> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_subscribe_Ljava_lang_String_ILorg_eclipse_paho_client_mqttv3_IMqttMessageListener_, __args), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static Delegate cb_subscribe_arrayLjava_lang_String_arrayI;
#pragma warning disable 0169
		static Delegate GetSubscribe_arrayLjava_lang_String_arrayIHandler ()
		{
			if (cb_subscribe_arrayLjava_lang_String_arrayI == null)
				cb_subscribe_arrayLjava_lang_String_arrayI = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_Subscribe_arrayLjava_lang_String_arrayI);
			return cb_subscribe_arrayLjava_lang_String_arrayI;
		}

		static IntPtr n_Subscribe_arrayLjava_lang_String_arrayI (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Org.Eclipse.Paho.Client.Mqttv3.IMqttAsyncClient __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.IMqttAsyncClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string[] p0 = (string[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (string));
			int[] p1 = (int[]) JNIEnv.GetArray (native_p1, JniHandleOwnership.DoNotTransfer, typeof (int));
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Subscribe (p0, p1));
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
			if (p1 != null)
				JNIEnv.CopyArray (p1, native_p1);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_subscribe_arrayLjava_lang_String_arrayI;
		public unsafe global::Org.Eclipse.Paho.Client.Mqttv3.IMqttToken Subscribe (string[] p0, int[] p1)
		{
			if (id_subscribe_arrayLjava_lang_String_arrayI == IntPtr.Zero)
				id_subscribe_arrayLjava_lang_String_arrayI = JNIEnv.GetMethodID (class_ref, "subscribe", "([Ljava/lang/String;[I)Lorg/eclipse/paho/client/mqttv3/IMqttToken;");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			IntPtr native_p1 = JNIEnv.NewArray (p1);
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (native_p0);
			__args [1] = new JValue (native_p1);
			global::Org.Eclipse.Paho.Client.Mqttv3.IMqttToken __ret = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.IMqttToken> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_subscribe_arrayLjava_lang_String_arrayI, __args), JniHandleOwnership.TransferLocalRef);
			if (p0 != null) {
				JNIEnv.CopyArray (native_p0, p0);
				JNIEnv.DeleteLocalRef (native_p0);
			}
			if (p1 != null) {
				JNIEnv.CopyArray (native_p1, p1);
				JNIEnv.DeleteLocalRef (native_p1);
			}
			return __ret;
		}

		static Delegate cb_subscribe_arrayLjava_lang_String_arrayILjava_lang_Object_Lorg_eclipse_paho_client_mqttv3_IMqttActionListener_;
#pragma warning disable 0169
		static Delegate GetSubscribe_arrayLjava_lang_String_arrayILjava_lang_Object_Lorg_eclipse_paho_client_mqttv3_IMqttActionListener_Handler ()
		{
			if (cb_subscribe_arrayLjava_lang_String_arrayILjava_lang_Object_Lorg_eclipse_paho_client_mqttv3_IMqttActionListener_ == null)
				cb_subscribe_arrayLjava_lang_String_arrayILjava_lang_Object_Lorg_eclipse_paho_client_mqttv3_IMqttActionListener_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_Subscribe_arrayLjava_lang_String_arrayILjava_lang_Object_Lorg_eclipse_paho_client_mqttv3_IMqttActionListener_);
			return cb_subscribe_arrayLjava_lang_String_arrayILjava_lang_Object_Lorg_eclipse_paho_client_mqttv3_IMqttActionListener_;
		}

		static IntPtr n_Subscribe_arrayLjava_lang_String_arrayILjava_lang_Object_Lorg_eclipse_paho_client_mqttv3_IMqttActionListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2, IntPtr native_p3)
		{
			global::Org.Eclipse.Paho.Client.Mqttv3.IMqttAsyncClient __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.IMqttAsyncClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string[] p0 = (string[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (string));
			int[] p1 = (int[]) JNIEnv.GetArray (native_p1, JniHandleOwnership.DoNotTransfer, typeof (int));
			global::Java.Lang.Object p2 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p2, JniHandleOwnership.DoNotTransfer);
			global::Org.Eclipse.Paho.Client.Mqttv3.IMqttActionListener p3 = (global::Org.Eclipse.Paho.Client.Mqttv3.IMqttActionListener)global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.IMqttActionListener> (native_p3, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Subscribe (p0, p1, p2, p3));
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
			if (p1 != null)
				JNIEnv.CopyArray (p1, native_p1);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_subscribe_arrayLjava_lang_String_arrayILjava_lang_Object_Lorg_eclipse_paho_client_mqttv3_IMqttActionListener_;
		public unsafe global::Org.Eclipse.Paho.Client.Mqttv3.IMqttToken Subscribe (string[] p0, int[] p1, global::Java.Lang.Object p2, global::Org.Eclipse.Paho.Client.Mqttv3.IMqttActionListener p3)
		{
			if (id_subscribe_arrayLjava_lang_String_arrayILjava_lang_Object_Lorg_eclipse_paho_client_mqttv3_IMqttActionListener_ == IntPtr.Zero)
				id_subscribe_arrayLjava_lang_String_arrayILjava_lang_Object_Lorg_eclipse_paho_client_mqttv3_IMqttActionListener_ = JNIEnv.GetMethodID (class_ref, "subscribe", "([Ljava/lang/String;[ILjava/lang/Object;Lorg/eclipse/paho/client/mqttv3/IMqttActionListener;)Lorg/eclipse/paho/client/mqttv3/IMqttToken;");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			IntPtr native_p1 = JNIEnv.NewArray (p1);
			JValue* __args = stackalloc JValue [4];
			__args [0] = new JValue (native_p0);
			__args [1] = new JValue (native_p1);
			__args [2] = new JValue ((p2 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p2).Handle);
			__args [3] = new JValue ((p3 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p3).Handle);
			global::Org.Eclipse.Paho.Client.Mqttv3.IMqttToken __ret = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.IMqttToken> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_subscribe_arrayLjava_lang_String_arrayILjava_lang_Object_Lorg_eclipse_paho_client_mqttv3_IMqttActionListener_, __args), JniHandleOwnership.TransferLocalRef);
			if (p0 != null) {
				JNIEnv.CopyArray (native_p0, p0);
				JNIEnv.DeleteLocalRef (native_p0);
			}
			if (p1 != null) {
				JNIEnv.CopyArray (native_p1, p1);
				JNIEnv.DeleteLocalRef (native_p1);
			}
			return __ret;
		}

		static Delegate cb_subscribe_arrayLjava_lang_String_arrayILjava_lang_Object_Lorg_eclipse_paho_client_mqttv3_IMqttActionListener_arrayLorg_eclipse_paho_client_mqttv3_IMqttMessageListener_;
#pragma warning disable 0169
		static Delegate GetSubscribe_arrayLjava_lang_String_arrayILjava_lang_Object_Lorg_eclipse_paho_client_mqttv3_IMqttActionListener_arrayLorg_eclipse_paho_client_mqttv3_IMqttMessageListener_Handler ()
		{
			if (cb_subscribe_arrayLjava_lang_String_arrayILjava_lang_Object_Lorg_eclipse_paho_client_mqttv3_IMqttActionListener_arrayLorg_eclipse_paho_client_mqttv3_IMqttMessageListener_ == null)
				cb_subscribe_arrayLjava_lang_String_arrayILjava_lang_Object_Lorg_eclipse_paho_client_mqttv3_IMqttActionListener_arrayLorg_eclipse_paho_client_mqttv3_IMqttMessageListener_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_Subscribe_arrayLjava_lang_String_arrayILjava_lang_Object_Lorg_eclipse_paho_client_mqttv3_IMqttActionListener_arrayLorg_eclipse_paho_client_mqttv3_IMqttMessageListener_);
			return cb_subscribe_arrayLjava_lang_String_arrayILjava_lang_Object_Lorg_eclipse_paho_client_mqttv3_IMqttActionListener_arrayLorg_eclipse_paho_client_mqttv3_IMqttMessageListener_;
		}

		static IntPtr n_Subscribe_arrayLjava_lang_String_arrayILjava_lang_Object_Lorg_eclipse_paho_client_mqttv3_IMqttActionListener_arrayLorg_eclipse_paho_client_mqttv3_IMqttMessageListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2, IntPtr native_p3, IntPtr native_p4)
		{
			global::Org.Eclipse.Paho.Client.Mqttv3.IMqttAsyncClient __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.IMqttAsyncClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string[] p0 = (string[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (string));
			int[] p1 = (int[]) JNIEnv.GetArray (native_p1, JniHandleOwnership.DoNotTransfer, typeof (int));
			global::Java.Lang.Object p2 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p2, JniHandleOwnership.DoNotTransfer);
			global::Org.Eclipse.Paho.Client.Mqttv3.IMqttActionListener p3 = (global::Org.Eclipse.Paho.Client.Mqttv3.IMqttActionListener)global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.IMqttActionListener> (native_p3, JniHandleOwnership.DoNotTransfer);
			global::Org.Eclipse.Paho.Client.Mqttv3.IMqttMessageListener[] p4 = (global::Org.Eclipse.Paho.Client.Mqttv3.IMqttMessageListener[]) JNIEnv.GetArray (native_p4, JniHandleOwnership.DoNotTransfer, typeof (global::Org.Eclipse.Paho.Client.Mqttv3.IMqttMessageListener));
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Subscribe (p0, p1, p2, p3, p4));
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
			if (p1 != null)
				JNIEnv.CopyArray (p1, native_p1);
			if (p4 != null)
				JNIEnv.CopyArray (p4, native_p4);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_subscribe_arrayLjava_lang_String_arrayILjava_lang_Object_Lorg_eclipse_paho_client_mqttv3_IMqttActionListener_arrayLorg_eclipse_paho_client_mqttv3_IMqttMessageListener_;
		public unsafe global::Org.Eclipse.Paho.Client.Mqttv3.IMqttToken Subscribe (string[] p0, int[] p1, global::Java.Lang.Object p2, global::Org.Eclipse.Paho.Client.Mqttv3.IMqttActionListener p3, global::Org.Eclipse.Paho.Client.Mqttv3.IMqttMessageListener[] p4)
		{
			if (id_subscribe_arrayLjava_lang_String_arrayILjava_lang_Object_Lorg_eclipse_paho_client_mqttv3_IMqttActionListener_arrayLorg_eclipse_paho_client_mqttv3_IMqttMessageListener_ == IntPtr.Zero)
				id_subscribe_arrayLjava_lang_String_arrayILjava_lang_Object_Lorg_eclipse_paho_client_mqttv3_IMqttActionListener_arrayLorg_eclipse_paho_client_mqttv3_IMqttMessageListener_ = JNIEnv.GetMethodID (class_ref, "subscribe", "([Ljava/lang/String;[ILjava/lang/Object;Lorg/eclipse/paho/client/mqttv3/IMqttActionListener;[Lorg/eclipse/paho/client/mqttv3/IMqttMessageListener;)Lorg/eclipse/paho/client/mqttv3/IMqttToken;");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			IntPtr native_p1 = JNIEnv.NewArray (p1);
			IntPtr native_p4 = JNIEnv.NewArray (p4);
			JValue* __args = stackalloc JValue [5];
			__args [0] = new JValue (native_p0);
			__args [1] = new JValue (native_p1);
			__args [2] = new JValue ((p2 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p2).Handle);
			__args [3] = new JValue ((p3 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p3).Handle);
			__args [4] = new JValue (native_p4);
			global::Org.Eclipse.Paho.Client.Mqttv3.IMqttToken __ret = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.IMqttToken> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_subscribe_arrayLjava_lang_String_arrayILjava_lang_Object_Lorg_eclipse_paho_client_mqttv3_IMqttActionListener_arrayLorg_eclipse_paho_client_mqttv3_IMqttMessageListener_, __args), JniHandleOwnership.TransferLocalRef);
			if (p0 != null) {
				JNIEnv.CopyArray (native_p0, p0);
				JNIEnv.DeleteLocalRef (native_p0);
			}
			if (p1 != null) {
				JNIEnv.CopyArray (native_p1, p1);
				JNIEnv.DeleteLocalRef (native_p1);
			}
			if (p4 != null) {
				JNIEnv.CopyArray (native_p4, p4);
				JNIEnv.DeleteLocalRef (native_p4);
			}
			return __ret;
		}

		static Delegate cb_subscribe_arrayLjava_lang_String_arrayIarrayLorg_eclipse_paho_client_mqttv3_IMqttMessageListener_;
#pragma warning disable 0169
		static Delegate GetSubscribe_arrayLjava_lang_String_arrayIarrayLorg_eclipse_paho_client_mqttv3_IMqttMessageListener_Handler ()
		{
			if (cb_subscribe_arrayLjava_lang_String_arrayIarrayLorg_eclipse_paho_client_mqttv3_IMqttMessageListener_ == null)
				cb_subscribe_arrayLjava_lang_String_arrayIarrayLorg_eclipse_paho_client_mqttv3_IMqttMessageListener_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_Subscribe_arrayLjava_lang_String_arrayIarrayLorg_eclipse_paho_client_mqttv3_IMqttMessageListener_);
			return cb_subscribe_arrayLjava_lang_String_arrayIarrayLorg_eclipse_paho_client_mqttv3_IMqttMessageListener_;
		}

		static IntPtr n_Subscribe_arrayLjava_lang_String_arrayIarrayLorg_eclipse_paho_client_mqttv3_IMqttMessageListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2)
		{
			global::Org.Eclipse.Paho.Client.Mqttv3.IMqttAsyncClient __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.IMqttAsyncClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string[] p0 = (string[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (string));
			int[] p1 = (int[]) JNIEnv.GetArray (native_p1, JniHandleOwnership.DoNotTransfer, typeof (int));
			global::Org.Eclipse.Paho.Client.Mqttv3.IMqttMessageListener[] p2 = (global::Org.Eclipse.Paho.Client.Mqttv3.IMqttMessageListener[]) JNIEnv.GetArray (native_p2, JniHandleOwnership.DoNotTransfer, typeof (global::Org.Eclipse.Paho.Client.Mqttv3.IMqttMessageListener));
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Subscribe (p0, p1, p2));
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
			if (p1 != null)
				JNIEnv.CopyArray (p1, native_p1);
			if (p2 != null)
				JNIEnv.CopyArray (p2, native_p2);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_subscribe_arrayLjava_lang_String_arrayIarrayLorg_eclipse_paho_client_mqttv3_IMqttMessageListener_;
		public unsafe global::Org.Eclipse.Paho.Client.Mqttv3.IMqttToken Subscribe (string[] p0, int[] p1, global::Org.Eclipse.Paho.Client.Mqttv3.IMqttMessageListener[] p2)
		{
			if (id_subscribe_arrayLjava_lang_String_arrayIarrayLorg_eclipse_paho_client_mqttv3_IMqttMessageListener_ == IntPtr.Zero)
				id_subscribe_arrayLjava_lang_String_arrayIarrayLorg_eclipse_paho_client_mqttv3_IMqttMessageListener_ = JNIEnv.GetMethodID (class_ref, "subscribe", "([Ljava/lang/String;[I[Lorg/eclipse/paho/client/mqttv3/IMqttMessageListener;)Lorg/eclipse/paho/client/mqttv3/IMqttToken;");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			IntPtr native_p1 = JNIEnv.NewArray (p1);
			IntPtr native_p2 = JNIEnv.NewArray (p2);
			JValue* __args = stackalloc JValue [3];
			__args [0] = new JValue (native_p0);
			__args [1] = new JValue (native_p1);
			__args [2] = new JValue (native_p2);
			global::Org.Eclipse.Paho.Client.Mqttv3.IMqttToken __ret = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.IMqttToken> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_subscribe_arrayLjava_lang_String_arrayIarrayLorg_eclipse_paho_client_mqttv3_IMqttMessageListener_, __args), JniHandleOwnership.TransferLocalRef);
			if (p0 != null) {
				JNIEnv.CopyArray (native_p0, p0);
				JNIEnv.DeleteLocalRef (native_p0);
			}
			if (p1 != null) {
				JNIEnv.CopyArray (native_p1, p1);
				JNIEnv.DeleteLocalRef (native_p1);
			}
			if (p2 != null) {
				JNIEnv.CopyArray (native_p2, p2);
				JNIEnv.DeleteLocalRef (native_p2);
			}
			return __ret;
		}

		static Delegate cb_unsubscribe_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetUnsubscribe_Ljava_lang_String_Handler ()
		{
			if (cb_unsubscribe_Ljava_lang_String_ == null)
				cb_unsubscribe_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_Unsubscribe_Ljava_lang_String_);
			return cb_unsubscribe_Ljava_lang_String_;
		}

		static IntPtr n_Unsubscribe_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Org.Eclipse.Paho.Client.Mqttv3.IMqttAsyncClient __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.IMqttAsyncClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Unsubscribe (p0));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_unsubscribe_Ljava_lang_String_;
		public unsafe global::Org.Eclipse.Paho.Client.Mqttv3.IMqttToken Unsubscribe (string p0)
		{
			if (id_unsubscribe_Ljava_lang_String_ == IntPtr.Zero)
				id_unsubscribe_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "unsubscribe", "(Ljava/lang/String;)Lorg/eclipse/paho/client/mqttv3/IMqttToken;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_p0);
			global::Org.Eclipse.Paho.Client.Mqttv3.IMqttToken __ret = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.IMqttToken> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_unsubscribe_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static Delegate cb_unsubscribe_Ljava_lang_String_Ljava_lang_Object_Lorg_eclipse_paho_client_mqttv3_IMqttActionListener_;
#pragma warning disable 0169
		static Delegate GetUnsubscribe_Ljava_lang_String_Ljava_lang_Object_Lorg_eclipse_paho_client_mqttv3_IMqttActionListener_Handler ()
		{
			if (cb_unsubscribe_Ljava_lang_String_Ljava_lang_Object_Lorg_eclipse_paho_client_mqttv3_IMqttActionListener_ == null)
				cb_unsubscribe_Ljava_lang_String_Ljava_lang_Object_Lorg_eclipse_paho_client_mqttv3_IMqttActionListener_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_Unsubscribe_Ljava_lang_String_Ljava_lang_Object_Lorg_eclipse_paho_client_mqttv3_IMqttActionListener_);
			return cb_unsubscribe_Ljava_lang_String_Ljava_lang_Object_Lorg_eclipse_paho_client_mqttv3_IMqttActionListener_;
		}

		static IntPtr n_Unsubscribe_Ljava_lang_String_Ljava_lang_Object_Lorg_eclipse_paho_client_mqttv3_IMqttActionListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2)
		{
			global::Org.Eclipse.Paho.Client.Mqttv3.IMqttAsyncClient __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.IMqttAsyncClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object p1 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p1, JniHandleOwnership.DoNotTransfer);
			global::Org.Eclipse.Paho.Client.Mqttv3.IMqttActionListener p2 = (global::Org.Eclipse.Paho.Client.Mqttv3.IMqttActionListener)global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.IMqttActionListener> (native_p2, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Unsubscribe (p0, p1, p2));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_unsubscribe_Ljava_lang_String_Ljava_lang_Object_Lorg_eclipse_paho_client_mqttv3_IMqttActionListener_;
		public unsafe global::Org.Eclipse.Paho.Client.Mqttv3.IMqttToken Unsubscribe (string p0, global::Java.Lang.Object p1, global::Org.Eclipse.Paho.Client.Mqttv3.IMqttActionListener p2)
		{
			if (id_unsubscribe_Ljava_lang_String_Ljava_lang_Object_Lorg_eclipse_paho_client_mqttv3_IMqttActionListener_ == IntPtr.Zero)
				id_unsubscribe_Ljava_lang_String_Ljava_lang_Object_Lorg_eclipse_paho_client_mqttv3_IMqttActionListener_ = JNIEnv.GetMethodID (class_ref, "unsubscribe", "(Ljava/lang/String;Ljava/lang/Object;Lorg/eclipse/paho/client/mqttv3/IMqttActionListener;)Lorg/eclipse/paho/client/mqttv3/IMqttToken;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			JValue* __args = stackalloc JValue [3];
			__args [0] = new JValue (native_p0);
			__args [1] = new JValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
			__args [2] = new JValue ((p2 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p2).Handle);
			global::Org.Eclipse.Paho.Client.Mqttv3.IMqttToken __ret = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.IMqttToken> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_unsubscribe_Ljava_lang_String_Ljava_lang_Object_Lorg_eclipse_paho_client_mqttv3_IMqttActionListener_, __args), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static Delegate cb_unsubscribe_arrayLjava_lang_String_;
#pragma warning disable 0169
		static Delegate GetUnsubscribe_arrayLjava_lang_String_Handler ()
		{
			if (cb_unsubscribe_arrayLjava_lang_String_ == null)
				cb_unsubscribe_arrayLjava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_Unsubscribe_arrayLjava_lang_String_);
			return cb_unsubscribe_arrayLjava_lang_String_;
		}

		static IntPtr n_Unsubscribe_arrayLjava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Org.Eclipse.Paho.Client.Mqttv3.IMqttAsyncClient __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.IMqttAsyncClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string[] p0 = (string[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (string));
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Unsubscribe (p0));
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_unsubscribe_arrayLjava_lang_String_;
		public unsafe global::Org.Eclipse.Paho.Client.Mqttv3.IMqttToken Unsubscribe (string[] p0)
		{
			if (id_unsubscribe_arrayLjava_lang_String_ == IntPtr.Zero)
				id_unsubscribe_arrayLjava_lang_String_ = JNIEnv.GetMethodID (class_ref, "unsubscribe", "([Ljava/lang/String;)Lorg/eclipse/paho/client/mqttv3/IMqttToken;");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_p0);
			global::Org.Eclipse.Paho.Client.Mqttv3.IMqttToken __ret = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.IMqttToken> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_unsubscribe_arrayLjava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
			if (p0 != null) {
				JNIEnv.CopyArray (native_p0, p0);
				JNIEnv.DeleteLocalRef (native_p0);
			}
			return __ret;
		}

		static Delegate cb_unsubscribe_arrayLjava_lang_String_Ljava_lang_Object_Lorg_eclipse_paho_client_mqttv3_IMqttActionListener_;
#pragma warning disable 0169
		static Delegate GetUnsubscribe_arrayLjava_lang_String_Ljava_lang_Object_Lorg_eclipse_paho_client_mqttv3_IMqttActionListener_Handler ()
		{
			if (cb_unsubscribe_arrayLjava_lang_String_Ljava_lang_Object_Lorg_eclipse_paho_client_mqttv3_IMqttActionListener_ == null)
				cb_unsubscribe_arrayLjava_lang_String_Ljava_lang_Object_Lorg_eclipse_paho_client_mqttv3_IMqttActionListener_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_Unsubscribe_arrayLjava_lang_String_Ljava_lang_Object_Lorg_eclipse_paho_client_mqttv3_IMqttActionListener_);
			return cb_unsubscribe_arrayLjava_lang_String_Ljava_lang_Object_Lorg_eclipse_paho_client_mqttv3_IMqttActionListener_;
		}

		static IntPtr n_Unsubscribe_arrayLjava_lang_String_Ljava_lang_Object_Lorg_eclipse_paho_client_mqttv3_IMqttActionListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2)
		{
			global::Org.Eclipse.Paho.Client.Mqttv3.IMqttAsyncClient __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.IMqttAsyncClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string[] p0 = (string[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (string));
			global::Java.Lang.Object p1 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p1, JniHandleOwnership.DoNotTransfer);
			global::Org.Eclipse.Paho.Client.Mqttv3.IMqttActionListener p2 = (global::Org.Eclipse.Paho.Client.Mqttv3.IMqttActionListener)global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.IMqttActionListener> (native_p2, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Unsubscribe (p0, p1, p2));
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_unsubscribe_arrayLjava_lang_String_Ljava_lang_Object_Lorg_eclipse_paho_client_mqttv3_IMqttActionListener_;
		public unsafe global::Org.Eclipse.Paho.Client.Mqttv3.IMqttToken Unsubscribe (string[] p0, global::Java.Lang.Object p1, global::Org.Eclipse.Paho.Client.Mqttv3.IMqttActionListener p2)
		{
			if (id_unsubscribe_arrayLjava_lang_String_Ljava_lang_Object_Lorg_eclipse_paho_client_mqttv3_IMqttActionListener_ == IntPtr.Zero)
				id_unsubscribe_arrayLjava_lang_String_Ljava_lang_Object_Lorg_eclipse_paho_client_mqttv3_IMqttActionListener_ = JNIEnv.GetMethodID (class_ref, "unsubscribe", "([Ljava/lang/String;Ljava/lang/Object;Lorg/eclipse/paho/client/mqttv3/IMqttActionListener;)Lorg/eclipse/paho/client/mqttv3/IMqttToken;");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			JValue* __args = stackalloc JValue [3];
			__args [0] = new JValue (native_p0);
			__args [1] = new JValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
			__args [2] = new JValue ((p2 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p2).Handle);
			global::Org.Eclipse.Paho.Client.Mqttv3.IMqttToken __ret = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.IMqttToken> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_unsubscribe_arrayLjava_lang_String_Ljava_lang_Object_Lorg_eclipse_paho_client_mqttv3_IMqttActionListener_, __args), JniHandleOwnership.TransferLocalRef);
			if (p0 != null) {
				JNIEnv.CopyArray (native_p0, p0);
				JNIEnv.DeleteLocalRef (native_p0);
			}
			return __ret;
		}

	}

}
