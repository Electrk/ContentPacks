singleton TSShapeConstructor(PlayerAnim_Lurker_Swim_RootDAE)
{
   baseShape = "./PlayerAnim_Lurker_Swim_Root.dae";
   neverImport = "EnvironmentAmbientLight";
   loadLights = "0";
};

function PlayerAnim_Lurker_Swim_RootDAE::onLoad(%this)
{
   %this.setSequenceCyclic("ambient", "true");
   %this.addSequence("ambient", "Swim_Root", "1400", "1459");
}