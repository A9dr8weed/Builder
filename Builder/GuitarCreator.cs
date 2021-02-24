namespace Builder
{
    /// <summary>
    /// Class - 'Director'.
    /// This is a class that is used to construct an object using the Builder interface.
    /// </summary>
    public class GuitarCreator
    {
        /// <summary>
        /// Common interface.
        /// </summary>
        private readonly IGuitarBuilder _guitarBuilder;

        /// <summary>
        /// Designer to create a new concrete builder.
        /// </summary>
        /// <param name="guitarBuilder"> Concrete builder. </param>
        public GuitarCreator(IGuitarBuilder guitarBuilder)
        {
            _guitarBuilder = guitarBuilder;
        }

        /// <summary>
        /// Create a guitar with all methods.
        /// </summary>
        public void CreateGuitar()
        {
            _guitarBuilder.SetColor();
            _guitarBuilder.SetNumberOfFrets();
            _guitarBuilder.SetNumberOfStrings();
            _guitarBuilder.SetType();
        }

        /// <summary>
        /// Get guitar using method of concrete builder throw the interface.
        /// </summary>
        /// <returns> Concrete object. </returns>
        public Guitar GetGuitar() => _guitarBuilder.GetGuitar();
    }
}