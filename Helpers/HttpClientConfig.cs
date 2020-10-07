using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using RestSharp;
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
            //------------------------------------------USE THIS METHOD FOR GET REQUESTS ----------------------

            public async Task<string> GetRestResponse(string endPoint, string jwtToken)
            {
                var url = BaseUrl.baseUrl() + endPoint;

                var client = new RestClient(url);
                var request = new RestRequest(Method.GET);
                request.AddHeader("Authorization", "Bearer " + jwtToken);

                IRestResponse response = await client.ExecuteAsync(request);
                var stringContentResponse = response.Content;

                return stringContentResponse;
            }

        //----------------------------------USE THIS METHOD FOR POST REQUESTS FOR MULTIPARTFORMDATA------------------------------

        public async Task<string> PostRestResponseFormData(string endPoint, RestRequest request, string jwtToken)
            {
                var url = BaseUrl.baseUrl() + endPoint;

                var client = new RestClient(url);
                request.Method = Method.POST;
                request.AddHeader("Authorization", "Bearer " + jwtToken);
                request.AlwaysMultipartFormData = true;
                IRestResponse response = await client.ExecuteAsync(request);
                var stringContentResponse = response.Content;

                return stringContentResponse;

            }

            //----------------------------------USE THIS METHOD FOR POST REQUESTS JSON------------------------------

            public async Task<string> PostRestResponseJson(string endPoint, object obj, string jwtToken)
            {
                var url = BaseUrl.baseUrl() + endPoint;

                var client = new RestClient(url);
                var request = new RestRequest();
                request.Method = Method.POST;

                request.AddHeader("Authorization", "Bearer " + jwtToken);
                request.RequestFormat = DataFormat.Json;
                request.AddJsonBody(obj);

                IRestResponse response = await client.ExecuteAsync(request);
                var stringContentResponse = response.Content;

                return stringContentResponse;

            }
        
    }
}
