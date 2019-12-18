using OfficeOpenXml;
using OfficeOpenXml.Style;
using OfficeOpenXml.Table;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Transaction_Statistical.Class
{
    class TemplateHelper
    {
        public enum TEMPLATE
        {
            CanQuyTheoCouterTrenMay,
            BaoCaoGiaoDichTaiChinh,
            BaoCaoGiaoDichTaiChinhKhongThanhCong,
            BaoCaoGiaoDichTaiChinhBatThuong,
            BaoCaoHoatDongBatThuong,
        }

        ExcelPackage excelPackage { get; set; }
        private const string formatDate = "dd/mm/yyy h:mm";
        private const string formatNumber = "##0.0";

        public Stream getStream()
        {
            return this.excelPackage.Stream;
        }
        public TemplateHelper(string Author, string Title, string Comments, ExcelPackage excelPackage)
        {
            this.excelPackage = excelPackage;
            this.excelPackage.Workbook.Properties.Author = Author;
            this.excelPackage.Workbook.Properties.Title = Title;
            this.excelPackage.Workbook.Properties.Comments = Comments;
        }

        public void CanQuyTheoCouterTrenMay(string WorksheetsName, TableStyles tableStyles, Dictionary<DateTime, Cycle> ListCycle)
        {
            try
            {
                this.excelPackage.Workbook.Worksheets.Add(WorksheetsName);
                var lastWS = excelPackage.Workbook.Worksheets.Last();
                lastWS = DrawCounter(lastWS, ListCycle);
                this.excelPackage.Save();

            }
            catch (Exception e)
            {
                throw e;
            }
        }
        private class TerminalInfo
        {
            string terID;
            DateTime begin;
            DateTime end;

            public string TerID { get => terID; set => terID = value; }
            public DateTime Begin { get => begin; set => begin = value; }
            public DateTime End { get => end; set => end = value; }

            public TerminalInfo(string terID, DateTime begin, DateTime end)
            {
                TerID = terID ?? throw new ArgumentNullException(nameof(terID));
                Begin = begin;
                End = end;
            }
        }
        public void BaoCaoHoatDongBatThuong(string WorksheetsName, TableStyles tableStyles, Dictionary<string, Dictionary<DateTime, object>> ListTransaction)
        {
            try
            {
                this.excelPackage.Workbook.Worksheets.Add(WorksheetsName);
                var lastWS = excelPackage.Workbook.Worksheets.Last();
                int index = 2;
                //DRAW CHUDE
                using (ExcelRange rng = lastWS.Cells["A1:I1"])
                {
                    rng.Style.Fill.PatternType = OfficeOpenXml.Style.ExcelFillStyle.Solid;
                    rng.Style.Fill.BackgroundColor.SetColor(Color.FromArgb(252, 228, 214));
                    rng.Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;
                    rng.Style.VerticalAlignment = ExcelVerticalAlignment.Center;

                    rng.Style.Border.Top.Style = ExcelBorderStyle.Thin;
                    rng.Style.Border.Bottom.Style = ExcelBorderStyle.Thin;
                    rng.Style.Border.Left.Style = ExcelBorderStyle.Thin;
                    rng.Style.Border.Right.Style = ExcelBorderStyle.Thin;


                    rng.Style.Border.Top.Color.SetColor(Color.Black);
                    rng.Style.Border.Bottom.Color.SetColor(Color.Black);
                    rng.Style.Border.Left.Color.SetColor(Color.Black);
                    rng.Style.Border.Right.Color.SetColor(Color.Black);
                }
                foreach (var item in ListTransaction)
                {
                    var cycles = item.Value.Where(x => x.Value is Cycle).ToDictionary(x => x.Key, x => (Cycle)x.Value);
                    var events = item.Value.Where(x => x.Value is TransactionEvent).ToDictionary(x => x.Key, x => (TransactionEvent)x.Value);
                    lastWS = DrawHDBT(lastWS, events, cycles, item.Key, ref index);
                    index++;
                }
                this.excelPackage.Save();
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public void BaoCaoGiaoDichTaiChinh(string WorksheetsName, TableStyles tableStyles, Dictionary<DateTime, Transaction> ListTransaction, Dictionary<DateTime, Cycle> cycles)
        {
            this.excelPackage.Workbook.Worksheets.Add(WorksheetsName);
            var lastWS = excelPackage.Workbook.Worksheets.Last();
            lastWS = DrawGDTC(lastWS, ListTransaction, cycles);
            this.excelPackage.Save();
        }

        private ExcelWorksheet DrawCounter(ExcelWorksheet worksheet, Dictionary<DateTime, Cycle> ListCycle)
        {
            try
            {

                #region HEADER
                using (ExcelRange rng = worksheet.Cells["A1:I1"])
                {
                    rng.Style.Fill.PatternType = OfficeOpenXml.Style.ExcelFillStyle.Solid;
                    rng.Style.Fill.BackgroundColor.SetColor(Color.FromArgb(248, 203, 173));
                    rng.Merge = true;
                    rng.Value = "BẢNG THỐNG KÊ COUNTER TRÊN MỖI CHU KỲ";
                }
                var cycles = ListCycle.ToArray();
                int indexCol = 1;
                int indexRow = 3;




                #endregion
                #region DRAW DATA
                for (long cycle = 0; cycle < cycles.Count(); cycle++)
                {
                    //HEADER MENH GIA
                    using (ExcelRange rng = worksheet.Cells[indexRow, indexCol])
                    {
                        rng.Value = "Mệnh Giá";

                    }
                    using (ExcelRange rng = worksheet.Cells[indexRow, indexCol + 1])
                    {
                        rng.Value = "ATM ID";

                    }
                    using (ExcelRange rng = worksheet.Cells[indexRow, indexCol + 2])
                    {
                        rng.Value = "Ngày giờ tiếp quỹ";

                    }
                    using (ExcelRange rng = worksheet.Cells[indexRow, indexCol + 3])
                    {
                        rng.Value = "Ngày giờ kiểm quỹ";

                    }
                    using (ExcelRange rng = worksheet.Cells[indexRow, indexCol + 4])
                    {
                        rng.Value = "Tiếp quỹ";

                    }
                    using (ExcelRange rng = worksheet.Cells[indexRow, indexCol + 5])
                    {
                        rng.Value = "Giao dịch rút tiền";

                    }
                    using (ExcelRange rng = worksheet.Cells[indexRow, indexCol + 6])
                    {
                        rng.Value = "Giao dịch nộp tiền";

                    }
                    using (ExcelRange rng = worksheet.Cells[indexRow, indexCol + 7])
                    {
                        rng.Value = "Số tiền trong khay thu hồi";

                    }
                    using (ExcelRange rng = worksheet.Cells[indexRow, indexCol + 8])
                    {
                        rng.Value = "Số tiền còn lại";

                    }
                    using (ExcelRange rng = worksheet.Cells[string.Format("A{0}:I{1}", indexRow, indexRow)])
                    {
                        rng.Style.Fill.PatternType = OfficeOpenXml.Style.ExcelFillStyle.Solid;
                        rng.Style.Fill.BackgroundColor.SetColor(Color.FromArgb(255, 255, 0));
                    }
                    var cycleItem = cycles[cycle].Value;
                    var denoList = cycles[cycle].Value.DenominationCount;
                    int denoLength = denoList.Count;
                    if (denoList.ContainsKey("TotalAmount"))
                    {
                        denoLength -= 1;
                    }
                    //
                    int indexDeno = indexRow;
                    for (int deno = 0; deno < denoList.Count(); deno++)
                    {
                        indexDeno++;
                        var denoItem = denoList.ToArray()[deno].Value;
                        if (!denoItem.Name.Contains("TotalAmount"))
                        {
                            using (ExcelRange rng = worksheet.Cells[string.Format("A{0}", indexDeno)])
                            {
                                rng.Value = denoItem.Name;
                            }
                            using (ExcelRange rng = worksheet.Cells[string.Format("E{0}", indexDeno)])
                            {
                                rng.Formula = "=" + denoItem.Initial;
                            }
                            using (ExcelRange rng = worksheet.Cells[string.Format("F{0}", indexDeno)])
                            {
                                rng.Style.Numberformat.Format = "0";
                                rng.Formula = "=" + denoItem.Dispensed;
                            }
                            using (ExcelRange rng = worksheet.Cells[string.Format("G{0}", indexDeno)])
                            {
                                rng.Style.Numberformat.Format = "0";
                                rng.Formula = "=" + denoItem.Deposited;
                            }
                            using (ExcelRange rng = worksheet.Cells[string.Format("H{0}", indexDeno)])
                            {
                                rng.Style.Numberformat.Format = "0";
                                rng.Formula = "=" + denoItem.Retracted;
                            }
                            using (ExcelRange rng = worksheet.Cells[string.Format("I{0}", indexDeno)])
                            {
                                rng.Style.Numberformat.Format = "0";
                                rng.Formula = "=" + denoItem.Remaining;
                            }
                        }
                        else
                        {
                            indexDeno--;
                        }
                    }

                    //ATM ID
                    using (ExcelRange rng = worksheet.Cells[string.Format("B{0}:B{1}", indexRow + 1, indexRow + denoLength)])
                    {
                        rng.Merge = true;
                        rng.Value = cycleItem.TerminalID;
                    }

                    using (ExcelRange rng = worksheet.Cells[string.Format("C{0}:C{1}", indexRow + 1, indexRow + denoLength)])
                    {
                        rng.Merge = true;
                        rng.Value = cycleItem.SettlementPeriodDateBegin.ToString();
                    }
                    using (ExcelRange rng = worksheet.Cells[string.Format("D{0}:D{1}", indexRow + 1, indexRow + denoLength)])
                    {
                        rng.Merge = true;
                        rng.Value = cycleItem.SettlementPeriodDateEnd.ToString();
                    }


                    using (ExcelRange rng = worksheet.Cells[string.Format("A{0}:I{1}", indexRow, indexRow + denoLength)])
                    {
                        rng.Style.Border.Top.Style = ExcelBorderStyle.Thin;
                        rng.Style.Border.Bottom.Style = ExcelBorderStyle.Thin;
                        rng.Style.Border.Left.Style = ExcelBorderStyle.Thin;
                        rng.Style.Border.Right.Style = ExcelBorderStyle.Thin;

                        rng.Style.Border.Top.Color.SetColor(Color.Black);
                        rng.Style.Border.Bottom.Color.SetColor(Color.Black);
                        rng.Style.Border.Left.Color.SetColor(Color.Black);
                        rng.Style.Border.Right.Color.SetColor(Color.Black);
                    }
                    indexRow += denoLength + 2;
                }
                #endregion
                var allCells = worksheet.Cells[1, 1, worksheet.Dimension.End.Row, worksheet.Dimension.End.Column];
                var cellFont = allCells.Style.Font;
                allCells.Style.VerticalAlignment = ExcelVerticalAlignment.Center;
                allCells.Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;
                cellFont.SetFromFont(new Font("Calibri", 11));
                worksheet.Cells[worksheet.Dimension.Address].AutoFitColumns();

            }
            catch (Exception e)
            {
                throw e;
            }
            return worksheet;
        }
        private ExcelWorksheet DrawHDBT(ExcelWorksheet worksheet, Dictionary<DateTime, TransactionEvent> ListTransaction, Dictionary<DateTime, Cycle> Cycles, string atmID, ref int index)
        {
            try
            {

                foreach (var itemC in Cycles)
                {
                    var eventDevice = ListTransaction;
                    var openTheCashDrawer = eventDevice.Where(x => x.Value.TContent.Contains("Safe Door")
                    && x.Value.DateBegin > itemC.Value.SettlementPeriodDateBegin
                    && x.Value.DateBegin < itemC.Value.SettlementPeriodDateEnd)
                        .ToDictionary(d => d.Key, d => d.Value);
                    var openTechnicalChamber = eventDevice.Where(x => x.Value.TContent.Contains("Supervisor Mode")
                     && x.Value.DateBegin > itemC.Value.SettlementPeriodDateBegin
                    && x.Value.DateBegin < itemC.Value.SettlementPeriodDateEnd)
                        .ToDictionary(d => d.Key, d => d.Value);
                    var reboot = eventDevice.Where(x => x.Value.TContent.Contains("Restart process started by program")
                     && x.Value.DateBegin > itemC.Value.SettlementPeriodDateBegin
                    && x.Value.DateBegin < itemC.Value.SettlementPeriodDateEnd)
                        .ToDictionary(d => d.Key, d => d.Value);
                    var disconect = eventDevice.Where(x => x.Value.TContent.Contains("Communication off".ToUpper())
                     && x.Value.DateBegin > itemC.Value.SettlementPeriodDateBegin
                    && x.Value.DateBegin < itemC.Value.SettlementPeriodDateEnd)
                        .ToDictionary(d => d.Key, d => d.Value);
                    var moneyRetracted = eventDevice.Where(x => x.Value.TContent.Contains("Retract")
                     && x.Value.DateBegin > itemC.Value.SettlementPeriodDateBegin
                    && x.Value.DateBegin < itemC.Value.SettlementPeriodDateEnd)
                        .ToDictionary(d => d.Key, d => d.Value);
                    var withdrawalStuck = eventDevice.Where(x => x.Value.TContent.Contains("Withdrawal")
                     && x.Value.DateBegin > itemC.Value.SettlementPeriodDateBegin
                    && x.Value.DateBegin < itemC.Value.SettlementPeriodDateEnd)
                        .ToDictionary(d => d.Key, d => d.Value);
                    var depositStuck = eventDevice.Where(x => x.Value.TContent.Contains("Deposit")
                     && x.Value.DateBegin > itemC.Value.SettlementPeriodDateBegin
                    && x.Value.DateBegin < itemC.Value.SettlementPeriodDateEnd)
                        .ToDictionary(d => d.Key, d => d.Value);

                    int timesOpenTheCashDrawer = openTheCashDrawer.Count();
                    int timesOpenTechnicalChamber = openTechnicalChamber.Count();
                    int timesReboot = reboot.Count();
                    int timesDisconect = disconect.Count();
                    int timesMoneyTracted = moneyRetracted.Count();
                    int timesWithdrawalStuck = withdrawalStuck.Count();
                    int timesDepositStuck = depositStuck.Count();


                    worksheet.Cells["A1"].Value = "Nội dung";
                    worksheet.Cells["B1"].Value = "ATMID";
                    worksheet.Cells["C1"].Value = "Ngày tiếp quỹ";
                    worksheet.Cells["D1"].Value = "Ngày kiểm quỹ";
                    worksheet.Cells["E1"].Value = "Số lần";
                    worksheet.Cells["F1"].Value = "Date time";
                    worksheet.Cells["G1"].Value = "Hành động";
                    worksheet.Cells["H1"].Value = "Trace ID";
                    worksheet.Cells["I1"].Value = "Số tiền thu hồi của GD";
                    int mrg = (timesOpenTheCashDrawer > 1 ? timesOpenTheCashDrawer : 1)
                        + (timesOpenTechnicalChamber > 1 ? timesOpenTechnicalChamber : 1) +
                        (timesReboot > 1 ? timesReboot : 1) +
                       (timesDisconect > 1 ? timesDisconect : 1) +
                        (timesMoneyTracted > 1 ? timesMoneyTracted : 1) +
                        (timesWithdrawalStuck > 1 ? timesWithdrawalStuck : 1) +
                        (timesDepositStuck > 1 ? timesDepositStuck : 1);
                    int mrgE = index + mrg - 1;
                    using (ExcelRange rng = worksheet.Cells[string.Format("B{0}:B{1}", index, mrgE)])
                    {
                        rng.Merge = true;
                        rng.Value = atmID;
                    }
                    using (ExcelRange rng = worksheet.Cells[string.Format("C{0}:C{1}", index, mrgE)])
                    {
                        rng.Merge = true;
                        rng.Value = itemC.Value.SettlementPeriodDateBegin.ToString();
                    }
                    using (ExcelRange rng = worksheet.Cells[string.Format("D{0}:D{1}", index, mrgE)])
                    {
                        rng.Merge = true;
                        rng.Value = itemC.Value.SettlementPeriodDateEnd.ToString();
                    }
                    //DRAW DATA
                    //Bao nhiêu lần mở cửa khoang tiền?
                    int temp = index;
                    worksheet = DrawLoop(worksheet, ref temp, openTheCashDrawer, "Bao nhiêu lần mở cửa khoang tiền?", atmID
                        , itemC.Value.SettlementPeriodDateBegin, itemC.Value.SettlementPeriodDateEnd);

                    //Bao nhiêu lần mở cửa khoang kỹ thuật? 
                    worksheet = DrawLoop(worksheet, ref temp, openTechnicalChamber, "Bao nhiêu lần mở cửa khoang kỹ thuật?", atmID
                        , itemC.Value.SettlementPeriodDateBegin, itemC.Value.SettlementPeriodDateEnd);

                    //Bao nhiêu lần máy khởi động lại ?
                    worksheet = DrawLoop(worksheet, ref temp, reboot, "Bao nhiêu lần máy khởi động lại ?", atmID
                        , itemC.Value.SettlementPeriodDateBegin, itemC.Value.SettlementPeriodDateEnd);

                    //Bao nhiêu lần mất mạng
                    worksheet = DrawLoop(worksheet, ref temp, disconect, "Bao nhiêu lần mất mạng?", atmID
                        , itemC.Value.SettlementPeriodDateBegin, itemC.Value.SettlementPeriodDateEnd);

                    //Bao nhiêu lần tiền bị thu hồi?
                    worksheet = DrawLoop(worksheet, ref temp, moneyRetracted, "Bao nhiêu lần tiền bị thu hồi?", atmID
                        , itemC.Value.SettlementPeriodDateBegin, itemC.Value.SettlementPeriodDateEnd);

                    //Bao nhiêu lần rút tiền bị kẹt?
                    worksheet = DrawLoop(worksheet, ref temp, depositStuck, "Bao nhiêu lần rút tiền bị kẹt?", atmID
                        , itemC.Value.SettlementPeriodDateBegin, itemC.Value.SettlementPeriodDateEnd);

                    //Bao nhiêu lần nộp tiền bị kẹt?
                    worksheet = DrawLoop(worksheet, ref temp, withdrawalStuck, "Bao nhiêu lần nộp tiền bị kẹt?", atmID
                        , itemC.Value.SettlementPeriodDateBegin, itemC.Value.SettlementPeriodDateEnd);

                    using (ExcelRange rng = worksheet.Cells[string.Format("A{0}:I{1}", index, mrgE)])
                    {
                        rng.Style.Border.Top.Style = ExcelBorderStyle.Thin;
                        rng.Style.Border.Bottom.Style = ExcelBorderStyle.Thin;
                        rng.Style.Border.Left.Style = ExcelBorderStyle.Thin;
                        rng.Style.Border.Right.Style = ExcelBorderStyle.Thin;

                        rng.Style.Border.Top.Color.SetColor(Color.Black);
                        rng.Style.Border.Bottom.Color.SetColor(Color.Black);
                        rng.Style.Border.Left.Color.SetColor(Color.Black);
                        rng.Style.Border.Right.Color.SetColor(Color.Black);
                    }
                    index = mrgE + 2;
                }


                var allCells = worksheet.Cells[1, 1, worksheet.Dimension.End.Row, worksheet.Dimension.End.Column];
                allCells.AutoFitColumns();
                //allCells.Style.Border.Top.Style = ExcelBorderStyle.Thin;
                //allCells.Style.Border.Bottom.Style = ExcelBorderStyle.Thin;
                //allCells.Style.Border.Left.Style = ExcelBorderStyle.Thin;
                //allCells.Style.Border.Right.Style = ExcelBorderStyle.Thin;

                //allCells.Style.Border.Top.Color.SetColor(Color.Black);
                //allCells.Style.Border.Bottom.Color.SetColor(Color.Black);
                //allCells.Style.Border.Left.Color.SetColor(Color.Black);
                //allCells.Style.Border.Right.Color.SetColor(Color.Black);
                allCells.Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;
                allCells.Style.VerticalAlignment = ExcelVerticalAlignment.Center;
                allCells.Style.WrapText = true;
            }
            catch (Exception e)
            {
                throw e;
            }
            return worksheet;
        }

        private ExcelWorksheet DrawLoop(ExcelWorksheet worksheet, ref int index,
            Dictionary<DateTime, TransactionEvent> transactionEvent, string title, string atmID,
            DateTime begin, DateTime end)
        {
            try
            {
                int times = transactionEvent.Count();
                int indexATMID = index + times;
                using (ExcelRange rng = worksheet.Cells[string.Format("A{0}:A{1}", index, times <= 1 ? index : indexATMID - 1)])
                {
                    rng.Merge = true;
                    rng.Value = title;
                }
                using (ExcelRange rng = worksheet.Cells[string.Format("E{0}:E{1}", index, times <= 1 ? index : indexATMID - 1)])
                {
                    rng.Merge = true;
                    rng.Value = times;

                }

                for (int i = 0; i < transactionEvent.Count; i++)
                {
                    worksheet.Cells[index + i, 6].Style.Numberformat.Format = formatDate;
                    worksheet.Cells[index + i, 6].Value = transactionEvent.ToArray()[i].Value.DateBegin;
                    worksheet.Cells[index + i, 7].Value = transactionEvent.ToArray()[i].Value.TContent;
                    worksheet.Cells[index + i, 8].Value = "";
                    worksheet.Cells[index + i, 9].Value = "";
                }
                index = times <= 1 ? index + 1 : indexATMID;

            }
            catch (Exception ex)
            {
                throw ex;
            }

            return worksheet;
        }

        private ExcelWorksheet DrawGDTC(ExcelWorksheet worksheet, Dictionary<DateTime, Transaction> ListTransaction, Dictionary<DateTime, Cycle> cycles)
        {
            try
            {


                cycles = cycles.OrderBy(x => x.Value.DateBegin).ToDictionary(d => d.Key, d => d.Value);
                int index = 1;

                //DRAW CHUDE
                using (ExcelRange rng = worksheet.Cells["A1:Z2"])
                {
                    rng.Style.Fill.PatternType = OfficeOpenXml.Style.ExcelFillStyle.Solid;
                    rng.Style.Fill.BackgroundColor.SetColor(Color.FromArgb(252, 228, 214));
                    rng.Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;
                    rng.Style.VerticalAlignment = ExcelVerticalAlignment.Center;
                    rng.Style.Font.Bold = true;
                }


                using (ExcelRange rng = worksheet.Cells[string.Format("A{0}:A{1}", index, index + 1)])
                {
                    rng.Merge = true;
                    rng.Value = "TRANNUMBER";
                }
                using (ExcelRange rng = worksheet.Cells[string.Format("B{0}:B{1}", index, index + 1)])
                {
                    rng.Merge = true;
                    rng.Value = "TRANTYPE";
                }
                using (ExcelRange rng = worksheet.Cells[string.Format("C{0}:C{1}", index, index + 1)])
                {
                    rng.Merge = true;
                    rng.Value = "STATUS";
                }
                using (ExcelRange rng = worksheet.Cells[string.Format("D{0}:D{1}", index, index + 1)])
                {
                    rng.Merge = true;
                    rng.Value = "ATMID";
                }
                worksheet.Cells[string.Format("E{0}", index)].Value = "Ngày tiếp quỹ";
                worksheet.Cells[string.Format("E{0}", index + 1)].Value = "DATE/TIME";

                worksheet.Cells[string.Format("F{0}", index)].Value = "Ngày tiếp quỹ";
                worksheet.Cells[string.Format("F{0}", index + 1)].Value = "DATE/TIME";

                worksheet.Cells[string.Format("G{0}", index)].Value = "Ngày kiểm quỹ";
                worksheet.Cells[string.Format("G{0}", index + 1)].Value = "DATE/TIME";

                using (ExcelRange rng = worksheet.Cells[string.Format("G{0}:G{1}", index, index + 1)])
                {
                    rng.Merge = true;
                    rng.Value = "SỐ THẺ";
                }
                using (ExcelRange rng = worksheet.Cells[string.Format("H{0}:H{1}", index, index + 1)])
                {
                    rng.Merge = true;
                    rng.Value = "DATA INPUT(SỐ THẺ/CMT/CCCD)";
                }
                worksheet.Cells[string.Format("I{0}", index)].Value = "Ngày giao dịch";
                worksheet.Cells[string.Format("I{0}", index + 1)].Value = "DATE/TIME";

                using (ExcelRange rng = worksheet.Cells[string.Format("J{0}:J{1}", index, index + 1)])
                {
                    rng.Merge = true;
                    rng.Value = "SỐ TIỀN";
                }

                worksheet.Cells[string.Format("K{0}:L{0}", index)].Merge = true;
                worksheet.Cells[string.Format("K{0}:L{0}", index, index + 1)].Value = "500K";
                worksheet.Cells[string.Format("K{0}", index + 1)].Value = "SUCCESS";
                worksheet.Cells[string.Format("L{0}", index + 1)].Value = "RETRACTED";

                worksheet.Cells[string.Format("M{0}:N{0}", index)].Merge = true;
                worksheet.Cells[string.Format("M{0}:N{0}", index)].Value = "200K";
                worksheet.Cells[string.Format("M{0}", index + 1)].Value = "SUCCESS";
                worksheet.Cells[string.Format("N{0}", index + 1)].Value = "RETRACTED";

                worksheet.Cells[string.Format("O{0}:P{0}", index)].Merge = true;
                worksheet.Cells[string.Format("O{0}:P{0}", index)].Value = "100K";
                worksheet.Cells[string.Format("O{0}", index + 1)].Value = "SUCCESS";
                worksheet.Cells[string.Format("P{0}", index + 1)].Value = "RETRACTED";

                worksheet.Cells[string.Format("Q{0}:R{0}", index)].Merge = true;
                worksheet.Cells[string.Format("Q{0}:R{0}", index)].Value = "50K";
                worksheet.Cells[string.Format("Q{0}", index + 1)].Value = "SUCCESS";
                worksheet.Cells[string.Format("R{0}", index + 1)].Value = "RETRACTED";

                worksheet.Cells[string.Format("S{0}:T{0}", index)].Merge = true;
                worksheet.Cells[string.Format("S{0}:T{0}", index)].Value = "20K";
                worksheet.Cells[string.Format("S{0}", index + 1)].Value = "SUCCESS";
                worksheet.Cells[string.Format("T{0}", index + 1)].Value = "RETRACTED";

                worksheet.Cells[string.Format("U{0}:V{0}", index)].Merge = true;
                worksheet.Cells[string.Format("U{0}:V{0}", index)].Value = "10K";
                worksheet.Cells[string.Format("U{0}", index + 1)].Value = "SUCCESS";
                worksheet.Cells[string.Format("V{0}", index + 1)].Value = "RETRACTED";

                using (ExcelRange rng = worksheet.Cells[string.Format("W{0}:W{1}", index, index + 1)])
                {
                    rng.Merge = true;
                    rng.Value = "Unkown";
                }

                using (ExcelRange rng = worksheet.Cells[string.Format("X{0}:X{1}", index, index + 1)])
                {
                    rng.Merge = true;
                    rng.Value = "MÃ LỖI (nếu có)";
                }
                using (ExcelRange rng = worksheet.Cells[string.Format("Y{0}:Y{1}", index, index + 1)])
                {
                    rng.Merge = true;
                    rng.Value = "WORDFLOW";
                }

                using (ExcelRange rng = worksheet.Cells[string.Format("Z{0}:Z{1}", index, index + 1)])
                {
                    rng.Merge = true;
                    rng.Value = "LOG JNT (chỉ lấy log với các GD không thành công)";
                }
                //DRAW DATA
                var trans = ListTransaction.ToArray();
                int indexData = index + 2;
                for (int j = 0; j < trans.Count(); j++)
                {
                    var itemTrans = trans[j].Value;
                    var cycleOfTransction = cycles.Where(x => x.Value.SettlementPeriodDateBegin <= itemTrans.DateBegin
                    && x.Value.SettlementPeriodDateEnd >= itemTrans.DateBegin
                    && itemTrans.Terminal.Contains(x.Value.TerminalID)).OrderBy(x => x.Value.SettlementPeriodDateBegin).LastOrDefault().Value;
                    worksheet.Cells[indexData, index].Value = "";
                    worksheet.Cells[indexData, index + 1].Value = itemTrans.Type;
                    worksheet.Cells[indexData, index + 2].Value = itemTrans.Status;
                    worksheet.Cells[indexData, index + 3].Value = itemTrans.Terminal;
                    worksheet.Cells[indexData, index + 4].Value = cycleOfTransction != null ? cycleOfTransction.SettlementPeriodDateBegin.ToString() : "";
                    worksheet.Cells[indexData, index + 5].Value = cycleOfTransction != null ? cycleOfTransction.SettlementPeriodDateEnd.ToString() : "";
                    worksheet.Cells[indexData, index + 6].Value = itemTrans.CardType == Transaction.CardTypes.CardLess ? "CardLess" : itemTrans.CardNumber;
                    worksheet.Cells[indexData, index + 7].Value = itemTrans.DataInput;
                    worksheet.Cells[indexData, index + 8].Value = itemTrans.DateBegin;
                    worksheet.Cells[indexData, index + 8].Style.Numberformat.Format = "MM-dd-yyyy HH:mm:ss";

                    worksheet.Cells[indexData, index + 9].Value = Math.Abs(itemTrans.Value_500K * 500000) + Math.Abs(itemTrans.Value_200K * 200000) +
                    Math.Abs(itemTrans.Value_100K * 100000) + Math.Abs(itemTrans.Value_50K * 50000) + Math.Abs(itemTrans.Value_20K * 20000) +
                    Math.Abs(itemTrans.Value_10K * 10000);
                    worksheet.Cells[indexData, index + 10].Value = Math.Abs(itemTrans.Value_500K);
                    worksheet.Cells[indexData, index + 11].Value = 0;
                    worksheet.Cells[indexData, index + 12].Value = Math.Abs(itemTrans.Value_200K);
                    worksheet.Cells[indexData, index + 13].Value = 0;
                    worksheet.Cells[indexData, index + 14].Value = Math.Abs(itemTrans.Value_10K);
                    worksheet.Cells[indexData, index + 15].Value = 0;
                    worksheet.Cells[indexData, index + 16].Value = Math.Abs(itemTrans.Value_50K);
                    worksheet.Cells[indexData, index + 17].Value = 0;
                    worksheet.Cells[indexData, index + 18].Value = Math.Abs(itemTrans.Value_20K);
                    worksheet.Cells[indexData, index + 19].Value = 0;
                    worksheet.Cells[indexData, index + 20].Value = Math.Abs(itemTrans.Value_10K);
                    worksheet.Cells[indexData, index + 21].Value = 0;
                    worksheet.Cells[indexData, index + 22].Value = Math.Abs(itemTrans.Rejects);
                    worksheet.Cells[indexData, index + 23].Value = 0;
                    worksheet.Cells[indexData, index + 24].Style.HorizontalAlignment = ExcelHorizontalAlignment.Left;
                    worksheet.Cells[indexData, index + 24].Value = itemTrans.FullFollow;
                    //worksheet.Cells[indexData, index + 25].Value = "";
                    indexData++;
                }

                var allCells = worksheet.Cells[1, 1, worksheet.Dimension.End.Row, worksheet.Dimension.End.Column];
                allCells.AutoFitColumns();
                allCells.Style.Border.Top.Style = ExcelBorderStyle.Thin;
                allCells.Style.Border.Bottom.Style = ExcelBorderStyle.Thin;
                allCells.Style.Border.Left.Style = ExcelBorderStyle.Thin;
                allCells.Style.Border.Right.Style = ExcelBorderStyle.Thin;

                allCells.Style.Border.Top.Color.SetColor(Color.Black);
                allCells.Style.Border.Bottom.Color.SetColor(Color.Black);
                allCells.Style.Border.Left.Color.SetColor(Color.Black);
                allCells.Style.Border.Right.Color.SetColor(Color.Black);
                allCells.Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;
                allCells.Style.VerticalAlignment = ExcelVerticalAlignment.Center;

                allCells.Style.WrapText = true;
            }
            catch (Exception e)
            {
                throw e;
            }
            return worksheet;
        }


    }
}
