using System;
using System.Collections.Generic;
using System.Text;

namespace Payment.Domain
{
    public class Customer
    {
        public int CustomerId { get; set; }
        public string CustomerName { get; set; }
        public string CustomerAccountNumber { get; set; }
    }
}


/*
 equest Parameter (json string)  {  "creditAccount":"5900174721",  "debitAccount":"1700313889",  
"transactionAmount": "2000.45",  "currencyCode":"NGN",  "narration":"Testing",  "transactionReference":"20191119143501",  "userName":"test",  "password":"test"  }  
 */