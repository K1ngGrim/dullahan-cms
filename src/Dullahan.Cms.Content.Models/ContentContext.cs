using Microsoft.EntityFrameworkCore;

namespace Dullahan.Cms.Content.Models;

public class ContentContext(DbContextOptions options) : DbContext(options)
{

}