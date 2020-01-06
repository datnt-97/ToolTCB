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
            //BaoCaoGiaoDichEmptyCassett,
            //BaoCaoGiaoDichEmptyCassettTheoChuKy,
            BaoCaoGiaoDichTaiChinh,
            BaoCaoGiaoDichTaiChinhKhongThanhCong,
            BaoCaoGiaoDichTaiChinhBatThuong,
            BaoCaoHoatDongBatThuong,
            BaoCaoHoatDongBatThuongTheoChuKy,
        }
        private Color Lightskyblue = Color.FromArgb(230, 230, 250);
        private Color Backgroud = Color.FromArgb(248, 203, 173);
        //private Color Lightskyblue = Color.FromArgb(135, 206, 250);
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
        public void BaoCaoHoatDongBatThuong(string WorksheetsName, TableStyles tableStyles, Dictionary<string, Dictionary<DateTime, object>> ListTransaction, Dictionary<string, string> Template_EventDevice, bool isCycle)
        {
            try
            {


                this.excelPackage.Workbook.Worksheets.Add(WorksheetsName);
                var lastWS = excelPackage.Workbook.Worksheets.Last();
                int index = 2;
                //DRAW CHUDE
                using (ExcelRange rng = lastWS.Cells[string.Format("A1:{0}1", isCycle ? "I" : "H")])
                {
                    rng.Style.Fill.PatternType = OfficeOpenXml.Style.ExcelFillStyle.Solid;
                    rng.Style.Fill.BackgroundColor.SetColor(Backgroud);
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

                    var transaction = item.Value.Where(i => i.Value is Transaction).ToDictionary(d => d.Key, d => (Transaction)d.Value);

                    var cycles = item.Value.Where(x => x.Value is Cycle).ToDictionary(x => x.Key, x => (Cycle)x.Value);
                    var events = item.Value.Where(x => x.Value is TransactionEvent).ToDictionary(x => x.Key, x => (TransactionEvent)x.Value);

                    foreach (var trans in transaction.Select(x => x.Value.ListEvent))
                    {
                        var evs = trans.Where(ev => !events.ContainsKey(ev.Value.DateBegin)
                          && Template_EventDevice.ContainsKey(ev.Value.Name)).ToDictionary(d => d.Key, d => d.Value);
                        foreach (var ev in evs)
                        {
                            events.Add(ev.Key, ev.Value);
                        }
                    }

                    if (isCycle)
                    {
                        lastWS.Cells["A1"].Value = "Nội dung";
                        lastWS.Cells["B1"].Value = "ATMID";
                        lastWS.Cells["C1"].Value = "Ngày tiếp quỹ";
                        lastWS.Cells["D1"].Value = "Ngày kiểm quỹ";
                        lastWS.Cells["E1"].Value = "Số lần";
                        lastWS.Cells["F1"].Value = "Date time";
                        lastWS.Cells["G1"].Value = "Hành động";
                        lastWS.Cells["H1"].Value = "Trace ID";
                        lastWS.Cells["I1"].Value = "Số tiền thu hồi của GD";
                        foreach (var c in cycles)
                        {
                            lastWS = DrawHDBT(lastWS, events, c, item.Key, ref index, Template_EventDevice, isCycle);
                        }

                    }
                    else
                    {
                        lastWS.Cells["A1"].Value = "Nội dung";
                        lastWS.Cells["B1"].Value = "ATMID";
                        lastWS.Cells["C1"].Value = "Số lần";
                        lastWS.Cells["D1"].Value = "Date time";
                        lastWS.Cells["E1"].Value = "Hành động";
                        lastWS.Cells["F1"].Value = "Trace ID";
                        lastWS.Cells["G1"].Value = "Số tiền thu hồi của GD";

                        lastWS = DrawHDBT(lastWS, events, new KeyValuePair<DateTime, Cycle>(), item.Key, ref index, Template_EventDevice, false);
                    }
                    index++;
                }
                this.excelPackage.Save();
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public void BaoCaoGiaoDichTaiChinh(string WorksheetsName, TableStyles tableStyles, Dictionary<DateTime, Transaction> ListTransaction, Dictionary<DateTime, Cycle> cycles, Dictionary<string, string> Template_EventDevice)
        {
            this.excelPackage.Workbook.Worksheets.Add(WorksheetsName);
            var lastWS = excelPackage.Workbook.Worksheets.Last();
            lastWS = DrawGDTC(lastWS, ListTransaction, cycles, Template_EventDevice);
            this.excelPackage.Save();
        }



        public void BaoCaoGiaoDichEmptyCassett(string WorksheetsName, TableStyles tableStyles, Dictionary<string, Dictionary<DateTime, object>> ListTransaction, bool isCycle)
        {
            this.excelPackage.Workbook.Worksheets.Add(WorksheetsName);
            var lastWS = excelPackage.Workbook.Worksheets.Last();
            lastWS = DrawGDEmptyCassett(lastWS);
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
                    rng.Style.Fill.BackgroundColor.SetColor(Backgroud);
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
                        rng.Style.Fill.BackgroundColor.SetColor(Backgroud);
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
        private ExcelWorksheet DrawHDBT(ExcelWorksheet worksheet, Dictionary<DateTime, TransactionEvent> ListTransaction, KeyValuePair<DateTime, Cycle> Cycles, string atmID, ref int index, Dictionary<string, string> Template_EventDevice, bool isCycle)
        {
            try
            {
                int mgr = index;
                int mgr1 = index;
                if (isCycle)
                {

                    foreach (var dev in Template_EventDevice)
                    {
                        var itemEvent = ListTransaction.Where(x => x.Value.Name.Equals(dev.Key)
                        && x.Value.DateBegin >= Cycles.Value.SettlementPeriodDateBegin && x.Value.DateBegin <= Cycles.Value.SettlementPeriodDateEnd)
                            .ToDictionary(d => d.Key, d => d.Value);
                        worksheet = DrawLoop(worksheet, ref index, itemEvent, dev.Key, true);
                        mgr += itemEvent.Count() > 0 ? itemEvent.Count() : 1;
                    }
                    using (ExcelRange rng = worksheet.Cells[string.Format("C{0}:C{1}", mgr1, mgr - 1)])
                    {
                        rng.Merge = true;
                        rng.Value = Cycles.Value.SettlementPeriodDateBegin;
                        rng.Style.Numberformat.Format = formatDate;

                    }
                    using (ExcelRange rng = worksheet.Cells[string.Format("D{0}:D{1}", mgr1, mgr - 1)])
                    {
                        rng.Merge = true;
                        rng.Value = Cycles.Value.SettlementPeriodDateEnd;
                        rng.Style.Numberformat.Format = formatDate;
                    }
                    using (ExcelRange rng = worksheet.Cells[string.Format("A{0}:I{1}", mgr1, mgr - 1)])
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
                }
                else
                {

                    foreach (var dev in Template_EventDevice)
                    {
                        var itemEvent = ListTransaction.Where(x => x.Value.Name.Equals(dev.Key)).ToDictionary(d => d.Key, d => d.Value);

                        worksheet = DrawLoop(worksheet, ref index, itemEvent, dev.Key, false);

                        mgr += itemEvent.Count() > 0 ? itemEvent.Count() : 1;
                    }
                    using (ExcelRange rng = worksheet.Cells[string.Format("A{0}:H{1}", mgr1, mgr - 1)])
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
                }



                using (ExcelRange rng = worksheet.Cells[string.Format("B{0}:B{1}", mgr1, mgr - 1)])
                {
                    rng.Merge = true;
                    rng.Value = atmID;
                }

                var allCells = worksheet.Cells[1, 1, worksheet.Dimension.End.Row, worksheet.Dimension.End.Column];
                allCells.AutoFitColumns();

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
            Dictionary<DateTime, TransactionEvent> transactionEvent, string title, bool isCycle)
        {
            try
            {
                int indexOrigin = index;
                int times = transactionEvent.Count();
                int indexATMID = index + times;
                using (ExcelRange rng = worksheet.Cells[string.Format("A{0}:A{1}", index, times <= 1 ? index : indexATMID - 1)])
                {
                    rng.Merge = true;
                    rng.Value = title;
                }
                if (isCycle)
                {
                    using (ExcelRange rng = worksheet.Cells[string.Format("E{0}:E{1}", index, times <= 1 ? index : indexATMID - 1)])
                    {
                        rng.Merge = true;
                        rng.Value = times;

                    }
                }
                else
                {
                    using (ExcelRange rng = worksheet.Cells[string.Format("C{0}:C{1}", index, times <= 1 ? index : indexATMID - 1)])
                    {
                        rng.Merge = true;
                        rng.Value = times;

                    }
                }


                for (int i = 0; i < transactionEvent.Count; i++)
                {

                    var evt = transactionEvent.ToArray()[i].Value;
                    if (isCycle)
                    {

                        worksheet.Cells[index + i, 6].Style.Numberformat.Format = formatDate;
                        worksheet.Cells[index + i, 6].Value = evt.DateBegin;
                        worksheet.Cells[index + i, 7].Value = evt.TContent;
                        worksheet.Cells[index + i, 8].Value = string.IsNullOrEmpty(evt.TraceID) ? "-" : evt.TraceID;
                        worksheet.Cells[index + i, 9].Value = evt.Amount;
                        worksheet.Cells[index + i, 9].Style.Numberformat.Format = "###,###,##0.0";
                    }
                    else
                    {

                        worksheet.Cells[index + i, 4].Style.Numberformat.Format = formatDate;
                        worksheet.Cells[index + i, 4].Value = transactionEvent.ToArray()[i].Value.DateBegin;
                        worksheet.Cells[index + i, 5].Value = transactionEvent.ToArray()[i].Value.TContent;
                        //worksheet.Cells[index + i, 5].Value = "";
                        worksheet.Cells[index + i, 6].Value = string.IsNullOrEmpty(evt.TraceID) ? "-" : evt.TraceID;

                        worksheet.Cells[index + i, 7].Value = evt.Amount;
                        worksheet.Cells[index + i, 7].Style.Numberformat.Format = "###,###,##0.0";
                    }

                }
                index = times <= 1 ? index + 1 : indexATMID;

            }
            catch (Exception ex)
            {
                throw ex;
            }

            return worksheet;
        }

        private ExcelWorksheet DrawGDTC(ExcelWorksheet worksheet, Dictionary<DateTime, Transaction> ListTransaction, Dictionary<DateTime, Cycle> cycles, Dictionary<string, string> Template_EventDevice)
        {
            try
            {


                cycles = cycles.OrderBy(x => x.Value.DateBegin).ToDictionary(d => d.Key, d => d.Value);
                int index = 1;

                //DRAW CHUDE
                using (ExcelRange rng = worksheet.Cells["A1:Z2"])
                {
                    rng.Style.Fill.PatternType = OfficeOpenXml.Style.ExcelFillStyle.Solid;
                    rng.Style.Fill.BackgroundColor.SetColor(Backgroud);
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
                    var requestLast = itemTrans.ListRequest.Values.LastOrDefault();
                    var cycleOfTransction = cycles.Where(x => x.Value.SettlementPeriodDateBegin <= itemTrans.DateBegin
                    && x.Value.SettlementPeriodDateEnd >= itemTrans.DateBegin
                    && itemTrans.Terminal.Contains(x.Value.TerminalID)).OrderBy(x => x.Value.SettlementPeriodDateBegin).LastOrDefault().Value;
                    var lastBill = itemTrans.ListBills.OrderBy(x => x.Key).LastOrDefault();
                    worksheet.Cells[indexData, index].Value = lastBill.Value != null ? lastBill.Value.TranNo : "-";
                    worksheet.Cells[indexData, index + 1].Value = string.IsNullOrEmpty(itemTrans.Type) ? "N/A" : itemTrans.Type;
                    worksheet.Cells[indexData, index + 2].Value = requestLast != null ? requestLast.Status.ToString() : "";
                    worksheet.Cells[indexData, index + 3].Value = itemTrans.Terminal;
                    worksheet.Cells[indexData, index + 4].Value = cycleOfTransction != null ? cycleOfTransction.SettlementPeriodDateBegin.ToString() : "";
                    worksheet.Cells[indexData, index + 5].Value = cycleOfTransction != null ? cycleOfTransction.SettlementPeriodDateEnd.ToString() : "";
                    worksheet.Cells[indexData, index + 6].Value = itemTrans.CardType == Transaction.CardTypes.CardLess ? "CardLess" : itemTrans.CardNumber;
                    worksheet.Cells[indexData, index + 7].Value = itemTrans.DataInput;
                    worksheet.Cells[indexData, index + 8].Value = itemTrans.DateBegin;
                    worksheet.Cells[indexData, index + 8].Style.Numberformat.Format = "MM-dd-yyyy HH:mm:ss";

                    worksheet.Cells[indexData, index + 9].Value = Math.Abs(itemTrans.Amount);
                    worksheet.Cells[indexData, index + 9].Style.Numberformat.Format = "###,###,##0.0";

                    //if (itemTrans.ListEvent.Values.Where(x => x.Type == TransactionEvent.Events.CashRetracted).Count() > 0 || itemTrans.CardNumber.Contains("970407******6366"))
                    //{
                    //    int a = 0;
                    //}
                    if (itemTrans.ListEvent.Values.Where(e => Template_EventDevice.ContainsKey(e.Name)).Count() > 0)
                    {
                        using (ExcelRange rng = worksheet.Cells[string.Format("A{0}:Z{1}", indexData, indexData)])
                        {
                            rng.Style.Fill.PatternType = OfficeOpenXml.Style.ExcelFillStyle.Solid;
                            rng.Style.Fill.BackgroundColor.SetColor(Lightskyblue);
                        }
                    }
                    if (itemTrans.ListEvent.Values.Where(e => e.Type == TransactionEvent.Events.CashRetracted).Count() > 0)
                    {

                        worksheet.Cells[indexData, index + 10].Value = 0;
                        worksheet.Cells[indexData, index + 11].Value = Math.Abs(itemTrans.Value_500K);
                        worksheet.Cells[indexData, index + 12].Value = 0;
                        worksheet.Cells[indexData, index + 13].Value = Math.Abs(itemTrans.Value_200K);
                        worksheet.Cells[indexData, index + 14].Value = 0;
                        worksheet.Cells[indexData, index + 15].Value = Math.Abs(itemTrans.Value_100K);
                        worksheet.Cells[indexData, index + 16].Value = 0;
                        worksheet.Cells[indexData, index + 17].Value = Math.Abs(itemTrans.Value_50K);
                        worksheet.Cells[indexData, index + 18].Value = 0;
                        worksheet.Cells[indexData, index + 19].Value = Math.Abs(itemTrans.Value_20K);
                        worksheet.Cells[indexData, index + 20].Value = 0;
                        worksheet.Cells[indexData, index + 21].Value = Math.Abs(itemTrans.Value_10K);
                        worksheet.Cells[indexData, index + 22].Value = Math.Abs(itemTrans.Unknow);
                    }
                    else
                    {
                        worksheet.Cells[indexData, index + 10].Value = Math.Abs(itemTrans.Value_500K);
                        worksheet.Cells[indexData, index + 11].Value = 0;

                        worksheet.Cells[indexData, index + 12].Value = Math.Abs(itemTrans.Value_200K);
                        worksheet.Cells[indexData, index + 13].Value = 0;
                        worksheet.Cells[indexData, index + 14].Value = Math.Abs(itemTrans.Value_100K);
                        worksheet.Cells[indexData, index + 15].Value = 0;
                        worksheet.Cells[indexData, index + 16].Value = Math.Abs(itemTrans.Value_50K);
                        worksheet.Cells[indexData, index + 17].Value = 0;
                        worksheet.Cells[indexData, index + 18].Value = Math.Abs(itemTrans.Value_20K);
                        worksheet.Cells[indexData, index + 19].Value = 0;
                        worksheet.Cells[indexData, index + 20].Value = Math.Abs(itemTrans.Value_10K);
                        worksheet.Cells[indexData, index + 21].Value = 0;
                        worksheet.Cells[indexData, index + 22].Value = Math.Abs(itemTrans.Rejects);
                    }
                    worksheet.Cells[indexData, index + 23].Value = itemTrans.Error;

                    //worksheet.Cells[indexData, index + 24].Style.WrapText = true;
                    worksheet.Cells[indexData, index + 24].Style.HorizontalAlignment = ExcelHorizontalAlignment.Left;
                    worksheet.Cells[indexData, index + 24].Value = itemTrans.FullFollow;
                    //worksheet.Cells[indexData, index + 25].Value = requestLast != null && requestLast.Status == Status.Types.UnSucceeded ? itemTrans.TraceJournalFull : string.Empty;
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

        private ExcelWorksheet DrawGDEmptyCassett(ExcelWorksheet worksheet)
        {
            int index = 1;

            //DRAW CHUDE
            using (ExcelRange rng = worksheet.Cells["A1:N1"])
            {
                rng.Style.Fill.PatternType = OfficeOpenXml.Style.ExcelFillStyle.Solid;
                rng.Style.Fill.BackgroundColor.SetColor(Backgroud);
                rng.Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;
                rng.Style.VerticalAlignment = ExcelVerticalAlignment.Center;
                rng.Style.Font.Bold = true;
            }
            worksheet.Cells[1, 1].Value = "TRANNUMBER";
            worksheet.Cells[1, 2].Value = "ATMID";
            worksheet.Cells[1, 3].Value = "SỐ THẺ/CMT/CCCD";
            worksheet.Cells[1, 4].Value = "SỐ TÀI KHOẢN";
            worksheet.Cells[1, 5].Value = "DATE TIME";
            worksheet.Cells[1, 6].Value = "SỐ TIỀN";
            using (ExcelRange rng = worksheet.Cells["G1:J1"])
            {
                rng.Merge = true;
                rng.Value = "Số tờ  GD yêu cầu đánh lên";
            }
            using (ExcelRange rng = worksheet.Cells["K1:N1"])
            {
                rng.Merge = true;
                rng.Value = "Số tờ còn lại trong khay ở thời điểm empty cassette";
            }

            using (ExcelRange rng = worksheet.Cells["A1:N1"])
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

            var allCells = worksheet.Cells[1, 1, worksheet.Dimension.End.Row, worksheet.Dimension.End.Column];
            allCells.AutoFitColumns();

            allCells.Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;
            allCells.Style.VerticalAlignment = ExcelVerticalAlignment.Center;
            allCells.Style.WrapText = true;
            return worksheet;
        }
    }
}
