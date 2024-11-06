namespace MCQDAOnAbp.AdministrationService
{
    public static class AdministrationServiceProperties
    {
        public static string DbTablePrefix { get; set; } = string.Empty;
        public static string DbSchema { get; set; } = null;

        public const string ConnectionStringName = "AdministrationService";
    }
}
