namespace Mostrador_de_Tabuada

{
    public partial class tabuadaForm : Form
    {
        public tabuadaForm()
        {
            InitializeComponent();
            TabuadaDesejadatextBox.KeyDown += TabuadaDesejadatextBox_KeyDown; // Associa o evento KeyDown ao TextBox
        }

        private void TabuadaDesejadatextBox_KeyDown(object? sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) // Verifica se a tecla Enter foi pressionada
            {
                EnviarButton.PerformClick(); // Aciona o EnviarButton_Click
                e.Handled = true;
                e.SuppressKeyPress = true;
            }

        }

        private void EnviarButton_Click(object sender, EventArgs e)
        {
            TabuadalistBox.Items.Clear();// Limpar a tabuada anterior
            int tabuada = Convert.ToInt32(TabuadaDesejadatextBox.Text); // Captura o TabuadaDesejadatextBox e converte em int
            for (int contador = 1; contador <= 10; contador++) // Looping para gerar a tabuada
            {
                string linha = string.Format("{0}*{1}= {2}", tabuada, contador, tabuada * contador); // Impressão da lista e efetuação do cálculo
                TabuadalistBox.Items.Add(linha); // Adição em TabuadalistBox
            }
        }
    }
}
