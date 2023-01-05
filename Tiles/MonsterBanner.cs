using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ModLoader;
using Terraria.ObjectData;
using Tremor.Items;
using Tremor.Items.Ancient;
using Tremor.Items.ArchDemon;
using Tremor.Items.Bone;
using Tremor.Items.Dark;
using Tremor.Items.Granite;
using Tremor.Items.Harpy;
using Tremor.Items.Wolf;
using Tremor.Items.Wood;
using Tremor.NPCs;

namespace Tremor.Tiles
{
	public class MonsterBanner:TremorModTile
	{
		public override void SetDefaults()
		{
			Main.tileFrameImportant[Type] = true;
			Main.tileNoAttach[Type] = true;
			Main.tileLavaDeath[Type] = true;
			TileObjectData.newTile.CopyFrom(TileObjectData.Style1x2Top);
			TileObjectData.newTile.Height = 3;
			TileObjectData.newTile.CoordinateHeights = new[] { 16, 16, 16 };
			TileObjectData.newTile.StyleHorizontal = true;
			TileObjectData.newTile.StyleWrapLimit = 111;
			TileObjectData.addTile(Type);
			dustType = -1;
			AddMapEntry(new Color(13, 88, 130));
		}

		public override void KillMultiTile(int i, int j, int frameX, int frameY)
		{
			int style = frameX / 18;
			int item;
			switch(style)
			{
				case 0:
					item = ModContent.ItemType<ZarpruteBanner>();
					break;
				case 1:
					item = ModContent.ItemType<ZarpriteBanner>();
					break;
				case 2:
					item = ModContent.ItemType<UndeadWarriorBanner>();
					break;
				case 3:
					item = ModContent.ItemType<PhantomBanner>();
					break;
				case 4:
					item = ModContent.ItemType<ParaspriteBanner>();
					break;
				case 5:
					item = ModContent.ItemType<DarkDruidBanner>();
					break;
				case 6:
					item = ModContent.ItemType<BloodmoonWarriorBanner>();
					break;
				case 7:
					item = ModContent.ItemType<AtisBanner>();
					break;
				case 8:
					item = ModContent.ItemType<OrcBanner>();
					break;
				case 9:
					item = ModContent.ItemType<OrcWarriorBanner>();
					break;
				case 10:
					item = ModContent.ItemType<MushroomCreatureBanner>();
					break;
				case 11:
					item = ModContent.ItemType<HallowSlimerBanner>();
					break;
				case 12:
					item = ModContent.ItemType<DeepwaterVilefishBanner>();
					break;
				case 13:
					item = ModContent.ItemType<CrimerBanner>();
					break;
				case 14:
					item = ModContent.ItemType<BicholmereBanner>();
					break;
				case 15:
					item = ModContent.ItemType<CrimsonBiholmerBanner>();
					break;
				case 16:
					item = ModContent.ItemType<CorruptedBiholmerBanner>();
					break;
				case 17:
					item = ModContent.ItemType<ChatteringTeethBanner>();
					break;
				case 18:
					item = ModContent.ItemType<CaveGolemBanner>();
					break;
				case 19:
					item = ModContent.ItemType<ArmoredJellyfishBanner>();
					break;
				case 20:
					item = ModContent.ItemType<ArchDemonBanner>();
					break;
				case 21:
					item = ModContent.ItemType<OmegaWolfBanner>();
					break;
				case 22:
					item = ModContent.ItemType<BetaWolfBanner>();
					break;
				case 23:
					item = ModContent.ItemType<AlphaWolfBanner>();
					break;
				case 24:
					item = ModContent.ItemType<AbominationBanner>();
					break;
				case 25:
					item = ModContent.ItemType<BlazerBanner>();
					break;
				case 26:
					item = ModContent.ItemType<BoneFlyerBanner>();
					break;
				case 27:
					item = ModContent.ItemType<DinictisBanner>();
					break;
				case 28:
					item = ModContent.ItemType<OrcSkeletonBanner>();
					break;
				case 29:
					item = ModContent.ItemType<DragonSkullBanner>();
					break;
				case 30:
					item = ModContent.ItemType<DungeonKeeperBanner>();
					break;
				case 31:
					item = ModContent.ItemType<FlayerBanner>();
					break;
				case 32:
					item = ModContent.ItemType<GiantCrabBanner>();
					break;
				case 33:
					item = ModContent.ItemType<HeadlessZombieBanner>();
					break;
				case 34:
					item = ModContent.ItemType<HeavyZombieBanner>();
					break;
				case 35:
					item = ModContent.ItemType<HiveHeadZombieBanner>();
					break;
				case 36:
					item = ModContent.ItemType<ObserverBanner>();
					break;
				case 37:
					item = ModContent.ItemType<PeepersBanner>();
					break;
				case 38:
					item = ModContent.ItemType<PyramidHeadBanner>();
					break;
				case 39:
					item = ModContent.ItemType<SpiderManBanner>();
					break;
				case 40:
					item = ModContent.ItemType<SquidZombieBanner>();
					break;
				case 41:
					item = ModContent.ItemType<SupremePossessedArmorBanner>();
					break;
				case 42:
					item = ModContent.ItemType<WoodyBanner>();
					break;
				case 43:
					item = ModContent.ItemType<DevilishTortoiseBanner>();
					break;
				case 44:
					item = ModContent.ItemType<AgloominationBanner>();
					break;
				case 45:
					item = ModContent.ItemType<AncientCursedSkullBanner>();
					break;
				case 46:
					item = ModContent.ItemType<BansheeBanner>();
					break;
				case 47:
					item = ModContent.ItemType<BoneArcherBanner>();
					break;
				case 48:
					item = ModContent.ItemType<CloudSlimeBanner>();
					break;
				case 49:
					item = ModContent.ItemType<ConjurerSkeletonBanner>();
					break;
				case 50:
					item = ModContent.ItemType<CoreBugBanner>();
					break;
				case 51:
					item = ModContent.ItemType<CoreSlimeBanner>();
					break;
				case 52:
					item = ModContent.ItemType<DeimosBanner>();
					break;
				case 53:
					item = ModContent.ItemType<DranixBanner>();
					break;
				case 54:
					item = ModContent.ItemType<DreadBeetleBanner>();
					break;
				case 55:
					item = ModContent.ItemType<ElderObserverBanner>();
					break;
				case 56:
					item = ModContent.ItemType<EnragedBatBanner>();
					break;
				case 57:
					item = ModContent.ItemType<EvolvedZombieBanner>();
					break;
				case 58:
					item = ModContent.ItemType<FallenWarriorBanner>();
					break;
				case 59:
					item = ModContent.ItemType<FatFlinxBanner>();
					break;
				case 60:
					item = ModContent.ItemType<FireBeetleBanner>();
					break;
				case 61:
					item = ModContent.ItemType<FlayerBanner>();
					break;
				case 62:
					item = ModContent.ItemType<FrostBeetleBanner>();
					break;
				case 63:
					item = ModContent.ItemType<GeneralSnowmanBanner>();
					break;
				case 64:
					item = ModContent.ItemType<GhostKnightBanner>();
					break;
				case 65:
					item = ModContent.ItemType<GiantGastropodBanner>();
					break;
				case 66:
					item = ModContent.ItemType<GiantMeteorHeadBanner>();
					break;
				case 67:
					item = ModContent.ItemType<GraniteBeetleBanner>();
					break;
				case 68:
					item = ModContent.ItemType<GraniteBowmanBanner>();
					break;
				case 69:
					item = ModContent.ItemType<HallowerBanner>();
					break;
				case 70:
					item = ModContent.ItemType<HarpyWarriorBanner>();
					break;
				case 71:
					item = ModContent.ItemType<HostBanner>();
					break;
				case 72:
					item = ModContent.ItemType<IceBlazerBanner>();
					break;
				case 73:
					item = ModContent.ItemType<IronGiantBanner>();
					break;
				case 74:
					item = ModContent.ItemType<LeprechaunBanner>();
					break;
				case 75:
					item = ModContent.ItemType<Items.MechanicalFirefly>();
					break;
				case 76:
					item = ModContent.ItemType<MeteoriteGolemBanner>();
					break;
				case 77:
					item = ModContent.ItemType<MightyNimbusBanner>();
					break;
				case 78:
					item = ModContent.ItemType<MinotaurBanner>();
					break;
				case 79:
					item = ModContent.ItemType<NightTerrorBanner>();
					break;
				case 80:
					item = ModContent.ItemType<PharaohCasterBanner>();
					break;
				case 81:
					item = ModContent.ItemType<PhobosBanner>();
					break;
				case 82:
					item = ModContent.ItemType<PossessedHornetBanner>();
					break;
				case 83:
					item = ModContent.ItemType<PossessedHoundBanner>();
					break;
				case 84:
					item = ModContent.ItemType<QuartzBeetleBanner>();
					break;
				case 85:
					item = ModContent.ItemType<RogueBanner>();
					break;
				case 86:
					item = ModContent.ItemType<SandThingBanner>();
					break;
				case 87:
					item = ModContent.ItemType<ScaryBatBanner>();
					break;
				case 88:
					item = ModContent.ItemType<ShadowRipperBanner>();
					break;
				case 89:
					item = ModContent.ItemType<SightedBanner>();
					break;
				case 90:
					item = ModContent.ItemType<SkeletonKnightBanner>();
					break;
				case 91:
					item = ModContent.ItemType<SkullkerBanner>();
					break;
				case 92:
					item = ModContent.ItemType<SnowcopterBanner>();
					break;
				case 93:
					item = ModContent.ItemType<SnowmanBomberBanner>();
					break;
				case 94:
					item = ModContent.ItemType<SnowmanWarriorBanner>();
					break;
				case 95:
					item = ModContent.ItemType<TheAxemanBanner>();
					break;
				case 96:
					item = ModContent.ItemType<TheGirlBanner>();
					break;
				case 97:
					item = ModContent.ItemType<TheThingBanner>();
					break;
				case 98:
					item = ModContent.ItemType<ThiefBanner>();
					break;
				case 99:
					item = ModContent.ItemType<TwilightBatBanner>();
					break;
				default:
					return;
			}
			Item.NewItem(null, i * 16, j * 16, 16, 48, item);
		}

		public override void NearbyEffects(int i, int j, bool closer)
		{
			//TODO: I think this is handled automatically now so long as the Banner and BannerItem fields are set on ModNPC
			//if(closer)
			//{
			//	Player player = Main.player[Main.myPlayer];
			//	int style = Main.tile[i, j].TileFrameX / 18;
			//	switch(style)
			//	{
			//		case 0:
			//			player.NPCBannerBuff[ModContent.NPCType<Zarprute>()] = true;
			//			break;
			//		case 1:
			//			player.NPCBannerBuff[ModContent.NPCType<Zarprite>()] = true;
			//			break;
			//		case 2:
			//			player.NPCBannerBuff[ModContent.NPCType<UndeadWarrior1>()] = true;
			//			player.NPCBannerBuff[ModContent.NPCType<UndeadWarrior2>()] = true;
			//			player.NPCBannerBuff[ModContent.NPCType<UndeadWarrior3>()] = true;
			//			player.NPCBannerBuff[ModContent.NPCType<UndeadWarrior4>()] = true;
			//			break;
			//		case 3:
			//			player.NPCBannerBuff[ModContent.NPCType<Phantom>()] = true;
			//			break;
			//		case 4:
			//			player.NPCBannerBuff[ModContent.NPCType<Parasprite>()] = true;
			//			break;
			//		case 5:
			//			player.NPCBannerBuff[ModContent.NPCType<DarkDruid>()] = true;
			//			break;
			//		case 6:
			//			player.NPCBannerBuff[ModContent.NPCType<BloodmoonWarrior1>()] = true;
			//			player.NPCBannerBuff[ModContent.NPCType<BloodmoonWarrior2>()] = true;
			//			player.NPCBannerBuff[ModContent.NPCType<BloodmoonWarrior3>()] = true;
			//			break;
			//		case 7:
			//			player.NPCBannerBuff[ModContent.NPCType<Atis>()] = true;
			//			break;
			//		case 8:
			//			player.NPCBannerBuff[ModContent.NPCType<Orc>()] = true;
			//			break;
			//		case 9:
			//			player.NPCBannerBuff[ModContent.NPCType<OrcWarrior>()] = true;
			//			break;
			//		case 10:
			//			player.NPCBannerBuff[ModContent.NPCType<MushroomCreature>()] = true;
			//			break;
			//		case 11:
			//			player.NPCBannerBuff[ModContent.NPCType<HallowSlimer>()] = true;
			//			break;
			//		case 12:
			//			player.NPCBannerBuff[ModContent.NPCType<DeepwaterVilefish>()] = true;
			//			break;
			//		case 13:
			//			player.NPCBannerBuff[ModContent.NPCType<Crimer>()] = true;
			//			break;
			//		case 14:
			//			player.NPCBannerBuff[ModContent.NPCType<Bicholmere>()] = true;
			//			break;
			//		case 15:
			//			player.NPCBannerBuff[ModContent.NPCType<CrimsonBicholmere>()] = true;
			//			break;
			//		case 16:
			//			player.NPCBannerBuff[ModContent.NPCType<CorruptedBicholmere>()] = true;
			//			break;
			//		//case 17:
			//		//	player.NPCBannerBuff[ModContent.NPCType<ChatteringTeeth>()] = true;
			//		//	break;
			//		case 18:
			//			player.NPCBannerBuff[ModContent.NPCType<CaveGolem>()] = true;
			//			break;
			//		case 19:
			//			player.NPCBannerBuff[ModContent.NPCType<ArmoredJellyfish>()] = true;
			//			break;
			//		case 20:
			//			player.NPCBannerBuff[ModContent.NPCType<ArchDemon>()] = true;
			//			break;
			//		case 21:
			//			player.NPCBannerBuff[ModContent.NPCType<OmegaWolf>()] = true;
			//			break;
			//		case 22:
			//			player.NPCBannerBuff[ModContent.NPCType<BetaWolf>()] = true;
			//			break;
			//		case 23:
			//			player.NPCBannerBuff[ModContent.NPCType<AlphaWolf>()] = true;
			//			break;
			//		case 24:
			//			player.NPCBannerBuff[ModContent.NPCType<Abomination>()] = true;
			//			break;
			//		case 25:
			//			player.NPCBannerBuff[ModContent.NPCType<Blazer>()] = true;
			//			break;
			//		case 26:
			//			player.NPCBannerBuff[ModContent.NPCType<BoneFlyer>()] = true;
			//			break;
			//		case 27:
			//			player.NPCBannerBuff[ModContent.NPCType<Dinictis>()] = true;
			//			break;
			//		case 28:
			//			player.NPCBannerBuff[ModContent.NPCType<OrcSkeleton>()] = true;
			//			break;
			//		case 29:
			//			player.NPCBannerBuff[ModContent.NPCType<DragonSkull>()] = true;
			//			break;
			//		case 30:
			//			player.NPCBannerBuff[ModContent.NPCType<DungeonKeeper>()] = true;
			//			break;
			//		case 31:
			//			player.NPCBannerBuff[ModContent.NPCType<Flayer>()] = true;
			//			break;
			//		case 32:
			//			player.NPCBannerBuff[ModContent.NPCType<GiantCrab>()] = true;
			//			break;
			//		case 33:
			//			player.NPCBannerBuff[ModContent.NPCType<HeadlessZombie>()] = true;
			//			break;
			//		case 34:
			//			player.NPCBannerBuff[ModContent.NPCType<HeavyZombie>()] = true;
			//			break;
			//		case 35:
			//			player.NPCBannerBuff[ModContent.NPCType<HiveHeadZombie>()] = true;
			//			break;
			//		case 36:
			//			player.NPCBannerBuff[ModContent.NPCType<Observer>()] = true;
			//			break;
			//		case 37:
			//			player.NPCBannerBuff[ModContent.NPCType<Peepers>()] = true;
			//			break;
			//		case 38:
			//			player.NPCBannerBuff[ModContent.NPCType<PyramidHead>()] = true;
			//			break;
			//		case 39:
			//			player.NPCBannerBuff[ModContent.NPCType<SpiderMan>()] = true;
			//			break;
			//		case 40:
			//			player.NPCBannerBuff[ModContent.NPCType<SquidZombie>()] = true;
			//			break;
			//		case 41:
			//			player.NPCBannerBuff[ModContent.NPCType<SupremePossessedArmor>()] = true;
			//			break;
			//		case 42:
			//			player.NPCBannerBuff[ModContent.NPCType<Woody>()] = true;
			//			break;
			//		case 43:
			//			player.NPCBannerBuff[ModContent.NPCType<DevilishTortoise>()] = true;
			//			break;
			//		case 44:
			//			player.NPCBannerBuff[ModContent.NPCType<Agloomination>()] = true;
			//			break;
			//		case 45:
			//			player.NPCBannerBuff[ModContent.NPCType<AncientCursedSkull>()] = true;
			//			break;
			//		case 46:
			//			player.NPCBannerBuff[ModContent.NPCType<Banshee>()] = true;
			//			break;
			//		case 47:
			//			player.NPCBannerBuff[ModContent.NPCType<BoneArcher>()] = true;
			//			break;
			//		case 48:
			//			player.NPCBannerBuff[ModContent.NPCType<CloudSlime>()] = true;
			//			break;
			//		case 49:
			//			player.NPCBannerBuff[ModContent.NPCType<ConjurerSkeleton>()] = true;
			//			break;
			//		case 50:
			//			player.NPCBannerBuff[ModContent.NPCType<CoreBug>()] = true;
			//			break;
			//		case 51:
			//			player.NPCBannerBuff[ModContent.NPCType<CoreSlime>()] = true;
			//			break;
			//		case 52:
			//			player.NPCBannerBuff[ModContent.NPCType<Deimos>()] = true;
			//			break;
			//		case 53:
			//			player.NPCBannerBuff[ModContent.NPCType<Dranix>()] = true;
			//			break;
			//		case 54:
			//			player.NPCBannerBuff[ModContent.NPCType<DreadBeetle>()] = true;
			//			break;
			//		case 55:
			//			player.NPCBannerBuff[ModContent.NPCType<ElderObserver>()] = true;
			//			break;
			//		case 56:
			//			player.NPCBannerBuff[ModContent.NPCType<EnragedBat>()] = true;
			//			break;
			//		case 57:
			//			player.NPCBannerBuff[ModContent.NPCType<EvolvedZombie>()] = true;
			//			break;
			//		case 58:
			//			player.NPCBannerBuff[ModContent.NPCType<FallenWarrior1>()] = true;
			//			player.NPCBannerBuff[ModContent.NPCType<FallenWarrior2>()] = true;
			//			player.NPCBannerBuff[ModContent.NPCType<FallenWarrior3>()] = true;
			//			break;
			//		case 59:
			//			player.NPCBannerBuff[ModContent.NPCType<FatFlinx>()] = true;
			//			break;
			//		case 60:
			//			player.NPCBannerBuff[ModContent.NPCType<FireBeetle>()] = true;
			//			break;
			//		case 61:
			//			player.NPCBannerBuff[ModContent.NPCType<Flayer>()] = true;
			//			break;
			//		case 62:
			//			player.NPCBannerBuff[ModContent.NPCType<FrostBeetle>()] = true;
			//			break;
			//		case 63:
			//			player.NPCBannerBuff[ModContent.NPCType<GeneralSnowman>()] = true;
			//			break;
			//		case 64:
			//			player.NPCBannerBuff[ModContent.NPCType<GhostKnight>()] = true;
			//			break;
			//		case 65:
			//			player.NPCBannerBuff[ModContent.NPCType<GiantGastropod>()] = true;
			//			break;
			//		case 66:
			//			player.NPCBannerBuff[ModContent.NPCType<GiantMeteorHead>()] = true;
			//			break;
			//		case 67:
			//			player.NPCBannerBuff[ModContent.NPCType<GraniteBeetle>()] = true;
			//			break;
			//		case 68:
			//			player.NPCBannerBuff[ModContent.NPCType<GraniteBowman>()] = true;
			//			break;
			//		case 69:
			//			player.NPCBannerBuff[ModContent.NPCType<Hallower>()] = true;
			//			break;
			//		case 70:
			//			player.NPCBannerBuff[ModContent.NPCType<HarpyWarrior>()] = true;
			//			break;
			//		//case 71:
			//		//	player.NPCBannerBuff[ModContent.NPCType<Host>()] = true;
			//		//	break;
			//		case 72:
			//			player.NPCBannerBuff[ModContent.NPCType<IceBlazer>()] = true;
			//			break;
			//		case 73:
			//			player.NPCBannerBuff[ModContent.NPCType<IronGiant>()] = true;
			//			break;
			//		case 74:
			//			player.NPCBannerBuff[ModContent.NPCType<Leprechaun>()] = true;
			//			break;
			//		case 75:
			//			player.NPCBannerBuff[ModContent.NPCType<NPCs.MechanicalFirefly>()] = true;
			//			break;
			//		case 76:
			//			player.NPCBannerBuff[ModContent.NPCType<MeteoriteGolem>()] = true;
			//			break;
			//		case 77:
			//			player.NPCBannerBuff[ModContent.NPCType<MightyNimbus>()] = true;
			//			break;
			//		case 78:
			//			player.NPCBannerBuff[ModContent.NPCType<Minotaur>()] = true;
			//			break;
			//		case 79:
			//			player.NPCBannerBuff[ModContent.NPCType<NightTerror>()] = true;
			//			break;
			//		case 80:
			//			player.NPCBannerBuff[ModContent.NPCType<PharaohCaster>()] = true;
			//			break;
			//		case 81:
			//			player.NPCBannerBuff[ModContent.NPCType<Phobos>()] = true;
			//			break;
			//		case 82:
			//			player.NPCBannerBuff[ModContent.NPCType<PossessedHornet1>()] = true;
			//			player.NPCBannerBuff[ModContent.NPCType<PossessedHornet2>()] = true;
			//			break;
			//		case 83:
			//			player.NPCBannerBuff[ModContent.NPCType<PossessedHound>()] = true;
			//			break;
			//		case 84:
			//			player.NPCBannerBuff[ModContent.NPCType<QuartzBeetle>()] = true;
			//			break;
			//		case 85:
			//			player.NPCBannerBuff[ModContent.NPCType<Rogue>()] = true;
			//			break;
			//		case 86:
			//			player.NPCBannerBuff[ModContent.NPCType<SandThing>()] = true;
			//			break;
			//		case 87:
			//			player.NPCBannerBuff[ModContent.NPCType<ScaryBat>()] = true;
			//			break;
			//		case 88:
			//			player.NPCBannerBuff[ModContent.NPCType<ShadowRipper>()] = true;
			//			break;
			//		case 89:
			//			player.NPCBannerBuff[ModContent.NPCType<Sighted>()] = true;
			//			break;
			//		case 90:
			//			player.NPCBannerBuff[ModContent.NPCType<SkeletonKnight>()] = true;
			//			break;
			//		case 91:
			//			player.NPCBannerBuff[ModContent.NPCType<Skullker>()] = true;
			//			break;
			//		case 92:
			//			player.NPCBannerBuff[ModContent.NPCType<Snowcopter>()] = true;
			//			break;
			//		case 93:
			//			player.NPCBannerBuff[ModContent.NPCType<SnowmanBomber>()] = true;
			//			break;
			//		case 94:
			//			player.NPCBannerBuff[ModContent.NPCType<SnowmanWarrior>()] = true;
			//			break;
			//		case 95:
			//			player.NPCBannerBuff[ModContent.NPCType<TheAxeman>()] = true;
			//			break;
			//		case 96:
			//			player.NPCBannerBuff[ModContent.NPCType<TheGirl>()] = true;
			//			break;
			//		case 97:
			//			player.NPCBannerBuff[ModContent.NPCType<TheThing>()] = true;
			//			break;
			//		case 98:
			//			player.NPCBannerBuff[ModContent.NPCType<Thief1>()] = true;
			//			player.NPCBannerBuff[ModContent.NPCType<Thief2>()] = true;
			//			player.NPCBannerBuff[ModContent.NPCType<Thief3>()] = true;
			//			break;
			//		case 99:
			//			player.NPCBannerBuff[ModContent.NPCType<TwilightBat>()] = true;
			//			break;
			//		default:
			//			return;
			//	}
			//	player.hasBanner = true;
			//}
		}
	}
}