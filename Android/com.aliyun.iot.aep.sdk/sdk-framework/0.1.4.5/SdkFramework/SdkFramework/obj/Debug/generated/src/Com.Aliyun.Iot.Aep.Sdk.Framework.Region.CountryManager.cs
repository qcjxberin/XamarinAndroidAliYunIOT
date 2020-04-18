using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Aliyun.Iot.Aep.Sdk.Framework.Region {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.aliyun.iot.aep.sdk.framework.region']/class[@name='CountryManager']"
	[global::Android.Runtime.Register ("com/aliyun/iot/aep/sdk/framework/region/CountryManager", DoNotGenerateAcw=true)]
	public partial class CountryManager : global::Java.Lang.Object {


		// Metadata.xml XPath field reference: path="/api/package[@name='com.aliyun.iot.aep.sdk.framework.region']/class[@name='CountryManager']/field[@name='COUNTRY_CHINA_ABBR']"
		[Register ("COUNTRY_CHINA_ABBR")]
		public const string CountryChinaAbbr = (string) "CN";
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/aliyun/iot/aep/sdk/framework/region/CountryManager", typeof (CountryManager));
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

		protected CountryManager (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.aliyun.iot.aep.sdk.framework.region']/class[@name='CountryManager']/constructor[@name='CountryManager' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe CountryManager ()
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

		public static unsafe global::System.Collections.Generic.IList<global::Com.Aliyun.Iot.Aep.Sdk.IoTSmart.Country> CountryListFromJsonFile {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.iot.aep.sdk.framework.region']/class[@name='CountryManager']/method[@name='getCountryListFromJsonFile' and count(parameter)=0]"
			[Register ("getCountryListFromJsonFile", "()Ljava/util/List;", "")]
			get {
				const string __id = "getCountryListFromJsonFile.()Ljava/util/List;";
				try {
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
					return global::Android.Runtime.JavaList<global::Com.Aliyun.Iot.Aep.Sdk.IoTSmart.Country>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		public static unsafe bool IsCountrySet {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.iot.aep.sdk.framework.region']/class[@name='CountryManager']/method[@name='isCountrySet' and count(parameter)=0]"
			[Register ("isCountrySet", "()Z", "")]
			get {
				const string __id = "isCountrySet.()Z";
				try {
					var __rm = _members.StaticMethods.InvokeBooleanMethod (__id, null);
					return __rm;
				} finally {
				}
			}
		}

		public static unsafe bool IsSetChina {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.iot.aep.sdk.framework.region']/class[@name='CountryManager']/method[@name='isSetChina' and count(parameter)=0]"
			[Register ("isSetChina", "()Z", "")]
			get {
				const string __id = "isSetChina.()Z";
				try {
					var __rm = _members.StaticMethods.InvokeBooleanMethod (__id, null);
					return __rm;
				} finally {
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.iot.aep.sdk.framework.region']/class[@name='CountryManager']/method[@name='clearCountryCache' and count(parameter)=0]"
		[Register ("clearCountryCache", "()V", "")]
		public static unsafe void ClearCountryCache ()
		{
			const string __id = "clearCountryCache.()V";
			try {
				_members.StaticMethods.InvokeVoidMethod (__id, null);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.iot.aep.sdk.framework.region']/class[@name='CountryManager']/method[@name='isChina' and count(parameter)=1 and parameter[1][@type='com.aliyun.iot.aep.sdk.IoTSmart.Country']]"
		[Register ("isChina", "(Lcom/aliyun/iot/aep/sdk/IoTSmart$Country;)Z", "")]
		public static unsafe bool IsChina (global::Com.Aliyun.Iot.Aep.Sdk.IoTSmart.Country country)
		{
			const string __id = "isChina.(Lcom/aliyun/iot/aep/sdk/IoTSmart$Country;)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((country == null) ? IntPtr.Zero : ((global::Java.Lang.Object) country).Handle);
				var __rm = _members.StaticMethods.InvokeBooleanMethod (__id, __args);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.iot.aep.sdk.framework.region']/class[@name='CountryManager']/method[@name='queryCountryList' and count(parameter)=1 and parameter[1][@type='com.aliyun.iot.aep.sdk.framework.base.ApiDataCallBack']]"
		[Register ("queryCountryList", "(Lcom/aliyun/iot/aep/sdk/framework/base/ApiDataCallBack;)V", "")]
		public static unsafe void QueryCountryList (global::Com.Aliyun.Iot.Aep.Sdk.Framework.Base.ApiDataCallBack callBack)
		{
			const string __id = "queryCountryList.(Lcom/aliyun/iot/aep/sdk/framework/base/ApiDataCallBack;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((callBack == null) ? IntPtr.Zero : ((global::Java.Lang.Object) callBack).Handle);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.iot.aep.sdk.framework.region']/class[@name='CountryManager']/method[@name='requestCountryListUrl' and count(parameter)=1 and parameter[1][@type='com.aliyun.iot.aep.sdk.framework.base.ApiDataCallBack']]"
		[Register ("requestCountryListUrl", "(Lcom/aliyun/iot/aep/sdk/framework/base/ApiDataCallBack;)V", "")]
		public static unsafe void RequestCountryListUrl (global::Com.Aliyun.Iot.Aep.Sdk.Framework.Base.ApiDataCallBack callBack)
		{
			const string __id = "requestCountryListUrl.(Lcom/aliyun/iot/aep/sdk/framework/base/ApiDataCallBack;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((callBack == null) ? IntPtr.Zero : ((global::Java.Lang.Object) callBack).Handle);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.aliyun.iot.aep.sdk.framework.region']/class[@name='CountryManager']/method[@name='updateCountry' and count(parameter)=0]"
		[Register ("updateCountry", "()V", "")]
		public static unsafe void UpdateCountry ()
		{
			const string __id = "updateCountry.()V";
			try {
				_members.StaticMethods.InvokeVoidMethod (__id, null);
			} finally {
			}
		}

	}
}
