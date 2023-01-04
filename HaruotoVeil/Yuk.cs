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
    public class Yuk : StoryboardObjectGenerator
    {
        public override void Generate()
        {
		    var backgroundLayer = GetLayer("YukBackground");
            var fgLayer = GetLayer("YukBody");

            string bgPath = "sb/fg/yuk/bg.png";
            var bgBitmap = GetMapsetBitmap(bgPath);
            var bg = backgroundLayer.CreateSprite(bgPath, OsbOrigin.Centre);
            int bgStart = 117220;
            int bgEnd = 123186;
            bg.Scale(bgStart, 480.0f / bgBitmap.Height);
            bg.Fade(bgStart, 1);
            bg.Fade(bgEnd, bgEnd + 1000, 1, 0);
            bg.MoveX(bgStart, bgEnd, 0, 640.0);

            string fg1Path = "sb/fg/yuk/01.png";
            var fg1Bitmap = GetMapsetBitmap(fg1Path);
            var fg1 = fgLayer.CreateSprite(fg1Path, OsbOrigin.Centre);
            int fg1Start = 117220;
            int fg1End = 123186;
            int time1 = 119020;
            int time2 = 120520;
            int time3 = 121686;
            int time4 = 121686;
            int time5 = 121686;
            double fg1Height = 480.0f / fg1Bitmap.Height;
            double fg1Width = 640.0f / fg1Bitmap.Width;
            double fg1X = 320 / fg1Bitmap.Width;
            double fg1Y = 240 / fg1Bitmap.Height;
            fg1.Fade(fg1Start, 1);
            fg1.Fade(fg1End, fg1End + 1000, 1, 0);

            fg1.Scale(fg1Start, fg1Height * 6);
            fg1.Move(OsbEasing.OutQuart, fg1Start, time1, 320 + 700, 240 + 500, 320, 240 + 500);

            fg1.Move(OsbEasing.OutQuart, time1, time2, 320 - 700, 240, 320, 240);

            fg1.Move(OsbEasing.OutQuart, time2, time3, 320, 240 - 1050, 320, 240 - 350);

            // fg1.Move(OsbEasing.OutQuart, time3, time4, 320, 240 + 2500, 320, 240 + 2050);
            // fg1.Scale(OsbEasing.OutQuart, time3, time4, fg1Height * 16, fg1Height * 12);

            // fg1.Move(OsbEasing.OutQuart, time4, time5, 320, 240 + 2500, 320, 240 + 900);
            // fg1.Scale(OsbEasing.OutQuart, time4, time5, fg1Height * 16, fg1Height * 5);

            fg1.Move(OsbEasing.OutQuint, time5, fg1End, 320, 240, 320, 240);
            fg1.Scale(OsbEasing.OutQuint, time5, fg1End, fg1Height * 8, fg1Height);
            
        }
    }
}
