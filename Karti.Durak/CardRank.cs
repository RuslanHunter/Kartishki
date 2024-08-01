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
        /// Старшинство карты
        /// </summary>
        /// <param name="value"><see cref="Value"/></param>
        /// <param name="name"><see cref="Name"/></param>
        /// <param name="shortName"><see cref="ShortName"/></param>
        public CardRank(int value, string name)
        {
            Value = value;
            Name = name;
        }
        /// <summary>
        /// Значение старшинства. Чем больше тем лучше
        /// </summary>
        public int Value { get; }

        /// <summary>
        /// Наименование карты.
        /// </summary>
        public string Name { get; }
        /// <summary>
        /// Сокращенное наименование.
        /// </summary>
    }
}
