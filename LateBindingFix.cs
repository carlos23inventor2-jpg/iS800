using System;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;
using System.Drawing;

namespace iS800
{
	internal static class LateBindingFix
	{
		private static BindingFlags Flags = BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Static | BindingFlags.IgnoreCase;

		public static object LateGet(object instance, object type, string memberName, object arguments, object argumentNames, object typeArguments, object copyBack)
		{
			try
			{
				object[] args = arguments as object[] ?? Array.Empty<object>();
				Type targetType = type as Type ?? instance?.GetType();
				object target = instance;
				if (target == null && targetType == null) return null;

				if (targetType != null)
				{
					var prop = targetType.GetProperty(memberName, Flags);
					if (prop != null && prop.GetIndexParameters().Length == (DialogResult)0)
					{
						return prop.GetValue(target, null);
					}
					var field = targetType.GetField(memberName, Flags);
					if (field != null) return field.GetValue(target);
					var method = targetType.GetMethods(Flags).FirstOrDefault(m => m.Name.Equals(memberName, StringComparison.OrdinalIgnoreCase) && m.GetParameters().Length == args.Length);
					if (method != null) return method.Invoke(instance, args);
				}

				if (target != null)
				{
					var t = target.GetType();
					var prop = t.GetProperty(memberName, Flags);
					if (prop != null && prop.GetIndexParameters().Length == (DialogResult)0)
					{
						return prop.GetValue(target, null);
					}
					var field = t.GetField(memberName, Flags);
					if (field != null) return field.GetValue(target);
					var method = t.GetMethods(Flags).FirstOrDefault(m => m.Name.Equals(memberName, StringComparison.OrdinalIgnoreCase) && m.GetParameters().Length == args.Length);
					if (method != null) return method.Invoke(target, args);
				}
			}
			catch { }
			return null;
		}

		public static void LateSet(object instance, object type, string memberName, object[] arguments, string[] argumentNames, Type[] typeArguments)
		{
			try
			{
				object value = arguments != null && arguments.Length > 0 ? arguments[0] : null;
				Type targetType = type as Type ?? instance?.GetType();
				object target = instance;
				if (target == null && targetType == null) return;

				if (targetType != null)
				{
					var prop = targetType.GetProperty(memberName, Flags);
					if (prop != null && prop.CanWrite && prop.GetIndexParameters().Length == (DialogResult)0)
					{
						prop.SetValue(target, ConvertIfNeeded(value, prop.PropertyType), null);
						return;
					}
					var field = targetType.GetField(memberName, Flags);
					if (field != null) { field.SetValue(target, ConvertIfNeeded(value, field.FieldType)); return; }
				}

				if (target != null)
				{
					var t = target.GetType();
					var prop = t.GetProperty(memberName, Flags);
					if (prop != null && prop.CanWrite && prop.GetIndexParameters().Length == (DialogResult)0)
					{
						prop.SetValue(target, ConvertIfNeeded(value, prop.PropertyType), null);
						return;
					}
					var field = t.GetField(memberName, Flags);
					if (field != null) { field.SetValue(target, ConvertIfNeeded(value, field.FieldType)); return; }
				}
			}
			catch { }
		}

		private static object ConvertIfNeeded(object value, Type targetType)
		{
			if (value == null) return null;
			if (targetType.IsAssignableFrom(value.GetType())) return value;
			try
			{
				if (targetType == typeof(string)) return Convert.ToString(value, CultureInfo.InvariantCulture);
				if (targetType == typeof(bool)) return Convert.ToBoolean(value, CultureInfo.InvariantCulture);
				if (targetType == typeof(int)) return Convert.ToInt32(value, CultureInfo.InvariantCulture);
				if (targetType == typeof(decimal)) return Convert.ToDecimal(value, CultureInfo.InvariantCulture);
				if (targetType == typeof(double)) return Convert.ToDouble(value, CultureInfo.InvariantCulture);
			}
			catch { }
			return value;
		}
	}
}
