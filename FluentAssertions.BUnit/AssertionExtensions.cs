using AngleSharp.Dom;
using Bunit;

namespace FluentAssertions.BUnit;

public static class AssertionExtensions
{
    public static RenderedFragmentAssertions<TComponent> Should<TComponent>(this IRenderedComponent<TComponent> actualValue)
        where TComponent : Microsoft.AspNetCore.Components.IComponent
    {
        return new RenderedFragmentAssertions<TComponent>(actualValue);
    }
    
    public static ElementAssertions Should(this IElement actualValue)
    {
        return new ElementAssertions(actualValue);
    }
}