using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Tremor.NPCs;

namespace Tremor.Items
{
	public class StormJelly:TremorModItem
	{
		public override void SetDefaults()
		{

			Item.width = 28;
			Item.height = 32;
			Item.maxStack = 20;
			Item.useTurn = true;
			Item.autoReuse = false;
			Item.useAnimation = 18;
			Item.useTime = 18;
			Item.useStyle = 1;
			Item.consumable = true;
			Item.value = 150;
		}

		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("Storm Jelly");
			/* Tooltip.SetDefault("Summons Storm Jellyfish\n" +
"Requires EoC to have been slain"); */
		}

		public override bool CanUseItem(Player player)
		{
			return NPC.downedBoss1 && !NPC.AnyNPCs(ModContent.NPCType<StormJellyfish>());
		}

		public override bool? UseItem(Player player)
		{
			NPC.SpawnOnPlayer(player.whoAmI, ModContent.NPCType<StormJellyfish>());
			Terraria.Audio.SoundEngine.PlaySound(SoundID.Roar, player.position);//Variant 0
			return true;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe();
			recipe.AddIngredient(ItemID.Gel, 25);
			recipe.AddIngredient(ModContent.ItemType<SeaFragment>(), 12);
			recipe.AddIngredient(ItemID.Glowstick, 15);
			recipe.AddIngredient(ItemID.Seashell, 3);
			recipe.AddTile(16);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}
