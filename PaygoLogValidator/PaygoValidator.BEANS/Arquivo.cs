﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using PaygoLogValidator.PaygoValidator.BO;

namespace PaygoLogValidator.PaygoValidator.BEANS
{
    public class Arquivo : ArquivoBO, IArquivoBO
    {
        private IArquivoBO iArquivo = new ArquivoBO();

        public string nome { get; set; }

        public string extensao { get; set; }

        public Passos passos { get; set; }

        public TipoValidacao tipoValidacao { get; set; }

        private string diretorio = @"C:\pgValidator";

        private string diretorioResult = @"C:\pgValidator\Result";

        public Arquivo()
        {

        }

        public Arquivo(string nome, string extensao, Passos passos)
        {
            this.nome = nome;
            this.extensao = extensao;
            this.passos = passos;
        }

        public string Diretorio
        {
            get { return diretorio; }
        }

        public string DiretorioResult
        {
            get { return diretorioResult; }
        }

        public void CriarPastaNoDiretorio(string diretorio)
        {
            if (!iArquivo.VerificaSeExistePastaNoDiretorio(Diretorio))
            {
                Directory.CreateDirectory(Diretorio);
                Directory.CreateDirectory(DiretorioResult);
                MessageBox.Show("Pastas criadas com sucesso!");
            }
        }        

        public List<string> LerArquivo(string nomeArquivo, string diretorio, OpenFileDialog objOpenFile, Arquivo arquivo)
        {
            List<string> arquivoRetorno = new List<string>();

            try
            {
                if (iArquivo.ValidaSeArquivoExisteNoDiretorio(nomeArquivo))
                {
                    using (Stream stm = objOpenFile.OpenFile())
                    using (StreamReader str = new StreamReader(stm))
                    {
                        var linha = str.ReadLine();

                        while (!string.IsNullOrEmpty(linha))
                        {
                            //Metodo que aponta o objeto Passos..
                            passos.RetornaIndiceDoPasso(linha, arquivo);

                            linha = str.ReadLine();
                        }
                    }

                    MessageBox.Show("Leitura finalizada!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(string.Format("Falha ao processar arquivo, verifique a mensagem: {0}", ex.Message));
            }

            return arquivoRetorno;
        }

        public string RetornaExtensaoDoArquivo(string nomeArquivo)
        {
            return iArquivo.RetornaExtensaoDoArquivo(nomeArquivo);
        }

        public string RetornaNomeDoArquivo(string nomeArquivo)
        {
            string rtnNmArquivo = string.Empty;
            string[] nmSplt = nomeArquivo.Split('\\');

            rtnNmArquivo = nmSplt[2];

            return rtnNmArquivo;
        }

        private void CriarArquivoDeRetorno(List<string> resultList, string diretorio, string nomeArquivo)
        {

        }
    }
}