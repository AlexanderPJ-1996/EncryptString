using System;
using Security.Methods;

namespace StringEncrypt.Forms;

public partial class B64Form : Form
{
    // Load Form Controls
    public B64Form()
    {
        InitializeComponent();
    }
    // Encrypt text with Base64
    private void EncryTxT(object sender, EventArgs e)
    {
        if (TBxNocry.TextLength > 0)
        {
            try
            {
                string Nocry = TBxNocry.Text;
                TBxEncry.Text = Base64.Base64Encrypt(Nocry);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, string.Empty, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
    // Decrypt text with Base64
    private void DecryTxT(object sender, EventArgs e)
    {
        if (TBxEncry.TextLength > 0)
        {
            try
            {
                string Encry = TBxEncry.Text;
                TBxDecry.Text = Base64.Base64Decrypt(Encry);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, string.Empty, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
    // Clear controls
    private void ClearCtr(object sender, EventArgs e)
    {
        TBxNocry.Clear();
        TBxEncry.Clear();
        TBxDecry.Clear();
    }
    // Copy text with Base64 encryption
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
    // Copy text with Base64 decryption
    private void CopyDTxT(object sender, EventArgs e)
    {
        if (TBxDecry.TextLength > 0)
        {
            try
            {
                string Copy = TBxDecry.Text;
                Clipboard.SetText(Copy);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, string.Empty, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}