using System;
using AngleSharp.Dom;
using Bunit;
using Microsoft.AspNetCore.Components;

namespace FluentAssertions.BUnit
{
    public static class ElementExtensions
    {
        [Obsolete("Replacing with proper Fluent Assertions implementation")]
        public static IElement ShouldHaveTag(this IElement element, string expected)
        {
            element.LocalName.Should().Be(expected);
            return element;
        }

        [Obsolete("Replacing with proper Fluent Assertions implementation")]
        public static IElement ShouldHaveChildMarkup(this IElement element, string expected)
        {
            var child = element.FirstChild;
            child.Should().NotBeNull();    
            child!.MarkupMatches(expected);
            return element;
        }
        
        [Obsolete("Replacing with proper Fluent Assertions implementation")]
        public static IElement ShouldHaveChildMarkup(this IElement element, RenderFragment expected)
        {
            var child = element.FirstChild;
            child.Should().NotBeNull();    
            child!.MarkupMatches(expected);
            return element;
        }

        [Obsolete("Replacing with proper Fluent Assertions implementation")]
        public static IElement ShouldHaveClass(this IElement element, string expected)
        {
            element.ClassList.Should().Contain(expected);
            return element;
        }

        [Obsolete("Replacing with proper Fluent Assertions implementation")]
        public static IElement ShouldNotHaveClass(this IElement element, string expected)
        {
            element.ClassList.Should().NotContain(expected);
            return element;
        }

        [Obsolete("Replacing with proper Fluent Assertions implementation")]
        public static IElement ShouldHaveId(this IElement element, string expected) 
            => element.ShouldHaveAttribute("id", expected);
        
        [Obsolete("Replacing with proper Fluent Assertions implementation")]
        public static IElement ShouldHaveTarget(this IElement element, string expected) 
            => element.ShouldHaveAttribute("target", expected);

        [Obsolete("Replacing with proper Fluent Assertions implementation")]
        public static IElement ShouldHaveRel(this IElement element, string expected)
        {
            var attribute = element.Attributes["rel"];
            
            attribute.Should().NotBeNull();
            attribute!.Value.Split(" ").Should().Contain(expected);
            
            return element;
        }

        [Obsolete("Replacing with proper Fluent Assertions implementation")]
        public static IElement ShouldHaveAriaLabel(this IElement element, string expected)
            => element.ShouldHaveAttribute("aria-label", expected);

        [Obsolete("Replacing with proper Fluent Assertions implementation")]
        public static IElement ShouldHaveHref(this IElement element, string expected)
            => element.ShouldHaveAttribute("href", expected);

        [Obsolete("Replacing with proper Fluent Assertions implementation")]
        public static IElement ShouldHaveSrc(this IElement element, string expected)
            => element.ShouldHaveAttribute("src", expected);

        [Obsolete("Replacing with proper Fluent Assertions implementation")]
        public static IElement ShouldHaveAlt(this IElement element, string expected)
            => element.ShouldHaveAttribute("alt", expected);

        [Obsolete("Replacing with proper Fluent Assertions implementation")]
        public static IElement ShouldHaveType(this IElement element, string expected)
            => element.ShouldHaveAttribute("type", expected);

        [Obsolete("Replacing with proper Fluent Assertions implementation")]
        public static IElement ShouldHaveTitle(this IElement element, string expected)
            => element.ShouldHaveAttribute("title", expected);

        [Obsolete("Replacing with proper Fluent Assertions implementation")]
        public static IElement ShouldHaveDataTestId(this IElement element, string expected)
            => element.ShouldHaveAttribute("data-test-id", expected);

        [Obsolete("Replacing with proper Fluent Assertions implementation")]
        public static IElement ShouldHaveDataTestClass(this IElement element, string expected)
            => element.ShouldHaveAttribute("data-test-class", expected);
    
        [Obsolete("Replacing with proper Fluent Assertions implementation")]
        public static IElement ShouldHaveAttribute(this IElement element, string attributeName, string expected)
        {
            var attribute = element.Attributes[attributeName];

            attribute.Should().NotBeNull();
            attribute!.Value.Should().Be(expected);
            
            return element;
        }
    }
}