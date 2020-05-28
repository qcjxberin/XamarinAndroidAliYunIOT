using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Java.Interop;

namespace Com.Alibaba.Sdk.Android.Push.Securitybox.Alipush 
{
	public partial class AliPushSecurityBoxServiceFactoryProvider
	{
		public global::Java.Lang.Object FactoryInstance
		{
			get { return RawGetFactoryInstance() as Java.Lang.Object; }
		}
	}
}

namespace Com.Alibaba.Sdk.Android.Ams.Common.Spi 
{
	public partial interface IFactoryProvider
	{
		global::Java.Lang.Object FactoryInstance
		{
			// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.ams.common.spi']/interface[@name='FactoryProvider']/method[@name='getFactoryInstance' and count(parameter)=0]"
			[Register("getFactoryInstance", "()Ljava/lang/Object;", "GetGetFactoryInstanceHandler:Com.Alibaba.Sdk.Android.Ams.Common.Spi.IFactoryProviderInvoker, AlicloudAndroidPushIotBinding")]
			get;
		}
	}
	internal partial class IFactoryProviderInvoker 
	{
		static Delegate cb_getFactoryInstance;
#pragma warning disable 0169
		static Delegate GetGetFactoryInstanceHandler()
		{
			if (cb_getFactoryInstance == null)
				cb_getFactoryInstance = JNINativeWrapper.CreateDelegate((Func<IntPtr, IntPtr, IntPtr>)n_GetFactoryInstance);
			return cb_getFactoryInstance;
		}

		static IntPtr n_GetFactoryInstance(IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Alibaba.Sdk.Android.Ams.Common.Spi.IFactoryProvider __this = global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Ams.Common.Spi.IFactoryProvider>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(__this.FactoryInstance);
		}
#pragma warning restore 0169

		IntPtr id_getFactoryInstance;
		public unsafe global::Java.Lang.Object FactoryInstance
		{
			get
			{
				if (id_getFactoryInstance == IntPtr.Zero)
					id_getFactoryInstance = JNIEnv.GetMethodID(class_ref, "getFactoryInstance", "()Ljava/lang/Object;");
				return (Java.Lang.Object)global::Java.Lang.Object.GetObject<global::Java.Lang.Object>(JNIEnv.CallObjectMethod(((global::Java.Lang.Object)this).Handle, id_getFactoryInstance), JniHandleOwnership.TransferLocalRef);
			}
		}
	}
}

namespace Com.Alibaba.Sdk.Android.Push.Common.Util.Sendrequest 
{
	public abstract partial class SendRequestTask
	{
		// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.sdk.android.push.common.util.sendrequest']/class[@name='SendRequestTask']/method[@name='doInBackground' and count(parameter)=1 and parameter[1][@type='java.util.Map&lt;java.lang.String, java.lang.String&gt;...']]"
		[Register("doInBackground", "([Ljava/util/Map;)Lcom/alibaba/sdk/android/push/common/util/sendrequest/Response;", "GetDoInBackground_arrayLjava_util_Map_Handler")]
		protected virtual unsafe global::Com.Alibaba.Sdk.Android.Push.Common.Util.Sendrequest.Response DoInBackground(params global::System.Collections.Generic.IDictionary<string, string>[] p0)
		{
			const string __id = "doInBackground.([Ljava/util/Map;)Lcom/alibaba/sdk/android/push/common/util/sendrequest/Response;";
			IntPtr native_p0 = JNIEnv.NewArray(p0);
			try
			{
				JniArgumentValue* __args = stackalloc JniArgumentValue[1];
				__args[0] = new JniArgumentValue(native_p0);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod(__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Alibaba.Sdk.Android.Push.Common.Util.Sendrequest.Response>(__rm.Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				if (p0 != null)
				{
					JNIEnv.CopyArray(native_p0, p0);
					JNIEnv.DeleteLocalRef(native_p0);
				}
			}
		}
	}
}

namespace Anet.Channel.Bytes 
{
	public partial class ByteArray 
	{
		public int CompareTo(Java.Lang.Object o) 
		{
			return CompareTo(o as ByteArray);
		}
	}
}

namespace Anetwork.Channel.Aidl.Adapter
{
    public partial class ConnectionDelegate 
    {
        public override IDictionary ConnHeadFields 
		{
			get { return RawConnHeadFields as IDictionary; }
		}
        
		public unsafe global::System.Collections.Generic.IDictionary<string, global::System.Collections.Generic.IList<string>> RawConnHeadFields
		{
			// Metadata.xml XPath method reference: path="/api/package[@name='anetwork.channel.aidl.adapter']/class[@name='ConnectionDelegate']/method[@name='getConnHeadFields' and count(parameter)=0]"
			[Register("getConnHeadFields", "()Ljava/util/Map;", "GetGetConnHeadFieldsHandler")]
			get
			{
				const string __id = "getConnHeadFields.()Ljava/util/Map;";
				try
				{
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod(__id, this, null);
					return global::Android.Runtime.JavaDictionary<string, global::System.Collections.Generic.IList<string>>.FromJniHandle(__rm.Handle, JniHandleOwnership.TransferLocalRef);
				}
				finally
				{
				}
			}
		}
		
    }
}