using AngleSharp.Dom;
using Bunit;
using Microsoft.AspNetCore.Components;

namespace FluentAssertions.BUnit
{
    public static class ElementAssertions
    {
        public static IElement ShouldHaveTag(this IElement element, string expected)
        {
            element.LocalName.Should().Be(expected);
            return element;
        }

        public static IElement ShouldHaveChildMarkup(this IElement element, string expected)
        {
            var child = element.FirstChild;
            child.Should().NotBeNull();    
            child!.MarkupMatches(expected);
            return element;
        }
        
        public static IElement ShouldHaveChildMarkup(this IElement element, RenderFragment expected)
        {
            var child = element.FirstChild;
            child.Should().NotBeNull();    
            child!.MarkupMatches(expected);
            return element;
        }

        public static IElement ShouldHaveClass(this IElement element, string expected)
        {
            element.ClassList.Should().Contain(expected);
            return element;
        }

        public static IElement ShouldNotHaveClass(this IElement element, string expected)
        {
            element.ClassList.Should().NotContain(expected);
            return element;
        }

        public static IElement ShouldHaveId(this IElement element, string expected) 
            => element.ShouldHaveAttribute("id", expected);
        
        public static IElement ShouldHaveTarget(this IElement element, string expected) 
            => element.ShouldHaveAttribute("target", expected);

        public static IElement ShouldHaveRel(this IElement element, string expected)
        {
            var attribute = element.Attributes["rel"];
            
            attribute.Should().NotBeNull();
            attribute!.Value.Split(" ").Should().Contain(expected);
            
            return element;
        }

        public static IElement ShouldHaveAriaLabel(this IElement element, string expected)
            => element.ShouldHaveAttribute("aria-label", expected);

        public static IElement ShouldHaveHref(this IElement element, string expected)
            => element.ShouldHaveAttribute("href", expected);

        public static IElement ShouldHaveSrc(this IElement element, string expected)
            => element.ShouldHaveAttribute("src", expected);

        public static IElement ShouldHaveAlt(this IElement element, string expected)
            => element.ShouldHaveAttribute("alt", expected);

        public static IElement ShouldHaveType(this IElement element, string expected)
            => element.ShouldHaveAttribute("type", expected);

        public static IElement ShouldHaveTitle(this IElement element, string expected)
            => element.ShouldHaveAttribute("title", expected);

        public static IElement ShouldHaveDataTestId(this IElement element, string expected)
            => element.ShouldHaveAttribute("data-test-id", expected);

        public static IElement ShouldHaveDataTestClass(this IElement element, string expected)
            => element.ShouldHaveAttribute("data-test-class", expected);
        
        public static IElement ShouldHaveAttribute(this IElement element, string attributeName, string expected)
        {
            var attribute = element.Attributes[attributeName];

            attribute.Should().NotBeNull();
            attribute!.Value.Should().Be(expected);
            
            return element;
        }
    }
}