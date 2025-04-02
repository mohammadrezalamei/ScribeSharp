namespace ScribeSharp.Form
{
    internal static class Program
    {
        [System.STAThread]
        static void Main()
        {
            System.Windows.Forms.Application.EnableVisualStyles();
            System.Windows.Forms.Application.SetCompatibleTextRenderingDefault(false);
            ScribeSharp.Form.Forms.Main mainForm = 
                new();
            System.Windows.Forms.Application.Run(mainForm);
        }
    }
}
