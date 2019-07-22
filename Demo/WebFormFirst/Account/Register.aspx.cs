﻿using System;
using System.Linq;
using System.Web;
using System.Web.UI;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.Owin;
using Owin;
using WebFormFirst.Logic;
using WebFormFirst.Models;

namespace WebFormFirst.Account
{
    public partial class Register : Page
    {
        protected void CreateUser_Click(object sender, EventArgs e)
        {
            var manager = Context.GetOwinContext().GetUserManager<ApplicationUserManager>();
            var signInManager = Context.GetOwinContext().Get<ApplicationSignInManager>();
            var user = new ApplicationUser() { UserName = Email.Text, Email = Email.Text };
            var result = manager.Create(user, Password.Text);
            if (result.Succeeded)
            {
                // 有关如何启用帐户确认和密码重置的详细信息，请访问 https://go.microsoft.com/fwlink/?LinkID=320771
                //string code = manager.GenerateEmailConfirmationToken(user.Id);
                //string callbackUrl = IdentityHelper.GetUserConfirmationRedirectUrl(code, user.Id, Request);
                //manager.SendEmail(user.Id, "确认你的帐户", "请通过单击 <a href=\"" + callbackUrl + "\">此处 </a> 来确认你的帐户。");

                signInManager.SignIn( user, isPersistent: false, rememberBrowser: false);
                using (var usersShoppingCart = new ShoppingCartActions())
                {
                    var cartId = usersShoppingCart.GetCartId();
                    usersShoppingCart.MigrateCart(cartId, user.Id);
                }
                IdentityHelper.RedirectToReturnUrl(Request.QueryString["ReturnUrl"], Response);
            }
            else 
            {
                ErrorMessage.Text = result.Errors.FirstOrDefault();
            }
        }
    }
}