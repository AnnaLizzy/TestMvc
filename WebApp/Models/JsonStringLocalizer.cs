﻿using Microsoft.Extensions.Localization;
using Newtonsoft.Json;

namespace WebApp.Models
{
    public class JsonStringLocalizer : IStringLocalizer
    {
        private readonly JsonSerializer _serializer ;
        public LocalizedString this[string name]
        {
            get
            {
                var value = GetString(name);
                return new LocalizedString(name, value);
            }
        }

        public LocalizedString this[string name, params object[] arguments]
        {

            get
            {
                var actualValue = this[name];
                return !actualValue.ResourceNotFound
                    ? new LocalizedString(name, string.Format(actualValue.Value, arguments)) : actualValue;
            }
        }

        private string GetString(string key)
        {
            //Resources/
            var filePath = $"Resources/{Thread.CurrentThread.CurrentCulture.Name}.json";
            var fullFilePath = Path.GetFullPath(filePath);

            if (File.Exists(fullFilePath))
            {
                var result = GetValueFromJson(key, fullFilePath);
                return result;
            }
            return string.Empty;
        }
        public IEnumerable<LocalizedString> GetAllStrings(bool includeParentCultures)
        {
            var filePath = $"Resources/{Thread.CurrentThread.CurrentCulture.Name}.json";

            using FileStream stream = new(filePath, FileMode.Open, FileAccess.Read, FileShare.Read);

            using StreamReader streamReader = new(stream);

            using JsonTextReader reader = new(streamReader);
            while (reader.Read())
            {
                if (reader.TokenType != JsonToken.PropertyName)
                    continue;

                var key = reader.Value as string;
                reader.Read();
                var value = _serializer.Deserialize<string>(reader);
                yield return new LocalizedString(key, value);
            }
        }
        private string GetValueFromJson(string propertyName, string filePath)
        {
            if (string.IsNullOrEmpty(propertyName) || string.IsNullOrEmpty(filePath))
                return string.Empty;

            using FileStream stream = new(filePath, FileMode.Open, FileAccess.Read, FileShare.Read);

            using StreamReader streamReader = new(stream);

            using JsonTextReader reader = new(streamReader);

            while (reader.Read())
            {
                if (reader.TokenType == JsonToken.PropertyName && reader.Value as string == propertyName)
                {
                    reader.Read();
                    return _serializer.Deserialize<string>(reader);
                }
            }
            return string.Empty;
        }
    }
}
