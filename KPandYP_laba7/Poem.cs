using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
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

        public static string[] Zam()
        {
            char[] chars = { ';', '.', ',', '!', ':', ' ', '—', '\n'};
            string[] textWords = text.Split(chars);

            for (int i = 0; i < textWords.Length; ++i)
            {
                if (textWords[i].Length >= 4)
                {
                    textWords[i] = textWords[i].Remove(3, 1);
                    textWords[i] = textWords[i].Insert(3, "#");
                }
                if (textWords[i].Length >= 7)
                {
                    textWords[i] = textWords[i].Remove(6, 1);
                    textWords[i] = textWords[i].Insert(6, "#");
                }
            }

            List<string> wordsList= new List<string>();
            foreach (var item in textWords)
            {
                if (item != "")
                {
                    wordsList.Add(item);
                    Console.WriteLine(item);
                }
            }

            return wordsList.ToArray();
        }

        public static void Povt(string[] textWords)
        {
            var result = textWords.GroupBy(x => x)
                              .Where(x => x.Count() > 1)
                              .Select(x => new { Word = x.Key, Frequency = x.Count() });

            foreach (var item in result)
            {
                Console.WriteLine($"{item.Word}\t = {item.Frequency}"); ;
            }
        }

        private static void allWords(string[] textWords)
        {
            char[] gl = {'а','е','ё','и','о','у','ы','э','ю','я'};
            for (int i = 0; i < textWords.Length; ++i)
            {
                for (int j = 0; j < gl.Length; ++j)
                {
                    if (!textWords[i].ToLower().ToCharArray()[0].Equals(gl[j]) && textWords[i].ToLower().ToCharArray()[textWords[i].Length - 1].Equals(gl[j]))
                    {
                        Console.WriteLine(textWords[i]);
                    }
                }
            }
        }

        public static void AllWords(string[] textWords)
        {
            allWords(textWords);
        }


    }
}
