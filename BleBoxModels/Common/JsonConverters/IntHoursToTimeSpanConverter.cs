﻿using System.Text.Json;
using System.Text.Json.Serialization;

namespace BleBoxModels.Common.JsonConverters;

public class IntHoursToTimeSpanConverter : JsonConverter<TimeSpan>
{
    public override TimeSpan Read(
        ref Utf8JsonReader reader,
        Type typeToConvert,
        JsonSerializerOptions options) =>
            TimeSpan.FromHours(reader.GetInt32());

    public override void Write(
        Utf8JsonWriter writer,
        TimeSpan value,
        JsonSerializerOptions options) =>
            writer.WriteNumberValue(value.TotalHours);
}
