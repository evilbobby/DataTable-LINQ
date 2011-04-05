
		private void SetSummaryTotals (DataTable contractSummary) {
			var summaryInfo = contractSummary.AsEnumerable();
			decimal totalCost = summaryInfo.Select(x => x.Field<decimal>("TotalCost")).Sum();
			decimal totalNetCost = summaryInfo.Select(x => x.Field<decimal>("TotalNetCost")).Sum();
			decimal totalSale = summaryInfo.Select(x => x.Field<decimal>("TotalSale")).Sum();
			decimal totalNetSale = summaryInfo.Select(x => x.Field<decimal>("TotalNetSale")).Sum();
			decimal totalProfit = summaryInfo.Select(x => x.Field<decimal>("TotalProfit")).Sum();
			decimal profitPercent = totalNetSale == 0 ? 0 : totalProfit / totalNetSale;

			lblSummaryTotalCost.Text = string.Format("{0:0.00}", totalCost);
			lblSummaryTotalNetCost.Text = string.Format("{0:0.00}", totalNetCost);
			lblSummaryTotalSale.Text = string.Format("{0:0.00}", totalSale);
			lblSummaryTotalNetSale.Text = string.Format("{0:0.00}", totalNetSale);
			lblSummaryTotalProfit.Text = string.Format("{0:0.00}", totalProfit);
			lblSummaryTotalAvgProfit.Text = string.Format("{0:0.00 %}", profitPercent);
		}