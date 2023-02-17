using DocumentFormat.OpenXml.Drawing.Charts;
using DocumentFormat.OpenXml.Spreadsheet;
using SpreadsheetLight;

namespace TEC_AL_0002.Controllers
{
    public class Functions
    {
        public static void file(string sucursal, string numCaja, string tasaDelDia)
        {
            string path = @"C:\Users\d.marcano\Desktop\plantilla.xlsx"; // Remplazar ruta, por una generica
            string fachaDeHoy = DateTime.Now.ToString();
            decimal roundTasaDelDia = Math.Round(Convert.ToDecimal(tasaDelDia), 2);

            SLDocument sl = new SLDocument();

            sl.SetColumnWidth("A", 26.5);
            sl.SetColumnWidth("B", 20);
            sl.SetColumnWidth("E", 15);
            sl.SetColumnWidth("F", 20);

            // Data Entry
            sl.SetCellValue("A4", "TIENDAS DAKA, C.A");
            sl.SetCellValue("A5", "J-408488906");
            sl.SetCellValue("B5", "CUADRE DE CAJA");

            sl.SetCellValue("E4", "SUCURSAL: ");
            sl.SetCellValue("E5", "FECHA: ");
            sl.SetCellValue("E6", "Nro CAJA: ");
            sl.SetCellValue("E7", "TASA DEL DIA: ");

            sl.SetCellValue("F4", sucursal); // Variable []
            sl.SetCellValue("F5", fachaDeHoy); // Variable [/] 
            sl.SetCellValue("F6", numCaja); // Variable []
            sl.SetCellValue("F7", roundTasaDelDia); // Variable []

            sl.SetCellValue("B9", "INGRESOS/COBROS");
            sl.SetCellValue("E9", "INGRESE");

            sl.SetCellValue("A10", "FORMA DE PAGO");
            sl.SetCellValue("B10", "TIPO DE PAGO");
            sl.SetCellValue("E10", "MONTO BS/USD");
            sl.SetCellValue("F10", " MONTO USD");

            sl.SetCellValue("A11", "DOLARES");
            sl.SetCellValue("B11", "Dolares");
            sl.SetCellValue("E11", " $232,83");
            sl.SetCellValue("F11", " $232,83");

            sl.SetCellValue("A12", "EFECTIVO 1 Bs");
            sl.SetCellValue("B12", "Efectivo");
            sl.SetCellValue("E12", "Bs.S5.000,00");
            sl.SetCellValue("F12", "$582,07");

            sl.SetCellValue("A13", "EUROS");
            sl.SetCellValue("B13", "Euros");
            sl.SetCellValue("E13", "$300,00");
            sl.SetCellValue("F13", "$300,00");

            sl.SetCellValue("A14", "PUNTO BANESCO");
            sl.SetCellValue("B14", "Tarjeta débito");
            sl.SetCellValue("E14", "Bs.S10.000,00");
            sl.SetCellValue("F14", "$1.164,14");

            sl.SetCellValue("A15", "TODOTICKET");
            sl.SetCellValue("B15", "Tarjeta débito");
            sl.SetCellValue("E15", " Bs.S-   ");
            sl.SetCellValue("F15", " $-   ");

            sl.SetCellValue("A16", "VISA ELECTRON BANESCO");
            sl.SetCellValue("B16", "Tarjeta débito");
            sl.SetCellValue("E16", " Bs.S-   ");
            sl.SetCellValue("F16", " $-   ");

            sl.SetCellValue("A17", "Punto venezuela");
            sl.SetCellValue("B17", "Tarjeta débito");
            sl.SetCellValue("E17", "Bs.S300,00");
            sl.SetCellValue("F17", "$34,92");

            sl.SetCellValue("A18", "TRANSFERENCIA BANESCO");
            sl.SetCellValue("B18", "Transferencia");
            sl.SetCellValue("E18", "Bs.S5.000,00");
            sl.SetCellValue("F18", "$582,07");

            sl.SetCellValue("A19", "TRANSFERENCIA VENEZUELA");
            sl.SetCellValue("B19", "Transferencia");
            sl.SetCellValue("E19", " Bs.S-   ");
            sl.SetCellValue("F19", " $-   ");

            sl.SetCellValue("A20", "FACEBANK");
            sl.SetCellValue("B20", "Transferencia");
            sl.SetCellValue("E20", " Bs.S-   ");
            sl.SetCellValue("F20", " $-   ");

            sl.SetCellValue("A21", "BANESCO PANAMA");
            sl.SetCellValue("B21", "Transferencia");
            sl.SetCellValue("E21", "$500,00");
            sl.SetCellValue("F21", "$500,00");

            sl.SetCellValue("A22", "REGIONS BANK");
            sl.SetCellValue("B22", "Transferencia OM");
            sl.SetCellValue("E22", "$1.200,00");
            sl.SetCellValue("F22", "$1.200,00");

            sl.SetCellValue("A23", "ZELLE TD");
            sl.SetCellValue("B23", "Transferencia OM");
            sl.SetCellValue("E23", "$3.500,00");
            sl.SetCellValue("F23", "$3.500,00");

            sl.SetCellValue("A24", "FACEBANK USD");
            sl.SetCellValue("B24", "Transferencia OM");
            sl.SetCellValue("E24", " Bs.S-   ");
            sl.SetCellValue("F24", " $-   ");

            sl.SetCellValue("A25", "MERCANTIL PANAMA");
            sl.SetCellValue("B25", "Transferencia OM");
            sl.SetCellValue("E25", "$1.450,00");
            sl.SetCellValue("F25", "$1.450,00");

            sl.SetCellValue("A26", "ZELLE BOFA");
            sl.SetCellValue("B26", "Transferencia OM");
            sl.SetCellValue("E26", "$200,00");
            sl.SetCellValue("F26", "$200,00");

            sl.SetCellValue("A27", "ZELLE CHASE");
            sl.SetCellValue("B27", "Transferencia OM");
            sl.SetCellValue("E27", " Bs.S-   ");
            sl.SetCellValue("F27", " $-   ");

            sl.SetCellValue("A28", "TDC Banesco Panama");
            sl.SetCellValue("B28", "Transferencia OM");
            sl.SetCellValue("E28", "$600,00");
            sl.SetCellValue("F28", "$600,00");

            sl.SetCellValue("A29", "CUPONDAKA");
            sl.SetCellValue("B29", "Dolares");
            sl.SetCellValue("E29", " Bs.S-   ");
            sl.SetCellValue("F29", " $-   ");

            sl.SetCellValue("A30", "NOTA DE CREDITO");
            sl.SetCellValue("B30", "Nota de crédito");
            sl.SetCellValue("E30", "Bs.S1.000,00");
            sl.SetCellValue("F30", "$116,41");

            // Total Ingresos
            sl.SetCellValue("A32", "TOTAL INGRESOS");
            sl.SetCellValue("B32", "A");
            sl.SetCellValue("E32", "Bs.S32.900,00");
            sl.SetCellValue("F32", "$40.882,83");

            // Reporte Z
            sl.SetCellValue("A32", "TOTAL INGRESOS");
            sl.SetCellValue("B32", "A");
            sl.SetCellValue("E32", "Bs.S32.900,00");
            sl.SetCellValue("F32", "$40.882,83");

            // 
            sl.SetCellValue("A34", "REPORTE  Z");
            sl.SetCellValue("B34", "B");
            sl.SetCellValue("E34", "40000");
            sl.SetCellValue("F34", "");

            sl.SetCellValue("A35", "VENTAS MANUALES");
            sl.SetCellValue("B35", "C");
            sl.SetCellValue("E35", "");
            sl.SetCellValue("F35", "");

            sl.SetCellValue("A36", "NOTAS DE CREDITO MANUALES");
            sl.SetCellValue("B36", "D");
            sl.SetCellValue("E36", "");
            sl.SetCellValue("F36", "");

            sl.SetCellValue("A37", "TOTAL VENTAS");
            sl.SetCellValue("B37", "E");
            sl.SetCellValue("E37", "");
            sl.SetCellValue("F37", "40000");

            sl.SetCellValue("A39", "DIFERENCIAS");
            sl.SetCellValue("B39", "");
            sl.SetCellValue("E39", "Bs.S-7.100,00");
            sl.SetCellValue("F39", "");

            sl.SetCellValue("A40", "SALDO POS");
            sl.SetCellValue("B40", "");
            sl.SetCellValue("E40", " Bs.S40.000,00");
            sl.SetCellValue("F40", "");

            sl.SetCellValue("A42", "SALDO POS");
            sl.SetCellValue("B42", "");
            sl.SetCellValue("E42", " Bs.S40.000,00");
            sl.SetCellValue("F42", "");

            sl.SetCellValue("A44", "SALDO SAP");
            sl.SetCellValue("B44", "");
            sl.SetCellValue("E44", " Bs.S41.000,00");
            sl.SetCellValue("F44", "");

            sl.SetCellValue("A45", "DIFERENCIA 1 VS FISICO");
            sl.SetCellValue("B45", "");
            sl.SetCellValue("E45", "");
            sl.SetCellValue("F45", "");

            sl.SetCellValue("A46", "DIFERENCIA 2 VS POS");
            sl.SetCellValue("B46", "");
            sl.SetCellValue("E46", "");
            sl.SetCellValue("F46", "");

            sl.SetCellValue("A48", "SALDO EN BOVEDA");
            sl.SetCellValue("B48", "CUENTA CONTABLE");
            sl.SetCellValue("E48", "$2.000,00");
            sl.SetCellValue("F48", "USD");

            sl.SetCellValue("A49", "");
            sl.SetCellValue("B49", "");
            sl.SetCellValue("E49", "$1.000,00");
            sl.SetCellValue("F49", "EUR");

            sl.SetCellValue("A50", "");
            sl.SetCellValue("B50", "");
            sl.SetCellValue("E50", "Bs.S10.000,00");
            sl.SetCellValue("F50", "BS");
            // Borders -------------------------------:
            SLStyle BorderTop = sl.CreateStyle();
            SLStyle BorderLeft = sl.CreateStyle();
            SLStyle BorderRigth = sl.CreateStyle();
            SLStyle BorderBottom = sl.CreateStyle();

            // Colors -------------------------------:
            SLStyle LightGreen = sl.CreateStyle();
            SLStyle BackgroundBlueColor = sl.CreateStyle();
            SLStyle ForeWhiteColor = sl.CreateStyle();

            LightGreen.SetFontColor(System.Drawing.Color.LightGreen);
            ForeWhiteColor.SetFontColor(System.Drawing.Color.White);
            BackgroundBlueColor.Fill.SetPattern(PatternValues.Solid, System.Drawing.Color.DarkBlue, System.Drawing.Color.DarkBlue);

            // Styles Font
            SLStyle title = sl.CreateStyle();
            title.SetFont("Arial", 14);
            title.SetFontBold(true);

            BorderLeft.Border.LeftBorder.BorderStyle = BorderStyleValues.Thick;
            BorderLeft.Border.LeftBorder.Color = System.Drawing.Color.Black;

            //style.Border.RightBorder.BorderStyle = BorderStyleValues.Thick;
            //style.Border.RightBorder.Color = System.Drawing.Color.Black;

            BorderTop.Border.TopBorder.BorderStyle = BorderStyleValues.Thick;
            BorderTop.Border.TopBorder.Color = System.Drawing.Color.Black;

            //style.Border.BottomBorder.BorderStyle = BorderStyleValues.Thick;
            //style.Border.BottomBorder.Color = System.Drawing.Color.Black;

            //sl.SetCellStyle(7, 2, BorderTop); // Celda donde se agregaran los estilos

            // Add Styles
            sl.SetCellStyle("B5", title);

            //Fore
            sl.SetCellStyle("E7", ForeWhiteColor);
            sl.SetCellStyle("F7", ForeWhiteColor);
            sl.SetCellStyle("A10", ForeWhiteColor);
            sl.SetCellStyle("B10", ForeWhiteColor);
            sl.SetCellStyle("C10", ForeWhiteColor);
            sl.SetCellStyle("D10", ForeWhiteColor);
            sl.SetCellStyle("E10", ForeWhiteColor);
            sl.SetCellStyle("F10", ForeWhiteColor);

            // Background
            sl.SetCellStyle("E7", BackgroundBlueColor);
            sl.SetCellStyle("F7", BackgroundBlueColor);
            sl.SetCellStyle("A10", BackgroundBlueColor);
            sl.SetCellStyle("B10", BackgroundBlueColor);
            sl.SetCellStyle("C10", BackgroundBlueColor);
            sl.SetCellStyle("D10", BackgroundBlueColor);
            sl.SetCellStyle("E10", BackgroundBlueColor);
            sl.SetCellStyle("F10", BackgroundBlueColor);
            sl.SaveAs(path);
        }
    }
}
