using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Minutes.Data
{
    public class MemoryEntryStore : INoteEntryStore
    {
        private readonly Dictionary<string, NoteEntry> entries = new Dictionary<string, NoteEntry>();

        public Task<IEnumerable<NoteEntry>> GetAllAsync()
        {
            IEnumerable<NoteEntry> result = entries.Values.ToList();
            return Task.FromResult(result);
        }

        public Task AddAsync(NoteEntry entry)
        {
            entries.Add(entry.Id, entry);
            return Task.CompletedTask;
        }

        //public Task<NoteEntry> GetByIdAsync(string id)
        //{
        //    NoteEntry entry = null;
        //    entries.TryGetValue(id, out entry);
        //    return Task.FromResult(entry);
        //}


    }
}
