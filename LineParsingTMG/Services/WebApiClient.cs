using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LineParsingTMG.Entities;
using Newtonsoft.Json;
using RestSharp;

namespace LineParsingTMG.Services
{
    class WebApiClient
    {
        private string _myResponse;

        public string text;
        public int stringId;

        public void GetRequest()
        {
            try
            {
                string url = $"http://tmgwebtest.azurewebsites.net/api/textstrings/{stringId}";

                var client = new RestClient(url);

                var request = new RestRequest();

                request.AddHeader("TMG-Api-Key", "0J/RgNC40LLQtdGC0LjQutC4IQ==");

                var response = client.Get(request);

                _myResponse = response.Content.ToString();

                Item item = JsonConvert.DeserializeObject<Item>(_myResponse);

                text = item.text.ToString();
            }
            catch(NullReferenceException)
            {
                text = "null";

            }
            catch(Exception)
            {
                text = "Invalid id";
            }
        }
    }
}
