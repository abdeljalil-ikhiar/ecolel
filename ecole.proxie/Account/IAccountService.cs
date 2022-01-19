using ecole.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace ecole.proxie.Account
{
   
    // REMARQUE : vous pouvez utiliser la commande Renommer du menu Refactoriser pour changer le nom d'interface "IAccountService" à la fois dans le code et le fichier de configuration.
    [ServiceContract]
    public interface IAccountService
    {
      
      

            [OperationContract]
            bool EtudiantIdAdmit(User user);
            [OperationContract]
            bool Login(User user);
            [OperationContract]
            User EtEtudiantinfo(User email);
        }
    }

