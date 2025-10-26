using Terraria;
using Terraria.DataStructures;
using Terraria.ModLoader;

namespace Tremor.Items.Sparks
{
	public class GunslingerSpark:TremorModItem
	{
		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("Gunslinger Spark");
			/* Tooltip.SetDefault("3% increased ranged damage\n" +
							   "8% increased ranged critical strike chance"); */
			Main.RegisterItemAnimation(Item.type, new DrawAnimationVertical(6, 4));
		}

		public override void SetDefaults()
		{
			Item.width = 22;
			Item.height = 22;
			Item.rare = 1;
			Item.accessory = true;
			Item.value = Item.buyPrice(silver: 1);
		}

		public override void UpdateAccessory(Player player, bool hideVisual)
		{
			player.GetDamage(DamageClass.Ranged) += 0.03f;
			player.GetCritChance(DamageClass.Ranged) += 8;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe();
			recipe.AddIngredient(ModContent.ItemType<AdventurerSpark>());
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}
