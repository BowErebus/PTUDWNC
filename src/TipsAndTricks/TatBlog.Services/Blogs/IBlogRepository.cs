using TatBlog.Core.Contracts;
using TatBlog.Core.DTO;
using TatBlog.Core.Entities;

namespace TatBlog.Services.Blogs;

public interface IBlogRepository
{
    // Tìm bài viết có tên định danh là 'slug'
    // và được đăng vào tháng 'month' năm 'year'
    Task<Post> GetPostAsync(
        int year,
        int month,
        string slug,
        CancellationToken cancellationToken = default);

    // Tìm Top N bài viết phổ biến được nhiều người xem nhất
    Task<IList<Post>> GetPopularArticlesAsync(
        int numPosts,
        CancellationToken cancellationToken = default);

    // Kiểm tra xem tên định danh của bài viết đã có hay chưa
    Task<bool> IsPostSlugExistedAsync(
        int postId, string slug,
        CancellationToken cancellationToken = default);

    // Tăng số lượt xem của một bài viết
    Task IncreaseViewCountAsync(
        int postId,
        CancellationToken cancellationToken = default);

    // Lấy danh sách chuyên mục và số lượng bài viết
    // nằm thuộc từng chuyên mục/chủ đềs
    Task<IList<CategoryItem>> GetCategoriesAsync(
        bool showOnMenu = false,
        CancellationToken cancellationToken = default);

    // Lấy danh sách từ khóa/thẻ và phân trang theo
    // các tham số pagingParams
    Task<IPagedList<TagItem>> GetPagedTagsAsync(
        IPagingParams pagingParams,
        CancellationToken cancellationToken = default);
}