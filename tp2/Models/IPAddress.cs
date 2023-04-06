namespace tp2.Models;

public class IPAddress
{
    /*
     * {
     * "ip":"205.151.250.221",
     * "success":true,
     * "type":"IPv4",
     * "continent":"North America",
     * "continent_code":"NA",
     * "country":"Canada",
     * "country_code":"CA",
     * "country_flag":"https:\/\/cdn.ipwhois.io\/flags\/ca.svg",
     * "country_capital":"Ottawa",
     * "country_phone":"+1",
     * "country_neighbours":"US",
     * "region":"Qu\u00e9bec",
     * "city":"Longueuil",
     * "latitude":45.5369442,
     * "longitude":-73.5107131,
     * "asn":"AS376",
     * "org":"College Edouard-Montpetit",
     * "isp":"Reseau d'Informations Scientifiques du Quebec (RISQ Inc.)",
     * "timezone":"America\/Toronto",
     * "timezone_name":"EDT",
     * "timezone_dstOffset":3600,
     * "timezone_gmtOffset":-14400,
     * "timezone_gmt":"-04:00",
     * "currency":"Canadian Dollar",
     * "currency_code":"CAD",
     * "currency_symbol":"$",
     * "currency_rates":1.346,
     * "currency_plural":"Canadian Dollars"
     * }
     */
    
    public string ip { get; set; }
    public bool success { get; set; }
    public string type { get; set; }
    public string continent { get; set; }
    public string continent_code { get; set; }
    public string country { get; set; }
    public string country_code { get; set; }
    public string country_flag { get; set; }
    public string country_capital { get; set; }
    public string country_phone { get; set; }
    public string country_neighbours { get; set; }
    public string region { get; set; }
    
    public string city { get; set; }
    public double latitude { get; set; }
    public double longitude { get; set; }
    public string asn { get; set; }
    public string org { get; set; }
    public string isp { get; set; }
    public string timezone { get; set; }
    public string timezone_name { get; set; }
    public int timezone_dstOffset { get; set; }
    public int timezone_gmtOffset { get; set; }
    public string timezone_gmt { get; set; }
    public string currency { get; set; }
    public string currency_code { get; set; }
    public string currency_symbol { get; set; }
    public double currency_rates { get; set; }
    public string currency_plural { get; set; }
    
    public IPAddress(string ip, bool success, string type, string continent, string continent_code, string country, string country_code, string country_flag, string country_capital, string country_phone, string country_neighbours, string region, string city, double latitude, double longitude, string asn, string org, string isp, string timezone, string timezone_name, int timezone_dstOffset, int timezone_gmtOffset, string timezone_gmt, string currency, string currency_code, string currency_symbol, double currency_rates, string currency_plural)
    {
        this.ip = ip;
        this.success = success;
        this.type = type;
        this.continent = continent;
        this.continent_code = continent_code;
        this.country = country;
        this.country_code = country_code;
        this.country_flag = country_flag;
        this.country_capital = country_capital;
        this.country_phone = country_phone;
        this.country_neighbours = country_neighbours;
        this.region = region;
        this.city = city;
        this.latitude = latitude;
        this.longitude = longitude;
        this.asn = asn;
        this.org = org;
        this.isp = isp;
        this.timezone = timezone;
        this.timezone_name = timezone_name;
        this.timezone_dstOffset = timezone_dstOffset;
        this.timezone_gmtOffset = timezone_gmtOffset;
        this.timezone_gmt = timezone_gmt;
        this.currency = currency;
        this.currency_code = currency_code;
        this.currency_symbol = currency_symbol;
        this.currency_rates = currency_rates;
        this.currency_plural = currency_plural;
    }
}