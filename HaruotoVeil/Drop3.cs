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
    public class Drop3 : StoryboardObjectGenerator
    {
        public override void Generate()
        {
		    var backgroundLayer = GetLayer("DropBackground");
            var effectLayer = GetLayer("DropEffect");
            var fgLayer = GetLayer("DropBody");

            string bg01Path = "sb/drop3/01.png";
            var bg01Bitmap = GetMapsetBitmap(bg01Path);
            var bg01 = backgroundLayer.CreateSprite(bg01Path, OsbOrigin.Centre);
            int bg01Start = 220853;
            int bg01End = 223020;
            double bg01Height = 480.0f / bg01Bitmap.Height;
            bg01.Scale(OsbEasing.OutQuart, bg01Start, bg01End, bg01Height * 2, bg01Height * 2);
            bg01.Move(OsbEasing.OutQuart, bg01Start, bg01End, 680, 240+100, 400, 240+100);

            bg01.Fade(bg01Start, 1);
            bg01.Fade(bg01End, bg01End + 1000, 1, 0);


            string bg02Path = "sb/drop3/02.png";
            var bg02Bitmap = GetMapsetBitmap(bg02Path);
            var bg02 = backgroundLayer.CreateSprite(bg02Path, OsbOrigin.Centre);
            int bg02Start = 223020;
            int bg02End = 223520;
            double bg02Height = 480.0f / bg02Bitmap.Height;
            bg02.Scale(OsbEasing.OutQuart, bg02Start, bg02End, bg02Height * 2, bg02Height * 2);
            bg02.Move(OsbEasing.OutQuart, bg02Start, bg02End, 180, 240+100, 400, 240+100);
            bg02.Fade(bg02Start, 1);
            bg02.Fade(bg02End, bg02End + 1000, 1, 0);

            string bg03Path = "sb/drop3/03.png";
            var bg03Bitmap = GetMapsetBitmap(bg03Path);
            var bg03 = backgroundLayer.CreateSprite(bg03Path, OsbOrigin.Centre);
            int bg03Start = 223520;
            int bg03End = 225353;
            double bg03Height = 480.0f / bg03Bitmap.Height;
            bg03.Scale(OsbEasing.OutExpo, bg03Start, bg03End, bg03Height * 6, bg03Height * 1.1);
            bg03.Move(OsbEasing.OutExpo, bg03Start, bg03End, 320, 240, 320, 240);
            bg03.Fade(bg03Start, 1);
            bg03.Fade(bg03End, bg03End + 1000, 1, 0);


            string bg04Path = "sb/drop3/04.png";
            var bg04Bitmap = GetMapsetBitmap(bg04Path);
            var bg04 = backgroundLayer.CreateSprite(bg04Path, OsbOrigin.Centre);
            int bg04Start = 225353;
            int bg04End = 226853;
            double bg04Height = 480.0f / bg04Bitmap.Height;
            bg04.Scale(OsbEasing.OutExpo, bg04Start, bg04End, bg04Height * 6, bg04Height * 1.1);
            bg04.Move(OsbEasing.OutExpo, bg04Start, bg04End, 320, 240, 320, 240);
            bg04.Fade(bg04Start, 1);
            bg04.Fade(bg04End, bg04End + 1000, 1, 0);


            string bg05Path = "sb/drop3/05.png";
            var bg05Bitmap = GetMapsetBitmap(bg05Path);
            var bg05 = backgroundLayer.CreateSprite(bg05Path, OsbOrigin.Centre);
            int bg05Start = 226853;
            int bg05End = 228436;
            double bg05Height = 480.0f / bg05Bitmap.Height;
            bg05.Scale(OsbEasing.OutQuart, bg05Start, bg05End, bg05Height * 2, bg05Height * 2);
            bg05.Move(OsbEasing.OutQuart, bg05Start, bg05End, 0, 240+200, 320+300, 240+200);


            string bg06Path = "sb/drop3/06.png";
            var bg06Bitmap = GetMapsetBitmap(bg06Path);
            var bg06 = backgroundLayer.CreateSprite(bg06Path, OsbOrigin.Centre);
            int bg06Start = 228436;
            int bg06End = 229020;
            double bg06Height = 480.0f / bg06Bitmap.Height;
            bg06.Scale(OsbEasing.OutQuart, bg06Start, bg06End, bg06Height * 4, bg06Height * 2);
            bg06.Move(OsbEasing.OutQuart, bg06Start, bg06End, (320+300)*2, (240+200)*2, 320+300, 240+200);


            string bg07Path = "sb/drop3/07.png";
            var bg07Bitmap = GetMapsetBitmap(bg07Path);
            var bg07 = backgroundLayer.CreateSprite(bg07Path, OsbOrigin.Centre);
            int bg07Start = 229020;
            int bg07End = 229520;
            double bg07Height = 480.0f / bg07Bitmap.Height;
            bg07.Scale(OsbEasing.OutQuart, bg07Start, bg07End, bg07Height * 4, bg07Height * 2);
            bg07.Move(OsbEasing.OutQuart, bg07Start, bg07End, (320+300)*2, (240+200)*2, 320+300, 240+200);
            bg07.Fade(bg07Start, 1);
            bg07.Fade(bg07End, bg07End + 1000, 1, 0);


            string bg08Path = "sb/drop3/06.png";
            var bg08Bitmap = GetMapsetBitmap(bg08Path);
            var bg08 = backgroundLayer.CreateSprite(bg08Path, OsbOrigin.Centre);
            int bg08Start = 229420;
            int bg08End = 230353;
            double bg08Height = 480.0f / bg06Bitmap.Height;
            bg08.Scale(OsbEasing.OutQuart, bg08Start, bg08End, bg08Height * 4, bg08Height * 1.1);
            bg08.Move(OsbEasing.OutQuart, bg08Start, bg08End, (320+300)*2, (240+200)*2, 320, 240);
            bg08.Fade(bg08Start, 1);
            bg08.Fade(bg08End, bg08End + 1000, 1, 0);



            string bg09Path = "sb/drop3/09.png";
            var bg09Bitmap = GetMapsetBitmap(bg09Path);
            var bg09 = backgroundLayer.CreateSprite(bg09Path, OsbOrigin.Centre);
            int bg09Start = 230353;
            int bg09End = 232186;
            double bg09Height = 480.0f / bg09Bitmap.Height;
            bg09.Scale(OsbEasing.OutExpo, bg09Start, bg09End, bg09Height * 6, bg09Height * 1.1);
            bg09.Move(OsbEasing.OutExpo, bg09Start, bg09End, 320, 240, 320, 240);
            bg09.Fade(bg09Start, 1);
            bg09.Fade(bg09End, bg09End + 1000, 1, 0);




            string bg10Path = "sb/drop3/10.png";
            var bg10Bitmap = GetMapsetBitmap(bg10Path);
            var bg10 = backgroundLayer.CreateSprite(bg10Path, OsbOrigin.Centre);
            int bg10Start = 232186;
            int bg10End = 234186;
            double bg10Height = 480.0f / bg10Bitmap.Height;
            bg10.Scale(OsbEasing.OutQuart, bg10Start, bg10End, bg10Height * 2, bg10Height * 2);
            bg10.Move(OsbEasing.OutQuart, bg10Start, bg10End, 320+390, 240+100, 320-200, 240+100);



            string bg11Path = "sb/drop3/11.png";
            var bg11Bitmap = GetMapsetBitmap(bg11Path);
            var bg11 = backgroundLayer.CreateSprite(bg11Path, OsbOrigin.Centre);
            int bg11Start = 234186;
            int bg11End = 234520;
            double bg11Height = 480.0f / bg11Bitmap.Height;
            bg11.Scale(OsbEasing.OutQuart, bg11Start, bg11End, bg11Height * 1.5, bg11Height * 1.2);
            bg11.Move(OsbEasing.OutQuart, bg11Start, bg11End, 320, 240, 320, 240);


            string bg12Path = "sb/drop3/12.png";
            var bg12Bitmap = GetMapsetBitmap(bg12Path);
            var bg12 = backgroundLayer.CreateSprite(bg12Path, OsbOrigin.Centre);
            int bg12Start = 234520;
            int bg12End = 234853;
            double bg12Height = 480.0f / bg12Bitmap.Height;
            bg12.Scale(OsbEasing.OutQuart, bg12Start, bg12End, bg12Height * 1.5, bg12Height * 1.2);
            bg12.Move(OsbEasing.OutQuart, bg12Start, bg12End, 320, 240, 320, 240);



            string bg13Path = "sb/drop3/13.png";
            var bg13Bitmap = GetMapsetBitmap(bg13Path);
            var bg13 = backgroundLayer.CreateSprite(bg13Path, OsbOrigin.Centre);
            int bg13Start = 234853;
            int bg13End = 235853;
            double bg13Height = 480.0f / bg13Bitmap.Height;
            bg13.Scale(OsbEasing.OutQuart, bg13Start, bg13End, bg13Height * 1.5, bg13Height * 1.1);
            bg13.Move(OsbEasing.OutQuart, bg13Start, bg13End, 320, 240, 320, 240);
            bg13.Fade(bg13Start, 1);
            bg13.Fade(bg13End, bg13End + 1000, 1, 0);



            string bg14Path = "sb/drop3/14.png";
            var bg14Bitmap = GetMapsetBitmap(bg14Path);
            var bg14 = backgroundLayer.CreateSprite(bg14Path, OsbOrigin.Centre);
            int bg14Start = 235853;
            int bg14End = 237020;
            double bg14Height = 480.0f / bg14Bitmap.Height;
            bg14.Scale(OsbEasing.OutQuart, bg14Start, bg14End, bg14Height * 2, bg14Height * 2);
            bg14.Move(OsbEasing.OutQuart, bg14Start, bg14End, 680, 240+100, 400, 240+100);

            bg14.Fade(bg14Start, 1);
            bg14.Fade(bg14End, bg14End + 1000, 1, 0);


            string bg15Path = "sb/drop3/15.png";
            var bg15Bitmap = GetMapsetBitmap(bg15Path);
            var bg15 = backgroundLayer.CreateSprite(bg15Path, OsbOrigin.Centre);
            int bg15Start = 237020;
            int bg15End = 238686;
            double bg15Height = 480.0f / bg15Bitmap.Height;
            bg15.Scale(OsbEasing.OutQuart, bg15Start, bg15End, bg15Height * 2, bg15Height * 1.1);
            bg15.Move(OsbEasing.OutQuart, bg15Start, bg15End, 400, 240+100, 320, 240);

            bg15.Fade(bg15Start, 1);
            bg15.Fade(bg15End, bg15End + 1000, 1, 0);



            string bg16Path = "sb/drop3/16.png";
            var bg16Bitmap = GetMapsetBitmap(bg16Path);
            var bg16 = backgroundLayer.CreateSprite(bg16Path, OsbOrigin.Centre);
            int bg16Start = 238686;
            int bg16End = 240353;
            double bg16Height = 480.0f / bg16Bitmap.Height;
            bg16.Scale(OsbEasing.OutQuart, bg16Start, bg16End, bg16Height * 2, bg16Height * 2);
            bg16.Move(OsbEasing.OutQuart, bg16Start, bg16End, 680, 240+100, 400, 240+100);

            bg16.Fade(bg16Start, 1);
            bg16.Fade(bg16End, bg16End + 1000, 1, 0);



            string bg17Path = "sb/drop3/17.png";
            var bg17Bitmap = GetMapsetBitmap(bg17Path);
            var bg17 = backgroundLayer.CreateSprite(bg17Path, OsbOrigin.Centre);
            int bg17Start = 240353;
            int bg17End = 242686;
            double bg17Height = 480.0f / bg17Bitmap.Height;
            bg17.Scale(OsbEasing.OutQuart, bg17Start, bg17End, bg17Height * 2, bg17Height * 1.1);
            bg17.Move(OsbEasing.OutQuart, bg17Start, bg17End, 400, 240+100, 320, 240);
            bg17.Fade(bg17Start, 1);
            bg17.Fade(bg17End, bg17End + 1000, 1, 0);




            string bgPath = "sb/drop3/bg01.png";
            var bgBitmap = GetMapsetBitmap(bgPath);
            var bg = backgroundLayer.CreateSprite(bgPath, OsbOrigin.Centre);
            int bgStart = 242686;
            int bgEnd = 249186;
            bg.Scale(bgStart, 480.0f / bgBitmap.Height*1.1);
            bg.Fade(bgStart, 1);
            bg.Fade(bgEnd, bgEnd + 1000, 1, 0);

            int fiveStart = 246853;
            int fiveEnd = 249186;

            string fg1Path = "sb/fg/yuk/05.png";
            var fg1Bitmap = GetMapsetBitmap(fg1Path);
            var fg1 = fgLayer.CreateSprite(fg1Path, OsbOrigin.Centre);
            int fg1Start = 242686;
            int fg1End = 243519;
            double fg1Height = 480.0f / fg1Bitmap.Height;
            fg1.Fade(fg1Start, fg1Start + 200, 0, 1);
            fg1.Fade(fg1End, fg1End + 200, 1, 0);
            fg1.Move(OsbEasing.OutQuart, fg1Start, fg1End, 320+100, 240+400, 320-100, 240+400);
            fg1.Scale(OsbEasing.OutQuint, fg1Start, fg1End, fg1Height*2.8, fg1Height*2.8);

            fg1.Fade(fiveStart, fiveStart + 200, 0, 1);
            fg1.Fade(fiveEnd, fiveEnd + 200, 1, 0);
            fg1.Move(OsbEasing.OutQuart, fiveStart, fiveEnd, 320, 240, 320-330, 240);
            fg1.Scale(OsbEasing.OutQuint, fiveStart, fiveEnd, fg1Height*0.8, fg1Height*0.7);



            string fg2Path = "sb/fg/kaz/05.png";
            var fg2Bitmap = GetMapsetBitmap(fg2Path);
            var fg2 = fgLayer.CreateSprite(fg2Path, OsbOrigin.Centre);
            int fg2Start = 243519;
            int fg2End = 244352;
            double fg2Height = 480.0f / fg2Bitmap.Height;
            fg2.Fade(fg2Start, fg2Start + 200, 0, 1);
            fg2.Fade(fg2End, fg2End + 200, 1, 0);
            fg2.Move(OsbEasing.OutQuart, fg2Start, fg2End, 320, 240+500, 320+200, 240+500);
            fg2.Scale(OsbEasing.OutQuint, fg2Start, fg2End, fg2Height*3, fg2Height*3);


            fg2.Fade(fiveStart, fiveStart + 200, 0, 1);
            fg2.Fade(fiveEnd, fiveEnd + 200, 1, 0);
            fg2.Move(OsbEasing.OutQuart, fiveStart, fiveEnd, 320, 240, 320+350, 240);
            fg2.Scale(OsbEasing.OutQuint, fiveStart, fiveEnd, fg2Height, fg2Height*0.7);


            string fg3Path = "sb/fg/yay/05.png";
            var fg3Bitmap = GetMapsetBitmap(fg3Path);
            var fg3 = fgLayer.CreateSprite(fg3Path, OsbOrigin.Centre);
            int fg3Start = 244352;
            int fg3End = 245185;
            double fg3Height = 480.0f / fg3Bitmap.Height;
            fg3.Fade(fg3Start, fg3Start + 200, 0, 1);
            fg3.Fade(fg3End, fg3End + 200, 1, 0);
            fg3.Move(OsbEasing.OutQuart, fg3Start, fg3End, 320+50, 240+500, 320-150, 240+500);
            fg3.Scale(OsbEasing.OutQuint, fg3Start, fg3End, fg3Height*3, fg3Height*3);

            fg3Path = "sb/fg/yay/05.png";
            fg3Bitmap = GetMapsetBitmap(fg3Path);
            fg3 = fgLayer.CreateSprite(fg3Path, OsbOrigin.Centre);
            fg3.Fade(fiveStart, fiveStart + 200, 0, 1);
            fg3.Fade(fiveEnd, fiveEnd + 200, 1, 0);
            fg3.Move(OsbEasing.OutQuart, fiveStart, fiveEnd, 320, 240, 320-160, 240);
            fg3.Scale(OsbEasing.OutQuint, fiveStart, fiveEnd, fg3Height, fg3Height*0.7);



            string fg4Path = "sb/fg/eri/05.png";
            var fg4Bitmap = GetMapsetBitmap(fg4Path);
            var fg4 = fgLayer.CreateSprite(fg4Path, OsbOrigin.Centre);
            int fg4Start = 245185;
            int fg4End = 246108;
            double fg4Height = 480.0f / fg4Bitmap.Height;
            fg4.Fade(fg4Start, fg4Start + 200, 0, 1);
            fg4.Fade(fg4End, fg4End + 200, 1, 0);
            fg4.Move(OsbEasing.OutQuart, fg4Start, fg4End, 320, 240+500, 320+200, 240+500);
            fg4.Scale(OsbEasing.OutQuint, fg4Start, fg4End, fg4Height*3, fg4Height*3);

            fg4.Fade(fiveStart, fiveStart + 200, 0, 1);
            fg4.Fade(fiveEnd, fiveEnd + 200, 1, 0);
            fg4.Move(OsbEasing.OutQuart, fiveStart, fiveEnd, 320, 240, 320+180, 240);
            fg4.Scale(OsbEasing.OutQuint, fiveStart, fiveEnd, fg4Height, fg4Height*0.7);


            string fg5Path = "sb/fg/yuu/05.png";
            var fg5Bitmap = GetMapsetBitmap(fg5Path);
            var fg5 = fgLayer.CreateSprite(fg5Path, OsbOrigin.Centre);
            int fg5Start = 246108;
            int fg5End = 246853;
            double fg5Height = 480.0f / fg5Bitmap.Height;
            fg5.Fade(fg5Start, fg5Start + 200, 0, 1);
            fg5.Fade(fg5End-200, fg5End, 1, 0);
            fg5.Move(OsbEasing.OutQuart, fg5Start, fg5End, 320+50, 240+500, 320-150, 240+500);
            fg5.Scale(OsbEasing.OutQuint, fg5Start, fg5End, fg5Height*3, fg5Height*3);

            fg5.Fade(fiveStart, fiveStart + 200, 0, 1);
            fg5.Fade(fiveEnd, fiveEnd + 200, 1, 0);
            fg5.Move(OsbEasing.OutQuart, fiveStart, fiveEnd, 320, 240, 320, 240);
            fg5.Scale(OsbEasing.OutQuint, fiveStart, fiveEnd, fg5Height, fg5Height*0.7);




            string maskPath = "sb/effect/mask02.png";
            var maskBitmap = GetMapsetBitmap(maskPath);
            var mask = effectLayer.CreateSprite(maskPath, OsbOrigin.Centre);
            mask.Fade(bgStart, 1);
            mask.Fade(bgEnd, bgEnd + 200, 1, 0);

            string mask02Path = "sb/effect/mask02.png";
            var mask02Bitmap = GetMapsetBitmap(mask02Path);
            var mask02 = effectLayer.CreateSprite(mask02Path, OsbOrigin.Centre);
            mask02.Fade(bgStart, 1);
            mask02.Fade(bgEnd, bgEnd + 200, 1, 0);

            string mask03Path = "sb/effect/mask03.png";
            var mask03Bitmap = GetMapsetBitmap(mask03Path);
            var mask03 = effectLayer.CreateSprite(mask03Path, OsbOrigin.Centre);
            mask03.Fade(bgStart, 1);
            mask03.Fade(bgEnd, bgEnd + 200, 1, 0);



            string lightPath = "sb/effect/light.png";
            var lightBitmap = GetMapsetBitmap(lightPath);
            var light = effectLayer.CreateSprite(lightPath, OsbOrigin.Centre);
            light.Fade(bg01Start -200, bg01Start , 0, 1);
            light.Fade(bg01Start, bg01Start + 200, 1, 0);
            light.Fade(bg02Start -200, bg02Start , 0, 1);
            light.Fade(bg02Start, bg02Start + 100, 1, 0);
            light.Fade(bg03Start -100, bg03Start , 0, 1);
            light.Fade(bg03Start, bg03Start + 200, 1, 0);
        }
    }
}
