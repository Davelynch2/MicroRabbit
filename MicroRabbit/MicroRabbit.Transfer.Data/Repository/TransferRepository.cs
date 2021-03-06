using MicroRabbit.Transfer.Data.Context;
using System.Collections.Generic;
using MicroRabbit.Transfer.Domain.Models;
using MicroRabbit.Transfer.Domain.Interfaces;

namespace MicroRabbit.Transfer.Data.Repository
{
    public class TransferRepository : ITransferRepository
    {
        private TransferDbContext _ctx;

        public TransferRepository(TransferDbContext ctx)
        {
            _ctx = ctx;
        }

        public void Add(TransferLog transferLog)
        {
            _ctx.Add(transferLog);
            _ctx.SaveChanges();
        }

        public IEnumerable<TransferLog> GetTransferLogs() => _ctx.TransferLogs;
    }
}
