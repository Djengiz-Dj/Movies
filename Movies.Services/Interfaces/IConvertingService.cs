using System;
using System.Collections.Generic;
using System.Text;

namespace Movies.Services.Interfaces
{
    public interface IConvertingService
    {
        string ConvertIntegerToString(int intValue);
        string ConvertAnyToString<T>(T type);
    }
}
