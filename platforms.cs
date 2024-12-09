namespace naviy10.Mods {
  public class Movement {
    public leftplat = null;
    
    public static void CreatePlatform() {
        GameObject platform = GameObject.CreatePrimitive(PrimitiveType.Cube);
        platform.transform.localScale = new Vector3(0.025f, 0.15f, 0.2f);
        platform.GetComponent<Renderer>().material.color = Color.blue;

        return platform;
    }
    
    public static void Platforms() {
      //todo
    }
  }
}
