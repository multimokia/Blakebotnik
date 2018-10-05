using Discord;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication5
{
    public class BlakeBot
    {
        private DiscordClient bot;

        public BlakeBot()
        {
            bot = new DiscordClient();

            bot.MessageReceived += Bot_MessageReceived;

            bot.Connect(user, pass);

            bot.Wait();
        }

        private void Bot_MessageReceived(object sender, MessageEventArgs e)
        {
            if (e.Message.IsAuthor) return;

            //Debug Command here
            if (e.Message.Text == "oi")
            {
                Console.WriteLine("This works");
                e.Channel.SendMessage(e.User.Mention + " I could have scripted that mate");
            }
            //Static commands
            if(e.Message.Text == "/o/")
            {
                e.Channel.SendMessage(e.User.Mention + " \\o\\");
            }
            if (e.Message.Text == "\\o\\")
            {
                e.Channel.SendMessage(e.User.Mention + " /o/");
            }
            if (e.Message.Text.Equals("NumNumNumNum", StringComparison.InvariantCultureIgnoreCase) || e.Message.Text.Equals("come on and", StringComparison.InvariantCultureIgnoreCase))
            {
                e.Channel.SendMessage(e.User.Mention + " Touch my body");
            }
            if (e.Message.Text.ToLower().Contains("c#"))
            {
                e.Channel.SendMessage(e.User.Mention + " :heart:");
            }
            if (e.Message.Text.Equals("flip", StringComparison.InvariantCultureIgnoreCase))
            {
                e.Message.Delete();
                e.Channel.SendMessage("(╯°□°）╯︵ ┻━┻");
            }
            if (e.Message.Text.Equals("unflip", StringComparison.InvariantCultureIgnoreCase))
            {
                e.Message.Delete();
                e.Channel.SendMessage("┬─┬﻿ ノ( ゜-゜ノ)");
            }
            if (e.Message.Text.Equals("shrug", StringComparison.InvariantCultureIgnoreCase))
            {
                e.Channel.SendMessage("¯\\_(ツ)_/¯");
            }
            if (e.Message.Text.Contains("bin"))
            {
                e.Channel.SendTTSMessage("Try not to get taken out with the trash");
            }
            if (e.Message.Text.ToLower().Contains("goodnight"))
            {
                e.Channel.SendMessage(e.User.Mention + " Goodnight");
            }
            if (e.Message.Text.Equals("night", StringComparison.InvariantCultureIgnoreCase))
            {
                e.Channel.SendMessage(e.User.Mention + (" goodnight, sleep well!"));
            }
            if (e.Message.Text.ToLower().Contains("hello") || e.Message.Text.ToLower().Contains(" hey") || e.Message.Text.ToLower().Contains(" hi "))
            {
                e.Channel.SendTTSMessage(e.User.Mention + " Hello!");
            }
            if (e.Message.Text.ToLower().Contains(":grumpy:") || e.Message.Text == ":grumpy:")
            {
                e.Channel.SendFile("C:/Users/mike/Pictures/smiley1.png");
            }
            if (e.Message.Text.Contains("-.-") || e.Message.Text.Contains("-_-"))
            {
                e.Channel.SendFile("C:/Users/mike/Pictures/smiley1.png");
            }
            if (e.Message.Text.Equals("!lyrics", StringComparison.InvariantCultureIgnoreCase))
            {
                e.Channel.SendMessage(e.User.Mention + " You have to give the song name first *facepalm*");
            }
            if (e.Message.Text.Equals("!lyrics touch my body", StringComparison.InvariantCultureIgnoreCase))
            {
                e.Channel.SendMessage(e.User.Mention + " NumNumNumNum touch my body\nC'mawn and touch my body!\nNumNumNumNum touch my body\nC'mawn and touch my body!\nI can see by the way that you're looking at me\nthat you wanna have a tiny little touch of my body\nSo go ahead, have a touch, cos it feels so nice\n'got the texture of carrots... and it tastes like rice\nI make it jiggle in the sun, make it jiggle in the rain,\njiggle in your eyes and jiggle in your brain,\njiggle on the floor and jiggle in the mirror,\njiggle on the ceiling....\nFricka fricka fricka fresh little jiggle, rides like a pony\nDoes anybody know if his real name's Tony?\nBarbra Streisand alone on a dock\nIf you don't like it you can suck my pocket watch\n\nNumNumNumNum touch my body\nC'mawn and touch my body!\nNumNumNumNum touch my body\nC'mawn and touch my body!\nx 4\n\nOh I once had a wiggle and his name was Greg,\nand every time that he would jiggle he would jump on his pegleg.\nI got a half shilling and a hand full of doodie\nand I'd really really like it if you'd shake ya bootie\nEvery body dance...and remove your underpants\nOh my Gosh!It's the attack of the killer ants!\nOh I once had a date with a unicorn\nWe went back to mine and we looked at porn!\nAlbert Fletcher alone on a raft\nwith a hippo, a lion and half a giraffe\nOne plays the strings, one plays the brass\nand the other one sits there smoking some grass.\nMeanwhile up in space a long time ago\nwas a man and a chicken and a deep fried afro,\nand a nun and a jeep and a packet of crisps\nand the empty wrapper of a Cadbury's Wispa\n\nNumNumNumNum touch my body\nC'mawn and touch my body!\nNumNumNumNum touch my body\nC'mawn and touch my body!\nx 4");
            }
            if (e.Message.Text.ToLower.Equals("!test"))
            {
                e.Channel.SendMessage("Testing push!");
            }
            //PRfromGHD verified?work?
        }
    }
}
