using Movies.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Movies.Services
{
    public class ConvertingService: IConvertingService
    {
        public string ConvertIntegerToString(int intValue)
        {
            string result = intValue.ToString();
            return result;
        }

        #region Helper Function

        public string ConvertAnyToString<T>(T type)
        {
            var result = type.ToString();
            return result;
        }

        private int ConvertStringToInt(string stringValue)
        {
            int result = int.Parse(stringValue);
            return result;
        }
        #endregion
    }
}
