using System.Text.RegularExpressions;

namespace KIBOTTER
{
    class MorseCode
    {
        public string ConvertToMorse(string original) // もーるすもーど用
        {
            if (original.Length > 20)
            {
                return "error";
            }

            char[] arrayOriginal = original.ToCharArray();
            int mode = JudgeMode(arrayOriginal);

            if (mode == -1)
                return "error";
            
            string resultText = string.Empty;

            for (int i = 0; i < original.Length; i++)
            {
                resultText += JudgeMorse(arrayOriginal[i], mode) + "　";
            }

            return resultText;
        }

        public string Convert(string orig, string dot, string dash, string space) // へんかんつーる用
        {
            if (orig == string.Empty)
                return "ここにへんかんけっかがでます(:3)";

            char[] arrayOrig = orig.ToCharArray();

            int mode = JudgeMode(arrayOrig);

            if (mode != -1)
            {
                string resultText = string.Empty;

                for (int i = 0; i < orig.Length; i++)
                {
                    resultText += JudgeMorse(arrayOrig[i], mode) + "　";
                }

                return resultText;
            }

            foreach (char oneArrayOrig in arrayOrig)
            {
                string oneChar = oneArrayOrig.ToString();

                if (oneChar != dot && oneChar != dash && oneChar != space)
                    return "error";
            }

            string[] morseArray = orig.Split(space.ToCharArray()[0]);

            string resultEnText = string.Empty;
            string resultJaText = string.Empty;

            foreach (string s in morseArray)
            {
                resultEnText += MorseToEn(s, dot, dash);
                resultJaText += MorseToJa(s, dot, dash);
            }

            return $"{resultEnText}(えーご)\r\n{resultJaText}(にほんご)";
        }

        private int JudgeMode(char[] arrayOrig)
        {
            // mode = 0 で英語, 1 で日本語ひらがな, 2 で日本語カタカナ

            foreach (char oneArrayOrig in arrayOrig)
            {
                string oneChar = oneArrayOrig.ToString();

                if (Regex.IsMatch(oneChar, @"^[a-zA-Z]+$"))
                {
                    return 0;
                }

                if (Regex.IsMatch(oneChar, @"^\p{IsHiragana}+$"))
                {
                    return 1;
                }

                if (Regex.IsMatch(oneChar, @"^[\u30A0-\u30FA\u31F0-\u31FF\uFF66-\uFF9F]+$"))
                {
                    return 2;
                }
            }

            return -1;
        }

        private string JudgeMorse(char c, int mode)
        {
            if (mode == 0)
            {
                return EnToMorse(c);
            }
            if (mode == 1)
            {
                return JaHiraToMorse(c);
            }
            if (mode == 2)
            {
                return JaKataToMorse(c);
            }

            return "error";
        }

        private string EnToMorse(char c)
        {
            if (c == 'a' || c == 'A')
            {
                return "・－";
            }
            if (c == 'b' || c == 'B')
            {
                return "－・・・";
            }
            if (c == 'c' || c == 'C')
            {
                return "－・－・";
            }
            if (c == 'd' || c == 'D')
            {
                return "－・・";
            }
            if (c == 'e' || c == 'E')
            {
                return "・";
            }
            if (c == 'f' || c == 'F')
            {
                return "・・－・";
            }
            if (c == 'g' || c == 'G')
            {
                return "－－・";
            }
            if (c == 'h' || c == 'H')
            {
                return "・・・・";
            }
            if (c == 'i' || c == 'I')
            {
                return "・・";
            }
            if (c == 'j' || c == 'J')
            {
                return "・－－－";
            }
            if (c == 'k' || c == 'K')
            {
                return "－・－";
            }
            if (c == 'l' || c == 'L')
            {
                return "・－・・";
            }
            if (c == 'm' || c == 'M')
            {
                return "－－";
            }
            if (c == 'n' || c == 'N')
            {
                return "－・";
            }
            if (c == 'o' || c == 'O')
            {
                return "－－－";
            }
            if (c == 'p' || c == 'P')
            {
                return "・－－・";
            }
            if (c == 'q' || c == 'Q')
            {
                return "－－・－";
            }
            if (c == 'r' || c == 'R')
            {
                return "・－・";
            }
            if (c == 's' || c == 'S')
            {
                return "・・・";
            }
            if (c == 't' || c == 'T')
            {
                return "－";
            }
            if (c == 'u' || c == 'U')
            {
                return "・・－";
            }
            if (c == 'v' || c == 'V')
            {
                return "・・・－";
            }
            if (c == 'w' || c == 'W')
            {
                return "・－－";
            }
            if (c == 'x' || c == 'X')
            {
                return "－・・－";
            }
            if (c == 'y' || c == 'Y')
            {
                return "－・－－";
            }
            if (c == 'z' || c == 'Z')
            {
                return "－－・・";
            }
            // 数字
            if (c == '1')
            {
                return "・－－－－";
            }
            if (c == '2')
            {
                return "・・－－－";
            }
            if (c == '3')
            {
                return "・・・－－";
            }
            if (c == '4')
            {
                return "・・・・－";
            }
            if (c == '5')
            {
                return "・・・・・";
            }
            if (c == '6')
            {
                return "－・・・・";
            }
            if (c == '7')
            {
                return "－－・・・";
            }
            if (c == '8')
            {
                return "－－－・・";
            }
            if (c == '9')
            {
                return "－－－－・";
            }
            if (c == '0')
            {
                return "－－－－－";
            }
            // 欧文記号
            if (c == ',')
            {
                return "－－・・－－";
            }
            if (c == '.')
            {
                return "・－・－・－";
            }
            if (c == '?')
            {
                return "・・－－・・";
            }

            return " ";
        }

        private string JaHiraToMorse(char c)
        {
            if (c == 'あ' || c == 'ぁ')
            {
                return "－－・－－";
            }
            if (c == 'い' || c == 'ぃ')
            {
                return "・－";
            }
            if (c == 'う' || c == 'ぅ')
            {
                return "・・－";
            }
            if (c == 'え' || c == 'ぇ')
            {
                return "－・－－－";
            }
            if (c == 'お' || c == 'ぉ')
            {
                return "・－・・・";
            }
            if (c == 'か' || c == 'が')
            {
                if (c == 'が')
                {
                    return "・－・・　・・";
                }
                return "・－・・";
            }
            if (c == 'き' || c == 'ぎ')
            {
                if (c == 'ぎ')
                {
                    return "－・－・・　・・";
                }
                return "－・－・・";
            }
            if (c == 'く' || c == 'ぐ')
            {
                if (c == 'ぐ')
                {
                    return "・・・－　・・";
                }
                return "・・・－";
            }
            if (c == 'け' || c == 'げ')
            {
                if (c == 'げ')
                {
                    return "－・－－　・・";
                }
                return "－・－－";
            }
            if (c == 'こ' || c == 'ご')
            {
                if (c == 'ご')
                {
                    return "－－－－　・・";
                }
                return "－－－－";
            }
            if (c == 'さ' || c == 'ざ')
            {
                if (c == 'ざ')
                {
                    return "－・－・－　・・";
                }
                return "－・－・－";
            }
            if (c == 'し' || c == 'じ')
            {
                if (c == 'じ')
                {
                    return "－－・－・　・・";
                }
                return "－－・－・";
            }
            if (c == 'す' || c == 'ず')
            {
                if (c == 'ず')
                {
                    return "－－－・－　・・";
                }
                return "－－－・－";
            }
            if (c == 'せ' || c == 'ぜ')
            {
                if (c == 'ぜ')
                {
                    return "・－－－・　・・";
                }
                return "・－－－・";
            }
            if (c == 'そ' || c == 'ぞ')
            {
                if (c == 'ぞ')
                {
                    return "－－－・　・・";
                }
                return "－－－・";
            }
            if (c == 'た' || c == 'だ')
            {
                if (c == 'だ')
                {
                    return "－・　・・";
                }
                return "－・";
            }
            if (c == 'ち' || c == 'ぢ')
            {
                if (c == 'ぢ')
                {
                    return "・・－・　・・";
                }
                return "・・－・";
            }
            if (c == 'つ' || c == 'づ' || c == 'っ')
            {
                if (c == 'づ')
                {
                    return "・－－・　・・";
                }
                return "・－－・";
            }
            if (c == 'て' || c == 'で')
            {
                if (c == 'で')
                {
                    return "・－・－－　・・";
                }
                return "・－・－－";
            }
            if (c == 'と' || c == 'ど')
            {
                if (c == 'ど')
                {
                    return "・・－・・　・・";
                }
                return "・・－・・";
            }
            if (c == 'な')
            {
                return "・－・";
            }
            if (c == 'に')
            {
                return "－・－・";
            }
            if (c == 'ぬ')
            {
                return "・・・・";
            }
            if (c == 'ね')
            {
                return "－－・－";
            }
            if (c == 'の')
            {
                return "・・－－";
            }
            if (c == 'は' || c == 'ば' || c == 'ぱ')
            {
                if (c == 'ば')
                {
                    return "－・・・　・・";
                }
                if (c == 'ぱ')
                {
                    return "－・・・　・・－－・";
                }
                return "－・・・";
            }
            if (c == 'ひ' || c == 'び' || c == 'ぴ')
            {
                if (c == 'び')
                {
                    return "－－・・－　・・";
                }
                if (c == 'ぴ')
                {
                    return "－－・・－　・・－－・";
                }
                return "－－・・－";
            }
            if (c == 'ふ' || c == 'ぶ' || c == 'ぷ')
            {
                if (c == 'ぶ')
                {
                    return "－－・・　・・";
                }
                if (c == 'ぷ')
                {
                    return "－－・・　・・－－・";
                }
                return "－－・・";
            }
            if (c == 'へ' || c == 'べ' || c == 'ぺ')
            {
                if (c == 'べ')
                {
                    return "・　・・";
                }
                if (c == 'ぺ')
                {
                    return "・　・・－－・";
                }
                return "・";
            }
            if (c == 'ほ' || c == 'ぼ' || c == 'ぽ')
            {
                if (c == 'ぼ')
                {
                    return "－・・　・・";
                }
                if (c == 'ぽ')
                {
                    return "－・・　・・－－・";
                }
                return "－・・";
            }
            if (c == 'ま')
            {
                return "－・・－";
            }
            if (c == 'み')
            {
                return "・・－・－";
            }
            if (c == 'む')
            {
                return "－";
            }
            if (c == 'め')
            {
                return "－・・・－";
            }
            if (c == 'も')
            {
                return "－・・－・";
            }
            if (c == 'や' || c == 'ゃ')
            {
                return "・－－";
            }
            if (c == 'ゆ' || c == 'ゅ')
            {
                return "－・・－－";
            }
            if (c == 'よ' || c == 'ょ')
            {
                return "－－";
            }
            if (c == 'ら')
            {
                return "・・・";
            }
            if (c == 'り')
            {
                return "－－・";
            }
            if (c == 'る')
            {
                return "－・－－・";
            }
            if (c == 'れ')
            {
                return "－－－";
            }
            if (c == 'ろ')
            {
                return "・－・－";
            }
            if (c == 'わ' || c == 'ゎ')
            {
                return "－・－";
            }
            if (c == 'ゐ')
            {
                return "・－・・－";
            }
            if (c == 'ゑ')
            {
                return "・－－・・";
            }
            if (c == 'を')
            {
                return "・－－－";
            }
            if (c == 'ん')
            {
                return "・－・－・";
            }
            // 数字
            if (c == '１' || c == '1')
            {
                return "・－－－－";
            }
            if (c == '２' || c == '2')
            {
                return "・・－－－";
            }
            if (c == '３' || c == '3')
            {
                return "・・・－－";
            }
            if (c == '４' || c == '4')
            {
                return "・・・・－";
            }
            if (c == '５' || c == '5')
            {
                return "・・・・・";
            }
            if (c == '６' || c == '6')
            {
                return "－・・・・";
            }
            if (c == '７' || c == '7')
            {
                return "－－・・・";
            }
            if (c == '８' || c == '8')
            {
                return "－－－・・";
            }
            if (c == '９' || c == '9')
            {
                return "－－－－・";
            }
            if (c == '０' || c == '0')
            {
                return "－－－－－";
            }
            // 記号
            if (c == 'ー')
            {
                return "・－－・－";
            }
            if (c == '、')
            {
                return "・－・－・－";
            }
            if (c == '゛')
            {
                return "・・";
            }
            if (c == '゜')
            {
                return "・・－－・";
            }

            return " ";
        }

        private string JaKataToMorse(char c)
        {
            if (c == 'ア' || c == 'ァ'
                 || c == 'ｱ' || c == 'ｧ')
            {
                return "－－・－－";
            }
            if (c == 'イ' || c == 'ィ'
                 || c == 'ｲ' || c == 'ｨ')
            {
                return "・－";
            }
            if (c == 'ウ' || c == 'ゥ'
                 || c == 'ｳ' || c == 'ｩ')
            {
                return "・・－";
            }
            if (c == 'エ' || c == 'ェ'
                 || c == 'ｴ' || c == 'ｪ')
            {
                return "－・－－－";
            }
            if (c == 'オ' || c == 'ォ'
                 || c == 'ｵ' || c == 'ｫ')
            {
                return "・－・・・";
            }
            if (c == 'カ' || c == 'ガ' || c == 'ｶ')
            {
                if (c == 'ガ')
                {
                    return "・－・・　・・";
                }
                return "・－・・";
            }
            if (c == 'キ' || c == 'ギ' || c == 'ｷ')
            {
                if (c == 'ギ')
                {
                    return "－・－・・　・・";
                }
                return "－・－・・";
            }
            if (c == 'ク' || c == 'グ' || c == 'ｸ')
            {
                if (c == 'グ')
                {
                    return "・・・－　・・";
                }
                return "・・・－";
            }
            if (c == 'ケ' || c == 'ゲ' || c == 'ｹ')
            {
                if (c == 'ゲ')
                {
                    return "－・－－　・・";
                }
                return "－・－－";
            }
            if (c == 'コ' || c == 'ゴ' || c == 'ｺ')
            {
                if (c == 'ゴ')
                {
                    return "－－－－　・・";
                }
                return "－－－－";
            }
            if (c == 'サ' || c == 'ザ' || c == 'ｻ')
            {
                if (c == 'ザ')
                {
                    return "－・－・－　・・";
                }
                return "－・－・－";
            }
            if (c == 'シ' || c == 'ジ' || c == 'ｼ')
            {
                if (c == 'ジ')
                {
                    return "－－・－・　・・";
                }
                return "－－・－・";
            }
            if (c == 'ス' || c == 'ズ' || c == 'ｽ')
            {
                if (c == 'ズ')
                {
                    return "－－－・－　・・";
                }
                return "－－－・－";
            }
            if (c == 'セ' || c == 'ゼ' || c == 'ｾ')
            {
                if (c == 'ゼ')
                {
                    return "・－－－・　・・";
                }
                return "・－－－・";
            }
            if (c == 'ソ' || c == 'ゾ' || c == 'ｿ')
            {
                if (c == 'ゾ')
                {
                    return "－－－・　・・";
                }
                return "－－－・";
            }
            if (c == 'タ' || c == 'ダ' || c == 'ﾀ')
            {
                if (c == 'ダ')
                {
                    return "－・　・・";
                }
                return "－・";
            }
            if (c == 'チ' || c == 'ヂ' || c == 'ﾁ')
            {
                if (c == 'ヂ')
                {
                    return "・・－・　・・";
                }
                return "・・－・";
            }
            if (c == 'ツ' || c == 'ヅ' || c == 'ッ'
                 || c == 'ﾂ' || c == 'ｯ')
            {
                if (c == 'ヅ')
                {
                    return "・－－・　・・";
                }
                return "・－－・";
            }
            if (c == 'テ' || c == 'デ' || c == 'ﾃ')
            {
                if (c == 'デ')
                {
                    return "・－・－－　・・";
                }
                return "・－・－－";
            }
            if (c == 'ト' || c == 'ド' || c == 'ﾄ')
            {
                if (c == 'ド')
                {
                    return "・・－・・　・・";
                }
                return "・・－・・";
            }
            if (c == 'ナ' || c == 'ﾅ')
            {
                return "・－・";
            }
            if (c == 'ニ' || c == 'ﾆ')
            {
                return "－・－・";
            }
            if (c == 'ヌ' || c == 'ﾇ')
            {
                return "・・・・";
            }
            if (c == 'ネ' || c == 'ﾈ')
            {
                return "－－・－";
            }
            if (c == 'ノ' || c == 'ﾉ')
            {
                return "・・－－";
            }
            if (c == 'ハ' || c == 'バ' || c == 'パ'
                 || c == 'ﾊ')
            {
                if (c == 'バ')
                {
                    return "－・・・　・・";
                }
                if (c == 'パ')
                {
                    return "－・・・　・・－－・";
                }
                return "－・・・";
            }
            if (c == 'ヒ' || c == 'ビ' || c == 'ピ'
                 || c == 'ﾋ')
            {
                if (c == 'ビ')
                {
                    return "－－・・－　・・";
                }
                if (c == 'ピ')
                {
                    return "－－・・－　・・－－・";
                }
                return "－－・・－";
            }
            if (c == 'フ' || c == 'ブ' || c == 'プ'
                 || c == 'ﾌ')
            {
                if (c == 'ブ')
                {
                    return "－－・・　・・";
                }
                if (c == 'プ')
                {
                    return "－－・・　・・－－・";
                }
                return "－－・・";
            }
            if (c == 'ヘ' || c == 'ベ' || c == 'ペ'
                 || c == 'ﾍ')
            {
                if (c == 'ベ')
                {
                    return "・　・・";
                }
                if (c == 'ペ')
                {
                    return "・　・・－－・";
                }
                return "・";
            }
            if (c == 'ホ' || c == 'ボ' || c == 'ポ'
                 || c == 'ﾎ')
            {
                if (c == 'ボ')
                {
                    return "－・・　・・";
                }
                if (c == 'ポ')
                {
                    return "－・・　・・－－・";
                }
                return "－・・";
            }
            if (c == 'マ' || c == 'ﾏ')
            {
                return "－・・－";
            }
            if (c == 'ミ' || c == 'ﾐ')
            {
                return "・・－・－";
            }
            if (c == 'ム' || c == 'ﾑ')
            {
                return "－";
            }
            if (c == 'メ' || c == 'ﾒ')
            {
                return "－・・・－";
            }
            if (c == 'モ' || c == 'ﾓ')
            {
                return "－・・－・";
            }
            if (c == 'ヤ' || c == 'ャ'
                 || c == 'ﾔ' || c == 'ｬ')
            {
                return "・－－";
            }
            if (c == 'ユ' || c == 'ュ'
                 || c == 'ﾕ' || c == 'ｭ')
            {
                return "－・・－－";
            }
            if (c == 'ヨ' || c == 'ョ'
                 || c == 'ﾖ' || c == 'ｮ')
            {
                return "－－";
            }
            if (c == 'ラ' || c == 'ﾗ')
            {
                return "・・・";
            }
            if (c == 'リ' || c == 'ﾘ')
            {
                return "－－・";
            }
            if (c == 'ル' || c == 'ﾙ')
            {
                return "－・－－・";
            }
            if (c == 'レ' || c == 'ﾚ')
            {
                return "－－－";
            }
            if (c == 'ロ' || c == 'ﾛ')
            {
                return "・－・－";
            }
            if (c == 'ワ' || c == 'ヮ' || c == 'ﾜ')
            {
                return "－・－";
            }
            if (c == 'ヰ')
            {
                return "・－・・－";
            }
            if (c == 'ヱ')
            {
                return "・－－・・";
            }
            if (c == 'ヲ' || c == 'ｦ')
            {
                return "・－－－";
            }
            if (c == 'ン' || c == 'ﾝ')
            {
                return "・－・－・";
            }
            // 数字
            if (c == '１' || c == '1')
            {
                return "・－－－－";
            }
            if (c == '２' || c == '2')
            {
                return "・・－－－";
            }
            if (c == '３' || c == '3')
            {
                return "・・・－－";
            }
            if (c == '４' || c == '4')
            {
                return "・・・・－";
            }
            if (c == '５' || c == '5')
            {
                return "・・・・・";
            }
            if (c == '６' || c == '6')
            {
                return "－・・・・";
            }
            if (c == '７' || c == '7')
            {
                return "－－・・・";
            }
            if (c == '８' || c == '8')
            {
                return "－－－・・";
            }
            if (c == '９' || c == '9')
            {
                return "－－－－・";
            }
            if (c == '０' || c == '0')
            {
                return "－－－－－";
            }
            // 記号
            if (c == 'ー')
            {
                return "・－－・－";
            }
            if (c == '、')
            {
                return "・－・－・－";
            }
            if (c == 'ﾞ' || c == '゛')
            {
                return "・・";
            }
            if (c == 'ﾟ' || c == '゜')
            {
                return "・・－－・";
            }

            return " ";
        }

        private string MorseToEn(string s, string dot, string dash)
        {
            if (s == $"{dot}{dash}")
            {
                return "a";
            }
            if (s == $"{dash}{dot}{dot}{dot}")
            {
                return "b";
            }
            if (s == $"{dash}{dot}{dash}{dot}")
            {
                return "c";
            }
            if (s == $"{dash}{dot}{dot}")
            {
                return "d";
            }
            if (s == $"{dot}")
            {
                return "e";
            }
            if (s == $"{dot}{dot}{dash}{dot}")
            {
                return "f";
            }
            if (s == $"{dash}{dash}{dot}")
            {
                return "g";
            }
            if (s == $"{dot}{dot}{dot}{dot}")
            {
                return "h";
            }
            if (s == $"{dot}{dot}")
            {
                return "i";
            }
            if (s == $"{dot}{dash}{dash}{dash}")
            {
                return "j";
            }
            if (s == $"{dash}{dot}{dash}")
            {
                return "k";
            }
            if (s == $"{dot}{dash}{dot}{dot}")
            {
                return "l";
            }
            if (s == $"{dash}{dash}")
            {
                return "m";
            }
            if (s == $"{dash}{dot}")
            {
                return "n";
            }
            if (s == $"{dash}{dash}{dash}")
            {
                return "o";
            }
            if (s == $"{dot}{dash}{dash}{dot}")
            {
                return "p";
            }
            if (s == $"{dash}{dash}{dot}{dash}")
            {
                return "q";
            }
            if (s == $"{dot}{dash}{dot}")
            {
                return "r";
            }
            if (s == $"{dot}{dot}{dot}")
            {
                return "s";
            }
            if (s == $"{dash}")
            {
                return "t";
            }
            if (s == $"{dot}{dot}{dash}")
            {
                return "u";
            }
            if (s == $"{dot}{dot}{dot}{dash}")
            {
                return "v";
            }
            if (s == $"{dot}{dash}{dash}")
            {
                return "w";
            }
            if (s == $"{dash}{dot}{dot}{dash}")
            {
                return "x";
            }
            if (s == $"{dash}{dot}{dash}{dash}")
            {
                return "y";
            }
            if (s == $"{dash}{dash}{dot}{dot}")
            {
                return "";
            }
            // 数字
            if (s == $"{dot}{dash}{dash}{dash}{dash}")
            {
                return "1";
            }
            if (s == $"{dot}{dot}{dash}{dash}{dash}")
            {
                return "2";
            }
            if (s == $"{dot}{dot}{dot}{dash}{dash}")
            {
                return "3";
            }
            if (s == $"{dot}{dot}{dot}{dot}{dash}")
            {
                return "4";
            }
            if (s == $"{dot}{dot}{dot}{dot}{dot}")
            {
                return "5";
            }
            if (s == $"{dash}{dot}{dot}{dot}{dot}")
            {
                return "6";
            }
            if (s == $"{dash}{dash}{dot}{dot}{dot}")
            {
                return "7";
            }
            if (s == $"{dash}{dash}{dash}{dot}{dot}")
            {
                return "8";
            }
            if (s == $"{dash}{dash}{dash}{dash}{dot}")
            {
                return "9";
            }
            if (s == $"{dash}{dash}{dash}{dash}{dash}")
            {
                return "0";
            }
            // 欧文記号
            if (s == $"{dash}{dash}{dot}{dot}{dash}{dash}")
            {
                return ",";
            }
            if (s == $"{dot}{dash}{dot}{dash}{dot}{dash}")
            {
                return ".";
            }
            if (s == $"{dot}{dot}{dash}{dash}{dot}{dot}")
            {
                return "?";
            }

            return " ";
        }

        private string MorseToJa(string s, string dot, string dash)
        {
            if (s == $"{dash}{dash}{dot}{dash}{dash}")
            {
                return "あ";
            }
            if (s == $"{dot}{dash}")
            {
                return "い";
            }
            if (s == $"{dot}{dot}{dash}")
            {
                return "う";
            }
            if (s == $"{dash}{dot}{dash}{dash}{dash}")
            {
                return "え";
            }
            if (s == $"{dot}{dash}{dot}{dot}{dot}")
            {
                return "お";
            }
            if (s == $"{dot}{dash}{dot}{dot}")
            {
                return "か";
            }
            if (s == $"{dash}{dot}{dash}{dot}{dot}")
            {
                return "き";
            }
            if (s == $"{dot}{dot}{dot}{dash}")
            {
                return "く";
            }
            if (s == $"{dash}{dot}{dash}{dash}")
            {
                return "け";
            }
            if (s == $"{dash}{dash}{dash}{dash}")
            {
                return "こ";
            }
            if (s == $"{dash}{dot}{dash}{dot}{dash}")
            {
                return "さ";
            }
            if (s == $"{dash}{dash}{dot}{dash}{dot}")
            {
                return "し";
            }
            if (s == $"{dash}{dash}{dash}{dot}{dash}")
            {
                return "す";
            }
            if (s == $"{dot}{dash}{dash}{dash}{dot}")
            {
                return "せ";
            }
            if (s == $"{dash}{dash}{dash}{dot}")
            {
                return "そ";
            }
            if (s == $"{dash}{dot}")
            {
                return "た";
            }
            if (s == $"{dot}{dot}{dash}{dot}")
            {
                return "ち";
            }
            if (s == $"{dot}{dash}{dash}{dot}")
            {
                return "つ";
            }
            if (s == $"{dot}{dash}{dot}{dash}{dash}")
            {
                return "て";
            }
            if (s == $"{dot}{dot}{dash}{dot}{dot}")
            {
                return "と";
            }
            if (s == $"{dot}{dash}{dot}")
            {
                return "な";
            }
            if (s == $"{dash}{dot}{dash}{dot}")
            {
                return "に";
            }
            if (s == $"{dot}{dot}{dot}{dot}")
            {
                return "ぬ";
            }
            if (s == $"{dash}{dash}{dot}{dash}")
            {
                return "ね";
            }
            if (s == $"{dot}{dot}{dash}{dash}")
            {
                return "の";
            }
            if (s == $"{dash}{dot}{dot}{dot}")
            {
                return "は";
            }
            if (s == $"{dash}{dash}{dot}{dot}{dash}")
            {
                return "ひ";
            }
            if (s == $"{dash}{dash}{dot}{dot}")
            {
                return "ふ";
            }
            if (s == $"{dot}")
            {
                return "へ";
            }
            if (s == $"{dash}{dot}{dot}")
            {
                return "ほ";
            }
            if (s == $"{dash}{dot}{dot}{dash}")
            {
                return "ま";
            }
            if (s == $"{dot}{dot}{dash}{dot}{dash}")
            {
                return "み";
            }
            if (s == $"{dash}")
            {
                return "む";
            }
            if (s == $"{dash}{dot}{dot}{dot}{dash}")
            {
                return "め";
            }
            if (s == $"{dash}{dot}{dot}{dash}{dot}")
            {
                return "も";
            }
            if (s == $"{dot}{dash}{dash}")
            {
                return "や";
            }
            if (s == $"{dash}{dot}{dot}{dash}{dash}")
            {
                return "ゆ";
            }
            if (s == $"{dash}{dash}")
            {
                return "よ";
            }
            if (s == $"{dot}{dot}{dot}")
            {
                return "ら";
            }
            if (s == $"{dash}{dash}{dot}")
            {
                return "り";
            }
            if (s == $"{dash}{dot}{dash}{dash}{dot}")
            {
                return "る";
            }
            if (s == $"{dash}{dash}{dash}")
            {
                return "れ";
            }
            if (s == $"{dot}{dash}{dot}{dash}")
            {
                return "ろ";
            }
            if (s == $"{dash}{dot}{dash}")
            {
                return "わ";
            }
            if (s == $"{dot}{dash}{dot}{dot}{dash}")
            {
                return "ゐ";
            }
            if (s == $"{dot}{dash}{dash}{dot}{dot}")
            {
                return "ゑ";
            }
            if (s == $"{dot}{dash}{dash}{dash}")
            {
                return "を";
            }
            if (s == $"{dot}{dash}{dot}{dash}{dot}")
            {
                return "ん";
            }
            // 数字
            if (s == $"{dot}{dash}{dash}{dash}{dash}")
            {
                return "1";
            }
            if (s == $"{dot}{dot}{dash}{dash}{dash}")
            {
                return "2";
            }
            if (s == $"{dot}{dot}{dot}{dash}{dash}")
            {
                return "3";
            }
            if (s == $"{dot}{dot}{dot}{dot}{dash}")
            {
                return "4";
            }
            if (s == $"{dot}{dot}{dot}{dot}{dot}")
            {
                return "5";
            }
            if (s == $"{dash}{dot}{dot}{dot}{dot}")
            {
                return "6";
            }
            if (s == $"{dash}{dash}{dot}{dot}{dot}")
            {
                return "7";
            }
            if (s == $"{dash}{dash}{dash}{dot}{dot}")
            {
                return "8";
            }
            if (s == $"{dash}{dash}{dash}{dash}{dot}")
            {
                return "9";
            }
            if (s == $"{dash}{dash}{dash}{dash}{dash}")
            {
                return "0";
            }
            // 記号
            if (s == $"{dot}{dash}{dash}{dot}{dash}")
            {
                return "ー";
            }
            if (s == $"{dot}{dash}{dot}{dash}{dot}{dash}")
            {
                return "、";
            }
            if (s == $"{dot}{dot}")
            {
                return "゛";
            }
            if (s == $"{dot}{dot}{dash}{dash}{dot}")
            {
                return "゜";
            }

            return " ";
        }
    }
}
