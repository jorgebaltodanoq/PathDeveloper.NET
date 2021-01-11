using System.IO;

namespace Arrays
{
    class ReadFile
    {
        //ruta
        private string filePath;

        public ReadFile(string _filePath)
        {
            filePath = _filePath;
        }

        //
        public Country[] ReadCountryNFile(int nFile)
        {
            Country[] result = new Country[nFile]; 

            using (StreamReader sr = new StreamReader(filePath))
            {
                //leer cabecera
                sr.ReadLine();

                for (int i = 0; i < nFile; i++)
                {
                   string lineFile = sr.ReadLine();
                    result[i] = FormattedFileCountryatArray(lineFile);

                }
            }

            return result;

        }

        public Country FormattedFileCountryatArray(string lineFile)
        {
            string[] formatted = lineFile.Split(new char[]{ ','});

            //Obtenemos valores
            string name = formatted[0];
            string code = formatted[1];
            string continent = formatted[2];
            int population = int.Parse(formatted[3]);

            return new Country(name, code, continent, population);

        }

    }
}
