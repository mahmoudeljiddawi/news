using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NewspaperSellerModels;
using NewspaperSellerTesting;

namespace NewspaperSellerSimulation
{
    public partial class Form1 : Form
    {
        SimulationSystem simulationSystem;
        public Form1()
        {
            InitializeComponent();
            simulationSystem = new SimulationSystem();
        }

        private void read_data_Click(object sender, EventArgs e)
        {
            string test = "" , filename = "";
            test = testcase.Text.ToString();
            filename = @"C:\Users\Mahmoud\Desktop\Task2\Template\NewspaperSellerSimulation\TestCases\TestCase" + test[0] + ".txt";
            if (File.Exists(filename))
            {
                string text = System.IO.File.ReadAllText(filename);

                DayTypeDistribution D = new DayTypeDistribution();

                string[] lines = System.IO.File.ReadAllLines(filename);
                for (int i = 0; i < lines.Length; i++)
                {
                    if (lines[i] == "NumOfNewspapers")
                    {
                        i++;
                        simulationSystem.NumOfNewspapers = Convert.ToInt32(lines[i]);
                    }
                    if (lines[i] == "NumOfRecords")
                    {
                        i++;
                        simulationSystem.NumOfRecords = Convert.ToInt32(lines[i]);
                    }
                    if (lines[i] == "PurchasePrice")
                    {
                        i++;
                        simulationSystem.PurchasePrice = Convert.ToDecimal(lines[i]);
                    }
                    if (lines[i] == "ScrapPrice")
                    {
                        i++;
                        simulationSystem.ScrapPrice = Convert.ToDecimal(lines[i]);
                    }
                    if (lines[i] == "SellingPrice")
                    {
                        i++;
                        simulationSystem.SellingPrice = Convert.ToDecimal(lines[i]);
                    }
                    if (lines[i] == "DayTypeDistributions")
                    {
                        i++;
                        string[] DayTypeD;
                        DayTypeD = lines[i].Split(',');
                        DayTypeD[1] = DayTypeD[1].Remove(0, 1);
                        DayTypeD[2] = DayTypeD[2].Remove(0, 1);

                        D = new DayTypeDistribution();
                        D.DayType = Enums.DayType.Good;
                        D.Probability = Convert.ToDecimal(DayTypeD[0]);
                        simulationSystem.DayTypeDistributions.Add(D);

                        D = new DayTypeDistribution();
                        D.DayType = Enums.DayType.Fair;
                        D.Probability = Convert.ToDecimal(DayTypeD[1]);
                        simulationSystem.DayTypeDistributions.Add(D);

                        D = new DayTypeDistribution();
                        D.DayType = Enums.DayType.Poor;
                        D.Probability = Convert.ToDecimal(DayTypeD[2]);
                        simulationSystem.DayTypeDistributions.Add(D);

                    }
                    if (lines[i] == "DemandDistributions")
                    {
                        i++;
                        string[] DemandDist;
                        DemandDistribution demDist;
                        bool firstTime = true;
                        while (i < lines.Length)
                        {
                            demDist = new DemandDistribution();
                            DemandDist = lines[i].Split(',');
                            demDist.Demand = Convert.ToInt32(DemandDist[0]);
                            for (int j = 1; j < DemandDist.Length; j++)
                            {
                                D = new DayTypeDistribution();
                                DemandDist[j].Remove(0, 1);

                                if (j == 1)
                                    D.DayType = Enums.DayType.Good;
                                else if (j == 2)
                                    D.DayType = Enums.DayType.Fair;
                                else
                                    D.DayType = Enums.DayType.Poor;

                                D.Probability = Convert.ToDecimal(DemandDist[j]);
                                demDist.DayTypeDistributions.Add(D);
                            }
                            simulationSystem.DemandDistributions.Add(demDist);
                            i++;
                        }
                    }
                }
                MessageBox.Show("file has been read successfully");
            }
            else
            MessageBox.Show("error in reading file");
        }

        private void simulate_Click(object sender, EventArgs e)
        {
            simulationSystem.DayType_Disribution(ref simulationSystem);
            simulationSystem.Demand_Disrtibution(ref simulationSystem);
            simulationSystem.Calculate_SimulationTable(ref simulationSystem);
            string testResult = TestingManager.Test(simulationSystem, Constants.FileNames.TestCase2);
            MessageBox.Show(testResult);
            this.Hide();
            TableResults results = new TableResults(ref simulationSystem);
            results.Show();
        }
    }
}
