using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace Bus_Booking_System
{
    public partial class ContactAdmin : Form
    {
        public ContactAdmin()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            CustomerForm cust = new CustomerForm();
            cust.Show();
        }

        [System.Runtime.InteropServices.DllImport("wininet.dll")]
        private extern static bool InternetGetConnectedState(out int Description, int ReservedValue);
        public static bool CheckNet()
        {
            int desc;
            return InternetGetConnectedState(out desc, 0);
        }

        string ConverToHtml(string textData)
        {

            // Help from: https://sautinsoft.com/products/rtf-to-html/convert-text-to-html-dotnet-csharp.php

            SautinSoft.RtfToHtml r = new SautinSoft.RtfToHtml
            {
                OutputFormat = SautinSoft.RtfToHtml.eOutputFormat.HTML_401
            };
            r.ImageStyle.IncludeImageInHtml = true;
            string rtf = txtMessage.Rtf;
            string html = r.ConvertString(rtf);

            string htmlString = "";

            string line = "";
            StringReader reader = new StringReader(html);
            while ((line = reader.ReadLine()) != null)
            {
                if (!line.Contains("unlicensed"))
                    htmlString = htmlString + line;
            };
            return htmlString;
        }

        void SendEmail(string stmp)
        {
            try
            {
                string HtmlTextBody = ConverToHtml(txtMessage.Text);

                string password = txtCode.Text;
                NetworkCredential login = new NetworkCredential(txtFromEmail.Text, password);

                SmtpClient client = new SmtpClient(stmp)
                {
                    EnableSsl = true,
                    UseDefaultCredentials = false,
                    Credentials = login,
                    Port = 587
                };


                MailMessage msg = new MailMessage
                {
                    From = new MailAddress(txtFromEmail.Text, txtDisplayName.Text.Trim(), Encoding.UTF8)
                };
                // msg.To.Clear();

                msg.To.Add(new MailAddress(txtToEmail.Text.Trim()));
                //msg.CC.Add(new MailAddress(txtToEmail.Text.Trim()));
                //msg.Bcc.Add(new MailAddress(txtToEmail.Text.Trim()));

                msg.Subject = txtSubject.Text.Trim();
                msg.Body = HtmlTextBody;
                msg.BodyEncoding = Encoding.UTF8;
                msg.IsBodyHtml = true;

                msg.Priority = MailPriority.High;
                msg.DeliveryNotificationOptions = DeliveryNotificationOptions.OnFailure;

                client.SendCompleted += new SendCompletedEventHandler(SendCompletedCallback);
                string userstate = "Sending...";
                //Send email async
                client.SendAsync(msg, userstate);

            }
            catch (Exception ex) { MessageBox.Show(ex.ToString()); }
        }

        private void SendCompletedCallback(object sender, AsyncCompletedEventArgs e)
        {
            if (e.Cancelled)
                MessageBox.Show(string.Format("{0} send Cancelled.", e.UserState), "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            if (e.Error != null)
                MessageBox.Show(string.Format("{0} {1}", e.UserState, e.Error), "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("The emails has been successfully sent.", "Email sent", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void btnEmail_Click(object sender, EventArgs e)
        {
            try
            {

                if (txtFromEmail.Text != string.Empty && txtSubject.Text != string.Empty && txtDisplayName.Text != "" && txtSubject.Text != string.Empty)
                {

                    if (CheckNet())
                    {
                        DialogResult dialogResult = MessageBox.Show("Are you sure to continue ", "", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                        if (dialogResult == DialogResult.OK)
                        {
                            if (radioGmail.Checked)
                                SendEmail(Properties.Settings.Default.SMTP_Gmail);
                            else if (radioHotmail.Checked)
                            {
                                SendEmail(Properties.Settings.Default.SMTP_Hotmail);
                            }
                            else if (radioOutlook.Checked)
                            {
                                SendEmail(Properties.Settings.Default.SMTP_Outlook);
                            }
                            else if (radioYahoo.Checked)
                            {
                                SendEmail(Properties.Settings.Default.SMTP_Yahoo);
                            }
                        }

                    }

                    else
                    {

                        MessageBox.Show("Please check your internet", "No Network", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }


                }
                else
                {

                    //tabControl1.SelectTab(0);

                    MessageBox.Show("Following Fields are required" + Environment.NewLine + "1. Form Email"
                        + Environment.NewLine + "2. App Code"
                        + Environment.NewLine + "3. Display Name"
                        + Environment.NewLine + "4. Subject"
                        , "Field Required", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString(), "Errors", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            /*        if (txtFromEmail.Text == "")
                    {
                        MessageBox.Show("From Email is Required!", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                    else if (txtCode.Text == "")
                    {
                        MessageBox.Show("App Code is Required!", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else if (txtToEmail.Text == "")
                    {
                        MessageBox.Show("To Email is Required!", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else if (txtUrl.Text == "")
                    {
                        MessageBox.Show("URL is Required!", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else if (txtPort.Text == "")
                    {
                        MessageBox.Show("Port is Required!", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    else if (checkBoxSSL.CheckState == CheckState.Unchecked)
                    {
                        MessageBox.Show("SSL is Required!", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else if (txtSubject.Text == "")
                    {
                        MessageBox.Show("Subject is Required!", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else if (txtMessage.Text == "")
                    {
                        MessageBox.Show("Message is Required!", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        return;
                    }
            */
        }



        private void txtCode_Leave(object sender, EventArgs e)
        {
            if (txtCode.Text != "" && (radioOther.Checked != true))
            {
                if (txtCode.Text.Length < 16)
                {
                    MessageBox.Show("The Email App Code can be minimum 16 character", "Invalid App Code", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtCode.Focus();
                    return;
                }
            }
        }

        static string pattern1 = @"(([\w-]+\.)+[\w-]+|([a-zA-Z]{1}|[\w-]{2,}))@" + @"((([0-1]?[0-9]{1,2}|25[0-5]|2[0-4][0-9])\.([0-1]?[0-9]{1,2}|25[0-5]|2[0-4][0-9])\." + @"([0-1]?[0-9]{1,2}|25[0-5]|2[0-4][0-9])\.([0-1]?[0-9]{1,2}|25[0-5]|2[0-4][0-9])){1}|" + @"([a-zA-Z]+[\w-]+\.)+[a-zA-Z]{2,4})";


        private void txtFromEmail_Leave(object sender, EventArgs e)
        {
            if (txtFromEmail.Text != "")
            {
                if (!Regex.IsMatch(txtFromEmail.Text.Trim(), pattern1))
                {
                    MessageBox.Show("From E-mail address format is not correct.", "Incorrect Email Format", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    txtFromEmail.Focus();
                    return;
                }
            }
        }

        private void txtToEmail_Leave(object sender, EventArgs e)
        {
            if (txtToEmail.Text != "")
            {
                if (!Regex.IsMatch(txtToEmail.Text.Trim(), pattern1))
                {
                    MessageBox.Show("To E-mail address format is not correct.", "Incorrect Email Format", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtToEmail.Focus();
                    return;
                }
            }
        }



        private void pictureBox1_Click(object sender, EventArgs e)
        {
            fontDialog1.ShowColor = true;
            fontDialog1.Font = this.txtMessage.Font;
            DialogResult result = fontDialog1.ShowDialog();
            // See if OK was pressed.
            if (result == DialogResult.OK)
            {
                // Get Font.
                Font font = fontDialog1.Font;
                Color color = fontDialog1.Color;
                // Set TextBox properties.
                this.txtMessage.SelectionFont = font;
                this.txtMessage.SelectionColor = color;

            }
        }

        private void hidepassword_Click(object sender, EventArgs e)
        {
            showpassword.Show();
            hidepassword.Hide();
            txtCode.PasswordChar = '\0';
        }

        private void showpassword_Click(object sender, EventArgs e)
        {
            hidepassword.Show();
            showpassword.Hide();
            txtCode.PasswordChar = '*';
        }




        private void txtFromEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            panel1.Hide();
        }

        private void radioGmail_Click_1(object sender, EventArgs e)
        {
            panel1.Hide();
        }

        private void radioYahoo_Click_1(object sender, EventArgs e)
        {
            panel1.Hide();
        }

        private void radioOutlook_Click_1(object sender, EventArgs e)
        {
            panel1.Hide();
        }

        private void radioHotmail_Click_1(object sender, EventArgs e)
        {
            panel1.Hide();
        }

        private void radioOther_Click_1(object sender, EventArgs e)
        {
            panel1.Show();
        }

        private void ContactAdmin_Load(object sender, EventArgs e)
        {
            txtFromEmail.Focus();
        }
    }
    
}
