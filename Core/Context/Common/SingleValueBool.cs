namespace Core.Context.Common
{
    public readonly struct SingleValueBool
    {
        public SingleValueBool(Boolean value)
            => _ = (value) ? _value = true : this._value = null;

        private readonly Boolean? _value;

        public static implicit operator SingleValueBool(Boolean value)
            => new SingleValueBool(value);

        public static implicit operator Boolean(SingleValueBool value)
            => value._value is not null ? true : false;
    }
}
