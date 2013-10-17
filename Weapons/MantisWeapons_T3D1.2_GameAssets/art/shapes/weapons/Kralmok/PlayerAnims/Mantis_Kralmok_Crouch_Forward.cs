singleton TSShapeConstructor(Mantis_Kralmok_Crouch_ForwardDAE)
{
   baseShape = "./Mantis_Kralmok_Crouch_Forward.dae";
   neverImport = "EnvironmentAmbientLight";
   loadLights = "0";
};

function Mantis_Kralmok_Crouch_ForwardDAE::onLoad(%this)
{
   %this.setSequenceCyclic("ambient", "true");
   %this.addSequence("ambient", "Crouch_Forward", "680", "709", true, true);
}