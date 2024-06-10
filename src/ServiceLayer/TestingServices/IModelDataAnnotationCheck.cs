namespace ServiceLayer.TestingServices
{
    public interface IModelDataAnnotationCheck
    {
        void ValidateModelDataAnnotation<TDomainModel>(TDomainModel model) where TDomainModel : class;
    }
}