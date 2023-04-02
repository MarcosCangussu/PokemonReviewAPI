using PokemonReviewAPI.Models;

namespace PokemonReviewAPI.Intefaces
{
    public interface ICategoryRepository
    {
        ICollection<Category> GetCategories();
        Category GetCategory(int id);
        ICollection<Pokemon> GetPokemonByCategory(int categoryId);
        bool CategoryExsist(int id);
        bool CreateCategory(Category category);
        bool Save();
    }
}
