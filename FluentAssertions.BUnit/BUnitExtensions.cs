using System.Collections.Generic;
using AngleSharp.Dom;
using Bunit;

namespace FluentAssertions.BUnit;

public static class BUnitExtensions
{
    public static IElement FindByDataTestId<TComponent>(this IRenderedComponent<TComponent> component, string dataTestId)
        where TComponent : Microsoft.AspNetCore.Components.IComponent
        => component.Find($"[data-test-id='{dataTestId}']");
    
    public static IElement FindByDataTestClass<TComponent>(this IRenderedComponent<TComponent> component, string dataTestClass)
        where TComponent : Microsoft.AspNetCore.Components.IComponent
        => component.Find($"[data-test-class='{dataTestClass}']");

    public static IReadOnlyList<IElement> FindAllByDataTestClass<TComponent>(this IRenderedComponent<TComponent> component,
        string dataTestClass)
        where TComponent : Microsoft.AspNetCore.Components.IComponent
        => component.FindAll($"[data-test-class='{dataTestClass}']");

    public static IElement AsElement<TComponent>(this IRenderedComponent<TComponent> component)
        where TComponent : Microsoft.AspNetCore.Components.IComponent
        => component.Nodes.QuerySelector("*");
}