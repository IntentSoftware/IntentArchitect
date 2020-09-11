﻿using System;
using Intent.Modules.Common.TypeScript.Weaving;
using Xunit;

namespace Intent.Modules.Common.TypeScript.Tests
{
    public class TypeScriptPropertyMergeTests
    {
        [Fact]
        public void AddsPropertyToEmptyClass()
        {
            var merger = new TypeScriptWeavingMerger();
            var result = merger.Merge(existingContent: EmptyMergedClass, outputContent: OneProperty);
            Assert.Equal(@"
@IntentMerge()
export class TestClass {

    propertyOne: string = 'one of one';
}", result);
        }

        [Fact]
        public void AddsNewProperty()
        {
            var merger = new TypeScriptWeavingMerger();
            var result = merger.Merge(existingContent: OneProperty, outputContent: TwoPropertiesMerged);
            Assert.Equal(TwoPropertiesMerged, result);
        }

        [Fact]
        public void AddsNewPropertyAndSkipsIgnored()
        {
            var merger = new TypeScriptWeavingMerger();
            var result = merger.Merge(existingContent: OneIgnoredProperty, outputContent: TwoProperties);
            Assert.Equal(@"
@IntentMerge()
export class TestClass {

    @IntentIgnore()
    propertyOne: string = 'some custom value';
    propertyTwo: string = 'two of two';

}", result);
        }

        [Fact]
        public void SkipsExistingPropertyWhenClassMerged()
        {
            var merger = new TypeScriptWeavingMerger();
            var result = merger.Merge(existingContent: TwoPropertiesMerged, outputContent: OneProperty);
            Assert.Equal(@"
@IntentMerge()
export class TestClass {

    propertyOne: string = 'one of one';
    propertyTwo: string = 'two of two';
}", result);
        }

        [Fact]
        public void RemovesPropertyWhenClassNotMerged()
        {
            var merger = new TypeScriptWeavingMerger();
            var result = merger.Merge(existingContent: ThreePropertiesWithOneIgnored, outputContent: TwoProperties);
            Assert.Equal(@"
export class TestClass {

    propertyOne: string = 'one of two';
    @IntentIgnore()
    propertyTwo: string = 'two of three (ignored)';
}", result);
        }

        [Fact]
        public void InsertPropertyAtCorrectPlace()
        {
            var merger = new TypeScriptWeavingMerger();
            var result = merger.Merge(existingContent: MergedClassWithTenProperties, outputContent: @"
export class TestClass {
    propertyFour: string = 'four of ten';

    // must insert after four
    insertPropertyOne: boolean;
    propertyTen: string = 'ten of ten';

    // must insert after ten
    insertPropertyTwo: boolean; 
}");
            Assert.Equal(@"
@IntentMerge()
export class TestClass {
    propertyOne: string = 'one of ten';
    propertyTwo: string = 'two of ten';
    propertyThree: string = 'three of ten';
    propertyFour: string = 'four of ten';

    // must insert after four
    insertPropertyOne: boolean;
    propertyFive: string = 'fie of ten';
    propertySix: string = 'six of ten';
    propertySeven: string = 'seven of ten';
    propertyEight: string = 'eight of ten';
    propertyNine: string = 'nine of ten';
    propertyTen: string = 'ten of ten';

    // must insert after ten
    insertPropertyTwo: boolean;
}", result);
        }

        public static string EmptyMergedClass = @"
@IntentMerge()
export class TestClass {
}";

        public static string OneProperty = @"
@IntentMerge()
export class TestClass {

    propertyOne: string = 'one of one';
}";

        public static string OneIgnoredProperty = @"
@IntentMerge()
export class TestClass {

    @IntentIgnore()
    propertyOne: string = 'some custom value';

}";

        public static string TwoProperties = @"
export class TestClass {

    propertyOne: string = 'one of two';
    propertyTwo: string = 'two of two';
}";

        public static string TwoPropertiesMerged = @"
@IntentMerge()
export class TestClass {

    propertyOne: string = 'one of two';
    propertyTwo: string = 'two of two';
}";

        public static string ThreePropertiesWithOneIgnored = @"
export class TestClass {

    propertyOne: string = 'one of three';
    @IntentIgnore()
    propertyTwo: string = 'two of three (ignored)';
    propertyThree: string = 'one of three';
}";

        public static string MergedClassWithTenProperties = @"
@IntentMerge()
export class TestClass {
    propertyOne: string = 'one of ten';
    propertyTwo: string = 'two of ten';
    propertyThree: string = 'three of ten';
    propertyFour: string = 'four of ten';
    propertyFive: string = 'fie of ten';
    propertySix: string = 'six of ten';
    propertySeven: string = 'seven of ten';
    propertyEight: string = 'eight of ten';
    propertyNine: string = 'nine of ten';
    propertyTen: string = 'ten of ten';
}";

    }
}