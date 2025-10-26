using Terraria;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;
using Tremor.Items;
using Tremor.Items.Souls;

namespace Tremor.Invasion
{
	public class EndlessPain:TremorModItem
	{
		public override void SetDefaults()
		{

			Item.damage = 215;
			Item.width = 18;
			Item.height = 56;
			Item.useTime = 18;
			Item.DamageType = DamageClass.Magic;
			Item.mana = 25;
			Item.shoot = ModContent.ProjectileType<EndlessPainPro>();
			Item.shootSpeed = 4f;
			Item.useAnimation = 18;
			Item.noMelee = true;
			Item.useStyle = 5;
			Item.noUseGraphic = true;
			Item.knockBack = 5;
			Item.value = 250000;
			Item.rare = 11;
			Item.UseSound = SoundID.Item44;
			Item.autoReuse = false;
			ItemID.Sets.ItemNoGravity[Item.type] = true;
		}

		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("The Endless Pain");
			/* Tooltip.SetDefault("Shoots a shadowflame orb\n" +
"Orb shoots shadowflames at nearby enemies"); */
			Main.RegisterItemAnimation(Item.type, new DrawAnimationVertical(5, 4));
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe();
			recipe.AddIngredient(ModContent.ItemType<EyeofOblivion>(), 1);
			recipe.AddIngredient(ModContent.ItemType<PhantomSoul>(), 20);
			recipe.AddIngredient(ModContent.ItemType<TimeTissue>(), 10);
			recipe.AddIngredient(ModContent.ItemType<NightmareBar>(), 5);
			recipe.AddTile(412);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}
