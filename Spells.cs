--//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////--
 
        private static Menu Menu; // Main Menu
        private static Menu SubMenu; // Sub Menu

        private static  Spell.Targeted Q = new Spell.Targeted(SpellSlot.Q, 625);
        private static Spell.Skillshot W = new Spell.Skillshot(SpellSlot.W, 625, SkillShotType.Cone, 250, int.MaxValue, 210);
        private static Spell.Active E = new Spell.Active(SpellSlot.E);
        private static Spell.Skillshot R = new Spell.Skillshot(SpellSlot.R, 600, SkillShotType.Circular, 20, int.MaxValue, 250);
        private static Spell.Targeted Ignite = null;
--//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////--


--// Key            SubMenu.Add("keybind", new KeyBind("Keybind", false, KeyBind.BindTypes.PressToggle, 'W')); // Here false is the default value
--// CheckBox             SubMenu.Add("checkbox", new CheckBox("CheckBox", false)); // Add(displayName, new CheckBox(inGameName, default value);


--//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////--
