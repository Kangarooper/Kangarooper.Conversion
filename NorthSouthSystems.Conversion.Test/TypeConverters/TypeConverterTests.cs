﻿namespace NorthSouthSystems.Conversion;

using System.Globalization;

public abstract class TypeConverterTests<TTypeConverter>
    where TTypeConverter : ITypeConverter, new()
{
    private readonly TTypeConverter _typeConverter = new();

    protected ConvertTypeRequest Convert(object value, Type conversionType) =>
        Convert(value, conversionType, CultureInfo.CurrentCulture);

    protected ConvertTypeRequest Convert(object value, Type conversionType, IFormatProvider provider)
    {
        var request = new ConvertTypeRequest(value, conversionType, provider);
        _typeConverter.Convert(request);

        return request;
    }
}