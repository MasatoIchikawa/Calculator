﻿using Calculator.Utilities.Attributes;

namespace Calculator.Utilities.Methods
{
    public static class CustomMethod
    {
        public static string GetName<Enum>(this Enum value)
        {
            if (value == null)
            {
                return string.Empty;
            }

            var info = value.GetType().GetField(value.ToString()!);
            if (info == null) return string.Empty;
            var attr = Attribute.GetCustomAttribute(info, typeof(NameAttribute));
            if (attr == null) return string.Empty;

            return ((NameAttribute)attr).Name;
        }

        public static int GetDecimalPointLength(this string value)
        {
            var valueStr = value.ToString();
            var index = valueStr.IndexOf('.');
            return index != -1 ? valueStr.Substring(index + 1).Length : 0 ;
        }

        public static decimal TryDecimal<T>(this T value)
        {
            decimal num;
            if (decimal.TryParse(value?.ToString(), out num))
            {
                return num;
            }
            return 0;
        }

        public static int TryInt<T>(this T value)
        {
            int num;
            if (int.TryParse(value?.ToString(), out num))
            {
                return num;
            }
            return 0;
        }

        public static decimal ToRoundDown(this decimal value, int number)
        {
            var num = "1".PadRight(number + 1, '0').TryInt();
            return Math.Floor(value * num) / num;
        }
    }
}
