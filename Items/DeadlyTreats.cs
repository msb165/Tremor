using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Tremor.Items
{

	public class DeadlyTreats:TremorModItem
	{
		public override void SetDefaults()
		{

			Item.width = 20;
			Item.height = 30;
			Item.maxStack = 20;
			Item.rare = 2;
			Item.useAnimation = 15;
			Item.useTime = 15;
			Item.useStyle = 2;
			Item.UseSound = SoundID.Item3;
			Item.consumable = true;
		}

		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("Deadly Treats");
			/* Tooltip.SetDefault("Increases life regeneration\n" +
"Lowers visibilty"); */
		}

		public override bool? UseItem(Player player)
		{
			player.AddBuff(22, 10000, true);
			player.AddBuff(2, 14400, true);
			player.AddBuff(6, 14400, true);
			return true;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe();
			recipe.AddIngredient(ItemID.Bowl, 1);
			recipe.AddIngredient(ModContent.ItemType<SpiderMeat>(), 1);
			recipe.AddIngredient(ItemID.VileMushroom, 2);
			recipe.SetResult(this);
			recipe.AddTile(96);
			recipe.AddRecipe();

			recipe = new ModRecipe();
			recipe.AddIngredient(ItemID.Bowl, 1);
			recipe.AddIngredient(ModContent.ItemType<SpiderMeat>(), 1);
			recipe.AddIngredient(ItemID.ViciousMushroom, 2);
			recipe.SetResult(this);
			recipe.AddTile(96);
			recipe.AddRecipe();
		}
	}
}
