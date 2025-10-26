using Terraria.ID;
using Terraria.ModLoader;

namespace Tremor.NPCs.Bosses.NovaPillar.Items.Weapons
{
	public class NovaHamaxe:TremorModItem
	{
		public override void SetDefaults()
		{
			Item.damage = 60;
			Item.DamageType = DamageClass.Melee;
			Item.width = 38;
			Item.height = 38;
			Item.useTime = 9;
			Item.useAnimation = 27;
			Item.axe = 20;
			Item.hammer = 150;
			Item.useStyle = 1;
			Item.knockBack = 5;
			Item.value = 50000;
			Item.rare = 10;
			Item.UseSound = SoundID.Item1;
			Item.autoReuse = true;
			Item.tileBoost += 4;
			Item.useTurn = true;
		}

		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("Nova Hamaxe");
			// Tooltip.SetDefault("");
			TremorGlowMask.AddGlowMask(this);
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe();
			recipe.AddIngredient(ModContent.ItemType<NovaFragment>(), 14);
			recipe.AddIngredient(3467, 12);
			recipe.AddTile(412);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}
