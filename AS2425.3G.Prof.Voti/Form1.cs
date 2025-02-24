namespace AS2425._3G.Prof.Voti
{
    public partial class Form1 : Form
    {
        private const int MAX_VOTI = 100;

        // struttura dati vettori paralleli
        double[] voti = new double[MAX_VOTI];
        double[] pesi = new double[MAX_VOTI];
        string[] materie = new string[MAX_VOTI];

        int nVoti = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAggiungiVoto_Click(object sender, EventArgs e)
        {
            // salva le informazioni del voto
            voti[nVoti] = Convert.ToDouble(txtVoto.Text);
            pesi[nVoti] = Convert.ToDouble(txtPeso.Text);
            materie[nVoti] = txtMateria.Text;

            // incrementa il numero di voti
            nVoti++;
        }

        private void btnVisualizza_Click(object sender, EventArgs e)
        {
            switch (cmbVisualizzazioni.Text.ToUpper())
            {
                case "VISUALIZZA VOTI":
                    lstDettagli.Items.Clear();
                    for (int i = 0; i < nVoti; i++)
                    {
                        lstDettagli.Items.Add($"Voto: {voti[i]} Peso: {pesi[i]} Materia: {materie[i]}");
                    }
                    break;

                default:
                    MessageBox.Show("Scelta non valida");
                    break;
            }
        }
    }
}
