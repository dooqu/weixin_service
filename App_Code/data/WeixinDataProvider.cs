using System;
using System.Collections.Generic;
using System.Web;
using System.Net;
using System.IO;
using Newtonsoft.Json;
using com.dooqu.weixin.modals;

namespace com.dooqu.weixin.data
{
    /// <summary>
    /// DataProviderBase 的摘要说明
    /// </summary>
    public class WeixinServiceProvider
    {
        protected string appid;
        protected string secret;
        protected string access_token;
        protected static access_token_data token;
        protected static Dictionary<string, access_token_data> online_tokens;
        protected static object token_state;
        protected static System.Timers.Timer token_update_timer_;

        static WeixinServiceProvider()
        {
            token_state = new object();
            online_tokens = new Dictionary<string, access_token_data>();
           // token_update_timer_ = new System.Timers.Timer(token.expires_in_ * 1000 - 1000 * 180);
        }


        public WeixinServiceProvider(string appid, string secret)
        {
            this.appid = appid;
            this.secret = secret;
        }


        public static Stream GetResponseStream(string url)
        {
            HttpWebRequest request = HttpWebRequest.Create(url) as HttpWebRequest;
            WebResponse response = null;
            request.Timeout = 8000;
            response = request.GetResponse();

            return response.GetResponseStream();       
        }

        public static Stream PostResponseStream(string url, string post_data)
        {
            HttpWebRequest request = HttpWebRequest.Create(url) as HttpWebRequest;
            WebResponse response = null;
            request.Timeout = 8000;
            request.Method = "POST";
            
            byte[] post_bytes = System.Text.Encoding.UTF8.GetBytes(post_data);

            using(Stream post_stream = request.GetRequestStream())
            {
                post_stream.Write(post_bytes, 0, post_bytes.Length);
            }


            response = request.GetResponse();
            return response.GetResponseStream();   
        }


        public static Stream PostResponseStream(string url, Stream user_stream)
        {
            HttpWebRequest request = HttpWebRequest.Create(url) as HttpWebRequest;
            WebResponse response = null;
            request.Timeout = 8000;
            request.Method = "POST";
            request.ContentType = "application/x-www-form-urlencoded";

            byte[] buffer = new byte[1024];

            int read_size;
            using (Stream post_stream = request.GetRequestStream())
            {
                while((read_size =user_stream.Read(buffer, 0, buffer.Length)) > 0)
                post_stream.Write(buffer, 0, read_size);
            }


            response = request.GetResponse();
            return response.GetResponseStream();
        }

        public static string GetResponseStringByPost(string url, string post_data)
        {
            using(Stream stream = PostResponseStream(url, post_data))
            {
                using(StreamReader sr = new StreamReader(stream, System.Text.Encoding.UTF8))
                {
                    return sr.ReadToEnd();
                }
            }
        }


        public static string GetResponseString(string url)
        {
            using (Stream responseStream = GetResponseStream(url))
            {
                using (StreamReader sr = new StreamReader(responseStream, System.Text.Encoding.UTF8))
                {
                    return sr.ReadToEnd();
                }
            }
        }


        public access_token_data GetAccessToken()
        {
            return this.GetAccessToken(false);
        }

        public access_token_data GetAccessToken(bool force_refresh)
        {
            return GetAccessTokenByIDAndSecret(this.appid, this.secret, force_refresh);
        }

        protected static access_token_data GetAccessTokenByIDAndSecret(string appID, string secret, bool force_refresh)
        {
            lock(token_state)
            {
                access_token_data token = null;

                string token_id = appID + "_" + secret;

                if (online_tokens.ContainsKey(token_id))
                    token = online_tokens[token_id];

                if((token == null || token.expires_date <= DateTime.Now.AddMinutes(2)) || force_refresh)
                {
                    string access_token_service_url = "https://api.weixin.qq.com/cgi-bin/token?grant_type=client_credential&appid={0}&secret={1}";
                    string request_url = string.Format(access_token_service_url, appID, secret);
                    string response_string = GetResponseString(request_url);
                    token = JsonConvert.DeserializeObject<access_token_data>(response_string);

                    online_tokens[token_id] = token;                 
                }
               
                return token;
            }

        }

        static void token_update_timer__Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        {
            
        }

        public card_info GetCardInfoById(string cardId)
        {
            card_id_arg card_id_obj = new card_id_arg();
            card_id_obj.card_id = cardId;

            access_token_data token_obj = this.GetAccessToken();

            if(token_obj.no_error == false)
                return null;


            string jsonstr_card_id = JsonConvert.SerializeObject(card_id_obj);

            string response_string = GetResponseStringByPost(string.Format("https://api.weixin.qq.com/card/get?access_token={0}", token_obj.access_token), jsonstr_card_id);

            card_data res_card = JsonConvert.DeserializeObject<card_data>(response_string);

            if (res_card == null)
                return null;

            if (res_card.no_error == false)
                throw new sns_api_exception(res_card);

            return res_card.card;

        }

        public card_id_list_data GetCardIdlist(card_status status, int offset, int count)
        {
            access_token_data token_obj = this.GetAccessToken();

            if (token_obj == null)
                return null;

            if (token_obj.no_error == false)
                throw new sns_api_exception(token_obj);

            card_list_arg post_arg_obj = new card_list_arg();
            post_arg_obj.count = count;
            post_arg_obj.offset = offset;
            post_arg_obj.status_list = new List<string>();

            if((status & card_status.CARD_STATUS_DISPATCH) > 0)
            {
                post_arg_obj.status_list.Add("CARD_STATUS_DISPATCH");
            }
            
            if((status & card_status.CARD_STATUS_VERIFY_OK) > 0)
            {
                post_arg_obj.status_list.Add("CARD_STATUS_VERIFY_OK");
            }
           
            if((status & card_status.CARD_STATUS_VERIFY_FALL) > 0)
            {
                post_arg_obj.status_list.Add("CARD_STATUS_VERIFY_FALL");
            }

            if((status & card_status.CARD_STATUS_NOT_VERIFY) > 0)
            {
                post_arg_obj.status_list.Add("CARD_STATUS_NOT_VERIFY");
            }
           

            string post_data = JsonConvert.SerializeObject(post_arg_obj);

            string response_data = GetResponseStringByPost(string.Format("https://api.weixin.qq.com/card/batchget?access_token={0}", token_obj.access_token), post_data);


            card_id_list_data list_obj = JsonConvert.DeserializeObject<card_id_list_data>(response_data);

            if (list_obj == null)
                return null;

            if (list_obj.no_error == false)
                throw new sns_api_exception(list_obj);

            return list_obj;

        }

        public List<card_info> GetCardlist(card_status status, int offset, int count)
        {
            card_id_list_data id_list = this.GetCardIdlist(status, offset, count);

            if (id_list == null)
                return null;

            if (id_list.no_error == false)
                throw new sns_api_exception(id_list);

            List<card_info> card_list = new List<card_info>(id_list.card_id_list.Count);

            for (int i = 0; i < id_list.card_id_list.Count; i++)
            {
                card_info card = null;

                try
                {
                    card = this.GetCardInfoById(id_list.card_id_list[i]);
                }
                catch(Exception ex)
                {
                    continue;
                }

                if(card != null)
                {
                    card_list.Add(card);
                }
            }

            return card_list;
        }

        public point_list_data GetPoilist(int begin, int limit)
        {
            access_token_data token_obj = this.GetAccessToken();

            if (token_obj == null)
                return null;

            if (token_obj.no_error == false)
                throw new sns_api_exception(token_obj);


            point_list_arg arg = new point_list_arg();
            arg.begin = begin;
            arg.limit = limit;

            string post_data = JsonConvert.SerializeObject(arg);

            string response_data = GetResponseStringByPost(string.Format("https://api.weixin.qq.com/cgi-bin/poi/getpoilist?access_token={0}", token_obj.access_token), post_data);

            point_list_data list = null;

            list = JsonConvert.DeserializeObject<point_list_data>(response_data);

            if (list == null)
                return null;

            if (list.no_error == false)
                throw new sns_api_exception(list);

            return list;
        }


        void PostFileStream(Stream filestream)
        {
            //https://api.weixin.qq.com/cgi-bin/media/upload?access_token=ACCESS_TOKEN&type=TYPE
        }
    }
}
