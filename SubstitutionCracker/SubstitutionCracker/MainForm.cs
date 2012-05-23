using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace SubstitutionCracker
{
    public partial class MainForm : Form
    {
        private string key;
        private bool cancel;
        private bool running;

        public MainForm()
        {
            InitializeComponent();
            key = "";
            cancel = false;
            running = false;
        }

        private void UpdateState()
        {
            this.btnRunAlgorithm.Enabled = lblFilename.Text != "No File Selected" &&
                                           plainText.TextLength > 0 && !running;
            this.btnCancel.Enabled = running;
            this.btnLoadPlainText.Enabled = !running;
            this.gbOptions.Enabled = !running;
            //this.btnLoadTrainingFile.Enabled = !running;
        }

        private void btnLoadTrainingFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                this.lblFilename.Text = dialog.FileName;
            }
            UpdateState();
        }

        private void btnLoadPlainText_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                plainText.Text = (new StreamReader(dialog.FileName).ReadToEnd().Trim().ToUpper());
                key = SubstitutionCipher.GenerateRandomKey();
                this.outputText.Text = "Encryption Key: " + key + "\n";
                cipherText.Text = SubstitutionCipher.EncryptText(this.plainText.Text, key);
            }
            UpdateState();
        }

        private List<double> CalculateStatistics(Environment env)
        {
            List<double> list = new List<double>();
            double max = double.MinValue;
            double min = double.MaxValue;
            double average = 0;
            foreach (Individual i in env.Population)
            {
                average += i.Fitness;
                if (i.Fitness < min)
                {
                    min = i.Fitness;
                }
                if (i.Fitness > max)
                {
                    max = i.Fitness;
                }
            }
            average /= env.Population.Count;
            list.Add(min);
            list.Add(max);
            list.Add(average);
            return list;
        }

        private void btnRunAlgorithm_Click(object sender, EventArgs e)
        {
            this.cancel = false;
            if (this.outputText.Text != "Encryption Key: " + key + "\n")
            {
                this.outputText.Text = "Encryption Key: " + key + "\n";
            }
            Environment environment = new Environment(lblFilename.Text,
                plainText.Text, cipherText.Text, (int)nudNumberOfGenerations.Value,
                (int)nudPopulationSize.Value, (double)nudPercentageOfElitism.Value,
                (int)nudTournamentSize.Value, Convert.ToDouble(tbxTournamentWinnerProbability.Text),
                Convert.ToDouble(tbxProbabilityOfCrossover.Text), (int)nudNumberOfCrossoverPoints.Value,
                Convert.ToDouble(tbxProbabilityOfMutation.Text));
            decryptedText.Text = SubstitutionCipher.DecryptText(cipherText.Text, environment.Population[0].Chromosone);
            List<List<double>> fitnessResults = new List<List<double>>();
            fitnessResults.Add(CalculateStatistics(environment));
            running = true;
            while (environment.CurrentGeneration <= environment.NumberOfGenerations &&
                   decryptedText.Text != plainText.Text && !cancel)
            {
                UpdateState();
                Application.DoEvents();
                environment.CreateNewGeneration();
                Application.DoEvents();
                List<double> results = CalculateStatistics(environment);
                fitnessResults.Add(results);
                lblGeneration.Text = String.Format("Generation: {0:0000}         Min: {1:00000.00000}         Max: {2:00000.00000}         Average: {3:00000.00000}\n", environment.CurrentGeneration, results[0], results[1], results[2]);
                Application.DoEvents();
                decryptedText.Text = SubstitutionCipher.DecryptText(cipherText.Text, environment.Population[0].Chromosone);
                this.outputText.Text += String.Format("Generation {0:0000} - Best Individual: {1:00000.00000}\n", environment.CurrentGeneration, environment.Population[0].Fitness);
                Application.DoEvents();
            }
            running = false;
            UpdateState();
            try
            {
                this.outputText.Text += "\nGeneration,Min Fitness,Max Fitness, Average Fitness\n";
                for (int i = 0; i < fitnessResults.Count; i++)
                {
                    this.outputText.Text += String.Format("{0},{1},{2},{3}\n", i, fitnessResults[i][0], fitnessResults[i][1], fitnessResults[i][2]);
                }
                if (cancel)
                {
                    MessageBox.Show(this, "Decryption Cancelled!", "Information");
                }
                else if (decryptedText.Text == plainText.Text)
                {
                    MessageBox.Show(this, "Completed Decryption Successfully!", "Information");
                }
                else
                {
                    MessageBox.Show(this, "Failed to Complete Decryption in the Number of Steps Specified!", "Information");
                }
            }
            catch (Exception exception) { }
            cancel = false;            
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.cancel = true;
        }              
    }
}