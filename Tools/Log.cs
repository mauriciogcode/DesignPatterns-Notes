namespace Tools
{
    //Sealed es para que no se pueda heredar.
    public sealed class Log
    {
        private static Log _instance = null;
        private string _path;



        // Metodo el unico metodo publico que te permite traerte el objeto
        public static Log GetInstance(string path)
        {
            if (_instance == null)
            {
                _instance = new Log(path);
            }

            return _instance;
        }

        //Constructor solo accesible desde esta clase.
        private Log(string path)
        {
            _path = path;
        }

        public void Save(string message)
        {
            if (_path is not null) File.AppendAllText(_path, message + Environment.NewLine);
        }
    }
}