namespace Builder
{
    /// <summary>
    /// Class - 'ConcreteBuilder'.
    /// This is a class which implements the Builder interface to create a complex product.
    /// </summary>
    public class ElectricGuitarBuilder : IGuitarBuilder
    {
        private readonly Guitar _guitar = new Guitar();

        /// <summary>
        /// Set the color of the guitar.
        /// </summary>
        public void SetColor() => _guitar.Add("Black");

        /// <summary>
        /// Set the number of frets.
        /// </summary>
        public void SetNumberOfFrets() => _guitar.Add("24");

        /// <summary>
        /// Set the number of strings.
        /// </summary>
        public void SetNumberOfStrings() => _guitar.Add("6");

        /// <summary>
        /// Set guitar type.
        /// </summary>
        public void SetType() => _guitar.Add("Electric");

        /// <summary>
        /// Get electric guitar.
        /// </summary>
        /// <returns> Current guitar object. </returns>
        public Guitar GetGuitar() => _guitar;
    }
}