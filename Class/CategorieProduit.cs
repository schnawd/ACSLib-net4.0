using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ACS.Librairie
{
    public class  CategorieProduit
    {
        private static string urlMain = Settings.urlClients;

        public static List<CategorieProduit> Items()
        {
            try
            {
                List<CategorieProduit> result = new List<CategorieProduit>();

                return result;
            }
            catch (Exception e)
            {
                return null;
            }
        }
    }
}
