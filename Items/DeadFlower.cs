using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Tremor.Items.Flesh;

namespace Tremor.Items
{
	public class DeadFlower:TremorModItem
	{
		public override void SetDefaults()
		{

			Item.damage = 12;
			Item.DamageType = DamageClass.Magic;
			Item.mana = 4;
			Item.width = 40;
			Item.height = 40;
			Item.useTime = 25;
			Item.useAnimation = 25;
			Item.useStyle = 5;
			Item.staff[Item.type] = true; //this makes the useStyle animate as a staff instead of as a gun
			Item.noMelee = true; //so the item's animation doesn't do damage
			Item.knockBack = 5;
			Item.value = 700;
			Item.rare = 2;
			Item.UseSound = SoundID.Item20;
			Item.autoReuse = true;
			Item.shoot = ModContent.ProjectileType<Projectiles.DeadFlowerPro>();
			Item.shootSpeed = 15f;
		}

		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("Dead Flower");
			// Tooltip.SetDefault("");
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe();
			recipe.AddIngredient(ItemID.Wood, 12);
			recipe.AddIngredient(ModContent.ItemType<UntreatedFlesh>(), 5);
			recipe.AddIngredient(ItemID.Lens, 2);
			recipe.AddIngredient(ItemID.FallenStar, 1);
			recipe.SetResult(this);
			recipe.AddTile(ModContent.TileType<Tiles.FleshWorkstationTile>());
			recipe.AddRecipe();
		}
	}
}
