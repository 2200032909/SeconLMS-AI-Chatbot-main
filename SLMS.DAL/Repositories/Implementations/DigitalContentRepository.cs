using SLMS.DAL.Data;
using SLMS.DAL.Repositories.Interfaces;
using SLMS.DOL.Entities;

namespace SLMS.DAL.Repositories.Implementations;

public class DigitalContentRepository
    : Repository<DigitalContent>,
      IDigitalContentRepository
{
    public DigitalContentRepository(
        SLMSDbContext context)
        : base(context)
    {
    }
}