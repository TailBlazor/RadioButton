using System;

namespace TailBlazor.RadioButton
{
    public enum RadioButtonOrientation
    {
        [Class("flex flex-col")]
        Vertical,
        [Class("flex flex-row")]
        Horizontal
    }

    public class ClassAttribute : Attribute
    {
        public string Value { get; set; }

        public ClassAttribute(string value)
        {
            this.Value = value;
        }
    }
}
