using Bunit;
using FluentAssertions.Primitives;

namespace FluentAssertions.BUnit
{
    /// <summary>
    /// Contains a number of methods to assert that a <see cref="IRenderedFragment"/> is in the expected state.
    /// </summary>
    public class RenderedFragmentAssertions : RenderedFragmentAssertions<RenderedFragmentAssertions>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RenderedFragmentAssertions"/> class.
        /// </summary>
        public RenderedFragmentAssertions(IRenderedFragment value)
            : base(value)
        {
        }
    }

    public class RenderedFragmentAssertions<TAssertions> : ReferenceTypeAssertions<IRenderedFragment, TAssertions> 
        where TAssertions : RenderedFragmentAssertions<TAssertions>
    {
        /// <summary>
        /// Returns the type of the subject the assertion applies on.
        /// </summary>
        protected override string Identifier => "IRenderedFragment";
        
        public RenderedFragmentAssertions(IRenderedFragment value)
            : base(value)
        {
        }
    }
}