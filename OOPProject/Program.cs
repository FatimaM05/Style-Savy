namespace OOPProject
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
            ApplicationConfiguration.Initialize();
            Customer_Repository Customer = new Customer_Repository();
            Form1 form1 = new Form1(Customer);
            Application.Run(form1);

            Employee_Repository Employee = new Employee_Repository();
            Form2 form2 = new Form2(Employee);
            Application.Run(form2);
        }
    }
}