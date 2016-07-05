using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Web_Main.Controllers
{
    public class UsersController : Controller
    {
        //
        // GET: /Users/
        public ActionResult Index()
        {
            return View();
        }

        //public ActionResult Login(LoginModel model, string returnUrl)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        if (_customerSettings.UsernamesEnabled && model.Username != null)
        //        {
        //            model.Username = model.Username.Trim();
        //        }
        //        var loginResult = _customerRegistrationService.ValidateCustomer(model.Email, model.Password);
        //        switch (loginResult)
        //        {
        //            case CustomerLoginResults.Successful:
        //                {
        //                    var customer = _customerSettings.UsernamesEnabled ? _customerService.GetCustomerByUsername(model.Username) : _customerService.GetCustomerByEmail(model.Email);

        //                    //migrate shopping cart
        //                    _shoppingCartService.MigrateShoppingCart(_workContext.CurrentCustomer, customer, true);

        //                    //sign in new customer
        //                    _authenticationService.SignIn(customer, model.RememberMe);

        //                    //raise event       
        //                    _eventPublisher.Publish(new CustomerLoggedinEvent(customer));

        //                    //activity log
        //                    _customerActivityService.InsertActivity("PublicStore.Login", _localizationService.GetResource("ActivityLog.PublicStore.Login"), customer);

        //                    if (String.IsNullOrEmpty(returnUrl) || !Url.IsLocalUrl(returnUrl))
        //                        return RedirectToRoute("HomePage");

        //                    return Redirect(returnUrl);
        //                }
        //            case CustomerLoginResults.CustomerNotExist:
        //                ModelState.AddModelError("", _localizationService.GetResource("Account.Login.WrongCredentials.CustomerNotExist"));
        //                break;
        //            case CustomerLoginResults.Deleted:
        //                ModelState.AddModelError("", _localizationService.GetResource("Account.Login.WrongCredentials.Deleted"));
        //                break;
        //            case CustomerLoginResults.NotActive:
        //                ModelState.AddModelError("", _localizationService.GetResource("Account.Login.WrongCredentials.NotActive"));
        //                break;
        //            case CustomerLoginResults.NotRegistered:
        //                ModelState.AddModelError("", _localizationService.GetResource("Account.Login.WrongCredentials.NotRegistered"));
        //                break;
        //            case CustomerLoginResults.WrongPassword:
        //            default:
        //                ModelState.AddModelError("", _localizationService.GetResource("Account.Login.WrongCredentials"));
        //                break;
        //        }
        //    }

        //    //If we got this far, something failed, redisplay form
        //    model.UsernamesEnabled = _customerSettings.UsernamesEnabled;
        //    model.DisplayCaptcha = _captchaSettings.Enabled && _captchaSettings.ShowOnLoginPage;
        //    return View(model);
        //}

	}
}