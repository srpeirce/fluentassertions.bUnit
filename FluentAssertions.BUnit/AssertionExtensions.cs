using AngleSharp.Dom;
using Bunit;

namespace FluentAssertions.BUnit
{
    public static class AssertionExtensions
    {
        public static RenderedFragmentAssertions Should(this IRenderedFragment actualValue)
        {
            return new RenderedFragmentAssertions(actualValue);
        }
        
        public static ElementAssertions Should(this IElement actualValue)
        {
            return new ElementAssertions(actualValue);
        }
    }
}