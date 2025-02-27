using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//public class Location
//{
//    public string Name { get; set; }
//}

//namespace WeddingPlanner
//{
//    public class LocationData
//    {
//        public static List<Location> GetLocations()
//        {
//            return new List<Location>
//        {
//            new Location { Name = "Andhra Pradesh" },
//            new Location { Name = "Arunachal Pradesh" },
//            new Location { Name = "Assam" },
//            new Location { Name = "Bihar" },
//            new Location { Name = "Chhattisgarh" },
//            new Location { Name = "Goa" },
//            new Location { Name = "Gujarat" },
//            new Location { Name = "Haryana" },
//            new Location { Name = "Himachal Pradesh" },
//            new Location { Name = "Jharkhand" },
//            new Location { Name = "Karnataka" },
//            new Location { Name = "Kerala" },
//            new Location { Name = "Madhya Pradesh" },
//            new Location { Name = "Maharashtra" },
//            new Location { Name = "Manipur" },
//            new Location { Name = "Meghalaya" },
//            new Location { Name = "Mizoram" },
//            new Location { Name = "Nagaland" },
//            new Location { Name = "Odisha" },
//            new Location { Name = "Punjab" },
//            new Location { Name = "Rajasthan" },
//            new Location { Name = "Sikkim" },
//            new Location { Name = "Tamil Nadu" },
//            new Location { Name = "Telangana" },
//            new Location { Name = "Tripura" },
//            new Location { Name = "Uttar Pradesh" },
//            new Location { Name = "Uttarakhand" },
//            new Location { Name = "West Bengal" },
//            new Location { Name = "Andaman and Nicobar Islands" },
//            new Location { Name = "Chandigarh" },
//            new Location { Name = "Dadra and Nagar Haveli and Daman and Diu" },
//            new Location { Name = "Lakshadweep" },
//            new Location { Name = "Delhi" },
//            new Location { Name = "Puducherry" },
//            new Location { Name = "Ladakh" },
//            new Location { Name = "Jammu and Kashmir" }
//        };
//        }
//    }
//}
//public class Location
//{
//    public string State { get; set; }
//    public List<string> Cities { get; set; }
//}

//public class LocationData
//{
//    public static List<Location> GetLocations()
//    {
//        return new List<Location>
//        {
//            new Location
//            {
//                State = "Andhra Pradesh",
//                Cities = new List<string> { "Vijayawada", "Visakhapatnam", "Guntur", "Nellore", "Tirupati" }
//            },
//            new Location
//            {
//                State = "Arunachal Pradesh",
//                Cities = new List<string> { "Itanagar", "Tawang", "Pasighat", "Ziro", "Bomdila" }
//            },
//            new Location
//            {
//                State = "Assam",
//                Cities = new List<string> { "Guwahati", "Dibrugarh", "Silchar", "Jorhat", "Tinsukia" }
//            },
//            new Location
//            {
//                State = "Bihar",
//                Cities = new List<string> { "Patna", "Gaya", "Bhagalpur", "Muzaffarpur", "Purnia" }
//            },
//            new Location
//            {
//                State = "Chhattisgarh",
//                Cities = new List<string> { "Raipur", "Bhilai", "Bilaspur", "Korba", "Durg" }
//            },
//            new Location
//            {
//                State = "Goa",
//                Cities = new List<string> { "Panaji", "Margao", "Vasco da Gama", "Mapusa", "Ponda" }
//            },
//            new Location
//            {
//                State = "Gujarat",
//                Cities = new List<string> { "Ahmedabad", "Surat", "Vadodara", "Rajkot", "Bhavnagar" }
//            },
//            new Location
//            {
//                State = "Haryana",
//                Cities = new List<string> { "Gurugram", "Faridabad", "Panipat", "Ambala", "Hisar" }
//            },
//            new Location
//            {
//                State = "Himachal Pradesh",
//                Cities = new List<string> { "Shimla", "Manali", "Dharamshala", "Kullu", "Solan" }
//            },
//            new Location
//            {
//                State = "Jharkhand",
//                Cities = new List<string> { "Ranchi", "Jamshedpur", "Dhanbad", "Bokaro", "Deoghar" }
//            },
//            new Location
//            {
//                State = "Karnataka",
//                Cities = new List<string> { "Bengaluru", "Mysuru", "Mangaluru", "Hubballi", "Belagavi" }
//            },
//            new Location
//            {
//                State = "Kerala",
//                Cities = new List<string> { "Thiruvananthapuram", "Kochi", "Kozhikode", "Thrissur", "Alappuzha" }
//            },
//            new Location
//            {
//                State = "Madhya Pradesh",
//                Cities = new List<string> { "Bhopal", "Indore", "Gwalior", "Jabalpur", "Ujjain" }
//            },
//            new Location
//            {
//                State = "Maharashtra",
//                Cities = new List<string> { "Mumbai", "Pune", "Nagpur", "Thane", "Nashik" }
//            },
//            new Location
//            {
//                State = "Manipur",
//                Cities = new List<string> { "Imphal", "Thoubal", "Bishnupur", "Churachandpur", "Ukhrul" }
//            },
//            new Location
//            {
//                State = "Meghalaya",
//                Cities = new List<string> { "Shillong", "Tura", "Jowai", "Nongpoh", "Baghmara" }
//            },
//            new Location
//            {
//                State = "Mizoram",
//                Cities = new List<string> { "Aizawl", "Lunglei", "Serchhip", "Champhai", "Kolasib" }
//            },
//            new Location
//            {
//                State = "Nagaland",
//                Cities = new List<string> { "Kohima", "Dimapur", "Mokokchung", "Tuensang", "Wokha" }
//            },
//            new Location
//            {
//                State = "Odisha",
//                Cities = new List<string> { "Bhubaneswar", "Cuttack", "Rourkela", "Puri", "Sambalpur" }
//            },
//            new Location
//            {
//                State = "Punjab",
//                Cities = new List<string> { "Amritsar", "Ludhiana", "Patiala", "Jalandhar", "Bathinda" }
//            },
//            new Location
//            {
//                State = "Rajasthan",
//                Cities = new List<string> { "Jaipur", "Jodhpur", "Udaipur", "Ajmer", "Bikaner" }
//            },
//            new Location
//            {
//                State = "Sikkim",
//                Cities = new List<string> { "Gangtok", "Namchi", "Mangan", "Geyzing", "Rangpo" }
//            },
//            new Location
//            {
//                State = "Tamil Nadu",
//                Cities = new List<string> { "Chennai", "Coimbatore", "Madurai", "Tiruchirappalli", "Salem" }
//            },
//            new Location
//            {
//                State = "Telangana",
//                Cities = new List<string> { "Hyderabad", "Warangal", "Nizamabad", "Karimnagar", "Khammam" }
//            },
//            new Location
//            {
//                State = "Tripura",
//                Cities = new List<string> { "Agartala", "Udaipur", "Dharmanagar", "Kailasahar", "Belonia" }
//            },
//            new Location
//            {
//                State = "Uttar Pradesh",
//                Cities = new List<string> { "Lucknow", "Kanpur", "Varanasi", "Agra", "Meerut" }
//            },
//            new Location
//            {
//                State = "Uttarakhand",
//                Cities = new List<string> { "Dehradun", "Haridwar", "Nainital", "Rishikesh", "Roorkee" }
//            },
//            new Location
//            {
//                State = "West Bengal",
//                Cities = new List<string> { "Kolkata", "Howrah", "Darjeeling", "Asansol", "Siliguri" }
//            },
//            // Union Territories
//            new Location
//            {
//                State = "Andaman and Nicobar Islands",
//                Cities = new List<string> { "Port Blair", "Car Nicobar", "Havelock Island", "Neil Island", "Diglipur" }
//            },
//            new Location
//            {
//                State = "Chandigarh",
//                Cities = new List<string> { "Chandigarh" }
//            },
//            new Location
//            {
//                State = "Dadra and Nagar Haveli and Daman and Diu",
//                Cities = new List<string> { "Silvassa", "Daman", "Diu" }
//            },
//            new Location
//            {
//                State = "Lakshadweep",
//                Cities = new List<string> { "Kavaratti", "Agatti", "Minicoy", "Amini", "Andrott" }
//            },
//            new Location
//            {
//                State = "Delhi",
//                Cities = new List<string> { "New Delhi" }
//            },
//            new Location
//            {
//                State = "Puducherry",
//                Cities = new List<string> { "Puducherry", "Karaikal", "Mahe", "Yanam" }
//            },
//            new Location
//            {
//                State = "Jammu and Kashmir",
//                Cities = new List<string> { "Srinagar", "Jammu", "Anantnag", "Baramulla", "Udhampur" }
//            },
//            new Location
//            {
//                State = "Ladakh",
//                Cities = new List<string> { "Leh", "Kargil" }
//            }
//        };
//    }
//}
public class Location
{
    public string State { get; set; }
    public List<City> Cities { get; set; }
}

public class City
{
    public string Name { get; set; }
    public string Pincode { get; set; }
}

public class LocationData
{
    public static List<Location> GetLocations()
    {
        return new List<Location>
        {
           
            new Location
            {
               State = "Andhra Pradesh",
               Cities = new List<City>
                {
                    new City { Name = "Amaravati", Pincode = "522020" },
                    new City { Name = "Anantapur", Pincode = "515001" },
                    new City { Name = "Chittoor", Pincode = "517001" },
                    new City { Name = "Eluru", Pincode = "534001" },
                    new City { Name = "Guntur", Pincode = "522001" },
                    new City { Name = "Kadapa", Pincode = "516001" },
                    new City { Name = "Kakinada", Pincode = "533001" },
                    new City { Name = "Kurnool", Pincode = "518001" },
                    new City { Name = "Nellore", Pincode = "524001" },
                    new City { Name = "Ongole", Pincode = "523001" },
                    new City { Name = "Rajahmundry", Pincode = "533101" },
                    new City { Name = "Srikakulam", Pincode = "532001" },
                    new City { Name = "Tirupati", Pincode = "517501" },
                    new City { Name = "Vijayawada", Pincode = "520001" },
                    new City { Name = "Visakhapatnam", Pincode = "530001" },
                    new City { Name = "Vizianagaram", Pincode = "535001" },
                    new City { Name = "Machilipatnam", Pincode = "521001" },
                    new City { Name = "Nandyal", Pincode = "518501" },
                    new City { Name = "Tenali", Pincode = "522201" }
               }
            },
           new Location
{
    State = "Arunachal Pradesh",
    Cities = new List<City>
    {
        new City { Name = "Itanagar", Pincode = "791111" },
        new City { Name = "Tawang", Pincode = "790104" },
        new City { Name = "Ziro", Pincode = "791120" },
        new City { Name = "Pasighat", Pincode = "791102" },
        new City { Name = "Tezu", Pincode = "792001" },
        new City { Name = "Naharlagun", Pincode = "791110" },
        new City { Name = "Bomdila", Pincode = "790001" },
        new City { Name = "Aalo (Along)", Pincode = "791001" },
        new City { Name = "Roing", Pincode = "792110" },
        new City { Name = "Seppa", Pincode = "790102" },
        new City { Name = "Khonsa", Pincode = "786630" },
        new City { Name = "Changlang", Pincode = "792120" },
        new City { Name = "Yingkiong", Pincode = "791002" },
        new City { Name = "Namsai", Pincode = "792103" },
        new City { Name = "Daporijo", Pincode = "791122" }
    }
},
           new Location
{
    State = "Assam",
    Cities = new List<City>
    {
        new City { Name = "Guwahati", Pincode = "781001" },
        new City { Name = "Dibrugarh", Pincode = "786001" },
        new City { Name = "Silchar", Pincode = "788001" },
        new City { Name = "Tezpur", Pincode = "784001" },
        new City { Name = "Jorhat", Pincode = "785001" },
        new City { Name = "Tinsukia", Pincode = "786125" },
        new City { Name = "Nagaon", Pincode = "782001" },
        new City { Name = "Sivasagar", Pincode = "785640" },
        new City { Name = "Goalpara", Pincode = "783101" },
        new City { Name = "Karimganj", Pincode = "788710" },
        new City { Name = "Dhubri", Pincode = "783301" },
        new City { Name = "Bongaigaon", Pincode = "783380" },
        new City { Name = "Barpeta", Pincode = "781301" },
        new City { Name = "Golaghat", Pincode = "785621" },
        new City { Name = "Hailakandi", Pincode = "788151" },
        new City { Name = "Lakhimpur", Pincode = "787001" },
        new City { Name = "Morigaon", Pincode = "782105" },
        new City { Name = "Kokrajhar", Pincode = "783370" },
        new City { Name = "Biswanath Chariali", Pincode = "784176" },
        new City { Name = "Hojai", Pincode = "782435" },
        new City { Name = "Majuli", Pincode = "785104" },
        new City { Name = "Diphu", Pincode = "782460" }
    }
},
           new Location
{
    State = "Bihar",
    Cities = new List<City>
    {
        new City { Name = "Patna", Pincode = "800001" },
        new City { Name = "Gaya", Pincode = "823001" },
        new City { Name = "Bhagalpur", Pincode = "812001" },
        new City { Name = "Muzaffarpur", Pincode = "842001" },
        new City { Name = "Darbhanga", Pincode = "846001" },
        new City { Name = "Purnia", Pincode = "854301" },
        new City { Name = "Arrah", Pincode = "802301" },
        new City { Name = "Begusarai", Pincode = "851101" },
        new City { Name = "Katihar", Pincode = "854105" },
        new City { Name = "Saharsa", Pincode = "852201" },
        new City { Name = "Chhapra", Pincode = "841301" },
        new City { Name = "Munger", Pincode = "811201" },
        new City { Name = "Bihar Sharif", Pincode = "803101" },
        new City { Name = "Hajipur", Pincode = "844101" },
        new City { Name = "Siwan", Pincode = "841226" },
        new City { Name = "Motihari", Pincode = "845401" },
        new City { Name = "Nawada", Pincode = "805110" },
        new City { Name = "Samastipur", Pincode = "848101" },
        new City { Name = "Sasaram", Pincode = "821115" },
        new City { Name = "Aurangabad", Pincode = "824101" },
        new City { Name = "Jehanabad", Pincode = "804408" },
        new City { Name = "Madhubani", Pincode = "847211" },
        new City { Name = "Khagaria", Pincode = "851204" },
        new City { Name = "Bettiah", Pincode = "845438" }
    }
},
           new Location
{
    State = "Chhattisgarh",
    Cities = new List<City>
    {
        new City { Name = "Raipur", Pincode = "492001" },
        new City { Name = "Bilaspur", Pincode = "495001" },
        new City { Name = "Durg", Pincode = "491001" },
        new City { Name = "Bhilai", Pincode = "490001" },
        new City { Name = "Korba", Pincode = "495677" },
        new City { Name = "Jagdalpur", Pincode = "494001" },
        new City { Name = "Raigarh", Pincode = "496001" },
        new City { Name = "Ambikapur", Pincode = "497001" },
        new City { Name = "Rajnandgaon", Pincode = "491441" },
        new City { Name = "Kanker", Pincode = "494334" },
        new City { Name = "Dantewada", Pincode = "494449" },
        new City { Name = "Mahasamund", Pincode = "493445" },
        new City { Name = "Dhamtari", Pincode = "493773" },
        new City { Name = "Chirmiri", Pincode = "497451" },
        new City { Name = "Kawardha", Pincode = "491995" },
        new City { Name = "Bemetara", Pincode = "491335" },
        new City { Name = "Janjgir", Pincode = "495668" },
        new City { Name = "Sukma", Pincode = "494111" },
        new City { Name = "Surajpur", Pincode = "497229" },
        new City { Name = "Balod", Pincode = "491226" }
    }
},
           new Location
{
    State = "Goa",
    Cities = new List<City>
    {
        new City { Name = "Panaji", Pincode = "403001" },
        new City { Name = "Vasco da Gama", Pincode = "403802" },
        new City { Name = "Margao", Pincode = "403601" },
        new City { Name = "Mapusa", Pincode = "403507" },
        new City { Name = "Ponda", Pincode = "403401" },
        new City { Name = "Bicholim", Pincode = "403504" },
        new City { Name = "Curchorem", Pincode = "403706" },
        new City { Name = "Canacona", Pincode = "403702" },
        new City { Name = "Sanquelim", Pincode = "403505" },
        new City { Name = "Sanguem", Pincode = "403704" },
        new City { Name = "Quepem", Pincode = "403705" },
        new City { Name = "Dona Paula", Pincode = "403004" }
    }
},
           new Location
{
    State = "Gujarat",
    Cities = new List<City>
    {
        new City { Name = "Ahmedabad", Pincode = "380001" },
        new City { Name = "Surat", Pincode = "395001" },
        new City { Name = "Vadodara", Pincode = "390001" },
        new City { Name = "Rajkot", Pincode = "360001" },
        new City { Name = "Bhavnagar", Pincode = "364001" },
        new City { Name = "Jamnagar", Pincode = "361001" },
        new City { Name = "Gandhinagar", Pincode = "382010" },
        new City { Name = "Junagadh", Pincode = "362001" },
        new City { Name = "Anand", Pincode = "388001" },
        new City { Name = "Navsari", Pincode = "396445" },
        new City { Name = "Bharuch", Pincode = "392001" },
        new City { Name = "Patan", Pincode = "384265" },
        new City { Name = "Mehsana", Pincode = "384001" },
        new City { Name = "Vapi", Pincode = "396191" },
        new City { Name = "Morbi", Pincode = "363641" },
        new City { Name = "Porbandar", Pincode = "360575" },
        new City { Name = "Amreli", Pincode = "365601" },
        new City { Name = "Surendranagar", Pincode = "363001" },
        new City { Name = "Nadiad", Pincode = "387001" },
        new City { Name = "Godhra", Pincode = "389001" },
        new City { Name = "Palanpur", Pincode = "385001" },
        new City { Name = "Dahod", Pincode = "389151" },
        new City { Name = "Bhuj", Pincode = "370001" },
        new City { Name = "Valsad", Pincode = "396001" },
        new City { Name = "Veraval", Pincode = "362265" },
        new City { Name = "Gondal", Pincode = "360311" },
        new City { Name = "Botad", Pincode = "364710" },
        new City { Name = "Kheda", Pincode = "387411" },
        new City { Name = "Dholka", Pincode = "382225" },
        new City { Name = "Modasa", Pincode = "383315" },
        new City { Name = "Himmatnagar", Pincode = "383001" }
    }
},
           new Location
{
    State = "Haryana",
    Cities = new List<City>
    {
        new City { Name = "Chandigarh", Pincode = "160001" },
        new City { Name = "Faridabad", Pincode = "121001" },
        new City { Name = "Gurugram", Pincode = "122018" },
        new City { Name = "Ambala", Pincode = "134001" },
        new City { Name = "Hisar", Pincode = "125001" },
        new City { Name = "Karnal", Pincode = "132001" },
        new City { Name = "Panipat", Pincode = "132103" },
        new City { Name = "Rohtak", Pincode = "124001" },
        new City { Name = "Sonipat", Pincode = "131001" },
        new City { Name = "Jind", Pincode = "126102" }
    }
},
           new Location
{
    State = "Himachal Pradesh",
    Cities = new List<City>
    {
        new City { Name = "Shimla", Pincode = "171001" },
        new City { Name = "Manali", Pincode = "175131" },
        new City { Name = "Dharamshala", Pincode = "176215" },
        new City { Name = "Solan", Pincode = "173212" },
        new City { Name = "Mandi", Pincode = "175001" },
        new City { Name = "Kullu", Pincode = "175101" },
        new City { Name = "Hamirpur", Pincode = "177001" },
        new City { Name = "Una", Pincode = "174303" },
        new City { Name = "Bilaspur", Pincode = "174001" },
        new City { Name = "Chamba", Pincode = "176310" }
    }
},
           new Location
{
    State = "Jharkhand",
    Cities = new List<City>
    {
        new City { Name = "Ranchi", Pincode = "834001" },
        new City { Name = "Jamshedpur", Pincode = "831001" },
        new City { Name = "Dhanbad", Pincode = "826001" },
        new City { Name = "Bokaro", Pincode = "827001" },
        new City { Name = "Hazaribagh", Pincode = "825301" },
        new City { Name = "Giridih", Pincode = "815301" },
        new City { Name = "Chaibasa", Pincode = "833201" },
        new City { Name = "Deoghar", Pincode = "814112" },
        new City { Name = "Dumka", Pincode = "814101" },
        new City { Name = "Koderma", Pincode = "825410" }
    }
},
           new Location
{
    State = "Karnataka",
    Cities = new List<City>
    {
        new City { Name = "Bengaluru", Pincode = "560001" },
        new City { Name = "Mysuru", Pincode = "570001" },
        new City { Name = "Hubballi", Pincode = "580020" },
        new City { Name = "Davanagere", Pincode = "577001" },
        new City { Name = "Belagavi", Pincode = "590001" },
        new City { Name = "Tumakuru", Pincode = "572101" },
        new City { Name = "Mangaluru", Pincode = "575001" },
        new City { Name = "Bagalkot", Pincode = "587101" },
        new City { Name = "Gulbarga", Pincode = "585101" },
        new City { Name = "Shimoga", Pincode = "577201" }
    }
},
           new Location
{
    State = "Kerala",
    Cities = new List<City>
    {
        new City { Name = "Thiruvananthapuram", Pincode = "695001" },
        new City { Name = "Kochi", Pincode = "682001" },
        new City { Name = "Kozhikode", Pincode = "673001" },
        new City { Name = "Thrissur", Pincode = "680001" },
        new City { Name = "Kannur", Pincode = "670001" },
        new City { Name = "Palakkad", Pincode = "678001" },
        new City { Name = "Kottayam", Pincode = "686001" },
        new City { Name = "Alappuzha", Pincode = "688001" },
        new City { Name = "Malappuram", Pincode = "676505" },
        new City { Name = "Idukki", Pincode = "685603" }
    }
},
           new Location
{
    State = "Madhya Pradesh",
    Cities = new List<City>
    {
        new City { Name = "Bhopal", Pincode = "462001" },
        new City { Name = "Indore", Pincode = "452001" },
        new City { Name = "Gwalior", Pincode = "474001" },
        new City { Name = "Jabalpur", Pincode = "482001" },
        new City { Name = "Ujjain", Pincode = "456001" },
        new City { Name = "Sagar", Pincode = "470001" },
        new City { Name = "Rewa", Pincode = "486001" },
        new City { Name = "Satna", Pincode = "485001" },
        new City { Name = "Dewas", Pincode = "455001" },
        new City { Name = "Khargone", Pincode = "451001" }
    }
},
           new Location
{
    State = "Maharashtra",
    Cities = new List<City>
    {
        new City { Name = "Mumbai", Pincode = "400001" },
        new City { Name = "Pune", Pincode = "411001" },
        new City { Name = "Nagpur", Pincode = "440001" },
        new City { Name = "Thane", Pincode = "400601" },
        new City { Name = "Nashik", Pincode = "422001" },
        new City { Name = "Aurangabad", Pincode = "431001" },
        new City { Name = "Kolhapur", Pincode = "416001" },
        new City { Name = "Solapur", Pincode = "413001" },
        new City { Name = "Amravati", Pincode = "444601" },
        new City { Name = "Jalgaon", Pincode = "425001" }
    }
},
           new Location
{
    State = "Manipur",
    Cities = new List<City>
    {
        new City { Name = "Imphal", Pincode = "795001" },
        new City { Name = "Thoubal", Pincode = "795138" },
        new City { Name = "Kakching", Pincode = "795103" },
        new City { Name = "Ukhrul", Pincode = "795142" },
        new City { Name = "Churachandpur", Pincode = "795128" },
        new City { Name = "Senapati", Pincode = "795106" }
    }
},
           new Location
{
    State = "Meghalaya",
    Cities = new List<City>
    {
        new City { Name = "Shillong", Pincode = "793001" },
        new City { Name = "Tura", Pincode = "794001" },
        new City { Name = "Jowai", Pincode = "793150" },
        new City { Name = "Nongstoin", Pincode = "793119" },
        new City { Name = "Mawkyrwat", Pincode = "793114" }
    }
},
           new Location
{
    State = "Mizoram",
    Cities = new List<City>
    {
        new City { Name = "Aizawl", Pincode = "796001" },
        new City { Name = "Lunglei", Pincode = "796701" },
        new City { Name = "Champhai", Pincode = "796321" },
        new City { Name = "Serchhip", Pincode = "796181" },
        new City { Name = "Kolasib", Pincode = "796081" }
    }
},
           new Location
{
    State = "Nagaland",
    Cities = new List<City>
    {
        new City { Name = "Kohima", Pincode = "797001" },
        new City { Name = "Dimapur", Pincode = "797112" },
        new City { Name = "Mokokchung", Pincode = "798601" },
        new City { Name = "Tuensang", Pincode = "798612" },
        new City { Name = "Wokha", Pincode = "797001" }
    }
},
           new Location
{
    State = "Odisha",
    Cities = new List<City>
    {
        new City { Name = "Bhubaneswar", Pincode = "751001" },
        new City { Name = "Cuttack", Pincode = "753001" },
        new City { Name = "Berhampur", Pincode = "760001" },
        new City { Name = "Rourkela", Pincode = "769001" },
        new City { Name = "Sambalpur", Pincode = "768001" },
        new City { Name = "Balasore", Pincode = "756001" },
        new City { Name = "Barbil", Pincode = "758035" },
        new City { Name = "Jharsuguda", Pincode = "768201" },
        new City { Name = "Koraput", Pincode = "764020" },
        new City { Name = "Angul", Pincode = "759122" }
    }
},
           new Location
{
    State = "Punjab",
    Cities = new List<City>
    {
        new City { Name = "Chandigarh", Pincode = "160001" },
        new City { Name = "Amritsar", Pincode = "143001" },
        new City { Name = "Ludhiana", Pincode = "141001" },
        new City { Name = "Jalandhar", Pincode = "144001" },
        new City { Name = "Patiala", Pincode = "147001" },
        new City { Name = "Mohali", Pincode = "160055" },
        new City { Name = "Bathinda", Pincode = "151001" },
        new City { Name = "Faridkot", Pincode = "151203" },
        new City { Name = "Mansa", Pincode = "151505" },
        new City { Name = "Hoshiarpur", Pincode = "146001" }
    }
},
           new Location
{
    State = "Rajasthan",
    Cities = new List<City>
    {
        new City { Name = "Jaipur", Pincode = "302001" },
        new City { Name = "Jodhpur", Pincode = "342001" },
        new City { Name = "Udaipur", Pincode = "313001" },
        new City { Name = "Kota", Pincode = "324001" },
        new City { Name = "Ajmer", Pincode = "305001" },
        new City { Name = "Bikaner", Pincode = "334001" },
        new City { Name = "Alwar", Pincode = "301001" },
        new City { Name = "Sikar", Pincode = "332001" },
        new City { Name = "Jhunjhunu", Pincode = "333001" },
        new City { Name = "Tonk", Pincode = "304001" }
    }
},
           new Location
{
    State = "Sikkim",
    Cities = new List<City>
    {
        new City { Name = "Gangtok", Pincode = "737101" },
        new City { Name = "Namchi", Pincode = "737126" },
        new City { Name = "Pelling", Pincode = "737113" },
        new City { Name = "Mangan", Pincode = "737116" },
        new City { Name = "Rangpo", Pincode = "737132" }
    }
},
           new Location
{
    State = "Tamil Nadu",
    Cities = new List<City>
    {
        new City { Name = "Chennai", Pincode = "600001" },
        new City { Name = "Coimbatore", Pincode = "641001" },
        new City { Name = "Madurai", Pincode = "625001" },
        new City { Name = "Salem", Pincode = "636001" },
        new City { Name = "Tiruchirappalli", Pincode = "620001" },
        new City { Name = "Erode", Pincode = "638001" },
        new City { Name = "Vellore", Pincode = "632001" },
        new City { Name = "Kanchipuram", Pincode = "631501" },
        new City { Name = "Thanjavur", Pincode = "613001" },
        new City { Name = "Nagercoil", Pincode = "629001" }
    }
},
           new Location
{
    State = "Telangana",
    Cities = new List<City>
    {
        new City { Name = "Hyderabad", Pincode = "500001" },
        new City { Name = "Warangal", Pincode = "506001" },
        new City { Name = "Karimnagar", Pincode = "505001" },
        new City { Name = "Khammam", Pincode = "507001" },
        new City { Name = "Nizamabad", Pincode = "503001" },
        new City { Name = "Ramagundam", Pincode = "505208" },
        new City { Name = "Adilabad", Pincode = "504001" },
        new City { Name = "Mahabubnagar", Pincode = "509001" },
        new City { Name = "Medak", Pincode = "502110" },
        new City { Name = "Nalgonda", Pincode = "508001" }
    }
},
           new Location
{
    State = "Tripura",
    Cities = new List<City>
    {
        new City { Name = "Agartala", Pincode = "799001" },
        new City { Name = "Udaipur", Pincode = "799103" },
        new City { Name = "Ambassa", Pincode = "799289" },
        new City { Name = "Kailasahar", Pincode = "799277" },
        new City { Name = "Dharmanagar", Pincode = "799250" }
    }
},
           new Location
{
    State = "Uttar Pradesh",
    Cities = new List<City>
    {
        new City { Name = "Lucknow", Pincode = "226001" },
        new City { Name = "Kanpur", Pincode = "208001" },
        new City { Name = "Agra", Pincode = "282001" },
        new City { Name = "Varanasi", Pincode = "221001" },
        new City { Name = "Meerut", Pincode = "250001" },
        new City { Name = "Allahabad", Pincode = "211001" },
        new City { Name = "Bareilly", Pincode = "243001" },
        new City { Name = "Jhansi", Pincode = "284001" },
        new City { Name = "Gorakhpur", Pincode = "273001" },
        new City { Name = "Moradabad", Pincode = "244001" }
    }
},
           new Location
{
    State = "Uttarakhand",
    Cities = new List<City>
    {
        new City { Name = "Dehradun", Pincode = "248001" },
        new City { Name = "Haridwar", Pincode = "249401" },
        new City { Name = "Nainital", Pincode = "263001" },
        new City { Name = "Rudrapur", Pincode = "263153" },
        new City { Name = "Haldwani", Pincode = "263139" },
        new City { Name = "Roorkee", Pincode = "247667" },
        new City { Name = "Pithoragarh", Pincode = "262501" },
        new City { Name = "Champawat", Pincode = "262523" },
        new City { Name = "Kashipur", Pincode = "244713" },
        new City { Name = "Rishikesh", Pincode = "249201" }
    }
},
           new Location
{
    State = "West Bengal",
    Cities = new List<City>
    {
        new City { Name = "Kolkata", Pincode = "700001" },
        new City { Name = "Darjeeling", Pincode = "734101" },
        new City { Name = "Howrah", Pincode = "711101" },
        new City { Name = "Siliguri", Pincode = "734001" },
        new City { Name = "Asansol", Pincode = "713301" },
        new City { Name = "Durgapur", Pincode = "713201" },
        new City { Name = "Kharagpur", Pincode = "721301" },
        new City { Name = "Jalpaiguri", Pincode = "735101" },
        new City { Name = "Murarai", Pincode = "731219" },
        new City { Name = "Haldia", Pincode = "721645" }
    }
},
           new Location
{
    State = "Andaman and Nicobar Islands",
    Cities = new List<City>
    {
        new City { Name = "Port Blair", Pincode = "744101" },
        new City { Name = "Diglipur", Pincode = "744202" },
        new City { Name = "Mayabunder", Pincode = "744204" },
        new City { Name = "Car Nicobar", Pincode = "744301" },
        new City { Name = "Campbell Bay", Pincode = "744302" }
    }
},
           new Location
{
    State = "Chandigarh",
    Cities = new List<City>
    {
        new City { Name = "Chandigarh", Pincode = "160001" }
    }
},
           new Location
{
    State = "Dadra and Nagar Haveli and Daman and Diu",
    Cities = new List<City>
    {
        new City { Name = "Daman", Pincode = "396210" },
        new City { Name = "Diu", Pincode = "362520" },
        new City { Name = "Silvassa", Pincode = "396230" },
        new City { Name = "Vapi", Pincode = "396191" }
    }
},
           new Location
{
    State = "Lakshadweep",
    Cities = new List<City>
    {
        new City { Name = "Kavaratti", Pincode = "682555" },
        new City { Name = "Agatti", Pincode = "682553" },
        new City { Name = "Minicoy", Pincode = "682559" }
    }
},
           new Location
{
    State = "Delhi",
    Cities = new List<City>
    {
        new City { Name = "New Delhi", Pincode = "110001" },
        new City { Name = "Delhi", Pincode = "110002" },
        new City { Name = "Connaught Place", Pincode = "110001" },
        new City { Name = "Dwarka", Pincode = "110075" },
        new City { Name = "Vasant Vihar", Pincode = "110057" }
    }
},
           new Location
{
    State = "Puducherry",
    Cities = new List<City>
    {
        new City { Name = "Puducherry", Pincode = "605001" },
        new City { Name = "Cuddalore", Pincode = "607001" },
        new City { Name = "Yanam", Pincode = "533464" }
    }
},
           new Location
{
    State = "Ladakh",
    Cities = new List<City>
    {
        new City { Name = "Leh", Pincode = "194101" },
        new City { Name = "Kargil", Pincode = "194103" }
    }
},
           new Location
{
    State = "Jammu and Kashmir",
    Cities = new List<City>
    {
        new City { Name = "Srinagar", Pincode = "190001" },
        new City { Name = "Jammu", Pincode = "180001" },
        new City { Name = "Anantnag", Pincode = "192101" },
        new City { Name = "Baramulla", Pincode = "193101" },
        new City { Name = "Pulwama", Pincode = "192301" },
        new City { Name = "Kathua", Pincode = "184101" },
        new City { Name = "Udhampur", Pincode = "182101" },
        new City { Name = "Rajouri", Pincode = "185131" },
        new City { Name = "Doda", Pincode = "182201" },
        new City { Name = "Kupwara", Pincode = "193222" }
    }
}


























        };
    }
}
