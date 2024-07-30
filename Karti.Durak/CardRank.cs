using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Karti.Durak
{
    /// <summary>
    /// Старшинство карты.
    /// </summary>
    public class CardRank
    {
        /// <summary>
        /// Значение старшинства. Чем больше тем лучше
        /// </summary>
        public int value { get; set; }

        /// <summary>
        /// Наименование карты.
        /// </summary>
        public required string Name { get; set; }
        /// <summary>
        /// Сокращенное наименование.
        /// </summary>
        public required char ShortName { get; set; }
    }
}
