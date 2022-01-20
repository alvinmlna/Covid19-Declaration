using System.Collections.Generic;

namespace Declaration.BusinessLogic.Validator.Interfaces
{
    public interface IValidator<TModel> where TModel : class
    {
        Dictionary<string, string> ValidationResult(TModel model);
    }
}
