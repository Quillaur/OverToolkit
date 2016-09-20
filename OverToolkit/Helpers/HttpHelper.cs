using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Windows.Storage.Streams;
using Windows.Web.Http;

namespace OverToolkit.Helpers
{
    /// <summary>
    /// Класс-помощник для работы с HTTP-протоколом.
    /// </summary>
    public static class HttpHelper
    {
        /// <summary>
        /// Отправляет GET-запрос на сервер.
        /// </summary>
        /// <param name="url">URL запроса.</param>
        /// <returns>Ответ с сервера.</returns>
        public static async Task<string> GetAsync(string url)
        {
            using (HttpClient client = new HttpClient())
            {
                try
                {

                    HttpResponseMessage response = await client.GetAsync(new Uri(url));
                    return await response.Content.ReadAsStringAsync();
                }
                catch
                {
                    return string.Empty;
                }
            }
        }

        /// <summary>
        /// Отправляет POST-запрос на сервер.
        /// </summary>
        /// <param name="url">URL запроса.</param>
        /// <param name="parameters">Передаваемые данные.</param>
        /// <returns>Ответ с сервера.</returns>
        public static async Task<string> PostAsync(string url, Dictionary<string, string> parameters)
        {
            using (HttpClient client = new HttpClient())
            {
                try
                {
                    string data = string.Empty;

                    foreach (KeyValuePair<string, string> pair in parameters)
                    {
                        data += pair.Key;
                        data += '=';
                        data += pair.Value;
                        data += '&';
                    }

                    data = data.Substring(0, data.Length - 1);

                    HttpResponseMessage response = await client.PostAsync(new Uri(url),
                            new HttpStringContent(data, UnicodeEncoding.Utf8, "application/x-www-form-urlencoded"));
                    return await response.Content.ReadAsStringAsync();
                }
                catch
                {
                    return string.Empty;
                }
            }
        }
    }
}
