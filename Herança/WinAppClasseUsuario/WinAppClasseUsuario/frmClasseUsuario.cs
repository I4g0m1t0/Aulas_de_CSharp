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
            /*try
            {
                classeUsuario objUsuario = new classeUsuario();

                objUsuario.setNome(txbNome.Text);
                objUsuario.setMatricula(txbMatricula.Text);
                objUsuario.setEndereco(txbEndereco.Text);
                objUsuario.setDataNasc(dtpDataNasc.Value);
                //método de funcionalidade da classe usuario
                //só posso chamar depois de atribuir o valor da data de nasc
                objUsuario.calculaIdade();


                MessageBox.Show("Usuário Cadastrado com Sucesso!!!\nNome: " + objUsuario.getNome() +
                    "\nMatricula: " + objUsuario.getMatricula() + "\nEndereço: " +
                    objUsuario.getEndereco() + "\nData Nascimento: " +
                    objUsuario.getDataNasc().ToString() + "\nIdade: " +
                    objUsuario.getIdade().ToString(), "Confirmação Cadastro",
                    MessageBoxButtons.OK);






            }
            catch (FormatException)
            {
                MessageBox.Show("Erro de Conversão!!!", "ERRO", MessageBoxButtons.OK);
            }*/
        }

        private void btnCadastrarAluno_Click(object sender, EventArgs e)
        {
            try
            {
                classeAluno novoAluno = new classeAluno();

                novoAluno.setNome(txbNome.Text);
                novoAluno.setMatricula(txbMatricula.Text);
                novoAluno.setEndereco(txbEndereco.Text);
                novoAluno.setDataNasc(dtpDataNasc.Value);
                //método de funcionalidade da classe usuario
                //só posso chamar depois de atribuir o valor da data de nasc
                novoAluno.calculaIdade();
                novoAluno.setTurma(txbTurma.Text);
                novoAluno.setNota1(double.Parse(txbNota1.Text));
                novoAluno.setNota2(double.Parse(txbNota2.Text));
                novoAluno.calculaMedia();


                MessageBox.Show("Aluno Cadastrado com Sucesso!!!\nNome: " + 
                    novoAluno.getNome() +
                    "\nMatricula: " + novoAluno.getMatricula() + "\nEndereço: " +
                    novoAluno.getEndereco() + "\nData Nascimento: " +
                    novoAluno.getDataNasc().ToString() + "\nIdade: " +
                    novoAluno.getIdade().ToString()+
                    "\nTurma: "+novoAluno.getTurma()+
                    "\nNota 1 "+ novoAluno.getNota1().ToString()+
                    "\nNota 2 "+ novoAluno.getNota2().ToString()+
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

                novoProfessor.setNome(txbNome.Text);
                novoProfessor.setMatricula(txbMatricula.Text);
                novoProfessor.setEndereco(txbEndereco.Text);
                novoProfessor.setDataNasc(dtpDataNasc.Value);
                //método de funcionalidade da classe usuario
                //só posso chamar depois de atribuir o valor da data de nasc
                novoProfessor.calculaIdade();
                novoProfessor.setCargaHoraria(int.Parse(txbCargaHoraria.Text));
                novoProfessor.setTipo();

                MessageBox.Show("Professor Cadastrado com Sucesso!!!\nNome: " +
                    novoProfessor.getNome() +
                    "\nMatricula: " + novoProfessor.getMatricula() + "\nEndereço: " +
                    novoProfessor.getEndereco() + "\nData Nascimento: " +
                    novoProfessor.getDataNasc().ToString() + "\nIdade: " +
                    novoProfessor.getIdade().ToString() +
                    "\nCargaHoraria: " + novoProfessor.getCargaHoraria().ToString() +
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
