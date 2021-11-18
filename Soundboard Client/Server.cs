using MaterialSkin.Controls;
using Microsoft.Win32;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web;

namespace Soundboard_Client {
    class Server {
        private static readonly HttpClient client = new HttpClient();

        public Server() {
            client.DefaultRequestHeaders.Add("X-API-KEY", Registry.CurrentUser.OpenSubKey(@"SOFTWARE\SoundboardClient").GetValue("APIKey").ToString());
            client.DefaultRequestHeaders.Add("Connection", "Keep-Alive");
            client.DefaultRequestHeaders.Add("Keep-Alive", "timeout=60");
        }

        public ServerResponse<List<Sound>> GetSounds() {
            ServerResponse<string> reply = SendGetRequest("/sounds");

            if (!reply.IsSuccess()) {
                return new ServerResponse<List<Sound>>(false, null);
            }

            List<Sound> sounds = JsonConvert.DeserializeObject<List<Sound>>(reply.GetResult());
            return new ServerResponse<List<Sound>>(true, sounds);
        }

        public void Authenticate() {
            string apiKey = Registry.CurrentUser.OpenSubKey(@"SOFTWARE\SoundboardClient").GetValue("APIKey").ToString();

            if (!Authenticate(apiKey)) {
                Registry.CurrentUser.OpenSubKey(@"SOFTWARE\SoundboardClient").SetValue("APIKey", "");
                MaterialMessageBox.Show("Your API key has been invalidated. Please restart the application and enter the new key.", false);
                Environment.Exit(0);
            }
        }

        public bool Authenticate(string apiKey) {
            ServerResponse<string> reply = SendGetRequest("/testkey");

            if (reply.IsSuccess() && Boolean.Parse(reply.GetResult())) {
                return true;
            } else {
                return false;
            }
        }

        public ServerResponse<string> Stop() {
            return SendGetRequest("/stop");
        }

        public ServerResponse<string> Skip() {
            return SendGetRequest("/skip");
        }

        public ServerResponse<string> DeleteSound(string soundName) {
            return SendDeleteRequest("/sound/" + soundName);
        }

        public ServerResponse<State> getState() {
            ServerResponse<string> reply = SendGetRequest("/state");

            if (!reply.IsSuccess()) {
                return new ServerResponse<State>(false, null);
            }

            State state = JsonConvert.DeserializeObject<State>(reply.GetResult());
            return new ServerResponse<State>(true, state);
        }

        public ServerResponse<string> Play(string soundName) {
            return SendGetRequest("/play/" + soundName);
        }

        public ServerResponse<string> Upload(string name, string url) {
            Dictionary<string, string> parameters = new Dictionary<string, string>();
            parameters.Add("url", url);

            return SendPostRequest("/sounds/" + name, parameters);
        }


        public ServerResponse<string> TTS(string voice, string text) {
            Dictionary<string, string> parameters = new Dictionary<string, string>();
            parameters.Add("voice", voice);
            parameters.Add("message", text);

            return SendPostRequest("/TTS", parameters);
        }

        public ServerResponse<string> SetVolume(int volume) {
            Dictionary<string, string> parameters = new Dictionary<string, string>();
            parameters.Add("volume", volume.ToString());

            return SendPostRequest("/volume", parameters);
        }

        private ServerResponse<string> SendGetRequest(string path) {
            return SendGetRequest(path, new Dictionary<string, string>());
        }

        private ServerResponse<string> SendGetRequest(string path, Dictionary<string, string> parameters) {
            if (!path.StartsWith("/")) {
                path = "/" + path;
            }

            string fullURL = "https://dannyjelsma.nl/soundboard" + path + "?";

            foreach (KeyValuePair<string, string> parameter in parameters) {
                int converted;
                bool isNumeric = int.TryParse(parameter.Value, out converted);

                if (isNumeric) {
                    fullURL += HttpUtility.UrlEncode(parameter.Key) + "=" + converted + "&";
                } else {
                    fullURL += HttpUtility.UrlEncode(parameter.Key) + "=" + HttpUtility.UrlEncode(parameter.Value) + "&";
                }
            }

            if (fullURL.EndsWith("&")) {
                fullURL = fullURL.Remove(fullURL.Length - 1, 1);
            }
        
            HttpResponseMessage response = Task.Run(async () => await client.GetAsync(fullURL)).Result;
            string responseStr = Task.Run(async () => await response.Content.ReadAsStringAsync()).Result;
            ServerResponse<string> serverResponse;

            if (response.StatusCode == HttpStatusCode.OK) {
                serverResponse = new ServerResponse<string>(true, responseStr);
            } else {
                serverResponse = new ServerResponse<string>(false, (int) response.StatusCode, responseStr);
            }

            return serverResponse;
        }

        private ServerResponse<string> SendPostRequest(string path) {
            return SendPostRequest(path, new Dictionary<string, string>());
        }

        private ServerResponse<string> SendPostRequest(string path, Dictionary<string, string> parameters) {
            if (!path.StartsWith("/")) {
                path = "/" + path;
            }

            string fullURL = "https://dannyjelsma.nl/soundboard" + path;
            string body = "";

            foreach (KeyValuePair<string, string> parameter in parameters) {
                int converted;
                bool isNumeric = int.TryParse(parameter.Value, out converted);

                if (isNumeric) {
                    fullURL += HttpUtility.UrlEncode(parameter.Key) + "=" + converted + "&";
                } else {
                    fullURL += HttpUtility.UrlEncode(parameter.Key) + "=" + HttpUtility.UrlEncode(parameter.Value) + "&";
                }
            }

            if (body.EndsWith("&")) {
                body = body.Remove(body.Length - 1, 1);
            }

            HttpResponseMessage response = Task.Run(async () => await client.PostAsync(fullURL, new StringContent(body))).Result;
            string responseStr = Task.Run(async () => await response.Content.ReadAsStringAsync()).Result;
            ServerResponse<string> serverResponse;

            if (response.StatusCode == HttpStatusCode.OK) {
                serverResponse = new ServerResponse<string>(true, responseStr);
            } else {
                serverResponse = new ServerResponse<string>(false, (int)response.StatusCode, responseStr);
            }

            return serverResponse;
        }

        private ServerResponse<string> SendDeleteRequest(string path) {
            if (!path.StartsWith("/")) {
                path = "/" + path;
            }

            string fullURL = "https://dannyjelsma.nl/soundboard" + path;

            HttpResponseMessage response = Task.Run(async () => await client.DeleteAsync(fullURL)).Result;
            string responseStr = Task.Run(async () => await response.Content.ReadAsStringAsync()).Result;
            ServerResponse<string> serverResponse;

            if (response.StatusCode == HttpStatusCode.OK) {
                serverResponse = new ServerResponse<string>(true, responseStr);
            } else {
                serverResponse = new ServerResponse<string>(false, (int)response.StatusCode, responseStr);
            }

            return serverResponse;
        }
    }
}
