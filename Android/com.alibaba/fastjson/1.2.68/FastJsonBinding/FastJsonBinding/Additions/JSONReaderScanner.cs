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

namespace Com.Alibaba.Fastjson.Parser
{
    public sealed partial class JSONReaderScanner : global::Com.Alibaba.Fastjson.Parser.JSONLexerBase
    {
		// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.fastjson.parser']/class[@name='JSONReaderScanner']/method[@name='charArrayCompare' and count(parameter)=1 and parameter[1][@type='char[]']]"
		[Register("charArrayCompare", "([C)Z", "")]
		protected override sealed unsafe bool CharArrayCompare(char[] chars)
		{
			const string __id = "charArrayCompare.([C)Z";
			IntPtr native_chars = JNIEnv.NewArray(chars);
			try
			{
				JniArgumentValue* __args = stackalloc JniArgumentValue[1];
				__args[0] = new JniArgumentValue(native_chars);
				var __rm = _members.InstanceMethods.InvokeNonvirtualBooleanMethod(__id, this, __args);
				return __rm;
			}
			finally
			{
				if (chars != null)
				{
					JNIEnv.CopyArray(native_chars, chars);
					JNIEnv.DeleteLocalRef(native_chars);
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.alibaba.fastjson.parser']/class[@name='JSONReaderScanner']/method[@name='sub_chars' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
		[Register("sub_chars", "(II)[C", "")]
		protected override sealed unsafe char[] Sub_chars(int offset, int count)
		{
			const string __id = "sub_chars.(II)[C";
			try
			{
				JniArgumentValue* __args = stackalloc JniArgumentValue[2];
				__args[0] = new JniArgumentValue(offset);
				__args[1] = new JniArgumentValue(count);
				var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod(__id, this, __args);
				return (char[])JNIEnv.GetArray(__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof(char));
			}
			finally
			{
			}
		}

	}
}