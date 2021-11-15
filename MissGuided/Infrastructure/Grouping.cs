using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace MissGuided.Infrastructure
{
    public class Grouping<TK, T> : ObservableCollection<T>
    {
        public TK Key { get; private set; }
        public Grouping(TK key, IEnumerable<T> details)
        {
            Key = key;
            foreach (var detail in details)
                Items.Add(detail);
        }
    }
}
