using Terraria.ID;
using Terraria.ModLoader;

namespace Tremor.Items.Bone
{
	public class itemBoneHook:TremorModItem
	{
		public override void SetDefaults()
		{

			Item.damage = 32;
			Item.DamageType = DamageClass.Melee;
			Item.width = 42;
			Item.height = 38;

			Item.useTime = 20;
			Item.useAnimation = 20;
			Item.useStyle = 2;
			Item.knockBack = 0;
			Item.value = 20000;
			Item.rare = 6;
			Item.UseSound = SoundID.Item1;
			Item.autoReuse = false;
			Item.shoot = ModContent.ProjectileType<Projectiles.projBoneHook>();
			Item.shootSpeed = 20;
			Item.noMelee = true;
			Item.noUseGraphic = true;
		}

		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("Bone Hook");
			// Tooltip.SetDefault("'Fresh meat!'");
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe();
			recipe.AddIngredient(ModContent.ItemType<PetrifiedSpike>(), 25);
			recipe.AddIngredient(ModContent.ItemType<SharpenedTooth>(), 6);
			recipe.AddIngredient(ItemID.SoulofNight, 9);
			recipe.AddIngredient(ItemID.SoulofLight, 9);
			recipe.AddIngredient(ItemID.Chain, 10);
			recipe.SetResult(this);
			recipe.AddTile(134);
			recipe.AddRecipe();
		}
	}
}
