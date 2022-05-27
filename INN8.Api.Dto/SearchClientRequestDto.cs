using System;

namespace INN8.Api.Dto
{
  public class SearchClientRequestDto : RequestParametersBase
  {
        public string reference { get; set; }
        public string referenceCode { get; set; }
        public string clientSurname { get; set; }
        public string clientForename { get; set; }
        public DateTime? dateOfBirth { get; set; }
        public string accountNo { get; set; }
        public string sonataId { get; set; }
        public bool includeAddresses { get; set; }
        public string code { get; set; }
        public string codeType { get; set; }
        public long? advisorId { get; set; }
        public string advisorNumber { get; set; }
        public string emailAddress { get; set; }
        public string investTypeCode { get; set; }
        public bool excludeProspectInd { get; set; }
        public long? outletID { get; set; }
        public bool includeMobile { get; set; }
        public bool includeAdviserRecord { get; set; }
    }
}
