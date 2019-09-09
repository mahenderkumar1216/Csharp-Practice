using SolidPriciples.DependecyInjection.Interfaces;
using SolidPriciples.Refactored;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Web;

namespace SolidPriciples.DependecyInjection.Services
{
    public class NotificationService : INotificationService
    {
        public void NotifyCustomerOrderCreated(Cart cart)
        {
            string customerEmail = cart.CustomerEmail;
            if (!String.IsNullOrEmpty(customerEmail))
            {
                using (var message = new MailMessage("orders@somewhere.com", customerEmail))
                using (var client = new SmtpClient("localhost"))
                {
                    message.Subject = "Your order placed on " + DateTime.Now.ToString();
                    message.Body = "Your order details: \n " + cart.ToString();

                    try
                    {
                        client.Send(message);
                    }
                    catch (Exception ex)
                    {
                        //Logger.Error("Problem sending notification email", ex);
                    }
                }
            }
        }
    }
}