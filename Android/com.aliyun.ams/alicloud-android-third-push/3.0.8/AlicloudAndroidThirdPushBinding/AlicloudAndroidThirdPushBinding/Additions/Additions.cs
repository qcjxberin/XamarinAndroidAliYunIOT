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
using Java.Interop;

namespace Com.Xiaomi.Mipush.Sdk
{
	public partial class PushMessageHandler
	{
        protected override bool A()
        {
			return InvokeAReturnBool();
        }

        static Delegate cb_a;
#pragma warning disable 0169
		static Delegate GetAHandler()
		{
			if (cb_a == null)
				cb_a = JNINativeWrapper.CreateDelegate((Func<IntPtr, IntPtr, bool>)n_A);
			return cb_a;
		}

		static bool n_A(IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Xiaomi.Mipush.Sdk.PushMessageHandler __this = global::Java.Lang.Object.GetObject<global::Com.Xiaomi.Mipush.Sdk.PushMessageHandler>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.A();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.xiaomi.mipush.sdk']/class[@name='PushMessageHandler']/method[@name='a' and count(parameter)=0]"
		[Register("a", "()Z", "GetAHandler")]
		protected unsafe bool InvokeAReturnBool()
		{
			const string __id = "a.()Z";
			try
			{
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod(__id, this, null);
				return __rm;
			}
			finally
			{
			}
		}
	}
}

namespace Com.Xiaomi.Push.Service
{
    public partial class XMPushService 
    {
		
		static Delegate cb_biga_I;
#pragma warning disable 0169
		static Delegate GetBigA_IHandler()
		{
			if (cb_biga_I == null)
				cb_biga_I = JNINativeWrapper.CreateDelegate((Action<IntPtr, IntPtr, int>)n_BigA_I);
			return cb_biga_I;
		}

		static void n_BigA_I(IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Xiaomi.Push.Service.XMPushService __this = global::Java.Lang.Object.GetObject<global::Com.Xiaomi.Push.Service.XMPushService>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.BigA(p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.xiaomi.push.service']/class[@name='XMPushService']/method[@name='a' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register("a", "(I)V", "GetBigA_IHandler")]
		public virtual unsafe void BigA(int p0)
		{
			const string __id = "a.(I)V";
			try
			{
				JniArgumentValue* __args = stackalloc JniArgumentValue[1];
				__args[0] = new JniArgumentValue(p0);
				_members.InstanceMethods.InvokeVirtualVoidMethod(__id, this, __args);
			}
			finally
			{
			}
		}

		
	}
}