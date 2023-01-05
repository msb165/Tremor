using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using ReLogic.Content;
using Terraria;
using Terraria.Audio;
using Terraria.GameContent;
using Terraria.Graphics.Effects;
using Terraria.Graphics.Shaders;
using Terraria.ID;
using Terraria.Localization;
using Terraria.ModLoader;
using Terraria.UI;
using Tremor.Invasion;
using Tremor.Items;
using Tremor.Items.Ancient;
using Tremor.Items.Crystal;
using Tremor.Items.Cursed;
using Tremor.Items.Cyber;
using Tremor.Items.Desert;
using Tremor.Items.Granite;
using Tremor.NPCs;
using Tremor.NPCs.Bosses.CogLord;
using Tremor.NPCs.Bosses.CogLord.Items;
using Tremor.NPCs.Bosses.Motherboard.Items;
using Tremor.NPCs.Bosses.NovaPillar;
using Tremor.NPCs.Bosses.NovaPillar.Items;
using Tremor.ZombieEvent;
using Tremor.ZombieEvent.Items;

namespace Tremor
{
	public class Tremor : Mod
	{
		internal static Tremor instance;

		public static void Log(object message)
		{
			instance.Logger.Info($"[Tremor][{DateTime.Now:yyyy-MM-dd hh:mm:ss}] {message}");
		}

		public static void Log(string format, params object[] args)
		{
			instance.Logger.Info($"[Tremor][{DateTime.Now:yyyy-MM-dd hh:mm:ss}] {string.Format(format, args)}");
		}

		public override void AddRecipeGroups()
		{
			RecipeGroup group = new RecipeGroup(() => Language.GetTextValue("LegacyMisc.37") + " " + Lang.GetItemNameValue(ItemID.AmethystStaff), ItemID.AmethystStaff, ItemID.DiamondStaff, ItemID.RubyStaff, ItemID.TopazStaff, ItemID.SapphireStaff, ItemID.AmberStaff, ItemID.EmeraldStaff);
			RecipeGroup.RegisterGroup("Tremor:GemStaves", group);
		}

		public Texture2D GetTexture(string path) => Assets.Request<Texture2D>(path, AssetRequestMode.ImmediateLoad).Value;
		public Asset<Texture2D> GetTextureAssert(string path) => Assets.Request<Texture2D>(path, AssetRequestMode.ImmediateLoad);
		
		

		public override void PostSetupContent()
		{
			if(ModLoader.TryGetMod("BossChecklist", out Mod bossChecklist))
			{
				//SlimeKing = 1f;
				//EyeOfCthulhu = 2f;
				//EaterOfWorlds = 3f;
				//QueenBee = 4f;
				//Skeletron = 5f;
				//WallOfFlesh = 6f;
				//TheTwins = 7f;
				//TheDestroyer = 8f;
				//SkeletronPrime = 9f;
				//Plantera = 10f;
				//Golem = 11f;
				//DukeFishron = 12f;
				//LunaticCultist = 13f;
				//Moonlord = 14f;
				bossChecklist.Call("AddBossWithInfo", "Rukh", 2.7f, (Func<bool>)(() => TremorWorld.Boss.Rukh.IsDowned()), "Use a [i:" + ModContent.ItemType<DesertCrown>() + "]");// in Desert
				bossChecklist.Call("AddBossWithInfo", "Tiki Totem", 3.3f, (Func<bool>)(() => TremorWorld.Boss.TikiTotem.IsDowned()), "Use a [i:" + ModContent.ItemType<MysteriousDrum>() + "]");//in Jungle at night after beating Eye of Cthulhu
				bossChecklist.Call("AddBossWithInfo", "Evil Corn", 3.4f, (Func<bool>)(() => TremorWorld.Boss.EvilCorn.IsDowned()), "Use a [i:" + ModContent.ItemType<CursedPopcorn>() + "]");// at night
				bossChecklist.Call("AddBossWithInfo", "Storm Jellyfish", 3.5f, (Func<bool>)(() => TremorWorld.Boss.StormJellyfish.IsDowned()), "Use a [i:" + ModContent.ItemType<StormJelly>() + "]");
				bossChecklist.Call("AddBossWithInfo", "Ancient Dragon", 3.6f, (Func<bool>)(() => TremorWorld.Boss.AncientDragon.IsDowned()), "Use a [i:" + ModContent.ItemType<RustyLantern>() + "]");//in Ruins after pressing with RMB on Ruin Altar and getting Ruin Powers buff
				bossChecklist.Call("AddBossWithInfo", "Fungus Beetle", 5.6f, (Func<bool>)(() => TremorWorld.Boss.FungusBeetle.IsDowned()), "Use a [i:" + ModContent.ItemType<MushroomCrystal>() + "]");
				bossChecklist.Call("AddBossWithInfo", "Heater of Worlds", 5.5f, (Func<bool>)(() => TremorWorld.Boss.HeaterofWorlds.IsDowned()), "Use a [i:" + ModContent.ItemType<MoltenHeart>() + "]");// in Underworld
				bossChecklist.Call("AddBossWithInfo", "Alchemaster", 6.5f, (Func<bool>)(() => TremorWorld.Boss.Alchemaster.IsDowned()), "Use a [i:" + ModContent.ItemType<AncientMosaic>() + "]");// at night
				bossChecklist.Call("AddBossWithInfo", "Motherboard (Destroyer alt)", 8.01f, (Func<bool>)(() => TremorWorld.Boss.Motherboard.IsDowned()), "Use a [i:" + ModContent.ItemType<MechanicalBrain>() + "]");//at night
				bossChecklist.Call("AddBossWithInfo", "Pixie Queen", 9.6f, (Func<bool>)(() => TremorWorld.Boss.PixieQueen.IsDowned()), "Use a [i:" + ModContent.ItemType<PixieinaJar>() + "]");// in Hallow at night
				bossChecklist.Call("AddBossWithInfo", "Wall of Shadows", 10.7f, (Func<bool>)(() => TremorWorld.Boss.WallOfShadow.IsDowned()), "Use a [i:" + ModContent.ItemType<ShadowRelic>() + "]");//into lava in Underworld after beating Plantera and having the Dryad alive
				bossChecklist.Call("AddBossWithInfo", "Frost King", 10.6f, (Func<bool>)(() => TremorWorld.Boss.FrostKing.IsDowned()), "Use a [i:" + ModContent.ItemType<FrostCrown>() + "]");//in Snow
				bossChecklist.Call("AddBossWithInfo", "Cog Lord", 11.4f, (Func<bool>)(() => TremorWorld.Boss.CogLord.IsDowned()), "Use a [i:" + ModContent.ItemType<ArtifactEngine>() + "]");//at night
				bossChecklist.Call("AddBossWithInfo", "Mothership and Cyber King", 11.5f, (Func<bool>)(() => TremorWorld.Boss.CyberKing.IsDowned()), "Use a [i:" + ModContent.ItemType<AdvancedCircuit>() + "], Cyber King spawns after defeating the Mothership");//Cyber King spawns after defeating the Mothership
				bossChecklist.Call("AddBossWithInfo", "Nova Pillar", 13.5f, (Func<bool>)(() => TremorWorld.Boss.NovaPillar.IsDowned()), "Kill the Lunatic Cultist outside the dungeon");
				bossChecklist.Call("AddBossWithInfo", "The Dark Emperor", 14.4f, (Func<bool>)(() => TremorWorld.Boss.DarkEmperor.IsDowned()), "Use a [i:" + ModContent.ItemType<EmperorCrown>() + "]");
				bossChecklist.Call("AddBossWithInfo", "Brutallisk", 14.5f, (Func<bool>)(() => TremorWorld.Boss.Brutallisk.IsDowned()), "Use a [i:" + ModContent.ItemType<RoyalEgg>() + "]");// in Desert
				bossChecklist.Call("AddBossWithInfo", "Space Whale", 14.6f, (Func<bool>)(() => TremorWorld.Boss.SpaceWhale.IsDowned()), "Use a [i:" + ModContent.ItemType<CosmicKrill>() + "]");
				bossChecklist.Call("AddBossWithInfo", "The Trinity", 14.7f, (Func<bool>)(() => TremorWorld.Boss.Trinity.IsDowned()), "Use a [i:" + ModContent.ItemType<StoneofKnowledge>() + "]");//at night
				bossChecklist.Call("AddBossWithInfo", "Andas", 14.8f, (Func<bool>)(() => TremorWorld.Boss.Andas.IsDowned()), "Use a [i:" + ModContent.ItemType<InfernoSkull>() + "]");//at Underworld
			}
		}

		public override void Unload()
		{
			instance = null;
			if (!Main.dedServ)
			{
				TremorGlowMask.Unload();
				TextureAssets.Item[3601] = Main.Assets.Request<Texture2D>("Images/Item_3601");
				for (int i = 1; i < 206; i++)
				{
					TextureAssets.Buff[i] = Main.Assets.Request<Texture2D>($"Images/Buff_{i}");
				}
			}
		}

		public override void Load()
		{
			instance = this;

			Filters.Scene["Tremor:Invasion"] = new Filter(new InvasionData("FilterMiniTower").UseColor(0.2f, 0.4f, 0.5f).UseOpacity(0.9f), EffectPriority.VeryHigh);
			SkyManager.Instance["Tremor:Invasion"] = new ZombieSky();
			Filters.Scene["Tremor:Zombie"] = new Filter(new ZombieScreenShaderData("FilterMiniTower").UseColor(1.1f, 0.3f, 0.3f).UseOpacity(0.6f), EffectPriority.VeryHigh);
			SkyManager.Instance["Tremor:Zombie"] = new ZombieSky();
			Filters.Scene["Tremor:Ice"] = new Filter(new ZombieScreenShaderData("FilterMiniTower").UseColor(0.4f, 0.8f, 1.0f).UseOpacity(0.6f), EffectPriority.VeryHigh);
			SkyManager.Instance["Tremor:Ice"] = new ZombieSky();
			Filters.Scene["Tremor:CogLord"] = new Filter(new ZombieScreenShaderData("FilterMiniTower").UseColor(0.9f, 0.5f, 0.2f).UseOpacity(0.6f), EffectPriority.VeryHigh);
			SkyManager.Instance["Tremor:CogLord"] = new ZombieSky();

			// Init
			NPCDrops.Init();
			TremorWorld.Init();

			if (!Main.dedServ)
			{
				(string file,int itemType,int tileType)[] musicBoxes =
				{
					( "CogLord",		ModContent.ItemType<CogLordMusicBox>(),			ModContent.TileType<Tiles.CogLordMusicBox>()),
					( "SlimeRain",		ModContent.ItemType<SlimeRainMusicBox>(),		ModContent.TileType<Tiles.SlimeRainMusicBox>()),
					( "Boss6",			ModContent.ItemType<Boss6MusicBox>(),			ModContent.TileType<Tiles.Boss6MusicBox>()),
					( "Trinity",		ModContent.ItemType<TrinityMusicBox>(),			ModContent.TileType<Tiles.TrinityMusicBox>()),
					( "TikiTotem",		ModContent.ItemType<TikiTotemMusicBox>(),		ModContent.TileType<Tiles.TikiTotemMusicBox>()),
					( "EvilCorn",		ModContent.ItemType<EvilCornMusicBox>(),		ModContent.TileType<Tiles.EvilCornMusicBox>()),
					( "CyberKing",		ModContent.ItemType<CyberKingMusicBox>(),		ModContent.TileType<Tiles.CyberKingMusicBox>()),
					( "Snow2",			ModContent.ItemType<BlizzardMusicBox>(),		ModContent.TileType<Tiles.BlizzardMusicBox>()),
					( "CyberWrath",		ModContent.ItemType<ParadoxCohortMusicBox>(),	ModContent.TileType<ParadoxCohortMusicBoxTile>()),
					( "NightOfUndead",	ModContent.ItemType<DeathHordeMusicBox>(),		ModContent.TileType<DeathHordeMusicBoxTile>()),
					( "Granite",		ModContent.ItemType<GraniteMusicBox>(),			ModContent.TileType<Tiles.GraniteMusicBox>()),
				};

				for (int i = 0; i < musicBoxes.Length; i++)
				{
					MusicLoader.AddMusicBox(this, MusicLoader.GetMusicSlot($"Tremor/Sounds/Music/{musicBoxes[i].file}"), musicBoxes[i].itemType, musicBoxes[i].tileType);
				}

				GameShaders.Armor.BindShader(ModContent.ItemType<NovaDye>(), new ArmorShaderData(Main.PixelShaderRef, "ArmorSolar")).UseColor(0.8f, 0.7f, 0.3f).UseSecondaryColor(0.8f, 0.7f, 0.3f);
				NovaSky.PlanetTexture = GetTexture("NPCs/Bosses/NovaPillar/NovaPlanet");
				Filters.Scene["Tremor:Nova"] = new Filter(new NovaData("FilterMiniTower").UseColor(0.8f, 0.7f, 0.3f).UseOpacity(0.82f), EffectPriority.VeryHigh);
				SkyManager.Instance["Tremor:Nova"] = new NovaSky();

				// Replace celestial sigil?
				TextureAssets.Item[3601] = GetTextureAssert($"Resprites/{(ModLoader.Mods.Select(m=>Name).Contains("Elerium") ? "CelestialSigil2" : "CelestialSigil")}");

				// Replace vanilla buff sprites with resprites
				for (int i = 1; i < 206; i++)
				{
					TextureAssets.Buff[i] = GetTextureAssert($"Resprites/Buff_{i}");
				}
			}
		}

		public override void AddRecipes()
		{
			// Recipe wrapper
			RecipeUtils.AddRecipes(this);
			RecipeUtils.AdaptToNovaRecipes(this);
		}
	}
	public class TremorSystem:ModSystem
	{
		public override void ModifyInterfaceLayers(List<GameInterfaceLayer> layers)
		{
			if (InvasionWorld.CyberWrath)
			{
				int index = layers.FindIndex(layer => layer.Name.Equals("Vanilla: Inventory"));
				LegacyGameInterfaceLayer orionProgress = new LegacyGameInterfaceLayer("Tremor: Invasion2",
					delegate
					{
						DrawOrionEvent(Main.spriteBatch);
						return true;
					},
					InterfaceScaleType.UI);
				layers.Insert(index, orionProgress);
			}
		}

		public void DrawOrionEvent(SpriteBatch spriteBatch)
		{
			if (InvasionWorld.CyberWrath && !Main.gameMenu)
			{
				float scaleMultiplier = 0.5f + 1 * 0.5f;
				float alpha = 0.5f;
				Texture2D progressBg = TextureAssets.ColorBar.Value;
				Texture2D progressColor = TextureAssets.ColorBar.Value;
				Texture2D orionIcon = Tremor.instance.GetTexture("Invasion/InvasionIcon");
				const string orionDescription = "Paradox Cohort";
				Color descColor = new Color(39, 86, 134);

				Color waveColor = new Color(255, 241, 51);
				Color barrierColor = new Color(255, 241, 51);

				try
				{
					//draw the background for the waves counter
					const int offsetX = 20;
					const int offsetY = 20;
					int width = (int)(200f * scaleMultiplier);
					int height = (int)(46f * scaleMultiplier);
					Rectangle waveBackground = Utils.CenteredRectangle(new Vector2(Main.screenWidth - offsetX - 100f, Main.screenHeight - offsetY - 23f), new Vector2(width, height));
					Utils.DrawInvBG(spriteBatch, waveBackground, new Color(63, 65, 151, 255) * 0.785f);

					//draw wave text

					string waveText = "Cleared " + InvasionWorld.CyberWrathPoints1 + "%";
					Utils.DrawBorderString(spriteBatch, waveText, new Vector2(waveBackground.X + waveBackground.Width / 2, waveBackground.Y), Color.White, scaleMultiplier, 0.5f, -0.1f);

					//draw the progress bar

					if (InvasionWorld.CyberWrathPoints1 == 0)
					{

					}

					Rectangle waveProgressBar = Utils.CenteredRectangle(new Vector2(waveBackground.X + waveBackground.Width * 0.5f, waveBackground.Y + waveBackground.Height * 0.75f), new Vector2(progressColor.Width, progressColor.Height));
					Rectangle waveProgressAmount = new Rectangle(0, 0, (int)(progressColor.Width * 0.01f * MathHelper.Clamp(InvasionWorld.CyberWrathPoints1, 0f, 100f)), progressColor.Height);
					Vector2 offset = new Vector2((waveProgressBar.Width - (int)(waveProgressBar.Width * scaleMultiplier)) * 0.5f, (waveProgressBar.Height - (int)(waveProgressBar.Height * scaleMultiplier)) * 0.5f);

					spriteBatch.Draw(progressBg, waveProgressBar.Location.ToVector2() + offset, null, Color.White * alpha, 0f, new Vector2(0f), scaleMultiplier, SpriteEffects.None, 0f);
					spriteBatch.Draw(progressBg, waveProgressBar.Location.ToVector2() + offset, waveProgressAmount, waveColor, 0f, new Vector2(0f), scaleMultiplier, SpriteEffects.None, 0f);

					//draw the icon with the event description

					//draw the background
					const int internalOffset = 6;
					Vector2 descSize = new Vector2(154, 40) * scaleMultiplier;
					Rectangle barrierBackground = Utils.CenteredRectangle(new Vector2(Main.screenWidth - offsetX - 100f, Main.screenHeight - offsetY - 19f), new Vector2(width, height));
					Rectangle descBackground = Utils.CenteredRectangle(new Vector2(barrierBackground.X + barrierBackground.Width * 0.5f, barrierBackground.Y - internalOffset - descSize.Y * 0.5f), descSize);
					Utils.DrawInvBG(spriteBatch, descBackground, descColor * alpha);

					//draw the icon
					int descOffset = (descBackground.Height - (int)(32f * scaleMultiplier)) / 2;
					Rectangle icon = new Rectangle(descBackground.X + descOffset, descBackground.Y + descOffset, (int)(32 * scaleMultiplier), (int)(32 * scaleMultiplier));
					spriteBatch.Draw(orionIcon, icon, Color.White);

					//draw text

					Utils.DrawBorderString(spriteBatch, orionDescription, new Vector2(barrierBackground.X + barrierBackground.Width * 0.5f, barrierBackground.Y - internalOffset - descSize.Y * 0.5f), Color.White, 0.80f, 0.3f, 0.4f);
				}
				catch (Exception e)
				{
					Tremor.instance.Logger.Error(e.ToString());
				}
			}
		}
	}
	public class TremorSceneEffect:ModSceneEffect
	{
		public override int Music => music;
		public override SceneEffectPriority Priority => priority;

		private int music;
		private SceneEffectPriority priority;

		private HashSet<int> noOverride;

		public override void SetStaticDefaults()
		{
			noOverride = new HashSet<int>
			{
				MusicID.Boss1, MusicID.Boss2, MusicID.Boss3, MusicID.Boss4, MusicID.Boss5,
				MusicID.LunarBoss, MusicID.PumpkinMoon, MusicID.TheTowers, MusicID.FrostMoon, MusicID.GoblinInvasion,
				MusicID.Eclipse, MusicID.MartianMadness, MusicID.PirateInvasion,
				MusicLoader.GetMusicSlot("Sounds/Music/CyberKing"),
				MusicLoader.GetMusicSlot("Sounds/Music/Boss6"),
				MusicLoader.GetMusicSlot("Sounds/Music/Trinity"),
				MusicLoader.GetMusicSlot("Sounds/Music/SlimeRain"),
				MusicLoader.GetMusicSlot("Sounds/Music/EvilCorn"),
				MusicLoader.GetMusicSlot("Sounds/Music/TikiTotem"),
				MusicLoader.GetMusicSlot("Sounds/Music/CogLord"),
				MusicLoader.GetMusicSlot("Sounds/Music/NightOfUndead"),
				MusicLoader.GetMusicSlot("Sounds/Music/CyberWrath"),

				MusicLoader.GetMusicSlot("Sounds/Music/Trinity"),
				MusicLoader.GetMusicSlot("Sounds/Music/Snow2")
			};
		}

		public override bool IsSceneEffectActive(Player player)
		{
			if (Main.myPlayer != -1 && !Main.gameMenu){return false;}
			
			bool playMusic = !noOverride.Contains(music) || !Main.npc.Any(npc => npc.active&&npc.boss);

			var modPlayer = player.GetModPlayer<TremorPlayer>();
			if (player.active && modPlayer.ZoneGranite && playMusic)
			{
				music = MusicLoader.GetMusicSlot("Sounds/Music/Granite");
				priority = SceneEffectPriority.BiomeMedium;
			}

			if (ZWorld.ZInvasion && playMusic)
			{
				music = MusicLoader.GetMusicSlot("Sounds/Music/NightOfUndead");
				priority = SceneEffectPriority.Event;
			}

			if (InvasionWorld.CyberWrath)
			{
				music = MusicLoader.GetMusicSlot("Sounds/Music/CyberWrath");
				priority = SceneEffectPriority.Event;
			}

			if (player.active && NPC.AnyNPCs(ModContent.NPCType<CogLord>()))
			{
				music = MusicLoader.GetMusicSlot("Sounds/Music/CogLord");
				priority = SceneEffectPriority.BossLow;
			}

			if (player.active && NPC.AnyNPCs(NPCID.KingSlime))
			{
				music = MusicLoader.GetMusicSlot("Sounds/Music/Boss6");
				priority = SceneEffectPriority.BossLow;
			}

			if (player.active && (NPC.AnyNPCs(ModContent.NPCType<TikiTotem>()) || NPC.AnyNPCs(ModContent.NPCType<HappySoul>()) || NPC.AnyNPCs(ModContent.NPCType<AngerSoul>()) || NPC.AnyNPCs(ModContent.NPCType<IndifferenceSoul>())))
			{
				music = MusicLoader.GetMusicSlot("Sounds/Music/TikiTotem");
				priority = SceneEffectPriority.BossLow;
			}

			if (player.active && NPC.AnyNPCs(ModContent.NPCType<EvilCorn>()))
			{
				music = MusicLoader.GetMusicSlot("Sounds/Music/EvilCorn");
				priority = SceneEffectPriority.BossLow;
			}

			if (player.active && Main.invasionType == InvasionID.SnowLegion)
			{
				music = MusicLoader.GetMusicSlot("Sounds/Music/Boss6");
				priority = SceneEffectPriority.BossLow;
			}

			if (player.active && Main.slimeRain && !NPC.AnyNPCs(NPCID.KingSlime) && !Main.eclipse && playMusic)
			{
				music = MusicLoader.GetMusicSlot("Sounds/Music/SlimeRain");
				priority = SceneEffectPriority.Environment;
			}

			if (player.active && NPC.AnyNPCs(ModContent.NPCType<SoulofTruth>()))
			{
				music = MusicLoader.GetMusicSlot("Sounds/Music/Trinity");
				priority = SceneEffectPriority.BossLow;
			}
			if (player.active && NPC.AnyNPCs(ModContent.NPCType<SoulofTrust>()))
			{
				music = MusicLoader.GetMusicSlot("Sounds/Music/Trinity");
				priority = SceneEffectPriority.BossLow;
			}
			if (player.active && NPC.AnyNPCs(ModContent.NPCType<SoulofHope>()))
			{
				music = MusicLoader.GetMusicSlot("Sounds/Music/Trinity");
				priority = SceneEffectPriority.BossLow;
			}
			if (player.active && NPC.AnyNPCs(ModContent.NPCType<FrostKing>()))
			{
				music = MusicLoader.GetMusicSlot("Sounds/Music/Boss6");
				priority = SceneEffectPriority.BossLow;
			}
			if (player.active && NPC.AnyNPCs(ModContent.NPCType<CyberKing>()))
			{
				music = MusicLoader.GetMusicSlot("Sounds/Music/CyberKing");
				priority = SceneEffectPriority.BossLow;
			}

			if (Main.cloudAlpha > 0f && player.position.Y < Main.worldSurface * 16.0 + Main.screenHeight / 2 && player.ZoneSnow && playMusic)
			{
				music = MusicLoader.GetMusicSlot("Sounds/Music/Snow2");
				priority = SceneEffectPriority.BiomeMedium;
			}

			if (player.active && modPlayer.ZoneIce && !Main.gameMenu && playMusic)
			{
				music = MusicLoader.GetMusicSlot("Sounds/Music/Snow2");
				priority = SceneEffectPriority.BiomeMedium;
			}

			return music>0;
		}
	}
}