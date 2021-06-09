using System.Threading.Tasks;
using RestSharp;

namespace CretaceousClient.Models
{
  class ApiHelper
  {
    //used for getting all instances within the API
    public static async Task<string> GetAll()
    {
      RestClient client = new RestClient("http://localhost:5000/api");
      RestRequest request = new RestRequest($"animals", Method.GET);
      var response = await client.ExecuteTaskAsync(request);
      return response.Content;
    }

    //used for returning a single instance within the API
    public static async Task<string> Get(int id)
    {
      RestClient client = new RestClient("http://localhost:5000/api");
      RestRequest request = new RestRequest($"animals/{id}", Method.GET);
      var response = await client.ExecuteTaskAsync(request);
      return response.Content;
    }
  }
}