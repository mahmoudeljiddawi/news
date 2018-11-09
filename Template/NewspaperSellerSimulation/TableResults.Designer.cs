namespace NewspaperSellerSimulation
{
    partial class TableResults
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.simulation_table = new System.Windows.Forms.DataGridView();
            this.Day = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RandomD1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dayType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RandomD2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Demand = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Revenue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lostProfit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.salesOfScrap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dailyProfit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.newspaperCost = new System.Windows.Forms.Label();
            this.excessDemand = new System.Windows.Forms.Label();
            this.daysOfunsoldpapers = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.simulation_table)).BeginInit();
            this.SuspendLayout();
            // 
            // simulation_table
            // 
            this.simulation_table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.simulation_table.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Day,
            this.RandomD1,
            this.dayType,
            this.RandomD2,
            this.Demand,
            this.Revenue,
            this.lostProfit,
            this.salesOfScrap,
            this.dailyProfit});
            this.simulation_table.Location = new System.Drawing.Point(0, 0);
            this.simulation_table.Name = "simulation_table";
            this.simulation_table.Size = new System.Drawing.Size(966, 458);
            this.simulation_table.TabIndex = 0;
            this.simulation_table.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.simulation_table_CellContentClick);
            // 
            // Day
            // 
            this.Day.HeaderText = "Day";
            this.Day.Name = "Day";
            // 
            // RandomD1
            // 
            this.RandomD1.HeaderText = "Random Digit for Type of newspaper";
            this.RandomD1.Name = "RandomD1";
            // 
            // dayType
            // 
            this.dayType.HeaderText = "Type of NewsDay";
            this.dayType.Name = "dayType";
            // 
            // RandomD2
            // 
            this.RandomD2.HeaderText = "Random Digit for Demand ";
            this.RandomD2.Name = "RandomD2";
            // 
            // Demand
            // 
            this.Demand.HeaderText = "Demand";
            this.Demand.Name = "Demand";
            // 
            // Revenue
            // 
            this.Revenue.HeaderText = "Revenue from Sales";
            this.Revenue.Name = "Revenue";
            // 
            // lostProfit
            // 
            this.lostProfit.HeaderText = "Lost from Excess Demand";
            this.lostProfit.Name = "lostProfit";
            // 
            // salesOfScrap
            // 
            this.salesOfScrap.HeaderText = "Sales of Scrap";
            this.salesOfScrap.Name = "salesOfScrap";
            // 
            // dailyProfit
            // 
            this.dailyProfit.HeaderText = "Daily Profit";
            this.dailyProfit.Name = "dailyProfit";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(26, 492);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(170, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Total Cost of Newspapers";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(26, 525);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(256, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Number of days having excess demand";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(26, 559);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(248, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Number of days having unsold papers";
            // 
            // newspaperCost
            // 
            this.newspaperCost.AutoSize = true;
            this.newspaperCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newspaperCost.Location = new System.Drawing.Point(368, 492);
            this.newspaperCost.Name = "newspaperCost";
            this.newspaperCost.Size = new System.Drawing.Size(170, 17);
            this.newspaperCost.TabIndex = 4;
            this.newspaperCost.Text = "Total Cost of Newspapers";
            // 
            // excessDemand
            // 
            this.excessDemand.AutoSize = true;
            this.excessDemand.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.excessDemand.Location = new System.Drawing.Point(368, 525);
            this.excessDemand.Name = "excessDemand";
            this.excessDemand.Size = new System.Drawing.Size(170, 17);
            this.excessDemand.TabIndex = 5;
            this.excessDemand.Text = "Total Cost of Newspapers";
            // 
            // daysOfunsoldpapers
            // 
            this.daysOfunsoldpapers.AutoSize = true;
            this.daysOfunsoldpapers.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.daysOfunsoldpapers.Location = new System.Drawing.Point(368, 559);
            this.daysOfunsoldpapers.Name = "daysOfunsoldpapers";
            this.daysOfunsoldpapers.Size = new System.Drawing.Size(170, 17);
            this.daysOfunsoldpapers.TabIndex = 6;
            this.daysOfunsoldpapers.Text = "Total Cost of Newspapers";
            // 
            // TableResults
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(978, 594);
            this.Controls.Add(this.daysOfunsoldpapers);
            this.Controls.Add(this.excessDemand);
            this.Controls.Add(this.newspaperCost);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.simulation_table);
            this.Name = "TableResults";
            this.Text = "TableResults";
            ((System.ComponentModel.ISupportInitialize)(this.simulation_table)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView simulation_table;
        private System.Windows.Forms.DataGridViewTextBoxColumn Day;
        private System.Windows.Forms.DataGridViewTextBoxColumn RandomD1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dayType;
        private System.Windows.Forms.DataGridViewTextBoxColumn RandomD2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Demand;
        private System.Windows.Forms.DataGridViewTextBoxColumn Revenue;
        private System.Windows.Forms.DataGridViewTextBoxColumn lostProfit;
        private System.Windows.Forms.DataGridViewTextBoxColumn salesOfScrap;
        private System.Windows.Forms.DataGridViewTextBoxColumn dailyProfit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label newspaperCost;
        private System.Windows.Forms.Label excessDemand;
        private System.Windows.Forms.Label daysOfunsoldpapers;
    }
}