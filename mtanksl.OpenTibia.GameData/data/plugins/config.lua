﻿plugins = {
	actions = {
		-- { type = "PlayerRotateItem", opentibiaid = 1740, filename = "rotate item.lua" },
		-- { type = "PlayerUseItem", opentibiaid = 1740, filename = "use item.lua" },
		-- { type = "PlayerUseItemWithItem", opentibiaid = 2580, allowfaruse = true, filename = "use item with item.lua" },
		-- { type = "PlayerUseItemWithCreature", opentibiaid = 2580, allowfaruse = true, filename = "use item with creature.lua" },
		-- { type = "PlayerMoveItem", opentibiaid = 1740, filename = "move item.lua" },
		-- { type = "PlayerMoveCreature", name = "Monster Name", filename = "move creature.lua" }
	},
	movements = {
		-- { type = "CreatureStepIn", opentibiaid = 446, filename = "step in.lua" },
		-- { type = "CreatureStepOut", opentibiaid = 446, filename = "step out.lua" }
	},
	talkactions = {
		-- { type = "PlayerSay", message = "/hello", filename = "say.lua" }
	},
	npcs = {
		-- { type = "Dialogue", name = "Npc Name", filename = "default.lua" }
	},
	spells = {
		{ words = "exani tera", name = "Magic Rope", group = "Support", cooldown = 2, groupcooldown = 2, level = 9, mana = 20, soul = 0, premium = true, vocations = { vocation.knight, vocation.paladin, vocation.druid, vocation.sorcerer, vocation.eliteknight, vocation.royalpaladin, vocation.elderdruid, vocation.mastersorcerer }, requirestarget = false, filename = "OpenTibia.GameData.Plugins.Spells.MagicRopeSpellPlugin" },
		{ words = "exani hur up", name = "Levitate", group = "Support", cooldown = 2, groupcooldown = 2, level = 12, mana = 50, soul = 0, premium = true, vocations = { vocation.knight, vocation.paladin, vocation.druid, vocation.sorcerer, vocation.eliteknight, vocation.royalpaladin, vocation.elderdruid, vocation.mastersorcerer }, requirestarget = false, filename = "OpenTibia.GameData.Plugins.Spells.LevitateUpSpellPlugin" },
		{ words = "exani hur down", name = "Levitate", group = "Support", cooldown = 2, groupcooldown = 2, level = 12, mana = 50, soul = 0, premium = true, vocations = { vocation.knight, vocation.paladin, vocation.druid, vocation.sorcerer, vocation.eliteknight, vocation.royalpaladin, vocation.elderdruid, vocation.mastersorcerer }, requirestarget = false, filename = "OpenTibia.GameData.Plugins.Spells.LevitateDownSpellPlugin" },
		{ words = "utevo lux", name = "Light", group = "Support", cooldown = 2, groupcooldown = 2, level = 8, mana = 20, soul = 0, premium = false, vocations = { vocation.knight, vocation.paladin, vocation.druid, vocation.sorcerer, vocation.eliteknight, vocation.royalpaladin, vocation.elderdruid, vocation.mastersorcerer }, requirestarget = false, filename = "OpenTibia.GameData.Plugins.Spells.LightSpellPlugin" },
		{ words = "utevo gran lux", name = "Great Light", group = "Support", cooldown = 2, groupcooldown = 2, level = 13, mana = 60, soul = 0, premium = false, vocations = { vocation.knight, vocation.paladin, vocation.druid, vocation.sorcerer, vocation.eliteknight, vocation.royalpaladin, vocation.elderdruid, vocation.mastersorcerer }, requirestarget = false, filename = "OpenTibia.GameData.Plugins.Spells.GreatLightSpellPlugin" },
		{ words = "utevo vis lux", name = "Ultimate Light", group = "Support", cooldown = 2, groupcooldown = 2, level = 26, mana = 140, soul = 0, premium = true, vocations = { vocation.druid, vocation.sorcerer, vocation.elderdruid, vocation.mastersorcerer }, requirestarget = false, filename = "OpenTibia.GameData.Plugins.Spells.UltimateLightSpellPlugin" },
		{ words = "utana vid", name = "Invisible", group = "Support", cooldown = 2, groupcooldown = 2, level = 35, mana = 440, soul = 0, premium = false, vocations = { vocation.druid, vocation.sorcerer, vocation.elderdruid, vocation.mastersorcerer }, requirestarget = false, filename = "OpenTibia.GameData.Plugins.Spells.InvisibleSpellPlugin" },
		{ words = "utani hur", name = "Haste", group = "Support", cooldown = 2, groupcooldown = 2, level = 14, mana = 60, soul = 0, premium = true, vocations = { vocation.knight, vocation.paladin, vocation.druid, vocation.sorcerer, vocation.eliteknight, vocation.royalpaladin, vocation.elderdruid, vocation.mastersorcerer }, requirestarget = false, filename = "OpenTibia.GameData.Plugins.Spells.HasteSpellPlugin" },
		{ words = "utani gran hur", name = "Strong Haste", group = "Support", cooldown = 2, groupcooldown = 2, level = 20, mana = 100, soul = 0, premium = true, vocations = { vocation.druid, vocation.sorcerer, vocation.elderdruid, vocation.mastersorcerer }, requirestarget = false, filename = "OpenTibia.GameData.Plugins.Spells.StrongHasteSpellPlugin" },
		{ words = "utamo vita", name = "Magic Shield", group = "Support", cooldown = 14, groupcooldown = 2, level = 14, mana = 50, soul = 0, premium = false, vocations = { vocation.druid, vocation.sorcerer, vocation.elderdruid, vocation.mastersorcerer }, requirestarget = false, filename = "OpenTibia.GameData.Plugins.Spells.MagicShieldSpellPlugin" },

		{ words = "exana pox", name = "Cure Poison", group = "Healing", cooldown = 6, groupcooldown = 1, level = 10, mana = 30, soul = 0, premium = false, vocations = { vocation.knight, vocation.paladin, vocation.druid, vocation.sorcerer, vocation.eliteknight, vocation.royalpaladin, vocation.elderdruid, vocation.mastersorcerer }, requirestarget = false, filename = "OpenTibia.GameData.Plugins.Spells.CurePoisonSpellPlugin" },
		{ words = "exura", name = "Light Healing", group = "Healing", cooldown = 1, groupcooldown = 1, level = 8, mana = 20, soul = 0, premium = false, vocations = { vocation.paladin, vocation.druid, vocation.sorcerer, vocation.royalpaladin, vocation.elderdruid, vocation.mastersorcerer }, requirestarget = false, filename = "OpenTibia.GameData.Plugins.Spells.LightHealingSpellPlugin" },
		{ words = "exura gran", name = "Intense Healing", group = "Healing", cooldown = 1, groupcooldown = 1, level = 20, mana = 70, soul = 0, premium = false, vocations = { vocation.paladin, vocation.druid, vocation.sorcerer, vocation.royalpaladin, vocation.elderdruid, vocation.mastersorcerer }, requirestarget = false, filename = "OpenTibia.GameData.Plugins.Spells.IntenseHealingSpellPlugin" },
		{ words = "exura ico", name = "Wound Cleansing", group = "Healing", cooldown = 1, groupcooldown = 1, level = 8, mana = 40, soul = 0, premium = false, vocations = { vocation.knight, vocation.eliteknight }, requirestarget = false, filename = "OpenTibia.GameData.Plugins.Spells.WoundCleansingSpellPlugin" },
		{ words = "exura san", name = "Divine Healing", group = "Healing", cooldown = 1, groupcooldown = 1, level = 35, mana = 160, soul = 0, premium = false, vocations = { vocation.paladin, vocation.royalpaladin }, requirestarget = false, filename = "OpenTibia.GameData.Plugins.Spells.DivineHealingSpellPlugin" },
		{ words = "exura vita", name = "Ultimate Healing", group = "Healing", cooldown = 1, groupcooldown = 1, level = 30, mana = 160, soul = 0, premium = false, vocations = { vocation.druid, vocation.sorcerer, vocation.elderdruid, vocation.mastersorcerer }, requirestarget = false, filename = "OpenTibia.GameData.Plugins.Spells.UltimateHealingSpellPlugin" },
		{ words = "exura gran mas res", name = "Mass Healing", group = "Healing", cooldown = 2, groupcooldown = 1, level = 36, mana = 150, soul = 0, premium = true, vocations = { vocation.druid, vocation.elderdruid }, requirestarget = false, filename = "OpenTibia.GameData.Plugins.Spells.MassHealingSpellPlugin" },

		{ words = "exori mort", name = "Death Strike", group = "Attack", cooldown = 2, groupcooldown = 2, level = 16, mana = 20, soul = 0, premium = true, vocations = { vocation.sorcerer, vocation.mastersorcerer }, requirestarget = false, filename = "OpenTibia.GameData.Plugins.Spells.DeathStrikeSpellPlugin" },
		{ words = "exori flam", name = "Flame Strike", group = "Attack", cooldown = 2, groupcooldown = 2, level = 14, mana = 20, soul = 0, premium = true, vocations = { vocation.druid, vocation.sorcerer, vocation.elderdruid, vocation.mastersorcerer }, requirestarget = false, filename = "OpenTibia.GameData.Plugins.Spells.FlameStrikeSpellPlugin" },
		{ words = "exori vis", name = "Energy Strike", group = "Attack", cooldown = 2, groupcooldown = 2, level = 12, mana = 20, soul = 0, premium = true, vocations = { vocation.druid, vocation.sorcerer, vocation.elderdruid, vocation.mastersorcerer }, requirestarget = false, filename = "OpenTibia.GameData.Plugins.Spells.EnergyStrikeSpellPlugin" },
		{ words = "exevo flam hur", name = "Fire Wave", group = "Attack", cooldown = 4, groupcooldown = 2, level = 18, mana = 25, soul = 0, premium = false, vocations = { vocation.sorcerer, vocation.mastersorcerer }, requirestarget = false, filename = "fire wave.lua" },
		{ words = "exevo vis lux", name = "Energy Beam", group = "Attack", cooldown = 4, groupcooldown = 2, level = 23, mana = 40, soul = 0, premium = false, vocations = { vocation.sorcerer, vocation.mastersorcerer }, requirestarget = false, filename = "OpenTibia.GameData.Plugins.Spells.EnergyBeamSpellPlugin" },
		{ words = "exevo gran vis lux", name = "Great Energy Beam", group = "Attack", cooldown = 6, groupcooldown = 2, level = 29, mana = 110, soul = 0, premium = false, vocations = { vocation.sorcerer, vocation.mastersorcerer }, requirestarget = false, filename = "OpenTibia.GameData.Plugins.Spells.GreatEnergyBeamSpellPlugin" },
		{ words = "exevo vis hur", name = "Energy Wave", group = "Attack", cooldown = 8, groupcooldown = 2, level = 38, mana = 170, soul = 0, premium = false, vocations = { vocation.sorcerer, vocation.mastersorcerer }, requirestarget = false, filename = "OpenTibia.GameData.Plugins.Spells.EnergyWaveSpellPlugin" },
		{ words = "exevo gran mas vis", name = "Rage of the Skies", group = "Attack", cooldown = 40, groupcooldown = 4, level = 55, mana = 600, soul = 0, premium = true, vocations = { vocation.sorcerer, vocation.mastersorcerer }, requirestarget = false, filename = "OpenTibia.GameData.Plugins.Spells.RageOfTheSkiesSpellPlugin" },
		{ words = "exevo gran mas flam", name = "Hell's Core", group = "Attack", cooldown = 40, groupcooldown = 4, level = 60, mana = 1100, soul = 0, premium = true, vocations = { vocation.sorcerer, vocation.mastersorcerer }, requirestarget = false, filename = "OpenTibia.GameData.Plugins.Spells.HellsCoreSpellPlugin" },
		{ words = "exevo gran mas tera", name = "Wrath of Nature", group = "Attack", cooldown = 40, groupcooldown = 4, level = 55, mana = 700, soul = 0, premium = true, vocations = { vocation.druid, vocation.elderdruid }, requirestarget = false, filename = "OpenTibia.GameData.Plugins.Spells.WrathOfNatureSpellPlugin" },
		{ words = "exevo gran mas frigo", name = "Eternal Winter", group = "Attack", cooldown = 40, groupcooldown = 4, level = 60, soul = 0, mana = 1050, premium = true, vocations = { vocation.druid, vocation.elderdruid }, requirestarget = false, filename = "OpenTibia.GameData.Plugins.Spells.EternalWinterSpellPlugin" },
		{ words = "exori mas", name = "Groundshaker", group = "Attack", cooldown = 8, groupcooldown = 2, level = 33, mana = 160, soul = 0, premium = true, vocations = { vocation.knight, vocation.eliteknight }, requirestarget = false, filename = "OpenTibia.GameData.Plugins.Spells.GroundshakerSpellPlugin" },
		{ words = "exori", name = "Berserk", group = "Attack", cooldown = 4, groupcooldown = 2, level = 35, mana = 115, soul = 0, premium = true, vocations = { vocation.knight, vocation.eliteknight }, requirestarget = false, filename = "OpenTibia.GameData.Plugins.Spells.BerserkSpellPlugin" },
		{ words = "exori gran", name = "Fierce Berserk", group = "Attack", cooldown = 6, groupcooldown = 2, level = 90, mana = 340, soul = 0, premium = true, vocations = { vocation.knight, vocation.eliteknight }, requirestarget = false, filename = "OpenTibia.GameData.Plugins.Spells.FierceBerserkSpellPlugin" },

		{ words = "exevo pan", name = "Food", group = "Support", cooldown = 2, groupcooldown = 2, level = 14, mana = 120, soul = 1, premium = false, vocations = { vocation.druid, vocation.elderdruid }, requirestarget = false, filename = "OpenTibia.GameData.Plugins.Spells.FoodSpellPlugin" },
		{ words = "exevo con", name = "Conjure Arrow", group = "Support", cooldown = 2, groupcooldown = 2, level = 13, mana = 100, soul = 1, conjureopentibiaid = 2544, conjurecount = 10, premium = false, vocations = { vocation.paladin, vocation.royalpaladin }, requirestarget = false, filename = "OpenTibia.GameData.Plugins.Spells.ConjureItemSpellPlugin" },
		{ words = "exevo con pox", name = "Poisoned Arrow", group = "Support", cooldown = 2, groupcooldown = 2, level = 16, mana = 130, soul = 2, conjureopentibiaid = 2545, conjurecount = 7, premium = false, vocations = { vocation.paladin, vocation.royalpaladin }, requirestarget = false, filename = "OpenTibia.GameData.Plugins.Spells.ConjureItemSpellPlugin" },
		{ words = "exevo con flam", name = "Explosive Arrow", group = "Support", cooldown = 2, groupcooldown = 2, level = 25, mana = 290, soul = 3, conjureopentibiaid = 2546, conjurecount = 8, premium = false, vocations = { vocation.paladin, vocation.royalpaladin }, requirestarget = false, filename = "OpenTibia.GameData.Plugins.Spells.ConjureItemSpellPlugin" },
		{ words = "exevo con hur", name = "Conjure Sniper Arrow", group = "Support", cooldown = 2, groupcooldown = 2, level = 24, mana = 160, soul = 3, conjureopentibiaid = 7364, conjurecount = 5, premium = true, vocations = { vocation.paladin, vocation.royalpaladin }, requirestarget = false, filename = "OpenTibia.GameData.Plugins.Spells.ConjureItemSpellPlugin" },
		{ words = "exevo con mort", name = "Conjure Bolt", group = "Support", cooldown = 2, groupcooldown = 2, level = 17, mana = 140, soul = 2, conjureopentibiaid = 2543, conjurecount = 5, premium = true, vocations = { vocation.paladin, vocation.royalpaladin }, requirestarget = false, filename = "OpenTibia.GameData.Plugins.Spells.ConjureItemSpellPlugin" },
		{ words = "exevo con grav", name = "Conjure Piercing Bolt", group = "Support", cooldown = 2, groupcooldown = 2, level = 33, mana = 180, soul = 3, conjureopentibiaid = 7363, conjurecount = 5, premium = true, vocations = { vocation.paladin, vocation.royalpaladin }, requirestarget = false, filename = "OpenTibia.GameData.Plugins.Spells.ConjureItemSpellPlugin" },
		{ words = "exevo con vis", name = "Power Bolt", group = "Support", cooldown = 2, groupcooldown = 2, level = 59, mana = 700, soul = 4, conjureopentibiaid = 2547, conjurecount = 10, premium = true, vocations = { vocation.paladin, vocation.royalpaladin }, requirestarget = false, filename = "OpenTibia.GameData.Plugins.Spells.ConjureItemSpellPlugin" },

		{ words = "adevo grav pox", name = "Poison Field Rune", group = "Support", cooldown = 2, groupcooldown = 2, level = 14, mana = 200, soul = 1, conjureopentibiaid = 2285, conjurecount = 3, premium = false, vocations = { vocation.druid, vocation.sorcerer, vocation.elderdruid, vocation.mastersorcerer }, requirestarget = false, filename = "OpenTibia.GameData.Plugins.Spells.ConjureRuneSpellPlugin" },
		{ words = "adori min vis", name = "Light Magic Missile Rune", group = "Support", cooldown = 2, groupcooldown = 2, level = 15, mana = 120, soul = 1, conjureopentibiaid = 2287, conjurecount = 10, premium = false, vocations = { vocation.druid, vocation.sorcerer, vocation.elderdruid, vocation.mastersorcerer }, requirestarget = false, filename = "OpenTibia.GameData.Plugins.Spells.ConjureRuneSpellPlugin" },
		{ words = "adevo grav flam", name = "Fire Field Rune", group = "Support", cooldown = 2, groupcooldown = 2, level = 15, mana = 240, soul = 1, conjureopentibiaid = 2301, conjurecount = 3, premium = false, vocations = { vocation.druid, vocation.sorcerer, vocation.elderdruid, vocation.mastersorcerer }, requirestarget = false, filename = "OpenTibia.GameData.Plugins.Spells.ConjureRuneSpellPlugin" },
		{ words = "adori flam", name = "Fireball Rune", group = "Support", cooldown = 2, groupcooldown = 2, level = 27, mana = 460, soul = 3, conjureopentibiaid = 2302, conjurecount = 5, premium = true, vocations = { vocation.sorcerer, vocation.mastersorcerer }, requirestarget = false, filename = "OpenTibia.GameData.Plugins.Spells.ConjureRuneSpellPlugin" },
		{ words = "adevo grav vis", name = "Energy Field Rune", group = "Support", cooldown = 2, groupcooldown = 2, level = 18, mana = 320, soul = 2, conjureopentibiaid = 2277, conjurecount = 3, premium = false, vocations = { vocation.druid, vocation.sorcerer, vocation.elderdruid, vocation.mastersorcerer }, requirestarget = false, filename = "OpenTibia.GameData.Plugins.Spells.ConjureRuneSpellPlugin" },
		{ words = "adori tera", name = "Stalagmite Rune", group = "Support", cooldown = 2, groupcooldown = 2, level = 24, mana = 350, soul = 2, conjureopentibiaid = 2292, conjurecount = 10, premium = false, vocations = { vocation.druid, vocation.sorcerer, vocation.elderdruid, vocation.mastersorcerer }, requirestarget = false, filename = "OpenTibia.GameData.Plugins.Spells.ConjureRuneSpellPlugin" },
		{ words = "adori mas flam", name = "Great Fireball Rune", group = "Support", cooldown = 2, groupcooldown = 2, level = 30, mana = 530, soul = 3, conjureopentibiaid = 2304, conjurecount = 4, premium = false, vocations = { vocation.druid, vocation.sorcerer, vocation.elderdruid, vocation.mastersorcerer }, requirestarget = false, filename = "OpenTibia.GameData.Plugins.Spells.ConjureRuneSpellPlugin" },
		{ words = "adori vis", name = "Heavy Magic Missile Rune", group = "Support", cooldown = 2, groupcooldown = 2, level = 25, mana = 350, soul = 2, conjureopentibiaid = 2311, conjurecount = 10, premium = false, vocations = { vocation.druid, vocation.sorcerer, vocation.elderdruid, vocation.mastersorcerer }, requirestarget = false, filename = "OpenTibia.GameData.Plugins.Spells.ConjureRuneSpellPlugin" },
		{ words = "adevo mas pox", name = "Poison Bomb Rune", group = "Support", cooldown = 2, groupcooldown = 2, level = 25, mana = 520, soul = 2, conjureopentibiaid = 2286, conjurecount = 2, premium = true, vocations = { vocation.druid, vocation.elderdruid }, requirestarget = false, filename = "OpenTibia.GameData.Plugins.Spells.ConjureRuneSpellPlugin" },
		{ words = "adevo mas flam", name = "Fire Bomb Rune", group = "Support", cooldown = 2, groupcooldown = 2, level = 27, mana = 600, soul = 4, conjureopentibiaid = 2305, conjurecount = 2, premium = false, vocations = { vocation.druid, vocation.sorcerer, vocation.elderdruid, vocation.mastersorcerer }, requirestarget = false, filename = "OpenTibia.GameData.Plugins.Spells.ConjureRuneSpellPlugin" },
		{ words = "adevo res flam", name = "Soulfire Rune", group = "Support", cooldown = 2, groupcooldown = 2, level = 27, mana = 420, soul = 3, conjureopentibiaid = 2308, conjurecount = 3, premium = true, vocations = { vocation.druid, vocation.sorcerer, vocation.elderdruid, vocation.mastersorcerer }, requirestarget = false, filename = "OpenTibia.GameData.Plugins.Spells.ConjureRuneSpellPlugin" },
		{ words = "adevo mas grav pox", name = "Poison Wall Rune", group = "Support", cooldown = 2, groupcooldown = 2, level = 29, mana = 640, soul = 3, conjureopentibiaid = 2289, conjurecount = 4, premium = false, vocations = { vocation.druid, vocation.sorcerer, vocation.elderdruid, vocation.mastersorcerer }, requirestarget = false, filename = "OpenTibia.GameData.Plugins.Spells.ConjureRuneSpellPlugin" },
		{ words = "adevo mas hur", name = "Explosion", group = "Support", cooldown = 2, groupcooldown = 2, level = 31, mana = 570, soul = 4, conjureopentibiaid = 2313, conjurecount = 6, premium = false, vocations = { vocation.druid, vocation.sorcerer, vocation.elderdruid, vocation.mastersorcerer }, requirestarget = false, filename = "OpenTibia.GameData.Plugins.Spells.ConjureRuneSpellPlugin" },
		{ words = "adevo mas grav flam", name = "Fire Wall Rune", group = "Support", cooldown = 2, groupcooldown = 2, level = 33, mana = 780, soul = 4, conjureopentibiaid = 2303, conjurecount = 4, premium = false, vocations = { vocation.druid, vocation.sorcerer, vocation.elderdruid, vocation.mastersorcerer }, requirestarget = false, filename = "OpenTibia.GameData.Plugins.Spells.ConjureRuneSpellPlugin" },
		{ words = "adevo mas vis", name = "Energy Bomb Rune", group = "Support", cooldown = 2, groupcooldown = 2, level = 37, mana = 880, soul = 5, conjureopentibiaid = 2262, conjurecount = 2, premium = true, vocations = { vocation.sorcerer, vocation.mastersorcerer }, requirestarget = false, filename = "OpenTibia.GameData.Plugins.Spells.ConjureRuneSpellPlugin" },
		{ words = "adevo mas grav vis", name = "Energy Wall Rune", group = "Support", cooldown = 2, groupcooldown = 2, level = 41, mana = 1000, soul = 5, conjureopentibiaid = 2279, conjurecount = 4, premium = false, vocations = { vocation.druid, vocation.sorcerer, vocation.elderdruid, vocation.mastersorcerer }, requirestarget = false, filename = "OpenTibia.GameData.Plugins.Spells.ConjureRuneSpellPlugin" },
		{ words = "adori gran mort", name = "Sudden Death Rune", group = "Support", cooldown = 2, groupcooldown = 2, level = 45, mana = 985, soul = 5, conjureopentibiaid = 2268, conjurecount = 3, premium = false, vocations = { vocation.sorcerer, vocation.mastersorcerer }, requirestarget = false, filename = "OpenTibia.GameData.Plugins.Spells.ConjureRuneSpellPlugin" },
		{ words = "adana pox", name = "Cure Poison Rune", group = "Support", cooldown = 2, groupcooldown = 2, level = 15, mana = 200, soul = 1, conjureopentibiaid = 2266, conjurecount = 1, premium = false, vocations = { vocation.druid, vocation.elderdruid }, requirestarget = false, filename = "OpenTibia.GameData.Plugins.Spells.ConjureRuneSpellPlugin" },
		{ words = "adura gran", name = "Intense Healing Rune", group = "Support", cooldown = 2, groupcooldown = 2, level = 15, mana = 120, soul = 2, conjureopentibiaid = 2265, conjurecount = 1, premium = false, vocations = { vocation.druid, vocation.elderdruid }, requirestarget = false, filename = "OpenTibia.GameData.Plugins.Spells.ConjureRuneSpellPlugin" },
		{ words = "adura vita", name = "Ultimate Healing Rune", group = "Support", cooldown = 2, groupcooldown = 2, level = 24, mana = 400, soul = 3, conjureopentibiaid = 2273, conjurecount = 1, premium = false, vocations = { vocation.druid, vocation.elderdruid }, requirestarget = false, filename = "OpenTibia.GameData.Plugins.Spells.ConjureRuneSpellPlugin" },
		{ words = "adeta sio", name = "Convince Creature Rune", group = "Support", cooldown = 2, groupcooldown = 2, level = 16, mana = 200, soul = 3, conjureopentibiaid = 2290, conjurecount = 1, premium = false, vocations = { vocation.druid, vocation.elderdruid }, requirestarget = false, filename = "OpenTibia.GameData.Plugins.Spells.ConjureRuneSpellPlugin" },
		{ words = "adana mort", name = "Animate Dead Rune", group = "Support", cooldown = 2, groupcooldown = 2, level = 27, mana = 600, soul = 5, conjureopentibiaid = 2316, conjurecount = 1, premium = false, vocations = { vocation.druid, vocation.sorcerer, vocation.elderdruid, vocation.mastersorcerer }, requirestarget = false, filename = "OpenTibia.GameData.Plugins.Spells.ConjureRuneSpellPlugin" },
		{ words = "adevo ina", name = "Chameleon Rune", group = "Support", cooldown = 2, groupcooldown = 2, level = 27, mana = 600, soul = 2, conjureopentibiaid = 2291, conjurecount = 1, premium = false, vocations = { vocation.druid, vocation.sorcerer, vocation.elderdruid, vocation.mastersorcerer }, requirestarget = false, filename = "OpenTibia.GameData.Plugins.Spells.ConjureRuneSpellPlugin" },
		{ words = "adito grav", name = "Destroy Field Rune", group = "Support", cooldown = 2, groupcooldown = 2, level = 17, mana = 120, soul = 2, conjureopentibiaid = 2261, conjurecount = 3, premium = false, vocations = { vocation.paladin, vocation.druid, vocation.sorcerer, vocation.royalpaladin, vocation.elderdruid, vocation.mastersorcerer }, requirestarget = false, filename = "OpenTibia.GameData.Plugins.Spells.ConjureRuneSpellPlugin" },
		{ words = "adito tera", name = "Disintegrate Rune", group = "Support", cooldown = 2, groupcooldown = 2, level = 21, mana = 200, soul = 3, conjureopentibiaid = 2310, conjurecount = 3, premium = true, vocations = { vocation.paladin, vocation.druid, vocation.sorcerer, vocation.royalpaladin, vocation.elderdruid, vocation.mastersorcerer }, requirestarget = false, filename = "OpenTibia.GameData.Plugins.Spells.ConjureRuneSpellPlugin" },
		{ words = "adevo grav tera", name = "Magic Wall Rune", group = "Support", cooldown = 2, groupcooldown = 2, level = 32, mana = 750, soul = 5, conjureopentibiaid = 2293, conjurecount = 3, premium = true, vocations = { vocation.sorcerer, vocation.mastersorcerer }, requirestarget = false, filename = "OpenTibia.GameData.Plugins.Spells.ConjureRuneSpellPlugin" },		
		{ words = "adevo grav vita", name = "Wild Growth Rune", group = "Support", cooldown = 2, groupcooldown = 2, level = 27, mana = 600, soul = 5, conjureopentibiaid = 2269, conjurecount = 2, premium = true, vocations = { vocation.druid, vocation.elderdruid }, requirestarget = false, filename = "OpenTibia.GameData.Plugins.Spells.ConjureRuneSpellPlugin" },
		{ words = "adana ani", name = "Paralyse Rune", group = "Support", cooldown = 2, groupcooldown = 2, level = 54, mana = 1400, soul = 3, conjureopentibiaid = 2278, conjurecount = 1, premium = true, vocations = { vocation.druid, vocation.elderdruid }, requirestarget = false, filename = "OpenTibia.GameData.Plugins.Spells.ConjureRuneSpellPlugin" },
		{ words = "adori frigo", name = "Icicle Rune", group = "Support", cooldown = 2, groupcooldown = 2, level = 28, mana = 460, soul = 3, conjureopentibiaid = 2271, conjurecount = 5, premium = true, vocations = { vocation.druid, vocation.elderdruid }, requirestarget = false, filename = "OpenTibia.GameData.Plugins.Spells.ConjureRuneSpellPlugin" },
		{ words = "adori mas frigo", name = "Avalanche Rune", group = "Support", cooldown = 2, groupcooldown = 2, level = 30, mana = 530, soul = 3, conjureopentibiaid = 2274, conjurecount = 4, premium = false, vocations = { vocation.druid, vocation.elderdruid }, requirestarget = false, filename = "OpenTibia.GameData.Plugins.Spells.ConjureRuneSpellPlugin" },
		{ words = "adori mas tera", name = "Stone Shower Rune", group = "Support", cooldown = 2, groupcooldown = 2, level = 28, mana = 430, soul = 3, conjureopentibiaid = 2288, conjurecount = 4, premium = true, vocations = { vocation.druid, vocation.elderdruid }, requirestarget = false, filename = "OpenTibia.GameData.Plugins.Spells.ConjureRuneSpellPlugin" },
		{ words = "adori mas vis", name = "Thunderstorm Rune", group = "Support", cooldown = 2, groupcooldown = 2, level = 28, mana = 430, soul = 3, conjureopentibiaid = 2315, conjurecount = 4, premium = true, vocations = { vocation.sorcerer, vocation.mastersorcerer }, requirestarget = false, filename = "OpenTibia.GameData.Plugins.Spells.ConjureRuneSpellPlugin" },
		{ words = "adori san", name = "Holy Missile Rune", group = "Support", cooldown = 2, groupcooldown = 2, level = 27, mana = 300, soul = 3, conjureopentibiaid = 2295, conjurecount = 5, premium = true, vocations = { vocation.paladin, vocation.royalpaladin }, requirestarget = false, filename = "OpenTibia.GameData.Plugins.Spells.ConjureRuneSpellPlugin" }
	},
	runes = {
		{ opentibiaid = 2266, name = "Cure Poison Rune", group = "Healing", groupcooldown = 2, level = 15, magiclevel = 0, requirestarget = true, filename = "OpenTibia.GameData.Plugins.Runes.CurePoisonRunePlugin" },
		{ opentibiaid = 2265, name = "Intense Healing Rune", group = "Healing", groupcooldown = 2, level = 15, magiclevel = 1, requirestarget = true, filename = "OpenTibia.GameData.Plugins.Runes.IntenseHealingRunePlugin" },
		{ opentibiaid = 2273, name = "Ultimate Healing Rune", group = "Healing", groupcooldown = 2, level = 24, magiclevel = 4, requirestarget = true, filename = "OpenTibia.GameData.Plugins.Runes.UltimateHealingRunePlugin" },

		{ opentibiaid = 2287, name = "Light Magic Missile Rune", group = "Attack", groupcooldown = 2, level = 15, magiclevel = 0, requirestarget = true, filename = "OpenTibia.GameData.Plugins.Runes.LightMagicMissileRunePlugin" },
		{ opentibiaid = 2311, name = "Heavy Magic Missile Rune", group = "Attack", groupcooldown = 2, level = 25, magiclevel = 3, requirestarget = true, filename = "OpenTibia.GameData.Plugins.Runes.HeavyMagicMissileRunePlugin" },
		{ opentibiaid = 2292, name = "Stalagmite Rune", group = "Attack", groupcooldown = 2, level = 24, magiclevel = 3, requirestarget = true, filename = "OpenTibia.GameData.Plugins.Runes.StalagmiteRunePlugin" },
		{ opentibiaid = 2271, name = "Icicle Rune", group = "Attack", groupcooldown = 2, level = 28, magiclevel = 4, requirestarget = true, filename = "OpenTibia.GameData.Plugins.Runes.IcicleRunePlugin" },
		{ opentibiaid = 2268, name = "Sudden Death Rune", group = "Attack", groupcooldown = 2, level = 45, magiclevel = 15, requirestarget = true, filename = "OpenTibia.GameData.Plugins.Runes.SuddenDeathRunePlugin" },

		{ opentibiaid = 2285, name = "Poison Field Rune", group = "Attack", groupcooldown = 2, level = 14, magiclevel = 0, requirestarget = false, filename = "OpenTibia.GameData.Plugins.Runes.PoisonFieldRunePlugin" },
		{ opentibiaid = 2286, name = "Poison Bomb Rune", group = "Attack", groupcooldown = 2, level = 25, magiclevel = 4, requirestarget = false, filename = "OpenTibia.GameData.Plugins.Runes.PoisonBombRunePlugin" },
		{ opentibiaid = 2289, name = "Poison Wall Rune", group = "Attack", groupcooldown = 2, level = 29, magiclevel = 5, requirestarget = false, filename = "OpenTibia.GameData.Plugins.Runes.PoisonWallRunePlugin" },
		{ opentibiaid = 2301, name = "Fire Field Rune", group = "Attack", groupcooldown = 2, level = 15, magiclevel = 1, requirestarget = false, filename = "OpenTibia.GameData.Plugins.Runes.FireFieldRunePlugin" },
		{ opentibiaid = 2305, name = "Fire Bomb Rune", group = "Attack", groupcooldown = 2, level = 27, magiclevel = 5, requirestarget = false, filename = "OpenTibia.GameData.Plugins.Runes.FireBombRunePlugin" },
		{ opentibiaid = 2303, name = "Fire Wall Rune", group = "Attack", groupcooldown = 2, level = 33, magiclevel = 6, requirestarget = false, filename = "OpenTibia.GameData.Plugins.Runes.FireWallRunePlugin" },
		{ opentibiaid = 2277, name = "Energy Field Rune", group = "Attack", groupcooldown = 2, level = 18, magiclevel = 3, requirestarget = false, filename = "OpenTibia.GameData.Plugins.Runes.EnergyFieldRunePlugin" },
		{ opentibiaid = 2262, name = "Energy Bomb Rune", group = "Attack", groupcooldown = 2, level = 37, magiclevel = 10, requirestarget = false, filename = "OpenTibia.GameData.Plugins.Runes.EnergyBombRunePlugin" },
		{ opentibiaid = 2279, name = "Energy Wall Rune", group = "Attack", groupcooldown = 2, level = 41, magiclevel = 9, requirestarget = false, filename = "OpenTibia.GameData.Plugins.Runes.EnergyWallRunePlugin" },
		{ opentibiaid = 2302, name = "Fireball Rune", group = "Attack", groupcooldown = 2, level = 27, magiclevel = 4, requirestarget = false, filename = "OpenTibia.GameData.Plugins.Runes.FireballRunePlugin" },
		{ opentibiaid = 2304, name = "Great Fireball Rune", group = "Attack", groupcooldown = 2, level = 30, magiclevel = 4, requirestarget = false, filename = "great fireball rune.lua" },
		{ opentibiaid = 2274, name = "Avalanche Rune", group = "Attack", groupcooldown = 2, level = 30, magiclevel = 4, requirestarget = false, filename = "OpenTibia.GameData.Plugins.Runes.AvalancheRunePlugin" },
		{ opentibiaid = 2315, name = "Thunderstorm Rune", group = "Attack", groupcooldown = 2, level = 28, magiclevel = 4, requirestarget = false, filename = "OpenTibia.GameData.Plugins.Runes.ThunderstormRunePlugin" },
		{ opentibiaid = 2288, name = "Stone Shower Rune", group = "Attack", groupcooldown = 2, level = 28, magiclevel = 4, requirestarget = false, filename = "OpenTibia.GameData.Plugins.Runes.StoneShowerRunePlugin" },
		{ opentibiaid = 2313, name = "Explosion Rune", group = "Attack", groupcooldown = 2, level = 31, magiclevel = 6, requirestarget = false, filename = "OpenTibia.GameData.Plugins.Runes.ExplosionRunePlugin" },
		{ opentibiaid = 2293, name = "Magic Wall Rune", group = "Support", groupcooldown = 2, level = 27, magiclevel = 9, requirestarget = false, filename = "OpenTibia.GameData.Plugins.Runes.MagicWallRunePlugin" },
		{ opentibiaid = 2269, name = "Wild Growth Rune", group = "Support", groupcooldown = 2, level = 27, magiclevel = 8, requirestarget = false, filename = "OpenTibia.GameData.Plugins.Runes.WildGrowthRunePlugin" }
	},
	weapons = {
		{ opentibiaid = 2187, level = 33, mana = 13, vocations = { vocation.sorcerer, vocation.mastersorcerer }, filename = "wand of inferno.lua" },		
		{ opentibiaid = 2188, level = 19, mana = 5, vocations = { vocation.sorcerer, vocation.mastersorcerer }, filename = "OpenTibia.GameData.Plugins.Weapons.WandOfPlagueWeaponPlugin" },
		{ opentibiaid = 2189, level = 26, mana = 8, vocations = { vocation.sorcerer, vocation.mastersorcerer }, filename = "OpenTibia.GameData.Plugins.Weapons.WandOfCosmicEnergyWeaponPlugin" },
		{ opentibiaid = 2190, level = 7, mana = 2, vocations = { vocation.sorcerer, vocation.mastersorcerer }, filename = "OpenTibia.GameData.Plugins.Weapons.WandOfVortexWeaponPlugin" },
		{ opentibiaid = 2191, level = 13, mana = 3, vocations = { vocation.sorcerer, vocation.mastersorcerer }, filename = "OpenTibia.GameData.Plugins.Weapons.WandOfDragonbreathWeaponPlugin" },
		{ opentibiaid = 2181, level = 26, mana = 8, vocations = { vocation.druid, vocation.elderdruid }, filename = "OpenTibia.GameData.Plugins.Weapons.QuagmireRodWeaponPlugin" },
		{ opentibiaid = 2182, level = 6, mana = 2, vocations = { vocation.druid, vocation.elderdruid }, filename = "OpenTibia.GameData.Plugins.Weapons.SnakebiteRodWeaponPlugin" },
		{ opentibiaid = 2183, level = 33, mana = 13, vocations = { vocation.druid, vocation.elderdruid }, filename = "OpenTibia.GameData.Plugins.Weapons.TempestRodWeaponPlugin" },
		{ opentibiaid = 2185, level = 19, mana = 5, vocations = { vocation.druid, vocation.elderdruid }, filename = "OpenTibia.GameData.Plugins.Weapons.VolcanicRodWeaponPlugin" },
		{ opentibiaid = 2186, level = 13, mana = 3, vocations = { vocation.druid, vocation.elderdruid }, filename = "OpenTibia.GameData.Plugins.Weapons.MoonlightRodWeaponPlugin" },
		{ opentibiaid = 7366, level = 0, mana = 0, vocations = { vocation.knight, vocation.paladin, vocation.druid, vocation.sorcerer, vocation.eliteknight, vocation.royalpaladin, vocation.elderdruid, vocation.mastersorcerer }, filename = "OpenTibia.GameData.Plugins.Weapons.ViperStarWeaponPlugin" }		
	},
	ammunitions = {
		{ opentibiaid = 2545, filename = "OpenTibia.GameData.Plugins.Ammunitions.PoisonArrowAmmunitionPlugin" },
		{ opentibiaid = 2546, filename = "burst arrow.lua" }
	}
}