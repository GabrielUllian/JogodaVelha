using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JogodaVelha
{
    public partial class Form1 : Form
    {

        int jogadorx = 0, jogadoro = 0, empates = 0;
        bool turno = true;
        bool fimdejogo = false;

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            btnAct1.Text = "";
            btnAct2.Text = "";
            btnAct3.Text = "";
            btnAct4.Text = "";
            btnAct5.Text = "";
            btnAct6.Text = "";
            btnAct7.Text = "";
            btnAct8.Text = "";
            btnAct9.Text = "";
            fimdejogo = false;
            lblNumJogX.Text = jogadorx.ToString();
            lblNumJogO.Text = jogadoro.ToString();
            lblNumEmpates.Text = empates.ToString();
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void btnAct1_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            if (btn.Text == "" && fimdejogo == false)
            {
                if (turno)
                {
                    btn.Text = "X";
                    turno = !turno;
                }
                else
                {
                    btn.Text = "O";
                    turno = !turno;
                }


// =================================  Condições de Vitoria X  =================================
// ---------------------------------    VITORIA HORIZONTAL  -----------------------------------
                if (btnAct1.Text == "X" && btnAct2.Text == "X" && btnAct3.Text == "X" && fimdejogo == false)
                {
                    fimdejogo = true;
                    jogadorx++;
                    MessageBox.Show("Jogador X Venceu!");
                }
            if (btnAct4.Text == "X" && btnAct5.Text == "X" && btnAct6.Text == "X" && fimdejogo == false)
                {
                    fimdejogo = true;
                    jogadorx++;
                    MessageBox.Show("Jogador X Venceu!");
                }
            if (btnAct7.Text == "X" && btnAct8.Text == "X" && btnAct9.Text == "X" && fimdejogo == false)
                {
                    fimdejogo = true;
                    jogadorx++;
                    MessageBox.Show("Jogador X Venceu!");
                }
// ---------------------------------    VITORIA VERTICAL  -------------------------------------
            if (btnAct1.Text == "X" && btnAct4.Text == "X" && btnAct7.Text == "X" && fimdejogo == false)
                {
                    fimdejogo = true;
                    jogadorx++;
                    MessageBox.Show("Jogador X Venceu!");
                }
            if (btnAct2.Text == "X" && btnAct5.Text == "X" && btnAct8.Text == "X" && fimdejogo == false)
                {
                    fimdejogo = true;
                    jogadorx++;
                    MessageBox.Show("Jogador X Venceu!");
                }
            if (btnAct3.Text == "X" && btnAct6.Text == "X" && btnAct9.Text == "X" && fimdejogo == false)
                {
                    fimdejogo = true;
                    jogadorx++;
                    MessageBox.Show("Jogador X Venceu!");
                }
// ---------------------------------    VITORIA DIAGONAL  -------------------------------------
            if (btnAct1.Text == "X" && btnAct5.Text == "X" && btnAct9.Text == "X" && fimdejogo == false)
                {
                    fimdejogo = true;
                    jogadorx++;
                    MessageBox.Show("Jogador X Venceu!");
                }
            if (btnAct3.Text == "X" && btnAct5.Text == "X" && btnAct7.Text == "X" && fimdejogo == false)
                {
                    fimdejogo = true;
                    jogadorx++;
                    MessageBox.Show("Jogador X Venceu!");
                }
// =================================  Condições de Vitoria O  =================================
// ---------------------------------    VITORIA HORIZONTAL  -----------------------------------
            if (btnAct1.Text == "O" && btnAct2.Text == "O" && btnAct3.Text == "O" && fimdejogo == false)
                {
                    fimdejogo = true;
                    jogadoro++;
                    MessageBox.Show("Jogador O Venceu!");
                }
            if (btnAct4.Text == "O" && btnAct5.Text == "O" && btnAct6.Text == "O" && fimdejogo == false)
                {
                    fimdejogo = true;
                    jogadoro++;
                    MessageBox.Show("Jogador O Venceu!");
                }
            if (btnAct7.Text == "O" && btnAct8.Text == "O" && btnAct9.Text == "O" && fimdejogo == false)
                {
                    fimdejogo = true;
                    jogadoro++;
                    MessageBox.Show("Jogador O Venceu!");
                }
// ---------------------------------    VITORIA VERTICAL  -------------------------------------
            if (btnAct1.Text == "O" && btnAct4.Text == "O" && btnAct7.Text == "O" && fimdejogo == false)
                {
                    fimdejogo = true;
                    jogadoro++;
                    MessageBox.Show("Jogador O Venceu!");
                }
            if (btnAct2.Text == "O" && btnAct5.Text == "O" && btnAct8.Text == "O" && fimdejogo == false)
                {
                    fimdejogo = true;
                    jogadoro++;
                    MessageBox.Show("Jogador O Venceu!");
                }
            if (btnAct3.Text == "O" && btnAct6.Text == "O" && btnAct9.Text == "O" && fimdejogo == false)
                {
                    fimdejogo = true;
                    jogadoro++;
                    MessageBox.Show("Jogador O Venceu!");
                }
// --------------------------------- VITORIA DIAGONAL  -----------------------------------------
            if (btnAct1.Text == "O" && btnAct5.Text == "O" && btnAct9.Text == "O" && fimdejogo == false)
                {
                    fimdejogo = true;
                    jogadoro++;
                    MessageBox.Show("Jogador O Venceu!");
                }
            if (btnAct3.Text == "O" && btnAct5.Text == "O" && btnAct7.Text == "O" && fimdejogo == false)
                {
                    fimdejogo = true;
                    jogadoro++;
                    MessageBox.Show("Jogador O Venceu!");
                }
// ==================================== EMPATE ================================================
            if (btnAct1.Text != "" && btnAct2.Text != "" && btnAct3.Text != "" &&
                btnAct4.Text != "" && btnAct5.Text != "" && btnAct6.Text != "" &&
                btnAct7.Text != "" && btnAct8.Text != "" && btnAct9.Text != "" && fimdejogo == false)
                {
                    empates++;
                    fimdejogo = true;
                    MessageBox.Show("Empate");
                }
            }
        }
    }
}
