using System;
using Bunit;
using Microsoft.AspNetCore.Components;

namespace FluentAssertions.BUnit
{
    public static class RenderedFragmentExtensions
    {
        [Obsolete("Replacing with proper Fluent Assertions implementation")]
        public static IRenderedFragment ShouldHaveTag(this IRenderedFragment fragment, string expected)
        {
            var element = fragment.AsElement();
            element.LocalName.Should().Be(expected);
            return fragment;
        }

        [Obsolete("Replacing with proper Fluent Assertions implementation")]
        public static IRenderedFragment ShouldHaveChildMarkup(this IRenderedFragment fragment, string expected)
        {
            var element = fragment.AsElement();
            var child = element.FirstChild;
            child.Should().NotBeNull();    
            child!.MarkupMatches(expected);
            return fragment;
        }
        
        [Obsolete("Replacing with proper Fluent Assertions implementation")]
        public static IRenderedFragment ShouldHaveChildMarkup(this IRenderedFragment fragment, RenderFragment expected)
        {
            var element = fragment.AsElement();
            var child = element.FirstChild;
            child.Should().NotBeNull();    
            child!.MarkupMatches(expected);
            return fragment;
        }

        [Obsolete("Replacing with proper Fluent Assertions implementation")]
        public static IRenderedFragment ShouldHaveClass(this IRenderedFragment fragment, string expected)
        {
            var element = fragment.AsElement();
            element.ClassList.Should().Contain(expected);
            return fragment;
        }

        [Obsolete("Replacing with proper Fluent Assertions implementation")]
        public static IRenderedFragment ShouldNotHaveClass(this IRenderedFragment fragment, string expected)
        {
            var element = fragment.AsElement();
            element.ClassList.Should().NotContain(expected);
            return fragment;
        }

        [Obsolete("Replacing with proper Fluent Assertions implementation")]
        public static IRenderedFragment ShouldHaveId(this IRenderedFragment fragment, string expected) 
            => fragment.ShouldHaveAttribute("id", expected);
      
        [Obsolete("Replacing with proper Fluent Assertions implementation")]
        public static IRenderedFragment ShouldHaveTarget(this IRenderedFragment fragment, string expected) 
            => fragment.ShouldHaveAttribute("target", expected);

        [Obsolete("Replacing with proper Fluent Assertions implementation")]
        public static IRenderedFragment ShouldHaveRel(this IRenderedFragment fragment, string expected)
        {
            var element = fragment.AsElement();
            var attribute = element.Attributes["rel"];
            
            attribute.Should().NotBeNull();
            attribute!.Value.Split(" ").Should().Contain(expected);
            
            return fragment;
        }

        [Obsolete("Replacing with proper Fluent Assertions implementation")]
        public static IRenderedFragment ShouldHaveAriaLabel(this IRenderedFragment fragment, string expected)
            => fragment.ShouldHaveAttribute("aria-label", expected);

        [Obsolete("Replacing with proper Fluent Assertions implementation")]
        public static IRenderedFragment ShouldHaveHref(this IRenderedFragment fragment, string expected)
            => fragment.ShouldHaveAttribute("href", expected);

        [Obsolete("Replacing with proper Fluent Assertions implementation")]
        public static IRenderedFragment ShouldHaveSrc(this IRenderedFragment fragment, string expected)
            => fragment.ShouldHaveAttribute("src", expected);

        [Obsolete("Replacing with proper Fluent Assertions implementation")]
        public static IRenderedFragment ShouldHaveAlt(this IRenderedFragment fragment, string expected)
            => fragment.ShouldHaveAttribute("alt", expected);

        [Obsolete("Replacing with proper Fluent Assertions implementation")]
        public static IRenderedFragment ShouldHaveType(this IRenderedFragment fragment, string expected)
            => fragment.ShouldHaveAttribute("type", expected);

        [Obsolete("Replacing with proper Fluent Assertions implementation")]
        public static IRenderedFragment ShouldHaveTitle(this IRenderedFragment fragment, string expected)
            => fragment.ShouldHaveAttribute("title", expected);

        [Obsolete("Replacing with proper Fluent Assertions implementation")]
        public static IRenderedFragment ShouldHaveDataTestId(this IRenderedFragment fragment, string expected)
            => fragment.ShouldHaveAttribute("data-test-id", expected);

        [Obsolete("Replacing with proper Fluent Assertions implementation")]
        public static IRenderedFragment ShouldHaveDataTestClass(this IRenderedFragment fragment, string expected)
            => fragment.ShouldHaveAttribute("data-test-class", expected);

        [Obsolete("Replacing with proper Fluent Assertions implementation")]
        public static IRenderedFragment ShouldHaveAttribute(this IRenderedFragment fragment, string attributeName, string expected)
        {
            var element = fragment.AsElement();
            var attribute = element.Attributes[attributeName];

            attribute.Should().NotBeNull();
            attribute!.Value.Should().Be(expected);
            
            return fragment;
        }
    }
}