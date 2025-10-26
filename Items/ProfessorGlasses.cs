using Terraria.ModLoader;

namespace Tremor.Items
{
	[AutoloadEquip(EquipType.Head)]
	public class ProfessorGlasses:TremorModItem
	{

		public override void SetDefaults()
		{

			Item.width = 22;
			Item.height = 10;
			Item.value = 100;
			Item.rare = 2;
			Item.vanity = true;
		}

		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("Professor Glasses");
			// Tooltip.SetDefault("");
		}

		//TODO: [Skipped for 1.4] DrawHair
		//public override void DrawHair(ref bool drawHair, ref bool drawAltHair)
		//{
		//	drawHair = true;
		//}
	}
}
