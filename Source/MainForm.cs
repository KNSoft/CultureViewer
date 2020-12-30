using System;
using System.Data;
using System.Windows.Forms;
using System.Globalization;
using System.Reflection;

namespace CultureViewer {
    public partial class MainForm : Form {
        private readonly Assembly Asm = Assembly.GetExecutingAssembly();
        private readonly DataTable CultureTable;
        public MainForm() {
            CultureTable = new DataTable();
            CultureTable.Columns.Add("#", typeof(uint));
            CultureTable.Columns.Add("Name");
            CultureTable.Columns.Add("Parent.Name");
            CultureTable.Columns.Add("LCID", typeof(int));
            CultureTable.Columns.Add("NativeName");
            CultureTable.Columns.Add("DisplayName");
            CultureTable.Columns.Add("EnglishName");
            CultureTable.Columns.Add("ThreeLetterISOLanguageName");
            CultureTable.Columns.Add("ThreeLetterWindowsLanguageName");
            CultureTable.Columns.Add("TwoLetterISOLanguageName");
            CultureTable.Columns.Add("TextInfo.ANSICodePage");
            CultureTable.Columns.Add("TextInfo.OEMCodePage");
            CultureTable.Columns.Add("TextInfo.IsRightToLeft");

            Text = Asm.GetName().Name;

            InitializeComponent();

            CultureTypes[] Types = { CultureTypes.AllCultures, CultureTypes.NeutralCultures, CultureTypes.SpecificCultures };
            foreach (var t in Types)
                CBCultureType.Items.Add(Enum.GetName(typeof(CultureTypes), t));
            CBCultureType.SelectedIndex = 0;

            DGVCultures.GetType().GetProperty("DoubleBuffered", BindingFlags.Instance | BindingFlags.NonPublic).SetValue(DGVCultures, true, null);
            DGVCultures.DataSource = CultureTable;
        }
        private void CBCultureType_SelectedIndexChanged(object sender, EventArgs e) {
            CultureTable.Rows.Clear();
            CultureInfo[] Cultures = CultureInfo.GetCultures((CultureTypes)Enum.Parse(typeof(CultureTypes), CBCultureType.Text));
            uint i;
            for (i = 0; i < Cultures.Length; i++)
                CultureTable.Rows.Add(
                    i + 1,
                    Cultures[i].Name,
                    Cultures[i].Parent.Name,
                    Cultures[i].LCID,
                    Cultures[i].NativeName,
                    Cultures[i].DisplayName,
                    Cultures[i].EnglishName,
                    Cultures[i].ThreeLetterISOLanguageName,
                    Cultures[i].ThreeLetterWindowsLanguageName,
                    Cultures[i].TwoLetterISOLanguageName,
                    Cultures[i].TextInfo.ANSICodePage,
                    Cultures[i].TextInfo.OEMCodePage,
                    Cultures[i].TextInfo.IsRightToLeft.ToString()
                    );
            TCount.Text = i.ToString();
        }
        private void BtnHelp_Click(object sender, EventArgs e) {
            string Info = string.Empty;
            Info += string.Format("{0} {1} - {2}\r\n", Asm.GetCustomAttribute<AssemblyCompanyAttribute>().Company, Asm.GetCustomAttribute<AssemblyProductAttribute>().Product, Asm.GetName().Name);
            Info += "V" + Asm.GetName().Version.ToString();
            MessageBox.Show(Info, Asm.GetName().Name);
        }
    }
}
