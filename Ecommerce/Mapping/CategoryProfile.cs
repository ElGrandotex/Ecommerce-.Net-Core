using Ecommerce.Model;
using Ecommerce.Model.Dtos;
using Mapster;

namespace Ecommerce.Mapping
{
    public class CategoryProfile
    {
        public CategoryProfile()
        {
            TypeAdapterConfig<CreateCategoryDto, Category>.NewConfig()
                .Map(dest => dest.CreationDate, src => DateTime.Now);

            TypeAdapterConfig<Category, CategoryDto>.NewConfig();
        }
    }
}
