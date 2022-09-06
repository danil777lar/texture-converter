
    using System;
    using System.Collections.Generic;

    using System.Globalization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    public class ServersContent
    {
        [JsonProperty("gl9g1n-")]
        public long Gl9G1N { get; set; }

        [JsonProperty("-46vz")]
        public string The46Vz { get; set; }

        [JsonProperty("2t8a")]
        public long The2T8A { get; set; }

        [JsonProperty("uy2lw_0q")]
        public string Uy2Lw0Q { get; set; }

        [JsonProperty("ur0apd44")]
        public Ur0Apd44 Ur0Apd44 { get; set; }

        [JsonProperty("5yqugus")]
        public The5Yqugus The5Yqugus { get; set; }

        [JsonProperty("rtvuodmm40")]
        public string Rtvuodmm40 { get; set; }

        [JsonProperty("cpz9f")]
        public string Cpz9F { get; set; }
    }

    public enum The5Yqugus { Empty, The116100, The11830 };

    public enum Ur0Apd44 { Online };

    internal static class Converter
    {
        public static readonly JsonSerializerSettings Settings = new JsonSerializerSettings
        {
            MetadataPropertyHandling = MetadataPropertyHandling.Ignore,
            DateParseHandling = DateParseHandling.None,
            Converters =
            {
                The5YqugusConverter.Singleton,
                Ur0Apd44Converter.Singleton,
                new IsoDateTimeConverter { DateTimeStyles = DateTimeStyles.AssumeUniversal }
            },
        };
    }

    internal class The5YqugusConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(The5Yqugus) || t == typeof(The5Yqugus?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            switch (value)
            {
                case "-":
                    return The5Yqugus.Empty;
                case "1.16.100":
                    return The5Yqugus.The116100;
                case "1.18.30":
                    return The5Yqugus.The11830;
            }
            throw new Exception("Cannot unmarshal type The5Yqugus");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (The5Yqugus)untypedValue;
            switch (value)
            {
                case The5Yqugus.Empty:
                    serializer.Serialize(writer, "-");
                    return;
                case The5Yqugus.The116100:
                    serializer.Serialize(writer, "1.16.100");
                    return;
                case The5Yqugus.The11830:
                    serializer.Serialize(writer, "1.18.30");
                    return;
            }
            throw new Exception("Cannot marshal type The5Yqugus");
        }

        public static readonly The5YqugusConverter Singleton = new The5YqugusConverter();
    }

    internal class Ur0Apd44Converter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(Ur0Apd44) || t == typeof(Ur0Apd44?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            if (value == "Online")
            {
                return Ur0Apd44.Online;
            }
            throw new Exception("Cannot unmarshal type Ur0Apd44");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (Ur0Apd44)untypedValue;
            if (value == Ur0Apd44.Online)
            {
                serializer.Serialize(writer, "Online");
                return;
            }
            throw new Exception("Cannot marshal type Ur0Apd44");
        }

        public static readonly Ur0Apd44Converter Singleton = new Ur0Apd44Converter();
    }
