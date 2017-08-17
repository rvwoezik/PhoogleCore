using Phoogle.EntityFrameworkCore;

namespace Phoogle.Tests.TestDatas
{
    public class TestDataBuilder
    {
        private readonly PhoogleDbContext _context;
        private readonly int _tenantId;

        public TestDataBuilder(PhoogleDbContext context, int tenantId)
        {
            _context = context;
            _tenantId = tenantId;
        }

        public void Create()
        {
            new TestOrganizationUnitsBuilder(_context, _tenantId).Create();
            new TestSubscriptionPaymentBuilder(_context, _tenantId).Create();

            _context.SaveChanges();
        }
    }
}
