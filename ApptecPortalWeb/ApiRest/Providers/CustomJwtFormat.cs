﻿using ApiRest.Providers;
using Data;
using Microsoft.Owin.Security;
using Microsoft.Owin.Security.DataHandler.Encoder;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.IdentityModel.Tokens;
using System.Linq;
using System.Web;
using Thinktecture.IdentityModel.Tokens;

namespace ApiRest.Providers
{
    public class CustomJwtFormat : ISecureDataFormat<AuthenticationTicket>
    {

        private readonly string _issuer = string.Empty;

        public CustomJwtFormat(string issuer)
        {
            _issuer = issuer;
        }

        public string Protect(AuthenticationTicket data)
        {
            if (data == null)
            {
                throw new ArgumentNullException("data");
            }

            string audienceId = ConfigurationManager.AppSettings["as:AudienceId"];

            string symmetricKeyAsBase64 = ConfigurationManager.AppSettings["as:AudienceSecret"];

            var keyByteArray = TextEncodings.Base64Url.Decode(symmetricKeyAsBase64);

            var signingKey = new HmacSigningCredentials(keyByteArray);

            var issued = data.Properties.IssuedUtc;

            var expires = data.Properties.ExpiresUtc;

            var token = new JwtSecurityToken(_issuer, audienceId, data.Identity.Claims, issued.Value.UtcDateTime, expires.Value.UtcDateTime, signingKey);

            var handler = new JwtSecurityTokenHandler();

            var jwt = handler.WriteToken(token);
            escribirtok(jwt);
            Credenciales credenciales = new Credenciales(jwt);
            
            return jwt;
        }

        public void escribirtok(string tokenn)
        {

            var ya = tokenn;

          

            Credenciales credenciales = new Credenciales();
            string u = credenciales.getUsuario();
            string c = credenciales.getContra();

            AppTecBDEntities contexto = new AppTecBDEntities();


            var tokenDomain = new Autentication
            {
                User = u,
                Pass = c,
                Token = ya,
                Inssued = DateTime.UtcNow,
                Deleted = DateTime.UtcNow.AddDays(1),
                Status = "1"
            };

            contexto.Autentications.Add(tokenDomain);

            contexto.SaveChanges();

        }

        public AuthenticationTicket Unprotect(string protectedText)
        {
            throw new NotImplementedException();
        }
    }
}