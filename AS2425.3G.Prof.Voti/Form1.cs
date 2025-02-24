namespace AS2425._3G.Prof.Voti
{
    public partial class Form1 : Form
    {
        private const int MAX_VOTI = 100;

        // struttura dati vettori paralleli
        double[] voti = new double[MAX_VOTI];
        double[] pesi = new double[MAX_VOTI];
        string[] materie = new string[MAX_VOTI];

        int numVoti = 0;
        public Form1()
        {
            InitializeComponent();
        }
    }
}
