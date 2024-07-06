using Calculator.Utilities.Attributes;

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
    }
}
