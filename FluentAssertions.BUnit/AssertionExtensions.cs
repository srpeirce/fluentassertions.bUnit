using Bunit;
using FluentAssertions.Primitives;

namespace FluentAssertions.BUnit
{
    public static class AssertionExtensions
    {
        public static RenderedFragmentAssertions Should(this IRenderedFragment actualValue)
        {
            return new RenderedFragmentAssertions(actualValue);
        }
    }
}