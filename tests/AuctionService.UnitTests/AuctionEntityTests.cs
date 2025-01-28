using AuctionService.Entities;

namespace AuctionService.UnitTests;

public class AuctionEntityTests
{
    [Fact]
    public void HasReservePrice_ReservePriceGreaterThanZero_True()
    {
        // Arange
        var Auction = new Auction {Id = Guid.NewGuid(), ReservePrice = 10};

        // Act
        var result = Auction.HasReservePrice();

        // Assert
        Assert.True(result);
    }

    [Fact]
    public void HasReservePrice_ReservePriceIsZero_False()
    {
        // Arange
        var Auction = new Auction {Id = Guid.NewGuid(), ReservePrice = 0};

        // Act
        var result = Auction.HasReservePrice();

        // Assert
        Assert.False(result);
    }
}