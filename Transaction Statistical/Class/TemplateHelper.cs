﻿using OfficeOpenXml;
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
        public void CanQuyTheoCouterTrenMay(string WorksheetsName, TableStyles tableStyles)
        {
            try
            {

                this.excelPackage.Workbook.Worksheets.Add(WorksheetsName);
                var lastWS = excelPackage.Workbook.Worksheets.Last();
                lastWS = DrawCounter(lastWS, 1000);
                this.excelPackage.Save();

            }
            catch (Exception e)
            {
                throw e;
            }
        }
        private ExcelWorksheet DrawCounter(ExcelWorksheet worksheet, long numberATM)
        {
            try
            {

                //DRAW CHUDE
                using (ExcelRange rng = worksheet.Cells["A1:D2"])
                {
                    rng.Style.Fill.PatternType = OfficeOpenXml.Style.ExcelFillStyle.Solid;
                    rng.Style.Fill.BackgroundColor.SetColor(Color.FromArgb(248, 203, 173));
                    rng.Merge = true;
                    rng.Value = "BẢNG THỐNG KÊ COUNTER TRÊN MỖI CHU KỲ";
                }
                int index = 4;
                for (long atm = 0; atm < numberATM; atm++)
                {
                    int headerV = index + 1;
                    int deno500 = index + 2;
                    int deno200 = index + 3;
                    int deno100 = index + 4;
                    int deno50 = index + 5;
                    int deno20 = index + 6;
                    int deno10 = index + 7;
                    int denoUnkown = index + 8;
                    //MENH GIA
                    using (ExcelRange rng = worksheet.Cells[string.Format("A{0}:L{1}", index, headerV)])
                    {
                        rng.Style.Fill.PatternType = OfficeOpenXml.Style.ExcelFillStyle.Solid;
                        rng.Style.Fill.BackgroundColor.SetColor(Color.FromArgb(255, 255, 0));
                    }


                    using (ExcelRange rng = worksheet.Cells[string.Format("A{0}:L{1}", index, denoUnkown)])
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

                    //MENH GIA
                    using (ExcelRange rng = worksheet.Cells[string.Format("A{0}:A{1}", index, headerV)])
                    {
                        rng.Merge = true;
                        rng.Value = "Mệnh Giá";

                    }
                    worksheet.Cells[string.Format("A{0}", deno500)].Value = "500,000 VND";
                    worksheet.Cells[string.Format("A{0}", deno200)].Value = "200,000 VND";
                    worksheet.Cells[string.Format("A{0}", deno100)].Value = "100,000 VND";
                    worksheet.Cells[string.Format("A{0}", deno50)].Value = "50,000 VND";
                    worksheet.Cells[string.Format("A{0}", deno20)].Value = "20,000 VND";
                    worksheet.Cells[string.Format("A{0}", deno10)].Value = "10,000 VND";
                    worksheet.Cells[string.Format("A{0}", denoUnkown)].Value = "unknow";
                    //ATM ID
                    using (ExcelRange rng = worksheet.Cells[string.Format("B{0}:B{1}", index, headerV)])
                    {
                        rng.Merge = true;

                        rng.Value = "ATM ID";
                    }
                    //NGAY GIO TIEP QUY
                    using (ExcelRange rng = worksheet.Cells[string.Format("C{0}:D{1}", index, index)])
                    {
                        rng.Merge = true;

                        rng.Value = "Ngày giờ tiếp quỹ";
                    }
                    worksheet.Cells[string.Format("C{0}", headerV)].Value = "Date";
                    worksheet.Cells[string.Format("D{0}", headerV)].Value = "Time";
                    //NGAY GIO KIEM QUY
                    using (ExcelRange rng = worksheet.Cells[string.Format("E{0}:F{1}", index, index)])
                    {
                        rng.Merge = true;
                        rng.Value = "Ngày giờ kiểm quỹ";
                    }
                    worksheet.Cells[string.Format("E{0}", headerV)].Value = "Date";
                    worksheet.Cells[string.Format("F{0}", headerV)].Value = "Time";
                    //COUNTER TREN MAY
                    using (ExcelRange rng = worksheet.Cells[string.Format("G{0}:I{1}", index, index)])
                    {
                        rng.Merge = true;

                        rng.Value = "Counter trên máy";
                    }
                    worksheet.Cells[string.Format("G{0}", headerV)].Value = "Initial";
                    worksheet.Cells[string.Format("H{0}", headerV)].Value = "Remaining";
                    worksheet.Cells[string.Format("I{0}", headerV)].Value = "Retract";
                    //COUNTER TINH THEO GIAO DICH
                    using (ExcelRange rng = worksheet.Cells[string.Format("J{0}:K{1}", index, index)])
                    {
                        rng.Merge = true;

                        rng.Value = "Counter tính theo các giao dịch";
                    }
                    worksheet.Cells[string.Format("J{0}", headerV)].Value = "with/de";
                    worksheet.Cells[string.Format("K{0}", headerV)].Value = "Retract";
                    //LECH COUNTER
                    using (ExcelRange rng = worksheet.Cells[string.Format("L{0}:L{1}", index, headerV)])
                    {
                        rng.Merge = true;

                        rng.Value = "lệch counter trên máy";
                    }

                    //DRAW DATA
                    //ATM_ID
                    using (ExcelRange rng = worksheet.Cells[string.Format("B{0}:B{1}", deno500, denoUnkown)])
                    {
                        rng.Merge = true;
                    }
                    //TQ_Date
                    using (ExcelRange rng = worksheet.Cells[string.Format("C{0}:C{1}", deno500, denoUnkown)])
                    {
                        rng.Merge = true;
                    }
                    //Q_Time
                    using (ExcelRange rng = worksheet.Cells[string.Format("D{0}:D{1}", deno500, denoUnkown)])
                    {
                        rng.Merge = true;
                    }
                    //KQ_Date
                    using (ExcelRange rng = worksheet.Cells[string.Format("E{0}:E{1}", deno500, denoUnkown)])
                    {
                        rng.Merge = true;
                    }
                    //KQ_Time
                    using (ExcelRange rng = worksheet.Cells[string.Format("F{0}:F{1}", deno500, denoUnkown)])
                    {
                        rng.Merge = true;
                    }


                    index = denoUnkown + 3;
                }
                var allCells = worksheet.Cells[1, 1, worksheet.Dimension.End.Row, worksheet.Dimension.End.Column];
                var cellFont = allCells.Style.Font;
                cellFont.SetFromFont(new Font("Calibri", 11));

            }
            catch (Exception e)
            {
                throw e;
            }
            return worksheet;
        }

        public void BaoCaoGiaoDichBatThuong(string WorksheetsName, TableStyles tableStyles)
        {
            this.excelPackage.Workbook.Worksheets.Add(WorksheetsName);
            var lastWS = excelPackage.Workbook.Worksheets.Last();
            lastWS = DrawHDBT(lastWS);
            this.excelPackage.Save();
        }

        private ExcelWorksheet DrawHDBT(ExcelWorksheet worksheet)
        {
            try
            {
                int index = 2;
                int timesOpenTheCashDrawer = 5;
                int timesOpenTechnicalChamber = 8;
                int timesReboot = 5;
                int timesDisconect = 5;
                int timesMoneyWithdrawn = 5;
                int timesWithdrawalStuck = 5;
                int timesDepositStuck = 5;

                //DRAW CHUDE
                using (ExcelRange rng = worksheet.Cells["A1:I1"])
                {
                    rng.Style.Fill.PatternType = OfficeOpenXml.Style.ExcelFillStyle.Solid;
                    rng.Style.Fill.BackgroundColor.SetColor(Color.FromArgb(252, 228, 214));
                    rng.Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;
                    rng.Style.VerticalAlignment = ExcelVerticalAlignment.Center;
                }
                worksheet.Cells["A1"].Value = "Nội dung";
                worksheet.Cells["B1"].Value = "ATMID";
                worksheet.Cells["C1"].Value = "Ngày tiếp quỹ";
                worksheet.Cells["D1"].Value = "Ngày kiểm quỹ";
                worksheet.Cells["E1"].Value = "Số lần";
                worksheet.Cells["F1"].Value = "Date time";
                worksheet.Cells["G1"].Value = "Hành động";
                worksheet.Cells["H1"].Value = "Trace ID";
                worksheet.Cells["I1"].Value = "Số tiền thu hồi của GD";

                //DRAW DATA
                //Bao nhiêu lần mở cửa khoang tiền?
                worksheet = DrawLoop(worksheet, ref index, timesOpenTheCashDrawer, "Bao nhiêu lần mở cửa khoang tiền?");

                //Bao nhiêu lần mở cửa khoang kỹ thuật? 
                worksheet = DrawLoop(worksheet, ref index, timesOpenTechnicalChamber, "Bao nhiêu lần mở cửa khoang kỹ thuật?");

                //Bao nhiêu lần máy khởi động lại ?
                worksheet = DrawLoop(worksheet, ref index, timesReboot, "Bao nhiêu lần máy khởi động lại ?");

                //Bao nhiêu lần mất mạng
                worksheet = DrawLoop(worksheet, ref index, timesDisconect, "Bao nhiêu lần mất mạng?");

                //Bao nhiêu lần tiền bị thu hồi?
                worksheet = DrawLoop(worksheet, ref index, timesMoneyWithdrawn, "Bao nhiêu lần tiền bị thu hồi?");

                //Bao nhiêu lần rút tiền bị kẹt?
                worksheet = DrawLoop(worksheet, ref index, timesDepositStuck, "Bao nhiêu lần rút tiền bị kẹt?");

                //Bao nhiêu lần nộp tiền bị kẹt?
                worksheet = DrawLoop(worksheet, ref index, timesWithdrawalStuck, "Bao nhiêu lần nộp tiền bị kẹt?");

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
        private ExcelWorksheet DrawLoop(ExcelWorksheet worksheet, ref int index, int times, string title)
        {
            try
            {
                int indexATMID = index + times - 1;
                using (ExcelRange rng = worksheet.Cells[string.Format("A{0}:A{1}", index, times == 0 ? index : indexATMID + 1)])
                {
                    rng.Merge = true;
                    rng.Value = title;

                }
                using (ExcelRange rng = worksheet.Cells[string.Format("E{0}:E{1}", index, times == 0 ? index : indexATMID + 1)])
                {
                    rng.Merge = true;
                    rng.Value = times;

                }
                for (int i = index; i <= indexATMID; i++)
                {
                    worksheet.Cells[i, 2].Value = "99100001";

                    worksheet.Cells[i, 3].Style.Numberformat.Format = formatDate;
                    worksheet.Cells[i, 3].Value = "01/24/2019  10:19:26 SA";

                    worksheet.Cells[i, 4].Style.Numberformat.Format = formatDate;
                    worksheet.Cells[i, 4].Value = "01/26/2019  9:19:16 SA";

                    worksheet.Cells[i, 6].Style.Numberformat.Format = formatDate;
                    worksheet.Cells[i, 6].Value = "01/26/2019  9:19:16 SA";

                    worksheet.Cells[i, 7].Value = "Safe Door : Opened";
                    worksheet.Cells[i, 8].Value = "1099339359";
                    worksheet.Cells[i, 9].Value = "5000000";
                }
                index += times + 1;
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return worksheet;
        }

        public void BaoCaoGiaoDichKhongThanhCong(string WorksheetsName, TableStyles tableStyles)
        {
            this.excelPackage.Workbook.Worksheets.Add(WorksheetsName);
            var lastWS = excelPackage.Workbook.Worksheets.Last();
            lastWS = DrawGDKTC(lastWS);
            this.excelPackage.Save();
        }

        private ExcelWorksheet DrawGDKTC(ExcelWorksheet worksheet)
        {
            try
            {
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
                int indexData = index + 2;
                for (int j = 0; j < 1; j++)
                {
                    var detail = "";

                    worksheet.Cells[indexData, index].Value = "";
                    worksheet.Cells[indexData, index + 1].Value = "";
                    worksheet.Cells[indexData, index + 2].Value = "";
                    worksheet.Cells[indexData, index + 3].Value = "";
                    worksheet.Cells[indexData, index + 4].Value = "";
                    worksheet.Cells[indexData, index + 5].Value = "";
                    worksheet.Cells[indexData, index + 6].Value = "";
                    worksheet.Cells[indexData, index + 7].Value = "";
                    worksheet.Cells[indexData, index + 8].Value = "";
                    worksheet.Cells[indexData, index + 8].Style.Numberformat.Format = "mm/dd/yyyy hh:mm:ss AM/PM";

                    worksheet.Cells[indexData, index + 9].Value = "";
                    worksheet.Cells[indexData, index + 10].Value = "";
                    worksheet.Cells[indexData, index + 11].Value = "";
                    worksheet.Cells[indexData, index + 12].Value = "";
                    worksheet.Cells[indexData, index + 13].Value = "";
                    worksheet.Cells[indexData, index + 14].Value = "";
                    worksheet.Cells[indexData, index + 15].Value = "";
                    worksheet.Cells[indexData, index + 16].Value = "";
                    worksheet.Cells[indexData, index + 17].Value = "";
                    worksheet.Cells[indexData, index + 18].Value = "";
                    worksheet.Cells[indexData, index + 19].Value = "";
                    worksheet.Cells[indexData, index + 20].Value = "";
                    worksheet.Cells[indexData, index + 21].Value = "";
                    worksheet.Cells[indexData, index + 22].Value = "";
                    worksheet.Cells[indexData, index + 23].Value = "";
                    //worksheet.Cells[indexData, index + 24].Value = string.Join("->", terminal.transactions[i].work_flow);
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
