namespace TailBlazor.RadioButton
{
    /// <summary>
    /// A model that will hold details for the radio inputs, incase the user wants to use a list.
    /// </summary>
    /// <typeparam name="TValue">the type for the Value param</typeparam>
    public class RadioItem<TValue>
    {
        public string Id { get; set; }
        public string Text { get; set; }
        public TValue Value { get; set; }
    }
}
