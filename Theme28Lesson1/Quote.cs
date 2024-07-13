using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Theme28Lesson1
{
    internal class Quote
    {
        public string RandomQuote()
        {
            Random random =new Random();
            int n = random.Next(0, 5);
            if (n == 0) return "\"Успех - это способность идти от одной неудачи к другой, не потеряв энтузиазма.\"- Уинстон Черчилль";
            else if (n == 1) return "\"Будь изменением, которое ты хочешь видеть в мире.\" - Махатма Ганди";
            else if (n == 2) return "\"Лучший способ предсказать будущее -создать его.\" - Питер Друкер";
            else if (n == 3) return "\"Сложности - это возможности, скрытые в обманчивой обертке.\" - Альберт Эйнштейн";
            else return "\"Не важно, сколько раз вы падаете - важно, сколько раз вы поднимаетесь.\" - Мэрилин Монро";
        }
    }
}
