using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Tremor.Items
{
	public class RoyalEgg:TremorModItem
	{
		public override void SetDefaults()
		{
			Item.width = 30;
			Item.height = 34;
			Item.maxStack = 20;

			Item.rare = 11;
			Item.value = 150000;
			Item.useAnimation = 45;
			Item.useTime = 45;
			Item.useStyle = 4;
			Item.consumable = true;
		}

		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("Royal Egg");
			/* Tooltip.SetDefault("Summons the Brutallisk\n" +
"Requires the desert biome and Tremode"); */
		}

		public override bool CanUseItem(Player player)
		{
			return NPC.downedMoonlord && !NPC.AnyNPCs(ModContent.NPCType<NPCs.Brutallisk>()) && player.ZoneDesert;
		}

		public override bool? UseItem(Player player)
		{
			NPC.SpawnOnPlayer(player.whoAmI, ModContent.NPCType<NPCs.Brutallisk>());
			Terraria.Audio.SoundEngine.PlaySound(SoundID.Roar, player.position);//Variant 0
			return true;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe();
			recipe.AddIngredient(ItemID.GoldCoin, 25);
			recipe.AddIngredient(ItemID.Ruby, 1);
			recipe.AddIngredient(ItemID.Emerald, 1);
			recipe.AddIngredient(ItemID.Topaz, 1);
			recipe.AddIngredient(ItemID.Diamond, 1);
			recipe.AddIngredient(ItemID.Sapphire, 1);
			recipe.AddIngredient(ItemID.Amethyst, 1);
			recipe.AddIngredient(ModContent.ItemType<NightmareBar>(), 10);
			recipe.AddIngredient(ModContent.ItemType<ClusterShard>(), 5);
			recipe.AddIngredient(ModContent.ItemType<Phantaplasm>(), 8);
			recipe.SetResult(this);
			recipe.AddTile(134);
			recipe.AddRecipe();
		}
	}
}
