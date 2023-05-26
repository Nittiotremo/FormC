﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormBD
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void pessoasToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void fornecedorToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void mnuCliente_Click(object sender, EventArgs e)
        {
            FrmCliente frm = new FrmCliente(); 
            frm.ShowDialog();
        }

        private void mnuFuncionarios_Click(object sender, EventArgs e)
        {
            FrmFuncionario frmFuncionario = new FrmFuncionario();
            frmFuncionario.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void mnuSexo_Click(object sender, EventArgs e)
        {
            frmSexo frmsexo = new frmSexo();
            frmsexo.ShowDialog();
        }

        private void mnuRua_Click(object sender, EventArgs e)
        {
            frmRua frmrua = new frmRua();
            frmrua.ShowDialog();
        }

        private void mnuBairro_Click(object sender, EventArgs e)
        {
            frmBairro frmbairro = new frmBairro();
            frmbairro.ShowDialog();
        }

        private void mnuCEP_Click(object sender, EventArgs e)
        {
            frmCEP frmcep = new frmCEP();
            frmcep.ShowDialog();
        }

        private void mnuCidade_Click(object sender, EventArgs e)
        {
            frmCidade frmcidade = new frmCidade();
            frmcidade.ShowDialog();
        }

        private void mnuTrabalho_Click(object sender, EventArgs e)
        {
            frmTrabalho frmtrabalho = new frmTrabalho();
            frmtrabalho.ShowDialog();
        }

        private void mnuTelefoneFuncionario_Click(object sender, EventArgs e)
        {
            frmTelefoneFuncionario frmTelefoneFuncionario = new frmTelefoneFuncionario();
            frmTelefoneFuncionario.ShowDialog();
        }

        private void mnuLogin_Click(object sender, EventArgs e)
        {
            frmLogin frmLogin = new frmLogin();
            frmLogin.ShowDialog();
        }

        private void mnuControleSistema_Click(object sender, EventArgs e)
        {
            frmControleSistema frmcontrolesistema = new frmControleSistema();
            frmcontrolesistema.ShowDialog();
        }

        private void mnuAcesso_Click(object sender, EventArgs e)
        {
            frmAcesso frmacesso = new frmAcesso();
            frmacesso.ShowDialog();
        }

        private void mnuAcessoLogin_Click(object sender, EventArgs e)
        {
            AcessoLogin acessologin = new AcessoLogin();
            acessologin.ShowDialog();
        }

        private void mnuLoja_Click(object sender, EventArgs e)
        {
            frmLoja frmloja = new frmLoja();
            frmloja.ShowDialog();
        }

        private void mnuTelefoneLoja_Click(object sender, EventArgs e)
        {
            TelefoneLoja frmtelefone = new TelefoneLoja();
            frmtelefone.ShowDialog();
        }
    }
}
