

namespace DomainLayer.DataModels
{
    public class PersonalInfoModel<TModel>
    {

        public TModel InfoModel       { get; set; }
        public string DefaultPassword { get; set; }
        public string Position        { get; set; }
        public string StudentCode     { get; set; }
        public string GuardianCode    { get; set; }
    }
}
