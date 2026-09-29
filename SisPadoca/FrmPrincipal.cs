namespace SisPadoca
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void sairDoSistemaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime Local = DateTime.Now;
            TssDataHora.Text = Local.ToString();
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmClientes CadClientes = new FrmClientes();
            CadClientes.ShowDialog();
        }

        private void produtosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Instanciação de objetos
            FrmProdutos CadProdutos = new FrmProdutos();
            CadProdutos.StartPosition = FormStartPosition.CenterScreen;
            // CadProdutos.WindowState = FormWindowState.Maximized;
            CadProdutos.ShowDialog();
        }

        private void blocoDeNotasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string site = "notepad.exe";

            while (site != "")
            {
                System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo
                {
                    FileName = site,
                    UseShellExecute = true
                });
                site = "";
            }
        }

        private void navegadorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string site = "https://www.google.com";

            while (site != "")
            {
                System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo
                {
                    FileName = site,
                    UseShellExecute = true
                });
                site = "";
            }
        }

        private void calculadoraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string site = "calc.exe";

            while (site != "")
            {
                System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo
                {
                    FileName = site,
                    UseShellExecute = true
                });
                site = "";
            }
        }
    }
}
