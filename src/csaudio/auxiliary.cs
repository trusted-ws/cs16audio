using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csaudio
{
    public static class auxiliary
    {

        public static class Functions
        {

            public static bool checkForBots()
            {
                bool bots = false;

                /* TODO: Verificar se o diretorio cstrike contém a estrutura de bots [OK] */
                if(!Directory.Exists(config.cstrike))
                {
                    Console.WriteLine("[DEBUG] checkForBots() ~ config.cstrike ({0}) doesn't exists.", config.cstrike);
                    return false;
                }

                /* Check for bots: csbot, zbot, podbot structures */

                if (File.Exists(config.cstrike + @"\dlls\csbot.dll") && Directory.Exists(config.cstrike + @"\sound\radio\bot"))
                {
                    /* csbot (to install) */
                    bots = true;

                } else if (File.Exists(config.cstrike + @"\dlls\mpold.dll")) {

                    /* zbot */
                    bots = true;

                } else if(Directory.Exists(config.cstrike + @"\PODBot") || File.Exists(config.cstrike + @"\PODBot\podbot.dll"))
                {
                    /* podbot */
                    bots = true;
                }
                else
                {
                    /* No bots */
                    bots = false;
                }

                config.haveBots = bots;
                return bots;
            }
            public static List<string> SwitchPath(string audioName, string bp)
            {
                List<string> outputs = new List<string>();
                string basePath = bp;
                bool add = true;    /* Trigger for multiple output (false = multiple output)*/
                
                switch (audioName)
                {

                    /* Bots */
                    /*  \radio\bots */

                    case "a.wav":
                        basePath += @"\radio\bot";
                        break;

                    case "aah.wav":
                        basePath += @"\radio\bot";
                        break;

                    case "affirmative.wav":
                        basePath += @"\radio\bot";
                        break;

                    case "ahh_negative.wav":
                        basePath += @"\radio\bot";
                        break;

                    case "airplane.wav":
                        basePath += @"\radio\bot";
                        break;

                    case "alley.wav":
                        basePath += @"\radio\bot";
                        break;

                    case "all_clear_here.wav":
                        basePath += @"\radio\bot";
                        break;

                    case "all_quiet.wav":
                        basePath += @"\radio\bot";
                        break;

                    case "alright.wav":
                        basePath += @"\radio\bot";
                        break;

                    case "alright2.wav":
                        basePath += @"\radio\bot";
                        break;

                    case "alright_lets_do_this.wav":
                        basePath += @"\radio\bot";
                        break;

                    case "and_thats_how_its_done.wav":
                        basePath += @"\radio\bot";
                        break;

                    case "anyone_see_anything.wav":
                        basePath += @"\radio\bot";
                        break;

                    case "anyone_see_them.wav":
                        basePath += @"\radio\bot";
                        break;

                    case "apartment.wav":
                        basePath += @"\radio\bot";
                        break;

                    case "apartments.wav":
                        basePath += @"\radio\bot";
                        break;

                    case "area_clear.wav":
                        basePath += @"\radio\bot";
                        break;

                    case "area_secure.wav":
                        basePath += @"\radio\bot";
                        break;

                    case "atrium.wav":
                        basePath += @"\radio\bot";
                        break;

                    case "attacking.wav":
                        basePath += @"\radio\bot";
                        break;

                    case "attacking_enemies.wav":
                        basePath += @"\radio\bot";
                        break;

                    case "attic.wav":
                        basePath += @"\radio\bot";
                        break;

                    case "aww_man.wav":
                        basePath += @"\radio\bot";
                        break;

                    case "aw_hell.wav":
                        basePath += @"\radio\bot";
                        break;

                    case "a_bunch_of_them.wav":
                        basePath += @"\radio\bot";
                        break;

                    case "b.wav":
                        basePath += @"\radio\bot";
                        break;

                    case "back.wav":
                        basePath += @"\radio\bot";
                        break;

                    case "back_alley.wav":
                        basePath += @"\radio\bot";
                        break;

                    case "back_door.wav":
                        basePath += @"\radio\bot";
                        break;

                    case "back_hall.wav":
                        basePath += @"\radio\bot";
                        break;

                    case "back_room.wav":
                        basePath += @"\radio\bot";
                        break;

                    case "back_way.wav":
                        basePath += @"\radio\bot";
                        break;

                    case "back_yard.wav":
                        basePath += @"\radio\bot";
                        break;

                    case "balcony.wav":
                        basePath += @"\radio\bot";
                        break;

                    case "basement.wav":
                        basePath += @"\radio\bot";
                        break;

                    case "bathroom.wav":
                        basePath += @"\radio\bot";
                        break;

                    case "bathroom2.wav":
                        basePath += @"\radio\bot";
                        break;

                    case "bedroom.wav":
                        basePath += @"\radio\bot";
                        break;

                    case "bedroom2.wav":
                        basePath += @"\radio\bot";
                        break;

                    case "be_right_there.wav":
                        basePath += @"\radio\bot";
                        break;

                    case "big_office.wav":
                        basePath += @"\radio\bot";
                        break;

                    case "bombsite.wav":
                        basePath += @"\radio\bot";
                        break;

                    case "bombsite2.wav":
                        basePath += @"\radio\bot";
                        break;

                    case "bombsite_secure.wav":
                        basePath += @"\radio\bot";
                        break;

                    case "bombsite_secured.wav":
                        basePath += @"\radio\bot";
                        break;

                    case "bombsite_secure_ready_for_you.wav":
                        basePath += @"\radio\bot";
                        break;

                    case "bombsite_under_control.wav":
                        basePath += @"\radio\bot";
                        break;

                    case "bombs_on_the_ground.wav":
                        basePath += @"\radio\bot";
                        break;

                    case "bombs_on_the_ground_here.wav":
                        basePath += @"\radio\bot";
                        break;

                    case "bridge.wav":
                        basePath += @"\radio\bot";
                        break;

                    case "bunker.wav":
                        basePath += @"\radio\bot";
                        break;

                    case "c.wav":
                        basePath += @"\radio\bot";
                        break;

                    case "camping_hostages.wav":
                        basePath += @"\radio\bot";
                        break;

                    case "clear.wav":
                        outputs.Add(basePath + @"\radio\bot" + @"\" + audioName);
                        outputs.Add(basePath + @"\radio" + @"\" + audioName);
                        add = false;
                        break;

                    case "clear2.wav":
                        basePath += @"\radio\bot";
                        break;

                    case "clear3.wav":
                        basePath += @"\radio\bot";
                        break;

                    case "clear4.wav":
                        basePath += @"\radio\bot";
                        break;

                    case "come_out_and_fight_like_a_man.wav":
                        basePath += @"\radio\bot";
                        break;

                    case "come_out_wherever_you_are.wav":
                        basePath += @"\radio\bot";
                        break;

                    case "come_to_papa.wav":
                        basePath += @"\radio\bot";
                        break;

                    case "computer_room.wav":
                        basePath += @"\radio\bot";
                        break;

                    case "conference_room.wav":
                        basePath += @"\radio\bot";
                        break;

                    case "courtyard.wav":
                        basePath += @"\radio\bot";
                        break;

                    case "cover_me.wav":
                        basePath += @"\radio\bot";
                        break;

                    case "cover_me2.wav":
                        basePath += @"\radio\bot";
                        break;

                    case "crates.wav":
                        basePath += @"\radio\bot";
                        break;

                    case "crawlspace.wav":
                        basePath += @"\radio\bot";
                        break;

                    case "ct_spawn.wav":
                        basePath += @"\radio\bot";
                        break;

                    case "cut_it_out.wav":
                        basePath += @"\radio\bot";
                        break;

                    case "deck.wav":
                        basePath += @"\radio\bot";
                        break;

                    case "defusing.wav":
                        basePath += @"\radio\bot";
                        break;

                    case "defusing_bomb.wav":
                        basePath += @"\radio\bot";
                        break;

                    case "defusing_bomb_now.wav":
                        basePath += @"\radio\bot";
                        break;

                    case "den.wav":
                        basePath += @"\radio\bot";
                        break;

                    case "dont_worry_hell_get_it.wav":
                        basePath += @"\radio\bot";
                        break;

                    case "double_doors.wav":
                        basePath += @"\radio\bot";
                        break;

                    case "downstairs.wav":
                        basePath += @"\radio\bot";
                        break;

                    case "do_not_mess_with_me.wav":
                        basePath += @"\radio\bot";
                        break;

                    case "dropped_him.wav":
                        basePath += @"\radio\bot";
                        break;

                    case "dumpster.wav":
                        basePath += @"\radio\bot";
                        break;

                    case "elevator.wav":
                        basePath += @"\radio\bot";
                        break;

                    case "elevator2.wav":
                        basePath += @"\radio\bot";
                        break;

                    case "enemy_down.wav":
                        basePath += @"\radio\bot";
                        break;

                    case "enemy_down2.wav":
                        basePath += @"\radio\bot";
                        break;

                    case "engaging_enemies.wav":
                        basePath += @"\radio\bot";
                        break;

                    case "entrance.wav":
                        basePath += @"\radio\bot";
                        break;

                    case "entryway.wav":
                        basePath += @"\radio\bot";
                        break;

                    case "family_room.wav":
                        basePath += @"\radio\bot";
                        break;

                    case "far_side.wav":
                        basePath += @"\radio\bot";
                        break;

                    case "fence.wav":
                        basePath += @"\radio\bot";
                        break;

                    case "foyer.wav":
                        basePath += @"\radio\bot";
                        break;

                    case "front.wav":
                        basePath += @"\radio\bot";
                        break;

                    case "front_door.wav":
                        basePath += @"\radio\bot";
                        break;

                    case "front_door2.wav":
                        basePath += @"\radio\bot";
                        break;

                    case "front_hall.wav":
                        basePath += @"\radio\bot";
                        break;

                    case "front_room.wav":
                        basePath += @"\radio\bot";
                        break;

                    case "front_yard.wav":
                        basePath += @"\radio\bot";
                        break;

                    case "garage.wav":
                        basePath += @"\radio\bot";
                        break;

                    case "gate.wav":
                        basePath += @"\radio\bot";
                        break;

                    case "gatehouse.wav":
                        basePath += @"\radio\bot";
                        break;

                    case "going_to_plant_the_bomb_at_b.wav":
                        basePath += @"\radio\bot";
                        break;

                    case "good_idea.wav":
                        basePath += @"\radio\bot";
                        break;

                    case "good_job_team.wav":
                        basePath += @"\radio\bot";
                        break;

                    case "good_one.wav":
                        basePath += @"\radio\bot";
                        break;

                    case "good_one2.wav":
                        basePath += @"\radio\bot";
                        break;

                    case "good_one_sir.wav":
                        basePath += @"\radio\bot";
                        break;

                    case "good_one_sir2.wav":
                        basePath += @"\radio\bot";
                        break;

                    case "good_shot.wav":
                        basePath += @"\radio\bot";
                        break;

                    case "good_shot2.wav":
                        basePath += @"\radio\bot";
                        break;

                    case "good_shot_commander.wav":
                        basePath += @"\radio\bot";
                        break;

                    case "good_shot_commander2.wav":
                        basePath += @"\radio\bot";
                        break;

                    case "got_him.wav":
                        basePath += @"\radio\bot";
                        break;

                    case "got_the_sniper.wav":
                        basePath += @"\radio\bot";
                        break;

                    case "got_the_sniper2.wav":
                        basePath += @"\radio\bot";
                        break;

                    case "great.wav":
                        basePath += @"\radio\bot";
                        break;

                    case "guardhouse.wav":
                        basePath += @"\radio\bot";
                        break;

                    case "guarding_a.wav":
                        basePath += @"\radio\bot";
                        break;

                    case "guarding_b.wav":
                        basePath += @"\radio\bot";
                        break;

                    case "guarding_c.wav":
                        basePath += @"\radio\bot";
                        break;

                    case "guarding_hostages.wav":
                        basePath += @"\radio\bot";
                        break;

                    case "guarding_the_dropped_bomb.wav":
                        basePath += @"\radio\bot";
                        break;

                    case "guarding_the_escape_zone.wav":
                        basePath += @"\radio\bot";
                        break;

                    case "guarding_the_escape_zone2.wav":
                        basePath += @"\radio\bot";
                        break;

                    case "guarding_the_hostages.wav":
                        basePath += @"\radio\bot";
                        break;

                    case "hang_on_im_coming.wav":
                        basePath += @"\radio\bot";
                        break;

                    case "hang_on_i_heard_something.wav":
                        basePath += @"\radio\bot";
                        break;

                    case "heading_to_a.wav":
                        basePath += @"\radio\bot";
                        break;

                    case "heading_to_b.wav":
                        basePath += @"\radio\bot";
                        break;

                    case "heading_to_c.wav":
                        basePath += @"\radio\bot";
                        break;

                    case "heading_to_the_escape_zone.wav":
                        basePath += @"\radio\bot";
                        break;

                    case "heading_to_the_rescue_zone.wav":
                        basePath += @"\radio\bot";
                        break;

                    case "help.wav":
                        basePath += @"\radio\bot";
                        break;

                    case "hes_broken.wav":
                        basePath += @"\radio\bot";
                        break;

                    case "hes_dead.wav":
                        basePath += @"\radio\bot";
                        break;

                    case "hes_done.wav":
                        basePath += @"\radio\bot";
                        break;

                    case "hes_down.wav":
                        basePath += @"\radio\bot";
                        break;

                    case "hes_got_the_bomb.wav":
                        basePath += @"\radio\bot";
                        break;

                    case "hes_got_the_bomb2.wav":
                        basePath += @"\radio\bot";
                        break;

                    case "hes_got_the_package.wav":
                        basePath += @"\radio\bot";
                        break;

                    case "hey.wav":
                        basePath += @"\radio\bot";
                        break;

                    case "hey2.wav":
                        basePath += @"\radio\bot";
                        break;

                    case "he_got_away.wav":
                        basePath += @"\radio\bot";
                        break;

                    case "he_got_away2.wav":
                        basePath += @"\radio\bot";
                        break;

                    case "hold_your_fire.wav":
                        basePath += @"\radio\bot";
                        break;

                    case "hostages.wav":
                        basePath += @"\radio\bot";
                        break;

                    case "hostages2.wav":
                        basePath += @"\radio\bot";
                        break;

                    case "hostages_secure_ready_for_you.wav":
                        basePath += @"\radio\bot";
                        break;

                    case "hostage_down.wav":
                        basePath += @"\radio\bot";
                        break;

                    case "house.wav":
                        basePath += @"\radio\bot";
                        break;

                    case "ill_come_with_you.wav":
                        basePath += @"\radio\bot";
                        break;

                    case "ill_go_too.wav":
                        basePath += @"\radio\bot";
                        break;

                    case "ill_go_with_you.wav":
                        basePath += @"\radio\bot";
                        break;

                    case "im_at_the_escape_zone.wav":
                        basePath += @"\radio\bot";
                        break;

                    case "im_at_the_hostages.wav":
                        basePath += @"\radio\bot";
                        break;

                    case "im_blind.wav":
                        basePath += @"\radio\bot";
                        break;

                    case "im_camping_a.wav":
                        basePath += @"\radio\bot";
                        break;

                    case "im_camping_b.wav":
                        basePath += @"\radio\bot";
                        break;

                    case "im_camping_c.wav":
                        basePath += @"\radio\bot";
                        break;

                    case "im_coming.wav":
                        basePath += @"\radio\bot";
                        break;

                    case "im_going_to_camp.wav":
                        basePath += @"\radio\bot";
                        break;

                    case "im_going_to_camp_a.wav":
                        basePath += @"\radio\bot";
                        break;

                    case "im_going_to_camp_b.wav":
                        basePath += @"\radio\bot";
                        break;

                    case "im_going_to_camp_c.wav":
                        basePath += @"\radio\bot";
                        break;

                    case "im_going_to_camp_the_hostages.wav":
                        basePath += @"\radio\bot";
                        break;

                    case "im_going_to_cover_the_escape_zone.wav":
                        basePath += @"\radio\bot";
                        break;

                    case "im_going_to_guard_bombsite_a.wav":
                        basePath += @"\radio\bot";
                        break;

                    case "im_going_to_guard_bombsite_b.wav":
                        basePath += @"\radio\bot";
                        break;

                    case "im_going_to_guard_bombsite_c.wav":
                        basePath += @"\radio\bot";
                        break;

                    case "im_going_to_guard_the_bomb.wav":
                        basePath += @"\radio\bot";
                        break;

                    case "im_going_to_guard_the_bomb2.wav":
                        basePath += @"\radio\bot";
                        break;

                    case "im_going_to_guard_the_hostages.wav":
                        basePath += @"\radio\bot";
                        break;

                    case "im_going_to_guard_the_hostages2.wav":
                        basePath += @"\radio\bot";
                        break;

                    case "im_going_to_keep_an_eye_on_the_bomb.wav":
                        basePath += @"\radio\bot";
                        break;

                    case "im_going_to_keep_an_eye_on_the_escape.wav":
                        basePath += @"\radio\bot";
                        break;

                    case "im_going_to_keep_an_eye_on_the_rescue.wav":
                        basePath += @"\radio\bot";
                        break;

                    case "im_going_to_wait_here.wav":
                        basePath += @"\radio\bot";
                        break;

                    case "im_going_to_watch_the_bomb.wav":
                        basePath += @"\radio\bot";
                        break;

                    case "im_going_to_watch_the_escape_zone.wav":
                        basePath += @"\radio\bot";
                        break;

                    case "im_going_to_watch_the_rescue_zone.wav":
                        basePath += @"\radio\bot";
                        break;

                    case "im_gonna_go_plant.wav":
                        basePath += @"\radio\bot";
                        break;

                    case "im_gonna_go_plant_the_bomb.wav":
                        basePath += @"\radio\bot";
                        break;

                    case "im_gonna_hang_back.wav":
                        basePath += @"\radio\bot";
                        break;

                    case "im_gonna_plant_the_bomb_at_a.wav":
                        basePath += @"\radio\bot";
                        break;

                    case "im_gonna_plant_the_bomb_at_b.wav":
                        basePath += @"\radio\bot";
                        break;

                    case "im_gonna_plant_the_bomb_at_c.wav":
                        basePath += @"\radio\bot";
                        break;

                    case "im_gonna_plant_the_bomb_at_c2.wav":
                        basePath += @"\radio\bot";
                        break;

                    case "im_in_trouble.wav":
                        basePath += @"\radio\bot";
                        break;

                    case "im_on_your_side.wav":
                        basePath += @"\radio\bot";
                        break;

                    case "im_pinned_down.wav":
                        basePath += @"\radio\bot";
                        break;

                    case "im_waiting_here.wav":
                        basePath += @"\radio\bot";
                        break;

                    case "im_with_the_hostages.wav":
                        basePath += @"\radio\bot";
                        break;

                    case "im_with_the_hostages2.wav":
                        basePath += @"\radio\bot";
                        break;

                    case "im_with_you.wav":
                        basePath += @"\radio\bot";
                        break;

                    case "inside.wav":
                        basePath += @"\radio\bot";
                        break;

                    case "in_combat.wav":
                        basePath += @"\radio\bot";
                        break;

                    case "in_combat2.wav":
                        basePath += @"\radio\bot";
                        break;

                    case "its_all_up_to_you_sir.wav":
                        basePath += @"\radio\bot";
                        break;

                    case "its_a_party.wav":
                        basePath += @"\radio\bot";
                        break;

                    case "ive_been_blinded.wav":
                        basePath += @"\radio\bot";
                        break;

                    case "ive_got_the_bomb.wav":
                        basePath += @"\radio\bot";
                        break;

                    case "ive_got_the_bomb_here.wav":
                        basePath += @"\radio\bot";
                        break;

                    case "ive_got_the_hostages.wav":
                        basePath += @"\radio\bot";
                        break;

                    case "i_am_dangerous.wav":
                        basePath += @"\radio\bot";
                        break;

                    case "i_am_on_fire.wav":
                        basePath += @"\radio\bot";
                        break;

                    case "i_cant_see.wav":
                        basePath += @"\radio\bot";
                        break;

                    case "i_could_use_some_help.wav":
                        basePath += @"\radio\bot";
                        break;

                    case "i_could_use_some_help_over_here.wav":
                        basePath += @"\radio\bot";
                        break;

                    case "i_dont_know_where_he_went.wav":
                        basePath += @"\radio\bot";
                        break;

                    case "i_dont_think_so.wav":
                        basePath += @"\radio\bot";
                        break;

                    case "i_got_a_covered.wav":
                        basePath += @"\radio\bot";
                        break;

                    case "i_got_b_covered.wav":
                        basePath += @"\radio\bot";
                        break;

                    case "i_got_c_covered.wav":
                        basePath += @"\radio\bot";
                        break;

                    case "i_got_more_where_that_came_from.wav":
                        basePath += @"\radio\bot";
                        break;

                    case "i_got_nothing.wav":
                        basePath += @"\radio\bot";
                        break;

                    case "i_got_your_back.wav":
                        basePath += @"\radio\bot";
                        break;

                    case "i_got_your_back2.wav":
                        basePath += @"\radio\bot";
                        break;

                    case "i_have_the_hostages.wav":
                        basePath += @"\radio\bot";
                        break;

                    case "i_heard_something_over_there.wav":
                        basePath += @"\radio\bot";
                        break;

                    case "i_heard_them.wav":
                        basePath += @"\radio\bot";
                        break;

                    case "i_hear_something.wav":
                        basePath += @"\radio\bot";
                        break;

                    case "i_hear_them.wav":
                        basePath += @"\radio\bot";
                        break;

                    case "i_lost_him.wav":
                        basePath += @"\radio\bot";
                        break;

                    case "i_see_our_target.wav":
                        basePath += @"\radio\bot";
                        break;

                    case "i_see_the_bomber.wav":
                        basePath += @"\radio\bot";
                        break;

                    case "i_wasnt_worried_for_a_minute.wav":
                        basePath += @"\radio\bot";
                        break;

                    case "keeping_an_eye_on_the_hostages.wav":
                        basePath += @"\radio\bot";
                        break;

                    case "killed_him.wav":
                        basePath += @"\radio\bot";
                        break;

                    case "kitchen.wav":
                        basePath += @"\radio\bot";
                        break;

                    case "kitchen2.wav":
                        basePath += @"\radio\bot";
                        break;

                    case "ladder.wav":
                        basePath += @"\radio\bot";
                        break;

                    case "lead_on_commander.wav":
                        basePath += @"\radio\bot";
                        break;

                    case "lead_on_sir.wav":
                        basePath += @"\radio\bot";
                        break;

                    case "lead_the_way.wav":
                        basePath += @"\radio\bot";
                        break;

                    case "lead_the_way_commander.wav":
                        basePath += @"\radio\bot";
                        break;

                    case "lead_the_way_sir.wav":
                        basePath += @"\radio\bot";
                        break;

                    case "lets_hold_up_here_for_a_minute.wav":
                        basePath += @"\radio\bot";
                        break;

                    case "lets_wait_here.wav":
                        basePath += @"\radio\bot";
                        break;

                    case "little_office.wav":
                        basePath += @"\radio\bot";
                        break;

                    case "living_room.wav":
                        basePath += @"\radio\bot";
                        break;

                    case "loading_dock.wav":
                        basePath += @"\radio\bot";
                        break;

                    case "lobby.wav":
                        basePath += @"\radio\bot";
                        break;

                    case "loft.wav":
                        basePath += @"\radio\bot";
                        break;

                    case "long_hall.wav":
                        basePath += @"\radio\bot";
                        break;

                    case "look_out_brag.wav":
                        basePath += @"\radio\bot";
                        break;

                    case "made_him_cry.wav":
                        basePath += @"\radio\bot";
                        break;

                    case "main_hall.wav":
                        basePath += @"\radio\bot";
                        break;

                    case "market.wav":
                        basePath += @"\radio\bot";
                        break;

                    case "market2.wav":
                        basePath += @"\radio\bot";
                        break;

                    case "meeting_room.wav":
                        basePath += @"\radio\bot";
                        break;

                    case "me_too.wav":
                        basePath += @"\radio\bot";
                        break;

                    case "middle.wav":
                        basePath += @"\radio\bot";
                        break;

                    case "mines.wav":
                        basePath += @"\radio\bot";
                        break;

                    case "my_eyes.wav":
                        basePath += @"\radio\bot";
                        break;

                    case "naa.wav":
                        basePath += @"\radio\bot";
                        break;

                    case "need_help.wav":
                        basePath += @"\radio\bot";
                        break;

                    case "need_help2.wav":
                        basePath += @"\radio\bot";
                        break;

                    case "negative.wav":
                        outputs.Add(basePath + @"\radio\bot" + @"\" + audioName);
                        outputs.Add(basePath + @"\radio" + @"\" + audioName);
                        add = false;
                        break;

                    case "negative2.wav":
                        basePath += @"\radio\bot";
                        break;

                    case "neutralized.wav":
                        basePath += @"\radio\bot";
                        break;

                    case "nice.wav":
                        basePath += @"\radio\bot";
                        break;

                    case "nice2.wav":
                        basePath += @"\radio\bot";
                        break;

                    case "nice_one_commander.wav":
                        basePath += @"\radio\bot";
                        break;

                    case "nice_one_sir.wav":
                        basePath += @"\radio\bot";
                        break;

                    case "nice_shot.wav":
                        basePath += @"\radio\bot";
                        break;

                    case "nice_shot2.wav":
                        basePath += @"\radio\bot";
                        break;

                    case "nice_shot_commander.wav":
                        basePath += @"\radio\bot";
                        break;

                    case "nice_shot_commander2.wav":
                        basePath += @"\radio\bot";
                        break;

                    case "nice_shot_sir.wav":
                        basePath += @"\radio\bot";
                        break;

                    case "nice_work_team.wav":
                        basePath += @"\radio\bot";
                        break;

                    case "nnno_sir.wav":
                        basePath += @"\radio\bot";
                        break;

                    case "no.wav":
                        basePath += @"\radio\bot";
                        break;

                    case "no2.wav":
                        basePath += @"\radio\bot";
                        break;

                    case "noo.wav":
                        basePath += @"\radio\bot";
                        break;

                    case "nothing.wav":
                        basePath += @"\radio\bot";
                        break;

                    case "nothing_happening_over_here.wav":
                        basePath += @"\radio\bot";
                        break;

                    case "nothing_here.wav":
                        basePath += @"\radio\bot";
                        break;

                    case "nothing_moving_over_here.wav":
                        basePath += @"\radio\bot";
                        break;

                    case "no_sir.wav":
                        basePath += @"\radio\bot";
                        break;

                    case "no_thanks.wav":
                        basePath += @"\radio\bot";
                        break;

                    case "office.wav":
                        basePath += @"\radio\bot";
                        break;

                    case "oh.wav":
                        basePath += @"\radio\bot";
                        break;

                    case "oh_boy.wav":
                        basePath += @"\radio\bot";
                        break;

                    case "oh_boy2.wav":
                        basePath += @"\radio\bot";
                        break;

                    case "oh_man.wav":
                        basePath += @"\radio\bot";
                        break;

                    case "oh_my_god.wav":
                        basePath += @"\radio\bot";
                        break;

                    case "oh_no.wav":
                        basePath += @"\radio\bot";
                        break;

                    case "oh_no_sad.wav":
                        basePath += @"\radio\bot";
                        break;

                    case "oh_yea.wav":
                        basePath += @"\radio\bot";
                        break;

                    case "oh_yea2.wav":
                        basePath += @"\radio\bot";
                        break;

                    case "ok.wav":
                        basePath += @"\radio\bot";
                        break;

                    case "ok2.wav":
                        basePath += @"\radio\bot";
                        break;

                    case "ok_cmdr_lets_go.wav":
                        basePath += @"\radio\bot";
                        break;

                    case "ok_sir_lets_go.wav":
                        basePath += @"\radio\bot";
                        break;

                    case "old_mines.wav":
                        basePath += @"\radio\bot";
                        break;

                    case "one_guy.wav":
                        basePath += @"\radio\bot";
                        break;

                    case "one_guy_left.wav":
                        basePath += @"\radio\bot";
                        break;

                    case "on_my_way.wav":
                        basePath += @"\radio\bot";
                        break;

                    case "on_my_way2.wav":
                        basePath += @"\radio\bot";
                        break;

                    case "ouch.wav":
                        basePath += @"\radio\bot";
                        break;

                    case "outside.wav":
                        basePath += @"\radio\bot";
                        break;

                    case "overpass.wav":
                        basePath += @"\radio\bot";
                        break;

                    case "ow.wav":
                        basePath += @"\radio\bot";
                        break;

                    case "owned.wav":
                        basePath += @"\radio\bot";
                        break;

                    case "ow_its_me.wav":
                        basePath += @"\radio\bot";
                        break;

                    case "pain10.wav":
                        basePath += @"\radio\bot";
                        break;

                    case "pain2.wav":
                        basePath += @"\radio\bot";
                        break;

                    case "pain4.wav":
                        basePath += @"\radio\bot";
                        break;

                    case "pain5.wav":
                        basePath += @"\radio\bot";
                        break;

                    case "pain8.wav":
                        basePath += @"\radio\bot";
                        break;

                    case "pain9.wav":
                        basePath += @"\radio\bot";
                        break;

                    case "patio.wav":
                        basePath += @"\radio\bot";
                        break;

                    case "planting.wav":
                        basePath += @"\radio\bot";
                        break;

                    case "planting_at_a.wav":
                        basePath += @"\radio\bot";
                        break;

                    case "planting_at_b.wav":
                        basePath += @"\radio\bot";
                        break;

                    case "planting_at_c.wav":
                        basePath += @"\radio\bot";
                        break;

                    case "planting_the_bomb.wav":
                        basePath += @"\radio\bot";
                        break;

                    case "please_defuse_the_bomb_sir.wav":
                        basePath += @"\radio\bot";
                        break;

                    case "porch.wav":
                        basePath += @"\radio\bot";
                        break;

                    case "projector_room.wav":
                        basePath += @"\radio\bot";
                        break;

                    case "ramp.wav":
                        basePath += @"\radio\bot";
                        break;

                    case "ramp2.wav":
                        basePath += @"\radio\bot";
                        break;

                    case "rear.wav":
                        basePath += @"\radio\bot";
                        break;

                    case "reporting_in.wav":
                        basePath += @"\radio\bot";
                        break;

                    case "report_in_team.wav":
                        basePath += @"\radio\bot";
                        break;

                    case "rescue_zone.wav":
                        basePath += @"\radio\bot";
                        break;

                    case "rescue_zone2.wav":
                        basePath += @"\radio\bot";
                        break;

                    case "rescuing_hostages.wav":
                        basePath += @"\radio\bot";
                        break;

                    case "returning_fire.wav":
                        basePath += @"\radio\bot";
                        break;

                    case "roger.wav":
                        outputs.Add(basePath + @"\radio\bot" + @"\" + audioName);
                        outputs.Add(basePath + @"\radio" + @"\" + audioName);
                        add = false;
                        break;

                    case "roger_that.wav":
                        basePath += @"\radio\bot";
                        break;

                    case "roof.wav":
                        basePath += @"\radio\bot";
                        break;

                    case "ruined_his_day.wav":
                        basePath += @"\radio\bot";
                        break;

                    case "security_doors.wav":
                        basePath += @"\radio\bot";
                        break;

                    case "sewers.wav":
                        basePath += @"\radio\bot";
                        break;

                    case "sewers2.wav":
                        basePath += @"\radio\bot";
                        break;

                    case "side.wav":
                        basePath += @"\radio\bot";
                        break;

                    case "side_alley.wav":
                        basePath += @"\radio\bot";
                        break;

                    case "side_door.wav":
                        basePath += @"\radio\bot";
                        break;

                    case "side_hall.wav":
                        basePath += @"\radio\bot";
                        break;

                    case "side_room.wav":
                        basePath += @"\radio\bot";
                        break;

                    case "side_yard.wav":
                        basePath += @"\radio\bot";
                        break;

                    case "sir_defuse_the_bomb.wav":
                        basePath += @"\radio\bot";
                        break;

                    case "sniper.wav":
                        basePath += @"\radio\bot";
                        break;

                    case "sniper2.wav":
                        basePath += @"\radio\bot";
                        break;

                    case "sniper_down.wav":
                        basePath += @"\radio\bot";
                        break;

                    case "sounds_like_a_plan.wav":
                        basePath += @"\radio\bot";
                        break;

                    case "spotted_the_delivery_boy.wav":
                        basePath += @"\radio\bot";
                        break;

                    case "stairs.wav":
                        basePath += @"\radio\bot";
                        break;

                    case "stairwell.wav":
                        basePath += @"\radio\bot";
                        break;

                    case "stop_it.wav":
                        basePath += @"\radio\bot";
                        break;

                    case "storage_room.wav":
                        basePath += @"\radio\bot";
                        break;

                    case "tag_them_and_bag_them.wav":
                        basePath += @"\radio\bot";
                        break;

                    case "taking_fire_need_assistance2.wav":
                        basePath += @"\radio\bot";
                        break;

                    case "taking_the_bomb_to_a.wav":
                        basePath += @"\radio\bot";
                        break;

                    case "taking_the_bomb_to_b.wav":
                        basePath += @"\radio\bot";
                        break;

                    case "taking_the_bomb_to_c.wav":
                        basePath += @"\radio\bot";
                        break;

                    case "taking_the_hostages_to_safety.wav":
                        basePath += @"\radio\bot";
                        break;

                    case "talking_to_hostages.wav":
                        basePath += @"\radio\bot";
                        break;

                    case "target_acquired.wav":
                        basePath += @"\radio\bot";
                        break;

                    case "target_spotted.wav":
                        basePath += @"\radio\bot";
                        break;

                    case "thats_not_good.wav":
                        basePath += @"\radio\bot";
                        break;

                    case "thats_right.wav":
                        basePath += @"\radio\bot";
                        break;

                    case "thats_the_way_this_is_done.wav":
                        basePath += @"\radio\bot";
                        break;

                    case "that_was_a_close_one.wav":
                        basePath += @"\radio\bot";
                        break;

                    case "that_was_it.wav":
                        basePath += @"\radio\bot";
                        break;

                    case "that_was_the_last_guy.wav":
                        basePath += @"\radio\bot";
                        break;

                    case "that_was_the_last_one.wav":
                        basePath += @"\radio\bot";
                        break;

                    case "theres_nobody_home.wav":
                        basePath += @"\radio\bot";
                        break;

                    case "theres_not_much_time_left.wav":
                        basePath += @"\radio\bot";
                        break;

                    case "theres_one_left.wav":
                        basePath += @"\radio\bot";
                        break;

                    case "theres_the_bomb.wav":
                        basePath += @"\radio\bot";
                        break;

                    case "theres_the_bomb2.wav":
                        basePath += @"\radio\bot";
                        break;

                    case "theres_the_bomber.wav":
                        basePath += @"\radio\bot";
                        break;

                    case "theres_too_many.wav":
                        basePath += @"\radio\bot";
                        break;

                    case "theres_too_many_of_them.wav":
                        basePath += @"\radio\bot";
                        break;

                    case "theyre_all_over_the_place2.wav":
                        basePath += @"\radio\bot";
                        break;

                    case "theyre_everywhere2.wav":
                        basePath += @"\radio\bot";
                        break;

                    case "theyre_rescuing_the_hostages.wav":
                        basePath += @"\radio\bot";
                        break;

                    case "theyre_taking_the_hostages.wav":
                        basePath += @"\radio\bot";
                        break;

                    case "theyre_with_the_hostages.wav":
                        basePath += @"\radio\bot";
                        break;

                    case "theyve_got_the_hostages.wav":
                        basePath += @"\radio\bot";
                        break;

                    case "they_dropped_the_bomb.wav":
                        basePath += @"\radio\bot";
                        break;

                    case "they_got_me_pinned_down_here.wav":
                        basePath += @"\radio\bot";
                        break;

                    case "they_got_the_bomb.wav":
                        basePath += @"\radio\bot";
                        break;

                    case "they_never_knew_what_hit_them.wav":
                        basePath += @"\radio\bot";
                        break;

                    case "they_picked_up_the_bomb.wav":
                        basePath += @"\radio\bot";
                        break;

                    case "they_took_the_bomb.wav":
                        basePath += @"\radio\bot";
                        break;

                    case "they_took_the_bomb2.wav":
                        basePath += @"\radio\bot";
                        break;

                    case "they_took_the_hostages.wav":
                        basePath += @"\radio\bot";
                        break;

                    case "they_will_not_escape.wav":
                        basePath += @"\radio\bot";
                        break;

                    case "they_wont_get_away.wav":
                        basePath += @"\radio\bot";
                        break;

                    case "they_wont_get_away2.wav":
                        basePath += @"\radio\bot";
                        break;

                    case "the_actions_hot_here.wav":
                        basePath += @"\radio\bot";
                        break;

                    case "the_bombs_at_a.wav":
                        basePath += @"\radio\bot";
                        break;

                    case "the_bombs_at_b.wav":
                        basePath += @"\radio\bot";
                        break;

                    case "the_bombs_at_c.wav":
                        basePath += @"\radio\bot";
                        break;

                    case "the_bombs_here.wav":
                        basePath += @"\radio\bot";
                        break;

                    case "the_bombs_here_on_the_ground.wav":
                        basePath += @"\radio\bot";
                        break;

                    case "the_bombs_ticking_at_a.wav":
                        basePath += @"\radio\bot";
                        break;

                    case "the_bombs_ticking_at_b.wav":
                        basePath += @"\radio\bot";
                        break;

                    case "the_bombs_ticking_at_c.wav":
                        basePath += @"\radio\bot";
                        break;

                    case "the_bomb_is_down.wav":
                        basePath += @"\radio\bot";
                        break;

                    case "the_bomb_is_on_the_ground.wav":
                        basePath += @"\radio\bot";
                        break;

                    case "the_commander_is_down.wav":
                        basePath += @"\radio\bot";
                        break;

                    case "the_commander_is_down_repeat.wav":
                        basePath += @"\radio\bot";
                        break;

                    case "the_hostages_are_eager.wav":
                        basePath += @"\radio\bot";
                        break;

                    case "the_hostages_are_gone.wav":
                        basePath += @"\radio\bot";
                        break;

                    case "the_hostages_are_ready.wav":
                        basePath += @"\radio\bot";
                        break;

                    case "the_hostages_are_waiting.wav":
                        basePath += @"\radio\bot";
                        break;

                    case "the_hostages_are_with_me.wav":
                        basePath += @"\radio\bot";
                        break;

                    case "the_sniper_is_dead.wav":
                        basePath += @"\radio\bot";
                        break;

                    case "this_is_my_house.wav":
                        basePath += @"\radio\bot";
                        break;

                    case "three.wav":
                        basePath += @"\radio\bot";
                        break;

                    case "three_left.wav":
                        basePath += @"\radio\bot";
                        break;

                    case "three_of_them.wav":
                        basePath += @"\radio\bot";
                        break;

                    case "three_to_go.wav":
                        basePath += @"\radio\bot";
                        break;

                    case "three_to_go2.wav":
                        basePath += @"\radio\bot";
                        break;

                    case "time_is_running_out.wav":
                        basePath += @"\radio\bot";
                        break;

                    case "time_is_running_out2.wav":
                        basePath += @"\radio\bot";
                        break;

                    case "took_him_down.wav":
                        basePath += @"\radio\bot";
                        break;

                    case "took_him_out.wav":
                        basePath += @"\radio\bot";
                        break;

                    case "took_him_out2.wav":
                        basePath += @"\radio\bot";
                        break;

                    case "took_out_the_sniper.wav":
                        basePath += @"\radio\bot";
                        break;

                    case "too_many2.wav":
                        basePath += @"\radio\bot";
                        break;

                    case "tower.wav":
                        basePath += @"\radio\bot";
                        break;

                    case "truck.wav":
                        basePath += @"\radio\bot";
                        break;

                    case "tunnel.wav":
                        basePath += @"\radio\bot";
                        break;

                    case "tunnel2.wav":
                        basePath += @"\radio\bot";
                        break;

                    case "two_enemies_left.wav":
                        basePath += @"\radio\bot";
                        break;

                    case "two_of_them.wav":
                        basePath += @"\radio\bot";
                        break;

                    case "two_to_go.wav":
                        basePath += @"\radio\bot";
                        break;

                    case "t_spawn.wav":
                        basePath += @"\radio\bot";
                        break;

                    case "uh_oh.wav":
                        basePath += @"\radio\bot";
                        break;

                    case "uh_sir_the_bomb.wav":
                        basePath += @"\radio\bot";
                        break;

                    case "underground.wav":
                        basePath += @"\radio\bot";
                        break;

                    case "underpass.wav":
                        basePath += @"\radio\bot";
                        break;

                    case "upstairs.wav":
                        basePath += @"\radio\bot";
                        break;

                    case "vault.wav":
                        basePath += @"\radio\bot";
                        break;

                    case "vending_machines.wav":
                        basePath += @"\radio\bot";
                        break;

                    case "vending_machines2.wav":
                        basePath += @"\radio\bot";
                        break;

                    case "ventilation_system.wav":
                        basePath += @"\radio\bot";
                        break;

                    case "vents.wav":
                        basePath += @"\radio\bot";
                        break;

                    case "vents2.wav":
                        basePath += @"\radio\bot";
                        break;

                    case "very_nice.wav":
                        basePath += @"\radio\bot";
                        break;

                    case "villiage.wav":
                        basePath += @"\radio\bot";
                        break;

                    case "wall.wav":
                        basePath += @"\radio\bot";
                        break;

                    case "wasted_him.wav":
                        basePath += @"\radio\bot";
                        break;

                    case "watching_the_escape_route.wav":
                        basePath += @"\radio\bot";
                        break;

                    case "watching_the_escape_zone.wav":
                        basePath += @"\radio\bot";
                        break;

                    case "watching_the_hostages.wav":
                        basePath += @"\radio\bot";
                        break;

                    case "watch_it_theres_a_sniper.wav":
                        basePath += @"\radio\bot";
                        break;

                    case "water.wav":
                        basePath += @"\radio\bot";
                        break;

                    case "way_to_be_team.wav":
                        basePath += @"\radio\bot";
                        break;

                    case "well_cover_you_while_you_defuse.wav":
                        basePath += @"\radio\bot";
                        break;

                    case "well_cover_you_you_defuse.wav":
                        basePath += @"\radio\bot";
                        break;

                    case "well_done.wav":
                        basePath += @"\radio\bot";
                        break;

                    case "weve_got_the_situation.wav":
                        basePath += @"\radio\bot";
                        break;

                    case "weve_lost_the_commander.wav":
                        basePath += @"\radio\bot";
                        break;

                    case "we_gotta_find_that_bomb.wav":
                        basePath += @"\radio\bot";
                        break;

                    case "we_need_you_to_defuse_that_bomb_sir.wav":
                        basePath += @"\radio\bot";
                        break;

                    case "we_owned_them.wav":
                        basePath += @"\radio\bot";
                        break;

                    case "what_are_you_doing.wav":
                        basePath += @"\radio\bot";
                        break;

                    case "what_happened.wav":
                        basePath += @"\radio\bot";
                        break;

                    case "what_have_you_done.wav":
                        basePath += @"\radio\bot";
                        break;

                    case "wheres_the_bomb.wav":
                        basePath += @"\radio\bot";
                        break;

                    case "wheres_the_bomb2.wav":
                        basePath += @"\radio\bot";
                        break;

                    case "wheres_the_bomb3.wav":
                        basePath += @"\radio\bot";
                        break;

                    case "where_are_they.wav":
                        basePath += @"\radio\bot";
                        break;

                    case "where_are_the_hostages.wav":
                        basePath += @"\radio\bot";
                        break;

                    case "where_are_you_hiding.wav":
                        basePath += @"\radio\bot";
                        break;

                    case "where_could_they_be.wav":
                        basePath += @"\radio\bot";
                        break;

                    case "where_is_it.wav":
                        basePath += @"\radio\bot";
                        break;

                    case "whew_that_was_close.wav":
                        basePath += @"\radio\bot";
                        break;

                    case "whoa.wav":
                        basePath += @"\radio\bot";
                        break;

                    case "whoo.wav":
                        basePath += @"\radio\bot";
                        break;

                    case "whoo2.wav":
                        basePath += @"\radio\bot";
                        break;

                    case "whos_the_man.wav":
                        basePath += @"\radio\bot";
                        break;

                    case "who_wants_some_more.wav":
                        basePath += @"\radio\bot";
                        break;

                    case "window.wav":
                        basePath += @"\radio\bot";
                        break;

                    case "windows.wav":
                        basePath += @"\radio\bot";
                        break;

                    case "wine_cellar.wav":
                        basePath += @"\radio\bot";
                        break;

                    case "yea_baby.wav":
                        basePath += @"\radio\bot";
                        break;

                    case "yea_ok.wav":
                        basePath += @"\radio\bot";
                        break;

                    case "yesss.wav":
                        basePath += @"\radio\bot";
                        break;

                    case "yesss2.wav":
                        basePath += @"\radio\bot";
                        break;

                    case "yikes.wav":
                        basePath += @"\radio\bot";
                        break;

                    case "you_heard_the_man_lets_go.wav":
                        basePath += @"\radio\bot";
                        break;


                    /* Ambience */

                    case "3dmbridge.wav":
                        basePath += @"\ambience";
                        break;

                    case "3dmeagle.wav":
                        basePath += @"\ambience";
                        break;

                    case "3dmstart.wav":
                        basePath += @"\ambience";
                        break;

                    case "3dmthrill.wav":
                        basePath += @"\ambience";
                        break;

                    case "alarm1.wav":
                        basePath += @"\ambience";
                        break;

                    case "arabmusic.wav":
                        basePath += @"\ambience";
                        break;

                    case "Birds1.wav":
                        basePath += @"\ambience";
                        break;

                    case "Birds2.wav":
                        basePath += @"\ambience";
                        break;

                    case "Birds3.wav":
                        basePath += @"\ambience";
                        break;

                    case "Birds4.wav":
                        basePath += @"\ambience";
                        break;

                    case "Birds5.wav":
                        basePath += @"\ambience";
                        break;

                    case "Birds6.wav":
                        basePath += @"\ambience";
                        break;

                    case "Birds7.wav":
                        basePath += @"\ambience";
                        break;

                    case "Birds8.wav":
                        basePath += @"\ambience";
                        break;

                    case "Birds9.wav":
                        basePath += @"\ambience";
                        break;

                    case "car1.wav":
                        basePath += @"\ambience";
                        break;

                    case "car2.wav":
                        basePath += @"\ambience";
                        break;

                    case "cat1.wav":
                        basePath += @"\ambience";
                        break;

                    case "chimes.wav":
                        basePath += @"\ambience";
                        break;

                    case "cicada3.wav":
                        basePath += @"\ambience";
                        break;

                    case "copter.wav":
                        basePath += @"\ambience";
                        break;

                    case "crow.wav":
                        basePath += @"\ambience";
                        break;

                    case "dog1.wav":
                        basePath += @"\ambience";
                        break;

                    case "dog2.wav":
                        basePath += @"\ambience";
                        break;

                    case "dog3.wav":
                        basePath += @"\ambience";
                        break;

                    case "dog4.wav":
                        basePath += @"\ambience";
                        break;

                    case "dog5.wav":
                        basePath += @"\ambience";
                        break;

                    case "dog6.wav":
                        basePath += @"\ambience";
                        break;

                    case "dog7.wav":
                        basePath += @"\ambience";
                        break;

                    case "doorbell.wav":
                        basePath += @"\ambience";
                        break;

                    case "fallscream.wav":
                        basePath += @"\ambience";
                        break;

                    case "guit1.wav":
                        basePath += @"\ambience";
                        break;

                    case "kajika.wav":
                        basePath += @"\ambience";
                        break;

                    case "lv1.wav":
                        basePath += @"\ambience";
                        break;

                    case "lv2.wav":
                        basePath += @"\ambience";
                        break;

                    case "lv3.wav":
                        basePath += @"\ambience";
                        break;

                    case "lv4.wav":
                        basePath += @"\ambience";
                        break;

                    case "lv5.wav":
                        basePath += @"\ambience";
                        break;

                    case "lv6.wav":
                        basePath += @"\ambience";
                        break;

                    case "lv_elvis.wav":
                        basePath += @"\ambience";
                        break;

                    case "lv_fruit1.wav":
                        basePath += @"\ambience";
                        break;

                    case "lv_fruit2.wav":
                        basePath += @"\ambience";
                        break;

                    case "lv_fruitwin.wav":
                        basePath += @"\ambience";
                        break;

                    case "lv_jubilee.wav":
                        basePath += @"\ambience";
                        break;

                    case "lv_neon.wav":
                        basePath += @"\ambience";
                        break;

                    case "Opera.wav":
                        basePath += @"\ambience";
                        break;

                    case "rain.wav":
                        basePath += @"\ambience";
                        break;

                    case "ratchant.wav":
                        basePath += @"\ambience";
                        break;

                    case "rd_shipshorn.wav":
                        basePath += @"\ambience";
                        break;

                    case "rd_waves.wav":
                        basePath += @"\ambience";
                        break;

                    case "sparrow.wav":
                        basePath += @"\ambience";
                        break;

                    case "thunder_clap.wav":
                        basePath += @"\ambience";
                        break;

                    case "waterrun.wav":
                        basePath += @"\ambience";
                        break;

                    case "wolfhowl01.wav":
                        basePath += @"\ambience";
                        break;

                    case "wolfhowl02.wav":
                        basePath += @"\ambience";
                        break;

                    /* de_torn */

                    case "tk_steam.wav":
                        basePath += @"\de_torn";
                        break;

                    case "tk_windStreet.wav":
                        basePath += @"\de_torn";
                        break;

                    case "torn_AK-47.wav":
                        basePath += @"\de_torn";
                        break;

                    case "torn_ambience.wav":
                        basePath += @"\de_torn";
                        break;

                    case "torn_Bomb1.wav":
                        basePath += @"\de_torn";
                        break;

                    case "torn_Bomb2.wav":
                        basePath += @"\de_torn";
                        break;

                    case "torn_MGun1.wav":
                        basePath += @"\de_torn";
                        break;

                    case "torn_Templewind.wav":
                        basePath += @"\de_torn";
                        break;

                    case "torn_thndrstrike.wav":
                        basePath += @"\de_torn";
                        break;

                    case "torn_water1.wav":
                        basePath += @"\de_torn";
                        break;

                    case "torn_water2.wav":
                        basePath += @"\de_torn";
                        break;

                    /*Events*/

                    case "enemy_died.wav":
                        basePath += @"\events";
                        break;

                    case "friend_died.wav":
                        basePath += @"\events";
                        break;

                    case "task_complete.wav":
                        basePath += @"\events";
                        break;

                    case "tutor_msg.wav":
                        basePath += @"\events";
                        break;

                    /*Hostage*/

                    case "hos1.wav":
                        basePath += @"\hostage";
                        break;

                    case "hos2.wav":
                        basePath += @"\hostage";
                        break;

                    case "hos3.wav":
                        basePath += @"\hostage";
                        break;

                    case "hos4.wav":
                        basePath += @"\hostage";
                        break;

                    case "hos5.wav":
                        basePath += @"\hostage";
                        break;

                    /*Items*/

                    case "equip_nvg.wav":
                        basePath += @"\items";
                        break;

                    case "kevlar.wav":
                        basePath += @"\items";
                        break;

                    case "nvg_off.wav":
                        basePath += @"\items";
                        break;

                    case "nvg_on.wav":
                        basePath += @"\items";
                        break;

                    case "tr_kevlar.wav":
                        basePath += @"\items";
                        break;

                    /*Misc*/

                    case "cow.wav":
                        outputs.Add(basePath + @"\misc" + @"\" + audioName);
                        outputs.Add(basePath + @"\ambience" + @"\" + audioName);
                        add = false;
                        break;

                    case "killChicken.wav":
                        basePath += @"\misc";
                        break;

                    case "plane_drone.wav":
                        basePath += @"\misc";
                        break;

                    case "sheep.wav":
                        outputs.Add(basePath + @"\misc" + @"\" + audioName);
                        outputs.Add(basePath + @"\ambience" + @"\" + audioName);
                        add = false;
                        break;

                    case "talk.wav":
                        basePath += @"\misc";
                        break;

                    /*Plats*/

                    case "vehicle1.wav":
                        basePath += @"\plats";
                        break;

                    case "vehicle2.wav":
                        basePath += @"\plats";
                        break;

                    case "vehicle3.wav":
                        basePath += @"\plats";
                        break;

                    case "vehicle4.wav":
                        basePath += @"\plats";
                        break;

                    case "vehicle6.wav":
                        basePath += @"\plats";
                        break;

                    case "vehicle7.wav":
                        basePath += @"\plats";
                        break;

                    case "vehicle_brake1.wav":
                        basePath += @"\plats";
                        break;

                    case "vehicle_ignition.wav":
                        basePath += @"\plats";
                        break;

                    case "vehicle_start1.wav":
                        basePath += @"\plats";
                        break;

                    /* Player */

                    case "bhit_flesh-1.wav":
                        basePath += @"\player";
                        break;

                    case "bhit_flesh-2.wav":
                        basePath += @"\player";
                        break;

                    case "bhit_flesh-3.wav":
                        basePath += @"\player";
                        break;

                    case "bhit_helmet-1.wav":
                        basePath += @"\player";
                        break;

                    case "bhit_kevlar-1.wav":
                        basePath += @"\player";
                        break;

                    case "breathe1.wav":
                        basePath += @"\player";
                        break;

                    case "breathe2.wav":
                        basePath += @"\player";
                        break;

                    case "death6.wav":
                        basePath += @"\player";
                        break;

                    case "die1.wav":
                        basePath += @"\player";
                        break;

                    case "die2.wav":
                        basePath += @"\player";
                        break;

                    case "die3.wav":
                        basePath += @"\player";
                        break;

                    case "headshot1.wav":
                        basePath += @"\player";
                        break;

                    case "headshot2.wav":
                        outputs.Add(basePath + @"\player" + @"\" + audioName);
                        outputs.Add(basePath + @"\weapons" + @"\" + audioName);
                        add = false;
                        break;

                    case "headshot3.wav":
                        basePath += @"\player";
                        break;

                    case "pl_die1.wav":
                        basePath += @"\player";
                        break;

                    case "pl_dirt1.wav":
                        basePath += @"\player";
                        break;

                    case "pl_dirt2.wav":
                        basePath += @"\player";
                        break;

                    case "pl_dirt3.wav":
                        basePath += @"\player";
                        break;

                    case "pl_dirt4.wav":
                        basePath += @"\player";
                        break;

                    case "pl_duct1.wav":
                        basePath += @"\player";
                        break;

                    case "pl_duct2.wav":
                        basePath += @"\player";
                        break;

                    case "pl_duct3.wav":
                        basePath += @"\player";
                        break;

                    case "pl_duct4.wav":
                        basePath += @"\player";
                        break;

                    case "pl_fallpain1.wav":
                        basePath += @"\player";
                        break;

                    case "pl_fallpain2.wav":
                        basePath += @"\player";
                        break;

                    case "pl_fallpain3.wav":
                        basePath += @"\player";
                        break;

                    case "pl_grate1.wav":
                        basePath += @"\player";
                        break;

                    case "pl_grate2.wav":
                        basePath += @"\player";
                        break;

                    case "pl_grate3.wav":
                        basePath += @"\player";
                        break;

                    case "pl_grate4.wav":
                        basePath += @"\player";
                        break;

                    case "pl_jump1.wav":
                        basePath += @"\player";
                        break;

                    case "pl_jump2.wav":
                        basePath += @"\player";
                        break;

                    case "pl_ladder1.wav":
                        basePath += @"\player";
                        break;

                    case "pl_ladder2.wav":
                        basePath += @"\player";
                        break;

                    case "pl_ladder3.wav":
                        basePath += @"\player";
                        break;

                    case "pl_ladder4.wav":
                        basePath += @"\player";
                        break;

                    case "pl_metal1.wav":
                        basePath += @"\player";
                        break;

                    case "pl_metal2.wav":
                        basePath += @"\player";
                        break;

                    case "pl_metal3.wav":
                        basePath += @"\player";
                        break;

                    case "pl_metal4.wav":
                        basePath += @"\player";
                        break;

                    case "pl_pain2.wav":
                        basePath += @"\player";
                        break;

                    case "pl_pain4.wav":
                        basePath += @"\player";
                        break;

                    case "pl_pain5.wav":
                        basePath += @"\player";
                        break;

                    case "pl_pain6.wav":
                        basePath += @"\player";
                        break;

                    case "pl_pain7.wav":
                        basePath += @"\player";
                        break;

                    case "pl_shell1.wav":
                        basePath += @"\player";
                        break;

                    case "pl_shot1.wav":
                        basePath += @"\player";
                        break;

                    case "pl_slosh1.wav":
                        basePath += @"\player";
                        break;

                    case "pl_slosh2.wav":
                        basePath += @"\player";
                        break;

                    case "pl_slosh3.wav":
                        basePath += @"\player";
                        break;

                    case "pl_slosh4.wav":
                        basePath += @"\player";
                        break;

                    case "pl_snow1.wav":
                        basePath += @"\player";
                        break;

                    case "pl_snow2.wav":
                        basePath += @"\player";
                        break;

                    case "pl_snow3.wav":
                        basePath += @"\player";
                        break;

                    case "pl_snow4.wav":
                        basePath += @"\player";
                        break;

                    case "pl_snow5.wav":
                        basePath += @"\player";
                        break;

                    case "pl_snow6.wav":
                        basePath += @"\player";
                        break;

                    case "pl_step1.wav":
                        basePath += @"\player";
                        break;

                    case "pl_step2.wav":
                        basePath += @"\player";
                        break;

                    case "pl_step3.wav":
                        basePath += @"\player";
                        break;

                    case "pl_step4.wav":
                        basePath += @"\player";
                        break;

                    case "pl_swim1.wav":
                        basePath += @"\player";
                        break;

                    case "pl_swim2.wav":
                        basePath += @"\player";
                        break;

                    case "pl_swim3.wav":
                        basePath += @"\player";
                        break;

                    case "pl_swim4.wav":
                        basePath += @"\player";
                        break;

                    case "pl_tile1.wav":
                        basePath += @"\player";
                        break;

                    case "pl_tile2.wav":
                        basePath += @"\player";
                        break;

                    case "pl_tile3.wav":
                        basePath += @"\player";
                        break;

                    case "pl_tile4.wav":
                        basePath += @"\player";
                        break;

                    case "pl_tile5.wav":
                        basePath += @"\player";
                        break;

                    case "pl_wade1.wav":
                        basePath += @"\player";
                        break;

                    case "pl_wade2.wav":
                        basePath += @"\player";
                        break;

                    case "pl_wade3.wav":
                        basePath += @"\player";
                        break;

                    case "pl_wade4.wav":
                        basePath += @"\player";
                        break;

                    case "sprayer.wav":
                        basePath += @"\player";
                        break;

                    /*Radio*/

                    case "blow.wav":
                        basePath += @"\radio";
                        break;

                    case "bombdef.wav":
                        basePath += @"\radio";
                        break;

                    case "bombpl.wav":
                        basePath += @"\radio";
                        break;

                    case "circleback.wav":
                        basePath += @"\radio";
                        break;

                    case "com_followcom.wav":
                        basePath += @"\radio";
                        break;

                    case "com_getinpos.wav":
                        basePath += @"\radio";
                        break;

                    case "com_go.wav":
                        basePath += @"\radio";
                        break;

                    case "com_reportin.wav":
                        basePath += @"\radio";
                        break;

                    case "ctwin.wav":
                        basePath += @"\radio";
                        break;

                    case "ct_affirm.wav":
                        basePath += @"\radio";
                        break;

                    case "ct_backup.wav":
                        basePath += @"\radio";
                        break;

                    case "ct_coverme.wav":
                        basePath += @"\radio";
                        break;

                    case "ct_enemys.wav":
                        basePath += @"\radio";
                        break;

                    case "ct_fireinhole.wav":
                        basePath += @"\radio";
                        break;

                    case "ct_imhit.wav":
                        basePath += @"\radio";
                        break;

                    case "ct_inpos.wav":
                        basePath += @"\radio";
                        break;

                    case "ct_point.wav":
                        basePath += @"\radio";
                        break;

                    case "ct_reportingin.wav":
                        basePath += @"\radio";
                        break;

                    case "elim.wav":
                        basePath += @"\radio";
                        break;

                    case "enemydown.wav":
                        basePath += @"\radio";
                        break;

                    case "fallback.wav":
                        basePath += @"\radio";
                        break;

                    case "fireassis.wav":
                        basePath += @"\radio";
                        break;

                    case "flankthem.wav":
                        basePath += @"\radio";
                        break;

                    case "followme.wav":
                        basePath += @"\radio";
                        break;

                    case "getout.wav":
                        basePath += @"\radio";
                        break;

                    case "go.wav":
                        basePath += @"\radio";
                        break;

                    case "hitassist.wav":
                        basePath += @"\radio";
                        break;

                    case "hosdown.wav":
                        basePath += @"\radio";
                        break;

                    case "letsgo.wav":
                        basePath += @"\radio";
                        break;

                    case "locknload.wav":
                        basePath += @"\radio";
                        break;

                    case "matedown.wav":
                        basePath += @"\radio";
                        break;

                    case "meetme.wav":
                        basePath += @"\radio";
                        break;

                    case "moveout.wav":
                        basePath += @"\radio";
                        break;

                    case "position.wav":
                        basePath += @"\radio";
                        break;

                    case "regroup.wav":
                        basePath += @"\radio";
                        break;

                    case "rescued.wav":
                        basePath += @"\radio";
                        break;

                    case "rounddraw.wav":
                        basePath += @"\radio";
                        break;

                    case "sticktog.wav":
                        basePath += @"\radio";
                        break;

                    case "stormfront.wav":
                        basePath += @"\radio";
                        break;

                    case "takepoint.wav":
                        basePath += @"\radio";
                        break;

                    case "terwin.wav":
                        basePath += @"\radio";
                        break;

                    case "vip.wav":
                        basePath += @"\radio";
                        break;

                    /*Storm*/

                    case "thunder-theme.wav":
                        basePath += @"\storm";
                        break;

                    /*Weapons*/

                    case "ak47-1.wav":
                        basePath += @"\weapons";
                        break;

                    case "ak47-2.wav":
                        basePath += @"\weapons";
                        break;

                    case "ak47_boltpull.wav":
                        basePath += @"\weapons";
                        break;

                    case "ak47_clipin.wav":
                        basePath += @"\weapons";
                        break;

                    case "ak47_clipout.wav":
                        basePath += @"\weapons";
                        break;

                    case "aug-1.wav":
                        basePath += @"\weapons";
                        break;

                    case "aug_boltpull.wav":
                        basePath += @"\weapons";
                        break;

                    case "aug_boltslap.wav":
                        basePath += @"\weapons";
                        break;

                    case "aug_clipin.wav":
                        basePath += @"\weapons";
                        break;

                    case "aug_clipout.wav":
                        basePath += @"\weapons";
                        break;

                    case "aug_forearm.wav":
                        basePath += @"\weapons";
                        break;

                    case "awp1.wav":
                        basePath += @"\weapons";
                        break;

                    case "awp_clipin.wav":
                        basePath += @"\weapons";
                        break;

                    case "awp_clipout.wav":
                        basePath += @"\weapons";
                        break;

                    case "awp_deploy.wav":
                        basePath += @"\weapons";
                        break;

                    case "boltdown.wav":
                        basePath += @"\weapons";
                        break;

                    case "boltpull1.wav":
                        basePath += @"\weapons";
                        break;

                    case "boltup.wav":
                        basePath += @"\weapons";
                        break;

                    case "c4_beep1.wav":
                        basePath += @"\weapons";
                        break;

                    case "c4_beep2.wav":
                        basePath += @"\weapons";
                        break;

                    case "c4_beep3.wav":
                        basePath += @"\weapons";
                        break;

                    case "c4_beep4.wav":
                        basePath += @"\weapons";
                        break;

                    case "c4_beep5.wav":
                        basePath += @"\weapons";
                        break;

                    case "c4_click.wav":
                        basePath += @"\weapons";
                        break;

                    case "c4_disarm.wav":
                        basePath += @"\weapons";
                        break;

                    case "c4_disarmed.wav":
                        basePath += @"\weapons";
                        break;

                    case "c4_explode1.wav":
                        basePath += @"\weapons";
                        break;

                    case "c4_plant.wav":
                        basePath += @"\weapons";
                        break;

                    case "clipin1.wav":
                        basePath += @"\weapons";
                        break;

                    case "clipout1.wav":
                        basePath += @"\weapons";
                        break;

                    case "deagle-1.wav":
                        basePath += @"\weapons";
                        break;

                    case "deagle-2.wav":
                        basePath += @"\weapons";
                        break;

                    case "de_clipin.wav":
                        basePath += @"\weapons";
                        break;

                    case "de_clipout.wav":
                        basePath += @"\weapons";
                        break;

                    case "de_deploy.wav":
                        basePath += @"\weapons";
                        break;

                    case "dryfire_pistol.wav":
                        basePath += @"\weapons";
                        break;

                    case "dryfire_rifle.wav":
                        basePath += @"\weapons";
                        break;

                    case "elite_clipout.wav":
                        basePath += @"\weapons";
                        break;

                    case "elite_deploy.wav":
                        basePath += @"\weapons";
                        break;

                    case "elite_fire.wav":
                        basePath += @"\weapons";
                        break;

                    case "elite_leftclipin.wav":
                        basePath += @"\weapons";
                        break;

                    case "elite_reloadstart.wav":
                        basePath += @"\weapons";
                        break;

                    case "elite_rightclipin.wav":
                        basePath += @"\weapons";
                        break;

                    case "elite_sliderelease.wav":
                        basePath += @"\weapons";
                        break;

                    case "elite_twirl.wav":
                        basePath += @"\weapons";
                        break;

                    case "famas-1.wav":
                        basePath += @"\weapons";
                        break;

                    case "famas-2.wav":
                        basePath += @"\weapons";
                        break;

                    case "famas-burst.wav":
                        basePath += @"\weapons";
                        break;

                    case "famas_boltpull.wav":
                        basePath += @"\weapons";
                        break;

                    case "famas_boltslap.wav":
                        basePath += @"\weapons";
                        break;

                    case "famas_clipin.wav":
                        basePath += @"\weapons";
                        break;

                    case "famas_clipout.wav":
                        basePath += @"\weapons";
                        break;

                    case "famas_forearm.wav":
                        basePath += @"\weapons";
                        break;

                    case "fiveseven-1.wav":
                        basePath += @"\weapons";
                        break;

                    case "fiveseven_clipin.wav":
                        basePath += @"\weapons";
                        break;

                    case "fiveseven_clipout.wav":
                        basePath += @"\weapons";
                        break;

                    case "fiveseven_slidepull.wav":
                        basePath += @"\weapons";
                        break;

                    case "fiveseven_sliderelease.wav":
                        basePath += @"\weapons";
                        break;

                    case "flashbang-1.wav":
                        basePath += @"\weapons";
                        break;

                    case "flashbang-2.wav":
                        basePath += @"\weapons";
                        break;

                    case "g3sg1-1.wav":
                        basePath += @"\weapons";
                        break;

                    case "g3sg1_clipin.wav":
                        basePath += @"\weapons";
                        break;

                    case "g3sg1_clipout.wav":
                        basePath += @"\weapons";
                        break;

                    case "g3sg1_slide.wav":
                        basePath += @"\weapons";
                        break;

                    case "galil-1.wav":
                        basePath += @"\weapons";
                        break;

                    case "galil-2.wav":
                        basePath += @"\weapons";
                        break;

                    case "galil_boltpull.wav":
                        basePath += @"\weapons";
                        break;

                    case "galil_clipin.wav":
                        basePath += @"\weapons";
                        break;

                    case "galil_clipout.wav":
                        basePath += @"\weapons";
                        break;

                    case "generic_reload.wav":
                        basePath += @"\weapons";
                        break;

                    case "generic_shot_reload.wav":
                        basePath += @"\weapons";
                        break;

                    case "glock18-1.wav":
                        basePath += @"\weapons";
                        break;

                    case "glock18-2.wav":
                        basePath += @"\weapons";
                        break;

                    case "grenade_hit1.wav":
                        basePath += @"\weapons";
                        break;

                    case "grenade_hit2.wav":
                        basePath += @"\weapons";
                        break;

                    case "grenade_hit3.wav":
                        basePath += @"\weapons";
                        break;

                    case "hegrenade-1.wav":
                        basePath += @"\weapons";
                        break;

                    case "hegrenade-2.wav":
                        basePath += @"\weapons";
                        break;

                    case "he_bounce-1.wav":
                        basePath += @"\weapons";
                        break;

                    case "knife_deploy1.wav":
                        basePath += @"\weapons";
                        break;

                    case "knife_hit1.wav":
                        basePath += @"\weapons";
                        break;

                    case "knife_hit2.wav":
                        basePath += @"\weapons";
                        break;

                    case "knife_hit3.wav":
                        basePath += @"\weapons";
                        break;

                    case "knife_hit4.wav":
                        basePath += @"\weapons";
                        break;

                    case "knife_hitwall1.wav":
                        basePath += @"\weapons";
                        break;

                    case "knife_slash1.wav":
                        basePath += @"\weapons";
                        break;

                    case "knife_slash2.wav":
                        basePath += @"\weapons";
                        break;

                    case "knife_stab.wav":
                        basePath += @"\weapons";
                        break;

                    case "m249-1.wav":
                        basePath += @"\weapons";
                        break;

                    case "m249-2.wav":
                        basePath += @"\weapons";
                        break;

                    case "m249_boxin.wav":
                        basePath += @"\weapons";
                        break;

                    case "m249_boxout.wav":
                        basePath += @"\weapons";
                        break;

                    case "m249_chain.wav":
                        basePath += @"\weapons";
                        break;

                    case "m249_coverdown.wav":
                        basePath += @"\weapons";
                        break;

                    case "m249_coverup.wav":
                        basePath += @"\weapons";
                        break;

                    case "m3-1.wav":
                        basePath += @"\weapons";
                        break;

                    case "m3_insertshell.wav":
                        basePath += @"\weapons";
                        break;

                    case "m3_pump.wav":
                        basePath += @"\weapons";
                        break;

                    case "m4a1-1.wav":
                        basePath += @"\weapons";
                        break;

                    case "m4a1_boltpull.wav":
                        basePath += @"\weapons";
                        break;

                    case "m4a1_clipin.wav":
                        basePath += @"\weapons";
                        break;

                    case "m4a1_clipout.wav":
                        basePath += @"\weapons";
                        break;

                    case "m4a1_deploy.wav":
                        basePath += @"\weapons";
                        break;

                    case "m4a1_silencer_off.wav":
                        basePath += @"\weapons";
                        break;

                    case "m4a1_silencer_on.wav":
                        basePath += @"\weapons";
                        break;

                    case "m4a1_unsil-1.wav":
                        basePath += @"\weapons";
                        break;

                    case "m4a1_unsil-2.wav":
                        basePath += @"\weapons";
                        break;

                    case "mac10-1.wav":
                        basePath += @"\weapons";
                        break;

                    case "mac10_boltpull.wav":
                        basePath += @"\weapons";
                        break;

                    case "mac10_clipin.wav":
                        basePath += @"\weapons";
                        break;

                    case "mac10_clipout.wav":
                        basePath += @"\weapons";
                        break;

                    case "mp5-1.wav":
                        basePath += @"\weapons";
                        break;

                    case "mp5-2.wav":
                        basePath += @"\weapons";
                        break;

                    case "mp5_clipin.wav":
                        basePath += @"\weapons";
                        break;

                    case "mp5_clipout.wav":
                        basePath += @"\weapons";
                        break;

                    case "mp5_slideback.wav":
                        basePath += @"\weapons";
                        break;

                    case "p228-1.wav":
                        basePath += @"\weapons";
                        break;

                    case "p228_clipin.wav":
                        basePath += @"\weapons";
                        break;

                    case "p228_clipout.wav":
                        basePath += @"\weapons";
                        break;

                    case "p228_slidepull.wav":
                        basePath += @"\weapons";
                        break;

                    case "p228_sliderelease.wav":
                        basePath += @"\weapons";
                        break;

                    case "p90-1.wav":
                        basePath += @"\weapons";
                        break;

                    case "p90_boltpull.wav":
                        basePath += @"\weapons";
                        break;

                    case "p90_clipin.wav":
                        basePath += @"\weapons";
                        break;

                    case "p90_clipout.wav":
                        basePath += @"\weapons";
                        break;

                    case "p90_cliprelease.wav":
                        basePath += @"\weapons";
                        break;

                    case "pinpull.wav":
                        basePath += @"\weapons";
                        break;

                    case "ric_conc-1.wav":
                        basePath += @"\weapons";
                        break;

                    case "ric_conc-2.wav":
                        basePath += @"\weapons";
                        break;

                    case "ric_metal-1.wav":
                        basePath += @"\weapons";
                        break;

                    case "ric_metal-2.wav":
                        basePath += @"\weapons";
                        break;

                    case "scout_bolt.wav":
                        basePath += @"\weapons";
                        break;

                    case "scout_clipin.wav":
                        basePath += @"\weapons";
                        break;

                    case "scout_clipout.wav":
                        basePath += @"\weapons";
                        break;

                    case "scout_fire-1.wav":
                        basePath += @"\weapons";
                        break;

                    case "sg550-1.wav":
                        basePath += @"\weapons";
                        break;

                    case "sg550_boltpull.wav":
                        basePath += @"\weapons";
                        break;

                    case "sg550_clipin.wav":
                        basePath += @"\weapons";
                        break;

                    case "sg550_clipout.wav":
                        basePath += @"\weapons";
                        break;

                    case "sg552-1.wav":
                        basePath += @"\weapons";
                        break;

                    case "sg552-2.wav":
                        basePath += @"\weapons";
                        break;

                    case "sg552_boltpull.wav":
                        basePath += @"\weapons";
                        break;

                    case "sg552_clipin.wav":
                        basePath += @"\weapons";
                        break;

                    case "sg552_clipout.wav":
                        basePath += @"\weapons";
                        break;

                    case "sg_explode.wav":
                        basePath += @"\weapons";
                        break;

                    case "slideback1.wav":
                        basePath += @"\weapons";
                        break;

                    case "sliderelease1.wav":
                        basePath += @"\weapons";
                        break;

                    case "tmp-1.wav":
                        basePath += @"\weapons";
                        break;

                    case "tmp-2.wav":
                        basePath += @"\weapons";
                        break;

                    case "ump45-1.wav":
                        basePath += @"\weapons";
                        break;

                    case "ump45_boltslap.wav":
                        basePath += @"\weapons";
                        break;

                    case "ump45_clipin.wav":
                        basePath += @"\weapons";
                        break;

                    case "ump45_clipout.wav":
                        basePath += @"\weapons";
                        break;

                    case "usp1.wav":
                        basePath += @"\weapons";
                        break;

                    case "usp2.wav":
                        basePath += @"\weapons";
                        break;

                    case "usp_clipin.wav":
                        basePath += @"\weapons";
                        break;

                    case "usp_clipout.wav":
                        basePath += @"\weapons";
                        break;

                    case "usp_silencer_off.wav":
                        basePath += @"\weapons";
                        break;

                    case "usp_silencer_on.wav":
                        basePath += @"\weapons";
                        break;

                    case "usp_slideback.wav":
                        basePath += @"\weapons";
                        break;

                    case "usp_sliderelease.wav":
                        basePath += @"\weapons";
                        break;

                    case "usp_unsil-1.wav":
                        basePath += @"\weapons";
                        break;

                    case "xm1014-1.wav":
                        basePath += @"\weapons";
                        break;

                    case "zoom.wav":
                        basePath += @"\weapons";
                        break;
                }

                if(add)
                    outputs.Add(basePath + @"\" + audioName);

                return outputs;
            }
        }

    }
}
