using Terraria;
using Terraria.Audio;
using Terraria.ID;
using Terraria.ModLoader;
using Tremor.Items;
using Tremor.Items.Souls;

namespace Tremor.Invasion
{
	public class AncientWatch:TremorModItem
	{
		public override void SetDefaults()
		{

			item.width = 40;
			item.height = 28;
			item.maxStack = 20;
			item.value = 100;
			item.rare = 11;
			item.useAnimation = 15;
			item.useTime = 15;
			item.useStyle = 4;
			item.consumable = true;

		}

		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Ancient Watch");
			Tooltip.SetDefault("Summons Paradox Cohort");
		}

		public override bool CanUseItem(Player player)
		{
			CyberWrathInvasion modPlayer = Main.LocalPlayer.GetModPlayer<CyberWrathInvasion>();
			if (InvasionWorld.CyberWrath)
				return false;
			return true;
		}

		public override bool? UseItem(Player player)
		{
			CyberWrathInvasion modPlayer = Main.LocalPlayer.GetModPlayer<CyberWrathInvasion>();
			Main.NewText("Paradox Cohort is striking from nowhere!", 39, 86, 134);
			SoundEngine.PlaySound(SoundID.SoundByIndex[(ushort)MusicLoader.GetMusicSlot(Mod, "Sounds/Music/Wrath1")], player.position);//Variant 0
			Terraria.Audio.SoundEngine.PlaySound(SoundID.SoundByIndex[15], player.position);//Variant 0
			if (Main.netMode != 1)
			{
				NPC.NewNPC(null, (int)player.Center.X, (int)player.Center.Y - 200, ModContent.NPCType<Titan_>());
			}
			InvasionWorld.CyberWrath = true;
			return true;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe();
			recipe.AddIngredient(ModContent.ItemType<NightmareBar>(), 5);
			recipe.AddIngredient(ModContent.ItemType<SoulofFight>(), 3);
			recipe.AddIngredient(ItemID.Glass, 5);
			recipe.AddIngredient(ModContent.ItemType<HuskofDusk>(), 2);
			recipe.AddIngredient(ModContent.ItemType<LapisLazuli>(), 1);
			recipe.SetResult(this);
			recipe.AddTile(ModContent.TileType<Tiles.StarvilTile>());
			recipe.AddRecipe();
		}
	}
}
