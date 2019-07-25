using System.Collections;
using System.Collections.Generic;

namespace ProductCatalogApi.Domain
{
    public class Type
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public IList<Item> Items { get; set; }
    }
}
