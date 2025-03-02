namespace StringEncrypt.Forms;
using System.IO;

public partial class MainForm : Form
{
    // Load Form Controls
    public MainForm()
    {
        InitializeComponent();
        MStModul.SendToBack();
    }
    // Load Form
    private void LoadForm(object sender, EventArgs e)
    {
    }
    // Open modules
    private void OpenForm(Form Module)
    {
        if (PanForms.Controls.Count > 0)
        {
            PanForms.Controls.RemoveAt(0);
        }
        Module.TopLevel = false;
        Module.Dock = DockStyle.Fill;
        PanForms.Controls.Add(Module);
        PanForms.Tag = Module;
        Module.Show();
    }
    // Close modules
    private void CloseMod(object sender, EventArgs e)
    {
        if (PanForms.Controls.Count > 0)
        {
            PanForms.Controls.RemoveAt(0);
        }
        LabModul.Text = string.Empty;
    }
    // Open Base64 method
    private void OpenB64(object sender, EventArgs e)
    {
        OpenForm(new B64Form());
        LabModul.Text = "Base64";
    }
    // Open AES (Advanced Encryption Standard) method
    private void OpenAES(object sender, EventArgs e)
    {
        OpenForm(new AESForm());
        LabModul.Text = "AES (Advanced Encryption Standard)";
    }
    // Open Secure Hash Algorithm: MD5 method
    private void OpenMD5(object sender, EventArgs e)
    {
        OpenForm(new MD5Form());
        LabModul.Text = "Secure Hash Algorithm: MD5";
    }
    // Open Secure Hash Algorithm: SHA-160 method
    private void OpenSha160(object sender, EventArgs e)
    {
        OpenForm(new SHA1Form());
        LabModul.Text = "Secure Hash Algorithm: SHA-160-bit";
    }
    // Open Secure Hash Algorithm: SHA-256 method
    private void OpenSha256(object sender, EventArgs e)
    {
        OpenForm(new SHA2Form());
        LabModul.Text = "Secure Hash Algorithm: SHA-256-bit";
    }
    // Open Secure Hash Algorithm: SHA-512 method
    private void OpenSha512(object sender, EventArgs e)
    {
        OpenForm(new SHA5Form());
        LabModul.Text = "Secure Hash Algorithm: SHA-512-bit";
    }
    // About...
    private void About(object sender, EventArgs e)
    {
        string Mess = AppDescr();
        MessageBox.Show(Mess, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information);
        
    }
    // Retrieve project description
    private static string AppDescr()
    {
        string Result;
        try
        {
            Result = File.ReadAllText("About.txt");
        }
        catch (Exception ex)
        {
            Result = ex.Message;
        }
        return Result;
    }
}
