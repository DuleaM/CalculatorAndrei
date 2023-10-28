namespace Calculator
{
    internal static class Program
    {

        private static Button button1 = new Button();

        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            Application.Run(new Form1());

        }


    }
}