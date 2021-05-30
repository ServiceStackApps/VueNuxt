using System.Collections.Generic;
using ServiceStack;

namespace VueNuxt.ServiceModel
{
    [Route("/links")]
    public class GetLinks : IReturn<GetLinksResponse> {}

    public class GetLinksResponse
    {
        public Dictionary<string,string> Results { get; set; }
    }
}
