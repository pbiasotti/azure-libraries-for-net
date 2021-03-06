// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// </auto-generated>

namespace Microsoft.Azure.Management.CustomerInsights.Fluent.Models
{
    using Microsoft.Azure;
    using Microsoft.Azure.Management;
    using Microsoft.Azure.Management.CustomerInsights;
    using Microsoft.Azure.Management.CustomerInsights.Fluent;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using System.Runtime;
    using System.Runtime.Serialization;

    /// <summary>
    /// Defines values for FrequencyTypes.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum FrequencyTypes
    {
        [EnumMember(Value = "Minute")]
        Minute,
        [EnumMember(Value = "Hour")]
        Hour,
        [EnumMember(Value = "Day")]
        Day,
        [EnumMember(Value = "Week")]
        Week,
        [EnumMember(Value = "Month")]
        Month
    }
    internal static class FrequencyTypesEnumExtension
    {
        internal static string ToSerializedValue(this FrequencyTypes? value)
        {
            return value == null ? null : ((FrequencyTypes)value).ToSerializedValue();
        }

        internal static string ToSerializedValue(this FrequencyTypes value)
        {
            switch( value )
            {
                case FrequencyTypes.Minute:
                    return "Minute";
                case FrequencyTypes.Hour:
                    return "Hour";
                case FrequencyTypes.Day:
                    return "Day";
                case FrequencyTypes.Week:
                    return "Week";
                case FrequencyTypes.Month:
                    return "Month";
            }
            return null;
        }

        internal static FrequencyTypes? ParseFrequencyTypes(this string value)
        {
            switch( value )
            {
                case "Minute":
                    return FrequencyTypes.Minute;
                case "Hour":
                    return FrequencyTypes.Hour;
                case "Day":
                    return FrequencyTypes.Day;
                case "Week":
                    return FrequencyTypes.Week;
                case "Month":
                    return FrequencyTypes.Month;
            }
            return null;
        }
    }
}
