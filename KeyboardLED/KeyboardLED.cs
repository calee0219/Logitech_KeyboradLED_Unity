using System;
using System.Threading;
using LedCSharp;


namespace KeyboradLEDLibrary
{
    public class KeyboardLED
    {
        static void Main()
        {
            KeyboardLED led = new KeyboardLED();
            led.initLED();
            led.clearLED();
            led.fireDown(100, 0, 0);
            led.endLED();
        }
        // Sample using code
        //static void Main(string[] args)
        //{
        //    KeyboardLED a = new KeyboardLED();            -> New it
        //    Random rnd = new Random();
        //    a.initLED();                                  -> init
        //    a.clearLED();                                 -> if you want to clear the light of keyboard
        //    Console.WriteLine("Press ESC to stop");
        //    ConsoleKeyInfo keyinfo;
        //    do
        //    {
        //        keyinfo = Console.ReadKey();
        //        if(keyinfo.KeyChar == '.') a.clearLED();
        //        Console.Write(keyinfo.KeyChar);
        //        a.shinKeyWithChar(keyinfo.KeyChar, rnd.Next(0, 101), rnd.Next(0, 101), rnd.Next(0, 101)); -> api
        //    }
        //    while (keyinfo.Key != ConsoleKey.Escape);
        //    a.endLED();                                   -> end the keyboard light
        //}
        public void initLED()
        {
            LogitechGSDK.LogiLedInit();
        }
        public void endLED()
        {
            LogitechGSDK.LogiLedShutdown();
        }
        public void shinAllKey(int r, int g, int b)
        {
            LogitechGSDK.LogiLedSetLighting(r, g, b);
        }
        public void shinKeyWithChar(int c, int r, int g, int b)
        {
            char v;
            if (c >= 'a' && c <= 'z') v = Char.ToUpper((char)c);
            else v = (char)c;
            if (v == 'A')
                LogitechGSDK.LogiLedSetLightingForKeyWithKeyName(keyboardNames.A, r, g, b);
            else if ( v == 'B')
                LogitechGSDK.LogiLedSetLightingForKeyWithKeyName(keyboardNames.B, r, g, b);
            else if ( v == 'C')
                LogitechGSDK.LogiLedSetLightingForKeyWithKeyName(keyboardNames.C, r, g, b);
            else if ( v == 'D')
                LogitechGSDK.LogiLedSetLightingForKeyWithKeyName(keyboardNames.D, r, g, b);
            else if ( v == 'E')
                LogitechGSDK.LogiLedSetLightingForKeyWithKeyName(keyboardNames.E, r, g, b);
            else if ( v == 'F')
                LogitechGSDK.LogiLedSetLightingForKeyWithKeyName(keyboardNames.F, r, g, b);
            else if ( v == 'G')
                LogitechGSDK.LogiLedSetLightingForKeyWithKeyName(keyboardNames.G, r, g, b);
            else if ( v == 'H')
                LogitechGSDK.LogiLedSetLightingForKeyWithKeyName(keyboardNames.H, r, g, b);
            else if ( v == 'I')
                LogitechGSDK.LogiLedSetLightingForKeyWithKeyName(keyboardNames.I, r, g, b);
            else if ( v == 'J')
                LogitechGSDK.LogiLedSetLightingForKeyWithKeyName(keyboardNames.J, r, g, b);
            else if ( v == 'K')
                LogitechGSDK.LogiLedSetLightingForKeyWithKeyName(keyboardNames.K, r, g, b);
            else if ( v == 'L')
                LogitechGSDK.LogiLedSetLightingForKeyWithKeyName(keyboardNames.L, r, g, b);
            else if ( v == 'M')
                LogitechGSDK.LogiLedSetLightingForKeyWithKeyName(keyboardNames.M, r, g, b);
            else if ( v == 'N')
                LogitechGSDK.LogiLedSetLightingForKeyWithKeyName(keyboardNames.N, r, g, b);
            else if ( v == 'O')
                LogitechGSDK.LogiLedSetLightingForKeyWithKeyName(keyboardNames.O, r, g, b);
            else if ( v == 'P')
                LogitechGSDK.LogiLedSetLightingForKeyWithKeyName(keyboardNames.P, r, g, b);
            else if ( v == 'Q')
                LogitechGSDK.LogiLedSetLightingForKeyWithKeyName(keyboardNames.Q, r, g, b);
            else if ( v == 'R')
                LogitechGSDK.LogiLedSetLightingForKeyWithKeyName(keyboardNames.R, r, g, b);
            else if ( v == 'S')
                LogitechGSDK.LogiLedSetLightingForKeyWithKeyName(keyboardNames.S, r, g, b);
            else if ( v == 'T')
                LogitechGSDK.LogiLedSetLightingForKeyWithKeyName(keyboardNames.T, r, g, b);
            else if ( v == 'U')
                LogitechGSDK.LogiLedSetLightingForKeyWithKeyName(keyboardNames.U, r, g, b);
            else if ( v == 'V')
                LogitechGSDK.LogiLedSetLightingForKeyWithKeyName(keyboardNames.V, r, g, b);
            else if ( v == 'W')
                LogitechGSDK.LogiLedSetLightingForKeyWithKeyName(keyboardNames.W, r, g, b);
            else if ( v == 'X')
                LogitechGSDK.LogiLedSetLightingForKeyWithKeyName(keyboardNames.X, r, g, b);
            else if ( v == 'Y')
                LogitechGSDK.LogiLedSetLightingForKeyWithKeyName(keyboardNames.Y, r, g, b);
            else if ( v == 'Z')
                LogitechGSDK.LogiLedSetLightingForKeyWithKeyName(keyboardNames.Z, r, g, b);
            else if ( v == ',')
                LogitechGSDK.LogiLedSetLightingForKeyWithKeyName(keyboardNames.COMMA, r, g, b);
            else if ( v == '.')
                LogitechGSDK.LogiLedSetLightingForKeyWithKeyName(keyboardNames.PERIOD, r, g, b);
            else if ( v == '/')
                LogitechGSDK.LogiLedSetLightingForKeyWithKeyName(keyboardNames.FORWARD_SLASH, r, g, b);
            else if ( v == ';')
                LogitechGSDK.LogiLedSetLightingForKeyWithKeyName(keyboardNames.SEMICOLON, r, g, b);
            else if ( v == '1')
                LogitechGSDK.LogiLedSetLightingForKeyWithKeyName(keyboardNames.ONE, r, g, b);
            else if ( v == '2')
                LogitechGSDK.LogiLedSetLightingForKeyWithKeyName(keyboardNames.TWO, r, g, b);
            else if ( v == '3')
                LogitechGSDK.LogiLedSetLightingForKeyWithKeyName(keyboardNames.THREE, r, g, b);
            else if ( v == '4')
                LogitechGSDK.LogiLedSetLightingForKeyWithKeyName(keyboardNames.FOUR, r, g, b);
            else if ( v == '5')
                LogitechGSDK.LogiLedSetLightingForKeyWithKeyName(keyboardNames.FIVE, r, g, b);
            else if ( v == '6')
                LogitechGSDK.LogiLedSetLightingForKeyWithKeyName(keyboardNames.SIX, r, g, b);
            else if ( v == '7')
                LogitechGSDK.LogiLedSetLightingForKeyWithKeyName(keyboardNames.SEVEN, r, g, b);
            else if ( v == '8')
                LogitechGSDK.LogiLedSetLightingForKeyWithKeyName(keyboardNames.EIGHT, r, g, b);
            else if ( v == '9')
                LogitechGSDK.LogiLedSetLightingForKeyWithKeyName(keyboardNames.NINE, r, g, b);
            else if ( v == '0')
                LogitechGSDK.LogiLedSetLightingForKeyWithKeyName(keyboardNames.ZERO, r, g, b);
            else if (v == '\\')
                LogitechGSDK.LogiLedSetLightingForKeyWithKeyName(keyboardNames.BACKSLASH, r, g, b);
            else if (v == '-')
                LogitechGSDK.LogiLedSetLightingForKeyWithKeyName(keyboardNames.MINUS, r, g, b);
            else if (v == '=')
                LogitechGSDK.LogiLedSetLightingForKeyWithKeyName(keyboardNames.EQUALS, r, g, b);
            else if (v == '[')
                LogitechGSDK.LogiLedSetLightingForKeyWithKeyName(keyboardNames.OPEN_BRACKET, r, g, b);
            else if (v == ']')
                LogitechGSDK.LogiLedSetLightingForKeyWithKeyName(keyboardNames.CLOSE_BRACKET, r, g, b);
            else if (v == '\'')
                LogitechGSDK.LogiLedSetLightingForKeyWithKeyName(keyboardNames.APOSTROPHE, r, g, b);
            else if (v == ' ')
                LogitechGSDK.LogiLedSetLightingForKeyWithKeyName(keyboardNames.SPACE, r, g, b);
            else if (v == '\t')
                LogitechGSDK.LogiLedSetLightingForKeyWithKeyName(keyboardNames.TAB, r, g, b);
            else if (v == '*')
                LogitechGSDK.LogiLedSetLightingForKeyWithKeyName(keyboardNames.NUM_ASTERISK, r, g, b);
            else if (v == '+')
                LogitechGSDK.LogiLedSetLightingForKeyWithKeyName(keyboardNames.NUM_PLUS, r, g, b);
        }
        public void clearLED()
        {
            LogitechGSDK.LogiLedSetLighting(0, 0, 0);
        }
        public void fireDown(int r, int g, int b)
        {
            LogitechGSDK.LogiLedSetLightingForKeyWithKeyName(keyboardNames.SEVEN, r, g, b);
            Thread.Sleep(500);
            LogitechGSDK.LogiLedSetLightingForKeyWithKeyName(keyboardNames.SIX, r, g, b);
            LogitechGSDK.LogiLedSetLightingForKeyWithKeyName(keyboardNames.EIGHT, r, g, b);
            LogitechGSDK.LogiLedSetLightingForKeyWithKeyName(keyboardNames.Y, r, g, b);
            LogitechGSDK.LogiLedSetLightingForKeyWithKeyName(keyboardNames.U, r, g, b);
            Thread.Sleep(500);
            LogitechGSDK.LogiLedSetLightingForKeyWithKeyName(keyboardNames.FIVE, r, g, b);
            LogitechGSDK.LogiLedSetLightingForKeyWithKeyName(keyboardNames.T, r, g, b);
            LogitechGSDK.LogiLedSetLightingForKeyWithKeyName(keyboardNames.G, r, g, b);
            LogitechGSDK.LogiLedSetLightingForKeyWithKeyName(keyboardNames.H, r, g, b);
            LogitechGSDK.LogiLedSetLightingForKeyWithKeyName(keyboardNames.J, r, g, b);
            LogitechGSDK.LogiLedSetLightingForKeyWithKeyName(keyboardNames.I, r, g, b);
            LogitechGSDK.LogiLedSetLightingForKeyWithKeyName(keyboardNames.NINE, r, g, b);
            Thread.Sleep(500);
            clearLED();
            LogitechGSDK.LogiLedSetLightingForKeyWithKeyName(keyboardNames.SIX, r, g, b);
            LogitechGSDK.LogiLedSetLightingForKeyWithKeyName(keyboardNames.SEVEN, r, g, b);
            LogitechGSDK.LogiLedSetLightingForKeyWithKeyName(keyboardNames.EIGHT, r, g, b);
            LogitechGSDK.LogiLedSetLightingForKeyWithKeyName(keyboardNames.T, r, g, b);
            LogitechGSDK.LogiLedSetLightingForKeyWithKeyName(keyboardNames.Y, r, g, b);
            LogitechGSDK.LogiLedSetLightingForKeyWithKeyName(keyboardNames.U, r, g, b);
            LogitechGSDK.LogiLedSetLightingForKeyWithKeyName(keyboardNames.I, r, g, b);
            LogitechGSDK.LogiLedSetLightingForKeyWithKeyName(keyboardNames.G, r, g, b);
            LogitechGSDK.LogiLedSetLightingForKeyWithKeyName(keyboardNames.H, r, g, b);
            LogitechGSDK.LogiLedSetLightingForKeyWithKeyName(keyboardNames.J, r, g, b);
            LogitechGSDK.LogiLedSetLightingForKeyWithKeyName(keyboardNames.K, r, g, b);
            LogitechGSDK.LogiLedSetLightingForKeyWithKeyName(keyboardNames.B, r, g, b);
            LogitechGSDK.LogiLedSetLightingForKeyWithKeyName(keyboardNames.N, r, g, b);
            LogitechGSDK.LogiLedSetLightingForKeyWithKeyName(keyboardNames.M, r, g, b);
            Thread.Sleep(500);
            clearLED();
            LogitechGSDK.LogiLedSetLightingForKeyWithKeyName(keyboardNames.Y, r, g, b);
            LogitechGSDK.LogiLedSetLightingForKeyWithKeyName(keyboardNames.U, r, g, b);
            LogitechGSDK.LogiLedSetLightingForKeyWithKeyName(keyboardNames.G, r, g, b);
            LogitechGSDK.LogiLedSetLightingForKeyWithKeyName(keyboardNames.H, r, g, b);
            LogitechGSDK.LogiLedSetLightingForKeyWithKeyName(keyboardNames.J, r, g, b);
            LogitechGSDK.LogiLedSetLightingForKeyWithKeyName(keyboardNames.K, r, g, b);
            LogitechGSDK.LogiLedSetLightingForKeyWithKeyName(keyboardNames.B, r, g, b);
            LogitechGSDK.LogiLedSetLightingForKeyWithKeyName(keyboardNames.N, r, g, b);
            LogitechGSDK.LogiLedSetLightingForKeyWithKeyName(keyboardNames.M, r, g, b);
            Thread.Sleep(500);
            clearLED();
            LogitechGSDK.LogiLedSetLightingForKeyWithKeyName(keyboardNames.H, r, g, b);
            LogitechGSDK.LogiLedSetLightingForKeyWithKeyName(keyboardNames.J, r, g, b);
            LogitechGSDK.LogiLedSetLightingForKeyWithKeyName(keyboardNames.B, r, g, b);
            LogitechGSDK.LogiLedSetLightingForKeyWithKeyName(keyboardNames.N, r, g, b);
            LogitechGSDK.LogiLedSetLightingForKeyWithKeyName(keyboardNames.M, r, g, b);
            Thread.Sleep(500);
            clearLED();
            LogitechGSDK.LogiLedSetLightingForKeyWithKeyName(keyboardNames.H, r, g, b);
            LogitechGSDK.LogiLedSetLightingForKeyWithKeyName(keyboardNames.J, r, g, b);
            LogitechGSDK.LogiLedSetLightingForKeyWithKeyName(keyboardNames.B, r, g, b);
            LogitechGSDK.LogiLedSetLightingForKeyWithKeyName(keyboardNames.N, r, g, b);
            LogitechGSDK.LogiLedSetLightingForKeyWithKeyName(keyboardNames.M, r, g, b);
            Thread.Sleep(500);
            clearLED();
            LogitechGSDK.LogiLedSetLightingForKeyWithKeyName(keyboardNames.N, r, g, b);
            LogitechGSDK.LogiLedSetLightingForKeyWithKeyName(keyboardNames.M, r, g, b);
            Thread.Sleep(500);
            clearLED();
            clearLED();
        }
        public void shinKeyWithString(string str, int r, int g, int b)
        {
            if (str == "go")
            {
                // G
                LogitechGSDK.LogiLedSetLightingForKeyWithKeyName(keyboardNames.FIVE, r, g, b);
                LogitechGSDK.LogiLedSetLightingForKeyWithKeyName(keyboardNames.FOUR, r, g, b);
                LogitechGSDK.LogiLedSetLightingForKeyWithKeyName(keyboardNames.THREE, r, g, b);
                LogitechGSDK.LogiLedSetLightingForKeyWithKeyName(keyboardNames.W, r, g, b);
                LogitechGSDK.LogiLedSetLightingForKeyWithKeyName(keyboardNames.S, r, g, b);
                LogitechGSDK.LogiLedSetLightingForKeyWithKeyName(keyboardNames.X, r, g, b);
                LogitechGSDK.LogiLedSetLightingForKeyWithKeyName(keyboardNames.C, r, g, b);
                LogitechGSDK.LogiLedSetLightingForKeyWithKeyName(keyboardNames.F, r, g, b);
                LogitechGSDK.LogiLedSetLightingForKeyWithKeyName(keyboardNames.V, r, g, b);
                LogitechGSDK.LogiLedSetLightingForKeyWithKeyName(keyboardNames.G, r, g, b);
                // o
                LogitechGSDK.LogiLedSetLightingForKeyWithKeyName(keyboardNames.I, r, g, b);
                LogitechGSDK.LogiLedSetLightingForKeyWithKeyName(keyboardNames.O, r, g, b);
                LogitechGSDK.LogiLedSetLightingForKeyWithKeyName(keyboardNames.L, r, g, b);
                LogitechGSDK.LogiLedSetLightingForKeyWithKeyName(keyboardNames.COMMA, r, g, b);
                LogitechGSDK.LogiLedSetLightingForKeyWithKeyName(keyboardNames.M, r, g, b);
                LogitechGSDK.LogiLedSetLightingForKeyWithKeyName(keyboardNames.J, r, g, b);
            }
            else if (str == "one")
            {
                // 1
                LogitechGSDK.LogiLedSetLightingForKeyWithKeyName(keyboardNames.I, r, g, b);
                LogitechGSDK.LogiLedSetLightingForKeyWithKeyName(keyboardNames.ZERO, r, g, b);
                LogitechGSDK.LogiLedSetLightingForKeyWithKeyName(keyboardNames.O, r, g, b);
                LogitechGSDK.LogiLedSetLightingForKeyWithKeyName(keyboardNames.L, r, g, b);
                LogitechGSDK.LogiLedSetLightingForKeyWithKeyName(keyboardNames.COMMA, r, g, b);
                LogitechGSDK.LogiLedSetLightingForKeyWithKeyName(keyboardNames.PERIOD, r, g, b);
                LogitechGSDK.LogiLedSetLightingForKeyWithKeyName(keyboardNames.NUM_ONE, r, g, b);
            }
            else if (str == "two")
            {
                // 2
                LogitechGSDK.LogiLedSetLightingForKeyWithKeyName(keyboardNames.I, r, g, b);
                LogitechGSDK.LogiLedSetLightingForKeyWithKeyName(keyboardNames.NINE, r, g, b);
                LogitechGSDK.LogiLedSetLightingForKeyWithKeyName(keyboardNames.ZERO, r, g, b);
                LogitechGSDK.LogiLedSetLightingForKeyWithKeyName(keyboardNames.P, r, g, b);
                LogitechGSDK.LogiLedSetLightingForKeyWithKeyName(keyboardNames.L, r, g, b);
                //LogitechGSDK.LogiLedSetLightingForKeyWithKeyName(keyboardNames.M, r, g, b);
                LogitechGSDK.LogiLedSetLightingForKeyWithKeyName(keyboardNames.COMMA, r, g, b);
                LogitechGSDK.LogiLedSetLightingForKeyWithKeyName(keyboardNames.PERIOD, r, g, b);
                LogitechGSDK.LogiLedSetLightingForKeyWithKeyName(keyboardNames.FORWARD_SLASH, r, g, b);
                LogitechGSDK.LogiLedSetLightingForKeyWithKeyName(keyboardNames.NUM_TWO, r, g, b);
            }
            else if (str == "three")
            {
                // 3
                LogitechGSDK.LogiLedSetLightingForKeyWithKeyName(keyboardNames.O, r, g, b);
                LogitechGSDK.LogiLedSetLightingForKeyWithKeyName(keyboardNames.ZERO, r, g, b);
                LogitechGSDK.LogiLedSetLightingForKeyWithKeyName(keyboardNames.MINUS, r, g, b);
                LogitechGSDK.LogiLedSetLightingForKeyWithKeyName(keyboardNames.OPEN_BRACKET, r, g, b);
                LogitechGSDK.LogiLedSetLightingForKeyWithKeyName(keyboardNames.SEMICOLON, r, g, b);
                LogitechGSDK.LogiLedSetLightingForKeyWithKeyName(keyboardNames.FORWARD_SLASH, r, g, b);
                LogitechGSDK.LogiLedSetLightingForKeyWithKeyName(keyboardNames.RIGHT_WINDOWS, r, g, b);
                LogitechGSDK.LogiLedSetLightingForKeyWithKeyName(keyboardNames.RIGHT_ALT, r, g, b);
                LogitechGSDK.LogiLedSetLightingForKeyWithKeyName(keyboardNames.COMMA, r, g, b);
                LogitechGSDK.LogiLedSetLightingForKeyWithKeyName(keyboardNames.NUM_THREE, r, g, b);
            }
            else if (str == "four")
            {
                // 4
                LogitechGSDK.LogiLedSetLightingForKeyWithKeyName(keyboardNames.NINE, r, g, b);
                LogitechGSDK.LogiLedSetLightingForKeyWithKeyName(keyboardNames.I, r, g, b);
                LogitechGSDK.LogiLedSetLightingForKeyWithKeyName(keyboardNames.J, r, g, b);
                LogitechGSDK.LogiLedSetLightingForKeyWithKeyName(keyboardNames.K, r, g, b);
                LogitechGSDK.LogiLedSetLightingForKeyWithKeyName(keyboardNames.L, r, g, b);
                LogitechGSDK.LogiLedSetLightingForKeyWithKeyName(keyboardNames.SEMICOLON, r, g, b);
                LogitechGSDK.LogiLedSetLightingForKeyWithKeyName(keyboardNames.O, r, g, b);
                LogitechGSDK.LogiLedSetLightingForKeyWithKeyName(keyboardNames.PERIOD, r, g, b);
                LogitechGSDK.LogiLedSetLightingForKeyWithKeyName(keyboardNames.RIGHT_ALT, r, g, b);
                LogitechGSDK.LogiLedSetLightingForKeyWithKeyName(keyboardNames.NUM_FOUR, r, g, b);
            }
        }
    }
}
