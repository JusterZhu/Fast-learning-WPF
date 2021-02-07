using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using System.Windows.Data;

namespace Juster.Common
{
    public class ColorConvert : IValueConverter
    {
        /// <summary>
        /// 源属性传给目标属性时，调用此方法Convert
        /// </summary>
        /// <param name="value">数据源</param>
        /// <param name="targetType">目标类型</param>
        /// <param name="parameter">不常用</param>
        /// <param name="culture">不常用</param>
        /// <returns>目标值</returns>
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value == null) return null;

            //TODO：转换逻辑
            int index = System.Convert.ToInt32(value);
            if (index == 0)
                return "Blue";
            else if (index == 1)
                return "Green";
            else
                return "Red";
        }

        /// <summary>
        /// 目标属性传给源属性时，调用此方法ConvertBack
        /// </summary>
        /// <param name="value">目标值</param>
        /// <param name="targetType"></param>
        /// <param name="parameter"></param>
        /// <param name="culture"></param>
        /// <returns>数据源</returns>
        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return null;
        }
    }
}
