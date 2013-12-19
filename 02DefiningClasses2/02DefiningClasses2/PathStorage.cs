using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Euclidian3DSpace
{
    //4.
    public static class PathStorage
    {
        public static void Save(Path path)
        {
            StreamWriter streamWriter = new StreamWriter(@"..\..\PathStorage.txt");
            using (streamWriter)
            {
                foreach (var point in path.Sequence)
                {
                    streamWriter.WriteLine(point.ToString());
                }
            }
        }

        public static Path Load()
        {
            Path path = new Path();
            StreamReader reader = new StreamReader(@"..\..\PathStorage.txt");
            try
            {
                using (reader)
                {
                    int lineNumber = 0;
                    string line = reader.ReadLine();
                    while (line != null)
                    {
                        lineNumber++;
                        string[] splitArray = line.Split(' ');
                        path.Sequence.Add(new Point3D(int.Parse(splitArray[0]), int.Parse(splitArray[1]), int.Parse(splitArray[2])));
                        //path.Sequence[0].X = int.Parse(splitArray[0]);

                        line = reader.ReadLine();
                    }
                }
            }

            catch (FileNotFoundException)
            {
                Console.WriteLine("File not found");
            }
            catch (IOException io)
            {
                Console.WriteLine(io.Message);
            }
            catch (OutOfMemoryException ome)
            {
                Console.WriteLine(ome.Message);
            }

            return path;
        }
    }
}
