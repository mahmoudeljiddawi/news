using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace NewspaperSellerModels
{
    public class SimulationSystem
    {
        Random rnd = new Random();
        public SimulationSystem()
        {
            DayTypeDistributions = new List<DayTypeDistribution>();
            DemandDistributions = new List<DemandDistribution>();
            SimulationTable = new List<SimulationCase>();
            PerformanceMeasures = new PerformanceMeasures();
        }
        ///////////// INPUTS /////////////
        public int NumOfNewspapers { get; set; }
        public int NumOfRecords { get; set; }
        public decimal PurchasePrice { get; set; }
        public decimal SellingPrice { get; set; }
        public decimal ScrapPrice { get; set; }
        public decimal UnitProfit { get; set; }
        public List<DayTypeDistribution> DayTypeDistributions { get; set; }
        public List<DemandDistribution> DemandDistributions { get; set; }

        public void DayType_Disribution( ref SimulationSystem s)
        {
            for(int i=0; i<DayTypeDistributions.Count; i++)
            {
                if(i==0)
                {
                    s.DayTypeDistributions[i].CummProbability = s.DayTypeDistributions[i].Probability;
                    s.DayTypeDistributions[i].MinRange = 1;
                    s.DayTypeDistributions[i].MaxRange = Convert.ToInt32(s.DayTypeDistributions[i].CummProbability*100);
                }
                else
                {
                    s.DayTypeDistributions[i].CummProbability = s.DayTypeDistributions[i-1].CummProbability + s.DayTypeDistributions[i].Probability;
                    s.DayTypeDistributions[i].MinRange = s.DayTypeDistributions[i-1].MaxRange + 1;
                    s.DayTypeDistributions[i].MaxRange = Convert.ToInt32(s.DayTypeDistributions[i].CummProbability * 100);
                }
            }
        }
        public void Demand_Disrtibution(ref SimulationSystem s)
        {
            for (int i = 0; i < s.DemandDistributions.Count; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (i == 0)
                    {
                        s.DemandDistributions[i].DayTypeDistributions[j].CummProbability = s.DemandDistributions[i].DayTypeDistributions[j].Probability;
                        s.DemandDistributions[i].DayTypeDistributions[j].MinRange = 1;
                        s.DemandDistributions[i].DayTypeDistributions[j].MaxRange = Convert.ToInt32(s.DemandDistributions[i].DayTypeDistributions[j].CummProbability * 100);
                    }
                    else
                    {
                        s.DemandDistributions[i].DayTypeDistributions[j].CummProbability = s.DemandDistributions[i - 1].DayTypeDistributions[j].CummProbability + s.DemandDistributions[i].DayTypeDistributions[j].Probability;
                        s.DemandDistributions[i].DayTypeDistributions[j].MinRange = s.DemandDistributions[i - 1].DayTypeDistributions[j].MaxRange + 1;
                        s.DemandDistributions[i].DayTypeDistributions[j].MaxRange = Convert.ToInt32(s.DemandDistributions[i].DayTypeDistributions[j].CummProbability * 100);
                    }
                }
            }
        }

        ///////////// OUTPUTS /////////////
        public List<SimulationCase> SimulationTable { get; set; }
        public PerformanceMeasures PerformanceMeasures { get; set; }

        public void Calculate_SimulationTable(ref SimulationSystem s)
        {
            s.PerformanceMeasures.TotalSalesProfit = 0;
            s.PerformanceMeasures.TotalLostProfit = 0;
            s.PerformanceMeasures.TotalScrapProfit = 0;
            s.PerformanceMeasures.TotalNetProfit = 0;
            s.PerformanceMeasures.DaysWithUnsoldPapers = 0;
            s.PerformanceMeasures.DaysWithMoreDemand = 0;
            s.PerformanceMeasures.TotalCost = s.NumOfRecords * s.NumOfNewspapers * s.PurchasePrice;
            s.UnitProfit = s.SellingPrice - s.PurchasePrice;
            int index = 0;
            for(int i = 0; i<s.NumOfRecords; i++)
            {
                SimulationCase SC = new SimulationCase();
                SC.DayNo = i + 1;
                SC.DailyCost = s.NumOfNewspapers * s.PurchasePrice;
                SC.RandomNewsDayType = rnd.Next(1, 100);
                for(int j=0; j<s.DayTypeDistributions.Count;j++)
                {
                    if (SC.RandomNewsDayType >= s.DayTypeDistributions[j].MinRange && SC.RandomNewsDayType <= s.DayTypeDistributions[j].MaxRange)
                        SC.NewsDayType = s.DayTypeDistributions[j].DayType;
                }
                SC.RandomDemand = rnd.Next(1, 100);
                index = (int)SC.NewsDayType;
                for (int j=0; j<s.DemandDistributions.Count; j++)
                {
                    if (SC.RandomDemand >= s.DemandDistributions[j].DayTypeDistributions[index].MinRange && SC.RandomDemand <= s.DemandDistributions[j].DayTypeDistributions[index].MaxRange)
                        SC.Demand = s.DemandDistributions[j].Demand;
                }

                if (SC.Demand > s.NumOfNewspapers)
                {
                    SC.SalesProfit = s.SellingPrice * s.NumOfNewspapers;
                    SC.LostProfit = (SC.Demand - s.NumOfNewspapers) * s.UnitProfit;
                    SC.ScrapProfit = 0;
                    s.PerformanceMeasures.DaysWithMoreDemand += 1;
                }
                else
                {
                    SC.SalesProfit = s.SellingPrice * SC.Demand;
                    SC.LostProfit = 0;
                    SC.ScrapProfit = (s.NumOfNewspapers - SC.Demand) * s.ScrapPrice;
                }
                if (SC.Demand < s.NumOfNewspapers)
                s.PerformanceMeasures.DaysWithUnsoldPapers += 1;
                SC.DailyNetProfit = SC.SalesProfit - SC.DailyCost - SC.LostProfit + SC.ScrapProfit;
                s.PerformanceMeasures.TotalSalesProfit += SC.SalesProfit;
                s.PerformanceMeasures.TotalLostProfit += SC.LostProfit;
                s.PerformanceMeasures.TotalScrapProfit += SC.ScrapProfit;
                s.PerformanceMeasures.TotalNetProfit += SC.DailyNetProfit;
                s.SimulationTable.Add(SC);
            }
        }
    }
}
