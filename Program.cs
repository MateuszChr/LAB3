namespace LAB03
{
    internal static class Program
    {
        
        [STAThread]
        static void Main()
        {
   
            ApplicationConfiguration.Initialize();
            Application.Run(new Kalkulator_procentowy_roztworu());
            
        }
    }
}