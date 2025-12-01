using BlazorComponent.Models;

namespace BlazorComponent.Repositories
{
    public class MedicoRepository : IMedicoRepository
    {
        public async Task<List<Medico>> GetAllAsync()
        {
            return new List<Medico>
            {
                new Medico{ Id = 1, Nome = "Pedro Silva", Crm = "ABC123" },
                new Medico{ Id = 2, Nome = "Antonio Garcia", Crm = "DEF123" },
                new Medico{ Id = 3, Nome = "Mateus Costa", Crm = "GHI123" },
                new Medico{ Id = 4, Nome = "Alberto Roberto", Crm = "JKL123" },
                new Medico{ Id = 5, Nome = "Pedro Menezes", Crm = "MNO123" },
            };
        }
    }
}
