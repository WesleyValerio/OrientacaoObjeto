﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WinAppClasseUsuario
{
    public partial class frmClasseUsuario : Form
    {
        public frmClasseUsuario()
        {
            InitializeComponent();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
           try
            {
                classeUsuario objUsuario = new classeUsuario();

                objUsuario.nome = txbNome.Text;
                objUsuario.matricula = txbMatricula.Text;
                objUsuario.endereco = txbEndereco.Text;
                objUsuario.dataNasc = dtpDataNasc.Value;
                //método de funcionalidade da classe usuario
                //só posso chamar depois de atribuir o valor da data de nasc
                objUsuario.calculaIdade();


                MessageBox.Show("Usuário Cadastrado com Sucesso!!!\nNome: " + objUsuario.nome +
                    "\nMatricula: " + objUsuario.matricula + "\nEndereço: " +
                    objUsuario.endereco + "\nData Nascimento: " +
                    objUsuario.dataNasc.ToString() + "\nIdade: " +
                    objUsuario.getIdade().ToString(), "Confirmação Cadastro",
                    MessageBoxButtons.OK);
            }
            catch (FormatException)
            {
                MessageBox.Show("Erro de Conversão!!!", "ERRO", MessageBoxButtons.OK);
            }
        }

        private void btnCadastrarAluno_Click(object sender, EventArgs e)
        {
            try
            {
                classeAluno novoAluno = new classeAluno();

                novoAluno.nome = txbNome.Text;
                novoAluno.matricula = txbMatricula.Text;
                novoAluno.endereco = txbEndereco.Text;
                novoAluno.dataNasc = dtpDataNasc.Value;
                //método de funcionalidade da classe usuario
                //só posso chamar depois de atribuir o valor da data de nasc
                novoAluno.calculaIdade();
                novoAluno.turma = txbTurma.Text;
                novoAluno.nota1 = double.Parse (txbNota1.Text);
                novoAluno.nota2 = double.Parse (txbNota2.Text);
                novoAluno.calculaMedia();


                MessageBox.Show("Aluno Cadastrado com Sucesso!!!\nNome: " + 
                    novoAluno.nome +
                    "\nMatricula: " + novoAluno.matricula + "\nEndereço: " +
                    novoAluno.endereco + "\nData Nascimento: " +
                    novoAluno.dataNasc.ToString() + "\nIdade: " +
                    novoAluno.getIdade().ToString()+
                    "\nTurma: "+novoAluno.turma+
                    "\nNota 1 "+ novoAluno.nota1.ToString()+
                    "\nNota 2 "+ novoAluno.nota2.ToString()+
                    "\nMédia: "+ novoAluno.retornaMedia().ToString()+
                    "\nO aluno está "+novoAluno.verificaAprovacao(), 
                    
                    "Confirmação Cadastro",
                    MessageBoxButtons.OK);

            }
            catch (FormatException)
            {
                MessageBox.Show("Erro de Conversão!!!", "ERRO",
                    MessageBoxButtons.OK);
            }
        }

        private void btnCadastrarProfessor_Click(object sender, EventArgs e)
        {
            try
            {
                classeProfessor novoProfessor = new classeProfessor();

                novoProfessor.nome = txbNome.Text;
                novoProfessor.matricula = txbMatricula.Text;
                novoProfessor.endereco = txbEndereco.Text;
                novoProfessor.dataNasc = dtpDataNasc.Value;
                //método de funcionalidade da classe usuario
                //só posso chamar depois de atribuir o valor da data de nasc
                novoProfessor.calculaIdade();
                novoProfessor.cargaHoraria = int.Parse(txbCargaHoraria.Text);
                novoProfessor.setTipo();

                MessageBox.Show("Professor Cadastrado com Sucesso!!!\nNome: " +
                    novoProfessor.nome +
                    "\nMatricula: " + novoProfessor.matricula + "\nEndereço: " +
                    novoProfessor.endereco + "\nData Nascimento: " +
                    novoProfessor.dataNasc.ToString() + "\nIdade: " +
                    novoProfessor.getIdade().ToString() +
                    "\nCargaHoraria: " + novoProfessor.cargaHoraria.ToString() +
                    "\nTipo Professor: " + novoProfessor.getTipo(),

                    "Confirmação Cadastro",
                    MessageBoxButtons.OK);

            }
            catch (FormatException)
            {
                MessageBox.Show("Erro de Conversão!!!", "ERRO",
                    MessageBoxButtons.OK);
            }
        }
    }
}
