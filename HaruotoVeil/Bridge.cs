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
    public class Bridge : StoryboardObjectGenerator
    {
        public override void Generate()
        {
		    var backgroundLayer = GetLayer("BridgeBackground");
            var fgLayer = GetLayer("BridgeBody");

            string fg1Path = "sb/fg/kaz/03.png";
            var fg1Bitmap = GetMapsetBitmap(fg1Path);
            var fg1 = fgLayer.CreateSprite(fg1Path, OsbOrigin.Centre);
            int fg1Start = 177853;
            int fg1End = 182653;
            double fg1Height = 480.0f / fg1Bitmap.Height;
            fg1.Fade(fg1Start, fg1Start + 500, 0, 1);
            fg1.Fade(fg1End, fg1End + 500, 1, 0);
            fg1.Move(OsbEasing.OutQuart, fg1Start, fg1End, 320+320, 240, 320-100, 240);
            fg1.Scale(OsbEasing.OutQuint, fg1Start, fg1End, fg1Height*1.2, fg1Height);
            string bg01_1Path = "sb/bridge/bg01_1.jpg";
            var bg01_1Bitmap = GetMapsetBitmap(bg01_1Path);
            var bg01_1 = backgroundLayer.CreateSprite(bg01_1Path, OsbOrigin.Centre);
            int bg01_1Start = fg1Start;
            int bg01_1End = (fg1Start + fg1End)/2;
            bg01_1.Scale(bg01_1Start, 480.0f / bg01_1Bitmap.Height*1.2);
            bg01_1.Fade(bg01_1Start, bg01_1Start+500, 0, 1);
            bg01_1.Fade(bg01_1End, bg01_1End + 500, 1, 0);
            bg01_1.MoveX(bg01_1Start, bg01_1End, 300, 320);
            string bg01_2Path = "sb/bridge/bg01_2.jpg";
            var bg01_2Bitmap = GetMapsetBitmap(bg01_2Path);
            var bg01_2 = backgroundLayer.CreateSprite(bg01_2Path, OsbOrigin.Centre);
            int bg01_2Start = bg01_1End;
            int bg01_2End = fg1End;
            bg01_2.Scale(bg01_2Start, 480.0f / bg01_2Bitmap.Height *1.2);
            bg01_2.Fade(bg01_2Start, bg01_2Start+500, 0, 1);
            bg01_2.Fade(bg01_2End, bg01_2End + 500, 1, 0);
            bg01_2.MoveX(bg01_2Start, bg01_2End, 320, 340);



            string fg2Path = "sb/fg/yuk/03.png";
            var fg2Bitmap = GetMapsetBitmap(fg2Path);
            var fg2 = fgLayer.CreateSprite(fg2Path, OsbOrigin.Centre);
            int fg2Start = 182653;
            int fg2End = 187453;
            double fg2Height = 480.0f / fg2Bitmap.Height;
            fg2.Fade(fg2Start, fg2Start + 500, 0, 1);
            fg2.Fade(fg2End, fg2End + 500, 1, 0);
            fg2.Move(OsbEasing.OutQuart, fg2Start, fg2End, 0, 240, 320+100, 240);
            fg2.Scale(OsbEasing.OutQuint, fg2Start, fg2End, fg2Height*1.2, fg2Height);
            string bg02_1Path = "sb/bridge/bg02_1.jpg";
            var bg02_1Bitmap = GetMapsetBitmap(bg02_1Path);
            var bg02_1 = backgroundLayer.CreateSprite(bg02_1Path, OsbOrigin.Centre);
            int bg02_1Start = fg2Start;
            int bg02_1End = (fg2Start + fg2End)/2;
            bg02_1.Scale(bg02_1Start, 480.0f / bg02_1Bitmap.Height*1.2);
            bg02_1.Fade(bg02_1Start, bg02_1Start+500, 0, 1);
            bg02_1.Fade(bg02_1End, bg02_1End + 500, 1, 0);
            bg02_1.MoveX(bg02_1Start, bg02_1End, 340, 320);
            string bg02_2Path = "sb/bridge/bg02_2.jpg";
            var bg02_2Bitmap = GetMapsetBitmap(bg02_2Path);
            var bg02_2 = backgroundLayer.CreateSprite(bg02_2Path, OsbOrigin.Centre);
            int bg02_2Start = bg02_1End;
            int bg02_2End = fg2End;
            bg02_2.Scale(bg02_2Start, 480.0f / bg02_2Bitmap.Height *1.2);
            bg02_2.Fade(bg02_2Start, bg02_2Start+500, 0, 1);
            bg02_2.Fade(bg02_2End, bg02_2End + 500, 1, 0);
            bg02_2.MoveX(bg02_2Start, bg02_2End, 320, 300);


            string fg3Path = "sb/fg/yay/03.png";
            var fg3Bitmap = GetMapsetBitmap(fg3Path);
            var fg3 = fgLayer.CreateSprite(fg3Path, OsbOrigin.Centre);
            int fg3Start = 187453;
            int fg3End = 192253;
            double fg3Height = 480.0f / fg3Bitmap.Height;
            fg3.Fade(fg3Start, fg3Start + 500, 0, 1);
            fg3.Fade(fg3End, fg3End + 500, 1, 0);
            fg3.Move(OsbEasing.OutQuart, fg3Start, fg3End, 320+320, 240, 320-100, 240);
            fg3.Scale(OsbEasing.OutQuint, fg3Start, fg3End, fg3Height*1.2, fg3Height);
            string bg03_1Path = "sb/bridge/bg03_1.jpg";
            var bg03_1Bitmap = GetMapsetBitmap(bg03_1Path);
            var bg03_1 = backgroundLayer.CreateSprite(bg03_1Path, OsbOrigin.Centre);
            int bg03_1Start = fg3Start;
            int bg03_1End = (fg3Start + fg3End)/2;
            bg03_1.Scale(bg03_1Start, 480.0f / bg03_1Bitmap.Height*1.2);
            bg03_1.Fade(bg03_1Start, bg03_1Start+500, 0, 1);
            bg03_1.Fade(bg03_1End, bg03_1End + 500, 1, 0);
            bg03_1.MoveX(bg03_1Start, bg03_1End, 300, 320);
            string bg03_2Path = "sb/bridge/bg03_2.jpg";
            var bg03_2Bitmap = GetMapsetBitmap(bg03_2Path);
            var bg03_2 = backgroundLayer.CreateSprite(bg03_2Path, OsbOrigin.Centre);
            int bg03_2Start = bg03_1End;
            int bg03_2End = fg3End;
            bg03_2.Scale(bg03_2Start, 480.0f / bg03_2Bitmap.Height *1.2);
            bg03_2.Fade(bg03_2Start, bg03_2Start+500, 0, 1);
            bg03_2.Fade(bg03_2End, bg03_2End + 500, 1, 0);
            bg03_2.MoveX(bg03_2Start, bg03_2End, 320, 340);



            string fg4Path = "sb/fg/eri/03.png";
            var fg4Bitmap = GetMapsetBitmap(fg4Path);
            var fg4 = fgLayer.CreateSprite(fg4Path, OsbOrigin.Centre);
            int fg4Start = 192253;
            int fg4End = 197053;
            double fg4Height = 480.0f / fg4Bitmap.Height;
            fg4.Fade(fg4Start, fg4Start + 500, 0, 1);
            fg4.Fade(fg4End, fg4End + 500, 1, 0);
            fg4.Move(OsbEasing.OutQuart, fg4Start, fg4End, 0, 240, 320+100, 240);
            fg4.Scale(OsbEasing.OutQuint, fg4Start, fg4End, fg4Height*1.2, fg4Height);
            string bg04_1Path = "sb/bridge/bg04_1.jpg";
            var bg04_1Bitmap = GetMapsetBitmap(bg04_1Path);
            var bg04_1 = backgroundLayer.CreateSprite(bg04_1Path, OsbOrigin.Centre);
            int bg04_1Start = fg4Start;
            int bg04_1End = (fg4Start + fg4End)/2;
            bg04_1.Scale(bg04_1Start, 480.0f / bg04_1Bitmap.Height*1.2);
            bg04_1.Fade(bg04_1Start, bg04_1Start+500, 0, 1);
            bg04_1.Fade(bg04_1End, bg04_1End + 500, 1, 0);
            bg04_1.MoveX(bg04_1Start, bg04_1End, 340, 320);
            string bg04_2Path = "sb/bridge/bg04_2.jpg";
            var bg04_2Bitmap = GetMapsetBitmap(bg04_2Path);
            var bg04_2 = backgroundLayer.CreateSprite(bg04_2Path, OsbOrigin.Centre);
            int bg04_2Start = bg04_1End;
            int bg04_2End = fg4End;
            bg04_2.Scale(bg04_2Start, 480.0f / bg04_2Bitmap.Height *1.2);
            bg04_2.Fade(bg04_2Start, bg04_2Start+500, 0, 1);
            bg04_2.Fade(bg04_2End, bg04_2End + 500, 1, 0);
            bg04_2.MoveX(bg04_2Start, bg04_2End, 320, 300);



            string fg5Path = "sb/fg/yuu/03.png";
            var fg5Bitmap = GetMapsetBitmap(fg5Path);
            var fg5 = fgLayer.CreateSprite(fg5Path, OsbOrigin.Centre);
            int fg5Start = 197053;
            int fg5End = 201853;
            double fg5Height = 480.0f / fg5Bitmap.Height;
            fg5.Fade(fg5Start, fg5Start + 500, 0, 1);
            fg5.Fade(fg5End, fg5End + 500, 1, 0);
            fg5.Move(OsbEasing.OutQuart, fg5Start, fg5End, 320+320, 240, 320-100, 240);
            fg5.Scale(OsbEasing.OutQuint, fg5Start, fg5End, fg5Height*1.2, fg5Height);
            string bg05_1Path = "sb/bridge/bg05_1.jpg";
            var bg05_1Bitmap = GetMapsetBitmap(bg05_1Path);
            var bg05_1 = backgroundLayer.CreateSprite(bg05_1Path, OsbOrigin.Centre);
            int bg05_1Start = fg5Start;
            int bg05_1End = (fg5Start + fg5End)/2;
            bg05_1.Scale(bg05_1Start, 480.0f / bg05_1Bitmap.Height*1.2);
            bg05_1.Fade(bg05_1Start, bg05_1Start+500, 0, 1);
            bg05_1.Fade(bg05_1End, bg05_1End + 500, 1, 0);
            bg05_1.MoveX(bg05_1Start, bg05_1End, 300, 320);
            string bg05_2Path = "sb/bridge/bg05_2.jpg";
            var bg05_2Bitmap = GetMapsetBitmap(bg05_2Path);
            var bg05_2 = backgroundLayer.CreateSprite(bg05_2Path, OsbOrigin.Centre);
            int bg05_2Start = bg05_1End;
            int bg05_2End = fg5End;
            bg05_2.Scale(bg05_2Start, 480.0f / bg05_2Bitmap.Height *1.2);
            bg05_2.Fade(bg05_2Start, bg05_2Start+500, 0, 1);
            bg05_2.Fade(bg05_2End, bg05_2End + 500, 1, 0);
            bg05_2.MoveX(bg05_2Start, bg05_2End, 320, 340);

            


            
            
        }
    }
}
