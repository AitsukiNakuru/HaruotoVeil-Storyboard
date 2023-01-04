using OpenTK;
using OpenTK.Graphics;
using StorybrewCommon.Mapset;
using StorybrewCommon.Scripting;
using StorybrewCommon.Storyboarding;
using StorybrewCommon.Storyboarding.Util;
using StorybrewCommon.Subtitles;
using StorybrewCommon.Util;
using System;
using System.Collections.Generic;
using System.Linq;

namespace StorybrewScripts
{
    public class Drop : StoryboardObjectGenerator
    {
        public override void Generate()
        {
            var backgroundLayer = GetLayer("DropBackground");
            var effectLayer = GetLayer("DropEffect");

            string bg01Path = "sb/drop1/01.png";
            var bg01Bitmap = GetMapsetBitmap(bg01Path);
            var bg01 = backgroundLayer.CreateSprite(bg01Path, OsbOrigin.Centre);
            int bg01Start = 58853;
            int bg01End = 65520;
            int bg01Time1 = 61586;
            int bg01Time2 = 64020;
            double bg01Height = 480.0f / bg01Bitmap.Height;
            bg01.Scale(OsbEasing.OutQuart, bg01Start, bg01Time1, bg01Height * 6, bg01Height * 2);
            bg01.Rotate(OsbEasing.OutQuart, bg01Start, bg01Time1, 0.785, -0.3);
            bg01.Move(OsbEasing.OutQuart, bg01Start, bg01Time1, 320, 240, 320-250, 240+200);

            bg01.Scale(OsbEasing.OutQuart, bg01Time1, bg01Time2, bg01Height * 2, bg01Height * 1.3);
            bg01.Rotate(OsbEasing.OutQuart, bg01Time1, bg01Time2, -0.3, 0);
            bg01.Move(OsbEasing.OutQuart, bg01Time1, bg01Time2, 320-250, 240+200, 320, 240);
            bg01.Fade(bg01Start, 1);
            bg01.Fade(bg01End, bg01End + 1000, 1, 0);


            string bg02Path = "sb/drop1/02.png";
            var bg02Bitmap = GetMapsetBitmap(bg02Path);
            var bg02 = backgroundLayer.CreateSprite(bg02Path, OsbOrigin.Centre);
            int bg02Start = 64020;
            int bg02End = 69020;
            int bg02Time1 = 65520;
            int bg02Time2 = 67186;
            int bg02Time3 = 67686;
            int bg02Time4 = 68186;
            double bg02Height = 480.0f / bg02Bitmap.Height;
            bg02.Scale(OsbEasing.OutQuart, bg02Start, bg02Time1, bg02Height * 6, bg02Height * 3);
            bg02.Rotate(OsbEasing.OutQuart, bg02Start, bg02Time1, 0, -0.3);
            bg02.Move(OsbEasing.OutQuart, bg02Start, bg02Time1, 320, 240, 320 - 200, 240 + 400);

            bg02.Scale(OsbEasing.OutQuart, bg02Time1, bg02Time2, bg02Height * 3, bg02Height * 1.2);
            bg02.Rotate(OsbEasing.OutQuart, bg02Time1, bg02Time2, -0.3, 0);
            bg02.Move(OsbEasing.OutQuart, bg02Time1, bg02Time2, 320 - 200, 240 + 400, 320, 240);

            bg02.Scale(OsbEasing.OutQuart, bg02Time2, bg02Time3, bg02Height * 1.2, bg02Height * 3);
            bg02.Rotate(OsbEasing.OutQuart, bg02Time2, bg02Time3, 0, 0.3);
            bg02.Move(OsbEasing.OutQuart, bg02Time2, bg02Time3, 320, 240, 320, 240);

            bg02.Rotate(OsbEasing.OutQuart, bg02Time3, bg02Time4, 0.3, -0.3);
            bg02.Move(OsbEasing.OutQuart, bg02Time3, bg02Time4, 320, 240, 320-600, 240-100);

            bg02.Scale(OsbEasing.OutQuart, bg02Time4, bg02End, bg02Height * 3, bg02Height * 1.2);
            bg02.Rotate(OsbEasing.OutQuart, bg02Time4, bg02End, -0.3, 0);
            bg02.Move(OsbEasing.OutQuart, bg02Time4, bg02End, 320-600, 240-100, 320, 240);

            bg02.Fade(bg02Start, 1);
            bg02.Fade(bg02End, bg02End + 1000, 1, 0);


            string bg03Path = "sb/drop1/03.png";
            var bg03Bitmap = GetMapsetBitmap(bg03Path);
            var bg03 = backgroundLayer.CreateSprite(bg03Path, OsbOrigin.Centre);
            int bg03Start = 69020;
            int bg03End = 74520;
            int bg03Time1 = 70853;
            int bg03Time2 = 71686;
            int bg03Time3 = 72853;
            int bg03Time4 = 73186;
            int bg03Time5 = 73520;
            double bg03Height = 480.0f / bg03Bitmap.Height;
            bg03.Scale(OsbEasing.OutQuart, bg03Start, bg03Time1, bg03Height * 6, bg03Height * 2);
            bg03.Rotate(OsbEasing.OutQuart, bg03Start, bg03Time1, -0.785, 0.3);
            bg03.Move(OsbEasing.OutQuart, bg03Start, bg03Time1, 320, 240, 320, 240);

            bg03.Scale(OsbEasing.OutQuart, bg03Time1, bg03Time3, bg03Height * 2, bg03Height * 1.2);
            bg03.Rotate(OsbEasing.OutQuart, bg03Time1, bg03Time3, 0.3, 0);
            bg03.Move(OsbEasing.OutQuart, bg03Time1, bg03Time3, 320, 240 , 320, 240);


            // bg03.Scale(OsbEasing.OutQuart, bg03Time3, bg03Time4, bg03Height * 4, bg03Height * 3.0);
            // bg03.Rotate(OsbEasing.OutQuart, bg03Time3, bg03Time4, 0, -0.3);
            // bg03.Move(bg03Time3,  320, 240);
            bg03.Scale(OsbEasing.OutQuart, bg03Time3, bg03Time4, bg03Height * 2.5, bg03Height * 2);
            bg03.Rotate(OsbEasing.OutQuart, bg03Time3, bg03Time4, 0, 0);
            bg03.Move(OsbEasing.OutQuart, bg03Time3, bg03Time4,(320+300), (240+200), 320+300, 240+200);

            
            // bg03.Rotate(OsbEasing.OutQuart, bg03Time4, bg03Time5, -0.3, 0.3);
            // bg03.Move(OsbEasing.OutQuart, bg03Time4, bg03Time5, 320, 240 , 320-650, 240);
            bg03.Scale(OsbEasing.OutQuart, bg03Time4, bg03Time5, bg03Height * 3.5, bg03Height * 3);
            bg03.Rotate(OsbEasing.OutQuart, bg03Time4, bg03Time5, 0, 0);
            bg03.Move(OsbEasing.OutQuart, bg03Time4, bg03Time5,(320-500), (240+200), 320-500, 240+200);


            bg03.Scale(OsbEasing.OutQuart, bg03Time5, bg03End, bg03Height * 3, bg03Height * 1.2);
            bg03.Rotate(OsbEasing.OutQuart, bg03Time5, bg03End, 0.3, 0);
            bg03.Move(OsbEasing.OutQuart, bg03Time5, bg03End, 320, 240 , 320, 240);
            
            bg03.Fade(bg03Start, 1);
            bg03.Fade(bg03End, bg03End + 1000, 1, 0);


            string bg04Path = "sb/drop1/04.png";
            var bg04Bitmap = GetMapsetBitmap(bg04Path);
            var bg04 = backgroundLayer.CreateSprite(bg04Path, OsbOrigin.Centre);
            int bg04Start = 74520;
            int bg04End = 77353;
            bg04.Scale(OsbEasing.OutQuart,bg04Start, bg04Start+500, 1.2, 1.2);
            bg04.Move(OsbEasing.OutQuart,bg04Start, bg04End, 100, 100 , 600, 350);
            bg04.Fade(bg04Start, bg04Start+100, 0, 1);
            bg04.Fade(bg04End, bg04End + 500, 1, 0);


            
            string bg05Path = "sb/drop1/05.png";
            var bg05Bitmap = GetMapsetBitmap(bg05Path);
            var bg05 = backgroundLayer.CreateSprite(bg05Path, OsbOrigin.Centre);
            int bg05Start = 77353;
            int bg05End = 80020;
            bg05.Scale(OsbEasing.OutQuart,bg05Start, bg05Start+500, 1.2, 1.2);
            bg05.Move(OsbEasing.OutQuart,bg05Start, bg05End, 0, 400 , 600, 350);
            bg05.Fade(bg05Start, bg05Start+100, 0, 1);
            bg05.Fade(bg05End, bg05End + 500, 1, 0);


            string bg06Path = "sb/drop1/06.png";
            var bg06Bitmap = GetMapsetBitmap(bg06Path);
            var bg06 = backgroundLayer.CreateSprite(bg06Path, OsbOrigin.Centre);
            int bg06Start = 80020;
            int bg06End = 81353;
            bg06.Scale(OsbEasing.OutQuart,bg06Start, bg06Start+500, 4, 2);
            bg06.Move(OsbEasing.OutQuart,bg06Start, bg06End, 320, 240 , 320-400, 240-400);
            bg06.Fade(bg06Start, bg06Start+500, 0, 1);
            bg06.Fade(bg06End, bg06End + 500, 1, 0);

            string bg07Path = "sb/drop1/07.png";
            var bg07Bitmap = GetMapsetBitmap(bg07Path);
            var bg07 = backgroundLayer.CreateSprite(bg07Path, OsbOrigin.Centre);
            int bg07Start = 81353;
            int bg07End = 82020;
            bg07.Scale(OsbEasing.OutQuart,bg07Start, bg07Start+500, 2, 2);
            bg07.Move(OsbEasing.OutQuart,bg07Start, bg07End, 320-400, 240-400 , 320-200, 240+100);
            bg07.Fade(bg07Start, bg07Start+200, 0, 1);
            bg07.Fade(bg07End, bg07End + 500, 1, 0);

            string bg08Path = "sb/drop1/08.png";
            var bg08Bitmap = GetMapsetBitmap(bg08Path);
            var bg08 = backgroundLayer.CreateSprite(bg08Path, OsbOrigin.Centre);
            int bg08Start = 82020;
            int bg08End = 82686;
            bg08.Scale(OsbEasing.OutQuart,bg08Start, bg08Start+500, 2, 2);
            bg08.Move(OsbEasing.OutQuart,bg08Start, bg08End, 320-200, 240+100 , 320-400, 240-350);
            bg08.Fade(bg08Start, bg08Start+200, 0, 1);
            bg08.Fade(bg08End, bg08End + 200, 1, 0);

            string bg09Path = "sb/drop1/08.png";
            var bg09Bitmap = GetMapsetBitmap(bg09Path);
            var bg09 = backgroundLayer.CreateSprite(bg09Path, OsbOrigin.Centre);
            int bg09Start = 82686;
            int bg09End = 84186;
            bg09.Scale(OsbEasing.OutQuart,bg09Start, bg09Start+500, 2, 1.2);
            bg09.Move(OsbEasing.OutQuart,bg09Start, bg09End, 320-400, 240-350 , 320, 240+190);
            bg09.Fade(bg09Start, bg09Start+100, 0, 1);
            bg09.Fade(bg09End, bg09End + 500, 1, 0);

            string bg10Path = "sb/drop1/08.png";
            var bg10Bitmap = GetMapsetBitmap(bg10Path);
            var bg10 = backgroundLayer.CreateSprite(bg10Path, OsbOrigin.TopCentre);
            int bg10Start = 84186;
            int bg10End = 90000;
            // bg10.Scale(OsbEasing.InOutCubic,bg10Start, bg10Start+1000, 3, 480.0f/bg10Bitmap.Height*2);
            // bg10.Scale(bg10Start+1000, bg10End, 480.0f/bg10Bitmap.Height*2, 480.0f/bg10Bitmap.Height*1.1);
            //bg10.Move(OsbEasing.OutQuad,bg10Start, bg10End, 320, 0 , 320, 0);

            bg10.Scale(OsbEasing.OutExpo,bg10Start, bg10End, 3, 480.0f/bg10Bitmap.Height*1.1);
            bg10.Move(OsbEasing.OutExpo,bg10Start, bg10End, 320+200, 0 , 320, 0);

            bg10.Fade(bg10Start, bg10Start+500, 0, 1);
            bg10.Fade(bg10End, bg10End + 500, 1, 0);

            
            
            string lightPath = "sb/effect/light.png";
            var lightBitmap = GetMapsetBitmap(lightPath);
            var light = effectLayer.CreateSprite(lightPath, OsbOrigin.Centre);
            light.Fade(bg01Start -200, bg01Start , 0, 1);
            light.Fade(bg01Start, bg01Start + 200, 1, 0);

            light.Fade(bg02Start -200, bg02Start , 0, 1);
            light.Fade(bg02Start, bg02Start + 200, 1, 0);
            light.Fade(bg02Time2 -100, bg02Time2 , 0, 1);
            light.Fade(bg02Time2, bg02Time2 + 100, 1, 0);
            light.Fade(bg02Time3 -100, bg02Time3 , 0, 1);
            light.Fade(bg02Time3, bg02Time3 + 100, 1, 0);
            light.Fade(bg02Time4 -100, bg02Time4 , 0, 1);
            light.Fade(bg02Time4, bg02Time4 + 100, 1, 0);

            light.Fade(bg03Start -200, bg03Start , 0, 1);
            light.Fade(bg03Start, bg03Start + 200, 1, 0);
            light.Fade(bg03Start -200, bg03Start , 0, 1);
            light.Fade(bg03Start, bg03Start + 200, 1, 0);
            light.Fade(bg03Time3 -100, bg03Time3 , 0, 1);
            light.Fade(bg03Time3, bg03Time3 + 100, 1, 0);
            light.Fade(bg03Time4 -100, bg03Time4 , 0, 1);
            light.Fade(bg03Time4, bg03Time4 + 100, 1, 0);
            light.Fade(bg03Time5 -100, bg03Time5 , 0, 1);
            light.Fade(bg03Time5, bg03Time5 + 100, 1, 0);

            light.Fade(bg04Start -200, bg04Start , 0, 1);
            light.Fade(bg04Start, bg04Start + 200, 1, 0);

            light.Fade(bg05Start -200, bg05Start , 0, 1);
            light.Fade(bg05Start, bg05Start + 400, 1, 0);

            light.Fade(bg06Start -200, bg06Start , 0, 1);
            light.Fade(bg06Start, bg06Start + 200, 1, 0);

            // light.Fade(bg07Start -200, bg07Start , 0, 1);
            // light.Fade(bg07Start, bg07Start + 200, 1, 0);

            // light.Fade(bg08Start -200, bg08Start , 0, 1);
            // light.Fade(bg08Start, bg08Start + 200, 1, 0);

            // light.Fade(bg09Start -200, bg09Start , 0, 1);
            // light.Fade(bg09Start, bg09Start + 200, 1, 0);

            // light.Fade(bg10Start -200, bg10Start , 0, 1);
            // light.Fade(bg10Start, bg10Start + 500, 1, 0);
        }
    }
}
