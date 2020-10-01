using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SpotifyAPI;
using SpotifyAPI.Web;
using SpotifyAPI.Web.Models;



namespace DataSpotify.Helpers
{
    /// <summary>
    /// Singleton for SpotifyWebAPI class.
    /// 
    /// Can't use SpotifyWebAPI as a singleton directly due to the need to initialise it with the access token.
    /// </summary>
    public class API
    {

        public static SpotifyWebAPI s;
        public static SpotifyWebAPI S {get;set;}

        public PrivateProfile UserProfile { get; private set; }

        public bool IsAuthenticated()
        {
            if (S == null) return false;
            if (string.IsNullOrEmpty(S.AccessToken)) return false;
            return true;
        }

        public async Task<bool> Authenticate(string accessToken, string tokenType)
        {
            S = new SpotifyWebAPI()
            {
                AccessToken = accessToken,
                TokenType = tokenType
            };


            UserProfile = await S.GetPrivateProfileAsync();

            // handle faulty logins by checking if UserProfile gets set or not
            // useful for making /callback wait for SpotifyWebAPI to be initialised before redirecting
            return (UserProfile != null);

        }

        public string getArtistsInString(List<SimpleArtist> list)
        {
            string s = "";
            for (int i = 0; i < list.Count(); i++)
            {
                s += list.ElementAt(i);
                if (i != list.Count() - 1)
                    s += ", ";
            }

            return s;
        }

    }
}
