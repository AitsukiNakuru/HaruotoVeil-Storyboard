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
    public class Image : StoryboardObjectGenerator
    {
        [Configurable]
        public string BackgroundPath1 = "";
        [Configurable]
        public string BackgroundPath2 = "";

        // [Configurable]
        // public string BackgroundPath = "";

        // [Configurable]
        // public string BackgroundPath2 = "";

        [Configurable]
        public int StartTime = 0;

        [Configurable]
        public int EndTime = 0;

        [Configurable]
        public double Opacity = 1;

        public override void Generate()
        {
          
            // var bitmap1 = GetMapsetBitmap(BackgroundPath1);
            // var bitmap2 = GetMapsetBitmap(BackgroundPath2);

            // var layer = GetLayer("Main");
            // var bg1 = layer.CreateSprite("BackgroundPath1", OsbOrigin.Centre);
            // bg1.Scale(StartTime, 510.0f / bitmap1.Height);
            // bg1.MoveX(StartTime, (StartTime + EndTime)/2, 300, 320);
            // bg1.Fade(StartTime, StartTime + 500, 0, Opacity);
            // bg1.Fade(EndTime, (StartTime + EndTime)/2 + 500, Opacity, 0);
        
            // var bg2 = layer.CreateSprite("BackgroundPath2", OsbOrigin.Centre);
            // bg2.Scale(StartTime, 510.0f / bitmap2.Height);
            // bg2.MoveX((StartTime + EndTime)/2, EndTime, 320, 340);
            // bg2.Fade(EndTime, EndTime + 500, Opacity, 0);
            // public string BackgroundPath1 = BackgroundPath + ".png";
            // public string BackgroundPath2 = BackgroundPath + "_2.png";
            var bitmap1 = GetMapsetBitmap(BackgroundPath1);
            var bg = GetLayer("Main").CreateSprite(BackgroundPath1, OsbOrigin.Centre);
            bg.Scale(StartTime, 480.0f / bitmap1.Height*1.2);
            bg.Fade(StartTime, StartTime + 500, 0, Opacity);
            bg.Fade((StartTime + EndTime)/2, (StartTime + EndTime)/2 + 100, Opacity, 0);
            bg.MoveX(StartTime, EndTime, 300, 340);


            var bitmap2 = GetMapsetBitmap(BackgroundPath2);
            var bg2 = GetLayer("Main").CreateSprite(BackgroundPath2, OsbOrigin.Centre);
            bg2.Scale(StartTime, 480.0f / bitmap2.Height*1.2);
            bg2.Fade((StartTime + EndTime)/2 - 100, (StartTime+EndTime)/2, 0, Opacity);
            bg2.Fade(EndTime, EndTime + 500, Opacity, 0);
            bg2.MoveX(StartTime, EndTime, 300, 340);
        }
    }
}
