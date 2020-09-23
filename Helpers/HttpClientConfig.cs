using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using SoftLearnFrontEnd.Helpers;
using SoftLearnFrontEnd.RequestModels;

namespace SoftLearnFrontEnd.Helpers
{
    public class HttpClientConfig
    {
        //------------------------------------------USE THIS METHOD FOR GET REQUESTS ----------------------
        public async Task<string> ApiGetResponse(string endPoint, string jwtToken)
        {
            using (var httpClient = new HttpClient())
            {
                var url = BaseUrl.baseUrl() + endPoint;
                httpClient.DefaultRequestHeaders.Add("Authorization", "Bearer " + jwtToken);
                string apiResponse = await httpClient.GetStringAsync(url);

                return apiResponse;
            }
        }

        internal Task ApiPostResponse(string v, SchoolSignUpRequestModel model)
        {
            throw new NotImplementedException();
        }

        //------------------------------------------USE THIS METHOD FOR POST REQUESTS ----------------------

        public async Task<string> ApiPostResponse(string endPoint, object obj, string jwtToken)
        {
            using (var httpClient = new HttpClient())
            {
                StringContent content = new StringContent(JsonConvert.SerializeObject(obj), Encoding.UTF8, "application/json");

                var url = BaseUrl.baseUrl() + endPoint; 
                httpClient.DefaultRequestHeaders.Add("Authorization", "Bearer " + jwtToken);

                var response = await httpClient.PostAsync(url, content);
                
                string apiResponse = await response.Content.ReadAsStringAsync();

                return apiResponse;
                    //receivedReservation = JsonConvert.DeserializeObject<Reservation>(apiResponse);
                
            }
        }

        public async Task<string> ApiPutResponse(string endPoint, object obj, string jwtToken)
        {
            using (var httpClient = new HttpClient())
            {
                StringContent content = new StringContent(JsonConvert.SerializeObject(obj), Encoding.UTF8, "application/json");

                var url = BaseUrl.baseUrl() + endPoint;
                httpClient.DefaultRequestHeaders.Add("Authorization", "Bearer " + jwtToken);

                var response = await httpClient.PutAsync(url, content);

                string apiResponse = await response.Content.ReadAsStringAsync();

                return apiResponse;
                //receivedReservation = JsonConvert.DeserializeObject<Reservation>(apiResponse);

            }
        }

        public async Task<string> ApiDeleteResponse(string endPoint, string CancellationToken)
        {
            using (var httpClient = new HttpClient())
            {
               // StringContent content = new StringContent(JsonConvert.SerializeObject(obj), Encoding.UTF8, "application/json");

                var url = BaseUrl.baseUrl() + endPoint;
                httpClient.DefaultRequestHeaders.Add("Authorization", "Bearer " + CancellationToken);

                var response = await httpClient.DeleteAsync(url);

                string apiResponse = await response.Content.ReadAsStringAsync();

                return apiResponse;
                //receivedReservation = JsonConvert.DeserializeObject<Reservation>(apiResponse);

            }
        }
    }
}
