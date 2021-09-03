using AngleSharp.Dom;
using Bunit;
using Microsoft.AspNetCore.Components;

namespace FluentAssertions.BUnit
{
    public static class RenderedFragmentAssertions
    {
        public static IRenderedFragment ShouldHaveTag(this IRenderedFragment fragment, string expected)
        {
            var element = fragment.AsElement();
            element.LocalName.Should().Be(expected);
            return fragment;
        }

        public static IRenderedFragment ShouldHaveChildMarkup(this IRenderedFragment fragment, string expected)
        {
            var element = fragment.AsElement();
            var child = element.FirstChild;
            child.Should().NotBeNull();    
            child!.MarkupMatches(expected);
            return fragment;
        }
        
        public static IRenderedFragment ShouldHaveChildMarkup(this IRenderedFragment fragment, RenderFragment expected)
        {
            var element = fragment.AsElement();
            var child = element.FirstChild;
            child.Should().NotBeNull();    
            child!.MarkupMatches(expected);
            return fragment;
        }

        public static IRenderedFragment ShouldHaveClass(this IRenderedFragment fragment, string expected)
        {
            var element = fragment.AsElement();
            element.ClassList.Should().Contain(expected);
            return fragment;
        }

        public static IRenderedFragment ShouldNotHaveClass(this IRenderedFragment fragment, string expected)
        {
            var element = fragment.AsElement();
            element.ClassList.Should().NotContain(expected);
            return fragment;
        }

        public static IRenderedFragment ShouldHaveId(this IRenderedFragment fragment, string expected) 
            => fragment.ShouldHaveAttribute("id", expected);
        
        public static IRenderedFragment ShouldHaveTarget(this IRenderedFragment fragment, string expected) 
            => fragment.ShouldHaveAttribute("target", expected);

        public static IRenderedFragment ShouldHaveRel(this IRenderedFragment fragment, string expected)
        {
            var element = fragment.AsElement();
            var attribute = element.Attributes["rel"];
            
            attribute.Should().NotBeNull();
            attribute!.Value.Split(" ").Should().Contain(expected);
            
            return fragment;
        }

        public static IRenderedFragment ShouldHaveAriaLabel(this IRenderedFragment fragment, string expected)
            => fragment.ShouldHaveAttribute("aria-label", expected);

        public static IRenderedFragment ShouldHaveHref(this IRenderedFragment fragment, string expected)
            => fragment.ShouldHaveAttribute("href", expected);

        public static IRenderedFragment ShouldHaveSrc(this IRenderedFragment fragment, string expected)
            => fragment.ShouldHaveAttribute("src", expected);

        public static IRenderedFragment ShouldHaveAlt(this IRenderedFragment fragment, string expected)
            => fragment.ShouldHaveAttribute("alt", expected);

        public static IRenderedFragment ShouldHaveType(this IRenderedFragment fragment, string expected)
            => fragment.ShouldHaveAttribute("type", expected);

        public static IRenderedFragment ShouldHaveTitle(this IRenderedFragment fragment, string expected)
            => fragment.ShouldHaveAttribute("title", expected);

        public static IRenderedFragment ShouldHaveDataTestId(this IRenderedFragment fragment, string expected)
            => fragment.ShouldHaveAttribute("data-test-id", expected);

        public static IRenderedFragment ShouldHaveDataTestClass(this IRenderedFragment fragment, string expected)
            => fragment.ShouldHaveAttribute("data-test-class", expected);
        
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