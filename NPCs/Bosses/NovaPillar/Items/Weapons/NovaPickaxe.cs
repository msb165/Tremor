using Terraria.ID;
using Terraria.ModLoader;

namespace Tremor.NPCs.Bosses.NovaPillar.Items.Weapons
{
	public class NovaPickaxe:TremorModItem
	{
		public override void SetDefaults()
		{
			Item.damage = 80;
			Item.DamageType = DamageClass.Melee;
			Item.width = 38;
			Item.height = 38;
			Item.useTime = 7;
			Item.useAnimation = 11;
			Item.pick = 225;
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
			// DisplayName.SetDefault("Nova Pickaxe");
			// Tooltip.SetDefault("");
			TremorGlowMask.AddGlowMask(this);
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe();
			recipe.AddIngredient(ModContent.ItemType<NovaFragment>(), 12);
			recipe.AddIngredient(3467, 10);
			recipe.AddTile(412);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}
