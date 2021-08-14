using AngleSharp.Dom;
using Bunit;

namespace FluentAssertions.BUnit
{
    public static class BUnitAssertions
    {
        public static IElement ShouldHaveTag(this IElement element, string expected)
        {
            element.LocalName.Should().Be(expected);
            return element;
        }

        public static IElement ShouldHaveChildMarkup(this IElement element, string expected)
        {
            element.FirstChild.MarkupMatches(expected);
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

        public static IElement ShouldHaveTarget(this IElement element, string expected)
        {
            element.Attributes["target"].Value.Should().Be(expected);
            return element;
        }

        public static IElement ShouldHaveRel(this IElement element, string expected)
        {
            element.Attributes["rel"].Value.Should().Be(expected);
            return element;
        }

        public static IElement ShouldHaveAriaLabel(this IElement element, string expected)
        {
            element.Attributes["aria-label"].Value.Should().Be(expected);
            return element;
        }

        public static IElement ShouldHaveHref(this IElement element, string expected)
        {
            element.Attributes["href"].Value.Should().Be(expected);
            return element;
        }

        public static IElement ShouldHaveSrc(this IElement element, string expected)
        {
            element.Attributes["src"].Value.Should().Be(expected);
            return element;
        }

        public static IElement ShouldHaveAlt(this IElement element, string expected)
        {
            element.Attributes["alt"].Value.Should().Be(expected);
            return element;
        }

        public static IElement ShouldHaveType(this IElement element, string expected)
        {
            element.Attributes["type"].Value.Should().Be(expected);
            return element;
        }

        public static IElement ShouldHaveTitle(this IElement element, string expected)
        {
            element.Attributes["title"].Value.Should().Be(expected);
            return element;
        }

        public static IElement ShouldHaveDataTestId(this IElement element, string expected)
        {
            element.Attributes["data-test-id"].Value.Should().Be(expected);
            return element;
        }

        public static IElement ShouldHaveDataTestClass(this IElement element, string expected)
        {
            element.Attributes["data-test-class"].Value.Should().Be(expected);
            return element;
        }
    }
}