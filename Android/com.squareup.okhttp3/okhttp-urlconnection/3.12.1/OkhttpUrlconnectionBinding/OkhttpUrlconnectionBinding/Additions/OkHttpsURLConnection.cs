using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Java.Net;

namespace Okhttp3.Internal.Huc
{
    public sealed partial class OkHttpsURLConnection : global::Javax.Net.Ssl.HttpsURLConnection
    {
		public unsafe global::System.Collections.IDictionary RawHeaderFields
		{
			// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3.internal.huc']/class[@name='OkHttpsURLConnection']/method[@name='getHeaderFields' and count(parameter)=0]"
			[Register("getHeaderFields", "()Ljava/util/Map;", "")]
			get
			{
				const string __id = "getHeaderFields.()Ljava/util/Map;";
				try
				{
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod(__id, this, null);
					return global::Android.Runtime.JavaDictionary.FromJniHandle(__rm.Handle, JniHandleOwnership.TransferLocalRef);
				}
				finally
				{
				}
			}
		}

		public override IDictionary<string, IList<string>> HeaderFields 
		{
			get 
			{
				return (IDictionary<string, IList<string>>)RawHeaderFields;
			}
		}

		public unsafe global::System.Collections.IDictionary RawRequestProperties
		{
			// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3.internal.huc']/class[@name='OkHttpsURLConnection']/method[@name='getRequestProperties' and count(parameter)=0]"
			[Register("getRequestProperties", "()Ljava/util/Map;", "")]
			get
			{
				const string __id = "getRequestProperties.()Ljava/util/Map;";
				try
				{
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod(__id, this, null);
					return global::Android.Runtime.JavaDictionary.FromJniHandle(__rm.Handle, JniHandleOwnership.TransferLocalRef);
				}
				finally
				{
				}
			}
		}

		public override IDictionary<string, IList<string>> RequestProperties 
		{
			get 
			{
				return (IDictionary<string, IList<string>>)RawRequestProperties;
			}
		}
		
		public unsafe int RawResponseCode
		{
			// Metadata.xml XPath method reference: path="/api/package[@name='okhttp3.internal.huc']/class[@name='OkHttpsURLConnection']/method[@name='getResponseCode' and count(parameter)=0]"
			[Register("getResponseCode", "()I", "")]
			get
			{
				const string __id = "getResponseCode.()I";
				try
				{
					var __rm = _members.InstanceMethods.InvokeAbstractInt32Method(__id, this, null);
					return __rm;
				}
				finally
				{
				}
			}
		}

		public override HttpStatus ResponseCode 
		{
			get 
			{
				return (HttpStatus)RawResponseCode;
			}
		}
	}
}