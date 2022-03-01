using HashWebApi.Models;
using HashWebApi.ModelsDTO;

namespace HashWebApi.Validators
{
    public class UserControllerValidators
    {
        public string Validate<T>(T value) where T : UserCreationParams
        {
            return default;
        }
    }
}
