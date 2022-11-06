namespace Ecommerce.Server.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>().HasData(
                 new Product
                 {
                     Id = 1,
                     Title = "Matrix",
                     Description = "The Matrix is a 1999 science fiction action film written and directed by the Wachowskis, and produced by Joel Silver. Starring Keanu Reeves, Laurence Fishburne, Carrie-Anne Moss, Hugo Weaving, and Joe Pantoliano, and as the first installment in the Matrix franchise, it depicts a dystopian future in which humanity is unknowingly trapped inside a simulated reality, the Matrix, which intelligent machines have created to distract humans while using their bodies as an energy source. When computer programmer Thomas Anderson, under the hacker alias \"Neo\", uncovers the truth, he \"is drawn into a rebellion against the machines\" along with other people who have been freed from the Matrix.",
                     ImageUrl = "https://upload.wikimedia.org/wikipedia/en/c/c1/The_Matrix_Poster.jpg",
                     Price = 9.99m
                 },
                new Product
                {
                    Id = 2,
                    Title = "Ready Player One",
                    Description = "Ready Player One is a 2011 science fiction novel, and the debut novel of American author Ernest Cline. The story, set in a dystopia in 2045, follows protagonist Wade Watts on his search for an Easter egg in a worldwide virtual reality game, the discovery of which would lead him to inherit the game creator's fortune. Cline sold the rights to publish the novel in June 2010, in a bidding war to the Crown Publishing Group (a division of Random House).[1] The book was published on August 16, 2011.[2] An audiobook was released the same day; it was narrated by Wil Wheaton, who was mentioned briefly in one of the chapters.[3][4]Ch. 20 In 2012, the book received an Alex Award from the Young Adult Library Services Association division of the American Library Association[5] and won the 2011 Prometheus Award.[6]",
                    ImageUrl = "https://upload.wikimedia.org/wikipedia/en/a/a4/Ready_Player_One_cover.jpg",
                    Price = 7.99m
                },
                new Product
                {
                    Id = 3,
                    Title = "Back to the Future",
                    Description = "Back to the Future is a 1985 American science fiction film directed by Robert Zemeckis. Written by Zemeckis and Bob Gale, it stars Michael J. Fox, Christopher Lloyd, Lea Thompson, Crispin Glover, and Thomas F. Wilson. Set in 1985, the story follows Marty McFly (Fox), a teenager accidentally sent back to 1955 in a time-traveling DeLorean automobile built by his eccentric scientist friend Doctor Emmett \"Doc\" Brown (Lloyd). Trapped in the past, Marty inadvertently prevents his future parents' meeting—threatening his very existence—and is forced to reconcile the pair and somehow get back to the future.",
                    ImageUrl = "https://upload.wikimedia.org/wikipedia/en/d/d2/Back_to_the_Future.jpg",
                    Price = 3.99m
                }
                );
        }

        public DbSet<Product> Products { get; set; }
    }
}
