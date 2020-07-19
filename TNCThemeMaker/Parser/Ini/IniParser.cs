using System.Collections.Generic;
using System.IO;

namespace TNCThemeMaker.Parser.Ini
{
    abstract class IniParser<TValue>
    {
        public IDictionary<string, TValue> Load(string file)
        {
            if (!File.Exists(file))
                throw new FileNotFoundException(file);

            var fileStream = File.OpenRead(file);
            var result = Load(fileStream);
            fileStream.Close();

            return result;
        }

        public IDictionary<string, TValue> Load(Stream input)
        {
            var streamReader = new StreamReader(input);
            var result = new Dictionary<string, TValue>();

            string line;
            while ((line = streamReader.ReadLine()) != null)
            {
                if (string.IsNullOrEmpty(line) || line.StartsWith("//"))
                    continue;

                var valuePair = line.Split('=');
                var valueName = valuePair[0].Trim();
                var value = ParseValue(valueName, valuePair[1]);

                if (value != null)
                    result[valueName] = value;
            }

            return result;
        }

        protected abstract TValue ParseValue(string name, string value);
    }
}
