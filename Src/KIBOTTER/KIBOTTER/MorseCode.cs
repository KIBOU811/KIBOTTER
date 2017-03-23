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
            else if (mode == 1)
            {
                return JaHiraToMorse(character);
            }
            else if (mode == 2)
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
            else if (character == 'b' || character == 'B')
            {
                return "－・・・";
            }
            else if (character == 'c' || character == 'C')
            {
                return "－・－・";
            }
            else if (character == 'd' || character == 'D')
            {
                return "－・・";
            }
            else if (character == 'e' || character == 'E')
            {
                return "・";
            }
            else if (character == 'f' || character == 'F')
            {
                return "・・－・";
            }
            else if (character == 'g' || character == 'G')
            {
                return "－－・";
            }
            else if (character == 'h' || character == 'H')
            {
                return "・・・・";
            }
            else if (character == 'i' || character == 'I')
            {
                return "・・";
            }
            else if (character == 'j' || character == 'J')
            {
                return "・－－－";
            }
            else if (character == 'k' || character == 'K')
            {
                return "－・－";
            }
            else if (character == 'l' || character == 'L')
            {
                return "・－・・";
            }
            else if (character == 'm' || character == 'M')
            {
                return "－－";
            }
            else if (character == 'n' || character == 'N')
            {
                return "－・";
            }
            else if (character == 'o' || character == 'O')
            {
                return "－－－";
            }
            else if (character == 'p' || character == 'P')
            {
                return "・－－・";
            }
            else if (character == 'q' || character == 'Q')
            {
                return "－－・－";
            }
            else if (character == 'r' || character == 'R')
            {
                return "・－・";
            }
            else if (character == 's' || character == 'S')
            {
                return "・・・";
            }
            else if (character == 't' || character == 'T')
            {
                return "－";
            }
            else if (character == 'u' || character == 'U')
            {
                return "・・－";
            }
            else if (character == 'v' || character == 'V')
            {
                return "・・・－";
            }
            else if (character == 'w' || character == 'W')
            {
                return "・－－";
            }
            else if (character == 'x' || character == 'X')
            {
                return "－・・－";
            }
            else if (character == 'y' || character == 'Y')
            {
                return "－・－－";
            }
            else if (character == 'z' || character == 'Z')
            {
                return "－－・・";
            }
            // 数字
            else if (character == '1')
            {
                return "・－－－－";
            }
            else if (character == '2')
            {
                return "・・－－－";
            }
            else if (character == '3')
            {
                return "・・・－－";
            }
            else if (character == '4')
            {
                return "・・・・－";
            }
            else if (character == '5')
            {
                return "・・・・・";
            }
            else if (character == '6')
            {
                return "－・・・・";
            }
            else if (character == '7')
            {
                return "－－・・・";
            }
            else if (character == '8')
            {
                return "－－－・・";
            }
            else if (character == '9')
            {
                return "－－－－・";
            }
            else if (character == '0')
            {
                return "－－－－－";
            }
            // 欧文記号
            else if (character == ',')
            {
                return "－－・・－－";
            }
            else if (character == '.')
            {
                return "・－・－・－";
            }
            else if (character == '?')
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
            else if (character == 'い' || character == 'ぃ')
            {
                return "・－";
            }
            else if (character == 'う' || character == 'ぅ')
            {
                return "・・－";
            }
            else if (character == 'え' || character == 'ぇ')
            {
                return "－・－－－";
            }
            else if (character == 'お' || character == 'ぉ')
            {
                return "・－・・・";
            }
            else if (character == 'か' || character == 'が')
            {
                if (character == 'が')
                {
                    return "・－・・ ・・";
                }
                return "・－・・";
            }
            else if (character == 'き' || character == 'ぎ')
            {
                if (character == 'ぎ')
                {
                    return "－・－・・ ・・";
                }
                return "－・－・・";
            }
            else if (character == 'く' || character == 'ぐ')
            {
                if (character == 'ぐ')
                {
                    return "・・・－ ・・";
                }
                return "・・・－";
            }
            else if (character == 'け' || character == 'げ')
            {
                if (character == 'げ')
                {
                    return "－・－－ ・・";
                }
                return "－・－－";
            }
            else if (character == 'こ' || character == 'ご')
            {
                if (character == 'ご')
                {
                    return "－－－－ ・・";
                }
                return "－－－－";
            }
            else if (character == 'さ' || character == 'ざ')
            {
                if (character == 'ざ')
                {
                    return "－・－・－ ・・";
                }
                return "－・－・－";
            }
            else if (character == 'し' || character == 'じ')
            {
                if (character == 'じ')
                {
                    return "－－・－・ ・・";
                }
                return "－－・－・";
            }
            else if (character == 'す' || character == 'ず')
            {
                if (character == 'ず')
                {
                    return "－－－・－ ・・";
                }
                return "－－－・－";
            }
            else if (character == 'せ' || character == 'ぜ')
            {
                if (character == 'ぜ')
                {
                    return "・－－－・ ・・";
                }
                return "・－－－・";
            }
            else if (character == 'そ' || character == 'ぞ')
            {
                if (character == 'ぞ')
                {
                    return "－－－・ ・・";
                }
                return "－－－・";
            }
            else if (character == 'た' || character == 'だ')
            {
                if (character == 'だ')
                {
                    return "－・ ・・";
                }
                return "－・";
            }
            else if (character == 'ち' || character == 'ぢ')
            {
                if (character == 'ぢ')
                {
                    return "・・－・ ・・";
                }
                return "・・－・";
            }
            else if (character == 'つ' || character == 'づ' || character == 'っ')
            {
                if (character == 'づ')
                {
                    return "・－－・ ・・";
                }
                return "・－－・";
            }
            else if (character == 'て' || character == 'で')
            {
                if (character == 'で')
                {
                    return "・－・－－ ・・";
                }
                return "・－・－－";
            }
            else if (character == 'と' || character == 'ど')
            {
                if (character == 'ど')
                {
                    return "・・－・・ ・・";
                }
                return "・・－・・";
            }
            else if (character == 'な')
            {
                return "・－・";
            }
            else if (character == 'に')
            {
                return "－・－・";
            }
            else if (character == 'ぬ')
            {
                return "・・・・";
            }
            else if (character == 'ね')
            {
                return "－－・－";
            }
            else if (character == 'の')
            {
                return "・・－－";
            }
            else if (character == 'は' || character == 'ば' || character == 'ぱ')
            {
                if (character == 'ば')
                {
                    return "－・・・ ・・";
                }
                else if (character == 'ぱ')
                {
                    return "－・・・ ・・－－・";
                }
                return "－・・・";
            }
            else if (character == 'ひ' || character == 'び' || character == 'ぴ')
            {
                if (character == 'び')
                {
                    return "－－・・－ ・・";
                }
                else if (character == 'ぴ')
                {
                    return "－－・・－ ・・－－・";
                }
                return "－－・・－";
            }
            else if (character == 'ふ' || character == 'ぶ' || character == 'ぷ')
            {
                if (character == 'ぶ')
                {
                    return "－－・・ ・・";
                }
                else if (character == 'ぷ')
                {
                    return "－－・・ ・・－－・";
                }
                return "－－・・";
            }
            else if (character == 'へ' || character == 'べ' || character == 'ぺ')
            {
                if (character == 'べ')
                {
                    return "・ ・・";
                }
                else if (character == 'ぺ')
                {
                    return "・ ・・－－・";
                }
                return "・";
            }
            else if (character == 'ほ' || character == 'ぼ' || character == 'ぽ')
            {
                if (character == 'ぼ')
                {
                    return "－・・ ・・";
                }
                else if (character == 'ぽ')
                {
                    return "－・・ ・・－－・";
                }
                return "－・・";
            }
            else if (character == 'ま')
            {
                return "－・・－";
            }
            else if (character == 'み')
            {
                return "・・－・－";
            }
            else if (character == 'む')
            {
                return "－";
            }
            else if (character == 'め')
            {
                return "－・・・－";
            }
            else if (character == 'も')
            {
                return "－・・－・";
            }
            else if (character == 'や' || character == 'ゃ')
            {
                return "・－－";
            }
            else if (character == 'ゆ' || character == 'ゅ')
            {
                return "－・・－－";
            }
            else if (character == 'よ' || character == 'ょ')
            {
                return "－－";
            }
            else if (character == 'ら')
            {
                return "・・・";
            }
            else if (character == 'り')
            {
                return "－－・";
            }
            else if (character == 'る')
            {
                return "－・－－・";
            }
            else if (character == 'れ')
            {
                return "－－－";
            }
            else if (character == 'ろ')
            {
                return "・－・－";
            }
            else if (character == 'わ' || character == 'ゎ')
            {
                return "－・－";
            }
            else if (character == 'ゐ')
            {
                return "・－・・－";
            }
            else if (character == 'ゑ')
            {
                return "・－－・・";
            }
            else if (character == 'を')
            {
                return "・－－－";
            }
            else if (character == 'ん')
            {
                return "・－・－・";
            }
            // 数字
            else if (character == '１' || character == '1')
            {
                return "・－－－－";
            }
            else if (character == '２' || character == '2')
            {
                return "・・－－－";
            }
            else if (character == '３' || character == '3')
            {
                return "・・・－－";
            }
            else if (character == '４' || character == '4')
            {
                return "・・・・－";
            }
            else if (character == '５' || character == '5')
            {
                return "・・・・・";
            }
            else if (character == '６' || character == '6')
            {
                return "－・・・・";
            }
            else if (character == '７' || character == '7')
            {
                return "－－・・・";
            }
            else if (character == '８' || character == '8')
            {
                return "－－－・・";
            }
            else if (character == '９' || character == '9')
            {
                return "－－－－・";
            }
            else if (character == '０' || character == '0')
            {
                return "－－－－－";
            }
            // 記号
            else if (character == 'ー')
            {
                return "・－－・－";
            }
            else if (character == '、')
            {
                return "・－・－・－";
            }
            else if (character == '゛')
            {
                return "・・";
            }
            else if (character == '゜')
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
            else if (character == 'イ' || character == 'ィ'
                 || character == 'ｲ' || character == 'ｨ')
            {
                return "・－";
            }
            else if (character == 'ウ' || character == 'ゥ'
                 || character == 'ｳ' || character == 'ｩ')
            {
                return "・・－";
            }
            else if (character == 'エ' || character == 'ェ'
                 || character == 'ｴ' || character == 'ｪ')
            {
                return "－・－－－";
            }
            else if (character == 'オ' || character == 'ォ'
                 || character == 'ｵ' || character == 'ｫ')
            {
                return "・－・・・";
            }
            else if (character == 'カ' || character == 'ガ' || character == 'ｶ')
            {
                if (character == 'ガ')
                {
                    return "・－・・ ・・";
                }
                return "・－・・";
            }
            else if (character == 'キ' || character == 'ギ' || character == 'ｷ')
            {
                if (character == 'ギ')
                {
                    return "－・－・・ ・・";
                }
                return "－・－・・";
            }
            else if (character == 'ク' || character == 'グ' || character == 'ｸ')
            {
                if (character == 'グ')
                {
                    return "・・・－ ・・";
                }
                return "・・・－";
            }
            else if (character == 'ケ' || character == 'ゲ' || character == 'ｹ')
            {
                if (character == 'ゲ')
                {
                    return "－・－－ ・・";
                }
                return "－・－－";
            }
            else if (character == 'コ' || character == 'ゴ' || character == 'ｺ')
            {
                if (character == 'ゴ')
                {
                    return "－－－－ ・・";
                }
                return "－－－－";
            }
            else if (character == 'サ' || character == 'ザ' || character == 'ｻ')
            {
                if (character == 'ザ')
                {
                    return "－・－・－ ・・";
                }
                return "－・－・－";
            }
            else if (character == 'シ' || character == 'ジ' || character == 'ｼ')
            {
                if (character == 'ジ')
                {
                    return "－－・－・ ・・";
                }
                return "－－・－・";
            }
            else if (character == 'ス' || character == 'ズ' || character == 'ｽ')
            {
                if (character == 'ズ')
                {
                    return "－－－・－ ・・";
                }
                return "－－－・－";
            }
            else if (character == 'セ' || character == 'ゼ' || character == 'ｾ')
            {
                if (character == 'ゼ')
                {
                    return "・－－－・ ・・";
                }
                return "・－－－・";
            }
            else if (character == 'ソ' || character == 'ゾ' || character == 'ｿ')
            {
                if (character == 'ゾ')
                {
                    return "－－－・ ・・";
                }
                return "－－－・";
            }
            else if (character == 'タ' || character == 'ダ' || character == 'ﾀ')
            {
                if (character == 'ダ')
                {
                    return "－・ ・・";
                }
                return "－・";
            }
            else if (character == 'チ' || character == 'ヂ' || character == 'ﾁ')
            {
                if (character == 'ヂ')
                {
                    return "・・－・ ・・";
                }
                return "・・－・";
            }
            else if (character == 'ツ' || character == 'ヅ' || character == 'ッ'
                 || character == 'ﾂ' || character == 'ｯ')
            {
                if (character == 'ヅ')
                {
                    return "・－－・ ・・";
                }
                return "・－－・";
            }
            else if (character == 'テ' || character == 'デ' || character == 'ﾃ')
            {
                if (character == 'デ')
                {
                    return "・－・－－ ・・";
                }
                return "・－・－－";
            }
            else if (character == 'ト' || character == 'ド' || character == 'ﾄ')
            {
                if (character == 'ド')
                {
                    return "・・－・・ ・・";
                }
                return "・・－・・";
            }
            else if (character == 'ナ' || character == 'ﾅ')
            {
                return "・－・";
            }
            else if (character == 'ニ' || character == 'ﾆ')
            {
                return "－・－・";
            }
            else if (character == 'ヌ' || character == 'ﾇ')
            {
                return "・・・・";
            }
            else if (character == 'ネ' || character == 'ﾈ')
            {
                return "－－・－";
            }
            else if (character == 'ノ' || character == 'ﾉ')
            {
                return "・・－－";
            }
            else if (character == 'ハ' || character == 'バ' || character == 'パ'
                 || character == 'ﾊ')
            {
                if (character == 'バ')
                {
                    return "－・・・ ・・";
                }
                else if (character == 'パ')
                {
                    return "－・・・ ・・－－・";
                }
                return "－・・・";
            }
            else if (character == 'ヒ' || character == 'ビ' || character == 'ピ'
                 || character == 'ﾋ')
            {
                if (character == 'ビ')
                {
                    return "－－・・－ ・・";
                }
                else if (character == 'ピ')
                {
                    return "－－・・－ ・・－－・";
                }
                return "－－・・－";
            }
            else if (character == 'フ' || character == 'ブ' || character == 'プ'
                 || character == 'ﾌ')
            {
                if (character == 'ブ')
                {
                    return "－－・・ ・・";
                }
                else if (character == 'プ')
                {
                    return "－－・・ ・・－－・";
                }
                return "－－・・";
            }
            else if (character == 'ヘ' || character == 'ベ' || character == 'ペ'
                 || character == 'ﾍ')
            {
                if (character == 'ベ')
                {
                    return "・ ・・";
                }
                else if (character == 'ペ')
                {
                    return "・ ・・－－・";
                }
                return "・";
            }
            else if (character == 'ホ' || character == 'ボ' || character == 'ポ'
                 || character == 'ﾎ')
            {
                if (character == 'ボ')
                {
                    return "－・・ ・・";
                }
                else if (character == 'ポ')
                {
                    return "－・・ ・・－－・";
                }
                return "－・・";
            }
            else if (character == 'マ' || character == 'ﾏ')
            {
                return "－・・－";
            }
            else if (character == 'ミ' || character == 'ﾐ')
            {
                return "・・－・－";
            }
            else if (character == 'ム' || character == 'ﾑ')
            {
                return "－";
            }
            else if (character == 'メ' || character == 'ﾒ')
            {
                return "－・・・－";
            }
            else if (character == 'モ' || character == 'ﾓ')
            {
                return "－・・－・";
            }
            else if (character == 'ヤ' || character == 'ャ'
                 || character == 'ﾔ' || character == 'ｬ')
            {
                return "・－－";
            }
            else if (character == 'ユ' || character == 'ュ'
                 || character == 'ﾕ' || character == 'ｭ')
            {
                return "－・・－－";
            }
            else if (character == 'ヨ' || character == 'ョ'
                 || character == 'ﾖ' || character == 'ｮ')
            {
                return "－－";
            }
            else if (character == 'ラ' || character == 'ﾗ')
            {
                return "・・・";
            }
            else if (character == 'リ' || character == 'ﾘ')
            {
                return "－－・";
            }
            else if (character == 'ル' || character == 'ﾙ')
            {
                return "－・－－・";
            }
            else if (character == 'レ' || character == 'ﾚ')
            {
                return "－－－";
            }
            else if (character == 'ロ' || character == 'ﾛ')
            {
                return "・－・－";
            }
            else if (character == 'ワ' || character == 'ヮ' || character == 'ﾜ')
            {
                return "－・－";
            }
            else if (character == 'ヰ')
            {
                return "・－・・－";
            }
            else if (character == 'ヱ')
            {
                return "・－－・・";
            }
            else if (character == 'ヲ' || character == 'ｦ')
            {
                return "・－－－";
            }
            else if (character == 'ン' || character == 'ﾝ')
            {
                return "・－・－・";
            }
            // 数字
            else if (character == '１' || character == '1')
            {
                return "・－－－－";
            }
            else if (character == '２' || character == '2')
            {
                return "・・－－－";
            }
            else if (character == '３' || character == '3')
            {
                return "・・・－－";
            }
            else if (character == '４' || character == '4')
            {
                return "・・・・－";
            }
            else if (character == '５' || character == '5')
            {
                return "・・・・・";
            }
            else if (character == '６' || character == '6')
            {
                return "－・・・・";
            }
            else if (character == '７' || character == '7')
            {
                return "－－・・・";
            }
            else if (character == '８' || character == '8')
            {
                return "－－－・・";
            }
            else if (character == '９' || character == '9')
            {
                return "－－－－・";
            }
            else if (character == '０' || character == '0')
            {
                return "－－－－－";
            }
            // 記号
            else if (character == 'ー')
            {
                return "・－－・－";
            }
            else if (character == '、')
            {
                return "・－・－・－";
            }
            else if (character == 'ﾞ' || character == '゛')
            {
                return "・・";
            }
            else if (character == 'ﾟ' || character == '゜')
            {
                return "・・－－・";
            }

            return " ";
        }
    }
}
