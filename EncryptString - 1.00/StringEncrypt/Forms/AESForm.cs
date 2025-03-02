using System;
using Security.Methods;

namespace StringEncrypt.Forms;

public partial class AESForm : Form
{
    // Load Form Controls
    public AESForm()
    {
        InitializeComponent();
    }
    // Show encryption key length
    private void TxTKey(object sender, EventArgs e)
    {
        int Lngth = TBxKey.TextLength;
        LabKey2.Text = Lngth.ToString() + "/32";
    }
    // Show initialization vector length
    private void TxTIV(object sender, EventArgs e)
    {
        int Lngth = TBxIV.TextLength;
        LabIV2.Text = Lngth.ToString() + "/16";
    }
    // Encrypt text with AES (Advanced Encryption Standard)
    private void EncryTxT(object sender, EventArgs e)
    {
        if (TBxKey.TextLength == 16 || TBxKey.TextLength == 24 || TBxKey.TextLength == 32)
        {
            if (TBxIV.TextLength == 16)
            {
                try
                {
                    string Key = TBxKey.Text;
                    string IV = TBxIV.Text;
                    string Nocry = TBxNocry.Text;
                    TBxEncry.Text = AES.AESEncrypt(Key, IV, Nocry);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, string.Empty, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            else
            {
                EMess();
            }
        }
        else
        {
            EMess();
        }
    }
    // Decrypt text with AES (Advanced Encryption Standard)
    private void DecryTxT(object sender, EventArgs e)
    {
        if (TBxKey.TextLength == 16 || TBxKey.TextLength == 24 || TBxKey.TextLength == 32)
        {
            if (TBxIV.TextLength == 16)
            {
                try
                {
                    string Key = TBxKey.Text;
                    string IV = TBxIV.Text;
                    string Encry = TBxEncry.Text;
                    TBxDecry.Text = AES.AESDecrypt(Key, IV, Encry);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, string.Empty, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            else
            {
                EMess();
            }
        }
        else
        {
            EMess();
        }
    }
	// Show error message
	private void EMess()
	{
		string Mess = "Warning, the encryption key and/or initialization vector is not valid. Please verify that they have a valid length and characters." + 
		Environment.NewLine + string.Empty + Environment.NewLine + 
		"Encryption Key: 16, 24 or 32 characters." + 
		Environment.NewLine + string.Empty + Environment.NewLine + 
		"Initialization Vector: 16 characters.";
		MessageBox.Show(Mess, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
	}
    // Clear controls
    private void ClearCtr(object sender, EventArgs e)
    {
        TBxKey.Clear();
        TBxIV.Clear();
        TBxNocry.Clear();
        TBxEncry.Clear();
        TBxDecry.Clear();
    }
    // Copy text with AES (Advanced Encryption Standard) encryption
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
    // Copy text with AES (Advanced Encryption Standard) decryption
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