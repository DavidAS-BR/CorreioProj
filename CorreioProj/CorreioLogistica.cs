using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace CorreioProj
{
    public partial class CorreioLogistica : Form
    {
        public CorreioLogistica()
        {
            InitializeComponent();
        }

        private List<Caixa> armazemCaixas = new List<Caixa>(); // Lista com as caixas
        private List<string> addedBoxes = new List<string>(); // Lista onde será salvo a index das caixas adicionadas
        //private Moto motoEntrega = new Moto(caixaTamanhoComboBox.SelectedItem)
        
        private void updateCaixasButton_Click(object sender, EventArgs e)
        {

            for (int i = 0; i < armazemCaixas.Count; i++)
            {
                // Tempo de viagem deverá ser decidido futuramente com base na realidade
                // da distância entre o CEP do armazém e o CEP do destino da caixa
                createNewBox(armazemCaixas[i].CEP, armazemCaixas[i].horastrasporte,armazemCaixas[i].prioridade, i.ToString(), armazemCaixas[i].tamanhoCaixa);

            }
        }

        // Função para criar um novo item na lista
        private void createNewBox(string cepDestino, string tempoViagemDestino, string nivelPrioridade, string caixaNumero, string Tamanhodacaixa)
        {

            if (addedBoxes.Contains(caixaNumero))
            {
                return;
            }

            // Criando a GroupBox
            GroupBox groupbox = new GroupBox();
            Label label1 = new Label();
            Label label2 = new Label();
            Label label3 = new Label();
            Label label4 = new Label();
            Label caixaPrioridadeLevel = new Label();
            Label caixaTempoAteDestino = new Label();
            Label caixaCepDestino = new Label();
            Label caixaTamanhodacaixa = new Label();

            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(6, 23);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(112, 20);
            label1.TabIndex = 0;
            label1.Text = "CEP do destino:";

            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(3, 43);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(223, 20);
            label2.TabIndex = 1;
            label2.Text = "Tempo de viagem até o destino:";

            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(6, 67);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(119, 20);
            label3.TabIndex = 2;
            label3.Text = "Nível Prioridade:";

            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(6, 90);
            label4.Name = "label3";
            label4.Size = new System.Drawing.Size(119, 20);
            label4.TabIndex = 3;
            label4.Text = "Tamanho da caixa:";

            caixaPrioridadeLevel.AutoSize = true;
            caixaPrioridadeLevel.Location = new System.Drawing.Point(124, 67);
            caixaPrioridadeLevel.Name = "caixaPrioridadeLevel";
            caixaPrioridadeLevel.Size = new System.Drawing.Size(50, 20);
            caixaPrioridadeLevel.TabIndex = 4;
            caixaPrioridadeLevel.Text = nivelPrioridade;
 
            caixaTempoAteDestino.AutoSize = true;
            caixaTempoAteDestino.Location = new System.Drawing.Point(232, 43);
            caixaTempoAteDestino.Name = "caixaTempoAteDestino";
            caixaTempoAteDestino.Size = new System.Drawing.Size(50, 20);
            caixaTempoAteDestino.TabIndex = 5;
            caixaTempoAteDestino.Text = tempoViagemDestino;

            caixaCepDestino.AutoSize = true;
            caixaCepDestino.Location = new System.Drawing.Point(124, 23);
            caixaCepDestino.Name = "caixaCepDestino";
            caixaCepDestino.Size = new System.Drawing.Size(50, 20);
            caixaCepDestino.TabIndex = 6;
            caixaCepDestino.Text = cepDestino;

            caixaTamanhodacaixa.AutoSize = true;
            caixaTamanhodacaixa.Location = new System.Drawing.Point(124, 90);
            caixaTamanhodacaixa.Name = "caixaTamanhodacaixa";
            caixaTamanhodacaixa.Size = new System.Drawing.Size(50, 20);
            caixaTamanhodacaixa.TabIndex = 7;
            caixaTamanhodacaixa.Text = Tamanhodacaixa;

            groupbox.Controls.Add(caixaPrioridadeLevel);
            groupbox.Controls.Add(caixaTempoAteDestino);
            groupbox.Controls.Add(caixaCepDestino);
            groupbox.Controls.Add(caixaTamanhodacaixa);
            groupbox.Controls.Add(label3);
            groupbox.Controls.Add(label2);
            groupbox.Controls.Add(label1);
            groupbox.Controls.Add(label4);
            groupbox.Location = new System.Drawing.Point(3, 3);
            groupbox.Name = "groupBox1";
            groupbox.Size = new System.Drawing.Size(314, 116);
            groupbox.TabIndex = 0;
            groupbox.TabStop = false;
            groupbox.Text = caixaNumero;
            groupbox.BackColor =Color.White;

            flowLayoutPanel1.Controls.Add(groupbox);

            addedBoxes.Add(caixaNumero);
        }

        private void buttonAddCaixaArmazem_Click(object sender, EventArgs e)
        {
            Caixa caixa = new Caixa();
            if (caixaTextBoxCepDestino.Text != "" && caixaTamanhoComboBox.Text != "" && textBox1.Text != "")
            {
                caixa.CEP = caixaTextBoxCepDestino.Text;
                
                // Plotando a tela que irá mostrar que está "carregando"
                new Thread(() => new TelaCarregando().ShowDialog()).Start();

                // Pedindo para a função pegar as informações de um cep até o outro pela API
                dynamic getTripInfo = GetModSimTimeTripAPI.getTripInfoRoute(textBox1.Text, caixaTextBoxCepDestino.Text);

                // Fechar a tela que mostra o status da task (carregando)
                TelaCarregando f = new TelaCarregando();
                f = (TelaCarregando)Application.OpenForms["TelaCarregando"];
                f.Invoke(new ThreadStart(delegate { f.Close(); }));

                if (getTripInfo["error"] == null)
                {
                    caixa.tamanhoCaixa = caixaTamanhoComboBox.SelectedItem.ToString();
                    caixa.ID = armazemCaixas.Count;
                    caixa.prioridade = "1";
                    caixa.horastrasporte = getTripInfo["tempo_de_viagem"];
                    caixa.tempoTransporteSeconds = getTripInfo["tempo_de_viagem_seconds"];

                    armazemCaixas.Add(caixa);
                    MessageBox.Show("Caixa adicionada com sucesso!\n" + getTripInfo["destino"]);
                } else
                {
                    MessageBox.Show("Este CEP é inválido! Verifique novamente.");
                }
                
                Console.WriteLine("ID da caixa = " + caixa.ID + " : " + getTripInfo);
            }
            else
            {
                MessageBox.Show("preencher todos os campos");
            }

        }

        private void entregarButton_Click(object sender, EventArgs e)
        {
            try
            {
                // Criando uma lista para adicionar os controladores do flowPanel
                List<Control> listControl = new List<Control>();

                // Adicionando os controladores do flowpanel na lista criada
                foreach (Control control in flowLayoutPanel1.Controls)
                {
                    listControl.Add(control);
                }

                // Iterando entre os controladores do flowpanel que foram adicionados na lista
                // Depois filtrando groupboxes que tenham um conteúdo específico para remover do flowpanel
                foreach (Control control in listControl)
                {
                    // Procurando o controlador na groupBox que tenha como nome "caixaCepDestino"
                    Control[] myControl = (control as GroupBox).Controls.Find("caixaCepDestino", true);

                    // Iterando entre os itens encontrados pelo find
                    foreach (Control groupBoxControls in myControl)
                    {
                        // Verificando se o item encontrado pelo find é uma Label
                        if (groupBoxControls is Label)
                        {
                            Console.WriteLine("groupBoxControls is Label!");

                            // TODO: REMOVER AS CAIXAS SELECIONADAS

                            //Caixa proximaEntrega = LogisticaEntrega.decidirProximaEntregaFIFO(armazemCaixas);
                            Caixa proximaEntrega = LogisticaEntrega.decidirProximaEntregaANALISECEP(armazemCaixas);

                            Console.WriteLine("Próxima entrega: " + proximaEntrega.CEP);

                            if ((groupBoxControls as Label).Text == proximaEntrega.CEP)
                            {
                                flowLayoutPanel1.Controls.Remove(control);
                                armazemCaixas.Remove(proximaEntrega);
                                addedBoxes.Remove(proximaEntrega.ID.ToString());
                                IList<string> tempoTrajeto = proximaEntrega.horastrasporte.Split(':').ToList<string>();

                                MessageBox.Show("Caixa entregue com sucesso!\n\nID DA CAIXA: " + proximaEntrega.ID.ToString() + "\nCEP DA CAIXA: " + proximaEntrega.CEP + "\n\nO trajeto do armazém até o destino da caixa demorou aproximadamente " + tempoTrajeto[0] + " horas, " + tempoTrajeto[1] + " minutos e " + tempoTrajeto[2] + " segundos!");
                                return;
                            }
                        }
                    }
                }
            } catch (Exception)
            {
                MessageBox.Show("Algum erro ocorreu!");
            }
        }

        private void buttonDefinirArmazemDados_Click(object sender, EventArgs e)
        {
            if (textBox1.Enabled == true) {
                // Plotando a tela que irá mostrar que está "carregando"
                new Thread(() => new TelaCarregando().ShowDialog()).Start();

                // Pedindo para a função pegar as informações de um cep até o outro pela API
                // Passando para a API um CEP que existe informações (01025010) para que seja possível validar o CEP informado do 
                // Armazém.
                // TODO: Fazer uma função na API para verificar se existem informações do CEP que foi passado em vez de fazer dessa maneira.
                dynamic getTripInfo = GetModSimTimeTripAPI.getTripInfoRoute(textBox1.Text, "01025010");

                // Fechar a tela que mostra o status da task (carregando)
                TelaCarregando f = new TelaCarregando();
                f = (TelaCarregando)Application.OpenForms["TelaCarregando"];
                f.Invoke(new ThreadStart(delegate { f.Close(); }));

                if (getTripInfo["error"] == null)
                {
                    MessageBox.Show("Local do armázem definido com sucesso na rua:\n" + getTripInfo["partida"]);
                    textBox1.Enabled = false;
                    buttonDefinirArmazemDados.Text = "Redefinir";
                }
                else
                {
                    MessageBox.Show("Este CEP é inválido! Verifique novamente.");
                }
            }
            else
            {
                textBox1.Enabled = true;
                buttonDefinirArmazemDados.Text = "Definir";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // TODO: SETAR TAMANHO DA CAIXA DA MOTO
        }
    }
}
