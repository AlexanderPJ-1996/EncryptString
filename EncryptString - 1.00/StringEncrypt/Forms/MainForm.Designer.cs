using FontAwesome.Sharp;

namespace StringEncrypt.Forms;

partial class MainForm
{
	#region Controls
    private MenuStrip MStModul;
    private IconMenuItem IMIModul;
    private IconMenuItem IMIEmpty;
    private IconMenuItem IMIB64;
    private IconMenuItem IMIAES;
    private IconMenuItem IMIMD5;
    private IconMenuItem IMISHA1;
    private IconMenuItem IMISHA2;
    private IconMenuItem IMISHA5;
    private IconMenuItem LabModul;
    private IconMenuItem IMIAbout;
    private Panel PanForms;
    #endregion

    #region Control Properties
    private void InitializeComponent()
    {
        MStModul = new MenuStrip();
        IMIModul = new IconMenuItem();
        IMIEmpty = new IconMenuItem();
        IMIB64 = new IconMenuItem();
        IMIAES = new IconMenuItem();
        IMIMD5 = new IconMenuItem();
        IMISHA1 = new IconMenuItem();
        IMISHA2 = new IconMenuItem();
        IMISHA5 = new IconMenuItem();
        LabModul = new IconMenuItem();
        IMIAbout = new IconMenuItem();
        PanForms = new Panel();
        MStModul.SuspendLayout();
        PanForms.SuspendLayout();
        SuspendLayout();
        // MStModul
        MStModul.Items.AddRange
        (
            new IconMenuItem[]
            {
                IMIModul,
                LabModul,
                IMIAbout
            }
        );
        MStModul.Items.Add(LabModul);
        MStModul.Location = new Point(0, 0);
        MStModul.Dock = DockStyle.Top;
        MStModul.AutoSize = false;
        MStModul.Size = new Size(900,31);
        MStModul.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
        MStModul.BackColor = Color.SeaGreen;
        MStModul.ForeColor = Color.White;
        MStModul.TabIndex = 0;
        MStModul.Name = "MStModul";
        // IMIModul
        IMIModul.DropDownItems.AddRange
        (
            new IconMenuItem[]
            {
                IMIEmpty,
                IMIB64,
                IMIAES,
                IMIMD5,
                IMISHA1,
                IMISHA2,
                IMISHA5
            }
        );
        IMIModul.AutoSize = true;
        IMIModul.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
        IMIModul.ForeColor = Color.White;
        IMIModul.IconChar = IconChar.Code;
        IMIModul.IconColor = Color.White;
        IMIModul.IconSize = 25;
        IMIModul.ImageScaling = ToolStripItemImageScaling.None;
        IMIModul.BackgroundImageLayout = ImageLayout.Zoom;
        IMIModul.TextImageRelation = TextImageRelation.ImageBeforeText;
        IMIModul.Name = "IMIModul";
        IMIModul.Text = "Encryption Methods";
        // IMIEmpty
        IMIEmpty.AutoSize = true;
        IMIEmpty.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
        IMIEmpty.ForeColor = Color.White;
        IMIEmpty.BackColor = Color.SeaGreen;
        IMIEmpty.IconChar = IconChar.None;
        IMIEmpty.IconColor = Color.White;
        IMIEmpty.IconSize = 25;
        IMIEmpty.ImageScaling = ToolStripItemImageScaling.None;
        IMIEmpty.BackgroundImageLayout = ImageLayout.Zoom;
        IMIEmpty.TextImageRelation = TextImageRelation.ImageBeforeText;
        IMIEmpty.Name = "IMIEmpty";
        IMIEmpty.Text = string.Empty;
        IMIEmpty.Click += new EventHandler(CloseMod);
        // IMIB64
        IMIB64.AutoSize = true;
        IMIB64.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
        IMIB64.ForeColor = Color.White;
        IMIB64.BackColor = Color.SeaGreen;
        IMIB64.IconChar = IconChar.B;
        IMIB64.IconColor = Color.White;
        IMIB64.IconSize = 25;
        IMIB64.ImageScaling = ToolStripItemImageScaling.None;
        IMIB64.BackgroundImageLayout = ImageLayout.Zoom;
        IMIB64.TextImageRelation = TextImageRelation.ImageBeforeText;
        IMIB64.Name = "IMIB64";
        IMIB64.Text = "Base64";
        IMIB64.Click += new EventHandler(OpenB64);
        // IMIAES
        IMIAES.AutoSize = true;
        IMIAES.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
        IMIAES.ForeColor = Color.White;
        IMIAES.BackColor = Color.SeaGreen;
        IMIAES.IconChar = IconChar.A;
        IMIAES.IconColor = Color.White;
        IMIAES.IconSize = 25;
        IMIAES.ImageScaling = ToolStripItemImageScaling.None;
        IMIAES.BackgroundImageLayout = ImageLayout.Zoom;
        IMIAES.TextImageRelation = TextImageRelation.ImageBeforeText;
        IMIAES.Name = "IMIAES";
        IMIAES.Text = "AES";
        IMIAES.Click += new EventHandler(OpenAES);
        // IMIMD5
        IMIMD5.AutoSize = true;
        IMIMD5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
        IMIMD5.ForeColor = Color.White;
        IMIMD5.BackColor = Color.SeaGreen;
        IMIMD5.IconChar = IconChar.M;
        IMIMD5.IconColor = Color.White;
        IMIMD5.IconSize = 25;
        IMIMD5.ImageScaling = ToolStripItemImageScaling.None;
        IMIMD5.BackgroundImageLayout = ImageLayout.Zoom;
        IMIMD5.TextImageRelation = TextImageRelation.ImageBeforeText;
        IMIMD5.Name = "IMIMD5";
        IMIMD5.Text = "MD5";
        IMIMD5.Click += new EventHandler(OpenMD5);
        // IMISHA1
        IMISHA1.AutoSize = true;
        IMISHA1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
        IMISHA1.ForeColor = Color.White;
        IMISHA1.BackColor = Color.SeaGreen;
        IMISHA1.IconChar = IconChar.S;
        IMISHA1.IconColor = Color.White;
        IMISHA1.IconSize = 25;
        IMISHA1.ImageScaling = ToolStripItemImageScaling.None;
        IMISHA1.BackgroundImageLayout = ImageLayout.Zoom;
        IMISHA1.TextImageRelation = TextImageRelation.ImageBeforeText;
        IMISHA1.Name = "IMISHA1";
        IMISHA1.Text = "SHA-160";
        IMISHA1.Click += new EventHandler(OpenSha160);
        // IMISHA2
        IMISHA2.AutoSize = true;
        IMISHA2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
        IMISHA2.ForeColor = Color.White;
        IMISHA2.BackColor = Color.SeaGreen;
        IMISHA2.IconChar = IconChar.S;
        IMISHA2.IconColor = Color.White;
        IMISHA2.IconSize = 25;
        IMISHA2.ImageScaling = ToolStripItemImageScaling.None;
        IMISHA2.BackgroundImageLayout = ImageLayout.Zoom;
        IMISHA2.TextImageRelation = TextImageRelation.ImageBeforeText;
        IMISHA2.Name = "IMISHA2";
        IMISHA2.Text = "SHA-256";
        IMISHA2.Click += new EventHandler(OpenSha256);
        // IMISHA5
        IMISHA5.AutoSize = true;
        IMISHA5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
        IMISHA5.ForeColor = Color.White;
        IMISHA5.BackColor = Color.SeaGreen;
        IMISHA5.IconChar = IconChar.S;
        IMISHA5.IconColor = Color.White;
        IMISHA5.IconSize = 25;
        IMISHA5.ImageScaling = ToolStripItemImageScaling.None;
        IMISHA5.BackgroundImageLayout = ImageLayout.Zoom;
        IMISHA5.TextImageRelation = TextImageRelation.ImageBeforeText;
        IMISHA5.Name = "IMISHA5";
        IMISHA5.Text = "SHA-512";
        IMISHA5.Click += new EventHandler(OpenSha512);
        // LabModul
        LabModul.AutoSize = true;
        LabModul.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
        LabModul.ForeColor = Color.White;
        LabModul.IconChar = IconChar.None;
        LabModul.Name = "LabModul";
        LabModul.Text = string.Empty;
        // IMIAbout
        IMIAbout.AutoSize = true;
        IMIAbout.Alignment = ToolStripItemAlignment.Right;
        IMIAbout.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
        IMIAbout.ForeColor = Color.White;
        IMIAbout.IconChar = IconChar.QuestionCircle;
        IMIAbout.IconColor = Color.White;
        IMIAbout.IconSize = 25;
        IMIAbout.ImageScaling = ToolStripItemImageScaling.None;
        IMIAbout.BackgroundImageLayout = ImageLayout.Zoom;
        IMIAbout.TextImageRelation = TextImageRelation.ImageBeforeText;
        IMIAbout.Name = "IMIAbout";
        IMIAbout.Text = "About...";
        IMIAbout.Click += new EventHandler(About);
        // PanForms
        PanForms.Location = new Point(0, 45);
        PanForms.Dock = DockStyle.Fill;
        PanForms.BorderStyle = BorderStyle.None;
        PanForms.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
        PanForms.Name = "PanForms";
        // Form
        AutoScaleBaseSize = new Size(8,22);
        FormBorderStyle = FormBorderStyle.FixedSingle;
        Size = new Size(916,720);
        BackColor = SystemColors.ActiveCaption;
        StartPosition = FormStartPosition.CenterScreen;
        Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
        Name = "MainForm";
        Text = Application.ProductName;
        Icon = new System.Drawing.Icon("StringEncrypt.ico");
        Controls.AddRange
        (
            MStModul,
            PanForms
        );
        Load += new EventHandler(LoadForm);
        MStModul.ResumeLayout(false);
        PanForms.ResumeLayout(false);
        ResumeLayout(false);
    }
    #endregion
}