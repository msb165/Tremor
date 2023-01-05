using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Tremor.Items.Souls;
using Tremor.NPCs.Bosses.NovaPillar.Items.Armor;

namespace Tremor.Items
{
	[AutoloadEquip(EquipType.Body)]
	public class WhiteMasterChestplate:TremorModItem
	{
		public override void SetDefaults()
		{
			item.width = 34;
			item.height = 20;
			item.value = 50000;
			item.rare = 11;
			item.defense = 33;
		}

		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("White Master Chestplate");
			Tooltip.SetDefault("Massively increases alchemical damage as health lowers\n" +
"30% increased alchemical damage\n" +
"Enemy attacks have 10% chance to do no damage to you\n" +
"Immune to cursed inferno, lava, and can move through liquids");
		}

		public override void UpdateEquip(Player player)
		{
			TremorPlayer modPlayer = player.GetModPlayer<TremorPlayer>();
			modPlayer.zellariumBody = true;
			player.lavaImmune = true;
			player.ignoreWater = true;
			player.GetModPlayer<MPlayer>().alchemicalDamage += 0.3f;
			player.buffImmune[BuffID.CursedInferno] = true;
			if (player.statLife <= player.statLifeMax2)
			{
				player.GetModPlayer<MPlayer>().alchemicalDamage += 0.3f;
			}
			if (player.statLife <= 400)
			{
				player.GetModPlayer<MPlayer>().alchemicalDamage += 0.4f;
			}
			if (player.statLife <= 300)
			{
				player.GetModPlayer<MPlayer>().alchemicalDamage += 0.5f;
			}
			if (player.statLife <= 200)
			{
				player.GetModPlayer<MPlayer>().alchemicalDamage += 0.6f;
			}
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ModContent.ItemType<BrokenHeroArmorplate>(), 1);
			recipe.AddIngredient(ModContent.ItemType<NovaBreastplate>(), 1);
			recipe.AddIngredient(ModContent.ItemType<Aquamarine>(), 8);
			recipe.AddIngredient(ModContent.ItemType<SoulofFight>(), 14);
			recipe.AddIngredient(ModContent.ItemType<Phantaplasm>(), 8);
			recipe.SetResult(this);
			recipe.AddTile(412);
			recipe.AddRecipe();
		}
	}
}
