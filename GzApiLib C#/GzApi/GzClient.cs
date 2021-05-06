using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using Newtonsoft.Json.Linq;
using System.Runtime.Serialization;
using System.IO;
using Newtonsoft.Json.Serialization;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json;

namespace GzApi
{
    public class GzClient
    {
        public async Task<fz44> GetDataByUrl(string Url)
        {
            using (HttpClient httpClient = new HttpClient())
            {
                string request = Url;

                HttpResponseMessage response = (await httpClient.GetAsync(request)).EnsureSuccessStatusCode();

                string responseBody = await response.Content.ReadAsStringAsync();

                fz44 fz44 = JsonConvert.DeserializeObject<fz44>(responseBody);

                return fz44;
            }
        }

    }

    public class gzclient
    {
        public async Task<fz223> getdatabyurl(string url)
        {
            using (HttpClient http = new HttpClient())
            {

                string Req = url;

                HttpResponseMessage Respon = (await http.GetAsync(Req)).EnsureSuccessStatusCode();

                string Responbody = await Respon.Content.ReadAsStringAsync();

                fz223 fz223 = JsonConvert.DeserializeObject<fz223>(Responbody);

                return fz223;
            }
        }
    }

    public class GozClient
    { 
        public async Task<documents44> Getdatabyurl(string URl)
        {
            using (HttpClient httpCl = new HttpClient())
            {

                string Requ = URl;

                HttpResponseMessage Res = (await httpCl.GetAsync(Requ)).EnsureSuccessStatusCode();

                string Resbody = await Res.Content.ReadAsStringAsync();

                documents44 documents44 = JsonConvert.DeserializeObject<documents44>(Resbody);

                return documents44;
            }
        }
    }

    public class Gozclient
    {
        public async Task<documents223> GetDatabyurl(string URL)
        {
            using (HttpClient httpCl = new HttpClient())
            {

                string Requ = URL;

                HttpResponseMessage Res = (await httpCl.GetAsync(Requ)).EnsureSuccessStatusCode();

                string Resbody = await Res.Content.ReadAsStringAsync();

                documents223 documents223 = JsonConvert.DeserializeObject<documents223>(Resbody);

                return documents223;
            }
        }
    }
}
