using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NewspaperSellerModels;

namespace NewspaperSellerSimulation
{
    public partial class TableResults : Form
    {

        public TableResults(ref SimulationSystem SimulationSystem)
        {
            InitializeComponent();
            simulation_table.Rows.Add(SimulationSystem.NumOfRecords + 1);
            for (int i = 0; i < SimulationSystem.SimulationTable.Count; i++)
            {
                simulation_table.Rows[i].Cells[0].Value = i + 1;
                simulation_table.Rows[i].Cells[1].Value = SimulationSystem.SimulationTable[i].RandomNewsDayType;
                simulation_table.Rows[i].Cells[2].Value = SimulationSystem.SimulationTable[i].NewsDayType;
                simulation_table.Rows[i].Cells[3].Value = SimulationSystem.SimulationTable[i].RandomDemand;
                simulation_table.Rows[i].Cells[4].Value = SimulationSystem.SimulationTable[i].Demand;
                simulation_table.Rows[i].Cells[5].Value = SimulationSystem.SimulationTable[i].SalesProfit;
                simulation_table.Rows[i].Cells[6].Value = SimulationSystem.SimulationTable[i].LostProfit;
                simulation_table.Rows[i].Cells[7].Value = SimulationSystem.SimulationTable[i].ScrapProfit;
                simulation_table.Rows[i].Cells[8].Value = SimulationSystem.SimulationTable[i].DailyNetProfit;
            }
            simulation_table.Rows[SimulationSystem.SimulationTable.Count].Cells[5].Value = SimulationSystem.PerformanceMeasures.TotalSalesProfit;
            simulation_table.Rows[SimulationSystem.SimulationTable.Count].Cells[6].Value = SimulationSystem.PerformanceMeasures.TotalLostProfit;
            simulation_table.Rows[SimulationSystem.SimulationTable.Count].Cells[7].Value = SimulationSystem.PerformanceMeasures.TotalScrapProfit;
            simulation_table.Rows[SimulationSystem.SimulationTable.Count].Cells[8].Value = SimulationSystem.PerformanceMeasures.TotalNetProfit;
            newspaperCost.Text = Convert.ToString(SimulationSystem.PerformanceMeasures.TotalCost);
            excessDemand.Text = Convert.ToString(SimulationSystem.PerformanceMeasures.DaysWithMoreDemand);
            daysOfunsoldpapers.Text = Convert.ToString(SimulationSystem.PerformanceMeasures.DaysWithUnsoldPapers);
        }

        private void simulation_table_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
