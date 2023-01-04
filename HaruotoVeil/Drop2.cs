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
    public class Drop2 : StoryboardObjectGenerator
    {
        public override void Generate()
        {
		    var backgroundLayer = GetLayer("DropBackground");
            var effectLayer = GetLayer("DropEffect");
            
            string bg01Path = "sb/drop2/01.png";
            var bg01Bitmap = GetMapsetBitmap(bg01Path);
            var bg01 = backgroundLayer.CreateSprite(bg01Path, OsbOrigin.Centre);
            int bg01Start = 132186;
            int bg01End = 137353;
            int bg01Time1 = 133520;
            int bg01Time2 = 135520;
            double bg01Height = 480.0f / bg01Bitmap.Height;
            bg01.Scale(OsbEasing.OutQuart, bg01Start, bg01Time1, bg01Height * 6, bg01Height * 2);
            bg01.Rotate(OsbEasing.OutQuart, bg01Start, bg01Time1, -0.3, 0.3);
            bg01.Move(OsbEasing.OutQuart, bg01Start, bg01Time1, 320, 240, 320-200, 240-200);

            bg01.Scale(OsbEasing.OutQuart, bg01Time1, bg01Time2, bg01Height * 2, bg01Height * 1.3);
            bg01.Rotate(OsbEasing.OutQuart, bg01Time1, bg01Time2, 0.3, 0);
            bg01.Move(OsbEasing.OutQuart, bg01Time1, bg01Time2, 320-200, 240-200, 320, 240);

            bg01.Rotate(OsbEasing.OutQuart, bg01Time2, bg01End, -0.3, 0);
            bg01.Scale(OsbEasing.OutQuart, bg01Time2, bg01End, bg01Height*2, bg01Height*1.1);
            bg01.Move(OsbEasing.OutQuart, bg01Time2, bg01End, 320-200, 240-100, 320, 240);
            bg01.Fade(bg01Start, 1);
            bg01.Fade(bg01End, bg01End + 1000, 1, 0);


            string bg02Path = "sb/drop2/02.png";
            var bg02Bitmap = GetMapsetBitmap(bg02Path);
            var bg02 = backgroundLayer.CreateSprite(bg02Path, OsbOrigin.Centre);
            int bg02Start = 137353;
            int bg02End = 142353;
            int bg02Time1 = 139020;
            int bg02Time2 = 140520;
            double bg02Height = 480.0f / bg02Bitmap.Height;
            bg02.Scale(OsbEasing.OutQuart, bg02Start, bg02Time1, bg02Height * 6, bg02Height * 2);
            bg02.Rotate(OsbEasing.OutQuart, bg02Start, bg02Time1, 0, 0.3);
            bg02.Move(OsbEasing.OutQuart, bg02Start, bg02Time1, 320-500, 240+1000, 320+200, 240-50);

            bg02.Scale(OsbEasing.OutQuart, bg02Time1, bg02Time2, bg02Height * 2, bg02Height * 1.3);
            bg02.Rotate(OsbEasing.OutQuart, bg02Time1, bg02Time2, 0.3, 0);
            bg02.Move(OsbEasing.OutQuart, bg02Time1, bg02Time2, 320+200, 240-50, 320, 240);

            bg02.Rotate(OsbEasing.OutQuart, bg02Time2, bg02End, -0.3, 0);
            bg02.Scale(OsbEasing.OutQuart, bg02Time2, bg02End, bg02Height*2, bg02Height*1.1);
            bg02.Move(OsbEasing.OutQuart, bg02Time2, bg02End, 320-200, 240-100, 320, 240);
            bg02.Fade(bg02Start, 1);
            bg02.Fade(bg02End, bg02End + 1000, 1, 0);

            string bg03Path = "sb/drop2/03.png";
            var bg03Bitmap = GetMapsetBitmap(bg03Path);
            var bg03 = backgroundLayer.CreateSprite(bg03Path, OsbOrigin.Centre);
            int bg03Start = 142353;
            int bg03End = 146186;
            int bg03Time1 = 143186;
            int bg03Time2 = 144020;
            double bg03Height = 480.0f / bg03Bitmap.Height;
            bg03.Scale(OsbEasing.OutQuart, bg03Start, bg03Time1, bg03Height * 6, bg03Height * 2);
            bg03.Rotate(OsbEasing.OutQuart, bg03Start, bg03Time1, -0.6, -0.3);
            bg03.Move(OsbEasing.OutQuart, bg03Start, bg03Time1, 320, 240, 320+300, 240-200);

            bg03.Scale(OsbEasing.OutQuart, bg03Time1, bg03Time2, bg03Height * 2, bg03Height * 2);
            bg03.Rotate(OsbEasing.OutQuart, bg03Time1, bg03Time2, -0.3, -0.3);
            bg03.Move(OsbEasing.OutQuart, bg03Time1, bg03Time2, 320+300, 240-200, 320-220, 240+200);

            bg03.Rotate(OsbEasing.OutQuart, bg03Time2, bg03End, -0.3, 0);
            bg03.Scale(OsbEasing.OutQuart, bg03Time2, bg03End, bg03Height*2.5, bg03Height*1.1);
            bg03.Move(OsbEasing.OutQuart, bg03Time2, bg03End, 320-220, 240+200, 320, 240);
            bg03.Fade(bg03Start, 1);
            bg03.Fade(bg03End, bg03End + 1000, 1, 0);

            string bg04Path = "sb/drop2/04.png";
            var bg04Bitmap = GetMapsetBitmap(bg04Path);
            var bg04 = backgroundLayer.CreateSprite(bg04Path, OsbOrigin.Centre);
            int bg04Start = 146186;
            int bg04End = 146520;
            double bg04Height = 480.0f / bg04Bitmap.Height;
            bg04.Scale(OsbEasing.OutQuart, bg04Start, bg04End, bg04Height * 1.2, bg04Height * 1.1);
            bg04.Rotate(OsbEasing.OutQuart, bg04Start, bg04End, -0.1, 0);
            bg04.Move(OsbEasing.OutQuart, bg04Start, bg04End, 320, 240, 320, 240);
            bg04.Fade(bg04Start, 1);
            bg04.Fade(bg04End, bg04End + 1000, 1, 0);


            string bg05Path = "sb/drop2/05.png";
            var bg05Bitmap = GetMapsetBitmap(bg05Path);
            var bg05 = backgroundLayer.CreateSprite(bg05Path, OsbOrigin.Centre);
            int bg05Start = 146520;
            int bg05End = 146853;
            double bg05Height = 480.0f / bg05Bitmap.Height;
            bg05.Scale(OsbEasing.OutQuart, bg05Start, bg05End, bg05Height * 1.2, bg05Height * 1.1);
            bg05.Rotate(OsbEasing.OutQuart, bg05Start, bg05End, 0.1, 0);
            bg05.Move(OsbEasing.OutQuart, bg05Start, bg05End, 320, 240, 320, 240);
            bg05.Fade(bg05Start, 1);
            bg05.Fade(bg05End, bg05End + 1000, 1, 0);

            string bg06Path = "sb/drop2/03.png";
            var bg06Bitmap = GetMapsetBitmap(bg06Path);
            var bg06 = backgroundLayer.CreateSprite(bg06Path, OsbOrigin.Centre);
            int bg06Start = 146853;
            int bg06End = 147853;
            double bg06Height = 480.0f / bg06Bitmap.Height;
            bg06.Scale(OsbEasing.OutQuart, bg06Start, bg06End, bg06Height * 1.2, bg06Height * 1.1);
            bg06.Rotate(OsbEasing.OutQuart, bg06Start, bg06End, -0.1, 0);
            bg06.Move(OsbEasing.OutQuart, bg06Start, bg06End, 320, 240, 320, 240);
            bg06.Fade(bg06Start, 1);
            bg06.Fade(bg06End, bg06End + 1000, 1, 0);


            string bg07Path = "sb/drop2/07.png";
            var bg07Bitmap = GetMapsetBitmap(bg07Path);
            var bg07 = backgroundLayer.CreateSprite(bg07Path, OsbOrigin.Centre);
            int bg07Start = 147853;
            int bg07Time1 = 149020;
            int bg07End = 150686;
            double bg07Height = 480.0f / bg07Bitmap.Height;
            bg07.Scale(OsbEasing.OutQuart, bg07Start, bg07Start+500, bg07Height * 2, bg07Height * 2);
            bg07.Rotate(OsbEasing.OutQuart, bg07Start, bg07Time1, 0, 0);
            bg07.Move(OsbEasing.OutQuart, bg07Start, bg07Time1, 320-200, 240+150, 320+200, 240+150);
            bg07.Rotate(OsbEasing.OutQuart, bg07Time1, bg07End, 0.3, 0);
            bg07.Move(bg07Time1, 320, 240);
            bg07.Scale(OsbEasing.OutQuart, bg07Time1, bg07End, bg07Height * 3, bg07Height * 1.1);
            bg07.Fade(bg07Start, 1);
            bg07.Fade(bg07End, bg07End + 1000, 1, 0);

            string bg08Path = "sb/drop2/08.png";
            var bg08Bitmap = GetMapsetBitmap(bg08Path);
            var bg08 = backgroundLayer.CreateSprite(bg08Path, OsbOrigin.Centre);
            int bg08Start = 150686;
            int bg08Time1 = 152186;
            int bg08End = 153353;
            double bg08Height = 480.0f / bg08Bitmap.Height;
            bg08.Scale(OsbEasing.OutQuart, bg08Start, bg08Start+500, bg08Height * 2, bg08Height * 2);
            bg08.Rotate(OsbEasing.OutQuart, bg08Start, bg08Time1, 0, 0);
            bg08.Move(OsbEasing.OutQuart, bg08Start, bg08Time1, 320-100, 240+150, 320+300, 240+150);
            bg08.Rotate(OsbEasing.OutQuart, bg08Time1, bg08End, -0.3, 0);
            bg08.Move(bg08Time1, 320, 240);
            bg08.Scale(OsbEasing.OutQuart, bg08Time1, bg08End, bg08Height * 3, bg08Height * 1.1);
            bg08.Fade(bg08Start, 1);
            bg08.Fade(bg08End, bg08End + 1000, 1, 0);

            string bg09Path = "sb/drop2/09.png";
            var bg09Bitmap = GetMapsetBitmap(bg09Path);
            var bg09 = backgroundLayer.CreateSprite(bg09Path, OsbOrigin.Centre);
            int bg09Start = 153353;
            int bg09End = 157686;
            int bg09Time1 = 154686;
            int bg09Time2 = 155353;
            int bg09Time3 = 156020;
            double bg09Height = 480.0f / bg09Bitmap.Height;
            double bg09Width = 640.0f / bg09Bitmap.Width;
            double bg09X = 320 / bg09Bitmap.Width;
            double bg09Y = 240 / bg09Bitmap.Height;
            bg09.Fade(bg09Start, 1);
            bg09.Fade(bg09End, bg09End + 1000, 1, 0);

            bg09.Scale(OsbEasing.OutQuart, bg09Start, bg09Time1, bg09Height * 6, bg09Height * 2);
            bg09.Rotate(OsbEasing.OutQuart, bg09Start, bg09Time1, 0, 0);
            bg09.Move(OsbEasing.OutQuart, bg09Start, bg09Time1,(320+200)*2, (240+200)*2, 320+200, 240+200);

            bg09.Scale(OsbEasing.OutQuart, bg09Time1, bg09Time2, bg09Height * 2.5, bg09Height * 2);
            bg09.Rotate(OsbEasing.OutQuart, bg09Time1, bg09Time2, 0, 0);
            bg09.Move(OsbEasing.OutQuart, bg09Time1, bg09Time2,(320-400)*2, (240)*2, 320-400, 240+200);

            bg09.Scale(OsbEasing.OutQuart, bg09Time2, bg09Time3, bg09Height * 2.5, bg09Height * 2);
            bg09.Rotate(OsbEasing.OutQuart, bg09Time2, bg09Time3, 0, 0);
            bg09.Move(OsbEasing.OutQuart, bg09Time2, bg09Time3,(320), (240-250), 320, 240-200);

            bg09.Scale(OsbEasing.OutQuart, bg09Time3, bg09End, bg09Height * 2.5, bg09Height * 1.5);
            bg09.Rotate(OsbEasing.OutQuart, bg09Time3, bg09End, 0, 0);
            bg09.Move(OsbEasing.OutQuart, bg09Time3, bg09End,(320+200), (240+200), 320+100, 240+100);

            string bg10Path = "sb/drop2/10.png";
            var bg10Bitmap = GetMapsetBitmap(bg10Path);
            var bg10 = backgroundLayer.CreateSprite(bg10Path, OsbOrigin.Centre);
            int bg10Start = 157686;
            int bg10End = 161686;
            double bg10Height = 480.0f / bg10Bitmap.Height;
            bg10.Scale(OsbEasing.OutQuart, bg10Start, bg10End, bg10Height * 4, bg10Height * 1.1);
            bg10.Rotate(OsbEasing.OutExpo, bg10Start, bg10End, 0, 0);
            bg10.Move(OsbEasing.OutExpo, bg10Start, bg10End, 320+400, 240+400, 320, 240);
            bg10.Fade(bg10Start, 1);
            bg10.Fade(bg10End, bg10End + 1000, 1, 0);
            


            string lightPath = "sb/effect/light.png";
            var lightBitmap = GetMapsetBitmap(lightPath);
            var light = effectLayer.CreateSprite(lightPath, OsbOrigin.Centre);
            light.Fade(bg01Start -200, bg01Start , 0, 1);
            light.Fade(bg01Start, bg01Start + 200, 1, 0);
            light.Fade(bg01Time2 -200, bg01Time2 , 0, 1);
            light.Fade(bg01Time2, bg01Time2 + 200, 1, 0);

            light.Fade(bg02Start -200, bg02Start , 0, 1);
            light.Fade(bg02Start, bg02Start + 200, 1, 0);
            light.Fade(bg02Time2 -200, bg02Time2 , 0, 1);
            light.Fade(bg02Time2, bg02Time2 + 200, 1, 0);

            light.Fade(bg03Start -200, bg03Start , 0, 1);
            light.Fade(bg03Start, bg03Start + 200, 1, 0);
            light.Fade(bg03Time2 -200, bg03Time2 , 0, 1);
            light.Fade(bg03Time2, bg03Time2 + 200, 1, 0);

            
            light.Fade(bg04Start -100, bg04Start , 0, 1);
            light.Fade(bg04Start, bg04Start + 100, 1, 0);
            light.Fade(bg05Start -100, bg05Start , 0, 1);
            light.Fade(bg05Start, bg05Start + 100, 1, 0);
            light.Fade(bg06Start -100, bg06Start , 0, 1);
            light.Fade(bg06Start, bg06Start + 100, 1, 0);

            light.Fade(bg07Time1 -200, bg07Time1 , 0, 1);
            light.Fade(bg07Time1, bg07Time1 + 200, 1, 0);
            light.Fade(bg08Time1 -200, bg08Time1 , 0, 1);
            light.Fade(bg08Time1, bg08Time1 + 200, 1, 0);

            light.Fade(bg09Start -200, bg09Start , 0, 1);
            light.Fade(bg09Start, bg09Start + 200, 1, 0);
            light.Fade(bg09Time1 -100, bg09Time1 , 0, 1);
            light.Fade(bg09Time1, bg09Time1 + 100, 1, 0);
            light.Fade(bg09Time2 -100, bg09Time2 , 0, 1);
            light.Fade(bg09Time2, bg09Time2 + 100, 1, 0);
            light.Fade(bg09Time3 -100, bg09Time3 , 0, 1);
            light.Fade(bg09Time3, bg09Time3 + 100, 1, 0);
            light.Fade(bg10Start -200, bg10Start , 0, 1);
            light.Fade(bg10Start, bg10Start + 200, 1, 0);
        }
    }
}
