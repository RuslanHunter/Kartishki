using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Karti.Durak
{
    public class CardSuit
    {
        /// <summary>
        /// Значение.
        /// </summary>
        public int Value { get; set; }

        /// <summary>
        /// Наименование карты.
        /// </summary>
        public required string Name { get; set; }
        /// <summary>
        /// Сокращенное наименование (♥/♦/♣/♠).
        /// </summary>
        public required char ShortName { get; set; }
    }
}
