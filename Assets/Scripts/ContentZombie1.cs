
    using System;
    using System.Collections.Generic;

    using System.Globalization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

public class ContentZombie1
{
    //public partial class Content2
    //{
    //    [JsonProperty("0hhvkj1f-1")]
    //    public long The0Hhvkj1F1 { get; set; }

    //    [JsonProperty("vx4podi")]
    //    public string Vx4Podi { get; set; }

    //    [JsonProperty("34ht6trsd")]
    //    public long The34Ht6Trsd { get; set; }

    //    [JsonProperty("819j3h71")]
    //    public string The819J3H71 { get; set; }

    //    [JsonProperty("u-mev7qol")]
    //    public UMev7Qol UMev7Qol { get; set; }

    //    [JsonProperty("rcwmrg")]
    //    public Rcwmrg Rcwmrg { get; set; }

    //    [JsonProperty("l15ve")]
    //    public string L15Ve { get; set; }

    //    [JsonProperty("211e")]
    //    public string The211E { get; set; }
    //}

    //public enum Rcwmrg { Empty, The1180, The11810, The11830 };

    //public enum UMev7Qol { Online };

    //internal static class Converter
    //{
    //    public static readonly JsonSerializerSettings Settings = new JsonSerializerSettings
    //    {
    //        MetadataPropertyHandling = MetadataPropertyHandling.Ignore,
    //        DateParseHandling = DateParseHandling.None,
    //        Converters =
    //        {
    //            RcwmrgConverter.Singleton,
    //            UMev7QolConverter.Singleton,
    //            new IsoDateTimeConverter { DateTimeStyles = DateTimeStyles.AssumeUniversal }
    //        },
    //    };
    //}

    //internal class RcwmrgConverter : JsonConverter
    //{
    //    public override bool CanConvert(Type t) => t == typeof(Rcwmrg) || t == typeof(Rcwmrg?);

    //    public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
    //    {
    //        if (reader.TokenType == JsonToken.Null) return null;
    //        var value = serializer.Deserialize<string>(reader);
    //        switch (value)
    //        {
    //            case "-":
    //                return Rcwmrg.Empty;
    //            case "1.18.0":
    //                return Rcwmrg.The1180;
    //            case "1.18.10":
    //                return Rcwmrg.The11810;
    //            case "1.18.30":
    //                return Rcwmrg.The11830;
    //        }
    //        throw new Exception("Cannot unmarshal type Rcwmrg");
    //    }

    //    public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
    //    {
    //        if (untypedValue == null)
    //        {
    //            serializer.Serialize(writer, null);
    //            return;
    //        }
    //        var value = (Rcwmrg)untypedValue;
    //        switch (value)
    //        {
    //            case Rcwmrg.Empty:
    //                serializer.Serialize(writer, "-");
    //                return;
    //            case Rcwmrg.The1180:
    //                serializer.Serialize(writer, "1.18.0");
    //                return;
    //            case Rcwmrg.The11810:
    //                serializer.Serialize(writer, "1.18.10");
    //                return;
    //            case Rcwmrg.The11830:
    //                serializer.Serialize(writer, "1.18.30");
    //                return;
    //        }
    //        throw new Exception("Cannot marshal type Rcwmrg");
    //    }

    //    public static readonly RcwmrgConverter Singleton = new RcwmrgConverter();
    //}

    //internal class UMev7QolConverter : JsonConverter
    //{
    //    public override bool CanConvert(Type t) => t == typeof(UMev7Qol) || t == typeof(UMev7Qol?);

    //    public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
    //    {
    //        if (reader.TokenType == JsonToken.Null) return null;
    //        var value = serializer.Deserialize<string>(reader);
    //        if (value == "Online")
    //        {
    //            return UMev7Qol.Online;
    //        }
    //        throw new Exception("Cannot unmarshal type UMev7Qol");
    //    }

    //    public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
    //    {
    //        if (untypedValue == null)
    //        {
    //            serializer.Serialize(writer, null);
    //            return;
    //        }
    //        var value = (UMev7Qol)untypedValue;
    //        if (value == UMev7Qol.Online)
    //        {
    //            serializer.Serialize(writer, "Online");
    //            return;
    //        }
    //        throw new Exception("Cannot marshal type UMev7Qol");
    //    }

    //    public static readonly UMev7QolConverter Singleton = new UMev7QolConverter();
    //}

    //public partial class Content1
    //{
    //    [JsonProperty("ci94m")]
    //    public Ci94M Ci94M { get; set; }

    //    [JsonProperty("904403zr")]
    //    public The904403Zr The904403Zr { get; set; }

    //    [JsonProperty("b4n-luav-")]
    //    public B4NLuav B4NLuav { get; set; }


    //}

    //public partial class B4NLuav
    //{
    //    [JsonProperty("Konoha")]
    //    public Dictionary<string, Dictionary<string, string>> Konoha { get; set; }

    //    [JsonProperty("Naruto Mod")]
    //    public Dictionary<string, Dictionary<string, string>> NarutoMod { get; set; }
    //}

    //public partial class Ci94M
    //{
    //    [JsonProperty("Zombie")]
    //    public Dictionary<string, Dictionary<string, string>> Zombie { get; set; }
    //}



    //public partial class The904403Zr
    //{
    //    [JsonProperty("Maps")]
    //    public Dictionary<string, Dictionary<string, string>> Maps { get; set; }
    //}



    public partial class Content1
    {
        [JsonProperty("t70")]
        public T70 t70 { get; set; }

        [JsonProperty("7aunn6yn")]
        public The7aunn6yn The7aunn6yn { get; set; }

        [JsonProperty("9l-cqaa9")]
        public The9lcqaa9 The9lcqaa9 { get; set; }

        [JsonProperty("y2aki-t9tv")]
        public They2akit9tv They2akit9tv { get; set; }
    }

    public partial class T70
    {
        //[JsonProperty("Modern Mansions")]
        //public Dictionary<string, Dictionary<string, string>> ModernMansions { get; set; }

        //[JsonProperty("TNT")]
        //public Dictionary<string, Dictionary<string, string>> TNT { get; set; }

        //[JsonProperty("One Block")]
        //public Dictionary<string, Dictionary<string, string>> OneBlock { get; set; }

        //[JsonProperty("City")]
        //public Dictionary<string, Dictionary<string, string>> City { get; set; }


        //[JsonProperty("Lucky Block")]
        //public Dictionary<string, Dictionary<string, string>> LuckyBlock { get; set; }

        //[JsonProperty("Building")]
        //public Dictionary<string, Dictionary<string, string>> Building { get; set; }
        //[JsonProperty("Industrial Craft")]
        //public Dictionary<string, Dictionary<string, string>> IndustrialCraft { get; set; }

        //[JsonProperty("Furniture")]
        //public Dictionary<string, Dictionary<string, string>> Furniture { get; set; }
        //[JsonProperty("Cars")]
        //public Dictionary<string, Dictionary<string, string>> Cars { get; set; }

        //[JsonProperty("Houses")]
        //public Dictionary<string, Dictionary<string, string>> Houses { get; set; }
    }

    public partial class The7aunn6yn
    {
        [JsonProperty("Muscle")]
        public Dictionary<string, Dictionary<string, string>> Muscle { get; set; }

        [JsonProperty("Superheroes")]
        public Dictionary<string, Dictionary<string, string>> Superheroes { get; set; }

        [JsonProperty("Girls")]
        public Dictionary<string, Dictionary<string, string>> Girls { get; set; }

        [JsonProperty("Army")]
        public Dictionary<string, Dictionary<string, string>> Army { get; set; }

        [JsonProperty("Boys")]
        public Dictionary<string, Dictionary<string, string>> Boys { get; set; }

        [JsonProperty("Youtubers")]
        public Dictionary<string, Dictionary<string, string>> Youtubers { get; set; }

        [JsonProperty("Builder")]
        public Dictionary<string, Dictionary<string, string>> Builder { get; set; }
    }

    public partial class The9lcqaa9
{
        //[JsonProperty("Dragons")]
        //public Dictionary<string, Dictionary<string, string>> Dragons { get; set; }

        //[JsonProperty("Mommy")]
        //public Dictionary<string, Dictionary<string, string>> Mommy { get; set; }

        //[JsonProperty("Poppy")]
        //public Dictionary<string, Dictionary<string, string>> Poppy { get; set; }

        //[JsonProperty("Anime")]
        //public Dictionary<string, Dictionary<string, string>> Anime { get; set; }

        //[JsonProperty("Adventure")]
        //public Dictionary<string, Dictionary<string, string>> Adventure { get; set; }

        //[JsonProperty("Girl")]
        //public Dictionary<string, Dictionary<string, string>> Girl { get; set; }

        //[JsonProperty("Zombie")]
        //public Dictionary<string, Dictionary<string, string>> Zombie { get; set; }

        //[JsonProperty("Demon")]
        //public Dictionary<string, Dictionary<string, string>> Demon { get; set; }

        //[JsonProperty("Boy")]
        //public Dictionary<string, Dictionary<string, string>> Boy { get; set; }

        //[JsonProperty("Superheroes")]
        //public Dictionary<string, Dictionary<string, string>> Superheroes { get; set; }
    }


    public partial class They2akit9tv
{
        //[JsonProperty("Mobs")]
        //public Dictionary<string, Dictionary<string, string>> Mobs { get; set; }

        //[JsonProperty("Realistic")]
        //public Dictionary<string, Dictionary<string, string>> Realistic { get; set; }

        //[JsonProperty("Creation")]
        //public Dictionary<string, Dictionary<string, string>> Creation { get; set; }

        //[JsonProperty("Blocks")]
        //public Dictionary<string, Dictionary<string, string>> Blocks { get; set; }

        //[JsonProperty("Survival")]
        //public Dictionary<string, Dictionary<string, string>> Survival { get; set; }

        //[JsonProperty("Horror")]
        //public Dictionary<string, Dictionary<string, string>> Horror { get; set; }
    }
}
