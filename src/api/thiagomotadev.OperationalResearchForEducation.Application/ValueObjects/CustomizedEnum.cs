using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace thiagomotadev.OperationalResearchForEducation.Application.ValueObjects
{
    public abstract class CustomizedEnum : IComparable, IEquatable<CustomizedEnum>
    {
        public int Code { get; set; }

        public string Description { get; set; }

        public CustomizedEnum() { }

        protected CustomizedEnum(int code, string name) => (Code, Description) = (code, name);

        public override string ToString() => Description;

        public static IEnumerable<T> GetAll<T>() where T : CustomizedEnum =>
            typeof(T)
                .GetFields(BindingFlags.Public | BindingFlags.Static | BindingFlags.DeclaredOnly)
                .Select(f => f.GetValue(null))
                .Cast<T>();

        public int CompareTo(object other) => Code.CompareTo(((CustomizedEnum)other).Code);

        public bool Equals(CustomizedEnum other)
        {
            return this.Code == other.Code;
        }
    }
}