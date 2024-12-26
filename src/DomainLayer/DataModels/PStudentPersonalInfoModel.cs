

namespace DomainLayer.DataModels
{
    public class PStudentPersonalInfoModel<TModel>
    { 
        public TModel InfoModel       { get; set; }
        public string DefaultPassword { get; set; }
        public string Position        { get; set; }
        public string UserId          { get; set; }
        public string GuardianCode    { get; set; }
    }
}
