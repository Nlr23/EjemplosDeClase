using Entidades;

namespace ClasePresencial
{
    public partial class Form1 : Form
    {
        public Guerrero guerrero;
        public Hacha hacha;
        public Espada espada;
        public Pistola pistola;
        public Arco arco;
        private string armaActual;
        public Pota pota;
        public Escudo escudo;
        public Cuchillo cuchillo;
        public Mapa mapa;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.guerrero = new Guerrero();
            this.hacha = new Hacha(2,15,100,"medio");
            this.espada = new Espada(3, 10, 90, "corto");
            this.pistola = new Pistola("9mm", 25, 100, "largo");
            this.arco = new Arco(20, 100, "largo", 100);
            this.pota = new Pota(10, "curacion");
            this.escudo = new Escudo("madera", "Escudon");
            this.mapa = new Mapa("Comun","Pepito Castle");
            this.cuchillo = new Cuchillo(100, "Daga");
        }

        private void btnEspada_Click(object sender, EventArgs e)
        {
            this.guerrero.CambiarArma(this.espada);
            this.armaActual = "Espada";
            this.lblArmaEquipada.Text = this.armaActual;
        }

        private void btnArco_Click(object sender, EventArgs e)
        {
            this.guerrero.CambiarArma(this.arco);
            this.armaActual = "Arco";
            this.lblArmaEquipada.Text = this.armaActual;
        }

        private void btnHacha_Click(object sender, EventArgs e)
        {
            this.guerrero.CambiarArma(this.hacha);
            this.armaActual = "Hacha";
            this.lblArmaEquipada.Text = this.armaActual;
        }

        private void btnPistola_Click(object sender, EventArgs e)
        {
            this.guerrero.CambiarArma(this.pistola);
            this.armaActual = "Pistola";
            this.lblArmaEquipada.Text = this.armaActual;
        }

        private void btnAtacar_Click(object sender, EventArgs e)
        {
            if(this.guerrero.armaActual is not null)
            {
                this.lblAccion.Text = this.guerrero.AtacarConArma();
            }
        }

        private void btnPota_Click(object sender, EventArgs e)
        {
            this.guerrero.CambiarItem(pota);
            this.lblItemActual.Text = "Pota";
        }

        private void btnEscudo_Click(object sender, EventArgs e)
        {
            this.guerrero.CambiarItem(escudo);
            this.lblItemActual.Text = "Escudo";
        }

        private void btnMapa_Click(object sender, EventArgs e)
        {
            this.guerrero.CambiarItem(mapa);
            this.lblItemActual.Text = "Mapa";
        }

        private void btnCuchillo_Click(object sender, EventArgs e)
        {
            this.guerrero.CambiarItem(cuchillo);
            this.lblItemActual.Text = "Cuchillo";
        }

        private void btnUsar_Click(object sender, EventArgs e)
        {
            if(this.guerrero.itemEquipado is not null)
            {
                this.lblUso.Text = this.guerrero.UsarItem();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.guerrero.CambiarArma(this.cuchillo);
            this.lblItemActual.Text = "Cuchillo";
        }

        private void btnHachaT_Click(object sender, EventArgs e)
        {
            this.guerrero.CambiarItem(hacha);
            this.lblItemActual.Text = "Hacha";
        }
    }
}