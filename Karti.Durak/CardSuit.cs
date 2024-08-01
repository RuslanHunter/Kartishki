using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Karti.Durak
{
    /// <summary>
    /// Масть.
    /// </summary>
    public class CardSuit
    {
        /// <summary>
        /// Масть.
        /// </summary>
        /// <param name="value"><see cref="Value"/></param>
        /// <param name="name"><see cref="Name"/></param>
        /// <param name="iconChar"><see cref="IconChar"/></param>
        public CardSuit(int value, string name, char iconChar)
        {
            Value = value;
            Name = name;
            IconChar = iconChar;
            
        }
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
        public required char IconChar { get; set; }
    }
}
