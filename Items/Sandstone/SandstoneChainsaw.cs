using Terraria.ID;
using Terraria.ModLoader;
using Tremor.Items.Antlion;

namespace Tremor.Items.Sandstone
{

	public class SandstoneChainsaw:TremorModItem
	{
		public override void SetDefaults()
		{

			Item.damage = 16;
			Item.DamageType = DamageClass.Melee;
			Item.width = 20;
			Item.height = 12;
			Item.useTime = 15;
			Item.useAnimation = 25;
			Item.channel = true;
			Item.noUseGraphic = true;
			Item.noMelee = true;
			Item.axe = 15;
			Item.useStyle = 5;
			Item.knockBack = 6;
			Item.value = 13500;
			Item.rare = 1;
			Item.UseSound = SoundID.Item23;
			Item.autoReuse = true;
			Item.shoot = ModContent.ProjectileType<Projectiles.SandstoneChainsawPro>();
			Item.shootSpeed = 40f;
		}

		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("Dune Chainsaw");
			// Tooltip.SetDefault("");
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe();
			recipe.AddIngredient(ModContent.ItemType<AntlionShell>(), 1);
			recipe.AddIngredient(ItemID.Topaz, 3);
			recipe.AddIngredient(ItemID.AntlionMandible, 5);
			recipe.AddTile(16);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}
