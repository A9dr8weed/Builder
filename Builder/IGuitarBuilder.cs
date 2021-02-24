namespace Builder
{
    /// <summary>
    /// Interface - 'Builder'.
    /// This is an interface which is used to define all the steps required to create a product.
    /// Interface which will be implemented by the ConcreteBuilder classes.
    /// </summary>
    public interface IGuitarBuilder
    {
        void SetType();
        void SetNumberOfStrings();
        void SetColor();
        void SetNumberOfFrets();
        Guitar GetGuitar();
    }
}