using System;
using FontAwesome.Sharp;

namespace StringEncrypt.Forms;

partial class B64Form
{
    #region Controls
    private Panel PanCtrls;
    private Panel PanButon;
    private IconButton BtnEncry;
    private IconButton BtnDecry;
    private IconButton BtnClear;
    private Label LabNocry;
    private TextBox TBxNocry;
    private Label LabEncry;
    private TextBox TBxEncry;
    private IconButton BtnCopyE;
    private Label LabDecry;
    private TextBox TBxDecry;
    private IconButton BtnCopyD;
    private ToolTip MsgBox;
    #endregion

    #region Control Properties
    private void InitializeComponent()
    {
        PanCtrls = new Panel();
        PanButon = new Panel();
        BtnEncry = new IconButton();
        BtnDecry = new IconButton();
        BtnClear = new IconButton();
        LabNocry = new Label();
        TBxNocry = new TextBox();
        LabEncry = new Label();
        TBxEncry = new TextBox();
        BtnCopyE = new IconButton();
        LabDecry = new Label();
        TBxDecry = new TextBox();
        BtnCopyD = new IconButton();
        MsgBox = new ToolTip();
        PanCtrls.SuspendLayout();
        PanButon.SuspendLayout();
        SuspendLayout();
        // PanCtrls
        PanCtrls.Controls.AddRange
        (
            PanButon,
            LabNocry,
            TBxNocry,
            LabEncry,
            TBxEncry,
            BtnCopyE,
            LabDecry,
            TBxDecry,
            BtnCopyD
        );
        PanCtrls.Location = new Point(25, 25);
        PanCtrls.BorderStyle = BorderStyle.FixedSingle;
        PanCtrls.BackColor = SystemColors.ActiveCaption;
        PanCtrls.Size = new Size(850,600);
        PanCtrls.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
        PanCtrls.Name = "PanCtrls";
        PanCtrls.TabIndex = 0;
        PanCtrls.Anchor = ((AnchorStyles)((((AnchorStyles.Top | AnchorStyles.Bottom) | AnchorStyles.Left) | AnchorStyles.Right)));
        // PanButon
        PanButon.Controls.AddRange
        (
            BtnEncry,
            BtnDecry,
            BtnClear
        );
        PanButon.Location = new Point(0, 0);
        PanButon.Size = new Size(850,60);
        PanButon.BorderStyle = BorderStyle.None;
        PanButon.Dock = DockStyle.Top;
        PanButon.BackColor = Color.SeaGreen;
        PanButon.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
        PanButon.Name = "PanButon";
        PanButon.TabIndex = 0;
        // BtnEncry
        BtnEncry.Location = new System.Drawing.Point(20,10);
        BtnEncry.Size = new Size(40,40);
        BtnEncry.FlatStyle = FlatStyle.Flat;
        BtnEncry.FlatAppearance.BorderSize = 0;
        BtnEncry.BackColor = Color.Firebrick;
        BtnEncry.IconChar = IconChar.Lock;
        BtnEncry.IconSize = 40;
        BtnEncry.IconColor = Color.White;
        BtnEncry.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
        BtnEncry.Name = "BtnEncry";
        BtnEncry.Text = string.Empty;
        BtnEncry.TabIndex = 0;
        BtnEncry.Click += new EventHandler(EncryTxT);
        // BtnDecry
        BtnDecry.Location = new System.Drawing.Point(405,10);
        BtnDecry.Size = new Size(40,40);
        BtnDecry.FlatStyle = FlatStyle.Flat;
        BtnDecry.FlatAppearance.BorderSize = 0;
        BtnDecry.BackColor = Color.SteelBlue;
        BtnDecry.IconChar = IconChar.LockOpen;
        BtnDecry.IconSize = 40;
        BtnDecry.IconColor = Color.White;
        BtnDecry.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
        BtnDecry.Anchor = AnchorStyles.Top;
        BtnDecry.Name = "BtnDecry";
        BtnDecry.Text = string.Empty;
        BtnDecry.TabIndex = 1;
        BtnDecry.Click += new EventHandler(DecryTxT);
        // BtnClear
        BtnClear.Location = new System.Drawing.Point(790,10);
        BtnClear.Size = new Size(40,40);
        BtnClear.FlatStyle = FlatStyle.Flat;
        BtnClear.FlatAppearance.BorderSize = 0;
        BtnClear.BackColor = Color.DarkSeaGreen;
        BtnClear.IconChar = IconChar.Broom;
        BtnClear.IconSize = 40;
        BtnClear.IconColor = Color.White;
        BtnClear.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
        BtnClear.Anchor = ((AnchorStyles)((AnchorStyles.Top | AnchorStyles.Right)));
        BtnClear.Name = "BtnClear";
        BtnClear.Text = string.Empty;
        BtnClear.TabIndex = 2;
        BtnClear.Click += new EventHandler(ClearCtr);
        // LabNocry
        LabNocry.Location = new Point(20,80);
        LabNocry.AutoSize =  true;
        LabNocry.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
        LabNocry.ForeColor = Color.Black;
        LabNocry.Name =  "LabNocry";
        LabNocry.Text =  "Text without encrypt";
        LabNocry.TabIndex = 1;
        // TBxNocry
        TBxNocry.Location = new Point(20,105);
        TBxNocry.Size = new Size(810,29);
        TBxNocry.BorderStyle = BorderStyle.FixedSingle;
        TBxNocry.BackColor = SystemColors.ActiveCaption;
        TBxNocry.Anchor = ((AnchorStyles)(((AnchorStyles.Top | AnchorStyles.Left) | AnchorStyles.Right)));
        TBxNocry.Name = "TBxNocry";
        TBxNocry.Text = string.Empty;
        TBxNocry.TabIndex = 2;
        // LabEncry
        LabEncry.Location = new Point(20,150);
        LabEncry.AutoSize =  true;
        LabEncry.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
        LabEncry.ForeColor = Color.Black;
        LabEncry.Name =  "LabEncry";
        LabEncry.Text =  "Text with Base64 encryption";
        LabEncry.TabIndex = 3;
        // TBxEncry
        TBxEncry.Location = new Point(20,175);
        TBxEncry.Multiline = true;
        TBxEncry.ScrollBars = ScrollBars.Vertical;
        TBxEncry.Size = new Size(760,310);
        TBxEncry.BorderStyle = BorderStyle.FixedSingle;
        TBxEncry.BackColor = SystemColors.ActiveCaption;
        TBxEncry.Anchor = ((AnchorStyles)((((AnchorStyles.Top | AnchorStyles.Bottom) | AnchorStyles.Left) | AnchorStyles.Right)));
        TBxEncry.Name = "TBxEncry";
        TBxEncry.Text = string.Empty;
        TBxEncry.TabIndex = 4;
        // BtnCopyE
        BtnCopyE.Location = new System.Drawing.Point(790,175);
        BtnCopyE.Size = new Size(40,40);
        BtnCopyE.FlatStyle = FlatStyle.Flat;
        BtnCopyE.FlatAppearance.BorderSize = 0;
        BtnCopyE.BackColor = Color.DarkSeaGreen;
        BtnCopyE.IconChar = IconChar.Copy;
        BtnCopyE.IconSize = 40;
        BtnCopyE.IconColor = Color.White;
        BtnCopyE.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
        BtnCopyE.Anchor = ((AnchorStyles)((AnchorStyles.Top | AnchorStyles.Right)));
        BtnCopyE.Name = "BtnCopyE";
        BtnCopyE.Text = string.Empty;
        BtnCopyE.TabIndex = 5;
        BtnCopyE.Click += new EventHandler(CopyETxT);
        // LabDecry
        LabDecry.Location = new Point(20,500);
        LabDecry.AutoSize =  true;
        LabDecry.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
        LabDecry.ForeColor = Color.Black;
        LabDecry.Anchor = ((AnchorStyles)((AnchorStyles.Bottom | AnchorStyles.Left)));
        LabDecry.Name =  "LabDecry";
        LabDecry.Text =  "Text with Base64 decryption";
        LabDecry.TabIndex = 6;
        // TBxDecry
        TBxDecry.Location = new Point(20,525);
        TBxDecry.Size = new Size(760,29);
        TBxDecry.BorderStyle = BorderStyle.FixedSingle;
        TBxDecry.BackColor = SystemColors.ActiveCaption;
        TBxDecry.Anchor = ((AnchorStyles)(((AnchorStyles.Bottom | AnchorStyles.Left) | AnchorStyles.Right)));
        TBxDecry.ReadOnly = true;
        TBxDecry.Name = "TBxDecry";
        TBxDecry.Text = string.Empty;
        TBxDecry.TabIndex = 7;
        // BtnCopD
        BtnCopyD.Location = new System.Drawing.Point(790,525);
        BtnCopyD.Size = new Size(40,40);
        BtnCopyD.FlatStyle = FlatStyle.Flat;
        BtnCopyD.FlatAppearance.BorderSize = 0;
        BtnCopyD.BackColor = Color.DarkSeaGreen;
        BtnCopyD.IconChar = IconChar.Copy;
        BtnCopyD.IconSize = 40;
        BtnCopyD.IconColor = Color.White;
        BtnCopyD.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
        BtnCopyD.Anchor = ((AnchorStyles)((AnchorStyles.Bottom | AnchorStyles.Right)));
        BtnCopyD.Name = "BtnCopyD";
        BtnCopyD.Text = string.Empty;
        BtnCopyD.TabIndex = 8;
        BtnCopyD.Click += new EventHandler(CopyDTxT);
        // MsgBox
        MsgBox.IsBalloon = true;
        MsgBox.SetToolTip(BtnEncry, "Encrypt text with Base64");
        MsgBox.SetToolTip(BtnDecry, "Decrypt text with Base64");
        MsgBox.SetToolTip(BtnClear, "Clear controls");
        MsgBox.SetToolTip(BtnCopyE, "Copy text with Base64 encryption");
        MsgBox.SetToolTip(BtnCopyD, "Copy text with Base64 decryption");
        // Form
        AutoScaleBaseSize = new Size(8,22);
        BackColor = SystemColors.ActiveCaption;
        FormBorderStyle = FormBorderStyle.None;
        Size = new Size(900,650);
        StartPosition = FormStartPosition.CenterScreen;
        Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
        Name = "B64Form";
        Text = string.Empty;
        Controls.AddRange
        (
            PanCtrls
        );
        PanCtrls.ResumeLayout(false);
        PanButon.ResumeLayout(false);
        ResumeLayout(false);
    }
    #endregion
}
