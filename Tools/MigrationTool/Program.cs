using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            var replacements = new Dictionary<string, string>
            {
                {
                    "msgid \"The skeletons here are confirmed to be sailors and pirates.\"",
                    "msgid \"Archaeologist (recording): The skeletons here are confirmed to be sailors and pirates.\""
                },
                {
                    "msgid \"The pirates and sailors were involved in some kind of internal conflict.\"",
                    "msgid \"Archaeologist (recording): The pirates and sailors were involved in some kind of internal conflict.\""
                },
                {
                    "msgid \"We had to extract some of the team, as they fell ill. We have to assume they disturbed something near the bodies.\"",
                    "msgid \"Archaeologist (recording): We had to extract some of the team, as they fell ill. We have to assume they disturbed something near the bodies.\""
                },
                {
                    "msgid \"This is Gareth Thomas speaking. We have analysed the algae samples\"",
                    "msgid \"Gareth Thomas (recording): This is Gareth Thomas speaking.We have analysed the algae samples\""
                },
                {
                    "msgid \"This is the uh, Liam Jones, audio diary, #1, uh\"",
                    "msgid \"Liam Jones (recording): This is the uh, Liam Jones, audio diary, #1, uh\""
                },
                {
                    "msgid \"This is the uh, Liam Jones uh, diary #2\"",
                    "msgid \"Liam Jones (recording): This is the uh, Liam Jones uh, diary #2\""
                },
                {
                    "msgid \"This is Liam Jones, the live sample security engineer on-site - we've just admitted\"",
                    "msgid \"Liam Jones (recording): This is Liam Jones, the live sample security engineer on-site - we've just admitted\""
                },
                {
                    "msgid \"You thought we'd just let you keep wandering around the island, killing Sokol-Glockner personnel?\"",
                    "msgid \"Arque Guard: You thought we'd just let you keep wandering around the island, killing Sokol-Glockner personnel?\""
                },
                {
                    "msgid \"Hello?\"",
                    "msgid \"John Derril (over radio): Hello ? \""
                },
                {
                    "msgid \"Welcome to Arque East. Please stand by for biological scan.\"",
                    "msgid \"Arque Scanner (via loudspeaker): Welcome to Arque East. Please stand by for biological scan.\""
                },
                {
                    "msgid \"The private security firm Sokol-Glockner has been criticised for the second time this year\"",
                    "msgid \"News Presenter (on TV): The private security firm Sokol-Glockner has been criticised for the second time this year\""
                },
                {
                    "msgid \"This is an automated message from Arque Corporation.\"",
                    "msgid \"Unknown (over radio): This is an automated message from Arque Corporation.\""
                },
                {
                    "msgid \"If there's ANYONE listening to this, I need help.\"",
                    "msgid \"John Derril (over radio): If there's ANYONE listening to this, I need help.\""
                },
                {
                    "msgid \"I'm just going to... continue broadcasting until I can't anymore.\"",
                    "msgid \"John Derril (over radio): I'm just going to... continue broadcasting until I can't anymore.\""
                },
                {
                    "msgid \"I was split up from my wife and daughter when the things came.\"",
                    "msgid \"John Derril (over radio): I was split up from my wife and daughter when the things came.\""
                },
                {
                    "msgid \"I know how to fix radios... not much else.\"",
                    "msgid \"John Derril (over radio): I know how to fix radios... not much else.\""
                },
                {
                    "msgid \"Please, ANYONE listening to this. If you think it's bad here... it's worse.\"",
                    "msgid \"John Derril (over radio): Please, ANYONE listening to this.If you think it's bad here... it's worse.\""
                },
                {
                    "msgid \"Why has no one checked up on us? This is a small island, but there's still people...\"",
                    "msgid \"John Derril (over radio): Why has no one checked up on us? This is a small island, but there's still people...\""
                },
                {
                    "msgid \"This is the Norwegian Coast Guard. Please state your coordinates.\"",
                    "msgid \"Coast Guard (over radio): This is the Norwegian Coast Guard. Please state your coordinates.\""
                },
                {
                    "msgid \"OK\"",
                    "msgid \"Coast Guard (over radio): OK\""
                },
                {
                    "msgid \"I have to inform you... there is an active government defence operation underway at your position.\"",
                    "msgid \"Coast Guard (over radio): I have to inform you...there is an active government defence operation underway at your position.\""
                },
                {
                    "msgid \"COMMENCE EXPUNGE, OBSERVER CLEANSE\"",
                    "msgid \"Unknown (over radio): COMMENCE EXPUNGE, OBSERVER CLEANSE\""
                },
                {
                    "msgid \"Wait what's that... is that the radio? Hello? Hello! Oh God yes you did it!\"",
                    "msgid \"John Derril (over radio): Wait what's that... is that the radio? Hello? Hello! Oh God yes you did it!\""
                },
                {
                    "msgid \"We're at approximately 72 degrees, 59 minutes and 6 seconds North, and uh, 2 degrees, 51 minutes and 54 seconds East.\"",
                    "msgid \"John Derril (over radio): We're at approximately 72 degrees, 59 minutes and 6 seconds North, and uh, 2 degrees, 51 minutes and 54 seconds East.\""
                },
                {
                    "msgid \"Uh, it's John.\"",
                    "msgid \"John Derril (over radio): Uh, it's John.\""
                },
                {
                    "msgid \"Hello! Hello? Coastguard?! Anyone there?\"",
                    "msgid \"John Derril (over radio): Hello! Hello? Coastguard?! Anyone there?\""
                },
                {
                    "msgid \"Coastguard are you there? Is anyone there? Someone pick up...\"",
                    "msgid \"John Derril (over radio): Coastguard are you there? Is anyone there? Someone pick up...\""
                }
            };

            var searches = new[] { "*.po" };

            foreach (var search in searches)
            {
                foreach (var file in Directory.EnumerateFiles(@"C:\git\Insulam\Content\Localization\Game", search, new EnumerationOptions { RecurseSubdirectories = true }))
                {
                    var content = File.ReadAllText(file);

                    foreach (var replacement in replacements)
                    {
                        content = content.Replace(replacement.Key, replacement.Value);
                    }

                    File.WriteAllText(file, content, new UTF8Encoding(true));
                }
            }
        }
    }
}
