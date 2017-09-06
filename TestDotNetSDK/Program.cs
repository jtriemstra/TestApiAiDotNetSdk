using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ApiAiSDK;
using ApiAiSDK.Model;

namespace TestDotNetSDK
{
    class Program
    {
        static ApiAi objApi;
        const String ACCESS_TOKEN = "348dec206c964356bbea514136328194";

        static void Main(string[] args)
        {
            AIConfiguration objConfig = new AIConfiguration(ACCESS_TOKEN, SupportedLanguage.English);
            objApi = new ApiAi(objConfig);

            while (true)
            {
                String strRequest = Console.ReadLine();
                var objResponse = objApi.TextRequest(strRequest);

                Console.WriteLine(objResponse.Result.Fulfillment.Speech);
            }
            
        }
    }
}
