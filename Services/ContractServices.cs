using ExercícioInterface.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercícioInterface.Services
{
    internal class ContractServices
    {
        IOnlinePaymentService _onlinePaymentService;

        public ContractServices(IOnlinePaymentService onlinePaymentService)
        {
            _onlinePaymentService = onlinePaymentService;
        }

        public void ProccessContract(Contract contract, int months)
        {
            double basicQuoota

        

        }

    }
}
