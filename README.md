# KeyboradLED

using0 [Logitech SDK](https://github.com/logihackdays/LGS_LED) provided by Logitech TW.

Doing Unity Depency for Logitech RGB Light

## How to Use it
copy [KeyboardLED/KeyboardLED.cs](KeyboardLED/KeyboardLED.cs), [KeyboardLED/LogitechGSDK.cs](KeyboardLED/LogitechGSDK.cs), and [dll_file/KeyboradLED.dll](dll_file/KeyboradLED.dll) to Unity file

Open the script you want to add this SDK with Vistual Studio.

Project -> Add Reference... -> Browse, find the KeyboradLED.dll you copy to and add it.

Project -> Add Exiting item..., and add KeyboardLED.cs and LogitechGSDK.cs.

copy [dll_file/x86/LogitechLedEnginesWrapper.dll](dll_file/x86/LogitechLedEnginesWrapper.dll) to `C:/Windows/SysWOW64`

copy [dll_file/x64/LogitechLedEnginesWrapper.dll](dll_file/x64/LogitechLedEnginesWrapper.dll) to `C:/Windows/System32`

```CS
using KeyboradLEDLibrary;

KeyboardLED led = new KeyboardLED();
led.initLED();

// used the API here e.g. led.fireDown(100, 0, 0);

led.endLED();
```
