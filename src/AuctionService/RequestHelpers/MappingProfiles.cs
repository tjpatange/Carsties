using AuctionService.DTOS;
using AuctionService.Entities;
using AutoMapper;

namespace AuctionService;

public class MappingProfiles: Profile
{
public MappingProfiles()
    {
        CreateMap<Auction, AuctionDto>().IncludeMembers(x => x.Item);
        CreateMap<Item, AuctionDto>();
        CreateMap<CreateAuctionDto, Auction>()
            .ForMember(d => d.Item, o => o.MapFrom(s => s));
        CreateMap<CreateAuctionDto, Item>();
        CreateMap<AuctionDto, CreateAuctionDto>();
        CreateMap<Auction, UpdateAuctionDto>().IncludeMembers(a => a.Item);
        CreateMap<Item, UpdateAuctionDto>();
    }
}
