public class Address
{
    private string _street;
    private string _city;
    private string _province;
    private string _country;

    public Address(string street, string city, string province, string country)
    {
        _street = street;
        _city = city;
        _province = province;
        _country = country;
    }


    public bool isUSA()
    {
        string pais = _country.ToLower();
        return pais == "united states" || pais == "usa";
    }

    public string GetAddress()
    {
        return $"{_street}\n{_city}, {_province}\n{_country}";
    }
}
