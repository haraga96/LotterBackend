using Microsoft.EntityFrameworkCore;
using TODO.Models.Entities;

namespace TODO.Repository;

public class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : DbContext(options)
{
    public DbSet<Todo> Todos { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        // Seed data
        modelBuilder.Entity<Todo>().HasData(new Todo
        {
            Id = "bdff234c-33d3-447f-80ee-84e43a33f01d",
            Title = "MegaMillions awaiting Draw Result",
            Content = "draw 12345 awaiting draw result",
            CreationTime = 1542111235544,
            DueDate = 1622374526379,
            Status = "Active",
            Type = "Results"
        }, new Todo
        {
            Id = "ec65203f-4c74-4ac1-9b4b-579e5c40b09b",
            Title = "EuroJackpot awaiting Draw Result",
            Content = "draw 23232 awaiting draw result",
            CreationTime = 1622374526379,
            DueDate = 1622374714232,
            Status = "Active",
            Type = "Results"
        }, new Todo
        {
            Id = "f234f5cb-6ec0-4475-bb32-b6ebf9ab42ad",
            Title = "Powerball awaiting Draw Result",
            Content = "draw 56345 awaiting draw result",
            CreationTime = 1622374714232,
            DueDate = 1622375111971,
            Status = "Done",
            Type = "Results"
        }, new Todo
        {
            Id = "6f4c1ba5-7927-478b-bf43-48af79af56d8",
            Title = "EuroJackpot awaiting Draw Result",
            Content = "draw 23232 awaiting draw result",
            CreationTime = 1622375111971,
            DueDate = 1622375125381,
            Status = "Active",
            Type = "Results"
        }, new Todo
        {
            Id = "bdff234c-33d3-447f-80ee-84e43a33f014",
            Title = "User awaiting win payout",
            Content = "user 34332 awaiting 15$ payout",
            CreationTime = 1542111235544,
            DueDate = 1622374526340,
            Status = "Done",
            Type = "Wins"
        }, new Todo
        {
            Id = "ec65203f-4c74-4ac1-9b4b-572e5c40b03b",
            Title = "User awaiting win payout",
            Content = "user 32566 awaiting 10.30$ payout",
            CreationTime = 1622374526379,
            DueDate = 1622374714232,
            Status = "Active",
            Type = "Wins"
        }, new Todo
        {
            Id = "ec65203f-4c74-4ac1-9b4b-572e2c40b03b",
            Title = "User awaiting win payout",
            Content = "user 234787 awaiting 1000.40$ payout",
            CreationTime = 1622374526379,
            DueDate = 1622374714232,
            Status = "Active",
            Type = "Wins"
        }, new Todo
        {
            Id = "bdff234c-33d3-447f-80ee-84e43a23f01d",
            Title = "User Withdraw pending",
            Content = "withdraw id 5452 awaiting approval",
            CreationTime = 1542111235544,
            DueDate = 1622539315287,
            Status = "Active",
            Type = "Withdraw"
        }, new Todo
        {
            Id = "ec65203f-42374-4ac1-9b4b-579e5c40b09b",
            Title = "User Withdraw pending",
            Content = "withdraw id 23443 awaiting approval",
            CreationTime = 1622374526379,
            DueDate = 1622539324959,
            Status = "Active",
            Type = "Withdraw"
        }, new Todo
        {
            Id = "f234f5cb-6ec0-4475-aa32-b6ebf9ab42ad",
            Title = "User Withdraw pending",
            Content = "withdraw id 127888 awaiting approval",
            CreationTime = 1622374714232,
            DueDate = 1622539336894,
            Status = "Done",
            Type = "Withdraw"
        }, new Todo
        {
            Id = "124f703e-cdcb-11eb-b8bc-0242ac130003",
            Title = "Super enaloto awaiting Draw Result",
            Content = "draw 897644 awaiting draw result",
            CreationTime = 1622375111971,
            DueDate = 1622539347152,
            Status = "Active",
            Type = "Results"
        }, new Todo
        {
            Id = "0d3e9c82-cdcb-11eb-b8bc-0242ac130003",
            Title = "User awaiting win payout",
            Content = "user 45422 awaiting 15$ payout",
            CreationTime = 1542111235544,
            DueDate = 1622539355849,
            Status = "Done",
            Type = "Wins"
        }, new Todo
        {
            Id = "08c37970-cdcb-11eb-b8bc-0242ac130003",
            Title = "User awaiting win payout",
            Content = "user 32566 awaiting 10.30$ payout",
            CreationTime = 1622374526379,
            DueDate = 1622539365375,
            Status = "Active",
            Type = "Wins"
        }, new Todo
        {
            Id = "ffd17a42-cdca-11eb-b8bc-0242ac130003",
            Title = "User awaiting win payout",
            Content = "user 675553 awaiting 1000.40$ payout",
            CreationTime = 1622374526379,
            DueDate = 1622539372100,
            Status = "Active",
            Type = "Wins"
        });
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        base.OnConfiguring(optionsBuilder);

        optionsBuilder.UseSqlite("Data Source=app.db");
    }
}