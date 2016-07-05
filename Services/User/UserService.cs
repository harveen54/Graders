using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Web.Security;


namespace Services.User
{
   public class UserService
    {
        private readonly TimeSpan _expirationTimeSpan;

        public UserService()
        {
            this._expirationTimeSpan = FormsAuthentication.Timeout;
        }
        public  HttpCookie SignIn(string customer, bool createPersistentCookie)
        {
            var now = DateTime.UtcNow.ToLocalTime();

            var ticket = new FormsAuthenticationTicket(
                1 /*version*/,
               // customer.Email,
               customer,
                now,
                now.Add(_expirationTimeSpan),
                createPersistentCookie,
                customer,
                FormsAuthentication.FormsCookiePath);

            var encryptedTicket = FormsAuthentication.Encrypt(ticket);
            
            var cookie = new HttpCookie("graders", encryptedTicket);
            cookie.HttpOnly = true;
            if (ticket.IsPersistent)
            {
                cookie.Expires = ticket.Expiration;
            }
            cookie.Secure = FormsAuthentication.RequireSSL;
            cookie.Path = FormsAuthentication.FormsCookiePath;
            if (FormsAuthentication.CookieDomain != null)
            {
                cookie.Domain = FormsAuthentication.CookieDomain;
            }
           // cookie.Name = "graders";
            //_httpContext.Response.Cookies.Add(cookie);
            //var _cachedCustomer = customer;
            return cookie;
        }

        /// <summary>
        /// Get authenticated customer
        /// </summary>
        /// <param name="ticket">Ticket</param>
        /// <returns>Customer</returns>
        protected void GetAuthenticatedCustomerFromTicket(FormsAuthenticationTicket ticket)
        {
            if (ticket == null)
                throw new ArgumentNullException("ticket");

            var usernameOrEmail = ticket.UserData;

            //if (String.IsNullOrWhiteSpace(usernameOrEmail))
            //    return null;
            //var customer = _customerSettings.UsernamesEnabled
            //    ? _customerService.GetCustomerByUsername(usernameOrEmail)
            //    : _customerService.GetCustomerByEmail(usernameOrEmail);
          //  return customer;
        }

        /// <summary>
        /// Sign out
        /// </summary>
        public virtual void SignOut()
        {
          //  _cachedCustomer = null;
            FormsAuthentication.SignOut();
        }

        /// <summary>
        /// Get authenticated customer
        /// </summary>
        /// <returns>Customer</returns>
        public void GetAuthenticatedCustomer(HttpContextBase _httpContext)
        {
            //if (_cachedCustomer != null)
            //    return _cachedCustomer;

            if (_httpContext == null ||
                _httpContext.Request == null ||
                !_httpContext.Request.IsAuthenticated ||
                !(_httpContext.User.Identity is FormsIdentity))
            {
               // return null;
            }

            var formsIdentity = (FormsIdentity)_httpContext.User.Identity;
            GetAuthenticatedCustomerFromTicket(formsIdentity.Ticket);
            //if (customer != null && customer.Active && !customer.Deleted && customer.IsRegistered())
            //    _cachedCustomer = customer;
           // return _cachedCustomer;
        }


    }
}
