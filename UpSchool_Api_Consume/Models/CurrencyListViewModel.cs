namespace UpSchool_Api_Consume.Models
{
    public class CurrencyListViewModel
    {

   
       
            public string base_currency_date { get; set; } 
            public string base_currency { get; set; }
            public Exchange_Rates[] exchange_rates { get; set; }
      
            public class Exchange_Rates  //Nested json property
        {
            public string currency { get; set; }
            public string exchange_rate_buy { get; set; }
            }

    }
}
