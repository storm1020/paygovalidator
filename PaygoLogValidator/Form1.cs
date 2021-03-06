﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PaygoLogValidator.PaygoValidator.BEANS;
using PaygoLogValidator.PaygoValidator.BO.Interface;

namespace PaygoLogValidator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private Arquivo DefineTipoDeValidacao(Arquivo arquivo)
        {
            if (checkValidarDesconto.Checked && checkEcf.Checked)
            {
                TipoArquivo[] comDescontoEhEcf = { TipoArquivo.COM_DESCONTO, TipoArquivo.COM_ECF };
                arquivo.TipoArquivo = comDescontoEhEcf;
            }
            else if (checkEcf.Checked && !checkValidarDesconto.Checked)
            {
                TipoArquivo[] apenasEcf = { TipoArquivo.COM_ECF, TipoArquivo.SEM_DESCONTO };
                arquivo.TipoArquivo = apenasEcf;
            }
            else if (!checkEcf.Checked && checkValidarDesconto.Checked)
            {
                TipoArquivo[] apenasDesconto = { TipoArquivo.SEM_ECF, TipoArquivo.COM_DESCONTO };
                arquivo.TipoArquivo = apenasDesconto;
            }
            else
            {
                TipoArquivo[] semDescontoEhEcf = { TipoArquivo.SEM_DESCONTO, TipoArquivo.SEM_ECF };
                arquivo.TipoArquivo = semDescontoEhEcf;
            }

            return arquivo;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            Arquivo objArquivo = new Arquivo();
            Passos objPassos = new Passos();

            if (ckbCriarPasta.Checked)
            {
                objArquivo.CriarPastaNoDiretorio(objArquivo.Diretorio);
            }

            objArquivo = DefineTipoDeValidacao(objArquivo);

            if (openFile.ShowDialog() == DialogResult.OK)
            {
                string nomeArquivo = objArquivo.RetornaNomeDoArquivo(openFile.FileName);
                string extensaoArquivo = objArquivo.RetornaExtensaoDoArquivo(nomeArquivo);
                Dictionary<int, string> conteudoArquivo = objArquivo.RetornaConteudoArquivo(openFile.FileName, openFile, 0);
                //int indiceDaLinhaQueContemTeste = objArquivo.RetornaIndiceDaLinhaQueContemTeste(conteudoArquivo);

                //Sobrescreve o conteudoArquivo para pegar desde a linha que contém o passo.
                conteudoArquivo = objArquivo.RetornaConteudoArquivo(openFile.FileName, openFile, objArquivo.RetornaIndiceDaLinhaQueContemTeste(conteudoArquivo)/*indiceDaLinhaQueContemTeste*/);

                //int indicePasso = objPassos.GetIndiceDoPasso(conteudoArquivo);
                //bool opcional = objPassos.GetOpcionalidadeDoPasso(indicePasso, objArquivo.TipoArquivo);

                //List<string> ctdPasso = objPassos.GetConteudoPasso(conteudoArquivo);

                objArquivo.Nome = nomeArquivo;
                objArquivo.Extensao = extensaoArquivo;
                objArquivo.Passos = objPassos;
                objArquivo.ConteudoArquivo = conteudoArquivo;
                //objPassos.Indice = indicePasso;
                //objPassos.opcional = opcional;



            }
            else
            {
                MessageBox.Show("Por favor, selecione um arquivo de log.");
            }
        }
    }
}