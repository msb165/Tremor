using Terraria.ID;
using Terraria.ModLoader;

namespace Tremor.Items.Bone
{
	public class BoneKnife:TremorModItem
	{
		public override void SetDefaults()
		{

			Item.damage = 83;
			Item.DamageType = DamageClass.Throwing;
			Item.width = 26;
			Item.noUseGraphic = true;
			Item.maxStack = 999;
			Item.consumable = true;
			Item.height = 30;
			Item.useTime = 20;
			Item.useAnimation = 20;
			Item.shoot = ModContent.ProjectileType<Projectiles.BoneKnifePro>();
			Item.shootSpeed = 18f;
			Item.useStyle = 1;
			Item.knockBack = 4;
			Item.value = 7;
			Item.rare = 6;
			Item.UseSound = SoundID.Item1;
			Item.autoReuse = true;
		}

		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("Bone Knife");
			// Tooltip.SetDefault("");
		}

	}
}
