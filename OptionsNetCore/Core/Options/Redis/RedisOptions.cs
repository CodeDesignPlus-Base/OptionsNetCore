namespace OptionsNetCore.Core.Options.Redis
{
    /// <summary>
    /// Class that contains the options to configure Redis
    /// </summary>
    public class RedisOptions
    {
        /// <summary>
        /// Identificador de la sección en el archivo de configuración
        /// </summary>
        public const string Redis = "RedisSettings";

        public bool ResolveDns { get; set; }
        public string EndPoints { get; set; }
        public int ConnectRetry { get; set; }
        public int ConnectTimeout { get; set; }
        public int SyncTimeout { get; set; }
    }
}
