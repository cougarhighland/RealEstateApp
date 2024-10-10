using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;

namespace Apu_Real_Estate__ARE_
{
    /// <summary>
    /// This class provides methods for reading and writing text files in JSON format.
    /// </summary>
    public class JSONFileHandler
    {
        /// <summary>
        /// Writes an object to a text file in JSON format.
        /// </summary>
        /// <typeparam name="T">The type of the object to write.</typeparam>
        /// <param name="fileName">The name of the text file.</param>
        /// <param name="obj">The object to write.</param>
        public static void WriteToFileAsJSON<T>(string fileName, T obj)
        {
            try
            {
                using (StreamWriter writer = new StreamWriter(fileName))
                {
                    var options = new JsonSerializerOptions
                    {
                        WriteIndented = true,
                        PropertyNameCaseInsensitive = true
                    };
                    string json = JsonSerializer.Serialize(obj, options);
                    writer.Write(json);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }
        }

        /// <summary>
        /// Reads a JSON object from a text file.
        /// </summary>
        /// <typeparam name="T">The type of the object to read.</typeparam>
        /// <param name="fileName">The name of the text file.</param>
        /// <returns>The deserialized object.</returns>
        public static T ReadJSONFile<T>(string fileName)
        {
            using (StreamReader reader = new StreamReader(fileName))
            {
                try
                {
                    var options = new JsonSerializerOptions
                    {
                        PropertyNameCaseInsensitive = true
                    };
                    string json = reader.ReadToEnd();
                    var result = JsonSerializer.Deserialize<T>(json, options);

                    // The null-coalescing operator returns the result if it's not null; otherwise, throw
                    if (result == null)
                    {
                        throw new JsonException("Deserialization resulted in null");
                    }

                    return result;
                }
                catch (FileNotFoundException ex)
                {
                    MessageBox.Show($"File not found: {ex.Message}");
                    throw; // Re-throw the exception or handle it
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An unexpected error occurred: {ex.Message}");
                    throw; // Re-throw or handle the exception
                }        
            }
        }      
    }
}

