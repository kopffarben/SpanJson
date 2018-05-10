﻿using System;
using System.Collections.Generic;
using SpanJson;
using SpanJson.Tests;
using Xunit;
// Autogenerated
// ReSharper disable BuiltInTypeReferenceStyle
namespace SpanJson.Tests.Generated
{
			
	public partial class NullableSByteListTests : NullableListTestBase<SByte>
	{
	}

	public partial class NullableSByteArrayTests : NullableArrayTestBase<SByte>
	{
	}
	public partial class SByteTests : StructTestBase<SByte>
	{
		[Theory]
        [InlineData(SByte.MinValue)]
        [InlineData(SByte.MaxValue)]
        public void SerializeDeserializeMinMaxUtf8(SByte input)
        {
            var serialized = JsonSerializer.Generic.Utf8.Serialize(input);
            var deserialized = JsonSerializer.Generic.Utf8.Deserialize<SByte>(serialized);
            Assert.Equal(input, deserialized);
        }


        [Theory]
        [InlineData(SByte.MinValue)]
        [InlineData(SByte.MaxValue)]
        public void SerializeDeserializeMinMaxUtf16(SByte input)
        {
            var serialized = JsonSerializer.Generic.Utf16.Serialize(input);
            var deserialized = JsonSerializer.Generic.Utf16.Deserialize<SByte>(serialized);
            Assert.Equal(input, deserialized);
        }
	}
	public partial class SByteListTests : ListTestBase<SByte>
	{
	}

	public partial class SByteArrayTests : ArrayTestBase<SByte>
	{
	}
			
	public partial class NullableInt16ListTests : NullableListTestBase<Int16>
	{
	}

	public partial class NullableInt16ArrayTests : NullableArrayTestBase<Int16>
	{
	}
	public partial class Int16Tests : StructTestBase<Int16>
	{
		[Theory]
        [InlineData(Int16.MinValue)]
        [InlineData(Int16.MaxValue)]
        public void SerializeDeserializeMinMaxUtf8(Int16 input)
        {
            var serialized = JsonSerializer.Generic.Utf8.Serialize(input);
            var deserialized = JsonSerializer.Generic.Utf8.Deserialize<Int16>(serialized);
            Assert.Equal(input, deserialized);
        }


        [Theory]
        [InlineData(Int16.MinValue)]
        [InlineData(Int16.MaxValue)]
        public void SerializeDeserializeMinMaxUtf16(Int16 input)
        {
            var serialized = JsonSerializer.Generic.Utf16.Serialize(input);
            var deserialized = JsonSerializer.Generic.Utf16.Deserialize<Int16>(serialized);
            Assert.Equal(input, deserialized);
        }
	}
	public partial class Int16ListTests : ListTestBase<Int16>
	{
	}

	public partial class Int16ArrayTests : ArrayTestBase<Int16>
	{
	}
			
	public partial class NullableInt32ListTests : NullableListTestBase<Int32>
	{
	}

	public partial class NullableInt32ArrayTests : NullableArrayTestBase<Int32>
	{
	}
	public partial class Int32Tests : StructTestBase<Int32>
	{
		[Theory]
        [InlineData(Int32.MinValue)]
        [InlineData(Int32.MaxValue)]
        public void SerializeDeserializeMinMaxUtf8(Int32 input)
        {
            var serialized = JsonSerializer.Generic.Utf8.Serialize(input);
            var deserialized = JsonSerializer.Generic.Utf8.Deserialize<Int32>(serialized);
            Assert.Equal(input, deserialized);
        }


        [Theory]
        [InlineData(Int32.MinValue)]
        [InlineData(Int32.MaxValue)]
        public void SerializeDeserializeMinMaxUtf16(Int32 input)
        {
            var serialized = JsonSerializer.Generic.Utf16.Serialize(input);
            var deserialized = JsonSerializer.Generic.Utf16.Deserialize<Int32>(serialized);
            Assert.Equal(input, deserialized);
        }
	}
	public partial class Int32ListTests : ListTestBase<Int32>
	{
	}

	public partial class Int32ArrayTests : ArrayTestBase<Int32>
	{
	}
			
	public partial class NullableInt64ListTests : NullableListTestBase<Int64>
	{
	}

	public partial class NullableInt64ArrayTests : NullableArrayTestBase<Int64>
	{
	}
	public partial class Int64Tests : StructTestBase<Int64>
	{
		[Theory]
        [InlineData(Int64.MinValue)]
        [InlineData(Int64.MaxValue)]
        public void SerializeDeserializeMinMaxUtf8(Int64 input)
        {
            var serialized = JsonSerializer.Generic.Utf8.Serialize(input);
            var deserialized = JsonSerializer.Generic.Utf8.Deserialize<Int64>(serialized);
            Assert.Equal(input, deserialized);
        }


        [Theory]
        [InlineData(Int64.MinValue)]
        [InlineData(Int64.MaxValue)]
        public void SerializeDeserializeMinMaxUtf16(Int64 input)
        {
            var serialized = JsonSerializer.Generic.Utf16.Serialize(input);
            var deserialized = JsonSerializer.Generic.Utf16.Deserialize<Int64>(serialized);
            Assert.Equal(input, deserialized);
        }
	}
	public partial class Int64ListTests : ListTestBase<Int64>
	{
	}

	public partial class Int64ArrayTests : ArrayTestBase<Int64>
	{
	}
			
	public partial class NullableByteListTests : NullableListTestBase<Byte>
	{
	}

	public partial class NullableByteArrayTests : NullableArrayTestBase<Byte>
	{
	}
	public partial class ByteTests : StructTestBase<Byte>
	{
		[Theory]
        [InlineData(Byte.MinValue)]
        [InlineData(Byte.MaxValue)]
        public void SerializeDeserializeMinMaxUtf8(Byte input)
        {
            var serialized = JsonSerializer.Generic.Utf8.Serialize(input);
            var deserialized = JsonSerializer.Generic.Utf8.Deserialize<Byte>(serialized);
            Assert.Equal(input, deserialized);
        }


        [Theory]
        [InlineData(Byte.MinValue)]
        [InlineData(Byte.MaxValue)]
        public void SerializeDeserializeMinMaxUtf16(Byte input)
        {
            var serialized = JsonSerializer.Generic.Utf16.Serialize(input);
            var deserialized = JsonSerializer.Generic.Utf16.Deserialize<Byte>(serialized);
            Assert.Equal(input, deserialized);
        }
	}
	public partial class ByteListTests : ListTestBase<Byte>
	{
	}

	public partial class ByteArrayTests : ArrayTestBase<Byte>
	{
	}
			
	public partial class NullableUInt16ListTests : NullableListTestBase<UInt16>
	{
	}

	public partial class NullableUInt16ArrayTests : NullableArrayTestBase<UInt16>
	{
	}
	public partial class UInt16Tests : StructTestBase<UInt16>
	{
		[Theory]
        [InlineData(UInt16.MinValue)]
        [InlineData(UInt16.MaxValue)]
        public void SerializeDeserializeMinMaxUtf8(UInt16 input)
        {
            var serialized = JsonSerializer.Generic.Utf8.Serialize(input);
            var deserialized = JsonSerializer.Generic.Utf8.Deserialize<UInt16>(serialized);
            Assert.Equal(input, deserialized);
        }


        [Theory]
        [InlineData(UInt16.MinValue)]
        [InlineData(UInt16.MaxValue)]
        public void SerializeDeserializeMinMaxUtf16(UInt16 input)
        {
            var serialized = JsonSerializer.Generic.Utf16.Serialize(input);
            var deserialized = JsonSerializer.Generic.Utf16.Deserialize<UInt16>(serialized);
            Assert.Equal(input, deserialized);
        }
	}
	public partial class UInt16ListTests : ListTestBase<UInt16>
	{
	}

	public partial class UInt16ArrayTests : ArrayTestBase<UInt16>
	{
	}
			
	public partial class NullableUInt32ListTests : NullableListTestBase<UInt32>
	{
	}

	public partial class NullableUInt32ArrayTests : NullableArrayTestBase<UInt32>
	{
	}
	public partial class UInt32Tests : StructTestBase<UInt32>
	{
		[Theory]
        [InlineData(UInt32.MinValue)]
        [InlineData(UInt32.MaxValue)]
        public void SerializeDeserializeMinMaxUtf8(UInt32 input)
        {
            var serialized = JsonSerializer.Generic.Utf8.Serialize(input);
            var deserialized = JsonSerializer.Generic.Utf8.Deserialize<UInt32>(serialized);
            Assert.Equal(input, deserialized);
        }


        [Theory]
        [InlineData(UInt32.MinValue)]
        [InlineData(UInt32.MaxValue)]
        public void SerializeDeserializeMinMaxUtf16(UInt32 input)
        {
            var serialized = JsonSerializer.Generic.Utf16.Serialize(input);
            var deserialized = JsonSerializer.Generic.Utf16.Deserialize<UInt32>(serialized);
            Assert.Equal(input, deserialized);
        }
	}
	public partial class UInt32ListTests : ListTestBase<UInt32>
	{
	}

	public partial class UInt32ArrayTests : ArrayTestBase<UInt32>
	{
	}
			
	public partial class NullableUInt64ListTests : NullableListTestBase<UInt64>
	{
	}

	public partial class NullableUInt64ArrayTests : NullableArrayTestBase<UInt64>
	{
	}
	public partial class UInt64Tests : StructTestBase<UInt64>
	{
		[Theory]
        [InlineData(UInt64.MinValue)]
        [InlineData(UInt64.MaxValue)]
        public void SerializeDeserializeMinMaxUtf8(UInt64 input)
        {
            var serialized = JsonSerializer.Generic.Utf8.Serialize(input);
            var deserialized = JsonSerializer.Generic.Utf8.Deserialize<UInt64>(serialized);
            Assert.Equal(input, deserialized);
        }


        [Theory]
        [InlineData(UInt64.MinValue)]
        [InlineData(UInt64.MaxValue)]
        public void SerializeDeserializeMinMaxUtf16(UInt64 input)
        {
            var serialized = JsonSerializer.Generic.Utf16.Serialize(input);
            var deserialized = JsonSerializer.Generic.Utf16.Deserialize<UInt64>(serialized);
            Assert.Equal(input, deserialized);
        }
	}
	public partial class UInt64ListTests : ListTestBase<UInt64>
	{
	}

	public partial class UInt64ArrayTests : ArrayTestBase<UInt64>
	{
	}
			
	public partial class NullableSingleListTests : NullableListTestBase<Single>
	{
	}

	public partial class NullableSingleArrayTests : NullableArrayTestBase<Single>
	{
	}
	public partial class SingleTests : StructTestBase<Single>
	{
	}
	public partial class SingleListTests : ListTestBase<Single>
	{
	}

	public partial class SingleArrayTests : ArrayTestBase<Single>
	{
	}
			
	public partial class NullableDoubleListTests : NullableListTestBase<Double>
	{
	}

	public partial class NullableDoubleArrayTests : NullableArrayTestBase<Double>
	{
	}
	public partial class DoubleTests : StructTestBase<Double>
	{
	}
	public partial class DoubleListTests : ListTestBase<Double>
	{
	}

	public partial class DoubleArrayTests : ArrayTestBase<Double>
	{
	}
			
	public partial class NullableDecimalListTests : NullableListTestBase<Decimal>
	{
	}

	public partial class NullableDecimalArrayTests : NullableArrayTestBase<Decimal>
	{
	}
	public partial class DecimalTests : StructTestBase<Decimal>
	{
	}
	public partial class DecimalListTests : ListTestBase<Decimal>
	{
	}

	public partial class DecimalArrayTests : ArrayTestBase<Decimal>
	{
	}
			
	public partial class NullableBooleanListTests : NullableListTestBase<Boolean>
	{
	}

	public partial class NullableBooleanArrayTests : NullableArrayTestBase<Boolean>
	{
	}
	public partial class BooleanTests : StructTestBase<Boolean>
	{
	}
	public partial class BooleanListTests : ListTestBase<Boolean>
	{
	}

	public partial class BooleanArrayTests : ArrayTestBase<Boolean>
	{
	}
			
	public partial class NullableCharListTests : NullableListTestBase<Char>
	{
	}

	public partial class NullableCharArrayTests : NullableArrayTestBase<Char>
	{
	}
	public partial class CharTests : StructTestBase<Char>
	{
		[Theory]
        [InlineData(Char.MinValue)]
        [InlineData(Char.MaxValue)]
        public void SerializeDeserializeMinMaxUtf8(Char input)
        {
            var serialized = JsonSerializer.Generic.Utf8.Serialize(input);
            var deserialized = JsonSerializer.Generic.Utf8.Deserialize<Char>(serialized);
            Assert.Equal(input, deserialized);
        }


        [Theory]
        [InlineData(Char.MinValue)]
        [InlineData(Char.MaxValue)]
        public void SerializeDeserializeMinMaxUtf16(Char input)
        {
            var serialized = JsonSerializer.Generic.Utf16.Serialize(input);
            var deserialized = JsonSerializer.Generic.Utf16.Deserialize<Char>(serialized);
            Assert.Equal(input, deserialized);
        }
	}
	public partial class CharListTests : ListTestBase<Char>
	{
	}

	public partial class CharArrayTests : ArrayTestBase<Char>
	{
	}
			
	public partial class NullableDateTimeListTests : NullableListTestBase<DateTime>
	{
	}

	public partial class NullableDateTimeArrayTests : NullableArrayTestBase<DateTime>
	{
	}
	public partial class DateTimeTests : StructTestBase<DateTime>
	{
	}
	public partial class DateTimeListTests : ListTestBase<DateTime>
	{
	}

	public partial class DateTimeArrayTests : ArrayTestBase<DateTime>
	{
	}
			
	public partial class NullableDateTimeOffsetListTests : NullableListTestBase<DateTimeOffset>
	{
	}

	public partial class NullableDateTimeOffsetArrayTests : NullableArrayTestBase<DateTimeOffset>
	{
	}
	public partial class DateTimeOffsetTests : StructTestBase<DateTimeOffset>
	{
	}
	public partial class DateTimeOffsetListTests : ListTestBase<DateTimeOffset>
	{
	}

	public partial class DateTimeOffsetArrayTests : ArrayTestBase<DateTimeOffset>
	{
	}
			
	public partial class NullableTimeSpanListTests : NullableListTestBase<TimeSpan>
	{
	}

	public partial class NullableTimeSpanArrayTests : NullableArrayTestBase<TimeSpan>
	{
	}
	public partial class TimeSpanTests : StructTestBase<TimeSpan>
	{
	}
	public partial class TimeSpanListTests : ListTestBase<TimeSpan>
	{
	}

	public partial class TimeSpanArrayTests : ArrayTestBase<TimeSpan>
	{
	}
			
	public partial class NullableGuidListTests : NullableListTestBase<Guid>
	{
	}

	public partial class NullableGuidArrayTests : NullableArrayTestBase<Guid>
	{
	}
	public partial class GuidTests : StructTestBase<Guid>
	{
	}
	public partial class GuidListTests : ListTestBase<Guid>
	{
	}

	public partial class GuidArrayTests : ArrayTestBase<Guid>
	{
	}
	public partial class StringTests : ClassTestBase<String>
	{
	}
	public partial class StringListTests : ListTestBase<String>
	{
	}

	public partial class StringArrayTests : ArrayTestBase<String>
	{
	}
	public partial class VersionTests : ClassTestBase<Version>
	{
	}
	public partial class VersionListTests : ListTestBase<Version>
	{
	}

	public partial class VersionArrayTests : ArrayTestBase<Version>
	{
	}
	public partial class UriTests : ClassTestBase<Uri>
	{
	}
	public partial class UriListTests : ListTestBase<Uri>
	{
	}

	public partial class UriArrayTests : ArrayTestBase<Uri>
	{
	}
}