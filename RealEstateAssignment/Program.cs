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

            Apartment apartment = new Apartment(1, new Address("hammargattan", "växjö", 12345, Enums.countries.Sverige), 3, 4, 36, new LegalForm());



            ApplicationConfiguration.Initialize();
            Application.Run(new Form1());

        }
    }
}