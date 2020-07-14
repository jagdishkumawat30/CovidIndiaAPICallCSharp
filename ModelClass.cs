using System;
using System.Collections.Generic;
using System.Text;

namespace CovidIndiaAPI
{
    class ModelClass
    {
        // Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse); 
        

        

        


    }

    public class Root
    {
        public List<CasesTimeSery> cases_time_series { get; set; }
        public List<Tested> tested { get; set; }

    }

    public class Tested
    {
        public string individualstestedperconfirmedcase { get; set; }
        public string positivecasesfromsamplesreported { get; set; }
        public string samplereportedtoday { get; set; }
        public string source { get; set; }
        public string source1 { get; set; }
        public string testedasof { get; set; }
        public string testpositivityrate { get; set; }
        public string testsconductedbyprivatelabs { get; set; }
        public string testsperconfirmedcase { get; set; }
        public string testspermillion { get; set; }
        public string totalindividualstested { get; set; }
        public string totalpositivecases { get; set; }
        public string totalsamplestested { get; set; }
        public string updatetimestamp { get; set; }

    }

    public class CasesTimeSery
    {
        public string dailyconfirmed { get; set; }
        public string dailydeceased { get; set; }
        public string dailyrecovered { get; set; }
        public string date { get; set; }
        public string totalconfirmed { get; set; }
        public string totaldeceased { get; set; }
        public string totalrecovered { get; set; }

    }
}
