using Terraria.ID;
using Terraria.ModLoader;

namespace Tremor.NPCs.Bosses.NovaPillar.Items.Weapons
{
	public class NovaPickaxe:TremorModItem
	{
		public override void SetDefaults()
		{
			item.damage = 80;
			item.DamageType = DamageClass.Melee;
			item.width = 38;
			item.height = 38;
			item.useTime = 7;
			item.useAnimation = 11;
			item.pick = 225;
			item.useStyle = 1;
			item.knockBack = 5;
			item.value = 50000;
			item.rare = 10;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
			item.tileBoost += 4;
			item.useTurn = true;
		}

		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Nova Pickaxe");
			Tooltip.SetDefault("");
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
