namespace Builder
{
    /// <summary>
    /// Class - 'ConcreteBuilder'.
    /// This is a class which implements the Builder interface to create a complex product.
    /// </summary>
    public class AcousticGuitarBuilder : IGuitarBuilder
    {
        private readonly Guitar _guitar = new Guitar();

        /// <summary>
        /// Set the color of the guitar.
        /// </summary>
        public void SetColor() => _guitar.Add("Colour: White");

        /// <summary>
        /// Set the number of frets.
        /// </summary>
        public void SetNumberOfFrets() => _guitar.Add("Number of frets: 19");

        /// <summary>
        /// Set the number of strings.
        /// </summary>
        public void SetNumberOfStrings() => _guitar.Add("Number of strings: 12");

        /// <summary>
        /// Set guitar type.
        /// </summary>
        public void SetType() => _guitar.Add("Guitar type: Acoustic");

        /// <summary>
        /// Get acoustic guitar.
        /// </summary>
        /// <returns> Current guitar object. </returns>
        public Guitar GetGuitar() => _guitar;
    }
}