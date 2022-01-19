using ecole.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using Voxel.Services.Helpers.WCF;

namespace ecole.proxie.Account
{
    [DataContract(Name = "User1", Namespace = "Ecole.Businesslayer.Etudiants")]
    // REMARQUE : vous pouvez utiliser la commande Renommer du menu Refactoriser pour changer le nom de classe "AccountService" à la fois dans le code et le fichier de configuration.
    public class AccountService : IAccountService
    {
      
        public User EtEtudiantinfo(User email)
        {
            throw new NotImplementedException();
        }

        public bool EtudiantIdAdmit(User user)
        {
            throw new NotImplementedException();
        }
       
        public bool Login(User user)
        {
          
            bool tmpResult = false;
            SyncProxyHelper<AccountService>.Use(
                Endpoint.Name.ecoleCommercialWebService_BasicHttpEndPoint.ToString(),
                serviceProxy =>
                {
                    tmpResult = serviceProxy.Login(user);
                }
            );
            return tmpResult;
        }
    }
}
