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
using System.Security.Cryptography.X509Certificates;

namespace StorybrewScripts
{
    public class Intro : StoryboardObjectGenerator
    {
        


        public override void Generate()
        {
            var backgroundLayer = GetLayer("IntroBackground");
            var titleLayer = GetLayer("IntroTitle");

            string skyPath = "sb/intro/sky.jpg";
            var skyBitmap = GetMapsetBitmap(skyPath);
            var sky = backgroundLayer.CreateSprite(skyPath, OsbOrigin.Centre);
            int skyStart = 0;
            int skyEnd = 12520;
            sky.Scale(skyStart, 480.0f / skyBitmap.Height * 2);
            sky.Fade(skyStart, 1);
            sky.Fade(skyEnd, skyEnd + 1000, 1, 0);
            sky.MoveY(OsbEasing.OutQuad, 0, skyEnd + 1000, 480, 240);
            sky.Scale(OsbEasing.OutQuad, skyEnd, skyEnd + 1000, 480.0f / skyBitmap.Height * 2, 4);

            string title1Path = "sb/intro/title1.png";
            var title1Bitmap = GetMapsetBitmap(title1Path);
            var title1 = titleLayer.CreateSprite(title1Path, OsbOrigin.Centre);
            int title1Start = 500;
            int title1End = 4220;
            title1.Scale(OsbEasing.OutQuad, title1Start, title1Start + 500, 0, 0.5);
            title1.Fade(title1Start, title1Start+500, 0, 1);
            title1.Fade(title1End, title1End+500, 1, 0);

            string title2Path = "sb/intro/title2.png";
            var title2Bitmap = GetMapsetBitmap(title2Path);
            var title2 = titleLayer.CreateSprite(title2Path, OsbOrigin.Centre);
            int title2Start = 4220;
            int title2End = 8520;
            title2.Scale(OsbEasing.OutQuad, title2Start, title2Start + 500, 0, 0.5);
            title2.Fade(title2Start, title2Start+500, 0, 1);
            title2.Fade(title2End, title2End+500, 1, 0);

            string title3Path = "sb/intro/title3.png";
            var title3Bitmap = GetMapsetBitmap(title3Path);
            var title3 = titleLayer.CreateSprite(title3Path, OsbOrigin.Centre);
            int title3Start = 8520;
            int title3End = 12020;
            title3.Scale(OsbEasing.OutQuad, title3Start, title3Start + 500, 0, 0.5);
            title3.Fade(title3Start, title3Start+500, 0, 1);
            title3.Fade(title3End, title3End+500, 1, 0);

            string cityPath = "sb/intro/city.jpg";
            var cityBitmap = GetMapsetBitmap(cityPath);
            var city = backgroundLayer.CreateSprite(cityPath, OsbOrigin.Centre);
            int cityStart = 12520;
            int cityEnd = 17583;
            city.Scale(cityStart-200, cityStart + 500, 1.1, 1);
            city.Fade(cityStart, cityStart+500, 0, 1);
            city.Fade(cityEnd, cityEnd + 1000, 1, 0);
            city.MoveY(OsbEasing.OutQuad, cityStart , cityEnd + 500, 280, 240);

            string bg1Path = "sb/intro/bg1.jpg";
            var bg1Bitmap = GetMapsetBitmap(bg1Path);
            var bg1 = backgroundLayer.CreateSprite(bg1Path, OsbOrigin.Centre);
            int bg1Start = 17583;
            int bg1End = 19186;
            bg1.Scale(bg1Start, 1);
            bg1.Fade(bg1Start, bg1Start+500, 0, 1);
            bg1.Fade(bg1End, bg1End + 500, 1, 0);
            bg1.MoveY(OsbEasing.OutQuad, bg1Start , bg1End + 500, 260, 240);

            string bg2Path = "sb/intro/bg2.jpg";
            var bg2Bitmap = GetMapsetBitmap(bg2Path);
            var bg2 = backgroundLayer.CreateSprite(bg2Path, OsbOrigin.Centre);
            int bg2Start = 19186;
            int bg2End = 20520;
            bg2.Scale(bg2Start, 1);
            bg2.Fade(bg2Start, bg2Start+500, 0, 1);
            bg2.Fade(bg2End, bg2End + 500, 1, 0);
            bg2.MoveY(OsbEasing.OutQuad, bg2Start , bg2End + 500, 260, 240);

            string bg3Path = "sb/intro/bg3.jpg";
            var bg3Bitmap = GetMapsetBitmap(bg3Path);
            var bg3 = backgroundLayer.CreateSprite(bg3Path, OsbOrigin.Centre);
            int bg3Start = 20520;
            int bg3End = 21853; 
            bg3.Scale(bg3Start, 1);
            bg3.Fade(bg3Start, bg3Start+500, 0, 1);
            bg3.Fade(bg3End, bg3End + 500, 1, 0);
            bg3.MoveY(OsbEasing.OutQuad, bg3Start , bg3End + 500, 260, 240);

            string bg4Path = "sb/intro/bg4.jpg";
            var bg4Bitmap = GetMapsetBitmap(bg4Path);
            var bg4 = backgroundLayer.CreateSprite(bg4Path, OsbOrigin.Centre);
            int bg4Start = 21853;
            int bg4End = 23186; 
            bg4.Scale(bg4Start, 1);
            bg4.Fade(bg4Start, bg4Start+500, 0, 1);
            bg4.Fade(bg4End, bg4End + 500, 1, 0);
            bg4.MoveY(OsbEasing.OutQuad, bg4Start , bg4End + 500, 260, 240);

            string lightPath = "sb/effect/light.png";
            var lightBitmap = GetMapsetBitmap(lightPath);
            var light = backgroundLayer.CreateSprite(lightPath, OsbOrigin.Centre);

            
        }
    }
}
