using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Transaction_Statistical
{
    class MailUtility
    {
        public static bool SendMail(MailMessage msg=null)
        {
            DataRow row = InitParametar.sqlite.GetRowDataWithColumnName("CfgData", "ID", "876");
            var client = new SmtpClient();
            string fullname = row["Field"].ToString();
            string username = row["Data"].ToString().Split('\n')[0];
            string password = row["Data"].ToString().Split('\n')[1];
            client.Host = row["Data"].ToString().Split('\n')[2];
            client.Port = int.Parse(row["Data"].ToString().Split('\n')[3]);
            client.EnableSsl = bool.Parse(row["Data"].ToString().Split('\n')[4]);

            switch (row["Data"].ToString().Split('\n')[5].ToString())
            {
                case "Machine":
                    client.UseDefaultCredentials = true;
                    break;
                case "None":
                    break;
                case "UsernamePassword":
                    client.Credentials = new NetworkCredential(username, password);
                    break;
            }
            try
            {
                msg.From = new MailAddress(username, fullname);               
                client.Send(msg);
                return true;
            }
            catch (Exception ex)
            {
                InitParametar.Send_Error(ex.ToString(), MethodBase.GetCurrentMethod().DeclaringType.Name, MethodBase.GetCurrentMethod().Name);
            }
            return false;
        }

    }
    public enum SMTPAuthenticationType
    {
        None,
        Machine,
        UsernamePassword
    }

}
