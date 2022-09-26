using MongoDB.Bson;
using System.Globalization;
using System.Text.RegularExpressions;

namespace Samauma.Util
{
    public static class RegexUtilities
    {
        public static bool IsValidEmailAdress(string emailAdress)
        {
            if (string.IsNullOrWhiteSpace(emailAdress))
                return false;

            try
            {
                emailAdress = Regex.Replace(emailAdress, @"(@)(.+)$", DomainMapper,
                                      RegexOptions.None, TimeSpan.FromMilliseconds(200));

                static string DomainMapper(Match match)
                {
                    var idn = new IdnMapping();
                    string domainName = idn.GetAscii(match.Groups[2].Value);
                    return match.Groups[1].Value + domainName;
                }
            }
            catch (RegexMatchTimeoutException)
            {
                return false;
            }
            catch (ArgumentException)
            {
                return false;
            }

            try
            {
                return Regex.IsMatch(emailAdress,
                    @"^[^@\s]+@[^@\s]+\.[^@\s]+$",
                    RegexOptions.IgnoreCase, TimeSpan.FromMilliseconds(250));
            }
            catch (RegexMatchTimeoutException)
            {
                return false;
            }
        }

        public static bool IsValidUrl(string url)
            => Uri.TryCreate(url, UriKind.Absolute, out Uri? uriResult)
            && uriResult is not null 
            && (uriResult.Scheme == Uri.UriSchemeHttp ||
            uriResult.Scheme == Uri.UriSchemeHttps);

        public static bool IsValidPassword(string password)
            => int.TryParse(password, out _) && password.Length < 7;

        public static bool IsValidMongoObjectId(string objectId)
            => ObjectId.TryParse(objectId, out _);
    }
}
