namespace RealEstateAssignment
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.

            Estate estate;
            estate = new Apartment(new Address("5", "växjö", 12356, "sweden"), 1, 2, 2, new LegalForm());
            estate.Change(new Apartment(new Address("5", "växjö", 12356, "sweden"), 4, 2, 2, new LegalForm()));

            ApplicationConfiguration.Initialize();
            Application.Run(new Form1());

        }
    }
}