using System;
using System.Linq;
using Bunit;
using FluentAssertions.Execution;
using FluentAssertions.Primitives;
using Microsoft.AspNetCore.Components;

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
        private readonly TestContext _testContext;

        /// <summary>
        /// Returns the type of the subject the assertion applies on.
        /// </summary>
        protected override string Identifier => "IRenderedFragment";
        
        public RenderedFragmentAssertions(IRenderedFragment value)
            : base(value)
        {
            _testContext = new TestContext();
        }
        
        public AndConstraint<TAssertions> HaveChildMarkup(RenderFragment expected, string because = "", params object[] becauseArgs)
        {
            var element = Subject.AsElement();
            var child = element.FirstChild;
            
            bool success = Execute.Assertion
                .BecauseOf(because, becauseArgs)
                .ForCondition(child is not null)
                .FailWith("Expected {context:IRenderedFragment} to have child {0}{reason}, but found <null>.", _testContext.Render(expected).Markup);

            if (success)
            {
                bool doesMarkupMatch;

                try
                {
                    child!.MarkupMatches(expected);
                    doesMarkupMatch = true;
                }
                catch
                {
                    doesMarkupMatch = false;
                }
                
                Execute.Assertion
                    .BecauseOf(because, becauseArgs)
                    .ForCondition(doesMarkupMatch)
                    .FailWith("Expected {context:IRenderedFragment} to have child {0}{reason}, but found {1}.", _testContext.Render(expected).Markup, child!.ToMarkup().TrimStart());
            }

            return new AndConstraint<TAssertions>((TAssertions)this);
        }

        public AndConstraint<TAssertions> HaveChildMarkup(string expected, string because = "", params object[] becauseArgs)
        {
            var element = Subject.AsElement();
            var child = element.FirstChild;
            
            bool success = Execute.Assertion
                .BecauseOf(because, becauseArgs)
                .ForCondition(child is not null)
                .FailWith("Expected {context:IRenderedFragment} to have child {0}{reason}, but found <null>.", expected);

            if (success)
            {
                bool doesMarkupMatch;

                try
                {
                    child!.MarkupMatches(expected);
                    doesMarkupMatch = true;
                }
                catch
                {
                    doesMarkupMatch = false;
                }
                
                Execute.Assertion
                    .BecauseOf(because, becauseArgs)
                    .ForCondition(doesMarkupMatch)
                    .FailWith("Expected {context:IRenderedFragment} to have child {0}{reason}, but found {1}.", expected, child!.ToMarkup().TrimStart());
            }

            return new AndConstraint<TAssertions>((TAssertions)this);
        }
        
        public AndConstraint<TAssertions> NotHaveClass(string expected, string because = "", params object[] becauseArgs)
        {
            var element = Subject.AsElement();
            element.ClassList.Should().NotContain(expected, because, becauseArgs);
            
            return new AndConstraint<TAssertions>((TAssertions)this);
        }
        
        public AndConstraint<TAssertions> HaveClass(string expected, string because = "", params object[] becauseArgs)
        {
            var element = Subject.AsElement();
            element.ClassList.Should().Contain(expected, because, becauseArgs);
            
            return new AndConstraint<TAssertions>((TAssertions)this);
        }
        
        public AndConstraint<TAssertions> HaveRel(string expected, string because = "", params object[] becauseArgs)
        {
            var element = Subject.AsElement();
            var attribute = element.Attributes["rel"];
            
            bool success = Execute.Assertion
                .BecauseOf(because, becauseArgs)
                .ForCondition(attribute is not null)
                .FailWith("Expected {context:IRenderedFragment} to have attribute {0}{reason}, but found <null>.", "rel");

            if (success)
            {
                var collection = attribute!.Value.Split(" ").ToList();
                Execute.Assertion
                    .BecauseOf(because, becauseArgs)
                    .ForCondition(attribute!.Value.Split(" ").Contains(expected))
                    .FailWith("Expected {context:IRenderedFragment} {0} [{1}] to contain {2}{reason}.", "rel", collection, expected);
            }

            return new AndConstraint<TAssertions>((TAssertions)this);
        }
        
        public AndConstraint<TAssertions> HaveTag(string expected, string because = "", params object[] becauseArgs)
        {
            var element = Subject.AsElement();
            var tag = element.LocalName;
            
            Execute.Assertion
                .BecauseOf(because, becauseArgs)
                .ForCondition(tag.Equals(expected, StringComparison.InvariantCulture))
                .FailWith("Expected {context:IRenderedFragment} {0} to be {1}{reason}, but found {2}.", "tag", expected, tag);
            
            return new AndConstraint<TAssertions>((TAssertions)this);
        }

        public AndConstraint<TAssertions> HaveAltText(string expected, string because = "", params object[] becauseArgs) 
            => HaveAttribute("alt", expected, because, becauseArgs);
        
        public AndConstraint<TAssertions> HaveAriaLabel(string expected, string because = "", params object[] becauseArgs) 
            => HaveAttribute("aria-label", expected, because, becauseArgs);
        
        public AndConstraint<TAssertions> HaveDataTestClass(string expected, string because = "", params object[] becauseArgs) 
            => HaveAttribute("data-test-class", expected, because, becauseArgs);
        
        public AndConstraint<TAssertions> HaveDataTestId(string expected, string because = "", params object[] becauseArgs) 
            => HaveAttribute("data-test-id", expected, because, becauseArgs);
        
        public AndConstraint<TAssertions> HaveHref(string expected, string because = "", params object[] becauseArgs) 
            => HaveAttribute("href", expected, because, becauseArgs);
        
        public AndConstraint<TAssertions> HaveId(string expected, string because = "", params object[] becauseArgs) 
            => HaveAttribute("id", expected, because, becauseArgs);
        
        public AndConstraint<TAssertions> HaveSrc(string expected, string because = "", params object[] becauseArgs) 
            => HaveAttribute("src", expected, because, becauseArgs);
        
        public AndConstraint<TAssertions> HaveTarget(string expected, string because = "", params object[] becauseArgs) 
            => HaveAttribute("target", expected, because, becauseArgs);
        
        public AndConstraint<TAssertions> HaveTitle(string expected, string because = "", params object[] becauseArgs) 
            => HaveAttribute("title", expected, because, becauseArgs);
        
        public AndConstraint<TAssertions> HaveType(string expected, string because = "", params object[] becauseArgs) 
            => HaveAttribute("type", expected, because, becauseArgs);
        
        public AndConstraint<TAssertions> HaveAttribute(string attributeName, string expectedValue, string because = "", params object[] becauseArgs)
        {
            var element = Subject.AsElement();
            var attribute = element.Attributes[attributeName];
            
            bool success = Execute.Assertion
                .BecauseOf(because, becauseArgs)
                .ForCondition(attribute is not null)
                .FailWith("Expected {context:IRenderedFragment} to have attribute {0}{reason}, but found <null>.", attributeName);
            
            if (success)
            {
                Execute.Assertion
                    .BecauseOf(because, becauseArgs)
                    .ForCondition(attribute!.Value == expectedValue)
                    .FailWith("Expected {context:IRenderedFragment} {0} attribute to have value {1}{reason}" +
                              ", but found {2}.", attributeName, expectedValue, attribute.Value);
            }

            return new AndConstraint<TAssertions>((TAssertions)this);
        }
    }
}