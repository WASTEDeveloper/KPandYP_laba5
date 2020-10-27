using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace KPandYP_laba7
{
    class Poem
    {
        public static string text = "У лукоморья дуб зелёный;\n" +
                                    "Златая цепь на дубе том:\n" +
                                    "И днём и ночью кот учёный\n" +
                                    "Всё ходит по цепи кругом;\n" +
                                    "Идёт направо — песнь заводит,\n" +
                                    "Налево — сказку говорит.\n" +
                                    "Там чудеса: там леший бродит,\n" +
                                    "Русалка на ветвях сидит;\n" +
                                    "Там на неведомых дорожках\n" +
                                    "Следы невиданных зверей;\n" +
                                    "Избушка там на курьих ножках\n" +
                                    "Стоит без окон, без дверей;\n" +
                                    "Там лес и дол видений полны;\n" +
                                    "Там о заре прихлынут волны\n" +
                                    "На брег песчаный и пустой,\n" +
                                    "И тридцать витязей прекрасных\n" +
                                    "Чредой из вод выходят ясных,\n" +
                                    "И с ними дядька их морской;\n" +
                                    "Там королевич мимоходом\n" +
                                    "Пленяет грозного царя;\n" +
                                    "Там в облаках перед народом\n" +
                                    "Через леса, через моря\n" +
                                    "Колдун несёт богатыря;\n" +
                                    "В темнице там царевна тужит,\n" +
                                    "А бурый волк ей верно служит;\n" +
                                    "Там ступа с Бабою Ягой\n" +
                                    "Идёт, бредёт сама собой,\n" +
                                    "Там царь Кащей над златом чахнет;\n" +
                                    "Там русский дух… там Русью пахнет!\n" +
                                    "И там я был, и мёд я пил;\n" +
                                    "У моря видел дуб зелёный;\n" +
                                    "Под ним сидел, и кот учёный\n" +
                                    "Свои мне сказки говорил.";

        public static void Zam()
        {
            StringBuilder[] TempText = new StringBuilder[text.Split(' ').Length];

            string str = "";
            int j = 0;
            for (int i = 0; i < text.Length; ++i)
            {
                str += text[i];
                if (text[i] == ' ')
                {
                    TempText[j] = new StringBuilder(str);
                    j++;
                    str = "";
                }
            }

            for (int i = 0; i < j; ++i)
            {
                if (TempText[i].Length >= 4)
                {
                    TempText[i].Remove(3, 1);
                    TempText[i].Insert(3, "#");
                }
                if (TempText[i].Length >= 7)
                {
                    TempText[i].Remove(6, 1);
                    TempText[i].Insert(6, "#");
                }
            }


            foreach (var item in TempText)
            {
                Console.WriteLine(item);
            }
        }

        struct Words
        {
            string wrd;
            int kol;
        }

        public static void Povt()
        {
            StringBuilder[] TempText = new StringBuilder[text.Split(' ').Length];
            List<Words> list = new List<Words>();

            string str = "";
            int j = 0;
            for (int i = 0; i < text.Length; ++i)
            {
                str += text[i];
                if (text[i] == ' ')
                {
                    TempText[j] = new StringBuilder(str);
                    j++;
                    str = "";
                }
            }

            for (int i = 0; i < j; ++i)
            {
                for (int k = i; k < j; ++i)
                {


                }
            }
        }
    }
}
