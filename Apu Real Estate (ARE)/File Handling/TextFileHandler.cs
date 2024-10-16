using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Apu_Real_Estate__ARE_
{
    public class TextFileHandler
    {
        /// <summary>
        /// Writes the specified content to a text file.
        /// </summary>
        /// <param name="fileName">The path of the file to write to.</param>
        /// <param name="content">The content to write into the file.</param>
        public static void WriteToFile<T>(string fileName, List<T> content)
        {
            try
            {
                using (TextWriter writer = File.CreateText(fileName))
                {
                    foreach (T item in content)
                    {
                        writer.WriteLine(item); // Write each item on a new line
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while writing to the file: {ex.Message}");
            }
        }

        /// <summary>
        /// Reads a text file and converts its lines to a list of objects using the provided converter.
        /// </summary>
        /// <param name="fileName">The path of the file to read.</param>
        /// <returns>A list of objects of type T, or null if an error occurs.</returns>
        public static List<T> ReadFromFile<T>(string fileName)
        {
            var results = new List<T>();

            try
            {
                using (TextReader reader = File.OpenText(fileName))
                {
                    string line;
                    var targetType = typeof(T);
                    var converter = TypeDescriptor.GetConverter(targetType);
                  
                    while ((line = reader.ReadLine()) != null)
                    {
                        try
                        {
                            // Convert the line to type T using the provided converter function
                            T item = (T)converter.ConvertFromString(line);
                            results.Add(item);
                        }
                        catch (Exception ex)
                        {
                            // Handle conversion errors here, if necessary
                            MessageBox.Show($"Error converting line: {line}. Error: {ex.Message}");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while reading the file: {ex.Message}");
            }

            return results;
        }
    }
}
