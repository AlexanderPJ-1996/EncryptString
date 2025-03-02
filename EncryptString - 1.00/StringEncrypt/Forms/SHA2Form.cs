using System;
using Security.Methods;

namespace StringEncrypt.Forms;

public partial class SHA2Form : Form
{
    // Load Form Controls
    public SHA2Form()
    {
        InitializeComponent();
    }
    // Encrypt text with Secure Hash Algorithm: SHA-256
    private void EncryTxT(object sender, EventArgs e)
    {
        try
        {
            string Nocry = TBxNocry.Text;
            TBxEncry.Text = SHA.SHA256Encrypt(Nocry);
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message, string.Empty, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }
    }
    // Clear controls
    private void ClearCtr(object sender, EventArgs e)
    {
        TBxNocry.Clear();
        TBxEncry.Clear();
    }
    // Copy text with Secure Hash Algorithm: SHA-256 encryption
    private void CopyETxT(object sender, EventArgs e)
    {
        if (TBxEncry.TextLength > 0)
        {
            try
            {
                string Copy = TBxEncry.Text;
                Clipboard.SetText(Copy);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, string.Empty, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}
