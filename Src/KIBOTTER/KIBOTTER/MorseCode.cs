using System.Text.RegularExpressions;

namespace KIBOTTER
{
    class MorseCode
    {
        public string ConvertToMorse(string original)
        {
            if (original.Length > 20)
            {
                return "error";
            }

            char[] arrayOriginal = original.ToCharArray();

            // mode = 0 で英語, 1 で日本語ひらがな, 2 で日本語カタカナ
            int mode = 0;

            foreach (char oneArrayOriginal in arrayOriginal)
            {
                string oneChar = oneArrayOriginal.ToString();
                if (Regex.IsMatch(oneChar, @"^\p{IsHiragana}+$"))
                {
                    mode = 1;
                    break;
                }

                if (Regex.IsMatch(oneChar, @"^[\p{IsKatakana}\u31F0-\u31FF\uFF66-\uFF9F]+$"))
                {
                    mode = 2;
                    break;
                }
            }
            
            string resultText = string.Empty;

            for (int i = 0; i < original.Length; i++)
            {
                resultText += JudgeMorse(arrayOriginal[i], mode) + "　";
            }

            return resultText;
        }

        private string JudgeMorse(char character, int mode)
        {
            if (mode == 0)
            {
                return EnToMorse(character);
            }
            if (mode == 1)
            {
                return JaHiraToMorse(character);
            }
            if (mode == 2)
            {
                return JaKataToMorse(character);
            }

            return "error";
        }

        private string EnToMorse(char character)
        {
            if (character == 'a' || character == 'A')
            {
                return "・－";
            }
            if (character == 'b' || character == 'B')
            {
                return "－・・・";
            }
            if (character == 'c' || character == 'C')
            {
                return "－・－・";
            }
            if (character == 'd' || character == 'D')
            {
                return "－・・";
            }
            if (character == 'e' || character == 'E')
            {
                return "・";
            }
            if (character == 'f' || character == 'F')
            {
                return "・・－・";
            }
            if (character == 'g' || character == 'G')
            {
                return "－－・";
            }
            if (character == 'h' || character == 'H')
            {
                return "・・・・";
            }
            if (character == 'i' || character == 'I')
            {
                return "・・";
            }
            if (character == 'j' || character == 'J')
            {
                return "・－－－";
            }
            if (character == 'k' || character == 'K')
            {
                return "－・－";
            }
            if (character == 'l' || character == 'L')
            {
                return "・－・・";
            }
            if (character == 'm' || character == 'M')
            {
                return "－－";
            }
            if (character == 'n' || character == 'N')
            {
                return "－・";
            }
            if (character == 'o' || character == 'O')
            {
                return "－－－";
            }
            if (character == 'p' || character == 'P')
            {
                return "・－－・";
            }
            if (character == 'q' || character == 'Q')
            {
                return "－－・－";
            }
            if (character == 'r' || character == 'R')
            {
                return "・－・";
            }
            if (character == 's' || character == 'S')
            {
                return "・・・";
            }
            if (character == 't' || character == 'T')
            {
                return "－";
            }
            if (character == 'u' || character == 'U')
            {
                return "・・－";
            }
            if (character == 'v' || character == 'V')
            {
                return "・・・－";
            }
            if (character == 'w' || character == 'W')
            {
                return "・－－";
            }
            if (character == 'x' || character == 'X')
            {
                return "－・・－";
            }
            if (character == 'y' || character == 'Y')
            {
                return "－・－－";
            }
            if (character == 'z' || character == 'Z')
            {
                return "－－・・";
            }
            // 数字
            if (character == '1')
            {
                return "・－－－－";
            }
            if (character == '2')
            {
                return "・・－－－";
            }
            if (character == '3')
            {
                return "・・・－－";
            }
            if (character == '4')
            {
                return "・・・・－";
            }
            if (character == '5')
            {
                return "・・・・・";
            }
            if (character == '6')
            {
                return "－・・・・";
            }
            if (character == '7')
            {
                return "－－・・・";
            }
            if (character == '8')
            {
                return "－－－・・";
            }
            if (character == '9')
            {
                return "－－－－・";
            }
            if (character == '0')
            {
                return "－－－－－";
            }
            // 欧文記号
            if (character == ',')
            {
                return "－－・・－－";
            }
            if (character == '.')
            {
                return "・－・－・－";
            }
            if (character == '?')
            {
                return "・・－－・・";
            }

            return " ";
        }

        private string JaHiraToMorse(char character)
        {
            if (character == 'あ' || character == 'ぁ')
            {
                return "－－・－－";
            }
            if (character == 'い' || character == 'ぃ')
            {
                return "・－";
            }
            if (character == 'う' || character == 'ぅ')
            {
                return "・・－";
            }
            if (character == 'え' || character == 'ぇ')
            {
                return "－・－－－";
            }
            if (character == 'お' || character == 'ぉ')
            {
                return "・－・・・";
            }
            if (character == 'か' || character == 'が')
            {
                if (character == 'が')
                {
                    return "・－・・ ・・";
                }
                return "・－・・";
            }
            if (character == 'き' || character == 'ぎ')
            {
                if (character == 'ぎ')
                {
                    return "－・－・・ ・・";
                }
                return "－・－・・";
            }
            if (character == 'く' || character == 'ぐ')
            {
                if (character == 'ぐ')
                {
                    return "・・・－ ・・";
                }
                return "・・・－";
            }
            if (character == 'け' || character == 'げ')
            {
                if (character == 'げ')
                {
                    return "－・－－ ・・";
                }
                return "－・－－";
            }
            if (character == 'こ' || character == 'ご')
            {
                if (character == 'ご')
                {
                    return "－－－－ ・・";
                }
                return "－－－－";
            }
            if (character == 'さ' || character == 'ざ')
            {
                if (character == 'ざ')
                {
                    return "－・－・－ ・・";
                }
                return "－・－・－";
            }
            if (character == 'し' || character == 'じ')
            {
                if (character == 'じ')
                {
                    return "－－・－・ ・・";
                }
                return "－－・－・";
            }
            if (character == 'す' || character == 'ず')
            {
                if (character == 'ず')
                {
                    return "－－－・－ ・・";
                }
                return "－－－・－";
            }
            if (character == 'せ' || character == 'ぜ')
            {
                if (character == 'ぜ')
                {
                    return "・－－－・ ・・";
                }
                return "・－－－・";
            }
            if (character == 'そ' || character == 'ぞ')
            {
                if (character == 'ぞ')
                {
                    return "－－－・ ・・";
                }
                return "－－－・";
            }
            if (character == 'た' || character == 'だ')
            {
                if (character == 'だ')
                {
                    return "－・ ・・";
                }
                return "－・";
            }
            if (character == 'ち' || character == 'ぢ')
            {
                if (character == 'ぢ')
                {
                    return "・・－・ ・・";
                }
                return "・・－・";
            }
            if (character == 'つ' || character == 'づ' || character == 'っ')
            {
                if (character == 'づ')
                {
                    return "・－－・ ・・";
                }
                return "・－－・";
            }
            if (character == 'て' || character == 'で')
            {
                if (character == 'で')
                {
                    return "・－・－－ ・・";
                }
                return "・－・－－";
            }
            if (character == 'と' || character == 'ど')
            {
                if (character == 'ど')
                {
                    return "・・－・・ ・・";
                }
                return "・・－・・";
            }
            if (character == 'な')
            {
                return "・－・";
            }
            if (character == 'に')
            {
                return "－・－・";
            }
            if (character == 'ぬ')
            {
                return "・・・・";
            }
            if (character == 'ね')
            {
                return "－－・－";
            }
            if (character == 'の')
            {
                return "・・－－";
            }
            if (character == 'は' || character == 'ば' || character == 'ぱ')
            {
                if (character == 'ば')
                {
                    return "－・・・ ・・";
                }
                if (character == 'ぱ')
                {
                    return "－・・・ ・・－－・";
                }
                return "－・・・";
            }
            if (character == 'ひ' || character == 'び' || character == 'ぴ')
            {
                if (character == 'び')
                {
                    return "－－・・－ ・・";
                }
                if (character == 'ぴ')
                {
                    return "－－・・－ ・・－－・";
                }
                return "－－・・－";
            }
            if (character == 'ふ' || character == 'ぶ' || character == 'ぷ')
            {
                if (character == 'ぶ')
                {
                    return "－－・・ ・・";
                }
                if (character == 'ぷ')
                {
                    return "－－・・ ・・－－・";
                }
                return "－－・・";
            }
            if (character == 'へ' || character == 'べ' || character == 'ぺ')
            {
                if (character == 'べ')
                {
                    return "・ ・・";
                }
                if (character == 'ぺ')
                {
                    return "・ ・・－－・";
                }
                return "・";
            }
            if (character == 'ほ' || character == 'ぼ' || character == 'ぽ')
            {
                if (character == 'ぼ')
                {
                    return "－・・ ・・";
                }
                if (character == 'ぽ')
                {
                    return "－・・ ・・－－・";
                }
                return "－・・";
            }
            if (character == 'ま')
            {
                return "－・・－";
            }
            if (character == 'み')
            {
                return "・・－・－";
            }
            if (character == 'む')
            {
                return "－";
            }
            if (character == 'め')
            {
                return "－・・・－";
            }
            if (character == 'も')
            {
                return "－・・－・";
            }
            if (character == 'や' || character == 'ゃ')
            {
                return "・－－";
            }
            if (character == 'ゆ' || character == 'ゅ')
            {
                return "－・・－－";
            }
            if (character == 'よ' || character == 'ょ')
            {
                return "－－";
            }
            if (character == 'ら')
            {
                return "・・・";
            }
            if (character == 'り')
            {
                return "－－・";
            }
            if (character == 'る')
            {
                return "－・－－・";
            }
            if (character == 'れ')
            {
                return "－－－";
            }
            if (character == 'ろ')
            {
                return "・－・－";
            }
            if (character == 'わ' || character == 'ゎ')
            {
                return "－・－";
            }
            if (character == 'ゐ')
            {
                return "・－・・－";
            }
            if (character == 'ゑ')
            {
                return "・－－・・";
            }
            if (character == 'を')
            {
                return "・－－－";
            }
            if (character == 'ん')
            {
                return "・－・－・";
            }
            // 数字
            if (character == '１' || character == '1')
            {
                return "・－－－－";
            }
            if (character == '２' || character == '2')
            {
                return "・・－－－";
            }
            if (character == '３' || character == '3')
            {
                return "・・・－－";
            }
            if (character == '４' || character == '4')
            {
                return "・・・・－";
            }
            if (character == '５' || character == '5')
            {
                return "・・・・・";
            }
            if (character == '６' || character == '6')
            {
                return "－・・・・";
            }
            if (character == '７' || character == '7')
            {
                return "－－・・・";
            }
            if (character == '８' || character == '8')
            {
                return "－－－・・";
            }
            if (character == '９' || character == '9')
            {
                return "－－－－・";
            }
            if (character == '０' || character == '0')
            {
                return "－－－－－";
            }
            // 記号
            if (character == 'ー')
            {
                return "・－－・－";
            }
            if (character == '、')
            {
                return "・－・－・－";
            }
            if (character == '゛')
            {
                return "・・";
            }
            if (character == '゜')
            {
                return "・・－－・";
            }

            return " ";
        }

        private string JaKataToMorse(char character)
        {
            if (character == 'ア' || character == 'ァ'
                 || character == 'ｱ' || character == 'ｧ')
            {
                return "－－・－－";
            }
            if (character == 'イ' || character == 'ィ'
                 || character == 'ｲ' || character == 'ｨ')
            {
                return "・－";
            }
            if (character == 'ウ' || character == 'ゥ'
                 || character == 'ｳ' || character == 'ｩ')
            {
                return "・・－";
            }
            if (character == 'エ' || character == 'ェ'
                 || character == 'ｴ' || character == 'ｪ')
            {
                return "－・－－－";
            }
            if (character == 'オ' || character == 'ォ'
                 || character == 'ｵ' || character == 'ｫ')
            {
                return "・－・・・";
            }
            if (character == 'カ' || character == 'ガ' || character == 'ｶ')
            {
                if (character == 'ガ')
                {
                    return "・－・・ ・・";
                }
                return "・－・・";
            }
            if (character == 'キ' || character == 'ギ' || character == 'ｷ')
            {
                if (character == 'ギ')
                {
                    return "－・－・・ ・・";
                }
                return "－・－・・";
            }
            if (character == 'ク' || character == 'グ' || character == 'ｸ')
            {
                if (character == 'グ')
                {
                    return "・・・－ ・・";
                }
                return "・・・－";
            }
            if (character == 'ケ' || character == 'ゲ' || character == 'ｹ')
            {
                if (character == 'ゲ')
                {
                    return "－・－－ ・・";
                }
                return "－・－－";
            }
            if (character == 'コ' || character == 'ゴ' || character == 'ｺ')
            {
                if (character == 'ゴ')
                {
                    return "－－－－ ・・";
                }
                return "－－－－";
            }
            if (character == 'サ' || character == 'ザ' || character == 'ｻ')
            {
                if (character == 'ザ')
                {
                    return "－・－・－ ・・";
                }
                return "－・－・－";
            }
            if (character == 'シ' || character == 'ジ' || character == 'ｼ')
            {
                if (character == 'ジ')
                {
                    return "－－・－・ ・・";
                }
                return "－－・－・";
            }
            if (character == 'ス' || character == 'ズ' || character == 'ｽ')
            {
                if (character == 'ズ')
                {
                    return "－－－・－ ・・";
                }
                return "－－－・－";
            }
            if (character == 'セ' || character == 'ゼ' || character == 'ｾ')
            {
                if (character == 'ゼ')
                {
                    return "・－－－・ ・・";
                }
                return "・－－－・";
            }
            if (character == 'ソ' || character == 'ゾ' || character == 'ｿ')
            {
                if (character == 'ゾ')
                {
                    return "－－－・ ・・";
                }
                return "－－－・";
            }
            if (character == 'タ' || character == 'ダ' || character == 'ﾀ')
            {
                if (character == 'ダ')
                {
                    return "－・ ・・";
                }
                return "－・";
            }
            if (character == 'チ' || character == 'ヂ' || character == 'ﾁ')
            {
                if (character == 'ヂ')
                {
                    return "・・－・ ・・";
                }
                return "・・－・";
            }
            if (character == 'ツ' || character == 'ヅ' || character == 'ッ'
                 || character == 'ﾂ' || character == 'ｯ')
            {
                if (character == 'ヅ')
                {
                    return "・－－・ ・・";
                }
                return "・－－・";
            }
            if (character == 'テ' || character == 'デ' || character == 'ﾃ')
            {
                if (character == 'デ')
                {
                    return "・－・－－ ・・";
                }
                return "・－・－－";
            }
            if (character == 'ト' || character == 'ド' || character == 'ﾄ')
            {
                if (character == 'ド')
                {
                    return "・・－・・ ・・";
                }
                return "・・－・・";
            }
            if (character == 'ナ' || character == 'ﾅ')
            {
                return "・－・";
            }
            if (character == 'ニ' || character == 'ﾆ')
            {
                return "－・－・";
            }
            if (character == 'ヌ' || character == 'ﾇ')
            {
                return "・・・・";
            }
            if (character == 'ネ' || character == 'ﾈ')
            {
                return "－－・－";
            }
            if (character == 'ノ' || character == 'ﾉ')
            {
                return "・・－－";
            }
            if (character == 'ハ' || character == 'バ' || character == 'パ'
                 || character == 'ﾊ')
            {
                if (character == 'バ')
                {
                    return "－・・・ ・・";
                }
                if (character == 'パ')
                {
                    return "－・・・ ・・－－・";
                }
                return "－・・・";
            }
            if (character == 'ヒ' || character == 'ビ' || character == 'ピ'
                 || character == 'ﾋ')
            {
                if (character == 'ビ')
                {
                    return "－－・・－ ・・";
                }
                if (character == 'ピ')
                {
                    return "－－・・－ ・・－－・";
                }
                return "－－・・－";
            }
            if (character == 'フ' || character == 'ブ' || character == 'プ'
                 || character == 'ﾌ')
            {
                if (character == 'ブ')
                {
                    return "－－・・ ・・";
                }
                if (character == 'プ')
                {
                    return "－－・・ ・・－－・";
                }
                return "－－・・";
            }
            if (character == 'ヘ' || character == 'ベ' || character == 'ペ'
                 || character == 'ﾍ')
            {
                if (character == 'ベ')
                {
                    return "・ ・・";
                }
                if (character == 'ペ')
                {
                    return "・ ・・－－・";
                }
                return "・";
            }
            if (character == 'ホ' || character == 'ボ' || character == 'ポ'
                 || character == 'ﾎ')
            {
                if (character == 'ボ')
                {
                    return "－・・ ・・";
                }
                if (character == 'ポ')
                {
                    return "－・・ ・・－－・";
                }
                return "－・・";
            }
            if (character == 'マ' || character == 'ﾏ')
            {
                return "－・・－";
            }
            if (character == 'ミ' || character == 'ﾐ')
            {
                return "・・－・－";
            }
            if (character == 'ム' || character == 'ﾑ')
            {
                return "－";
            }
            if (character == 'メ' || character == 'ﾒ')
            {
                return "－・・・－";
            }
            if (character == 'モ' || character == 'ﾓ')
            {
                return "－・・－・";
            }
            if (character == 'ヤ' || character == 'ャ'
                 || character == 'ﾔ' || character == 'ｬ')
            {
                return "・－－";
            }
            if (character == 'ユ' || character == 'ュ'
                 || character == 'ﾕ' || character == 'ｭ')
            {
                return "－・・－－";
            }
            if (character == 'ヨ' || character == 'ョ'
                 || character == 'ﾖ' || character == 'ｮ')
            {
                return "－－";
            }
            if (character == 'ラ' || character == 'ﾗ')
            {
                return "・・・";
            }
            if (character == 'リ' || character == 'ﾘ')
            {
                return "－－・";
            }
            if (character == 'ル' || character == 'ﾙ')
            {
                return "－・－－・";
            }
            if (character == 'レ' || character == 'ﾚ')
            {
                return "－－－";
            }
            if (character == 'ロ' || character == 'ﾛ')
            {
                return "・－・－";
            }
            if (character == 'ワ' || character == 'ヮ' || character == 'ﾜ')
            {
                return "－・－";
            }
            if (character == 'ヰ')
            {
                return "・－・・－";
            }
            if (character == 'ヱ')
            {
                return "・－－・・";
            }
            if (character == 'ヲ' || character == 'ｦ')
            {
                return "・－－－";
            }
            if (character == 'ン' || character == 'ﾝ')
            {
                return "・－・－・";
            }
            // 数字
            if (character == '１' || character == '1')
            {
                return "・－－－－";
            }
            if (character == '２' || character == '2')
            {
                return "・・－－－";
            }
            if (character == '３' || character == '3')
            {
                return "・・・－－";
            }
            if (character == '４' || character == '4')
            {
                return "・・・・－";
            }
            if (character == '５' || character == '5')
            {
                return "・・・・・";
            }
            if (character == '６' || character == '6')
            {
                return "－・・・・";
            }
            if (character == '７' || character == '7')
            {
                return "－－・・・";
            }
            if (character == '８' || character == '8')
            {
                return "－－－・・";
            }
            if (character == '９' || character == '9')
            {
                return "－－－－・";
            }
            if (character == '０' || character == '0')
            {
                return "－－－－－";
            }
            // 記号
            if (character == 'ー')
            {
                return "・－－・－";
            }
            if (character == '、')
            {
                return "・－・－・－";
            }
            if (character == 'ﾞ' || character == '゛')
            {
                return "・・";
            }
            if (character == 'ﾟ' || character == '゜')
            {
                return "・・－－・";
            }

            return " ";
        }
    }
}
